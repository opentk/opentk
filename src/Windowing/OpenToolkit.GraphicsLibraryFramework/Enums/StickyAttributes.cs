//
// StickyAttributes.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Attributes related to sticky keys and buttons.
    /// </summary>
    /// <seealso cref="GLFW.SetInputMode(Window*,StickyAttributes,bool)"/>
    /// <seealso cref="GLFW.GetInputMode(Window*,StickyAttributes)"/>
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
