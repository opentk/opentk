namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Used in <see cref="MapVirtualKeyType"/> to specify the translation to be performed.
    /// </summary>
    public enum MapVirtualKeyType : uint
    {
        /// <summary>
        /// uCode is a virtual-key code and is translated into a scan code. If it is a virtual-key code that does not
        /// distinguish between left- and right-hand keys, the left-hand scan code is returned.
        /// If there is no translation, the function returns 0.
        /// </summary>
        VirtualKeyToScanCode = 0,

        /// <summary>
        /// uCode is a scan code and is translated into a virtual-key code that does not distinguish between left- and
        /// right-hand keys. If there is no translation, the function returns 0.
        /// </summary>
        ScanCodeToVirtualKey = 1,

        /// <summary>
        /// uCode is a virtual-key code and is translated into an unshifted character value in the low-order word of
        /// the return value. Dead keys (diacritics) are indicated by setting the top bit of the return value.
        /// If there is no translation, the function returns 0.
        /// </summary>
        VirtualKeyToCharacter = 2,

        /// <summary>
        /// Windows NT/2000/XP: uCode is a scan code and is translated into a virtual-key code that distinguishes
        /// between left- and right-hand keys. If there is no translation, the function returns 0.
        /// </summary>
        ScanCodeToVirtualKeyExtended = 3,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        VirtualKeyToScanCodeExtended = 4
    }
}
