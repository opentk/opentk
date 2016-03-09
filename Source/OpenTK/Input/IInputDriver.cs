// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

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
