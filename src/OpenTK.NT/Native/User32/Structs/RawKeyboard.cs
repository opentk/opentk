using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Contains information about the state of the keyboard.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RawKeyboard
    {
        /// <summary>
        /// Scan code from the key depression. The scan code for keyboard overrun is KEYBOARD_OVERRUN_MAKE_CODE.
        /// </summary>
        //internal USHORT MakeCode;
        internal short MakeCode;

        /// <summary>
        /// Flags for scan code information. It can be one or more of the following.
        /// RI_KEY_MAKE
        /// RI_KEY_BREAK
        /// RI_KEY_E0
        /// RI_KEY_E1
        /// RI_KEY_TERMSRV_SET_LED
        /// RI_KEY_TERMSRV_SHADOW
        /// </summary>
        internal RawInputKeyboardDataFlags Flags;

        /// <summary>
        /// Reserved; must be zero.
        /// </summary>
        private readonly ushort Reserved;

        /// <summary>
        /// Microsoft Windows message compatible virtual-key code. For more information, see Virtual-Key Codes.
        /// </summary>
        //internal USHORT VKey;
        internal VirtualKeys VKey;

        /// <summary>
        /// Corresponding window message, for example WM_KEYDOWN, WM_SYSKEYDOWN, and so forth.
        /// </summary>
        //internal UINT Message;
        internal int Message;

        /// <summary>
        /// Device-specific additional information for the event.
        /// </summary>
        //internal ULONG ExtraInformation;
        internal int ExtraInformation;
    }
}
