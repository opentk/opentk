namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// A list of valid 32-bit Float Listener/GetListener parameters
    /// </summary>
    public enum ALListenerf
    {
        /// <summary>
        /// Indicate the gain (Volume amplification) applied. Type: float Range: [0.0f - ? ] A value of 1.0 means
        /// un-attenuated/unchanged. Each division by 2 equals an attenuation of -6dB. Each multiplicaton with 2 equals an
        /// amplification of +6dB. A value of 0.0f is interpreted as zero volume and the channel is effectively disabled.
        /// </summary>
        Gain = 0x100A,

        /// <summary>
        /// (EFX Extension) This setting is critical if Air Absorption effects are enabled because the amount of Air
        /// Absorption applied is directly related to the real-world distance between the Source and the Listener. centimeters
        /// 0.01f meters 1.0f kilometers 1000.0f Range [float.MinValue .. float.MaxValue] Default: 1.0f
        /// </summary>
        EfxMetersPerUnit = 0x20004
    }
}
