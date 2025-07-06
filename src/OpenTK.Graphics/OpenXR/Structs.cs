// This file is auto generated, do not edit.
using OpenTK.Mathematics;
using OpenTK.Graphics.Vulkan;
using OpenTK.Graphics.Egl;
using OpenTK.Graphics.Glx;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenXR
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>Used by <see cref="Xr.CreateAction"/></summary>
    public unsafe struct XrActionCreateInfo
    {
        public XrStructureType type = XrStructureType.TypeActionCreateInfo;
        public void* next;
        [InlineArray(64)]
        public struct actionNameInlineArray1
        {
            public byte element;
        }
        public actionNameInlineArray1 actionName;
        public XrActionType actionType;
        public uint countSubactionPaths;
        public ulong* subactionPaths;
        [InlineArray(128)]
        public struct localizedActionNameInlineArray1
        {
            public byte element;
        }
        public localizedActionNameInlineArray1 localizedActionName;
        public XrActionCreateInfo() { }
    }
    /// <summary>Used by <see cref="Xr.CreateActionSet"/></summary>
    public unsafe struct XrActionSetCreateInfo
    {
        public XrStructureType type = XrStructureType.TypeActionSetCreateInfo;
        public void* next;
        [InlineArray(64)]
        public struct actionSetNameInlineArray1
        {
            public byte element;
        }
        public actionSetNameInlineArray1 actionSetName;
        [InlineArray(128)]
        public struct localizedActionSetNameInlineArray1
        {
            public byte element;
        }
        public localizedActionSetNameInlineArray1 localizedActionSetName;
        public uint priority;
        public XrActionSetCreateInfo() { }
    }
    /// <summary>Used by <see cref="Xr.CreateActionSpace"/></summary>
    public unsafe struct XrActionSpaceCreateInfo
    {
        public XrStructureType type = XrStructureType.TypeActionSpaceCreateInfo;
        public void* next;
        public XrAction action;
        public ulong subactionPath;
        public XrPosef poseInActionSpace;
        public XrActionSpaceCreateInfo() { }
        public XrActionSpaceCreateInfo(XrStructureType type, void* next, XrAction action, ulong subactionPath, XrPosef poseInActionSpace)
        {
            this.type = type;
            this.next = next;
            this.action = action;
            this.subactionPath = subactionPath;
            this.poseInActionSpace = poseInActionSpace;
        }
    }
    /// <summary>Used by <see cref="Xr.SyncActions"/></summary>
    public unsafe struct XrActionsSyncInfo
    {
        public XrStructureType type = XrStructureType.TypeActionsSyncInfo;
        public void* next;
        public uint countActiveActionSets;
        public XrActiveActionSet* activeActionSets;
        public XrActionsSyncInfo() { }
        public XrActionsSyncInfo(XrStructureType type, void* next, uint countActiveActionSets, XrActiveActionSet* activeActionSets)
        {
            this.type = type;
            this.next = next;
            this.countActiveActionSets = countActiveActionSets;
            this.activeActionSets = activeActionSets;
        }
    }
    /// <summary>Used by <see cref="Xr.GetActionStateBoolean"/></summary>
    public unsafe struct XrActionStateBoolean
    {
        public XrStructureType type = XrStructureType.TypeActionStateBoolean;
        public void* next;
        public int currentState;
        public int changedSinceLastSync;
        public long lastChangeTime;
        public int isActive;
        public XrActionStateBoolean() { }
        public XrActionStateBoolean(XrStructureType type, void* next, int currentState, int changedSinceLastSync, long lastChangeTime, int isActive)
        {
            this.type = type;
            this.next = next;
            this.currentState = currentState;
            this.changedSinceLastSync = changedSinceLastSync;
            this.lastChangeTime = lastChangeTime;
            this.isActive = isActive;
        }
    }
    /// <summary>Used by <see cref="Xr.GetActionStateFloat"/></summary>
    public unsafe struct XrActionStateFloat
    {
        public XrStructureType type = XrStructureType.TypeActionStateFloat;
        public void* next;
        public float currentState;
        public int changedSinceLastSync;
        public long lastChangeTime;
        public int isActive;
        public XrActionStateFloat() { }
        public XrActionStateFloat(XrStructureType type, void* next, float currentState, int changedSinceLastSync, long lastChangeTime, int isActive)
        {
            this.type = type;
            this.next = next;
            this.currentState = currentState;
            this.changedSinceLastSync = changedSinceLastSync;
            this.lastChangeTime = lastChangeTime;
            this.isActive = isActive;
        }
    }
    /// <summary>Used by <see cref="Xr.GetActionStateBoolean"/>, <see cref="Xr.GetActionStateFloat"/>, <see cref="Xr.GetActionStatePose"/>, ...</summary>
    public unsafe struct XrActionStateGetInfo
    {
        public XrStructureType type = XrStructureType.TypeActionStateGetInfo;
        public void* next;
        public XrAction action;
        public ulong subactionPath;
        public XrActionStateGetInfo() { }
        public XrActionStateGetInfo(XrStructureType type, void* next, XrAction action, ulong subactionPath)
        {
            this.type = type;
            this.next = next;
            this.action = action;
            this.subactionPath = subactionPath;
        }
    }
    /// <summary>Used by <see cref="Xr.GetActionStatePose"/></summary>
    public unsafe struct XrActionStatePose
    {
        public XrStructureType type = XrStructureType.TypeActionStatePose;
        public void* next;
        public int isActive;
        public XrActionStatePose() { }
        public XrActionStatePose(XrStructureType type, void* next, int isActive)
        {
            this.type = type;
            this.next = next;
            this.isActive = isActive;
        }
    }
    /// <summary>Used by <see cref="Xr.GetActionStateVector2f"/></summary>
    public unsafe struct XrActionStateVector2f
    {
        public XrStructureType type = XrStructureType.TypeActionStateVector2f;
        public void* next;
        public XrVector2f currentState;
        public int changedSinceLastSync;
        public long lastChangeTime;
        public int isActive;
        public XrActionStateVector2f() { }
        public XrActionStateVector2f(XrStructureType type, void* next, XrVector2f currentState, int changedSinceLastSync, long lastChangeTime, int isActive)
        {
            this.type = type;
            this.next = next;
            this.currentState = currentState;
            this.changedSinceLastSync = changedSinceLastSync;
            this.lastChangeTime = lastChangeTime;
            this.isActive = isActive;
        }
    }
    /// <summary></summary>
    public unsafe struct XrActionSuggestedBinding
    {
        public XrAction action;
        public ulong binding;
        public XrActionSuggestedBinding() { }
        public XrActionSuggestedBinding(XrAction action, ulong binding)
        {
            this.action = action;
            this.binding = binding;
        }
    }
    /// <summary></summary>
    public unsafe struct XrActiveActionSet
    {
        public XrActionSet actionSet;
        public ulong subactionPath;
        public XrActiveActionSet() { }
        public XrActiveActionSet(XrActionSet actionSet, ulong subactionPath)
        {
            this.actionSet = actionSet;
            this.subactionPath = subactionPath;
        }
    }
    /// <summary><b>[requires: XR_EXT_active_action_set_priority]</b> </summary>
    public unsafe struct XrActiveActionSetPrioritiesEXT
    {
        public XrStructureType type = XrStructureType.TypeActiveActionSetPrioritiesExt;
        public void* next;
        public uint actionSetPriorityCount;
        public XrActiveActionSetPriorityEXT* actionSetPriorities;
        public XrActiveActionSetPrioritiesEXT() { }
        public XrActiveActionSetPrioritiesEXT(XrStructureType type, void* next, uint actionSetPriorityCount, XrActiveActionSetPriorityEXT* actionSetPriorities)
        {
            this.type = type;
            this.next = next;
            this.actionSetPriorityCount = actionSetPriorityCount;
            this.actionSetPriorities = actionSetPriorities;
        }
    }
    /// <summary><b>[requires: XR_EXT_active_action_set_priority]</b> </summary>
    public unsafe struct XrActiveActionSetPriorityEXT
    {
        public XrActionSet actionSet;
        public uint priorityOverride;
        public XrActiveActionSetPriorityEXT() { }
        public XrActiveActionSetPriorityEXT(XrActionSet actionSet, uint priorityOverride)
        {
            this.actionSet = actionSet;
            this.priorityOverride = priorityOverride;
        }
    }
    /// <summary><b>[requires: XR_FB_android_surface_swapchain_create]</b> </summary>
    public unsafe struct XrAndroidSurfaceSwapchainCreateInfoFB
    {
        public XrStructureType type = XrStructureType.TypeAndroidSurfaceSwapchainCreateInfoFb;
        public void* next;
        public XrAndroidSurfaceSwapchainFlagBitsFB createFlags;
        public XrAndroidSurfaceSwapchainCreateInfoFB() { }
        public XrAndroidSurfaceSwapchainCreateInfoFB(XrStructureType type, void* next, XrAndroidSurfaceSwapchainFlagBitsFB createFlags)
        {
            this.type = type;
            this.next = next;
            this.createFlags = createFlags;
        }
    }
    /// <summary>Used by <see cref="Xr.CreateApiLayerInstance"/></summary>
    public unsafe struct XrApiLayerCreateInfo
    {
        public XrLoaderInterfaceStructs structType;
        public uint structVersion;
        public nuint structSize;
        public void* loaderInstance;
        [InlineArray(512)]
        public struct settings_file_locationInlineArray1
        {
            public byte element;
        }
        public settings_file_locationInlineArray1 settings_file_location;
        public XrApiLayerNextInfo* nextInfo;
        public XrApiLayerCreateInfo() { }
    }
    /// <summary></summary>
    public unsafe struct XrApiLayerNextInfo
    {
        public XrLoaderInterfaceStructs structType;
        public uint structVersion;
        public nuint structSize;
        [InlineArray(256)]
        public struct layerNameInlineArray1
        {
            public byte element;
        }
        public layerNameInlineArray1 layerName;
        public delegate* unmanaged[Cdecl]<XrInstance, byte*, void*, XrResult> nextGetInstanceProcAddr;
        public delegate* unmanaged[Cdecl]<XrInstanceCreateInfo*, XrApiLayerCreateInfo*, byte*, XrInstance*, XrResult> nextCreateApiLayerInstance;
        public XrApiLayerNextInfo* next;
        public XrApiLayerNextInfo() { }
    }
    /// <summary>Used by <see cref="Xr.EnumerateApiLayerProperties"/></summary>
    public unsafe struct XrApiLayerProperties
    {
        public XrStructureType type = XrStructureType.TypeApiLayerProperties;
        public void* next;
        [InlineArray(256)]
        public struct layerNameInlineArray1
        {
            public byte element;
        }
        public layerNameInlineArray1 layerName;
        public ulong specVersion;
        public uint layerVersion;
        [InlineArray(256)]
        public struct descriptionInlineArray1
        {
            public byte element;
        }
        public descriptionInlineArray1 description;
        public XrApiLayerProperties() { }
    }
    /// <summary></summary>
    public unsafe struct XrApplicationInfo
    {
        [InlineArray(128)]
        public struct applicationNameInlineArray1
        {
            public byte element;
        }
        public applicationNameInlineArray1 applicationName;
        public uint applicationVersion;
        [InlineArray(128)]
        public struct engineNameInlineArray1
        {
            public byte element;
        }
        public engineNameInlineArray1 engineName;
        public uint engineVersion;
        public ulong apiVersion;
        public XrApplicationInfo() { }
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    public unsafe struct XrBaseInStructure
    {
        public XrStructureType type;
        public XrBaseInStructure* next;
        public XrBaseInStructure() { }
        public XrBaseInStructure(XrStructureType type, XrBaseInStructure* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    public unsafe struct XrBaseOutStructure
    {
        public XrStructureType type;
        public XrBaseOutStructure* next;
        public XrBaseOutStructure() { }
        public XrBaseOutStructure(XrStructureType type, XrBaseOutStructure* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_KHR_binding_modification]</b> </summary>
    public unsafe struct XrBindingModificationBaseHeaderKHR
    {
        public XrStructureType type;
        public void* next;
        public XrBindingModificationBaseHeaderKHR() { }
        public XrBindingModificationBaseHeaderKHR(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_KHR_binding_modification]</b> </summary>
    public unsafe struct XrBindingModificationsKHR
    {
        public XrStructureType type = XrStructureType.TypeBindingModificationsKhr;
        public void* next;
        public uint bindingModificationCount;
        public XrBindingModificationBaseHeaderKHR** bindingModifications;
        public XrBindingModificationsKHR() { }
        public XrBindingModificationsKHR(XrStructureType type, void* next, uint bindingModificationCount, XrBindingModificationBaseHeaderKHR** bindingModifications)
        {
            this.type = type;
            this.next = next;
            this.bindingModificationCount = bindingModificationCount;
            this.bindingModifications = bindingModifications;
        }
    }
    /// <summary><b>[requires: XR_BD_body_tracking]</b> </summary>
    public unsafe struct XrBodyJointLocationBD
    {
        public XrSpaceLocationFlagBits locationFlags;
        public XrPosef pose;
        public XrBodyJointLocationBD() { }
        public XrBodyJointLocationBD(XrSpaceLocationFlagBits locationFlags, XrPosef pose)
        {
            this.locationFlags = locationFlags;
            this.pose = pose;
        }
    }
    /// <summary><b>[requires: XR_FB_body_tracking]</b> </summary>
    public unsafe struct XrBodyJointLocationFB
    {
        public XrSpaceLocationFlagBits locationFlags;
        public XrPosef pose;
        public XrBodyJointLocationFB() { }
        public XrBodyJointLocationFB(XrSpaceLocationFlagBits locationFlags, XrPosef pose)
        {
            this.locationFlags = locationFlags;
            this.pose = pose;
        }
    }
    /// <summary><b>[requires: XR_HTC_body_tracking]</b> </summary>
    public unsafe struct XrBodyJointLocationHTC
    {
        public XrSpaceLocationFlagBits locationFlags;
        public XrPosef pose;
        public XrBodyJointLocationHTC() { }
        public XrBodyJointLocationHTC(XrSpaceLocationFlagBits locationFlags, XrPosef pose)
        {
            this.locationFlags = locationFlags;
            this.pose = pose;
        }
    }
    /// <summary><b>[requires: XR_BD_body_tracking]</b> Used by <see cref="Xr.LocateBodyJointsBD"/></summary>
    public unsafe struct XrBodyJointLocationsBD
    {
        public XrStructureType type = XrStructureType.TypeBodyJointLocationsBd;
        public void* next;
        public int allJointPosesTracked;
        public uint jointLocationCount;
        public XrBodyJointLocationBD* jointLocations;
        public XrBodyJointLocationsBD() { }
        public XrBodyJointLocationsBD(XrStructureType type, void* next, int allJointPosesTracked, uint jointLocationCount, XrBodyJointLocationBD* jointLocations)
        {
            this.type = type;
            this.next = next;
            this.allJointPosesTracked = allJointPosesTracked;
            this.jointLocationCount = jointLocationCount;
            this.jointLocations = jointLocations;
        }
    }
    /// <summary><b>[requires: XR_FB_body_tracking]</b> Used by <see cref="Xr.LocateBodyJointsFB"/></summary>
    public unsafe struct XrBodyJointLocationsFB
    {
        public XrStructureType type = XrStructureType.TypeBodyJointLocationsFb;
        public void* next;
        public int isActive;
        public float confidence;
        public uint jointCount;
        public XrBodyJointLocationFB* jointLocations;
        public uint skeletonChangedCount;
        public long time;
        public XrBodyJointLocationsFB() { }
        public XrBodyJointLocationsFB(XrStructureType type, void* next, int isActive, float confidence, uint jointCount, XrBodyJointLocationFB* jointLocations, uint skeletonChangedCount, long time)
        {
            this.type = type;
            this.next = next;
            this.isActive = isActive;
            this.confidence = confidence;
            this.jointCount = jointCount;
            this.jointLocations = jointLocations;
            this.skeletonChangedCount = skeletonChangedCount;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_HTC_body_tracking]</b> Used by <see cref="Xr.LocateBodyJointsHTC"/></summary>
    public unsafe struct XrBodyJointLocationsHTC
    {
        public XrStructureType type = XrStructureType.TypeBodyJointLocationsHtc;
        public void* next;
        public XrSpaceLocationFlagBits combinedLocationFlags;
        public XrBodyJointConfidenceHTC confidenceLevel;
        public uint jointLocationCount;
        public XrBodyJointLocationHTC* jointLocations;
        public uint skeletonGenerationId;
        public XrBodyJointLocationsHTC() { }
        public XrBodyJointLocationsHTC(XrStructureType type, void* next, XrSpaceLocationFlagBits combinedLocationFlags, XrBodyJointConfidenceHTC confidenceLevel, uint jointLocationCount, XrBodyJointLocationHTC* jointLocations, uint skeletonGenerationId)
        {
            this.type = type;
            this.next = next;
            this.combinedLocationFlags = combinedLocationFlags;
            this.confidenceLevel = confidenceLevel;
            this.jointLocationCount = jointLocationCount;
            this.jointLocations = jointLocations;
            this.skeletonGenerationId = skeletonGenerationId;
        }
    }
    /// <summary><b>[requires: XR_BD_body_tracking]</b> Used by <see cref="Xr.LocateBodyJointsBD"/></summary>
    public unsafe struct XrBodyJointsLocateInfoBD
    {
        public XrStructureType type = XrStructureType.TypeBodyJointsLocateInfoBd;
        public void* next;
        public XrSpace baseSpace;
        public long time;
        public XrBodyJointsLocateInfoBD() { }
        public XrBodyJointsLocateInfoBD(XrStructureType type, void* next, XrSpace baseSpace, long time)
        {
            this.type = type;
            this.next = next;
            this.baseSpace = baseSpace;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_FB_body_tracking]</b> Used by <see cref="Xr.LocateBodyJointsFB"/></summary>
    public unsafe struct XrBodyJointsLocateInfoFB
    {
        public XrStructureType type = XrStructureType.TypeBodyJointsLocateInfoFb;
        public void* next;
        public XrSpace baseSpace;
        public long time;
        public XrBodyJointsLocateInfoFB() { }
        public XrBodyJointsLocateInfoFB(XrStructureType type, void* next, XrSpace baseSpace, long time)
        {
            this.type = type;
            this.next = next;
            this.baseSpace = baseSpace;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_HTC_body_tracking]</b> Used by <see cref="Xr.LocateBodyJointsHTC"/></summary>
    public unsafe struct XrBodyJointsLocateInfoHTC
    {
        public XrStructureType type = XrStructureType.TypeBodyJointsLocateInfoHtc;
        public void* next;
        public XrSpace baseSpace;
        public long time;
        public XrBodyJointsLocateInfoHTC() { }
        public XrBodyJointsLocateInfoHTC(XrStructureType type, void* next, XrSpace baseSpace, long time)
        {
            this.type = type;
            this.next = next;
            this.baseSpace = baseSpace;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_FB_body_tracking]</b> Used by <see cref="Xr.GetBodySkeletonFB"/></summary>
    public unsafe struct XrBodySkeletonFB
    {
        public XrStructureType type = XrStructureType.TypeBodySkeletonFb;
        public void* next;
        public uint jointCount;
        public XrBodySkeletonJointFB* joints;
        public XrBodySkeletonFB() { }
        public XrBodySkeletonFB(XrStructureType type, void* next, uint jointCount, XrBodySkeletonJointFB* joints)
        {
            this.type = type;
            this.next = next;
            this.jointCount = jointCount;
            this.joints = joints;
        }
    }
    /// <summary><b>[requires: XR_HTC_body_tracking]</b> Used by <see cref="Xr.GetBodySkeletonHTC"/></summary>
    public unsafe struct XrBodySkeletonHTC
    {
        public XrStructureType type = XrStructureType.TypeBodySkeletonHtc;
        public void* next;
        public uint jointCount;
        public XrBodySkeletonJointHTC* joints;
        public XrBodySkeletonHTC() { }
        public XrBodySkeletonHTC(XrStructureType type, void* next, uint jointCount, XrBodySkeletonJointHTC* joints)
        {
            this.type = type;
            this.next = next;
            this.jointCount = jointCount;
            this.joints = joints;
        }
    }
    /// <summary><b>[requires: XR_FB_body_tracking]</b> </summary>
    public unsafe struct XrBodySkeletonJointFB
    {
        public int joint;
        public int parentJoint;
        public XrPosef pose;
        public XrBodySkeletonJointFB() { }
        public XrBodySkeletonJointFB(int joint, int parentJoint, XrPosef pose)
        {
            this.joint = joint;
            this.parentJoint = parentJoint;
            this.pose = pose;
        }
    }
    /// <summary></summary>
    public unsafe struct XrBodySkeletonJointHTC
    {
        public XrPosef pose;
        public XrBodySkeletonJointHTC() { }
        public XrBodySkeletonJointHTC(XrPosef pose)
        {
            this.pose = pose;
        }
    }
    /// <summary><b>[requires: XR_BD_body_tracking]</b> Used by <see cref="Xr.CreateBodyTrackerBD"/></summary>
    public unsafe struct XrBodyTrackerCreateInfoBD
    {
        public XrStructureType type = XrStructureType.TypeBodyTrackerCreateInfoBd;
        public void* next;
        public XrBodyJointSetBD jointSet;
        public XrBodyTrackerCreateInfoBD() { }
        public XrBodyTrackerCreateInfoBD(XrStructureType type, void* next, XrBodyJointSetBD jointSet)
        {
            this.type = type;
            this.next = next;
            this.jointSet = jointSet;
        }
    }
    /// <summary><b>[requires: XR_FB_body_tracking]</b> Used by <see cref="Xr.CreateBodyTrackerFB"/></summary>
    public unsafe struct XrBodyTrackerCreateInfoFB
    {
        public XrStructureType type = XrStructureType.TypeBodyTrackerCreateInfoFb;
        public void* next;
        public XrBodyJointSetFB bodyJointSet;
        public XrBodyTrackerCreateInfoFB() { }
        public XrBodyTrackerCreateInfoFB(XrStructureType type, void* next, XrBodyJointSetFB bodyJointSet)
        {
            this.type = type;
            this.next = next;
            this.bodyJointSet = bodyJointSet;
        }
    }
    /// <summary><b>[requires: XR_HTC_body_tracking]</b> Used by <see cref="Xr.CreateBodyTrackerHTC"/></summary>
    public unsafe struct XrBodyTrackerCreateInfoHTC
    {
        public XrStructureType type = XrStructureType.TypeBodyTrackerCreateInfoHtc;
        public void* next;
        public XrBodyJointSetHTC bodyJointSet;
        public XrBodyTrackerCreateInfoHTC() { }
        public XrBodyTrackerCreateInfoHTC(XrStructureType type, void* next, XrBodyJointSetHTC bodyJointSet)
        {
            this.type = type;
            this.next = next;
            this.bodyJointSet = bodyJointSet;
        }
    }
    /// <summary><b>[requires: XR_FB_scene]</b> Used by <see cref="Xr.GetSpaceBoundary2DFB"/></summary>
    public unsafe struct XrBoundary2DFB
    {
        public XrStructureType type = XrStructureType.TypeBoundary2dFb;
        public void* next;
        public uint vertexCapacityInput;
        public uint vertexCountOutput;
        public XrVector2f* vertices;
        public XrBoundary2DFB() { }
        public XrBoundary2DFB(XrStructureType type, void* next, uint vertexCapacityInput, uint vertexCountOutput, XrVector2f* vertices)
        {
            this.type = type;
            this.next = next;
            this.vertexCapacityInput = vertexCapacityInput;
            this.vertexCountOutput = vertexCountOutput;
            this.vertices = vertices;
        }
    }
    /// <summary>Used by <see cref="Xr.EnumerateBoundSourcesForAction"/></summary>
    public unsafe struct XrBoundSourcesForActionEnumerateInfo
    {
        public XrStructureType type = XrStructureType.TypeBoundSourcesForActionEnumerateInfo;
        public void* next;
        public XrAction action;
        public XrBoundSourcesForActionEnumerateInfo() { }
        public XrBoundSourcesForActionEnumerateInfo(XrStructureType type, void* next, XrAction action)
        {
            this.type = type;
            this.next = next;
            this.action = action;
        }
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    public unsafe struct XrBoxf
    {
        public XrPosef center;
        public XrExtent3Df extents;
        public XrBoxf() { }
        public XrBoxf(XrPosef center, XrExtent3Df extents)
        {
            this.center = center;
            this.extents = extents;
        }
    }
    /// <summary><b>[requires: XR_KHR_maintenance1]</b> </summary>
    public unsafe struct XrBoxfKHR
    {
        public XrPosef center;
        public XrExtent3Df extents;
        public XrBoxfKHR() { }
        public XrBoxfKHR(XrPosef center, XrExtent3Df extents)
        {
            this.center = center;
            this.extents = extents;
        }
    }
    /// <summary><b>[requires: XR_META_colocation_discovery]</b> Used by <see cref="Xr.StartColocationAdvertisementMETA"/></summary>
    public unsafe struct XrColocationAdvertisementStartInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeColocationAdvertisementStartInfoMeta;
        public void* next;
        public uint bufferSize;
        public byte* buffer;
        public XrColocationAdvertisementStartInfoMETA() { }
        public XrColocationAdvertisementStartInfoMETA(XrStructureType type, void* next, uint bufferSize, byte* buffer)
        {
            this.type = type;
            this.next = next;
            this.bufferSize = bufferSize;
            this.buffer = buffer;
        }
    }
    /// <summary><b>[requires: XR_META_colocation_discovery]</b> Used by <see cref="Xr.StopColocationAdvertisementMETA"/></summary>
    public unsafe struct XrColocationAdvertisementStopInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeColocationAdvertisementStopInfoMeta;
        public void* next;
        public XrColocationAdvertisementStopInfoMETA() { }
        public XrColocationAdvertisementStopInfoMETA(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_META_colocation_discovery]</b> Used by <see cref="Xr.StartColocationDiscoveryMETA"/></summary>
    public unsafe struct XrColocationDiscoveryStartInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeColocationDiscoveryStartInfoMeta;
        public void* next;
        public XrColocationDiscoveryStartInfoMETA() { }
        public XrColocationDiscoveryStartInfoMETA(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_META_colocation_discovery]</b> Used by <see cref="Xr.StopColocationDiscoveryMETA"/></summary>
    public unsafe struct XrColocationDiscoveryStopInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeColocationDiscoveryStopInfoMeta;
        public void* next;
        public XrColocationDiscoveryStopInfoMETA() { }
        public XrColocationDiscoveryStopInfoMETA(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    public unsafe struct XrColor3f
    {
        public float r;
        public float g;
        public float b;
        public XrColor3f() { }
        public XrColor3f(float r, float g, float b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }
    /// <summary><b>[requires: XR_KHR_maintenance1]</b> </summary>
    public unsafe struct XrColor3fKHR
    {
        public float r;
        public float g;
        public float b;
        public XrColor3fKHR() { }
        public XrColor3fKHR(float r, float g, float b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    public unsafe struct XrColor4f
    {
        public float r;
        public float g;
        public float b;
        public float a;
        public XrColor4f() { }
        public XrColor4f(float r, float g, float b, float a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }
    }
    /// <summary><b>[requires: XR_FB_composition_layer_alpha_blend]</b> </summary>
    public unsafe struct XrCompositionLayerAlphaBlendFB
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerAlphaBlendFb;
        public void* next;
        public XrBlendFactorFB srcFactorColor;
        public XrBlendFactorFB dstFactorColor;
        public XrBlendFactorFB srcFactorAlpha;
        public XrBlendFactorFB dstFactorAlpha;
        public XrCompositionLayerAlphaBlendFB() { }
        public XrCompositionLayerAlphaBlendFB(XrStructureType type, void* next, XrBlendFactorFB srcFactorColor, XrBlendFactorFB dstFactorColor, XrBlendFactorFB srcFactorAlpha, XrBlendFactorFB dstFactorAlpha)
        {
            this.type = type;
            this.next = next;
            this.srcFactorColor = srcFactorColor;
            this.dstFactorColor = dstFactorColor;
            this.srcFactorAlpha = srcFactorAlpha;
            this.dstFactorAlpha = dstFactorAlpha;
        }
    }
    /// <summary></summary>
    public unsafe struct XrCompositionLayerBaseHeader
    {
        public XrStructureType type;
        public void* next;
        public XrCompositionLayerFlagBits layerFlags;
        public XrSpace space;
        public XrCompositionLayerBaseHeader() { }
        public XrCompositionLayerBaseHeader(XrStructureType type, void* next, XrCompositionLayerFlagBits layerFlags, XrSpace space)
        {
            this.type = type;
            this.next = next;
            this.layerFlags = layerFlags;
            this.space = space;
        }
    }
    /// <summary><b>[requires: XR_KHR_composition_layer_color_scale_bias]</b> </summary>
    public unsafe struct XrCompositionLayerColorScaleBiasKHR
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerColorScaleBiasKhr;
        public void* next;
        public XrColor4f colorScale;
        public XrColor4f colorBias;
        public XrCompositionLayerColorScaleBiasKHR() { }
        public XrCompositionLayerColorScaleBiasKHR(XrStructureType type, void* next, XrColor4f colorScale, XrColor4f colorBias)
        {
            this.type = type;
            this.next = next;
            this.colorScale = colorScale;
            this.colorBias = colorBias;
        }
    }
    /// <summary><b>[requires: XR_KHR_composition_layer_cube]</b> </summary>
    public unsafe struct XrCompositionLayerCubeKHR
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerCubeKhr;
        public void* next;
        public XrCompositionLayerFlagBits layerFlags;
        public XrSpace space;
        public XrEyeVisibility eyeVisibility;
        public XrSwapchain swapchain;
        public uint imageArrayIndex;
        public XrQuaternionf orientation;
        public XrCompositionLayerCubeKHR() { }
        public XrCompositionLayerCubeKHR(XrStructureType type, void* next, XrCompositionLayerFlagBits layerFlags, XrSpace space, XrEyeVisibility eyeVisibility, XrSwapchain swapchain, uint imageArrayIndex, XrQuaternionf orientation)
        {
            this.type = type;
            this.next = next;
            this.layerFlags = layerFlags;
            this.space = space;
            this.eyeVisibility = eyeVisibility;
            this.swapchain = swapchain;
            this.imageArrayIndex = imageArrayIndex;
            this.orientation = orientation;
        }
    }
    /// <summary><b>[requires: XR_KHR_composition_layer_cylinder]</b> </summary>
    public unsafe struct XrCompositionLayerCylinderKHR
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerCylinderKhr;
        public void* next;
        public XrCompositionLayerFlagBits layerFlags;
        public XrSpace space;
        public XrEyeVisibility eyeVisibility;
        public XrSwapchainSubImage subImage;
        public XrPosef pose;
        public float radius;
        public float centralAngle;
        public float aspectRatio;
        public XrCompositionLayerCylinderKHR() { }
        public XrCompositionLayerCylinderKHR(XrStructureType type, void* next, XrCompositionLayerFlagBits layerFlags, XrSpace space, XrEyeVisibility eyeVisibility, XrSwapchainSubImage subImage, XrPosef pose, float radius, float centralAngle, float aspectRatio)
        {
            this.type = type;
            this.next = next;
            this.layerFlags = layerFlags;
            this.space = space;
            this.eyeVisibility = eyeVisibility;
            this.subImage = subImage;
            this.pose = pose;
            this.radius = radius;
            this.centralAngle = centralAngle;
            this.aspectRatio = aspectRatio;
        }
    }
    /// <summary><b>[requires: XR_KHR_composition_layer_depth]</b> </summary>
    public unsafe struct XrCompositionLayerDepthInfoKHR
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerDepthInfoKhr;
        public void* next;
        public XrSwapchainSubImage subImage;
        public float minDepth;
        public float maxDepth;
        public float nearZ;
        public float farZ;
        public XrCompositionLayerDepthInfoKHR() { }
        public XrCompositionLayerDepthInfoKHR(XrStructureType type, void* next, XrSwapchainSubImage subImage, float minDepth, float maxDepth, float nearZ, float farZ)
        {
            this.type = type;
            this.next = next;
            this.subImage = subImage;
            this.minDepth = minDepth;
            this.maxDepth = maxDepth;
            this.nearZ = nearZ;
            this.farZ = farZ;
        }
    }
    /// <summary><b>[requires: XR_FB_composition_layer_depth_test]</b> </summary>
    public unsafe struct XrCompositionLayerDepthTestFB
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerDepthTestFb;
        public void* next;
        public int depthMask;
        public XrCompareOpFB compareOp;
        public XrCompositionLayerDepthTestFB() { }
        public XrCompositionLayerDepthTestFB(XrStructureType type, void* next, int depthMask, XrCompareOpFB compareOp)
        {
            this.type = type;
            this.next = next;
            this.depthMask = depthMask;
            this.compareOp = compareOp;
        }
    }
    /// <summary><b>[requires: XR_VARJO_composition_layer_depth_test]</b> </summary>
    public unsafe struct XrCompositionLayerDepthTestVARJO
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerDepthTestVarjo;
        public void* next;
        public float depthTestRangeNearZ;
        public float depthTestRangeFarZ;
        public XrCompositionLayerDepthTestVARJO() { }
        public XrCompositionLayerDepthTestVARJO(XrStructureType type, void* next, float depthTestRangeNearZ, float depthTestRangeFarZ)
        {
            this.type = type;
            this.next = next;
            this.depthTestRangeNearZ = depthTestRangeNearZ;
            this.depthTestRangeFarZ = depthTestRangeFarZ;
        }
    }
    /// <summary><b>[requires: XR_KHR_composition_layer_equirect2]</b> </summary>
    public unsafe struct XrCompositionLayerEquirect2KHR
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerEquirect2Khr;
        public void* next;
        public XrCompositionLayerFlagBits layerFlags;
        public XrSpace space;
        public XrEyeVisibility eyeVisibility;
        public XrSwapchainSubImage subImage;
        public XrPosef pose;
        public float radius;
        public float centralHorizontalAngle;
        public float upperVerticalAngle;
        public float lowerVerticalAngle;
        public XrCompositionLayerEquirect2KHR() { }
        public XrCompositionLayerEquirect2KHR(XrStructureType type, void* next, XrCompositionLayerFlagBits layerFlags, XrSpace space, XrEyeVisibility eyeVisibility, XrSwapchainSubImage subImage, XrPosef pose, float radius, float centralHorizontalAngle, float upperVerticalAngle, float lowerVerticalAngle)
        {
            this.type = type;
            this.next = next;
            this.layerFlags = layerFlags;
            this.space = space;
            this.eyeVisibility = eyeVisibility;
            this.subImage = subImage;
            this.pose = pose;
            this.radius = radius;
            this.centralHorizontalAngle = centralHorizontalAngle;
            this.upperVerticalAngle = upperVerticalAngle;
            this.lowerVerticalAngle = lowerVerticalAngle;
        }
    }
    /// <summary><b>[requires: XR_KHR_composition_layer_equirect]</b> </summary>
    public unsafe struct XrCompositionLayerEquirectKHR
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerEquirectKhr;
        public void* next;
        public XrCompositionLayerFlagBits layerFlags;
        public XrSpace space;
        public XrEyeVisibility eyeVisibility;
        public XrSwapchainSubImage subImage;
        public XrPosef pose;
        public float radius;
        public XrVector2f scale;
        public XrVector2f bias;
        public XrCompositionLayerEquirectKHR() { }
        public XrCompositionLayerEquirectKHR(XrStructureType type, void* next, XrCompositionLayerFlagBits layerFlags, XrSpace space, XrEyeVisibility eyeVisibility, XrSwapchainSubImage subImage, XrPosef pose, float radius, XrVector2f scale, XrVector2f bias)
        {
            this.type = type;
            this.next = next;
            this.layerFlags = layerFlags;
            this.space = space;
            this.eyeVisibility = eyeVisibility;
            this.subImage = subImage;
            this.pose = pose;
            this.radius = radius;
            this.scale = scale;
            this.bias = bias;
        }
    }
    /// <summary><b>[requires: XR_FB_composition_layer_image_layout]</b> </summary>
    public unsafe struct XrCompositionLayerImageLayoutFB
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerImageLayoutFb;
        public void* next;
        public XrCompositionLayerImageLayoutFlagBitsFB flags;
        public XrCompositionLayerImageLayoutFB() { }
        public XrCompositionLayerImageLayoutFB(XrStructureType type, void* next, XrCompositionLayerImageLayoutFlagBitsFB flags)
        {
            this.type = type;
            this.next = next;
            this.flags = flags;
        }
    }
    /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
    public unsafe struct XrCompositionLayerPassthroughFB
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerPassthroughFb;
        public void* next;
        public XrCompositionLayerFlagBits flags;
        public XrSpace space;
        public XrPassthroughLayerFB layerHandle;
        public XrCompositionLayerPassthroughFB() { }
        public XrCompositionLayerPassthroughFB(XrStructureType type, void* next, XrCompositionLayerFlagBits flags, XrSpace space, XrPassthroughLayerFB layerHandle)
        {
            this.type = type;
            this.next = next;
            this.flags = flags;
            this.space = space;
            this.layerHandle = layerHandle;
        }
    }
    /// <summary><b>[requires: XR_HTC_passthrough]</b> </summary>
    public unsafe struct XrCompositionLayerPassthroughHTC
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerPassthroughHtc;
        public void* next;
        public XrCompositionLayerFlagBits layerFlags;
        public XrSpace space;
        public XrPassthroughHTC passthrough;
        public XrPassthroughColorHTC color;
        public XrCompositionLayerPassthroughHTC() { }
        public XrCompositionLayerPassthroughHTC(XrStructureType type, void* next, XrCompositionLayerFlagBits layerFlags, XrSpace space, XrPassthroughHTC passthrough, XrPassthroughColorHTC color)
        {
            this.type = type;
            this.next = next;
            this.layerFlags = layerFlags;
            this.space = space;
            this.passthrough = passthrough;
            this.color = color;
        }
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    public unsafe struct XrCompositionLayerProjection
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerProjection;
        public void* next;
        public XrCompositionLayerFlagBits layerFlags;
        public XrSpace space;
        public uint viewCount;
        public XrCompositionLayerProjectionView* views;
        public XrCompositionLayerProjection() { }
        public XrCompositionLayerProjection(XrStructureType type, void* next, XrCompositionLayerFlagBits layerFlags, XrSpace space, uint viewCount, XrCompositionLayerProjectionView* views)
        {
            this.type = type;
            this.next = next;
            this.layerFlags = layerFlags;
            this.space = space;
            this.viewCount = viewCount;
            this.views = views;
        }
    }
    /// <summary></summary>
    public unsafe struct XrCompositionLayerProjectionView
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerProjectionView;
        public void* next;
        public XrPosef pose;
        public XrFovf fov;
        public XrSwapchainSubImage subImage;
        public XrCompositionLayerProjectionView() { }
        public XrCompositionLayerProjectionView(XrStructureType type, void* next, XrPosef pose, XrFovf fov, XrSwapchainSubImage subImage)
        {
            this.type = type;
            this.next = next;
            this.pose = pose;
            this.fov = fov;
            this.subImage = subImage;
        }
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    public unsafe struct XrCompositionLayerQuad
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerQuad;
        public void* next;
        public XrCompositionLayerFlagBits layerFlags;
        public XrSpace space;
        public XrEyeVisibility eyeVisibility;
        public XrSwapchainSubImage subImage;
        public XrPosef pose;
        public XrExtent2Df size;
        public XrCompositionLayerQuad() { }
        public XrCompositionLayerQuad(XrStructureType type, void* next, XrCompositionLayerFlagBits layerFlags, XrSpace space, XrEyeVisibility eyeVisibility, XrSwapchainSubImage subImage, XrPosef pose, XrExtent2Df size)
        {
            this.type = type;
            this.next = next;
            this.layerFlags = layerFlags;
            this.space = space;
            this.eyeVisibility = eyeVisibility;
            this.subImage = subImage;
            this.pose = pose;
            this.size = size;
        }
    }
    /// <summary><b>[requires: XR_MSFT_composition_layer_reprojection]</b> </summary>
    public unsafe struct XrCompositionLayerReprojectionInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerReprojectionInfoMsft;
        public void* next;
        public XrReprojectionModeMSFT reprojectionMode;
        public XrCompositionLayerReprojectionInfoMSFT() { }
        public XrCompositionLayerReprojectionInfoMSFT(XrStructureType type, void* next, XrReprojectionModeMSFT reprojectionMode)
        {
            this.type = type;
            this.next = next;
            this.reprojectionMode = reprojectionMode;
        }
    }
    /// <summary><b>[requires: XR_MSFT_composition_layer_reprojection]</b> </summary>
    public unsafe struct XrCompositionLayerReprojectionPlaneOverrideMSFT
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerReprojectionPlaneOverrideMsft;
        public void* next;
        public XrVector3f position;
        public XrVector3f normal;
        public XrVector3f velocity;
        public XrCompositionLayerReprojectionPlaneOverrideMSFT() { }
        public XrCompositionLayerReprojectionPlaneOverrideMSFT(XrStructureType type, void* next, XrVector3f position, XrVector3f normal, XrVector3f velocity)
        {
            this.type = type;
            this.next = next;
            this.position = position;
            this.normal = normal;
            this.velocity = velocity;
        }
    }
    /// <summary><b>[requires: XR_FB_composition_layer_secure_content]</b> </summary>
    public unsafe struct XrCompositionLayerSecureContentFB
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerSecureContentFb;
        public void* next;
        public XrCompositionLayerSecureContentFlagBitsFB flags;
        public XrCompositionLayerSecureContentFB() { }
        public XrCompositionLayerSecureContentFB(XrStructureType type, void* next, XrCompositionLayerSecureContentFlagBitsFB flags)
        {
            this.type = type;
            this.next = next;
            this.flags = flags;
        }
    }
    /// <summary><b>[requires: XR_FB_composition_layer_settings]</b> </summary>
    public unsafe struct XrCompositionLayerSettingsFB
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerSettingsFb;
        public void* next;
        public XrCompositionLayerSettingsFlagBitsFB layerFlags;
        public XrCompositionLayerSettingsFB() { }
        public XrCompositionLayerSettingsFB(XrStructureType type, void* next, XrCompositionLayerSettingsFlagBitsFB layerFlags)
        {
            this.type = type;
            this.next = next;
            this.layerFlags = layerFlags;
        }
    }
    /// <summary><b>[requires: XR_FB_space_warp]</b> </summary>
    public unsafe struct XrCompositionLayerSpaceWarpInfoFB
    {
        public XrStructureType type = XrStructureType.TypeCompositionLayerSpaceWarpInfoFb;
        public void* next;
        public XrCompositionLayerSpaceWarpInfoFlagBitsFB layerFlags;
        public XrSwapchainSubImage motionVectorSubImage;
        public XrPosef appSpaceDeltaPose;
        public XrSwapchainSubImage depthSubImage;
        public float minDepth;
        public float maxDepth;
        public float nearZ;
        public float farZ;
        public XrCompositionLayerSpaceWarpInfoFB() { }
        public XrCompositionLayerSpaceWarpInfoFB(XrStructureType type, void* next, XrCompositionLayerSpaceWarpInfoFlagBitsFB layerFlags, XrSwapchainSubImage motionVectorSubImage, XrPosef appSpaceDeltaPose, XrSwapchainSubImage depthSubImage, float minDepth, float maxDepth, float nearZ, float farZ)
        {
            this.type = type;
            this.next = next;
            this.layerFlags = layerFlags;
            this.motionVectorSubImage = motionVectorSubImage;
            this.appSpaceDeltaPose = appSpaceDeltaPose;
            this.depthSubImage = depthSubImage;
            this.minDepth = minDepth;
            this.maxDepth = maxDepth;
            this.nearZ = nearZ;
            this.farZ = farZ;
        }
    }
    /// <summary><b>[requires: XR_MSFT_controller_model]</b> Used by <see cref="Xr.GetControllerModelKeyMSFT"/></summary>
    public unsafe struct XrControllerModelKeyStateMSFT
    {
        public XrStructureType type = XrStructureType.TypeControllerModelKeyStateMsft;
        public void* next;
        public ulong modelKey;
        public XrControllerModelKeyStateMSFT() { }
        public XrControllerModelKeyStateMSFT(XrStructureType type, void* next, ulong modelKey)
        {
            this.type = type;
            this.next = next;
            this.modelKey = modelKey;
        }
    }
    /// <summary><b>[requires: XR_MSFT_controller_model]</b> </summary>
    public unsafe struct XrControllerModelNodePropertiesMSFT
    {
        public XrStructureType type = XrStructureType.TypeControllerModelNodePropertiesMsft;
        public void* next;
        [InlineArray(64)]
        public struct parentNodeNameInlineArray1
        {
            public byte element;
        }
        public parentNodeNameInlineArray1 parentNodeName;
        [InlineArray(64)]
        public struct nodeNameInlineArray1
        {
            public byte element;
        }
        public nodeNameInlineArray1 nodeName;
        public XrControllerModelNodePropertiesMSFT() { }
    }
    /// <summary><b>[requires: XR_MSFT_controller_model]</b> </summary>
    public unsafe struct XrControllerModelNodeStateMSFT
    {
        public XrStructureType type = XrStructureType.TypeControllerModelNodeStateMsft;
        public void* next;
        public XrPosef nodePose;
        public XrControllerModelNodeStateMSFT() { }
        public XrControllerModelNodeStateMSFT(XrStructureType type, void* next, XrPosef nodePose)
        {
            this.type = type;
            this.next = next;
            this.nodePose = nodePose;
        }
    }
    /// <summary><b>[requires: XR_MSFT_controller_model]</b> Used by <see cref="Xr.GetControllerModelPropertiesMSFT"/></summary>
    public unsafe struct XrControllerModelPropertiesMSFT
    {
        public XrStructureType type = XrStructureType.TypeControllerModelPropertiesMsft;
        public void* next;
        public uint nodeCapacityInput;
        public uint nodeCountOutput;
        public XrControllerModelNodePropertiesMSFT* nodeProperties;
        public XrControllerModelPropertiesMSFT() { }
        public XrControllerModelPropertiesMSFT(XrStructureType type, void* next, uint nodeCapacityInput, uint nodeCountOutput, XrControllerModelNodePropertiesMSFT* nodeProperties)
        {
            this.type = type;
            this.next = next;
            this.nodeCapacityInput = nodeCapacityInput;
            this.nodeCountOutput = nodeCountOutput;
            this.nodeProperties = nodeProperties;
        }
    }
    /// <summary><b>[requires: XR_MSFT_controller_model]</b> Used by <see cref="Xr.GetControllerModelStateMSFT"/></summary>
    public unsafe struct XrControllerModelStateMSFT
    {
        public XrStructureType type = XrStructureType.TypeControllerModelStateMsft;
        public void* next;
        public uint nodeCapacityInput;
        public uint nodeCountOutput;
        public XrControllerModelNodeStateMSFT* nodeStates;
        public XrControllerModelStateMSFT() { }
        public XrControllerModelStateMSFT(XrStructureType type, void* next, uint nodeCapacityInput, uint nodeCountOutput, XrControllerModelNodeStateMSFT* nodeStates)
        {
            this.type = type;
            this.next = next;
            this.nodeCapacityInput = nodeCapacityInput;
            this.nodeCountOutput = nodeCountOutput;
            this.nodeStates = nodeStates;
        }
    }
    /// <summary>Used by <see cref="Xr.CreateSpaceFromCoordinateFrameUIDML"/></summary>
    public unsafe struct XrCoordinateSpaceCreateInfoML
    {
        public XrStructureType type = XrStructureType.TypeCoordinateSpaceCreateInfoMl;
        public void* next;
        public Guid cfuid;
        public XrPosef poseInCoordinateSpace;
        public XrCoordinateSpaceCreateInfoML() { }
        public XrCoordinateSpaceCreateInfoML(XrStructureType type, void* next, Guid cfuid, XrPosef poseInCoordinateSpace)
        {
            this.type = type;
            this.next = next;
            this.cfuid = cfuid;
            this.poseInCoordinateSpace = poseInCoordinateSpace;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors]</b> Used by <see cref="Xr.CreateSpatialAnchorsCompleteML"/></summary>
    public unsafe struct XrCreateSpatialAnchorsCompletionML
    {
        public XrStructureType type = XrStructureType.TypeCreateSpatialAnchorsCompletionMl;
        public void* next;
        public XrResult futureResult;
        public uint spaceCount;
        public XrSpace* spaces;
        public XrCreateSpatialAnchorsCompletionML() { }
        public XrCreateSpatialAnchorsCompletionML(XrStructureType type, void* next, XrResult futureResult, uint spaceCount, XrSpace* spaces)
        {
            this.type = type;
            this.next = next;
            this.futureResult = futureResult;
            this.spaceCount = spaceCount;
            this.spaces = spaces;
        }
    }
    /// <summary><b>[requires: XR_EXT_debug_utils]</b> Used by <see cref="Xr.SessionBeginDebugUtilsLabelRegionEXT"/>, <see cref="Xr.SessionInsertDebugUtilsLabelEXT"/></summary>
    public unsafe struct XrDebugUtilsLabelEXT
    {
        public XrStructureType type = XrStructureType.TypeDebugUtilsLabelExt;
        public void* next;
        public byte* labelName;
        public XrDebugUtilsLabelEXT() { }
        public XrDebugUtilsLabelEXT(XrStructureType type, void* next, byte* labelName)
        {
            this.type = type;
            this.next = next;
            this.labelName = labelName;
        }
    }
    /// <summary><b>[requires: XR_EXT_debug_utils]</b> Used by <see cref="Xr.SubmitDebugUtilsMessageEXT"/></summary>
    public unsafe struct XrDebugUtilsMessengerCallbackDataEXT
    {
        public XrStructureType type = XrStructureType.TypeDebugUtilsMessengerCallbackDataExt;
        public void* next;
        public byte* messageId;
        public byte* functionName;
        public byte* message;
        public uint objectCount;
        public XrDebugUtilsObjectNameInfoEXT* objects;
        public uint sessionLabelCount;
        public XrDebugUtilsLabelEXT* sessionLabels;
        public XrDebugUtilsMessengerCallbackDataEXT() { }
        public XrDebugUtilsMessengerCallbackDataEXT(XrStructureType type, void* next, byte* messageId, byte* functionName, byte* message, uint objectCount, XrDebugUtilsObjectNameInfoEXT* objects, uint sessionLabelCount, XrDebugUtilsLabelEXT* sessionLabels)
        {
            this.type = type;
            this.next = next;
            this.messageId = messageId;
            this.functionName = functionName;
            this.message = message;
            this.objectCount = objectCount;
            this.objects = objects;
            this.sessionLabelCount = sessionLabelCount;
            this.sessionLabels = sessionLabels;
        }
    }
    /// <summary><b>[requires: XR_EXT_debug_utils]</b> Used by <see cref="Xr.CreateDebugUtilsMessengerEXT"/></summary>
    public unsafe struct XrDebugUtilsMessengerCreateInfoEXT
    {
        public XrStructureType type = XrStructureType.TypeDebugUtilsMessengerCreateInfoExt;
        public void* next;
        public XrDebugUtilsMessageSeverityFlagBitsEXT messageSeverities;
        public XrDebugUtilsMessageTypeFlagBitsEXT messageTypes;
        public delegate* unmanaged[Cdecl]<XrDebugUtilsMessageSeverityFlagBitsEXT, XrDebugUtilsMessageTypeFlagBitsEXT, XrDebugUtilsMessengerCallbackDataEXT*, void*, int> userCallback;
        public void* userData;
        public XrDebugUtilsMessengerCreateInfoEXT() { }
        public XrDebugUtilsMessengerCreateInfoEXT(XrStructureType type, void* next, XrDebugUtilsMessageSeverityFlagBitsEXT messageSeverities, XrDebugUtilsMessageTypeFlagBitsEXT messageTypes, delegate* unmanaged[Cdecl]<XrDebugUtilsMessageSeverityFlagBitsEXT, XrDebugUtilsMessageTypeFlagBitsEXT, XrDebugUtilsMessengerCallbackDataEXT*, void*, int> userCallback, void* userData)
        {
            this.type = type;
            this.next = next;
            this.messageSeverities = messageSeverities;
            this.messageTypes = messageTypes;
            this.userCallback = userCallback;
            this.userData = userData;
        }
    }
    /// <summary><b>[requires: XR_EXT_debug_utils]</b> Used by <see cref="Xr.SetDebugUtilsObjectNameEXT"/></summary>
    public unsafe struct XrDebugUtilsObjectNameInfoEXT
    {
        public XrStructureType type = XrStructureType.TypeDebugUtilsObjectNameInfoExt;
        public void* next;
        public XrObjectType objectType;
        public ulong objectHandle;
        public byte* objectName;
        public XrDebugUtilsObjectNameInfoEXT() { }
        public XrDebugUtilsObjectNameInfoEXT(XrStructureType type, void* next, XrObjectType objectType, ulong objectHandle, byte* objectName)
        {
            this.type = type;
            this.next = next;
            this.objectType = objectType;
            this.objectHandle = objectHandle;
            this.objectName = objectName;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding_serialization]</b> </summary>
    public unsafe struct XrDeserializeSceneFragmentMSFT
    {
        public uint bufferSize;
        public byte* buffer;
        public XrDeserializeSceneFragmentMSFT() { }
        public XrDeserializeSceneFragmentMSFT(uint bufferSize, byte* buffer)
        {
            this.bufferSize = bufferSize;
            this.buffer = buffer;
        }
    }
    /// <summary></summary>
    public unsafe struct XrDevicePcmSampleRateGetInfoFB
    {
        public XrStructureType type = XrStructureType.TypeDevicePcmSampleRateStateFb;
        public void* next;
        public float sampleRate;
        public XrDevicePcmSampleRateGetInfoFB() { }
        public XrDevicePcmSampleRateGetInfoFB(XrStructureType type, void* next, float sampleRate)
        {
            this.type = type;
            this.next = next;
            this.sampleRate = sampleRate;
        }
    }
    /// <summary><b>[requires: XR_FB_haptic_pcm]</b> Used by <see cref="Xr.GetDeviceSampleRateFB"/></summary>
    public unsafe struct XrDevicePcmSampleRateStateFB
    {
        public XrStructureType type = XrStructureType.TypeDevicePcmSampleRateStateFb;
        public void* next;
        public float sampleRate;
        public XrDevicePcmSampleRateStateFB() { }
        public XrDevicePcmSampleRateStateFB(XrStructureType type, void* next, float sampleRate)
        {
            this.type = type;
            this.next = next;
            this.sampleRate = sampleRate;
        }
    }
    /// <summary>Used by <see cref="Xr.SetDigitalLensControlALMALENCE"/></summary>
    public unsafe struct XrDigitalLensControlALMALENCE
    {
        public XrStructureType type = XrStructureType.TypeDigitalLensControlAlmalence;
        public void* next;
        public XrDigitalLensControlFlagBitsALMALENCE flags;
        public XrDigitalLensControlALMALENCE() { }
        public XrDigitalLensControlALMALENCE(XrStructureType type, void* next, XrDigitalLensControlFlagBitsALMALENCE flags)
        {
            this.type = type;
            this.next = next;
            this.flags = flags;
        }
    }
    /// <summary><b>[requires: XR_META_environment_depth]</b> Used by <see cref="Xr.SetEnvironmentDepthHandRemovalMETA"/></summary>
    public unsafe struct XrEnvironmentDepthHandRemovalSetInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeEnvironmentDepthHandRemovalSetInfoMeta;
        public void* next;
        public int enabled;
        public XrEnvironmentDepthHandRemovalSetInfoMETA() { }
        public XrEnvironmentDepthHandRemovalSetInfoMETA(XrStructureType type, void* next, int enabled)
        {
            this.type = type;
            this.next = next;
            this.enabled = enabled;
        }
    }
    /// <summary><b>[requires: XR_META_environment_depth]</b> Used by <see cref="Xr.AcquireEnvironmentDepthImageMETA"/></summary>
    public unsafe struct XrEnvironmentDepthImageAcquireInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeEnvironmentDepthImageAcquireInfoMeta;
        public void* next;
        public XrSpace space;
        public long displayTime;
        public XrEnvironmentDepthImageAcquireInfoMETA() { }
        public XrEnvironmentDepthImageAcquireInfoMETA(XrStructureType type, void* next, XrSpace space, long displayTime)
        {
            this.type = type;
            this.next = next;
            this.space = space;
            this.displayTime = displayTime;
        }
    }
    /// <summary><b>[requires: XR_META_environment_depth]</b> Used by <see cref="Xr.AcquireEnvironmentDepthImageMETA"/></summary>
    public unsafe struct XrEnvironmentDepthImageMETA
    {
        public XrStructureType type = XrStructureType.TypeEnvironmentDepthImageMeta;
        public void* next;
        public uint swapchainIndex;
        public float nearZ;
        public float farZ;
        [InlineArray(2)]
        public struct viewsInlineArray1
        {
            public XrEnvironmentDepthImageViewMETA element;
        }
        public viewsInlineArray1 views;
        public XrEnvironmentDepthImageMETA() { }
    }
    /// <summary><b>[requires: XR_META_environment_depth]</b> </summary>
    public unsafe struct XrEnvironmentDepthImageViewMETA
    {
        public XrStructureType type = XrStructureType.TypeEnvironmentDepthImageViewMeta;
        public void* next;
        public XrFovf fov;
        public XrPosef pose;
        public XrEnvironmentDepthImageViewMETA() { }
        public XrEnvironmentDepthImageViewMETA(XrStructureType type, void* next, XrFovf fov, XrPosef pose)
        {
            this.type = type;
            this.next = next;
            this.fov = fov;
            this.pose = pose;
        }
    }
    /// <summary><b>[requires: XR_META_environment_depth]</b> Used by <see cref="Xr.CreateEnvironmentDepthProviderMETA"/></summary>
    public unsafe struct XrEnvironmentDepthProviderCreateInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeEnvironmentDepthProviderCreateInfoMeta;
        public void* next;
        public XrEnvironmentDepthProviderCreateFlagBitsMETA createFlags;
        public XrEnvironmentDepthProviderCreateInfoMETA() { }
        public XrEnvironmentDepthProviderCreateInfoMETA(XrStructureType type, void* next, XrEnvironmentDepthProviderCreateFlagBitsMETA createFlags)
        {
            this.type = type;
            this.next = next;
            this.createFlags = createFlags;
        }
    }
    /// <summary><b>[requires: XR_META_environment_depth]</b> Used by <see cref="Xr.CreateEnvironmentDepthSwapchainMETA"/></summary>
    public unsafe struct XrEnvironmentDepthSwapchainCreateInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeEnvironmentDepthSwapchainCreateInfoMeta;
        public void* next;
        public XrEnvironmentDepthSwapchainCreateFlagBitsMETA createFlags;
        public XrEnvironmentDepthSwapchainCreateInfoMETA() { }
        public XrEnvironmentDepthSwapchainCreateInfoMETA(XrStructureType type, void* next, XrEnvironmentDepthSwapchainCreateFlagBitsMETA createFlags)
        {
            this.type = type;
            this.next = next;
            this.createFlags = createFlags;
        }
    }
    /// <summary><b>[requires: XR_META_environment_depth]</b> Used by <see cref="Xr.GetEnvironmentDepthSwapchainStateMETA"/></summary>
    public unsafe struct XrEnvironmentDepthSwapchainStateMETA
    {
        public XrStructureType type = XrStructureType.TypeEnvironmentDepthSwapchainStateMeta;
        public void* next;
        public uint width;
        public uint height;
        public XrEnvironmentDepthSwapchainStateMETA() { }
        public XrEnvironmentDepthSwapchainStateMETA(XrStructureType type, void* next, uint width, uint height)
        {
            this.type = type;
            this.next = next;
            this.width = width;
            this.height = height;
        }
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    public unsafe struct XrEventDataBaseHeader
    {
        public XrStructureType type;
        public void* next;
        public XrEventDataBaseHeader() { }
        public XrEventDataBaseHeader(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary>Used by <see cref="Xr.PollEvent"/></summary>
    public unsafe struct XrEventDataBuffer
    {
        public XrStructureType type = XrStructureType.TypeEventDataBuffer;
        public void* next;
        public fixed byte varying[4000];
        public XrEventDataBuffer() { }
    }
    /// <summary><b>[requires: XR_META_colocation_discovery]</b> </summary>
    public unsafe struct XrEventDataColocationAdvertisementCompleteMETA
    {
        public XrStructureType type = XrStructureType.TypeEventDataColocationAdvertisementCompleteMeta;
        public void* next;
        public ulong advertisementRequestId;
        public XrResult result;
        public XrEventDataColocationAdvertisementCompleteMETA() { }
        public XrEventDataColocationAdvertisementCompleteMETA(XrStructureType type, void* next, ulong advertisementRequestId, XrResult result)
        {
            this.type = type;
            this.next = next;
            this.advertisementRequestId = advertisementRequestId;
            this.result = result;
        }
    }
    /// <summary><b>[requires: XR_META_colocation_discovery]</b> </summary>
    public unsafe struct XrEventDataColocationDiscoveryCompleteMETA
    {
        public XrStructureType type = XrStructureType.TypeEventDataColocationDiscoveryCompleteMeta;
        public void* next;
        public ulong discoveryRequestId;
        public XrResult result;
        public XrEventDataColocationDiscoveryCompleteMETA() { }
        public XrEventDataColocationDiscoveryCompleteMETA(XrStructureType type, void* next, ulong discoveryRequestId, XrResult result)
        {
            this.type = type;
            this.next = next;
            this.discoveryRequestId = discoveryRequestId;
            this.result = result;
        }
    }
    /// <summary><b>[requires: XR_META_colocation_discovery]</b> </summary>
    public unsafe struct XrEventDataColocationDiscoveryResultMETA
    {
        public XrStructureType type = XrStructureType.TypeEventDataColocationDiscoveryResultMeta;
        public void* next;
        public ulong discoveryRequestId;
        public XrUuid advertisementUuid;
        public uint bufferSize;
        public fixed byte buffer[1024];
        public XrEventDataColocationDiscoveryResultMETA() { }
    }
    /// <summary><b>[requires: XR_FB_display_refresh_rate]</b> </summary>
    public unsafe struct XrEventDataDisplayRefreshRateChangedFB
    {
        public XrStructureType type = XrStructureType.TypeEventDataDisplayRefreshRateChangedFb;
        public void* next;
        public float fromDisplayRefreshRate;
        public float toDisplayRefreshRate;
        public XrEventDataDisplayRefreshRateChangedFB() { }
        public XrEventDataDisplayRefreshRateChangedFB(XrStructureType type, void* next, float fromDisplayRefreshRate, float toDisplayRefreshRate)
        {
            this.type = type;
            this.next = next;
            this.fromDisplayRefreshRate = fromDisplayRefreshRate;
            this.toDisplayRefreshRate = toDisplayRefreshRate;
        }
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    public unsafe struct XrEventDataEventsLost
    {
        public XrStructureType type = XrStructureType.TypeEventDataEventsLost;
        public void* next;
        public uint lostEventCount;
        public XrEventDataEventsLost() { }
        public XrEventDataEventsLost(XrStructureType type, void* next, uint lostEventCount)
        {
            this.type = type;
            this.next = next;
            this.lostEventCount = lostEventCount;
        }
    }
    /// <summary><b>[requires: XR_ML_user_calibration]</b> </summary>
    public unsafe struct XrEventDataEyeCalibrationChangedML
    {
        public XrStructureType type = XrStructureType.TypeEventDataEyeCalibrationChangedMl;
        public void* next;
        public XrEyeCalibrationStatusML status;
        public XrEventDataEyeCalibrationChangedML() { }
        public XrEventDataEyeCalibrationChangedML(XrStructureType type, void* next, XrEyeCalibrationStatusML status)
        {
            this.type = type;
            this.next = next;
            this.status = status;
        }
    }
    /// <summary><b>[requires: XR_ML_user_calibration]</b> </summary>
    public unsafe struct XrEventDataHeadsetFitChangedML
    {
        public XrStructureType type = XrStructureType.TypeEventDataHeadsetFitChangedMl;
        public void* next;
        public XrHeadsetFitStatusML status;
        public long time;
        public XrEventDataHeadsetFitChangedML() { }
        public XrEventDataHeadsetFitChangedML(XrStructureType type, void* next, XrHeadsetFitStatusML status, long time)
        {
            this.type = type;
            this.next = next;
            this.status = status;
            this.time = time;
        }
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    public unsafe struct XrEventDataInstanceLossPending
    {
        public XrStructureType type = XrStructureType.TypeEventDataInstanceLossPending;
        public void* next;
        public long lossTime;
        public XrEventDataInstanceLossPending() { }
        public XrEventDataInstanceLossPending(XrStructureType type, void* next, long lossTime)
        {
            this.type = type;
            this.next = next;
            this.lossTime = lossTime;
        }
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    public unsafe struct XrEventDataInteractionProfileChanged
    {
        public XrStructureType type = XrStructureType.TypeEventDataInteractionProfileChanged;
        public void* next;
        public XrSession session;
        public XrEventDataInteractionProfileChanged() { }
        public XrEventDataInteractionProfileChanged(XrStructureType type, void* next, XrSession session)
        {
            this.type = type;
            this.next = next;
            this.session = session;
        }
    }
    /// <summary><b>[requires: XR_ML_localization_map]</b> </summary>
    public unsafe struct XrEventDataLocalizationChangedML
    {
        public XrStructureType type = XrStructureType.TypeEventDataLocalizationChangedMl;
        public void* next;
        public XrSession session;
        public XrLocalizationMapStateML state;
        public XrLocalizationMapML map;
        public XrLocalizationMapConfidenceML confidence;
        public XrLocalizationMapErrorFlagBitsML errorFlags;
        public XrEventDataLocalizationChangedML() { }
        public XrEventDataLocalizationChangedML(XrStructureType type, void* next, XrSession session, XrLocalizationMapStateML state, XrLocalizationMapML map, XrLocalizationMapConfidenceML confidence, XrLocalizationMapErrorFlagBitsML errorFlags)
        {
            this.type = type;
            this.next = next;
            this.session = session;
            this.state = state;
            this.map = map;
            this.confidence = confidence;
            this.errorFlags = errorFlags;
        }
    }
    /// <summary><b>[requires: XR_EXTX_overlay]</b> </summary>
    public unsafe struct XrEventDataMainSessionVisibilityChangedEXTX
    {
        public XrStructureType type = XrStructureType.TypeEventDataMainSessionVisibilityChangedExtx;
        public void* next;
        public int visible;
        public XrOverlayMainSessionFlagBitsEXTX flags;
        public XrEventDataMainSessionVisibilityChangedEXTX() { }
        public XrEventDataMainSessionVisibilityChangedEXTX(XrStructureType type, void* next, int visible, XrOverlayMainSessionFlagBitsEXTX flags)
        {
            this.type = type;
            this.next = next;
            this.visible = visible;
            this.flags = flags;
        }
    }
    /// <summary><b>[requires: XR_VARJO_marker_tracking]</b> </summary>
    public unsafe struct XrEventDataMarkerTrackingUpdateVARJO
    {
        public XrStructureType type = XrStructureType.TypeEventDataMarkerTrackingUpdateVarjo;
        public void* next;
        public ulong markerId;
        public int isActive;
        public int isPredicted;
        public long time;
        public XrEventDataMarkerTrackingUpdateVARJO() { }
        public XrEventDataMarkerTrackingUpdateVARJO(XrStructureType type, void* next, ulong markerId, int isActive, int isPredicted, long time)
        {
            this.type = type;
            this.next = next;
            this.markerId = markerId;
            this.isActive = isActive;
            this.isPredicted = isPredicted;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_META_passthrough_layer_resumed_event]</b> </summary>
    public unsafe struct XrEventDataPassthroughLayerResumedMETA
    {
        public XrStructureType type = XrStructureType.TypeEventDataPassthroughLayerResumedMeta;
        public void* next;
        public XrPassthroughLayerFB layer;
        public XrEventDataPassthroughLayerResumedMETA() { }
        public XrEventDataPassthroughLayerResumedMETA(XrStructureType type, void* next, XrPassthroughLayerFB layer)
        {
            this.type = type;
            this.next = next;
            this.layer = layer;
        }
    }
    /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
    public unsafe struct XrEventDataPassthroughStateChangedFB
    {
        public XrStructureType type = XrStructureType.TypeEventDataPassthroughStateChangedFb;
        public void* next;
        public XrPassthroughStateChangedFlagBitsFB flags;
        public XrEventDataPassthroughStateChangedFB() { }
        public XrEventDataPassthroughStateChangedFB(XrStructureType type, void* next, XrPassthroughStateChangedFlagBitsFB flags)
        {
            this.type = type;
            this.next = next;
            this.flags = flags;
        }
    }
    /// <summary><b>[requires: XR_EXT_performance_settings]</b> </summary>
    public unsafe struct XrEventDataPerfSettingsEXT
    {
        public XrStructureType type = XrStructureType.TypeEventDataPerfSettingsExt;
        public void* next;
        public XrPerfSettingsDomainEXT domain;
        public XrPerfSettingsSubDomainEXT subDomain;
        public XrPerfSettingsNotificationLevelEXT fromLevel;
        public XrPerfSettingsNotificationLevelEXT toLevel;
        public XrEventDataPerfSettingsEXT() { }
        public XrEventDataPerfSettingsEXT(XrStructureType type, void* next, XrPerfSettingsDomainEXT domain, XrPerfSettingsSubDomainEXT subDomain, XrPerfSettingsNotificationLevelEXT fromLevel, XrPerfSettingsNotificationLevelEXT toLevel)
        {
            this.type = type;
            this.next = next;
            this.domain = domain;
            this.subDomain = subDomain;
            this.fromLevel = fromLevel;
            this.toLevel = toLevel;
        }
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    public unsafe struct XrEventDataReferenceSpaceChangePending
    {
        public XrStructureType type = XrStructureType.TypeEventDataReferenceSpaceChangePending;
        public void* next;
        public XrSession session;
        public XrReferenceSpaceType referenceSpaceType;
        public long changeTime;
        public int poseValid;
        public XrPosef poseInPreviousSpace;
        public XrEventDataReferenceSpaceChangePending() { }
        public XrEventDataReferenceSpaceChangePending(XrStructureType type, void* next, XrSession session, XrReferenceSpaceType referenceSpaceType, long changeTime, int poseValid, XrPosef poseInPreviousSpace)
        {
            this.type = type;
            this.next = next;
            this.session = session;
            this.referenceSpaceType = referenceSpaceType;
            this.changeTime = changeTime;
            this.poseValid = poseValid;
            this.poseInPreviousSpace = poseInPreviousSpace;
        }
    }
    /// <summary><b>[requires: XR_FB_scene_capture]</b> </summary>
    public unsafe struct XrEventDataSceneCaptureCompleteFB
    {
        public XrStructureType type = XrStructureType.TypeEventDataSceneCaptureCompleteFb;
        public void* next;
        public ulong requestId;
        public XrResult result;
        public XrEventDataSceneCaptureCompleteFB() { }
        public XrEventDataSceneCaptureCompleteFB(XrStructureType type, void* next, ulong requestId, XrResult result)
        {
            this.type = type;
            this.next = next;
            this.requestId = requestId;
            this.result = result;
        }
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    public unsafe struct XrEventDataSessionStateChanged
    {
        public XrStructureType type = XrStructureType.TypeEventDataSessionStateChanged;
        public void* next;
        public XrSession session;
        public XrSessionState state;
        public long time;
        public XrEventDataSessionStateChanged() { }
        public XrEventDataSessionStateChanged(XrStructureType type, void* next, XrSession session, XrSessionState state, long time)
        {
            this.type = type;
            this.next = next;
            this.session = session;
            this.state = state;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_META_spatial_entity_sharing]</b> </summary>
    public unsafe struct XrEventDataShareSpacesCompleteMETA
    {
        public XrStructureType type = XrStructureType.TypeEventDataShareSpacesCompleteMeta;
        public void* next;
        public ulong requestId;
        public XrResult result;
        public XrEventDataShareSpacesCompleteMETA() { }
        public XrEventDataShareSpacesCompleteMETA(XrStructureType type, void* next, ulong requestId, XrResult result)
        {
            this.type = type;
            this.next = next;
            this.requestId = requestId;
            this.result = result;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_storage]</b> </summary>
    public unsafe struct XrEventDataSpaceEraseCompleteFB
    {
        public XrStructureType type = XrStructureType.TypeEventDataSpaceEraseCompleteFb;
        public void* next;
        public ulong requestId;
        public XrResult result;
        public XrSpace space;
        public XrUuid uuid;
        public XrSpaceStorageLocationFB location;
        public XrEventDataSpaceEraseCompleteFB() { }
        public XrEventDataSpaceEraseCompleteFB(XrStructureType type, void* next, ulong requestId, XrResult result, XrSpace space, XrUuid uuid, XrSpaceStorageLocationFB location)
        {
            this.type = type;
            this.next = next;
            this.requestId = requestId;
            this.result = result;
            this.space = space;
            this.uuid = uuid;
            this.location = location;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_storage_batch]</b> </summary>
    public unsafe struct XrEventDataSpaceListSaveCompleteFB
    {
        public XrStructureType type = XrStructureType.TypeEventDataSpaceListSaveCompleteFb;
        public void* next;
        public ulong requestId;
        public XrResult result;
        public XrEventDataSpaceListSaveCompleteFB() { }
        public XrEventDataSpaceListSaveCompleteFB(XrStructureType type, void* next, ulong requestId, XrResult result)
        {
            this.type = type;
            this.next = next;
            this.requestId = requestId;
            this.result = result;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_query]</b> </summary>
    public unsafe struct XrEventDataSpaceQueryCompleteFB
    {
        public XrStructureType type = XrStructureType.TypeEventDataSpaceQueryCompleteFb;
        public void* next;
        public ulong requestId;
        public XrResult result;
        public XrEventDataSpaceQueryCompleteFB() { }
        public XrEventDataSpaceQueryCompleteFB(XrStructureType type, void* next, ulong requestId, XrResult result)
        {
            this.type = type;
            this.next = next;
            this.requestId = requestId;
            this.result = result;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_query]</b> </summary>
    public unsafe struct XrEventDataSpaceQueryResultsAvailableFB
    {
        public XrStructureType type = XrStructureType.TypeEventDataSpaceQueryResultsAvailableFb;
        public void* next;
        public ulong requestId;
        public XrEventDataSpaceQueryResultsAvailableFB() { }
        public XrEventDataSpaceQueryResultsAvailableFB(XrStructureType type, void* next, ulong requestId)
        {
            this.type = type;
            this.next = next;
            this.requestId = requestId;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_storage]</b> </summary>
    public unsafe struct XrEventDataSpaceSaveCompleteFB
    {
        public XrStructureType type = XrStructureType.TypeEventDataSpaceSaveCompleteFb;
        public void* next;
        public ulong requestId;
        public XrResult result;
        public XrSpace space;
        public XrUuid uuid;
        public XrSpaceStorageLocationFB location;
        public XrEventDataSpaceSaveCompleteFB() { }
        public XrEventDataSpaceSaveCompleteFB(XrStructureType type, void* next, ulong requestId, XrResult result, XrSpace space, XrUuid uuid, XrSpaceStorageLocationFB location)
        {
            this.type = type;
            this.next = next;
            this.requestId = requestId;
            this.result = result;
            this.space = space;
            this.uuid = uuid;
            this.location = location;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity]</b> </summary>
    public unsafe struct XrEventDataSpaceSetStatusCompleteFB
    {
        public XrStructureType type = XrStructureType.TypeEventDataSpaceSetStatusCompleteFb;
        public void* next;
        public ulong requestId;
        public XrResult result;
        public XrSpace space;
        public XrUuid uuid;
        public XrSpaceComponentTypeFB componentType;
        public int enabled;
        public XrEventDataSpaceSetStatusCompleteFB() { }
        public XrEventDataSpaceSetStatusCompleteFB(XrStructureType type, void* next, ulong requestId, XrResult result, XrSpace space, XrUuid uuid, XrSpaceComponentTypeFB componentType, int enabled)
        {
            this.type = type;
            this.next = next;
            this.requestId = requestId;
            this.result = result;
            this.space = space;
            this.uuid = uuid;
            this.componentType = componentType;
            this.enabled = enabled;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_sharing]</b> </summary>
    public unsafe struct XrEventDataSpaceShareCompleteFB
    {
        public XrStructureType type = XrStructureType.TypeEventDataSpaceShareCompleteFb;
        public void* next;
        public ulong requestId;
        public XrResult result;
        public XrEventDataSpaceShareCompleteFB() { }
        public XrEventDataSpaceShareCompleteFB(XrStructureType type, void* next, ulong requestId, XrResult result)
        {
            this.type = type;
            this.next = next;
            this.requestId = requestId;
            this.result = result;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity]</b> </summary>
    public unsafe struct XrEventDataSpatialAnchorCreateCompleteFB
    {
        public XrStructureType type = XrStructureType.TypeEventDataSpatialAnchorCreateCompleteFb;
        public void* next;
        public ulong requestId;
        public XrResult result;
        public XrSpace space;
        public XrUuid uuid;
        public XrEventDataSpatialAnchorCreateCompleteFB() { }
        public XrEventDataSpatialAnchorCreateCompleteFB(XrStructureType type, void* next, ulong requestId, XrResult result, XrSpace space, XrUuid uuid)
        {
            this.type = type;
            this.next = next;
            this.requestId = requestId;
            this.result = result;
            this.space = space;
            this.uuid = uuid;
        }
    }
    /// <summary><b>[requires: XR_META_colocation_discovery]</b> </summary>
    public unsafe struct XrEventDataStartColocationAdvertisementCompleteMETA
    {
        public XrStructureType type = XrStructureType.TypeEventDataStartColocationAdvertisementCompleteMeta;
        public void* next;
        public ulong advertisementRequestId;
        public XrResult result;
        public XrUuid advertisementUuid;
        public XrEventDataStartColocationAdvertisementCompleteMETA() { }
        public XrEventDataStartColocationAdvertisementCompleteMETA(XrStructureType type, void* next, ulong advertisementRequestId, XrResult result, XrUuid advertisementUuid)
        {
            this.type = type;
            this.next = next;
            this.advertisementRequestId = advertisementRequestId;
            this.result = result;
            this.advertisementUuid = advertisementUuid;
        }
    }
    /// <summary><b>[requires: XR_META_colocation_discovery]</b> </summary>
    public unsafe struct XrEventDataStartColocationDiscoveryCompleteMETA
    {
        public XrStructureType type = XrStructureType.TypeEventDataStartColocationDiscoveryCompleteMeta;
        public void* next;
        public ulong discoveryRequestId;
        public XrResult result;
        public XrEventDataStartColocationDiscoveryCompleteMETA() { }
        public XrEventDataStartColocationDiscoveryCompleteMETA(XrStructureType type, void* next, ulong discoveryRequestId, XrResult result)
        {
            this.type = type;
            this.next = next;
            this.discoveryRequestId = discoveryRequestId;
            this.result = result;
        }
    }
    /// <summary><b>[requires: XR_META_colocation_discovery]</b> </summary>
    public unsafe struct XrEventDataStopColocationAdvertisementCompleteMETA
    {
        public XrStructureType type = XrStructureType.TypeEventDataStopColocationAdvertisementCompleteMeta;
        public void* next;
        public ulong requestId;
        public XrResult result;
        public XrEventDataStopColocationAdvertisementCompleteMETA() { }
        public XrEventDataStopColocationAdvertisementCompleteMETA(XrStructureType type, void* next, ulong requestId, XrResult result)
        {
            this.type = type;
            this.next = next;
            this.requestId = requestId;
            this.result = result;
        }
    }
    /// <summary><b>[requires: XR_META_colocation_discovery]</b> </summary>
    public unsafe struct XrEventDataStopColocationDiscoveryCompleteMETA
    {
        public XrStructureType type = XrStructureType.TypeEventDataStopColocationDiscoveryCompleteMeta;
        public void* next;
        public ulong requestId;
        public XrResult result;
        public XrEventDataStopColocationDiscoveryCompleteMETA() { }
        public XrEventDataStopColocationDiscoveryCompleteMETA(XrStructureType type, void* next, ulong requestId, XrResult result)
        {
            this.type = type;
            this.next = next;
            this.requestId = requestId;
            this.result = result;
        }
    }
    /// <summary><b>[requires: XR_EXT_user_presence]</b> </summary>
    public unsafe struct XrEventDataUserPresenceChangedEXT
    {
        public XrStructureType type = XrStructureType.TypeEventDataUserPresenceChangedExt;
        public void* next;
        public XrSession session;
        public int isUserPresent;
        public XrEventDataUserPresenceChangedEXT() { }
        public XrEventDataUserPresenceChangedEXT(XrStructureType type, void* next, XrSession session, int isUserPresent)
        {
            this.type = type;
            this.next = next;
            this.session = session;
            this.isUserPresent = isUserPresent;
        }
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
    public unsafe struct XrEventDataVirtualKeyboardBackspaceMETA
    {
        public XrStructureType type = XrStructureType.TypeEventDataVirtualKeyboardBackspaceMeta;
        public void* next;
        public XrVirtualKeyboardMETA keyboard;
        public XrEventDataVirtualKeyboardBackspaceMETA() { }
        public XrEventDataVirtualKeyboardBackspaceMETA(XrStructureType type, void* next, XrVirtualKeyboardMETA keyboard)
        {
            this.type = type;
            this.next = next;
            this.keyboard = keyboard;
        }
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
    public unsafe struct XrEventDataVirtualKeyboardCommitTextMETA
    {
        public XrStructureType type = XrStructureType.TypeEventDataVirtualKeyboardCommitTextMeta;
        public void* next;
        public XrVirtualKeyboardMETA keyboard;
        [InlineArray(3992)]
        public struct textInlineArray1
        {
            public byte element;
        }
        public textInlineArray1 text;
        public XrEventDataVirtualKeyboardCommitTextMETA() { }
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
    public unsafe struct XrEventDataVirtualKeyboardEnterMETA
    {
        public XrStructureType type = XrStructureType.TypeEventDataVirtualKeyboardEnterMeta;
        public void* next;
        public XrVirtualKeyboardMETA keyboard;
        public XrEventDataVirtualKeyboardEnterMETA() { }
        public XrEventDataVirtualKeyboardEnterMETA(XrStructureType type, void* next, XrVirtualKeyboardMETA keyboard)
        {
            this.type = type;
            this.next = next;
            this.keyboard = keyboard;
        }
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
    public unsafe struct XrEventDataVirtualKeyboardHiddenMETA
    {
        public XrStructureType type = XrStructureType.TypeEventDataVirtualKeyboardHiddenMeta;
        public void* next;
        public XrVirtualKeyboardMETA keyboard;
        public XrEventDataVirtualKeyboardHiddenMETA() { }
        public XrEventDataVirtualKeyboardHiddenMETA(XrStructureType type, void* next, XrVirtualKeyboardMETA keyboard)
        {
            this.type = type;
            this.next = next;
            this.keyboard = keyboard;
        }
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
    public unsafe struct XrEventDataVirtualKeyboardShownMETA
    {
        public XrStructureType type = XrStructureType.TypeEventDataVirtualKeyboardShownMeta;
        public void* next;
        public XrVirtualKeyboardMETA keyboard;
        public XrEventDataVirtualKeyboardShownMETA() { }
        public XrEventDataVirtualKeyboardShownMETA(XrStructureType type, void* next, XrVirtualKeyboardMETA keyboard)
        {
            this.type = type;
            this.next = next;
            this.keyboard = keyboard;
        }
    }
    /// <summary><b>[requires: XR_KHR_visibility_mask]</b> </summary>
    public unsafe struct XrEventDataVisibilityMaskChangedKHR
    {
        public XrStructureType type = XrStructureType.TypeEventDataVisibilityMaskChangedKhr;
        public void* next;
        public XrSession session;
        public XrViewConfigurationType viewConfigurationType;
        public uint viewIndex;
        public XrEventDataVisibilityMaskChangedKHR() { }
        public XrEventDataVisibilityMaskChangedKHR(XrStructureType type, void* next, XrSession session, XrViewConfigurationType viewConfigurationType, uint viewIndex)
        {
            this.type = type;
            this.next = next;
            this.session = session;
            this.viewConfigurationType = viewConfigurationType;
            this.viewIndex = viewIndex;
        }
    }
    /// <summary><b>[requires: XR_HTCX_vive_tracker_interaction]</b> </summary>
    public unsafe struct XrEventDataViveTrackerConnectedHTCX
    {
        public XrStructureType type = XrStructureType.TypeEventDataViveTrackerConnectedHtcx;
        public void* next;
        public XrViveTrackerPathsHTCX* paths;
        public XrEventDataViveTrackerConnectedHTCX() { }
        public XrEventDataViveTrackerConnectedHTCX(XrStructureType type, void* next, XrViveTrackerPathsHTCX* paths)
        {
            this.type = type;
            this.next = next;
            this.paths = paths;
        }
    }
    /// <summary>Used by <see cref="Xr.EnumerateInstanceExtensionProperties"/></summary>
    public unsafe struct XrExtensionProperties
    {
        public XrStructureType type = XrStructureType.TypeExtensionProperties;
        public void* next;
        [InlineArray(128)]
        public struct extensionNameInlineArray1
        {
            public byte element;
        }
        public extensionNameInlineArray1 extensionName;
        public uint extensionVersion;
        public XrExtensionProperties() { }
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Xr.GetMarkerSizeVARJO"/>, <see cref="Xr.GetReferenceSpaceBoundsRect"/></summary>
    public unsafe struct XrExtent2Df
    {
        public float width;
        public float height;
        public XrExtent2Df() { }
        public XrExtent2Df(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
    }
    /// <summary></summary>
    public unsafe struct XrExtent2Di
    {
        public int width;
        public int height;
        public XrExtent2Di() { }
        public XrExtent2Di(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    public unsafe struct XrExtent3Df
    {
        public float width;
        public float height;
        public float depth;
        public XrExtent3Df() { }
        public XrExtent3Df(float width, float height, float depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    }
    /// <summary><b>[requires: XR_EXT_plane_detection]</b> </summary>
    public unsafe struct XrExtent3DfEXT
    {
        public float width;
        public float height;
        public float depth;
        public XrExtent3DfEXT() { }
        public XrExtent3DfEXT(float width, float height, float depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    }
    /// <summary><b>[requires: XR_FB_scene]</b> </summary>
    public unsafe struct XrExtent3DfFB
    {
        public float width;
        public float height;
        public float depth;
        public XrExtent3DfFB() { }
        public XrExtent3DfFB(float width, float height, float depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    }
    /// <summary><b>[requires: XR_KHR_maintenance1]</b> </summary>
    public unsafe struct XrExtent3DfKHR
    {
        public float width;
        public float height;
        public float depth;
        public XrExtent3DfKHR() { }
        public XrExtent3DfKHR(float width, float height, float depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    }
    /// <summary><b>[requires: XR_OCULUS_external_camera]</b> </summary>
    public unsafe struct XrExternalCameraExtrinsicsOCULUS
    {
        public long lastChangeTime;
        public XrExternalCameraStatusFlagBitsOCULUS cameraStatusFlags;
        public XrExternalCameraAttachedToDeviceOCULUS attachedToDevice;
        public XrPosef relativePose;
        public XrExternalCameraExtrinsicsOCULUS() { }
        public XrExternalCameraExtrinsicsOCULUS(long lastChangeTime, XrExternalCameraStatusFlagBitsOCULUS cameraStatusFlags, XrExternalCameraAttachedToDeviceOCULUS attachedToDevice, XrPosef relativePose)
        {
            this.lastChangeTime = lastChangeTime;
            this.cameraStatusFlags = cameraStatusFlags;
            this.attachedToDevice = attachedToDevice;
            this.relativePose = relativePose;
        }
    }
    /// <summary><b>[requires: XR_OCULUS_external_camera]</b> </summary>
    public unsafe struct XrExternalCameraIntrinsicsOCULUS
    {
        public long lastChangeTime;
        public XrFovf fov;
        public float virtualNearPlaneDistance;
        public float virtualFarPlaneDistance;
        public XrExtent2Di imageSensorPixelResolution;
        public XrExternalCameraIntrinsicsOCULUS() { }
        public XrExternalCameraIntrinsicsOCULUS(long lastChangeTime, XrFovf fov, float virtualNearPlaneDistance, float virtualFarPlaneDistance, XrExtent2Di imageSensorPixelResolution)
        {
            this.lastChangeTime = lastChangeTime;
            this.fov = fov;
            this.virtualNearPlaneDistance = virtualNearPlaneDistance;
            this.virtualFarPlaneDistance = virtualFarPlaneDistance;
            this.imageSensorPixelResolution = imageSensorPixelResolution;
        }
    }
    /// <summary><b>[requires: XR_OCULUS_external_camera]</b> Used by <see cref="Xr.EnumerateExternalCamerasOCULUS"/></summary>
    public unsafe struct XrExternalCameraOCULUS
    {
        public XrStructureType type = XrStructureType.TypeExternalCameraOculus;
        public void* next;
        [InlineArray(32)]
        public struct nameInlineArray1
        {
            public byte element;
        }
        public nameInlineArray1 name;
        public XrExternalCameraIntrinsicsOCULUS intrinsics;
        public XrExternalCameraExtrinsicsOCULUS extrinsics;
        public XrExternalCameraOCULUS() { }
    }
    /// <summary><b>[requires: XR_FB_eye_tracking_social]</b> </summary>
    public unsafe struct XrEyeGazeFB
    {
        public int isValid;
        public XrPosef gazePose;
        public float gazeConfidence;
        public XrEyeGazeFB() { }
        public XrEyeGazeFB(int isValid, XrPosef gazePose, float gazeConfidence)
        {
            this.isValid = isValid;
            this.gazePose = gazePose;
            this.gazeConfidence = gazeConfidence;
        }
    }
    /// <summary><b>[requires: XR_EXT_eye_gaze_interaction]</b> </summary>
    public unsafe struct XrEyeGazeSampleTimeEXT
    {
        public XrStructureType type = XrStructureType.TypeEyeGazeSampleTimeExt;
        public void* next;
        public long time;
        public XrEyeGazeSampleTimeEXT() { }
        public XrEyeGazeSampleTimeEXT(XrStructureType type, void* next, long time)
        {
            this.type = type;
            this.next = next;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_FB_eye_tracking_social]</b> Used by <see cref="Xr.GetEyeGazesFB"/></summary>
    public unsafe struct XrEyeGazesFB
    {
        public XrStructureType type = XrStructureType.TypeEyeGazesFb;
        public void* next;
        [InlineArray(2)]
        public struct gazeInlineArray1
        {
            public XrEyeGazeFB element;
        }
        public gazeInlineArray1 gaze;
        public long time;
        public XrEyeGazesFB() { }
    }
    /// <summary><b>[requires: XR_FB_eye_tracking_social]</b> Used by <see cref="Xr.GetEyeGazesFB"/></summary>
    public unsafe struct XrEyeGazesInfoFB
    {
        public XrStructureType type = XrStructureType.TypeEyeGazesInfoFb;
        public void* next;
        public XrSpace baseSpace;
        public long time;
        public XrEyeGazesInfoFB() { }
        public XrEyeGazesInfoFB(XrStructureType type, void* next, XrSpace baseSpace, long time)
        {
            this.type = type;
            this.next = next;
            this.baseSpace = baseSpace;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_FB_eye_tracking_social]</b> Used by <see cref="Xr.CreateEyeTrackerFB"/></summary>
    public unsafe struct XrEyeTrackerCreateInfoFB
    {
        public XrStructureType type = XrStructureType.TypeEyeTrackerCreateInfoFb;
        public void* next;
        public XrEyeTrackerCreateInfoFB() { }
        public XrEyeTrackerCreateInfoFB(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_FB_face_tracking2]</b> Used by <see cref="Xr.GetFaceExpressionWeights2FB"/></summary>
    public unsafe struct XrFaceExpressionInfo2FB
    {
        public XrStructureType type = XrStructureType.TypeFaceExpressionInfo2Fb;
        public void* next;
        public long time;
        public XrFaceExpressionInfo2FB() { }
        public XrFaceExpressionInfo2FB(XrStructureType type, void* next, long time)
        {
            this.type = type;
            this.next = next;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_FB_face_tracking]</b> Used by <see cref="Xr.GetFaceExpressionWeightsFB"/></summary>
    public unsafe struct XrFaceExpressionInfoFB
    {
        public XrStructureType type = XrStructureType.TypeFaceExpressionInfoFb;
        public void* next;
        public long time;
        public XrFaceExpressionInfoFB() { }
        public XrFaceExpressionInfoFB(XrStructureType type, void* next, long time)
        {
            this.type = type;
            this.next = next;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_FB_face_tracking]</b> </summary>
    public unsafe struct XrFaceExpressionStatusFB
    {
        public int isValid;
        public int isEyeFollowingBlendshapesValid;
        public XrFaceExpressionStatusFB() { }
        public XrFaceExpressionStatusFB(int isValid, int isEyeFollowingBlendshapesValid)
        {
            this.isValid = isValid;
            this.isEyeFollowingBlendshapesValid = isEyeFollowingBlendshapesValid;
        }
    }
    /// <summary><b>[requires: XR_FB_face_tracking2]</b> Used by <see cref="Xr.GetFaceExpressionWeights2FB"/></summary>
    public unsafe struct XrFaceExpressionWeights2FB
    {
        public XrStructureType type = XrStructureType.TypeFaceExpressionWeights2Fb;
        public void* next;
        public uint weightCount;
        public float* weights;
        public uint confidenceCount;
        public float* confidences;
        public int isValid;
        public int isEyeFollowingBlendshapesValid;
        public XrFaceTrackingDataSource2FB dataSource;
        public long time;
        public XrFaceExpressionWeights2FB() { }
        public XrFaceExpressionWeights2FB(XrStructureType type, void* next, uint weightCount, float* weights, uint confidenceCount, float* confidences, int isValid, int isEyeFollowingBlendshapesValid, XrFaceTrackingDataSource2FB dataSource, long time)
        {
            this.type = type;
            this.next = next;
            this.weightCount = weightCount;
            this.weights = weights;
            this.confidenceCount = confidenceCount;
            this.confidences = confidences;
            this.isValid = isValid;
            this.isEyeFollowingBlendshapesValid = isEyeFollowingBlendshapesValid;
            this.dataSource = dataSource;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_FB_face_tracking]</b> Used by <see cref="Xr.GetFaceExpressionWeightsFB"/></summary>
    public unsafe struct XrFaceExpressionWeightsFB
    {
        public XrStructureType type = XrStructureType.TypeFaceExpressionWeightsFb;
        public void* next;
        public uint weightCount;
        public float* weights;
        public uint confidenceCount;
        public float* confidences;
        public XrFaceExpressionStatusFB status;
        public long time;
        public XrFaceExpressionWeightsFB() { }
        public XrFaceExpressionWeightsFB(XrStructureType type, void* next, uint weightCount, float* weights, uint confidenceCount, float* confidences, XrFaceExpressionStatusFB status, long time)
        {
            this.type = type;
            this.next = next;
            this.weightCount = weightCount;
            this.weights = weights;
            this.confidenceCount = confidenceCount;
            this.confidences = confidences;
            this.status = status;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_FB_face_tracking2]</b> Used by <see cref="Xr.CreateFaceTracker2FB"/></summary>
    public unsafe struct XrFaceTrackerCreateInfo2FB
    {
        public XrStructureType type = XrStructureType.TypeFaceTrackerCreateInfo2Fb;
        public void* next;
        public XrFaceExpressionSet2FB faceExpressionSet;
        public uint requestedDataSourceCount;
        public XrFaceTrackingDataSource2FB* requestedDataSources;
        public XrFaceTrackerCreateInfo2FB() { }
        public XrFaceTrackerCreateInfo2FB(XrStructureType type, void* next, XrFaceExpressionSet2FB faceExpressionSet, uint requestedDataSourceCount, XrFaceTrackingDataSource2FB* requestedDataSources)
        {
            this.type = type;
            this.next = next;
            this.faceExpressionSet = faceExpressionSet;
            this.requestedDataSourceCount = requestedDataSourceCount;
            this.requestedDataSources = requestedDataSources;
        }
    }
    /// <summary><b>[requires: XR_FB_face_tracking]</b> Used by <see cref="Xr.CreateFaceTrackerFB"/></summary>
    public unsafe struct XrFaceTrackerCreateInfoFB
    {
        public XrStructureType type = XrStructureType.TypeFaceTrackerCreateInfoFb;
        public void* next;
        public XrFaceExpressionSetFB faceExpressionSet;
        public XrFaceTrackerCreateInfoFB() { }
        public XrFaceTrackerCreateInfoFB(XrStructureType type, void* next, XrFaceExpressionSetFB faceExpressionSet)
        {
            this.type = type;
            this.next = next;
            this.faceExpressionSet = faceExpressionSet;
        }
    }
    /// <summary><b>[requires: XR_ML_facial_expression]</b> Used by <see cref="Xr.GetFacialExpressionBlendShapePropertiesML"/></summary>
    public unsafe struct XrFacialExpressionBlendShapeGetInfoML
    {
        public XrStructureType type = XrStructureType.TypeFacialExpressionBlendShapeGetInfoMl;
        public void* next;
        public XrFacialExpressionBlendShapeGetInfoML() { }
        public XrFacialExpressionBlendShapeGetInfoML(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_ML_facial_expression]</b> Used by <see cref="Xr.GetFacialExpressionBlendShapePropertiesML"/></summary>
    public unsafe struct XrFacialExpressionBlendShapePropertiesML
    {
        public XrStructureType type = XrStructureType.TypeFacialExpressionBlendShapePropertiesMl;
        public void* next;
        public XrFacialBlendShapeML requestedFacialBlendShape;
        public float weight;
        public XrFacialExpressionBlendShapePropertiesFlagBitsML flags;
        public long time;
        public XrFacialExpressionBlendShapePropertiesML() { }
        public XrFacialExpressionBlendShapePropertiesML(XrStructureType type, void* next, XrFacialBlendShapeML requestedFacialBlendShape, float weight, XrFacialExpressionBlendShapePropertiesFlagBitsML flags, long time)
        {
            this.type = type;
            this.next = next;
            this.requestedFacialBlendShape = requestedFacialBlendShape;
            this.weight = weight;
            this.flags = flags;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_ML_facial_expression]</b> Used by <see cref="Xr.CreateFacialExpressionClientML"/></summary>
    public unsafe struct XrFacialExpressionClientCreateInfoML
    {
        public XrStructureType type = XrStructureType.TypeFacialExpressionClientCreateInfoMl;
        public void* next;
        public uint requestedCount;
        public XrFacialBlendShapeML* requestedFacialBlendShapes;
        public XrFacialExpressionClientCreateInfoML() { }
        public XrFacialExpressionClientCreateInfoML(XrStructureType type, void* next, uint requestedCount, XrFacialBlendShapeML* requestedFacialBlendShapes)
        {
            this.type = type;
            this.next = next;
            this.requestedCount = requestedCount;
            this.requestedFacialBlendShapes = requestedFacialBlendShapes;
        }
    }
    /// <summary><b>[requires: XR_HTC_facial_tracking]</b> Used by <see cref="Xr.GetFacialExpressionsHTC"/></summary>
    public unsafe struct XrFacialExpressionsHTC
    {
        public XrStructureType type = XrStructureType.TypeFacialExpressionsHtc;
        public void* next;
        public int isActive;
        public long sampleTime;
        public uint expressionCount;
        public float* expressionWeightings;
        public XrFacialExpressionsHTC() { }
        public XrFacialExpressionsHTC(XrStructureType type, void* next, int isActive, long sampleTime, uint expressionCount, float* expressionWeightings)
        {
            this.type = type;
            this.next = next;
            this.isActive = isActive;
            this.sampleTime = sampleTime;
            this.expressionCount = expressionCount;
            this.expressionWeightings = expressionWeightings;
        }
    }
    /// <summary><b>[requires: XR_HTC_facial_tracking]</b> Used by <see cref="Xr.CreateFacialTrackerHTC"/></summary>
    public unsafe struct XrFacialTrackerCreateInfoHTC
    {
        public XrStructureType type = XrStructureType.TypeFacialTrackerCreateInfoHtc;
        public void* next;
        public XrFacialTrackingTypeHTC facialTrackingType;
        public XrFacialTrackerCreateInfoHTC() { }
        public XrFacialTrackerCreateInfoHTC(XrStructureType type, void* next, XrFacialTrackingTypeHTC facialTrackingType)
        {
            this.type = type;
            this.next = next;
            this.facialTrackingType = facialTrackingType;
        }
    }
    /// <summary><b>[requires: XR_MNDX_force_feedback_curl]</b> </summary>
    public unsafe struct XrForceFeedbackCurlApplyLocationMNDX
    {
        public XrForceFeedbackCurlLocationMNDX location;
        public float value;
        public XrForceFeedbackCurlApplyLocationMNDX() { }
        public XrForceFeedbackCurlApplyLocationMNDX(XrForceFeedbackCurlLocationMNDX location, float value)
        {
            this.location = location;
            this.value = value;
        }
    }
    /// <summary><b>[requires: XR_MNDX_force_feedback_curl]</b> Used by <see cref="Xr.ApplyForceFeedbackCurlMNDX"/></summary>
    public unsafe struct XrForceFeedbackCurlApplyLocationsMNDX
    {
        public XrStructureType type = XrStructureType.TypeForceFeedbackCurlApplyLocationsMndx;
        public void* next;
        public uint locationCount;
        public XrForceFeedbackCurlApplyLocationMNDX* locations;
        public XrForceFeedbackCurlApplyLocationsMNDX() { }
        public XrForceFeedbackCurlApplyLocationsMNDX(XrStructureType type, void* next, uint locationCount, XrForceFeedbackCurlApplyLocationMNDX* locations)
        {
            this.type = type;
            this.next = next;
            this.locationCount = locationCount;
            this.locations = locations;
        }
    }
    /// <summary><b>[requires: XR_VARJO_foveated_rendering]</b> </summary>
    public unsafe struct XrFoveatedViewConfigurationViewVARJO
    {
        public XrStructureType type = XrStructureType.TypeFoveatedViewConfigurationViewVarjo;
        public void* next;
        public int foveatedRenderingActive;
        public XrFoveatedViewConfigurationViewVARJO() { }
        public XrFoveatedViewConfigurationViewVARJO(XrStructureType type, void* next, int foveatedRenderingActive)
        {
            this.type = type;
            this.next = next;
            this.foveatedRenderingActive = foveatedRenderingActive;
        }
    }
    /// <summary><b>[requires: XR_HTC_foveation]</b> Used by <see cref="Xr.ApplyFoveationHTC"/></summary>
    public unsafe struct XrFoveationApplyInfoHTC
    {
        public XrStructureType type = XrStructureType.TypeFoveationApplyInfoHtc;
        public void* next;
        public XrFoveationModeHTC mode;
        public uint subImageCount;
        public XrSwapchainSubImage* subImages;
        public XrFoveationApplyInfoHTC() { }
        public XrFoveationApplyInfoHTC(XrStructureType type, void* next, XrFoveationModeHTC mode, uint subImageCount, XrSwapchainSubImage* subImages)
        {
            this.type = type;
            this.next = next;
            this.mode = mode;
            this.subImageCount = subImageCount;
            this.subImages = subImages;
        }
    }
    /// <summary><b>[requires: XR_HTC_foveation]</b> </summary>
    public unsafe struct XrFoveationConfigurationHTC
    {
        public XrFoveationLevelHTC level;
        public float clearFovDegree;
        public XrVector2f focalCenterOffset;
        public XrFoveationConfigurationHTC() { }
        public XrFoveationConfigurationHTC(XrFoveationLevelHTC level, float clearFovDegree, XrVector2f focalCenterOffset)
        {
            this.level = level;
            this.clearFovDegree = clearFovDegree;
            this.focalCenterOffset = focalCenterOffset;
        }
    }
    /// <summary><b>[requires: XR_HTC_foveation]</b> </summary>
    public unsafe struct XrFoveationCustomModeInfoHTC
    {
        public XrStructureType type = XrStructureType.TypeFoveationCustomModeInfoHtc;
        public void* next;
        public uint configCount;
        public XrFoveationConfigurationHTC* configs;
        public XrFoveationCustomModeInfoHTC() { }
        public XrFoveationCustomModeInfoHTC(XrStructureType type, void* next, uint configCount, XrFoveationConfigurationHTC* configs)
        {
            this.type = type;
            this.next = next;
            this.configCount = configCount;
            this.configs = configs;
        }
    }
    /// <summary><b>[requires: XR_HTC_foveation]</b> </summary>
    public unsafe struct XrFoveationDynamicModeInfoHTC
    {
        public XrStructureType type = XrStructureType.TypeFoveationDynamicModeInfoHtc;
        public void* next;
        public XrFoveationDynamicFlagBitsHTC dynamicFlags;
        public XrFoveationDynamicModeInfoHTC() { }
        public XrFoveationDynamicModeInfoHTC(XrStructureType type, void* next, XrFoveationDynamicFlagBitsHTC dynamicFlags)
        {
            this.type = type;
            this.next = next;
            this.dynamicFlags = dynamicFlags;
        }
    }
    /// <summary><b>[requires: XR_META_foveation_eye_tracked]</b> </summary>
    public unsafe struct XrFoveationEyeTrackedProfileCreateInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeFoveationEyeTrackedProfileCreateInfoMeta;
        public void* next;
        public XrFoveationEyeTrackedProfileCreateFlagBitsMETA flags;
        public XrFoveationEyeTrackedProfileCreateInfoMETA() { }
        public XrFoveationEyeTrackedProfileCreateInfoMETA(XrStructureType type, void* next, XrFoveationEyeTrackedProfileCreateFlagBitsMETA flags)
        {
            this.type = type;
            this.next = next;
            this.flags = flags;
        }
    }
    /// <summary><b>[requires: XR_META_foveation_eye_tracked]</b> Used by <see cref="Xr.GetFoveationEyeTrackedStateMETA"/></summary>
    public unsafe struct XrFoveationEyeTrackedStateMETA
    {
        public XrStructureType type = XrStructureType.TypeFoveationEyeTrackedStateMeta;
        public void* next;
        [InlineArray(2)]
        public struct foveationCenterInlineArray1
        {
            public XrVector2f element;
        }
        public foveationCenterInlineArray1 foveationCenter;
        public XrFoveationEyeTrackedStateFlagBitsMETA flags;
        public XrFoveationEyeTrackedStateMETA() { }
    }
    /// <summary><b>[requires: XR_FB_foveation_configuration]</b> </summary>
    public unsafe struct XrFoveationLevelProfileCreateInfoFB
    {
        public XrStructureType type = XrStructureType.TypeFoveationLevelProfileCreateInfoFb;
        public void* next;
        public XrFoveationLevelFB level;
        public float verticalOffset;
        public XrFoveationDynamicFB dynamic;
        public XrFoveationLevelProfileCreateInfoFB() { }
        public XrFoveationLevelProfileCreateInfoFB(XrStructureType type, void* next, XrFoveationLevelFB level, float verticalOffset, XrFoveationDynamicFB dynamic)
        {
            this.type = type;
            this.next = next;
            this.level = level;
            this.verticalOffset = verticalOffset;
            this.dynamic = dynamic;
        }
    }
    /// <summary><b>[requires: XR_FB_foveation]</b> Used by <see cref="Xr.CreateFoveationProfileFB"/></summary>
    public unsafe struct XrFoveationProfileCreateInfoFB
    {
        public XrStructureType type = XrStructureType.TypeFoveationProfileCreateInfoFb;
        public void* next;
        public XrFoveationProfileCreateInfoFB() { }
        public XrFoveationProfileCreateInfoFB(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary></summary>
    public unsafe struct XrFovf
    {
        public float angleLeft;
        public float angleRight;
        public float angleUp;
        public float angleDown;
        public XrFovf() { }
        public XrFovf(float angleLeft, float angleRight, float angleUp, float angleDown)
        {
            this.angleLeft = angleLeft;
            this.angleRight = angleRight;
            this.angleUp = angleUp;
            this.angleDown = angleDown;
        }
    }
    /// <summary>Used by <see cref="Xr.BeginFrame"/></summary>
    public unsafe struct XrFrameBeginInfo
    {
        public XrStructureType type = XrStructureType.TypeFrameBeginInfo;
        public void* next;
        public XrFrameBeginInfo() { }
        public XrFrameBeginInfo(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary>Used by <see cref="Xr.EndFrame"/></summary>
    public unsafe struct XrFrameEndInfo
    {
        public XrStructureType type = XrStructureType.TypeFrameEndInfo;
        public void* next;
        public long displayTime;
        public XrEnvironmentBlendMode environmentBlendMode;
        public uint layerCount;
        public XrCompositionLayerBaseHeader** layers;
        public XrFrameEndInfo() { }
        public XrFrameEndInfo(XrStructureType type, void* next, long displayTime, XrEnvironmentBlendMode environmentBlendMode, uint layerCount, XrCompositionLayerBaseHeader** layers)
        {
            this.type = type;
            this.next = next;
            this.displayTime = displayTime;
            this.environmentBlendMode = environmentBlendMode;
            this.layerCount = layerCount;
            this.layers = layers;
        }
    }
    /// <summary><b>[requires: XR_ML_frame_end_info]</b> </summary>
    public unsafe struct XrFrameEndInfoML
    {
        public XrStructureType type = XrStructureType.TypeFrameEndInfoMl;
        public void* next;
        public float focusDistance;
        public XrFrameEndInfoFlagBitsML flags;
        public XrFrameEndInfoML() { }
        public XrFrameEndInfoML(XrStructureType type, void* next, float focusDistance, XrFrameEndInfoFlagBitsML flags)
        {
            this.type = type;
            this.next = next;
            this.focusDistance = focusDistance;
            this.flags = flags;
        }
    }
    /// <summary>Used by <see cref="Xr.WaitFrame"/></summary>
    public unsafe struct XrFrameState
    {
        public XrStructureType type = XrStructureType.TypeFrameState;
        public void* next;
        public long predictedDisplayTime;
        public long predictedDisplayPeriod;
        public int shouldRender;
        public XrFrameState() { }
        public XrFrameState(XrStructureType type, void* next, long predictedDisplayTime, long predictedDisplayPeriod, int shouldRender)
        {
            this.type = type;
            this.next = next;
            this.predictedDisplayTime = predictedDisplayTime;
            this.predictedDisplayPeriod = predictedDisplayPeriod;
            this.shouldRender = shouldRender;
        }
    }
    /// <summary><b>[requires: XR_EXT_frame_synthesis]</b> </summary>
    public unsafe struct XrFrameSynthesisConfigViewEXT
    {
        public XrStructureType type = XrStructureType.TypeFrameSynthesisConfigViewExt;
        public void* next;
        public uint recommendedMotionVectorImageRectWidth;
        public uint recommendedMotionVectorImageRectHeight;
        public XrFrameSynthesisConfigViewEXT() { }
        public XrFrameSynthesisConfigViewEXT(XrStructureType type, void* next, uint recommendedMotionVectorImageRectWidth, uint recommendedMotionVectorImageRectHeight)
        {
            this.type = type;
            this.next = next;
            this.recommendedMotionVectorImageRectWidth = recommendedMotionVectorImageRectWidth;
            this.recommendedMotionVectorImageRectHeight = recommendedMotionVectorImageRectHeight;
        }
    }
    /// <summary><b>[requires: XR_EXT_frame_synthesis]</b> </summary>
    public unsafe struct XrFrameSynthesisInfoEXT
    {
        public XrStructureType type = XrStructureType.TypeFrameSynthesisInfoExt;
        public void* next;
        public XrFrameSynthesisInfoFlagBitsEXT layerFlags;
        public XrSwapchainSubImage motionVectorSubImage;
        public XrVector4f motionVectorScale;
        public XrVector4f motionVectorOffset;
        public XrPosef appSpaceDeltaPose;
        public XrSwapchainSubImage depthSubImage;
        public float minDepth;
        public float maxDepth;
        public float nearZ;
        public float farZ;
        public XrFrameSynthesisInfoEXT() { }
        public XrFrameSynthesisInfoEXT(XrStructureType type, void* next, XrFrameSynthesisInfoFlagBitsEXT layerFlags, XrSwapchainSubImage motionVectorSubImage, XrVector4f motionVectorScale, XrVector4f motionVectorOffset, XrPosef appSpaceDeltaPose, XrSwapchainSubImage depthSubImage, float minDepth, float maxDepth, float nearZ, float farZ)
        {
            this.type = type;
            this.next = next;
            this.layerFlags = layerFlags;
            this.motionVectorSubImage = motionVectorSubImage;
            this.motionVectorScale = motionVectorScale;
            this.motionVectorOffset = motionVectorOffset;
            this.appSpaceDeltaPose = appSpaceDeltaPose;
            this.depthSubImage = depthSubImage;
            this.minDepth = minDepth;
            this.maxDepth = maxDepth;
            this.nearZ = nearZ;
            this.farZ = farZ;
        }
    }
    /// <summary>Used by <see cref="Xr.WaitFrame"/></summary>
    public unsafe struct XrFrameWaitInfo
    {
        public XrStructureType type = XrStructureType.TypeFrameWaitInfo;
        public void* next;
        public XrFrameWaitInfo() { }
        public XrFrameWaitInfo(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    public unsafe struct XrFrustumf
    {
        public XrPosef pose;
        public XrFovf fov;
        public float nearZ;
        public float farZ;
        public XrFrustumf() { }
        public XrFrustumf(XrPosef pose, XrFovf fov, float nearZ, float farZ)
        {
            this.pose = pose;
            this.fov = fov;
            this.nearZ = nearZ;
            this.farZ = farZ;
        }
    }
    /// <summary><b>[requires: XR_KHR_maintenance1]</b> </summary>
    public unsafe struct XrFrustumfKHR
    {
        public XrPosef pose;
        public XrFovf fov;
        public float nearZ;
        public float farZ;
        public XrFrustumfKHR() { }
        public XrFrustumfKHR(XrPosef pose, XrFovf fov, float nearZ, float farZ)
        {
            this.pose = pose;
            this.fov = fov;
            this.nearZ = nearZ;
            this.farZ = farZ;
        }
    }
    /// <summary><b>[requires: XR_EXT_future]</b> Used by <see cref="Xr.CancelFutureEXT"/></summary>
    public unsafe struct XrFutureCancelInfoEXT
    {
        public XrStructureType type = XrStructureType.TypeFutureCancelInfoExt;
        public void* next;
        public ulong future;
        public XrFutureCancelInfoEXT() { }
        public XrFutureCancelInfoEXT(XrStructureType type, void* next, ulong future)
        {
            this.type = type;
            this.next = next;
            this.future = future;
        }
    }
    /// <summary><b>[requires: XR_EXT_future]</b> </summary>
    public unsafe struct XrFutureCompletionBaseHeaderEXT
    {
        public XrStructureType type;
        public void* next;
        public XrResult futureResult;
        public XrFutureCompletionBaseHeaderEXT() { }
        public XrFutureCompletionBaseHeaderEXT(XrStructureType type, void* next, XrResult futureResult)
        {
            this.type = type;
            this.next = next;
            this.futureResult = futureResult;
        }
    }
    /// <summary><b>[requires: XR_EXT_future]</b> </summary>
    public unsafe struct XrFutureCompletionEXT
    {
        public XrStructureType type = XrStructureType.TypeFutureCompletionExt;
        public void* next;
        public XrResult futureResult;
        public XrFutureCompletionEXT() { }
        public XrFutureCompletionEXT(XrStructureType type, void* next, XrResult futureResult)
        {
            this.type = type;
            this.next = next;
            this.futureResult = futureResult;
        }
    }
    /// <summary><b>[requires: XR_EXT_future]</b> Used by <see cref="Xr.PollFutureEXT"/></summary>
    public unsafe struct XrFuturePollInfoEXT
    {
        public XrStructureType type = XrStructureType.TypeFuturePollInfoExt;
        public void* next;
        public ulong future;
        public XrFuturePollInfoEXT() { }
        public XrFuturePollInfoEXT(XrStructureType type, void* next, ulong future)
        {
            this.type = type;
            this.next = next;
            this.future = future;
        }
    }
    /// <summary><b>[requires: XR_EXT_future]</b> Used by <see cref="Xr.PollFutureEXT"/></summary>
    public unsafe struct XrFuturePollResultEXT
    {
        public XrStructureType type = XrStructureType.TypeFuturePollResultExt;
        public void* next;
        public XrFutureStateEXT state;
        public XrFuturePollResultEXT() { }
        public XrFuturePollResultEXT(XrStructureType type, void* next, XrFutureStateEXT state)
        {
            this.type = type;
            this.next = next;
            this.state = state;
        }
    }
    /// <summary><b>[requires: XR_FB_passthrough]</b> Used by <see cref="Xr.CreateGeometryInstanceFB"/></summary>
    public unsafe struct XrGeometryInstanceCreateInfoFB
    {
        public XrStructureType type = XrStructureType.TypeGeometryInstanceCreateInfoFb;
        public void* next;
        public XrPassthroughLayerFB layer;
        public XrTriangleMeshFB mesh;
        public XrSpace baseSpace;
        public XrPosef pose;
        public XrVector3f scale;
        public XrGeometryInstanceCreateInfoFB() { }
        public XrGeometryInstanceCreateInfoFB(XrStructureType type, void* next, XrPassthroughLayerFB layer, XrTriangleMeshFB mesh, XrSpace baseSpace, XrPosef pose, XrVector3f scale)
        {
            this.type = type;
            this.next = next;
            this.layer = layer;
            this.mesh = mesh;
            this.baseSpace = baseSpace;
            this.pose = pose;
            this.scale = scale;
        }
    }
    /// <summary><b>[requires: XR_FB_passthrough]</b> Used by <see cref="Xr.GeometryInstanceSetTransformFB"/></summary>
    public unsafe struct XrGeometryInstanceTransformFB
    {
        public XrStructureType type = XrStructureType.TypeGeometryInstanceTransformFb;
        public void* next;
        public XrSpace baseSpace;
        public long time;
        public XrPosef pose;
        public XrVector3f scale;
        public XrGeometryInstanceTransformFB() { }
        public XrGeometryInstanceTransformFB(XrStructureType type, void* next, XrSpace baseSpace, long time, XrPosef pose, XrVector3f scale)
        {
            this.type = type;
            this.next = next;
            this.baseSpace = baseSpace;
            this.time = time;
            this.pose = pose;
            this.scale = scale;
        }
    }
    /// <summary><b>[requires: XR_ML_global_dimmer]</b> </summary>
    public unsafe struct XrGlobalDimmerFrameEndInfoML
    {
        public XrStructureType type = XrStructureType.TypeGlobalDimmerFrameEndInfoMl;
        public void* next;
        public float dimmerValue;
        public XrGlobalDimmerFrameEndInfoFlagBitsML flags;
        public XrGlobalDimmerFrameEndInfoML() { }
        public XrGlobalDimmerFrameEndInfoML(XrStructureType type, void* next, float dimmerValue, XrGlobalDimmerFrameEndInfoFlagBitsML flags)
        {
            this.type = type;
            this.next = next;
            this.dimmerValue = dimmerValue;
            this.flags = flags;
        }
    }
    /// <summary><b>[requires: XR_KHR_D3D11_enable]</b> </summary>
    public unsafe struct XrGraphicsBindingD3D11KHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsBindingD3d11Khr;
        public void* next;
        public IntPtr* device;
        public XrGraphicsBindingD3D11KHR() { }
        public XrGraphicsBindingD3D11KHR(XrStructureType type, void* next, IntPtr* device)
        {
            this.type = type;
            this.next = next;
            this.device = device;
        }
    }
    /// <summary><b>[requires: XR_KHR_D3D12_enable]</b> </summary>
    public unsafe struct XrGraphicsBindingD3D12KHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsBindingD3d12Khr;
        public void* next;
        public IntPtr* device;
        public IntPtr* queue;
        public XrGraphicsBindingD3D12KHR() { }
        public XrGraphicsBindingD3D12KHR(XrStructureType type, void* next, IntPtr* device, IntPtr* queue)
        {
            this.type = type;
            this.next = next;
            this.device = device;
            this.queue = queue;
        }
    }
    /// <summary><b>[requires: XR_MNDX_egl_enable]</b> </summary>
    public unsafe struct XrGraphicsBindingEGLMNDX
    {
        public XrStructureType type = XrStructureType.TypeGraphicsBindingEglMndx;
        public void* next;
        public delegate* unmanaged[Cdecl]<byte*, void*> getProcAddress;
        public EGLDisplay display;
        public EGLConfig config;
        public EGLContext context;
        public XrGraphicsBindingEGLMNDX() { }
        public XrGraphicsBindingEGLMNDX(XrStructureType type, void* next, delegate* unmanaged[Cdecl]<byte*, void*> getProcAddress, EGLDisplay display, EGLConfig config, EGLContext context)
        {
            this.type = type;
            this.next = next;
            this.getProcAddress = getProcAddress;
            this.display = display;
            this.config = config;
            this.context = context;
        }
    }
    /// <summary><b>[requires: XR_KHR_metal_enable]</b> </summary>
    public unsafe struct XrGraphicsBindingMetalKHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsBindingMetalKhr;
        public void* next;
        public void* commandQueue;
        public XrGraphicsBindingMetalKHR() { }
        public XrGraphicsBindingMetalKHR(XrStructureType type, void* next, void* commandQueue)
        {
            this.type = type;
            this.next = next;
            this.commandQueue = commandQueue;
        }
    }
    /// <summary><b>[requires: XR_KHR_opengl_es_enable]</b> </summary>
    public unsafe struct XrGraphicsBindingOpenGLESAndroidKHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsBindingOpenglEsAndroidKhr;
        public void* next;
        public EGLDisplay display;
        public EGLConfig config;
        public EGLContext context;
        public XrGraphicsBindingOpenGLESAndroidKHR() { }
        public XrGraphicsBindingOpenGLESAndroidKHR(XrStructureType type, void* next, EGLDisplay display, EGLConfig config, EGLContext context)
        {
            this.type = type;
            this.next = next;
            this.display = display;
            this.config = config;
            this.context = context;
        }
    }
    /// <summary><b>[requires: XR_KHR_opengl_enable]</b> </summary>
    public unsafe struct XrGraphicsBindingOpenGLWaylandKHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsBindingOpenglWaylandKhr;
        public void* next;
        public IntPtr display;
        public XrGraphicsBindingOpenGLWaylandKHR() { }
        public XrGraphicsBindingOpenGLWaylandKHR(XrStructureType type, void* next, IntPtr display)
        {
            this.type = type;
            this.next = next;
            this.display = display;
        }
    }
    /// <summary><b>[requires: XR_KHR_opengl_enable]</b> </summary>
    public unsafe struct XrGraphicsBindingOpenGLWin32KHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsBindingOpenglWin32Khr;
        public void* next;
        public IntPtr hDC;
        public IntPtr hGLRC;
        public XrGraphicsBindingOpenGLWin32KHR() { }
        public XrGraphicsBindingOpenGLWin32KHR(XrStructureType type, void* next, IntPtr hDC, IntPtr hGLRC)
        {
            this.type = type;
            this.next = next;
            this.hDC = hDC;
            this.hGLRC = hGLRC;
        }
    }
    /// <summary><b>[requires: XR_KHR_opengl_enable]</b> </summary>
    public unsafe struct XrGraphicsBindingOpenGLXcbKHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsBindingOpenglXcbKhr;
        public void* next;
        public IntPtr connection;
        public uint screenNumber;
        public uint fbconfigid;
        public uint visualid;
        public uint glxDrawable;
        public uint glxContext;
        public XrGraphicsBindingOpenGLXcbKHR() { }
        public XrGraphicsBindingOpenGLXcbKHR(XrStructureType type, void* next, IntPtr connection, uint screenNumber, uint fbconfigid, uint visualid, uint glxDrawable, uint glxContext)
        {
            this.type = type;
            this.next = next;
            this.connection = connection;
            this.screenNumber = screenNumber;
            this.fbconfigid = fbconfigid;
            this.visualid = visualid;
            this.glxDrawable = glxDrawable;
            this.glxContext = glxContext;
        }
    }
    /// <summary><b>[requires: XR_KHR_opengl_enable]</b> </summary>
    public unsafe struct XrGraphicsBindingOpenGLXlibKHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsBindingOpenglXlibKhr;
        public void* next;
        public IntPtr xDisplay;
        public uint visualid;
        public GLXFBConfig glxFBConfig;
        public GLXDrawable glxDrawable;
        public GLXContext glxContext;
        public XrGraphicsBindingOpenGLXlibKHR() { }
        public XrGraphicsBindingOpenGLXlibKHR(XrStructureType type, void* next, IntPtr xDisplay, uint visualid, GLXFBConfig glxFBConfig, GLXDrawable glxDrawable, GLXContext glxContext)
        {
            this.type = type;
            this.next = next;
            this.xDisplay = xDisplay;
            this.visualid = visualid;
            this.glxFBConfig = glxFBConfig;
            this.glxDrawable = glxDrawable;
            this.glxContext = glxContext;
        }
    }
    /// <summary><b>[requires: XR_KHR_vulkan_enable2]</b> </summary>
    public unsafe struct XrGraphicsBindingVulkan2KHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsBindingVulkanKhr;
        public void* next;
        public VkInstance instance;
        public VkPhysicalDevice physicalDevice;
        public VkDevice device;
        public uint queueFamilyIndex;
        public uint queueIndex;
        public XrGraphicsBindingVulkan2KHR() { }
        public XrGraphicsBindingVulkan2KHR(XrStructureType type, void* next, VkInstance instance, VkPhysicalDevice physicalDevice, VkDevice device, uint queueFamilyIndex, uint queueIndex)
        {
            this.type = type;
            this.next = next;
            this.instance = instance;
            this.physicalDevice = physicalDevice;
            this.device = device;
            this.queueFamilyIndex = queueFamilyIndex;
            this.queueIndex = queueIndex;
        }
    }
    /// <summary><b>[requires: XR_KHR_vulkan_enable]</b> </summary>
    public unsafe struct XrGraphicsBindingVulkanKHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsBindingVulkanKhr;
        public void* next;
        public VkInstance instance;
        public VkPhysicalDevice physicalDevice;
        public VkDevice device;
        public uint queueFamilyIndex;
        public uint queueIndex;
        public XrGraphicsBindingVulkanKHR() { }
        public XrGraphicsBindingVulkanKHR(XrStructureType type, void* next, VkInstance instance, VkPhysicalDevice physicalDevice, VkDevice device, uint queueFamilyIndex, uint queueIndex)
        {
            this.type = type;
            this.next = next;
            this.instance = instance;
            this.physicalDevice = physicalDevice;
            this.device = device;
            this.queueFamilyIndex = queueFamilyIndex;
            this.queueIndex = queueIndex;
        }
    }
    /// <summary><b>[requires: XR_KHR_D3D11_enable]</b> Used by <see cref="Xr.GetD3D11GraphicsRequirementsKHR"/></summary>
    public unsafe struct XrGraphicsRequirementsD3D11KHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsRequirementsD3d11Khr;
        public void* next;
        public Guid adapterLuid;
        public int minFeatureLevel;
        public XrGraphicsRequirementsD3D11KHR() { }
        public XrGraphicsRequirementsD3D11KHR(XrStructureType type, void* next, Guid adapterLuid, int minFeatureLevel)
        {
            this.type = type;
            this.next = next;
            this.adapterLuid = adapterLuid;
            this.minFeatureLevel = minFeatureLevel;
        }
    }
    /// <summary><b>[requires: XR_KHR_D3D12_enable]</b> Used by <see cref="Xr.GetD3D12GraphicsRequirementsKHR"/></summary>
    public unsafe struct XrGraphicsRequirementsD3D12KHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsRequirementsD3d12Khr;
        public void* next;
        public Guid adapterLuid;
        public int minFeatureLevel;
        public XrGraphicsRequirementsD3D12KHR() { }
        public XrGraphicsRequirementsD3D12KHR(XrStructureType type, void* next, Guid adapterLuid, int minFeatureLevel)
        {
            this.type = type;
            this.next = next;
            this.adapterLuid = adapterLuid;
            this.minFeatureLevel = minFeatureLevel;
        }
    }
    /// <summary><b>[requires: XR_KHR_metal_enable]</b> Used by <see cref="Xr.GetMetalGraphicsRequirementsKHR"/></summary>
    public unsafe struct XrGraphicsRequirementsMetalKHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsRequirementsMetalKhr;
        public void* next;
        public void* metalDevice;
        public XrGraphicsRequirementsMetalKHR() { }
        public XrGraphicsRequirementsMetalKHR(XrStructureType type, void* next, void* metalDevice)
        {
            this.type = type;
            this.next = next;
            this.metalDevice = metalDevice;
        }
    }
    /// <summary><b>[requires: XR_KHR_opengl_es_enable]</b> Used by <see cref="Xr.GetOpenGLESGraphicsRequirementsKHR"/></summary>
    public unsafe struct XrGraphicsRequirementsOpenGLESKHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsRequirementsOpenglEsKhr;
        public void* next;
        public ulong minApiVersionSupported;
        public ulong maxApiVersionSupported;
        public XrGraphicsRequirementsOpenGLESKHR() { }
        public XrGraphicsRequirementsOpenGLESKHR(XrStructureType type, void* next, ulong minApiVersionSupported, ulong maxApiVersionSupported)
        {
            this.type = type;
            this.next = next;
            this.minApiVersionSupported = minApiVersionSupported;
            this.maxApiVersionSupported = maxApiVersionSupported;
        }
    }
    /// <summary><b>[requires: XR_KHR_opengl_enable]</b> Used by <see cref="Xr.GetOpenGLGraphicsRequirementsKHR"/></summary>
    public unsafe struct XrGraphicsRequirementsOpenGLKHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsRequirementsOpenglKhr;
        public void* next;
        public ulong minApiVersionSupported;
        public ulong maxApiVersionSupported;
        public XrGraphicsRequirementsOpenGLKHR() { }
        public XrGraphicsRequirementsOpenGLKHR(XrStructureType type, void* next, ulong minApiVersionSupported, ulong maxApiVersionSupported)
        {
            this.type = type;
            this.next = next;
            this.minApiVersionSupported = minApiVersionSupported;
            this.maxApiVersionSupported = maxApiVersionSupported;
        }
    }
    /// <summary><b>[requires: XR_KHR_vulkan_enable2]</b> </summary>
    public unsafe struct XrGraphicsRequirementsVulkan2KHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsRequirementsVulkanKhr;
        public void* next;
        public ulong minApiVersionSupported;
        public ulong maxApiVersionSupported;
        public XrGraphicsRequirementsVulkan2KHR() { }
        public XrGraphicsRequirementsVulkan2KHR(XrStructureType type, void* next, ulong minApiVersionSupported, ulong maxApiVersionSupported)
        {
            this.type = type;
            this.next = next;
            this.minApiVersionSupported = minApiVersionSupported;
            this.maxApiVersionSupported = maxApiVersionSupported;
        }
    }
    /// <summary><b>[requires: XR_KHR_vulkan_enable]</b> Used by <see cref="Xr.GetVulkanGraphicsRequirements2KHR"/>, <see cref="Xr.GetVulkanGraphicsRequirementsKHR"/></summary>
    public unsafe struct XrGraphicsRequirementsVulkanKHR
    {
        public XrStructureType type = XrStructureType.TypeGraphicsRequirementsVulkanKhr;
        public void* next;
        public ulong minApiVersionSupported;
        public ulong maxApiVersionSupported;
        public XrGraphicsRequirementsVulkanKHR() { }
        public XrGraphicsRequirementsVulkanKHR(XrStructureType type, void* next, ulong minApiVersionSupported, ulong maxApiVersionSupported)
        {
            this.type = type;
            this.next = next;
            this.minApiVersionSupported = minApiVersionSupported;
            this.maxApiVersionSupported = maxApiVersionSupported;
        }
    }
    /// <summary><b>[requires: XR_FB_hand_tracking_capsules]</b> </summary>
    public unsafe struct XrHandCapsuleFB
    {
        [InlineArray(2)]
        public struct pointsInlineArray1
        {
            public XrVector3f element;
        }
        public pointsInlineArray1 points;
        public float radius;
        public XrHandJointEXT joint;
        public XrHandCapsuleFB() { }
    }
    /// <summary><b>[requires: XR_EXT_hand_tracking]</b> </summary>
    public unsafe struct XrHandJointLocationEXT
    {
        public XrSpaceLocationFlagBits locationFlags;
        public XrPosef pose;
        public float radius;
        public XrHandJointLocationEXT() { }
        public XrHandJointLocationEXT(XrSpaceLocationFlagBits locationFlags, XrPosef pose, float radius)
        {
            this.locationFlags = locationFlags;
            this.pose = pose;
            this.radius = radius;
        }
    }
    /// <summary><b>[requires: XR_EXT_hand_tracking]</b> Used by <see cref="Xr.LocateHandJointsEXT"/></summary>
    public unsafe struct XrHandJointLocationsEXT
    {
        public XrStructureType type = XrStructureType.TypeHandJointLocationsExt;
        public void* next;
        public int isActive;
        public uint jointCount;
        public XrHandJointLocationEXT* jointLocations;
        public XrHandJointLocationsEXT() { }
        public XrHandJointLocationsEXT(XrStructureType type, void* next, int isActive, uint jointCount, XrHandJointLocationEXT* jointLocations)
        {
            this.type = type;
            this.next = next;
            this.isActive = isActive;
            this.jointCount = jointCount;
            this.jointLocations = jointLocations;
        }
    }
    /// <summary><b>[requires: XR_EXT_hand_tracking]</b> Used by <see cref="Xr.LocateHandJointsEXT"/></summary>
    public unsafe struct XrHandJointsLocateInfoEXT
    {
        public XrStructureType type = XrStructureType.TypeHandJointsLocateInfoExt;
        public void* next;
        public XrSpace baseSpace;
        public long time;
        public XrHandJointsLocateInfoEXT() { }
        public XrHandJointsLocateInfoEXT(XrStructureType type, void* next, XrSpace baseSpace, long time)
        {
            this.type = type;
            this.next = next;
            this.baseSpace = baseSpace;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_EXT_hand_joints_motion_range]</b> </summary>
    public unsafe struct XrHandJointsMotionRangeInfoEXT
    {
        public XrStructureType type = XrStructureType.TypeHandJointsMotionRangeInfoExt;
        public void* next;
        public XrHandJointsMotionRangeEXT handJointsMotionRange;
        public XrHandJointsMotionRangeInfoEXT() { }
        public XrHandJointsMotionRangeInfoEXT(XrStructureType type, void* next, XrHandJointsMotionRangeEXT handJointsMotionRange)
        {
            this.type = type;
            this.next = next;
            this.handJointsMotionRange = handJointsMotionRange;
        }
    }
    /// <summary><b>[requires: XR_EXT_hand_tracking]</b> </summary>
    public unsafe struct XrHandJointVelocitiesEXT
    {
        public XrStructureType type = XrStructureType.TypeHandJointVelocitiesExt;
        public void* next;
        public uint jointCount;
        public XrHandJointVelocityEXT* jointVelocities;
        public XrHandJointVelocitiesEXT() { }
        public XrHandJointVelocitiesEXT(XrStructureType type, void* next, uint jointCount, XrHandJointVelocityEXT* jointVelocities)
        {
            this.type = type;
            this.next = next;
            this.jointCount = jointCount;
            this.jointVelocities = jointVelocities;
        }
    }
    /// <summary><b>[requires: XR_EXT_hand_tracking]</b> </summary>
    public unsafe struct XrHandJointVelocityEXT
    {
        public XrSpaceVelocityFlagBits velocityFlags;
        public XrVector3f linearVelocity;
        public XrVector3f angularVelocity;
        public XrHandJointVelocityEXT() { }
        public XrHandJointVelocityEXT(XrSpaceVelocityFlagBits velocityFlags, XrVector3f linearVelocity, XrVector3f angularVelocity)
        {
            this.velocityFlags = velocityFlags;
            this.linearVelocity = linearVelocity;
            this.angularVelocity = angularVelocity;
        }
    }
    /// <summary><b>[requires: XR_MSFT_hand_tracking_mesh]</b> </summary>
    public unsafe struct XrHandMeshIndexBufferMSFT
    {
        public uint indexBufferKey;
        public uint indexCapacityInput;
        public uint indexCountOutput;
        public uint* indices;
        public XrHandMeshIndexBufferMSFT() { }
        public XrHandMeshIndexBufferMSFT(uint indexBufferKey, uint indexCapacityInput, uint indexCountOutput, uint* indices)
        {
            this.indexBufferKey = indexBufferKey;
            this.indexCapacityInput = indexCapacityInput;
            this.indexCountOutput = indexCountOutput;
            this.indices = indices;
        }
    }
    /// <summary><b>[requires: XR_MSFT_hand_tracking_mesh]</b> Used by <see cref="Xr.UpdateHandMeshMSFT"/></summary>
    public unsafe struct XrHandMeshMSFT
    {
        public XrStructureType type = XrStructureType.TypeHandMeshMsft;
        public void* next;
        public int isActive;
        public int indexBufferChanged;
        public int vertexBufferChanged;
        public XrHandMeshIndexBufferMSFT indexBuffer;
        public XrHandMeshVertexBufferMSFT vertexBuffer;
        public XrHandMeshMSFT() { }
        public XrHandMeshMSFT(XrStructureType type, void* next, int isActive, int indexBufferChanged, int vertexBufferChanged, XrHandMeshIndexBufferMSFT indexBuffer, XrHandMeshVertexBufferMSFT vertexBuffer)
        {
            this.type = type;
            this.next = next;
            this.isActive = isActive;
            this.indexBufferChanged = indexBufferChanged;
            this.vertexBufferChanged = vertexBufferChanged;
            this.indexBuffer = indexBuffer;
            this.vertexBuffer = vertexBuffer;
        }
    }
    /// <summary><b>[requires: XR_MSFT_hand_tracking_mesh]</b> Used by <see cref="Xr.CreateHandMeshSpaceMSFT"/></summary>
    public unsafe struct XrHandMeshSpaceCreateInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeHandMeshSpaceCreateInfoMsft;
        public void* next;
        public XrHandPoseTypeMSFT handPoseType;
        public XrPosef poseInHandMeshSpace;
        public XrHandMeshSpaceCreateInfoMSFT() { }
        public XrHandMeshSpaceCreateInfoMSFT(XrStructureType type, void* next, XrHandPoseTypeMSFT handPoseType, XrPosef poseInHandMeshSpace)
        {
            this.type = type;
            this.next = next;
            this.handPoseType = handPoseType;
            this.poseInHandMeshSpace = poseInHandMeshSpace;
        }
    }
    /// <summary><b>[requires: XR_MSFT_hand_tracking_mesh]</b> Used by <see cref="Xr.UpdateHandMeshMSFT"/></summary>
    public unsafe struct XrHandMeshUpdateInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeHandMeshUpdateInfoMsft;
        public void* next;
        public long time;
        public XrHandPoseTypeMSFT handPoseType;
        public XrHandMeshUpdateInfoMSFT() { }
        public XrHandMeshUpdateInfoMSFT(XrStructureType type, void* next, long time, XrHandPoseTypeMSFT handPoseType)
        {
            this.type = type;
            this.next = next;
            this.time = time;
            this.handPoseType = handPoseType;
        }
    }
    /// <summary><b>[requires: XR_MSFT_hand_tracking_mesh]</b> </summary>
    public unsafe struct XrHandMeshVertexBufferMSFT
    {
        public long vertexUpdateTime;
        public uint vertexCapacityInput;
        public uint vertexCountOutput;
        public XrHandMeshVertexMSFT* vertices;
        public XrHandMeshVertexBufferMSFT() { }
        public XrHandMeshVertexBufferMSFT(long vertexUpdateTime, uint vertexCapacityInput, uint vertexCountOutput, XrHandMeshVertexMSFT* vertices)
        {
            this.vertexUpdateTime = vertexUpdateTime;
            this.vertexCapacityInput = vertexCapacityInput;
            this.vertexCountOutput = vertexCountOutput;
            this.vertices = vertices;
        }
    }
    /// <summary><b>[requires: XR_MSFT_hand_tracking_mesh]</b> </summary>
    public unsafe struct XrHandMeshVertexMSFT
    {
        public XrVector3f position;
        public XrVector3f normal;
        public XrHandMeshVertexMSFT() { }
        public XrHandMeshVertexMSFT(XrVector3f position, XrVector3f normal)
        {
            this.position = position;
            this.normal = normal;
        }
    }
    /// <summary><b>[requires: XR_MSFT_hand_tracking_mesh]</b> </summary>
    public unsafe struct XrHandPoseTypeInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeHandPoseTypeInfoMsft;
        public void* next;
        public XrHandPoseTypeMSFT handPoseType;
        public XrHandPoseTypeInfoMSFT() { }
        public XrHandPoseTypeInfoMSFT(XrStructureType type, void* next, XrHandPoseTypeMSFT handPoseType)
        {
            this.type = type;
            this.next = next;
            this.handPoseType = handPoseType;
        }
    }
    /// <summary><b>[requires: XR_EXT_hand_tracking]</b> Used by <see cref="Xr.CreateHandTrackerEXT"/></summary>
    public unsafe struct XrHandTrackerCreateInfoEXT
    {
        public XrStructureType type = XrStructureType.TypeHandTrackerCreateInfoExt;
        public void* next;
        public XrHandEXT hand;
        public XrHandJointSetEXT handJointSet;
        public XrHandTrackerCreateInfoEXT() { }
        public XrHandTrackerCreateInfoEXT(XrStructureType type, void* next, XrHandEXT hand, XrHandJointSetEXT handJointSet)
        {
            this.type = type;
            this.next = next;
            this.hand = hand;
            this.handJointSet = handJointSet;
        }
    }
    /// <summary><b>[requires: XR_FB_hand_tracking_aim]</b> </summary>
    public unsafe struct XrHandTrackingAimStateFB
    {
        public XrStructureType type = XrStructureType.TypeHandTrackingAimStateFb;
        public void* next;
        public XrHandTrackingAimFlagBitsFB status;
        public XrPosef aimPose;
        public float pinchStrengthIndex;
        public float pinchStrengthMiddle;
        public float pinchStrengthRing;
        public float pinchStrengthLittle;
        public XrHandTrackingAimStateFB() { }
        public XrHandTrackingAimStateFB(XrStructureType type, void* next, XrHandTrackingAimFlagBitsFB status, XrPosef aimPose, float pinchStrengthIndex, float pinchStrengthMiddle, float pinchStrengthRing, float pinchStrengthLittle)
        {
            this.type = type;
            this.next = next;
            this.status = status;
            this.aimPose = aimPose;
            this.pinchStrengthIndex = pinchStrengthIndex;
            this.pinchStrengthMiddle = pinchStrengthMiddle;
            this.pinchStrengthRing = pinchStrengthRing;
            this.pinchStrengthLittle = pinchStrengthLittle;
        }
    }
    /// <summary><b>[requires: XR_FB_hand_tracking_capsules]</b> </summary>
    public unsafe struct XrHandTrackingCapsulesStateFB
    {
        public XrStructureType type = XrStructureType.TypeHandTrackingCapsulesStateFb;
        public void* next;
        [InlineArray(19)]
        public struct capsulesInlineArray1
        {
            public XrHandCapsuleFB element;
        }
        public capsulesInlineArray1 capsules;
        public XrHandTrackingCapsulesStateFB() { }
    }
    /// <summary><b>[requires: XR_EXT_hand_tracking_data_source]</b> </summary>
    public unsafe struct XrHandTrackingDataSourceInfoEXT
    {
        public XrStructureType type = XrStructureType.TypeHandTrackingDataSourceInfoExt;
        public void* next;
        public uint requestedDataSourceCount;
        public XrHandTrackingDataSourceEXT* requestedDataSources;
        public XrHandTrackingDataSourceInfoEXT() { }
        public XrHandTrackingDataSourceInfoEXT(XrStructureType type, void* next, uint requestedDataSourceCount, XrHandTrackingDataSourceEXT* requestedDataSources)
        {
            this.type = type;
            this.next = next;
            this.requestedDataSourceCount = requestedDataSourceCount;
            this.requestedDataSources = requestedDataSources;
        }
    }
    /// <summary><b>[requires: XR_EXT_hand_tracking_data_source]</b> </summary>
    public unsafe struct XrHandTrackingDataSourceStateEXT
    {
        public XrStructureType type = XrStructureType.TypeHandTrackingDataSourceStateExt;
        public void* next;
        public int isActive;
        public XrHandTrackingDataSourceEXT dataSource;
        public XrHandTrackingDataSourceStateEXT() { }
        public XrHandTrackingDataSourceStateEXT(XrStructureType type, void* next, int isActive, XrHandTrackingDataSourceEXT dataSource)
        {
            this.type = type;
            this.next = next;
            this.isActive = isActive;
            this.dataSource = dataSource;
        }
    }
    /// <summary><b>[requires: XR_FB_hand_tracking_mesh]</b> Used by <see cref="Xr.GetHandMeshFB"/></summary>
    public unsafe struct XrHandTrackingMeshFB
    {
        public XrStructureType type = XrStructureType.TypeHandTrackingMeshFb;
        public void* next;
        public uint jointCapacityInput;
        public uint jointCountOutput;
        public XrPosef* jointBindPoses;
        public float* jointRadii;
        public XrHandJointEXT* jointParents;
        public uint vertexCapacityInput;
        public uint vertexCountOutput;
        public XrVector3f* vertexPositions;
        public XrVector3f* vertexNormals;
        public XrVector2f* vertexUVs;
        public XrVector4sFB* vertexBlendIndices;
        public XrVector4f* vertexBlendWeights;
        public uint indexCapacityInput;
        public uint indexCountOutput;
        public short* indices;
        public XrHandTrackingMeshFB() { }
        public XrHandTrackingMeshFB(XrStructureType type, void* next, uint jointCapacityInput, uint jointCountOutput, XrPosef* jointBindPoses, float* jointRadii, XrHandJointEXT* jointParents, uint vertexCapacityInput, uint vertexCountOutput, XrVector3f* vertexPositions, XrVector3f* vertexNormals, XrVector2f* vertexUVs, XrVector4sFB* vertexBlendIndices, XrVector4f* vertexBlendWeights, uint indexCapacityInput, uint indexCountOutput, short* indices)
        {
            this.type = type;
            this.next = next;
            this.jointCapacityInput = jointCapacityInput;
            this.jointCountOutput = jointCountOutput;
            this.jointBindPoses = jointBindPoses;
            this.jointRadii = jointRadii;
            this.jointParents = jointParents;
            this.vertexCapacityInput = vertexCapacityInput;
            this.vertexCountOutput = vertexCountOutput;
            this.vertexPositions = vertexPositions;
            this.vertexNormals = vertexNormals;
            this.vertexUVs = vertexUVs;
            this.vertexBlendIndices = vertexBlendIndices;
            this.vertexBlendWeights = vertexBlendWeights;
            this.indexCapacityInput = indexCapacityInput;
            this.indexCountOutput = indexCountOutput;
            this.indices = indices;
        }
    }
    /// <summary><b>[requires: XR_FB_hand_tracking_mesh]</b> </summary>
    public unsafe struct XrHandTrackingScaleFB
    {
        public XrStructureType type = XrStructureType.TypeHandTrackingScaleFb;
        public void* next;
        public float sensorOutput;
        public float currentOutput;
        public int overrideHandScale;
        public float overrideValueInput;
        public XrHandTrackingScaleFB() { }
        public XrHandTrackingScaleFB(XrStructureType type, void* next, float sensorOutput, float currentOutput, int overrideHandScale, float overrideValueInput)
        {
            this.type = type;
            this.next = next;
            this.sensorOutput = sensorOutput;
            this.currentOutput = currentOutput;
            this.overrideHandScale = overrideHandScale;
            this.overrideValueInput = overrideValueInput;
        }
    }
    /// <summary>Used by <see cref="Xr.ApplyHapticFeedback"/>, <see cref="Xr.GetDeviceSampleRateFB"/>, <see cref="Xr.StopHapticFeedback"/></summary>
    public unsafe struct XrHapticActionInfo
    {
        public XrStructureType type = XrStructureType.TypeHapticActionInfo;
        public void* next;
        public XrAction action;
        public ulong subactionPath;
        public XrHapticActionInfo() { }
        public XrHapticActionInfo(XrStructureType type, void* next, XrAction action, ulong subactionPath)
        {
            this.type = type;
            this.next = next;
            this.action = action;
            this.subactionPath = subactionPath;
        }
    }
    /// <summary><b>[requires: XR_FB_haptic_amplitude_envelope]</b> </summary>
    public unsafe struct XrHapticAmplitudeEnvelopeVibrationFB
    {
        public XrStructureType type = XrStructureType.TypeHapticAmplitudeEnvelopeVibrationFb;
        public void* next;
        public long duration;
        public uint amplitudeCount;
        public float* amplitudes;
        public XrHapticAmplitudeEnvelopeVibrationFB() { }
        public XrHapticAmplitudeEnvelopeVibrationFB(XrStructureType type, void* next, long duration, uint amplitudeCount, float* amplitudes)
        {
            this.type = type;
            this.next = next;
            this.duration = duration;
            this.amplitudeCount = amplitudeCount;
            this.amplitudes = amplitudes;
        }
    }
    /// <summary>Used by <see cref="Xr.ApplyHapticFeedback"/></summary>
    public unsafe struct XrHapticBaseHeader
    {
        public XrStructureType type;
        public void* next;
        public XrHapticBaseHeader() { }
        public XrHapticBaseHeader(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_FB_haptic_pcm]</b> </summary>
    public unsafe struct XrHapticPcmVibrationFB
    {
        public XrStructureType type = XrStructureType.TypeHapticPcmVibrationFb;
        public void* next;
        public uint bufferSize;
        public float* buffer;
        public float sampleRate;
        public int append;
        public uint* samplesConsumed;
        public XrHapticPcmVibrationFB() { }
        public XrHapticPcmVibrationFB(XrStructureType type, void* next, uint bufferSize, float* buffer, float sampleRate, int append, uint* samplesConsumed)
        {
            this.type = type;
            this.next = next;
            this.bufferSize = bufferSize;
            this.buffer = buffer;
            this.sampleRate = sampleRate;
            this.append = append;
            this.samplesConsumed = samplesConsumed;
        }
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    public unsafe struct XrHapticVibration
    {
        public XrStructureType type = XrStructureType.TypeHapticVibration;
        public void* next;
        public long duration;
        public float frequency;
        public float amplitude;
        public XrHapticVibration() { }
        public XrHapticVibration(XrStructureType type, void* next, long duration, float frequency, float amplitude)
        {
            this.type = type;
            this.next = next;
            this.duration = duration;
            this.frequency = frequency;
            this.amplitude = amplitude;
        }
    }
    /// <summary><b>[requires: XR_MSFT_holographic_window_attachment]</b> </summary>
    public unsafe struct XrHolographicWindowAttachmentMSFT
    {
        public XrStructureType type = XrStructureType.TypeHolographicWindowAttachmentMsft;
        public void* next;
        public IntPtr* holographicSpace;
        public IntPtr* coreWindow;
        public XrHolographicWindowAttachmentMSFT() { }
        public XrHolographicWindowAttachmentMSFT(XrStructureType type, void* next, IntPtr* holographicSpace, IntPtr* coreWindow)
        {
            this.type = type;
            this.next = next;
            this.holographicSpace = holographicSpace;
            this.coreWindow = coreWindow;
        }
    }
    /// <summary>Used by <see cref="Xr.GetInputSourceLocalizedName"/></summary>
    public unsafe struct XrInputSourceLocalizedNameGetInfo
    {
        public XrStructureType type = XrStructureType.TypeInputSourceLocalizedNameGetInfo;
        public void* next;
        public ulong sourcePath;
        public XrInputSourceLocalizedNameFlagBits whichComponents;
        public XrInputSourceLocalizedNameGetInfo() { }
        public XrInputSourceLocalizedNameGetInfo(XrStructureType type, void* next, ulong sourcePath, XrInputSourceLocalizedNameFlagBits whichComponents)
        {
            this.type = type;
            this.next = next;
            this.sourcePath = sourcePath;
            this.whichComponents = whichComponents;
        }
    }
    /// <summary>Used by <see cref="Xr.CreateApiLayerInstance"/>, <see cref="Xr.CreateInstance"/></summary>
    public unsafe struct XrInstanceCreateInfo
    {
        public XrStructureType type = XrStructureType.TypeInstanceCreateInfo;
        public void* next;
        public XrInstanceCreateFlagBits createFlags;
        public XrApplicationInfo applicationInfo;
        public uint enabledApiLayerCount;
        public byte** enabledApiLayerNames;
        public uint enabledExtensionCount;
        public byte** enabledExtensionNames;
        public XrInstanceCreateInfo() { }
        public XrInstanceCreateInfo(XrStructureType type, void* next, XrInstanceCreateFlagBits createFlags, XrApplicationInfo applicationInfo, uint enabledApiLayerCount, byte** enabledApiLayerNames, uint enabledExtensionCount, byte** enabledExtensionNames)
        {
            this.type = type;
            this.next = next;
            this.createFlags = createFlags;
            this.applicationInfo = applicationInfo;
            this.enabledApiLayerCount = enabledApiLayerCount;
            this.enabledApiLayerNames = enabledApiLayerNames;
            this.enabledExtensionCount = enabledExtensionCount;
            this.enabledExtensionNames = enabledExtensionNames;
        }
    }
    /// <summary><b>[requires: XR_KHR_android_create_instance]</b> </summary>
    public unsafe struct XrInstanceCreateInfoAndroidKHR
    {
        public XrStructureType type = XrStructureType.TypeInstanceCreateInfoAndroidKhr;
        public void* next;
        public void* applicationVM;
        public void* applicationActivity;
        public XrInstanceCreateInfoAndroidKHR() { }
        public XrInstanceCreateInfoAndroidKHR(XrStructureType type, void* next, void* applicationVM, void* applicationActivity)
        {
            this.type = type;
            this.next = next;
            this.applicationVM = applicationVM;
            this.applicationActivity = applicationActivity;
        }
    }
    /// <summary>Used by <see cref="Xr.GetInstanceProperties"/></summary>
    public unsafe struct XrInstanceProperties
    {
        public XrStructureType type = XrStructureType.TypeInstanceProperties;
        public void* next;
        public ulong runtimeVersion;
        [InlineArray(128)]
        public struct runtimeNameInlineArray1
        {
            public byte element;
        }
        public runtimeNameInlineArray1 runtimeName;
        public XrInstanceProperties() { }
    }
    /// <summary><b>[requires: XR_VALVE_analog_threshold]</b> </summary>
    public unsafe struct XrInteractionProfileAnalogThresholdVALVE
    {
        public XrStructureType type = XrStructureType.TypeInteractionProfileAnalogThresholdValve;
        public void* next;
        public XrAction action;
        public ulong binding;
        public float onThreshold;
        public float offThreshold;
        public XrHapticBaseHeader* onHaptic;
        public XrHapticBaseHeader* offHaptic;
        public XrInteractionProfileAnalogThresholdVALVE() { }
        public XrInteractionProfileAnalogThresholdVALVE(XrStructureType type, void* next, XrAction action, ulong binding, float onThreshold, float offThreshold, XrHapticBaseHeader* onHaptic, XrHapticBaseHeader* offHaptic)
        {
            this.type = type;
            this.next = next;
            this.action = action;
            this.binding = binding;
            this.onThreshold = onThreshold;
            this.offThreshold = offThreshold;
            this.onHaptic = onHaptic;
            this.offHaptic = offHaptic;
        }
    }
    /// <summary><b>[requires: XR_EXT_dpad_binding]</b> </summary>
    public unsafe struct XrInteractionProfileDpadBindingEXT
    {
        public XrStructureType type = XrStructureType.TypeInteractionProfileDpadBindingExt;
        public void* next;
        public ulong binding;
        public XrActionSet actionSet;
        public float forceThreshold;
        public float forceThresholdReleased;
        public float centerRegion;
        public float wedgeAngle;
        public int isSticky;
        public XrHapticBaseHeader* onHaptic;
        public XrHapticBaseHeader* offHaptic;
        public XrInteractionProfileDpadBindingEXT() { }
        public XrInteractionProfileDpadBindingEXT(XrStructureType type, void* next, ulong binding, XrActionSet actionSet, float forceThreshold, float forceThresholdReleased, float centerRegion, float wedgeAngle, int isSticky, XrHapticBaseHeader* onHaptic, XrHapticBaseHeader* offHaptic)
        {
            this.type = type;
            this.next = next;
            this.binding = binding;
            this.actionSet = actionSet;
            this.forceThreshold = forceThreshold;
            this.forceThresholdReleased = forceThresholdReleased;
            this.centerRegion = centerRegion;
            this.wedgeAngle = wedgeAngle;
            this.isSticky = isSticky;
            this.onHaptic = onHaptic;
            this.offHaptic = offHaptic;
        }
    }
    /// <summary>Used by <see cref="Xr.GetCurrentInteractionProfile"/></summary>
    public unsafe struct XrInteractionProfileState
    {
        public XrStructureType type = XrStructureType.TypeInteractionProfileState;
        public void* next;
        public ulong interactionProfile;
        public XrInteractionProfileState() { }
        public XrInteractionProfileState(XrStructureType type, void* next, ulong interactionProfile)
        {
            this.type = type;
            this.next = next;
            this.interactionProfile = interactionProfile;
        }
    }
    /// <summary>Used by <see cref="Xr.SuggestInteractionProfileBindings"/></summary>
    public unsafe struct XrInteractionProfileSuggestedBinding
    {
        public XrStructureType type = XrStructureType.TypeInteractionProfileSuggestedBinding;
        public void* next;
        public ulong interactionProfile;
        public uint countSuggestedBindings;
        public XrActionSuggestedBinding* suggestedBindings;
        public XrInteractionProfileSuggestedBinding() { }
        public XrInteractionProfileSuggestedBinding(XrStructureType type, void* next, ulong interactionProfile, uint countSuggestedBindings, XrActionSuggestedBinding* suggestedBindings)
        {
            this.type = type;
            this.next = next;
            this.interactionProfile = interactionProfile;
            this.countSuggestedBindings = countSuggestedBindings;
            this.suggestedBindings = suggestedBindings;
        }
    }
    /// <summary><b>[requires: XR_FB_keyboard_tracking]</b> Used by <see cref="Xr.CreateKeyboardSpaceFB"/></summary>
    public unsafe struct XrKeyboardSpaceCreateInfoFB
    {
        public XrStructureType type = XrStructureType.TypeKeyboardSpaceCreateInfoFb;
        public void* next;
        public ulong trackedKeyboardId;
        public XrKeyboardSpaceCreateInfoFB() { }
        public XrKeyboardSpaceCreateInfoFB(XrStructureType type, void* next, ulong trackedKeyboardId)
        {
            this.type = type;
            this.next = next;
            this.trackedKeyboardId = trackedKeyboardId;
        }
    }
    /// <summary><b>[requires: XR_FB_keyboard_tracking]</b> Used by <see cref="Xr.QuerySystemTrackedKeyboardFB"/></summary>
    public unsafe struct XrKeyboardTrackingDescriptionFB
    {
        public ulong trackedKeyboardId;
        public XrVector3f size;
        public XrKeyboardTrackingFlagBitsFB flags;
        [InlineArray(128)]
        public struct nameInlineArray1
        {
            public byte element;
        }
        public nameInlineArray1 name;
        public XrKeyboardTrackingDescriptionFB() { }
    }
    /// <summary><b>[requires: XR_FB_keyboard_tracking]</b> Used by <see cref="Xr.QuerySystemTrackedKeyboardFB"/></summary>
    public unsafe struct XrKeyboardTrackingQueryFB
    {
        public XrStructureType type = XrStructureType.TypeKeyboardTrackingQueryFb;
        public void* next;
        public XrKeyboardTrackingQueryFlagBitsFB flags;
        public XrKeyboardTrackingQueryFB() { }
        public XrKeyboardTrackingQueryFB(XrStructureType type, void* next, XrKeyboardTrackingQueryFlagBitsFB flags)
        {
            this.type = type;
            this.next = next;
            this.flags = flags;
        }
    }
    /// <summary><b>[requires: XR_KHR_loader_init_android]</b> </summary>
    public unsafe struct XrLoaderInitInfoAndroidKHR
    {
        public XrStructureType type = XrStructureType.TypeLoaderInitInfoAndroidKhr;
        public void* next;
        public void* applicationVM;
        public void* applicationContext;
        public XrLoaderInitInfoAndroidKHR() { }
        public XrLoaderInitInfoAndroidKHR(XrStructureType type, void* next, void* applicationVM, void* applicationContext)
        {
            this.type = type;
            this.next = next;
            this.applicationVM = applicationVM;
            this.applicationContext = applicationContext;
        }
    }
    /// <summary><b>[requires: XR_KHR_loader_init]</b> Used by <see cref="Xr.InitializeLoaderKHR"/></summary>
    public unsafe struct XrLoaderInitInfoBaseHeaderKHR
    {
        public XrStructureType type;
        public void* next;
        public XrLoaderInitInfoBaseHeaderKHR() { }
        public XrLoaderInitInfoBaseHeaderKHR(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_META_local_dimming]</b> </summary>
    public unsafe struct XrLocalDimmingFrameEndInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeLocalDimmingFrameEndInfoMeta;
        public void* next;
        public XrLocalDimmingModeMETA localDimmingMode;
        public XrLocalDimmingFrameEndInfoMETA() { }
        public XrLocalDimmingFrameEndInfoMETA(XrStructureType type, void* next, XrLocalDimmingModeMETA localDimmingMode)
        {
            this.type = type;
            this.next = next;
            this.localDimmingMode = localDimmingMode;
        }
    }
    /// <summary><b>[requires: XR_ML_localization_map]</b> Used by <see cref="Xr.EnableLocalizationEventsML"/></summary>
    public unsafe struct XrLocalizationEnableEventsInfoML
    {
        public XrStructureType type = XrStructureType.TypeLocalizationEnableEventsInfoMl;
        public void* next;
        public int enabled;
        public XrLocalizationEnableEventsInfoML() { }
        public XrLocalizationEnableEventsInfoML(XrStructureType type, void* next, int enabled)
        {
            this.type = type;
            this.next = next;
            this.enabled = enabled;
        }
    }
    /// <summary><b>[requires: XR_ML_localization_map]</b> Used by <see cref="Xr.ImportLocalizationMapML"/></summary>
    public unsafe struct XrLocalizationMapImportInfoML
    {
        public XrStructureType type = XrStructureType.TypeLocalizationMapImportInfoMl;
        public void* next;
        public uint size;
        public byte* data;
        public XrLocalizationMapImportInfoML() { }
        public XrLocalizationMapImportInfoML(XrStructureType type, void* next, uint size, byte* data)
        {
            this.type = type;
            this.next = next;
            this.size = size;
            this.data = data;
        }
    }
    /// <summary><b>[requires: XR_ML_localization_map]</b> Used by <see cref="Xr.QueryLocalizationMapsML"/></summary>
    public unsafe struct XrLocalizationMapML
    {
        public XrStructureType type = XrStructureType.TypeLocalizationMapMl;
        public void* next;
        [InlineArray(64)]
        public struct nameInlineArray1
        {
            public byte element;
        }
        public nameInlineArray1 name;
        public XrUuid mapUuid;
        public XrLocalizationMapTypeML mapType;
        public XrLocalizationMapML() { }
    }
    /// <summary><b>[requires: XR_ML_localization_map]</b> Used by <see cref="Xr.QueryLocalizationMapsML"/></summary>
    public unsafe struct XrLocalizationMapQueryInfoBaseHeaderML
    {
        public XrStructureType type;
        public void* next;
        public XrLocalizationMapQueryInfoBaseHeaderML() { }
        public XrLocalizationMapQueryInfoBaseHeaderML(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_ML_localization_map]</b> Used by <see cref="Xr.RequestMapLocalizationML"/></summary>
    public unsafe struct XrMapLocalizationRequestInfoML
    {
        public XrStructureType type = XrStructureType.TypeMapLocalizationRequestInfoMl;
        public void* next;
        public XrUuid mapUuid;
        public XrMapLocalizationRequestInfoML() { }
        public XrMapLocalizationRequestInfoML(XrStructureType type, void* next, XrUuid mapUuid)
        {
            this.type = type;
            this.next = next;
            this.mapUuid = mapUuid;
        }
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
    public unsafe struct XrMarkerDetectorAprilTagInfoML
    {
        public XrStructureType type = XrStructureType.TypeMarkerDetectorAprilTagInfoMl;
        public void* next;
        public XrMarkerAprilTagDictML aprilTagDict;
        public XrMarkerDetectorAprilTagInfoML() { }
        public XrMarkerDetectorAprilTagInfoML(XrStructureType type, void* next, XrMarkerAprilTagDictML aprilTagDict)
        {
            this.type = type;
            this.next = next;
            this.aprilTagDict = aprilTagDict;
        }
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
    public unsafe struct XrMarkerDetectorArucoInfoML
    {
        public XrStructureType type = XrStructureType.TypeMarkerDetectorArucoInfoMl;
        public void* next;
        public XrMarkerArucoDictML arucoDict;
        public XrMarkerDetectorArucoInfoML() { }
        public XrMarkerDetectorArucoInfoML(XrStructureType type, void* next, XrMarkerArucoDictML arucoDict)
        {
            this.type = type;
            this.next = next;
            this.arucoDict = arucoDict;
        }
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> Used by <see cref="Xr.CreateMarkerDetectorML"/></summary>
    public unsafe struct XrMarkerDetectorCreateInfoML
    {
        public XrStructureType type = XrStructureType.TypeMarkerDetectorCreateInfoMl;
        public void* next;
        public XrMarkerDetectorProfileML profile;
        public XrMarkerTypeML markerType;
        public XrMarkerDetectorCreateInfoML() { }
        public XrMarkerDetectorCreateInfoML(XrStructureType type, void* next, XrMarkerDetectorProfileML profile, XrMarkerTypeML markerType)
        {
            this.type = type;
            this.next = next;
            this.profile = profile;
            this.markerType = markerType;
        }
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
    public unsafe struct XrMarkerDetectorCustomProfileInfoML
    {
        public XrStructureType type = XrStructureType.TypeMarkerDetectorCustomProfileInfoMl;
        public void* next;
        public XrMarkerDetectorFpsML fpsHint;
        public XrMarkerDetectorResolutionML resolutionHint;
        public XrMarkerDetectorCameraML cameraHint;
        public XrMarkerDetectorCornerRefineMethodML cornerRefineMethod;
        public int useEdgeRefinement;
        public XrMarkerDetectorFullAnalysisIntervalML fullAnalysisIntervalHint;
        public XrMarkerDetectorCustomProfileInfoML() { }
        public XrMarkerDetectorCustomProfileInfoML(XrStructureType type, void* next, XrMarkerDetectorFpsML fpsHint, XrMarkerDetectorResolutionML resolutionHint, XrMarkerDetectorCameraML cameraHint, XrMarkerDetectorCornerRefineMethodML cornerRefineMethod, int useEdgeRefinement, XrMarkerDetectorFullAnalysisIntervalML fullAnalysisIntervalHint)
        {
            this.type = type;
            this.next = next;
            this.fpsHint = fpsHint;
            this.resolutionHint = resolutionHint;
            this.cameraHint = cameraHint;
            this.cornerRefineMethod = cornerRefineMethod;
            this.useEdgeRefinement = useEdgeRefinement;
            this.fullAnalysisIntervalHint = fullAnalysisIntervalHint;
        }
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
    public unsafe struct XrMarkerDetectorSizeInfoML
    {
        public XrStructureType type = XrStructureType.TypeMarkerDetectorSizeInfoMl;
        public void* next;
        public float markerLength;
        public XrMarkerDetectorSizeInfoML() { }
        public XrMarkerDetectorSizeInfoML(XrStructureType type, void* next, float markerLength)
        {
            this.type = type;
            this.next = next;
            this.markerLength = markerLength;
        }
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> Used by <see cref="Xr.SnapshotMarkerDetectorML"/></summary>
    public unsafe struct XrMarkerDetectorSnapshotInfoML
    {
        public XrStructureType type = XrStructureType.TypeMarkerDetectorSnapshotInfoMl;
        public void* next;
        public XrMarkerDetectorSnapshotInfoML() { }
        public XrMarkerDetectorSnapshotInfoML(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> Used by <see cref="Xr.GetMarkerDetectorStateML"/></summary>
    public unsafe struct XrMarkerDetectorStateML
    {
        public XrStructureType type = XrStructureType.TypeMarkerDetectorStateMl;
        public void* next;
        public XrMarkerDetectorStatusML state;
        public XrMarkerDetectorStateML() { }
        public XrMarkerDetectorStateML(XrStructureType type, void* next, XrMarkerDetectorStatusML state)
        {
            this.type = type;
            this.next = next;
            this.state = state;
        }
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> Used by <see cref="Xr.CreateMarkerSpaceML"/></summary>
    public unsafe struct XrMarkerSpaceCreateInfoML
    {
        public XrStructureType type = XrStructureType.TypeMarkerSpaceCreateInfoMl;
        public void* next;
        public XrMarkerDetectorML markerDetector;
        public ulong marker;
        public XrPosef poseInMarkerSpace;
        public XrMarkerSpaceCreateInfoML() { }
        public XrMarkerSpaceCreateInfoML(XrStructureType type, void* next, XrMarkerDetectorML markerDetector, ulong marker, XrPosef poseInMarkerSpace)
        {
            this.type = type;
            this.next = next;
            this.markerDetector = markerDetector;
            this.marker = marker;
            this.poseInMarkerSpace = poseInMarkerSpace;
        }
    }
    /// <summary><b>[requires: XR_VARJO_marker_tracking]</b> Used by <see cref="Xr.CreateMarkerSpaceVARJO"/></summary>
    public unsafe struct XrMarkerSpaceCreateInfoVARJO
    {
        public XrStructureType type = XrStructureType.TypeMarkerSpaceCreateInfoVarjo;
        public void* next;
        public ulong markerId;
        public XrPosef poseInMarkerSpace;
        public XrMarkerSpaceCreateInfoVARJO() { }
        public XrMarkerSpaceCreateInfoVARJO(XrStructureType type, void* next, ulong markerId, XrPosef poseInMarkerSpace)
        {
            this.type = type;
            this.next = next;
            this.markerId = markerId;
            this.poseInMarkerSpace = poseInMarkerSpace;
        }
    }
    /// <summary>Used by <see cref="Xr.NegotiateLoaderApiLayerInterface"/></summary>
    public unsafe struct XrNegotiateApiLayerRequest
    {
        public XrLoaderInterfaceStructs structType;
        public uint structVersion;
        public nuint structSize;
        public uint layerInterfaceVersion;
        public ulong layerApiVersion;
        public delegate* unmanaged[Cdecl]<XrInstance, byte*, void*, XrResult> getInstanceProcAddr;
        public delegate* unmanaged[Cdecl]<XrInstanceCreateInfo*, XrApiLayerCreateInfo*, byte*, XrInstance*, XrResult> createApiLayerInstance;
        public XrNegotiateApiLayerRequest() { }
        public XrNegotiateApiLayerRequest(XrLoaderInterfaceStructs structType, uint structVersion, nuint structSize, uint layerInterfaceVersion, ulong layerApiVersion, delegate* unmanaged[Cdecl]<XrInstance, byte*, void*, XrResult> getInstanceProcAddr, delegate* unmanaged[Cdecl]<XrInstanceCreateInfo*, XrApiLayerCreateInfo*, byte*, XrInstance*, XrResult> createApiLayerInstance)
        {
            this.structType = structType;
            this.structVersion = structVersion;
            this.structSize = structSize;
            this.layerInterfaceVersion = layerInterfaceVersion;
            this.layerApiVersion = layerApiVersion;
            this.getInstanceProcAddr = getInstanceProcAddr;
            this.createApiLayerInstance = createApiLayerInstance;
        }
    }
    /// <summary>Used by <see cref="Xr.NegotiateLoaderApiLayerInterface"/>, <see cref="Xr.NegotiateLoaderRuntimeInterface"/></summary>
    public unsafe struct XrNegotiateLoaderInfo
    {
        public XrLoaderInterfaceStructs structType;
        public uint structVersion;
        public nuint structSize;
        public uint minInterfaceVersion;
        public uint maxInterfaceVersion;
        public ulong minApiVersion;
        public ulong maxApiVersion;
        public XrNegotiateLoaderInfo() { }
        public XrNegotiateLoaderInfo(XrLoaderInterfaceStructs structType, uint structVersion, nuint structSize, uint minInterfaceVersion, uint maxInterfaceVersion, ulong minApiVersion, ulong maxApiVersion)
        {
            this.structType = structType;
            this.structVersion = structVersion;
            this.structSize = structSize;
            this.minInterfaceVersion = minInterfaceVersion;
            this.maxInterfaceVersion = maxInterfaceVersion;
            this.minApiVersion = minApiVersion;
            this.maxApiVersion = maxApiVersion;
        }
    }
    /// <summary>Used by <see cref="Xr.NegotiateLoaderRuntimeInterface"/></summary>
    public unsafe struct XrNegotiateRuntimeRequest
    {
        public XrLoaderInterfaceStructs structType;
        public uint structVersion;
        public nuint structSize;
        public uint runtimeInterfaceVersion;
        public ulong runtimeApiVersion;
        public delegate* unmanaged[Cdecl]<XrInstance, byte*, void*, XrResult> getInstanceProcAddr;
        public XrNegotiateRuntimeRequest() { }
        public XrNegotiateRuntimeRequest(XrLoaderInterfaceStructs structType, uint structVersion, nuint structSize, uint runtimeInterfaceVersion, ulong runtimeApiVersion, delegate* unmanaged[Cdecl]<XrInstance, byte*, void*, XrResult> getInstanceProcAddr)
        {
            this.structType = structType;
            this.structVersion = structVersion;
            this.structSize = structSize;
            this.runtimeInterfaceVersion = runtimeInterfaceVersion;
            this.runtimeApiVersion = runtimeApiVersion;
            this.getInstanceProcAddr = getInstanceProcAddr;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> Used by <see cref="Xr.ComputeNewSceneMSFT"/></summary>
    public unsafe struct XrNewSceneComputeInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeNewSceneComputeInfoMsft;
        public void* next;
        public uint requestedFeatureCount;
        public XrSceneComputeFeatureMSFT* requestedFeatures;
        public XrSceneComputeConsistencyMSFT consistency;
        public XrSceneBoundsMSFT bounds;
        public XrNewSceneComputeInfoMSFT() { }
        public XrNewSceneComputeInfoMSFT(XrStructureType type, void* next, uint requestedFeatureCount, XrSceneComputeFeatureMSFT* requestedFeatures, XrSceneComputeConsistencyMSFT consistency, XrSceneBoundsMSFT bounds)
        {
            this.type = type;
            this.next = next;
            this.requestedFeatureCount = requestedFeatureCount;
            this.requestedFeatures = requestedFeatures;
            this.consistency = consistency;
            this.bounds = bounds;
        }
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    public unsafe struct XrOffset2Df
    {
        public float x;
        public float y;
        public XrOffset2Df() { }
        public XrOffset2Df(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
    /// <summary></summary>
    public unsafe struct XrOffset2Di
    {
        public int x;
        public int y;
        public XrOffset2Di() { }
        public XrOffset2Di(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    /// <summary><b>[requires: XR_FB_scene]</b> </summary>
    public unsafe struct XrOffset3DfFB
    {
        public float x;
        public float y;
        public float z;
        public XrOffset3DfFB() { }
        public XrOffset3DfFB(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
    /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
    public unsafe struct XrPassthroughBrightnessContrastSaturationFB
    {
        public XrStructureType type = XrStructureType.TypePassthroughBrightnessContrastSaturationFb;
        public void* next;
        public float brightness;
        public float contrast;
        public float saturation;
        public XrPassthroughBrightnessContrastSaturationFB() { }
        public XrPassthroughBrightnessContrastSaturationFB(XrStructureType type, void* next, float brightness, float contrast, float saturation)
        {
            this.type = type;
            this.next = next;
            this.brightness = brightness;
            this.contrast = contrast;
            this.saturation = saturation;
        }
    }
    /// <summary><b>[requires: XR_HTC_passthrough]</b> </summary>
    public unsafe struct XrPassthroughColorHTC
    {
        public XrStructureType type = XrStructureType.TypePassthroughColorHtc;
        public void* next;
        public float alpha;
        public XrPassthroughColorHTC() { }
        public XrPassthroughColorHTC(XrStructureType type, void* next, float alpha)
        {
            this.type = type;
            this.next = next;
            this.alpha = alpha;
        }
    }
    /// <summary><b>[requires: XR_META_passthrough_color_lut]</b> Used by <see cref="Xr.CreatePassthroughColorLutMETA"/></summary>
    public unsafe struct XrPassthroughColorLutCreateInfoMETA
    {
        public XrStructureType type = XrStructureType.TypePassthroughColorLutCreateInfoMeta;
        public void* next;
        public XrPassthroughColorLutChannelsMETA channels;
        public uint resolution;
        public XrPassthroughColorLutDataMETA data;
        public XrPassthroughColorLutCreateInfoMETA() { }
        public XrPassthroughColorLutCreateInfoMETA(XrStructureType type, void* next, XrPassthroughColorLutChannelsMETA channels, uint resolution, XrPassthroughColorLutDataMETA data)
        {
            this.type = type;
            this.next = next;
            this.channels = channels;
            this.resolution = resolution;
            this.data = data;
        }
    }
    /// <summary><b>[requires: XR_META_passthrough_color_lut]</b> </summary>
    public unsafe struct XrPassthroughColorLutDataMETA
    {
        public uint bufferSize;
        public byte* buffer;
        public XrPassthroughColorLutDataMETA() { }
        public XrPassthroughColorLutDataMETA(uint bufferSize, byte* buffer)
        {
            this.bufferSize = bufferSize;
            this.buffer = buffer;
        }
    }
    /// <summary><b>[requires: XR_META_passthrough_color_lut]</b> Used by <see cref="Xr.UpdatePassthroughColorLutMETA"/></summary>
    public unsafe struct XrPassthroughColorLutUpdateInfoMETA
    {
        public XrStructureType type = XrStructureType.TypePassthroughColorLutUpdateInfoMeta;
        public void* next;
        public XrPassthroughColorLutDataMETA data;
        public XrPassthroughColorLutUpdateInfoMETA() { }
        public XrPassthroughColorLutUpdateInfoMETA(XrStructureType type, void* next, XrPassthroughColorLutDataMETA data)
        {
            this.type = type;
            this.next = next;
            this.data = data;
        }
    }
    /// <summary><b>[requires: XR_META_passthrough_color_lut]</b> </summary>
    public unsafe struct XrPassthroughColorMapInterpolatedLutMETA
    {
        public XrStructureType type = XrStructureType.TypePassthroughColorMapInterpolatedLutMeta;
        public void* next;
        public XrPassthroughColorLutMETA sourceColorLut;
        public XrPassthroughColorLutMETA targetColorLut;
        public float weight;
        public XrPassthroughColorMapInterpolatedLutMETA() { }
        public XrPassthroughColorMapInterpolatedLutMETA(XrStructureType type, void* next, XrPassthroughColorLutMETA sourceColorLut, XrPassthroughColorLutMETA targetColorLut, float weight)
        {
            this.type = type;
            this.next = next;
            this.sourceColorLut = sourceColorLut;
            this.targetColorLut = targetColorLut;
            this.weight = weight;
        }
    }
    /// <summary><b>[requires: XR_META_passthrough_color_lut]</b> </summary>
    public unsafe struct XrPassthroughColorMapLutMETA
    {
        public XrStructureType type = XrStructureType.TypePassthroughColorMapLutMeta;
        public void* next;
        public XrPassthroughColorLutMETA colorLut;
        public float weight;
        public XrPassthroughColorMapLutMETA() { }
        public XrPassthroughColorMapLutMETA(XrStructureType type, void* next, XrPassthroughColorLutMETA colorLut, float weight)
        {
            this.type = type;
            this.next = next;
            this.colorLut = colorLut;
            this.weight = weight;
        }
    }
    /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
    public unsafe struct XrPassthroughColorMapMonoToMonoFB
    {
        public XrStructureType type = XrStructureType.TypePassthroughColorMapMonoToMonoFb;
        public void* next;
        public fixed byte textureColorMap[256];
        public XrPassthroughColorMapMonoToMonoFB() { }
    }
    /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
    public unsafe struct XrPassthroughColorMapMonoToRgbaFB
    {
        public XrStructureType type = XrStructureType.TypePassthroughColorMapMonoToRgbaFb;
        public void* next;
        [InlineArray(256)]
        public struct textureColorMapInlineArray1
        {
            public XrColor4f element;
        }
        public textureColorMapInlineArray1 textureColorMap;
        public XrPassthroughColorMapMonoToRgbaFB() { }
    }
    /// <summary><b>[requires: XR_FB_passthrough]</b> Used by <see cref="Xr.CreatePassthroughFB"/></summary>
    public unsafe struct XrPassthroughCreateInfoFB
    {
        public XrStructureType type = XrStructureType.TypePassthroughCreateInfoFb;
        public void* next;
        public XrPassthroughFlagBitsFB flags;
        public XrPassthroughCreateInfoFB() { }
        public XrPassthroughCreateInfoFB(XrStructureType type, void* next, XrPassthroughFlagBitsFB flags)
        {
            this.type = type;
            this.next = next;
            this.flags = flags;
        }
    }
    /// <summary><b>[requires: XR_HTC_passthrough]</b> Used by <see cref="Xr.CreatePassthroughHTC"/></summary>
    public unsafe struct XrPassthroughCreateInfoHTC
    {
        public XrStructureType type = XrStructureType.TypePassthroughCreateInfoHtc;
        public void* next;
        public XrPassthroughFormHTC form;
        public XrPassthroughCreateInfoHTC() { }
        public XrPassthroughCreateInfoHTC(XrStructureType type, void* next, XrPassthroughFormHTC form)
        {
            this.type = type;
            this.next = next;
            this.form = form;
        }
    }
    /// <summary><b>[requires: XR_FB_passthrough_keyboard_hands]</b> Used by <see cref="Xr.PassthroughLayerSetKeyboardHandsIntensityFB"/></summary>
    public unsafe struct XrPassthroughKeyboardHandsIntensityFB
    {
        public XrStructureType type = XrStructureType.TypePassthroughKeyboardHandsIntensityFb;
        public void* next;
        public float leftHandIntensity;
        public float rightHandIntensity;
        public XrPassthroughKeyboardHandsIntensityFB() { }
        public XrPassthroughKeyboardHandsIntensityFB(XrStructureType type, void* next, float leftHandIntensity, float rightHandIntensity)
        {
            this.type = type;
            this.next = next;
            this.leftHandIntensity = leftHandIntensity;
            this.rightHandIntensity = rightHandIntensity;
        }
    }
    /// <summary><b>[requires: XR_FB_passthrough]</b> Used by <see cref="Xr.CreatePassthroughLayerFB"/></summary>
    public unsafe struct XrPassthroughLayerCreateInfoFB
    {
        public XrStructureType type = XrStructureType.TypePassthroughLayerCreateInfoFb;
        public void* next;
        public XrPassthroughFB passthrough;
        public XrPassthroughFlagBitsFB flags;
        public XrPassthroughLayerPurposeFB purpose;
        public XrPassthroughLayerCreateInfoFB() { }
        public XrPassthroughLayerCreateInfoFB(XrStructureType type, void* next, XrPassthroughFB passthrough, XrPassthroughFlagBitsFB flags, XrPassthroughLayerPurposeFB purpose)
        {
            this.type = type;
            this.next = next;
            this.passthrough = passthrough;
            this.flags = flags;
            this.purpose = purpose;
        }
    }
    /// <summary><b>[requires: XR_HTC_passthrough]</b> </summary>
    public unsafe struct XrPassthroughMeshTransformInfoHTC
    {
        public XrStructureType type = XrStructureType.TypePassthroughMeshTransformInfoHtc;
        public void* next;
        public uint vertexCount;
        public XrVector3f* vertices;
        public uint indexCount;
        public uint* indices;
        public XrSpace baseSpace;
        public long time;
        public XrPosef pose;
        public XrVector3f scale;
        public XrPassthroughMeshTransformInfoHTC() { }
        public XrPassthroughMeshTransformInfoHTC(XrStructureType type, void* next, uint vertexCount, XrVector3f* vertices, uint indexCount, uint* indices, XrSpace baseSpace, long time, XrPosef pose, XrVector3f scale)
        {
            this.type = type;
            this.next = next;
            this.vertexCount = vertexCount;
            this.vertices = vertices;
            this.indexCount = indexCount;
            this.indices = indices;
            this.baseSpace = baseSpace;
            this.time = time;
            this.pose = pose;
            this.scale = scale;
        }
    }
    /// <summary><b>[requires: XR_META_passthrough_preferences]</b> Used by <see cref="Xr.GetPassthroughPreferencesMETA"/></summary>
    public unsafe struct XrPassthroughPreferencesMETA
    {
        public XrStructureType type = XrStructureType.TypePassthroughPreferencesMeta;
        public void* next;
        public XrPassthroughPreferenceFlagBitsMETA flags;
        public XrPassthroughPreferencesMETA() { }
        public XrPassthroughPreferencesMETA(XrStructureType type, void* next, XrPassthroughPreferenceFlagBitsMETA flags)
        {
            this.type = type;
            this.next = next;
            this.flags = flags;
        }
    }
    /// <summary><b>[requires: XR_FB_passthrough]</b> Used by <see cref="Xr.PassthroughLayerSetStyleFB"/></summary>
    public unsafe struct XrPassthroughStyleFB
    {
        public XrStructureType type = XrStructureType.TypePassthroughStyleFb;
        public void* next;
        public float textureOpacityFactor;
        public XrColor4f edgeColor;
        public XrPassthroughStyleFB() { }
        public XrPassthroughStyleFB(XrStructureType type, void* next, float textureOpacityFactor, XrColor4f edgeColor)
        {
            this.type = type;
            this.next = next;
            this.textureOpacityFactor = textureOpacityFactor;
            this.edgeColor = edgeColor;
        }
    }
    /// <summary><b>[requires: XR_META_performance_metrics]</b> Used by <see cref="Xr.QueryPerformanceMetricsCounterMETA"/></summary>
    public unsafe struct XrPerformanceMetricsCounterMETA
    {
        public XrStructureType type = XrStructureType.TypePerformanceMetricsCounterMeta;
        public void* next;
        public XrPerformanceMetricsCounterFlagBitsMETA counterFlags;
        public XrPerformanceMetricsCounterUnitMETA counterUnit;
        public uint uintValue;
        public float floatValue;
        public XrPerformanceMetricsCounterMETA() { }
        public XrPerformanceMetricsCounterMETA(XrStructureType type, void* next, XrPerformanceMetricsCounterFlagBitsMETA counterFlags, XrPerformanceMetricsCounterUnitMETA counterUnit, uint uintValue, float floatValue)
        {
            this.type = type;
            this.next = next;
            this.counterFlags = counterFlags;
            this.counterUnit = counterUnit;
            this.uintValue = uintValue;
            this.floatValue = floatValue;
        }
    }
    /// <summary><b>[requires: XR_META_performance_metrics]</b> Used by <see cref="Xr.GetPerformanceMetricsStateMETA"/>, <see cref="Xr.SetPerformanceMetricsStateMETA"/></summary>
    public unsafe struct XrPerformanceMetricsStateMETA
    {
        public XrStructureType type = XrStructureType.TypePerformanceMetricsStateMeta;
        public void* next;
        public int enabled;
        public XrPerformanceMetricsStateMETA() { }
        public XrPerformanceMetricsStateMETA(XrStructureType type, void* next, int enabled)
        {
            this.type = type;
            this.next = next;
            this.enabled = enabled;
        }
    }
    /// <summary><b>[requires: XR_EXT_plane_detection]</b> Used by <see cref="Xr.BeginPlaneDetectionEXT"/></summary>
    public unsafe struct XrPlaneDetectorBeginInfoEXT
    {
        public XrStructureType type = XrStructureType.TypePlaneDetectorBeginInfoExt;
        public void* next;
        public XrSpace baseSpace;
        public long time;
        public uint orientationCount;
        public XrPlaneDetectorOrientationEXT* orientations;
        public uint semanticTypeCount;
        public XrPlaneDetectorSemanticTypeEXT* semanticTypes;
        public uint maxPlanes;
        public float minArea;
        public XrPosef boundingBoxPose;
        public XrExtent3Df boundingBoxExtent;
        public XrPlaneDetectorBeginInfoEXT() { }
        public XrPlaneDetectorBeginInfoEXT(XrStructureType type, void* next, XrSpace baseSpace, long time, uint orientationCount, XrPlaneDetectorOrientationEXT* orientations, uint semanticTypeCount, XrPlaneDetectorSemanticTypeEXT* semanticTypes, uint maxPlanes, float minArea, XrPosef boundingBoxPose, XrExtent3Df boundingBoxExtent)
        {
            this.type = type;
            this.next = next;
            this.baseSpace = baseSpace;
            this.time = time;
            this.orientationCount = orientationCount;
            this.orientations = orientations;
            this.semanticTypeCount = semanticTypeCount;
            this.semanticTypes = semanticTypes;
            this.maxPlanes = maxPlanes;
            this.minArea = minArea;
            this.boundingBoxPose = boundingBoxPose;
            this.boundingBoxExtent = boundingBoxExtent;
        }
    }
    /// <summary><b>[requires: XR_EXT_plane_detection]</b> Used by <see cref="Xr.CreatePlaneDetectorEXT"/></summary>
    public unsafe struct XrPlaneDetectorCreateInfoEXT
    {
        public XrStructureType type = XrStructureType.TypePlaneDetectorCreateInfoExt;
        public void* next;
        public XrPlaneDetectorFlagBitsEXT flags;
        public XrPlaneDetectorCreateInfoEXT() { }
        public XrPlaneDetectorCreateInfoEXT(XrStructureType type, void* next, XrPlaneDetectorFlagBitsEXT flags)
        {
            this.type = type;
            this.next = next;
            this.flags = flags;
        }
    }
    /// <summary><b>[requires: XR_EXT_plane_detection]</b> Used by <see cref="Xr.GetPlaneDetectionsEXT"/></summary>
    public unsafe struct XrPlaneDetectorGetInfoEXT
    {
        public XrStructureType type = XrStructureType.TypePlaneDetectorGetInfoExt;
        public void* next;
        public XrSpace baseSpace;
        public long time;
        public XrPlaneDetectorGetInfoEXT() { }
        public XrPlaneDetectorGetInfoEXT(XrStructureType type, void* next, XrSpace baseSpace, long time)
        {
            this.type = type;
            this.next = next;
            this.baseSpace = baseSpace;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_EXT_plane_detection]</b> </summary>
    public unsafe struct XrPlaneDetectorLocationEXT
    {
        public XrStructureType type = XrStructureType.TypePlaneDetectorLocationExt;
        public void* next;
        public ulong planeId;
        public XrSpaceLocationFlagBits locationFlags;
        public XrPosef pose;
        public XrExtent2Df extents;
        public XrPlaneDetectorOrientationEXT orientation;
        public XrPlaneDetectorSemanticTypeEXT semanticType;
        public uint polygonBufferCount;
        public XrPlaneDetectorLocationEXT() { }
        public XrPlaneDetectorLocationEXT(XrStructureType type, void* next, ulong planeId, XrSpaceLocationFlagBits locationFlags, XrPosef pose, XrExtent2Df extents, XrPlaneDetectorOrientationEXT orientation, XrPlaneDetectorSemanticTypeEXT semanticType, uint polygonBufferCount)
        {
            this.type = type;
            this.next = next;
            this.planeId = planeId;
            this.locationFlags = locationFlags;
            this.pose = pose;
            this.extents = extents;
            this.orientation = orientation;
            this.semanticType = semanticType;
            this.polygonBufferCount = polygonBufferCount;
        }
    }
    /// <summary><b>[requires: XR_EXT_plane_detection]</b> Used by <see cref="Xr.GetPlaneDetectionsEXT"/></summary>
    public unsafe struct XrPlaneDetectorLocationsEXT
    {
        public XrStructureType type = XrStructureType.TypePlaneDetectorLocationsExt;
        public void* next;
        public uint planeLocationCapacityInput;
        public uint planeLocationCountOutput;
        public XrPlaneDetectorLocationEXT* planeLocations;
        public XrPlaneDetectorLocationsEXT() { }
        public XrPlaneDetectorLocationsEXT(XrStructureType type, void* next, uint planeLocationCapacityInput, uint planeLocationCountOutput, XrPlaneDetectorLocationEXT* planeLocations)
        {
            this.type = type;
            this.next = next;
            this.planeLocationCapacityInput = planeLocationCapacityInput;
            this.planeLocationCountOutput = planeLocationCountOutput;
            this.planeLocations = planeLocations;
        }
    }
    /// <summary><b>[requires: XR_EXT_plane_detection]</b> Used by <see cref="Xr.GetPlanePolygonBufferEXT"/></summary>
    public unsafe struct XrPlaneDetectorPolygonBufferEXT
    {
        public XrStructureType type = XrStructureType.TypePlaneDetectorPolygonBufferExt;
        public void* next;
        public uint vertexCapacityInput;
        public uint vertexCountOutput;
        public XrVector2f* vertices;
        public XrPlaneDetectorPolygonBufferEXT() { }
        public XrPlaneDetectorPolygonBufferEXT(XrStructureType type, void* next, uint vertexCapacityInput, uint vertexCountOutput, XrVector2f* vertices)
        {
            this.type = type;
            this.next = next;
            this.vertexCapacityInput = vertexCapacityInput;
            this.vertexCountOutput = vertexCountOutput;
            this.vertices = vertices;
        }
    }
    /// <summary>Used by <see cref="Xr.SendVirtualKeyboardInputMETA"/>, <see cref="Xr.SetInputDeviceLocationEXT"/></summary>
    public unsafe struct XrPosef
    {
        public XrQuaternionf orientation;
        public XrVector3f position;
        public XrPosef() { }
        public XrPosef(XrQuaternionf orientation, XrVector3f position)
        {
            this.orientation = orientation;
            this.position = position;
        }
    }
    /// <summary></summary>
    public unsafe struct XrQuaternionf
    {
        public float x;
        public float y;
        public float z;
        public float w;
        public XrQuaternionf() { }
        public XrQuaternionf(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
    }
    /// <summary><b>[requires: XR_META_recommended_layer_resolution]</b> Used by <see cref="Xr.GetRecommendedLayerResolutionMETA"/></summary>
    public unsafe struct XrRecommendedLayerResolutionGetInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeRecommendedLayerResolutionGetInfoMeta;
        public void* next;
        public XrCompositionLayerBaseHeader* layer;
        public long predictedDisplayTime;
        public XrRecommendedLayerResolutionGetInfoMETA() { }
        public XrRecommendedLayerResolutionGetInfoMETA(XrStructureType type, void* next, XrCompositionLayerBaseHeader* layer, long predictedDisplayTime)
        {
            this.type = type;
            this.next = next;
            this.layer = layer;
            this.predictedDisplayTime = predictedDisplayTime;
        }
    }
    /// <summary><b>[requires: XR_META_recommended_layer_resolution]</b> Used by <see cref="Xr.GetRecommendedLayerResolutionMETA"/></summary>
    public unsafe struct XrRecommendedLayerResolutionMETA
    {
        public XrStructureType type = XrStructureType.TypeRecommendedLayerResolutionMeta;
        public void* next;
        public XrExtent2Di recommendedImageDimensions;
        public int isValid;
        public XrRecommendedLayerResolutionMETA() { }
        public XrRecommendedLayerResolutionMETA(XrStructureType type, void* next, XrExtent2Di recommendedImageDimensions, int isValid)
        {
            this.type = type;
            this.next = next;
            this.recommendedImageDimensions = recommendedImageDimensions;
            this.isValid = isValid;
        }
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Xr.GetSpaceBoundingBox2DFB"/></summary>
    public unsafe struct XrRect2Df
    {
        public XrOffset2Df offset;
        public XrExtent2Df extent;
        public XrRect2Df() { }
        public XrRect2Df(XrOffset2Df offset, XrExtent2Df extent)
        {
            this.offset = offset;
            this.extent = extent;
        }
    }
    /// <summary></summary>
    public unsafe struct XrRect2Di
    {
        public XrOffset2Di offset;
        public XrExtent2Di extent;
        public XrRect2Di() { }
        public XrRect2Di(XrOffset2Di offset, XrExtent2Di extent)
        {
            this.offset = offset;
            this.extent = extent;
        }
    }
    /// <summary><b>[requires: XR_FB_scene]</b> Used by <see cref="Xr.GetSpaceBoundingBox3DFB"/></summary>
    public unsafe struct XrRect3DfFB
    {
        public XrOffset3DfFB offset;
        public XrExtent3Df extent;
        public XrRect3DfFB() { }
        public XrRect3DfFB(XrOffset3DfFB offset, XrExtent3Df extent)
        {
            this.offset = offset;
            this.extent = extent;
        }
    }
    /// <summary>Used by <see cref="Xr.CreateReferenceSpace"/></summary>
    public unsafe struct XrReferenceSpaceCreateInfo
    {
        public XrStructureType type = XrStructureType.TypeReferenceSpaceCreateInfo;
        public void* next;
        public XrReferenceSpaceType referenceSpaceType;
        public XrPosef poseInReferenceSpace;
        public XrReferenceSpaceCreateInfo() { }
        public XrReferenceSpaceCreateInfo(XrStructureType type, void* next, XrReferenceSpaceType referenceSpaceType, XrPosef poseInReferenceSpace)
        {
            this.type = type;
            this.next = next;
            this.referenceSpaceType = referenceSpaceType;
            this.poseInReferenceSpace = poseInReferenceSpace;
        }
    }
    /// <summary><b>[requires: XR_FB_render_model]</b> Used by <see cref="Xr.LoadRenderModelFB"/></summary>
    public unsafe struct XrRenderModelBufferFB
    {
        public XrStructureType type = XrStructureType.TypeRenderModelBufferFb;
        public void* next;
        public uint bufferCapacityInput;
        public uint bufferCountOutput;
        public byte* buffer;
        public XrRenderModelBufferFB() { }
        public XrRenderModelBufferFB(XrStructureType type, void* next, uint bufferCapacityInput, uint bufferCountOutput, byte* buffer)
        {
            this.type = type;
            this.next = next;
            this.bufferCapacityInput = bufferCapacityInput;
            this.bufferCountOutput = bufferCountOutput;
            this.buffer = buffer;
        }
    }
    /// <summary><b>[requires: XR_FB_render_model]</b> </summary>
    public unsafe struct XrRenderModelCapabilitiesRequestFB
    {
        public XrStructureType type = XrStructureType.TypeRenderModelCapabilitiesRequestFb;
        public void* next;
        public XrRenderModelFlagBitsFB flags;
        public XrRenderModelCapabilitiesRequestFB() { }
        public XrRenderModelCapabilitiesRequestFB(XrStructureType type, void* next, XrRenderModelFlagBitsFB flags)
        {
            this.type = type;
            this.next = next;
            this.flags = flags;
        }
    }
    /// <summary><b>[requires: XR_FB_render_model]</b> Used by <see cref="Xr.LoadRenderModelFB"/></summary>
    public unsafe struct XrRenderModelLoadInfoFB
    {
        public XrStructureType type = XrStructureType.TypeRenderModelLoadInfoFb;
        public void* next;
        public ulong modelKey;
        public XrRenderModelLoadInfoFB() { }
        public XrRenderModelLoadInfoFB(XrStructureType type, void* next, ulong modelKey)
        {
            this.type = type;
            this.next = next;
            this.modelKey = modelKey;
        }
    }
    /// <summary><b>[requires: XR_FB_render_model]</b> Used by <see cref="Xr.EnumerateRenderModelPathsFB"/></summary>
    public unsafe struct XrRenderModelPathInfoFB
    {
        public XrStructureType type = XrStructureType.TypeRenderModelPathInfoFb;
        public void* next;
        public ulong path;
        public XrRenderModelPathInfoFB() { }
        public XrRenderModelPathInfoFB(XrStructureType type, void* next, ulong path)
        {
            this.type = type;
            this.next = next;
            this.path = path;
        }
    }
    /// <summary><b>[requires: XR_FB_render_model]</b> Used by <see cref="Xr.GetRenderModelPropertiesFB"/></summary>
    public unsafe struct XrRenderModelPropertiesFB
    {
        public XrStructureType type = XrStructureType.TypeRenderModelPropertiesFb;
        public void* next;
        public uint vendorId;
        [InlineArray(64)]
        public struct modelNameInlineArray1
        {
            public byte element;
        }
        public modelNameInlineArray1 modelName;
        public ulong modelKey;
        public uint modelVersion;
        public XrRenderModelFlagBitsFB flags;
        public XrRenderModelPropertiesFB() { }
    }
    /// <summary><b>[requires: XR_FB_scene]</b> Used by <see cref="Xr.GetSpaceRoomLayoutFB"/></summary>
    public unsafe struct XrRoomLayoutFB
    {
        public XrStructureType type = XrStructureType.TypeRoomLayoutFb;
        public void* next;
        public XrUuid floorUuid;
        public XrUuid ceilingUuid;
        public uint wallUuidCapacityInput;
        public uint wallUuidCountOutput;
        public XrUuid* wallUuids;
        public XrRoomLayoutFB() { }
        public XrRoomLayoutFB(XrStructureType type, void* next, XrUuid floorUuid, XrUuid ceilingUuid, uint wallUuidCapacityInput, uint wallUuidCountOutput, XrUuid* wallUuids)
        {
            this.type = type;
            this.next = next;
            this.floorUuid = floorUuid;
            this.ceilingUuid = ceilingUuid;
            this.wallUuidCapacityInput = wallUuidCapacityInput;
            this.wallUuidCountOutput = wallUuidCountOutput;
            this.wallUuids = wallUuids;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrSceneBoundsMSFT
    {
        public XrSpace space;
        public long time;
        public uint sphereCount;
        public XrSceneSphereBoundMSFT* spheres;
        public uint boxCount;
        public XrSceneOrientedBoxBoundMSFT* boxes;
        public uint frustumCount;
        public XrSceneFrustumBoundMSFT* frustums;
        public XrSceneBoundsMSFT() { }
        public XrSceneBoundsMSFT(XrSpace space, long time, uint sphereCount, XrSceneSphereBoundMSFT* spheres, uint boxCount, XrSceneOrientedBoxBoundMSFT* boxes, uint frustumCount, XrSceneFrustumBoundMSFT* frustums)
        {
            this.space = space;
            this.time = time;
            this.sphereCount = sphereCount;
            this.spheres = spheres;
            this.boxCount = boxCount;
            this.boxes = boxes;
            this.frustumCount = frustumCount;
            this.frustums = frustums;
        }
    }
    /// <summary><b>[requires: XR_FB_scene_capture]</b> Used by <see cref="Xr.RequestSceneCaptureFB"/></summary>
    public unsafe struct XrSceneCaptureRequestInfoFB
    {
        public XrStructureType type = XrStructureType.TypeSceneCaptureRequestInfoFb;
        public void* next;
        public uint requestByteCount;
        public byte* request;
        public XrSceneCaptureRequestInfoFB() { }
        public XrSceneCaptureRequestInfoFB(XrStructureType type, void* next, uint requestByteCount, byte* request)
        {
            this.type = type;
            this.next = next;
            this.requestByteCount = requestByteCount;
            this.request = request;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrSceneComponentLocationMSFT
    {
        public XrSpaceLocationFlagBits flags;
        public XrPosef pose;
        public XrSceneComponentLocationMSFT() { }
        public XrSceneComponentLocationMSFT(XrSpaceLocationFlagBits flags, XrPosef pose)
        {
            this.flags = flags;
            this.pose = pose;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> Used by <see cref="Xr.LocateSceneComponentsMSFT"/></summary>
    public unsafe struct XrSceneComponentLocationsMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneComponentLocationsMsft;
        public void* next;
        public uint locationCount;
        public XrSceneComponentLocationMSFT* locations;
        public XrSceneComponentLocationsMSFT() { }
        public XrSceneComponentLocationsMSFT(XrStructureType type, void* next, uint locationCount, XrSceneComponentLocationMSFT* locations)
        {
            this.type = type;
            this.next = next;
            this.locationCount = locationCount;
            this.locations = locations;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrSceneComponentMSFT
    {
        public XrSceneComponentTypeMSFT componentType;
        public XrUuidMSFT id;
        public XrUuidMSFT parentId;
        public long updateTime;
        public XrSceneComponentMSFT() { }
        public XrSceneComponentMSFT(XrSceneComponentTypeMSFT componentType, XrUuidMSFT id, XrUuidMSFT parentId, long updateTime)
        {
            this.componentType = componentType;
            this.id = id;
            this.parentId = parentId;
            this.updateTime = updateTime;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrSceneComponentParentFilterInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneComponentParentFilterInfoMsft;
        public void* next;
        public XrUuidMSFT parentId;
        public XrSceneComponentParentFilterInfoMSFT() { }
        public XrSceneComponentParentFilterInfoMSFT(XrStructureType type, void* next, XrUuidMSFT parentId)
        {
            this.type = type;
            this.next = next;
            this.parentId = parentId;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> Used by <see cref="Xr.GetSceneComponentsMSFT"/></summary>
    public unsafe struct XrSceneComponentsGetInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneComponentsGetInfoMsft;
        public void* next;
        public XrSceneComponentTypeMSFT componentType;
        public XrSceneComponentsGetInfoMSFT() { }
        public XrSceneComponentsGetInfoMSFT(XrStructureType type, void* next, XrSceneComponentTypeMSFT componentType)
        {
            this.type = type;
            this.next = next;
            this.componentType = componentType;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> Used by <see cref="Xr.LocateSceneComponentsMSFT"/></summary>
    public unsafe struct XrSceneComponentsLocateInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneComponentsLocateInfoMsft;
        public void* next;
        public XrSpace baseSpace;
        public long time;
        public uint componentIdCount;
        public XrUuidMSFT* componentIds;
        public XrSceneComponentsLocateInfoMSFT() { }
        public XrSceneComponentsLocateInfoMSFT(XrStructureType type, void* next, XrSpace baseSpace, long time, uint componentIdCount, XrUuidMSFT* componentIds)
        {
            this.type = type;
            this.next = next;
            this.baseSpace = baseSpace;
            this.time = time;
            this.componentIdCount = componentIdCount;
            this.componentIds = componentIds;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> Used by <see cref="Xr.GetSceneComponentsMSFT"/></summary>
    public unsafe struct XrSceneComponentsMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneComponentsMsft;
        public void* next;
        public uint componentCapacityInput;
        public uint componentCountOutput;
        public XrSceneComponentMSFT* components;
        public XrSceneComponentsMSFT() { }
        public XrSceneComponentsMSFT(XrStructureType type, void* next, uint componentCapacityInput, uint componentCountOutput, XrSceneComponentMSFT* components)
        {
            this.type = type;
            this.next = next;
            this.componentCapacityInput = componentCapacityInput;
            this.componentCountOutput = componentCountOutput;
            this.components = components;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> Used by <see cref="Xr.CreateSceneMSFT"/></summary>
    public unsafe struct XrSceneCreateInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneCreateInfoMsft;
        public void* next;
        public XrSceneCreateInfoMSFT() { }
        public XrSceneCreateInfoMSFT(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding_serialization]</b> Used by <see cref="Xr.DeserializeSceneMSFT"/></summary>
    public unsafe struct XrSceneDeserializeInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneDeserializeInfoMsft;
        public void* next;
        public uint fragmentCount;
        public XrDeserializeSceneFragmentMSFT* fragments;
        public XrSceneDeserializeInfoMSFT() { }
        public XrSceneDeserializeInfoMSFT(XrStructureType type, void* next, uint fragmentCount, XrDeserializeSceneFragmentMSFT* fragments)
        {
            this.type = type;
            this.next = next;
            this.fragmentCount = fragmentCount;
            this.fragments = fragments;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrSceneFrustumBoundMSFT
    {
        public XrPosef pose;
        public XrFovf fov;
        public float farDistance;
        public XrSceneFrustumBoundMSFT() { }
        public XrSceneFrustumBoundMSFT(XrPosef pose, XrFovf fov, float farDistance)
        {
            this.pose = pose;
            this.fov = fov;
            this.farDistance = farDistance;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_marker]</b> </summary>
    public unsafe struct XrSceneMarkerMSFT
    {
        public XrSceneMarkerTypeMSFT markerType;
        public long lastSeenTime;
        public XrOffset2Df center;
        public XrExtent2Df size;
        public XrSceneMarkerMSFT() { }
        public XrSceneMarkerMSFT(XrSceneMarkerTypeMSFT markerType, long lastSeenTime, XrOffset2Df center, XrExtent2Df size)
        {
            this.markerType = markerType;
            this.lastSeenTime = lastSeenTime;
            this.center = center;
            this.size = size;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_marker]</b> </summary>
    public unsafe struct XrSceneMarkerQRCodeMSFT
    {
        public XrSceneMarkerQRCodeSymbolTypeMSFT symbolType;
        public byte version;
        public XrSceneMarkerQRCodeMSFT() { }
        public XrSceneMarkerQRCodeMSFT(XrSceneMarkerQRCodeSymbolTypeMSFT symbolType, byte version)
        {
            this.symbolType = symbolType;
            this.version = version;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_marker]</b> </summary>
    public unsafe struct XrSceneMarkerQRCodesMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneMarkerQrCodesMsft;
        public void* next;
        public uint qrCodeCapacityInput;
        public XrSceneMarkerQRCodeMSFT* qrCodes;
        public XrSceneMarkerQRCodesMSFT() { }
        public XrSceneMarkerQRCodesMSFT(XrStructureType type, void* next, uint qrCodeCapacityInput, XrSceneMarkerQRCodeMSFT* qrCodes)
        {
            this.type = type;
            this.next = next;
            this.qrCodeCapacityInput = qrCodeCapacityInput;
            this.qrCodes = qrCodes;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_marker]</b> </summary>
    public unsafe struct XrSceneMarkersMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneMarkersMsft;
        public void* next;
        public uint sceneMarkerCapacityInput;
        public XrSceneMarkerMSFT* sceneMarkers;
        public XrSceneMarkersMSFT() { }
        public XrSceneMarkersMSFT(XrStructureType type, void* next, uint sceneMarkerCapacityInput, XrSceneMarkerMSFT* sceneMarkers)
        {
            this.type = type;
            this.next = next;
            this.sceneMarkerCapacityInput = sceneMarkerCapacityInput;
            this.sceneMarkers = sceneMarkers;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_marker]</b> </summary>
    public unsafe struct XrSceneMarkerTypeFilterMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneMarkerTypeFilterMsft;
        public void* next;
        public uint markerTypeCount;
        public XrSceneMarkerTypeMSFT* markerTypes;
        public XrSceneMarkerTypeFilterMSFT() { }
        public XrSceneMarkerTypeFilterMSFT(XrStructureType type, void* next, uint markerTypeCount, XrSceneMarkerTypeMSFT* markerTypes)
        {
            this.type = type;
            this.next = next;
            this.markerTypeCount = markerTypeCount;
            this.markerTypes = markerTypes;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> Used by <see cref="Xr.GetSceneMeshBuffersMSFT"/></summary>
    public unsafe struct XrSceneMeshBuffersGetInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneMeshBuffersGetInfoMsft;
        public void* next;
        public ulong meshBufferId;
        public XrSceneMeshBuffersGetInfoMSFT() { }
        public XrSceneMeshBuffersGetInfoMSFT(XrStructureType type, void* next, ulong meshBufferId)
        {
            this.type = type;
            this.next = next;
            this.meshBufferId = meshBufferId;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> Used by <see cref="Xr.GetSceneMeshBuffersMSFT"/></summary>
    public unsafe struct XrSceneMeshBuffersMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneMeshBuffersMsft;
        public void* next;
        public XrSceneMeshBuffersMSFT() { }
        public XrSceneMeshBuffersMSFT(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrSceneMeshesMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneMeshesMsft;
        public void* next;
        public uint sceneMeshCount;
        public XrSceneMeshMSFT* sceneMeshes;
        public XrSceneMeshesMSFT() { }
        public XrSceneMeshesMSFT(XrStructureType type, void* next, uint sceneMeshCount, XrSceneMeshMSFT* sceneMeshes)
        {
            this.type = type;
            this.next = next;
            this.sceneMeshCount = sceneMeshCount;
            this.sceneMeshes = sceneMeshes;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrSceneMeshIndicesUint16MSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneMeshIndicesUint16Msft;
        public void* next;
        public uint indexCapacityInput;
        public uint indexCountOutput;
        public ushort* indices;
        public XrSceneMeshIndicesUint16MSFT() { }
        public XrSceneMeshIndicesUint16MSFT(XrStructureType type, void* next, uint indexCapacityInput, uint indexCountOutput, ushort* indices)
        {
            this.type = type;
            this.next = next;
            this.indexCapacityInput = indexCapacityInput;
            this.indexCountOutput = indexCountOutput;
            this.indices = indices;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrSceneMeshIndicesUint32MSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneMeshIndicesUint32Msft;
        public void* next;
        public uint indexCapacityInput;
        public uint indexCountOutput;
        public uint* indices;
        public XrSceneMeshIndicesUint32MSFT() { }
        public XrSceneMeshIndicesUint32MSFT(XrStructureType type, void* next, uint indexCapacityInput, uint indexCountOutput, uint* indices)
        {
            this.type = type;
            this.next = next;
            this.indexCapacityInput = indexCapacityInput;
            this.indexCountOutput = indexCountOutput;
            this.indices = indices;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrSceneMeshMSFT
    {
        public ulong meshBufferId;
        public int supportsIndicesUint16;
        public XrSceneMeshMSFT() { }
        public XrSceneMeshMSFT(ulong meshBufferId, int supportsIndicesUint16)
        {
            this.meshBufferId = meshBufferId;
            this.supportsIndicesUint16 = supportsIndicesUint16;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrSceneMeshVertexBufferMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneMeshVertexBufferMsft;
        public void* next;
        public uint vertexCapacityInput;
        public uint vertexCountOutput;
        public XrVector3f* vertices;
        public XrSceneMeshVertexBufferMSFT() { }
        public XrSceneMeshVertexBufferMSFT(XrStructureType type, void* next, uint vertexCapacityInput, uint vertexCountOutput, XrVector3f* vertices)
        {
            this.type = type;
            this.next = next;
            this.vertexCapacityInput = vertexCapacityInput;
            this.vertexCountOutput = vertexCountOutput;
            this.vertices = vertices;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrSceneObjectMSFT
    {
        public XrSceneObjectTypeMSFT objectType;
        public XrSceneObjectMSFT() { }
        public XrSceneObjectMSFT(XrSceneObjectTypeMSFT objectType)
        {
            this.objectType = objectType;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrSceneObjectsMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneObjectsMsft;
        public void* next;
        public uint sceneObjectCount;
        public XrSceneObjectMSFT* sceneObjects;
        public XrSceneObjectsMSFT() { }
        public XrSceneObjectsMSFT(XrStructureType type, void* next, uint sceneObjectCount, XrSceneObjectMSFT* sceneObjects)
        {
            this.type = type;
            this.next = next;
            this.sceneObjectCount = sceneObjectCount;
            this.sceneObjects = sceneObjects;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrSceneObjectTypesFilterInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneObjectTypesFilterInfoMsft;
        public void* next;
        public uint objectTypeCount;
        public XrSceneObjectTypeMSFT* objectTypes;
        public XrSceneObjectTypesFilterInfoMSFT() { }
        public XrSceneObjectTypesFilterInfoMSFT(XrStructureType type, void* next, uint objectTypeCount, XrSceneObjectTypeMSFT* objectTypes)
        {
            this.type = type;
            this.next = next;
            this.objectTypeCount = objectTypeCount;
            this.objectTypes = objectTypes;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> Used by <see cref="Xr.CreateSceneObserverMSFT"/></summary>
    public unsafe struct XrSceneObserverCreateInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSceneObserverCreateInfoMsft;
        public void* next;
        public XrSceneObserverCreateInfoMSFT() { }
        public XrSceneObserverCreateInfoMSFT(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrSceneOrientedBoxBoundMSFT
    {
        public XrPosef pose;
        public XrVector3f extents;
        public XrSceneOrientedBoxBoundMSFT() { }
        public XrSceneOrientedBoxBoundMSFT(XrPosef pose, XrVector3f extents)
        {
            this.pose = pose;
            this.extents = extents;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrScenePlaneAlignmentFilterInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeScenePlaneAlignmentFilterInfoMsft;
        public void* next;
        public uint alignmentCount;
        public XrScenePlaneAlignmentTypeMSFT* alignments;
        public XrScenePlaneAlignmentFilterInfoMSFT() { }
        public XrScenePlaneAlignmentFilterInfoMSFT(XrStructureType type, void* next, uint alignmentCount, XrScenePlaneAlignmentTypeMSFT* alignments)
        {
            this.type = type;
            this.next = next;
            this.alignmentCount = alignmentCount;
            this.alignments = alignments;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrScenePlaneMSFT
    {
        public XrScenePlaneAlignmentTypeMSFT alignment;
        public XrExtent2Df size;
        public ulong meshBufferId;
        public int supportsIndicesUint16;
        public XrScenePlaneMSFT() { }
        public XrScenePlaneMSFT(XrScenePlaneAlignmentTypeMSFT alignment, XrExtent2Df size, ulong meshBufferId, int supportsIndicesUint16)
        {
            this.alignment = alignment;
            this.size = size;
            this.meshBufferId = meshBufferId;
            this.supportsIndicesUint16 = supportsIndicesUint16;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrScenePlanesMSFT
    {
        public XrStructureType type = XrStructureType.TypeScenePlanesMsft;
        public void* next;
        public uint scenePlaneCount;
        public XrScenePlaneMSFT* scenePlanes;
        public XrScenePlanesMSFT() { }
        public XrScenePlanesMSFT(XrStructureType type, void* next, uint scenePlaneCount, XrScenePlaneMSFT* scenePlanes)
        {
            this.type = type;
            this.next = next;
            this.scenePlaneCount = scenePlaneCount;
            this.scenePlanes = scenePlanes;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrSceneSphereBoundMSFT
    {
        public XrVector3f center;
        public float radius;
        public XrSceneSphereBoundMSFT() { }
        public XrSceneSphereBoundMSFT(XrVector3f center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }
    }
    /// <summary><b>[requires: XR_MSFT_secondary_view_configuration]</b> </summary>
    public unsafe struct XrSecondaryViewConfigurationFrameEndInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSecondaryViewConfigurationFrameEndInfoMsft;
        public void* next;
        public uint viewConfigurationCount;
        public XrSecondaryViewConfigurationLayerInfoMSFT* viewConfigurationLayersInfo;
        public XrSecondaryViewConfigurationFrameEndInfoMSFT() { }
        public XrSecondaryViewConfigurationFrameEndInfoMSFT(XrStructureType type, void* next, uint viewConfigurationCount, XrSecondaryViewConfigurationLayerInfoMSFT* viewConfigurationLayersInfo)
        {
            this.type = type;
            this.next = next;
            this.viewConfigurationCount = viewConfigurationCount;
            this.viewConfigurationLayersInfo = viewConfigurationLayersInfo;
        }
    }
    /// <summary><b>[requires: XR_MSFT_secondary_view_configuration]</b> </summary>
    public unsafe struct XrSecondaryViewConfigurationFrameStateMSFT
    {
        public XrStructureType type = XrStructureType.TypeSecondaryViewConfigurationFrameStateMsft;
        public void* next;
        public uint viewConfigurationCount;
        public XrSecondaryViewConfigurationStateMSFT* viewConfigurationStates;
        public XrSecondaryViewConfigurationFrameStateMSFT() { }
        public XrSecondaryViewConfigurationFrameStateMSFT(XrStructureType type, void* next, uint viewConfigurationCount, XrSecondaryViewConfigurationStateMSFT* viewConfigurationStates)
        {
            this.type = type;
            this.next = next;
            this.viewConfigurationCount = viewConfigurationCount;
            this.viewConfigurationStates = viewConfigurationStates;
        }
    }
    /// <summary><b>[requires: XR_MSFT_secondary_view_configuration]</b> </summary>
    public unsafe struct XrSecondaryViewConfigurationLayerInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSecondaryViewConfigurationLayerInfoMsft;
        public void* next;
        public XrViewConfigurationType viewConfigurationType;
        public XrEnvironmentBlendMode environmentBlendMode;
        public uint layerCount;
        public XrCompositionLayerBaseHeader** layers;
        public XrSecondaryViewConfigurationLayerInfoMSFT() { }
        public XrSecondaryViewConfigurationLayerInfoMSFT(XrStructureType type, void* next, XrViewConfigurationType viewConfigurationType, XrEnvironmentBlendMode environmentBlendMode, uint layerCount, XrCompositionLayerBaseHeader** layers)
        {
            this.type = type;
            this.next = next;
            this.viewConfigurationType = viewConfigurationType;
            this.environmentBlendMode = environmentBlendMode;
            this.layerCount = layerCount;
            this.layers = layers;
        }
    }
    /// <summary><b>[requires: XR_MSFT_secondary_view_configuration]</b> </summary>
    public unsafe struct XrSecondaryViewConfigurationSessionBeginInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSecondaryViewConfigurationSessionBeginInfoMsft;
        public void* next;
        public uint viewConfigurationCount;
        public XrViewConfigurationType* enabledViewConfigurationTypes;
        public XrSecondaryViewConfigurationSessionBeginInfoMSFT() { }
        public XrSecondaryViewConfigurationSessionBeginInfoMSFT(XrStructureType type, void* next, uint viewConfigurationCount, XrViewConfigurationType* enabledViewConfigurationTypes)
        {
            this.type = type;
            this.next = next;
            this.viewConfigurationCount = viewConfigurationCount;
            this.enabledViewConfigurationTypes = enabledViewConfigurationTypes;
        }
    }
    /// <summary><b>[requires: XR_MSFT_secondary_view_configuration]</b> </summary>
    public unsafe struct XrSecondaryViewConfigurationStateMSFT
    {
        public XrStructureType type = XrStructureType.TypeSecondaryViewConfigurationStateMsft;
        public void* next;
        public XrViewConfigurationType viewConfigurationType;
        public int active;
        public XrSecondaryViewConfigurationStateMSFT() { }
        public XrSecondaryViewConfigurationStateMSFT(XrStructureType type, void* next, XrViewConfigurationType viewConfigurationType, int active)
        {
            this.type = type;
            this.next = next;
            this.viewConfigurationType = viewConfigurationType;
            this.active = active;
        }
    }
    /// <summary><b>[requires: XR_MSFT_secondary_view_configuration]</b> </summary>
    public unsafe struct XrSecondaryViewConfigurationSwapchainCreateInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSecondaryViewConfigurationSwapchainCreateInfoMsft;
        public void* next;
        public XrViewConfigurationType viewConfigurationType;
        public XrSecondaryViewConfigurationSwapchainCreateInfoMSFT() { }
        public XrSecondaryViewConfigurationSwapchainCreateInfoMSFT(XrStructureType type, void* next, XrViewConfigurationType viewConfigurationType)
        {
            this.type = type;
            this.next = next;
            this.viewConfigurationType = viewConfigurationType;
        }
    }
    /// <summary><b>[requires: XR_FB_scene]</b> Used by <see cref="Xr.GetSpaceSemanticLabelsFB"/></summary>
    public unsafe struct XrSemanticLabelsFB
    {
        public XrStructureType type = XrStructureType.TypeSemanticLabelsFb;
        public void* next;
        public uint bufferCapacityInput;
        public uint bufferCountOutput;
        public byte* buffer;
        public XrSemanticLabelsFB() { }
        public XrSemanticLabelsFB(XrStructureType type, void* next, uint bufferCapacityInput, uint bufferCountOutput, byte* buffer)
        {
            this.type = type;
            this.next = next;
            this.bufferCapacityInput = bufferCapacityInput;
            this.bufferCountOutput = bufferCountOutput;
            this.buffer = buffer;
        }
    }
    /// <summary><b>[requires: XR_FB_scene]</b> </summary>
    public unsafe struct XrSemanticLabelsSupportInfoFB
    {
        public XrStructureType type = XrStructureType.TypeSemanticLabelsSupportInfoFb;
        public void* next;
        public XrSemanticLabelsSupportFlagBitsFB flags;
        public byte* recognizedLabels;
        public XrSemanticLabelsSupportInfoFB() { }
        public XrSemanticLabelsSupportInfoFB(XrStructureType type, void* next, XrSemanticLabelsSupportFlagBitsFB flags, byte* recognizedLabels)
        {
            this.type = type;
            this.next = next;
            this.flags = flags;
            this.recognizedLabels = recognizedLabels;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding_serialization]</b> Used by <see cref="Xr.GetSerializedSceneFragmentDataMSFT"/></summary>
    public unsafe struct XrSerializedSceneFragmentDataGetInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSerializedSceneFragmentDataGetInfoMsft;
        public void* next;
        public XrUuidMSFT sceneFragmentId;
        public XrSerializedSceneFragmentDataGetInfoMSFT() { }
        public XrSerializedSceneFragmentDataGetInfoMSFT(XrStructureType type, void* next, XrUuidMSFT sceneFragmentId)
        {
            this.type = type;
            this.next = next;
            this.sceneFragmentId = sceneFragmentId;
        }
    }
    /// <summary>Used by <see cref="Xr.AttachSessionActionSets"/></summary>
    public unsafe struct XrSessionActionSetsAttachInfo
    {
        public XrStructureType type = XrStructureType.TypeSessionActionSetsAttachInfo;
        public void* next;
        public uint countActionSets;
        public XrActionSet* actionSets;
        public XrSessionActionSetsAttachInfo() { }
        public XrSessionActionSetsAttachInfo(XrStructureType type, void* next, uint countActionSets, XrActionSet* actionSets)
        {
            this.type = type;
            this.next = next;
            this.countActionSets = countActionSets;
            this.actionSets = actionSets;
        }
    }
    /// <summary>Used by <see cref="Xr.BeginSession"/></summary>
    public unsafe struct XrSessionBeginInfo
    {
        public XrStructureType type = XrStructureType.TypeSessionBeginInfo;
        public void* next;
        public XrViewConfigurationType primaryViewConfigurationType;
        public XrSessionBeginInfo() { }
        public XrSessionBeginInfo(XrStructureType type, void* next, XrViewConfigurationType primaryViewConfigurationType)
        {
            this.type = type;
            this.next = next;
            this.primaryViewConfigurationType = primaryViewConfigurationType;
        }
    }
    /// <summary>Used by <see cref="Xr.CreateSession"/></summary>
    public unsafe struct XrSessionCreateInfo
    {
        public XrStructureType type = XrStructureType.TypeSessionCreateInfo;
        public void* next;
        public XrSessionCreateFlagBits createFlags;
        public ulong systemId;
        public XrSessionCreateInfo() { }
        public XrSessionCreateInfo(XrStructureType type, void* next, XrSessionCreateFlagBits createFlags, ulong systemId)
        {
            this.type = type;
            this.next = next;
            this.createFlags = createFlags;
            this.systemId = systemId;
        }
    }
    /// <summary><b>[requires: XR_EXTX_overlay]</b> </summary>
    public unsafe struct XrSessionCreateInfoOverlayEXTX
    {
        public XrStructureType type = XrStructureType.TypeSessionCreateInfoOverlayExtx;
        public void* next;
        public XrOverlaySessionCreateFlagBitsEXTX createFlags;
        public uint sessionLayersPlacement;
        public XrSessionCreateInfoOverlayEXTX() { }
        public XrSessionCreateInfoOverlayEXTX(XrStructureType type, void* next, XrOverlaySessionCreateFlagBitsEXTX createFlags, uint sessionLayersPlacement)
        {
            this.type = type;
            this.next = next;
            this.createFlags = createFlags;
            this.sessionLayersPlacement = sessionLayersPlacement;
        }
    }
    /// <summary><b>[requires: XR_META_spatial_entity_sharing]</b> Used by <see cref="Xr.ShareSpacesMETA"/></summary>
    public unsafe struct XrShareSpacesInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeShareSpacesInfoMeta;
        public void* next;
        public uint spaceCount;
        public XrSpace* spaces;
        public XrShareSpacesRecipientBaseHeaderMETA* recipientInfo;
        public XrShareSpacesInfoMETA() { }
        public XrShareSpacesInfoMETA(XrStructureType type, void* next, uint spaceCount, XrSpace* spaces, XrShareSpacesRecipientBaseHeaderMETA* recipientInfo)
        {
            this.type = type;
            this.next = next;
            this.spaceCount = spaceCount;
            this.spaces = spaces;
            this.recipientInfo = recipientInfo;
        }
    }
    /// <summary><b>[requires: XR_META_spatial_entity_sharing]</b> </summary>
    public unsafe struct XrShareSpacesRecipientBaseHeaderMETA
    {
        public XrStructureType type;
        public void* next;
        public XrShareSpacesRecipientBaseHeaderMETA() { }
        public XrShareSpacesRecipientBaseHeaderMETA(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_META_spatial_entity_group_sharing]</b> </summary>
    public unsafe struct XrShareSpacesRecipientGroupsMETA
    {
        public XrStructureType type = XrStructureType.TypeShareSpacesRecipientGroupsMeta;
        public void* next;
        public uint groupCount;
        public XrUuid* groups;
        public XrShareSpacesRecipientGroupsMETA() { }
        public XrShareSpacesRecipientGroupsMETA(XrStructureType type, void* next, uint groupCount, XrUuid* groups)
        {
            this.type = type;
            this.next = next;
            this.groupCount = groupCount;
            this.groups = groups;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_query]</b> </summary>
    public unsafe struct XrSpaceComponentFilterInfoFB
    {
        public XrStructureType type = XrStructureType.TypeSpaceComponentFilterInfoFb;
        public void* next;
        public XrSpaceComponentTypeFB componentType;
        public XrSpaceComponentFilterInfoFB() { }
        public XrSpaceComponentFilterInfoFB(XrStructureType type, void* next, XrSpaceComponentTypeFB componentType)
        {
            this.type = type;
            this.next = next;
            this.componentType = componentType;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity]</b> Used by <see cref="Xr.GetSpaceComponentStatusFB"/></summary>
    public unsafe struct XrSpaceComponentStatusFB
    {
        public XrStructureType type = XrStructureType.TypeSpaceComponentStatusFb;
        public void* next;
        public int enabled;
        public int changePending;
        public XrSpaceComponentStatusFB() { }
        public XrSpaceComponentStatusFB(XrStructureType type, void* next, int enabled, int changePending)
        {
            this.type = type;
            this.next = next;
            this.enabled = enabled;
            this.changePending = changePending;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity]</b> Used by <see cref="Xr.SetSpaceComponentStatusFB"/></summary>
    public unsafe struct XrSpaceComponentStatusSetInfoFB
    {
        public XrStructureType type = XrStructureType.TypeSpaceComponentStatusSetInfoFb;
        public void* next;
        public XrSpaceComponentTypeFB componentType;
        public int enabled;
        public long timeout;
        public XrSpaceComponentStatusSetInfoFB() { }
        public XrSpaceComponentStatusSetInfoFB(XrStructureType type, void* next, XrSpaceComponentTypeFB componentType, int enabled, long timeout)
        {
            this.type = type;
            this.next = next;
            this.componentType = componentType;
            this.enabled = enabled;
            this.timeout = timeout;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_container]</b> Used by <see cref="Xr.GetSpaceContainerFB"/></summary>
    public unsafe struct XrSpaceContainerFB
    {
        public XrStructureType type = XrStructureType.TypeSpaceContainerFb;
        public void* next;
        public uint uuidCapacityInput;
        public uint uuidCountOutput;
        public XrUuid* uuids;
        public XrSpaceContainerFB() { }
        public XrSpaceContainerFB(XrStructureType type, void* next, uint uuidCapacityInput, uint uuidCountOutput, XrUuid* uuids)
        {
            this.type = type;
            this.next = next;
            this.uuidCapacityInput = uuidCapacityInput;
            this.uuidCountOutput = uuidCountOutput;
            this.uuids = uuids;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_storage]</b> Used by <see cref="Xr.EraseSpaceFB"/></summary>
    public unsafe struct XrSpaceEraseInfoFB
    {
        public XrStructureType type = XrStructureType.TypeSpaceEraseInfoFb;
        public void* next;
        public XrSpace space;
        public XrSpaceStorageLocationFB location;
        public XrSpaceEraseInfoFB() { }
        public XrSpaceEraseInfoFB(XrStructureType type, void* next, XrSpace space, XrSpaceStorageLocationFB location)
        {
            this.type = type;
            this.next = next;
            this.space = space;
            this.location = location;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_query]</b> </summary>
    public unsafe struct XrSpaceFilterInfoBaseHeaderFB
    {
        public XrStructureType type;
        public void* next;
        public XrSpaceFilterInfoBaseHeaderFB() { }
        public XrSpaceFilterInfoBaseHeaderFB(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_META_spatial_entity_group_sharing]</b> </summary>
    public unsafe struct XrSpaceGroupUuidFilterInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeSpaceGroupUuidFilterInfoMeta;
        public void* next;
        public XrUuid groupUuid;
        public XrSpaceGroupUuidFilterInfoMETA() { }
        public XrSpaceGroupUuidFilterInfoMETA(XrStructureType type, void* next, XrUuid groupUuid)
        {
            this.type = type;
            this.next = next;
            this.groupUuid = groupUuid;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_storage_batch]</b> Used by <see cref="Xr.SaveSpaceListFB"/></summary>
    public unsafe struct XrSpaceListSaveInfoFB
    {
        public XrStructureType type = XrStructureType.TypeSpaceListSaveInfoFb;
        public void* next;
        public uint spaceCount;
        public XrSpace* spaces;
        public XrSpaceStorageLocationFB location;
        public XrSpaceListSaveInfoFB() { }
        public XrSpaceListSaveInfoFB(XrStructureType type, void* next, uint spaceCount, XrSpace* spaces, XrSpaceStorageLocationFB location)
        {
            this.type = type;
            this.next = next;
            this.spaceCount = spaceCount;
            this.spaces = spaces;
            this.location = location;
        }
    }
    /// <summary>Used by <see cref="Xr.LocateSpace"/></summary>
    public unsafe struct XrSpaceLocation
    {
        public XrStructureType type = XrStructureType.TypeSpaceLocation;
        public void* next;
        public XrSpaceLocationFlagBits locationFlags;
        public XrPosef pose;
        public XrSpaceLocation() { }
        public XrSpaceLocation(XrStructureType type, void* next, XrSpaceLocationFlagBits locationFlags, XrPosef pose)
        {
            this.type = type;
            this.next = next;
            this.locationFlags = locationFlags;
            this.pose = pose;
        }
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    public unsafe struct XrSpaceLocationData
    {
        public XrSpaceLocationFlagBits locationFlags;
        public XrPosef pose;
        public XrSpaceLocationData() { }
        public XrSpaceLocationData(XrSpaceLocationFlagBits locationFlags, XrPosef pose)
        {
            this.locationFlags = locationFlags;
            this.pose = pose;
        }
    }
    /// <summary><b>[requires: XR_KHR_locate_spaces]</b> </summary>
    public unsafe struct XrSpaceLocationDataKHR
    {
        public XrSpaceLocationFlagBits locationFlags;
        public XrPosef pose;
        public XrSpaceLocationDataKHR() { }
        public XrSpaceLocationDataKHR(XrSpaceLocationFlagBits locationFlags, XrPosef pose)
        {
            this.locationFlags = locationFlags;
            this.pose = pose;
        }
    }
    /// <summary><b>[requires: v1.1]</b> Used by <see cref="Xr.LocateSpaces"/>, <see cref="Xr.LocateSpacesKHR"/></summary>
    public unsafe struct XrSpaceLocations
    {
        public XrStructureType type = XrStructureType.TypeSpaceLocations;
        public void* next;
        public uint locationCount;
        public XrSpaceLocationData* locations;
        public XrSpaceLocations() { }
        public XrSpaceLocations(XrStructureType type, void* next, uint locationCount, XrSpaceLocationData* locations)
        {
            this.type = type;
            this.next = next;
            this.locationCount = locationCount;
            this.locations = locations;
        }
    }
    /// <summary><b>[requires: XR_KHR_locate_spaces]</b> </summary>
    public unsafe struct XrSpaceLocationsKHR
    {
        public XrStructureType type = XrStructureType.TypeSpaceLocations;
        public void* next;
        public uint locationCount;
        public XrSpaceLocationData* locations;
        public XrSpaceLocationsKHR() { }
        public XrSpaceLocationsKHR(XrStructureType type, void* next, uint locationCount, XrSpaceLocationData* locations)
        {
            this.type = type;
            this.next = next;
            this.locationCount = locationCount;
            this.locations = locations;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_query]</b> Used by <see cref="Xr.QuerySpacesFB"/></summary>
    public unsafe struct XrSpaceQueryInfoBaseHeaderFB
    {
        public XrStructureType type;
        public void* next;
        public XrSpaceQueryInfoBaseHeaderFB() { }
        public XrSpaceQueryInfoBaseHeaderFB(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_query]</b> </summary>
    public unsafe struct XrSpaceQueryInfoFB
    {
        public XrStructureType type = XrStructureType.TypeSpaceQueryInfoFb;
        public void* next;
        public XrSpaceQueryActionFB queryAction;
        public uint maxResultCount;
        public long timeout;
        public XrSpaceFilterInfoBaseHeaderFB* filter;
        public XrSpaceFilterInfoBaseHeaderFB* excludeFilter;
        public XrSpaceQueryInfoFB() { }
        public XrSpaceQueryInfoFB(XrStructureType type, void* next, XrSpaceQueryActionFB queryAction, uint maxResultCount, long timeout, XrSpaceFilterInfoBaseHeaderFB* filter, XrSpaceFilterInfoBaseHeaderFB* excludeFilter)
        {
            this.type = type;
            this.next = next;
            this.queryAction = queryAction;
            this.maxResultCount = maxResultCount;
            this.timeout = timeout;
            this.filter = filter;
            this.excludeFilter = excludeFilter;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_query]</b> </summary>
    public unsafe struct XrSpaceQueryResultFB
    {
        public XrSpace space;
        public XrUuid uuid;
        public XrSpaceQueryResultFB() { }
        public XrSpaceQueryResultFB(XrSpace space, XrUuid uuid)
        {
            this.space = space;
            this.uuid = uuid;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_query]</b> Used by <see cref="Xr.RetrieveSpaceQueryResultsFB"/></summary>
    public unsafe struct XrSpaceQueryResultsFB
    {
        public XrStructureType type = XrStructureType.TypeSpaceQueryResultsFb;
        public void* next;
        public uint resultCapacityInput;
        public uint resultCountOutput;
        public XrSpaceQueryResultFB* results;
        public XrSpaceQueryResultsFB() { }
        public XrSpaceQueryResultsFB(XrStructureType type, void* next, uint resultCapacityInput, uint resultCountOutput, XrSpaceQueryResultFB* results)
        {
            this.type = type;
            this.next = next;
            this.resultCapacityInput = resultCapacityInput;
            this.resultCountOutput = resultCountOutput;
            this.results = results;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_storage]</b> Used by <see cref="Xr.SaveSpaceFB"/></summary>
    public unsafe struct XrSpaceSaveInfoFB
    {
        public XrStructureType type = XrStructureType.TypeSpaceSaveInfoFb;
        public void* next;
        public XrSpace space;
        public XrSpaceStorageLocationFB location;
        public XrSpacePersistenceModeFB persistenceMode;
        public XrSpaceSaveInfoFB() { }
        public XrSpaceSaveInfoFB(XrStructureType type, void* next, XrSpace space, XrSpaceStorageLocationFB location, XrSpacePersistenceModeFB persistenceMode)
        {
            this.type = type;
            this.next = next;
            this.space = space;
            this.location = location;
            this.persistenceMode = persistenceMode;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_sharing]</b> Used by <see cref="Xr.ShareSpacesFB"/></summary>
    public unsafe struct XrSpaceShareInfoFB
    {
        public XrStructureType type = XrStructureType.TypeSpaceShareInfoFb;
        public void* next;
        public uint spaceCount;
        public XrSpace* spaces;
        public uint userCount;
        public XrSpaceUserFB* users;
        public XrSpaceShareInfoFB() { }
        public XrSpaceShareInfoFB(XrStructureType type, void* next, uint spaceCount, XrSpace* spaces, uint userCount, XrSpaceUserFB* users)
        {
            this.type = type;
            this.next = next;
            this.spaceCount = spaceCount;
            this.spaces = spaces;
            this.userCount = userCount;
            this.users = users;
        }
    }
    /// <summary><b>[requires: v1.1]</b> Used by <see cref="Xr.LocateSpaces"/>, <see cref="Xr.LocateSpacesKHR"/></summary>
    public unsafe struct XrSpacesLocateInfo
    {
        public XrStructureType type = XrStructureType.TypeSpacesLocateInfo;
        public void* next;
        public XrSpace baseSpace;
        public long time;
        public uint spaceCount;
        public XrSpace* spaces;
        public XrSpacesLocateInfo() { }
        public XrSpacesLocateInfo(XrStructureType type, void* next, XrSpace baseSpace, long time, uint spaceCount, XrSpace* spaces)
        {
            this.type = type;
            this.next = next;
            this.baseSpace = baseSpace;
            this.time = time;
            this.spaceCount = spaceCount;
            this.spaces = spaces;
        }
    }
    /// <summary><b>[requires: XR_KHR_locate_spaces]</b> </summary>
    public unsafe struct XrSpacesLocateInfoKHR
    {
        public XrStructureType type = XrStructureType.TypeSpacesLocateInfo;
        public void* next;
        public XrSpace baseSpace;
        public long time;
        public uint spaceCount;
        public XrSpace* spaces;
        public XrSpacesLocateInfoKHR() { }
        public XrSpacesLocateInfoKHR(XrStructureType type, void* next, XrSpace baseSpace, long time, uint spaceCount, XrSpace* spaces)
        {
            this.type = type;
            this.next = next;
            this.baseSpace = baseSpace;
            this.time = time;
            this.spaceCount = spaceCount;
            this.spaces = spaces;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_query]</b> </summary>
    public unsafe struct XrSpaceStorageLocationFilterInfoFB
    {
        public XrStructureType type = XrStructureType.TypeSpaceStorageLocationFilterInfoFb;
        public void* next;
        public XrSpaceStorageLocationFB location;
        public XrSpaceStorageLocationFilterInfoFB() { }
        public XrSpaceStorageLocationFilterInfoFB(XrStructureType type, void* next, XrSpaceStorageLocationFB location)
        {
            this.type = type;
            this.next = next;
            this.location = location;
        }
    }
    /// <summary><b>[requires: XR_META_spatial_entity_mesh]</b> Used by <see cref="Xr.GetSpaceTriangleMeshMETA"/></summary>
    public unsafe struct XrSpaceTriangleMeshGetInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeSpaceTriangleMeshGetInfoMeta;
        public void* next;
        public XrSpaceTriangleMeshGetInfoMETA() { }
        public XrSpaceTriangleMeshGetInfoMETA(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_META_spatial_entity_mesh]</b> Used by <see cref="Xr.GetSpaceTriangleMeshMETA"/></summary>
    public unsafe struct XrSpaceTriangleMeshMETA
    {
        public XrStructureType type = XrStructureType.TypeSpaceTriangleMeshMeta;
        public void* next;
        public uint vertexCapacityInput;
        public uint vertexCountOutput;
        public XrVector3f* vertices;
        public uint indexCapacityInput;
        public uint indexCountOutput;
        public uint* indices;
        public XrSpaceTriangleMeshMETA() { }
        public XrSpaceTriangleMeshMETA(XrStructureType type, void* next, uint vertexCapacityInput, uint vertexCountOutput, XrVector3f* vertices, uint indexCapacityInput, uint indexCountOutput, uint* indices)
        {
            this.type = type;
            this.next = next;
            this.vertexCapacityInput = vertexCapacityInput;
            this.vertexCountOutput = vertexCountOutput;
            this.vertices = vertices;
            this.indexCapacityInput = indexCapacityInput;
            this.indexCountOutput = indexCountOutput;
            this.indices = indices;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_user]</b> Used by <see cref="Xr.CreateSpaceUserFB"/></summary>
    public unsafe struct XrSpaceUserCreateInfoFB
    {
        public XrStructureType type = XrStructureType.TypeSpaceUserCreateInfoFb;
        public void* next;
        public ulong userId;
        public XrSpaceUserCreateInfoFB() { }
        public XrSpaceUserCreateInfoFB(XrStructureType type, void* next, ulong userId)
        {
            this.type = type;
            this.next = next;
            this.userId = userId;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity_query]</b> </summary>
    public unsafe struct XrSpaceUuidFilterInfoFB
    {
        public XrStructureType type = XrStructureType.TypeSpaceUuidFilterInfoFb;
        public void* next;
        public uint uuidCount;
        public XrUuid* uuids;
        public XrSpaceUuidFilterInfoFB() { }
        public XrSpaceUuidFilterInfoFB(XrStructureType type, void* next, uint uuidCount, XrUuid* uuids)
        {
            this.type = type;
            this.next = next;
            this.uuidCount = uuidCount;
            this.uuids = uuids;
        }
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    public unsafe struct XrSpaceVelocities
    {
        public XrStructureType type = XrStructureType.TypeSpaceVelocities;
        public void* next;
        public uint velocityCount;
        public XrSpaceVelocityData* velocities;
        public XrSpaceVelocities() { }
        public XrSpaceVelocities(XrStructureType type, void* next, uint velocityCount, XrSpaceVelocityData* velocities)
        {
            this.type = type;
            this.next = next;
            this.velocityCount = velocityCount;
            this.velocities = velocities;
        }
    }
    /// <summary><b>[requires: XR_KHR_locate_spaces]</b> </summary>
    public unsafe struct XrSpaceVelocitiesKHR
    {
        public XrStructureType type = XrStructureType.TypeSpaceVelocities;
        public void* next;
        public uint velocityCount;
        public XrSpaceVelocityData* velocities;
        public XrSpaceVelocitiesKHR() { }
        public XrSpaceVelocitiesKHR(XrStructureType type, void* next, uint velocityCount, XrSpaceVelocityData* velocities)
        {
            this.type = type;
            this.next = next;
            this.velocityCount = velocityCount;
            this.velocities = velocities;
        }
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    public unsafe struct XrSpaceVelocity
    {
        public XrStructureType type = XrStructureType.TypeSpaceVelocity;
        public void* next;
        public XrSpaceVelocityFlagBits velocityFlags;
        public XrVector3f linearVelocity;
        public XrVector3f angularVelocity;
        public XrSpaceVelocity() { }
        public XrSpaceVelocity(XrStructureType type, void* next, XrSpaceVelocityFlagBits velocityFlags, XrVector3f linearVelocity, XrVector3f angularVelocity)
        {
            this.type = type;
            this.next = next;
            this.velocityFlags = velocityFlags;
            this.linearVelocity = linearVelocity;
            this.angularVelocity = angularVelocity;
        }
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    public unsafe struct XrSpaceVelocityData
    {
        public XrSpaceVelocityFlagBits velocityFlags;
        public XrVector3f linearVelocity;
        public XrVector3f angularVelocity;
        public XrSpaceVelocityData() { }
        public XrSpaceVelocityData(XrSpaceVelocityFlagBits velocityFlags, XrVector3f linearVelocity, XrVector3f angularVelocity)
        {
            this.velocityFlags = velocityFlags;
            this.linearVelocity = linearVelocity;
            this.angularVelocity = angularVelocity;
        }
    }
    /// <summary><b>[requires: XR_KHR_locate_spaces]</b> </summary>
    public unsafe struct XrSpaceVelocityDataKHR
    {
        public XrSpaceVelocityFlagBits velocityFlags;
        public XrVector3f linearVelocity;
        public XrVector3f angularVelocity;
        public XrSpaceVelocityDataKHR() { }
        public XrSpaceVelocityDataKHR(XrSpaceVelocityFlagBits velocityFlags, XrVector3f linearVelocity, XrVector3f angularVelocity)
        {
            this.velocityFlags = velocityFlags;
            this.linearVelocity = linearVelocity;
            this.angularVelocity = angularVelocity;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> </summary>
    public unsafe struct XrSpatialAnchorCompletionResultML
    {
        public XrUuid uuid;
        public XrResult result;
        public XrSpatialAnchorCompletionResultML() { }
        public XrSpatialAnchorCompletionResultML(XrUuid uuid, XrResult result)
        {
            this.uuid = uuid;
            this.result = result;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity]</b> Used by <see cref="Xr.CreateSpatialAnchorFB"/></summary>
    public unsafe struct XrSpatialAnchorCreateInfoFB
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorCreateInfoFb;
        public void* next;
        public XrSpace space;
        public XrPosef poseInSpace;
        public long time;
        public XrSpatialAnchorCreateInfoFB() { }
        public XrSpatialAnchorCreateInfoFB(XrStructureType type, void* next, XrSpace space, XrPosef poseInSpace, long time)
        {
            this.type = type;
            this.next = next;
            this.space = space;
            this.poseInSpace = poseInSpace;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_HTC_anchor]</b> Used by <see cref="Xr.CreateSpatialAnchorHTC"/></summary>
    public unsafe struct XrSpatialAnchorCreateInfoHTC
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorCreateInfoHtc;
        public void* next;
        public XrSpace space;
        public XrPosef poseInSpace;
        public XrSpatialAnchorNameHTC name;
        public XrSpatialAnchorCreateInfoHTC() { }
        public XrSpatialAnchorCreateInfoHTC(XrStructureType type, void* next, XrSpace space, XrPosef poseInSpace, XrSpatialAnchorNameHTC name)
        {
            this.type = type;
            this.next = next;
            this.space = space;
            this.poseInSpace = poseInSpace;
            this.name = name;
        }
    }
    /// <summary>Used by <see cref="Xr.CreateSpatialAnchorMSFT"/></summary>
    public unsafe struct XrSpatialAnchorCreateInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorCreateInfoMsft;
        public void* next;
        public XrSpace space;
        public XrPosef pose;
        public long time;
        public XrSpatialAnchorCreateInfoMSFT() { }
        public XrSpatialAnchorCreateInfoMSFT(XrStructureType type, void* next, XrSpace space, XrPosef pose, long time)
        {
            this.type = type;
            this.next = next;
            this.space = space;
            this.pose = pose;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_MSFT_spatial_anchor_persistence]</b> Used by <see cref="Xr.CreateSpatialAnchorFromPersistedNameMSFT"/></summary>
    public unsafe struct XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorFromPersistedAnchorCreateInfoMsft;
        public void* next;
        public XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore;
        public XrSpatialAnchorPersistenceNameMSFT spatialAnchorPersistenceName;
        public XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT() { }
        public XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT(XrStructureType type, void* next, XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceNameMSFT spatialAnchorPersistenceName)
        {
            this.type = type;
            this.next = next;
            this.spatialAnchorStore = spatialAnchorStore;
            this.spatialAnchorPersistenceName = spatialAnchorPersistenceName;
        }
    }
    /// <summary><b>[requires: XR_HTC_anchor]</b> Used by <see cref="Xr.GetSpatialAnchorNameHTC"/></summary>
    public unsafe struct XrSpatialAnchorNameHTC
    {
        [InlineArray(256)]
        public struct nameInlineArray1
        {
            public byte element;
        }
        public nameInlineArray1 name;
        public XrSpatialAnchorNameHTC() { }
    }
    /// <summary><b>[requires: XR_MSFT_spatial_anchor_persistence]</b> Used by <see cref="Xr.PersistSpatialAnchorMSFT"/></summary>
    public unsafe struct XrSpatialAnchorPersistenceInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorPersistenceInfoMsft;
        public void* next;
        public XrSpatialAnchorPersistenceNameMSFT spatialAnchorPersistenceName;
        public XrSpatialAnchorMSFT spatialAnchor;
        public XrSpatialAnchorPersistenceInfoMSFT() { }
        public XrSpatialAnchorPersistenceInfoMSFT(XrStructureType type, void* next, XrSpatialAnchorPersistenceNameMSFT spatialAnchorPersistenceName, XrSpatialAnchorMSFT spatialAnchor)
        {
            this.type = type;
            this.next = next;
            this.spatialAnchorPersistenceName = spatialAnchorPersistenceName;
            this.spatialAnchor = spatialAnchor;
        }
    }
    /// <summary><b>[requires: XR_MSFT_spatial_anchor_persistence]</b> Used by <see cref="Xr.EnumeratePersistedSpatialAnchorNamesMSFT"/>, <see cref="Xr.UnpersistSpatialAnchorMSFT"/></summary>
    public unsafe struct XrSpatialAnchorPersistenceNameMSFT
    {
        [InlineArray(256)]
        public struct nameInlineArray1
        {
            public byte element;
        }
        public nameInlineArray1 name;
        public XrSpatialAnchorPersistenceNameMSFT() { }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors]</b> Used by <see cref="Xr.CreateSpatialAnchorsAsyncML"/></summary>
    public unsafe struct XrSpatialAnchorsCreateInfoBaseHeaderML
    {
        public XrStructureType type;
        public void* next;
        public XrSpatialAnchorsCreateInfoBaseHeaderML() { }
        public XrSpatialAnchorsCreateInfoBaseHeaderML(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors]</b> </summary>
    public unsafe struct XrSpatialAnchorsCreateInfoFromPoseML
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorsCreateInfoFromPoseMl;
        public void* next;
        public XrSpace baseSpace;
        public XrPosef poseInBaseSpace;
        public long time;
        public XrSpatialAnchorsCreateInfoFromPoseML() { }
        public XrSpatialAnchorsCreateInfoFromPoseML(XrStructureType type, void* next, XrSpace baseSpace, XrPosef poseInBaseSpace, long time)
        {
            this.type = type;
            this.next = next;
            this.baseSpace = baseSpace;
            this.poseInBaseSpace = poseInBaseSpace;
            this.time = time;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> </summary>
    public unsafe struct XrSpatialAnchorsCreateInfoFromUuidsML
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorsCreateInfoFromUuidsMl;
        public void* next;
        public XrSpatialAnchorsStorageML storage;
        public uint uuidCount;
        public XrUuid* uuids;
        public XrSpatialAnchorsCreateInfoFromUuidsML() { }
        public XrSpatialAnchorsCreateInfoFromUuidsML(XrStructureType type, void* next, XrSpatialAnchorsStorageML storage, uint uuidCount, XrUuid* uuids)
        {
            this.type = type;
            this.next = next;
            this.storage = storage;
            this.uuidCount = uuidCount;
            this.uuids = uuids;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> Used by <see cref="Xr.CreateSpatialAnchorsStorageML"/></summary>
    public unsafe struct XrSpatialAnchorsCreateStorageInfoML
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorsCreateStorageInfoMl;
        public void* next;
        public XrSpatialAnchorsCreateStorageInfoML() { }
        public XrSpatialAnchorsCreateStorageInfoML(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> </summary>
    public unsafe struct XrSpatialAnchorsDeleteCompletionDetailsML
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorsDeleteCompletionDetailsMl;
        public void* next;
        public uint resultCount;
        public XrSpatialAnchorCompletionResultML* results;
        public XrSpatialAnchorsDeleteCompletionDetailsML() { }
        public XrSpatialAnchorsDeleteCompletionDetailsML(XrStructureType type, void* next, uint resultCount, XrSpatialAnchorCompletionResultML* results)
        {
            this.type = type;
            this.next = next;
            this.resultCount = resultCount;
            this.results = results;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> Used by <see cref="Xr.DeleteSpatialAnchorsCompleteML"/></summary>
    public unsafe struct XrSpatialAnchorsDeleteCompletionML
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorsDeleteCompletionMl;
        public void* next;
        public XrResult futureResult;
        public XrSpatialAnchorsDeleteCompletionML() { }
        public XrSpatialAnchorsDeleteCompletionML(XrStructureType type, void* next, XrResult futureResult)
        {
            this.type = type;
            this.next = next;
            this.futureResult = futureResult;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> Used by <see cref="Xr.DeleteSpatialAnchorsAsyncML"/></summary>
    public unsafe struct XrSpatialAnchorsDeleteInfoML
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorsDeleteInfoMl;
        public void* next;
        public uint uuidCount;
        public XrUuid* uuids;
        public XrSpatialAnchorsDeleteInfoML() { }
        public XrSpatialAnchorsDeleteInfoML(XrStructureType type, void* next, uint uuidCount, XrUuid* uuids)
        {
            this.type = type;
            this.next = next;
            this.uuidCount = uuidCount;
            this.uuids = uuids;
        }
    }
    /// <summary>Used by <see cref="Xr.CreateSpatialAnchorSpaceMSFT"/></summary>
    public unsafe struct XrSpatialAnchorSpaceCreateInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorSpaceCreateInfoMsft;
        public void* next;
        public XrSpatialAnchorMSFT anchor;
        public XrPosef poseInAnchorSpace;
        public XrSpatialAnchorSpaceCreateInfoMSFT() { }
        public XrSpatialAnchorSpaceCreateInfoMSFT(XrStructureType type, void* next, XrSpatialAnchorMSFT anchor, XrPosef poseInAnchorSpace)
        {
            this.type = type;
            this.next = next;
            this.anchor = anchor;
            this.poseInAnchorSpace = poseInAnchorSpace;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> </summary>
    public unsafe struct XrSpatialAnchorsPublishCompletionDetailsML
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorsPublishCompletionDetailsMl;
        public void* next;
        public uint resultCount;
        public XrSpatialAnchorCompletionResultML* results;
        public XrSpatialAnchorsPublishCompletionDetailsML() { }
        public XrSpatialAnchorsPublishCompletionDetailsML(XrStructureType type, void* next, uint resultCount, XrSpatialAnchorCompletionResultML* results)
        {
            this.type = type;
            this.next = next;
            this.resultCount = resultCount;
            this.results = results;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> Used by <see cref="Xr.PublishSpatialAnchorsCompleteML"/></summary>
    public unsafe struct XrSpatialAnchorsPublishCompletionML
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorsPublishCompletionMl;
        public void* next;
        public XrResult futureResult;
        public uint uuidCount;
        public XrUuid* uuids;
        public XrSpatialAnchorsPublishCompletionML() { }
        public XrSpatialAnchorsPublishCompletionML(XrStructureType type, void* next, XrResult futureResult, uint uuidCount, XrUuid* uuids)
        {
            this.type = type;
            this.next = next;
            this.futureResult = futureResult;
            this.uuidCount = uuidCount;
            this.uuids = uuids;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> Used by <see cref="Xr.PublishSpatialAnchorsAsyncML"/></summary>
    public unsafe struct XrSpatialAnchorsPublishInfoML
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorsPublishInfoMl;
        public void* next;
        public uint anchorCount;
        public XrSpace* anchors;
        public ulong expiration;
        public XrSpatialAnchorsPublishInfoML() { }
        public XrSpatialAnchorsPublishInfoML(XrStructureType type, void* next, uint anchorCount, XrSpace* anchors, ulong expiration)
        {
            this.type = type;
            this.next = next;
            this.anchorCount = anchorCount;
            this.anchors = anchors;
            this.expiration = expiration;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> Used by <see cref="Xr.QuerySpatialAnchorsCompleteML"/></summary>
    public unsafe struct XrSpatialAnchorsQueryCompletionML
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorsQueryCompletionMl;
        public void* next;
        public XrResult futureResult;
        public uint uuidCapacityInput;
        public uint uuidCountOutput;
        public XrUuid* uuids;
        public XrSpatialAnchorsQueryCompletionML() { }
        public XrSpatialAnchorsQueryCompletionML(XrStructureType type, void* next, XrResult futureResult, uint uuidCapacityInput, uint uuidCountOutput, XrUuid* uuids)
        {
            this.type = type;
            this.next = next;
            this.futureResult = futureResult;
            this.uuidCapacityInput = uuidCapacityInput;
            this.uuidCountOutput = uuidCountOutput;
            this.uuids = uuids;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> Used by <see cref="Xr.QuerySpatialAnchorsAsyncML"/></summary>
    public unsafe struct XrSpatialAnchorsQueryInfoBaseHeaderML
    {
        public XrStructureType type;
        public void* next;
        public XrSpatialAnchorsQueryInfoBaseHeaderML() { }
        public XrSpatialAnchorsQueryInfoBaseHeaderML(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> </summary>
    public unsafe struct XrSpatialAnchorsQueryInfoRadiusML
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorsQueryInfoRadiusMl;
        public void* next;
        public XrSpace baseSpace;
        public XrVector3f center;
        public long time;
        public float radius;
        public XrSpatialAnchorsQueryInfoRadiusML() { }
        public XrSpatialAnchorsQueryInfoRadiusML(XrStructureType type, void* next, XrSpace baseSpace, XrVector3f center, long time, float radius)
        {
            this.type = type;
            this.next = next;
            this.baseSpace = baseSpace;
            this.center = center;
            this.time = time;
            this.radius = radius;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors]</b> Used by <see cref="Xr.GetSpatialAnchorStateML"/></summary>
    public unsafe struct XrSpatialAnchorStateML
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorStateMl;
        public void* next;
        public XrSpatialAnchorConfidenceML confidence;
        public XrSpatialAnchorStateML() { }
        public XrSpatialAnchorStateML(XrStructureType type, void* next, XrSpatialAnchorConfidenceML confidence)
        {
            this.type = type;
            this.next = next;
            this.confidence = confidence;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> </summary>
    public unsafe struct XrSpatialAnchorsUpdateExpirationCompletionDetailsML
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorsUpdateExpirationCompletionDetailsMl;
        public void* next;
        public uint resultCount;
        public XrSpatialAnchorCompletionResultML* results;
        public XrSpatialAnchorsUpdateExpirationCompletionDetailsML() { }
        public XrSpatialAnchorsUpdateExpirationCompletionDetailsML(XrStructureType type, void* next, uint resultCount, XrSpatialAnchorCompletionResultML* results)
        {
            this.type = type;
            this.next = next;
            this.resultCount = resultCount;
            this.results = results;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> Used by <see cref="Xr.UpdateSpatialAnchorsExpirationCompleteML"/></summary>
    public unsafe struct XrSpatialAnchorsUpdateExpirationCompletionML
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorsUpdateExpirationCompletionMl;
        public void* next;
        public XrResult futureResult;
        public XrSpatialAnchorsUpdateExpirationCompletionML() { }
        public XrSpatialAnchorsUpdateExpirationCompletionML(XrStructureType type, void* next, XrResult futureResult)
        {
            this.type = type;
            this.next = next;
            this.futureResult = futureResult;
        }
    }
    /// <summary><b>[requires: XR_ML_spatial_anchors_storage]</b> Used by <see cref="Xr.UpdateSpatialAnchorsExpirationAsyncML"/></summary>
    public unsafe struct XrSpatialAnchorsUpdateExpirationInfoML
    {
        public XrStructureType type = XrStructureType.TypeSpatialAnchorsUpdateExpirationInfoMl;
        public void* next;
        public uint uuidCount;
        public XrUuid* uuids;
        public ulong expiration;
        public XrSpatialAnchorsUpdateExpirationInfoML() { }
        public XrSpatialAnchorsUpdateExpirationInfoML(XrStructureType type, void* next, uint uuidCount, XrUuid* uuids, ulong expiration)
        {
            this.type = type;
            this.next = next;
            this.uuidCount = uuidCount;
            this.uuids = uuids;
            this.expiration = expiration;
        }
    }
    /// <summary><b>[requires: XR_MSFT_spatial_graph_bridge]</b> Used by <see cref="Xr.GetSpatialGraphNodeBindingPropertiesMSFT"/></summary>
    public unsafe struct XrSpatialGraphNodeBindingPropertiesGetInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSpatialGraphNodeBindingPropertiesGetInfoMsft;
        public void* next;
        public XrSpatialGraphNodeBindingPropertiesGetInfoMSFT() { }
        public XrSpatialGraphNodeBindingPropertiesGetInfoMSFT(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_MSFT_spatial_graph_bridge]</b> Used by <see cref="Xr.GetSpatialGraphNodeBindingPropertiesMSFT"/></summary>
    public unsafe struct XrSpatialGraphNodeBindingPropertiesMSFT
    {
        public XrStructureType type = XrStructureType.TypeSpatialGraphNodeBindingPropertiesMsft;
        public void* next;
        public fixed byte nodeId[16];
        public XrPosef poseInNodeSpace;
        public XrSpatialGraphNodeBindingPropertiesMSFT() { }
    }
    /// <summary><b>[requires: XR_MSFT_spatial_graph_bridge]</b> Used by <see cref="Xr.CreateSpatialGraphNodeSpaceMSFT"/></summary>
    public unsafe struct XrSpatialGraphNodeSpaceCreateInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSpatialGraphNodeSpaceCreateInfoMsft;
        public void* next;
        public XrSpatialGraphNodeTypeMSFT nodeType;
        public fixed byte nodeId[16];
        public XrPosef pose;
        public XrSpatialGraphNodeSpaceCreateInfoMSFT() { }
    }
    /// <summary><b>[requires: XR_MSFT_spatial_graph_bridge]</b> Used by <see cref="Xr.TryCreateSpatialGraphStaticNodeBindingMSFT"/></summary>
    public unsafe struct XrSpatialGraphStaticNodeBindingCreateInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeSpatialGraphStaticNodeBindingCreateInfoMsft;
        public void* next;
        public XrSpace space;
        public XrPosef poseInSpace;
        public long time;
        public XrSpatialGraphStaticNodeBindingCreateInfoMSFT() { }
        public XrSpatialGraphStaticNodeBindingCreateInfoMSFT(XrStructureType type, void* next, XrSpace space, XrPosef poseInSpace, long time)
        {
            this.type = type;
            this.next = next;
            this.space = space;
            this.poseInSpace = poseInSpace;
            this.time = time;
        }
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    public unsafe struct XrSpheref
    {
        public XrPosef center;
        public float radius;
        public XrSpheref() { }
        public XrSpheref(XrPosef center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }
    }
    /// <summary><b>[requires: XR_KHR_maintenance1]</b> </summary>
    public unsafe struct XrSpherefKHR
    {
        public XrPosef center;
        public float radius;
        public XrSpherefKHR() { }
        public XrSpherefKHR(XrPosef center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }
    }
    /// <summary>Used by <see cref="Xr.CreateSwapchain"/>, <see cref="Xr.CreateSwapchainAndroidSurfaceKHR"/></summary>
    public unsafe struct XrSwapchainCreateInfo
    {
        public XrStructureType type = XrStructureType.TypeSwapchainCreateInfo;
        public void* next;
        public XrSwapchainCreateFlagBits createFlags;
        public XrSwapchainUsageFlagBits usageFlags;
        public long format;
        public uint sampleCount;
        public uint width;
        public uint height;
        public uint faceCount;
        public uint arraySize;
        public uint mipCount;
        public XrSwapchainCreateInfo() { }
        public XrSwapchainCreateInfo(XrStructureType type, void* next, XrSwapchainCreateFlagBits createFlags, XrSwapchainUsageFlagBits usageFlags, long format, uint sampleCount, uint width, uint height, uint faceCount, uint arraySize, uint mipCount)
        {
            this.type = type;
            this.next = next;
            this.createFlags = createFlags;
            this.usageFlags = usageFlags;
            this.format = format;
            this.sampleCount = sampleCount;
            this.width = width;
            this.height = height;
            this.faceCount = faceCount;
            this.arraySize = arraySize;
            this.mipCount = mipCount;
        }
    }
    /// <summary><b>[requires: XR_FB_foveation]</b> </summary>
    public unsafe struct XrSwapchainCreateInfoFoveationFB
    {
        public XrStructureType type = XrStructureType.TypeSwapchainCreateInfoFoveationFb;
        public void* next;
        public XrSwapchainCreateFoveationFlagBitsFB flags;
        public XrSwapchainCreateInfoFoveationFB() { }
        public XrSwapchainCreateInfoFoveationFB(XrStructureType type, void* next, XrSwapchainCreateFoveationFlagBitsFB flags)
        {
            this.type = type;
            this.next = next;
            this.flags = flags;
        }
    }
    /// <summary>Used by <see cref="Xr.AcquireSwapchainImage"/></summary>
    public unsafe struct XrSwapchainImageAcquireInfo
    {
        public XrStructureType type = XrStructureType.TypeSwapchainImageAcquireInfo;
        public void* next;
        public XrSwapchainImageAcquireInfo() { }
        public XrSwapchainImageAcquireInfo(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary>Used by <see cref="Xr.EnumerateEnvironmentDepthSwapchainImagesMETA"/>, <see cref="Xr.EnumerateSwapchainImages"/></summary>
    public unsafe struct XrSwapchainImageBaseHeader
    {
        public XrStructureType type;
        public void* next;
        public XrSwapchainImageBaseHeader() { }
        public XrSwapchainImageBaseHeader(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_KHR_D3D11_enable]</b> </summary>
    public unsafe struct XrSwapchainImageD3D11KHR
    {
        public XrStructureType type = XrStructureType.TypeSwapchainImageD3d11Khr;
        public void* next;
        public IntPtr* texture;
        public XrSwapchainImageD3D11KHR() { }
        public XrSwapchainImageD3D11KHR(XrStructureType type, void* next, IntPtr* texture)
        {
            this.type = type;
            this.next = next;
            this.texture = texture;
        }
    }
    /// <summary><b>[requires: XR_KHR_D3D12_enable]</b> </summary>
    public unsafe struct XrSwapchainImageD3D12KHR
    {
        public XrStructureType type = XrStructureType.TypeSwapchainImageD3d12Khr;
        public void* next;
        public IntPtr* texture;
        public XrSwapchainImageD3D12KHR() { }
        public XrSwapchainImageD3D12KHR(XrStructureType type, void* next, IntPtr* texture)
        {
            this.type = type;
            this.next = next;
            this.texture = texture;
        }
    }
    /// <summary><b>[requires: XR_FB_foveation_vulkan]</b> </summary>
    public unsafe struct XrSwapchainImageFoveationVulkanFB
    {
        public XrStructureType type = XrStructureType.TypeSwapchainImageFoveationVulkanFb;
        public void* next;
        public VkImage image;
        public uint width;
        public uint height;
        public XrSwapchainImageFoveationVulkanFB() { }
        public XrSwapchainImageFoveationVulkanFB(XrStructureType type, void* next, VkImage image, uint width, uint height)
        {
            this.type = type;
            this.next = next;
            this.image = image;
            this.width = width;
            this.height = height;
        }
    }
    /// <summary><b>[requires: XR_KHR_metal_enable]</b> </summary>
    public unsafe struct XrSwapchainImageMetalKHR
    {
        public XrStructureType type = XrStructureType.TypeSwapchainImageMetalKhr;
        public void* next;
        public void* texture;
        public XrSwapchainImageMetalKHR() { }
        public XrSwapchainImageMetalKHR(XrStructureType type, void* next, void* texture)
        {
            this.type = type;
            this.next = next;
            this.texture = texture;
        }
    }
    /// <summary><b>[requires: XR_KHR_opengl_es_enable]</b> </summary>
    public unsafe struct XrSwapchainImageOpenGLESKHR
    {
        public XrStructureType type = XrStructureType.TypeSwapchainImageOpenglEsKhr;
        public void* next;
        public uint image;
        public XrSwapchainImageOpenGLESKHR() { }
        public XrSwapchainImageOpenGLESKHR(XrStructureType type, void* next, uint image)
        {
            this.type = type;
            this.next = next;
            this.image = image;
        }
    }
    /// <summary><b>[requires: XR_KHR_opengl_enable]</b> </summary>
    public unsafe struct XrSwapchainImageOpenGLKHR
    {
        public XrStructureType type = XrStructureType.TypeSwapchainImageOpenglKhr;
        public void* next;
        public uint image;
        public XrSwapchainImageOpenGLKHR() { }
        public XrSwapchainImageOpenGLKHR(XrStructureType type, void* next, uint image)
        {
            this.type = type;
            this.next = next;
            this.image = image;
        }
    }
    /// <summary>Used by <see cref="Xr.ReleaseSwapchainImage"/></summary>
    public unsafe struct XrSwapchainImageReleaseInfo
    {
        public XrStructureType type = XrStructureType.TypeSwapchainImageReleaseInfo;
        public void* next;
        public XrSwapchainImageReleaseInfo() { }
        public XrSwapchainImageReleaseInfo(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_KHR_vulkan_enable2]</b> </summary>
    public unsafe struct XrSwapchainImageVulkan2KHR
    {
        public XrStructureType type = XrStructureType.TypeSwapchainImageVulkanKhr;
        public void* next;
        public VkImage image;
        public XrSwapchainImageVulkan2KHR() { }
        public XrSwapchainImageVulkan2KHR(XrStructureType type, void* next, VkImage image)
        {
            this.type = type;
            this.next = next;
            this.image = image;
        }
    }
    /// <summary><b>[requires: XR_KHR_vulkan_enable]</b> </summary>
    public unsafe struct XrSwapchainImageVulkanKHR
    {
        public XrStructureType type = XrStructureType.TypeSwapchainImageVulkanKhr;
        public void* next;
        public VkImage image;
        public XrSwapchainImageVulkanKHR() { }
        public XrSwapchainImageVulkanKHR(XrStructureType type, void* next, VkImage image)
        {
            this.type = type;
            this.next = next;
            this.image = image;
        }
    }
    /// <summary>Used by <see cref="Xr.WaitSwapchainImage"/></summary>
    public unsafe struct XrSwapchainImageWaitInfo
    {
        public XrStructureType type = XrStructureType.TypeSwapchainImageWaitInfo;
        public void* next;
        public long timeout;
        public XrSwapchainImageWaitInfo() { }
        public XrSwapchainImageWaitInfo(XrStructureType type, void* next, long timeout)
        {
            this.type = type;
            this.next = next;
            this.timeout = timeout;
        }
    }
    /// <summary><b>[requires: XR_FB_swapchain_update_state_android_surface]</b> </summary>
    public unsafe struct XrSwapchainStateAndroidSurfaceDimensionsFB
    {
        public XrStructureType type = XrStructureType.TypeSwapchainStateAndroidSurfaceDimensionsFb;
        public void* next;
        public uint width;
        public uint height;
        public XrSwapchainStateAndroidSurfaceDimensionsFB() { }
        public XrSwapchainStateAndroidSurfaceDimensionsFB(XrStructureType type, void* next, uint width, uint height)
        {
            this.type = type;
            this.next = next;
            this.width = width;
            this.height = height;
        }
    }
    /// <summary><b>[requires: XR_FB_swapchain_update_state]</b> Used by <see cref="Xr.GetSwapchainStateFB"/>, <see cref="Xr.UpdateSwapchainFB"/></summary>
    public unsafe struct XrSwapchainStateBaseHeaderFB
    {
        public XrStructureType type;
        public void* next;
        public XrSwapchainStateBaseHeaderFB() { }
        public XrSwapchainStateBaseHeaderFB(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_FB_foveation]</b> </summary>
    public unsafe struct XrSwapchainStateFoveationFB
    {
        public XrStructureType type = XrStructureType.TypeSwapchainStateFoveationFb;
        public void* next;
        public XrSwapchainStateFoveationFlagBitsFB flags;
        public XrFoveationProfileFB profile;
        public XrSwapchainStateFoveationFB() { }
        public XrSwapchainStateFoveationFB(XrStructureType type, void* next, XrSwapchainStateFoveationFlagBitsFB flags, XrFoveationProfileFB profile)
        {
            this.type = type;
            this.next = next;
            this.flags = flags;
            this.profile = profile;
        }
    }
    /// <summary><b>[requires: XR_FB_swapchain_update_state_opengl_es]</b> </summary>
    public unsafe struct XrSwapchainStateSamplerOpenGLESFB
    {
        public XrStructureType type = XrStructureType.TypeSwapchainStateSamplerOpenglEsFb;
        public void* next;
        public OpenTK.Graphics.Egl.All minFilter;
        public OpenTK.Graphics.Egl.All magFilter;
        public OpenTK.Graphics.Egl.All wrapModeS;
        public OpenTK.Graphics.Egl.All wrapModeT;
        public OpenTK.Graphics.Egl.All swizzleRed;
        public OpenTK.Graphics.Egl.All swizzleGreen;
        public OpenTK.Graphics.Egl.All swizzleBlue;
        public OpenTK.Graphics.Egl.All swizzleAlpha;
        public float maxAnisotropy;
        public XrColor4f borderColor;
        public XrSwapchainStateSamplerOpenGLESFB() { }
        public XrSwapchainStateSamplerOpenGLESFB(XrStructureType type, void* next, OpenTK.Graphics.Egl.All minFilter, OpenTK.Graphics.Egl.All magFilter, OpenTK.Graphics.Egl.All wrapModeS, OpenTK.Graphics.Egl.All wrapModeT, OpenTK.Graphics.Egl.All swizzleRed, OpenTK.Graphics.Egl.All swizzleGreen, OpenTK.Graphics.Egl.All swizzleBlue, OpenTK.Graphics.Egl.All swizzleAlpha, float maxAnisotropy, XrColor4f borderColor)
        {
            this.type = type;
            this.next = next;
            this.minFilter = minFilter;
            this.magFilter = magFilter;
            this.wrapModeS = wrapModeS;
            this.wrapModeT = wrapModeT;
            this.swizzleRed = swizzleRed;
            this.swizzleGreen = swizzleGreen;
            this.swizzleBlue = swizzleBlue;
            this.swizzleAlpha = swizzleAlpha;
            this.maxAnisotropy = maxAnisotropy;
            this.borderColor = borderColor;
        }
    }
    /// <summary><b>[requires: XR_FB_swapchain_update_state_vulkan]</b> </summary>
    public unsafe struct XrSwapchainStateSamplerVulkanFB
    {
        public XrStructureType type = XrStructureType.TypeSwapchainStateSamplerVulkanFb;
        public void* next;
        public VkFilter minFilter;
        public VkFilter magFilter;
        public VkSamplerMipmapMode mipmapMode;
        public VkSamplerAddressMode wrapModeS;
        public VkSamplerAddressMode wrapModeT;
        public VkComponentSwizzle swizzleRed;
        public VkComponentSwizzle swizzleGreen;
        public VkComponentSwizzle swizzleBlue;
        public VkComponentSwizzle swizzleAlpha;
        public float maxAnisotropy;
        public XrColor4f borderColor;
        public XrSwapchainStateSamplerVulkanFB() { }
        public XrSwapchainStateSamplerVulkanFB(XrStructureType type, void* next, VkFilter minFilter, VkFilter magFilter, VkSamplerMipmapMode mipmapMode, VkSamplerAddressMode wrapModeS, VkSamplerAddressMode wrapModeT, VkComponentSwizzle swizzleRed, VkComponentSwizzle swizzleGreen, VkComponentSwizzle swizzleBlue, VkComponentSwizzle swizzleAlpha, float maxAnisotropy, XrColor4f borderColor)
        {
            this.type = type;
            this.next = next;
            this.minFilter = minFilter;
            this.magFilter = magFilter;
            this.mipmapMode = mipmapMode;
            this.wrapModeS = wrapModeS;
            this.wrapModeT = wrapModeT;
            this.swizzleRed = swizzleRed;
            this.swizzleGreen = swizzleGreen;
            this.swizzleBlue = swizzleBlue;
            this.swizzleAlpha = swizzleAlpha;
            this.maxAnisotropy = maxAnisotropy;
            this.borderColor = borderColor;
        }
    }
    /// <summary></summary>
    public unsafe struct XrSwapchainSubImage
    {
        public XrSwapchain swapchain;
        public XrRect2Di imageRect;
        public uint imageArrayIndex;
        public XrSwapchainSubImage() { }
        public XrSwapchainSubImage(XrSwapchain swapchain, XrRect2Di imageRect, uint imageArrayIndex)
        {
            this.swapchain = swapchain;
            this.imageRect = imageRect;
            this.imageArrayIndex = imageArrayIndex;
        }
    }
    /// <summary><b>[requires: XR_HTC_anchor]</b> </summary>
    public unsafe struct XrSystemAnchorPropertiesHTC
    {
        public XrStructureType type = XrStructureType.TypeSystemAnchorPropertiesHtc;
        public void* next;
        public int supportsAnchor;
        public XrSystemAnchorPropertiesHTC() { }
        public XrSystemAnchorPropertiesHTC(XrStructureType type, void* next, int supportsAnchor)
        {
            this.type = type;
            this.next = next;
            this.supportsAnchor = supportsAnchor;
        }
    }
    /// <summary><b>[requires: XR_BD_body_tracking]</b> </summary>
    public unsafe struct XrSystemBodyTrackingPropertiesBD
    {
        public XrStructureType type = XrStructureType.TypeSystemBodyTrackingPropertiesBd;
        public void* next;
        public int supportsBodyTracking;
        public XrSystemBodyTrackingPropertiesBD() { }
        public XrSystemBodyTrackingPropertiesBD(XrStructureType type, void* next, int supportsBodyTracking)
        {
            this.type = type;
            this.next = next;
            this.supportsBodyTracking = supportsBodyTracking;
        }
    }
    /// <summary><b>[requires: XR_FB_body_tracking]</b> </summary>
    public unsafe struct XrSystemBodyTrackingPropertiesFB
    {
        public XrStructureType type = XrStructureType.TypeSystemBodyTrackingPropertiesFb;
        public void* next;
        public int supportsBodyTracking;
        public XrSystemBodyTrackingPropertiesFB() { }
        public XrSystemBodyTrackingPropertiesFB(XrStructureType type, void* next, int supportsBodyTracking)
        {
            this.type = type;
            this.next = next;
            this.supportsBodyTracking = supportsBodyTracking;
        }
    }
    /// <summary><b>[requires: XR_HTC_body_tracking]</b> </summary>
    public unsafe struct XrSystemBodyTrackingPropertiesHTC
    {
        public XrStructureType type = XrStructureType.TypeSystemBodyTrackingPropertiesHtc;
        public void* next;
        public int supportsBodyTracking;
        public XrSystemBodyTrackingPropertiesHTC() { }
        public XrSystemBodyTrackingPropertiesHTC(XrStructureType type, void* next, int supportsBodyTracking)
        {
            this.type = type;
            this.next = next;
            this.supportsBodyTracking = supportsBodyTracking;
        }
    }
    /// <summary><b>[requires: XR_META_colocation_discovery]</b> </summary>
    public unsafe struct XrSystemColocationDiscoveryPropertiesMETA
    {
        public XrStructureType type = XrStructureType.TypeSystemColocationDiscoveryPropertiesMeta;
        public void* next;
        public int supportsColocationDiscovery;
        public XrSystemColocationDiscoveryPropertiesMETA() { }
        public XrSystemColocationDiscoveryPropertiesMETA(XrStructureType type, void* next, int supportsColocationDiscovery)
        {
            this.type = type;
            this.next = next;
            this.supportsColocationDiscovery = supportsColocationDiscovery;
        }
    }
    /// <summary><b>[requires: XR_FB_color_space]</b> </summary>
    public unsafe struct XrSystemColorSpacePropertiesFB
    {
        public XrStructureType type = XrStructureType.TypeSystemColorSpacePropertiesFb;
        public void* next;
        public XrColorSpaceFB colorSpace;
        public XrSystemColorSpacePropertiesFB() { }
        public XrSystemColorSpacePropertiesFB(XrStructureType type, void* next, XrColorSpaceFB colorSpace)
        {
            this.type = type;
            this.next = next;
            this.colorSpace = colorSpace;
        }
    }
    /// <summary><b>[requires: XR_META_environment_depth]</b> </summary>
    public unsafe struct XrSystemEnvironmentDepthPropertiesMETA
    {
        public XrStructureType type = XrStructureType.TypeSystemEnvironmentDepthPropertiesMeta;
        public void* next;
        public int supportsEnvironmentDepth;
        public int supportsHandRemoval;
        public XrSystemEnvironmentDepthPropertiesMETA() { }
        public XrSystemEnvironmentDepthPropertiesMETA(XrStructureType type, void* next, int supportsEnvironmentDepth, int supportsHandRemoval)
        {
            this.type = type;
            this.next = next;
            this.supportsEnvironmentDepth = supportsEnvironmentDepth;
            this.supportsHandRemoval = supportsHandRemoval;
        }
    }
    /// <summary><b>[requires: XR_EXT_eye_gaze_interaction]</b> </summary>
    public unsafe struct XrSystemEyeGazeInteractionPropertiesEXT
    {
        public XrStructureType type = XrStructureType.TypeSystemEyeGazeInteractionPropertiesExt;
        public void* next;
        public int supportsEyeGazeInteraction;
        public XrSystemEyeGazeInteractionPropertiesEXT() { }
        public XrSystemEyeGazeInteractionPropertiesEXT(XrStructureType type, void* next, int supportsEyeGazeInteraction)
        {
            this.type = type;
            this.next = next;
            this.supportsEyeGazeInteraction = supportsEyeGazeInteraction;
        }
    }
    /// <summary><b>[requires: XR_FB_eye_tracking_social]</b> </summary>
    public unsafe struct XrSystemEyeTrackingPropertiesFB
    {
        public XrStructureType type = XrStructureType.TypeSystemEyeTrackingPropertiesFb;
        public void* next;
        public int supportsEyeTracking;
        public XrSystemEyeTrackingPropertiesFB() { }
        public XrSystemEyeTrackingPropertiesFB(XrStructureType type, void* next, int supportsEyeTracking)
        {
            this.type = type;
            this.next = next;
            this.supportsEyeTracking = supportsEyeTracking;
        }
    }
    /// <summary><b>[requires: XR_FB_face_tracking2]</b> </summary>
    public unsafe struct XrSystemFaceTrackingProperties2FB
    {
        public XrStructureType type = XrStructureType.TypeSystemFaceTrackingProperties2Fb;
        public void* next;
        public int supportsVisualFaceTracking;
        public int supportsAudioFaceTracking;
        public XrSystemFaceTrackingProperties2FB() { }
        public XrSystemFaceTrackingProperties2FB(XrStructureType type, void* next, int supportsVisualFaceTracking, int supportsAudioFaceTracking)
        {
            this.type = type;
            this.next = next;
            this.supportsVisualFaceTracking = supportsVisualFaceTracking;
            this.supportsAudioFaceTracking = supportsAudioFaceTracking;
        }
    }
    /// <summary><b>[requires: XR_FB_face_tracking]</b> </summary>
    public unsafe struct XrSystemFaceTrackingPropertiesFB
    {
        public XrStructureType type = XrStructureType.TypeSystemFaceTrackingPropertiesFb;
        public void* next;
        public int supportsFaceTracking;
        public XrSystemFaceTrackingPropertiesFB() { }
        public XrSystemFaceTrackingPropertiesFB(XrStructureType type, void* next, int supportsFaceTracking)
        {
            this.type = type;
            this.next = next;
            this.supportsFaceTracking = supportsFaceTracking;
        }
    }
    /// <summary><b>[requires: XR_ML_facial_expression]</b> </summary>
    public unsafe struct XrSystemFacialExpressionPropertiesML
    {
        public XrStructureType type = XrStructureType.TypeSystemFacialExpressionPropertiesMl;
        public void* next;
        public int supportsFacialExpression;
        public XrSystemFacialExpressionPropertiesML() { }
        public XrSystemFacialExpressionPropertiesML(XrStructureType type, void* next, int supportsFacialExpression)
        {
            this.type = type;
            this.next = next;
            this.supportsFacialExpression = supportsFacialExpression;
        }
    }
    /// <summary><b>[requires: XR_HTC_facial_tracking]</b> </summary>
    public unsafe struct XrSystemFacialTrackingPropertiesHTC
    {
        public XrStructureType type = XrStructureType.TypeSystemFacialTrackingPropertiesHtc;
        public void* next;
        public int supportEyeFacialTracking;
        public int supportLipFacialTracking;
        public XrSystemFacialTrackingPropertiesHTC() { }
        public XrSystemFacialTrackingPropertiesHTC(XrStructureType type, void* next, int supportEyeFacialTracking, int supportLipFacialTracking)
        {
            this.type = type;
            this.next = next;
            this.supportEyeFacialTracking = supportEyeFacialTracking;
            this.supportLipFacialTracking = supportLipFacialTracking;
        }
    }
    /// <summary><b>[requires: XR_MNDX_force_feedback_curl]</b> </summary>
    public unsafe struct XrSystemForceFeedbackCurlPropertiesMNDX
    {
        public XrStructureType type = XrStructureType.TypeSystemForceFeedbackCurlPropertiesMndx;
        public void* next;
        public int supportsForceFeedbackCurl;
        public XrSystemForceFeedbackCurlPropertiesMNDX() { }
        public XrSystemForceFeedbackCurlPropertiesMNDX(XrStructureType type, void* next, int supportsForceFeedbackCurl)
        {
            this.type = type;
            this.next = next;
            this.supportsForceFeedbackCurl = supportsForceFeedbackCurl;
        }
    }
    /// <summary><b>[requires: XR_VARJO_foveated_rendering]</b> </summary>
    public unsafe struct XrSystemFoveatedRenderingPropertiesVARJO
    {
        public XrStructureType type = XrStructureType.TypeSystemFoveatedRenderingPropertiesVarjo;
        public void* next;
        public int supportsFoveatedRendering;
        public XrSystemFoveatedRenderingPropertiesVARJO() { }
        public XrSystemFoveatedRenderingPropertiesVARJO(XrStructureType type, void* next, int supportsFoveatedRendering)
        {
            this.type = type;
            this.next = next;
            this.supportsFoveatedRendering = supportsFoveatedRendering;
        }
    }
    /// <summary><b>[requires: XR_META_foveation_eye_tracked]</b> </summary>
    public unsafe struct XrSystemFoveationEyeTrackedPropertiesMETA
    {
        public XrStructureType type = XrStructureType.TypeSystemFoveationEyeTrackedPropertiesMeta;
        public void* next;
        public int supportsFoveationEyeTracked;
        public XrSystemFoveationEyeTrackedPropertiesMETA() { }
        public XrSystemFoveationEyeTrackedPropertiesMETA(XrStructureType type, void* next, int supportsFoveationEyeTracked)
        {
            this.type = type;
            this.next = next;
            this.supportsFoveationEyeTracked = supportsFoveationEyeTracked;
        }
    }
    /// <summary>Used by <see cref="Xr.GetSystem"/></summary>
    public unsafe struct XrSystemGetInfo
    {
        public XrStructureType type = XrStructureType.TypeSystemGetInfo;
        public void* next;
        public XrFormFactor formFactor;
        public XrSystemGetInfo() { }
        public XrSystemGetInfo(XrStructureType type, void* next, XrFormFactor formFactor)
        {
            this.type = type;
            this.next = next;
            this.formFactor = formFactor;
        }
    }
    /// <summary></summary>
    public unsafe struct XrSystemGraphicsProperties
    {
        public uint maxSwapchainImageHeight;
        public uint maxSwapchainImageWidth;
        public uint maxLayerCount;
        public XrSystemGraphicsProperties() { }
        public XrSystemGraphicsProperties(uint maxSwapchainImageHeight, uint maxSwapchainImageWidth, uint maxLayerCount)
        {
            this.maxSwapchainImageHeight = maxSwapchainImageHeight;
            this.maxSwapchainImageWidth = maxSwapchainImageWidth;
            this.maxLayerCount = maxLayerCount;
        }
    }
    /// <summary><b>[requires: XR_MSFT_hand_tracking_mesh]</b> </summary>
    public unsafe struct XrSystemHandTrackingMeshPropertiesMSFT
    {
        public XrStructureType type = XrStructureType.TypeSystemHandTrackingMeshPropertiesMsft;
        public void* next;
        public int supportsHandTrackingMesh;
        public uint maxHandMeshIndexCount;
        public uint maxHandMeshVertexCount;
        public XrSystemHandTrackingMeshPropertiesMSFT() { }
        public XrSystemHandTrackingMeshPropertiesMSFT(XrStructureType type, void* next, int supportsHandTrackingMesh, uint maxHandMeshIndexCount, uint maxHandMeshVertexCount)
        {
            this.type = type;
            this.next = next;
            this.supportsHandTrackingMesh = supportsHandTrackingMesh;
            this.maxHandMeshIndexCount = maxHandMeshIndexCount;
            this.maxHandMeshVertexCount = maxHandMeshVertexCount;
        }
    }
    /// <summary><b>[requires: XR_EXT_hand_tracking]</b> </summary>
    public unsafe struct XrSystemHandTrackingPropertiesEXT
    {
        public XrStructureType type = XrStructureType.TypeSystemHandTrackingPropertiesExt;
        public void* next;
        public int supportsHandTracking;
        public XrSystemHandTrackingPropertiesEXT() { }
        public XrSystemHandTrackingPropertiesEXT(XrStructureType type, void* next, int supportsHandTracking)
        {
            this.type = type;
            this.next = next;
            this.supportsHandTracking = supportsHandTracking;
        }
    }
    /// <summary><b>[requires: XR_META_headset_id]</b> </summary>
    public unsafe struct XrSystemHeadsetIdPropertiesMETA
    {
        public XrStructureType type = XrStructureType.TypeSystemHeadsetIdPropertiesMeta;
        public void* next;
        public XrUuid id;
        public XrSystemHeadsetIdPropertiesMETA() { }
        public XrSystemHeadsetIdPropertiesMETA(XrStructureType type, void* next, XrUuid id)
        {
            this.type = type;
            this.next = next;
            this.id = id;
        }
    }
    /// <summary><b>[requires: XR_FB_keyboard_tracking]</b> </summary>
    public unsafe struct XrSystemKeyboardTrackingPropertiesFB
    {
        public XrStructureType type = XrStructureType.TypeSystemKeyboardTrackingPropertiesFb;
        public void* next;
        public int supportsKeyboardTracking;
        public XrSystemKeyboardTrackingPropertiesFB() { }
        public XrSystemKeyboardTrackingPropertiesFB(XrStructureType type, void* next, int supportsKeyboardTracking)
        {
            this.type = type;
            this.next = next;
            this.supportsKeyboardTracking = supportsKeyboardTracking;
        }
    }
    /// <summary><b>[requires: XR_VARJO_marker_tracking]</b> </summary>
    public unsafe struct XrSystemMarkerTrackingPropertiesVARJO
    {
        public XrStructureType type = XrStructureType.TypeSystemMarkerTrackingPropertiesVarjo;
        public void* next;
        public int supportsMarkerTracking;
        public XrSystemMarkerTrackingPropertiesVARJO() { }
        public XrSystemMarkerTrackingPropertiesVARJO(XrStructureType type, void* next, int supportsMarkerTracking)
        {
            this.type = type;
            this.next = next;
            this.supportsMarkerTracking = supportsMarkerTracking;
        }
    }
    /// <summary><b>[requires: XR_ML_marker_understanding]</b> </summary>
    public unsafe struct XrSystemMarkerUnderstandingPropertiesML
    {
        public XrStructureType type = XrStructureType.TypeSystemMarkerUnderstandingPropertiesMl;
        public void* next;
        public int supportsMarkerUnderstanding;
        public XrSystemMarkerUnderstandingPropertiesML() { }
        public XrSystemMarkerUnderstandingPropertiesML(XrStructureType type, void* next, int supportsMarkerUnderstanding)
        {
            this.type = type;
            this.next = next;
            this.supportsMarkerUnderstanding = supportsMarkerUnderstanding;
        }
    }
    /// <summary><b>[requires: XR_ML_system_notifications]</b> Used by <see cref="Xr.SetSystemNotificationsML"/></summary>
    public unsafe struct XrSystemNotificationsSetInfoML
    {
        public XrStructureType type = XrStructureType.TypeSystemNotificationsSetInfoMl;
        public void* next;
        public int suppressNotifications;
        public XrSystemNotificationsSetInfoML() { }
        public XrSystemNotificationsSetInfoML(XrStructureType type, void* next, int suppressNotifications)
        {
            this.type = type;
            this.next = next;
            this.suppressNotifications = suppressNotifications;
        }
    }
    /// <summary><b>[requires: XR_META_passthrough_color_lut]</b> </summary>
    public unsafe struct XrSystemPassthroughColorLutPropertiesMETA
    {
        public XrStructureType type = XrStructureType.TypeSystemPassthroughColorLutPropertiesMeta;
        public void* next;
        public uint maxColorLutResolution;
        public XrSystemPassthroughColorLutPropertiesMETA() { }
        public XrSystemPassthroughColorLutPropertiesMETA(XrStructureType type, void* next, uint maxColorLutResolution)
        {
            this.type = type;
            this.next = next;
            this.maxColorLutResolution = maxColorLutResolution;
        }
    }
    /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
    public unsafe struct XrSystemPassthroughProperties2FB
    {
        public XrStructureType type = XrStructureType.TypeSystemPassthroughProperties2Fb;
        public void* next;
        public XrPassthroughCapabilityFlagBitsFB capabilities;
        public XrSystemPassthroughProperties2FB() { }
        public XrSystemPassthroughProperties2FB(XrStructureType type, void* next, XrPassthroughCapabilityFlagBitsFB capabilities)
        {
            this.type = type;
            this.next = next;
            this.capabilities = capabilities;
        }
    }
    /// <summary><b>[requires: XR_FB_passthrough]</b> </summary>
    public unsafe struct XrSystemPassthroughPropertiesFB
    {
        public XrStructureType type = XrStructureType.TypeSystemPassthroughPropertiesFb;
        public void* next;
        public int supportsPassthrough;
        public XrSystemPassthroughPropertiesFB() { }
        public XrSystemPassthroughPropertiesFB(XrStructureType type, void* next, int supportsPassthrough)
        {
            this.type = type;
            this.next = next;
            this.supportsPassthrough = supportsPassthrough;
        }
    }
    /// <summary><b>[requires: XR_EXT_plane_detection]</b> </summary>
    public unsafe struct XrSystemPlaneDetectionPropertiesEXT
    {
        public XrStructureType type = XrStructureType.TypeSystemPlaneDetectionPropertiesExt;
        public void* next;
        public XrPlaneDetectionCapabilityFlagBitsEXT supportedFeatures;
        public XrSystemPlaneDetectionPropertiesEXT() { }
        public XrSystemPlaneDetectionPropertiesEXT(XrStructureType type, void* next, XrPlaneDetectionCapabilityFlagBitsEXT supportedFeatures)
        {
            this.type = type;
            this.next = next;
            this.supportedFeatures = supportedFeatures;
        }
    }
    /// <summary>Used by <see cref="Xr.GetSystemProperties"/></summary>
    public unsafe struct XrSystemProperties
    {
        public XrStructureType type = XrStructureType.TypeSystemProperties;
        public void* next;
        public ulong systemId;
        public uint vendorId;
        [InlineArray(256)]
        public struct systemNameInlineArray1
        {
            public byte element;
        }
        public systemNameInlineArray1 systemName;
        public XrSystemGraphicsProperties graphicsProperties;
        public XrSystemTrackingProperties trackingProperties;
        public XrSystemProperties() { }
    }
    /// <summary><b>[requires: XR_FB_render_model]</b> </summary>
    public unsafe struct XrSystemRenderModelPropertiesFB
    {
        public XrStructureType type = XrStructureType.TypeSystemRenderModelPropertiesFb;
        public void* next;
        public int supportsRenderModelLoading;
        public XrSystemRenderModelPropertiesFB() { }
        public XrSystemRenderModelPropertiesFB(XrStructureType type, void* next, int supportsRenderModelLoading)
        {
            this.type = type;
            this.next = next;
            this.supportsRenderModelLoading = supportsRenderModelLoading;
        }
    }
    /// <summary><b>[requires: XR_FB_space_warp]</b> </summary>
    public unsafe struct XrSystemSpaceWarpPropertiesFB
    {
        public XrStructureType type = XrStructureType.TypeSystemSpaceWarpPropertiesFb;
        public void* next;
        public uint recommendedMotionVectorImageRectWidth;
        public uint recommendedMotionVectorImageRectHeight;
        public XrSystemSpaceWarpPropertiesFB() { }
        public XrSystemSpaceWarpPropertiesFB(XrStructureType type, void* next, uint recommendedMotionVectorImageRectWidth, uint recommendedMotionVectorImageRectHeight)
        {
            this.type = type;
            this.next = next;
            this.recommendedMotionVectorImageRectWidth = recommendedMotionVectorImageRectWidth;
            this.recommendedMotionVectorImageRectHeight = recommendedMotionVectorImageRectHeight;
        }
    }
    /// <summary><b>[requires: XR_META_spatial_entity_group_sharing]</b> </summary>
    public unsafe struct XrSystemSpatialEntityGroupSharingPropertiesMETA
    {
        public XrStructureType type = XrStructureType.TypeSystemSpatialEntityGroupSharingPropertiesMeta;
        public void* next;
        public int supportsSpatialEntityGroupSharing;
        public XrSystemSpatialEntityGroupSharingPropertiesMETA() { }
        public XrSystemSpatialEntityGroupSharingPropertiesMETA(XrStructureType type, void* next, int supportsSpatialEntityGroupSharing)
        {
            this.type = type;
            this.next = next;
            this.supportsSpatialEntityGroupSharing = supportsSpatialEntityGroupSharing;
        }
    }
    /// <summary><b>[requires: XR_FB_spatial_entity]</b> </summary>
    public unsafe struct XrSystemSpatialEntityPropertiesFB
    {
        public XrStructureType type = XrStructureType.TypeSystemSpatialEntityPropertiesFb;
        public void* next;
        public int supportsSpatialEntity;
        public XrSystemSpatialEntityPropertiesFB() { }
        public XrSystemSpatialEntityPropertiesFB(XrStructureType type, void* next, int supportsSpatialEntity)
        {
            this.type = type;
            this.next = next;
            this.supportsSpatialEntity = supportsSpatialEntity;
        }
    }
    /// <summary><b>[requires: XR_META_spatial_entity_sharing]</b> </summary>
    public unsafe struct XrSystemSpatialEntitySharingPropertiesMETA
    {
        public XrStructureType type = XrStructureType.TypeSystemSpatialEntitySharingPropertiesMeta;
        public void* next;
        public int supportsSpatialEntitySharing;
        public XrSystemSpatialEntitySharingPropertiesMETA() { }
        public XrSystemSpatialEntitySharingPropertiesMETA(XrStructureType type, void* next, int supportsSpatialEntitySharing)
        {
            this.type = type;
            this.next = next;
            this.supportsSpatialEntitySharing = supportsSpatialEntitySharing;
        }
    }
    /// <summary></summary>
    public unsafe struct XrSystemTrackingProperties
    {
        public int orientationTracking;
        public int positionTracking;
        public XrSystemTrackingProperties() { }
        public XrSystemTrackingProperties(int orientationTracking, int positionTracking)
        {
            this.orientationTracking = orientationTracking;
            this.positionTracking = positionTracking;
        }
    }
    /// <summary><b>[requires: XR_EXT_user_presence]</b> </summary>
    public unsafe struct XrSystemUserPresencePropertiesEXT
    {
        public XrStructureType type = XrStructureType.TypeSystemUserPresencePropertiesExt;
        public void* next;
        public int supportsUserPresence;
        public XrSystemUserPresencePropertiesEXT() { }
        public XrSystemUserPresencePropertiesEXT(XrStructureType type, void* next, int supportsUserPresence)
        {
            this.type = type;
            this.next = next;
            this.supportsUserPresence = supportsUserPresence;
        }
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
    public unsafe struct XrSystemVirtualKeyboardPropertiesMETA
    {
        public XrStructureType type = XrStructureType.TypeSystemVirtualKeyboardPropertiesMeta;
        public void* next;
        public int supportsVirtualKeyboard;
        public XrSystemVirtualKeyboardPropertiesMETA() { }
        public XrSystemVirtualKeyboardPropertiesMETA(XrStructureType type, void* next, int supportsVirtualKeyboard)
        {
            this.type = type;
            this.next = next;
            this.supportsVirtualKeyboard = supportsVirtualKeyboard;
        }
    }
    /// <summary><b>[requires: XR_FB_triangle_mesh]</b> Used by <see cref="Xr.CreateTriangleMeshFB"/></summary>
    public unsafe struct XrTriangleMeshCreateInfoFB
    {
        public XrStructureType type = XrStructureType.TypeTriangleMeshCreateInfoFb;
        public void* next;
        public XrTriangleMeshFlagBitsFB flags;
        public XrWindingOrderFB windingOrder;
        public uint vertexCount;
        public XrVector3f* vertexBuffer;
        public uint triangleCount;
        public uint* indexBuffer;
        public XrTriangleMeshCreateInfoFB() { }
        public XrTriangleMeshCreateInfoFB(XrStructureType type, void* next, XrTriangleMeshFlagBitsFB flags, XrWindingOrderFB windingOrder, uint vertexCount, XrVector3f* vertexBuffer, uint triangleCount, uint* indexBuffer)
        {
            this.type = type;
            this.next = next;
            this.flags = flags;
            this.windingOrder = windingOrder;
            this.vertexCount = vertexCount;
            this.vertexBuffer = vertexBuffer;
            this.triangleCount = triangleCount;
            this.indexBuffer = indexBuffer;
        }
    }
    /// <summary><b>[requires: XR_ML_user_calibration]</b> Used by <see cref="Xr.EnableUserCalibrationEventsML"/></summary>
    public unsafe struct XrUserCalibrationEnableEventsInfoML
    {
        public XrStructureType type = XrStructureType.TypeUserCalibrationEnableEventsInfoMl;
        public void* next;
        public int enabled;
        public XrUserCalibrationEnableEventsInfoML() { }
        public XrUserCalibrationEnableEventsInfoML(XrStructureType type, void* next, int enabled)
        {
            this.type = type;
            this.next = next;
            this.enabled = enabled;
        }
    }
    /// <summary><b>[requires: v1.1]</b> Used by <see cref="Xr.CreateExportedLocalizationMapML"/>, <see cref="Xr.GetSpaceUuidFB"/>, <see cref="Xr.ImportLocalizationMapML"/></summary>
    public unsafe struct XrUuid
    {
        public fixed byte data[16];
        public XrUuid() { }
    }
    /// <summary><b>[requires: XR_EXT_uuid]</b> </summary>
    public unsafe struct XrUuidEXT
    {
        public fixed byte data[16];
        public XrUuidEXT() { }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> Used by <see cref="Xr.GetSceneMarkerDecodedStringMSFT"/>, <see cref="Xr.GetSceneMarkerRawDataMSFT"/></summary>
    public unsafe struct XrUuidMSFT
    {
        public fixed byte bytes[16];
        public XrUuidMSFT() { }
    }
    /// <summary>Used by <see cref="Xr.SetInputDeviceStateVector2fEXT"/></summary>
    public unsafe struct XrVector2f
    {
        public float x;
        public float y;
        public XrVector2f() { }
        public XrVector2f(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
    /// <summary>Used by <see cref="Xr.TriangleMeshGetVertexBufferFB"/></summary>
    public unsafe struct XrVector3f
    {
        public float x;
        public float y;
        public float z;
        public XrVector3f() { }
        public XrVector3f(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    public unsafe struct XrVector4f
    {
        public float x;
        public float y;
        public float z;
        public float w;
        public XrVector4f() { }
        public XrVector4f(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
    }
    /// <summary><b>[requires: XR_FB_hand_tracking_mesh]</b> </summary>
    public unsafe struct XrVector4sFB
    {
        public short x;
        public short y;
        public short z;
        public short w;
        public XrVector4sFB() { }
        public XrVector4sFB(short x, short y, short z, short w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
    }
    /// <summary>Used by <see cref="Xr.LocateViews"/></summary>
    public unsafe struct XrView
    {
        public XrStructureType type = XrStructureType.TypeView;
        public void* next;
        public XrPosef pose;
        public XrFovf fov;
        public XrView() { }
        public XrView(XrStructureType type, void* next, XrPosef pose, XrFovf fov)
        {
            this.type = type;
            this.next = next;
            this.pose = pose;
            this.fov = fov;
        }
    }
    /// <summary><b>[requires: XR_EXT_view_configuration_depth_range]</b> </summary>
    public unsafe struct XrViewConfigurationDepthRangeEXT
    {
        public XrStructureType type = XrStructureType.TypeViewConfigurationDepthRangeExt;
        public void* next;
        public float recommendedNearZ;
        public float minNearZ;
        public float recommendedFarZ;
        public float maxFarZ;
        public XrViewConfigurationDepthRangeEXT() { }
        public XrViewConfigurationDepthRangeEXT(XrStructureType type, void* next, float recommendedNearZ, float minNearZ, float recommendedFarZ, float maxFarZ)
        {
            this.type = type;
            this.next = next;
            this.recommendedNearZ = recommendedNearZ;
            this.minNearZ = minNearZ;
            this.recommendedFarZ = recommendedFarZ;
            this.maxFarZ = maxFarZ;
        }
    }
    /// <summary>Used by <see cref="Xr.GetViewConfigurationProperties"/></summary>
    public unsafe struct XrViewConfigurationProperties
    {
        public XrStructureType type = XrStructureType.TypeViewConfigurationProperties;
        public void* next;
        public XrViewConfigurationType viewConfigurationType;
        public int fovMutable;
        public XrViewConfigurationProperties() { }
        public XrViewConfigurationProperties(XrStructureType type, void* next, XrViewConfigurationType viewConfigurationType, int fovMutable)
        {
            this.type = type;
            this.next = next;
            this.viewConfigurationType = viewConfigurationType;
            this.fovMutable = fovMutable;
        }
    }
    /// <summary>Used by <see cref="Xr.EnumerateViewConfigurationViews"/></summary>
    public unsafe struct XrViewConfigurationView
    {
        public XrStructureType type = XrStructureType.TypeViewConfigurationView;
        public void* next;
        public uint recommendedImageRectWidth;
        public uint maxImageRectWidth;
        public uint recommendedImageRectHeight;
        public uint maxImageRectHeight;
        public uint recommendedSwapchainSampleCount;
        public uint maxSwapchainSampleCount;
        public XrViewConfigurationView() { }
        public XrViewConfigurationView(XrStructureType type, void* next, uint recommendedImageRectWidth, uint maxImageRectWidth, uint recommendedImageRectHeight, uint maxImageRectHeight, uint recommendedSwapchainSampleCount, uint maxSwapchainSampleCount)
        {
            this.type = type;
            this.next = next;
            this.recommendedImageRectWidth = recommendedImageRectWidth;
            this.maxImageRectWidth = maxImageRectWidth;
            this.recommendedImageRectHeight = recommendedImageRectHeight;
            this.maxImageRectHeight = maxImageRectHeight;
            this.recommendedSwapchainSampleCount = recommendedSwapchainSampleCount;
            this.maxSwapchainSampleCount = maxSwapchainSampleCount;
        }
    }
    /// <summary><b>[requires: XR_EPIC_view_configuration_fov]</b> </summary>
    public unsafe struct XrViewConfigurationViewFovEPIC
    {
        public XrStructureType type = XrStructureType.TypeViewConfigurationViewFovEpic;
        public void* next;
        public XrFovf recommendedFov;
        public XrFovf maxMutableFov;
        public XrViewConfigurationViewFovEPIC() { }
        public XrViewConfigurationViewFovEPIC(XrStructureType type, void* next, XrFovf recommendedFov, XrFovf maxMutableFov)
        {
            this.type = type;
            this.next = next;
            this.recommendedFov = recommendedFov;
            this.maxMutableFov = maxMutableFov;
        }
    }
    /// <summary><b>[requires: XR_VARJO_foveated_rendering]</b> </summary>
    public unsafe struct XrViewLocateFoveatedRenderingVARJO
    {
        public XrStructureType type = XrStructureType.TypeViewLocateFoveatedRenderingVarjo;
        public void* next;
        public int foveatedRenderingActive;
        public XrViewLocateFoveatedRenderingVARJO() { }
        public XrViewLocateFoveatedRenderingVARJO(XrStructureType type, void* next, int foveatedRenderingActive)
        {
            this.type = type;
            this.next = next;
            this.foveatedRenderingActive = foveatedRenderingActive;
        }
    }
    /// <summary>Used by <see cref="Xr.LocateViews"/></summary>
    public unsafe struct XrViewLocateInfo
    {
        public XrStructureType type = XrStructureType.TypeViewLocateInfo;
        public void* next;
        public XrViewConfigurationType viewConfigurationType;
        public long displayTime;
        public XrSpace space;
        public XrViewLocateInfo() { }
        public XrViewLocateInfo(XrStructureType type, void* next, XrViewConfigurationType viewConfigurationType, long displayTime, XrSpace space)
        {
            this.type = type;
            this.next = next;
            this.viewConfigurationType = viewConfigurationType;
            this.displayTime = displayTime;
            this.space = space;
        }
    }
    /// <summary>Used by <see cref="Xr.LocateViews"/></summary>
    public unsafe struct XrViewState
    {
        public XrStructureType type = XrStructureType.TypeViewState;
        public void* next;
        public XrViewStateFlagBits viewStateFlags;
        public XrViewState() { }
        public XrViewState(XrStructureType type, void* next, XrViewStateFlagBits viewStateFlags)
        {
            this.type = type;
            this.next = next;
            this.viewStateFlags = viewStateFlags;
        }
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> </summary>
    public unsafe struct XrVirtualKeyboardAnimationStateMETA
    {
        public XrStructureType type = XrStructureType.TypeVirtualKeyboardAnimationStateMeta;
        public void* next;
        public int animationIndex;
        public float fraction;
        public XrVirtualKeyboardAnimationStateMETA() { }
        public XrVirtualKeyboardAnimationStateMETA(XrStructureType type, void* next, int animationIndex, float fraction)
        {
            this.type = type;
            this.next = next;
            this.animationIndex = animationIndex;
            this.fraction = fraction;
        }
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> Used by <see cref="Xr.CreateVirtualKeyboardMETA"/></summary>
    public unsafe struct XrVirtualKeyboardCreateInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeVirtualKeyboardCreateInfoMeta;
        public void* next;
        public XrVirtualKeyboardCreateInfoMETA() { }
        public XrVirtualKeyboardCreateInfoMETA(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> Used by <see cref="Xr.SendVirtualKeyboardInputMETA"/></summary>
    public unsafe struct XrVirtualKeyboardInputInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeVirtualKeyboardInputInfoMeta;
        public void* next;
        public XrVirtualKeyboardInputSourceMETA inputSource;
        public XrSpace inputSpace;
        public XrPosef inputPoseInSpace;
        public XrVirtualKeyboardInputStateFlagBitsMETA inputState;
        public XrVirtualKeyboardInputInfoMETA() { }
        public XrVirtualKeyboardInputInfoMETA(XrStructureType type, void* next, XrVirtualKeyboardInputSourceMETA inputSource, XrSpace inputSpace, XrPosef inputPoseInSpace, XrVirtualKeyboardInputStateFlagBitsMETA inputState)
        {
            this.type = type;
            this.next = next;
            this.inputSource = inputSource;
            this.inputSpace = inputSpace;
            this.inputPoseInSpace = inputPoseInSpace;
            this.inputState = inputState;
        }
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> Used by <see cref="Xr.SuggestVirtualKeyboardLocationMETA"/></summary>
    public unsafe struct XrVirtualKeyboardLocationInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeVirtualKeyboardLocationInfoMeta;
        public void* next;
        public XrVirtualKeyboardLocationTypeMETA locationType;
        public XrSpace space;
        public XrPosef poseInSpace;
        public float scale;
        public XrVirtualKeyboardLocationInfoMETA() { }
        public XrVirtualKeyboardLocationInfoMETA(XrStructureType type, void* next, XrVirtualKeyboardLocationTypeMETA locationType, XrSpace space, XrPosef poseInSpace, float scale)
        {
            this.type = type;
            this.next = next;
            this.locationType = locationType;
            this.space = space;
            this.poseInSpace = poseInSpace;
            this.scale = scale;
        }
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> Used by <see cref="Xr.GetVirtualKeyboardModelAnimationStatesMETA"/></summary>
    public unsafe struct XrVirtualKeyboardModelAnimationStatesMETA
    {
        public XrStructureType type = XrStructureType.TypeVirtualKeyboardModelAnimationStatesMeta;
        public void* next;
        public uint stateCapacityInput;
        public uint stateCountOutput;
        public XrVirtualKeyboardAnimationStateMETA* states;
        public XrVirtualKeyboardModelAnimationStatesMETA() { }
        public XrVirtualKeyboardModelAnimationStatesMETA(XrStructureType type, void* next, uint stateCapacityInput, uint stateCountOutput, XrVirtualKeyboardAnimationStateMETA* states)
        {
            this.type = type;
            this.next = next;
            this.stateCapacityInput = stateCapacityInput;
            this.stateCountOutput = stateCountOutput;
            this.states = states;
        }
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> Used by <see cref="Xr.SetVirtualKeyboardModelVisibilityMETA"/></summary>
    public unsafe struct XrVirtualKeyboardModelVisibilitySetInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeVirtualKeyboardModelVisibilitySetInfoMeta;
        public void* next;
        public int visible;
        public XrVirtualKeyboardModelVisibilitySetInfoMETA() { }
        public XrVirtualKeyboardModelVisibilitySetInfoMETA(XrStructureType type, void* next, int visible)
        {
            this.type = type;
            this.next = next;
            this.visible = visible;
        }
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> Used by <see cref="Xr.CreateVirtualKeyboardSpaceMETA"/></summary>
    public unsafe struct XrVirtualKeyboardSpaceCreateInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeVirtualKeyboardSpaceCreateInfoMeta;
        public void* next;
        public XrVirtualKeyboardLocationTypeMETA locationType;
        public XrSpace space;
        public XrPosef poseInSpace;
        public XrVirtualKeyboardSpaceCreateInfoMETA() { }
        public XrVirtualKeyboardSpaceCreateInfoMETA(XrStructureType type, void* next, XrVirtualKeyboardLocationTypeMETA locationType, XrSpace space, XrPosef poseInSpace)
        {
            this.type = type;
            this.next = next;
            this.locationType = locationType;
            this.space = space;
            this.poseInSpace = poseInSpace;
        }
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> Used by <see cref="Xr.ChangeVirtualKeyboardTextContextMETA"/></summary>
    public unsafe struct XrVirtualKeyboardTextContextChangeInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeVirtualKeyboardTextContextChangeInfoMeta;
        public void* next;
        public byte* textContext;
        public XrVirtualKeyboardTextContextChangeInfoMETA() { }
        public XrVirtualKeyboardTextContextChangeInfoMETA(XrStructureType type, void* next, byte* textContext)
        {
            this.type = type;
            this.next = next;
            this.textContext = textContext;
        }
    }
    /// <summary><b>[requires: XR_META_virtual_keyboard]</b> Used by <see cref="Xr.GetVirtualKeyboardTextureDataMETA"/></summary>
    public unsafe struct XrVirtualKeyboardTextureDataMETA
    {
        public XrStructureType type = XrStructureType.TypeVirtualKeyboardTextureDataMeta;
        public void* next;
        public uint textureWidth;
        public uint textureHeight;
        public uint bufferCapacityInput;
        public uint bufferCountOutput;
        public byte* buffer;
        public XrVirtualKeyboardTextureDataMETA() { }
        public XrVirtualKeyboardTextureDataMETA(XrStructureType type, void* next, uint textureWidth, uint textureHeight, uint bufferCapacityInput, uint bufferCountOutput, byte* buffer)
        {
            this.type = type;
            this.next = next;
            this.textureWidth = textureWidth;
            this.textureHeight = textureHeight;
            this.bufferCapacityInput = bufferCapacityInput;
            this.bufferCountOutput = bufferCountOutput;
            this.buffer = buffer;
        }
    }
    /// <summary><b>[requires: XR_KHR_visibility_mask]</b> Used by <see cref="Xr.GetVisibilityMaskKHR"/></summary>
    public unsafe struct XrVisibilityMaskKHR
    {
        public XrStructureType type = XrStructureType.TypeVisibilityMaskKhr;
        public void* next;
        public uint vertexCapacityInput;
        public uint vertexCountOutput;
        public XrVector2f* vertices;
        public uint indexCapacityInput;
        public uint indexCountOutput;
        public uint* indices;
        public XrVisibilityMaskKHR() { }
        public XrVisibilityMaskKHR(XrStructureType type, void* next, uint vertexCapacityInput, uint vertexCountOutput, XrVector2f* vertices, uint indexCapacityInput, uint indexCountOutput, uint* indices)
        {
            this.type = type;
            this.next = next;
            this.vertexCapacityInput = vertexCapacityInput;
            this.vertexCountOutput = vertexCountOutput;
            this.vertices = vertices;
            this.indexCapacityInput = indexCapacityInput;
            this.indexCountOutput = indexCountOutput;
            this.indices = indices;
        }
    }
    /// <summary><b>[requires: XR_MSFT_scene_understanding]</b> </summary>
    public unsafe struct XrVisualMeshComputeLodInfoMSFT
    {
        public XrStructureType type = XrStructureType.TypeVisualMeshComputeLodInfoMsft;
        public void* next;
        public XrMeshComputeLodMSFT lod;
        public XrVisualMeshComputeLodInfoMSFT() { }
        public XrVisualMeshComputeLodInfoMSFT(XrStructureType type, void* next, XrMeshComputeLodMSFT lod)
        {
            this.type = type;
            this.next = next;
            this.lod = lod;
        }
    }
    /// <summary><b>[requires: XR_HTCX_vive_tracker_interaction]</b> Used by <see cref="Xr.EnumerateViveTrackerPathsHTCX"/></summary>
    public unsafe struct XrViveTrackerPathsHTCX
    {
        public XrStructureType type = XrStructureType.TypeViveTrackerPathsHtcx;
        public void* next;
        public ulong persistentPath;
        public ulong rolePath;
        public XrViveTrackerPathsHTCX() { }
        public XrViveTrackerPathsHTCX(XrStructureType type, void* next, ulong persistentPath, ulong rolePath)
        {
            this.type = type;
            this.next = next;
            this.persistentPath = persistentPath;
            this.rolePath = rolePath;
        }
    }
    /// <summary><b>[requires: XR_KHR_vulkan_enable2]</b> Used by <see cref="Xr.CreateVulkanDeviceKHR"/></summary>
    public unsafe struct XrVulkanDeviceCreateInfoKHR
    {
        public XrStructureType type = XrStructureType.TypeVulkanDeviceCreateInfoKhr;
        public void* next;
        public ulong systemId;
        public XrVulkanDeviceCreateFlagBitsKHR createFlags;
        public delegate* unmanaged[Cdecl]<VkInstance, byte*, IntPtr> pfnGetInstanceProcAddr;
        public VkPhysicalDevice vulkanPhysicalDevice;
        public VkDeviceCreateInfo* vulkanCreateInfo;
        public VkAllocationCallbacks* vulkanAllocator;
        public XrVulkanDeviceCreateInfoKHR() { }
        public XrVulkanDeviceCreateInfoKHR(XrStructureType type, void* next, ulong systemId, XrVulkanDeviceCreateFlagBitsKHR createFlags, delegate* unmanaged[Cdecl]<VkInstance, byte*, IntPtr> pfnGetInstanceProcAddr, VkPhysicalDevice vulkanPhysicalDevice, VkDeviceCreateInfo* vulkanCreateInfo, VkAllocationCallbacks* vulkanAllocator)
        {
            this.type = type;
            this.next = next;
            this.systemId = systemId;
            this.createFlags = createFlags;
            this.pfnGetInstanceProcAddr = pfnGetInstanceProcAddr;
            this.vulkanPhysicalDevice = vulkanPhysicalDevice;
            this.vulkanCreateInfo = vulkanCreateInfo;
            this.vulkanAllocator = vulkanAllocator;
        }
    }
    /// <summary><b>[requires: XR_KHR_vulkan_enable2]</b> Used by <see cref="Xr.GetVulkanGraphicsDevice2KHR"/></summary>
    public unsafe struct XrVulkanGraphicsDeviceGetInfoKHR
    {
        public XrStructureType type = XrStructureType.TypeVulkanGraphicsDeviceGetInfoKhr;
        public void* next;
        public ulong systemId;
        public VkInstance vulkanInstance;
        public XrVulkanGraphicsDeviceGetInfoKHR() { }
        public XrVulkanGraphicsDeviceGetInfoKHR(XrStructureType type, void* next, ulong systemId, VkInstance vulkanInstance)
        {
            this.type = type;
            this.next = next;
            this.systemId = systemId;
            this.vulkanInstance = vulkanInstance;
        }
    }
    /// <summary><b>[requires: XR_KHR_vulkan_enable2]</b> Used by <see cref="Xr.CreateVulkanInstanceKHR"/></summary>
    public unsafe struct XrVulkanInstanceCreateInfoKHR
    {
        public XrStructureType type = XrStructureType.TypeVulkanInstanceCreateInfoKhr;
        public void* next;
        public ulong systemId;
        public XrVulkanInstanceCreateFlagBitsKHR createFlags;
        public delegate* unmanaged[Cdecl]<VkInstance, byte*, IntPtr> pfnGetInstanceProcAddr;
        public VkInstanceCreateInfo* vulkanCreateInfo;
        public VkAllocationCallbacks* vulkanAllocator;
        public XrVulkanInstanceCreateInfoKHR() { }
        public XrVulkanInstanceCreateInfoKHR(XrStructureType type, void* next, ulong systemId, XrVulkanInstanceCreateFlagBitsKHR createFlags, delegate* unmanaged[Cdecl]<VkInstance, byte*, IntPtr> pfnGetInstanceProcAddr, VkInstanceCreateInfo* vulkanCreateInfo, VkAllocationCallbacks* vulkanAllocator)
        {
            this.type = type;
            this.next = next;
            this.systemId = systemId;
            this.createFlags = createFlags;
            this.pfnGetInstanceProcAddr = pfnGetInstanceProcAddr;
            this.vulkanCreateInfo = vulkanCreateInfo;
            this.vulkanAllocator = vulkanAllocator;
        }
    }
    /// <summary><b>[requires: XR_META_vulkan_swapchain_create_info]</b> </summary>
    public unsafe struct XrVulkanSwapchainCreateInfoMETA
    {
        public XrStructureType type = XrStructureType.TypeVulkanSwapchainCreateInfoMeta;
        public void* next;
        public VkImageCreateFlagBits additionalCreateFlags;
        public VkImageUsageFlagBits additionalUsageFlags;
        public XrVulkanSwapchainCreateInfoMETA() { }
        public XrVulkanSwapchainCreateInfoMETA(XrStructureType type, void* next, VkImageCreateFlagBits additionalCreateFlags, VkImageUsageFlagBits additionalUsageFlags)
        {
            this.type = type;
            this.next = next;
            this.additionalCreateFlags = additionalCreateFlags;
            this.additionalUsageFlags = additionalUsageFlags;
        }
    }
    /// <summary><b>[requires: XR_KHR_vulkan_swapchain_format_list]</b> </summary>
    public unsafe struct XrVulkanSwapchainFormatListCreateInfoKHR
    {
        public XrStructureType type = XrStructureType.TypeVulkanSwapchainFormatListCreateInfoKhr;
        public void* next;
        public uint viewFormatCount;
        public VkFormat* viewFormats;
        public XrVulkanSwapchainFormatListCreateInfoKHR() { }
        public XrVulkanSwapchainFormatListCreateInfoKHR(XrStructureType type, void* next, uint viewFormatCount, VkFormat* viewFormats)
        {
            this.type = type;
            this.next = next;
            this.viewFormatCount = viewFormatCount;
            this.viewFormats = viewFormats;
        }
    }
    /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> </summary>
    public unsafe struct XrWorldMeshBlockML
    {
        public XrStructureType type = XrStructureType.TypeWorldMeshBlockMl;
        public void* next;
        public XrUuid uuid;
        public XrWorldMeshBlockResultML blockResult;
        public XrWorldMeshDetectorLodML lod;
        public XrWorldMeshDetectorFlagBitsML flags;
        public uint indexCount;
        public ushort* indexBuffer;
        public uint vertexCount;
        public XrVector3f* vertexBuffer;
        public uint normalCount;
        public XrVector3f* normalBuffer;
        public uint confidenceCount;
        public float* confidenceBuffer;
        public XrWorldMeshBlockML() { }
        public XrWorldMeshBlockML(XrStructureType type, void* next, XrUuid uuid, XrWorldMeshBlockResultML blockResult, XrWorldMeshDetectorLodML lod, XrWorldMeshDetectorFlagBitsML flags, uint indexCount, ushort* indexBuffer, uint vertexCount, XrVector3f* vertexBuffer, uint normalCount, XrVector3f* normalBuffer, uint confidenceCount, float* confidenceBuffer)
        {
            this.type = type;
            this.next = next;
            this.uuid = uuid;
            this.blockResult = blockResult;
            this.lod = lod;
            this.flags = flags;
            this.indexCount = indexCount;
            this.indexBuffer = indexBuffer;
            this.vertexCount = vertexCount;
            this.vertexBuffer = vertexBuffer;
            this.normalCount = normalCount;
            this.normalBuffer = normalBuffer;
            this.confidenceCount = confidenceCount;
            this.confidenceBuffer = confidenceBuffer;
        }
    }
    /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> </summary>
    public unsafe struct XrWorldMeshBlockRequestML
    {
        public XrStructureType type = XrStructureType.TypeWorldMeshBlockRequestMl;
        public void* next;
        public XrUuid uuid;
        public XrWorldMeshDetectorLodML lod;
        public XrWorldMeshBlockRequestML() { }
        public XrWorldMeshBlockRequestML(XrStructureType type, void* next, XrUuid uuid, XrWorldMeshDetectorLodML lod)
        {
            this.type = type;
            this.next = next;
            this.uuid = uuid;
            this.lod = lod;
        }
    }
    /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> </summary>
    public unsafe struct XrWorldMeshBlockStateML
    {
        public XrStructureType type = XrStructureType.TypeWorldMeshBlockStateMl;
        public void* next;
        public XrUuid uuid;
        public XrPosef meshBoundingBoxCenter;
        public XrExtent3Df meshBoundingBoxExtents;
        public long lastUpdateTime;
        public XrWorldMeshBlockStatusML status;
        public XrWorldMeshBlockStateML() { }
        public XrWorldMeshBlockStateML(XrStructureType type, void* next, XrUuid uuid, XrPosef meshBoundingBoxCenter, XrExtent3Df meshBoundingBoxExtents, long lastUpdateTime, XrWorldMeshBlockStatusML status)
        {
            this.type = type;
            this.next = next;
            this.uuid = uuid;
            this.meshBoundingBoxCenter = meshBoundingBoxCenter;
            this.meshBoundingBoxExtents = meshBoundingBoxExtents;
            this.lastUpdateTime = lastUpdateTime;
            this.status = status;
        }
    }
    /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> Used by <see cref="Xr.AllocateWorldMeshBufferML"/>, <see cref="Xr.FreeWorldMeshBufferML"/>, <see cref="Xr.RequestWorldMeshAsyncML"/></summary>
    public unsafe struct XrWorldMeshBufferML
    {
        public XrStructureType type = XrStructureType.TypeWorldMeshBufferMl;
        public void* next;
        public uint bufferSize;
        public void* buffer;
        public XrWorldMeshBufferML() { }
        public XrWorldMeshBufferML(XrStructureType type, void* next, uint bufferSize, void* buffer)
        {
            this.type = type;
            this.next = next;
            this.bufferSize = bufferSize;
            this.buffer = buffer;
        }
    }
    /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> Used by <see cref="Xr.GetWorldMeshBufferRecommendSizeML"/></summary>
    public unsafe struct XrWorldMeshBufferRecommendedSizeInfoML
    {
        public XrStructureType type = XrStructureType.TypeWorldMeshBufferRecommendedSizeInfoMl;
        public void* next;
        public uint maxBlockCount;
        public XrWorldMeshBufferRecommendedSizeInfoML() { }
        public XrWorldMeshBufferRecommendedSizeInfoML(XrStructureType type, void* next, uint maxBlockCount)
        {
            this.type = type;
            this.next = next;
            this.maxBlockCount = maxBlockCount;
        }
    }
    /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> Used by <see cref="Xr.AllocateWorldMeshBufferML"/>, <see cref="Xr.GetWorldMeshBufferRecommendSizeML"/></summary>
    public unsafe struct XrWorldMeshBufferSizeML
    {
        public XrStructureType type = XrStructureType.TypeWorldMeshBufferSizeMl;
        public void* next;
        public uint size;
        public XrWorldMeshBufferSizeML() { }
        public XrWorldMeshBufferSizeML(XrStructureType type, void* next, uint size)
        {
            this.type = type;
            this.next = next;
            this.size = size;
        }
    }
    /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> Used by <see cref="Xr.CreateWorldMeshDetectorML"/></summary>
    public unsafe struct XrWorldMeshDetectorCreateInfoML
    {
        public XrStructureType type = XrStructureType.TypeWorldMeshDetectorCreateInfoMl;
        public void* next;
        public XrWorldMeshDetectorCreateInfoML() { }
        public XrWorldMeshDetectorCreateInfoML(XrStructureType type, void* next)
        {
            this.type = type;
            this.next = next;
        }
    }
    /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> Used by <see cref="Xr.RequestWorldMeshAsyncML"/></summary>
    public unsafe struct XrWorldMeshGetInfoML
    {
        public XrStructureType type = XrStructureType.TypeWorldMeshGetInfoMl;
        public void* next;
        public XrWorldMeshDetectorFlagBitsML flags;
        public float fillHoleLength;
        public float disconnectedComponentArea;
        public uint blockCount;
        public XrWorldMeshBlockRequestML* blocks;
        public XrWorldMeshGetInfoML() { }
        public XrWorldMeshGetInfoML(XrStructureType type, void* next, XrWorldMeshDetectorFlagBitsML flags, float fillHoleLength, float disconnectedComponentArea, uint blockCount, XrWorldMeshBlockRequestML* blocks)
        {
            this.type = type;
            this.next = next;
            this.flags = flags;
            this.fillHoleLength = fillHoleLength;
            this.disconnectedComponentArea = disconnectedComponentArea;
            this.blockCount = blockCount;
            this.blocks = blocks;
        }
    }
    /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> Used by <see cref="Xr.RequestWorldMeshCompleteML"/></summary>
    public unsafe struct XrWorldMeshRequestCompletionInfoML
    {
        public XrStructureType type = XrStructureType.TypeWorldMeshRequestCompletionInfoMl;
        public void* next;
        public XrSpace meshSpace;
        public long meshSpaceLocateTime;
        public XrWorldMeshRequestCompletionInfoML() { }
        public XrWorldMeshRequestCompletionInfoML(XrStructureType type, void* next, XrSpace meshSpace, long meshSpaceLocateTime)
        {
            this.type = type;
            this.next = next;
            this.meshSpace = meshSpace;
            this.meshSpaceLocateTime = meshSpaceLocateTime;
        }
    }
    /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> Used by <see cref="Xr.RequestWorldMeshCompleteML"/></summary>
    public unsafe struct XrWorldMeshRequestCompletionML
    {
        public XrStructureType type = XrStructureType.TypeWorldMeshRequestCompletionMl;
        public void* next;
        public XrResult futureResult;
        public uint blockCount;
        public XrWorldMeshBlockML* blocks;
        public XrWorldMeshRequestCompletionML() { }
        public XrWorldMeshRequestCompletionML(XrStructureType type, void* next, XrResult futureResult, uint blockCount, XrWorldMeshBlockML* blocks)
        {
            this.type = type;
            this.next = next;
            this.futureResult = futureResult;
            this.blockCount = blockCount;
            this.blocks = blocks;
        }
    }
    /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> Used by <see cref="Xr.RequestWorldMeshStateCompleteML"/></summary>
    public unsafe struct XrWorldMeshStateRequestCompletionML
    {
        public XrStructureType type = XrStructureType.TypeWorldMeshStateRequestCompletionMl;
        public void* next;
        public XrResult futureResult;
        public long timestamp;
        public uint meshBlockStateCapacityInput;
        public uint meshBlockStateCountOutput;
        public XrWorldMeshBlockStateML* meshBlockStates;
        public XrWorldMeshStateRequestCompletionML() { }
        public XrWorldMeshStateRequestCompletionML(XrStructureType type, void* next, XrResult futureResult, long timestamp, uint meshBlockStateCapacityInput, uint meshBlockStateCountOutput, XrWorldMeshBlockStateML* meshBlockStates)
        {
            this.type = type;
            this.next = next;
            this.futureResult = futureResult;
            this.timestamp = timestamp;
            this.meshBlockStateCapacityInput = meshBlockStateCapacityInput;
            this.meshBlockStateCountOutput = meshBlockStateCountOutput;
            this.meshBlockStates = meshBlockStates;
        }
    }
    /// <summary><b>[requires: XR_ML_world_mesh_detection]</b> Used by <see cref="Xr.RequestWorldMeshStateAsyncML"/></summary>
    public unsafe struct XrWorldMeshStateRequestInfoML
    {
        public XrStructureType type = XrStructureType.TypeWorldMeshStateRequestInfoMl;
        public void* next;
        public XrSpace baseSpace;
        public long time;
        public XrPosef boundingBoxCenter;
        public XrExtent3Df boundingBoxExtents;
        public XrWorldMeshStateRequestInfoML() { }
        public XrWorldMeshStateRequestInfoML(XrStructureType type, void* next, XrSpace baseSpace, long time, XrPosef boundingBoxCenter, XrExtent3Df boundingBoxExtents)
        {
            this.type = type;
            this.next = next;
            this.baseSpace = baseSpace;
            this.time = time;
            this.boundingBoxCenter = boundingBoxCenter;
            this.boundingBoxExtents = boundingBoxExtents;
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
