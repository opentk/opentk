using System.Runtime.InteropServices;

using HBRUSH = System.IntPtr;
using HCURSOR = System.IntPtr;
using HICON = System.IntPtr;
using HINSTANCE = System.IntPtr;
using UINT = System.UInt32;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WindowClassEx
    {
        public UINT Size;

        public WindowClassStyleFlags Style;

        [MarshalAs(UnmanagedType.FunctionPtr)]
        public WindowProc WndProc;

        public int ClsExtra;
        public int WndExtra;

        public HINSTANCE Instance;
        public HICON Icon;
        public HCURSOR Cursor;
        public HBRUSH Background;

        public string MenuName;
        public string ClassName;

        public HICON IconSm;

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<WindowClassEx>();
    }
}
