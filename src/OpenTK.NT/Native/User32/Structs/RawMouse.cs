using System.Runtime.InteropServices;
using OpenToolkit.NT.Native.User32.Enums;
using LONG = System.Int32;
using ULONG = System.UInt32;
using USHORT = System.UInt16;

namespace OpenToolkit.NT.Native.User32.Structs
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
        public ULONG Buttons;

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
        public USHORT ButtonData;

        /// <summary>
        /// Raw state of the mouse buttons.
        /// </summary>
        [FieldOffset(8)]
        public ULONG RawButtons;

        /// <summary>
        /// Motion in the X direction. This is signed relative motion or absolute motion,
        /// depending on the value of <see cref="Flags"/>.
        /// </summary>
        [FieldOffset(12)]
        public LONG LastX;

        /// <summary>
        /// Motion in the Y direction. This is signed relative motion or absolute motion,
        /// depending on the value of <see cref="Flags"/>.
        /// </summary>
        [FieldOffset(16)]
        public LONG LastY;

        /// <summary>
        /// Device-specific additional information for the event.
        /// </summary>
        [FieldOffset(20)]
        public ULONG ExtraInformation;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<RawMouse>();
    }
}
