using System.Runtime.InteropServices;

using DWORD = System.UInt32;
using HICON = System.IntPtr;
using TCHAR = System.String;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct SHFileInfo
    {
        public HICON Icon;
        public int IconIndex;
        public DWORD Attributes;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public TCHAR DisplayName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public TCHAR TypeName;

        public static uint SizeInBytes = (uint)Marshal.SizeOf<SHFileInfo>();
    }
}
