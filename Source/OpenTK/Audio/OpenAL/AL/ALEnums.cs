#region --- OpenTK.OpenAL License ---
/* AlTokens.cs
 * C header: \OpenAL 1.1 SDK\include\Al.h
 * Spec: http://www.openal.org/openal_webstf/specs/OpenAL11Specification.pdf
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */
#endregion

using System;

namespace OpenTK.Audio.OpenAL
{

    ///<summary>A list of valid Enable/Disable/IsEnabled parameters</summary>
    public enum ALCapability : int
    {
        ///<summary>Currently no state toggles exist for vanilla OpenAL and no Extension uses it.</summary>
        Invalid = -1,
    }

    ///<summary>A list of valid 32-bit Float Listener/GetListener parameters</summary>
    public enum ALListenerf : int
    {
        ///<summary>Indicate the gain (Volume amplification) applied. Type: float Range: [0.0f - ? ] A value of 1.0 means un-attenuated/unchanged. Each division by 2 equals an attenuation of -6dB. Each multiplicaton with 2 equals an amplification of +6dB. A value of 0.0f is interpreted as zero volume and the channel is effectively disabled.</summary>
        Gain = 0x100A,

        ///<summary>(EFX Extension) This setting is critical if Air Absorption effects are enabled because the amount of Air Absorption applied is directly related to the real-world distance between the Source and the Listener. centimeters 0.01f meters 1.0f kilometers 1000.0f Range [float.MinValue .. float.MaxValue] Default: 1.0f</summary>
        EfxMetersPerUnit = 0x20004,
    }

    ///<summary>A list of valid Math.Vector3 Listener/GetListener parameters</summary>
    public enum ALListener3f : int
    {
        ///<summary>Specify the current location in three dimensional space. OpenAL, like OpenGL, uses a right handed coordinate system, where in a frontal default view X (thumb) points right, Y points up (index finger), and Z points towards the viewer/camera (middle finger). To switch from a left handed coordinate system, flip the sign on the Z coordinate. Listener position is always in the world coordinate system.</summary>
        Position = 0x1004,

        ///<summary>Specify the current velocity in three dimensional space.</summary>
        Velocity = 0x1006,
    }

    ///<summary>A list of valid float[] Listener/GetListener parameters</summary>
    public enum ALListenerfv : int
    {
        ///<summary>Indicate Listener orientation. Expects two Vector3, At followed by Up.</summary>
        Orientation = 0x100F,
    }

    ///<summary>A list of valid 32-bit Float Source/GetSource parameters</summary>
    public enum ALSourcef : int
    {
        ///<summary>Source specific reference distance. Type: float Range: [0.0f - float.PositiveInfinity] At 0.0f, no distance attenuation occurs. Type: float Default: 1.0f.</summary>
        ReferenceDistance = 0x1020,

        ///<summary>Indicate distance above which Sources are not attenuated using the inverse clamped distance model. Default: float.PositiveInfinity Type: float Range: [0.0f - float.PositiveInfinity]</summary>
        MaxDistance = 0x1023,

        ///<summary>Source specific rolloff factor. Type: float Range: [0.0f - float.PositiveInfinity]</summary>
        RolloffFactor = 0x1021,

        ///<summary>Specify the pitch to be applied, either at Source, or on mixer results, at Listener. Range: [0.5f - 2.0f] Default: 1.0f</summary>
        Pitch = 0x1003,

        ///<summary>Indicate the gain (volume amplification) applied. Type: float. Range: [0.0f - ? ] A value of 1.0 means un-attenuated/unchanged. Each division by 2 equals an attenuation of -6dB. Each multiplicaton with 2 equals an amplification of +6dB. A value of 0.0f is meaningless with respect to a logarithmic scale; it is interpreted as zero volume - the channel is effectively disabled.</summary>
        Gain = 0x100A,

        ///<summary>Indicate minimum Source attenuation. Type: float Range: [0.0f - 1.0f] (Logarthmic)</summary>
        MinGain = 0x100D,

        ///<summary>Indicate maximum Source attenuation. Type: float Range: [0.0f - 1.0f] (Logarthmic)</summary>
        MaxGain = 0x100E,

        ///<summary>Directional Source, inner cone angle, in degrees. Range: [0-360] Default: 360</summary>
        ConeInnerAngle = 0x1001,

