namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// A list of valid 32-bit Float Source/GetSource parameters.
    /// </summary>
    public enum ALSourcef
    {
        /// <summary>
        /// Source specific reference distance. Type: float Range: [0.0f - float.PositiveInfinity] At 0.0f, no distance
        /// attenuation occurs. Type: float Default: 1.0f.
        /// </summary>
        ReferenceDistance = 0x1020,

        /// <summary>
        /// Indicate distance above which Sources are not attenuated using the inverse clamped distance model. Default:
        /// float.PositiveInfinity Type: float Range: [0.0f - float.PositiveInfinity].
        /// </summary>
        MaxDistance = 0x1023,

        /// <summary>
        /// Source specific rolloff factor. Type: float Range: [0.0f - float.PositiveInfinity].
        /// </summary>
        RolloffFactor = 0x1021,

        /// <summary>
        /// Specify the pitch to be applied, either at Source, or on mixer results, at Listener. Range: [0.5f - 2.0f]
        /// Default: 1.0f.
        /// </summary>
        Pitch = 0x1003,

        /// <summary>
        /// Indicate the gain (volume amplification) applied. Type: float. Range: [0.0f - ? ] A value of 1.0 means
        /// un-attenuated/unchanged. Each division by 2 equals an attenuation of -6dB. Each multiplicaton with 2 equals an
        /// amplification of +6dB. A value of 0.0f is meaningless with respect to a logarithmic scale; it is interpreted as
        /// zero volume - the channel is effectively disabled.
        /// </summary>
        Gain = 0x100A,

        /// <summary>
        /// Indicate minimum Source attenuation. Type: float Range: [0.0f - 1.0f] (Logarthmic).
        /// </summary>
        MinGain = 0x100D,

        /// <summary>
        /// Indicate maximum Source attenuation. Type: float Range: [0.0f - 1.0f] (Logarthmic).
        /// </summary>
        MaxGain = 0x100E,

        /// <summary>
        /// Directional Source, inner cone angle, in degrees. Range: [0-360] Default: 360.
        /// </summary>
        ConeInnerAngle = 0x1001,

        /// <summary>
        /// Directional Source, outer cone angle, in degrees. Range: [0-360] Default: 360.
        /// </summary>
        ConeOuterAngle = 0x1002,

        /// <summary>
        /// Directional Source, outer cone gain. Default: 0.0f Range: [0.0f - 1.0] (Logarithmic).
        /// </summary>
        ConeOuterGain = 0x1022,

        /// <summary>
        /// The playback position, expressed in seconds.
        /// </summary>
        SecOffset = 0x1024,

        /// <summary>
        /// (EFX Extension) This property is a multiplier on the amount of Air Absorption applied to the Source. The
        /// AL_AIR_ABSORPTION_FACTOR is multiplied by an internal Air Absorption Gain HF value of 0.994 (-0.05dB) per meter
        /// which represents normal atmospheric humidity and temperature. Range [0.0f .. 10.0f] Default: 0.0f.
        /// </summary>
        EfxAirAbsorptionFactor = 0x20007,

        /// <summary>
        /// (EFX Extension) This property is defined the same way as the Reverb Room Rolloff property: it is one of two
        /// methods available in the Effect Extension to attenuate the reflected sound (early reflections and reverberation)
        /// according to source-listener distance. Range [0.0f .. 10.0f] Default: 0.0f.
        /// </summary>
        EfxRoomRolloffFactor = 0x20008,

        /// <summary>
        /// (EFX Extension) A directed Source points in a specified direction. The Source sounds at full volume when the
        /// listener is directly in front of the source; it is attenuated as the listener circles the Source away from the
        /// front. Range [0.0f .. 1.0f] Default: 1.0f.
        /// </summary>
        EfxConeOuterGainHighFrequency = 0x20009
    }
}
