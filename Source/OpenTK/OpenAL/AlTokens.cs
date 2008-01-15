#region --- OpenTK.OpenAL License ---
/* AlTokens.cs
 * C header: \OpenAL 1.1 SDK\include\Al.h
 * Spec: http://www.openal.org/openal_webstf/specs/OpenAL11Specification.pdf
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */
#endregion

using System;

namespace OpenTK.OpenAL.Enums
{

    public enum ALCapability : int
    {
        ///<summary>Currently no state toggles exist for vanilla OpenAL.</summary>
        Invalid = -1,
    }

    public enum ALListenerf : int
    {
        ///<summary>Indicate the gain (volume amplification) applied. Type: float. Range: [0.0f - ? ] A value of 1.0 means un-attenuated/unchanged. Each division by 2 equals an attenuation of -6dB. Each multiplicaton with 2 equals an amplification of +6dB. A value of 0.0f is meaningless with respect to a logarithmic scale; it is interpreted as zero volume - the channel is effectively disabled.</summary>
        Gain = 0x100A,
    }

    public enum ALListener3f : int
    {
        ///<summary>Specify the current location in three dimensional space. OpenAL, like OpenGL, uses a right handed coordinate system, where in a frontal default view X (thumb) points right, Y points up (index finger), and Z points towards the viewer/camera (middle finger). To switch from a left handed coordinate system, flip the sign on the Z coordinate. Listener position is always in the world coordinate system.</summary>
        Position = 0x1004,

        ///<summary>Specify the current velocity in three dimensional space.</summary>
        Velocity = 0x1006,
    }

    public enum ALListenerfv : int
    {
        ///<summary>Indicate Listener orientation. (at/up)</summary>
        Orientation = 0x100F,
    }

    public enum ALSourcef : int
    {
        ///<summary>Source specific reference distance. Type: float Range: [0.0f - float.PositiveInfinity] At 0.0f, no distance attenuation occurs.  Default is 1.0.</summary>
        ReferenceDistance = 0x1020,

        ///<summary>Indicate distance above which Sources are not attenuated using the inverse clamped distance model. Default: float.PositiveInfinity Type: ALfloat Range: [0.0f - float.PositiveInfinity]</summary>
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
    }

    public enum ALSource3f : int
    {
        ///<summary>Specify the current location in three dimensional space. OpenAL, like OpenGL, uses a right handed coordinate system, where in a frontal default view X (thumb) points right, Y points up (index finger), and Z points towards the viewer/camera (middle finger). To switch from a left handed coordinate system, flip the sign on the Z coordinate. Listener position is always in the world coordinate system.</summary>
        Position = 0x1004,

        ///<summary>Specify the current velocity in three dimensional space.</summary>
        Velocity = 0x1006,

        ///<summary>Specify the current direction vector.</summary>
        Direction = 0x1005,
    }

    public enum ALSourceb : int
    {
        ///<summary>Indicate Source has relative coordinates.</summary>
        SourceRelative = 0x202,

        ///<summary>Indicate whether Source is looping. Type: Al.Bool Range: [True, False] Default: False.</summary>
        Looping = 0x1007,
    }

    public enum ALSourcei : int
    {
        ///<summary>The playback position, expressed in bytes.</summary>
        ByteOffset = 0x1026,  // AL_EXT_OFFSET extension.

        ///<summary>The playback position, expressed in samples.</summary>
        SampleOffset = 0x1025, // AL_EXT_OFFSET extension.

        ///<summary>Indicate the Buffer to provide sound samples. Type: uint Range: any valid Buffer id.</summary>
        Buffer = 0x1009,

        ///<summary>Source type (Static, Streaming or undetermined). Use enum AlSourceType for comparison</summary>
        SourceType = 0x1027,
    }

    public enum ALSourceiGet : int
    {
        ///<summary>The playback position, expressed in bytes.</summary>
        ByteOffset = 0x1026,  // AL_EXT_OFFSET extension.

        ///<summary>The playback position, expressed in samples.</summary>
        SampleOffset = 0x1025, // AL_EXT_OFFSET extension.

        ///<summary>Indicate the Buffer to provide sound samples. Type: uint Range: any valid Buffer id.</summary>
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

