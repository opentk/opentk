using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Defines the raw input data coming from the specified keyboard.
    /// </summary>
    /// <remarks>
    /// For the keyboard, the Usage Page is 1 and the Usage is 6.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct RawInputKeyboardDeviceInfo
    {
        /// <summary>
        /// Type of the keyboard.
        /// </summary>
        internal int Type;

        /// <summary>
        /// Subtype of the keyboard.
        /// </summary>
        internal int SubType;

        /// <summary>
        /// Scan code mode.
        /// </summary>
        internal int KeyboardMode;

        /// <summary>
        /// Number of function keys on the keyboard.
        /// </summary>
        internal int NumberOfFunctionKeys;

        /// <summary>
        /// Number of LED indicators on the keyboard.
        /// </summary>
        internal int NumberOfIndicators;

        /// <summary>
        /// Total number of keys on the keyboard.
        /// </summary>
        internal int NumberOfKeysTotal;
    }
}
