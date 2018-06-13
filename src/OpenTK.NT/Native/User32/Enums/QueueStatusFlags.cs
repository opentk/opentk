using System;

using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Queue status flags for GetQueueStatus() and MsgWaitForMultipleObjects()
    /// </summary>
    [Flags]
    public enum QueueStatusFlags : DWORD
    {
        /// <summary>
        /// A WM_KEYUP, WM_KEYDOWN, WM_SYSKEYUP, or WM_SYSKEYDOWN message is in the queue.
        /// </summary>
        Key = 0x0001,

        /// <summary>
        /// A WM_MOUSEMOVE message is in the queue.
        /// </summary>
        MouseMove = 0x0002,

        /// <summary>
        /// A mouse-button message (WM_LBUTTONUP, WM_RBUTTONDOWN, and so on).
        /// </summary>
        MouseButton = 0x0004,

        /// <summary>
        /// A posted message (other than those listed here) is in the queue.
        /// </summary>
        PostMessage = 0x0008,

        /// <summary>
        /// A WM_TIMER message is in the queue.
        /// </summary>
        Timer = 0x0010,

        /// <summary>
        /// A WM_PAINT message is in the queue.
        /// </summary>
        Paint = 0x0020,

        /// <summary>
        /// A message sent by another thread or application is in the queue.
        /// </summary>
        SendMessage = 0x0040,

        /// <summary>
        /// A WM_HOTKEY message is in the queue.
        /// </summary>
        Hotkey = 0x0080,

        /// <summary>
        /// A posted message (other than those listed here) is in the queue.
        /// </summary>
        AllPostMessage = 0x0100,

        /// <summary>
        /// A raw input message is in the queue. For more information, see Raw Input.
        /// Windows XP and higher only.
        /// </summary>
        RawInput = 0x0400,

        /// <summary>
        /// A WM_MOUSEMOVE message or mouse-button message (WM_LBUTTONUP, WM_RBUTTONDOWN, and so on).
        /// </summary>
        Mouse = MouseMove | MouseButton,

        /// <summary>
        /// An input message is in the queue. This is composed of KEY, MOUSE and RAWINPUT.
        /// Windows XP and higher only.
        /// </summary>
        Input = Mouse | Key | RawInput,

        /// <summary>
        /// An input message is in the queue. This is composed of QS_KEY and QS_MOUSE.
        /// Windows 2000 and earlier.
        /// </summary>
        InputLegacy = Mouse | Key,

        /// <summary>
        /// An input, WM_TIMER, WM_PAINT, WM_HOTKEY, or posted message is in the queue.
        /// </summary>
        AllEvents = Input | PostMessage | Timer | Paint | Hotkey,

        /// <summary>
        /// Any message is in the queue.
        /// </summary>
        AllInput = Input | PostMessage | Timer | Paint | Hotkey | SendMessage
    }
}
