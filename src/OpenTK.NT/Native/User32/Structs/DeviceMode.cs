using System.Runtime.InteropServices;

using DWORD = System.UInt32;
using WORD = System.UInt16;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DeviceMode // unions aren't represented
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;
        public WORD SpecVersion;
        public WORD DriverVersion;
        public WORD Size;
        public WORD DriverExtra;
        public DeviceModeFieldFlags Fields;

        public Point Position;
        public DWORD DisplayOrientation;
        public DWORD DisplayFixedOutput;

        public short Color;
        public short Duplex;
        public short YResolution;
        public short TTOption;
        public short Collate;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string FormName;
        public WORD LogPixels;
        public DWORD BitsPerPel;
        public DWORD PelsWidth;
        public DWORD PelsHeight;

        public DWORD DisplayFlags;
        public DWORD DisplayFrequency;

        public DWORD ICMMethod;
        public DWORD ICMIntent;
        public DWORD MediaType;
        public DWORD DitherType;
        public DWORD Reserved1;
        public DWORD Reserved2;

        public DWORD PanningWidth;
        public DWORD PanningHeight;

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<DeviceMode>();
    }
}
