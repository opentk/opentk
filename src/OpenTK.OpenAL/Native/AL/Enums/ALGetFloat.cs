namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// A list of valid 32-bit Float AL.Get() parameters
    /// </summary>
    public enum ALGetFloat
    {
        /// <summary>
        /// Doppler scale. Default 1.0f
        /// </summary>
        DopplerFactor = 0xC000,

        /// <summary>
        /// Tweaks speed of propagation. This functionality is deprecated.
        /// </summary>
        DopplerVelocity = 0xC001,

        /// <summary>
        /// Speed of Sound in units per second. Default: 343.3f
        /// </summary>
        SpeedOfSound = 0xC003
    }
}
