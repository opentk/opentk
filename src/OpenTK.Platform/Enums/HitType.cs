namespace OpenTK.Platform
{
    /// <summary>
    /// Type of window hit.
    /// </summary>
    public enum HitType
    {
        /// <summary>
        /// Do what would be done if no hit test delegate was set.
        /// </summary>
        Default,

        // FIXME:
        // Add PassThrough to allow events to pass through to other OpenTK windows?

        /// <summary>
        /// The client area of the window.
        /// </summary>
        Normal,

        /// <summary>
        /// A part of the window that can be used to move the window.
        /// </summary>
        Draggable,

        /// <summary>
        /// The top left resizeable part of the window.
        /// </summary>
        ResizeTopLeft,

        /// <summary>
        /// The top resizeable part of the window.
        /// </summary>
        ResizeTop,

        /// <summary>
        /// The top right resizeable part of the window.
        /// </summary>
        ResizeTopRight,

        /// <summary>
        /// The right resizeable part of the window.
        /// </summary>
        ResizeRight,

        /// <summary>
        /// The bottom right resizeable part of the window.
        /// </summary>
        ResizeBottomRight,

        /// <summary>
        /// The bottom resizeable part of the window.
        /// </summary>
        ResizeBottom,

        /// <summary>
        /// The bottom left resizeable part of the window.
        /// </summary>
        ResizeBottomLeft,

        /// <summary>
        /// The left resizeable part of the window.
        /// </summary>
        ResizeLeft,
    }
}