        ///<summary>Directional Source, outer cone angle, in degrees. Range: [0-360] Default: 360</summary>
        ConeOuterAngle = 0x1002,

        ///<summary>Directional Source, outer cone gain. Default: 0.0f Range: [0.0f - 1.0] (Logarithmic)</summary>
        ConeOuterGain = 0x1022,

        /// <summary>The playback position, expressed in seconds.</summary>
        SecOffset = 0x1024, // AL_EXT_OFFSET extension.

        ///<summary>(EFX Extension) This property is a multiplier on the amount of Air Absorption applied to the Source. The AL_AIR_ABSORPTION_FACTOR is multiplied by an internal Air Absorption Gain HF value of 0.994 (-0.05dB) per meter which represents normal atmospheric humidity and temperature. Range [0.0f .. 10.0f] Default: 0.0f</summary>
        EfxAirAbsorptionFactor = 0x20007,

        ///<summary>(EFX Extension) This property is defined the same way as the Reverb Room Rolloff property: it is one of two methods available in the Effect Extension to attenuate the reflected sound (early reflections and reverberation) according to source-listener distance. Range [0.0f .. 10.0f] Default: 0.0f</summary>
        EfxRoomRolloffFactor = 0x20008,

        ///<summary>(EFX Extension) A directed Source points in a specified direction. The Source sounds at full volume when the listener is directly in front of the source; it is attenuated as the listener circles the Source away from the front. Range [0.0f .. 1.0f] Default: 1.0f</summary>
        EfxConeOuterGainHighFrequency = 0x20009,

    }

    ///<summary>A list of valid Math.Vector3 Source/GetSource parameters</summary>
    public enum ALSource3f : int
    {
        ///<summary>Specify the current location in three dimensional space. OpenAL, like OpenGL, uses a right handed coordinate system, where in a frontal default view X (thumb) points right, Y points up (index finger), and Z points towards the viewer/camera (middle finger). To switch from a left handed coordinate system, flip the sign on the Z coordinate. Listener position is always in the world coordinate system.</summary>
        Position = 0x1004,

        ///<summary>Specify the current velocity in three dimensional space.</summary>
        Velocity = 0x1006,

        ///<summary>Specify the current direction vector.</summary>
        Direction = 0x1005,
    }

    ///<summary>A list of valid 8-bit boolean Source/GetSource parameters</summary>
    public enum ALSourceb : int
    {
        ///<summary>Indicate that the Source has relative coordinates. Type: bool Range: [True, False]</summary>
        SourceRelative = 0x202,

        ///<summary>Indicate whether the Source is looping. Type: bool Range: [True, False] Default: False.</summary>
        Looping = 0x1007,

        ///<summary>(EFX Extension) If this Source property is set to True, this Source’s direct-path is automatically filtered according to the orientation of the source relative to the listener and the setting of the Source property Sourcef.ConeOuterGainHF. Type: bool Range [False, True] Default: True</summary>
        EfxDirectFilterGainHighFrequencyAuto = 0x2000A,

        ///<summary>(EFX Extension) If this Source property is set to True, the intensity of this Source’s reflected sound is automatically attenuated according to source-listener distance and source directivity (as determined by the cone parameters). If it is False, the reflected sound is not attenuated according to distance and directivity. Type: bool Range [False, True] Default: True</summary>
        EfxAuxiliarySendFilterGainAuto = 0x2000B,

        ///<summary>(EFX Extension) If this Source property is AL_TRUE (its default value), the intensity of this Source’s reflected sound at high frequencies will be automatically attenuated according to the high-frequency source directivity as set by the Sourcef.ConeOuterGainHF property. If this property is AL_FALSE, the Source’s reflected sound is not filtered at all according to the Source’s directivity. Type: bool Range [False, True] Default: True</summary>
        EfxAuxiliarySendFilterGainHighFrequencyAuto = 0x2000C,
    }

    ///<summary>A list of valid Int32 Source parameters</summary>
    public enum ALSourcei : int
    {
        ///<summary>The playback position, expressed in bytes.</summary>
        ByteOffset = 0x1026,  // AL_EXT_OFFSET extension.

        ///<summary>The playback position, expressed in samples.</summary>
        SampleOffset = 0x1025, // AL_EXT_OFFSET extension.

        ///<summary>Indicate the Buffer to provide sound samples. Type: uint Range: any valid Buffer Handle.</summary>
        Buffer = 0x1009,