    public enum ALDeprecated : int
    {
        ///<summary>Deprecated. Specify the channel mask. (Creative) Type: uint Range: [0 - 255]</summary>
        ChannelMask = 0x3000,
    }

    ///<summary>Source state information.</summary>
    public enum ALSourceState : int
    {
        ///<summary>Default State when loaded, can be manually set with Al.SourceRewind().</summary>
        Initial = 0x1011,
        ///<summary>The source is currently playing.</summary>
        Playing = 0x1012,
        ///<summary>The source has paused playback.</summary>
        Paused = 0x1013,
        ///<summary>The source is not playing.</summary>
        Stopped = 0x1014,
    }

    ///<summary>Source type (Static, Streaming or undetermined)</summary>
    public enum ALSourceType : int
    {
        ///<summary>Source is Static if a Buffer has been attached using AL_Buffer</summary>
        Static = 0x1028,
        ///<summary>Source is Streaming if one or more Buffers have been attached using alSourceQueueBuffers</summary>
        Streaming = 0x1029,
        ///<summary>Source is undetermined when it has the NULL Buffer attached</summary>
        Undetermined = 0x1030,
    }

    ///<summary>Sound samples: Format specifier.</summary>
    public enum ALFormat : int
    {
        ///<summary>1 Channel, 8 Bit.</summary>
        FormatMono8 = 0x1100,

        ///<summary>1 Channel, 16 Bit.</summary>
        FormatMono16 = 0x1101,

        ///<summary>2 Channels, 8 Bit each.</summary>
        FormatStereo8 = 0x1102,

        ///<summary>2 Channels, 16 Bit each.</summary>
        FormatStereo16 = 0x1103,
    }

    public enum ALGetBufferi : int
    {
        ///<summary>Sound sample's frequency, in units of Hertz [Hz]. This is the number of samples per second. Half of the sample frequency marks the maximum significant frequency component.</summary>
        Frequency = 0x2001,
        /// <summary>Bit depth of buffer. Should be 8 or 16.</summary>
        Bits = 0x2002,
        /// <summary>Number of channels in buffer. > 1 is valid, but buffer won’t be positioned when played. 1 for Mono, 2 for Stereo.</summary>
        Channels = 0x2003,
        /// <summary>size of buffer in bytes</summary>
        Size = 0x2004,

        // From Manual, not in header: AL_DATA ( i, iv ) original location where data was copied from generally useless, as was probably freed after buffer creation
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

    public enum ALError : int // alGetString
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

        ///<summary>No mojo. No OpenAL Memory left.</summary>
        OutOfMemory = 0xA005,
    }

    public enum ALGetString : int // alGetString
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

    public enum ALGetFloat : int
    {
        ///<summary>Doppler scale.  Default 1.0f</summary>
        DopplerFactor = 0xC000,

        ///<summary>Tweaks speed of propagation. This functionality is deprecated.</summary>
        DopplerVelocity = 0xC001,

        ///<summary>Speed of Sound in units per second. default value 343.3f</summary>
        SpeedOfSound = 0xC003,
    }

    public enum ALGetInteger : int
    {
        ///<summary>See enum AlDistanceModel.</summary><see cref="AlDistanceModels"/>
        DistanceModel = 0xD000,
    }

    public enum ALDistanceModel : int // used in conjunction with Al.DistanceModel
    {
        ///<summary>bypasses all distance attenuation calculation for all sources.</summary>
        None = 0,

        ///<summary>InverseDistance is equivalent to the IASIG I3DL2 model with the exception that AL_REFERENCE_DISTANCE does not imply any clamping.</summary>
        InverseDistance = 0xD001,
        ///<summary>InverseDistanceClamped is the IASIG I3DL2 model, with AL_REFERENCE_DISTANCE indicating both the reference distance and the distance below which gain will be clamped.</summary>
        InverseDistanceClamped = 0xD002,
        ///<summary></summary>
        LinearDistance = 0xD003, // AL_EXT_LINEAR_DISTANCE extension.
        ///<summary></summary>
        LinearDistanceClamped = 0xD004, // AL_EXT_LINEAR_DISTANCE extension.
        ///<summary></summary>
        ExponentDistance = 0xD005, // AL_EXT_EXPONENT_DISTANCE extension.
        ///<summary></summary>
        ExponentDistanceClamped = 0xD006, // AL_EXT_EXPONENT_DISTANCE extension.
    }

}
