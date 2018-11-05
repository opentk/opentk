using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Contains information about the state of the mouse.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct RawMouse
    {
        /// <summary>
        /// Mouse state.
        /// </summary>
        [FieldOffset(0)]
        public RawMouseFlags Flags;

        /// <summary>
        /// Reserved. Use <see cref="ButtonFlags"/> instead.
        /// </summary>
        [FieldOffset(4)]
        public uint Buttons;

        /// <summary>
        /// The transition state of the mouse buttons.
        /// </summary>
        [FieldOffset(4)]
        public RawMouseButtonFlags ButtonFlags;

        /// <summary>
        /// If <see cref="ButtonFlags"/> is <see cref="RawMouseButtonFlags.Wheel"/>,
        /// this member is a signed value that specifies the wheel delta.
        /// </summary>
        [FieldOffset(6)]
        public ushort ButtonData;

        /// <summary>
        /// Raw state of the mouse buttons.
        /// </summary>
        [FieldOffset(8)]
        public uint RawButtons;

        /// <summary>
        /// Motion in the X direction. This is signed relative motion or absolute motion,
        /// depending on the value of <see cref="Flags"/>.
        /// </summary>
        [FieldOffset(12)]
        public int LastX;

        /// <summary>
        /// Motion in the Y direction. This is signed relative motion or absolute motion,
        /// depending on the value of <see cref="Flags"/>.
        /// </summary>
        [FieldOffset(16)]
        public int LastY;

        /// <summary>
        /// Device-specific additional information for the event.
        /// </summary>
        [FieldOffset(20)]
        public uint ExtraInformation;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<RawMouse>();
    }
}
