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
            // TODO: Global X11 lock.
            for (int screen = 0; screen < API.ScreenCount; screen++)
            {
                List<DisplayResolution> available_res;
                int[] depths;
                float refreshRate;
                int currentDepth;

                FindAvailableDepths(screen, out depths);
                FindAvailableResolutions(screen, depths, out available_res);
                FindCurrentRefreshRate(screen, out refreshRate);
                FindCurrentDepth(screen, out currentDepth);

                // The default resolution (but not refresh rate) is the first one in available_res.
                // Its refresh rate is discovered by the FindCurrentRefreshRate call.
                // Its depth is discovered by the FindCurrentDepth call.
                new DisplayDevice(new DisplayResolution(available_res[0].Width, available_res[0].Height, currentDepth, refreshRate),
                    screen == API.DefaultScreen, available_res);
            }
        }

        internal X11XrandrDisplayDevice() { }

        #endregion

        #region --- Private Methods ---

        #region static void FindAvailableResolutions(int screen, out List<DisplayResolution> resolutions)

        static void FindAvailableResolutions(int screen, int[] depths, out List<DisplayResolution> resolutions)
        {
            resolutions = new List<DisplayResolution>();
            unsafe
            {
                XRRScreenSize[] array = Functions.XRRSizes(API.DefaultDisplay, screen);
                if (array == null)
                    throw new NotSupportedException("XRandR extensions not available.");

                int resolution = 0;
                foreach (XRRScreenSize size in array)
                {
                    short[] rates = Functions.XRRRates(API.DefaultDisplay, screen, resolution);

                    // TODO: Is the rate != 0 conditional correct? It seems that XRRRates returns 0
                    // for modes that are larger than the screen can support (?)
                    foreach (short rate in rates)
                        if (rate != 0)
                            foreach (int depth in depths)
                                resolutions.Add(new DisplayResolution(size.Width, size.Height, depth, (float)rate));
                    ++resolution;
                }
            }
        }

        #endregion

        #region static void FindCurrentRefreshRate(int screen, out float refreshRate)

        static void FindCurrentRefreshRate(int screen, out float refreshRate)
        {
            IntPtr screen_config_ptr = Functions.XRRGetScreenInfo(API.DefaultDisplay, API.RootWindow);
            ushort rotation = 0;
            int size = Functions.XRRConfigCurrentConfiguration(screen_config_ptr, ref rotation);
            short rate = Functions.XRRConfigCurrentRate(screen_config_ptr);
            Functions.XRRFreeScreenConfigInfo(screen_config_ptr);

            refreshRate = (float)rate;
        }

        #endregion

        #region private static void FindAvailableDepths(int screen, out int[] depths)

        private static void FindAvailableDepths(int screen, out int[] depths)
        {
            depths = Functions.XListDepths(API.DefaultDisplay, screen);
        }

        #endregion

        #region private static void FindCurrentDepth(int screen, out int current_depth)

        private static void FindCurrentDepth(int screen, out int current_depth)
        {
            current_depth = (int)Functions.XDefaultDepth(API.DefaultDisplay, screen);
        }

        #endregion

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
