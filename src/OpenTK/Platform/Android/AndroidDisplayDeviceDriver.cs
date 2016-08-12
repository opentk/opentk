#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2011 Xamarin, Inc.
 * Copyright 2013 Xamarin Inc
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;

namespace OpenTK.Platform.Android
{
    class AndroidDisplayDeviceDriver : IDisplayDeviceDriver
    {
        static DisplayDevice dev;
        static AndroidDisplayDeviceDriver ()
        {
            dev = new DisplayDevice ();
            dev.IsPrimary = true;
            dev.BitsPerPixel = 16;
        }

        public DisplayDevice GetDisplay(DisplayIndex displayIndex)
        {
            return (displayIndex == DisplayIndex.First || displayIndex == DisplayIndex.Primary) ? dev : null;
        }


        public bool TryChangeResolution (DisplayDevice device, DisplayResolution resolution)
        {
            return false;
        }

        public bool TryRestoreResolution (DisplayDevice device)
        {
            return false;
        }
    }
}