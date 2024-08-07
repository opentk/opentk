#nullable enable

namespace OpenTK.Platform
{
    /// <summary>
    /// Handle to a window object.
    /// </summary>
    public abstract class WindowHandle : PalHandle
    {
        /// <summary>
        /// The <see cref="Platform.GraphicsApiHints"/> that where used to create the window.
        /// </summary>
        public GraphicsApiHints GraphicsApiHints { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowHandle"/> class.
        /// </summary>
        /// <param name="graphicsApiHints">The <see cref="Platform.GraphicsApiHints"/> that where used to create the window.</param>
        public WindowHandle(GraphicsApiHints graphicsApiHints)
        {
            GraphicsApiHints = graphicsApiHints;
        }
    }
}
