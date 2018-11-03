namespace OpenToolkit.OpenAL
{
    /// <summary>
    /// A list of valid 32-bit Float AL.Get() parameters.
    /// </summary>
    public enum StateFloat
    {
        /// <summary>
        /// Doppler scale. Default 1.0f.
        /// </summary>
        DopplerFactor = 0xC000,

        /// <summary>
        /// Speed of Sound in units per second. Default: 343.3f.
        /// </summary>
        SpeedOfSound = 0xC003
    }
}
