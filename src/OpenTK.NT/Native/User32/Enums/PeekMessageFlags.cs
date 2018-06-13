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
        NoRemove = 0,

        /// <summary>
        /// Messages are removed from the queue after processing by <see cref="User32.Message.PeekMessage"/>.
        /// </summary>
        Remove = 1,

        /// <summary>
        /// Prevents the system from releasing any thread that is waiting for the caller to go idle (see WaitForInputIdle).
        /// Combine this value with either <see cref="NoRemove"/> or <see cref="Remove"/>.
        /// </summary>
        NoYield = 2,


        /// <summary>
        /// Process mouse and keyboard messages.
        /// </summary>
        QSInput = QueueStatusFlags.Input << 16,

        /// <summary>
        /// Process paint messages.
        /// </summary>
        QSPaint = QueueStatusFlags.Paint << 16,

        /// <summary>
        /// Process all posted messages, including timers and hotkeys.
        /// </summary>
        QSPostMessage = (QueueStatusFlags.PostMessage | QueueStatusFlags.Hotkey | QueueStatusFlags.Timer) << 16,

        /// <summary>
        /// Process all sent messages.
        /// </summary>
        QSSendMessage = QueueStatusFlags.SendMessage << 16
    }
}
