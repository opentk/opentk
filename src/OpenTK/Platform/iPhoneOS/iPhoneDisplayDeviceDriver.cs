using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Platform;

namespace OpenTK.Platform.iPhoneOS
{
    class AndroidDisplayDeviceDriver : IDisplayDeviceDriver
    {
        static DisplayDevice dev;
        static AndroidDisplayDeviceDriver()
        {
            dev = new DisplayDevice();
            dev.IsPrimary = true;
            dev.BitsPerPixel = 16;
        }

        public DisplayDevice GetDisplay(DisplayIndex displayIndex)
        {
            return (displayIndex == DisplayIndex.First || displayIndex == DisplayIndex.Primary) ? dev : null;
        }


        public bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution)
        {
            return false;
        }

        public bool TryRestoreResolution(DisplayDevice device)
        {
            return false;
        }
    }
}
