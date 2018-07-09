using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RawInput
    {
        public RawInputHeader Header;
        public RawInputData Data;

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<RawInput>();
    }
}
