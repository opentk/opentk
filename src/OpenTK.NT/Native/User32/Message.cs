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
            /// <summary>
            /// Low-level WINAPI function that checks the next message in the queue.
            /// </summary>
            /// <param name="msg">The pending message (if any) is stored here.</param>
            /// <param name="hWnd">Not used</param>
            /// <param name="messageFilterMin">Not used</param>
            /// <param name="messageFilterMax">Not used</param>
            /// <param name="flags">Not used</param>
            /// <returns>True if there is a message pending.</returns>
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

            /// <summary>
            /// Low-level WINAPI function that retrieves the next message in the queue.
            /// </summary>
            /// <param name="msg">The pending message (if any) is stored here.</param>
            /// <param name="windowHandle">Not used</param>
            /// <param name="messageFilterMin">Not used</param>
            /// <param name="messageFilterMax">Not used</param>
            /// <returns>
            /// Nonzero indicates that the function retrieves a message other than WM_QUIT.
            /// Zero indicates that the function retrieves the WM_QUIT message, or that lpMsg is an invalid pointer.
            /// 1 indicates that an error occurred  for example, the function fails if hWnd is an invalid window handle.
            /// To get extended error information, call GetLastError.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport("User32.dll", SetLastError = true)]
            public static extern int GetMessage
            (
                [Out] out Msg msg,
                [In] [Optional] HWND hWnd,
                [In] uint wMsgFilterMin,
                [In] uint wMsgFilterMax
            );

            /// <summary>
            /// Retrieves the message time for the last message retrieved by the
            /// GetMessage function. The time is a long integer that specifies the
            /// elapsed time, in milliseconds, from the time the system was started
            /// to the time the message was created (that is, placed in the thread's
            /// message queue).
            /// </summary>
            /// <returns>The return value specifies the message time.</returns>
            [DllImport("User32.dll")]
            public static extern int GetMessageTime();

            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern LRESULT SendMessage
            (
                [In] HWND hWnd,
                [In] WindowMessage Msg,
                [In] WPARAM wParam,
                [In] LPARAM lParam
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool PostMessage
            (
                [In] [Optional] HWND hWnd,
                [In] WindowMessage Msg,
                [In] WPARAM wParam,
                [In] LPARAM lParam
            );

            [DllImport("User32.dll", CharSet = CharSet.Auto)]
            public static extern void PostQuitMessage([In] int nExitCode);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("User32.dll")]
            public static extern LRESULT DispatchMessage([In] ref Msg lpmsg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("User32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool TranslateMessage([In] ref Msg lpMsg);

            /// <summary>
            /// Indicates the type of messages found in the calling thread's message queue.
            /// </summary>
            /// <param name="flags"></param>
            /// <returns>
            /// The high-order word of the return value indicates the types of messages currently in the queue.
            /// The low-order word indicates the types of messages that have been added to the queue and that are still
            /// in the queue since the last call to the GetQueueStatus, GetMessage, or PeekMessage function.
            /// </returns>
            /// <remarks>
            /// The presence of a QS_ flag in the return value does not guarantee that
            /// a subsequent call to the GetMessage or PeekMessage function will return a message.
            /// GetMessage and PeekMessage perform some internal filtering that may cause the message
            /// to be processed internally. For this reason, the return value from GetQueueStatus
            /// should be considered only a hint as to whether GetMessage or PeekMessage should be called.
            ///  <para>
            /// The QS_ALLPOSTMESSAGE and QS_POSTMESSAGE flags differ in when they are cleared.
            /// QS_POSTMESSAGE is cleared when you call GetMessage or PeekMessage, whether or not you are filtering messages.
            /// QS_ALLPOSTMESSAGE is cleared when you call GetMessage or PeekMessage without filtering messages
            /// (wMsgFilterMin and wMsgFilterMax are 0). This can be useful when you call PeekMessage multiple times
            /// to get messages in different ranges.
            ///  </para>
            /// </remarks>
            [SuppressUnmanagedCodeSecurity]
            [DllImport("User32.dll", CharSet = CharSet.Auto)]
            public static extern int GetQueueStatus([In] QueueStatusFlags flags);
        }
    }
}
