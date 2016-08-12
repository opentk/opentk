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
    /// Defines the interface for an input driver.
    /// </summary>
    [Obsolete("This interface has been replaced by OpenTK.Input.Keyboard, Mouse, Joystick and GamePad.")]
    public interface IInputDriver : IKeyboardDriver, IMouseDriver, IJoystickDriver, IDisposable
    {
        /// <summary>
        /// Updates the state of the driver.
        /// </summary>
        void Poll();
    }
}
