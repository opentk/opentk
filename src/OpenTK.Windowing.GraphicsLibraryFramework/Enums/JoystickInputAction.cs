//
// JoystickInputAction.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    ///     Defines event information for <see cref="GLFW.GetJoystickButtons" /> and <see cref="GLFW.GetJoystickButtonsRaw(int,out int)" />.
    /// </summary>
    public enum JoystickInputAction : byte
    {
        /// <summary>
        ///     The joystick button was released.
        /// </summary>
        Release = 0,

        /// <summary>
        ///     The joystick button was pressed.
        /// </summary>
        Press = 1
    }
}
