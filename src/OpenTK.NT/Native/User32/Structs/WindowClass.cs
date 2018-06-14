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
        public WindowClassStyleFlags Style;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public WindowProc WndProc;

        public int ClsExtra;
        public int WndExtra;

        public HINSTANCE Instance;
        public HICON Icon;
        public HCURSOR Cursor;

        public HBRUSH Background;

        [MarshalAs(UnmanagedType.LPTStr)]
        public string MenuName;

        [MarshalAs(UnmanagedType.LPTStr)]
        public string ClassName;

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<WindowClass>();
    }
}
