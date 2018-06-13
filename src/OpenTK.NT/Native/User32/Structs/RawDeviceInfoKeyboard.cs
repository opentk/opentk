using System.Runtime.InteropServices;

using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Defines the raw input data coming from the specified keyboard.
    /// </summary>
    /// <remarks>
    /// For the keyboard, the Usage Page is 1 and the Usage is 6.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct RawDeviceInfoKeyboard
    {
        /// <summary>
        /// Type of the keyboard.
        /// </summary>
        public DWORD dwType;

        /// <summary>
        /// Subtype of the keyboard.
        /// </summary>
        public DWORD dwSubType;

        /// <summary>
        /// Scan code mode.
        /// </summary>
        public DWORD dwKeyboardMode;

        /// <summary>
        /// Number of function keys on the keyboard.
        /// </summary>
        public DWORD dwNumberOfFunctionKeys;

        /// <summary>
        /// Number of LED indicators on the keyboard.
        /// </summary>
        public DWORD dwNumberOfIndicators;

        /// <summary>
        /// Total number of keys on the keyboard.
        /// </summary>
        public DWORD dwNumberOfKeysTotal;
    }
}
