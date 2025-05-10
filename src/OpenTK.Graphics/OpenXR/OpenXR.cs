// This file is auto generated, do not edit.
using OpenTK.Mathematics;
using OpenTK.Graphics.Vulkan;
using System;
using System.Runtime.CompilerServices;

namespace OpenTK.Graphics.OpenXR
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static unsafe partial class Xr
    {
        /// <summary><b>[requires: XR_META_environment_depth]</b> </summary>
        public static XrResult AcquireEnvironmentDepthImageMETA(XrEnvironmentDepthProviderMETA environmentDepthProvider, XrEnvironmentDepthImageAcquireInfoMETA* acquireInfo, XrEnvironmentDepthImageMETA* environmentDepthImage)
        {
            return XrPointers._xrAcquireEnvironmentDepthImageMETA_fnptr(environmentDepthProvider, acquireInfo, environmentDepthImage);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult AcquireSwapchainImage(XrSwapchain swapchain, XrSwapchainImageAcquireInfo* acquireInfo, uint* index)
        {
            return XrPointers._xrAcquireSwapchainImage_fnptr(swapchain, acquireInfo, index);
        }
        /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> </summary>
        public static XrResult AllocateWorldMeshBufferML(XrWorldMeshDetectorML detector, XrWorldMeshBufferSizeML* size, XrWorldMeshBufferML* buffer)
        {
            return XrPointers._xrAllocateWorldMeshBufferML_fnptr(detector, size, buffer);
        }
        /// <summary><b>[requires: XR_MNDX_force_feedback_curl]</b> </summary>
        public static XrResult ApplyForceFeedbackCurlMNDX(XrHandTrackerEXT handTracker, XrForceFeedbackCurlApplyLocationsMNDX* locations)
        {
            return XrPointers._xrApplyForceFeedbackCurlMNDX_fnptr(handTracker, locations);
        }
        /// <summary><b>[requires: XR_HTC_foveation]</b> </summary>
        public static XrResult ApplyFoveationHTC(XrSession session, XrFoveationApplyInfoHTC* applyInfo)
        {
            return XrPointers._xrApplyFoveationHTC_fnptr(session, applyInfo);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult ApplyHapticFeedback(XrSession session, XrHapticActionInfo* hapticActionInfo, XrHapticBaseHeader* hapticFeedback)
        {
            return XrPointers._xrApplyHapticFeedback_fnptr(session, hapticActionInfo, hapticFeedback);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult AttachSessionActionSets(XrSession session, XrSessionActionSetsAttachInfo* attachInfo)
        {
            return XrPointers._xrAttachSessionActionSets_fnptr(session, attachInfo);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult BeginFrame(XrSession session, XrFrameBeginInfo* frameBeginInfo)
        {
            return XrPointers._xrBeginFrame_fnptr(session, frameBeginInfo);
        }
        /// <summary><b>[requires: XR_EXT_plane_detection]</b> </summary>
        public static XrResult BeginPlaneDetectionEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorBeginInfoEXT* beginInfo)
        {
            return XrPointers._xrBeginPlaneDetectionEXT_fnptr(planeDetector, beginInfo);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult BeginSession(XrSession session, XrSessionBeginInfo* beginInfo)
        {
            return XrPointers._xrBeginSession_fnptr(session, beginInfo);
        }
        /// <summary><b>[requires: XR_EXT_future]</b> </summary>
        public static XrResult CancelFutureEXT(XrInstance instance, XrFutureCancelInfoEXT* cancelInfo)
        {
            return XrPointers._xrCancelFutureEXT_fnptr(instance, cancelInfo);
        }
        /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
        public static XrResult ChangeVirtualKeyboardTextContextMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardTextContextChangeInfoMETA* changeInfo)
        {
            return XrPointers._xrChangeVirtualKeyboardTextContextMETA_fnptr(keyboard, changeInfo);
        }
        /// <summary><b>[requires: XR_MSFT_spatial_anchor_persistence]</b> </summary>
        public static XrResult ClearSpatialAnchorStoreMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore)
        {
            return XrPointers._xrClearSpatialAnchorStoreMSFT_fnptr(spatialAnchorStore);
        }
        /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
        public static XrResult ComputeNewSceneMSFT(XrSceneObserverMSFT sceneObserver, XrNewSceneComputeInfoMSFT* computeInfo)
        {
            return XrPointers._xrComputeNewSceneMSFT_fnptr(sceneObserver, computeInfo);
        }
        /// <summary><b>[requires: XR_KHR_convert_timespec_time]</b> </summary>
        public static XrResult ConvertTimespecTimeToTimeKHR(XrInstance instance, void* timespecTime, long* time)
        {
            return XrPointers._xrConvertTimespecTimeToTimeKHR_fnptr(instance, timespecTime, time);
        }
        /// <summary><b>[requires: XR_KHR_convert_timespec_time]</b> </summary>
        public static XrResult ConvertTimeToTimespecTimeKHR(XrInstance instance, long time, void* timespecTime)
        {
            return XrPointers._xrConvertTimeToTimespecTimeKHR_fnptr(instance, time, timespecTime);
        }
        /// <summary><b>[requires: XR_KHR_win32_convert_performance_counter_time]</b> </summary>
        public static XrResult ConvertTimeToWin32PerformanceCounterKHR(XrInstance instance, long time, long* performanceCounter)
        {
            return XrPointers._xrConvertTimeToWin32PerformanceCounterKHR_fnptr(instance, time, performanceCounter);
        }
        /// <summary><b>[requires: XR_KHR_win32_convert_performance_counter_time]</b> </summary>
        public static XrResult ConvertWin32PerformanceCounterToTimeKHR(XrInstance instance, long* performanceCounter, long* time)
        {
            return XrPointers._xrConvertWin32PerformanceCounterToTimeKHR_fnptr(instance, performanceCounter, time);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult CreateAction(XrActionSet actionSet, XrActionCreateInfo* createInfo, XrAction* action)
        {
            return XrPointers._xrCreateAction_fnptr(actionSet, createInfo, action);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult CreateActionSet(XrInstance instance, XrActionSetCreateInfo* createInfo, XrActionSet* actionSet)
        {
            return XrPointers._xrCreateActionSet_fnptr(instance, createInfo, actionSet);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult CreateActionSpace(XrSession session, XrActionSpaceCreateInfo* createInfo, XrSpace* space)
        {
            return XrPointers._xrCreateActionSpace_fnptr(session, createInfo, space);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult CreateApiLayerInstance(XrInstanceCreateInfo* info, XrApiLayerCreateInfo* layerInfo, XrInstance* instance)
        {
            return XrPointers._xrCreateApiLayerInstance_fnptr(info, layerInfo, instance);
        }
        /// <summary><b>[requires: XR_BD_body_tracking]</b> </summary>
        public static XrResult CreateBodyTrackerBD(XrSession session, XrBodyTrackerCreateInfoBD* createInfo, XrBodyTrackerBD* bodyTracker)
        {
            return XrPointers._xrCreateBodyTrackerBD_fnptr(session, createInfo, bodyTracker);
        }
        /// <summary><b>[requires: XR_FB_body_tracking]</b> </summary>
        public static XrResult CreateBodyTrackerFB(XrSession session, XrBodyTrackerCreateInfoFB* createInfo, XrBodyTrackerFB* bodyTracker)
        {
            return XrPointers._xrCreateBodyTrackerFB_fnptr(session, createInfo, bodyTracker);
        }
        /// <summary><b>[requires: XR_HTC_body_tracking]</b> </summary>
        public static XrResult CreateBodyTrackerHTC(XrSession session, XrBodyTrackerCreateInfoHTC* createInfo, XrBodyTrackerHTC* bodyTracker)
        {
            return XrPointers._xrCreateBodyTrackerHTC_fnptr(session, createInfo, bodyTracker);
        }
        /// <summary><b>[requires: XR_EXT_debug_utils]</b> </summary>
        public static XrResult CreateDebugUtilsMessengerEXT(XrInstance instance, XrDebugUtilsMessengerCreateInfoEXT* createInfo, XrDebugUtilsMessengerEXT* messenger)
        {
            return XrPointers._xrCreateDebugUtilsMessengerEXT_fnptr(instance, createInfo, messenger);
        }
        /// <summary><b>[requires: XR_META_environment_depth]</b> </summary>
        public static XrResult CreateEnvironmentDepthProviderMETA(XrSession session, XrEnvironmentDepthProviderCreateInfoMETA* createInfo, XrEnvironmentDepthProviderMETA* environmentDepthProvider)
        {
            return XrPointers._xrCreateEnvironmentDepthProviderMETA_fnptr(session, createInfo, environmentDepthProvider);
        }
        /// <summary><b>[requires: XR_META_environment_depth]</b> </summary>
        public static XrResult CreateEnvironmentDepthSwapchainMETA(XrEnvironmentDepthProviderMETA environmentDepthProvider, XrEnvironmentDepthSwapchainCreateInfoMETA* createInfo, XrEnvironmentDepthSwapchainMETA* swapchain)
        {
            return XrPointers._xrCreateEnvironmentDepthSwapchainMETA_fnptr(environmentDepthProvider, createInfo, swapchain);
        }
        /// <summary><b>[requires: XR_ML_localization_map]</b> </summary>
        public static XrResult CreateExportedLocalizationMapML(XrSession session, XrUuid* mapUuid, XrExportedLocalizationMapML* map)
        {
            return XrPointers._xrCreateExportedLocalizationMapML_fnptr(session, mapUuid, map);
        }
        /// <summary><b>[requires: XR_FB_eye_tracking_social]</b> </summary>
        public static XrResult CreateEyeTrackerFB(XrSession session, XrEyeTrackerCreateInfoFB* createInfo, XrEyeTrackerFB* eyeTracker)
        {
            return XrPointers._xrCreateEyeTrackerFB_fnptr(session, createInfo, eyeTracker);
        }
        /// <summary><b>[requires: XR_FB_face_tracking2]</b> </summary>
        public static XrResult CreateFaceTracker2FB(XrSession session, XrFaceTrackerCreateInfo2FB* createInfo, XrFaceTracker2FB* faceTracker)
        {
            return XrPointers._xrCreateFaceTracker2FB_fnptr(session, createInfo, faceTracker);
        }
        /// <summary><b>[requires: XR_FB_face_tracking]</b> </summary>
        public static XrResult CreateFaceTrackerFB(XrSession session, XrFaceTrackerCreateInfoFB* createInfo, XrFaceTrackerFB* faceTracker)
        {
            return XrPointers._xrCreateFaceTrackerFB_fnptr(session, createInfo, faceTracker);
        }
        /// <summary><b>[requires: XR_ML_facial_expression]</b> </summary>
        public static XrResult CreateFacialExpressionClientML(XrSession session, XrFacialExpressionClientCreateInfoML* createInfo, XrFacialExpressionClientML* facialExpressionClient)
        {
            return XrPointers._xrCreateFacialExpressionClientML_fnptr(session, createInfo, facialExpressionClient);
        }
        /// <summary><b>[requires: XR_HTC_facial_tracking]</b> </summary>
        public static XrResult CreateFacialTrackerHTC(XrSession session, XrFacialTrackerCreateInfoHTC* createInfo, XrFacialTrackerHTC* facialTracker)
        {
            return XrPointers._xrCreateFacialTrackerHTC_fnptr(session, createInfo, facialTracker);
        }
        /// <summary><b>[requires: XR_FB_foveation]</b> </summary>
        public static XrResult CreateFoveationProfileFB(XrSession session, XrFoveationProfileCreateInfoFB* createInfo, XrFoveationProfileFB* profile)
        {
            return XrPointers._xrCreateFoveationProfileFB_fnptr(session, createInfo, profile);
        }
        /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
        public static XrResult CreateGeometryInstanceFB(XrSession session, XrGeometryInstanceCreateInfoFB* createInfo, XrGeometryInstanceFB* outGeometryInstance)
        {
            return XrPointers._xrCreateGeometryInstanceFB_fnptr(session, createInfo, outGeometryInstance);
        }
        /// <summary><b>[requires: XR_MSFT_hand_tracking_mesh]</b> </summary>
        public static XrResult CreateHandMeshSpaceMSFT(XrHandTrackerEXT handTracker, XrHandMeshSpaceCreateInfoMSFT* createInfo, XrSpace* space)
        {
            return XrPointers._xrCreateHandMeshSpaceMSFT_fnptr(handTracker, createInfo, space);
        }
        /// <summary><b>[requires: XR_EXT_hand_tracking]</b> </summary>
        public static XrResult CreateHandTrackerEXT(XrSession session, XrHandTrackerCreateInfoEXT* createInfo, XrHandTrackerEXT* handTracker)
        {
            return XrPointers._xrCreateHandTrackerEXT_fnptr(session, createInfo, handTracker);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult CreateInstance(XrInstanceCreateInfo* createInfo, XrInstance* instance)
        {
            return XrPointers._xrCreateInstance_fnptr(createInfo, instance);
        }
        /// <summary><b>[requires: XR_FB_keyboard_tracking]</b> </summary>
        public static XrResult CreateKeyboardSpaceFB(XrSession session, XrKeyboardSpaceCreateInfoFB* createInfo, XrSpace* keyboardSpace)
        {
            return XrPointers._xrCreateKeyboardSpaceFB_fnptr(session, createInfo, keyboardSpace);
        }
        /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
        public static XrResult CreateMarkerDetectorML(XrSession session, XrMarkerDetectorCreateInfoML* createInfo, XrMarkerDetectorML* markerDetector)
        {
            return XrPointers._xrCreateMarkerDetectorML_fnptr(session, createInfo, markerDetector);
        }
        /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
        public static XrResult CreateMarkerSpaceML(XrSession session, XrMarkerSpaceCreateInfoML* createInfo, XrSpace* space)
        {
            return XrPointers._xrCreateMarkerSpaceML_fnptr(session, createInfo, space);
        }
        /// <summary><b>[requires: XR_VARJO_marker_tracking]</b> </summary>
        public static XrResult CreateMarkerSpaceVARJO(XrSession session, XrMarkerSpaceCreateInfoVARJO* createInfo, XrSpace* space)
        {
            return XrPointers._xrCreateMarkerSpaceVARJO_fnptr(session, createInfo, space);
        }
        /// <summary><b>[requires: XR_META_passthrough_color_lut]</b> </summary>
        public static XrResult CreatePassthroughColorLutMETA(XrPassthroughFB passthrough, XrPassthroughColorLutCreateInfoMETA* createInfo, XrPassthroughColorLutMETA* colorLut)
        {
            return XrPointers._xrCreatePassthroughColorLutMETA_fnptr(passthrough, createInfo, colorLut);
        }
        /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
        public static XrResult CreatePassthroughFB(XrSession session, XrPassthroughCreateInfoFB* createInfo, XrPassthroughFB* outPassthrough)
        {
            return XrPointers._xrCreatePassthroughFB_fnptr(session, createInfo, outPassthrough);
        }
        /// <summary><b>[requires: XR_HTC_passthrough]</b> </summary>
        public static XrResult CreatePassthroughHTC(XrSession session, XrPassthroughCreateInfoHTC* createInfo, XrPassthroughHTC* passthrough)
        {
            return XrPointers._xrCreatePassthroughHTC_fnptr(session, createInfo, passthrough);
        }
        /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
        public static XrResult CreatePassthroughLayerFB(XrSession session, XrPassthroughLayerCreateInfoFB* createInfo, XrPassthroughLayerFB* outLayer)
        {
            return XrPointers._xrCreatePassthroughLayerFB_fnptr(session, createInfo, outLayer);
        }
        /// <summary><b>[requires: XR_EXT_plane_detection]</b> </summary>
        public static XrResult CreatePlaneDetectorEXT(XrSession session, XrPlaneDetectorCreateInfoEXT* createInfo, XrPlaneDetectorEXT* planeDetector)
        {
            return XrPointers._xrCreatePlaneDetectorEXT_fnptr(session, createInfo, planeDetector);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult CreateReferenceSpace(XrSession session, XrReferenceSpaceCreateInfo* createInfo, XrSpace* space)
        {
            return XrPointers._xrCreateReferenceSpace_fnptr(session, createInfo, space);
        }
        /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
        public static XrResult CreateSceneMSFT(XrSceneObserverMSFT sceneObserver, XrSceneCreateInfoMSFT* createInfo, XrSceneMSFT* scene)
        {
            return XrPointers._xrCreateSceneMSFT_fnptr(sceneObserver, createInfo, scene);
        }
        /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
        public static XrResult CreateSceneObserverMSFT(XrSession session, XrSceneObserverCreateInfoMSFT* createInfo, XrSceneObserverMSFT* sceneObserver)
        {
            return XrPointers._xrCreateSceneObserverMSFT_fnptr(session, createInfo, sceneObserver);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult CreateSession(XrInstance instance, XrSessionCreateInfo* createInfo, XrSession* session)
        {
            return XrPointers._xrCreateSession_fnptr(instance, createInfo, session);
        }
        /// <summary><b>[requires: XR_ML_compat]</b> </summary>
        public static XrResult CreateSpaceFromCoordinateFrameUIDML(XrSession session, XrCoordinateSpaceCreateInfoML* createInfo, XrSpace* space)
        {
            return XrPointers._xrCreateSpaceFromCoordinateFrameUIDML_fnptr(session, createInfo, space);
        }
        /// <summary><b>[requires: XR_FB_spatial_entity_user]</b> </summary>
        public static XrResult CreateSpaceUserFB(XrSession session, XrSpaceUserCreateInfoFB* info, XrSpaceUserFB* user)
        {
            return XrPointers._xrCreateSpaceUserFB_fnptr(session, info, user);
        }
        /// <summary><b>[requires: XR_FB_spatial_entity]</b> </summary>
        public static XrResult CreateSpatialAnchorFB(XrSession session, XrSpatialAnchorCreateInfoFB* info, ulong* requestId)
        {
            return XrPointers._xrCreateSpatialAnchorFB_fnptr(session, info, requestId);
        }
        /// <summary><b>[requires: XR_MSFT_perception_anchor_interop]</b> </summary>
        public static XrResult CreateSpatialAnchorFromPerceptionAnchorMSFT(XrSession session, IntPtr* perceptionAnchor, XrSpatialAnchorMSFT* anchor)
        {
            return XrPointers._xrCreateSpatialAnchorFromPerceptionAnchorMSFT_fnptr(session, perceptionAnchor, anchor);
        }
        /// <summary><b>[requires: XR_MSFT_spatial_anchor_persistence]</b> </summary>
        public static XrResult CreateSpatialAnchorFromPersistedNameMSFT(XrSession session, XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT* spatialAnchorCreateInfo, XrSpatialAnchorMSFT* spatialAnchor)
        {
            return XrPointers._xrCreateSpatialAnchorFromPersistedNameMSFT_fnptr(session, spatialAnchorCreateInfo, spatialAnchor);
        }
        /// <summary><b>[requires: XR_HTC_anchor]</b> </summary>
        public static XrResult CreateSpatialAnchorHTC(XrSession session, XrSpatialAnchorCreateInfoHTC* createInfo, XrSpace* anchor)
        {
            return XrPointers._xrCreateSpatialAnchorHTC_fnptr(session, createInfo, anchor);
        }
        /// <summary><b>[requires: XR_MSFT_spatial_anchor]</b> </summary>
        public static XrResult CreateSpatialAnchorMSFT(XrSession session, XrSpatialAnchorCreateInfoMSFT* createInfo, XrSpatialAnchorMSFT* anchor)
        {
            return XrPointers._xrCreateSpatialAnchorMSFT_fnptr(session, createInfo, anchor);
        }
        /// <summary><b>[requires: XR_ML_spatial_anchors]</b> </summary>
        public static XrResult CreateSpatialAnchorsAsyncML(XrSession session, XrSpatialAnchorsCreateInfoBaseHeaderML* createInfo, ulong* future)
        {
            return XrPointers._xrCreateSpatialAnchorsAsyncML_fnptr(session, createInfo, future);
        }
        /// <summary><b>[requires: XR_ML_spatial_anchors]</b> </summary>
        public static XrResult CreateSpatialAnchorsCompleteML(XrSession session, ulong future, XrCreateSpatialAnchorsCompletionML* completion)
        {
            return XrPointers._xrCreateSpatialAnchorsCompleteML_fnptr(session, future, completion);
        }
        /// <summary><b>[requires: XR_MSFT_spatial_anchor]</b> </summary>
        public static XrResult CreateSpatialAnchorSpaceMSFT(XrSession session, XrSpatialAnchorSpaceCreateInfoMSFT* createInfo, XrSpace* space)
        {
            return XrPointers._xrCreateSpatialAnchorSpaceMSFT_fnptr(session, createInfo, space);
        }
        /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> </summary>
        public static XrResult CreateSpatialAnchorsStorageML(XrSession session, XrSpatialAnchorsCreateStorageInfoML* createInfo, XrSpatialAnchorsStorageML* storage)
        {
            return XrPointers._xrCreateSpatialAnchorsStorageML_fnptr(session, createInfo, storage);
        }
        /// <summary><b>[requires: XR_MSFT_spatial_anchor_persistence]</b> </summary>
        public static XrResult CreateSpatialAnchorStoreConnectionMSFT(XrSession session, XrSpatialAnchorStoreConnectionMSFT* spatialAnchorStore)
        {
            return XrPointers._xrCreateSpatialAnchorStoreConnectionMSFT_fnptr(session, spatialAnchorStore);
        }
        /// <summary><b>[requires: XR_MSFT_spatial_graph_bridge]</b> </summary>
        public static XrResult CreateSpatialGraphNodeSpaceMSFT(XrSession session, XrSpatialGraphNodeSpaceCreateInfoMSFT* createInfo, XrSpace* space)
        {
            return XrPointers._xrCreateSpatialGraphNodeSpaceMSFT_fnptr(session, createInfo, space);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult CreateSwapchain(XrSession session, XrSwapchainCreateInfo* createInfo, XrSwapchain* swapchain)
        {
            return XrPointers._xrCreateSwapchain_fnptr(session, createInfo, swapchain);
        }
        /// <summary><b>[requires: XR_KHR_android_surface_swapchain]</b> </summary>
        public static XrResult CreateSwapchainAndroidSurfaceKHR(XrSession session, XrSwapchainCreateInfo* info, XrSwapchain* swapchain, void* surface)
        {
            return XrPointers._xrCreateSwapchainAndroidSurfaceKHR_fnptr(session, info, swapchain, surface);
        }
        /// <summary><b>[requires: XR_FB_triangle_mesh]</b> </summary>
        public static XrResult CreateTriangleMeshFB(XrSession session, XrTriangleMeshCreateInfoFB* createInfo, XrTriangleMeshFB* outTriangleMesh)
        {
            return XrPointers._xrCreateTriangleMeshFB_fnptr(session, createInfo, outTriangleMesh);
        }
        /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
        public static XrResult CreateVirtualKeyboardMETA(XrSession session, XrVirtualKeyboardCreateInfoMETA* createInfo, XrVirtualKeyboardMETA* keyboard)
        {
            return XrPointers._xrCreateVirtualKeyboardMETA_fnptr(session, createInfo, keyboard);
        }
        /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
        public static XrResult CreateVirtualKeyboardSpaceMETA(XrSession session, XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardSpaceCreateInfoMETA* createInfo, XrSpace* keyboardSpace)
        {
            return XrPointers._xrCreateVirtualKeyboardSpaceMETA_fnptr(session, keyboard, createInfo, keyboardSpace);
        }
        /// <summary><b>[requires: XR_KHR_vulkan_enable2]</b> </summary>
        public static XrResult CreateVulkanDeviceKHR(XrInstance instance, XrVulkanDeviceCreateInfoKHR* createInfo, VkDevice* vulkanDevice, VkResult* vulkanResult)
        {
            return XrPointers._xrCreateVulkanDeviceKHR_fnptr(instance, createInfo, vulkanDevice, vulkanResult);
        }
        /// <summary><b>[requires: XR_KHR_vulkan_enable2]</b> </summary>
        public static XrResult CreateVulkanInstanceKHR(XrInstance instance, XrVulkanInstanceCreateInfoKHR* createInfo, VkInstance* vulkanInstance, VkResult* vulkanResult)
        {
            return XrPointers._xrCreateVulkanInstanceKHR_fnptr(instance, createInfo, vulkanInstance, vulkanResult);
        }
        /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> </summary>
        public static XrResult CreateWorldMeshDetectorML(XrSession session, XrWorldMeshDetectorCreateInfoML* createInfo, XrWorldMeshDetectorML* detector)
        {
            return XrPointers._xrCreateWorldMeshDetectorML_fnptr(session, createInfo, detector);
        }
        /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> </summary>
        public static XrResult DeleteSpatialAnchorsAsyncML(XrSpatialAnchorsStorageML storage, XrSpatialAnchorsDeleteInfoML* deleteInfo, ulong* future)
        {
            return XrPointers._xrDeleteSpatialAnchorsAsyncML_fnptr(storage, deleteInfo, future);
        }
        /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> </summary>
        public static XrResult DeleteSpatialAnchorsCompleteML(XrSpatialAnchorsStorageML storage, ulong future, XrSpatialAnchorsDeleteCompletionML* completion)
        {
            return XrPointers._xrDeleteSpatialAnchorsCompleteML_fnptr(storage, future, completion);
        }
        /// <summary><b>[requires: XR_MSFT_scene_understanding_serialization]</b> </summary>
        public static XrResult DeserializeSceneMSFT(XrSceneObserverMSFT sceneObserver, XrSceneDeserializeInfoMSFT* deserializeInfo)
        {
            return XrPointers._xrDeserializeSceneMSFT_fnptr(sceneObserver, deserializeInfo);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult DestroyAction(XrAction action)
        {
            return XrPointers._xrDestroyAction_fnptr(action);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult DestroyActionSet(XrActionSet actionSet)
        {
            return XrPointers._xrDestroyActionSet_fnptr(actionSet);
        }
        /// <summary><b>[requires: XR_BD_body_tracking]</b> </summary>
        public static XrResult DestroyBodyTrackerBD(XrBodyTrackerBD bodyTracker)
        {
            return XrPointers._xrDestroyBodyTrackerBD_fnptr(bodyTracker);
        }
        /// <summary><b>[requires: XR_FB_body_tracking]</b> </summary>
        public static XrResult DestroyBodyTrackerFB(XrBodyTrackerFB bodyTracker)
        {
            return XrPointers._xrDestroyBodyTrackerFB_fnptr(bodyTracker);
        }
        /// <summary><b>[requires: XR_HTC_body_tracking]</b> </summary>
        public static XrResult DestroyBodyTrackerHTC(XrBodyTrackerHTC bodyTracker)
        {
            return XrPointers._xrDestroyBodyTrackerHTC_fnptr(bodyTracker);
        }
        /// <summary><b>[requires: XR_EXT_debug_utils]</b> </summary>
        public static XrResult DestroyDebugUtilsMessengerEXT(XrDebugUtilsMessengerEXT messenger)
        {
            return XrPointers._xrDestroyDebugUtilsMessengerEXT_fnptr(messenger);
        }
        /// <summary><b>[requires: XR_META_environment_depth]</b> </summary>
        public static XrResult DestroyEnvironmentDepthProviderMETA(XrEnvironmentDepthProviderMETA environmentDepthProvider)
        {
            return XrPointers._xrDestroyEnvironmentDepthProviderMETA_fnptr(environmentDepthProvider);
        }
        /// <summary><b>[requires: XR_META_environment_depth]</b> </summary>
        public static XrResult DestroyEnvironmentDepthSwapchainMETA(XrEnvironmentDepthSwapchainMETA swapchain)
        {
            return XrPointers._xrDestroyEnvironmentDepthSwapchainMETA_fnptr(swapchain);
        }
        /// <summary><b>[requires: XR_ML_localization_map]</b> </summary>
        public static XrResult DestroyExportedLocalizationMapML(XrExportedLocalizationMapML map)
        {
            return XrPointers._xrDestroyExportedLocalizationMapML_fnptr(map);
        }
        /// <summary><b>[requires: XR_FB_eye_tracking_social]</b> </summary>
        public static XrResult DestroyEyeTrackerFB(XrEyeTrackerFB eyeTracker)
        {
            return XrPointers._xrDestroyEyeTrackerFB_fnptr(eyeTracker);
        }
        /// <summary><b>[requires: XR_FB_face_tracking2]</b> </summary>
        public static XrResult DestroyFaceTracker2FB(XrFaceTracker2FB faceTracker)
        {
            return XrPointers._xrDestroyFaceTracker2FB_fnptr(faceTracker);
        }
        /// <summary><b>[requires: XR_FB_face_tracking]</b> </summary>
        public static XrResult DestroyFaceTrackerFB(XrFaceTrackerFB faceTracker)
        {
            return XrPointers._xrDestroyFaceTrackerFB_fnptr(faceTracker);
        }
        /// <summary><b>[requires: XR_ML_facial_expression]</b> </summary>
        public static XrResult DestroyFacialExpressionClientML(XrFacialExpressionClientML facialExpressionClient)
        {
            return XrPointers._xrDestroyFacialExpressionClientML_fnptr(facialExpressionClient);
        }
        /// <summary><b>[requires: XR_HTC_facial_tracking]</b> </summary>
        public static XrResult DestroyFacialTrackerHTC(XrFacialTrackerHTC facialTracker)
        {
            return XrPointers._xrDestroyFacialTrackerHTC_fnptr(facialTracker);
        }
        /// <summary><b>[requires: XR_FB_foveation]</b> </summary>
        public static XrResult DestroyFoveationProfileFB(XrFoveationProfileFB profile)
        {
            return XrPointers._xrDestroyFoveationProfileFB_fnptr(profile);
        }
        /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
        public static XrResult DestroyGeometryInstanceFB(XrGeometryInstanceFB instance)
        {
            return XrPointers._xrDestroyGeometryInstanceFB_fnptr(instance);
        }
        /// <summary><b>[requires: XR_EXT_hand_tracking]</b> </summary>
        public static XrResult DestroyHandTrackerEXT(XrHandTrackerEXT handTracker)
        {
            return XrPointers._xrDestroyHandTrackerEXT_fnptr(handTracker);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult DestroyInstance(XrInstance instance)
        {
            return XrPointers._xrDestroyInstance_fnptr(instance);
        }
        /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
        public static XrResult DestroyMarkerDetectorML(XrMarkerDetectorML markerDetector)
        {
            return XrPointers._xrDestroyMarkerDetectorML_fnptr(markerDetector);
        }
        /// <summary><b>[requires: XR_META_passthrough_color_lut]</b> </summary>
        public static XrResult DestroyPassthroughColorLutMETA(XrPassthroughColorLutMETA colorLut)
        {
            return XrPointers._xrDestroyPassthroughColorLutMETA_fnptr(colorLut);
        }
        /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
        public static XrResult DestroyPassthroughFB(XrPassthroughFB passthrough)
        {
            return XrPointers._xrDestroyPassthroughFB_fnptr(passthrough);
        }
        /// <summary><b>[requires: XR_HTC_passthrough]</b> </summary>
        public static XrResult DestroyPassthroughHTC(XrPassthroughHTC passthrough)
        {
            return XrPointers._xrDestroyPassthroughHTC_fnptr(passthrough);
        }
        /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
        public static XrResult DestroyPassthroughLayerFB(XrPassthroughLayerFB layer)
        {
            return XrPointers._xrDestroyPassthroughLayerFB_fnptr(layer);
        }
        /// <summary><b>[requires: XR_EXT_plane_detection]</b> </summary>
        public static XrResult DestroyPlaneDetectorEXT(XrPlaneDetectorEXT planeDetector)
        {
            return XrPointers._xrDestroyPlaneDetectorEXT_fnptr(planeDetector);
        }
        /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
        public static XrResult DestroySceneMSFT(XrSceneMSFT scene)
        {
            return XrPointers._xrDestroySceneMSFT_fnptr(scene);
        }
        /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
        public static XrResult DestroySceneObserverMSFT(XrSceneObserverMSFT sceneObserver)
        {
            return XrPointers._xrDestroySceneObserverMSFT_fnptr(sceneObserver);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult DestroySession(XrSession session)
        {
            return XrPointers._xrDestroySession_fnptr(session);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult DestroySpace(XrSpace space)
        {
            return XrPointers._xrDestroySpace_fnptr(space);
        }
        /// <summary><b>[requires: XR_FB_spatial_entity_user]</b> </summary>
        public static XrResult DestroySpaceUserFB(XrSpaceUserFB user)
        {
            return XrPointers._xrDestroySpaceUserFB_fnptr(user);
        }
        /// <summary><b>[requires: XR_MSFT_spatial_anchor]</b> </summary>
        public static XrResult DestroySpatialAnchorMSFT(XrSpatialAnchorMSFT anchor)
        {
            return XrPointers._xrDestroySpatialAnchorMSFT_fnptr(anchor);
        }
        /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> </summary>
        public static XrResult DestroySpatialAnchorsStorageML(XrSpatialAnchorsStorageML storage)
        {
            return XrPointers._xrDestroySpatialAnchorsStorageML_fnptr(storage);
        }
        /// <summary><b>[requires: XR_MSFT_spatial_anchor_persistence]</b> </summary>
        public static XrResult DestroySpatialAnchorStoreConnectionMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore)
        {
            return XrPointers._xrDestroySpatialAnchorStoreConnectionMSFT_fnptr(spatialAnchorStore);
        }
        /// <summary><b>[requires: XR_MSFT_spatial_graph_bridge]</b> </summary>
        public static XrResult DestroySpatialGraphNodeBindingMSFT(XrSpatialGraphNodeBindingMSFT nodeBinding)
        {
            return XrPointers._xrDestroySpatialGraphNodeBindingMSFT_fnptr(nodeBinding);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult DestroySwapchain(XrSwapchain swapchain)
        {
            return XrPointers._xrDestroySwapchain_fnptr(swapchain);
        }
        /// <summary><b>[requires: XR_FB_triangle_mesh]</b> </summary>
        public static XrResult DestroyTriangleMeshFB(XrTriangleMeshFB mesh)
        {
            return XrPointers._xrDestroyTriangleMeshFB_fnptr(mesh);
        }
        /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
        public static XrResult DestroyVirtualKeyboardMETA(XrVirtualKeyboardMETA keyboard)
        {
            return XrPointers._xrDestroyVirtualKeyboardMETA_fnptr(keyboard);
        }
        /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> </summary>
        public static XrResult DestroyWorldMeshDetectorML(XrWorldMeshDetectorML detector)
        {
            return XrPointers._xrDestroyWorldMeshDetectorML_fnptr(detector);
        }
        /// <summary><b>[requires: XR_ML_localization_map]</b> </summary>
        public static XrResult EnableLocalizationEventsML(XrSession session, XrLocalizationEnableEventsInfoML* info)
        {
            return XrPointers._xrEnableLocalizationEventsML_fnptr(session, info);
        }
        /// <summary><b>[requires: XR_ML_user_calibration]</b> </summary>
        public static XrResult EnableUserCalibrationEventsML(XrInstance instance, XrUserCalibrationEnableEventsInfoML* enableInfo)
        {
            return XrPointers._xrEnableUserCalibrationEventsML_fnptr(instance, enableInfo);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult EndFrame(XrSession session, XrFrameEndInfo* frameEndInfo)
        {
            return XrPointers._xrEndFrame_fnptr(session, frameEndInfo);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult EndSession(XrSession session)
        {
            return XrPointers._xrEndSession_fnptr(session);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult EnumerateApiLayerProperties(uint propertyCapacityInput, uint* propertyCountOutput, XrApiLayerProperties* properties)
        {
            return XrPointers._xrEnumerateApiLayerProperties_fnptr(propertyCapacityInput, propertyCountOutput, properties);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult EnumerateBoundSourcesForAction(XrSession session, XrBoundSourcesForActionEnumerateInfo* enumerateInfo, uint sourceCapacityInput, uint* sourceCountOutput, ulong* sources)
        {
            return XrPointers._xrEnumerateBoundSourcesForAction_fnptr(session, enumerateInfo, sourceCapacityInput, sourceCountOutput, sources);
        }
        /// <summary><b>[requires: XR_FB_color_space]</b> </summary>
        public static XrResult EnumerateColorSpacesFB(XrSession session, uint colorSpaceCapacityInput, uint* colorSpaceCountOutput, XrColorSpaceFB* colorSpaces)
        {
            return XrPointers._xrEnumerateColorSpacesFB_fnptr(session, colorSpaceCapacityInput, colorSpaceCountOutput, colorSpaces);
        }
        /// <summary><b>[requires: XR_FB_display_refresh_rate]</b> </summary>
        public static XrResult EnumerateDisplayRefreshRatesFB(XrSession session, uint displayRefreshRateCapacityInput, uint* displayRefreshRateCountOutput, float* displayRefreshRates)
        {
            return XrPointers._xrEnumerateDisplayRefreshRatesFB_fnptr(session, displayRefreshRateCapacityInput, displayRefreshRateCountOutput, displayRefreshRates);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult EnumerateEnvironmentBlendModes(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint environmentBlendModeCapacityInput, uint* environmentBlendModeCountOutput, XrEnvironmentBlendMode* environmentBlendModes)
        {
            return XrPointers._xrEnumerateEnvironmentBlendModes_fnptr(instance, systemId, viewConfigurationType, environmentBlendModeCapacityInput, environmentBlendModeCountOutput, environmentBlendModes);
        }
        /// <summary><b>[requires: XR_META_environment_depth]</b> </summary>
        public static XrResult EnumerateEnvironmentDepthSwapchainImagesMETA(XrEnvironmentDepthSwapchainMETA swapchain, uint imageCapacityInput, uint* imageCountOutput, XrSwapchainImageBaseHeader* images)
        {
            return XrPointers._xrEnumerateEnvironmentDepthSwapchainImagesMETA_fnptr(swapchain, imageCapacityInput, imageCountOutput, images);
        }
        /// <summary><b>[requires: XR_OCULUS_external_camera]</b> </summary>
        public static XrResult EnumerateExternalCamerasOCULUS(XrSession session, uint cameraCapacityInput, uint* cameraCountOutput, XrExternalCameraOCULUS* cameras)
        {
            return XrPointers._xrEnumerateExternalCamerasOCULUS_fnptr(session, cameraCapacityInput, cameraCountOutput, cameras);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult EnumerateInstanceExtensionProperties(byte* layerName, uint propertyCapacityInput, uint* propertyCountOutput, XrExtensionProperties* properties)
        {
            return XrPointers._xrEnumerateInstanceExtensionProperties_fnptr(layerName, propertyCapacityInput, propertyCountOutput, properties);
        }
        /// <summary><b>[requires: XR_META_performance_metrics]</b> </summary>
        public static XrResult EnumeratePerformanceMetricsCounterPathsMETA(XrInstance instance, uint counterPathCapacityInput, uint* counterPathCountOutput, ulong* counterPaths)
        {
            return XrPointers._xrEnumeratePerformanceMetricsCounterPathsMETA_fnptr(instance, counterPathCapacityInput, counterPathCountOutput, counterPaths);
        }
        /// <summary><b>[requires: XR_MSFT_spatial_anchor_persistence]</b> </summary>
        public static XrResult EnumeratePersistedSpatialAnchorNamesMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, uint spatialAnchorNameCapacityInput, uint* spatialAnchorNameCountOutput, XrSpatialAnchorPersistenceNameMSFT* spatialAnchorNames)
        {
            return XrPointers._xrEnumeratePersistedSpatialAnchorNamesMSFT_fnptr(spatialAnchorStore, spatialAnchorNameCapacityInput, spatialAnchorNameCountOutput, spatialAnchorNames);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult EnumerateReferenceSpaces(XrSession session, uint spaceCapacityInput, uint* spaceCountOutput, XrReferenceSpaceType* spaces)
        {
            return XrPointers._xrEnumerateReferenceSpaces_fnptr(session, spaceCapacityInput, spaceCountOutput, spaces);
        }
        /// <summary><b>[requires: XR_FB_render_model]</b> </summary>
        public static XrResult EnumerateRenderModelPathsFB(XrSession session, uint pathCapacityInput, uint* pathCountOutput, XrRenderModelPathInfoFB* paths)
        {
            return XrPointers._xrEnumerateRenderModelPathsFB_fnptr(session, pathCapacityInput, pathCountOutput, paths);
        }
        /// <summary><b>[requires: XR_MSFT_composition_layer_reprojection]</b> </summary>
        public static XrResult EnumerateReprojectionModesMSFT(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint modeCapacityInput, uint* modeCountOutput, XrReprojectionModeMSFT* modes)
        {
            return XrPointers._xrEnumerateReprojectionModesMSFT_fnptr(instance, systemId, viewConfigurationType, modeCapacityInput, modeCountOutput, modes);
        }
        /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
        public static XrResult EnumerateSceneComputeFeaturesMSFT(XrInstance instance, ulong systemId, uint featureCapacityInput, uint* featureCountOutput, XrSceneComputeFeatureMSFT* features)
        {
            return XrPointers._xrEnumerateSceneComputeFeaturesMSFT_fnptr(instance, systemId, featureCapacityInput, featureCountOutput, features);
        }
        /// <summary><b>[requires: XR_FB_spatial_entity]</b> </summary>
        public static XrResult EnumerateSpaceSupportedComponentsFB(XrSpace space, uint componentTypeCapacityInput, uint* componentTypeCountOutput, XrSpaceComponentTypeFB* componentTypes)
        {
            return XrPointers._xrEnumerateSpaceSupportedComponentsFB_fnptr(space, componentTypeCapacityInput, componentTypeCountOutput, componentTypes);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult EnumerateSwapchainFormats(XrSession session, uint formatCapacityInput, uint* formatCountOutput, long* formats)
        {
            return XrPointers._xrEnumerateSwapchainFormats_fnptr(session, formatCapacityInput, formatCountOutput, formats);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult EnumerateSwapchainImages(XrSwapchain swapchain, uint imageCapacityInput, uint* imageCountOutput, XrSwapchainImageBaseHeader* images)
        {
            return XrPointers._xrEnumerateSwapchainImages_fnptr(swapchain, imageCapacityInput, imageCountOutput, images);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult EnumerateViewConfigurations(XrInstance instance, ulong systemId, uint viewConfigurationTypeCapacityInput, uint* viewConfigurationTypeCountOutput, XrViewConfigurationType* viewConfigurationTypes)
        {
            return XrPointers._xrEnumerateViewConfigurations_fnptr(instance, systemId, viewConfigurationTypeCapacityInput, viewConfigurationTypeCountOutput, viewConfigurationTypes);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult EnumerateViewConfigurationViews(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint viewCapacityInput, uint* viewCountOutput, XrViewConfigurationView* views)
        {
            return XrPointers._xrEnumerateViewConfigurationViews_fnptr(instance, systemId, viewConfigurationType, viewCapacityInput, viewCountOutput, views);
        }
        /// <summary><b>[requires: XR_HTCX_vive_tracker_interaction]</b> </summary>
        public static XrResult EnumerateViveTrackerPathsHTCX(XrInstance instance, uint pathCapacityInput, uint* pathCountOutput, XrViveTrackerPathsHTCX* paths)
        {
            return XrPointers._xrEnumerateViveTrackerPathsHTCX_fnptr(instance, pathCapacityInput, pathCountOutput, paths);
        }
        /// <summary><b>[requires: XR_FB_spatial_entity_storage]</b> </summary>
        public static XrResult EraseSpaceFB(XrSession session, XrSpaceEraseInfoFB* info, ulong* requestId)
        {
            return XrPointers._xrEraseSpaceFB_fnptr(session, info, requestId);
        }
        /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> </summary>
        public static XrResult FreeWorldMeshBufferML(XrWorldMeshDetectorML detector, XrWorldMeshBufferML* buffer)
        {
            return XrPointers._xrFreeWorldMeshBufferML_fnptr(detector, buffer);
        }
        /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
        public static XrResult GeometryInstanceSetTransformFB(XrGeometryInstanceFB instance, XrGeometryInstanceTransformFB* transformation)
        {
            return XrPointers._xrGeometryInstanceSetTransformFB_fnptr(instance, transformation);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult GetActionStateBoolean(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateBoolean* state)
        {
            return XrPointers._xrGetActionStateBoolean_fnptr(session, getInfo, state);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult GetActionStateFloat(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateFloat* state)
        {
            return XrPointers._xrGetActionStateFloat_fnptr(session, getInfo, state);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult GetActionStatePose(XrSession session, XrActionStateGetInfo* getInfo, XrActionStatePose* state)
        {
            return XrPointers._xrGetActionStatePose_fnptr(session, getInfo, state);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult GetActionStateVector2f(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateVector2f* state)
        {
            return XrPointers._xrGetActionStateVector2f_fnptr(session, getInfo, state);
        }
        /// <summary><b>[requires: XR_OCULUS_audio_device_guid]</b> </summary>
        public static XrResult GetAudioInputDeviceGuidOculus(XrInstance instance, char* buffer)
        {
            return XrPointers._xrGetAudioInputDeviceGuidOculus_fnptr(instance, buffer);
        }
        /// <summary><b>[requires: XR_OCULUS_audio_device_guid]</b> </summary>
        public static XrResult GetAudioOutputDeviceGuidOculus(XrInstance instance, char* buffer)
        {
            return XrPointers._xrGetAudioOutputDeviceGuidOculus_fnptr(instance, buffer);
        }
        /// <summary><b>[requires: XR_FB_body_tracking]</b> </summary>
        public static XrResult GetBodySkeletonFB(XrBodyTrackerFB bodyTracker, XrBodySkeletonFB* skeleton)
        {
            return XrPointers._xrGetBodySkeletonFB_fnptr(bodyTracker, skeleton);
        }
        /// <summary><b>[requires: XR_HTC_body_tracking]</b> </summary>
        public static XrResult GetBodySkeletonHTC(XrBodyTrackerHTC bodyTracker, XrSpace baseSpace, uint skeletonGenerationId, XrBodySkeletonHTC* skeleton)
        {
            return XrPointers._xrGetBodySkeletonHTC_fnptr(bodyTracker, baseSpace, skeletonGenerationId, skeleton);
        }
        /// <summary><b>[requires: XR_MSFT_controller_model]</b> </summary>
        public static XrResult GetControllerModelKeyMSFT(XrSession session, ulong topLevelUserPath, XrControllerModelKeyStateMSFT* controllerModelKeyState)
        {
            return XrPointers._xrGetControllerModelKeyMSFT_fnptr(session, topLevelUserPath, controllerModelKeyState);
        }
        /// <summary><b>[requires: XR_MSFT_controller_model]</b> </summary>
        public static XrResult GetControllerModelPropertiesMSFT(XrSession session, ulong modelKey, XrControllerModelPropertiesMSFT* properties)
        {
            return XrPointers._xrGetControllerModelPropertiesMSFT_fnptr(session, modelKey, properties);
        }
        /// <summary><b>[requires: XR_MSFT_controller_model]</b> </summary>
        public static XrResult GetControllerModelStateMSFT(XrSession session, ulong modelKey, XrControllerModelStateMSFT* state)
        {
            return XrPointers._xrGetControllerModelStateMSFT_fnptr(session, modelKey, state);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult GetCurrentInteractionProfile(XrSession session, ulong topLevelUserPath, XrInteractionProfileState* interactionProfile)
        {
            return XrPointers._xrGetCurrentInteractionProfile_fnptr(session, topLevelUserPath, interactionProfile);
        }
        /// <summary><b>[requires: XR_KHR_D3D11_enable]</b> </summary>
        public static XrResult GetD3D11GraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D11KHR* graphicsRequirements)
        {
            return XrPointers._xrGetD3D11GraphicsRequirementsKHR_fnptr(instance, systemId, graphicsRequirements);
        }
        /// <summary><b>[requires: XR_KHR_D3D12_enable]</b> </summary>
        public static XrResult GetD3D12GraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D12KHR* graphicsRequirements)
        {
            return XrPointers._xrGetD3D12GraphicsRequirementsKHR_fnptr(instance, systemId, graphicsRequirements);
        }
        /// <summary><b>[requires: XR_FB_haptic_pcm]</b> </summary>
        public static XrResult GetDeviceSampleRateFB(XrSession session, XrHapticActionInfo* hapticActionInfo, XrDevicePcmSampleRateStateFB* deviceSampleRate)
        {
            return XrPointers._xrGetDeviceSampleRateFB_fnptr(session, hapticActionInfo, deviceSampleRate);
        }
        /// <summary><b>[requires: XR_FB_display_refresh_rate]</b> </summary>
        public static XrResult GetDisplayRefreshRateFB(XrSession session, float* displayRefreshRate)
        {
            return XrPointers._xrGetDisplayRefreshRateFB_fnptr(session, displayRefreshRate);
        }
        /// <summary><b>[requires: XR_META_environment_depth]</b> </summary>
        public static XrResult GetEnvironmentDepthSwapchainStateMETA(XrEnvironmentDepthSwapchainMETA swapchain, XrEnvironmentDepthSwapchainStateMETA* state)
        {
            return XrPointers._xrGetEnvironmentDepthSwapchainStateMETA_fnptr(swapchain, state);
        }
        /// <summary><b>[requires: XR_ML_localization_map]</b> </summary>
        public static XrResult GetExportedLocalizationMapDataML(XrExportedLocalizationMapML map, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            return XrPointers._xrGetExportedLocalizationMapDataML_fnptr(map, bufferCapacityInput, bufferCountOutput, buffer);
        }
        /// <summary><b>[requires: XR_FB_eye_tracking_social]</b> </summary>
        public static XrResult GetEyeGazesFB(XrEyeTrackerFB eyeTracker, XrEyeGazesInfoFB* gazeInfo, XrEyeGazesFB* eyeGazes)
        {
            return XrPointers._xrGetEyeGazesFB_fnptr(eyeTracker, gazeInfo, eyeGazes);
        }
        /// <summary><b>[requires: XR_FB_face_tracking2]</b> </summary>
        public static XrResult GetFaceExpressionWeights2FB(XrFaceTracker2FB faceTracker, XrFaceExpressionInfo2FB* expressionInfo, XrFaceExpressionWeights2FB* expressionWeights)
        {
            return XrPointers._xrGetFaceExpressionWeights2FB_fnptr(faceTracker, expressionInfo, expressionWeights);
        }
        /// <summary><b>[requires: XR_FB_face_tracking]</b> </summary>
        public static XrResult GetFaceExpressionWeightsFB(XrFaceTrackerFB faceTracker, XrFaceExpressionInfoFB* expressionInfo, XrFaceExpressionWeightsFB* expressionWeights)
        {
            return XrPointers._xrGetFaceExpressionWeightsFB_fnptr(faceTracker, expressionInfo, expressionWeights);
        }
        /// <summary><b>[requires: XR_ML_facial_expression]</b> </summary>
        public static XrResult GetFacialExpressionBlendShapePropertiesML(XrFacialExpressionClientML facialExpressionClient, XrFacialExpressionBlendShapeGetInfoML* blendShapeGetInfo, uint blendShapeCount, XrFacialExpressionBlendShapePropertiesML* blendShapes)
        {
            return XrPointers._xrGetFacialExpressionBlendShapePropertiesML_fnptr(facialExpressionClient, blendShapeGetInfo, blendShapeCount, blendShapes);
        }
        /// <summary><b>[requires: XR_HTC_facial_tracking]</b> </summary>
        public static XrResult GetFacialExpressionsHTC(XrFacialTrackerHTC facialTracker, XrFacialExpressionsHTC* facialExpressions)
        {
            return XrPointers._xrGetFacialExpressionsHTC_fnptr(facialTracker, facialExpressions);
        }
        /// <summary><b>[requires: XR_META_foveation_eye_tracked]</b> </summary>
        public static XrResult GetFoveationEyeTrackedStateMETA(XrSession session, XrFoveationEyeTrackedStateMETA* foveationState)
        {
            return XrPointers._xrGetFoveationEyeTrackedStateMETA_fnptr(session, foveationState);
        }
        /// <summary><b>[requires: XR_FB_hand_tracking_mesh]</b> </summary>
        public static XrResult GetHandMeshFB(XrHandTrackerEXT handTracker, XrHandTrackingMeshFB* mesh)
        {
            return XrPointers._xrGetHandMeshFB_fnptr(handTracker, mesh);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult GetInputSourceLocalizedName(XrSession session, XrInputSourceLocalizedNameGetInfo* getInfo, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            return XrPointers._xrGetInputSourceLocalizedName_fnptr(session, getInfo, bufferCapacityInput, bufferCountOutput, buffer);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult GetInstanceProcAddr(XrInstance instance, byte* name, delegate* unmanaged[Cdecl]<void>* function)
        {
            return XrPointers._xrGetInstanceProcAddr_fnptr(instance, name, function);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult GetInstanceProperties(XrInstance instance, XrInstanceProperties* instanceProperties)
        {
            return XrPointers._xrGetInstanceProperties_fnptr(instance, instanceProperties);
        }
        /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
        public static XrResult GetMarkerDetectorStateML(XrMarkerDetectorML markerDetector, XrMarkerDetectorStateML* state)
        {
            return XrPointers._xrGetMarkerDetectorStateML_fnptr(markerDetector, state);
        }
        /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
        public static XrResult GetMarkerLengthML(XrMarkerDetectorML markerDetector, ulong marker, float* meters)
        {
            return XrPointers._xrGetMarkerLengthML_fnptr(markerDetector, marker, meters);
        }
        /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
        public static XrResult GetMarkerNumberML(XrMarkerDetectorML markerDetector, ulong marker, ulong* number)
        {
            return XrPointers._xrGetMarkerNumberML_fnptr(markerDetector, marker, number);
        }
        /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
        public static XrResult GetMarkerReprojectionErrorML(XrMarkerDetectorML markerDetector, ulong marker, float* reprojectionErrorMeters)
        {
            return XrPointers._xrGetMarkerReprojectionErrorML_fnptr(markerDetector, marker, reprojectionErrorMeters);
        }
        /// <summary><b>[requires: XR_VARJO_marker_tracking]</b> </summary>
        public static XrResult GetMarkerSizeVARJO(XrSession session, ulong markerId, XrExtent2Df* size)
        {
            return XrPointers._xrGetMarkerSizeVARJO_fnptr(session, markerId, size);
        }
        /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
        public static XrResult GetMarkersML(XrMarkerDetectorML markerDetector, uint markerCapacityInput, uint* markerCountOutput, ulong* markers)
        {
            return XrPointers._xrGetMarkersML_fnptr(markerDetector, markerCapacityInput, markerCountOutput, markers);
        }
        /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
        public static XrResult GetMarkerStringML(XrMarkerDetectorML markerDetector, ulong marker, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            return XrPointers._xrGetMarkerStringML_fnptr(markerDetector, marker, bufferCapacityInput, bufferCountOutput, buffer);
        }
        /// <summary><b>[requires: XR_KHR_metal_enable]</b> </summary>
        public static XrResult GetMetalGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsMetalKHR* graphicsRequirements)
        {
            return XrPointers._xrGetMetalGraphicsRequirementsKHR_fnptr(instance, systemId, graphicsRequirements);
        }
        /// <summary><b>[requires: XR_KHR_opengl_es_enable]</b> </summary>
        public static XrResult GetOpenGLESGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLESKHR* graphicsRequirements)
        {
            return XrPointers._xrGetOpenGLESGraphicsRequirementsKHR_fnptr(instance, systemId, graphicsRequirements);
        }
        /// <summary><b>[requires: XR_KHR_opengl_enable]</b> </summary>
        public static XrResult GetOpenGLGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLKHR* graphicsRequirements)
        {
            return XrPointers._xrGetOpenGLGraphicsRequirementsKHR_fnptr(instance, systemId, graphicsRequirements);
        }
        /// <summary><b>[requires: XR_META_passthrough_preferences]</b> </summary>
        public static XrResult GetPassthroughPreferencesMETA(XrSession session, XrPassthroughPreferencesMETA* preferences)
        {
            return XrPointers._xrGetPassthroughPreferencesMETA_fnptr(session, preferences);
        }
        /// <summary><b>[requires: XR_META_performance_metrics]</b> </summary>
        public static XrResult GetPerformanceMetricsStateMETA(XrSession session, XrPerformanceMetricsStateMETA* state)
        {
            return XrPointers._xrGetPerformanceMetricsStateMETA_fnptr(session, state);
        }
        /// <summary><b>[requires: XR_EXT_plane_detection]</b> </summary>
        public static XrResult GetPlaneDetectionsEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorGetInfoEXT* info, XrPlaneDetectorLocationsEXT* locations)
        {
            return XrPointers._xrGetPlaneDetectionsEXT_fnptr(planeDetector, info, locations);
        }
        /// <summary><b>[requires: XR_EXT_plane_detection]</b> </summary>
        public static XrResult GetPlaneDetectionStateEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectionStateEXT* state)
        {
            return XrPointers._xrGetPlaneDetectionStateEXT_fnptr(planeDetector, state);
        }
        /// <summary><b>[requires: XR_EXT_plane_detection]</b> </summary>
        public static XrResult GetPlanePolygonBufferEXT(XrPlaneDetectorEXT planeDetector, ulong planeId, uint polygonBufferIndex, XrPlaneDetectorPolygonBufferEXT* polygonBuffer)
        {
            return XrPointers._xrGetPlanePolygonBufferEXT_fnptr(planeDetector, planeId, polygonBufferIndex, polygonBuffer);
        }
        /// <summary><b>[requires: XR_META_recommended_layer_resolution]</b> </summary>
        public static XrResult GetRecommendedLayerResolutionMETA(XrSession session, XrRecommendedLayerResolutionGetInfoMETA* info, XrRecommendedLayerResolutionMETA* resolution)
        {
            return XrPointers._xrGetRecommendedLayerResolutionMETA_fnptr(session, info, resolution);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult GetReferenceSpaceBoundsRect(XrSession session, XrReferenceSpaceType referenceSpaceType, XrExtent2Df* bounds)
        {
            return XrPointers._xrGetReferenceSpaceBoundsRect_fnptr(session, referenceSpaceType, bounds);
        }
        /// <summary><b>[requires: XR_FB_render_model]</b> </summary>
        public static XrResult GetRenderModelPropertiesFB(XrSession session, ulong path, XrRenderModelPropertiesFB* properties)
        {
            return XrPointers._xrGetRenderModelPropertiesFB_fnptr(session, path, properties);
        }
        /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
        public static XrResult GetSceneComponentsMSFT(XrSceneMSFT scene, XrSceneComponentsGetInfoMSFT* getInfo, XrSceneComponentsMSFT* components)
        {
            return XrPointers._xrGetSceneComponentsMSFT_fnptr(scene, getInfo, components);
        }
        /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
        public static XrResult GetSceneComputeStateMSFT(XrSceneObserverMSFT sceneObserver, XrSceneComputeStateMSFT* state)
        {
            return XrPointers._xrGetSceneComputeStateMSFT_fnptr(sceneObserver, state);
        }
        /// <summary><b>[requires: XR_MSFT_scene_marker]</b> </summary>
        public static XrResult GetSceneMarkerDecodedStringMSFT(XrSceneMSFT scene, XrUuidMSFT* markerId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            return XrPointers._xrGetSceneMarkerDecodedStringMSFT_fnptr(scene, markerId, bufferCapacityInput, bufferCountOutput, buffer);
        }
        /// <summary><b>[requires: XR_MSFT_scene_marker]</b> </summary>
        public static XrResult GetSceneMarkerRawDataMSFT(XrSceneMSFT scene, XrUuidMSFT* markerId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            return XrPointers._xrGetSceneMarkerRawDataMSFT_fnptr(scene, markerId, bufferCapacityInput, bufferCountOutput, buffer);
        }
        /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
        public static XrResult GetSceneMeshBuffersMSFT(XrSceneMSFT scene, XrSceneMeshBuffersGetInfoMSFT* getInfo, XrSceneMeshBuffersMSFT* buffers)
        {
            return XrPointers._xrGetSceneMeshBuffersMSFT_fnptr(scene, getInfo, buffers);
        }
        /// <summary><b>[requires: XR_MSFT_scene_understanding_serialization]</b> </summary>
        public static XrResult GetSerializedSceneFragmentDataMSFT(XrSceneMSFT scene, XrSerializedSceneFragmentDataGetInfoMSFT* getInfo, uint countInput, uint* readOutput, byte* buffer)
        {
            return XrPointers._xrGetSerializedSceneFragmentDataMSFT_fnptr(scene, getInfo, countInput, readOutput, buffer);
        }
        /// <summary><b>[requires: XR_FB_scene]</b> </summary>
        public static XrResult GetSpaceBoundary2DFB(XrSession session, XrSpace space, XrBoundary2DFB* boundary2DOutput)
        {
            return XrPointers._xrGetSpaceBoundary2DFB_fnptr(session, space, boundary2DOutput);
        }
        /// <summary><b>[requires: XR_FB_scene]</b> </summary>
        public static XrResult GetSpaceBoundingBox2DFB(XrSession session, XrSpace space, XrRect2Df* boundingBox2DOutput)
        {
            return XrPointers._xrGetSpaceBoundingBox2DFB_fnptr(session, space, boundingBox2DOutput);
        }
        /// <summary><b>[requires: XR_FB_scene]</b> </summary>
        public static XrResult GetSpaceBoundingBox3DFB(XrSession session, XrSpace space, XrRect3DfFB* boundingBox3DOutput)
        {
            return XrPointers._xrGetSpaceBoundingBox3DFB_fnptr(session, space, boundingBox3DOutput);
        }
        /// <summary><b>[requires: XR_FB_spatial_entity]</b> </summary>
        public static XrResult GetSpaceComponentStatusFB(XrSpace space, XrSpaceComponentTypeFB componentType, XrSpaceComponentStatusFB* status)
        {
            return XrPointers._xrGetSpaceComponentStatusFB_fnptr(space, componentType, status);
        }
        /// <summary><b>[requires: XR_FB_spatial_entity_container]</b> </summary>
        public static XrResult GetSpaceContainerFB(XrSession session, XrSpace space, XrSpaceContainerFB* spaceContainerOutput)
        {
            return XrPointers._xrGetSpaceContainerFB_fnptr(session, space, spaceContainerOutput);
        }
        /// <summary><b>[requires: XR_FB_scene]</b> </summary>
        public static XrResult GetSpaceRoomLayoutFB(XrSession session, XrSpace space, XrRoomLayoutFB* roomLayoutOutput)
        {
            return XrPointers._xrGetSpaceRoomLayoutFB_fnptr(session, space, roomLayoutOutput);
        }
        /// <summary><b>[requires: XR_FB_scene]</b> </summary>
        public static XrResult GetSpaceSemanticLabelsFB(XrSession session, XrSpace space, XrSemanticLabelsFB* semanticLabelsOutput)
        {
            return XrPointers._xrGetSpaceSemanticLabelsFB_fnptr(session, space, semanticLabelsOutput);
        }
        /// <summary><b>[requires: XR_META_spatial_entity_mesh]</b> </summary>
        public static XrResult GetSpaceTriangleMeshMETA(XrSpace space, XrSpaceTriangleMeshGetInfoMETA* getInfo, XrSpaceTriangleMeshMETA* triangleMeshOutput)
        {
            return XrPointers._xrGetSpaceTriangleMeshMETA_fnptr(space, getInfo, triangleMeshOutput);
        }
        /// <summary><b>[requires: XR_FB_spatial_entity_user]</b> </summary>
        public static XrResult GetSpaceUserIdFB(XrSpaceUserFB user, ulong* userId)
        {
            return XrPointers._xrGetSpaceUserIdFB_fnptr(user, userId);
        }
        /// <summary><b>[requires: XR_FB_spatial_entity]</b> </summary>
        public static XrResult GetSpaceUuidFB(XrSpace space, XrUuid* uuid)
        {
            return XrPointers._xrGetSpaceUuidFB_fnptr(space, uuid);
        }
        /// <summary><b>[requires: XR_HTC_anchor]</b> </summary>
        public static XrResult GetSpatialAnchorNameHTC(XrSpace anchor, XrSpatialAnchorNameHTC* name)
        {
            return XrPointers._xrGetSpatialAnchorNameHTC_fnptr(anchor, name);
        }
        /// <summary><b>[requires: XR_ML_spatial_anchors]</b> </summary>
        public static XrResult GetSpatialAnchorStateML(XrSpace anchor, XrSpatialAnchorStateML* state)
        {
            return XrPointers._xrGetSpatialAnchorStateML_fnptr(anchor, state);
        }
        /// <summary><b>[requires: XR_MSFT_spatial_graph_bridge]</b> </summary>
        public static XrResult GetSpatialGraphNodeBindingPropertiesMSFT(XrSpatialGraphNodeBindingMSFT nodeBinding, XrSpatialGraphNodeBindingPropertiesGetInfoMSFT* getInfo, XrSpatialGraphNodeBindingPropertiesMSFT* properties)
        {
            return XrPointers._xrGetSpatialGraphNodeBindingPropertiesMSFT_fnptr(nodeBinding, getInfo, properties);
        }
        /// <summary><b>[requires: XR_FB_swapchain_update_state]</b> </summary>
        public static XrResult GetSwapchainStateFB(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state)
        {
            return XrPointers._xrGetSwapchainStateFB_fnptr(swapchain, state);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult GetSystem(XrInstance instance, XrSystemGetInfo* getInfo, ulong* systemId)
        {
            return XrPointers._xrGetSystem_fnptr(instance, getInfo, systemId);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult GetSystemProperties(XrInstance instance, ulong systemId, XrSystemProperties* properties)
        {
            return XrPointers._xrGetSystemProperties_fnptr(instance, systemId, properties);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult GetViewConfigurationProperties(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, XrViewConfigurationProperties* configurationProperties)
        {
            return XrPointers._xrGetViewConfigurationProperties_fnptr(instance, systemId, viewConfigurationType, configurationProperties);
        }
        /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
        public static XrResult GetVirtualKeyboardDirtyTexturesMETA(XrVirtualKeyboardMETA keyboard, uint textureIdCapacityInput, uint* textureIdCountOutput, ulong* textureIds)
        {
            return XrPointers._xrGetVirtualKeyboardDirtyTexturesMETA_fnptr(keyboard, textureIdCapacityInput, textureIdCountOutput, textureIds);
        }
        /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
        public static XrResult GetVirtualKeyboardModelAnimationStatesMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelAnimationStatesMETA* animationStates)
        {
            return XrPointers._xrGetVirtualKeyboardModelAnimationStatesMETA_fnptr(keyboard, animationStates);
        }
        /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
        public static XrResult GetVirtualKeyboardScaleMETA(XrVirtualKeyboardMETA keyboard, float* scale)
        {
            return XrPointers._xrGetVirtualKeyboardScaleMETA_fnptr(keyboard, scale);
        }
        /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
        public static XrResult GetVirtualKeyboardTextureDataMETA(XrVirtualKeyboardMETA keyboard, ulong textureId, XrVirtualKeyboardTextureDataMETA* textureData)
        {
            return XrPointers._xrGetVirtualKeyboardTextureDataMETA_fnptr(keyboard, textureId, textureData);
        }
        /// <summary><b>[requires: XR_KHR_visibility_mask]</b> </summary>
        public static XrResult GetVisibilityMaskKHR(XrSession session, XrViewConfigurationType viewConfigurationType, uint viewIndex, XrVisibilityMaskTypeKHR visibilityMaskType, XrVisibilityMaskKHR* visibilityMask)
        {
            return XrPointers._xrGetVisibilityMaskKHR_fnptr(session, viewConfigurationType, viewIndex, visibilityMaskType, visibilityMask);
        }
        /// <summary><b>[requires: XR_KHR_vulkan_enable]</b> </summary>
        public static XrResult GetVulkanDeviceExtensionsKHR(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            return XrPointers._xrGetVulkanDeviceExtensionsKHR_fnptr(instance, systemId, bufferCapacityInput, bufferCountOutput, buffer);
        }
        /// <summary><b>[requires: XR_KHR_vulkan_enable2]</b> </summary>
        public static XrResult GetVulkanGraphicsDevice2KHR(XrInstance instance, XrVulkanGraphicsDeviceGetInfoKHR* getInfo, VkPhysicalDevice* vulkanPhysicalDevice)
        {
            return XrPointers._xrGetVulkanGraphicsDevice2KHR_fnptr(instance, getInfo, vulkanPhysicalDevice);
        }
        /// <summary><b>[requires: XR_KHR_vulkan_enable]</b> </summary>
        public static XrResult GetVulkanGraphicsDeviceKHR(XrInstance instance, ulong systemId, VkInstance vkInstance, VkPhysicalDevice* vkPhysicalDevice)
        {
            return XrPointers._xrGetVulkanGraphicsDeviceKHR_fnptr(instance, systemId, vkInstance, vkPhysicalDevice);
        }
        /// <summary><b>[requires: XR_KHR_vulkan_enable2]</b>  Alias of <see cref="GetVulkanGraphicsRequirementsKHR"/></summary>
        public static XrResult GetVulkanGraphicsRequirements2KHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsVulkanKHR* graphicsRequirements)
        {
            return XrPointers._xrGetVulkanGraphicsRequirements2KHR_fnptr(instance, systemId, graphicsRequirements);
        }
        /// <summary><b>[requires: XR_KHR_vulkan_enable]</b> </summary>
        public static XrResult GetVulkanGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsVulkanKHR* graphicsRequirements)
        {
            return XrPointers._xrGetVulkanGraphicsRequirementsKHR_fnptr(instance, systemId, graphicsRequirements);
        }
        /// <summary><b>[requires: XR_KHR_vulkan_enable]</b> </summary>
        public static XrResult GetVulkanInstanceExtensionsKHR(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            return XrPointers._xrGetVulkanInstanceExtensionsKHR_fnptr(instance, systemId, bufferCapacityInput, bufferCountOutput, buffer);
        }
        /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> </summary>
        public static XrResult GetWorldMeshBufferRecommendSizeML(XrWorldMeshDetectorML detector, XrWorldMeshBufferRecommendedSizeInfoML* sizeInfo, XrWorldMeshBufferSizeML* size)
        {
            return XrPointers._xrGetWorldMeshBufferRecommendSizeML_fnptr(detector, sizeInfo, size);
        }
        /// <summary><b>[requires: XR_ML_localization_map]</b> </summary>
        public static XrResult ImportLocalizationMapML(XrSession session, XrLocalizationMapImportInfoML* importInfo, XrUuid* mapUuid)
        {
            return XrPointers._xrImportLocalizationMapML_fnptr(session, importInfo, mapUuid);
        }
        /// <summary><b>[requires: XR_KHR_loader_init]</b> </summary>
        public static XrResult InitializeLoaderKHR(XrLoaderInitInfoBaseHeaderKHR* loaderInitInfo)
        {
            return XrPointers._xrInitializeLoaderKHR_fnptr(loaderInitInfo);
        }
        /// <summary><b>[requires: XR_MSFT_controller_model]</b> </summary>
        public static XrResult LoadControllerModelMSFT(XrSession session, ulong modelKey, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            return XrPointers._xrLoadControllerModelMSFT_fnptr(session, modelKey, bufferCapacityInput, bufferCountOutput, buffer);
        }
        /// <summary><b>[requires: XR_FB_render_model]</b> </summary>
        public static XrResult LoadRenderModelFB(XrSession session, XrRenderModelLoadInfoFB* info, XrRenderModelBufferFB* buffer)
        {
            return XrPointers._xrLoadRenderModelFB_fnptr(session, info, buffer);
        }
        /// <summary><b>[requires: XR_BD_body_tracking]</b> </summary>
        public static XrResult LocateBodyJointsBD(XrBodyTrackerBD bodyTracker, XrBodyJointsLocateInfoBD* locateInfo, XrBodyJointLocationsBD* locations)
        {
            return XrPointers._xrLocateBodyJointsBD_fnptr(bodyTracker, locateInfo, locations);
        }
        /// <summary><b>[requires: XR_FB_body_tracking]</b> </summary>
        public static XrResult LocateBodyJointsFB(XrBodyTrackerFB bodyTracker, XrBodyJointsLocateInfoFB* locateInfo, XrBodyJointLocationsFB* locations)
        {
            return XrPointers._xrLocateBodyJointsFB_fnptr(bodyTracker, locateInfo, locations);
        }
        /// <summary><b>[requires: XR_HTC_body_tracking]</b> </summary>
        public static XrResult LocateBodyJointsHTC(XrBodyTrackerHTC bodyTracker, XrBodyJointsLocateInfoHTC* locateInfo, XrBodyJointLocationsHTC* locations)
        {
            return XrPointers._xrLocateBodyJointsHTC_fnptr(bodyTracker, locateInfo, locations);
        }
        /// <summary><b>[requires: XR_EXT_hand_tracking]</b> </summary>
        public static XrResult LocateHandJointsEXT(XrHandTrackerEXT handTracker, XrHandJointsLocateInfoEXT* locateInfo, XrHandJointLocationsEXT* locations)
        {
            return XrPointers._xrLocateHandJointsEXT_fnptr(handTracker, locateInfo, locations);
        }
        /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
        public static XrResult LocateSceneComponentsMSFT(XrSceneMSFT scene, XrSceneComponentsLocateInfoMSFT* locateInfo, XrSceneComponentLocationsMSFT* locations)
        {
            return XrPointers._xrLocateSceneComponentsMSFT_fnptr(scene, locateInfo, locations);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult LocateSpace(XrSpace space, XrSpace baseSpace, long time, XrSpaceLocation* location)
        {
            return XrPointers._xrLocateSpace_fnptr(space, baseSpace, time, location);
        }
        /// <summary><b>[requires: v1.1]</b> </summary>
        public static XrResult LocateSpaces(XrSession session, XrSpacesLocateInfo* locateInfo, XrSpaceLocations* spaceLocations)
        {
            return XrPointers._xrLocateSpaces_fnptr(session, locateInfo, spaceLocations);
        }
        /// <summary><b>[requires: XR_KHR_locate_spaces]</b>  Alias of <see cref="LocateSpaces"/></summary>
        public static XrResult LocateSpacesKHR(XrSession session, XrSpacesLocateInfo* locateInfo, XrSpaceLocations* spaceLocations)
        {
            return XrPointers._xrLocateSpacesKHR_fnptr(session, locateInfo, spaceLocations);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult LocateViews(XrSession session, XrViewLocateInfo* viewLocateInfo, XrViewState* viewState, uint viewCapacityInput, uint* viewCountOutput, XrView* views)
        {
            return XrPointers._xrLocateViews_fnptr(session, viewLocateInfo, viewState, viewCapacityInput, viewCountOutput, views);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult NegotiateLoaderApiLayerInterface(XrNegotiateLoaderInfo* loaderInfo, byte* layerName, XrNegotiateApiLayerRequest* apiLayerRequest)
        {
            return XrPointers._xrNegotiateLoaderApiLayerInterface_fnptr(loaderInfo, layerName, apiLayerRequest);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult NegotiateLoaderRuntimeInterface(XrNegotiateLoaderInfo* loaderInfo, XrNegotiateRuntimeRequest* runtimeRequest)
        {
            return XrPointers._xrNegotiateLoaderRuntimeInterface_fnptr(loaderInfo, runtimeRequest);
        }
        /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
        public static XrResult PassthroughLayerPauseFB(XrPassthroughLayerFB layer)
        {
            return XrPointers._xrPassthroughLayerPauseFB_fnptr(layer);
        }
        /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
        public static XrResult PassthroughLayerResumeFB(XrPassthroughLayerFB layer)
        {
            return XrPointers._xrPassthroughLayerResumeFB_fnptr(layer);
        }
        /// <summary><b>[requires: XR_FB_passthrough_keyboard_hands]</b> </summary>
        public static XrResult PassthroughLayerSetKeyboardHandsIntensityFB(XrPassthroughLayerFB layer, XrPassthroughKeyboardHandsIntensityFB* intensity)
        {
            return XrPointers._xrPassthroughLayerSetKeyboardHandsIntensityFB_fnptr(layer, intensity);
        }
        /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
        public static XrResult PassthroughLayerSetStyleFB(XrPassthroughLayerFB layer, XrPassthroughStyleFB* style)
        {
            return XrPointers._xrPassthroughLayerSetStyleFB_fnptr(layer, style);
        }
        /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
        public static XrResult PassthroughPauseFB(XrPassthroughFB passthrough)
        {
            return XrPointers._xrPassthroughPauseFB_fnptr(passthrough);
        }
        /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
        public static XrResult PassthroughStartFB(XrPassthroughFB passthrough)
        {
            return XrPointers._xrPassthroughStartFB_fnptr(passthrough);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult PathToString(XrInstance instance, ulong path, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            return XrPointers._xrPathToString_fnptr(instance, path, bufferCapacityInput, bufferCountOutput, buffer);
        }
        /// <summary><b>[requires: XR_EXT_performance_settings]</b> </summary>
        public static XrResult PerfSettingsSetPerformanceLevelEXT(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsLevelEXT level)
        {
            return XrPointers._xrPerfSettingsSetPerformanceLevelEXT_fnptr(session, domain, level);
        }
        /// <summary><b>[requires: XR_MSFT_spatial_anchor_persistence]</b> </summary>
        public static XrResult PersistSpatialAnchorMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceInfoMSFT* spatialAnchorPersistenceInfo)
        {
            return XrPointers._xrPersistSpatialAnchorMSFT_fnptr(spatialAnchorStore, spatialAnchorPersistenceInfo);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult PollEvent(XrInstance instance, XrEventDataBuffer* eventData)
        {
            return XrPointers._xrPollEvent_fnptr(instance, eventData);
        }
        /// <summary><b>[requires: XR_EXT_future]</b> </summary>
        public static XrResult PollFutureEXT(XrInstance instance, XrFuturePollInfoEXT* pollInfo, XrFuturePollResultEXT* pollResult)
        {
            return XrPointers._xrPollFutureEXT_fnptr(instance, pollInfo, pollResult);
        }
        /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> </summary>
        public static XrResult PublishSpatialAnchorsAsyncML(XrSpatialAnchorsStorageML storage, XrSpatialAnchorsPublishInfoML* publishInfo, ulong* future)
        {
            return XrPointers._xrPublishSpatialAnchorsAsyncML_fnptr(storage, publishInfo, future);
        }
        /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> </summary>
        public static XrResult PublishSpatialAnchorsCompleteML(XrSpatialAnchorsStorageML storage, ulong future, XrSpatialAnchorsPublishCompletionML* completion)
        {
            return XrPointers._xrPublishSpatialAnchorsCompleteML_fnptr(storage, future, completion);
        }
        /// <summary><b>[requires: XR_ML_localization_map]</b> </summary>
        public static XrResult QueryLocalizationMapsML(XrSession session, XrLocalizationMapQueryInfoBaseHeaderML* queryInfo, uint mapCapacityInput, uint* mapCountOutput, XrLocalizationMapML* maps)
        {
            return XrPointers._xrQueryLocalizationMapsML_fnptr(session, queryInfo, mapCapacityInput, mapCountOutput, maps);
        }
        /// <summary><b>[requires: XR_META_performance_metrics]</b> </summary>
        public static XrResult QueryPerformanceMetricsCounterMETA(XrSession session, ulong counterPath, XrPerformanceMetricsCounterMETA* counter)
        {
            return XrPointers._xrQueryPerformanceMetricsCounterMETA_fnptr(session, counterPath, counter);
        }
        /// <summary><b>[requires: XR_FB_spatial_entity_query]</b> </summary>
        public static XrResult QuerySpacesFB(XrSession session, XrSpaceQueryInfoBaseHeaderFB* info, ulong* requestId)
        {
            return XrPointers._xrQuerySpacesFB_fnptr(session, info, requestId);
        }
        /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> </summary>
        public static XrResult QuerySpatialAnchorsAsyncML(XrSpatialAnchorsStorageML storage, XrSpatialAnchorsQueryInfoBaseHeaderML* queryInfo, ulong* future)
        {
            return XrPointers._xrQuerySpatialAnchorsAsyncML_fnptr(storage, queryInfo, future);
        }
        /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> </summary>
        public static XrResult QuerySpatialAnchorsCompleteML(XrSpatialAnchorsStorageML storage, ulong future, XrSpatialAnchorsQueryCompletionML* completion)
        {
            return XrPointers._xrQuerySpatialAnchorsCompleteML_fnptr(storage, future, completion);
        }
        /// <summary><b>[requires: XR_FB_keyboard_tracking]</b> </summary>
        public static XrResult QuerySystemTrackedKeyboardFB(XrSession session, XrKeyboardTrackingQueryFB* queryInfo, XrKeyboardTrackingDescriptionFB* keyboard)
        {
            return XrPointers._xrQuerySystemTrackedKeyboardFB_fnptr(session, queryInfo, keyboard);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult ReleaseSwapchainImage(XrSwapchain swapchain, XrSwapchainImageReleaseInfo* releaseInfo)
        {
            return XrPointers._xrReleaseSwapchainImage_fnptr(swapchain, releaseInfo);
        }
        /// <summary><b>[requires: XR_FB_display_refresh_rate]</b> </summary>
        public static XrResult RequestDisplayRefreshRateFB(XrSession session, float displayRefreshRate)
        {
            return XrPointers._xrRequestDisplayRefreshRateFB_fnptr(session, displayRefreshRate);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult RequestExitSession(XrSession session)
        {
            return XrPointers._xrRequestExitSession_fnptr(session);
        }
        /// <summary><b>[requires: XR_ML_localization_map]</b> </summary>
        public static XrResult RequestMapLocalizationML(XrSession session, XrMapLocalizationRequestInfoML* requestInfo)
        {
            return XrPointers._xrRequestMapLocalizationML_fnptr(session, requestInfo);
        }
        /// <summary><b>[requires: XR_FB_scene_capture]</b> </summary>
        public static XrResult RequestSceneCaptureFB(XrSession session, XrSceneCaptureRequestInfoFB* info, ulong* requestId)
        {
            return XrPointers._xrRequestSceneCaptureFB_fnptr(session, info, requestId);
        }
        /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> </summary>
        public static XrResult RequestWorldMeshAsyncML(XrWorldMeshDetectorML detector, XrWorldMeshGetInfoML* getInfo, XrWorldMeshBufferML* buffer, ulong* future)
        {
            return XrPointers._xrRequestWorldMeshAsyncML_fnptr(detector, getInfo, buffer, future);
        }
        /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> </summary>
        public static XrResult RequestWorldMeshCompleteML(XrWorldMeshDetectorML detector, XrWorldMeshRequestCompletionInfoML* completionInfo, ulong future, XrWorldMeshRequestCompletionML* completion)
        {
            return XrPointers._xrRequestWorldMeshCompleteML_fnptr(detector, completionInfo, future, completion);
        }
        /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> </summary>
        public static XrResult RequestWorldMeshStateAsyncML(XrWorldMeshDetectorML detector, XrWorldMeshStateRequestInfoML* stateRequest, ulong* future)
        {
            return XrPointers._xrRequestWorldMeshStateAsyncML_fnptr(detector, stateRequest, future);
        }
        /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> </summary>
        public static XrResult RequestWorldMeshStateCompleteML(XrWorldMeshDetectorML detector, ulong future, XrWorldMeshStateRequestCompletionML* completion)
        {
            return XrPointers._xrRequestWorldMeshStateCompleteML_fnptr(detector, future, completion);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult ResultToString(XrInstance instance, XrResult value, byte* buffer)
        {
            return XrPointers._xrResultToString_fnptr(instance, value, buffer);
        }
        /// <summary><b>[requires: XR_FB_spatial_entity_query]</b> </summary>
        public static XrResult RetrieveSpaceQueryResultsFB(XrSession session, ulong requestId, XrSpaceQueryResultsFB* results)
        {
            return XrPointers._xrRetrieveSpaceQueryResultsFB_fnptr(session, requestId, results);
        }
        /// <summary><b>[requires: XR_FB_spatial_entity_storage]</b> </summary>
        public static XrResult SaveSpaceFB(XrSession session, XrSpaceSaveInfoFB* info, ulong* requestId)
        {
            return XrPointers._xrSaveSpaceFB_fnptr(session, info, requestId);
        }
        /// <summary><b>[requires: XR_FB_spatial_entity_storage_batch]</b> </summary>
        public static XrResult SaveSpaceListFB(XrSession session, XrSpaceListSaveInfoFB* info, ulong* requestId)
        {
            return XrPointers._xrSaveSpaceListFB_fnptr(session, info, requestId);
        }
        /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
        public static XrResult SendVirtualKeyboardInputMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardInputInfoMETA* info, XrPosef* interactorRootPose)
        {
            return XrPointers._xrSendVirtualKeyboardInputMETA_fnptr(keyboard, info, interactorRootPose);
        }
        /// <summary><b>[requires: XR_EXT_debug_utils]</b> </summary>
        public static XrResult SessionBeginDebugUtilsLabelRegionEXT(XrSession session, XrDebugUtilsLabelEXT* labelInfo)
        {
            return XrPointers._xrSessionBeginDebugUtilsLabelRegionEXT_fnptr(session, labelInfo);
        }
        /// <summary><b>[requires: XR_EXT_debug_utils]</b> </summary>
        public static XrResult SessionEndDebugUtilsLabelRegionEXT(XrSession session)
        {
            return XrPointers._xrSessionEndDebugUtilsLabelRegionEXT_fnptr(session);
        }
        /// <summary><b>[requires: XR_EXT_debug_utils]</b> </summary>
        public static XrResult SessionInsertDebugUtilsLabelEXT(XrSession session, XrDebugUtilsLabelEXT* labelInfo)
        {
            return XrPointers._xrSessionInsertDebugUtilsLabelEXT_fnptr(session, labelInfo);
        }
        /// <summary><b>[requires: XR_KHR_android_thread_settings]</b> </summary>
        public static XrResult SetAndroidApplicationThreadKHR(XrSession session, XrAndroidThreadTypeKHR threadType, uint threadId)
        {
            return XrPointers._xrSetAndroidApplicationThreadKHR_fnptr(session, threadType, threadId);
        }
        /// <summary><b>[requires: XR_FB_color_space]</b> </summary>
        public static XrResult SetColorSpaceFB(XrSession session, XrColorSpaceFB colorSpace)
        {
            return XrPointers._xrSetColorSpaceFB_fnptr(session, colorSpace);
        }
        /// <summary><b>[requires: XR_EXT_debug_utils]</b> </summary>
        public static XrResult SetDebugUtilsObjectNameEXT(XrInstance instance, XrDebugUtilsObjectNameInfoEXT* nameInfo)
        {
            return XrPointers._xrSetDebugUtilsObjectNameEXT_fnptr(instance, nameInfo);
        }
        /// <summary><b>[requires: XR_ALMALENCE_digital_lens_control]</b> </summary>
        public static XrResult SetDigitalLensControlALMALENCE(XrSession session, XrDigitalLensControlALMALENCE* digitalLensControl)
        {
            return XrPointers._xrSetDigitalLensControlALMALENCE_fnptr(session, digitalLensControl);
        }
        /// <summary><b>[requires: XR_VARJO_environment_depth_estimation]</b> </summary>
        public static XrResult SetEnvironmentDepthEstimationVARJO(XrSession session, int enabled)
        {
            return XrPointers._xrSetEnvironmentDepthEstimationVARJO_fnptr(session, enabled);
        }
        /// <summary><b>[requires: XR_META_environment_depth]</b> </summary>
        public static XrResult SetEnvironmentDepthHandRemovalMETA(XrEnvironmentDepthProviderMETA environmentDepthProvider, XrEnvironmentDepthHandRemovalSetInfoMETA* setInfo)
        {
            return XrPointers._xrSetEnvironmentDepthHandRemovalMETA_fnptr(environmentDepthProvider, setInfo);
        }
        /// <summary><b>[requires: XR_EXT_conformance_automation]</b> </summary>
        public static XrResult SetInputDeviceActiveEXT(XrSession session, ulong interactionProfile, ulong topLevelPath, int isActive)
        {
            return XrPointers._xrSetInputDeviceActiveEXT_fnptr(session, interactionProfile, topLevelPath, isActive);
        }
        /// <summary><b>[requires: XR_EXT_conformance_automation]</b> </summary>
        public static XrResult SetInputDeviceLocationEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrSpace space, XrPosef pose)
        {
            return XrPointers._xrSetInputDeviceLocationEXT_fnptr(session, topLevelPath, inputSourcePath, space, pose);
        }
        /// <summary><b>[requires: XR_EXT_conformance_automation]</b> </summary>
        public static XrResult SetInputDeviceStateBoolEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, int state)
        {
            return XrPointers._xrSetInputDeviceStateBoolEXT_fnptr(session, topLevelPath, inputSourcePath, state);
        }
        /// <summary><b>[requires: XR_EXT_conformance_automation]</b> </summary>
        public static XrResult SetInputDeviceStateFloatEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, float state)
        {
            return XrPointers._xrSetInputDeviceStateFloatEXT_fnptr(session, topLevelPath, inputSourcePath, state);
        }
        /// <summary><b>[requires: XR_EXT_conformance_automation]</b> </summary>
        public static XrResult SetInputDeviceStateVector2fEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrVector2f state)
        {
            return XrPointers._xrSetInputDeviceStateVector2fEXT_fnptr(session, topLevelPath, inputSourcePath, state);
        }
        /// <summary><b>[requires: XR_VARJO_marker_tracking]</b> </summary>
        public static XrResult SetMarkerTrackingPredictionVARJO(XrSession session, ulong markerId, int enable)
        {
            return XrPointers._xrSetMarkerTrackingPredictionVARJO_fnptr(session, markerId, enable);
        }
        /// <summary><b>[requires: XR_VARJO_marker_tracking]</b> </summary>
        public static XrResult SetMarkerTrackingTimeoutVARJO(XrSession session, ulong markerId, long timeout)
        {
            return XrPointers._xrSetMarkerTrackingTimeoutVARJO_fnptr(session, markerId, timeout);
        }
        /// <summary><b>[requires: XR_VARJO_marker_tracking]</b> </summary>
        public static XrResult SetMarkerTrackingVARJO(XrSession session, int enabled)
        {
            return XrPointers._xrSetMarkerTrackingVARJO_fnptr(session, enabled);
        }
        /// <summary><b>[requires: XR_META_performance_metrics]</b> </summary>
        public static XrResult SetPerformanceMetricsStateMETA(XrSession session, XrPerformanceMetricsStateMETA* state)
        {
            return XrPointers._xrSetPerformanceMetricsStateMETA_fnptr(session, state);
        }
        /// <summary><b>[requires: XR_FB_spatial_entity]</b> </summary>
        public static XrResult SetSpaceComponentStatusFB(XrSpace space, XrSpaceComponentStatusSetInfoFB* info, ulong* requestId)
        {
            return XrPointers._xrSetSpaceComponentStatusFB_fnptr(space, info, requestId);
        }
        /// <summary><b>[requires: XR_ML_system_notifications]</b> </summary>
        public static XrResult SetSystemNotificationsML(XrInstance instance, XrSystemNotificationsSetInfoML* info)
        {
            return XrPointers._xrSetSystemNotificationsML_fnptr(instance, info);
        }
        /// <summary><b>[requires: XR_QCOM_tracking_optimization_settings]</b> </summary>
        public static XrResult SetTrackingOptimizationSettingsHintQCOM(XrSession session, XrTrackingOptimizationSettingsDomainQCOM domain, XrTrackingOptimizationSettingsHintQCOM hint)
        {
            return XrPointers._xrSetTrackingOptimizationSettingsHintQCOM_fnptr(session, domain, hint);
        }
        /// <summary><b>[requires: XR_VARJO_view_offset]</b> </summary>
        public static XrResult SetViewOffsetVARJO(XrSession session, float offset)
        {
            return XrPointers._xrSetViewOffsetVARJO_fnptr(session, offset);
        }
        /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
        public static XrResult SetVirtualKeyboardModelVisibilityMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelVisibilitySetInfoMETA* modelVisibility)
        {
            return XrPointers._xrSetVirtualKeyboardModelVisibilityMETA_fnptr(keyboard, modelVisibility);
        }
        /// <summary><b>[requires: XR_FB_spatial_entity_sharing]</b> </summary>
        public static XrResult ShareSpacesFB(XrSession session, XrSpaceShareInfoFB* info, ulong* requestId)
        {
            return XrPointers._xrShareSpacesFB_fnptr(session, info, requestId);
        }
        /// <summary><b>[requires: XR_META_spatial_entity_sharing]</b> </summary>
        public static XrResult ShareSpacesMETA(XrSession session, XrShareSpacesInfoMETA* info, ulong* requestId)
        {
            return XrPointers._xrShareSpacesMETA_fnptr(session, info, requestId);
        }
        /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
        public static XrResult SnapshotMarkerDetectorML(XrMarkerDetectorML markerDetector, XrMarkerDetectorSnapshotInfoML* snapshotInfo)
        {
            return XrPointers._xrSnapshotMarkerDetectorML_fnptr(markerDetector, snapshotInfo);
        }
        /// <summary><b>[requires: XR_META_colocation_discovery]</b> </summary>
        public static XrResult StartColocationAdvertisementMETA(XrSession session, XrColocationAdvertisementStartInfoMETA* info, ulong* advertisementRequestId)
        {
            return XrPointers._xrStartColocationAdvertisementMETA_fnptr(session, info, advertisementRequestId);
        }
        /// <summary><b>[requires: XR_META_colocation_discovery]</b> </summary>
        public static XrResult StartColocationDiscoveryMETA(XrSession session, XrColocationDiscoveryStartInfoMETA* info, ulong* discoveryRequestId)
        {
            return XrPointers._xrStartColocationDiscoveryMETA_fnptr(session, info, discoveryRequestId);
        }
        /// <summary><b>[requires: XR_META_environment_depth]</b> </summary>
        public static XrResult StartEnvironmentDepthProviderMETA(XrEnvironmentDepthProviderMETA environmentDepthProvider)
        {
            return XrPointers._xrStartEnvironmentDepthProviderMETA_fnptr(environmentDepthProvider);
        }
        /// <summary><b>[requires: XR_META_colocation_discovery]</b> </summary>
        public static XrResult StopColocationAdvertisementMETA(XrSession session, XrColocationAdvertisementStopInfoMETA* info, ulong* requestId)
        {
            return XrPointers._xrStopColocationAdvertisementMETA_fnptr(session, info, requestId);
        }
        /// <summary><b>[requires: XR_META_colocation_discovery]</b> </summary>
        public static XrResult StopColocationDiscoveryMETA(XrSession session, XrColocationDiscoveryStopInfoMETA* info, ulong* requestId)
        {
            return XrPointers._xrStopColocationDiscoveryMETA_fnptr(session, info, requestId);
        }
        /// <summary><b>[requires: XR_META_environment_depth]</b> </summary>
        public static XrResult StopEnvironmentDepthProviderMETA(XrEnvironmentDepthProviderMETA environmentDepthProvider)
        {
            return XrPointers._xrStopEnvironmentDepthProviderMETA_fnptr(environmentDepthProvider);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult StopHapticFeedback(XrSession session, XrHapticActionInfo* hapticActionInfo)
        {
            return XrPointers._xrStopHapticFeedback_fnptr(session, hapticActionInfo);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult StringToPath(XrInstance instance, byte* pathString, ulong* path)
        {
            return XrPointers._xrStringToPath_fnptr(instance, pathString, path);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult StructureTypeToString(XrInstance instance, XrStructureType value, byte* buffer)
        {
            return XrPointers._xrStructureTypeToString_fnptr(instance, value, buffer);
        }
        /// <summary><b>[requires: XR_KHR_extended_struct_name_lengths]</b> </summary>
        public static XrResult StructureTypeToString2KHR(XrInstance instance, XrStructureType value, byte* buffer)
        {
            return XrPointers._xrStructureTypeToString2KHR_fnptr(instance, value, buffer);
        }
        /// <summary><b>[requires: XR_EXT_debug_utils]</b> </summary>
        public static XrResult SubmitDebugUtilsMessageEXT(XrInstance instance, XrDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, XrDebugUtilsMessageTypeFlagBitsEXT messageTypes, XrDebugUtilsMessengerCallbackDataEXT* callbackData)
        {
            return XrPointers._xrSubmitDebugUtilsMessageEXT_fnptr(instance, messageSeverity, messageTypes, callbackData);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult SuggestInteractionProfileBindings(XrInstance instance, XrInteractionProfileSuggestedBinding* suggestedBindings)
        {
            return XrPointers._xrSuggestInteractionProfileBindings_fnptr(instance, suggestedBindings);
        }
        /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
        public static XrResult SuggestVirtualKeyboardLocationMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardLocationInfoMETA* locationInfo)
        {
            return XrPointers._xrSuggestVirtualKeyboardLocationMETA_fnptr(keyboard, locationInfo);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult SyncActions(XrSession session, XrActionsSyncInfo* syncInfo)
        {
            return XrPointers._xrSyncActions_fnptr(session, syncInfo);
        }
        /// <summary><b>[requires: XR_EXT_thermal_query]</b> </summary>
        public static XrResult ThermalGetTemperatureTrendEXT(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsNotificationLevelEXT* notificationLevel, float* tempHeadroom, float* tempSlope)
        {
            return XrPointers._xrThermalGetTemperatureTrendEXT_fnptr(session, domain, notificationLevel, tempHeadroom, tempSlope);
        }
        /// <summary><b>[requires: XR_FB_triangle_mesh]</b> </summary>
        public static XrResult TriangleMeshBeginUpdateFB(XrTriangleMeshFB mesh)
        {
            return XrPointers._xrTriangleMeshBeginUpdateFB_fnptr(mesh);
        }
        /// <summary><b>[requires: XR_FB_triangle_mesh]</b> </summary>
        public static XrResult TriangleMeshBeginVertexBufferUpdateFB(XrTriangleMeshFB mesh, uint* outVertexCount)
        {
            return XrPointers._xrTriangleMeshBeginVertexBufferUpdateFB_fnptr(mesh, outVertexCount);
        }
        /// <summary><b>[requires: XR_FB_triangle_mesh]</b> </summary>
        public static XrResult TriangleMeshEndUpdateFB(XrTriangleMeshFB mesh, uint vertexCount, uint triangleCount)
        {
            return XrPointers._xrTriangleMeshEndUpdateFB_fnptr(mesh, vertexCount, triangleCount);
        }
        /// <summary><b>[requires: XR_FB_triangle_mesh]</b> </summary>
        public static XrResult TriangleMeshEndVertexBufferUpdateFB(XrTriangleMeshFB mesh)
        {
            return XrPointers._xrTriangleMeshEndVertexBufferUpdateFB_fnptr(mesh);
        }
        /// <summary><b>[requires: XR_FB_triangle_mesh]</b> </summary>
        public static XrResult TriangleMeshGetIndexBufferFB(XrTriangleMeshFB mesh, uint** outIndexBuffer)
        {
            return XrPointers._xrTriangleMeshGetIndexBufferFB_fnptr(mesh, outIndexBuffer);
        }
        /// <summary><b>[requires: XR_FB_triangle_mesh]</b> </summary>
        public static XrResult TriangleMeshGetVertexBufferFB(XrTriangleMeshFB mesh, XrVector3f** outVertexBuffer)
        {
            return XrPointers._xrTriangleMeshGetVertexBufferFB_fnptr(mesh, outVertexBuffer);
        }
        /// <summary><b>[requires: XR_MSFT_spatial_graph_bridge]</b> </summary>
        public static XrResult TryCreateSpatialGraphStaticNodeBindingMSFT(XrSession session, XrSpatialGraphStaticNodeBindingCreateInfoMSFT* createInfo, XrSpatialGraphNodeBindingMSFT* nodeBinding)
        {
            return XrPointers._xrTryCreateSpatialGraphStaticNodeBindingMSFT_fnptr(session, createInfo, nodeBinding);
        }
        /// <summary><b>[requires: XR_MSFT_perception_anchor_interop]</b> </summary>
        public static XrResult TryGetPerceptionAnchorFromSpatialAnchorMSFT(XrSession session, XrSpatialAnchorMSFT anchor, IntPtr** perceptionAnchor)
        {
            return XrPointers._xrTryGetPerceptionAnchorFromSpatialAnchorMSFT_fnptr(session, anchor, perceptionAnchor);
        }
        /// <summary><b>[requires: XR_MSFT_spatial_anchor_persistence]</b> </summary>
        public static XrResult UnpersistSpatialAnchorMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceNameMSFT* spatialAnchorPersistenceName)
        {
            return XrPointers._xrUnpersistSpatialAnchorMSFT_fnptr(spatialAnchorStore, spatialAnchorPersistenceName);
        }
        /// <summary><b>[requires: XR_MSFT_hand_tracking_mesh]</b> </summary>
        public static XrResult UpdateHandMeshMSFT(XrHandTrackerEXT handTracker, XrHandMeshUpdateInfoMSFT* updateInfo, XrHandMeshMSFT* handMesh)
        {
            return XrPointers._xrUpdateHandMeshMSFT_fnptr(handTracker, updateInfo, handMesh);
        }
        /// <summary><b>[requires: XR_META_passthrough_color_lut]</b> </summary>
        public static XrResult UpdatePassthroughColorLutMETA(XrPassthroughColorLutMETA colorLut, XrPassthroughColorLutUpdateInfoMETA* updateInfo)
        {
            return XrPointers._xrUpdatePassthroughColorLutMETA_fnptr(colorLut, updateInfo);
        }
        /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> </summary>
        public static XrResult UpdateSpatialAnchorsExpirationAsyncML(XrSpatialAnchorsStorageML storage, XrSpatialAnchorsUpdateExpirationInfoML* updateInfo, ulong* future)
        {
            return XrPointers._xrUpdateSpatialAnchorsExpirationAsyncML_fnptr(storage, updateInfo, future);
        }
        /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> </summary>
        public static XrResult UpdateSpatialAnchorsExpirationCompleteML(XrSpatialAnchorsStorageML storage, ulong future, XrSpatialAnchorsUpdateExpirationCompletionML* completion)
        {
            return XrPointers._xrUpdateSpatialAnchorsExpirationCompleteML_fnptr(storage, future, completion);
        }
        /// <summary><b>[requires: XR_FB_swapchain_update_state]</b> </summary>
        public static XrResult UpdateSwapchainFB(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state)
        {
            return XrPointers._xrUpdateSwapchainFB_fnptr(swapchain, state);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult WaitFrame(XrSession session, XrFrameWaitInfo* frameWaitInfo, XrFrameState* frameState)
        {
            return XrPointers._xrWaitFrame_fnptr(session, frameWaitInfo, frameState);
        }
        /// <summary><b>[requires: v1.0]</b> </summary>
        public static XrResult WaitSwapchainImage(XrSwapchain swapchain, XrSwapchainImageWaitInfo* waitInfo)
        {
            return XrPointers._xrWaitSwapchainImage_fnptr(swapchain, waitInfo);
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
