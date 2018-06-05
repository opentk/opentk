using System;
using System.Runtime.InteropServices;

using HBRUSH = System.IntPtr;
using HCURSOR = System.IntPtr;
using HICON = System.IntPtr;
using HINSTANCE = System.IntPtr;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    internal struct ExtendedWindowClass
    {
        public uint Size;

        public ClassStyle Style;

        //public WNDPROC WndProc;
        [MarshalAs(UnmanagedType.FunctionPtr)] public WindowProcedure WndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public HINSTANCE Instance;
        public HICON Icon;
        public HCURSOR Cursor;
        public HBRUSH Background;
        public IntPtr MenuName;
        public IntPtr ClassName;
        public HICON IconSm;

        public static uint SizeInBytes = (uint)Marshal.SizeOf(default(ExtendedWindowClass));
    }
}
