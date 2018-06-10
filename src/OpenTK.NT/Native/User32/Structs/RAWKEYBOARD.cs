using System.Runtime.InteropServices;

using UINT = System.UInt32;
using ULONG = System.UInt32;
using USHORT = System.UInt16;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Contains information about the state of the keyboard.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RAWKEYBOARD
    {
        /// <summary>
        /// Scan code from the key depression. The scan code for keyboard overrun is KEYBOARD_OVERRUN_MAKE_CODE.
        /// </summary>
        internal USHORT MakeCode;

        /// <summary>
        /// Flags for scan code information. It can be one or more of the following.
        /// RI_KEY_MAKE
        /// RI_KEY_BREAK
        /// RI_KEY_E0
        /// RI_KEY_E1
        /// RI_KEY_TERMSRV_SET_LED
        /// RI_KEY_TERMSRV_SHADOW
        /// </summary>
        internal RAWKEYBOARD_FLAGS Flags;

        /// <summary>
        /// Reserved; must be zero.
        /// </summary>
        private readonly USHORT Reserved;

        /// <summary>
        /// Microsoft Windows message compatible virtual-key code. For more information, see Virtual-Key Codes.
        /// </summary>
        internal VIRTUALKEYS VKey;

        /// <summary>
        /// Corresponding window message, for example WM_KEYDOWN, WM_SYSKEYDOWN, and so forth.
        /// </summary>
        internal UINT Message;

        /// <summary>
        /// Device-specific additional information for the event.
        /// </summary>
        internal ULONG ExtraInformation;
    }
}
