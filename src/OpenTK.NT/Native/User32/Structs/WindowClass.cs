using System.Runtime.InteropServices;

using HINSTANCE = System.IntPtr;
using HICON = System.IntPtr;
using HBRUSH = System.IntPtr;
using HCURSOR = System.IntPtr;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WindowClass
    {
        public WindowClassStyleFlags style;
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

        public static int SizeInBytes = Marshal.SizeOf<WindowClass>();
    }
}
