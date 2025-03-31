// This file is auto generated, do not edit.
using OpenTK.Mathematics;
using OpenTK.Graphics.Vulkan;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenXR
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static unsafe partial class Xr
    {
        public const int True = 1;
        public const int False = 0;
        public const int MaxExtensionNameSize = 128;
        public const int MaxApiLayerNameSize = 256;
        public const int MaxApiLayerDescriptionSize = 256;
        public const int MaxSystemNameSize = 256;
        public const int MaxApplicationNameSize = 128;
        public const int MaxEngineNameSize = 128;
        public const int MaxRuntimeNameSize = 128;
        public const int MaxPathLength = 256;
        public const int MaxStructureNameSize = 64;
        public const int MaxResultStringSize = 64;
        public const int MaxGraphicsApisSupported = 32;
        public const int MaxActionSetNameSize = 64;
        public const int MaxActionNameSize = 64;
        public const int MaxLocalizedActionSetNameSize = 128;
        public const int MaxLocalizedActionNameSize = 128;
        public const int UuidSize = 16;
        /// <summary>[from: <b>XR_KHR_android_thread_settings</b>]</summary>
        public const uint KhrAndroidThreadSettingsSpecVersion = 6;
        /// <summary>[from: <b>XR_KHR_android_thread_settings</b>]</summary>
        public const string KhrAndroidThreadSettingsExtensionName = "XR_KHR_android_thread_settings";
        /// <summary>[from: <b>XR_KHR_android_surface_swapchain</b>]</summary>
        public const uint KhrAndroidSurfaceSwapchainSpecVersion = 4;
        /// <summary>[from: <b>XR_KHR_android_surface_swapchain</b>]</summary>
        public const string KhrAndroidSurfaceSwapchainExtensionName = "XR_KHR_android_surface_swapchain";
        /// <summary>[from: <b>XR_KHR_composition_layer_cube</b>]</summary>
        public const uint KhrCompositionLayerCubeSpecVersion = 8;
        /// <summary>[from: <b>XR_KHR_composition_layer_cube</b>]</summary>
        public const string KhrCompositionLayerCubeExtensionName = "XR_KHR_composition_layer_cube";
        /// <summary>[from: <b>XR_KHR_android_create_instance</b>]</summary>
        public const uint KhrAndroidCreateInstanceSpecVersion = 3;
        /// <summary>[from: <b>XR_KHR_android_create_instance</b>]</summary>
        public const string KhrAndroidCreateInstanceExtensionName = "XR_KHR_android_create_instance";
        /// <summary>[from: <b>XR_KHR_composition_layer_depth</b>]</summary>
        public const uint KhrCompositionLayerDepthSpecVersion = 6;
        /// <summary>[from: <b>XR_KHR_composition_layer_depth</b>]</summary>
        public const string KhrCompositionLayerDepthExtensionName = "XR_KHR_composition_layer_depth";
        /// <summary>[from: <b>XR_KHR_vulkan_swapchain_format_list</b>]</summary>
        public const uint KhrVulkanSwapchainFormatListSpecVersion = 5;
        /// <summary>[from: <b>XR_KHR_vulkan_swapchain_format_list</b>]</summary>
        public const string KhrVulkanSwapchainFormatListExtensionName = "XR_KHR_vulkan_swapchain_format_list";
        /// <summary>[from: <b>XR_EXT_performance_settings</b>]</summary>
        public const uint ExtPerformanceSettingsSpecVersion = 4;
        /// <summary>[from: <b>XR_EXT_performance_settings</b>]</summary>
        public const string ExtPerformanceSettingsExtensionName = "XR_EXT_performance_settings";
        /// <summary>[from: <b>XR_EXT_thermal_query</b>]</summary>
        public const uint ExtThermalQuerySpecVersion = 2;
        /// <summary>[from: <b>XR_EXT_thermal_query</b>]</summary>
        public const string ExtThermalQueryExtensionName = "XR_EXT_thermal_query";
        /// <summary>[from: <b>XR_KHR_composition_layer_cylinder</b>]</summary>
        public const uint KhrCompositionLayerCylinderSpecVersion = 4;
        /// <summary>[from: <b>XR_KHR_composition_layer_cylinder</b>]</summary>
        public const string KhrCompositionLayerCylinderExtensionName = "XR_KHR_composition_layer_cylinder";
        /// <summary>[from: <b>XR_KHR_composition_layer_equirect</b>]</summary>
        public const uint KhrCompositionLayerEquirectSpecVersion = 3;
        /// <summary>[from: <b>XR_KHR_composition_layer_equirect</b>]</summary>
        public const string KhrCompositionLayerEquirectExtensionName = "XR_KHR_composition_layer_equirect";
        /// <summary>[from: <b>XR_EXT_debug_utils</b>]</summary>
        public const uint ExtDebugUtilsSpecVersion = 5;
        /// <summary>[from: <b>XR_EXT_debug_utils</b>]</summary>
        public const string ExtDebugUtilsExtensionName = "XR_EXT_debug_utils";
        /// <summary>[from: <b>XR_KHR_opengl_enable</b>]</summary>
        public const uint KhrOpenglEnableSpecVersion = 10;
        /// <summary>[from: <b>XR_KHR_opengl_enable</b>]</summary>
        public const string KhrOpenglEnableExtensionName = "XR_KHR_opengl_enable";
        /// <summary>[from: <b>XR_KHR_opengl_es_enable</b>]</summary>
        public const uint KhrOpenglEsEnableSpecVersion = 8;
        /// <summary>[from: <b>XR_KHR_opengl_es_enable</b>]</summary>
        public const string KhrOpenglEsEnableExtensionName = "XR_KHR_opengl_es_enable";
        /// <summary>[from: <b>XR_KHR_vulkan_enable</b>]</summary>
        public const uint KhrVulkanEnableSpecVersion = 8;
        /// <summary>[from: <b>XR_KHR_vulkan_enable</b>]</summary>
        public const string KhrVulkanEnableExtensionName = "XR_KHR_vulkan_enable";
        /// <summary>[from: <b>XR_KHR_D3D11_enable</b>]</summary>
        public const uint KhrD3d11EnableSpecVersion = 9;
        /// <summary>[from: <b>XR_KHR_D3D11_enable</b>]</summary>
        public const string KhrD3d11EnableExtensionName = "XR_KHR_D3D11_enable";
        /// <summary>[from: <b>XR_KHR_D3D12_enable</b>]</summary>
        public const uint KhrD3d12EnableSpecVersion = 9;
        /// <summary>[from: <b>XR_KHR_D3D12_enable</b>]</summary>
        public const string KhrD3d12EnableExtensionName = "XR_KHR_D3D12_enable";
        /// <summary>[from: <b>XR_KHR_metal_enable</b>]</summary>
        public const uint KhrMetalEnableSpecVersion = 1;
        /// <summary>[from: <b>XR_KHR_metal_enable</b>]</summary>
        public const string KhrMetalEnableExtensionName = "XR_KHR_metal_enable";
        /// <summary>[from: <b>XR_EXT_eye_gaze_interaction</b>]</summary>
        public const uint ExtEyeGazeInteractionSpecVersion = 2;
        /// <summary>[from: <b>XR_EXT_eye_gaze_interaction</b>]</summary>
        public const string ExtEyeGazeInteractionExtensionName = "XR_EXT_eye_gaze_interaction";
        /// <summary>[from: <b>XR_KHR_visibility_mask</b>]</summary>
        public const uint KhrVisibilityMaskSpecVersion = 2;
        /// <summary>[from: <b>XR_KHR_visibility_mask</b>]</summary>
        public const string KhrVisibilityMaskExtensionName = "XR_KHR_visibility_mask";
        /// <summary>[from: <b>XR_EXTX_overlay</b>]</summary>
        public const uint ExtxOverlaySpecVersion = 5;
        /// <summary>[from: <b>XR_EXTX_overlay</b>]</summary>
        public const string ExtxOverlayExtensionName = "XR_EXTX_overlay";
        /// <summary>[from: <b>XR_KHR_composition_layer_color_scale_bias</b>]</summary>
        public const uint KhrCompositionLayerColorScaleBiasSpecVersion = 5;
        /// <summary>[from: <b>XR_KHR_composition_layer_color_scale_bias</b>]</summary>
        public const string KhrCompositionLayerColorScaleBiasExtensionName = "XR_KHR_composition_layer_color_scale_bias";
        /// <summary>[from: <b>XR_KHR_win32_convert_performance_counter_time</b>]</summary>
        public const uint KhrWin32ConvertPerformanceCounterTimeSpecVersion = 1;
        /// <summary>[from: <b>XR_KHR_win32_convert_performance_counter_time</b>]</summary>
        public const string KhrWin32ConvertPerformanceCounterTimeExtensionName = "XR_KHR_win32_convert_performance_counter_time";
        /// <summary>[from: <b>XR_KHR_convert_timespec_time</b>]</summary>
        public const uint KhrConvertTimespecTimeSpecVersion = 1;
        /// <summary>[from: <b>XR_KHR_convert_timespec_time</b>]</summary>
        public const string KhrConvertTimespecTimeExtensionName = "XR_KHR_convert_timespec_time";
        /// <summary>[from: <b>XR_VARJO_quad_views</b>]</summary>
        public const uint VarjoQuadViewsSpecVersion = 2;
        /// <summary>[from: <b>XR_VARJO_quad_views</b>]</summary>
        public const string VarjoQuadViewsExtensionName = "XR_VARJO_quad_views";
        /// <summary>[from: <b>XR_MSFT_unbounded_reference_space</b>]</summary>
        public const uint MsftUnboundedReferenceSpaceSpecVersion = 1;
        /// <summary>[from: <b>XR_MSFT_unbounded_reference_space</b>]</summary>
        public const string MsftUnboundedReferenceSpaceExtensionName = "XR_MSFT_unbounded_reference_space";
        /// <summary>[from: <b>XR_MSFT_spatial_anchor</b>]</summary>
        public const uint MsftSpatialAnchorSpecVersion = 2;
        /// <summary>[from: <b>XR_MSFT_spatial_anchor</b>]</summary>
        public const string MsftSpatialAnchorExtensionName = "XR_MSFT_spatial_anchor";
        /// <summary>[from: <b>XR_FB_composition_layer_image_layout</b>]</summary>
        public const uint FbCompositionLayerImageLayoutSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_composition_layer_image_layout</b>]</summary>
        public const string FbCompositionLayerImageLayoutExtensionName = "XR_FB_composition_layer_image_layout";
        /// <summary>[from: <b>XR_FB_composition_layer_alpha_blend</b>]</summary>
        public const uint FbCompositionLayerAlphaBlendSpecVersion = 3;
        /// <summary>[from: <b>XR_FB_composition_layer_alpha_blend</b>]</summary>
        public const string FbCompositionLayerAlphaBlendExtensionName = "XR_FB_composition_layer_alpha_blend";
        /// <summary>[from: <b>XR_MND_headless</b>]</summary>
        public const uint MndHeadlessSpecVersion = 2;
        /// <summary>[from: <b>XR_MND_headless</b>]</summary>
        public const string MndHeadlessExtensionName = "XR_MND_headless";
        /// <summary>[from: <b>XR_OCULUS_android_session_state_enable</b>]</summary>
        public const uint OculusAndroidSessionStateEnableSpecVersion = 1;
        /// <summary>[from: <b>XR_OCULUS_android_session_state_enable</b>]</summary>
        public const string OculusAndroidSessionStateEnableExtensionName = "XR_OCULUS_android_session_state_enable";
        /// <summary>[from: <b>XR_EXT_view_configuration_depth_range</b>]</summary>
        public const uint ExtViewConfigurationDepthRangeSpecVersion = 1;
        /// <summary>[from: <b>XR_EXT_view_configuration_depth_range</b>]</summary>
        public const string ExtViewConfigurationDepthRangeExtensionName = "XR_EXT_view_configuration_depth_range";
        /// <summary>[from: <b>XR_EXT_conformance_automation</b>]</summary>
        public const uint ExtConformanceAutomationSpecVersion = 3;
        /// <summary>[from: <b>XR_EXT_conformance_automation</b>]</summary>
        public const string ExtConformanceAutomationExtensionName = "XR_EXT_conformance_automation";
        /// <summary>[from: <b>XR_MNDX_egl_enable</b>]</summary>
        public const uint MndxEglEnableSpecVersion = 2;
        /// <summary>[from: <b>XR_MNDX_egl_enable</b>]</summary>
        public const string MndxEglEnableExtensionName = "XR_MNDX_egl_enable";
        /// <summary>[from: <b>XR_MSFT_spatial_graph_bridge</b>]</summary>
        public const uint MsftSpatialGraphBridgeSpecVersion = 2;
        /// <summary>[from: <b>XR_MSFT_spatial_graph_bridge</b>]</summary>
        public const string MsftSpatialGraphBridgeExtensionName = "XR_MSFT_spatial_graph_bridge";
        /// <summary>[from: <b>XR_MSFT_spatial_graph_bridge</b>]</summary>
        public const uint GuidSizeMsft = 16;
        /// <summary>[from: <b>XR_MSFT_hand_interaction</b>]</summary>
        public const uint MsftHandInteractionSpecVersion = 1;
        /// <summary>[from: <b>XR_MSFT_hand_interaction</b>]</summary>
        public const string MsftHandInteractionExtensionName = "XR_MSFT_hand_interaction";
        /// <summary>[from: <b>XR_EXT_hand_tracking</b>]</summary>
        public const uint ExtHandTrackingSpecVersion = 4;
        /// <summary>[from: <b>XR_EXT_hand_tracking</b>]</summary>
        public const string ExtHandTrackingExtensionName = "XR_EXT_hand_tracking";
        /// <summary>[from: <b>XR_MSFT_hand_tracking_mesh</b>]</summary>
        public const uint MsftHandTrackingMeshSpecVersion = 4;
        /// <summary>[from: <b>XR_MSFT_hand_tracking_mesh</b>]</summary>
        public const string MsftHandTrackingMeshExtensionName = "XR_MSFT_hand_tracking_mesh";
        /// <summary>[from: <b>XR_MSFT_secondary_view_configuration</b>]</summary>
        public const uint MsftSecondaryViewConfigurationSpecVersion = 1;
        /// <summary>[from: <b>XR_MSFT_secondary_view_configuration</b>]</summary>
        public const string MsftSecondaryViewConfigurationExtensionName = "XR_MSFT_secondary_view_configuration";
        /// <summary>[from: <b>XR_MSFT_first_person_observer</b>]</summary>
        public const uint MsftFirstPersonObserverSpecVersion = 1;
        /// <summary>[from: <b>XR_MSFT_first_person_observer</b>]</summary>
        public const string MsftFirstPersonObserverExtensionName = "XR_MSFT_first_person_observer";
        /// <summary>[from: <b>XR_MSFT_controller_model</b>]</summary>
        public const uint MsftControllerModelSpecVersion = 2;
        /// <summary>[from: <b>XR_MSFT_controller_model</b>]</summary>
        public const string MsftControllerModelExtensionName = "XR_MSFT_controller_model";
        /// <summary>[from: <b>XR_MSFT_controller_model</b>]</summary>
        public const uint MaxControllerModelNodeNameSizeMsft = 64;
        /// <summary>[from: <b>XR_MSFT_perception_anchor_interop</b>]</summary>
        public const uint MsftPerceptionAnchorInteropSpecVersion = 1;
        /// <summary>[from: <b>XR_MSFT_perception_anchor_interop</b>]</summary>
        public const string MsftPerceptionAnchorInteropExtensionName = "XR_MSFT_perception_anchor_interop";
        /// <summary>[from: <b>XR_EXT_win32_appcontainer_compatible</b>]</summary>
        public const uint ExtWin32AppcontainerCompatibleSpecVersion = 1;
        /// <summary>[from: <b>XR_EXT_win32_appcontainer_compatible</b>]</summary>
        public const string ExtWin32AppcontainerCompatibleExtensionName = "XR_EXT_win32_appcontainer_compatible";
        /// <summary>[from: <b>XR_EPIC_view_configuration_fov</b>]</summary>
        public const uint EpicViewConfigurationFovSpecVersion = 2;
        /// <summary>[from: <b>XR_EPIC_view_configuration_fov</b>]</summary>
        public const string EpicViewConfigurationFovExtensionName = "XR_EPIC_view_configuration_fov";
        /// <summary>[from: <b>XR_MSFT_holographic_window_attachment</b>]</summary>
        public const uint MsftHolographicWindowAttachmentSpecVersion = 1;
        /// <summary>[from: <b>XR_MSFT_holographic_window_attachment</b>]</summary>
        public const string MsftHolographicWindowAttachmentExtensionName = "XR_MSFT_holographic_window_attachment";
        /// <summary>[from: <b>XR_MSFT_composition_layer_reprojection</b>]</summary>
        public const uint MsftCompositionLayerReprojectionSpecVersion = 1;
        /// <summary>[from: <b>XR_MSFT_composition_layer_reprojection</b>]</summary>
        public const string MsftCompositionLayerReprojectionExtensionName = "XR_MSFT_composition_layer_reprojection";
        /// <summary>[from: <b>XR_HUAWEI_controller_interaction</b>]</summary>
        public const uint HuaweiControllerInteractionSpecVersion = 1;
        /// <summary>[from: <b>XR_HUAWEI_controller_interaction</b>]</summary>
        public const string HuaweiControllerInteractionExtensionName = "XR_HUAWEI_controller_interaction";
        /// <summary>[from: <b>XR_FB_android_surface_swapchain_create</b>]</summary>
        public const uint FbAndroidSurfaceSwapchainCreateSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_android_surface_swapchain_create</b>]</summary>
        public const string FbAndroidSurfaceSwapchainCreateExtensionName = "XR_FB_android_surface_swapchain_create";
        /// <summary>[from: <b>XR_FB_swapchain_update_state</b>]</summary>
        public const uint FbSwapchainUpdateStateSpecVersion = 3;
        /// <summary>[from: <b>XR_FB_swapchain_update_state</b>]</summary>
        public const string FbSwapchainUpdateStateExtensionName = "XR_FB_swapchain_update_state";
        /// <summary>[from: <b>XR_FB_composition_layer_secure_content</b>]</summary>
        public const uint FbCompositionLayerSecureContentSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_composition_layer_secure_content</b>]</summary>
        public const string FbCompositionLayerSecureContentExtensionName = "XR_FB_composition_layer_secure_content";
        /// <summary>[from: <b>XR_FB_body_tracking</b>]</summary>
        public const uint FbBodyTrackingSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_body_tracking</b>]</summary>
        public const string FbBodyTrackingExtensionName = "XR_FB_body_tracking";
        /// <summary>[from: <b>XR_EXT_dpad_binding</b>]</summary>
        public const uint ExtDpadBindingSpecVersion = 1;
        /// <summary>[from: <b>XR_EXT_dpad_binding</b>]</summary>
        public const string ExtDpadBindingExtensionName = "XR_EXT_dpad_binding";
        /// <summary>[from: <b>XR_VALVE_analog_threshold</b>]</summary>
        public const uint ValveAnalogThresholdSpecVersion = 2;
        /// <summary>[from: <b>XR_VALVE_analog_threshold</b>]</summary>
        public const string ValveAnalogThresholdExtensionName = "XR_VALVE_analog_threshold";
        /// <summary>[from: <b>XR_EXT_hand_joints_motion_range</b>]</summary>
        public const uint ExtHandJointsMotionRangeSpecVersion = 1;
        /// <summary>[from: <b>XR_EXT_hand_joints_motion_range</b>]</summary>
        public const string ExtHandJointsMotionRangeExtensionName = "XR_EXT_hand_joints_motion_range";
        /// <summary>[from: <b>XR_KHR_loader_init</b>]</summary>
        public const uint KhrLoaderInitSpecVersion = 2;
        /// <summary>[from: <b>XR_KHR_loader_init</b>]</summary>
        public const string KhrLoaderInitExtensionName = "XR_KHR_loader_init";
        /// <summary>[from: <b>XR_KHR_loader_init_android</b>]</summary>
        public const uint KhrLoaderInitAndroidSpecVersion = 1;
        /// <summary>[from: <b>XR_KHR_loader_init_android</b>]</summary>
        public const string KhrLoaderInitAndroidExtensionName = "XR_KHR_loader_init_android";
        /// <summary>[from: <b>XR_KHR_vulkan_enable2</b>]</summary>
        public const uint KhrVulkanEnable2SpecVersion = 2;
        /// <summary>[from: <b>XR_KHR_vulkan_enable2</b>]</summary>
        public const string KhrVulkanEnable2ExtensionName = "XR_KHR_vulkan_enable2";
        /// <summary>[from: <b>XR_KHR_composition_layer_equirect2</b>]</summary>
        public const uint KhrCompositionLayerEquirect2SpecVersion = 1;
        /// <summary>[from: <b>XR_KHR_composition_layer_equirect2</b>]</summary>
        public const string KhrCompositionLayerEquirect2ExtensionName = "XR_KHR_composition_layer_equirect2";
        /// <summary>[from: <b>XR_EXT_samsung_odyssey_controller</b>]</summary>
        public const uint ExtSamsungOdysseyControllerSpecVersion = 1;
        /// <summary>[from: <b>XR_EXT_samsung_odyssey_controller</b>]</summary>
        public const string ExtSamsungOdysseyControllerExtensionName = "XR_EXT_samsung_odyssey_controller";
        /// <summary>[from: <b>XR_EXT_hp_mixed_reality_controller</b>]</summary>
        public const uint ExtHpMixedRealityControllerSpecVersion = 1;
        /// <summary>[from: <b>XR_EXT_hp_mixed_reality_controller</b>]</summary>
        public const string ExtHpMixedRealityControllerExtensionName = "XR_EXT_hp_mixed_reality_controller";
        /// <summary>[from: <b>XR_MND_swapchain_usage_input_attachment_bit</b>]</summary>
        public const uint MndSwapchainUsageInputAttachmentBitSpecVersion = 2;
        /// <summary>[from: <b>XR_MND_swapchain_usage_input_attachment_bit</b>]</summary>
        public const string MndSwapchainUsageInputAttachmentBitExtensionName = "XR_MND_swapchain_usage_input_attachment_bit";
        /// <summary>[from: <b>XR_MSFT_scene_understanding</b>]</summary>
        public const uint MsftSceneUnderstandingSpecVersion = 2;
        /// <summary>[from: <b>XR_MSFT_scene_understanding</b>]</summary>
        public const string MsftSceneUnderstandingExtensionName = "XR_MSFT_scene_understanding";
        /// <summary>[from: <b>XR_MSFT_scene_understanding_serialization</b>]</summary>
        public const uint MsftSceneUnderstandingSerializationSpecVersion = 2;
        /// <summary>[from: <b>XR_MSFT_scene_understanding_serialization</b>]</summary>
        public const string MsftSceneUnderstandingSerializationExtensionName = "XR_MSFT_scene_understanding_serialization";
        /// <summary>[from: <b>XR_FB_display_refresh_rate</b>]</summary>
        public const uint FbDisplayRefreshRateSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_display_refresh_rate</b>]</summary>
        public const string FbDisplayRefreshRateExtensionName = "XR_FB_display_refresh_rate";
        /// <summary>[from: <b>XR_HTC_vive_cosmos_controller_interaction</b>]</summary>
        public const uint HtcViveCosmosControllerInteractionSpecVersion = 1;
        /// <summary>[from: <b>XR_HTC_vive_cosmos_controller_interaction</b>]</summary>
        public const string HtcViveCosmosControllerInteractionExtensionName = "XR_HTC_vive_cosmos_controller_interaction";
        /// <summary>[from: <b>XR_HTCX_vive_tracker_interaction</b>]</summary>
        public const uint HtcxViveTrackerInteractionSpecVersion = 3;
        /// <summary>[from: <b>XR_HTCX_vive_tracker_interaction</b>]</summary>
        public const string HtcxViveTrackerInteractionExtensionName = "XR_HTCX_vive_tracker_interaction";
        /// <summary>[from: <b>XR_HTC_facial_tracking</b>]</summary>
        public const uint HtcFacialTrackingSpecVersion = 3;
        /// <summary>[from: <b>XR_HTC_facial_tracking</b>]</summary>
        public const string HtcFacialTrackingExtensionName = "XR_HTC_facial_tracking";
        /// <summary>[from: <b>XR_HTC_vive_focus3_controller_interaction</b>]</summary>
        public const uint HtcViveFocus3ControllerInteractionSpecVersion = 2;
        /// <summary>[from: <b>XR_HTC_vive_focus3_controller_interaction</b>]</summary>
        public const string HtcViveFocus3ControllerInteractionExtensionName = "XR_HTC_vive_focus3_controller_interaction";
        /// <summary>[from: <b>XR_HTC_hand_interaction</b>]</summary>
        public const uint HtcHandInteractionSpecVersion = 1;
        /// <summary>[from: <b>XR_HTC_hand_interaction</b>]</summary>
        public const string HtcHandInteractionExtensionName = "XR_HTC_hand_interaction";
        /// <summary>[from: <b>XR_HTC_vive_wrist_tracker_interaction</b>]</summary>
        public const uint HtcViveWristTrackerInteractionSpecVersion = 1;
        /// <summary>[from: <b>XR_HTC_vive_wrist_tracker_interaction</b>]</summary>
        public const string HtcViveWristTrackerInteractionExtensionName = "XR_HTC_vive_wrist_tracker_interaction";
        /// <summary>[from: <b>XR_FB_color_space</b>]</summary>
        public const uint FbColorSpaceSpecVersion = 3;
        /// <summary>[from: <b>XR_FB_color_space</b>]</summary>
        public const string FbColorSpaceExtensionName = "XR_FB_color_space";
        /// <summary>[from: <b>XR_FB_hand_tracking_mesh</b>]</summary>
        public const uint FbHandTrackingMeshSpecVersion = 3;
        /// <summary>[from: <b>XR_FB_hand_tracking_mesh</b>]</summary>
        public const string FbHandTrackingMeshExtensionName = "XR_FB_hand_tracking_mesh";
        /// <summary>[from: <b>XR_FB_hand_tracking_aim</b>]</summary>
        public const uint FbHandTrackingAimSpecVersion = 2;
        /// <summary>[from: <b>XR_FB_hand_tracking_aim</b>]</summary>
        public const string FbHandTrackingAimExtensionName = "XR_FB_hand_tracking_aim";
        /// <summary>[from: <b>XR_FB_hand_tracking_capsules</b>]</summary>
        public const uint FbHandTrackingCapsulesSpecVersion = 3;
        /// <summary>[from: <b>XR_FB_hand_tracking_capsules</b>]</summary>
        public const string FbHandTrackingCapsulesExtensionName = "XR_FB_hand_tracking_capsules";
        /// <summary>[from: <b>XR_FB_hand_tracking_capsules</b>]</summary>
        public const uint HandTrackingCapsulePointCountFb = 2;
        /// <summary>[from: <b>XR_FB_hand_tracking_capsules</b>]</summary>
        public const uint HandTrackingCapsuleCountFb = 19;
        /// <summary>[from: <b>XR_FB_spatial_entity</b>]</summary>
        public const uint FbSpatialEntitySpecVersion = 3;
        /// <summary>[from: <b>XR_FB_spatial_entity</b>]</summary>
        public const string FbSpatialEntityExtensionName = "XR_FB_spatial_entity";
        /// <summary>[from: <b>XR_FB_foveation</b>]</summary>
        public const uint FbFoveationSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_foveation</b>]</summary>
        public const string FbFoveationExtensionName = "XR_FB_foveation";
        /// <summary>[from: <b>XR_FB_foveation_configuration</b>]</summary>
        public const uint FbFoveationConfigurationSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_foveation_configuration</b>]</summary>
        public const string FbFoveationConfigurationExtensionName = "XR_FB_foveation_configuration";
        /// <summary>[from: <b>XR_FB_keyboard_tracking</b>]</summary>
        public const uint FbKeyboardTrackingSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_keyboard_tracking</b>]</summary>
        public const string FbKeyboardTrackingExtensionName = "XR_FB_keyboard_tracking";
        /// <summary>[from: <b>XR_FB_keyboard_tracking</b>]</summary>
        public const uint MaxKeyboardTrackingNameSizeFb = 128;
        /// <summary>[from: <b>XR_FB_triangle_mesh</b>]</summary>
        public const uint FbTriangleMeshSpecVersion = 2;
        /// <summary>[from: <b>XR_FB_triangle_mesh</b>]</summary>
        public const string FbTriangleMeshExtensionName = "XR_FB_triangle_mesh";
        /// <summary>[from: <b>XR_FB_passthrough</b>]</summary>
        public const uint FbPassthroughSpecVersion = 4;
        /// <summary>[from: <b>XR_FB_passthrough</b>]</summary>
        public const string FbPassthroughExtensionName = "XR_FB_passthrough";
        /// <summary>[from: <b>XR_FB_passthrough</b>]</summary>
        public const uint PassthroughColorMapMonoSizeFb = 256;
        /// <summary>[from: <b>XR_FB_render_model</b>]</summary>
        public const uint FbRenderModelSpecVersion = 4;
        /// <summary>[from: <b>XR_FB_render_model</b>]</summary>
        public const string FbRenderModelExtensionName = "XR_FB_render_model";
        /// <summary>[from: <b>XR_FB_render_model</b>]</summary>
        public const uint MaxRenderModelNameSizeFb = 64;
        /// <summary>[from: <b>XR_KHR_binding_modification</b>]</summary>
        public const uint KhrBindingModificationSpecVersion = 1;
        /// <summary>[from: <b>XR_KHR_binding_modification</b>]</summary>
        public const string KhrBindingModificationExtensionName = "XR_KHR_binding_modification";
        /// <summary>[from: <b>XR_VARJO_foveated_rendering</b>]</summary>
        public const uint VarjoFoveatedRenderingSpecVersion = 3;
        /// <summary>[from: <b>XR_VARJO_foveated_rendering</b>]</summary>
        public const string VarjoFoveatedRenderingExtensionName = "XR_VARJO_foveated_rendering";
        /// <summary>[from: <b>XR_VARJO_composition_layer_depth_test</b>]</summary>
        public const uint VarjoCompositionLayerDepthTestSpecVersion = 2;
        /// <summary>[from: <b>XR_VARJO_composition_layer_depth_test</b>]</summary>
        public const string VarjoCompositionLayerDepthTestExtensionName = "XR_VARJO_composition_layer_depth_test";
        /// <summary>[from: <b>XR_VARJO_environment_depth_estimation</b>]</summary>
        public const uint VarjoEnvironmentDepthEstimationSpecVersion = 1;
        /// <summary>[from: <b>XR_VARJO_environment_depth_estimation</b>]</summary>
        public const string VarjoEnvironmentDepthEstimationExtensionName = "XR_VARJO_environment_depth_estimation";
        /// <summary>[from: <b>XR_VARJO_marker_tracking</b>]</summary>
        public const uint VarjoMarkerTrackingSpecVersion = 1;
        /// <summary>[from: <b>XR_VARJO_marker_tracking</b>]</summary>
        public const string VarjoMarkerTrackingExtensionName = "XR_VARJO_marker_tracking";
        /// <summary>[from: <b>XR_VARJO_view_offset</b>]</summary>
        public const uint VarjoViewOffsetSpecVersion = 1;
        /// <summary>[from: <b>XR_VARJO_view_offset</b>]</summary>
        public const string VarjoViewOffsetExtensionName = "XR_VARJO_view_offset";
        /// <summary>[from: <b>XR_VARJO_xr4_controller_interaction</b>]</summary>
        public const uint VarjoXr4ControllerInteractionSpecVersion = 2;
        /// <summary>[from: <b>XR_VARJO_xr4_controller_interaction</b>]</summary>
        public const string VarjoXr4ControllerInteractionExtensionName = "XR_VARJO_xr4_controller_interaction";
        /// <summary>[from: <b>XR_ML_ml2_controller_interaction</b>]</summary>
        public const uint MlMl2ControllerInteractionSpecVersion = 1;
        /// <summary>[from: <b>XR_ML_ml2_controller_interaction</b>]</summary>
        public const string MlMl2ControllerInteractionExtensionName = "XR_ML_ml2_controller_interaction";
        /// <summary>[from: <b>XR_ML_frame_end_info</b>]</summary>
        public const uint MlFrameEndInfoSpecVersion = 1;
        /// <summary>[from: <b>XR_ML_frame_end_info</b>]</summary>
        public const string MlFrameEndInfoExtensionName = "XR_ML_frame_end_info";
        /// <summary>[from: <b>XR_ML_global_dimmer</b>]</summary>
        public const uint MlGlobalDimmerSpecVersion = 1;
        /// <summary>[from: <b>XR_ML_global_dimmer</b>]</summary>
        public const string MlGlobalDimmerExtensionName = "XR_ML_global_dimmer";
        /// <summary>[from: <b>XR_ML_compat</b>]</summary>
        public const uint MlCompatSpecVersion = 1;
        /// <summary>[from: <b>XR_ML_compat</b>]</summary>
        public const string MlCompatExtensionName = "XR_ML_compat";
        /// <summary>[from: <b>XR_ML_marker_understanding</b>]</summary>
        public const uint MlMarkerUnderstandingSpecVersion = 1;
        /// <summary>[from: <b>XR_ML_marker_understanding</b>]</summary>
        public const string MlMarkerUnderstandingExtensionName = "XR_ML_marker_understanding";
        /// <summary>[from: <b>XR_ML_localization_map</b>]</summary>
        public const uint MlLocalizationMapSpecVersion = 1;
        /// <summary>[from: <b>XR_ML_localization_map</b>]</summary>
        public const string MlLocalizationMapExtensionName = "XR_ML_localization_map";
        /// <summary>[from: <b>XR_ML_localization_map</b>]</summary>
        public const uint MaxLocalizationMapNameLengthMl = 64;
        /// <summary>[from: <b>XR_ML_spatial_anchors</b>]</summary>
        public const uint MlSpatialAnchorsSpecVersion = 1;
        /// <summary>[from: <b>XR_ML_spatial_anchors</b>]</summary>
        public const string MlSpatialAnchorsExtensionName = "XR_ML_spatial_anchors";
        /// <summary>[from: <b>XR_ML_spatial_anchors_storage</b>]</summary>
        public const uint MlSpatialAnchorsStorageSpecVersion = 1;
        /// <summary>[from: <b>XR_ML_spatial_anchors_storage</b>]</summary>
        public const string MlSpatialAnchorsStorageExtensionName = "XR_ML_spatial_anchors_storage";
        /// <summary>[from: <b>XR_ML_user_calibration</b>]</summary>
        public const uint MlUserCalibrationSpecVersion = 1;
        /// <summary>[from: <b>XR_ML_user_calibration</b>]</summary>
        public const string MlUserCalibrationExtensionName = "XR_ML_user_calibration";
        /// <summary>[from: <b>XR_MSFT_spatial_anchor_persistence</b>]</summary>
        public const uint MsftSpatialAnchorPersistenceSpecVersion = 2;
        /// <summary>[from: <b>XR_MSFT_spatial_anchor_persistence</b>]</summary>
        public const string MsftSpatialAnchorPersistenceExtensionName = "XR_MSFT_spatial_anchor_persistence";
        /// <summary>[from: <b>XR_MSFT_spatial_anchor_persistence</b>]</summary>
        public const uint MaxSpatialAnchorNameSizeMsft = 256;
        /// <summary>[from: <b>XR_MSFT_scene_marker</b>]</summary>
        public const uint MsftSceneMarkerSpecVersion = 1;
        /// <summary>[from: <b>XR_MSFT_scene_marker</b>]</summary>
        public const string MsftSceneMarkerExtensionName = "XR_MSFT_scene_marker";
        /// <summary>[from: <b>XR_KHR_extended_struct_name_lengths</b>]</summary>
        public const uint KhrExtendedStructNameLengthsSpecVersion = 1;
        /// <summary>[from: <b>XR_KHR_extended_struct_name_lengths</b>]</summary>
        public const string KhrExtendedStructNameLengthsExtensionName = "XR_KHR_extended_struct_name_lengths";
        /// <summary>[from: <b>XR_KHR_extended_struct_name_lengths</b>]</summary>
        public const uint MaxStructureNameSizeExtendedKhr = 256;
        /// <summary>[from: <b>XR_ULTRALEAP_hand_tracking_forearm</b>]</summary>
        public const uint UltraleapHandTrackingForearmSpecVersion = 1;
        /// <summary>[from: <b>XR_ULTRALEAP_hand_tracking_forearm</b>]</summary>
        public const string UltraleapHandTrackingForearmExtensionName = "XR_ULTRALEAP_hand_tracking_forearm";
        /// <summary>[from: <b>XR_FB_spatial_entity_query</b>]</summary>
        public const uint FbSpatialEntityQuerySpecVersion = 1;
        /// <summary>[from: <b>XR_FB_spatial_entity_query</b>]</summary>
        public const string FbSpatialEntityQueryExtensionName = "XR_FB_spatial_entity_query";
        /// <summary>[from: <b>XR_FB_spatial_entity_storage</b>]</summary>
        public const uint FbSpatialEntityStorageSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_spatial_entity_storage</b>]</summary>
        public const string FbSpatialEntityStorageExtensionName = "XR_FB_spatial_entity_storage";
        /// <summary>[from: <b>XR_OCULUS_audio_device_guid</b>]</summary>
        public const uint OculusAudioDeviceGuidSpecVersion = 1;
        /// <summary>[from: <b>XR_OCULUS_audio_device_guid</b>]</summary>
        public const string OculusAudioDeviceGuidExtensionName = "XR_OCULUS_audio_device_guid";
        /// <summary>[from: <b>XR_OCULUS_audio_device_guid</b>]</summary>
        public const uint MaxAudioDeviceStrSizeOculus = 128;
        /// <summary>[from: <b>XR_FB_foveation_vulkan</b>]</summary>
        public const uint FbFoveationVulkanSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_foveation_vulkan</b>]</summary>
        public const string FbFoveationVulkanExtensionName = "XR_FB_foveation_vulkan";
        /// <summary>[from: <b>XR_FB_swapchain_update_state_android_surface</b>]</summary>
        public const uint FbSwapchainUpdateStateAndroidSurfaceSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_swapchain_update_state_android_surface</b>]</summary>
        public const string FbSwapchainUpdateStateAndroidSurfaceExtensionName = "XR_FB_swapchain_update_state_android_surface";
        /// <summary>[from: <b>XR_FB_swapchain_update_state_opengl_es</b>]</summary>
        public const uint FbSwapchainUpdateStateOpenglEsSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_swapchain_update_state_opengl_es</b>]</summary>
        public const string FbSwapchainUpdateStateOpenglEsExtensionName = "XR_FB_swapchain_update_state_opengl_es";
        /// <summary>[from: <b>XR_FB_swapchain_update_state_vulkan</b>]</summary>
        public const uint FbSwapchainUpdateStateVulkanSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_swapchain_update_state_vulkan</b>]</summary>
        public const string FbSwapchainUpdateStateVulkanExtensionName = "XR_FB_swapchain_update_state_vulkan";
        /// <summary>[from: <b>XR_KHR_swapchain_usage_input_attachment_bit</b>]</summary>
        public const uint KhrSwapchainUsageInputAttachmentBitSpecVersion = 3;
        /// <summary>[from: <b>XR_KHR_swapchain_usage_input_attachment_bit</b>]</summary>
        public const string KhrSwapchainUsageInputAttachmentBitExtensionName = "XR_KHR_swapchain_usage_input_attachment_bit";
        /// <summary>[from: <b>XR_FB_touch_controller_pro</b>]</summary>
        public const uint FbTouchControllerProSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_touch_controller_pro</b>]</summary>
        public const string FbTouchControllerProExtensionName = "XR_FB_touch_controller_pro";
        /// <summary>[from: <b>XR_FB_spatial_entity_sharing</b>]</summary>
        public const uint FbSpatialEntitySharingSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_spatial_entity_sharing</b>]</summary>
        public const string FbSpatialEntitySharingExtensionName = "XR_FB_spatial_entity_sharing";
        /// <summary>[from: <b>XR_FB_space_warp</b>]</summary>
        public const uint FbSpaceWarpSpecVersion = 2;
        /// <summary>[from: <b>XR_FB_space_warp</b>]</summary>
        public const string FbSpaceWarpExtensionName = "XR_FB_space_warp";
        /// <summary>[from: <b>XR_FB_haptic_amplitude_envelope</b>]</summary>
        public const uint FbHapticAmplitudeEnvelopeSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_haptic_amplitude_envelope</b>]</summary>
        public const string FbHapticAmplitudeEnvelopeExtensionName = "XR_FB_haptic_amplitude_envelope";
        /// <summary>[from: <b>XR_FB_scene</b>]</summary>
        public const uint FbSceneSpecVersion = 4;
        /// <summary>[from: <b>XR_FB_scene</b>]</summary>
        public const string FbSceneExtensionName = "XR_FB_scene";
        /// <summary>[from: <b>XR_EXT_palm_pose</b>]</summary>
        public const uint ExtPalmPoseSpecVersion = 3;
        /// <summary>[from: <b>XR_EXT_palm_pose</b>]</summary>
        public const string ExtPalmPoseExtensionName = "XR_EXT_palm_pose";
        /// <summary>[from: <b>XR_ALMALENCE_digital_lens_control</b>]</summary>
        public const uint AlmalenceDigitalLensControlSpecVersion = 1;
        /// <summary>[from: <b>XR_ALMALENCE_digital_lens_control</b>]</summary>
        public const string AlmalenceDigitalLensControlExtensionName = "XR_ALMALENCE_digital_lens_control";
        /// <summary>[from: <b>XR_FB_scene_capture</b>]</summary>
        public const uint FbSceneCaptureSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_scene_capture</b>]</summary>
        public const string FbSceneCaptureExtensionName = "XR_FB_scene_capture";
        /// <summary>[from: <b>XR_FB_spatial_entity_container</b>]</summary>
        public const uint FbSpatialEntityContainerSpecVersion = 2;
        /// <summary>[from: <b>XR_FB_spatial_entity_container</b>]</summary>
        public const string FbSpatialEntityContainerExtensionName = "XR_FB_spatial_entity_container";
        /// <summary>[from: <b>XR_META_foveation_eye_tracked</b>]</summary>
        public const uint MetaFoveationEyeTrackedSpecVersion = 1;
        /// <summary>[from: <b>XR_META_foveation_eye_tracked</b>]</summary>
        public const string MetaFoveationEyeTrackedExtensionName = "XR_META_foveation_eye_tracked";
        /// <summary>[from: <b>XR_META_foveation_eye_tracked</b>]</summary>
        public const uint FoveationCenterSizeMeta = 2;
        /// <summary>[from: <b>XR_FB_face_tracking</b>]</summary>
        public const uint FbFaceTrackingSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_face_tracking</b>]</summary>
        public const string FbFaceTrackingExtensionName = "XR_FB_face_tracking";
        /// <summary>[from: <b>XR_FB_eye_tracking_social</b>]</summary>
        public const uint FbEyeTrackingSocialSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_eye_tracking_social</b>]</summary>
        public const string FbEyeTrackingSocialExtensionName = "XR_FB_eye_tracking_social";
        /// <summary>[from: <b>XR_FB_passthrough_keyboard_hands</b>]</summary>
        public const uint FbPassthroughKeyboardHandsSpecVersion = 2;
        /// <summary>[from: <b>XR_FB_passthrough_keyboard_hands</b>]</summary>
        public const string FbPassthroughKeyboardHandsExtensionName = "XR_FB_passthrough_keyboard_hands";
        /// <summary>[from: <b>XR_FB_composition_layer_settings</b>]</summary>
        public const uint FbCompositionLayerSettingsSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_composition_layer_settings</b>]</summary>
        public const string FbCompositionLayerSettingsExtensionName = "XR_FB_composition_layer_settings";
        /// <summary>[from: <b>XR_FB_touch_controller_proximity</b>]</summary>
        public const uint FbTouchControllerProximitySpecVersion = 1;
        /// <summary>[from: <b>XR_FB_touch_controller_proximity</b>]</summary>
        public const string FbTouchControllerProximityExtensionName = "XR_FB_touch_controller_proximity";
        /// <summary>[from: <b>XR_FB_haptic_pcm</b>]</summary>
        public const uint FbHapticPcmSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_haptic_pcm</b>]</summary>
        public const string FbHapticPcmExtensionName = "XR_FB_haptic_pcm";
        /// <summary>[from: <b>XR_EXT_frame_synthesis</b>]</summary>
        public const uint ExtFrameSynthesisSpecVersion = 1;
        /// <summary>[from: <b>XR_EXT_frame_synthesis</b>]</summary>
        public const string ExtFrameSynthesisExtensionName = "XR_EXT_frame_synthesis";
        /// <summary>[from: <b>XR_FB_composition_layer_depth_test</b>]</summary>
        public const uint FbCompositionLayerDepthTestSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_composition_layer_depth_test</b>]</summary>
        public const string FbCompositionLayerDepthTestExtensionName = "XR_FB_composition_layer_depth_test";
        /// <summary>[from: <b>XR_META_local_dimming</b>]</summary>
        public const uint MetaLocalDimmingSpecVersion = 1;
        /// <summary>[from: <b>XR_META_local_dimming</b>]</summary>
        public const string MetaLocalDimmingExtensionName = "XR_META_local_dimming";
        /// <summary>[from: <b>XR_META_passthrough_preferences</b>]</summary>
        public const uint MetaPassthroughPreferencesSpecVersion = 1;
        /// <summary>[from: <b>XR_META_passthrough_preferences</b>]</summary>
        public const string MetaPassthroughPreferencesExtensionName = "XR_META_passthrough_preferences";
        /// <summary>[from: <b>XR_META_virtual_keyboard</b>]</summary>
        public const uint MetaVirtualKeyboardSpecVersion = 1;
        /// <summary>[from: <b>XR_META_virtual_keyboard</b>]</summary>
        public const string MetaVirtualKeyboardExtensionName = "XR_META_virtual_keyboard";
        /// <summary>[from: <b>XR_META_virtual_keyboard</b>]</summary>
        public const uint MaxVirtualKeyboardCommitTextSizeMeta = 3992;
        /// <summary>[from: <b>XR_OCULUS_external_camera</b>]</summary>
        public const uint OculusExternalCameraSpecVersion = 1;
        /// <summary>[from: <b>XR_OCULUS_external_camera</b>]</summary>
        public const string OculusExternalCameraExtensionName = "XR_OCULUS_external_camera";
        /// <summary>[from: <b>XR_OCULUS_external_camera</b>]</summary>
        public const uint MaxExternalCameraNameSizeOculus = 32;
        /// <summary>[from: <b>XR_META_vulkan_swapchain_create_info</b>]</summary>
        public const uint MetaVulkanSwapchainCreateInfoSpecVersion = 1;
        /// <summary>[from: <b>XR_META_vulkan_swapchain_create_info</b>]</summary>
        public const string MetaVulkanSwapchainCreateInfoExtensionName = "XR_META_vulkan_swapchain_create_info";
        /// <summary>[from: <b>XR_META_performance_metrics</b>]</summary>
        public const uint MetaPerformanceMetricsSpecVersion = 2;
        /// <summary>[from: <b>XR_META_performance_metrics</b>]</summary>
        public const string MetaPerformanceMetricsExtensionName = "XR_META_performance_metrics";
        /// <summary>[from: <b>XR_FB_spatial_entity_storage_batch</b>]</summary>
        public const uint FbSpatialEntityStorageBatchSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_spatial_entity_storage_batch</b>]</summary>
        public const string FbSpatialEntityStorageBatchExtensionName = "XR_FB_spatial_entity_storage_batch";
        /// <summary>[from: <b>XR_FB_spatial_entity_user</b>]</summary>
        public const uint FbSpatialEntityUserSpecVersion = 1;
        /// <summary>[from: <b>XR_FB_spatial_entity_user</b>]</summary>
        public const string FbSpatialEntityUserExtensionName = "XR_FB_spatial_entity_user";
        /// <summary>[from: <b>XR_META_headset_id</b>]</summary>
        public const uint MetaHeadsetIdSpecVersion = 2;
        /// <summary>[from: <b>XR_META_headset_id</b>]</summary>
        public const string MetaHeadsetIdExtensionName = "XR_META_headset_id";
        /// <summary>[from: <b>XR_META_hand_tracking_microgestures</b>]</summary>
        public const uint MetaHandTrackingMicrogesturesSpecVersion = 1;
        /// <summary>[from: <b>XR_META_hand_tracking_microgestures</b>]</summary>
        public const string MetaHandTrackingMicrogesturesExtensionName = "XR_META_hand_tracking_microgestures";
        /// <summary>[from: <b>XR_META_recommended_layer_resolution</b>]</summary>
        public const uint MetaRecommendedLayerResolutionSpecVersion = 1;
        /// <summary>[from: <b>XR_META_recommended_layer_resolution</b>]</summary>
        public const string MetaRecommendedLayerResolutionExtensionName = "XR_META_recommended_layer_resolution";
        /// <summary>[from: <b>XR_META_passthrough_color_lut</b>]</summary>
        public const uint MetaPassthroughColorLutSpecVersion = 1;
        /// <summary>[from: <b>XR_META_passthrough_color_lut</b>]</summary>
        public const string MetaPassthroughColorLutExtensionName = "XR_META_passthrough_color_lut";
        /// <summary>[from: <b>XR_META_spatial_entity_mesh</b>]</summary>
        public const uint MetaSpatialEntityMeshSpecVersion = 1;
        /// <summary>[from: <b>XR_META_spatial_entity_mesh</b>]</summary>
        public const string MetaSpatialEntityMeshExtensionName = "XR_META_spatial_entity_mesh";
        /// <summary>[from: <b>XR_META_automatic_layer_filter</b>]</summary>
        public const uint MetaAutomaticLayerFilterSpecVersion = 1;
        /// <summary>[from: <b>XR_META_automatic_layer_filter</b>]</summary>
        public const string MetaAutomaticLayerFilterExtensionName = "XR_META_automatic_layer_filter";
        /// <summary>[from: <b>XR_META_touch_controller_plus</b>]</summary>
        public const uint MetaTouchControllerPlusSpecVersion = 1;
        /// <summary>[from: <b>XR_META_touch_controller_plus</b>]</summary>
        public const string MetaTouchControllerPlusExtensionName = "XR_META_touch_controller_plus";
        /// <summary>[from: <b>XR_META_passthrough_layer_resumed_event</b>]</summary>
        public const uint MetaPassthroughLayerResumedEventSpecVersion = 1;
        /// <summary>[from: <b>XR_META_passthrough_layer_resumed_event</b>]</summary>
        public const string MetaPassthroughLayerResumedEventExtensionName = "XR_META_passthrough_layer_resumed_event";
        /// <summary>[from: <b>XR_FB_face_tracking2</b>]</summary>
        public const uint FbFaceTracking2SpecVersion = 1;
        /// <summary>[from: <b>XR_FB_face_tracking2</b>]</summary>
        public const string FbFaceTracking2ExtensionName = "XR_FB_face_tracking2";
        /// <summary>[from: <b>XR_META_spatial_entity_sharing</b>]</summary>
        public const uint MetaSpatialEntitySharingSpecVersion = 1;
        /// <summary>[from: <b>XR_META_spatial_entity_sharing</b>]</summary>
        public const string MetaSpatialEntitySharingExtensionName = "XR_META_spatial_entity_sharing";
        /// <summary>[from: <b>XR_META_spatial_entity_sharing</b>]</summary>
        public const uint MaxSpacesPerShareRequestMeta = 32;
        /// <summary>[from: <b>XR_META_environment_depth</b>]</summary>
        public const uint MetaEnvironmentDepthSpecVersion = 1;
        /// <summary>[from: <b>XR_META_environment_depth</b>]</summary>
        public const string MetaEnvironmentDepthExtensionName = "XR_META_environment_depth";
        /// <summary>[from: <b>XR_EXT_uuid</b>]</summary>
        public const uint ExtUuidSpecVersion = 1;
        /// <summary>[from: <b>XR_EXT_uuid</b>]</summary>
        public const string ExtUuidExtensionName = "XR_EXT_uuid";
        /// <summary>[from: <b>XR_EXT_uuid</b>]</summary>
        public const uint UuidSizeExt = 16;
        /// <summary>[from: <b>XR_EXT_hand_interaction</b>]</summary>
        public const uint ExtHandInteractionSpecVersion = 1;
        /// <summary>[from: <b>XR_EXT_hand_interaction</b>]</summary>
        public const string ExtHandInteractionExtensionName = "XR_EXT_hand_interaction";
        /// <summary>[from: <b>XR_QCOM_tracking_optimization_settings</b>]</summary>
        public const uint QcomTrackingOptimizationSettingsSpecVersion = 1;
        /// <summary>[from: <b>XR_QCOM_tracking_optimization_settings</b>]</summary>
        public const string QcomTrackingOptimizationSettingsExtensionName = "XR_QCOM_tracking_optimization_settings";
        /// <summary>[from: <b>XR_HTC_passthrough</b>]</summary>
        public const uint HtcPassthroughSpecVersion = 1;
        /// <summary>[from: <b>XR_HTC_passthrough</b>]</summary>
        public const string HtcPassthroughExtensionName = "XR_HTC_passthrough";
        /// <summary>[from: <b>XR_HTC_foveation</b>]</summary>
        public const uint HtcFoveationSpecVersion = 1;
        /// <summary>[from: <b>XR_HTC_foveation</b>]</summary>
        public const string HtcFoveationExtensionName = "XR_HTC_foveation";
        /// <summary>[from: <b>XR_HTC_anchor</b>]</summary>
        public const uint HtcAnchorSpecVersion = 1;
        /// <summary>[from: <b>XR_HTC_anchor</b>]</summary>
        public const string HtcAnchorExtensionName = "XR_HTC_anchor";
        /// <summary>[from: <b>XR_HTC_anchor</b>]</summary>
        public const uint MaxSpatialAnchorNameSizeHtc = 256;
        /// <summary>[from: <b>XR_HTC_body_tracking</b>]</summary>
        public const uint HtcBodyTrackingSpecVersion = 1;
        /// <summary>[from: <b>XR_HTC_body_tracking</b>]</summary>
        public const string HtcBodyTrackingExtensionName = "XR_HTC_body_tracking";
        /// <summary>[from: <b>XR_EXT_active_action_set_priority</b>]</summary>
        public const uint ExtActiveActionSetPrioritySpecVersion = 1;
        /// <summary>[from: <b>XR_EXT_active_action_set_priority</b>]</summary>
        public const string ExtActiveActionSetPriorityExtensionName = "XR_EXT_active_action_set_priority";
        /// <summary>[from: <b>XR_MNDX_force_feedback_curl</b>]</summary>
        public const uint MndxForceFeedbackCurlSpecVersion = 1;
        /// <summary>[from: <b>XR_MNDX_force_feedback_curl</b>]</summary>
        public const string MndxForceFeedbackCurlExtensionName = "XR_MNDX_force_feedback_curl";
        /// <summary>[from: <b>XR_BD_controller_interaction</b>]</summary>
        public const uint BdControllerInteractionSpecVersion = 2;
        /// <summary>[from: <b>XR_BD_controller_interaction</b>]</summary>
        public const string BdControllerInteractionExtensionName = "XR_BD_controller_interaction";
        /// <summary>[from: <b>XR_BD_body_tracking</b>]</summary>
        public const uint BdBodyTrackingSpecVersion = 1;
        /// <summary>[from: <b>XR_BD_body_tracking</b>]</summary>
        public const string BdBodyTrackingExtensionName = "XR_BD_body_tracking";
        /// <summary>[from: <b>XR_EXT_local_floor</b>]</summary>
        public const uint ExtLocalFloorSpecVersion = 1;
        /// <summary>[from: <b>XR_EXT_local_floor</b>]</summary>
        public const string ExtLocalFloorExtensionName = "XR_EXT_local_floor";
        /// <summary>[from: <b>XR_EXT_hand_tracking_data_source</b>]</summary>
        public const uint ExtHandTrackingDataSourceSpecVersion = 1;
        /// <summary>[from: <b>XR_EXT_hand_tracking_data_source</b>]</summary>
        public const string ExtHandTrackingDataSourceExtensionName = "XR_EXT_hand_tracking_data_source";
        /// <summary>[from: <b>XR_EXT_plane_detection</b>]</summary>
        public const uint ExtPlaneDetectionSpecVersion = 2;
        /// <summary>[from: <b>XR_EXT_plane_detection</b>]</summary>
        public const string ExtPlaneDetectionExtensionName = "XR_EXT_plane_detection";
        /// <summary>[from: <b>XR_OPPO_controller_interaction</b>]</summary>
        public const uint OppoControllerInteractionSpecVersion = 1;
        /// <summary>[from: <b>XR_OPPO_controller_interaction</b>]</summary>
        public const string OppoControllerInteractionExtensionName = "XR_OPPO_controller_interaction";
        /// <summary>[from: <b>XR_EXT_future</b>]</summary>
        public const uint ExtFutureSpecVersion = 1;
        /// <summary>[from: <b>XR_EXT_future</b>]</summary>
        public const string ExtFutureExtensionName = "XR_EXT_future";
        /// <summary>[from: <b>XR_EXT_future</b>]</summary>
        public const uint NullFutureExt = 0;
        /// <summary>[from: <b>XR_EXT_user_presence</b>]</summary>
        public const uint ExtUserPresenceSpecVersion = 1;
        /// <summary>[from: <b>XR_EXT_user_presence</b>]</summary>
        public const string ExtUserPresenceExtensionName = "XR_EXT_user_presence";
        /// <summary>[from: <b>XR_KHR_locate_spaces</b>]</summary>
        public const uint KhrLocateSpacesSpecVersion = 1;
        /// <summary>[from: <b>XR_KHR_locate_spaces</b>]</summary>
        public const string KhrLocateSpacesExtensionName = "XR_KHR_locate_spaces";
        /// <summary>[from: <b>XR_ML_system_notifications</b>]</summary>
        public const uint MlSystemNotificationsSpecVersion = 1;
        /// <summary>[from: <b>XR_ML_system_notifications</b>]</summary>
        public const string MlSystemNotificationsExtensionName = "XR_ML_system_notifications";
        /// <summary>[from: <b>XR_ML_world_mesh_detection</b>]</summary>
        public const uint MlWorldMeshDetectionSpecVersion = 1;
        /// <summary>[from: <b>XR_ML_world_mesh_detection</b>]</summary>
        public const string MlWorldMeshDetectionExtensionName = "XR_ML_world_mesh_detection";
        /// <summary>[from: <b>XR_ML_facial_expression</b>]</summary>
        public const uint MlFacialExpressionSpecVersion = 1;
        /// <summary>[from: <b>XR_ML_facial_expression</b>]</summary>
        public const string MlFacialExpressionExtensionName = "XR_ML_facial_expression";
        /// <summary>[from: <b>XR_ML_view_configuration_depth_range_change</b>]</summary>
        public const uint MlViewConfigurationDepthRangeChangeSpecVersion = 1;
        /// <summary>[from: <b>XR_ML_view_configuration_depth_range_change</b>]</summary>
        public const string MlViewConfigurationDepthRangeChangeExtensionName = "XR_ML_view_configuration_depth_range_change";
        /// <summary>[from: <b>XR_YVR_controller_interaction</b>]</summary>
        public const uint YvrControllerInteractionSpecVersion = 1;
        /// <summary>[from: <b>XR_YVR_controller_interaction</b>]</summary>
        public const string YvrControllerInteractionExtensionName = "XR_YVR_controller_interaction";
        /// <summary>[from: <b>XR_EXT_composition_layer_inverted_alpha</b>]</summary>
        public const uint ExtCompositionLayerInvertedAlphaSpecVersion = 1;
        /// <summary>[from: <b>XR_EXT_composition_layer_inverted_alpha</b>]</summary>
        public const string ExtCompositionLayerInvertedAlphaExtensionName = "XR_EXT_composition_layer_inverted_alpha";
        /// <summary>[from: <b>XR_META_colocation_discovery</b>]</summary>
        public const uint MetaColocationDiscoverySpecVersion = 1;
        /// <summary>[from: <b>XR_META_colocation_discovery</b>]</summary>
        public const string MetaColocationDiscoveryExtensionName = "XR_META_colocation_discovery";
        /// <summary>[from: <b>XR_META_colocation_discovery</b>]</summary>
        public const uint MaxColocationDiscoveryBufferSizeMeta = 1024;
        /// <summary>[from: <b>XR_META_spatial_entity_group_sharing</b>]</summary>
        public const uint MetaSpatialEntityGroupSharingSpecVersion = 1;
        /// <summary>[from: <b>XR_META_spatial_entity_group_sharing</b>]</summary>
        public const string MetaSpatialEntityGroupSharingExtensionName = "XR_META_spatial_entity_group_sharing";
        /// <summary>[from: <b>XR_KHR_maintenance1</b>]</summary>
        public const uint KhrMaintenance1SpecVersion = 1;
        /// <summary>[from: <b>XR_KHR_maintenance1</b>]</summary>
        public const string KhrMaintenance1ExtensionName = "XR_KHR_maintenance1";
        /// <summary>[from: <b>XR_LOGITECH_mx_ink_stylus_interaction</b>]</summary>
        public const uint LogitechMxInkStylusInteractionSpecVersion = 1;
        /// <summary>[from: <b>XR_LOGITECH_mx_ink_stylus_interaction</b>]</summary>
        public const string LogitechMxInkStylusInteractionExtensionName = "XR_LOGITECH_mx_ink_stylus_interaction";
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
