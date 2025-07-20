// This file is auto generated, do not edit.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace OpenTK.Graphics.OpenXR
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>Used by <see cref="Xr.CreateAction"/>, <see cref="Xr.DestroyAction"/></summary>
    [DebuggerDisplay("XrAction\\{{Handle}\\}")]
    public unsafe struct XrAction : IEquatable<XrAction>
    {
        public static XrAction Zero => new XrAction(0);
        public ulong Handle;
        public XrAction(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrAction instance && Equals(instance);
        public bool Equals(XrAction other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrAction left, XrAction right) => left.Equals(right);
        public static bool operator !=(XrAction left, XrAction right) => !(left == right);
        public static explicit operator ulong(XrAction handle) => handle.Handle;
        public static explicit operator XrAction(ulong handle) => new XrAction(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateAction"/>, <see cref="Xr.CreateActionSet"/>, <see cref="Xr.DestroyActionSet"/></summary>
    [DebuggerDisplay("XrActionSet\\{{Handle}\\}")]
    public unsafe struct XrActionSet : IEquatable<XrActionSet>
    {
        public static XrActionSet Zero => new XrActionSet(0);
        public ulong Handle;
        public XrActionSet(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrActionSet instance && Equals(instance);
        public bool Equals(XrActionSet other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrActionSet left, XrActionSet right) => left.Equals(right);
        public static bool operator !=(XrActionSet left, XrActionSet right) => !(left == right);
        public static explicit operator ulong(XrActionSet handle) => handle.Handle;
        public static explicit operator XrActionSet(ulong handle) => new XrActionSet(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateBodyTrackerBD"/>, <see cref="Xr.DestroyBodyTrackerBD"/>, <see cref="Xr.LocateBodyJointsBD"/></summary>
    [DebuggerDisplay("XrBodyTrackerBD\\{{Handle}\\}")]
    public unsafe struct XrBodyTrackerBD : IEquatable<XrBodyTrackerBD>
    {
        public static XrBodyTrackerBD Zero => new XrBodyTrackerBD(0);
        public ulong Handle;
        public XrBodyTrackerBD(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrBodyTrackerBD instance && Equals(instance);
        public bool Equals(XrBodyTrackerBD other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrBodyTrackerBD left, XrBodyTrackerBD right) => left.Equals(right);
        public static bool operator !=(XrBodyTrackerBD left, XrBodyTrackerBD right) => !(left == right);
        public static explicit operator ulong(XrBodyTrackerBD handle) => handle.Handle;
        public static explicit operator XrBodyTrackerBD(ulong handle) => new XrBodyTrackerBD(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateBodyTrackerFB"/>, <see cref="Xr.DestroyBodyTrackerFB"/>, <see cref="Xr.GetBodySkeletonFB"/>, ...</summary>
    [DebuggerDisplay("XrBodyTrackerFB\\{{Handle}\\}")]
    public unsafe struct XrBodyTrackerFB : IEquatable<XrBodyTrackerFB>
    {
        public static XrBodyTrackerFB Zero => new XrBodyTrackerFB(0);
        public ulong Handle;
        public XrBodyTrackerFB(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrBodyTrackerFB instance && Equals(instance);
        public bool Equals(XrBodyTrackerFB other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrBodyTrackerFB left, XrBodyTrackerFB right) => left.Equals(right);
        public static bool operator !=(XrBodyTrackerFB left, XrBodyTrackerFB right) => !(left == right);
        public static explicit operator ulong(XrBodyTrackerFB handle) => handle.Handle;
        public static explicit operator XrBodyTrackerFB(ulong handle) => new XrBodyTrackerFB(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateBodyTrackerHTC"/>, <see cref="Xr.DestroyBodyTrackerHTC"/>, <see cref="Xr.GetBodySkeletonHTC"/>, ...</summary>
    [DebuggerDisplay("XrBodyTrackerHTC\\{{Handle}\\}")]
    public unsafe struct XrBodyTrackerHTC : IEquatable<XrBodyTrackerHTC>
    {
        public static XrBodyTrackerHTC Zero => new XrBodyTrackerHTC(0);
        public ulong Handle;
        public XrBodyTrackerHTC(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrBodyTrackerHTC instance && Equals(instance);
        public bool Equals(XrBodyTrackerHTC other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrBodyTrackerHTC left, XrBodyTrackerHTC right) => left.Equals(right);
        public static bool operator !=(XrBodyTrackerHTC left, XrBodyTrackerHTC right) => !(left == right);
        public static explicit operator ulong(XrBodyTrackerHTC handle) => handle.Handle;
        public static explicit operator XrBodyTrackerHTC(ulong handle) => new XrBodyTrackerHTC(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateDebugUtilsMessengerEXT"/>, <see cref="Xr.DestroyDebugUtilsMessengerEXT"/></summary>
    [DebuggerDisplay("XrDebugUtilsMessengerEXT\\{{Handle}\\}")]
    public unsafe struct XrDebugUtilsMessengerEXT : IEquatable<XrDebugUtilsMessengerEXT>
    {
        public static XrDebugUtilsMessengerEXT Zero => new XrDebugUtilsMessengerEXT(0);
        public ulong Handle;
        public XrDebugUtilsMessengerEXT(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrDebugUtilsMessengerEXT instance && Equals(instance);
        public bool Equals(XrDebugUtilsMessengerEXT other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrDebugUtilsMessengerEXT left, XrDebugUtilsMessengerEXT right) => left.Equals(right);
        public static bool operator !=(XrDebugUtilsMessengerEXT left, XrDebugUtilsMessengerEXT right) => !(left == right);
        public static explicit operator ulong(XrDebugUtilsMessengerEXT handle) => handle.Handle;
        public static explicit operator XrDebugUtilsMessengerEXT(ulong handle) => new XrDebugUtilsMessengerEXT(handle);
    }
    /// <summary>Used by <see cref="Xr.AcquireEnvironmentDepthImageMETA"/>, <see cref="Xr.CreateEnvironmentDepthProviderMETA"/>, <see cref="Xr.CreateEnvironmentDepthSwapchainMETA"/>, ...</summary>
    [DebuggerDisplay("XrEnvironmentDepthProviderMETA\\{{Handle}\\}")]
    public unsafe struct XrEnvironmentDepthProviderMETA : IEquatable<XrEnvironmentDepthProviderMETA>
    {
        public static XrEnvironmentDepthProviderMETA Zero => new XrEnvironmentDepthProviderMETA(0);
        public ulong Handle;
        public XrEnvironmentDepthProviderMETA(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrEnvironmentDepthProviderMETA instance && Equals(instance);
        public bool Equals(XrEnvironmentDepthProviderMETA other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrEnvironmentDepthProviderMETA left, XrEnvironmentDepthProviderMETA right) => left.Equals(right);
        public static bool operator !=(XrEnvironmentDepthProviderMETA left, XrEnvironmentDepthProviderMETA right) => !(left == right);
        public static explicit operator ulong(XrEnvironmentDepthProviderMETA handle) => handle.Handle;
        public static explicit operator XrEnvironmentDepthProviderMETA(ulong handle) => new XrEnvironmentDepthProviderMETA(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateEnvironmentDepthSwapchainMETA"/>, <see cref="Xr.DestroyEnvironmentDepthSwapchainMETA"/>, <see cref="Xr.EnumerateEnvironmentDepthSwapchainImagesMETA"/>, ...</summary>
    [DebuggerDisplay("XrEnvironmentDepthSwapchainMETA\\{{Handle}\\}")]
    public unsafe struct XrEnvironmentDepthSwapchainMETA : IEquatable<XrEnvironmentDepthSwapchainMETA>
    {
        public static XrEnvironmentDepthSwapchainMETA Zero => new XrEnvironmentDepthSwapchainMETA(0);
        public ulong Handle;
        public XrEnvironmentDepthSwapchainMETA(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrEnvironmentDepthSwapchainMETA instance && Equals(instance);
        public bool Equals(XrEnvironmentDepthSwapchainMETA other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrEnvironmentDepthSwapchainMETA left, XrEnvironmentDepthSwapchainMETA right) => left.Equals(right);
        public static bool operator !=(XrEnvironmentDepthSwapchainMETA left, XrEnvironmentDepthSwapchainMETA right) => !(left == right);
        public static explicit operator ulong(XrEnvironmentDepthSwapchainMETA handle) => handle.Handle;
        public static explicit operator XrEnvironmentDepthSwapchainMETA(ulong handle) => new XrEnvironmentDepthSwapchainMETA(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateExportedLocalizationMapML"/>, <see cref="Xr.DestroyExportedLocalizationMapML"/>, <see cref="Xr.GetExportedLocalizationMapDataML"/></summary>
    [DebuggerDisplay("XrExportedLocalizationMapML\\{{Handle}\\}")]
    public unsafe struct XrExportedLocalizationMapML : IEquatable<XrExportedLocalizationMapML>
    {
        public static XrExportedLocalizationMapML Zero => new XrExportedLocalizationMapML(0);
        public ulong Handle;
        public XrExportedLocalizationMapML(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrExportedLocalizationMapML instance && Equals(instance);
        public bool Equals(XrExportedLocalizationMapML other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrExportedLocalizationMapML left, XrExportedLocalizationMapML right) => left.Equals(right);
        public static bool operator !=(XrExportedLocalizationMapML left, XrExportedLocalizationMapML right) => !(left == right);
        public static explicit operator ulong(XrExportedLocalizationMapML handle) => handle.Handle;
        public static explicit operator XrExportedLocalizationMapML(ulong handle) => new XrExportedLocalizationMapML(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateEyeTrackerFB"/>, <see cref="Xr.DestroyEyeTrackerFB"/>, <see cref="Xr.GetEyeGazesFB"/></summary>
    [DebuggerDisplay("XrEyeTrackerFB\\{{Handle}\\}")]
    public unsafe struct XrEyeTrackerFB : IEquatable<XrEyeTrackerFB>
    {
        public static XrEyeTrackerFB Zero => new XrEyeTrackerFB(0);
        public ulong Handle;
        public XrEyeTrackerFB(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrEyeTrackerFB instance && Equals(instance);
        public bool Equals(XrEyeTrackerFB other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrEyeTrackerFB left, XrEyeTrackerFB right) => left.Equals(right);
        public static bool operator !=(XrEyeTrackerFB left, XrEyeTrackerFB right) => !(left == right);
        public static explicit operator ulong(XrEyeTrackerFB handle) => handle.Handle;
        public static explicit operator XrEyeTrackerFB(ulong handle) => new XrEyeTrackerFB(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateFaceTracker2FB"/>, <see cref="Xr.DestroyFaceTracker2FB"/>, <see cref="Xr.GetFaceExpressionWeights2FB"/></summary>
    [DebuggerDisplay("XrFaceTracker2FB\\{{Handle}\\}")]
    public unsafe struct XrFaceTracker2FB : IEquatable<XrFaceTracker2FB>
    {
        public static XrFaceTracker2FB Zero => new XrFaceTracker2FB(0);
        public ulong Handle;
        public XrFaceTracker2FB(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrFaceTracker2FB instance && Equals(instance);
        public bool Equals(XrFaceTracker2FB other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrFaceTracker2FB left, XrFaceTracker2FB right) => left.Equals(right);
        public static bool operator !=(XrFaceTracker2FB left, XrFaceTracker2FB right) => !(left == right);
        public static explicit operator ulong(XrFaceTracker2FB handle) => handle.Handle;
        public static explicit operator XrFaceTracker2FB(ulong handle) => new XrFaceTracker2FB(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateFaceTrackerFB"/>, <see cref="Xr.DestroyFaceTrackerFB"/>, <see cref="Xr.GetFaceExpressionWeightsFB"/></summary>
    [DebuggerDisplay("XrFaceTrackerFB\\{{Handle}\\}")]
    public unsafe struct XrFaceTrackerFB : IEquatable<XrFaceTrackerFB>
    {
        public static XrFaceTrackerFB Zero => new XrFaceTrackerFB(0);
        public ulong Handle;
        public XrFaceTrackerFB(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrFaceTrackerFB instance && Equals(instance);
        public bool Equals(XrFaceTrackerFB other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrFaceTrackerFB left, XrFaceTrackerFB right) => left.Equals(right);
        public static bool operator !=(XrFaceTrackerFB left, XrFaceTrackerFB right) => !(left == right);
        public static explicit operator ulong(XrFaceTrackerFB handle) => handle.Handle;
        public static explicit operator XrFaceTrackerFB(ulong handle) => new XrFaceTrackerFB(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateFacialExpressionClientML"/>, <see cref="Xr.DestroyFacialExpressionClientML"/>, <see cref="Xr.GetFacialExpressionBlendShapePropertiesML"/></summary>
    [DebuggerDisplay("XrFacialExpressionClientML\\{{Handle}\\}")]
    public unsafe struct XrFacialExpressionClientML : IEquatable<XrFacialExpressionClientML>
    {
        public static XrFacialExpressionClientML Zero => new XrFacialExpressionClientML(0);
        public ulong Handle;
        public XrFacialExpressionClientML(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrFacialExpressionClientML instance && Equals(instance);
        public bool Equals(XrFacialExpressionClientML other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrFacialExpressionClientML left, XrFacialExpressionClientML right) => left.Equals(right);
        public static bool operator !=(XrFacialExpressionClientML left, XrFacialExpressionClientML right) => !(left == right);
        public static explicit operator ulong(XrFacialExpressionClientML handle) => handle.Handle;
        public static explicit operator XrFacialExpressionClientML(ulong handle) => new XrFacialExpressionClientML(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateFacialTrackerHTC"/>, <see cref="Xr.DestroyFacialTrackerHTC"/>, <see cref="Xr.GetFacialExpressionsHTC"/></summary>
    [DebuggerDisplay("XrFacialTrackerHTC\\{{Handle}\\}")]
    public unsafe struct XrFacialTrackerHTC : IEquatable<XrFacialTrackerHTC>
    {
        public static XrFacialTrackerHTC Zero => new XrFacialTrackerHTC(0);
        public ulong Handle;
        public XrFacialTrackerHTC(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrFacialTrackerHTC instance && Equals(instance);
        public bool Equals(XrFacialTrackerHTC other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrFacialTrackerHTC left, XrFacialTrackerHTC right) => left.Equals(right);
        public static bool operator !=(XrFacialTrackerHTC left, XrFacialTrackerHTC right) => !(left == right);
        public static explicit operator ulong(XrFacialTrackerHTC handle) => handle.Handle;
        public static explicit operator XrFacialTrackerHTC(ulong handle) => new XrFacialTrackerHTC(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateFoveationProfileFB"/>, <see cref="Xr.DestroyFoveationProfileFB"/></summary>
    [DebuggerDisplay("XrFoveationProfileFB\\{{Handle}\\}")]
    public unsafe struct XrFoveationProfileFB : IEquatable<XrFoveationProfileFB>
    {
        public static XrFoveationProfileFB Zero => new XrFoveationProfileFB(0);
        public ulong Handle;
        public XrFoveationProfileFB(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrFoveationProfileFB instance && Equals(instance);
        public bool Equals(XrFoveationProfileFB other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrFoveationProfileFB left, XrFoveationProfileFB right) => left.Equals(right);
        public static bool operator !=(XrFoveationProfileFB left, XrFoveationProfileFB right) => !(left == right);
        public static explicit operator ulong(XrFoveationProfileFB handle) => handle.Handle;
        public static explicit operator XrFoveationProfileFB(ulong handle) => new XrFoveationProfileFB(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateGeometryInstanceFB"/>, <see cref="Xr.DestroyGeometryInstanceFB"/>, <see cref="Xr.GeometryInstanceSetTransformFB"/></summary>
    [DebuggerDisplay("XrGeometryInstanceFB\\{{Handle}\\}")]
    public unsafe struct XrGeometryInstanceFB : IEquatable<XrGeometryInstanceFB>
    {
        public static XrGeometryInstanceFB Zero => new XrGeometryInstanceFB(0);
        public ulong Handle;
        public XrGeometryInstanceFB(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrGeometryInstanceFB instance && Equals(instance);
        public bool Equals(XrGeometryInstanceFB other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrGeometryInstanceFB left, XrGeometryInstanceFB right) => left.Equals(right);
        public static bool operator !=(XrGeometryInstanceFB left, XrGeometryInstanceFB right) => !(left == right);
        public static explicit operator ulong(XrGeometryInstanceFB handle) => handle.Handle;
        public static explicit operator XrGeometryInstanceFB(ulong handle) => new XrGeometryInstanceFB(handle);
    }
    /// <summary>Used by <see cref="Xr.ApplyForceFeedbackCurlMNDX"/>, <see cref="Xr.CreateHandMeshSpaceMSFT"/>, <see cref="Xr.CreateHandTrackerEXT"/>, ...</summary>
    [DebuggerDisplay("XrHandTrackerEXT\\{{Handle}\\}")]
    public unsafe struct XrHandTrackerEXT : IEquatable<XrHandTrackerEXT>
    {
        public static XrHandTrackerEXT Zero => new XrHandTrackerEXT(0);
        public ulong Handle;
        public XrHandTrackerEXT(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrHandTrackerEXT instance && Equals(instance);
        public bool Equals(XrHandTrackerEXT other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrHandTrackerEXT left, XrHandTrackerEXT right) => left.Equals(right);
        public static bool operator !=(XrHandTrackerEXT left, XrHandTrackerEXT right) => !(left == right);
        public static explicit operator ulong(XrHandTrackerEXT handle) => handle.Handle;
        public static explicit operator XrHandTrackerEXT(ulong handle) => new XrHandTrackerEXT(handle);
    }
    /// <summary>Used by <see cref="Xr.CancelFutureEXT"/>, <see cref="Xr.ConvertTimespecTimeToTimeKHR"/>, <see cref="Xr.ConvertTimeToTimespecTimeKHR"/>, ...</summary>
    [DebuggerDisplay("XrInstance\\{{Handle}\\}")]
    public unsafe struct XrInstance : IEquatable<XrInstance>
    {
        public static XrInstance Zero => new XrInstance(0);
        public ulong Handle;
        public XrInstance(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrInstance instance && Equals(instance);
        public bool Equals(XrInstance other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrInstance left, XrInstance right) => left.Equals(right);
        public static bool operator !=(XrInstance left, XrInstance right) => !(left == right);
        public static explicit operator ulong(XrInstance handle) => handle.Handle;
        public static explicit operator XrInstance(ulong handle) => new XrInstance(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateMarkerDetectorML"/>, <see cref="Xr.DestroyMarkerDetectorML"/>, <see cref="Xr.GetMarkerDetectorStateML"/>, ...</summary>
    [DebuggerDisplay("XrMarkerDetectorML\\{{Handle}\\}")]
    public unsafe struct XrMarkerDetectorML : IEquatable<XrMarkerDetectorML>
    {
        public static XrMarkerDetectorML Zero => new XrMarkerDetectorML(0);
        public ulong Handle;
        public XrMarkerDetectorML(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrMarkerDetectorML instance && Equals(instance);
        public bool Equals(XrMarkerDetectorML other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrMarkerDetectorML left, XrMarkerDetectorML right) => left.Equals(right);
        public static bool operator !=(XrMarkerDetectorML left, XrMarkerDetectorML right) => !(left == right);
        public static explicit operator ulong(XrMarkerDetectorML handle) => handle.Handle;
        public static explicit operator XrMarkerDetectorML(ulong handle) => new XrMarkerDetectorML(handle);
    }
    /// <summary>Used by <see cref="Xr.CreatePassthroughColorLutMETA"/>, <see cref="Xr.DestroyPassthroughColorLutMETA"/>, <see cref="Xr.UpdatePassthroughColorLutMETA"/></summary>
    [DebuggerDisplay("XrPassthroughColorLutMETA\\{{Handle}\\}")]
    public unsafe struct XrPassthroughColorLutMETA : IEquatable<XrPassthroughColorLutMETA>
    {
        public static XrPassthroughColorLutMETA Zero => new XrPassthroughColorLutMETA(0);
        public ulong Handle;
        public XrPassthroughColorLutMETA(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrPassthroughColorLutMETA instance && Equals(instance);
        public bool Equals(XrPassthroughColorLutMETA other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrPassthroughColorLutMETA left, XrPassthroughColorLutMETA right) => left.Equals(right);
        public static bool operator !=(XrPassthroughColorLutMETA left, XrPassthroughColorLutMETA right) => !(left == right);
        public static explicit operator ulong(XrPassthroughColorLutMETA handle) => handle.Handle;
        public static explicit operator XrPassthroughColorLutMETA(ulong handle) => new XrPassthroughColorLutMETA(handle);
    }
    /// <summary>Used by <see cref="Xr.CreatePassthroughColorLutMETA"/>, <see cref="Xr.CreatePassthroughFB"/>, <see cref="Xr.DestroyPassthroughFB"/>, ...</summary>
    [DebuggerDisplay("XrPassthroughFB\\{{Handle}\\}")]
    public unsafe struct XrPassthroughFB : IEquatable<XrPassthroughFB>
    {
        public static XrPassthroughFB Zero => new XrPassthroughFB(0);
        public ulong Handle;
        public XrPassthroughFB(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrPassthroughFB instance && Equals(instance);
        public bool Equals(XrPassthroughFB other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrPassthroughFB left, XrPassthroughFB right) => left.Equals(right);
        public static bool operator !=(XrPassthroughFB left, XrPassthroughFB right) => !(left == right);
        public static explicit operator ulong(XrPassthroughFB handle) => handle.Handle;
        public static explicit operator XrPassthroughFB(ulong handle) => new XrPassthroughFB(handle);
    }
    /// <summary>Used by <see cref="Xr.CreatePassthroughHTC"/>, <see cref="Xr.DestroyPassthroughHTC"/></summary>
    [DebuggerDisplay("XrPassthroughHTC\\{{Handle}\\}")]
    public unsafe struct XrPassthroughHTC : IEquatable<XrPassthroughHTC>
    {
        public static XrPassthroughHTC Zero => new XrPassthroughHTC(0);
        public ulong Handle;
        public XrPassthroughHTC(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrPassthroughHTC instance && Equals(instance);
        public bool Equals(XrPassthroughHTC other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrPassthroughHTC left, XrPassthroughHTC right) => left.Equals(right);
        public static bool operator !=(XrPassthroughHTC left, XrPassthroughHTC right) => !(left == right);
        public static explicit operator ulong(XrPassthroughHTC handle) => handle.Handle;
        public static explicit operator XrPassthroughHTC(ulong handle) => new XrPassthroughHTC(handle);
    }
    /// <summary>Used by <see cref="Xr.CreatePassthroughLayerFB"/>, <see cref="Xr.DestroyPassthroughLayerFB"/>, <see cref="Xr.PassthroughLayerPauseFB"/>, ...</summary>
    [DebuggerDisplay("XrPassthroughLayerFB\\{{Handle}\\}")]
    public unsafe struct XrPassthroughLayerFB : IEquatable<XrPassthroughLayerFB>
    {
        public static XrPassthroughLayerFB Zero => new XrPassthroughLayerFB(0);
        public ulong Handle;
        public XrPassthroughLayerFB(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrPassthroughLayerFB instance && Equals(instance);
        public bool Equals(XrPassthroughLayerFB other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrPassthroughLayerFB left, XrPassthroughLayerFB right) => left.Equals(right);
        public static bool operator !=(XrPassthroughLayerFB left, XrPassthroughLayerFB right) => !(left == right);
        public static explicit operator ulong(XrPassthroughLayerFB handle) => handle.Handle;
        public static explicit operator XrPassthroughLayerFB(ulong handle) => new XrPassthroughLayerFB(handle);
    }
    /// <summary>Used by <see cref="Xr.BeginPlaneDetectionEXT"/>, <see cref="Xr.CreatePlaneDetectorEXT"/>, <see cref="Xr.DestroyPlaneDetectorEXT"/>, ...</summary>
    [DebuggerDisplay("XrPlaneDetectorEXT\\{{Handle}\\}")]
    public unsafe struct XrPlaneDetectorEXT : IEquatable<XrPlaneDetectorEXT>
    {
        public static XrPlaneDetectorEXT Zero => new XrPlaneDetectorEXT(0);
        public ulong Handle;
        public XrPlaneDetectorEXT(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrPlaneDetectorEXT instance && Equals(instance);
        public bool Equals(XrPlaneDetectorEXT other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrPlaneDetectorEXT left, XrPlaneDetectorEXT right) => left.Equals(right);
        public static bool operator !=(XrPlaneDetectorEXT left, XrPlaneDetectorEXT right) => !(left == right);
        public static explicit operator ulong(XrPlaneDetectorEXT handle) => handle.Handle;
        public static explicit operator XrPlaneDetectorEXT(ulong handle) => new XrPlaneDetectorEXT(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateSceneMSFT"/>, <see cref="Xr.DestroySceneMSFT"/>, <see cref="Xr.GetSceneComponentsMSFT"/>, ...</summary>
    [DebuggerDisplay("XrSceneMSFT\\{{Handle}\\}")]
    public unsafe struct XrSceneMSFT : IEquatable<XrSceneMSFT>
    {
        public static XrSceneMSFT Zero => new XrSceneMSFT(0);
        public ulong Handle;
        public XrSceneMSFT(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrSceneMSFT instance && Equals(instance);
        public bool Equals(XrSceneMSFT other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrSceneMSFT left, XrSceneMSFT right) => left.Equals(right);
        public static bool operator !=(XrSceneMSFT left, XrSceneMSFT right) => !(left == right);
        public static explicit operator ulong(XrSceneMSFT handle) => handle.Handle;
        public static explicit operator XrSceneMSFT(ulong handle) => new XrSceneMSFT(handle);
    }
    /// <summary>Used by <see cref="Xr.ComputeNewSceneMSFT"/>, <see cref="Xr.CreateSceneMSFT"/>, <see cref="Xr.CreateSceneObserverMSFT"/>, ...</summary>
    [DebuggerDisplay("XrSceneObserverMSFT\\{{Handle}\\}")]
    public unsafe struct XrSceneObserverMSFT : IEquatable<XrSceneObserverMSFT>
    {
        public static XrSceneObserverMSFT Zero => new XrSceneObserverMSFT(0);
        public ulong Handle;
        public XrSceneObserverMSFT(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrSceneObserverMSFT instance && Equals(instance);
        public bool Equals(XrSceneObserverMSFT other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrSceneObserverMSFT left, XrSceneObserverMSFT right) => left.Equals(right);
        public static bool operator !=(XrSceneObserverMSFT left, XrSceneObserverMSFT right) => !(left == right);
        public static explicit operator ulong(XrSceneObserverMSFT handle) => handle.Handle;
        public static explicit operator XrSceneObserverMSFT(ulong handle) => new XrSceneObserverMSFT(handle);
    }
    /// <summary>Used by <see cref="Xr.ApplyFoveationHTC"/>, <see cref="Xr.ApplyHapticFeedback"/>, <see cref="Xr.AttachSessionActionSets"/>, ...</summary>
    [DebuggerDisplay("XrSession\\{{Handle}\\}")]
    public unsafe struct XrSession : IEquatable<XrSession>
    {
        public static XrSession Zero => new XrSession(0);
        public ulong Handle;
        public XrSession(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrSession instance && Equals(instance);
        public bool Equals(XrSession other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrSession left, XrSession right) => left.Equals(right);
        public static bool operator !=(XrSession left, XrSession right) => !(left == right);
        public static explicit operator ulong(XrSession handle) => handle.Handle;
        public static explicit operator XrSession(ulong handle) => new XrSession(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateActionSpace"/>, <see cref="Xr.CreateHandMeshSpaceMSFT"/>, <see cref="Xr.CreateKeyboardSpaceFB"/>, ...</summary>
    [DebuggerDisplay("XrSpace\\{{Handle}\\}")]
    public unsafe struct XrSpace : IEquatable<XrSpace>
    {
        public static XrSpace Zero => new XrSpace(0);
        public ulong Handle;
        public XrSpace(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrSpace instance && Equals(instance);
        public bool Equals(XrSpace other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrSpace left, XrSpace right) => left.Equals(right);
        public static bool operator !=(XrSpace left, XrSpace right) => !(left == right);
        public static explicit operator ulong(XrSpace handle) => handle.Handle;
        public static explicit operator XrSpace(ulong handle) => new XrSpace(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateSpaceUserFB"/>, <see cref="Xr.DestroySpaceUserFB"/>, <see cref="Xr.GetSpaceUserIdFB"/></summary>
    [DebuggerDisplay("XrSpaceUserFB\\{{Handle}\\}")]
    public unsafe struct XrSpaceUserFB : IEquatable<XrSpaceUserFB>
    {
        public static XrSpaceUserFB Zero => new XrSpaceUserFB(0);
        public ulong Handle;
        public XrSpaceUserFB(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrSpaceUserFB instance && Equals(instance);
        public bool Equals(XrSpaceUserFB other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrSpaceUserFB left, XrSpaceUserFB right) => left.Equals(right);
        public static bool operator !=(XrSpaceUserFB left, XrSpaceUserFB right) => !(left == right);
        public static explicit operator ulong(XrSpaceUserFB handle) => handle.Handle;
        public static explicit operator XrSpaceUserFB(ulong handle) => new XrSpaceUserFB(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateSpatialAnchorFromPerceptionAnchorMSFT"/>, <see cref="Xr.CreateSpatialAnchorFromPersistedNameMSFT"/>, <see cref="Xr.CreateSpatialAnchorMSFT"/>, ...</summary>
    [DebuggerDisplay("XrSpatialAnchorMSFT\\{{Handle}\\}")]
    public unsafe struct XrSpatialAnchorMSFT : IEquatable<XrSpatialAnchorMSFT>
    {
        public static XrSpatialAnchorMSFT Zero => new XrSpatialAnchorMSFT(0);
        public ulong Handle;
        public XrSpatialAnchorMSFT(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrSpatialAnchorMSFT instance && Equals(instance);
        public bool Equals(XrSpatialAnchorMSFT other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrSpatialAnchorMSFT left, XrSpatialAnchorMSFT right) => left.Equals(right);
        public static bool operator !=(XrSpatialAnchorMSFT left, XrSpatialAnchorMSFT right) => !(left == right);
        public static explicit operator ulong(XrSpatialAnchorMSFT handle) => handle.Handle;
        public static explicit operator XrSpatialAnchorMSFT(ulong handle) => new XrSpatialAnchorMSFT(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateSpatialAnchorsStorageML"/>, <see cref="Xr.DeleteSpatialAnchorsAsyncML"/>, <see cref="Xr.DeleteSpatialAnchorsCompleteML"/>, ...</summary>
    [DebuggerDisplay("XrSpatialAnchorsStorageML\\{{Handle}\\}")]
    public unsafe struct XrSpatialAnchorsStorageML : IEquatable<XrSpatialAnchorsStorageML>
    {
        public static XrSpatialAnchorsStorageML Zero => new XrSpatialAnchorsStorageML(0);
        public ulong Handle;
        public XrSpatialAnchorsStorageML(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrSpatialAnchorsStorageML instance && Equals(instance);
        public bool Equals(XrSpatialAnchorsStorageML other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrSpatialAnchorsStorageML left, XrSpatialAnchorsStorageML right) => left.Equals(right);
        public static bool operator !=(XrSpatialAnchorsStorageML left, XrSpatialAnchorsStorageML right) => !(left == right);
        public static explicit operator ulong(XrSpatialAnchorsStorageML handle) => handle.Handle;
        public static explicit operator XrSpatialAnchorsStorageML(ulong handle) => new XrSpatialAnchorsStorageML(handle);
    }
    /// <summary>Used by <see cref="Xr.ClearSpatialAnchorStoreMSFT"/>, <see cref="Xr.CreateSpatialAnchorStoreConnectionMSFT"/>, <see cref="Xr.DestroySpatialAnchorStoreConnectionMSFT"/>, ...</summary>
    [DebuggerDisplay("XrSpatialAnchorStoreConnectionMSFT\\{{Handle}\\}")]
    public unsafe struct XrSpatialAnchorStoreConnectionMSFT : IEquatable<XrSpatialAnchorStoreConnectionMSFT>
    {
        public static XrSpatialAnchorStoreConnectionMSFT Zero => new XrSpatialAnchorStoreConnectionMSFT(0);
        public ulong Handle;
        public XrSpatialAnchorStoreConnectionMSFT(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrSpatialAnchorStoreConnectionMSFT instance && Equals(instance);
        public bool Equals(XrSpatialAnchorStoreConnectionMSFT other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrSpatialAnchorStoreConnectionMSFT left, XrSpatialAnchorStoreConnectionMSFT right) => left.Equals(right);
        public static bool operator !=(XrSpatialAnchorStoreConnectionMSFT left, XrSpatialAnchorStoreConnectionMSFT right) => !(left == right);
        public static explicit operator ulong(XrSpatialAnchorStoreConnectionMSFT handle) => handle.Handle;
        public static explicit operator XrSpatialAnchorStoreConnectionMSFT(ulong handle) => new XrSpatialAnchorStoreConnectionMSFT(handle);
    }
    /// <summary>Used by <see cref="Xr.DestroySpatialGraphNodeBindingMSFT"/>, <see cref="Xr.GetSpatialGraphNodeBindingPropertiesMSFT"/>, <see cref="Xr.TryCreateSpatialGraphStaticNodeBindingMSFT"/></summary>
    [DebuggerDisplay("XrSpatialGraphNodeBindingMSFT\\{{Handle}\\}")]
    public unsafe struct XrSpatialGraphNodeBindingMSFT : IEquatable<XrSpatialGraphNodeBindingMSFT>
    {
        public static XrSpatialGraphNodeBindingMSFT Zero => new XrSpatialGraphNodeBindingMSFT(0);
        public ulong Handle;
        public XrSpatialGraphNodeBindingMSFT(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrSpatialGraphNodeBindingMSFT instance && Equals(instance);
        public bool Equals(XrSpatialGraphNodeBindingMSFT other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrSpatialGraphNodeBindingMSFT left, XrSpatialGraphNodeBindingMSFT right) => left.Equals(right);
        public static bool operator !=(XrSpatialGraphNodeBindingMSFT left, XrSpatialGraphNodeBindingMSFT right) => !(left == right);
        public static explicit operator ulong(XrSpatialGraphNodeBindingMSFT handle) => handle.Handle;
        public static explicit operator XrSpatialGraphNodeBindingMSFT(ulong handle) => new XrSpatialGraphNodeBindingMSFT(handle);
    }
    /// <summary>Used by <see cref="Xr.AcquireSwapchainImage"/>, <see cref="Xr.CreateSwapchain"/>, <see cref="Xr.CreateSwapchainAndroidSurfaceKHR"/>, ...</summary>
    [DebuggerDisplay("XrSwapchain\\{{Handle}\\}")]
    public unsafe struct XrSwapchain : IEquatable<XrSwapchain>
    {
        public static XrSwapchain Zero => new XrSwapchain(0);
        public ulong Handle;
        public XrSwapchain(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrSwapchain instance && Equals(instance);
        public bool Equals(XrSwapchain other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrSwapchain left, XrSwapchain right) => left.Equals(right);
        public static bool operator !=(XrSwapchain left, XrSwapchain right) => !(left == right);
        public static explicit operator ulong(XrSwapchain handle) => handle.Handle;
        public static explicit operator XrSwapchain(ulong handle) => new XrSwapchain(handle);
    }
    /// <summary>Used by <see cref="Xr.CreateTriangleMeshFB"/>, <see cref="Xr.DestroyTriangleMeshFB"/>, <see cref="Xr.TriangleMeshBeginUpdateFB"/>, ...</summary>
    [DebuggerDisplay("XrTriangleMeshFB\\{{Handle}\\}")]
    public unsafe struct XrTriangleMeshFB : IEquatable<XrTriangleMeshFB>
    {
        public static XrTriangleMeshFB Zero => new XrTriangleMeshFB(0);
        public ulong Handle;
        public XrTriangleMeshFB(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrTriangleMeshFB instance && Equals(instance);
        public bool Equals(XrTriangleMeshFB other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrTriangleMeshFB left, XrTriangleMeshFB right) => left.Equals(right);
        public static bool operator !=(XrTriangleMeshFB left, XrTriangleMeshFB right) => !(left == right);
        public static explicit operator ulong(XrTriangleMeshFB handle) => handle.Handle;
        public static explicit operator XrTriangleMeshFB(ulong handle) => new XrTriangleMeshFB(handle);
    }
    /// <summary>Used by <see cref="Xr.ChangeVirtualKeyboardTextContextMETA"/>, <see cref="Xr.CreateVirtualKeyboardMETA"/>, <see cref="Xr.CreateVirtualKeyboardSpaceMETA"/>, ...</summary>
    [DebuggerDisplay("XrVirtualKeyboardMETA\\{{Handle}\\}")]
    public unsafe struct XrVirtualKeyboardMETA : IEquatable<XrVirtualKeyboardMETA>
    {
        public static XrVirtualKeyboardMETA Zero => new XrVirtualKeyboardMETA(0);
        public ulong Handle;
        public XrVirtualKeyboardMETA(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrVirtualKeyboardMETA instance && Equals(instance);
        public bool Equals(XrVirtualKeyboardMETA other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrVirtualKeyboardMETA left, XrVirtualKeyboardMETA right) => left.Equals(right);
        public static bool operator !=(XrVirtualKeyboardMETA left, XrVirtualKeyboardMETA right) => !(left == right);
        public static explicit operator ulong(XrVirtualKeyboardMETA handle) => handle.Handle;
        public static explicit operator XrVirtualKeyboardMETA(ulong handle) => new XrVirtualKeyboardMETA(handle);
    }
    /// <summary>Used by <see cref="Xr.AllocateWorldMeshBufferML"/>, <see cref="Xr.CreateWorldMeshDetectorML"/>, <see cref="Xr.DestroyWorldMeshDetectorML"/>, ...</summary>
    [DebuggerDisplay("XrWorldMeshDetectorML\\{{Handle}\\}")]
    public unsafe struct XrWorldMeshDetectorML : IEquatable<XrWorldMeshDetectorML>
    {
        public static XrWorldMeshDetectorML Zero => new XrWorldMeshDetectorML(0);
        public ulong Handle;
        public XrWorldMeshDetectorML(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is XrWorldMeshDetectorML instance && Equals(instance);
        public bool Equals(XrWorldMeshDetectorML other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(XrWorldMeshDetectorML left, XrWorldMeshDetectorML right) => left.Equals(right);
        public static bool operator !=(XrWorldMeshDetectorML left, XrWorldMeshDetectorML right) => !(left == right);
        public static explicit operator ulong(XrWorldMeshDetectorML handle) => handle.Handle;
        public static explicit operator XrWorldMeshDetectorML(ulong handle) => new XrWorldMeshDetectorML(handle);
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
