using DWORD = System.UInt32;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Defines the raw input data coming from the specified keyboard.
    /// </summary>
    /// <remarks>
    /// For the keyboard, the Usage Page is 1 and the Usage is 6.
    /// </remarks>
    public struct RawInputDeviceInfoKeyboard
    {
        /// <summary>
        /// Type of the keyboard.
        /// </summary>
        public DWORD Type;

        /// <summary>
        /// Subtype of the keyboard.
        /// </summary>
        public DWORD SubType;

        /// <summary>
        /// Scan code mode.
        /// </summary>
        public DWORD KeyboardMode;

        /// <summary>
        /// Number of function keys on the keyboard.
        /// </summary>
        public DWORD NumberOfFunctionKeys;

        /// <summary>
        /// Number of LED indicators on the keyboard.
        /// </summary>
        public DWORD NumberOfIndicators;

        /// <summary>
        /// Total number of keys on the keyboard.
        /// </summary>
        public DWORD NumberOfKeysTotal;
    }
}
