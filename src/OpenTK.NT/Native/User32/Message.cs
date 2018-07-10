using System.Runtime.InteropServices;
using System.Security;

using HWND = System.IntPtr;
using LPARAM = System.IntPtr;
using LRESULT = System.IntPtr;
using WPARAM = System.IntPtr;

namespace OpenTK.NT.Native
{
    public static partial class User32
    {
        public static class Message
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool PeekMessage
            (
                [Out] out Msg lpMsg,
                [In] [Optional] HWND hWnd,
                [In] uint wMsgFilterMin,
                [In] uint wMsgFilterMax,
                [In] PeekMessageFlags wRemoveMsg
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport("User32.dll", SetLastError = true)]
            public static extern int GetMessage
            (
                [Out] out Msg msg,
                [In] [Optional] HWND hWnd,
                [In] uint wMsgFilterMin,
                [In] uint wMsgFilterMax
            );

            [DllImport("User32.dll")]
            public static extern int GetMessageTime();

            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern LRESULT SendMessage
            (
                [In] HWND hWnd,
                [In] WindowMessage msg,
                [In] WPARAM wParam,
                [In] LPARAM lParam
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool PostMessage
            (
                [In] [Optional] HWND hWnd,
                [In] WindowMessage msg,
                [In] WPARAM wParam,
                [In] LPARAM lParam
            );

            [DllImport("User32.dll")]
            public static extern void PostQuitMessage([In] int nExitCode);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("User32.dll")]
            public static extern LRESULT DispatchMessage([In] ref Msg lpmsg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("User32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool TranslateMessage([In] ref Msg lpMsg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("User32.dll")]
            public static extern int GetQueueStatus([In] QueueStatusFlags flags);
        }
    }
}
