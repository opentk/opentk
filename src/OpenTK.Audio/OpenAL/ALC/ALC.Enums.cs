// This file is auto generated, do not edit.
using System;

namespace OpenTK.Audio.OpenAL.ALC
{
#pragma warning disable CA1069 // Enums values should not be duplicated
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS0419 // Ambiguous reference in cref attribute
    public enum All : uint
    {
        AsaDistortionTypeBitbrush = 0,
        AsaReverbQualityMin = 0,
        AsaReverbRoomTypeSmallroom = 0,
        AsaRogerBeepSensitivityLight = 0,
        AsaRogerBeepTypeQuindartone = 0,
        FumaSoft = 0,
        HrtfDisabledSoft = 0,
        /// <summary>
        /// No error.
        /// </summary>
        NoError = 0,
        AcnSoft = 1,
        AsaDistortionTypeBufferbeats = 1,
        AsaReverbRoomTypeMediumroom = 1,
        AsaRogerBeepSensitivityMedium = 1,
        AsaRogerBeepTypeWhitenoise = 1,
        ContextDebugBitExt = 1,
        HrtfEnabledSoft = 1,
        Sn3dSoft = 1,
        AsaDistortionTypeLofi = 2,
        AsaReverbRoomTypeLargeroom = 2,
        AsaRogerBeepSensitivityHeavy = 2,
        AsaRogerBeepTypeWalkietalkie = 2,
        DontCareSoft = 2,
        HrtfDeniedSoft = 2,
        N3dSoft = 2,
        AsaDistortionTypeBrokenspeaker = 3,
        AsaReverbRoomTypeMediumhall = 3,
        HrtfRequiredSoft = 3,
        AsaDistortionTypeCellphone = 4,
        AsaReverbRoomTypeLargehall = 4,
        HrtfHeadphonesDetectedSoft = 4,
        AsaDistortionTypeDecimated1 = 5,
        AsaReverbRoomTypePlate = 5,
        HrtfUnsupportedFormatSoft = 5,
        AsaDistortionTypeDecimated2 = 6,
        AsaReverbRoomTypeMediumchamber = 6,
        AsaDistortionTypeDecimated3 = 7,
        AsaReverbRoomTypeLargechamber = 7,
        AsaDistortionTypeDecimated4 = 8,
        AsaReverbRoomTypeCathedral = 8,
        AsaDistortionTypeDistortedfunk = 9,
        AsaReverbRoomTypeLargeroom2 = 9,
        AsaDistortionTypeDistortioncubed = 10,
        AsaReverbRoomTypeMediumhall2 = 10,
        AsaDistortionTypeDistortionsquared = 11,
        AsaReverbRoomTypeMediumhall3 = 11,
        AsaDistortionTypeEcho1 = 12,
        AsaReverbRoomTypeLargehall2 = 12,
        AsaDistortionTypeEcho2 = 13,
        AsaDistortionTypeEchotight1 = 14,
        AsaDistortionTypeEchotight2 = 15,
        AsaDistortionTypeEverythingbroken = 16,
        AsaDistortionTypeAlienchatter = 17,
        AsaDistortionTypeCosmicinteference = 18,
        AsaDistortionTypeGoldenpi = 19,
        AsaDistortionTypeRadiotower = 20,
        AsaDistortionTypeWaves = 21,
        AsaReverbQualityLow = 32,
        AsaReverbQualityMedium = 64,
        AsaReverbQualityHigh = 96,
        AsaReverbQualityMax = 127,
        /// <summary>
        /// 
        ///                 Capture specifier string.
        /// 
        ///                 If device handle is NULL, it is instead a null-character separated list of
        ///                 strings of known device specifiers (list ends with an empty string).
        /// 
        /// </summary>
        CaptureDeviceSpecifier = 784,
        /// <summary>
        /// String for the default capture device specifier.
        /// </summary>
        CaptureDefaultDeviceSpecifier = 785,
        /// <summary>
        /// Number of sample frames available for capture.
        /// </summary>
        CaptureSamples = 786,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        Connected = 787,
        AsaDistortionEnable = 1006,
        AsaRogerBeepType = 1016,
        AsaReverbEqBandwith = 1018,
        AsaReverbPreset = 1019,
        AsaRogerBeepPreset = 1019,
        AsaDistortionType = 1020,
        AsaReverbRoomType = 1020,
        MacOsxSpatialRenderingQualityHigh = 1021,
        AsaDistortionMix = 1022,
        AsaDistortionOn = 1022,
        AsaObstruction = 1022,
        AsaOcclusion = 1022,
        AsaReverbEqFreq = 1022,
        AsaReverbGlobalLevel = 1022,
        AsaReverbOn = 1022,
        AsaReverbQuality = 1022,
        AsaReverbSendLevel = 1022,
        AsaRogerBeepEnable = 1022,
        AsaRogerBeepGain = 1022,
        AsaRogerBeepOn = 1022,
        AsaRogerBeepSensitivity = 1022,
        AsaDistortionPreset = 1023,
        AsaReverbEqGain = 1023,
        MacOsxSpatialRenderingQualityLow = 1023,
        /// <summary>
        /// Runtime ALC major version.
        /// </summary>
        MajorVersion = 4096,
        /// <summary>
        /// Runtime ALC minor version.
        /// </summary>
        MinorVersion = 4097,
        /// <summary>
        /// Context attribute list size.
        /// </summary>
        AttributesSize = 4098,
        /// <summary>
        /// Context attribute list properties.
        /// </summary>
        AllAttributes = 4099,
        /// <summary>
        /// String for the default device specifier.
        /// </summary>
        DefaultDeviceSpecifier = 4100,
        /// <summary>
        /// 
        ///                 Device specifier string.
        /// 
        ///                 If device handle is NULL, it is instead a null-character separated list of
        ///                 strings of known device specifiers (list ends with an empty string).
        /// 
        /// </summary>
        DeviceSpecifier = 4101,
        /// <summary>
        /// String for space-separated list of ALC extensions.
        /// </summary>
        Extensions = 4102,
        /// <summary>
        /// Context attribute: <int> Hz.
        /// </summary>
        Frequency = 4103,
        FrequencyAax = 4103,
        /// <summary>
        /// Context attribute: <int> Hz.
        /// </summary>
        Refresh = 4104,
        /// <summary>
        /// Context attribute: AL_TRUE or AL_FALSE synchronous context?
        /// </summary>
        Sync = 4105,
        /// <summary>
        /// Context attribute: <int> requested Mono (3D) Sources.
        /// </summary>
        MonoSources = 4112,
        /// <summary>
        /// Context attribute: <int> requested Stereo Sources.
        /// </summary>
        StereoSources = 4113,
        /// <summary>
        /// String for the default extended device specifier.
        /// </summary>
        DefaultAllDevicesSpecifier = 4114,
        /// <summary>
        /// 
        ///                 Device's extended specifier string.
        /// 
        ///                 If device handle is NULL, it is instead a null-character separated list of
        ///                 strings of known extended device specifiers (list ends with an empty string).
        /// 
        /// </summary>
        AllDevicesSpecifier = 4115,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        DefaultFilterOrder = 4352,
        ByteSoft = 5120,
        UnsignedByteSoft = 5121,
        ShortSoft = 5122,
        UnsignedShortSoft = 5123,
        IntSoft = 5124,
        UnsignedIntSoft = 5125,
        FloatSoft = 5126,
        MonoSoft = 5376,
        StereoSoft = 5377,
        QuadSoft = 5379,
        _5point1Soft = 5380,
        Surround51Soft = 5380,
        _6point1Soft = 5381,
        Surround61Soft = 5381,
        _7point1Soft = 5382,
        Surround71Soft = 5382,
        Bformat3dSoft = 5383,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        DeviceClockSoft = 5632,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        DeviceLatencySoft = 5633,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        DeviceClockLatencySoft = 5634,
        FormatChannelsSoft = 6544,
        FormatTypeSoft = 6545,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        HrtfSoft = 6546,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        HrtfStatusSoft = 6547,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        NumHrtfSpecifiersSoft = 6548,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        HrtfSpecifierSoft = 6549,
        HrtfIdSoft = 6550,
        AmbisonicLayoutSoft = 6551,
        AmbisonicScalingSoft = 6552,
        AmbisonicOrderSoft = 6553,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        OutputLimiterSoft = 6554,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        MaxAmbisonicOrderSoft = 6555,
        /// <summary>
        /// <b>[property on: context][default value: ALC_ANY_SOFT]</b><br/>
        /// </summary>
        OutputModeSoft = 6572,
        AnySoft = 6573,
        StereoBasicSoft = 6574,
        StereoUhjSoft = 6575,
        StereoHrtfSoft = 6578,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        ContextFlagsExt = 6607,
        PlaybackDeviceSoft = 6612,
        CaptureDeviceSoft = 6613,
        EventTypeDefaultDeviceChangedSoft = 6614,
        EventTypeDeviceAddedSoft = 6615,
        EventTypeDeviceRemovedSoft = 6616,
        EventSupportedSoft = 6617,
        EventNotSupportedSoft = 6618,
        BitsAax = 8194,
        ChannelsAax = 8195,
        /// <summary>
        /// Invalid device handle.
        /// </summary>
        InvalidDevice = 40961,
        /// <summary>
        /// Invalid context handle.
        /// </summary>
        InvalidContext = 40962,
        /// <summary>
        /// Invalid enumeration passed to an ALC call.
        /// </summary>
        InvalidEnum = 40963,
        /// <summary>
        /// Invalid value passed to an ALC call.
        /// </summary>
        InvalidValue = 40964,
        /// <summary>
        /// Out of memory.
        /// </summary>
        OutOfMemory = 40965,
        EfxMajorVersion = 131073,
        EfxMinorVersion = 131074,
        MaxAuxiliarySends = 131075,
        FormatAax = 2555936,
        ChanMainLoki = 5242881,
        ChanPcmLoki = 5242882,
        ChanCdLoki = 5242883,
    }
    public enum AmbisonicLayout : uint
    {
        FumaSoft = 0,
        AcnSoft = 1,
    }
    public enum AmbisonicScaling : uint
    {
        FumaSoft = 0,
        Sn3dSoft = 1,
        N3dSoft = 2,
    }
    public enum AudioChannelLOKI : uint
    {
        ChanMainLoki = 5242881,
        ChanPcmLoki = 5242882,
        ChanCdLoki = 5242883,
    }
    public enum ContextAttribute : uint
    {
        /// <summary>
        /// Context attribute: <int> Hz.
        /// </summary>
        Frequency = 4103,
        /// <summary>
        /// Context attribute: <int> Hz.
        /// </summary>
        Refresh = 4104,
        /// <summary>
        /// Context attribute: AL_TRUE or AL_FALSE synchronous context?
        /// </summary>
        Sync = 4105,
        /// <summary>
        /// Context attribute: <int> requested Mono (3D) Sources.
        /// </summary>
        MonoSources = 4112,
        /// <summary>
        /// Context attribute: <int> requested Stereo Sources.
        /// </summary>
        StereoSources = 4113,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        DefaultFilterOrder = 4352,
        Bformat3dSoft = 5383,
        FormatChannelsSoft = 6544,
        FormatTypeSoft = 6545,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        HrtfSoft = 6546,
        HrtfIdSoft = 6550,
        AmbisonicLayoutSoft = 6551,
        AmbisonicScalingSoft = 6552,
        AmbisonicOrderSoft = 6553,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        OutputLimiterSoft = 6554,
        /// <summary>
        /// <b>[property on: context][default value: ALC_ANY_SOFT]</b><br/>
        /// </summary>
        OutputModeSoft = 6572,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        ContextFlagsExt = 6607,
        MaxAuxiliarySends = 131075,
    }
    public enum ContextFlags : uint
    {
        ContextDebugBitExt = 1,
    }
    ///<summary>Used in <see cref="ALC.SOFT.EventIsSupportedSOFT" /></summary>
    public enum DeviceType : uint
    {
        PlaybackDeviceSoft = 6612,
        CaptureDeviceSoft = 6613,
    }
    ///<summary>Used in <see cref="ALC.GetError" /></summary>
    public enum ErrorCode : uint
    {
        /// <summary>
        /// No error.
        /// </summary>
        NoError = 0,
        /// <summary>
        /// Invalid device handle.
        /// </summary>
        InvalidDevice = 40961,
        /// <summary>
        /// Invalid context handle.
        /// </summary>
        InvalidContext = 40962,
        /// <summary>
        /// Invalid enumeration passed to an ALC call.
        /// </summary>
        InvalidEnum = 40963,
        /// <summary>
        /// Invalid value passed to an ALC call.
        /// </summary>
        InvalidValue = 40964,
        /// <summary>
        /// Out of memory.
        /// </summary>
        OutOfMemory = 40965,
    }
    ///<summary>Used in <see cref="ALC.SOFT.EventIsSupportedSOFT" /></summary>
    public enum EventSupport : uint
    {
        EventSupportedSoft = 6617,
        EventNotSupportedSoft = 6618,
    }
    ///<summary>Used in <see cref="ALC.SOFT.EventControlSOFT" />, <see cref="ALC.SOFT.EventIsSupportedSOFT" /></summary>
    public enum EventType : uint
    {
        EventTypeDefaultDeviceChangedSoft = 6614,
        EventTypeDeviceAddedSoft = 6615,
        EventTypeDeviceRemovedSoft = 6616,
    }
    ///<summary>Used in <see cref="ALC.SOFT.GetInteger64vSOFT" /></summary>
    public enum GetPNameI64V : uint
    {
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        DeviceClockSoft = 5632,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        DeviceLatencySoft = 5633,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        DeviceClockLatencySoft = 5634,
    }
    ///<summary>Used in <see cref="ALC.GetIntegerv" /></summary>
    public enum GetPNameIV : uint
    {
        /// <summary>
        /// Number of sample frames available for capture.
        /// </summary>
        CaptureSamples = 786,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        Connected = 787,
        /// <summary>
        /// Runtime ALC major version.
        /// </summary>
        MajorVersion = 4096,
        /// <summary>
        /// Runtime ALC minor version.
        /// </summary>
        MinorVersion = 4097,
        /// <summary>
        /// Context attribute list size.
        /// </summary>
        AttributesSize = 4098,
        /// <summary>
        /// Context attribute list properties.
        /// </summary>
        AllAttributes = 4099,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        HrtfSoft = 6546,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        HrtfStatusSoft = 6547,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        NumHrtfSpecifiersSoft = 6548,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        OutputLimiterSoft = 6554,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        MaxAmbisonicOrderSoft = 6555,
        EfxMajorVersion = 131073,
        EfxMinorVersion = 131074,
    }
    public enum HRTFMode : uint
    {
        DontCareSoft = 2,
    }
    public enum HRTFStatus : uint
    {
        HrtfDisabledSoft = 0,
        HrtfEnabledSoft = 1,
        HrtfDeniedSoft = 2,
        HrtfRequiredSoft = 3,
        HrtfHeadphonesDetectedSoft = 4,
        HrtfUnsupportedFormatSoft = 5,
    }
    ///<summary>Used in <see cref="ALC.SOFT.GetStringiSOFT" /></summary>
    public enum IndexedStringName : uint
    {
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        HrtfSpecifierSoft = 6549,
    }
    ///<summary>Used in <see cref="ALC.EXT.MacOSXGetRenderingQuality" />, <see cref="ALC.EXT.MacOSXRenderingQuality" /></summary>
    public enum MacOSXSpatialRenderingQuality : uint
    {
        MacOsxSpatialRenderingQualityHigh = 1021,
        MacOsxSpatialRenderingQualityLow = 1023,
    }
    public enum OutputLimiterMode : uint
    {
        DontCareSoft = 2,
    }
    public enum OutputMode : uint
    {
        Surround51Soft = 5380,
        Surround61Soft = 5381,
        Surround71Soft = 5382,
        AnySoft = 6573,
        StereoBasicSoft = 6574,
        StereoUhjSoft = 6575,
        StereoHrtfSoft = 6578,
    }
    ///<summary>Used in <see cref="ALC.SOFT.IsRenderFormatSupportedSOFT" /></summary>
    public enum RenderFormatChannels : uint
    {
        MonoSoft = 5376,
        StereoSoft = 5377,
        QuadSoft = 5379,
        _5point1Soft = 5380,
        _6point1Soft = 5381,
        _7point1Soft = 5382,
    }
    ///<summary>Used in <see cref="ALC.SOFT.IsRenderFormatSupportedSOFT" /></summary>
    public enum RenderFormatType : uint
    {
        ByteSoft = 5120,
        UnsignedByteSoft = 5121,
        ShortSoft = 5122,
        UnsignedShortSoft = 5123,
        IntSoft = 5124,
        UnsignedIntSoft = 5125,
        FloatSoft = 5126,
    }
    ///<summary>Used in <see cref="ALC.GetString" /></summary>
    public enum StringName : uint
    {
        /// <summary>
        /// 
        ///                 Capture specifier string.
        /// 
        ///                 If device handle is NULL, it is instead a null-character separated list of
        ///                 strings of known device specifiers (list ends with an empty string).
        /// 
        /// </summary>
        CaptureDeviceSpecifier = 784,
        /// <summary>
        /// String for the default capture device specifier.
        /// </summary>
        CaptureDefaultDeviceSpecifier = 785,
        /// <summary>
        /// String for the default device specifier.
        /// </summary>
        DefaultDeviceSpecifier = 4100,
        /// <summary>
        /// 
        ///                 Device specifier string.
        /// 
        ///                 If device handle is NULL, it is instead a null-character separated list of
        ///                 strings of known device specifiers (list ends with an empty string).
        /// 
        /// </summary>
        DeviceSpecifier = 4101,
        /// <summary>
        /// String for space-separated list of ALC extensions.
        /// </summary>
        Extensions = 4102,
        /// <summary>
        /// String for the default extended device specifier.
        /// </summary>
        DefaultAllDevicesSpecifier = 4114,
        /// <summary>
        /// 
        ///                 Device's extended specifier string.
        /// 
        ///                 If device handle is NULL, it is instead a null-character separated list of
        ///                 strings of known extended device specifiers (list ends with an empty string).
        /// 
        /// </summary>
        AllDevicesSpecifier = 4115,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// </summary>
        HrtfSpecifierSoft = 6549,
    }
#pragma warning restore CA1069 // Enums values should not be duplicated
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning restore CS0419 // Ambiguous reference in cref attribute
}
