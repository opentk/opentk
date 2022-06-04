namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Handle to a window object.
    /// </summary>
    public abstract class WindowHandle : PalHandle
    {
        public GraphicsApiHints GraphicsApiHints { get; protected set; }
    }
}
