using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Platform;

namespace OpenTK.Platform.iPhoneOS
{
    internal sealed class AndroidDisplayDevice : DisplayDevice
    {
        public override DisplayResolution CurrentResolution
        {
            get
            {
                return new DisplayResolution(0, 0, 0, 0, 16, 0);
            }

            set
            {
                base.CurrentResolution = value;
            }
        }

        public override IList<DisplayResolution> AvailableResolutions
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool IsPrimary
        {
            get
            {
                return true;
            }
        }

        public override void ChangeResolution(DisplayResolution resolution)
        {
            throw new Graphics.GraphicsModeException(
                string.Format("Device {0}: Failed to change resolution to {1}.", this, resolution));
        }

        public override void RestoreResolution()
        {
            throw new Graphics.GraphicsModeException(string.Format("Device {0}: Failed to restore resolution.", this));
        }
    }

    internal class AndroidDisplayDeviceDriver : DisplayDeviceDriver
    {
        private static DisplayDevice dev;
        static AndroidDisplayDeviceDriver()
        {
            dev = new AndroidDisplayDevice();
        }

        public override DisplayDevice GetDisplay(DisplayIndex displayIndex)
        {
            return (displayIndex == DisplayIndex.First || displayIndex == DisplayIndex.Primary) ? dev : null;
        }
    }
}