        ///<summary>Source type (Static, Streaming or undetermined). Use enum AlSourceType for comparison</summary>
        SourceType = 0x1027,

        ///<summary>(EFX Extension) This Source property is used to apply filtering on the direct-path (dry signal) of a Source.</summary>
        EfxDirectFilter = 0x20005,
    }

    ///<summary>A list of valid 3x Int32 Source/GetSource parameters</summary>
    public enum ALSource3i : int
    {
        ///<summary>(EFX Extension) This Source property is used to establish connections between Sources and Auxiliary Effect Slots. For a Source to feed an Effect that has been loaded into an Auxiliary Effect Slot the application must configure one of the Source’s auxiliary sends. This process involves setting 3 variables – the destination Auxiliary Effect Slot ID, the Auxiliary Send number, and an optional Filter ID. Type: uint Range: any valid Filter Handle.</summary>
        EfxAuxiliarySendFilter = 0x20006,
    }

    ///<summary>A list of valid Int32 GetSource parameters</summary>
    public enum ALGetSourcei : int
    {
        ///<summary>The playback position, expressed in bytes. AL_EXT_OFFSET Extension.</summary>
        ByteOffset = 0x1026,

        ///<summary>The playback position, expressed in samples. AL_EXT_OFFSET Extension.</summary>
        SampleOffset = 0x1025,

        ///<summary>Indicate the Buffer to provide sound samples. Type: uint Range: any valid Buffer Handle.</summary>
        Buffer = 0x1009,

        /// <summary>The state of the source (Stopped, Playing, etc.) Use the enum AlSourceState for comparison.</summary>
        SourceState = 0x1010,

        /// <summary>The number of buffers queued on this source.</summary>
        BuffersQueued = 0x1015,

        /// <summary>The number of buffers in the queue that have been processed.</summary>
        BuffersProcessed = 0x1016,

        ///<summary>Source type (Static, Streaming or undetermined). Use enum AlSourceType for comparison.</summary>
        SourceType = 0x1027,
    }

    /*
    public enum ALDeprecated : int
    {
        ///<summary>Deprecated. Specify the channel mask. (Creative) Type: uint Range: [0 - 255]</summary>
        ChannelMask = 0x3000,
    }
    */

    ///<summary>Source state information, can be retrieved by AL.Source() with ALSourcei.SourceState.</summary>
    public enum ALSourceState : int
    {
        ///<summary>Default State when loaded, can be manually set with AL.SourceRewind().</summary>
        Initial = 0x1011,

        ///<summary>The source is currently playing.</summary>
        Playing = 0x1012,

        ///<summary>The source has paused playback.</summary>
        Paused = 0x1013,

        ///<summary>The source is not playing.</summary>
        Stopped = 0x1014,
    }

    ///<summary>Source type information,  can be retrieved by AL.Source() with ALSourcei.SourceType.</summary>
    public enum ALSourceType : int
    {
        ///<summary>Source is Static if a Buffer has been attached using AL.Source with the parameter Sourcei.Buffer.</summary>
        Static = 0x1028,

        ///<summary>Source is Streaming if one or more Buffers have been attached using AL.SourceQueueBuffers</summary>
        Streaming = 0x1029,

        ///<summary>Source is undetermined when it has a null Buffer attached</summary>
        Undetermined = 0x1030,
    }

    ///<summary>Sound samples: Format specifier.</summary>
    public enum ALFormat : int
    {
        ///<summary>1 Channel, 8 bits per sample.</summary>
        Mono8 = 0x1100,

        ///<summary>1 Channel, 16 bits per sample.</summary>
        Mono16 = 0x1101,

        ///<summary>2 Channels, 8 bits per sample each.</summary>
        Stereo8 = 0x1102,

        ///<summary>2 Channels, 16 bits per sample each.</summary>
        Stereo16 = 0x1103,

        /// <summary>1 Channel, A-law encoded data. Requires Extension: AL_EXT_ALAW</summary>
        MonoALawExt = 0x10016,

        /// <summary>2 Channels, A-law encoded data. Requires Extension: AL_EXT_ALAW</summary>
        StereoALawExt = 0x10017,

        /// <summary>1 Channel, µ-law encoded data. Requires Extension: AL_EXT_MULAW</summary>
        MonoMuLawExt = 0x10014,

        /// <summary>2 Channels, µ-law encoded data. Requires Extension: AL_EXT_MULAW</summary>
        StereoMuLawExt = 0x10015,

