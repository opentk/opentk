using System.Runtime.InteropServices;

using DWORD = System.UInt32;
using WORD = System.UInt16;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct DeviceMode // unions aren't represented
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;
        public WORD dmSpecVersion;
        public WORD dmDriverVersion;
        public WORD dmSize;
        public WORD dmDriverExtra;
        public DWORD dmFields;

        public Point dmPosition;
        public DWORD dmDisplayOrientation;
        public DWORD dmDisplayFixedOutput;

        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmFormName;
        public WORD dmLogPixels;
        public DWORD dmBitsPerPel;
        public DWORD dmPelsWidth;
        public DWORD dmPelsHeight;

        public DWORD dmDisplayFlags;
        public DWORD dmDisplayFrequency;

        public DWORD dmICMMethod;
        public DWORD dmICMIntent;
        public DWORD dmMediaType;
        public DWORD dmDitherType;
        public DWORD dmReserved1;
        public DWORD dmReserved2;

        public DWORD dmPanningWidth;
        public DWORD dmPanningHeight;

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<DeviceMode>();
    }
}
