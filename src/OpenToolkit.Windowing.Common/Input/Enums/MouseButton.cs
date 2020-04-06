//
// MouseButton.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.Windowing.Common.Input
{
    /// <summary>
    /// Enumerates all possible mouse buttons.
    /// </summary>
    public enum MouseButton
    {
        // This mirrors GLFW behaviour,
        // see https://www.glfw.org/docs/latest/group__buttons.html

        /// <summary>
        /// The left mouse button. Equivalent to Button1.
        /// </summary>
        Left = Button1,

        /// <summary>
        /// The middle mouse button. Equivalent to Button2.
        /// </summary>
        Middle = Button3,

        /// <summary>
        /// The right mouse button. Equivalent to Button3.
        /// </summary>
        Right = Button2,

        /// <summary>
        /// The first mouse button. Equivalent to Left.
        /// </summary>
        Button1 = 0,

        /// <summary>
        /// The second mouse button. Equivalent to Right.
        /// </summary>
        Button2,

        /// <summary>
        /// The third mouse button. Equivalent to Middle.
        /// </summary>
        Button3,

        /// <summary>
        /// The fourth mouse button.
        /// </summary>
        Button4,

        /// <summary>
        /// The fifth mouse button.
        /// </summary>
        Button5,

        /// <summary>
        /// The sixth mouse button.
        /// </summary>
        Button6,

        /// <summary>
        /// The seventh mouse button.
        /// </summary>
        Button7,

        /// <summary>
        /// The eigth mouse button.
        /// </summary>
        Button8,

        /// <summary>
        /// Indicates the last available mouse button.
        /// </summary>
        LastButton = Button8
    }
}