        /// <summary>Ogg Vorbis encoded data. Requires Extension: AL_EXT_vorbis</summary>
        VorbisExt = 0x10003,

        /// <summary>MP3 encoded data. Requires Extension: AL_EXT_mp3</summary>
        Mp3Ext = 0x10020,

        /// <summary>1 Channel, IMA4 ADPCM encoded data. Requires Extension: AL_EXT_IMA4</summary>
        MonoIma4Ext = 0x1300,

        /// <summary>2 Channels, IMA4 ADPCM encoded data. Requires Extension: AL_EXT_IMA4</summary>
        StereoIma4Ext = 0x1301,

        /// <summary>1 Channel, single-precision floating-point data. Requires Extension: AL_EXT_float32</summary>
        MonoFloat32Ext = 0x10010,

        /// <summary>2 Channels, single-precision floating-point data. Requires Extension: AL_EXT_float32</summary>
        StereoFloat32Ext = 0x10011,

        /// <summary>1 Channel, double-precision floating-point data. Requires Extension: AL_EXT_double</summary>
        MonoDoubleExt = 0x10012,

        /// <summary>2 Channels, double-precision floating-point data. Requires Extension: AL_EXT_double</summary>
        StereoDoubleExt = 0x10013,

        /// <summary>Multichannel 5.1, 16-bit data. Requires Extension: AL_EXT_MCFORMATS</summary>
        Multi51Chn16Ext = 0x120B,

        /// <summary>Multichannel 5.1, 32-bit data. Requires Extension: AL_EXT_MCFORMATS</summary>
        Multi51Chn32Ext = 0x120C,

        /// <summary>Multichannel 5.1, 8-bit data. Requires Extension: AL_EXT_MCFORMATS</summary>
        Multi51Chn8Ext = 0x120A,

        /// <summary>Multichannel 6.1, 16-bit data. Requires Extension: AL_EXT_MCFORMATS</summary>
        Multi61Chn16Ext = 0x120E,

        /// <summary>Multichannel 6.1, 32-bit data. Requires Extension: AL_EXT_MCFORMATS</summary>
        Multi61Chn32Ext = 0x120F,

        /// <summary>Multichannel 6.1, 8-bit data. Requires Extension: AL_EXT_MCFORMATS</summary>
        Multi61Chn8Ext = 0x120D,

        /// <summary>Multichannel 7.1, 16-bit data. Requires Extension: AL_EXT_MCFORMATS</summary>
        Multi71Chn16Ext = 0x1211,

        /// <summary>Multichannel 7.1, 32-bit data. Requires Extension: AL_EXT_MCFORMATS</summary>
        Multi71Chn32Ext = 0x1212,

        /// <summary>Multichannel 7.1, 8-bit data. Requires Extension: AL_EXT_MCFORMATS</summary>
        Multi71Chn8Ext = 0x1210,

        /// <summary>Multichannel 4.0, 16-bit data. Requires Extension: AL_EXT_MCFORMATS</summary>
        MultiQuad16Ext = 0x1205,

        /// <summary>Multichannel 4.0, 32-bit data. Requires Extension: AL_EXT_MCFORMATS</summary>
        MultiQuad32Ext = 0x1206,

        /// <summary>Multichannel 4.0, 8-bit data. Requires Extension: AL_EXT_MCFORMATS</summary>
        MultiQuad8Ext = 0x1204,

        /// <summary>1 Channel rear speaker, 16-bit data. See Quadrophonic setups. Requires Extension: AL_EXT_MCFORMATS</summary>
        MultiRear16Ext = 0x1208,

        /// <summary>1 Channel rear speaker, 32-bit data. See Quadrophonic setups. Requires Extension: AL_EXT_MCFORMATS</summary>
        MultiRear32Ext = 0x1209,

        /// <summary>1 Channel rear speaker, 8-bit data. See Quadrophonic setups. Requires Extension: AL_EXT_MCFORMATS</summary>
        MultiRear8Ext = 0x1207,
    }

    ///<summary>A list of valid Int32 GetBuffer parameters</summary>
    public enum ALGetBufferi : int
    {
        ///<summary>Sound sample's frequency, in units of hertz [Hz]. This is the number of samples per second. Half of the sample frequency marks the maximum significant frequency component.</summary>
        Frequency = 0x2001,

