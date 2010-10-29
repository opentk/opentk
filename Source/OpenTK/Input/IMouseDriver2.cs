using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    interface IMouseDriver2
    {
        /// <summary>
        /// Retrieves the MouseState for the default keyboard device.
        /// </summary>
        /// <returns>A <see cref="OpenTK.Input.MouseState"/> structure containing the state of the mouse device.</returns>
        MouseState GetState();

        /// <summary>
        /// Retrieves the MouseState for the specified keyboard device.
        /// </summary>
        /// <param name="index">The index of the keyboard device.</param>
        /// <returns>A <see cref="OpenTK.Input.MouseState"/> structure containing the state of the mouse device.</returns>
        MouseState GetState(int index);
    }
}
