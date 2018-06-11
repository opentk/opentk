using System.Runtime.InteropServices;

using HINSTANCE = System.IntPtr;
using HICON = System.IntPtr;
using HBRUSH = System.IntPtr;
using HCURSOR = System.IntPtr;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct WindowClass
    {
        internal WindowClassStyleFlags style;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        internal WindowProc lpfnWndProc;

        internal int cbClsExtra;
        internal int cbWndExtra;

        internal HINSTANCE hInstance;
        internal HICON hIcon;
        internal HCURSOR hCursor;

        internal HBRUSH hbrBackground;

        [MarshalAs(UnmanagedType.LPTStr)]
        internal string lpszMenuName;

        [MarshalAs(UnmanagedType.LPTStr)]
        internal string lpszClassName;

        internal static int SizeInBytes = Marshal.SizeOf<WindowClass>();
    }
}
