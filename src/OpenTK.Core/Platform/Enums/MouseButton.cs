using System;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Enumeration of mouse buttons.
    /// </summary>
    public enum MouseButton
    {
        // FIXME: Better names!

        /// <summary>
        /// The primary mouse button (usually the left one).
        /// </summary>
        Button1,

        /// <summary>
        /// The secondary mouse button (usually the right one).
        /// </summary>
        Button2,

        /// <summary>
        /// The tertiary mouse button (usually in the mouse wheel).
        /// </summary>
        Button3,

        /// <summary>
        /// Auxiliary mouse button.
        /// </summary>
        Button4,

        /// <summary>
        /// Auxiliary mouse button.
        /// </summary>
        Button5,

        /// <summary>
        /// Auxiliary mouse button.
        /// </summary>
        Button6,

        /// <summary>
        /// Auxiliary mouse button.
        /// </summary>
        Button7,

        /// <summary>
        /// Auxiliary mouse button.
        /// </summary>
        Button8,
    }

    /// <summary>
    /// Mouse button flags.
    /// </summary>
    [Flags]
    public enum MouseButtonFlags
    {
        /// <summary>
        /// Indicates that the primary mouse button (usually the left one) is pressed.
        /// </summary>
        Button1 = 1 << MouseButton.Button1,

        /// <summary>
        /// Indicates that the secondary mouse button (usually the right one) is pressed.
        /// </summary>
        Button2 = 1 << MouseButton.Button2,

        /// <summary>
        /// Indicates that the tertiary mouse button (usually in the mouse wheel) is pressed.
        /// </summary>
        Button3 = 1 << MouseButton.Button3,

        /// <summary>
        /// Indicates that auxiliary mouse button 1 is pressed.
        /// </summary>
        Button4 = 1 << MouseButton.Button4,

        /// <summary>
        /// Indicates that auxiliary mouse button 2 is pressed.
        /// </summary>
        Button5 = 1 << MouseButton.Button5,

        /// <summary>
        /// Indicates that auxiliary mouse button 3 is pressed.
        /// </summary>
        Button6 = 1 << MouseButton.Button6,

        /// <summary>
        /// Indicates that auxiliary mouse button 4 is pressed.
        /// </summary>
        Button7 = 1 << MouseButton.Button7,

        /// <summary>
        /// Indicates that auxiliary mouse button 5 is pressed.
        /// </summary>
        Button8 = 1 << MouseButton.Button8,
    }
}
