// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    internal interface IDisplayDeviceDriver
    {
        bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution);
        bool TryRestoreResolution(DisplayDevice device);
        DisplayDevice GetDisplay(DisplayIndex displayIndex);
    }
}
