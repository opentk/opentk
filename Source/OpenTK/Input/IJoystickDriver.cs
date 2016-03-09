// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Defines the interface for JoystickDevice drivers.
    /// </summary>
    [Obsolete]
    public interface IJoystickDriver
    {
        /// <summary>
        /// Gets the list of available JoystickDevices.
        /// </summary>
        IList<JoystickDevice> Joysticks { get; }
    }
}
