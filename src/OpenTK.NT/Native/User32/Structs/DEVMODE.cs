using System.Runtime.InteropServices;

using DWORD = System.UInt32;
using WORD = System.UInt16;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class DEVMODE // unions aren't represented
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        internal string DeviceName;
        internal WORD dmSpecVersion;
        internal WORD dmDriverVersion;
        internal readonly WORD dmSize = (ushort)Marshal.SizeOf(typeof(DEVMODE));
        internal WORD dmDriverExtra;
        internal DWORD dmFields;

        internal POINT dmPosition;
        internal DWORD dmDisplayOrientation;
        internal DWORD dmDisplayFixedOutput;

        internal short dmColor;
        internal short dmDuplex;
        internal short dmYResolution;
        internal short dmTTOption;
        internal short dmCollate;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        internal string dmFormName;
        internal WORD dmLogPixels;
        internal DWORD dmBitsPerPel;
        internal DWORD dmPelsWidth;
        internal DWORD dmPelsHeight;

        internal DWORD dmDisplayFlags;
        internal DWORD dmDisplayFrequency;

        internal DWORD dmICMMethod;
        internal DWORD dmICMIntent;
        internal DWORD dmMediaType;
        internal DWORD dmDitherType;
        internal DWORD dmReserved1;
        internal DWORD dmReserved2;

        internal DWORD dmPanningWidth;
        internal DWORD dmPanningHeight;
    }
}
