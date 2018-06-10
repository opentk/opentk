namespace OpenTK.NT.Native
{
    public enum RAWKEYBOARD_FLAGS : ushort
    {
        /// <summary>
        /// The key is down.
        /// </summary>
        MAKE = 0x0,

        /// <summary>
        /// The key is up.
        /// </summary>
        BREAK = 0x1,

        /// <summary>
        /// The scan code has the E0 prefix.
        /// </summary>
        E0 = 0x2,

        /// <summary>
        /// The scan code has the E1 prefix.
        /// </summary>
        E1 = 0x4,

        TERMSRV_SET_LED = 0x8,
        TERMSRV_SHADOW = 0x10
    }
}
