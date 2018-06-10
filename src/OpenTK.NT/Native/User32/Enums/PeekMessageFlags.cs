using System;

using UINT = System.UInt32;

namespace OpenTK.NT.Native
{
    [Flags]
    internal enum PeekMessageFlags : UINT
    {
        /// <summary>
        /// Messages are not removed from the queue after processing by <see cref="User32.Message.PeekMessage"/>.
        /// </summary>
        NOREMOVE = 0,

        /// <summary>
        /// Messages are removed from the queue after processing by <see cref="User32.Message.PeekMessage"/>.
        /// </summary>
        REMOVE = 1,

        /// <summary>
        /// Prevents the system from releasing any thread that is waiting for the caller to go idle (see WaitForInputIdle).
        /// Combine this value with either <see cref="NOREMOVE"/> or <see cref="REMOVE"/>.
        /// </summary>
        NOYIELD = 2,


        /// <summary>
        /// Process mouse and keyboard messages.
        /// </summary>
        QS_INPUT = QueueStatusFlags.INPUT << 16,

        /// <summary>
        /// Process paint messages.
        /// </summary>
        QS_PAINT = QueueStatusFlags.PAINT << 16,

        /// <summary>
        /// Process all posted messages, including timers and hotkeys.
        /// </summary>
        QS_POSTMESSAGE = (QueueStatusFlags.POSTMESSAGE | QueueStatusFlags.HOTKEY | QueueStatusFlags.TIMER) << 16,

        /// <summary>
        /// Process all sent messages.
        /// </summary>
        QS_SENDMESSAGE = QueueStatusFlags.SENDMESSAGE << 16
    }
}
