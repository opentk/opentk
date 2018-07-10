using System.Runtime.InteropServices;

using HICON = System.IntPtr;
using HINSTANCE = System.IntPtr;

namespace OpenTK.NT.Native
{
    public static partial class User32
    {
        public static class Icon
        {
            [DllImport("user32.dll", SetLastError = true)]
            public static extern HICON CreateIconIndirect([In] ref IconInfo iconInfo);

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool DestroyIcon([In] HICON icon);

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetIconInfo([In] HICON icon, [Out] out IconInfo iconInfo);

            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern HICON LoadIcon([In] [Optional] HINSTANCE moduleInstance, [In] string iconName);
        }
    }
}
