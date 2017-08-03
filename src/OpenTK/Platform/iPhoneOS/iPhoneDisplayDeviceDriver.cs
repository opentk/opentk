using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Platform;

namespace OpenTK.Platform.iPhoneOS
{
    internal class AndroidDisplayDeviceDriver : DisplayDeviceDriver
    {
        private static DisplayDevice dev;
        static AndroidDisplayDeviceDriver()
        {
            dev = new DisplayDevice(null);
        }

        public override IList<DisplayResolution> GetAvailableResolutions(object device)
        {
            throw new NotImplementedException();
        }

        public override DisplayDevice GetDisplay(DisplayIndex displayIndex)
        {
            return (displayIndex == DisplayIndex.First || displayIndex == DisplayIndex.Primary) ? dev : null;
        }

        public override bool GetIsPrimary(object device)
        {
            return true;
        }

        public override DisplayResolution GetResolution(object device)
        {
            return new DisplayResolution(0, 0, 0, 0, 16, 0);
        }

        public override bool TryChangeResolution(object device, DisplayResolution resolution)
        {
            return false;
        }
        
        public override bool TryRestoreResolution(object device)
        {
            return false;
        }
    }
}
