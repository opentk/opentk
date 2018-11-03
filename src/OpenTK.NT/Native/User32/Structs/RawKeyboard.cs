namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Contains information about the state of the keyboard.
    /// </summary>
    public struct RawKeyboard
    {
        /// <summary>
        /// Scan code from the key depression. The scan code for keyboard overrun is KEYBOARD_OVERRUN_MAKE_CODE.
        /// </summary>
        public ushort MakeCode;

        /// <summary>
        /// Flags for scan code information.
        /// </summary>
        public RawKeyboardScanCodeFlags Flags;

        /// <summary>
        /// Reserved; must be zero.
        /// </summary>
        public ushort Reserved;

        /// <summary>
        /// Microsoft Windows message compatible virtual-key code. For more information, see Virtual-Key Codes.
        /// </summary>
        public VirtualKey VKey;

        /// <summary>
        /// Corresponding window message, for example <see cref="WindowMessage.KeyDown"/>,
        /// <see cref="WindowMessage.SystemKeyDown"/>, and so forth.
        /// </summary>
        public uint Message;

        /// <summary>
        /// Device-specific additional information for the event.
        /// </summary>
        public uint ExtraInformation;
    }
}
