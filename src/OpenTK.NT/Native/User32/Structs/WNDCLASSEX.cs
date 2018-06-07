using System.Runtime.InteropServices;

using HBRUSH = System.IntPtr;
using HCURSOR = System.IntPtr;
using HICON = System.IntPtr;
using HINSTANCE = System.IntPtr;
using UINT = System.UInt32;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    internal struct WNDCLASSEX
    {
        public UINT cbSize;

        public ClassStyle style;

        //public WNDPROC WndProc;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public WindowProc lpfnWndProc;

        public int cbClsExtra;
        public int cbWndExtra;

        public HINSTANCE hInstance;
        public HICON hIcon;
        public HCURSOR hCursor;
        public HBRUSH hbrBackground;

        [MarshalAs(UnmanagedType.LPTStr)]
        public string lpszMenuName;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string lpszClassName;

        public HICON hIconSm;

        public static uint SizeInBytes = (uint)Marshal.SizeOf(default(WNDCLASSEX));
    }
}
