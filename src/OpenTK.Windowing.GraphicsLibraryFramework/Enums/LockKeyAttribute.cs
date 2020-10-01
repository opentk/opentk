//
// LockKeyAttribute.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    ///     Attribute for setting caps and num lock bits on when setting the input mode.
    /// </summary>
    /// <seealso cref="GLFW.SetInputMode(Window*,LockKeyModAttribute,bool)" />
    /// <seealso cref="GLFW.GetInputMode(Window*,LockKeyModAttribute)" />
    public enum LockKeyModAttribute
    {
        /// <summary>
        ///     Specify whether the lock key bits should be set or not.
        /// </summary>
        LockKeyMods = 0x00033004
    }
}
