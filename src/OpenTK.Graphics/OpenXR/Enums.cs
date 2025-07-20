// This file is auto generated, do not edit.
using System;

namespace OpenTK.Graphics.OpenXR
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary></summary>
    public enum XrActionType : int
    {
        /// <summary></summary>
        ActionTypeBooleanInput = 1,
        /// <summary></summary>
        ActionTypeFloatInput = 2,
        /// <summary></summary>
        ActionTypePoseInput = 4,
        /// <summary></summary>
        ActionTypeVector2fInput = 3,
        /// <summary></summary>
        ActionTypeVibrationOutput = 100,
    }
    /// <summary></summary>
    [Flags]
    public enum XrAndroidSurfaceSwapchainFlagBitsFB : ulong
    {
        /// <summary>Create the underlying BufferQueue in synchronous mode</summary>
        AndroidSurfaceSwapchainSynchronousBitFb = 1,
        /// <summary>Acquire most recent buffer whose presentation timestamp is not greater than display time of final composited frame</summary>
        AndroidSurfaceSwapchainUseTimestampsBitFb = 2,
    }
    /// <summary><b>[requires: XR_KHR_android_thread_settings]</b> Used by <see cref="Xr.SetAndroidApplicationThreadKHR"/></summary>
    public enum XrAndroidThreadTypeKHR : int
    {
        /// <summary>[requires: <b>XR_KHR_android_thread_settings</b>] </summary>
        AndroidThreadTypeApplicationMainKhr = 1,
        /// <summary>[requires: <b>XR_KHR_android_thread_settings</b>] </summary>
        AndroidThreadTypeApplicationWorkerKhr = 2,
        /// <summary>[requires: <b>XR_KHR_android_thread_settings</b>] </summary>
        AndroidThreadTypeRendererMainKhr = 3,
        /// <summary>[requires: <b>XR_KHR_android_thread_settings</b>] </summary>
        AndroidThreadTypeRendererWorkerKhr = 4,
    }
    /// <summary><b>[requires: XR_FB_composition_layer_alpha_blend]</b> </summary>
    public enum XrBlendFactorFB : int
    {
        /// <summary>[requires: <b>XR_FB_composition_layer_alpha_blend</b>] </summary>
        BlendFactorDstAlphaFb = 4,
        /// <summary>[requires: <b>XR_FB_composition_layer_alpha_blend</b>] </summary>
        BlendFactorOneFb = 1,
        /// <summary>[requires: <b>XR_FB_composition_layer_alpha_blend</b>] </summary>
        BlendFactorOneMinusDstAlphaFb = 5,
        /// <summary>[requires: <b>XR_FB_composition_layer_alpha_blend</b>] </summary>
        BlendFactorOneMinusSrcAlphaFb = 3,
        /// <summary>[requires: <b>XR_FB_composition_layer_alpha_blend</b>] </summary>
        BlendFactorSrcAlphaFb = 2,
        /// <summary>[requires: <b>XR_FB_composition_layer_alpha_blend</b>] </summary>
        BlendFactorZeroFb = 0,
    }
    /// <summary><b>[requires: XR_BD_body_tracking]</b> </summary>
    public enum XrBodyJointBD : int
    {
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointHeadBd = 15,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointLeftAnkleBd = 7,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointLeftCollarBd = 13,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointLeftElbowBd = 18,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointLeftFootBd = 10,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointLeftHandBd = 22,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointLeftHipBd = 1,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointLeftKneeBd = 4,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointLeftShoulderBd = 16,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointLeftWristBd = 20,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointNeckBd = 12,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointPelvisBd = 0,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointRightAnkleBd = 8,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointRightCollarBd = 14,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointRightElbowBd = 19,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointRightFootBd = 11,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointRightHandBd = 23,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointRightHipBd = 2,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointRightKneeBd = 5,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointRightShoulderBd = 17,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointRightWristBd = 21,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointSpine1Bd = 3,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointSpine2Bd = 6,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        BodyJointSpine3Bd = 9,
    }
    /// <summary><b>[requires: XR_HTC_body_tracking]</b> </summary>
    public enum XrBodyJointConfidenceHTC : int
    {
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointConfidenceHighHtc = 2,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointConfidenceLowHtc = 1,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointConfidenceNoneHtc = 0,
    }
    /// <summary><b>[requires: XR_FB_body_tracking | XR_FB_body_tracking]</b> </summary>
    public enum XrBodyJointFB : int
    {
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointChestFb = 5,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointCountFb = 70,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointHeadFb = 7,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointHipsFb = 1,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftArmLowerFb = 11,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftArmUpperFb = 10,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandIndexDistalFb = 27,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandIndexIntermediateFb = 26,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandIndexMetacarpalFb = 24,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandIndexProximalFb = 25,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandIndexTipFb = 28,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandLittleDistalFb = 42,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandLittleIntermediateFb = 41,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandLittleMetacarpalFb = 39,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandLittleProximalFb = 40,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandLittleTipFb = 43,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandMiddleDistalFb = 32,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandMiddleIntermediateFb = 31,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandMiddleMetacarpalFb = 29,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandMiddleProximalFb = 30,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandMiddleTipFb = 33,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandPalmFb = 18,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandRingDistalFb = 37,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandRingIntermediateFb = 36,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandRingMetacarpalFb = 34,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandRingProximalFb = 35,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandRingTipFb = 38,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandThumbDistalFb = 22,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandThumbMetacarpalFb = 20,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandThumbProximalFb = 21,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandThumbTipFb = 23,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandWristFb = 19,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftHandWristTwistFb = 12,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftScapulaFb = 9,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointLeftShoulderFb = 8,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointNeckFb = 6,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointNoneFb = -1,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightArmLowerFb = 16,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightArmUpperFb = 15,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandIndexDistalFb = 53,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandIndexIntermediateFb = 52,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandIndexMetacarpalFb = 50,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandIndexProximalFb = 51,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandIndexTipFb = 54,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandLittleDistalFb = 68,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandLittleIntermediateFb = 67,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandLittleMetacarpalFb = 65,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandLittleProximalFb = 66,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandLittleTipFb = 69,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandMiddleDistalFb = 58,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandMiddleIntermediateFb = 57,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandMiddleMetacarpalFb = 55,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandMiddleProximalFb = 56,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandMiddleTipFb = 59,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandPalmFb = 44,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandRingDistalFb = 63,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandRingIntermediateFb = 62,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandRingMetacarpalFb = 60,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandRingProximalFb = 61,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandRingTipFb = 64,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandThumbDistalFb = 48,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandThumbMetacarpalFb = 46,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandThumbProximalFb = 47,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandThumbTipFb = 49,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandWristFb = 45,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightHandWristTwistFb = 17,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightScapulaFb = 14,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRightShoulderFb = 13,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointRootFb = 0,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointSpineLowerFb = 2,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointSpineMiddleFb = 3,
        /// <summary>[requires: <b>XR_FB_body_tracking | XR_FB_body_tracking</b>] </summary>
        BodyJointSpineUpperFb = 4,
    }
    /// <summary><b>[requires: XR_HTC_body_tracking]</b> </summary>
    public enum XrBodyJointHTC : int
    {
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointChestHtc = 13,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointHeadHtc = 15,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointLeftAnkleHtc = 3,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointLeftArmHtc = 18,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointLeftClavicleHtc = 16,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointLeftElbowHtc = 19,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointLeftFeetHtc = 4,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointLeftHipHtc = 1,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointLeftKneeHtc = 2,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointLeftScapulaHtc = 17,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointLeftWristHtc = 20,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointNeckHtc = 14,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointPelvisHtc = 0,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointRightAnkleHtc = 7,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointRightArmHtc = 23,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointRightClavicleHtc = 21,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointRightElbowHtc = 24,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointRightFeetHtc = 8,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointRightHipHtc = 5,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointRightKneeHtc = 6,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointRightScapulaHtc = 22,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointRightWristHtc = 25,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointSpineHighHtc = 12,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointSpineLowerHtc = 10,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointSpineMiddleHtc = 11,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointWaistHtc = 9,
    }
    /// <summary><b>[requires: XR_BD_body_tracking]</b> </summary>
    public enum XrBodyJointSetBD : int
    {
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] Contains joints in elink:XrBodyJointBD in the range ename:XR_BODY_JOINT_PELVIS_BD through ename:XR_BODY_JOINT_HEAD_BD inclusive, a total of dlink:XR_BODY_JOINT_WITHOUT_ARM_COUNT_BD joints.</summary>
        BodyJointSetBodyWithoutArmBd = 1,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] Contains joints in elink:XrBodyJointBD in the range ename:XR_BODY_JOINT_PELVIS_BD through ename:XR_BODY_JOINT_RIGHT_HAND_BD inclusive, a total of dlink:XR_BODY_JOINT_COUNT_BD joints.</summary>
        BodyJointSetFullBodyJointsBd = 2,
    }
    /// <summary><b>[requires: XR_FB_body_tracking]</b> </summary>
    public enum XrBodyJointSetFB : int
    {
        /// <summary>[requires: <b>XR_FB_body_tracking</b>] Indicates that the created slink:XrBodyTrackerFB tracks the set of body joints described by elink:XrBodyJointFB enum, i.e. the flink:xrLocateBodyJointsFB function returns an array of joint locations with the count of ename:XR_BODY_JOINT_COUNT_FB and can be indexed using elink:XrBodyJointFB.</summary>
        BodyJointSetDefaultFb = 0,
    }
    /// <summary><b>[requires: XR_HTC_body_tracking]</b> </summary>
    public enum XrBodyJointSetHTC : int
    {
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        BodyJointSetFullHtc = 0,
    }
    /// <summary><b>[requires: XR_FB_color_space]</b> Used by <see cref="Xr.EnumerateColorSpacesFB"/>, <see cref="Xr.SetColorSpaceFB"/></summary>
    public enum XrColorSpaceFB : int
    {
        /// <summary>[requires: <b>XR_FB_color_space</b>] </summary>
        ColorSpaceAdobeRgbFb = 7,
        /// <summary>[requires: <b>XR_FB_color_space</b>] </summary>
        ColorSpaceP3Fb = 6,
        /// <summary>[requires: <b>XR_FB_color_space</b>] </summary>
        ColorSpaceQuestFb = 5,
        /// <summary>[requires: <b>XR_FB_color_space</b>] </summary>
        ColorSpaceRec2020Fb = 1,
        /// <summary>[requires: <b>XR_FB_color_space</b>] </summary>
        ColorSpaceRec709Fb = 2,
        /// <summary>[requires: <b>XR_FB_color_space</b>] </summary>
        ColorSpaceRiftCv1Fb = 3,
        /// <summary>[requires: <b>XR_FB_color_space</b>] </summary>
        ColorSpaceRiftSFb = 4,
        /// <summary>[requires: <b>XR_FB_color_space</b>] </summary>
        ColorSpaceUnmanagedFb = 0,
    }
    /// <summary><b>[requires: XR_FB_composition_layer_depth_test]</b> </summary>
    public enum XrCompareOpFB : int
    {
        /// <summary>[requires: <b>XR_FB_composition_layer_depth_test</b>] Comparison is always true.</summary>
        CompareOpAlwaysFb = 7,
        /// <summary>[requires: <b>XR_FB_composition_layer_depth_test</b>] Comparison is true if source is equal to destination.</summary>
        CompareOpEqualFb = 2,
        /// <summary>[requires: <b>XR_FB_composition_layer_depth_test</b>] Comparison is true if source is greater than destination.</summary>
        CompareOpGreaterFb = 4,
        /// <summary>[requires: <b>XR_FB_composition_layer_depth_test</b>] Comparison is true if source is greater than or equal to destination.</summary>
        CompareOpGreaterOrEqualFb = 6,
        /// <summary>[requires: <b>XR_FB_composition_layer_depth_test</b>] Comparison is true if source less than is destination.</summary>
        CompareOpLessFb = 1,
        /// <summary>[requires: <b>XR_FB_composition_layer_depth_test</b>] Comparison is true if source is less than or equal to destination.</summary>
        CompareOpLessOrEqualFb = 3,
        /// <summary>[requires: <b>XR_FB_composition_layer_depth_test</b>] Comparison is never true.</summary>
        CompareOpNeverFb = 0,
        /// <summary>[requires: <b>XR_FB_composition_layer_depth_test</b>] Comparison is true if source is not equal to destination.</summary>
        CompareOpNotEqualFb = 5,
    }
    /// <summary></summary>
    [Flags]
    public enum XrCompositionLayerFlagBits : ulong
    {
        /// <summary>Enables the layer texture alpha channel.</summary>
        CompositionLayerBlendTextureSourceAlphaBit = 2,
        /// <summary>Enables chromatic aberration correction when not done by default. This flag has no effect on any known conformant runtime, and is officially deprecated in OpenXR 1.1.</summary>
        CompositionLayerCorrectChromaticAberrationBit = 1,
        /// <summary>[requires: <b>XR_EXT_composition_layer_inverted_alpha</b>] Indicates that the texture alpha channel stores transparency instead of opacity, and is to be inverted before layer blending.</summary>
        CompositionLayerInvertedAlphaBitExt = 8,
        /// <summary>Indicates the texture color channels have not been premultiplied by the texture alpha channel.</summary>
        CompositionLayerUnpremultipliedAlphaBit = 4,
    }
    /// <summary></summary>
    [Flags]
    public enum XrCompositionLayerImageLayoutFlagBitsFB : ulong
    {
        /// <summary>The coordinate origin of the swapchain image must be considered to be flipped vertically.</summary>
        CompositionLayerImageLayoutVerticalFlipBitFb = 1,
    }
    /// <summary></summary>
    [Flags]
    public enum XrCompositionLayerSecureContentFlagBitsFB : ulong
    {
        /// <summary>Indicates the layer will only be visible inside the HMD, and not visible to external sources</summary>
        CompositionLayerSecureContentExcludeLayerBitFb = 1,
        /// <summary>Indicates the layer will be displayed inside the HMD, but replaced by proxy content when written to external sources</summary>
        CompositionLayerSecureContentReplaceLayerBitFb = 2,
    }
    /// <summary></summary>
    [Flags]
    public enum XrCompositionLayerSettingsFlagBitsFB : ulong
    {
        /// <summary>[requires: <b>XR_META_automatic_layer_filter</b>] Indicates compositor may: automatically toggle a texture filtering mechanism to improve visual quality of layer. This must: not be the only bit set. (Added by apiext:XR_META_automatic_layer_filter)</summary>
        CompositionLayerSettingsAutoLayerFilterBitMeta = 32,
        /// <summary>Indicates compositor may: use layer texture sharpening.</summary>
        CompositionLayerSettingsNormalSharpeningBitFb = 4,
        /// <summary>Indicates compositor may: use layer texture supersampling.</summary>
        CompositionLayerSettingsNormalSuperSamplingBitFb = 1,
        /// <summary>Indicates compositor may: use high quality layer texture sharpening.</summary>
        CompositionLayerSettingsQualitySharpeningBitFb = 8,
        /// <summary>Indicates compositor may: use high quality layer texture supersampling.</summary>
        CompositionLayerSettingsQualitySuperSamplingBitFb = 2,
    }
    /// <summary></summary>
    [Flags]
    public enum XrCompositionLayerSpaceWarpInfoFlagBitsFB : ulong
    {
        /// <summary>Skip current frame&apos;s space warp extrapolation</summary>
        CompositionLayerSpaceWarpInfoFrameSkipBitFb = 1,
    }
    /// <summary>Used by <see cref="Xr.SubmitDebugUtilsMessageEXT"/></summary>
    [Flags]
    public enum XrDebugUtilsMessageSeverityFlagBitsEXT : ulong
    {
        /// <summary>Indicates that the item is definitely related to erroneous behavior.</summary>
        DebugUtilsMessageSeverityErrorBitExt = 4096,
        /// <summary>General info message</summary>
        DebugUtilsMessageSeverityInfoBitExt = 16,
        /// <summary>Most verbose output severity, typically used for debugging.</summary>
        DebugUtilsMessageSeverityVerboseBitExt = 1,
        /// <summary>Indicates the item may be the cause of issues.</summary>
        DebugUtilsMessageSeverityWarningBitExt = 256,
    }
    /// <summary>Used by <see cref="Xr.SubmitDebugUtilsMessageEXT"/></summary>
    [Flags]
    public enum XrDebugUtilsMessageTypeFlagBitsEXT : ulong
    {
        /// <summary>Indicates the message is related to a non-conformant runtime result</summary>
        DebugUtilsMessageTypeConformanceBitExt = 8,
        /// <summary>Indicates this is a general message</summary>
        DebugUtilsMessageTypeGeneralBitExt = 1,
        /// <summary>Indicates the message is related to a potential performance situation</summary>
        DebugUtilsMessageTypePerformanceBitExt = 4,
        /// <summary>Indicates the message is related to a validation message</summary>
        DebugUtilsMessageTypeValidationBitExt = 2,
    }
    /// <summary></summary>
    [Flags]
    public enum XrDigitalLensControlFlagBitsALMALENCE : ulong
    {
        /// <summary>disables Digital Lens processing of render textures</summary>
        DigitalLensControlProcessingDisableBitAlmalence = 1,
    }
    /// <summary>Used by <see cref="Xr.EnumerateEnvironmentBlendModes"/></summary>
    public enum XrEnvironmentBlendMode : int
    {
        /// <summary></summary>
        EnvironmentBlendModeAdditive = 2,
        /// <summary></summary>
        EnvironmentBlendModeAlphaBlend = 3,
        /// <summary></summary>
        EnvironmentBlendModeOpaque = 1,
    }
    /// <summary><b>[requires: XR_META_environment_depth]</b> </summary>
    [Flags]
    public enum XrEnvironmentDepthProviderCreateFlagBitsMETA : ulong
    {
    }
    /// <summary><b>[requires: XR_META_environment_depth]</b> </summary>
    [Flags]
    public enum XrEnvironmentDepthSwapchainCreateFlagBitsMETA : ulong
    {
    }
    /// <summary><b>[requires: XR_OCULUS_external_camera]</b> </summary>
    public enum XrExternalCameraAttachedToDeviceOCULUS : int
    {
        /// <summary>[requires: <b>XR_OCULUS_external_camera</b>] External camera is attached to the HMD</summary>
        ExternalCameraAttachedToDeviceHmdOculus = 1,
        /// <summary>[requires: <b>XR_OCULUS_external_camera</b>] External camera is attached to a left Touch controller</summary>
        ExternalCameraAttachedToDeviceLtouchOculus = 2,
        /// <summary>[requires: <b>XR_OCULUS_external_camera</b>] External camera is at a fixed point in LOCAL space</summary>
        ExternalCameraAttachedToDeviceNoneOculus = 0,
        /// <summary>[requires: <b>XR_OCULUS_external_camera</b>] External camera is attached to a right Touch controller</summary>
        ExternalCameraAttachedToDeviceRtouchOculus = 3,
    }
    /// <summary></summary>
    [Flags]
    public enum XrExternalCameraStatusFlagBitsOCULUS : ulong
    {
        /// <summary>External camera has tried and passed calibration</summary>
        ExternalCameraStatusCalibratedBitOculus = 8,
        /// <summary>External camera is undergoing calibration</summary>
        ExternalCameraStatusCalibratingBitOculus = 2,
        /// <summary>External camera has tried and failed calibration</summary>
        ExternalCameraStatusCalibrationFailedBitOculus = 4,
        /// <summary>External camera is capturing</summary>
        ExternalCameraStatusCapturingBitOculus = 16,
        /// <summary>External camera is connected</summary>
        ExternalCameraStatusConnectedBitOculus = 1,
    }
    /// <summary><b>[requires: XR_ML_user_calibration]</b> </summary>
    public enum XrEyeCalibrationStatusML : int
    {
        /// <summary>[requires: <b>XR_ML_user_calibration</b>] Eye calibration is of lower accuracy.</summary>
        EyeCalibrationStatusCoarseMl = 2,
        /// <summary>[requires: <b>XR_ML_user_calibration</b>] Eye calibration is of higher accuracy.</summary>
        EyeCalibrationStatusFineMl = 3,
        /// <summary>[requires: <b>XR_ML_user_calibration</b>] User has not performed the eye calibration step. Use system provided app to perform eye calibration.</summary>
        EyeCalibrationStatusNoneMl = 1,
        /// <summary>[requires: <b>XR_ML_user_calibration</b>] Eye calibration status not available for unknown reason.</summary>
        EyeCalibrationStatusUnknownMl = 0,
    }
    /// <summary><b>[requires: XR_HTC_facial_tracking]</b> </summary>
    public enum XrEyeExpressionHTC : int
    {
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        EyeExpressionLeftBlinkHtc = 0,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        EyeExpressionLeftDownHtc = 6,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        EyeExpressionLeftInHtc = 10,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        EyeExpressionLeftOutHtc = 8,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        EyeExpressionLeftSqueezeHtc = 4,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        EyeExpressionLeftUpHtc = 12,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        EyeExpressionLeftWideHtc = 1,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        EyeExpressionRightBlinkHtc = 2,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        EyeExpressionRightDownHtc = 7,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        EyeExpressionRightInHtc = 9,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        EyeExpressionRightOutHtc = 11,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        EyeExpressionRightSqueezeHtc = 5,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        EyeExpressionRightUpHtc = 13,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        EyeExpressionRightWideHtc = 3,
    }
    /// <summary><b>[requires: XR_FB_eye_tracking_social]</b> </summary>
    public enum XrEyePositionFB : int
    {
        /// <summary>[requires: <b>XR_FB_eye_tracking_social</b>] </summary>
        EyePositionCountFb = 2,
        /// <summary>[requires: <b>XR_FB_eye_tracking_social</b>] Specifies the position of the left eye.</summary>
        EyePositionLeftFb = 0,
        /// <summary>[requires: <b>XR_FB_eye_tracking_social</b>] Specifies the position of the right eye.</summary>
        EyePositionRightFb = 1,
    }
    /// <summary></summary>
    public enum XrEyeVisibility : int
    {
        /// <summary>Display in both eyes.</summary>
        EyeVisibilityBoth = 0,
        /// <summary>Display in the left eye only.</summary>
        EyeVisibilityLeft = 1,
        /// <summary>Display in the right eye only.</summary>
        EyeVisibilityRight = 2,
    }
    /// <summary><b>[requires: XR_FB_face_tracking2]</b> </summary>
    public enum XrFaceConfidence2FB : int
    {
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceConfidence2CountFb = 2,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceConfidence2LowerFaceFb = 0,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceConfidence2UpperFaceFb = 1,
    }
    /// <summary><b>[requires: XR_FB_face_tracking]</b> </summary>
    public enum XrFaceConfidenceFB : int
    {
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceConfidenceCountFb = 2,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceConfidenceLowerFaceFb = 0,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceConfidenceUpperFaceFb = 1,
    }
    /// <summary><b>[requires: XR_FB_face_tracking2]</b> </summary>
    public enum XrFaceExpression2FB : int
    {
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2BrowLowererLFb = 0,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2BrowLowererRFb = 1,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2CheekPuffLFb = 2,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2CheekPuffRFb = 3,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2CheekRaiserLFb = 4,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2CheekRaiserRFb = 5,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2CheekSuckLFb = 6,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2CheekSuckRFb = 7,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2ChinRaiserBFb = 8,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2ChinRaiserTFb = 9,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2CountFb = 70,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2DimplerLFb = 10,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2DimplerRFb = 11,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2EyesClosedLFb = 12,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2EyesClosedRFb = 13,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2EyesLookDownLFb = 14,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2EyesLookDownRFb = 15,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2EyesLookLeftLFb = 16,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2EyesLookLeftRFb = 17,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2EyesLookRightLFb = 18,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2EyesLookRightRFb = 19,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2EyesLookUpLFb = 20,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2EyesLookUpRFb = 21,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2InnerBrowRaiserLFb = 22,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2InnerBrowRaiserRFb = 23,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2JawDropFb = 24,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2JawSidewaysLeftFb = 25,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2JawSidewaysRightFb = 26,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2JawThrustFb = 27,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LidTightenerLFb = 28,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LidTightenerRFb = 29,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipCornerDepressorLFb = 30,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipCornerDepressorRFb = 31,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipCornerPullerLFb = 32,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipCornerPullerRFb = 33,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipFunnelerLbFb = 34,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipFunnelerLtFb = 35,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipFunnelerRbFb = 36,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipFunnelerRtFb = 37,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipPressorLFb = 38,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipPressorRFb = 39,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipPuckerLFb = 40,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipPuckerRFb = 41,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipStretcherLFb = 42,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipStretcherRFb = 43,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipSuckLbFb = 44,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipSuckLtFb = 45,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipSuckRbFb = 46,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipSuckRtFb = 47,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipTightenerLFb = 48,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipTightenerRFb = 49,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LipsTowardFb = 50,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LowerLipDepressorLFb = 51,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2LowerLipDepressorRFb = 52,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2MouthLeftFb = 53,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2MouthRightFb = 54,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2NoseWrinklerLFb = 55,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2NoseWrinklerRFb = 56,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2OuterBrowRaiserLFb = 57,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2OuterBrowRaiserRFb = 58,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2TongueBackDorsalVelarFb = 67,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2TongueFrontDorsalPalateFb = 65,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2TongueMidDorsalPalateFb = 66,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2TongueOutFb = 68,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2TongueRetreatFb = 69,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2TongueTipAlveolarFb = 64,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2TongueTipInterdentalFb = 63,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2UpperLidRaiserLFb = 59,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2UpperLidRaiserRFb = 60,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2UpperLipRaiserLFb = 61,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        FaceExpression2UpperLipRaiserRFb = 62,
    }
    /// <summary><b>[requires: XR_FB_face_tracking]</b> </summary>
    public enum XrFaceExpressionFB : int
    {
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionBrowLowererLFb = 0,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionBrowLowererRFb = 1,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionCheekPuffLFb = 2,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionCheekPuffRFb = 3,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionCheekRaiserLFb = 4,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionCheekRaiserRFb = 5,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionCheekSuckLFb = 6,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionCheekSuckRFb = 7,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionChinRaiserBFb = 8,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionChinRaiserTFb = 9,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionCountFb = 63,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionDimplerLFb = 10,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionDimplerRFb = 11,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionEyesClosedLFb = 12,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionEyesClosedRFb = 13,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionEyesLookDownLFb = 14,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionEyesLookDownRFb = 15,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionEyesLookLeftLFb = 16,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionEyesLookLeftRFb = 17,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionEyesLookRightLFb = 18,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionEyesLookRightRFb = 19,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionEyesLookUpLFb = 20,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionEyesLookUpRFb = 21,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionInnerBrowRaiserLFb = 22,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionInnerBrowRaiserRFb = 23,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionJawDropFb = 24,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionJawSidewaysLeftFb = 25,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionJawSidewaysRightFb = 26,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionJawThrustFb = 27,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLidTightenerLFb = 28,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLidTightenerRFb = 29,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipCornerDepressorLFb = 30,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipCornerDepressorRFb = 31,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipCornerPullerLFb = 32,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipCornerPullerRFb = 33,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipFunnelerLbFb = 34,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipFunnelerLtFb = 35,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipFunnelerRbFb = 36,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipFunnelerRtFb = 37,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipPressorLFb = 38,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipPressorRFb = 39,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipPuckerLFb = 40,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipPuckerRFb = 41,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipStretcherLFb = 42,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipStretcherRFb = 43,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipSuckLbFb = 44,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipSuckLtFb = 45,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipSuckRbFb = 46,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipSuckRtFb = 47,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipTightenerLFb = 48,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipTightenerRFb = 49,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLipsTowardFb = 50,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLowerLipDepressorLFb = 51,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionLowerLipDepressorRFb = 52,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionMouthLeftFb = 53,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionMouthRightFb = 54,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionNoseWrinklerLFb = 55,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionNoseWrinklerRFb = 56,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionOuterBrowRaiserLFb = 57,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionOuterBrowRaiserRFb = 58,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionUpperLidRaiserLFb = 59,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionUpperLidRaiserRFb = 60,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionUpperLipRaiserLFb = 61,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        FaceExpressionUpperLipRaiserRFb = 62,
    }
    /// <summary><b>[requires: XR_FB_face_tracking2]</b> </summary>
    public enum XrFaceExpressionSet2FB : int
    {
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] indicates that the created slink:XrFaceTracker2FB tracks the set of blend shapes described by elink:XrFaceExpression2FB enum, i.e. the flink:xrGetFaceExpressionWeights2FB function returns an array of blend shapes with the count of ename:XR_FACE_EXPRESSION2_COUNT_FB and can: be indexed using elink:XrFaceExpression2FB.</summary>
        FaceExpressionSet2DefaultFb = 0,
    }
    /// <summary><b>[requires: XR_FB_face_tracking]</b> </summary>
    public enum XrFaceExpressionSetFB : int
    {
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] indicates that the created slink:XrFaceTrackerFB tracks the set of blend shapes described by elink:XrFaceExpressionFB enum, i.e. the flink:xrGetFaceExpressionWeightsFB function returns an array of blend shapes with the count of ename:XR_FACE_EXPRESSION_COUNT_FB and can: be indexed using elink:XrFaceExpressionFB.</summary>
        FaceExpressionSetDefaultFb = 0,
    }
    /// <summary><b>[requires: XR_FB_face_tracking2]</b> </summary>
    public enum XrFaceTrackingDataSource2FB : int
    {
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] face tracking uses audio data to estimate expressions.</summary>
        FaceTrackingDataSource2AudioFb = 1,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] face tracking uses visual data to estimate expressions. Face tracking may use audio to further improve the quality of face tracking.</summary>
        FaceTrackingDataSource2VisualFb = 0,
    }
    /// <summary><b>[requires: XR_ML_facial_expression]</b> </summary>
    public enum XrFacialBlendShapeML : int
    {
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeBrowLowererLMl = 0,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeBrowLowererRMl = 1,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeCheekRaiserLMl = 2,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeCheekRaiserRMl = 3,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeChinRaiserMl = 4,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeDimplerLMl = 5,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeDimplerRMl = 6,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeEyesClosedLMl = 7,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeEyesClosedRMl = 8,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeInnerBrowRaiserLMl = 9,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeInnerBrowRaiserRMl = 10,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeJawDropMl = 11,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLidTightenerLMl = 12,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLidTightenerRMl = 13,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipCornerDepressorLMl = 14,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipCornerDepressorRMl = 15,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipCornerPullerLMl = 16,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipCornerPullerRMl = 17,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipFunnelerLbMl = 18,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipFunnelerLtMl = 19,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipFunnelerRbMl = 20,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipFunnelerRtMl = 21,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipPressorLMl = 22,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipPressorRMl = 23,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipPuckerLMl = 24,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipPuckerRMl = 25,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipStretcherLMl = 26,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipStretcherRMl = 27,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipSuckLbMl = 28,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipSuckLtMl = 29,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipSuckRbMl = 30,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipSuckRtMl = 31,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipTightenerLMl = 32,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipTightenerRMl = 33,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLipsTowardMl = 34,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLowerLipDepressorLMl = 35,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeLowerLipDepressorRMl = 36,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeNoseWrinklerLMl = 37,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeNoseWrinklerRMl = 38,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeOuterBrowRaiserLMl = 39,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeOuterBrowRaiserRMl = 40,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeTongueOutMl = 45,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeUpperLidRaiserLMl = 41,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeUpperLidRaiserRMl = 42,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeUpperLipRaiserLMl = 43,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        FacialBlendShapeUpperLipRaiserRMl = 44,
    }
    /// <summary></summary>
    [Flags]
    public enum XrFacialExpressionBlendShapePropertiesFlagBitsML : ulong
    {
        /// <summary>Indicates whether the blend shape is being tracked by the runtime.</summary>
        FacialExpressionBlendShapePropertiesTrackedBitMl = 2,
        /// <summary>Indicates whether the blend shape is valid.</summary>
        FacialExpressionBlendShapePropertiesValidBitMl = 1,
    }
    /// <summary><b>[requires: XR_HTC_facial_tracking]</b> </summary>
    public enum XrFacialTrackingTypeHTC : int
    {
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] Specifies this handle will observe eye expressions, with values indexed by elink:XrEyeExpressionHTC whose count is dlink:XR_FACIAL_EXPRESSION_EYE_COUNT_HTC.</summary>
        FacialTrackingTypeEyeDefaultHtc = 1,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] Specifies this handle will observe lip expressions, with values indexed by elink:XrLipExpressionHTC whose count is dlink:XR_FACIAL_EXPRESSION_LIP_COUNT_HTC.</summary>
        FacialTrackingTypeLipDefaultHtc = 2,
    }
    /// <summary><b>[requires: XR_MNDX_force_feedback_curl]</b> </summary>
    public enum XrForceFeedbackCurlLocationMNDX : int
    {
        /// <summary>[requires: <b>XR_MNDX_force_feedback_curl</b>] force feedback for index finger curl</summary>
        ForceFeedbackCurlLocationIndexCurlMndx = 1,
        /// <summary>[requires: <b>XR_MNDX_force_feedback_curl</b>] force feedback for little finger curl</summary>
        ForceFeedbackCurlLocationLittleCurlMndx = 4,
        /// <summary>[requires: <b>XR_MNDX_force_feedback_curl</b>] force feedback for middle finger curl</summary>
        ForceFeedbackCurlLocationMiddleCurlMndx = 2,
        /// <summary>[requires: <b>XR_MNDX_force_feedback_curl</b>] force feedback for ring finger curl</summary>
        ForceFeedbackCurlLocationRingCurlMndx = 3,
        /// <summary>[requires: <b>XR_MNDX_force_feedback_curl</b>] force feedback for thumb curl</summary>
        ForceFeedbackCurlLocationThumbCurlMndx = 0,
    }
    /// <summary></summary>
    public enum XrFormFactor : int
    {
        /// <summary></summary>
        FormFactorHandheldDisplay = 2,
        /// <summary></summary>
        FormFactorHeadMountedDisplay = 1,
    }
    /// <summary><b>[requires: XR_FB_foveation_configuration]</b> </summary>
    public enum XrFoveationDynamicFB : int
    {
        /// <summary>[requires: <b>XR_FB_foveation_configuration</b>] Static foveation at the maximum desired level</summary>
        FoveationDynamicDisabledFb = 0,
        /// <summary>[requires: <b>XR_FB_foveation_configuration</b>] Dynamic changing foveation based on performance headroom available up to the maximum desired level</summary>
        FoveationDynamicLevelEnabledFb = 1,
    }
    /// <summary></summary>
    [Flags]
    public enum XrFoveationDynamicFlagBitsHTC : ulong
    {
        /// <summary>Allow system to set clear FOV degree dynamically.</summary>
        FoveationDynamicClearFovEnabledBitHtc = 2,
        /// <summary>Allow system to set focal center offset dynamically.</summary>
        FoveationDynamicFocalCenterOffsetEnabledBitHtc = 4,
        /// <summary>Allow system to set periphery pixel density dynamically.</summary>
        FoveationDynamicLevelEnabledBitHtc = 1,
    }
    /// <summary><b>[requires: XR_META_foveation_eye_tracked]</b> </summary>
    [Flags]
    public enum XrFoveationEyeTrackedProfileCreateFlagBitsMETA : ulong
    {
    }
    /// <summary><b>[requires: XR_META_foveation_eye_tracked]</b> </summary>
    [Flags]
    public enum XrFoveationEyeTrackedStateFlagBitsMETA : ulong
    {
        /// <summary>[requires: <b>XR_META_foveation_eye_tracked</b>] Indicates whether or not foveation data is valid. This can happen if the eye tracker is obscured, the camera has dirt, or eye lid is closed, etc.</summary>
        FoveationEyeTrackedStateValidBitMeta = 1,
    }
    /// <summary><b>[requires: XR_FB_foveation_configuration]</b> </summary>
    public enum XrFoveationLevelFB : int
    {
        /// <summary>[requires: <b>XR_FB_foveation_configuration</b>] High foveation (lower periphery visual fidelity, higher performance)</summary>
        FoveationLevelHighFb = 3,
        /// <summary>[requires: <b>XR_FB_foveation_configuration</b>] Less foveation (higher periphery visual fidelity, lower performance)</summary>
        FoveationLevelLowFb = 1,
        /// <summary>[requires: <b>XR_FB_foveation_configuration</b>] Medium foveation (medium periphery visual fidelity, medium performance)</summary>
        FoveationLevelMediumFb = 2,
        /// <summary>[requires: <b>XR_FB_foveation_configuration</b>] No foveation</summary>
        FoveationLevelNoneFb = 0,
    }
    /// <summary><b>[requires: XR_HTC_foveation]</b> </summary>
    public enum XrFoveationLevelHTC : int
    {
        /// <summary>[requires: <b>XR_HTC_foveation</b>] Heavy periphery pixel density drop and higher performance gain</summary>
        FoveationLevelHighHtc = 3,
        /// <summary>[requires: <b>XR_HTC_foveation</b>] Light periphery pixel density drop and lower performance gain.</summary>
        FoveationLevelLowHtc = 1,
        /// <summary>[requires: <b>XR_HTC_foveation</b>] Medium periphery pixel density drop and medium performance gain</summary>
        FoveationLevelMediumHtc = 2,
        /// <summary>[requires: <b>XR_HTC_foveation</b>] No foveation</summary>
        FoveationLevelNoneHtc = 0,
    }
    /// <summary><b>[requires: XR_HTC_foveation]</b> </summary>
    public enum XrFoveationModeHTC : int
    {
        /// <summary>[requires: <b>XR_HTC_foveation</b>] Allow application to set foveation with desired clear FOV, periphery quality, and focal center offset.</summary>
        FoveationModeCustomHtc = 3,
        /// <summary>[requires: <b>XR_HTC_foveation</b>] No foveation</summary>
        FoveationModeDisableHtc = 0,
        /// <summary>[requires: <b>XR_HTC_foveation</b>] Allow system to set foveation dynamically according realtime system metric or other extensions.</summary>
        FoveationModeDynamicHtc = 2,
        /// <summary>[requires: <b>XR_HTC_foveation</b>] Apply system default setting with fixed clear FOV and periphery quality.</summary>
        FoveationModeFixedHtc = 1,
    }
    /// <summary></summary>
    [Flags]
    public enum XrFrameEndInfoFlagBitsML : ulong
    {
        /// <summary>Indicates that the content for this frame is protected and should not be recorded or captured outside the graphics system.</summary>
        FrameEndInfoProtectedBitMl = 1,
        /// <summary>Indicates that a soft fade to transparent should be added to the frame in the compositor to blend any hard edges at the FOV limits.</summary>
        FrameEndInfoVignetteBitMl = 2,
    }
    /// <summary></summary>
    [Flags]
    public enum XrFrameSynthesisInfoFlagBitsEXT : ulong
    {
        /// <summary>Request the runtime to relax the application&apos;s frame interval to allow additional render time</summary>
        FrameSynthesisInfoRequestRelaxedFrameIntervalBitExt = 2,
        /// <summary>2D motion vector will be used</summary>
        FrameSynthesisInfoUse2dMotionVectorBitExt = 1,
    }
    /// <summary><b>[requires: XR_EXT_future]</b> </summary>
    public enum XrFutureStateEXT : int
    {
        /// <summary>[requires: <b>XR_EXT_future</b>] </summary>
        FutureStatePendingExt = 1,
        /// <summary>[requires: <b>XR_EXT_future</b>] </summary>
        FutureStateReadyExt = 2,
    }
    /// <summary></summary>
    [Flags]
    public enum XrGlobalDimmerFrameEndInfoFlagBitsML : ulong
    {
        /// <summary>Indicates that the global dimmer should: be enabled and controlled by slink:XrGlobalDimmerFrameEndInfoML::pname:dimmerValue.</summary>
        GlobalDimmerFrameEndInfoEnabledBitMl = 1,
    }
    /// <summary><b>[requires: XR_EXT_hand_tracking]</b> </summary>
    public enum XrHandEXT : int
    {
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandLeftExt = 1,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandRightExt = 2,
    }
    /// <summary><b>[requires: XR_ULTRALEAP_hand_tracking_forearm]</b> </summary>
    public enum XrHandForearmJointULTRALEAP : int
    {
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointElbowUltraleap = 26,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointIndexDistalUltraleap = 9,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointIndexIntermediateUltraleap = 8,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointIndexMetacarpalUltraleap = 6,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointIndexProximalUltraleap = 7,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointIndexTipUltraleap = 10,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointLittleDistalUltraleap = 24,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointLittleIntermediateUltraleap = 23,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointLittleMetacarpalUltraleap = 21,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointLittleProximalUltraleap = 22,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointLittleTipUltraleap = 25,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointMiddleDistalUltraleap = 14,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointMiddleIntermediateUltraleap = 13,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointMiddleMetacarpalUltraleap = 11,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointMiddleProximalUltraleap = 12,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointMiddleTipUltraleap = 15,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointPalmUltraleap = 0,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointRingDistalUltraleap = 19,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointRingIntermediateUltraleap = 18,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointRingMetacarpalUltraleap = 16,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointRingProximalUltraleap = 17,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointRingTipUltraleap = 20,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointThumbDistalUltraleap = 4,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointThumbMetacarpalUltraleap = 2,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointThumbProximalUltraleap = 3,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointThumbTipUltraleap = 5,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandForearmJointWristUltraleap = 1,
    }
    /// <summary><b>[requires: XR_EXT_hand_tracking]</b> </summary>
    public enum XrHandJointEXT : int
    {
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointIndexDistalExt = 9,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointIndexIntermediateExt = 8,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointIndexMetacarpalExt = 6,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointIndexProximalExt = 7,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointIndexTipExt = 10,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointLittleDistalExt = 24,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointLittleIntermediateExt = 23,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointLittleMetacarpalExt = 21,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointLittleProximalExt = 22,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointLittleTipExt = 25,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointMiddleDistalExt = 14,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointMiddleIntermediateExt = 13,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointMiddleMetacarpalExt = 11,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointMiddleProximalExt = 12,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointMiddleTipExt = 15,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointPalmExt = 0,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointRingDistalExt = 19,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointRingIntermediateExt = 18,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointRingMetacarpalExt = 16,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointRingProximalExt = 17,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointRingTipExt = 20,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointThumbDistalExt = 4,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointThumbMetacarpalExt = 2,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointThumbProximalExt = 3,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointThumbTipExt = 5,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointWristExt = 1,
    }
    /// <summary><b>[requires: XR_EXT_hand_tracking]</b> </summary>
    public enum XrHandJointSetEXT : int
    {
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        HandJointSetDefaultExt = 0,
        /// <summary>[requires: <b>XR_ULTRALEAP_hand_tracking_forearm</b>] </summary>
        HandJointSetHandWithForearmUltraleap = 1000149000,
    }
    /// <summary><b>[requires: XR_EXT_hand_joints_motion_range]</b> </summary>
    public enum XrHandJointsMotionRangeEXT : int
    {
        /// <summary>[requires: <b>XR_EXT_hand_joints_motion_range</b>] </summary>
        HandJointsMotionRangeConformingToControllerExt = 2,
        /// <summary>[requires: <b>XR_EXT_hand_joints_motion_range</b>] </summary>
        HandJointsMotionRangeUnobstructedExt = 1,
    }
    /// <summary><b>[requires: XR_MSFT_hand_tracking_mesh]</b> </summary>
    public enum XrHandPoseTypeMSFT : int
    {
        /// <summary>[requires: <b>XR_MSFT_hand_tracking_mesh</b>] </summary>
        HandPoseTypeReferenceOpenPalmMsft = 1,
        /// <summary>[requires: <b>XR_MSFT_hand_tracking_mesh</b>] </summary>
        HandPoseTypeTrackedMsft = 0,
    }
    /// <summary></summary>
    [Flags]
    public enum XrHandTrackingAimFlagBitsFB : ulong
    {
        /// <summary>Aiming data is computed from additional sources beyond the hand data in the base structure</summary>
        HandTrackingAimComputedBitFb = 1,
        /// <summary>Hand is currently marked as dominant for the system</summary>
        HandTrackingAimDominantHandBitFb = 128,
        /// <summary>Index finger pinch discrete signal</summary>
        HandTrackingAimIndexPinchingBitFb = 4,
        /// <summary>Little finger pinch discrete signal</summary>
        HandTrackingAimLittlePinchingBitFb = 32,
        /// <summary>System menu gesture is active</summary>
        HandTrackingAimMenuPressedBitFb = 256,
        /// <summary>Middle finger pinch discrete signal</summary>
        HandTrackingAimMiddlePinchingBitFb = 8,
        /// <summary>Ring finger pinch discrete signal</summary>
        HandTrackingAimRingPinchingBitFb = 16,
        /// <summary>System gesture is active</summary>
        HandTrackingAimSystemGestureBitFb = 64,
        /// <summary>Aiming data is valid</summary>
        HandTrackingAimValidBitFb = 2,
    }
    /// <summary><b>[requires: XR_EXT_hand_tracking_data_source]</b> </summary>
    public enum XrHandTrackingDataSourceEXT : int
    {
        /// <summary>[requires: <b>XR_EXT_hand_tracking_data_source</b>] This data source value indicates hand joints are inferred based on motion controller state.</summary>
        HandTrackingDataSourceControllerExt = 2,
        /// <summary>[requires: <b>XR_EXT_hand_tracking_data_source</b>] This data source value indicates individual fingers and joints are tracked from unobstructed data source such as optical hand tracking, data gloves, or motion capture devices.</summary>
        HandTrackingDataSourceUnobstructedExt = 1,
    }
    /// <summary><b>[requires: XR_ML_user_calibration]</b> </summary>
    public enum XrHeadsetFitStatusML : int
    {
        /// <summary>[requires: <b>XR_ML_user_calibration</b>] Bad fit.</summary>
        HeadsetFitStatusBadFitMl = 3,
        /// <summary>[requires: <b>XR_ML_user_calibration</b>] Good fit.</summary>
        HeadsetFitStatusGoodFitMl = 2,
        /// <summary>[requires: <b>XR_ML_user_calibration</b>] Headset not worn.</summary>
        HeadsetFitStatusNotWornMl = 1,
        /// <summary>[requires: <b>XR_ML_user_calibration</b>] Headset fit status not available for unknown reason.</summary>
        HeadsetFitStatusUnknownMl = 0,
    }
    /// <summary></summary>
    [Flags]
    public enum XrInputSourceLocalizedNameFlagBits : ulong
    {
        /// <summary>Asks for the part of the string which represents the component on the device which needs to be interacted with</summary>
        InputSourceLocalizedNameComponentBit = 4,
        /// <summary>Asks for the part of the string which represents the interaction profile of the source</summary>
        InputSourceLocalizedNameInteractionProfileBit = 2,
        /// <summary>Asks for the part of the string which indicates the top level user path the source represents</summary>
        InputSourceLocalizedNameUserPathBit = 1,
    }
    /// <summary></summary>
    [Flags]
    public enum XrInstanceCreateFlagBits : ulong
    {
    }
    /// <summary></summary>
    [Flags]
    public enum XrKeyboardTrackingFlagBitsFB : ulong
    {
        /// <summary>indicates that the physically tracked keyboard is actively connected to the headset and capable of sending key data</summary>
        KeyboardTrackingConnectedBitFb = 8,
        /// <summary>indicates that the system has a physically tracked keyboard to report.  If not set then no other bits should be considered to be valid or meaningful.  If set either XR_KEYBOARD_TRACKING_LOCAL_BIT_FB or XR_KEYBOARD_TRACKING_REMOTE_BIT_FB must also be set.</summary>
        KeyboardTrackingExistsBitFb = 1,
        /// <summary>indicates that the physically tracked keyboard is intended to be used in a local pairing with the system.  Mutually exclusive with XR_KEYBOARD_TRACKING_REMOTE_BIT_FB.</summary>
        KeyboardTrackingLocalBitFb = 2,
        /// <summary>indicates that the physically tracked keyboard is intended to be used while paired to a separate remote computing device. Mutually exclusive with XR_KEYBOARD_TRACKING_LOCAL_BIT_FB.</summary>
        KeyboardTrackingRemoteBitFb = 4,
    }
    /// <summary></summary>
    [Flags]
    public enum XrKeyboardTrackingQueryFlagBitsFB : ulong
    {
        /// <summary>indicates the query is for the physically tracked keyboard that is intended to be used in a local pairing with the System. Mutually exclusive with XR_KEYBOARD_TRACKING_QUERY_REMOTE_BIT_FB.</summary>
        KeyboardTrackingQueryLocalBitFb = 2,
        /// <summary>indicates the query is for the physically tracked keyboard that may be connected to a separate remote computing device. Mutually exclusive with XR_KEYBOARD_TRACKING_QUERY_LOCAL_BIT_FB.</summary>
        KeyboardTrackingQueryRemoteBitFb = 4,
    }
    /// <summary><b>[requires: XR_HTC_facial_tracking]</b> </summary>
    public enum XrLipExpressionHTC : int
    {
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionCheekPuffLeftHtc = 17,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionCheekPuffRightHtc = 16,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionCheekSuckHtc = 18,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionJawForwardHtc = 2,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionJawLeftHtc = 1,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionJawOpenHtc = 3,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionJawRightHtc = 0,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthApeShapeHtc = 4,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthLowerDownleftHtc = 22,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthLowerDownrightHtc = 21,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthLowerInsideHtc = 24,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthLowerLeftHtc = 8,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthLowerOverlayHtc = 25,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthLowerOverturnHtc = 10,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthLowerRightHtc = 7,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthPoutHtc = 11,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthRaiserLeftHtc = 13,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthRaiserRightHtc = 12,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] Backward-compatibility alias for deprecated name.</summary>
        LipExpressionMouthSadLeftHtc = 15,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] Backward-compatibility alias for deprecated name.</summary>
        LipExpressionMouthSadRightHtc = 14,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] Backward-compatibility alias for deprecated name.</summary>
        LipExpressionMouthSmileLeftHtc = 13,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] Backward-compatibility alias for deprecated name.</summary>
        LipExpressionMouthSmileRightHtc = 12,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthStretcherLeftHtc = 15,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthStretcherRightHtc = 14,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthUpperInsideHtc = 23,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthUpperLeftHtc = 6,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthUpperOverturnHtc = 9,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthUpperRightHtc = 5,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthUpperUpleftHtc = 20,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionMouthUpperUprightHtc = 19,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionTongueDownHtc = 30,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionTongueDownleftMorphHtc = 36,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionTongueDownrightMorphHtc = 35,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionTongueLeftHtc = 27,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionTongueLongstep1Htc = 26,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionTongueLongstep2Htc = 32,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionTongueRightHtc = 28,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionTongueRollHtc = 31,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionTongueUpHtc = 29,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionTongueUpleftMorphHtc = 34,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        LipExpressionTongueUprightMorphHtc = 33,
    }
    /// <summary></summary>
    public enum XrLoaderInterfaceStructs : int
    {
        /// <summary></summary>
        LoaderInterfaceStructApiLayerCreateInfo = 4,
        /// <summary></summary>
        LoaderInterfaceStructApiLayerNextInfo = 5,
        /// <summary></summary>
        LoaderInterfaceStructApiLayerRequest = 2,
        /// <summary></summary>
        LoaderInterfaceStructLoaderInfo = 1,
        /// <summary></summary>
        LoaderInterfaceStructRuntimeRequest = 3,
        /// <summary></summary>
        LoaderInterfaceStructUnintialized = 0,
    }
    /// <summary><b>[requires: XR_META_local_dimming]</b> </summary>
    public enum XrLocalDimmingModeMETA : int
    {
        /// <summary>[requires: <b>XR_META_local_dimming</b>] Local dimming is turned off by default for the current submitted frame. This is the same as not chaining elink:XrLocalDimmingModeMETA.</summary>
        LocalDimmingModeOffMeta = 0,
        /// <summary>[requires: <b>XR_META_local_dimming</b>] Local dimming is turned on for the current submitted frame.</summary>
        LocalDimmingModeOnMeta = 1,
    }
    /// <summary><b>[requires: XR_ML_localization_map]</b> </summary>
    public enum XrLocalizationMapConfidenceML : int
    {
        /// <summary>[requires: <b>XR_ML_localization_map</b>] This is a very high-confidence localization, persistent content will be very stable.</summary>
        LocalizationMapConfidenceExcellentMl = 3,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] The confidence is fair, current environmental conditions may adversely affect localization.</summary>
        LocalizationMapConfidenceFairMl = 1,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] The confidence is high, persistent content should be stable.</summary>
        LocalizationMapConfidenceGoodMl = 2,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] The localization map has poor confidence, systems relying on the localization map are likely to have poor performance.</summary>
        LocalizationMapConfidencePoorMl = 0,
    }
    /// <summary><b>[requires: XR_ML_localization_map]</b> </summary>
    [Flags]
    public enum XrLocalizationMapErrorFlagBitsML : ulong
    {
        /// <summary>[requires: <b>XR_ML_localization_map</b>] Localization failed due to excessive motion.</summary>
        LocalizationMapErrorExcessiveMotionBitMl = 8,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] A headpose failure caused localization to be unsuccessful.</summary>
        LocalizationMapErrorHeadposeBitMl = 32,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] There are not enough features in the environment to successfully localize.</summary>
        LocalizationMapErrorLowFeatureCountBitMl = 4,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] Localization failed because the lighting levels are too low in the environment.</summary>
        LocalizationMapErrorLowLightBitMl = 16,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] Localization failed because the user is outside of the mapped area.</summary>
        LocalizationMapErrorOutOfMappedAreaBitMl = 2,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] Localization failed for an unknown reason.</summary>
        LocalizationMapErrorUnknownBitMl = 1,
    }
    /// <summary><b>[requires: XR_ML_localization_map]</b> </summary>
    public enum XrLocalizationMapStateML : int
    {
        /// <summary>[requires: <b>XR_ML_localization_map</b>] The system is localizing into a map.</summary>
        LocalizationMapStateLocalizationPendingMl = 2,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] Initial localization failed, the system will retry localization.</summary>
        LocalizationMapStateLocalizationSleepingBeforeRetryMl = 3,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] The system is localized into a map.</summary>
        LocalizationMapStateLocalizedMl = 1,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] The system is not localized into a map. Features like Spatial Anchors relying on localization will not work.</summary>
        LocalizationMapStateNotLocalizedMl = 0,
    }
    /// <summary><b>[requires: XR_ML_localization_map]</b> </summary>
    public enum XrLocalizationMapTypeML : int
    {
        /// <summary>[requires: <b>XR_ML_localization_map</b>] The system is localized into a Cloud Map, anchors are shared per cloud account settings.</summary>
        LocalizationMapTypeCloudMl = 1,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] The system is localized into an On-Device map, published anchors are not shared between different devices.</summary>
        LocalizationMapTypeOnDeviceMl = 0,
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
    public enum XrMarkerAprilTagDictML : int
    {
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 4 by 4 bits, minimum Hamming distance between any two codes = 5, 30 codes.</summary>
        MarkerAprilTagDict16h5Ml = 0,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 5 by 5 bits, minimum Hamming distance between any two codes = 9, 35 codes.</summary>
        MarkerAprilTagDict25h9Ml = 1,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 6 by 6 bits, minimum Hamming distance between any two codes = 10, 2320 codes.</summary>
        MarkerAprilTagDict36h10Ml = 2,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 6 by 6 bits, minimum Hamming distance between any two codes = 11, 587 codes.</summary>
        MarkerAprilTagDict36h11Ml = 3,
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
    public enum XrMarkerArucoDictML : int
    {
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 4 by 4 pixel Aruco marker dictionary with 100 IDs.</summary>
        MarkerArucoDict4x4100Ml = 1,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 4 by 4 pixel Aruco marker dictionary with 1000 IDs.</summary>
        MarkerArucoDict4x41000Ml = 3,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 4 by 4 pixel Aruco marker dictionary with 250 IDs.</summary>
        MarkerArucoDict4x4250Ml = 2,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 4 by 4 pixel Aruco marker dictionary with 50 IDs.</summary>
        MarkerArucoDict4x450Ml = 0,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 5 by 5 pixel Aruco marker dictionary with 100 IDs.</summary>
        MarkerArucoDict5x5100Ml = 5,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 5 by 5 pixel Aruco marker dictionary with 1000 IDs.</summary>
        MarkerArucoDict5x51000Ml = 7,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 5 by 5 pixel Aruco marker dictionary with 250 IDs.</summary>
        MarkerArucoDict5x5250Ml = 6,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 5 by 5 pixel Aruco marker dictionary with 50 IDs.</summary>
        MarkerArucoDict5x550Ml = 4,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 6 by 6 pixel Aruco marker dictionary with 100 IDs.</summary>
        MarkerArucoDict6x6100Ml = 9,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 6 by 6 pixel Aruco marker dictionary with 1000 IDs.</summary>
        MarkerArucoDict6x61000Ml = 11,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 6 by 6 pixel Aruco marker dictionary with 250 IDs.</summary>
        MarkerArucoDict6x6250Ml = 10,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 6 by 6 pixel Aruco marker dictionary with 50 IDs.</summary>
        MarkerArucoDict6x650Ml = 8,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 7 by 7 pixel Aruco marker dictionary with 100 IDs.</summary>
        MarkerArucoDict7x7100Ml = 13,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 7 by 7 pixel Aruco marker dictionary with 1000 IDs.</summary>
        MarkerArucoDict7x71000Ml = 15,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 7 by 7 pixel Aruco marker dictionary with 250 IDs.</summary>
        MarkerArucoDict7x7250Ml = 14,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] 7 by 7 pixel Aruco marker dictionary with 50 IDs.</summary>
        MarkerArucoDict7x750Ml = 12,
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
    public enum XrMarkerDetectorCameraML : int
    {
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Single RGB camera.</summary>
        MarkerDetectorCameraRgbCameraMl = 0,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] One or more world cameras.</summary>
        MarkerDetectorCameraWorldCamerasMl = 1,
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
    public enum XrMarkerDetectorCornerRefineMethodML : int
    {
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] AprilTag refinement. Reasonable detection rate, slowest, but very accurate. Only valid with AprilTags.</summary>
        MarkerDetectorCornerRefineMethodAprilTagMl = 3,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Contour refinement. High detection rate, fast, reasonable accuracy.</summary>
        MarkerDetectorCornerRefineMethodContourMl = 2,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] No refinement. Inaccurate corners.</summary>
        MarkerDetectorCornerRefineMethodNoneMl = 0,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Subpixel refinement. Corners have subpixel coordinates. High detection rate, very fast, reasonable accuracy.</summary>
        MarkerDetectorCornerRefineMethodSubpixMl = 1,
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
    public enum XrMarkerDetectorFpsML : int
    {
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] High FPS.</summary>
        MarkerDetectorFpsHighMl = 2,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Low FPS.</summary>
        MarkerDetectorFpsLowMl = 0,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Max possible FPS.</summary>
        MarkerDetectorFpsMaxMl = 3,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Medium FPS.</summary>
        MarkerDetectorFpsMediumMl = 1,
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
    public enum XrMarkerDetectorFullAnalysisIntervalML : int
    {
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Detector analyzes frame fully very often.</summary>
        MarkerDetectorFullAnalysisIntervalFastMl = 1,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Detector analyzes every frame fully.</summary>
        MarkerDetectorFullAnalysisIntervalMaxMl = 0,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Detector analyzes frame fully a few times per second.</summary>
        MarkerDetectorFullAnalysisIntervalMediumMl = 2,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Detector analyzes frame fully about every second.</summary>
        MarkerDetectorFullAnalysisIntervalSlowMl = 3,
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
    public enum XrMarkerDetectorProfileML : int
    {
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Optimized for accuracy. Use this profile to optimize for accurate marker poses. This can cause increased load on the compute.</summary>
        MarkerDetectorProfileAccuracyMl = 2,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Custom Tracker Profile. The application can define a custom tracker profile. See slink:XrMarkerDetectorCustomProfileInfoML for more details.</summary>
        MarkerDetectorProfileCustomMl = 5,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Tracker profile that covers standard use cases. If this does not suite the needs of the application try the other profiles listed below.</summary>
        MarkerDetectorProfileDefaultMl = 0,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Optimized for FoV. Use this profile to be able to detect markers across a larger FoV. The marker tracker system will attempt to use multiple cameras to detect the markers.</summary>
        MarkerDetectorProfileLargeFovMl = 4,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Optimized for small targets. Use this profile to optimize for markers that are small or for larger markers that need to be detected from afar.</summary>
        MarkerDetectorProfileSmallTargetsMl = 3,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Optimized for speed. Use this profile to reduce the compute load and increase detection/tracker speed. This can result in low accuracy poses.</summary>
        MarkerDetectorProfileSpeedMl = 1,
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
    public enum XrMarkerDetectorResolutionML : int
    {
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] High Resolution.</summary>
        MarkerDetectorResolutionHighMl = 2,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Low Resolution.</summary>
        MarkerDetectorResolutionLowMl = 0,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Medium Resolution.</summary>
        MarkerDetectorResolutionMediumMl = 1,
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
    public enum XrMarkerDetectorStatusML : int
    {
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] The marker detector has encountered a fatal error.</summary>
        MarkerDetectorStatusErrorMl = 2,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] The marker detector is working on a new snapshot.</summary>
        MarkerDetectorStatusPendingMl = 0,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] The marker detector is ready to be inspected.</summary>
        MarkerDetectorStatusReadyMl = 1,
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
    public enum XrMarkerTypeML : int
    {
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] AprilTag detection and localization. The marker id of the AprilTags is available via flink:xrGetMarkerNumberML.</summary>
        MarkerTypeAprilTagMl = 1,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Aruco Marker detection and localization. The marker id of the Aruco marker is available via flink:xrGetMarkerNumberML.</summary>
        MarkerTypeArucoMl = 0,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] Code 128, detection only, not locatable. The contents of the barcode is available via flink:xrGetMarkerStringML.</summary>
        MarkerTypeCode128Ml = 5,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] EAN-13, detection only, not locatable. The contents of the barcode is available via flink:xrGetMarkerStringML.</summary>
        MarkerTypeEan13Ml = 3,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] QR code detection and localization. The contents of the QR code is available via flink:xrGetMarkerStringML.</summary>
        MarkerTypeQrMl = 2,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] UPC-A, detection only, not locatable. The contents of the barcode is available via flink:xrGetMarkerStringML.</summary>
        MarkerTypeUpcAMl = 4,
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public enum XrMeshComputeLodMSFT : int
    {
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        MeshComputeLodCoarseMsft = 1,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        MeshComputeLodFineMsft = 3,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        MeshComputeLodMediumMsft = 2,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        MeshComputeLodUnlimitedMsft = 4,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    public enum XrObjectType : int
    {
        /// <summary>[requires: <b>v1.0</b>] XrAction</summary>
        ObjectTypeAction = 6,
        /// <summary>[requires: <b>v1.0</b>] XrActionSet</summary>
        ObjectTypeActionSet = 5,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] XrBodyTrackerBD</summary>
        ObjectTypeBodyTrackerBd = 1000385000,
        /// <summary>[requires: <b>XR_FB_body_tracking</b>] XrBodyTrackerFB</summary>
        ObjectTypeBodyTrackerFb = 1000076000,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] XrBodyTrackerHTC</summary>
        ObjectTypeBodyTrackerHtc = 1000320000,
        /// <summary>[requires: <b>XR_EXT_debug_utils</b>] XrDebugUtilsMessengerEXT</summary>
        ObjectTypeDebugUtilsMessengerExt = 1000019000,
        /// <summary>[requires: <b>XR_META_environment_depth</b>] XrEnvironmentDepthProviderMETA</summary>
        ObjectTypeEnvironmentDepthProviderMeta = 1000291000,
        /// <summary>[requires: <b>XR_META_environment_depth</b>] XrEnvironmentDepthSwapchainMETA</summary>
        ObjectTypeEnvironmentDepthSwapchainMeta = 1000291001,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] XrExportedLocalizationMapML</summary>
        ObjectTypeExportedLocalizationMapMl = 1000139000,
        /// <summary>[requires: <b>XR_FB_eye_tracking_social</b>] XrEyeTrackerFB</summary>
        ObjectTypeEyeTrackerFb = 1000202000,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] XrFaceTrackerFB</summary>
        ObjectTypeFaceTrackerFb = 1000201000,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] XrFaceTracker2FB</summary>
        ObjectTypeFaceTracker2Fb = 1000287012,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] XrFacialExpressionClientML</summary>
        ObjectTypeFacialExpressionClientMl = 1000482000,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] XrFacialTrackerHTC</summary>
        ObjectTypeFacialTrackerHtc = 1000104000,
        /// <summary>[requires: <b>XR_FB_foveation</b>] XrFoveationProfileFB</summary>
        ObjectTypeFoveationProfileFb = 1000114000,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] XrGeometryInstanceFB</summary>
        ObjectTypeGeometryInstanceFb = 1000118004,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] XrHandTrackerEXT</summary>
        ObjectTypeHandTrackerExt = 1000051000,
        /// <summary>[requires: <b>v1.0</b>] XrInstance</summary>
        ObjectTypeInstance = 1,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] XrMarkerDetectorML</summary>
        ObjectTypeMarkerDetectorMl = 1000138000,
        /// <summary>[requires: <b>XR_META_passthrough_color_lut</b>] XrPassthroughColorLutMETA</summary>
        ObjectTypePassthroughColorLutMeta = 1000266000,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] XrPassthroughFB</summary>
        ObjectTypePassthroughFb = 1000118000,
        /// <summary>[requires: <b>XR_HTC_passthrough</b>] XrPassthroughHTC</summary>
        ObjectTypePassthroughHtc = 1000317000,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] XrPassthroughLayerFB</summary>
        ObjectTypePassthroughLayerFb = 1000118002,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] XrPlaneDetectorEXT</summary>
        ObjectTypePlaneDetectorExt = 1000429000,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] XrSceneMSFT</summary>
        ObjectTypeSceneMsft = 1000097001,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] XrSceneObserverMSFT</summary>
        ObjectTypeSceneObserverMsft = 1000097000,
        /// <summary>[requires: <b>v1.0</b>] XrSession</summary>
        ObjectTypeSession = 2,
        /// <summary>[requires: <b>v1.0</b>] XrSpace</summary>
        ObjectTypeSpace = 4,
        /// <summary>[requires: <b>XR_FB_spatial_entity_user</b>] XrSpaceUserFB</summary>
        ObjectTypeSpaceUserFb = 1000241000,
        /// <summary>[requires: <b>XR_MSFT_spatial_anchor</b>] XrSpatialAnchorMSFT</summary>
        ObjectTypeSpatialAnchorMsft = 1000039000,
        /// <summary>[requires: <b>XR_MSFT_spatial_anchor_persistence</b>] XrSpatialAnchorStoreConnectionMSFT</summary>
        ObjectTypeSpatialAnchorStoreConnectionMsft = 1000142000,
        /// <summary>[requires: <b>XR_ML_spatial_anchors_storage</b>] XrSpatialAnchorsStorageML</summary>
        ObjectTypeSpatialAnchorsStorageMl = 1000141000,
        /// <summary>[requires: <b>XR_MSFT_spatial_graph_bridge</b>] XrSpatialGraphNodeBindingMSFT</summary>
        ObjectTypeSpatialGraphNodeBindingMsft = 1000049000,
        /// <summary>[requires: <b>v1.0</b>] XrSwapchain</summary>
        ObjectTypeSwapchain = 3,
        /// <summary>[requires: <b>XR_FB_triangle_mesh</b>] XrTriangleMeshFB</summary>
        ObjectTypeTriangleMeshFb = 1000117000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeUnknown = 0,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] XrVirtualKeyboardMETA</summary>
        ObjectTypeVirtualKeyboardMeta = 1000219000,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] XrWorldMeshDetectorML</summary>
        ObjectTypeWorldMeshDetectorMl = 1000474000,
    }
    /// <summary></summary>
    [Flags]
    public enum XrOverlayMainSessionFlagBitsEXTX : ulong
    {
        /// <summary>Indicates the main session enabled `XR_KHR_composition_layer_depth`</summary>
        OverlayMainSessionEnabledCompositionLayerInfoDepthBitExtx = 1,
    }
    /// <summary></summary>
    [Flags]
    public enum XrOverlaySessionCreateFlagBitsEXTX : ulong
    {
    }
    /// <summary></summary>
    [Flags]
    public enum XrPassthroughCapabilityFlagBitsFB : ulong
    {
        /// <summary>The system supports passthrough.</summary>
        PassthroughCapabilityBitFb = 1,
        /// <summary>The system can show passthrough with realistic colors. ename:XR_PASSTHROUGH_CAPABILITY_BIT_FB must: be set if ename:XR_PASSTHROUGH_CAPABILITY_COLOR_BIT_FB is set.</summary>
        PassthroughCapabilityColorBitFb = 2,
        /// <summary>The system supports passthrough layers composited using depth testing. ename:XR_PASSTHROUGH_CAPABILITY_BIT_FB must: be set if ename:XR_PASSTHROUGH_CAPABILITY_LAYER_DEPTH_BIT_FB is set.</summary>
        PassthroughCapabilityLayerDepthBitFb = 4,
    }
    /// <summary></summary>
    public enum XrPassthroughColorLutChannelsMETA : int
    {
        /// <summary></summary>
        PassthroughColorLutChannelsRgbMeta = 1,
        /// <summary></summary>
        PassthroughColorLutChannelsRgbaMeta = 2,
    }
    /// <summary></summary>
    [Flags]
    public enum XrPassthroughFlagBitsFB : ulong
    {
        /// <summary>The object (passthrough, layer) is running at creation.</summary>
        PassthroughIsRunningAtCreationBitFb = 1,
        /// <summary>The passthrough system sends depth information to the compositor. Only applicable to layer objects.</summary>
        PassthroughLayerDepthBitFb = 2,
    }
    /// <summary><b>[requires: XR_HTC_passthrough]</b> </summary>
    public enum XrPassthroughFormHTC : int
    {
        /// <summary>[requires: <b>XR_HTC_passthrough</b>] Presents the passthrough with full of the entire screen.</summary>
        PassthroughFormPlanarHtc = 0,
        /// <summary>[requires: <b>XR_HTC_passthrough</b>] Presents the passthrough projecting onto a custom mesh.</summary>
        PassthroughFormProjectedHtc = 1,
    }
    /// <summary></summary>
    public enum XrPassthroughLayerPurposeFB : int
    {
        /// <summary>Projected passthrough (using a custom surface)</summary>
        PassthroughLayerPurposeProjectedFb = 1,
        /// <summary>Reconstruction passthrough (full screen environment)</summary>
        PassthroughLayerPurposeReconstructionFb = 0,
        /// <summary>[requires: <b>XR_FB_passthrough_keyboard_hands</b>] Passthrough layer purpose for keyboard hands presence.</summary>
        PassthroughLayerPurposeTrackedKeyboardHandsFb = 1000203001,
        /// <summary>[requires: <b>XR_FB_passthrough_keyboard_hands</b>] Passthrough layer purpose for keyboard hands presence with keyboard masked hand transitions (i.e passthrough hands rendered only when they are over the keyboard).</summary>
        PassthroughLayerPurposeTrackedKeyboardMaskedHandsFb = 1000203002,
    }
    /// <summary><b>[requires: XR_META_passthrough_preferences]</b> </summary>
    [Flags]
    public enum XrPassthroughPreferenceFlagBitsMETA : ulong
    {
        /// <summary>[requires: <b>XR_META_passthrough_preferences</b>] Indicates that the runtime recommends apps to default to a mixed reality experience with passthrough (if supported).</summary>
        PassthroughPreferenceDefaultToActiveBitMeta = 1,
    }
    /// <summary></summary>
    [Flags]
    public enum XrPassthroughStateChangedFlagBitsFB : ulong
    {
        /// <summary>Non-recoverable error has occurred. A device reboot or a firmware update may be required.</summary>
        PassthroughStateChangedNonRecoverableErrorBitFb = 2,
        /// <summary>A recoverable error has occurred. The runtime will attempt to recover, but some functionality may be temporarily unavailable.</summary>
        PassthroughStateChangedRecoverableErrorBitFb = 4,
        /// <summary>Passthrough system requires reinitialization.</summary>
        PassthroughStateChangedReinitRequiredBitFb = 1,
        /// <summary>The runtime has recovered from a previous error and is functioning normally.</summary>
        PassthroughStateChangedRestoredErrorBitFb = 8,
    }
    /// <summary></summary>
    [Flags]
    public enum XrPerformanceMetricsCounterFlagBitsMETA : ulong
    {
        /// <summary>Indicates any of the values in XrPerformanceMetricsCounterMETA is valid.</summary>
        PerformanceMetricsCounterAnyValueValidBitMeta = 1,
        /// <summary>Indicates the floatValue in XrPerformanceMetricsCounterMETA is valid.</summary>
        PerformanceMetricsCounterFloatValueValidBitMeta = 4,
        /// <summary>Indicates the uintValue in XrPerformanceMetricsCounterMETA is valid.</summary>
        PerformanceMetricsCounterUintValueValidBitMeta = 2,
    }
    /// <summary><b>[requires: XR_META_performance_metrics]</b> </summary>
    public enum XrPerformanceMetricsCounterUnitMETA : int
    {
        /// <summary>[requires: <b>XR_META_performance_metrics</b>] the performance counter unit is byte.</summary>
        PerformanceMetricsCounterUnitBytesMeta = 3,
        /// <summary>[requires: <b>XR_META_performance_metrics</b>] the performance counter unit is generic (unspecified).</summary>
        PerformanceMetricsCounterUnitGenericMeta = 0,
        /// <summary>[requires: <b>XR_META_performance_metrics</b>] the performance counter unit is hertz (Hz).</summary>
        PerformanceMetricsCounterUnitHertzMeta = 4,
        /// <summary>[requires: <b>XR_META_performance_metrics</b>] the performance counter unit is millisecond.</summary>
        PerformanceMetricsCounterUnitMillisecondsMeta = 2,
        /// <summary>[requires: <b>XR_META_performance_metrics</b>] the performance counter unit is percentage (%).</summary>
        PerformanceMetricsCounterUnitPercentageMeta = 1,
    }
    /// <summary><b>[requires: XR_EXT_performance_settings | XR_EXT_thermal_query]</b> Used by <see cref="Xr.PerfSettingsSetPerformanceLevelEXT"/>, <see cref="Xr.ThermalGetTemperatureTrendEXT"/></summary>
    public enum XrPerfSettingsDomainEXT : int
    {
        /// <summary>[requires: <b>XR_EXT_performance_settings | XR_EXT_thermal_query</b>] Indicates that the performance settings or notification applies to CPU domain</summary>
        PerfSettingsDomainCpuExt = 1,
        /// <summary>[requires: <b>XR_EXT_performance_settings | XR_EXT_thermal_query</b>] Indicates that the performance settings or notification applies to GPU domain</summary>
        PerfSettingsDomainGpuExt = 2,
    }
    /// <summary><b>[requires: XR_EXT_performance_settings]</b> Used by <see cref="Xr.PerfSettingsSetPerformanceLevelEXT"/></summary>
    public enum XrPerfSettingsLevelEXT : int
    {
        /// <summary>[requires: <b>XR_EXT_performance_settings</b>] Performance settings hint used by the application to indicate that the application enters a section with very high complexity, during which the XR Runtime is allowed to step up beyond the thermally sustainable range</summary>
        PerfSettingsLevelBoostExt = 75,
        /// <summary>[requires: <b>XR_EXT_performance_settings</b>] Performance settings hint used by the application to indicate that it enters a non-XR section (head-locked / static screen), during which power savings are to be prioritized</summary>
        PerfSettingsLevelPowerSavingsExt = 0,
        /// <summary>[requires: <b>XR_EXT_performance_settings</b>] Performance settings hint used by the application to indicate that it enters a high or dynamic complexity section, during which the XR Runtime strives for consistent XR compositing and frame rendering within a thermally sustainable range</summary>
        PerfSettingsLevelSustainedHighExt = 50,
        /// <summary>[requires: <b>XR_EXT_performance_settings</b>] Performance settings hint used by the application to indicate that it enters a low and stable complexity section, during which reducing power is more important than occasional late rendering frames</summary>
        PerfSettingsLevelSustainedLowExt = 25,
    }
    /// <summary><b>[requires: XR_EXT_performance_settings | XR_EXT_thermal_query]</b> Used by <see cref="Xr.ThermalGetTemperatureTrendEXT"/></summary>
    public enum XrPerfSettingsNotificationLevelEXT : int
    {
        /// <summary>[requires: <b>XR_EXT_performance_settings | XR_EXT_thermal_query</b>] Notifies that the sub-domain has reached a critical level with significant performance degradation. The application should take drastic mitigation action</summary>
        PerfSettingsNotifLevelImpairedExt = 75,
        /// <summary>[requires: <b>XR_EXT_performance_settings | XR_EXT_thermal_query</b>] Notifies that the sub-domain has reached a level where no further actions other than currently applied are necessary</summary>
        PerfSettingsNotifLevelNormalExt = 0,
        /// <summary>[requires: <b>XR_EXT_performance_settings | XR_EXT_thermal_query</b>] Notifies that the sub-domain has reached an early warning level where the application should start proactive mitigation actions with the goal to return to the ename:XR_PERF_NOTIF_LEVEL_NORMAL level</summary>
        PerfSettingsNotifLevelWarningExt = 25,
    }
    /// <summary><b>[requires: XR_EXT_performance_settings]</b> </summary>
    public enum XrPerfSettingsSubDomainEXT : int
    {
        /// <summary>[requires: <b>XR_EXT_performance_settings</b>] Indicates that the performance notification originates from the COMPOSITING sub-domain</summary>
        PerfSettingsSubDomainCompositingExt = 1,
        /// <summary>[requires: <b>XR_EXT_performance_settings</b>] Indicates that the performance notification originates from the RENDERING sub-domain</summary>
        PerfSettingsSubDomainRenderingExt = 2,
        /// <summary>[requires: <b>XR_EXT_performance_settings</b>] Indicates that the performance notification originates from the THERMAL sub-domain</summary>
        PerfSettingsSubDomainThermalExt = 3,
    }
    /// <summary></summary>
    [Flags]
    public enum XrPlaneDetectionCapabilityFlagBitsEXT : ulong
    {
        /// <summary>plane detection supports plane orientation classification. If not supported planes are always classified as ARBITRARY.</summary>
        PlaneDetectionCapabilityOrientationBitExt = 64,
        /// <summary>plane detection is supported</summary>
        PlaneDetectionCapabilityPlaneDetectionBitExt = 1,
        /// <summary>polygon buffers for holes in planes can be generated</summary>
        PlaneDetectionCapabilityPlaneHolesBitExt = 2,
        /// <summary>plane detection supports ceiling semantic classification</summary>
        PlaneDetectionCapabilitySemanticCeilingBitExt = 4,
        /// <summary>plane detection supports floor semantic classification</summary>
        PlaneDetectionCapabilitySemanticFloorBitExt = 8,
        /// <summary>plane detection supports platform semantic classification (for example table tops)</summary>
        PlaneDetectionCapabilitySemanticPlatformBitExt = 32,
        /// <summary>plane detection supports wall semantic classification</summary>
        PlaneDetectionCapabilitySemanticWallBitExt = 16,
    }
    /// <summary><b>[requires: XR_EXT_plane_detection]</b> Used by <see cref="Xr.GetPlaneDetectionStateEXT"/></summary>
    public enum XrPlaneDetectionStateEXT : int
    {
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] </summary>
        PlaneDetectionStateDoneExt = 2,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] </summary>
        PlaneDetectionStateErrorExt = 3,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] </summary>
        PlaneDetectionStateFatalExt = 4,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] </summary>
        PlaneDetectionStateNoneExt = 0,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] </summary>
        PlaneDetectionStatePendingExt = 1,
    }
    /// <summary></summary>
    [Flags]
    public enum XrPlaneDetectorFlagBitsEXT : ulong
    {
        /// <summary>populate the plane contour information</summary>
        PlaneDetectorEnableContourBitExt = 1,
    }
    /// <summary><b>[requires: XR_EXT_plane_detection]</b> </summary>
    public enum XrPlaneDetectorOrientationEXT : int
    {
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] The detected plane has an arbitrary, non-vertical and non-horizontal orientation.</summary>
        PlaneDetectorOrientationArbitraryExt = 3,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] The detected plane is horizontal and faces downward (e.g. ceiling).</summary>
        PlaneDetectorOrientationHorizontalDownwardExt = 1,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] The detected plane is horizontal and faces upward (e.g. floor).</summary>
        PlaneDetectorOrientationHorizontalUpwardExt = 0,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] The detected plane is vertical (e.g. wall).</summary>
        PlaneDetectorOrientationVerticalExt = 2,
    }
    /// <summary><b>[requires: XR_EXT_plane_detection]</b> </summary>
    public enum XrPlaneDetectorSemanticTypeEXT : int
    {
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] The detected plane is a ceiling.</summary>
        PlaneDetectorSemanticTypeCeilingExt = 1,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] The detected plane is a floor.</summary>
        PlaneDetectorSemanticTypeFloorExt = 2,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] The detected plane is a platform, like a table.</summary>
        PlaneDetectorSemanticTypePlatformExt = 4,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] The runtime was unable to classify this plane.</summary>
        PlaneDetectorSemanticTypeUndefinedExt = 0,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] The detected plane is a wall.</summary>
        PlaneDetectorSemanticTypeWallExt = 3,
    }
    /// <summary>Used by <see cref="Xr.EnumerateReferenceSpaces"/>, <see cref="Xr.GetReferenceSpaceBoundsRect"/></summary>
    public enum XrReferenceSpaceType : int
    {
        /// <summary>[requires: <b>XR_VARJO_foveated_rendering</b>] </summary>
        ReferenceSpaceTypeCombinedEyeVarjo = 1000121000,
        /// <summary></summary>
        ReferenceSpaceTypeLocal = 2,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ReferenceSpaceTypeLocalFloor = 1000426000,
        /// <summary>[requires: <b>XR_EXT_local_floor</b>] </summary>
        ReferenceSpaceTypeLocalFloorExt = 1000426000,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] </summary>
        ReferenceSpaceTypeLocalizationMapMl = 1000139000,
        /// <summary></summary>
        ReferenceSpaceTypeStage = 3,
        /// <summary>[requires: <b>XR_MSFT_unbounded_reference_space</b>] </summary>
        ReferenceSpaceTypeUnboundedMsft = 1000038000,
        /// <summary></summary>
        ReferenceSpaceTypeView = 1,
    }
    /// <summary></summary>
    [Flags]
    public enum XrRenderModelFlagBitsFB : ulong
    {
        /// <summary>Minimal level of support.  Can only contain a single mesh.  Can only contain a single texture.  Can not contain transparency.  Assumes unlit rendering.  Requires Extension KHR_texturebasisu.</summary>
        RenderModelSupportsGltf20Subset1BitFb = 1,
        /// <summary>All of XR_RENDER_MODEL_SUPPORTS_GLTF_2_0_SUBSET_1_BIT_FB support plus: Multiple meshes. Multiple Textures. Texture Transparency.</summary>
        RenderModelSupportsGltf20Subset2BitFb = 2,
    }
    /// <summary><b>[requires: XR_MSFT_composition_layer_reprojection]</b> Used by <see cref="Xr.EnumerateReprojectionModesMSFT"/></summary>
    public enum XrReprojectionModeMSFT : int
    {
        /// <summary>[requires: <b>XR_MSFT_composition_layer_reprojection</b>] </summary>
        ReprojectionModeDepthMsft = 1,
        /// <summary>[requires: <b>XR_MSFT_composition_layer_reprojection</b>] </summary>
        ReprojectionModeOrientationOnlyMsft = 4,
        /// <summary>[requires: <b>XR_MSFT_composition_layer_reprojection</b>] </summary>
        ReprojectionModePlanarFromDepthMsft = 2,
        /// <summary>[requires: <b>XR_MSFT_composition_layer_reprojection</b>] </summary>
        ReprojectionModePlanarManualMsft = 3,
    }
    /// <summary>Used by <see cref="Xr.AcquireEnvironmentDepthImageMETA"/>, <see cref="Xr.AcquireSwapchainImage"/>, <see cref="Xr.AllocateWorldMeshBufferML"/>, ...</summary>
    public enum XrResult : int
    {
        /// <summary>[requires: <b>XR_META_colocation_discovery</b>] Colocation advertisement has already been enabled</summary>
        ColocationDiscoveryAlreadyAdvertisingMeta = 1000571003,
        /// <summary>[requires: <b>XR_META_colocation_discovery</b>] Colocation discovery has already been enabled</summary>
        ColocationDiscoveryAlreadyDiscoveringMeta = 1000571004,
        /// <summary>[requires: <b>XR_META_environment_depth</b>] Warning: The requested depth image is not yet available.</summary>
        EnvironmentDepthNotAvailableMeta = 1000291000,
        /// <summary>The API used to retrieve an action&apos;s state does not match the action&apos;s type.</summary>
        ErrorActionTypeMismatch = -27,
        /// <summary>A referenced action set is not attached to the session.</summary>
        ErrorActionsetNotAttached = -46,
        /// <summary>The session already has attached action sets.</summary>
        ErrorActionsetsAlreadyAttached = -47,
        /// <summary>[requires: <b>XR_KHR_android_thread_settings</b>] xrSetAndroidApplicationThreadKHR failed setting the thread attributes/priority.</summary>
        ErrorAndroidThreadSettingsFailureKhr = -1000003001,
        /// <summary>[requires: <b>XR_KHR_android_thread_settings</b>] xrSetAndroidApplicationThreadKHR failed as thread id is invalid.</summary>
        ErrorAndroidThreadSettingsIdInvalidKhr = -1000003000,
        /// <summary>A requested API layer is not present or could not be loaded.</summary>
        ErrorApiLayerNotPresent = -36,
        /// <summary>The runtime does not support the requested API version.</summary>
        ErrorApiVersionUnsupported = -4,
        /// <summary>The call was made without having made a previously required call.</summary>
        ErrorCallOrderInvalid = -37,
        /// <summary>[requires: <b>XR_META_colocation_discovery</b>] The network request failed.</summary>
        ErrorColocationDiscoveryNetworkFailedMeta = -1000571001,
        /// <summary>[requires: <b>XR_META_colocation_discovery</b>] The runtime does not have any methods available to perform discovery.</summary>
        ErrorColocationDiscoveryNoDiscoveryMethodMeta = -1000571002,
        /// <summary>[requires: <b>XR_FB_color_space</b>] The color space is not supported by the runtime.</summary>
        ErrorColorSpaceUnsupportedFb = -1000108000,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] Compute new scene not completed.</summary>
        ErrorComputeNewSceneNotCompletedMsft = -1000097000,
        /// <summary>[requires: <b>XR_MSFT_controller_model</b>] The controller model key is invalid.</summary>
        ErrorControllerModelKeyInvalidMsft = -1000055000,
        /// <summary>[requires: <b>XR_MSFT_spatial_anchor</b>] Spatial anchor could not be created at that location.</summary>
        ErrorCreateSpatialAnchorFailedMsft = -1000039001,
        /// <summary>[requires: <b>XR_FB_display_refresh_rate</b>] The display refresh rate is not supported by the platform.</summary>
        ErrorDisplayRefreshRateUnsupportedFb = -1000101000,
        /// <summary>The specified environment blend mode is not supported by the runtime or platform.</summary>
        ErrorEnvironmentBlendModeUnsupported = -42,
        /// <summary>[requires: <b>v1.1</b>] One or more of the extensions being enabled has dependency on extensions that are not enabled.</summary>
        ErrorExtensionDependencyNotEnabled = -1000710001,
        /// <summary>[requires: <b>XR_KHR_maintenance1</b>] </summary>
        ErrorExtensionDependencyNotEnabledKhr = -1000710001,
        /// <summary>A requested extension is not supported.</summary>
        ErrorExtensionNotPresent = -9,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] Permission to track facial expressions was not granted</summary>
        ErrorFacialExpressionPermissionDeniedMl = 1000482000,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] Trying to create an MR feature when one was already created and only one instance is allowed.</summary>
        ErrorFeatureAlreadyCreatedPassthroughFb = -1000118001,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] Requested functionality requires a feature to be created first.</summary>
        ErrorFeatureRequiredPassthroughFb = -1000118002,
        /// <summary>The requested feature is not supported.</summary>
        ErrorFeatureUnsupported = -8,
        /// <summary>The file could not be accessed.</summary>
        ErrorFileAccessError = -32,
        /// <summary>The file&apos;s contents were invalid.</summary>
        ErrorFileContentsInvalid = -33,
        /// <summary>The specified form factor is supported, but the device is currently not available, e.g. not plugged in or powered off.</summary>
        ErrorFormFactorUnavailable = -35,
        /// <summary>The specified form factor is not supported by the current runtime or platform.</summary>
        ErrorFormFactorUnsupported = -34,
        /// <summary>The requested function was not found or is otherwise unsupported.</summary>
        ErrorFunctionUnsupported = -7,
        /// <summary>[requires: <b>XR_EXT_future</b>] Returned by completion function to indicate future is not valid.</summary>
        ErrorFutureInvalidExt = -1000469002,
        /// <summary>[requires: <b>XR_EXT_future</b>] Returned by completion function to indicate future is not ready.</summary>
        ErrorFuturePendingExt = -1000469001,
        /// <summary>The given graphics device is not in a valid state. The graphics device could be lost or initialized without meeting graphics requirements.</summary>
        ErrorGraphicsDeviceInvalid = -38,
        /// <summary>The fname:xrGetGraphicsRequirements* call was not made before calling fname:xrCreateSession.</summary>
        ErrorGraphicsRequirementsCallMissing = -50,
        /// <summary>A supplied object handle was invalid.</summary>
        ErrorHandleInvalid = -12,
        /// <summary>[requires: <b>XR_QCOM_tracking_optimization_settings</b>] Tracking optimization hint is already set for the domain.</summary>
        ErrorHintAlreadySetQcom = -1000306000,
        /// <summary>The supplied index was outside the range of valid indices.</summary>
        ErrorIndexOutOfRange = -40,
        /// <summary>Initialization of object could not be completed.</summary>
        ErrorInitializationFailed = -6,
        /// <summary>The slink:XrInstance was lost or could not be found. It will need to be destroyed and optionally recreated.</summary>
        ErrorInstanceLost = -13,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] There were insufficient resources available to perform an operation.</summary>
        ErrorInsufficientResourcesPassthroughFb = -1000118004,
        /// <summary>The layer was NULL or otherwise invalid.</summary>
        ErrorLayerInvalid = -23,
        /// <summary>The number of specified layers is greater than the supported number.</summary>
        ErrorLayerLimitExceeded = -24,
        /// <summary>The runtime supports no more of the requested resource.</summary>
        ErrorLimitReached = -10,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] The map being imported already exists in the system.</summary>
        ErrorLocalizationMapAlreadyExistsMl = -1000139005,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] The map localization service cannot export cloud based maps.</summary>
        ErrorLocalizationMapCannotExportCloudMapMl = -1000139006,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] The map localization service failed to fulfill the request, retry later.</summary>
        ErrorLocalizationMapFailMl = -1000139002,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] The com.magicleap.permission.SPACE_IMPORT_EXPORT permission was denied.</summary>
        ErrorLocalizationMapImportExportPermissionDeniedMl = -1000139003,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] The localization map being imported is not compatible with current OS or mode.</summary>
        ErrorLocalizationMapIncompatibleMl = -1000139000,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] The com.magicleap.permission.SPACE_MANAGER permission was denied.</summary>
        ErrorLocalizationMapPermissionDeniedMl = -1000139004,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] The localization map requested is not available.</summary>
        ErrorLocalizationMapUnavailableMl = -1000139001,
        /// <summary>The localized name provided was a duplicate of an already-existing resource.</summary>
        ErrorLocalizedNameDuplicated = -48,
        /// <summary>The localized name provided was invalid.</summary>
        ErrorLocalizedNameInvalid = -49,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] pname:createInfo contains mutually exclusive parameters, such as setting ename:XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_APRIL_TAG_ML with ename:XR_MARKER_TYPE_ARUCO_ML.</summary>
        ErrorMarkerDetectorInvalidCreateInfoMl = -1000138003,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] The marker queried does not contain data of the requested type.</summary>
        ErrorMarkerDetectorInvalidDataQueryMl = -1000138002,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] The specified marker could not be located spatially.</summary>
        ErrorMarkerDetectorLocateFailedMl = -1000138001,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] The com.magicleap.permission.MARKER_TRACKING permission was denied.</summary>
        ErrorMarkerDetectorPermissionDeniedMl = -1000138000,
        /// <summary>[requires: <b>XR_VARJO_marker_tracking</b>] The specified marker ID is not valid.</summary>
        ErrorMarkerIdInvalidVarjo = -1000124001,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] The marker id passed to the function was invalid.</summary>
        ErrorMarkerInvalidMl = -1000138004,
        /// <summary>[requires: <b>XR_VARJO_marker_tracking</b>] Marker tracking is disabled or the specified marker is not currently tracked.</summary>
        ErrorMarkerNotTrackedVarjo = -1000124000,
        /// <summary>The name provided was a duplicate of an already-existing resource.</summary>
        ErrorNameDuplicated = -44,
        /// <summary>The name provided was invalid.</summary>
        ErrorNameInvalid = -45,
        /// <summary>[requires: <b>XR_HTC_anchor</b>] The provided space is valid but not an anchor.</summary>
        ErrorNotAnAnchorHtc = -1000319000,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] Requested functionality is not permitted - application is not allowed to perform the requested operation.</summary>
        ErrorNotPermittedPassthroughFb = -1000118003,
        /// <summary>A memory allocation has failed.</summary>
        ErrorOutOfMemory = -3,
        /// <summary>[requires: <b>XR_META_passthrough_color_lut</b>] The provided data buffer did not match the required size.</summary>
        ErrorPassthroughColorLutBufferSizeMismatchMeta = -1000266000,
        /// <summary>The maximum number of supported semantic paths has been reached.</summary>
        ErrorPathCountExceeded = -20,
        /// <summary>The semantic path character format is invalid.</summary>
        ErrorPathFormatInvalid = -21,
        /// <summary>The provided basetype:XrPath was not valid.</summary>
        ErrorPathInvalid = -19,
        /// <summary>The semantic path is unsupported.</summary>
        ErrorPathUnsupported = -22,
        /// <summary>[requires: <b>v1.1</b>] Insufficient permissions. This error is included for use by vendor extensions. The precise definition of `XR_ERROR_PERMISSION_INSUFFICIENT` and actions possible by the developer or user to resolve it can vary by platform, extension or function. The developer should refer to the documentation of the function that returned the error code and extension it was defined.</summary>
        ErrorPermissionInsufficient = -1000710000,
        /// <summary>[requires: <b>XR_KHR_maintenance1</b>] </summary>
        ErrorPermissionInsufficientKhr = -1000710000,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] The permission for this resource was not granted.</summary>
        ErrorPlaneDetectionPermissionDeniedExt = -1000429001,
        /// <summary>The supplied pose was invalid with respect to the requirements.</summary>
        ErrorPoseInvalid = -39,
        /// <summary>The specified reference space is not supported by the runtime or system.</summary>
        ErrorReferenceSpaceUnsupported = -31,
        /// <summary>[requires: <b>XR_FB_render_model</b>] The model key is invalid.</summary>
        ErrorRenderModelKeyInvalidFb = -1000119000,
        /// <summary>[requires: <b>XR_MSFT_composition_layer_reprojection</b>] The reprojection mode is not supported.</summary>
        ErrorReprojectionModeUnsupportedMsft = -1000066000,
        /// <summary>The runtime failed to handle the function in an unexpected way that is not covered by another error result. </summary>
        ErrorRuntimeFailure = -2,
        /// <summary>The loader was unable to find or load a runtime.</summary>
        ErrorRuntimeUnavailable = -51,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] Scene component id invalid.</summary>
        ErrorSceneComponentIdInvalidMsft = -1000097001,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] Scene component type mismatch.</summary>
        ErrorSceneComponentTypeMismatchMsft = -1000097002,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] Scene compute consistency mismatch.</summary>
        ErrorSceneComputeConsistencyMismatchMsft = -1000097005,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] Scene compute feature incompatible.</summary>
        ErrorSceneComputeFeatureIncompatibleMsft = -1000097004,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] Scene mesh buffer id invalid.</summary>
        ErrorSceneMeshBufferIdInvalidMsft = -1000097003,
        /// <summary>[requires: <b>XR_MSFT_secondary_view_configuration</b>] The secondary view configuration was not enabled when creating the session.</summary>
        ErrorSecondaryViewConfigurationTypeNotEnabledMsft = -1000053000,
        /// <summary>The slink:XrSession was lost. It will need to be destroyed and optionally recreated.</summary>
        ErrorSessionLost = -17,
        /// <summary>The session is not in the ready state.</summary>
        ErrorSessionNotReady = -28,
        /// <summary>The session &lt;&lt;session-not-running, is not yet running&gt;&gt;.</summary>
        ErrorSessionNotRunning = -16,
        /// <summary>The session is not in the stopping state.</summary>
        ErrorSessionNotStopping = -29,
        /// <summary>The session &lt;&lt;session-running, is already running&gt;&gt;.</summary>
        ErrorSessionRunning = -14,
        /// <summary>The supplied size was smaller than required.</summary>
        ErrorSizeInsufficient = -11,
        /// <summary>[requires: <b>XR_FB_spatial_entity_sharing</b>] Cloud storage is required for this operation but is currently disabled.</summary>
        ErrorSpaceCloudStorageDisabledFb = -1000169004,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] The required component is not enabled for this space.</summary>
        ErrorSpaceComponentNotEnabledFb = -1000113001,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] The component type is not supported for this space.</summary>
        ErrorSpaceComponentNotSupportedFb = -1000113000,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] The component is already set to the requested value.</summary>
        ErrorSpaceComponentStatusAlreadySetFb = -1000113003,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] A request to set the component&apos;s status is currently pending.</summary>
        ErrorSpaceComponentStatusPendingFb = -1000113002,
        /// <summary>[requires: <b>XR_META_spatial_entity_group_sharing</b>] The group UUID was not be found within the runtime</summary>
        ErrorSpaceGroupNotFoundMeta = -1000572002,
        /// <summary>[requires: <b>XR_FB_spatial_entity_sharing</b>] Anchors were downloaded from the cloud but failed to be imported/aligned on the device.</summary>
        ErrorSpaceLocalizationFailedFb = -1000169001,
        /// <summary>[requires: <b>XR_FB_spatial_entity_sharing</b>] Anchor import from cloud or export from device failed.</summary>
        ErrorSpaceMappingInsufficientFb = -1000169000,
        /// <summary>[requires: <b>XR_FB_spatial_entity_sharing</b>] The network request failed.</summary>
        ErrorSpaceNetworkRequestFailedFb = -1000169003,
        /// <summary>[requires: <b>XR_FB_spatial_entity_sharing</b>] Timeout occurred while waiting for network request to complete.</summary>
        ErrorSpaceNetworkTimeoutFb = -1000169002,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] The space passed to the function was not locatable.</summary>
        ErrorSpaceNotLocatableExt = -1000429000,
        /// <summary>[requires: <b>XR_MSFT_spatial_anchor_persistence</b>] The spatial anchor name provided was not valid</summary>
        ErrorSpatialAnchorNameInvalidMsft = -1000142002,
        /// <summary>[requires: <b>XR_MSFT_spatial_anchor_persistence</b>] A spatial anchor was not found associated with the spatial anchor name provided</summary>
        ErrorSpatialAnchorNameNotFoundMsft = -1000142001,
        /// <summary>[requires: <b>XR_ML_spatial_anchors_storage</b>] The anchor references was not found.</summary>
        ErrorSpatialAnchorsAnchorNotFoundMl = -1000141000,
        /// <summary>[requires: <b>XR_ML_spatial_anchors</b>] Operation failed because the system is not localized into a localization map.</summary>
        ErrorSpatialAnchorsNotLocalizedMl = -1000140001,
        /// <summary>[requires: <b>XR_ML_spatial_anchors</b>] Operation failed because it is performed outside of the localization map.</summary>
        ErrorSpatialAnchorsOutOfMapBoundsMl = -1000140002,
        /// <summary>[requires: <b>XR_ML_spatial_anchors</b>] The com.magicleap.permission.SPATIAL_ANCHOR permission was not granted.</summary>
        ErrorSpatialAnchorsPermissionDeniedMl = -1000140000,
        /// <summary>[requires: <b>XR_ML_spatial_anchors</b>] Operation failed because the space referenced cannot be located.</summary>
        ErrorSpatialAnchorsSpaceNotLocatableMl = -1000140003,
        /// <summary>The image format is not supported by the runtime or platform.</summary>
        ErrorSwapchainFormatUnsupported = -26,
        /// <summary>The image rect was negatively sized or otherwise invalid.</summary>
        ErrorSwapchainRectInvalid = -25,
        /// <summary>The provided basetype:XrSystemId was invalid.</summary>
        ErrorSystemInvalid = -18,
        /// <summary>[requires: <b>XR_ML_system_notifications</b>] Incompatible SKU detected.</summary>
        ErrorSystemNotificationIncompatibleSkuMl = -1000473001,
        /// <summary>[requires: <b>XR_ML_system_notifications</b>] The com.magicleap.permission.SYSTEM_NOTIFICATION permission was not granted.</summary>
        ErrorSystemNotificationPermissionDeniedMl = -1000473000,
        /// <summary>The provided basetype:XrTime was zero, negative, or out of range.</summary>
        ErrorTimeInvalid = -30,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] The object state is unexpected for the issued command.</summary>
        ErrorUnexpectedStatePassthroughFb = -1000118000,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] Unknown Passthrough error (no further details provided).</summary>
        ErrorUnknownPassthroughFb = -1000118050,
        /// <summary>The function usage was invalid in some way.</summary>
        ErrorValidationFailure = -1,
        /// <summary>The specified view configuration type is not supported by the runtime or platform.</summary>
        ErrorViewConfigurationTypeUnsupported = -41,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] The world mesh detector permission was not granted.</summary>
        ErrorWorldMeshDetectorPermissionDeniedMl = -1000474000,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] At the time of the call the runtime was unable to locate the space and cannot fulfill your request.</summary>
        ErrorWorldMeshDetectorSpaceNotLocatableMl = -1000474001,
        /// <summary>No event was available.</summary>
        EventUnavailable = 4,
        /// <summary>A frame has been discarded from composition.</summary>
        FrameDiscarded = 9,
        /// <summary>[requires: <b>XR_FB_render_model</b>] The model is unavailable.</summary>
        RenderModelUnavailableFb = 1000119020,
        /// <summary>[requires: <b>XR_MSFT_scene_marker</b>] Marker does not encode a string.</summary>
        SceneMarkerDataNotStringMsft = 1000147000,
        /// <summary>The session will be lost soon.</summary>
        SessionLossPending = 3,
        /// <summary>The session is not in the focused state.</summary>
        SessionNotFocused = 8,
        /// <summary>The space&apos;s bounds are not known at the moment.</summary>
        SpaceBoundsUnavailable = 7,
        /// <summary>Function successfully completed.</summary>
        Success = 0,
        /// <summary>The specified timeout time occurred before the operation could complete.</summary>
        TimeoutExpired = 1,
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public enum XrSceneComponentTypeMSFT : int
    {
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneComponentTypeColliderMeshMsft = 4,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneComponentTypeInvalidMsft = -1,
        /// <summary>[requires: <b>XR_MSFT_scene_marker</b>] </summary>
        SceneComponentTypeMarkerMsft = 1000147000,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneComponentTypeObjectMsft = 1,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneComponentTypePlaneMsft = 2,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding_serialization</b>] </summary>
        SceneComponentTypeSerializedSceneFragmentMsft = 1000098000,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneComponentTypeVisualMeshMsft = 3,
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public enum XrSceneComputeConsistencyMSFT : int
    {
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneComputeConsistencyOcclusionOptimizedMsft = 3,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneComputeConsistencySnapshotCompleteMsft = 1,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneComputeConsistencySnapshotIncompleteFastMsft = 2,
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> Used by <see cref="Xr.EnumerateSceneComputeFeaturesMSFT"/></summary>
    public enum XrSceneComputeFeatureMSFT : int
    {
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneComputeFeatureColliderMeshMsft = 4,
        /// <summary>[requires: <b>XR_MSFT_scene_marker</b>] </summary>
        SceneComputeFeatureMarkerMsft = 1000147000,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneComputeFeaturePlaneMeshMsft = 2,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneComputeFeaturePlaneMsft = 1,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding_serialization</b>] </summary>
        SceneComputeFeatureSerializeSceneMsft = 1000098000,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneComputeFeatureVisualMeshMsft = 3,
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> Used by <see cref="Xr.GetSceneComputeStateMSFT"/></summary>
    public enum XrSceneComputeStateMSFT : int
    {
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneComputeStateCompletedMsft = 2,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneComputeStateCompletedWithErrorMsft = 3,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneComputeStateNoneMsft = 0,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneComputeStateUpdatingMsft = 1,
    }
    /// <summary><b>[requires: XR_MSFT_scene_marker]</b> </summary>
    public enum XrSceneMarkerQRCodeSymbolTypeMSFT : int
    {
        /// <summary>[requires: <b>XR_MSFT_scene_marker</b>] </summary>
        SceneMarkerQrCodeSymbolTypeMicroQrCodeMsft = 2,
        /// <summary>[requires: <b>XR_MSFT_scene_marker</b>] </summary>
        SceneMarkerQrCodeSymbolTypeQrCodeMsft = 1,
    }
    /// <summary><b>[requires: XR_MSFT_scene_marker]</b> </summary>
    public enum XrSceneMarkerTypeMSFT : int
    {
        /// <summary>[requires: <b>XR_MSFT_scene_marker</b>] </summary>
        SceneMarkerTypeQrCodeMsft = 1,
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public enum XrSceneObjectTypeMSFT : int
    {
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneObjectTypeBackgroundMsft = 1,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneObjectTypeCeilingMsft = 4,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneObjectTypeFloorMsft = 3,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneObjectTypeInferredMsft = 6,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneObjectTypePlatformMsft = 5,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneObjectTypeUncategorizedMsft = -1,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        SceneObjectTypeWallMsft = 2,
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public enum XrScenePlaneAlignmentTypeMSFT : int
    {
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        ScenePlaneAlignmentTypeHorizontalMsft = 1,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        ScenePlaneAlignmentTypeNonOrthogonalMsft = 0,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        ScenePlaneAlignmentTypeVerticalMsft = 2,
    }
    /// <summary><b>[requires: XR_FB_scene]</b> </summary>
    [Flags]
    public enum XrSemanticLabelsSupportFlagBitsFB : ulong
    {
        /// <summary>[requires: <b>XR_FB_scene</b>] If set, and the runtime reports the pname:extensionVersion as 3 or greater, the runtime must: return &quot;TABLE&quot; instead of &quot;DESK&quot; as a semantic label to the application. Otherwise, the runtime must: return &quot;DESK&quot; instead of &quot;TABLE&quot; as a semantic label to the application, when applicable.</summary>
        SemanticLabelsSupportAcceptDeskToTableMigrationBitFb = 2,
        /// <summary>[requires: <b>XR_FB_scene</b>] If set, and the runtime reports the pname:extensionVersion as 4 or greater, the runtime may: return &quot;INVISIBLE_WALL_FACE&quot; instead of &quot;WALL_FACE&quot; as a semantic label to the application in order to represent an invisible wall used to conceptually separate a space (e.g., separate a living space from a kitchen space in an open floor plan house even though there is no real wall between the two spaces) instead of a real wall. Otherwise, the runtime must: return &quot;WALL_FACE&quot; as a semantic label to the application in order to represent both an invisible and real wall, when applicable.</summary>
        SemanticLabelsSupportAcceptInvisibleWallFaceBitFb = 4,
        /// <summary>[requires: <b>XR_FB_scene</b>] If set, and the runtime reports the pname:extensionVersion as 2 or greater, the runtime may: return multiple semantic labels separated by a comma without spaces. Otherwise, the runtime must: return a single semantic label.</summary>
        SemanticLabelsSupportMultipleSemanticLabelsBitFb = 1,
    }
    /// <summary></summary>
    [Flags]
    public enum XrSessionCreateFlagBits : ulong
    {
    }
    /// <summary></summary>
    public enum XrSessionState : int
    {
        /// <summary></summary>
        SessionStateExiting = 8,
        /// <summary></summary>
        SessionStateFocused = 5,
        /// <summary></summary>
        SessionStateIdle = 1,
        /// <summary></summary>
        SessionStateLossPending = 7,
        /// <summary></summary>
        SessionStateReady = 2,
        /// <summary></summary>
        SessionStateStopping = 6,
        /// <summary></summary>
        SessionStateSynchronized = 3,
        /// <summary></summary>
        SessionStateUnknown = 0,
        /// <summary></summary>
        SessionStateVisible = 4,
    }
    /// <summary><b>[requires: XR_FB_spatial_entity]</b> Used by <see cref="Xr.EnumerateSpaceSupportedComponentsFB"/>, <see cref="Xr.GetSpaceComponentStatusFB"/></summary>
    public enum XrSpaceComponentTypeFB : int
    {
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] Bounded 2D component.</summary>
        SpaceComponentTypeBounded2dFb = 3,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] Bounded 3D component.</summary>
        SpaceComponentTypeBounded3dFb = 4,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] Enables tracking the 6 DOF pose of the slink:XrSpace with flink:xrLocateSpace.</summary>
        SpaceComponentTypeLocatableFb = 0,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] Room layout component.</summary>
        SpaceComponentTypeRoomLayoutFb = 6,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] Semantic labels component.</summary>
        SpaceComponentTypeSemanticLabelsFb = 5,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] Enables sharing of spatial entities.</summary>
        SpaceComponentTypeSharableFb = 2,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] Space container component.</summary>
        SpaceComponentTypeSpaceContainerFb = 7,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] Enables persistence operations: save and erase.</summary>
        SpaceComponentTypeStorableFb = 1,
        /// <summary>[requires: <b>XR_META_spatial_entity_mesh</b>] </summary>
        SpaceComponentTypeTriangleMeshMeta = 1000269000,
    }
    /// <summary></summary>
    [Flags]
    public enum XrSpaceLocationFlagBits : ulong
    {
        /// <summary>Indicates whether pname:pose member contains an actively tracked pname:orientation</summary>
        SpaceLocationOrientationTrackedBit = 4,
        /// <summary>Indicates that the pname:orientation member contains valid data</summary>
        SpaceLocationOrientationValidBit = 1,
        /// <summary>Indicates whether pname:pose member contains an actively tracked pname:position</summary>
        SpaceLocationPositionTrackedBit = 8,
        /// <summary>Indicates that the pname:position member contains valid data</summary>
        SpaceLocationPositionValidBit = 2,
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_storage]</b> </summary>
    public enum XrSpacePersistenceModeFB : int
    {
        /// <summary>[requires: <b>XR_FB_spatial_entity_storage</b>] Store slink:XrSpace indefinitely, or until erased</summary>
        SpacePersistenceModeIndefiniteFb = 1,
        /// <summary>[requires: <b>XR_FB_spatial_entity_storage</b>] Invalid storage persistence</summary>
        SpacePersistenceModeInvalidFb = 0,
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_query]</b> </summary>
    public enum XrSpaceQueryActionFB : int
    {
        /// <summary>[requires: <b>XR_FB_spatial_entity_query</b>] Tells the query to perform a load operation on any slink:XrSpace returned by the query.</summary>
        SpaceQueryActionLoadFb = 0,
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_storage]</b> </summary>
    public enum XrSpaceStorageLocationFB : int
    {
        /// <summary>[requires: <b>XR_FB_spatial_entity_storage</b>] Cloud storage</summary>
        SpaceStorageLocationCloudFb = 2,
        /// <summary>[requires: <b>XR_FB_spatial_entity_storage</b>] Invalid storage location</summary>
        SpaceStorageLocationInvalidFb = 0,
        /// <summary>[requires: <b>XR_FB_spatial_entity_storage</b>] Local device storage</summary>
        SpaceStorageLocationLocalFb = 1,
    }
    /// <summary></summary>
    [Flags]
    public enum XrSpaceVelocityFlagBits : ulong
    {
        /// <summary>Indicates that the pname:angularVelocity member contains valid data. Applications must: not read the pname:angularVelocity field if this flag is unset.</summary>
        SpaceVelocityAngularValidBit = 2,
        /// <summary>Indicates that the pname:linearVelocity member contains valid data. Applications must: not read the pname:linearVelocity field if this flag is unset.</summary>
        SpaceVelocityLinearValidBit = 1,
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors]</b> </summary>
    public enum XrSpatialAnchorConfidenceML : int
    {
        /// <summary>[requires: <b>XR_ML_spatial_anchors</b>] High quality, this anchor is stable and suitable for digital content attachment.</summary>
        SpatialAnchorConfidenceHighMl = 2,
        /// <summary>[requires: <b>XR_ML_spatial_anchors</b>] Low quality, this anchor can be expected to move significantly.</summary>
        SpatialAnchorConfidenceLowMl = 0,
        /// <summary>[requires: <b>XR_ML_spatial_anchors</b>] Medium quality, this anchor may move slightly.</summary>
        SpatialAnchorConfidenceMediumMl = 1,
    }
    /// <summary><b>[requires: XR_MSFT_spatial_graph_bridge]</b> </summary>
    public enum XrSpatialGraphNodeTypeMSFT : int
    {
        /// <summary>[requires: <b>XR_MSFT_spatial_graph_bridge</b>] </summary>
        SpatialGraphNodeTypeDynamicMsft = 2,
        /// <summary>[requires: <b>XR_MSFT_spatial_graph_bridge</b>] </summary>
        SpatialGraphNodeTypeStaticMsft = 1,
    }
    /// <summary>Used by <see cref="Xr.StructureTypeToString"/>, <see cref="Xr.StructureTypeToString2KHR"/></summary>
    public enum XrStructureType : int
    {
        /// <summary></summary>
        TypeActionCreateInfo = 29,
        /// <summary></summary>
        TypeActionSetCreateInfo = 28,
        /// <summary></summary>
        TypeActionSpaceCreateInfo = 38,
        /// <summary></summary>
        TypeActionStateBoolean = 23,
        /// <summary></summary>
        TypeActionStateFloat = 24,
        /// <summary></summary>
        TypeActionStateGetInfo = 58,
        /// <summary></summary>
        TypeActionStatePose = 27,
        /// <summary></summary>
        TypeActionStateVector2f = 25,
        /// <summary></summary>
        TypeActionsSyncInfo = 61,
        /// <summary>[requires: <b>XR_EXT_active_action_set_priority</b>] </summary>
        TypeActiveActionSetPrioritiesExt = 1000373000,
        /// <summary>[requires: <b>XR_FB_android_surface_swapchain_create</b>] </summary>
        TypeAndroidSurfaceSwapchainCreateInfoFb = 1000070000,
        /// <summary></summary>
        TypeApiLayerProperties = 1,
        /// <summary>[requires: <b>XR_KHR_binding_modification</b>] </summary>
        TypeBindingModificationsKhr = 1000120000,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        TypeBodyJointLocationsBd = 1000385003,
        /// <summary>[requires: <b>XR_FB_body_tracking</b>] </summary>
        TypeBodyJointLocationsFb = 1000076005,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        TypeBodyJointLocationsHtc = 1000320003,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        TypeBodyJointsLocateInfoBd = 1000385002,
        /// <summary>[requires: <b>XR_FB_body_tracking</b>] </summary>
        TypeBodyJointsLocateInfoFb = 1000076002,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        TypeBodyJointsLocateInfoHtc = 1000320002,
        /// <summary>[requires: <b>XR_FB_body_tracking</b>] </summary>
        TypeBodySkeletonFb = 1000076006,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        TypeBodySkeletonHtc = 1000320004,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        TypeBodyTrackerCreateInfoBd = 1000385001,
        /// <summary>[requires: <b>XR_FB_body_tracking</b>] </summary>
        TypeBodyTrackerCreateInfoFb = 1000076001,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        TypeBodyTrackerCreateInfoHtc = 1000320001,
        /// <summary></summary>
        TypeBoundSourcesForActionEnumerateInfo = 62,
        /// <summary>[requires: <b>XR_FB_scene</b>] </summary>
        TypeBoundary2dFb = 1000175002,
        /// <summary>[requires: <b>XR_META_colocation_discovery</b>] </summary>
        TypeColocationAdvertisementStartInfoMeta = 1000571012,
        /// <summary>[requires: <b>XR_META_colocation_discovery</b>] </summary>
        TypeColocationAdvertisementStopInfoMeta = 1000571013,
        /// <summary>[requires: <b>XR_META_colocation_discovery</b>] </summary>
        TypeColocationDiscoveryStartInfoMeta = 1000571010,
        /// <summary>[requires: <b>XR_META_colocation_discovery</b>] </summary>
        TypeColocationDiscoveryStopInfoMeta = 1000571011,
        /// <summary>[requires: <b>XR_FB_composition_layer_alpha_blend</b>] </summary>
        TypeCompositionLayerAlphaBlendFb = 1000041001,
        /// <summary>[requires: <b>XR_KHR_composition_layer_color_scale_bias</b>] </summary>
        TypeCompositionLayerColorScaleBiasKhr = 1000034000,
        /// <summary>[requires: <b>XR_KHR_composition_layer_cube</b>] </summary>
        TypeCompositionLayerCubeKhr = 1000006000,
        /// <summary>[requires: <b>XR_KHR_composition_layer_cylinder</b>] </summary>
        TypeCompositionLayerCylinderKhr = 1000017000,
        /// <summary>[requires: <b>XR_KHR_composition_layer_depth</b>] </summary>
        TypeCompositionLayerDepthInfoKhr = 1000010000,
        /// <summary>[requires: <b>XR_FB_composition_layer_depth_test</b>] </summary>
        TypeCompositionLayerDepthTestFb = 1000212000,
        /// <summary>[requires: <b>XR_VARJO_composition_layer_depth_test</b>] </summary>
        TypeCompositionLayerDepthTestVarjo = 1000122000,
        /// <summary>[requires: <b>XR_KHR_composition_layer_equirect</b>] </summary>
        TypeCompositionLayerEquirectKhr = 1000018000,
        /// <summary>[requires: <b>XR_KHR_composition_layer_equirect2</b>] </summary>
        TypeCompositionLayerEquirect2Khr = 1000091000,
        /// <summary>[requires: <b>XR_FB_composition_layer_image_layout</b>] </summary>
        TypeCompositionLayerImageLayoutFb = 1000040000,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] </summary>
        TypeCompositionLayerPassthroughFb = 1000118003,
        /// <summary>[requires: <b>XR_HTC_passthrough</b>] </summary>
        TypeCompositionLayerPassthroughHtc = 1000317004,
        /// <summary></summary>
        TypeCompositionLayerProjection = 35,
        /// <summary></summary>
        TypeCompositionLayerProjectionView = 48,
        /// <summary></summary>
        TypeCompositionLayerQuad = 36,
        /// <summary>[requires: <b>XR_MSFT_composition_layer_reprojection</b>] </summary>
        TypeCompositionLayerReprojectionInfoMsft = 1000066000,
        /// <summary>[requires: <b>XR_MSFT_composition_layer_reprojection</b>] </summary>
        TypeCompositionLayerReprojectionPlaneOverrideMsft = 1000066001,
        /// <summary>[requires: <b>XR_FB_composition_layer_secure_content</b>] </summary>
        TypeCompositionLayerSecureContentFb = 1000072000,
        /// <summary>[requires: <b>XR_FB_composition_layer_settings</b>] </summary>
        TypeCompositionLayerSettingsFb = 1000204000,
        /// <summary>[requires: <b>XR_FB_space_warp</b>] </summary>
        TypeCompositionLayerSpaceWarpInfoFb = 1000171000,
        /// <summary>[requires: <b>XR_MSFT_controller_model</b>] </summary>
        TypeControllerModelKeyStateMsft = 1000055000,
        /// <summary>[requires: <b>XR_MSFT_controller_model</b>] </summary>
        TypeControllerModelNodePropertiesMsft = 1000055001,
        /// <summary>[requires: <b>XR_MSFT_controller_model</b>] </summary>
        TypeControllerModelNodeStateMsft = 1000055003,
        /// <summary>[requires: <b>XR_MSFT_controller_model</b>] </summary>
        TypeControllerModelPropertiesMsft = 1000055002,
        /// <summary>[requires: <b>XR_MSFT_controller_model</b>] </summary>
        TypeControllerModelStateMsft = 1000055004,
        /// <summary>[requires: <b>XR_ML_compat</b>] </summary>
        TypeCoordinateSpaceCreateInfoMl = 1000137000,
        /// <summary>[requires: <b>XR_ML_spatial_anchors</b>] </summary>
        TypeCreateSpatialAnchorsCompletionMl = 1000140001,
        /// <summary>[requires: <b>XR_EXT_debug_utils</b>] </summary>
        TypeDebugUtilsLabelExt = 1000019003,
        /// <summary>[requires: <b>XR_EXT_debug_utils</b>] </summary>
        TypeDebugUtilsMessengerCallbackDataExt = 1000019001,
        /// <summary>[requires: <b>XR_EXT_debug_utils</b>] </summary>
        TypeDebugUtilsMessengerCreateInfoExt = 1000019002,
        /// <summary>[requires: <b>XR_EXT_debug_utils</b>] </summary>
        TypeDebugUtilsObjectNameInfoExt = 1000019000,
        /// <summary>[requires: <b>XR_FB_haptic_pcm</b>] </summary>
        TypeDevicePcmSampleRateGetInfoFb = 1000209002,
        /// <summary>[requires: <b>XR_FB_haptic_pcm</b>] </summary>
        TypeDevicePcmSampleRateStateFb = 1000209002,
        /// <summary>[requires: <b>XR_ALMALENCE_digital_lens_control</b>] </summary>
        TypeDigitalLensControlAlmalence = 1000196000,
        /// <summary>[requires: <b>XR_META_environment_depth</b>] </summary>
        TypeEnvironmentDepthHandRemovalSetInfoMeta = 1000291006,
        /// <summary>[requires: <b>XR_META_environment_depth</b>] </summary>
        TypeEnvironmentDepthImageAcquireInfoMeta = 1000291003,
        /// <summary>[requires: <b>XR_META_environment_depth</b>] </summary>
        TypeEnvironmentDepthImageMeta = 1000291005,
        /// <summary>[requires: <b>XR_META_environment_depth</b>] </summary>
        TypeEnvironmentDepthImageViewMeta = 1000291004,
        /// <summary>[requires: <b>XR_META_environment_depth</b>] </summary>
        TypeEnvironmentDepthProviderCreateInfoMeta = 1000291000,
        /// <summary>[requires: <b>XR_META_environment_depth</b>] </summary>
        TypeEnvironmentDepthSwapchainCreateInfoMeta = 1000291001,
        /// <summary>[requires: <b>XR_META_environment_depth</b>] </summary>
        TypeEnvironmentDepthSwapchainStateMeta = 1000291002,
        /// <summary></summary>
        TypeEventDataBuffer = 16,
        /// <summary>[requires: <b>XR_META_colocation_discovery</b>] </summary>
        TypeEventDataColocationAdvertisementCompleteMeta = 1000571022,
        /// <summary>[requires: <b>XR_META_colocation_discovery</b>] </summary>
        TypeEventDataColocationDiscoveryCompleteMeta = 1000571025,
        /// <summary>[requires: <b>XR_META_colocation_discovery</b>] </summary>
        TypeEventDataColocationDiscoveryResultMeta = 1000571024,
        /// <summary>[requires: <b>XR_FB_display_refresh_rate</b>] </summary>
        TypeEventDataDisplayRefreshRateChangedFb = 1000101000,
        /// <summary></summary>
        TypeEventDataEventsLost = 49,
        /// <summary>[requires: <b>XR_ML_user_calibration</b>] </summary>
        TypeEventDataEyeCalibrationChangedMl = 1000472001,
        /// <summary>[requires: <b>XR_ML_user_calibration</b>] </summary>
        TypeEventDataHeadsetFitChangedMl = 1000472000,
        /// <summary></summary>
        TypeEventDataInstanceLossPending = 17,
        /// <summary></summary>
        TypeEventDataInteractionProfileChanged = 52,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] </summary>
        TypeEventDataLocalizationChangedMl = 1000139001,
        /// <summary>[requires: <b>XR_EXTX_overlay</b>] </summary>
        TypeEventDataMainSessionVisibilityChangedExtx = 1000033003,
        /// <summary>[requires: <b>XR_VARJO_marker_tracking</b>] </summary>
        TypeEventDataMarkerTrackingUpdateVarjo = 1000124001,
        /// <summary>[requires: <b>XR_META_passthrough_layer_resumed_event</b>] </summary>
        TypeEventDataPassthroughLayerResumedMeta = 1000282000,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] </summary>
        TypeEventDataPassthroughStateChangedFb = 1000118030,
        /// <summary>[requires: <b>XR_EXT_performance_settings</b>] </summary>
        TypeEventDataPerfSettingsExt = 1000015000,
        /// <summary></summary>
        TypeEventDataReferenceSpaceChangePending = 40,
        /// <summary>[requires: <b>XR_FB_scene_capture</b>] </summary>
        TypeEventDataSceneCaptureCompleteFb = 1000198001,
        /// <summary></summary>
        TypeEventDataSessionStateChanged = 18,
        /// <summary>[requires: <b>XR_META_spatial_entity_sharing</b>] </summary>
        TypeEventDataShareSpacesCompleteMeta = 1000290002,
        /// <summary>[requires: <b>XR_FB_spatial_entity_storage</b>] </summary>
        TypeEventDataSpaceEraseCompleteFb = 1000158107,
        /// <summary>[requires: <b>XR_FB_spatial_entity_storage_batch</b>] </summary>
        TypeEventDataSpaceListSaveCompleteFb = 1000238001,
        /// <summary>[requires: <b>XR_FB_spatial_entity_query</b>] </summary>
        TypeEventDataSpaceQueryCompleteFb = 1000156104,
        /// <summary>[requires: <b>XR_FB_spatial_entity_query</b>] </summary>
        TypeEventDataSpaceQueryResultsAvailableFb = 1000156103,
        /// <summary>[requires: <b>XR_FB_spatial_entity_storage</b>] </summary>
        TypeEventDataSpaceSaveCompleteFb = 1000158106,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] </summary>
        TypeEventDataSpaceSetStatusCompleteFb = 1000113006,
        /// <summary>[requires: <b>XR_FB_spatial_entity_sharing</b>] </summary>
        TypeEventDataSpaceShareCompleteFb = 1000169002,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] </summary>
        TypeEventDataSpatialAnchorCreateCompleteFb = 1000113005,
        /// <summary>[requires: <b>XR_META_colocation_discovery</b>] </summary>
        TypeEventDataStartColocationAdvertisementCompleteMeta = 1000571020,
        /// <summary>[requires: <b>XR_META_colocation_discovery</b>] </summary>
        TypeEventDataStartColocationDiscoveryCompleteMeta = 1000571023,
        /// <summary>[requires: <b>XR_META_colocation_discovery</b>] </summary>
        TypeEventDataStopColocationAdvertisementCompleteMeta = 1000571021,
        /// <summary>[requires: <b>XR_META_colocation_discovery</b>] </summary>
        TypeEventDataStopColocationDiscoveryCompleteMeta = 1000571026,
        /// <summary>[requires: <b>XR_EXT_user_presence</b>] </summary>
        TypeEventDataUserPresenceChangedExt = 1000470000,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] </summary>
        TypeEventDataVirtualKeyboardBackspaceMeta = 1000219015,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] </summary>
        TypeEventDataVirtualKeyboardCommitTextMeta = 1000219014,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] </summary>
        TypeEventDataVirtualKeyboardEnterMeta = 1000219016,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] </summary>
        TypeEventDataVirtualKeyboardHiddenMeta = 1000219018,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] </summary>
        TypeEventDataVirtualKeyboardShownMeta = 1000219017,
        /// <summary>[requires: <b>XR_KHR_visibility_mask</b>] </summary>
        TypeEventDataVisibilityMaskChangedKhr = 1000031001,
        /// <summary>[requires: <b>XR_HTCX_vive_tracker_interaction</b>] </summary>
        TypeEventDataViveTrackerConnectedHtcx = 1000103001,
        /// <summary></summary>
        TypeExtensionProperties = 2,
        /// <summary>[requires: <b>XR_OCULUS_external_camera</b>] </summary>
        TypeExternalCameraOculus = 1000226000,
        /// <summary>[requires: <b>XR_EXT_eye_gaze_interaction</b>] </summary>
        TypeEyeGazeSampleTimeExt = 1000030001,
        /// <summary>[requires: <b>XR_FB_eye_tracking_social</b>] </summary>
        TypeEyeGazesFb = 1000202003,
        /// <summary>[requires: <b>XR_FB_eye_tracking_social</b>] </summary>
        TypeEyeGazesInfoFb = 1000202002,
        /// <summary>[requires: <b>XR_FB_eye_tracking_social</b>] </summary>
        TypeEyeTrackerCreateInfoFb = 1000202001,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        TypeFaceExpressionInfoFb = 1000201002,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        TypeFaceExpressionInfo2Fb = 1000287015,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        TypeFaceExpressionWeightsFb = 1000201006,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        TypeFaceExpressionWeights2Fb = 1000287016,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        TypeFaceTrackerCreateInfoFb = 1000201005,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        TypeFaceTrackerCreateInfo2Fb = 1000287014,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        TypeFacialExpressionBlendShapeGetInfoMl = 1000482006,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        TypeFacialExpressionBlendShapePropertiesMl = 1000482007,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        TypeFacialExpressionClientCreateInfoMl = 1000482005,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        TypeFacialExpressionsHtc = 1000104002,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        TypeFacialTrackerCreateInfoHtc = 1000104001,
        /// <summary>[requires: <b>XR_MNDX_force_feedback_curl</b>] </summary>
        TypeForceFeedbackCurlApplyLocationsMndx = 1000375001,
        /// <summary>[requires: <b>XR_VARJO_foveated_rendering</b>] </summary>
        TypeFoveatedViewConfigurationViewVarjo = 1000121001,
        /// <summary>[requires: <b>XR_HTC_foveation</b>] </summary>
        TypeFoveationApplyInfoHtc = 1000318000,
        /// <summary>[requires: <b>XR_HTC_foveation</b>] </summary>
        TypeFoveationCustomModeInfoHtc = 1000318002,
        /// <summary>[requires: <b>XR_HTC_foveation</b>] </summary>
        TypeFoveationDynamicModeInfoHtc = 1000318001,
        /// <summary>[requires: <b>XR_META_foveation_eye_tracked</b>] </summary>
        TypeFoveationEyeTrackedProfileCreateInfoMeta = 1000200000,
        /// <summary>[requires: <b>XR_META_foveation_eye_tracked</b>] </summary>
        TypeFoveationEyeTrackedStateMeta = 1000200001,
        /// <summary>[requires: <b>XR_FB_foveation_configuration</b>] </summary>
        TypeFoveationLevelProfileCreateInfoFb = 1000115000,
        /// <summary>[requires: <b>XR_FB_foveation</b>] </summary>
        TypeFoveationProfileCreateInfoFb = 1000114000,
        /// <summary></summary>
        TypeFrameBeginInfo = 46,
        /// <summary></summary>
        TypeFrameEndInfo = 12,
        /// <summary>[requires: <b>XR_ML_frame_end_info</b>] </summary>
        TypeFrameEndInfoMl = 1000135000,
        /// <summary></summary>
        TypeFrameState = 44,
        /// <summary>[requires: <b>XR_EXT_frame_synthesis</b>] </summary>
        TypeFrameSynthesisConfigViewExt = 1000211001,
        /// <summary>[requires: <b>XR_EXT_frame_synthesis</b>] </summary>
        TypeFrameSynthesisInfoExt = 1000211000,
        /// <summary></summary>
        TypeFrameWaitInfo = 33,
        /// <summary>[requires: <b>XR_EXT_future</b>] </summary>
        TypeFutureCancelInfoExt = 1000469000,
        /// <summary>[requires: <b>XR_EXT_future</b>] </summary>
        TypeFutureCompletionExt = 1000469002,
        /// <summary>[requires: <b>XR_EXT_future</b>] </summary>
        TypeFuturePollInfoExt = 1000469001,
        /// <summary>[requires: <b>XR_EXT_future</b>] </summary>
        TypeFuturePollResultExt = 1000469003,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] </summary>
        TypeGeometryInstanceCreateInfoFb = 1000118004,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] </summary>
        TypeGeometryInstanceTransformFb = 1000118005,
        /// <summary>[requires: <b>XR_ML_global_dimmer</b>] </summary>
        TypeGlobalDimmerFrameEndInfoMl = 1000136000,
        /// <summary>[requires: <b>XR_KHR_D3D11_enable</b>] </summary>
        TypeGraphicsBindingD3d11Khr = 1000027000,
        /// <summary>[requires: <b>XR_KHR_D3D12_enable</b>] </summary>
        TypeGraphicsBindingD3d12Khr = 1000028000,
        /// <summary>[requires: <b>XR_MNDX_egl_enable</b>] </summary>
        TypeGraphicsBindingEglMndx = 1000048004,
        /// <summary>[requires: <b>XR_KHR_metal_enable</b>] </summary>
        TypeGraphicsBindingMetalKhr = 1000029000,
        /// <summary>[requires: <b>XR_KHR_opengl_es_enable</b>] </summary>
        TypeGraphicsBindingOpenglEsAndroidKhr = 1000024001,
        /// <summary>[requires: <b>XR_KHR_opengl_enable</b>] </summary>
        TypeGraphicsBindingOpenglWaylandKhr = 1000023003,
        /// <summary>[requires: <b>XR_KHR_opengl_enable</b>] </summary>
        TypeGraphicsBindingOpenglWin32Khr = 1000023000,
        /// <summary>[requires: <b>XR_KHR_opengl_enable</b>] </summary>
        TypeGraphicsBindingOpenglXcbKhr = 1000023002,
        /// <summary>[requires: <b>XR_KHR_opengl_enable</b>] </summary>
        TypeGraphicsBindingOpenglXlibKhr = 1000023001,
        /// <summary>[requires: <b>XR_KHR_vulkan_enable</b>] </summary>
        TypeGraphicsBindingVulkanKhr = 1000025000,
        /// <summary>[requires: <b>XR_KHR_vulkan_enable2</b>] </summary>
        TypeGraphicsBindingVulkan2Khr = 1000025000,
        /// <summary>[requires: <b>XR_KHR_D3D11_enable</b>] </summary>
        TypeGraphicsRequirementsD3d11Khr = 1000027002,
        /// <summary>[requires: <b>XR_KHR_D3D12_enable</b>] </summary>
        TypeGraphicsRequirementsD3d12Khr = 1000028002,
        /// <summary>[requires: <b>XR_KHR_metal_enable</b>] </summary>
        TypeGraphicsRequirementsMetalKhr = 1000029002,
        /// <summary>[requires: <b>XR_KHR_opengl_es_enable</b>] </summary>
        TypeGraphicsRequirementsOpenglEsKhr = 1000024003,
        /// <summary>[requires: <b>XR_KHR_opengl_enable</b>] </summary>
        TypeGraphicsRequirementsOpenglKhr = 1000023005,
        /// <summary>[requires: <b>XR_KHR_vulkan_enable</b>] </summary>
        TypeGraphicsRequirementsVulkanKhr = 1000025002,
        /// <summary>[requires: <b>XR_KHR_vulkan_enable2</b>] </summary>
        TypeGraphicsRequirementsVulkan2Khr = 1000025002,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        TypeHandJointLocationsExt = 1000051003,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        TypeHandJointVelocitiesExt = 1000051004,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        TypeHandJointsLocateInfoExt = 1000051002,
        /// <summary>[requires: <b>XR_EXT_hand_joints_motion_range</b>] </summary>
        TypeHandJointsMotionRangeInfoExt = 1000080000,
        /// <summary>[requires: <b>XR_MSFT_hand_tracking_mesh</b>] </summary>
        TypeHandMeshMsft = 1000052003,
        /// <summary>[requires: <b>XR_MSFT_hand_tracking_mesh</b>] </summary>
        TypeHandMeshSpaceCreateInfoMsft = 1000052001,
        /// <summary>[requires: <b>XR_MSFT_hand_tracking_mesh</b>] </summary>
        TypeHandMeshUpdateInfoMsft = 1000052002,
        /// <summary>[requires: <b>XR_MSFT_hand_tracking_mesh</b>] </summary>
        TypeHandPoseTypeInfoMsft = 1000052004,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        TypeHandTrackerCreateInfoExt = 1000051001,
        /// <summary>[requires: <b>XR_FB_hand_tracking_aim</b>] </summary>
        TypeHandTrackingAimStateFb = 1000111001,
        /// <summary>[requires: <b>XR_FB_hand_tracking_capsules</b>] </summary>
        TypeHandTrackingCapsulesStateFb = 1000112000,
        /// <summary>[requires: <b>XR_EXT_hand_tracking_data_source</b>] </summary>
        TypeHandTrackingDataSourceInfoExt = 1000428000,
        /// <summary>[requires: <b>XR_EXT_hand_tracking_data_source</b>] </summary>
        TypeHandTrackingDataSourceStateExt = 1000428001,
        /// <summary>[requires: <b>XR_FB_hand_tracking_mesh</b>] </summary>
        TypeHandTrackingMeshFb = 1000110001,
        /// <summary>[requires: <b>XR_FB_hand_tracking_mesh</b>] </summary>
        TypeHandTrackingScaleFb = 1000110003,
        /// <summary></summary>
        TypeHapticActionInfo = 59,
        /// <summary>[requires: <b>XR_FB_haptic_amplitude_envelope</b>] </summary>
        TypeHapticAmplitudeEnvelopeVibrationFb = 1000173001,
        /// <summary>[requires: <b>XR_FB_haptic_pcm</b>] </summary>
        TypeHapticPcmVibrationFb = 1000209001,
        /// <summary></summary>
        TypeHapticVibration = 13,
        /// <summary>[requires: <b>XR_MSFT_holographic_window_attachment</b>] </summary>
        TypeHolographicWindowAttachmentMsft = 1000063000,
        /// <summary></summary>
        TypeInputSourceLocalizedNameGetInfo = 63,
        /// <summary></summary>
        TypeInstanceCreateInfo = 3,
        /// <summary>[requires: <b>XR_KHR_android_create_instance</b>] </summary>
        TypeInstanceCreateInfoAndroidKhr = 1000008000,
        /// <summary></summary>
        TypeInstanceProperties = 32,
        /// <summary>[requires: <b>XR_VALVE_analog_threshold</b>] </summary>
        TypeInteractionProfileAnalogThresholdValve = 1000079000,
        /// <summary>[requires: <b>XR_EXT_dpad_binding</b>] </summary>
        TypeInteractionProfileDpadBindingExt = 1000078000,
        /// <summary></summary>
        TypeInteractionProfileState = 53,
        /// <summary></summary>
        TypeInteractionProfileSuggestedBinding = 51,
        /// <summary>[requires: <b>XR_FB_keyboard_tracking</b>] </summary>
        TypeKeyboardSpaceCreateInfoFb = 1000116009,
        /// <summary>[requires: <b>XR_FB_keyboard_tracking</b>] </summary>
        TypeKeyboardTrackingQueryFb = 1000116004,
        /// <summary>[requires: <b>XR_KHR_loader_init_android</b>] </summary>
        TypeLoaderInitInfoAndroidKhr = 1000089000,
        /// <summary>[requires: <b>XR_META_local_dimming</b>] </summary>
        TypeLocalDimmingFrameEndInfoMeta = 1000216000,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] </summary>
        TypeLocalizationEnableEventsInfoMl = 1000139004,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] </summary>
        TypeLocalizationMapImportInfoMl = 1000139003,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] </summary>
        TypeLocalizationMapMl = 1000139000,
        /// <summary>[requires: <b>XR_ML_localization_map</b>] </summary>
        TypeMapLocalizationRequestInfoMl = 1000139002,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] </summary>
        TypeMarkerDetectorAprilTagInfoMl = 1000138004,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] </summary>
        TypeMarkerDetectorArucoInfoMl = 1000138002,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] </summary>
        TypeMarkerDetectorCreateInfoMl = 1000138001,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] </summary>
        TypeMarkerDetectorCustomProfileInfoMl = 1000138005,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] </summary>
        TypeMarkerDetectorSizeInfoMl = 1000138003,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] </summary>
        TypeMarkerDetectorSnapshotInfoMl = 1000138006,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] </summary>
        TypeMarkerDetectorStateMl = 1000138007,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] </summary>
        TypeMarkerSpaceCreateInfoMl = 1000138008,
        /// <summary>[requires: <b>XR_VARJO_marker_tracking</b>] </summary>
        TypeMarkerSpaceCreateInfoVarjo = 1000124002,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeNewSceneComputeInfoMsft = 1000097002,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] </summary>
        TypePassthroughBrightnessContrastSaturationFb = 1000118023,
        /// <summary>[requires: <b>XR_HTC_passthrough</b>] </summary>
        TypePassthroughColorHtc = 1000317002,
        /// <summary>[requires: <b>XR_META_passthrough_color_lut</b>] </summary>
        TypePassthroughColorLutCreateInfoMeta = 1000266001,
        /// <summary>[requires: <b>XR_META_passthrough_color_lut</b>] </summary>
        TypePassthroughColorLutUpdateInfoMeta = 1000266002,
        /// <summary>[requires: <b>XR_META_passthrough_color_lut</b>] </summary>
        TypePassthroughColorMapInterpolatedLutMeta = 1000266101,
        /// <summary>[requires: <b>XR_META_passthrough_color_lut</b>] </summary>
        TypePassthroughColorMapLutMeta = 1000266100,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] </summary>
        TypePassthroughColorMapMonoToMonoFb = 1000118022,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] </summary>
        TypePassthroughColorMapMonoToRgbaFb = 1000118021,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] </summary>
        TypePassthroughCreateInfoFb = 1000118001,
        /// <summary>[requires: <b>XR_HTC_passthrough</b>] </summary>
        TypePassthroughCreateInfoHtc = 1000317001,
        /// <summary>[requires: <b>XR_FB_passthrough_keyboard_hands</b>] </summary>
        TypePassthroughKeyboardHandsIntensityFb = 1000203002,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] </summary>
        TypePassthroughLayerCreateInfoFb = 1000118002,
        /// <summary>[requires: <b>XR_HTC_passthrough</b>] </summary>
        TypePassthroughMeshTransformInfoHtc = 1000317003,
        /// <summary>[requires: <b>XR_META_passthrough_preferences</b>] </summary>
        TypePassthroughPreferencesMeta = 1000217000,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] </summary>
        TypePassthroughStyleFb = 1000118020,
        /// <summary>[requires: <b>XR_META_performance_metrics</b>] </summary>
        TypePerformanceMetricsCounterMeta = 1000232002,
        /// <summary>[requires: <b>XR_META_performance_metrics</b>] </summary>
        TypePerformanceMetricsStateMeta = 1000232001,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] </summary>
        TypePlaneDetectorBeginInfoExt = 1000429002,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] </summary>
        TypePlaneDetectorCreateInfoExt = 1000429001,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] </summary>
        TypePlaneDetectorGetInfoExt = 1000429003,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] </summary>
        TypePlaneDetectorLocationExt = 1000429005,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] </summary>
        TypePlaneDetectorLocationsExt = 1000429004,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] </summary>
        TypePlaneDetectorPolygonBufferExt = 1000429006,
        /// <summary>[requires: <b>XR_META_recommended_layer_resolution</b>] </summary>
        TypeRecommendedLayerResolutionGetInfoMeta = 1000254001,
        /// <summary>[requires: <b>XR_META_recommended_layer_resolution</b>] </summary>
        TypeRecommendedLayerResolutionMeta = 1000254000,
        /// <summary></summary>
        TypeReferenceSpaceCreateInfo = 37,
        /// <summary>[requires: <b>XR_FB_render_model</b>] </summary>
        TypeRenderModelBufferFb = 1000119002,
        /// <summary>[requires: <b>XR_FB_render_model</b>] </summary>
        TypeRenderModelCapabilitiesRequestFb = 1000119005,
        /// <summary>[requires: <b>XR_FB_render_model</b>] </summary>
        TypeRenderModelLoadInfoFb = 1000119003,
        /// <summary>[requires: <b>XR_FB_render_model</b>] </summary>
        TypeRenderModelPathInfoFb = 1000119000,
        /// <summary>[requires: <b>XR_FB_render_model</b>] </summary>
        TypeRenderModelPropertiesFb = 1000119001,
        /// <summary>[requires: <b>XR_FB_scene</b>] </summary>
        TypeRoomLayoutFb = 1000175001,
        /// <summary>[requires: <b>XR_FB_scene_capture</b>] </summary>
        TypeSceneCaptureRequestInfoFb = 1000198050,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeSceneComponentLocationsMsft = 1000097006,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeSceneComponentParentFilterInfoMsft = 1000097009,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeSceneComponentsGetInfoMsft = 1000097005,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeSceneComponentsLocateInfoMsft = 1000097007,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeSceneComponentsMsft = 1000097004,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeSceneCreateInfoMsft = 1000097001,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding_serialization</b>] </summary>
        TypeSceneDeserializeInfoMsft = 1000098001,
        /// <summary>[requires: <b>XR_MSFT_scene_marker</b>] </summary>
        TypeSceneMarkerQrCodesMsft = 1000147002,
        /// <summary>[requires: <b>XR_MSFT_scene_marker</b>] </summary>
        TypeSceneMarkerTypeFilterMsft = 1000147001,
        /// <summary>[requires: <b>XR_MSFT_scene_marker</b>] </summary>
        TypeSceneMarkersMsft = 1000147000,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeSceneMeshBuffersGetInfoMsft = 1000097014,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeSceneMeshBuffersMsft = 1000097015,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeSceneMeshIndicesUint16Msft = 1000097018,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeSceneMeshIndicesUint32Msft = 1000097017,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeSceneMeshVertexBufferMsft = 1000097016,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeSceneMeshesMsft = 1000097013,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeSceneObjectTypesFilterInfoMsft = 1000097010,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeSceneObjectsMsft = 1000097008,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeSceneObserverCreateInfoMsft = 1000097000,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeScenePlaneAlignmentFilterInfoMsft = 1000097012,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeScenePlanesMsft = 1000097011,
        /// <summary>[requires: <b>XR_MSFT_secondary_view_configuration</b>] </summary>
        TypeSecondaryViewConfigurationFrameEndInfoMsft = 1000053003,
        /// <summary>[requires: <b>XR_MSFT_secondary_view_configuration</b>] </summary>
        TypeSecondaryViewConfigurationFrameStateMsft = 1000053002,
        /// <summary>[requires: <b>XR_MSFT_secondary_view_configuration</b>] </summary>
        TypeSecondaryViewConfigurationLayerInfoMsft = 1000053004,
        /// <summary>[requires: <b>XR_MSFT_secondary_view_configuration</b>] </summary>
        TypeSecondaryViewConfigurationSessionBeginInfoMsft = 1000053000,
        /// <summary>[requires: <b>XR_MSFT_secondary_view_configuration</b>] </summary>
        TypeSecondaryViewConfigurationStateMsft = 1000053001,
        /// <summary>[requires: <b>XR_MSFT_secondary_view_configuration</b>] </summary>
        TypeSecondaryViewConfigurationSwapchainCreateInfoMsft = 1000053005,
        /// <summary>[requires: <b>XR_FB_scene</b>] </summary>
        TypeSemanticLabelsFb = 1000175000,
        /// <summary>[requires: <b>XR_FB_scene</b>] </summary>
        TypeSemanticLabelsSupportInfoFb = 1000175010,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding_serialization</b>] </summary>
        TypeSerializedSceneFragmentDataGetInfoMsft = 1000098000,
        /// <summary></summary>
        TypeSessionActionSetsAttachInfo = 60,
        /// <summary></summary>
        TypeSessionBeginInfo = 10,
        /// <summary></summary>
        TypeSessionCreateInfo = 8,
        /// <summary>[requires: <b>XR_EXTX_overlay</b>] </summary>
        TypeSessionCreateInfoOverlayExtx = 1000033000,
        /// <summary>[requires: <b>XR_META_spatial_entity_sharing</b>] </summary>
        TypeShareSpacesInfoMeta = 1000290001,
        /// <summary>[requires: <b>XR_META_spatial_entity_group_sharing</b>] </summary>
        TypeShareSpacesRecipientGroupsMeta = 1000572000,
        /// <summary>[requires: <b>XR_FB_spatial_entity_query</b>] </summary>
        TypeSpaceComponentFilterInfoFb = 1000156052,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] </summary>
        TypeSpaceComponentStatusFb = 1000113001,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] </summary>
        TypeSpaceComponentStatusSetInfoFb = 1000113007,
        /// <summary>[requires: <b>XR_FB_spatial_entity_container</b>] </summary>
        TypeSpaceContainerFb = 1000199000,
        /// <summary>[requires: <b>XR_FB_spatial_entity_storage</b>] </summary>
        TypeSpaceEraseInfoFb = 1000158001,
        /// <summary>[requires: <b>XR_META_spatial_entity_group_sharing</b>] </summary>
        TypeSpaceGroupUuidFilterInfoMeta = 1000572001,
        /// <summary>[requires: <b>XR_FB_spatial_entity_storage_batch</b>] </summary>
        TypeSpaceListSaveInfoFb = 1000238000,
        /// <summary></summary>
        TypeSpaceLocation = 42,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        TypeSpaceLocations = 1000471001,
        /// <summary>[requires: <b>XR_KHR_locate_spaces</b>] </summary>
        TypeSpaceLocationsKhr = 1000471001,
        /// <summary>[requires: <b>XR_FB_spatial_entity_query</b>] </summary>
        TypeSpaceQueryInfoFb = 1000156001,
        /// <summary>[requires: <b>XR_FB_spatial_entity_query</b>] </summary>
        TypeSpaceQueryResultsFb = 1000156002,
        /// <summary>[requires: <b>XR_FB_spatial_entity_storage</b>] </summary>
        TypeSpaceSaveInfoFb = 1000158000,
        /// <summary>[requires: <b>XR_FB_spatial_entity_sharing</b>] </summary>
        TypeSpaceShareInfoFb = 1000169001,
        /// <summary>[requires: <b>XR_FB_spatial_entity_query</b>] </summary>
        TypeSpaceStorageLocationFilterInfoFb = 1000156003,
        /// <summary>[requires: <b>XR_META_spatial_entity_mesh</b>] </summary>
        TypeSpaceTriangleMeshGetInfoMeta = 1000269001,
        /// <summary>[requires: <b>XR_META_spatial_entity_mesh</b>] </summary>
        TypeSpaceTriangleMeshMeta = 1000269002,
        /// <summary>[requires: <b>XR_FB_spatial_entity_user</b>] </summary>
        TypeSpaceUserCreateInfoFb = 1000241001,
        /// <summary>[requires: <b>XR_FB_spatial_entity_query</b>] </summary>
        TypeSpaceUuidFilterInfoFb = 1000156054,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        TypeSpaceVelocities = 1000471002,
        /// <summary>[requires: <b>XR_KHR_locate_spaces</b>] </summary>
        TypeSpaceVelocitiesKhr = 1000471002,
        /// <summary></summary>
        TypeSpaceVelocity = 43,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        TypeSpacesLocateInfo = 1000471000,
        /// <summary>[requires: <b>XR_KHR_locate_spaces</b>] </summary>
        TypeSpacesLocateInfoKhr = 1000471000,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] </summary>
        TypeSpatialAnchorCreateInfoFb = 1000113003,
        /// <summary>[requires: <b>XR_HTC_anchor</b>] </summary>
        TypeSpatialAnchorCreateInfoHtc = 1000319001,
        /// <summary>[requires: <b>XR_MSFT_spatial_anchor</b>] </summary>
        TypeSpatialAnchorCreateInfoMsft = 1000039000,
        /// <summary>[requires: <b>XR_MSFT_spatial_anchor_persistence</b>] </summary>
        TypeSpatialAnchorFromPersistedAnchorCreateInfoMsft = 1000142001,
        /// <summary>[requires: <b>XR_MSFT_spatial_anchor_persistence</b>] </summary>
        TypeSpatialAnchorPersistenceInfoMsft = 1000142000,
        /// <summary>[requires: <b>XR_MSFT_spatial_anchor</b>] </summary>
        TypeSpatialAnchorSpaceCreateInfoMsft = 1000039001,
        /// <summary>[requires: <b>XR_ML_spatial_anchors</b>] </summary>
        TypeSpatialAnchorStateMl = 1000140002,
        /// <summary>[requires: <b>XR_ML_spatial_anchors</b>] </summary>
        TypeSpatialAnchorsCreateInfoFromPoseMl = 1000140000,
        /// <summary>[requires: <b>XR_ML_spatial_anchors_storage</b>] </summary>
        TypeSpatialAnchorsCreateInfoFromUuidsMl = 1000141003,
        /// <summary>[requires: <b>XR_ML_spatial_anchors_storage</b>] </summary>
        TypeSpatialAnchorsCreateStorageInfoMl = 1000141000,
        /// <summary>[requires: <b>XR_ML_spatial_anchors_storage</b>] </summary>
        TypeSpatialAnchorsDeleteCompletionDetailsMl = 1000141011,
        /// <summary>[requires: <b>XR_ML_spatial_anchors_storage</b>] </summary>
        TypeSpatialAnchorsDeleteCompletionMl = 1000141007,
        /// <summary>[requires: <b>XR_ML_spatial_anchors_storage</b>] </summary>
        TypeSpatialAnchorsDeleteInfoMl = 1000141006,
        /// <summary>[requires: <b>XR_ML_spatial_anchors_storage</b>] </summary>
        TypeSpatialAnchorsPublishCompletionDetailsMl = 1000141010,
        /// <summary>[requires: <b>XR_ML_spatial_anchors_storage</b>] </summary>
        TypeSpatialAnchorsPublishCompletionMl = 1000141005,
        /// <summary>[requires: <b>XR_ML_spatial_anchors_storage</b>] </summary>
        TypeSpatialAnchorsPublishInfoMl = 1000141004,
        /// <summary>[requires: <b>XR_ML_spatial_anchors_storage</b>] </summary>
        TypeSpatialAnchorsQueryCompletionMl = 1000141002,
        /// <summary>[requires: <b>XR_ML_spatial_anchors_storage</b>] </summary>
        TypeSpatialAnchorsQueryInfoRadiusMl = 1000141001,
        /// <summary>[requires: <b>XR_ML_spatial_anchors_storage</b>] </summary>
        TypeSpatialAnchorsUpdateExpirationCompletionDetailsMl = 1000141012,
        /// <summary>[requires: <b>XR_ML_spatial_anchors_storage</b>] </summary>
        TypeSpatialAnchorsUpdateExpirationCompletionMl = 1000141009,
        /// <summary>[requires: <b>XR_ML_spatial_anchors_storage</b>] </summary>
        TypeSpatialAnchorsUpdateExpirationInfoMl = 1000141008,
        /// <summary>[requires: <b>XR_MSFT_spatial_graph_bridge</b>] </summary>
        TypeSpatialGraphNodeBindingPropertiesGetInfoMsft = 1000049002,
        /// <summary>[requires: <b>XR_MSFT_spatial_graph_bridge</b>] </summary>
        TypeSpatialGraphNodeBindingPropertiesMsft = 1000049003,
        /// <summary>[requires: <b>XR_MSFT_spatial_graph_bridge</b>] </summary>
        TypeSpatialGraphNodeSpaceCreateInfoMsft = 1000049000,
        /// <summary>[requires: <b>XR_MSFT_spatial_graph_bridge</b>] </summary>
        TypeSpatialGraphStaticNodeBindingCreateInfoMsft = 1000049001,
        /// <summary></summary>
        TypeSwapchainCreateInfo = 9,
        /// <summary>[requires: <b>XR_FB_foveation</b>] </summary>
        TypeSwapchainCreateInfoFoveationFb = 1000114001,
        /// <summary></summary>
        TypeSwapchainImageAcquireInfo = 55,
        /// <summary>[requires: <b>XR_KHR_D3D11_enable</b>] </summary>
        TypeSwapchainImageD3d11Khr = 1000027001,
        /// <summary>[requires: <b>XR_KHR_D3D12_enable</b>] </summary>
        TypeSwapchainImageD3d12Khr = 1000028001,
        /// <summary>[requires: <b>XR_FB_foveation_vulkan</b>] </summary>
        TypeSwapchainImageFoveationVulkanFb = 1000160000,
        /// <summary>[requires: <b>XR_KHR_metal_enable</b>] </summary>
        TypeSwapchainImageMetalKhr = 1000029001,
        /// <summary>[requires: <b>XR_KHR_opengl_es_enable</b>] </summary>
        TypeSwapchainImageOpenglEsKhr = 1000024002,
        /// <summary>[requires: <b>XR_KHR_opengl_enable</b>] </summary>
        TypeSwapchainImageOpenglKhr = 1000023004,
        /// <summary></summary>
        TypeSwapchainImageReleaseInfo = 57,
        /// <summary>[requires: <b>XR_KHR_vulkan_enable</b>] </summary>
        TypeSwapchainImageVulkanKhr = 1000025001,
        /// <summary>[requires: <b>XR_KHR_vulkan_enable2</b>] </summary>
        TypeSwapchainImageVulkan2Khr = 1000025001,
        /// <summary></summary>
        TypeSwapchainImageWaitInfo = 56,
        /// <summary>[requires: <b>XR_FB_swapchain_update_state_android_surface</b>] </summary>
        TypeSwapchainStateAndroidSurfaceDimensionsFb = 1000161000,
        /// <summary>[requires: <b>XR_FB_foveation</b>] </summary>
        TypeSwapchainStateFoveationFb = 1000114002,
        /// <summary>[requires: <b>XR_FB_swapchain_update_state_opengl_es</b>] </summary>
        TypeSwapchainStateSamplerOpenglEsFb = 1000162000,
        /// <summary>[requires: <b>XR_FB_swapchain_update_state_vulkan</b>] </summary>
        TypeSwapchainStateSamplerVulkanFb = 1000163000,
        /// <summary>[requires: <b>XR_HTC_anchor</b>] </summary>
        TypeSystemAnchorPropertiesHtc = 1000319000,
        /// <summary>[requires: <b>XR_BD_body_tracking</b>] </summary>
        TypeSystemBodyTrackingPropertiesBd = 1000385004,
        /// <summary>[requires: <b>XR_FB_body_tracking</b>] </summary>
        TypeSystemBodyTrackingPropertiesFb = 1000076004,
        /// <summary>[requires: <b>XR_HTC_body_tracking</b>] </summary>
        TypeSystemBodyTrackingPropertiesHtc = 1000320000,
        /// <summary>[requires: <b>XR_META_colocation_discovery</b>] </summary>
        TypeSystemColocationDiscoveryPropertiesMeta = 1000571030,
        /// <summary>[requires: <b>XR_FB_color_space</b>] </summary>
        TypeSystemColorSpacePropertiesFb = 1000108000,
        /// <summary>[requires: <b>XR_META_environment_depth</b>] </summary>
        TypeSystemEnvironmentDepthPropertiesMeta = 1000291007,
        /// <summary>[requires: <b>XR_EXT_eye_gaze_interaction</b>] </summary>
        TypeSystemEyeGazeInteractionPropertiesExt = 1000030000,
        /// <summary>[requires: <b>XR_FB_eye_tracking_social</b>] </summary>
        TypeSystemEyeTrackingPropertiesFb = 1000202004,
        /// <summary>[requires: <b>XR_FB_face_tracking</b>] </summary>
        TypeSystemFaceTrackingPropertiesFb = 1000201004,
        /// <summary>[requires: <b>XR_FB_face_tracking2</b>] </summary>
        TypeSystemFaceTrackingProperties2Fb = 1000287013,
        /// <summary>[requires: <b>XR_ML_facial_expression</b>] </summary>
        TypeSystemFacialExpressionPropertiesMl = 1000482004,
        /// <summary>[requires: <b>XR_HTC_facial_tracking</b>] </summary>
        TypeSystemFacialTrackingPropertiesHtc = 1000104000,
        /// <summary>[requires: <b>XR_MNDX_force_feedback_curl</b>] </summary>
        TypeSystemForceFeedbackCurlPropertiesMndx = 1000375000,
        /// <summary>[requires: <b>XR_VARJO_foveated_rendering</b>] </summary>
        TypeSystemFoveatedRenderingPropertiesVarjo = 1000121002,
        /// <summary>[requires: <b>XR_META_foveation_eye_tracked</b>] </summary>
        TypeSystemFoveationEyeTrackedPropertiesMeta = 1000200002,
        /// <summary></summary>
        TypeSystemGetInfo = 4,
        /// <summary>[requires: <b>XR_MSFT_hand_tracking_mesh</b>] </summary>
        TypeSystemHandTrackingMeshPropertiesMsft = 1000052000,
        /// <summary>[requires: <b>XR_EXT_hand_tracking</b>] </summary>
        TypeSystemHandTrackingPropertiesExt = 1000051000,
        /// <summary>[requires: <b>XR_META_headset_id</b>] </summary>
        TypeSystemHeadsetIdPropertiesMeta = 1000245000,
        /// <summary>[requires: <b>XR_FB_keyboard_tracking</b>] </summary>
        TypeSystemKeyboardTrackingPropertiesFb = 1000116002,
        /// <summary>[requires: <b>XR_VARJO_marker_tracking</b>] </summary>
        TypeSystemMarkerTrackingPropertiesVarjo = 1000124000,
        /// <summary>[requires: <b>XR_ML_marker_understanding</b>] </summary>
        TypeSystemMarkerUnderstandingPropertiesMl = 1000138000,
        /// <summary>[requires: <b>XR_ML_system_notifications</b>] </summary>
        TypeSystemNotificationsSetInfoMl = 1000473000,
        /// <summary>[requires: <b>XR_META_passthrough_color_lut</b>] </summary>
        TypeSystemPassthroughColorLutPropertiesMeta = 1000266000,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] </summary>
        TypeSystemPassthroughPropertiesFb = 1000118000,
        /// <summary>[requires: <b>XR_FB_passthrough</b>] </summary>
        TypeSystemPassthroughProperties2Fb = 1000118006,
        /// <summary>[requires: <b>XR_EXT_plane_detection</b>] </summary>
        TypeSystemPlaneDetectionPropertiesExt = 1000429007,
        /// <summary></summary>
        TypeSystemProperties = 5,
        /// <summary>[requires: <b>XR_FB_render_model</b>] </summary>
        TypeSystemRenderModelPropertiesFb = 1000119004,
        /// <summary>[requires: <b>XR_FB_space_warp</b>] </summary>
        TypeSystemSpaceWarpPropertiesFb = 1000171001,
        /// <summary>[requires: <b>XR_META_spatial_entity_group_sharing</b>] </summary>
        TypeSystemSpatialEntityGroupSharingPropertiesMeta = 1000572100,
        /// <summary>[requires: <b>XR_FB_spatial_entity</b>] </summary>
        TypeSystemSpatialEntityPropertiesFb = 1000113004,
        /// <summary>[requires: <b>XR_META_spatial_entity_sharing</b>] </summary>
        TypeSystemSpatialEntitySharingPropertiesMeta = 1000290000,
        /// <summary>[requires: <b>XR_EXT_user_presence</b>] </summary>
        TypeSystemUserPresencePropertiesExt = 1000470001,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] </summary>
        TypeSystemVirtualKeyboardPropertiesMeta = 1000219001,
        /// <summary>[requires: <b>XR_FB_triangle_mesh</b>] </summary>
        TypeTriangleMeshCreateInfoFb = 1000117001,
        /// <summary></summary>
        TypeUnknown = 0,
        /// <summary>[requires: <b>XR_ML_user_calibration</b>] </summary>
        TypeUserCalibrationEnableEventsInfoMl = 1000472002,
        /// <summary></summary>
        TypeView = 7,
        /// <summary>[requires: <b>XR_EXT_view_configuration_depth_range</b>] </summary>
        TypeViewConfigurationDepthRangeExt = 1000046000,
        /// <summary></summary>
        TypeViewConfigurationProperties = 45,
        /// <summary></summary>
        TypeViewConfigurationView = 41,
        /// <summary>[requires: <b>XR_EPIC_view_configuration_fov</b>] </summary>
        TypeViewConfigurationViewFovEpic = 1000059000,
        /// <summary>[requires: <b>XR_VARJO_foveated_rendering</b>] </summary>
        TypeViewLocateFoveatedRenderingVarjo = 1000121000,
        /// <summary></summary>
        TypeViewLocateInfo = 6,
        /// <summary></summary>
        TypeViewState = 11,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] </summary>
        TypeVirtualKeyboardAnimationStateMeta = 1000219006,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] </summary>
        TypeVirtualKeyboardCreateInfoMeta = 1000219002,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] </summary>
        TypeVirtualKeyboardInputInfoMeta = 1000219010,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] </summary>
        TypeVirtualKeyboardLocationInfoMeta = 1000219004,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] </summary>
        TypeVirtualKeyboardModelAnimationStatesMeta = 1000219007,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] </summary>
        TypeVirtualKeyboardModelVisibilitySetInfoMeta = 1000219005,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] </summary>
        TypeVirtualKeyboardSpaceCreateInfoMeta = 1000219003,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] </summary>
        TypeVirtualKeyboardTextContextChangeInfoMeta = 1000219011,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] </summary>
        TypeVirtualKeyboardTextureDataMeta = 1000219009,
        /// <summary>[requires: <b>XR_KHR_visibility_mask</b>] </summary>
        TypeVisibilityMaskKhr = 1000031000,
        /// <summary>[requires: <b>XR_MSFT_scene_understanding</b>] </summary>
        TypeVisualMeshComputeLodInfoMsft = 1000097003,
        /// <summary>[requires: <b>XR_HTCX_vive_tracker_interaction</b>] </summary>
        TypeViveTrackerPathsHtcx = 1000103000,
        /// <summary>[requires: <b>XR_KHR_vulkan_enable2</b>] </summary>
        TypeVulkanDeviceCreateInfoKhr = 1000090001,
        /// <summary>[requires: <b>XR_KHR_vulkan_enable2</b>] </summary>
        TypeVulkanGraphicsDeviceGetInfoKhr = 1000090003,
        /// <summary>[requires: <b>XR_KHR_vulkan_enable2</b>] </summary>
        TypeVulkanInstanceCreateInfoKhr = 1000090000,
        /// <summary>[requires: <b>XR_META_vulkan_swapchain_create_info</b>] </summary>
        TypeVulkanSwapchainCreateInfoMeta = 1000227000,
        /// <summary>[requires: <b>XR_KHR_vulkan_swapchain_format_list</b>] </summary>
        TypeVulkanSwapchainFormatListCreateInfoKhr = 1000014000,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] </summary>
        TypeWorldMeshBlockMl = 1000474010,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] </summary>
        TypeWorldMeshBlockRequestMl = 1000474008,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] </summary>
        TypeWorldMeshBlockStateMl = 1000474003,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] </summary>
        TypeWorldMeshBufferMl = 1000474007,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] </summary>
        TypeWorldMeshBufferRecommendedSizeInfoMl = 1000474005,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] </summary>
        TypeWorldMeshBufferSizeMl = 1000474006,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] </summary>
        TypeWorldMeshDetectorCreateInfoMl = 1000474001,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] </summary>
        TypeWorldMeshGetInfoMl = 1000474009,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] </summary>
        TypeWorldMeshRequestCompletionInfoMl = 1000474012,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] </summary>
        TypeWorldMeshRequestCompletionMl = 1000474011,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] </summary>
        TypeWorldMeshStateRequestCompletionMl = 1000474004,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] </summary>
        TypeWorldMeshStateRequestInfoMl = 1000474002,
    }
    /// <summary></summary>
    [Flags]
    public enum XrSwapchainCreateFlagBits : ulong
    {
        /// <summary>Content will be protected from CPU access</summary>
        SwapchainCreateProtectedContentBit = 1,
        /// <summary>Only one image will be acquired from this swapchain over its lifetime</summary>
        SwapchainCreateStaticImageBit = 2,
    }
    /// <summary></summary>
    [Flags]
    public enum XrSwapchainCreateFoveationFlagBitsFB : ulong
    {
        /// <summary>Explicitly create the swapchain with fragment density map foveation support. The application must ensure that the swapchain is using the Vulkan graphics API and that the VK_EXT_fragment_density_map extension is supported and enabled.</summary>
        SwapchainCreateFoveationFragmentDensityMapBitFb = 2,
        /// <summary>Explicitly create the swapchain with scaled bin foveation support. The application must ensure that the swapchain is using the OpenGL graphics API and that the QCOM_texture_foveated extension is supported and enabled.</summary>
        SwapchainCreateFoveationScaledBinBitFb = 1,
    }
    /// <summary></summary>
    [Flags]
    public enum XrSwapchainStateFoveationFlagBitsFB : ulong
    {
    }
    /// <summary></summary>
    [Flags]
    public enum XrSwapchainUsageFlagBits : ulong
    {
        /// <summary>Specifies that the image may: be a color rendering target.</summary>
        SwapchainUsageColorAttachmentBit = 1,
        /// <summary>Specifies that the image may: be a depth/stencil rendering target.</summary>
        SwapchainUsageDepthStencilAttachmentBit = 2,
        /// <summary>[requires: <b>XR_KHR_swapchain_usage_input_attachment_bit</b>] Specifies that the image may: be used as a input attachment.</summary>
        SwapchainUsageInputAttachmentBitKhr = 128,
        /// <summary>[requires: <b>XR_MND_swapchain_usage_input_attachment_bit</b>] Specifies that the image may: be used as a input attachment.</summary>
        SwapchainUsageInputAttachmentBitMnd = 128,
        /// <summary>Specifies that the image may: be reinterpreted as another image format.</summary>
        SwapchainUsageMutableFormatBit = 64,
        /// <summary>Specifies that the image may: be sampled by a shader.</summary>
        SwapchainUsageSampledBit = 32,
        /// <summary>Specifies that the image may: be used as the destination of a transfer operation.</summary>
        SwapchainUsageTransferDstBit = 16,
        /// <summary>Specifies that the image may: be used as the source of a transfer operation.</summary>
        SwapchainUsageTransferSrcBit = 8,
        /// <summary>Specifies that the image may: be accessed out of order and that access may: be via atomic operations.</summary>
        SwapchainUsageUnorderedAccessBit = 4,
    }
    /// <summary><b>[requires: XR_QCOM_tracking_optimization_settings]</b> Used by <see cref="Xr.SetTrackingOptimizationSettingsHintQCOM"/></summary>
    public enum XrTrackingOptimizationSettingsDomainQCOM : int
    {
        /// <summary>[requires: <b>XR_QCOM_tracking_optimization_settings</b>] Setting applies to all QCOM tracking extensions.</summary>
        TrackingOptimizationSettingsDomainAllQcom = 1,
    }
    /// <summary><b>[requires: XR_QCOM_tracking_optimization_settings]</b> Used by <see cref="Xr.SetTrackingOptimizationSettingsHintQCOM"/></summary>
    public enum XrTrackingOptimizationSettingsHintQCOM : int
    {
        /// <summary>[requires: <b>XR_QCOM_tracking_optimization_settings</b>] Used by the application to indicate that it prefers tracking to be optimized for close range, possibly at the expense of competing interests.</summary>
        TrackingOptimizationSettingsHintCloseRangePriorizationQcom = 2,
        /// <summary>[requires: <b>XR_QCOM_tracking_optimization_settings</b>] Used by the application to indicate that it prefers tracking to be optimized for increased tracking performance, possibly at the cost of increased power consumption.</summary>
        TrackingOptimizationSettingsHintHighPowerPriorizationQcom = 4,
        /// <summary>[requires: <b>XR_QCOM_tracking_optimization_settings</b>] Used by the application to indicate that it prefers tracking to be optimized for long range, possibly at the expense of competing interests.</summary>
        TrackingOptimizationSettingsHintLongRangePriorizationQcom = 1,
        /// <summary>[requires: <b>XR_QCOM_tracking_optimization_settings</b>] Used by the application to indicate that it prefers tracking to be optimized for low power consumption, possibly at the expense of competing interests.</summary>
        TrackingOptimizationSettingsHintLowPowerPriorizationQcom = 3,
        /// <summary>[requires: <b>XR_QCOM_tracking_optimization_settings</b>] Used by the application to indicate that it does not have a preference to optimize for. The run-time is understood to choose a balanced approach.</summary>
        TrackingOptimizationSettingsHintNoneQcom = 0,
    }
    /// <summary></summary>
    [Flags]
    public enum XrTriangleMeshFlagBitsFB : ulong
    {
        /// <summary>The triangle mesh is mutable (can be modified after it is created).</summary>
        TriangleMeshMutableBitFb = 1,
    }
    /// <summary>Used by <see cref="Xr.EnumerateEnvironmentBlendModes"/>, <see cref="Xr.EnumerateReprojectionModesMSFT"/>, <see cref="Xr.EnumerateViewConfigurations"/>, ...</summary>
    public enum XrViewConfigurationType : int
    {
        /// <summary></summary>
        ViewConfigurationTypePrimaryMono = 1,
        /// <summary>[requires: <b>XR_VARJO_quad_views</b>] </summary>
        ViewConfigurationTypePrimaryQuadVarjo = 1000037000,
        /// <summary></summary>
        ViewConfigurationTypePrimaryStereo = 2,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ViewConfigurationTypePrimaryStereoWithFoveatedInset = 1000037000,
        /// <summary>[requires: <b>XR_MSFT_first_person_observer</b>] </summary>
        ViewConfigurationTypeSecondaryMonoFirstPersonObserverMsft = 1000054000,
    }
    /// <summary></summary>
    [Flags]
    public enum XrViewStateFlagBits : ulong
    {
        /// <summary>Indicates whether all slink:XrView orientations are actively tracked</summary>
        ViewStateOrientationTrackedBit = 4,
        /// <summary>Indicates validity of all slink:XrView orientations</summary>
        ViewStateOrientationValidBit = 1,
        /// <summary>Indicates whether all slink:XrView positions are actively tracked</summary>
        ViewStatePositionTrackedBit = 8,
        /// <summary>Indicates validity of all slink:XrView positions</summary>
        ViewStatePositionValidBit = 2,
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
    public enum XrVirtualKeyboardInputSourceMETA : int
    {
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] Left controller direct touch.</summary>
        VirtualKeyboardInputSourceControllerDirectLeftMeta = 5,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] Right controller direct touch.</summary>
        VirtualKeyboardInputSourceControllerDirectRightMeta = 6,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] Left controller ray.</summary>
        VirtualKeyboardInputSourceControllerRayLeftMeta = 1,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] Right controller ray.</summary>
        VirtualKeyboardInputSourceControllerRayRightMeta = 2,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] Left hand direct touch.</summary>
        VirtualKeyboardInputSourceHandDirectIndexTipLeftMeta = 7,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] Right hand direct touch.</summary>
        VirtualKeyboardInputSourceHandDirectIndexTipRightMeta = 8,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] Left hand ray.</summary>
        VirtualKeyboardInputSourceHandRayLeftMeta = 3,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] Right hand ray.</summary>
        VirtualKeyboardInputSourceHandRayRightMeta = 4,
    }
    /// <summary></summary>
    [Flags]
    public enum XrVirtualKeyboardInputStateFlagBitsMETA : ulong
    {
        /// <summary>If the input source is considered &apos;pressed&apos; at all. Pinch for hands, Primary button for controllers.</summary>
        VirtualKeyboardInputStatePressedBitMeta = 1,
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
    public enum XrVirtualKeyboardLocationTypeMETA : int
    {
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] Indicates that the application will provide the position and scale of the keyboard.</summary>
        VirtualKeyboardLocationTypeCustomMeta = 0,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] Indicates that the runtime will set the position and scale for direct interaction keyboard.</summary>
        VirtualKeyboardLocationTypeDirectMeta = 2,
        /// <summary>[requires: <b>XR_META_virtual_keyboard</b>] Indicates that the runtime will set the position and scale for far field keyboard.</summary>
        VirtualKeyboardLocationTypeFarMeta = 1,
    }
    /// <summary><b>[requires: XR_KHR_visibility_mask]</b> Used by <see cref="Xr.GetVisibilityMaskKHR"/></summary>
    public enum XrVisibilityMaskTypeKHR : int
    {
        /// <summary>[requires: <b>XR_KHR_visibility_mask</b>] exclusive mesh; indicates that which the viewer cannot see.</summary>
        VisibilityMaskTypeHiddenTriangleMeshKhr = 1,
        /// <summary>[requires: <b>XR_KHR_visibility_mask</b>] line loop; traces the outline of the area the viewer can see.</summary>
        VisibilityMaskTypeLineLoopKhr = 3,
        /// <summary>[requires: <b>XR_KHR_visibility_mask</b>] inclusive mesh; indicates strictly that which the viewer can see.</summary>
        VisibilityMaskTypeVisibleTriangleMeshKhr = 2,
    }
    /// <summary></summary>
    [Flags]
    public enum XrVulkanDeviceCreateFlagBitsKHR : ulong
    {
    }
    /// <summary></summary>
    [Flags]
    public enum XrVulkanInstanceCreateFlagBitsKHR : ulong
    {
    }
    /// <summary><b>[requires: XR_FB_triangle_mesh]</b> </summary>
    public enum XrWindingOrderFB : int
    {
        /// <summary>[requires: <b>XR_FB_triangle_mesh</b>] Counter-clockwise winding order</summary>
        WindingOrderCcwFb = 2,
        /// <summary>[requires: <b>XR_FB_triangle_mesh</b>] Clockwise winding order</summary>
        WindingOrderCwFb = 1,
        /// <summary>[requires: <b>XR_FB_triangle_mesh</b>] Winding order is unknown and the runtime cannot make any assumptions on the triangle orientation</summary>
        WindingOrderUnknownFb = 0,
    }
    /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> </summary>
    public enum XrWorldMeshBlockResultML : int
    {
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] Mesh request has failed.</summary>
        WorldMeshBlockResultFailedMl = 1,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] There are partial updates on the mesh request.</summary>
        WorldMeshBlockResultPartialUpdateMl = 3,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] Mesh request is pending.</summary>
        WorldMeshBlockResultPendingMl = 2,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] Mesh request has succeeded.</summary>
        WorldMeshBlockResultSuccessMl = 0,
    }
    /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> </summary>
    public enum XrWorldMeshBlockStatusML : int
    {
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] The mesh block has been deleted.</summary>
        WorldMeshBlockStatusDeletedMl = 2,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] The mesh block has been created.</summary>
        WorldMeshBlockStatusNewMl = 0,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] The mesh block is unchanged.</summary>
        WorldMeshBlockStatusUnchangedMl = 3,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] The mesh block has been updated.</summary>
        WorldMeshBlockStatusUpdatedMl = 1,
    }
    /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> </summary>
    [Flags]
    public enum XrWorldMeshDetectorFlagBitsML : ulong
    {
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] If set, the system will compute the confidence values.</summary>
        WorldMeshDetectorComputeConfidenceBitMl = 4,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] If set, the system will compute the normals for the triangle vertices.</summary>
        WorldMeshDetectorComputeNormalsBitMl = 2,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] If set, winding order of indices will be be changed from counter clockwise to clockwise.</summary>
        WorldMeshDetectorIndexOrderCwBitMl = 32,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] If set, the system will planarize the returned mesh (planar regions will be smoothed out).</summary>
        WorldMeshDetectorPlanarizeBitMl = 8,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] If set, will return a point cloud instead of a triangle mesh.</summary>
        WorldMeshDetectorPointCloudBitMl = 1,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] If set, the mesh skirt (overlapping area between two mesh blocks) will be removed.</summary>
        WorldMeshDetectorRemoveMeshSkirtBitMl = 16,
    }
    /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> </summary>
    public enum XrWorldMeshDetectorLodML : int
    {
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] Maximum Level of Detail (LOD) for the mesh.</summary>
        WorldMeshDetectorLodMaximumMl = 2,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] Medium Level of Detail (LOD) for the mesh.</summary>
        WorldMeshDetectorLodMediumMl = 1,
        /// <summary>[requires: <b>XR_ML_world_mesh_detection</b>] Minimum Level of Detail (LOD) for the mesh.</summary>
        WorldMeshDetectorLodMinimumMl = 0,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
