// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    interface IJoystickDriver2
    {
        JoystickState GetState(int index);
        JoystickCapabilities GetCapabilities(int index);
        Guid GetGuid(int index);
    }
}
