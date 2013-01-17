using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    interface IGamePadDriver
    {
        /// <summary>
        /// Retrieves the combined <see cref="OpenTK.Input.GamePadState"/> for all gamepad devices.
        /// </summary>
        /// <returns>A <see cref="OpenTK.Input.GamePadState"/> structure containing the combined state for all gamepad devices.</returns>
        GamePadState GetState();

        /// <summary>
        /// Retrieves the <see cref="OpenTK.Input.GamePadState"/> for the specified gamepad device.
        /// </summary>
        /// <param name="index">The index of the keyboard device.</param>
        /// <returns>A <see cref="OpenTK.Input.GamePadState"/> structure containing the state of the gamepad device.</returns>
        GamePadState GetState(int index);

        /// <summary>
        /// Retrieves the device name for the gamepad device.
        /// </summary>
        /// <param name="index">The index of the gamepad device.</param>
        /// <returns>A <see cref="System.String"/> with the name of the specified device or <see cref="System.String.Empty"/>.</returns>
        /// <remarks>
        /// <para>If no device exists at the specified index, the return value is <see cref="System.String.Empty"/>.</para></remarks>
        string GetDeviceName(int index);
    }
}
