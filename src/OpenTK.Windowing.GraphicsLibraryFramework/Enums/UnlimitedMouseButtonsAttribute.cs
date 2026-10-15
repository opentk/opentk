//
// StickyAttributes.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Attribute for enabling unlimited mouse buttons.
    /// </summary>
    /// <seealso cref="GLFW.SetInputMode(Window*, UnlimitedMouseButtonsAttribute, bool)"/>
    /// <seealso cref="GLFW.GetInputMode(Window*, UnlimitedMouseButtonsAttribute)"/>
    public enum UnlimitedMouseButtonsAttribute
    {
        /// <summary>
        /// Specify whether mouse buttons beyond the standard eight should be reported in the <see cref="GLFWCallbacks.MouseButtonCallback"/>.
        /// </summary>
        UnlimitedMouseButtons = 0x00050000
    }
}
