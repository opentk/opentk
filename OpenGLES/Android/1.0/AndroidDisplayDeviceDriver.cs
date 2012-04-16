#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2011 Xamarin, Inc.
 * Copyright 2013 Xamarin Inc
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using OpenTK.Graphics;

namespace OpenTK.Platform.Android
{
	class AndroidDisplayDeviceDriver : IDisplayDeviceDriver
	{
		static AndroidDisplayDeviceDriver ()
		{
			DisplayDevice dev = new DisplayDevice ();
			dev.IsPrimary = true;
			dev.BitsPerPixel = 16;
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