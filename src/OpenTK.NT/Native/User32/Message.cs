using System;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenToolkit.NT.Native
{
    public static partial class User32
    {
        /// <summary>
        /// Provides a subset of functions from the Windows API,
        /// specifically those imported from user32.dll that deal with messages.
        /// </summary>
        public static class Message
        {
            /// <summary>
            /// A special constant value that can be used to send a message to all top-level windows, including
            /// disabled or invisible unowned windows, overlapped windows, and pop-up windows;
            /// but not to child windows.
            /// </summary>
            public static readonly IntPtr BroadcastHandle = new IntPtr(0xFFFF);

            /// <summary>
            /// Dispatches incoming sent messages, checks the thread message queue for a posted message,
            /// and retrieves the message (if any exist).
            /// </summary>
            /// <param name="msg">A <see cref="Msg"/> structure that receives message information.</param>
            /// <param name="window">
            /// A handle to the window whose messages are to be retrieved.
            /// The window must belong to the current thread.<para/>
            /// If <paramref name="window"/> is <see cref="IntPtr.Zero"/>,
            /// <see cref="PeekMessage(out Msg, IntPtr, uint, uint, PeekMessageActions)"/> retrieves messages for any
            /// window that belongs to the current thread, and any messages on the current thread's message queue whose
            /// <paramref name="window"/> value is <see cref="IntPtr.Zero"/> (see the <see cref="Msg"/> structure).
            /// Therefore if <paramref name="window"/> is <see cref="IntPtr.Zero"/>, both window messages
            /// and thread messages are processed.<para/>
            /// If <paramref name="window"/> is -1,
            /// <see cref="PeekMessage(out Msg, IntPtr, uint, uint, PeekMessageActions)"/> retrieves only messages on the
            /// current thread's message queue whose <paramref name="window"/> value is <see cref="IntPtr.Zero"/>,
            /// that is, thread messages as posted by <see cref="PostMessage(IntPtr, WindowMessage, IntPtr, IntPtr)"/>
            /// (when the window parameter is <see cref="IntPtr.Zero"/>) or PostThreadMessage.
            /// </param>
            /// <param name="messageFilterMin">
            /// The value of the first message in the range of messages to be examined.
            /// Use <see cref="WindowMessage.KeyFirst"/> to specify the first keyboard message or
            /// <see cref="WindowMessage.MouseFirst"/> to specify the first mouse message.<para/>
            /// If <paramref name="messageFilterMin"/> and <paramref name="messageFilterMax"/> are both zero,
            /// <see cref="PeekMessage(out Msg, IntPtr, uint, uint, PeekMessageActions)"/> returns all available messages
            /// (that is, no range filtering is performed).
            /// </param>
            /// <param name="messageFilterMax">
            /// The value of the last message in the range of messages to be examined. Use
            /// <see cref="WindowMessage.KeyLast"/> to specify the last keyboard message or
            /// <see cref="WindowMessage.MouseLast"/> to specify the last mouse message.<para/>
            /// If <paramref name="messageFilterMin"/> and <paramref name="messageFilterMax"/> are both zero,
            /// <see cref="PeekMessage(out Msg, IntPtr, uint, uint, PeekMessageActions)"/> returns all available messages
            /// (that is, no range filtering is performed).
            /// </param>
            /// <param name="messageActions">Specifies how messages are to be handled.</param>
            /// <returns>
            /// If a message is available, the return value is true.<para/>
            /// If no messages are available, the return value is false.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool PeekMessage
            (
                [Out] out Msg msg,
                [In] [Optional] IntPtr window,
                [In] uint messageFilterMin,
                [In] uint messageFilterMax,
                [In] PeekMessageActions messageActions
            );

            /// <summary>
            /// Retrieves a message from the calling thread's message queue. The function dispatches
            /// incoming sent messages until a posted message is available for retrieval.<para/>
            /// Unlike <see cref="GetMessage(out Msg, IntPtr, uint, uint)"/>, the
            /// <see cref="PeekMessage(out Msg, IntPtr, uint, uint, PeekMessageActions)"/> function does not wait
            /// for a message to be posted before returning.
            /// </summary>
            /// <param name="msg">
            /// An <see cref="Msg"/> structure that receives message information from the thread's message queue.
            /// </param>
            /// <param name="window">
            /// A handle to the window whose messages are to be retrieved.
            /// The window must belong to the current thread.<para/>
            /// If <paramref name="window"/> is <see cref="IntPtr.Zero"/>,
            /// <see cref="PeekMessage(out Msg, IntPtr, uint, uint, PeekMessageActions)"/> retrieves messages for any
            /// window that belongs to the current thread, and any messages on the current thread's message queue whose
            /// <paramref name="window"/> value is <see cref="IntPtr.Zero"/> (see the <see cref="Msg"/> structure).
            /// Therefore if <paramref name="window"/> is <see cref="IntPtr.Zero"/>, both window messages
            /// and thread messages are processed.<para/>
            /// If <paramref name="window"/> is -1,
            /// <see cref="PeekMessage(out Msg, IntPtr, uint, uint, PeekMessageActions)"/> retrieves only messages on the
            /// current thread's message queue whose <paramref name="window"/> value is <see cref="IntPtr.Zero"/>,
            /// that is, thread messages as posted by <see cref="PostMessage(IntPtr, WindowMessage, IntPtr, IntPtr)"/>
            /// (when the window parameter is <see cref="IntPtr.Zero"/>) or PostThreadMessage.
            /// </param>
            /// <param name="messageFilterMin">
            /// The value of the first message in the range of messages to be examined.
            /// Use <see cref="WindowMessage.KeyFirst"/> to specify the first keyboard message or
            /// <see cref="WindowMessage.MouseFirst"/> to specify the first mouse message.<para/>
            /// Use <see cref="WindowMessage.Input"/> here and in <paramref name="messageFilterMax"/> to specify only
            /// the <see cref="WindowMessage.Input"/> messages.<para/>
            /// If <paramref name="messageFilterMin"/> and <paramref name="messageFilterMax"/> are both zero,
            /// <see cref="PeekMessage(out Msg, IntPtr, uint, uint, PeekMessageActions)"/> returns all available messages
            /// (that is, no range filtering is performed).
            /// </param>
            /// <param name="messageFilterMax">
            /// The value of the last message in the range of messages to be examined. Use
            /// <see cref="WindowMessage.KeyLast"/> to specify the last keyboard message or
            /// <see cref="WindowMessage.MouseLast"/> to specify the last mouse message.<para/>
            /// Use <see cref="WindowMessage.Input"/> here and in <paramref name="messageFilterMin"/> to specify only
            /// the <see cref="WindowMessage.Input"/> messages.<para/>
            /// If <paramref name="messageFilterMin"/> and <paramref name="messageFilterMax"/> are both zero,
            /// <see cref="PeekMessage(out Msg, IntPtr, uint, uint, PeekMessageActions)"/> returns all available messages
            /// (that is, no range filtering is performed).
            /// </param>
            /// <returns>
            /// If the function retrieves a message other than <see cref="WindowMessage.Quit"/>,
            /// the return value is true.<para/>
            /// If the function retrieves the <see cref="WindowMessage.Quit"/> message, the return value is false.
            /// <para/>
            /// If there is an error, the return value is -1. For example, the function fails if
            /// <paramref name="window"/> is an invalid window handle or <paramref name="msg"/> is an invalid pointer.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            public static extern int GetMessage
            (
                [Out] out Msg msg,
                [In] [Optional] IntPtr window,
                [In] uint messageFilterMin,
                [In] uint messageFilterMax
            );

            /// <summary>
            /// Retrieves the message time for the last message retrieved by the
            /// <see cref="GetMessage(out Msg, IntPtr, uint, uint)"/> function. The time is a long integer that
            /// specifies the elapsed time, in milliseconds, from the time the system was started to the time the
            /// message was created (that is, placed in the thread's message queue).
            /// </summary>
            /// <returns>The return value specifies the message time.</returns>
            [DllImport(Library)]
            public static extern int GetMessageTime();

            /// <summary>
            /// Sends the specified message to a window or windows. The
            /// <see cref="SendMessage(IntPtr, WindowMessage, IntPtr, IntPtr)"/> function calls the window procedure for the
            /// specified window and does not return until the window procedure has processed the message.
            /// </summary>
            /// <param name="window">
            /// A handle to the window whose window procedure will receive the message.<para/>
            /// Message sending is subject to UIPI. The thread of a process can send messages only to message queues
            /// of threads in processes of lesser or equal integrity level.
            /// </param>
            /// <param name="msg">The message to be sent.</param>
            /// <param name="wparam">Additional message-specific information.</param>
            /// <param name="lparam">Additional message-specific information.</param>
            /// <returns>
            /// The return value specifies the result of the message processing; it depends on the message sent.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            public static extern IntPtr SendMessage
            (
                [In] IntPtr window,
                [In] WindowMessage msg,
                [In] IntPtr wparam,
                [In] IntPtr lparam
            );

            /// <summary>
            /// Sends a message to all top-level windows in the system, including disabled or invisible unowned
            /// windows, overlapped windows, and pop-up windows; but not to child windows.
            /// </summary>
            /// <param name="msg">The message to be sent.</param>
            /// <param name="wparam">Additional message-specific information.</param>
            /// <param name="lparam">Additional message-specific information.</param>
            /// <returns>
            /// The return value specifies the result of the message processing; it depends on the message sent.
            /// </returns>
            /// <remarks>
            /// This method uses the constant <see cref="BroadcastHandle"/> for this special behavior.
            /// </remarks>
            public static IntPtr SendMessageAsBroadcast(WindowMessage msg, IntPtr wparam, IntPtr lparam)
            {
                return SendMessage(BroadcastHandle, msg, wparam, lparam);
            }

            /// <summary>
            /// Places (posts) a message in the message queue associated with the thread that created the specified
            /// window and returns without waiting for the thread to process the message.
            /// </summary>
            /// <param name="window">
            /// A handle to the window whose window procedure is to receive the message.<para/>
            /// Starting with Windows Vista, message posting is subject to UIPI. The thread of a process can post
            /// messages only to message queues of threads in processes of lesser or equal integrity level.<para/>
            /// If <paramref name="window"/> is <see cref="IntPtr.Zero"/>, this function will behave like a call to
            /// PostThreadMessage with the dwThreadId parameter set to the identifier of the current thread.
            /// </param>
            /// <param name="msg">The message to be posted.</param>
            /// <param name="wparam">Additional message-specific information.</param>
            /// <param name="lparam">Additional message-specific information.</param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool PostMessage
            (
                [In] [Optional] IntPtr window,
                [In] WindowMessage msg,
                [In] IntPtr wparam,
                [In] IntPtr lparam
            );

            /// <summary>
            /// Places (posts) a message to all top-level windows in the system, including disabled or invisible
            /// unowned windows, overlapped windows, and pop-up windows. The message is not posted to child windows.
            /// </summary>
            /// <param name="msg">The message to be posted.</param>
            /// <param name="wparam">Additional message-specific information.</param>
            /// <param name="lparam">Additional message-specific information.</param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            /// <remarks>
            /// This method uses the constant <see cref="BroadcastHandle"/> for this special behavior.
            /// </remarks>
            public static bool PostMessageAsBroadcast(WindowMessage msg, IntPtr wparam, IntPtr lparam)
            {
                return PostMessage(BroadcastHandle, msg, wparam, lparam);
            }

            /// <summary>
            /// Indicates to the system that a thread has made a request to terminate (quit).
            /// It is typically used in response to a <see cref="WindowMessage.Destroy"/> message.
            /// </summary>
            /// <param name="exitCode">
            /// The application exit code. This value is used as the
            /// wParam parameter of the <see cref="WindowMessage.Quit"/> message.
            /// </param>
            [DllImport(Library)]
            public static extern void PostQuitMessage([In] int exitCode);

            /// <summary>
            /// Dispatches a message to a window procedure. It is typically used to
            /// dispatch a message retrieved by the <see cref="GetMessage(out Msg, IntPtr, uint, uint)"/> function.
            /// </summary>
            /// <param name="msg">A structure that contains the message.</param>
            /// <returns>
            /// The return value specifies the value returned by the window procedure.
            /// Although its meaning depends on the message being dispatched, the return value generally is ignored.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library)]
            public static extern IntPtr DispatchMessage([In] ref Msg msg);

            /// <summary>
            /// Translates virtual-key messages into character messages. The character messages are posted to the
            /// calling thread's message queue, to be read the next time the thread calls the
            /// <see cref="GetMessage(out Msg, IntPtr, uint, uint)"/> or
            /// <see cref="PeekMessage(out Msg, IntPtr, uint, uint, PeekMessageActions)"/> function.
            /// </summary>
            /// <param name="msg">
            /// An <see cref="Msg"/> structure that contains message information retrieved from the
            /// calling thread's message queue by using the <see cref="GetMessage(out Msg, IntPtr, uint, uint)"/> or
            /// <see cref="PeekMessage(out Msg, IntPtr, uint, uint, PeekMessageActions)"/> function.
            /// </param>
            /// <returns>
            /// If the message is translated (that is, a character message is posted to the thread's message queue),
            /// the return value is true.<para/>
            /// If the message is <see cref="WindowMessage.KeyDown"/>, <see cref="WindowMessage.KeyUp"/>,
            /// <see cref="WindowMessage.SystemKeyDown"/>, or <see cref="WindowMessage.SystemKeyUp"/>,
            /// the return value is true, regardless of the translation.<para/>
            /// If the message is not translated (that is, a character message is not posted to the
            /// thread's message queue), the return value is false.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool TranslateMessage([In] ref Msg msg);

            /// <summary>
            /// Retrieves the type of messages found in the calling thread's message queue.
            /// </summary>
            /// <param name="flags">The types of messages for which to check.</param>
            /// <returns>
            /// The high-order word of the return value indicates the types of messages currently in the queue.
            /// The low-order word indicates the types of messages that have been added to the queue and that are
            /// still in the queue since the last call to the <see cref="GetQueueStatus(QueueMessageTypes)"/>,
            /// <see cref="GetMessage(out Msg, IntPtr, uint, uint)"/>, or
            /// <see cref="PeekMessage(out Msg, IntPtr, uint, uint, PeekMessageActions)"/> function.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library)]
            public static extern uint GetQueueStatus([In] QueueMessageTypes flags);
        }
    }
}
