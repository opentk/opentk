using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Flags used in <see cref="User32.Message.GetQueueStatus(QueueMessageTypes)"/>
    /// to specify the types of messages to check for.
    /// </summary>
    [Flags]
    public enum QueueMessageTypes : uint
    {
        /// <summary>
        /// A <see cref="WindowMessage.KeyUp"/>, <see cref="WindowMessage.KeyDown"/>,
        /// <see cref="WindowMessage.SystemKeyUp"/>, or <see cref="WindowMessage.SystemKeyDown"/> message
        /// is in the queue.
        /// </summary>
        Key = 0x0001,

        /// <summary>
        /// A <see cref="WindowMessage.MouseMove"/> message is in the queue.
        /// </summary>
        MouseMove = 0x0002,

        /// <summary>
        /// A mouse-button message (<see cref="WindowMessage.LButtonUp"/>,
        /// <see cref="WindowMessage.RButtonDown"/>, and so on).
        /// </summary>
        MouseButton = 0x0004,

        /// <summary>
        /// A posted message (other than those listed here) is in the queue.
        /// </summary>
        PostMessage = 0x0008,

        /// <summary>
        /// A <see cref="WindowMessage.Timer"/> message is in the queue.
        /// </summary>
        Timer = 0x0010,

        /// <summary>
        /// A <see cref="WindowMessage.Paint"/> message is in the queue.
        /// </summary>
        Paint = 0x0020,

        /// <summary>
        /// A message sent by another thread or application is in the queue.
        /// </summary>
        SendMessage = 0x0040,

        /// <summary>
        /// A <see cref="WindowMessage.Hotkey"/> message is in the queue.
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
        /// A <see cref="WindowMessage.MouseMove"/> message or mouse-button message
        /// (<see cref="WindowMessage.LButtonUp"/>, <see cref="WindowMessage.RButtonDown"/>, and so on).
        /// </summary>
        Mouse = MouseMove | MouseButton,

        /// <summary>
        /// An input message is in the queue. This is composed of <see cref="Key"/>,
        /// <see cref="Mouse"/> and <see cref="RawInput"/>.
        /// Windows XP and higher only.
        /// </summary>
        Input = Mouse | Key | RawInput,

        /// <summary>
        /// An input message is in the queue. This is composed of <see cref="Key"/> and <see cref="Mouse"/>.
        /// Windows 2000 and earlier.
        /// </summary>
        InputLegacy = Mouse | Key,

        /// <summary>
        /// An input, <see cref="WindowMessage.Timer"/>, <see cref="WindowMessage.Paint"/>,
        /// <see cref="WindowMessage.Hotkey"/>, or posted message is in the queue.
        /// </summary>
        AllEvents = Input | PostMessage | Timer | Paint | Hotkey,

        /// <summary>
        /// Any message is in the queue.
        /// </summary>
        AllInput = Input | PostMessage | Timer | Paint | Hotkey | SendMessage
    }
}
