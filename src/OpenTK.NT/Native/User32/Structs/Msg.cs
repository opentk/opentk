using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Contains message information from a thread's message queue.
    /// </summary>
    public struct Msg
    {
        /// <summary>
        /// A handle to the window whose window procedure receives the message. This member is
        /// <see cref="System.IntPtr.Zero"/> when the message is a thread message.
        /// </summary>
        public IntPtr HWnd;

        /// <summary>
        /// The message identifier. Applications can only use the low word; the high word is reserved by the system.
        /// </summary>
        public WindowMessage Message;

        /// <summary>
        /// Additional information about the message.The exact meaning depends on the value of the
        /// <see cref="Message"/> member.
        /// </summary>
        public IntPtr WParam;

        /// <summary>
        /// Additional information about the message.The exact meaning depends on the value of the
        /// <see cref="Message"/> member.
        /// </summary>
        public IntPtr LParam;

        /// <summary>
        /// The time at which the message was posted.
        /// </summary>
        public uint Time;

        /// <summary>
        /// The cursor position, in screen coordinates, when the message was posted.
        /// </summary>
        public Point Point;

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"msg=0x{(int)Message:x} ({Message.ToString()}) hwnd=0x{HWnd.ToInt32():x}"
                + $"wparam=0x{WParam.ToInt32():x} lparam=0x{LParam.ToInt32():x} pt={Point}";
        }
    }
}
