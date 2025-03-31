// This file is auto generated, do not edit.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace OpenTK.Graphics.OpenXR
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static unsafe partial class Xr
    {
        public static ulong MakeVersion(ushort major, ushort minor, uint patch) { return ((((major) & 0xffffu) << 48) | (((minor) & 0xffffu) << 32) | ((patch) & 0xffffffffu)); }
        public static ushort VersionMajor(ulong version) { return (ushort)(((ulong)(version) << 48) & 0xffffu); }
        public static ushort VersionMinor(ushort version) { return (ushort)(((ulong)(version) << 32) & 0xffffu); }
        public static uint VersionPatch(ulong version) { return (uint)((ulong)(version) & 0xffffffffu); }
        public static ulong CurrentApiVersion() { return MakeVersion(1, 1, 46); }
        public static ulong ApiVersion10() { return MakeVersion(1, 0, VersionPatch(CurrentApiVersion())); }
        public static ulong ApiVersion11() { return MakeVersion(1, 1, VersionPatch(CurrentApiVersion())); }
        public const int ExtensionEnumBase = unchecked((int)1000000000);
        public const int ExtensionEnumStride = unchecked((int)1000);
        public const int NullPath = unchecked((int)0);
        public const int NullSystemId = unchecked((int)0);
        public static bool Succeeded(XrResult result) { return result >= 0; }
        public static bool UnqualifiedSuccess(XrResult result) { return result == 0; }
        public static bool Failed(XrResult result) { return result < 0; }
        public const int NoDuration = unchecked((int)0);
        public const long InfiniteDuration = unchecked((long)9223372036854775807);
        public const int MinHapticDuration = unchecked((int)4294967295);
        public const int FrequencyUnspecified = unchecked((int)0);
        public static int MaxEventDataSize() { return sizeof(XrEventDataBuffer); }
        public const int MinCompositionLayersSupported = unchecked((int)16);
        public const int CurrentLoaderApiLayerVersion = unchecked((int)1);
        public const int CurrentLoaderRuntimeVersion = unchecked((int)1);
        public const int LoaderInfoStructVersion = unchecked((int)1);
        public const int ApiLayerInfoStructVersion = unchecked((int)1);
        public const int RuntimeInfoStructVersion = unchecked((int)1);
        public const int ApiLayerNextInfoStructVersion = unchecked((int)1);
        public const int ApiLayerCreateInfoStructVersion = unchecked((int)1);
        public const int ApiLayerMaxSettingsPathSize = unchecked((int)512);
        public const int HandJointCountExt = unchecked((int)26);
        public const int BodyJointCountBd = unchecked((int)24);
        public const int BodyJointWithoutArmCountBd = unchecked((int)16);
        public const int NullControllerModelKeyMsft = unchecked((int)0);
        public const int NullRenderModelKeyFb = unchecked((int)0);
        public const int FacialExpressionEyeCountHtc = unchecked((int)14);
        public const int FacialExpressionLipCountHtc = unchecked((int)37);
        public const int HandForearmJointCountUltraleap = unchecked((int)27);
        public const uint MaxHapticAmplitudeEnvelopeSamplesFb = unchecked((uint)4000);
        public const int MaxHapticPcmBufferSizeFb = unchecked((int)4000);
        public const int BodyJointCountHtc = unchecked((int)26);
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
