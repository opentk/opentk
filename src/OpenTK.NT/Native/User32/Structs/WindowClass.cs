using System;
using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct WindowClass
    {
        internal ClassStyle Style;
        [MarshalAs(UnmanagedType.FunctionPtr)] internal WindowProcedure WindowProcedure;
        internal int ClassExtraBytes;

        internal int WindowExtraBytes;

        //[MarshalAs(UnmanagedType.
        internal IntPtr Instance;
        internal IntPtr Icon;
        internal IntPtr Cursor;

        internal IntPtr BackgroundBrush;

        //[MarshalAs(UnmanagedType.LPStr)]
        internal IntPtr MenuName;

        [MarshalAs(UnmanagedType.LPTStr)] internal string ClassName;
        //internal string ClassName;

        internal static int SizeInBytes = Marshal.SizeOf(default(WindowClass));
    }
}
