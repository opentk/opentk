using System.Runtime.InteropServices;

using DWORD = System.UInt32;
using HICON = System.IntPtr;
using TCHAR = System.String;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct SHFILEINFO
    {
        public HICON hIcon;
        public int iIcon;
        public DWORD dwAttributes;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public TCHAR szDisplayName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public TCHAR szTypeName;
    }
}
