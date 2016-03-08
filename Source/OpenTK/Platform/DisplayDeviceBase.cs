// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    abstract class DisplayDeviceBase : IDisplayDeviceDriver
    {
        protected readonly List<DisplayDevice> AvailableDevices = new List<DisplayDevice>();
        protected DisplayDevice Primary;

        public abstract bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution);
        public abstract bool TryRestoreResolution(DisplayDevice device);

        // Gets the DisplayDevice that corresponds to the specified index.
        public virtual DisplayDevice GetDisplay(DisplayIndex index)
        {
            if (index == DisplayIndex.Primary)
                return Primary;
            else if ((int)index >= 0 && (int)index < AvailableDevices.Count)
                return AvailableDevices[(int)index];
            else
                return null;
        }
    }
}
