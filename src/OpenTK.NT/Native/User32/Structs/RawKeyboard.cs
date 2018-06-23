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
    public struct RawKeyboard
    {
        /// <summary>
        /// Scan code from the key depression. The scan code for keyboard overrun is KEYBOARD_OVERRUN_MAKE_CODE.
        /// </summary>
        public USHORT MakeCode;

        /// <summary>
        /// Flags for scan code information.
        /// </summary>
        public RawKeyboardFlags Flags;

        /// <summary>
        /// Reserved; must be zero.
        /// </summary>
        private readonly USHORT Reserved;

        /// <summary>
        /// Microsoft Windows message compatible virtual-key code. For more information, see Virtual-Key Codes.
        /// </summary>
        public VirtualKeys VKey;

        /// <summary>
        /// Corresponding window message, for example WM_KEYDOWN, WM_SYSKEYDOWN, and so forth.
        /// </summary>
        public UINT Message;

        /// <summary>
        /// Device-specific additional information for the event.
        /// </summary>
        public ULONG ExtraInformation;
    }
}
