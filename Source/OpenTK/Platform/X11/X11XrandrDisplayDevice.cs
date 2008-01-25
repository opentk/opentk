#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK team.
 * This notice may not be removed.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Graphics;
using System.Diagnostics;

namespace OpenTK.Platform.X11
{
    internal class X11XrandrDisplayDevice : IDisplayDeviceDriver
    {
        static object display_lock = new object();

        #region --- Constructors ---

        static X11XrandrDisplayDevice()
        {
            // Get available resolutions. Then, for each resolution get all
            // available rates.
            // TODO: Find a way to get all available depths, too.

            //lock (display_lock)   // TODO: Global X11 lock.
            {
                for (int screen = 0; screen < API.ScreenCount; screen++)
                {
                    List<DisplayResolution> resolutions = new List<DisplayResolution>();
                    unsafe
                    {
                        XRRScreenSize[] array = Functions.XRRSizes(API.DefaultDisplay, screen);
                        if (array == null)
                            throw new NotSupportedException("XRandR extensions not available.");

                        int resolution = 0;
                        foreach (XRRScreenSize size in array)
                        {
                            short[] rates = Functions.XRRRates(API.DefaultDisplay, screen, resolution);
                            foreach (short rate in rates)
                                resolutions.Add(new DisplayResolution(size.Width, size.Height, 24, (float)rate));
                            ++resolution;
                        }
                    }

                    // Construct a default device for testing purposes.
                    new DisplayDevice(resolutions[0], screen == API.DefaultScreen, resolutions);
                }
            }
        }

        public X11XrandrDisplayDevice()
        {
        }

        #endregion

        #region --- IDisplayDeviceDriver Members ---

        public bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution)
        {
            return false;
        }

        public void RestoreResolution(DisplayDevice device)
        {
            
        }

        #endregion
    }
}
