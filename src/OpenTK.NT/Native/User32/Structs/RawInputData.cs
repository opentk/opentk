using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Explicit)]
    public struct RawInputData
    {
        [FieldOffset(0)] public RawMouse Mouse;
        [FieldOffset(0)] public RawKeyboard Keyboard;
        [FieldOffset(0)] public RawHid HID;

        public static readonly int SizeInBytes = Marshal.SizeOf<RawInputData>();
    }
}
