using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Used in <see cref="TrackMouseEvent"/> to request specific services.
    /// </summary>
    [Flags]
    public enum TrackMouseEvents : uint
    {
        /// <summary>
        /// The caller wants hover notification. Notification is delivered as a <see cref="WindowMessage.MouseHover"/>
        /// message.<para/>
        /// If the caller requests hover tracking while hover tracking is already active,
        /// the hover timer will be reset.<para/>
        /// This flag is ignored if the mouse pointer is not over the specified window or area.
        /// </summary>
        Hover = 0x00000001,

        /// <summary>
        /// The caller wants leave notification. Notification is delivered as a <see cref="WindowMessage.MouseLeave"/>
        /// message. If the mouse is not over the specified window or area,
        /// a leave notification is generated immediately and no further tracking is performed.
        /// </summary>
        Leave = 0x00000002,

        /// <summary>
        /// The caller wants hover and leave notification for the nonclient areas.
        /// Notification is delivered as <see cref="WindowMessage.NCMouseHover"/>
        /// and <see cref="WindowMessage.NCMouseLeave"/> messages.
        /// </summary>
        NonClient = 0x00000010,

        /// <summary>
        /// The function fills in the structure instead of treating it as a tracking request.
        /// The structure is filled such that had that structure been passed to TrackMouseEvent,
        /// it would generate the current tracking. The only anomaly is that the hover time-out
        /// returned is always the actual time-out and not <see cref="TrackMouseEvent.DefaultHoverTime"/>, if
        /// <see cref="TrackMouseEvent.DefaultHoverTime"/> was specified during the original
        /// <see cref="User32.Mouse.TrackMouseEvent"/> request.
        /// </summary>
        Query = 0x40000000,

        /// <summary>
        /// The caller wants to cancel a prior tracking request. The caller should also specify the type
        /// of tracking that it wants to cancel. For example, to cancel hover tracking, the caller must
        /// pass the <see cref="Cancel"/> and <see cref="Hover"/> flags.
        /// </summary>
        Cancel = 0x80000000
    }
}
