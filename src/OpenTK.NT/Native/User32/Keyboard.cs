using System.Runtime.InteropServices;
using System.Security;

using HWND = System.IntPtr;

namespace OpenTK.NT.Native
{
    public static partial class User32
    {
        public static class Keyboard
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            internal static extern short GetKeyState([In] VIRTUALKEYS nVirtKey);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            internal static extern short GetAsyncKeyState([In] VIRTUALKEYS vKey);

            [DllImport("user32.dll")]
            public static extern HWND GetFocus();

            [DllImport("user32.dll", SetLastError = true)]
            public static extern HWND SetFocus([In] [Optional] HWND hWnd);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            internal static extern uint MapVirtualKey([In] VIRTUALKEYS vkey, [In] MapVirtualKeyType uMapType);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            internal static extern uint MapVirtualKey([In] uint uCode, [In] MapVirtualKeyType uMapType);
        }
    }
}
