// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    // Defines the interface for a 2nd generation input driver.
    interface IInputDriver2 : IDisposable
    {
        IMouseDriver2 MouseDriver { get; }
        IKeyboardDriver2 KeyboardDriver { get; }
        IGamePadDriver GamePadDriver { get; }
        IJoystickDriver2 JoystickDriver { get; }
    }
}
