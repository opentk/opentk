namespace OpenToolkit.OpenAL
{
    /// <summary>
    /// A list of valid 8-bit boolean Source/GetSource parameters.
    /// </summary>
    public enum SourceBoolean
    {
        /// <summary>
        /// Indicate that the Source has relative coordinates. Type: bool Range: [True, False].
        /// </summary>
        SourceRelative = 0x202,

        /// <summary>
        /// Indicate whether the Source is looping. Type: bool Range: [True, False] Default: False.
        /// </summary>
        Looping = 0x1007,
    }
}
