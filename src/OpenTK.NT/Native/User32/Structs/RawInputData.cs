using OpenTK.Core;
using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Explicit)]
    public struct RawInputData
    {
        [FieldOffset(0)] internal RawMouse Mouse;
        [FieldOffset(0)] internal RawKeyboard Keyboard;
        [FieldOffset(0)] internal RawHid HID;

        public static readonly int SizeInBytes =
            BlittableValueType<RawInputData>.Stride;
    }
}
