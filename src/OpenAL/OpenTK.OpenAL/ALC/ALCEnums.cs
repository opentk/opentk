//
// ALCEnums.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenTK.Audio.OpenAL
{
#pragma warning disable SA1402 // File may only contain a single type
    /// <summary>
    /// Defines available context attributes.
    /// </summary>
    public enum AlcContextAttributes : int
    {
        /// <summary>Followed by System.Int32 Hz</summary>
        Frequency = 0x1007,

        /// <summary>Followed by System.Int32 Hz</summary>
        Refresh = 0x1008,

        /// <summary>Followed by AlBoolean.True, or AlBoolean.False</summary>
        Sync = 0x1009,

        /// <summary>Followed by System.Int32 Num of requested Mono (3D) Sources</summary>
        MonoSources = 0x1010,

        /// <summary>Followed by System.Int32 Num of requested Stereo Sources</summary>
        StereoSources = 0x1011,

        /// <summary>(EFX Extension) This Context property can be passed to OpenAL during Context creation (alcCreateContext) to request a maximum number of Auxiliary Sends desired on each Source. It is not guaranteed that the desired number of sends will be available, so an application should query this property after creating the context using alcGetIntergerv. Default: 2</summary>
        EfxMaxAuxiliarySends = 0x20003,
    }

    /// <summary>
    /// Defines OpenAL context errors.
    /// </summary>
    public enum AlcError : int
    {
        /// <summary>There is no current error.</summary>
        NoError = 0,

        /// <summary>No Device. The device handle or specifier names an inaccessible driver/server.</summary>
        InvalidDevice = 0xA001,

        /// <summary>Invalid context ID. The Context argument does not name a valid context.</summary>
        InvalidContext = 0xA002,

        /// <summary>Bad enum. A token used is not valid, or not applicable.</summary>
        InvalidEnum = 0xA003,

        /// <summary>Bad value. A value (e.g. Attribute) is not valid, or not applicable.</summary>
        InvalidValue = 0xA004,

        /// <summary>Out of memory. Unable to allocate memory.</summary>
        OutOfMemory = 0xA005,
    }

    /// <summary>
    /// Defines available parameters for <see cref="ALC.GetString(ALDevice, AlcGetString)"/>.
    /// </summary>
    public enum AlcGetString : int
    {
        /// <summary>The specifier string for the default device.</summary>
        DefaultDeviceSpecifier = 0x1004,

        /// <summary>A list of available context extensions separated by spaces.</summary>
        Extensions = 0x1006,

        /// <summary>The name of the default capture device</summary>
        CaptureDefaultDeviceSpecifier = 0x311, // ALC_EXT_CAPTURE extension.

        /// <summary>a list of the default devices.</summary>
        DefaultAllDevicesSpecifier = 0x1012,

        // duplicates from AlcGetStringList:

        /// <summary>Will only return the first Device, not a list. Use AlcGetStringList.CaptureDeviceSpecifier. ALC_EXT_CAPTURE_EXT </summary>
        CaptureDeviceSpecifier = 0x310,

        /// <summary>Will only return the first Device, not a list. Use AlcGetStringList.DeviceSpecifier</summary>
        DeviceSpecifier = 0x1005,

        /// <summary>Will only return the first Device, not a list. Use AlcGetStringList.AllDevicesSpecifier</summary>
        AllDevicesSpecifier = 0x1013,
    }

    /// <summary>
    /// Defines available parameters for <see cref="ALC.GetString(ALDevice, AlcGetStringList)"/>.
    /// </summary>
    public enum AlcGetStringList : int
    {
        /// <summary>The name of the specified capture device, or a list of all available capture devices if no capture device is specified. ALC_EXT_CAPTURE_EXT </summary>
        CaptureDeviceSpecifier = 0x310,

        /// <summary>The specifier strings for all available devices. ALC_ENUMERATION_EXT</summary>
        DeviceSpecifier = 0x1005,

        /// <summary>The specifier strings for all available devices. ALC_ENUMERATE_ALL_EXT</summary>
        AllDevicesSpecifier = 0x1013,
    }

    /// <summary>
    /// Defines available parameters for <see cref="ALC.GetInteger(ALDevice, AlcGetInteger, int, int[])"/>.
    /// </summary>
    public enum AlcGetInteger : int
    {
        /// <summary>The specification revision for this implementation (major version). NULL is an acceptable device.</summary>
        MajorVersion = 0x1000,

        /// <summary>The specification revision for this implementation (minor version). NULL is an acceptable device.</summary>
        MinorVersion = 0x1001,

        /// <summary>The size (number of ALCint values) required for a zero-terminated attributes list, for the current context. NULL is an invalid device.</summary>
        AttributesSize = 0x1002,

        /// <summary>Expects a destination of ALC_ATTRIBUTES_SIZE, and provides an attribute list for the current context of the specified device. NULL is an invalid device.</summary>
        AllAttributes = 0x1003,

        /// <summary>The number of capture samples available. NULL is an invalid device.</summary>
        CaptureSamples = 0x312,

        /// <summary>(EFX Extension) This property can be used by the application to retrieve the Major version number of the Effects Extension supported by this OpenAL implementation. As this is a Context property is should be retrieved using alcGetIntegerv.</summary>
        EfxMajorVersion = 0x20001,

        /// <summary>(EFX Extension) This property can be used by the application to retrieve the Minor version number of the Effects Extension supported by this OpenAL implementation. As this is a Context property is should be retrieved using alcGetIntegerv.</summary>
        EfxMinorVersion = 0x20002,

        /// <summary>(EFX Extension) This Context property can be passed to OpenAL during Context creation (alcCreateContext) to request a maximum number of Auxiliary Sends desired on each Source. It is not guaranteed that the desired number of sends will be available, so an application should query this property after creating the context using alcGetIntergerv. Default: 2</summary>
        EfxMaxAuxiliarySends = 0x20003,
    }

    /// <summary>
    /// Defines available parameters for <see cref="ALC.GetString(ALDevice, GetEnumerationString)" />.
    /// </summary>
    public enum GetEnumerationString
    {
        /// <summary>
        /// Gets the specifier for the default device. ALC_ENUMERATION_EXT
        /// </summary>
        DefaultDeviceSpecifier = 0x1004,

        /// <summary>
        /// Gets a specific output device's specifier.
        /// Can also be used without a device to get a list of all available output devices, see <see cref="GetEnumerationStringList.DeviceSpecifier"/>. ALC_ENUMERATION_EXT
        /// </summary>
        DeviceSpecifier = 0x1005,

        /// <summary>
        /// Gets the specifier for the default capture device. ALC_ENUMERATION_EXT
        /// </summary>
        DefaultCaptureDeviceSpecifier = 0x311,

        /// <summary>
        /// Gets a specific capture device's specifier.
        /// Can also be used without a device to get a list of all available capture devices, see <see cref="GetEnumerationStringList.CaptureDeviceSpecifier"/>. ALC_ENUMERATION_EXT
        /// </summary>
        CaptureDeviceSpecifier = 0x310,
    }

    /// <summary>
    /// Defines available parameters for <see cref="ALC.GetStringListPtr(ALDevice, GetEnumerationStringList)" />.
    /// </summary>
    public enum GetEnumerationStringList
    {
        /// <summary>
        /// Gets the specifier strings for all available output devices.
        /// Can also be used to get the specifier for a specific device, see <see cref="GetEnumerationString.DeviceSpecifier"/>. ALC_ENUMERATION_EXT
        /// </summary>
        DeviceSpecifier = 0x1005,

        /// <summary>
        /// Gets the specifier strings for all available capture devices.
        /// Can also be used to get the specifier for a specific capture device, see <see cref="GetEnumerationString.DeviceSpecifier"/>. ALC_ENUMERATION_EXT
        /// </summary>
        CaptureDeviceSpecifier = 0x310,
    }
#pragma warning restore SA1402 // File may only contain a single type
}
