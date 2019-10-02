//
// GamepadState.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// This describes the input state of a gamepad.
    /// </summary>
    public struct GamepadState
    {
        /// <summary>
        /// State of each of the 15 gamepad buttons, equal to <see cref="InputAction.Press"/> or <see cref="InputAction.Release"/>.
        /// </summary>
        public unsafe fixed byte Buttons[15];

        /// <summary>
        /// State of each of the 6 gamepad axes, ranging from -1.0 to 1.0.
        /// </summary>
        public unsafe fixed float Axes[6];
    }
}
