namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// A list of valid Int32 Source parameters.
    /// </summary>
    public enum ALSourcei
    {
        /// <summary>
        /// The playback position, expressed in bytes.
        /// </summary>
        ByteOffset = 0x1026, // AL_EXT_OFFSET extension.

        /// <summary>
        /// The playback position, expressed in samples.
        /// </summary>
        SampleOffset = 0x1025, // AL_EXT_OFFSET extension.

        /// <summary>
        /// Indicate the Buffer to provide sound samples. Type: uint Range: any valid Buffer Handle.
        /// </summary>
        Buffer = 0x1009,

        /// <summary>
        /// Source type (Static, Streaming or undetermined). Use enum AlSourceType for comparison.
        /// </summary>
        SourceType = 0x1027,

        /// <summary>
        /// (EFX Extension) This Source property is used to apply filtering on the direct-path (dry signal) of a Source.
        /// </summary>
        EfxDirectFilter = 0x20005
    }
}
