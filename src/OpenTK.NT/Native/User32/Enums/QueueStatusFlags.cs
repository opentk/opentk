using System;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Queue status flags for GetQueueStatus() and MsgWaitForMultipleObjects()
    /// </summary>
    [Flags]
    internal enum QueueStatusFlags : uint
    {
        /// <summary>
        /// A WM_KEYUP, WM_KEYDOWN, WM_SYSKEYUP, or WM_SYSKEYDOWN message is in the queue.
        /// </summary>
        KEY = 0x0001,

        /// <summary>
        /// A WM_MOUSEMOVE message is in the queue.
        /// </summary>
        MOUSEMOVE = 0x0002,

        /// <summary>
        /// A mouse-button message (WM_LBUTTONUP, WM_RBUTTONDOWN, and so on).
        /// </summary>
        MOUSEBUTTON = 0x0004,

        /// <summary>
        /// A posted message (other than those listed here) is in the queue.
        /// </summary>
        POSTMESSAGE = 0x0008,

        /// <summary>
        /// A WM_TIMER message is in the queue.
        /// </summary>
        TIMER = 0x0010,

        /// <summary>
        /// A WM_PAINT message is in the queue.
        /// </summary>
        PAINT = 0x0020,

        /// <summary>
        /// A message sent by another thread or application is in the queue.
        /// </summary>
        SENDMESSAGE = 0x0040,

        /// <summary>
        /// A WM_HOTKEY message is in the queue.
        /// </summary>
        HOTKEY = 0x0080,

        /// <summary>
        /// A posted message (other than those listed here) is in the queue.
        /// </summary>
        ALLPOSTMESSAGE = 0x0100,

        /// <summary>
        /// A raw input message is in the queue. For more information, see Raw Input.
        /// Windows XP and higher only.
        /// </summary>
        RAWINPUT = 0x0400,

        /// <summary>
        /// A WM_MOUSEMOVE message or mouse-button message (WM_LBUTTONUP, WM_RBUTTONDOWN, and so on).
        /// </summary>
        MOUSE = MOUSEMOVE | MOUSEBUTTON,

        /// <summary>
        /// An input message is in the queue. This is composed of KEY, MOUSE and RAWINPUT.
        /// Windows XP and higher only.
        /// </summary>
        INPUT = MOUSE | KEY | RAWINPUT,

        /// <summary>
        /// An input message is in the queue. This is composed of QS_KEY and QS_MOUSE.
        /// Windows 2000 and earlier.
        /// </summary>
        INPUT_LEGACY = MOUSE | KEY,

        /// <summary>
        /// An input, WM_TIMER, WM_PAINT, WM_HOTKEY, or posted message is in the queue.
        /// </summary>
        ALLEVENTS = INPUT | POSTMESSAGE | TIMER | PAINT | HOTKEY,

        /// <summary>
        /// Any message is in the queue.
        /// </summary>
        ALLINPUT = INPUT | POSTMESSAGE | TIMER | PAINT | HOTKEY | SENDMESSAGE
    }
}
