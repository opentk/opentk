using OpenTK.Core;
using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Explicit)]
    public struct RawInputData
    {
        [FieldOffset(0)] internal RAWMOUSE Mouse;
        [FieldOffset(0)] internal RAWKEYBOARD Keyboard;
        [FieldOffset(0)] internal RAWHID HID;

        public static readonly int SizeInBytes =
            BlittableValueType<RawInputData>.Stride;
    }
}
