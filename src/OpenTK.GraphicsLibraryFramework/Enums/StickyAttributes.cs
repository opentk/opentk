namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Attributes related to sticky keys and buttons.
    /// </summary>
    /// <seealso cref="IGLFW.SetInputMode(Window*,StickyAttributes,bool)"/>
    /// <seealso cref="IGLFW.GetInputMode(Window*,StickyAttributes)"/>
    public enum StickyAttributes
    {
        /// <summary>
        /// Specify whether keyboard input should be sticky or not.
        /// </summary>
        StickyKeys = 0x00033002,

        /// <summary>
        /// Specify whether mouse button input should be sticky or not.
        /// </summary>
        StickyMouseButtons = 0x00033003
    }
}