        /// <summary>Bit depth of the buffer. Should be 8 or 16.</summary>
        Bits = 0x2002,

        /// <summary>Number of channels in buffer. > 1 is valid, but buffer won’t be positioned when played. 1 for Mono, 2 for Stereo.</summary>
        Channels = 0x2003,

        /// <summary>size of the Buffer in bytes.</summary>
        Size = 0x2004,

        // Deprecated: From Manual, not in header: AL_DATA ( i, iv ) original location where buffer was copied from generally useless, as was probably freed after buffer creation
    }

    ///<summary>Buffer state. Not supported for public use (yet).</summary>
    public enum ALBufferState : int
    {
        ///<summary>Buffer state. Not supported for public use (yet).</summary>
        Unused = 0x2010,

        ///<summary>Buffer state. Not supported for public use (yet).</summary>
        Pending = 0x2011,

        ///<summary>Buffer state. Not supported for public use (yet).</summary>
        Processed = 0x2012,
    }

    /// <summary>Returned by AL.GetError</summary>
    public enum ALError : int
    {
        ///<summary>No OpenAL Error.</summary>
        NoError = 0,

        ///<summary>Invalid Name paramater passed to OpenAL call.</summary>
        InvalidName = 0xA001,

        ///<summary>Invalid parameter passed to OpenAL call.</summary>
        IllegalEnum = 0xA002,
        ///<summary>Invalid parameter passed to OpenAL call.</summary>
        InvalidEnum = 0xA002,

        ///<summary>Invalid OpenAL enum parameter value.</summary>
        InvalidValue = 0xA003,

        ///<summary>Illegal OpenAL call.</summary>
        IllegalCommand = 0xA004,
        ///<summary>Illegal OpenAL call.</summary>
        InvalidOperation = 0xA004,

        ///<summary>No OpenAL memory left.</summary>
        OutOfMemory = 0xA005,
    }

    ///<summary>A list of valid string AL.Get() parameters</summary>
    public enum ALGetString : int
    {
        /// <summary>Gets the Vendor name.</summary>
        Vendor = 0xB001,

        /// <summary>Gets the driver version.</summary>
        Version = 0xB002,

        /// <summary>Gets the renderer mode.</summary>
        Renderer = 0xB003,

        /// <summary>Gets a list of all available Extensions, separated with spaces.</summary>
        Extensions = 0xB004,
    }

    ///<summary>A list of valid 32-bit Float AL.Get() parameters</summary>
    public enum ALGetFloat : int
    {
        ///<summary>Doppler scale. Default 1.0f</summary>
        DopplerFactor = 0xC000,

        ///<summary>Tweaks speed of propagation. This functionality is deprecated.</summary>
        DopplerVelocity = 0xC001,

        ///<summary>Speed of Sound in units per second. Default: 343.3f</summary>
        SpeedOfSound = 0xC003,
    }

    ///<summary>A list of valid Int32 AL.Get() parameters</summary>
    public enum ALGetInteger : int
    {
        ///<summary>See enum ALDistanceModel.</summary><see cref="ALDistanceModel"/>
        DistanceModel = 0xD000,
    }

    /// <summary>Used by AL.DistanceModel(), the distance model can be retrieved by AL.Get() with ALGetInteger.DistanceModel</summary>
    public enum ALDistanceModel : int
    {
        ///<summary>Bypasses all distance attenuation calculation for all Sources.</summary>
        None = 0,

        ///<summary>InverseDistance is equivalent to the IASIG I3DL2 model with the exception that ALSourcef.ReferenceDistance does not imply any clamping.</summary>
        InverseDistance = 0xD001,

        ///<summary>InverseDistanceClamped is the IASIG I3DL2 model, with ALSourcef.ReferenceDistance indicating both the reference distance and the distance below which gain will be clamped.</summary>
        InverseDistanceClamped = 0xD002,

        ///<summary>AL_EXT_LINEAR_DISTANCE extension.</summary>
        LinearDistance = 0xD003,

        ///<summary>AL_EXT_LINEAR_DISTANCE extension.</summary>
        LinearDistanceClamped = 0xD004,

        ///<summary>AL_EXT_EXPONENT_DISTANCE extension.</summary>
        ExponentDistance = 0xD005,

        ///<summary>AL_EXT_EXPONENT_DISTANCE extension.</summary>
        ExponentDistanceClamped = 0xD006,
    }

}
