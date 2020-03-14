//
// CursorStateAttribute.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Attribute for setting <see cref="CursorModeValue"/> of the cursor.
    /// </summary>
    /// <seealso cref="GLFW.SetInputMode(Window*,CursorStateAttribute,CursorModeValue)"/>
    /// <seealso cref="GLFW.GetInputMode(Window*,CursorStateAttribute)"/>
    public enum CursorStateAttribute
    {
        /// <summary>
        /// Attribute for setting <see cref="CursorModeValue"/> of the cursor.
        /// </summary>
        Cursor = 0x00033001,
    }
}
