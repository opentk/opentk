using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    interface IKeyboardDriver2
    {
        /// <summary>
        /// Retrieves the combined <see cref="OpenTK.Input.KeyboardState"/> for all keyboard devices.
        /// </summary>
        /// <returns>An <see cref="OpenTK.Input.KeyboardState"/> structure containing the combined state for all keyboard devices.</returns>
        KeyboardState GetState();

        /// <summary>
        /// Retrieves the <see cref="OpenTK.Input.KeyboardState"/> for the specified keyboard device.
        /// </summary>
        /// <param name="index">The index of the keyboard device.</param>
        /// <returns>An <see cref="OpenTK.Input.KeyboardState"/> structure containing the state of the keyboard device.</returns>
        KeyboardState GetState(int index);

        /// <summary>
        /// Retrieves the device name for the keyboard device.
        /// </summary>
        /// <param name="index">The index of the keyboard device.</param>
        /// <returns>A <see cref="System.String"/> with the name of the specified device or <see cref="System.String.Empty"/>.</returns>
        /// <remarks>
        /// <para>If no device exists at the specified index, the return value is <see cref="System.String.Empty"/>.</para></remarks>
        string GetDeviceName(int index);
    }
}
