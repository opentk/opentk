using System;

using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    [Flags]
    public enum TrackMouseEventFlags : DWORD
    {
        /// <summary>
        /// The caller wants hover notification. Notification is delivered as a WM_MOUSEHOVER message.<br/>
        /// If the caller requests hover tracking while hover tracking is already active, the hover timer will be reset.<br/>
        /// This flag is ignored if the mouse pointer is not over the specified window or area.
        /// </summary>
        HOVER = 0x00000001,

        /// <summary>
        /// The caller wants leave notification. Notification is delivered as a WM_MOUSELEAVE message.
        /// If the mouse is not over the specified window or area, a leave notification is generated immediately and no further tracking is performed.
        /// </summary>
        LEAVE = 0x00000002,

        /// <summary>
        /// The caller wants hover and leave notification for the nonclient areas.
        /// Notification is delivered as WM_NCMOUSEHOVER and WM_NCMOUSELEAVE messages.
        /// </summary>
        NONCLIENT = 0x00000010,

        /// <summary>
        /// The function fills in the structure instead of treating it as a tracking request. 
        /// The structure is filled such that had that structure been passed to TrackMouseEvent, 
        /// it would generate the current tracking. The only anomaly is that the hover time-out
        /// returned is always the actual time-out and not HOVER_DEFAULT, if HOVER_DEFAULT was 
        /// specified during the original <see cref="User32.Mouse.TrackMouseEvent"/> request.
        /// </summary>
        QUERY = 0x40000000,

        /// <summary>
        /// The caller wants to cancel a prior tracking request. The caller should also specify the type
        /// of tracking that it wants to cancel. For example, to cancel hover tracking, the caller must 
        /// pass the TME_CANCEL and TME_HOVER flags.
        /// </summary>
        CANCEL = 0x80000000
    }
}
