#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Defines the interface for KeyboardDevice drivers.
    /// </summary>
    public interface IKeyboardDriver
    {
        /// <summary>
        /// Gets the list of available KeyboardDevices.
        /// </summary>
        IList<KeyboardDevice> Keyboard { get; }

        /// <summary>
        /// Retrieves the KeyboardState for the default keyboard device.
        /// </summary>
        /// <returns>A <see cref="OpenTK.Input.KeyboardState"/> structure containing the state of the keyboard device.</returns>
        KeyboardState GetState();

        /// <summary>
        /// Retrieves the KeyboardState for the specified keyboard device.
        /// </summary>
        /// <param name="index">The index of the keyboard device.</param>
        /// <returns>A <see cref="OpenTK.Input.KeyboardState"/> structure containing the state of the keyboard device.</returns>
        KeyboardState GetState(int index);
    }
}
