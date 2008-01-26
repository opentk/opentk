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
        int current_size = -1;  // current_size == -1 means it hasn't been changed.
        int current_refresh;
        // Store a mapping between resolutions and their respective
        // size_index (needed for XRRSetScreenConfig). The size_index
        // is simply the sequence number of the resolution as returned by
        // XRRSizes. This is done per available screen.
        // The default size for all screens is 0 - no need to store that separately.
        static List<Dictionary<DisplayResolution, int>> screenResolutionToIndex =
            new List<Dictionary<DisplayResolution, int>>();
        // Store a mapping between DisplayDevices and X11 screens.
        static Dictionary<DisplayDevice, int> deviceToScreen = new Dictionary<DisplayDevice, int>();
        // Keep the time when the config of each screen was last updated.
        static List<uint> lastConfigUpdate = new List<uint>();
        
        #region --- Constructors ---

        static X11XrandrDisplayDevice()
        {
            // Get available resolutions. Then, for each resolution get all
            // available rates.
            // TODO: Find a way to get all available depths, too.
            // TODO: Global X11 lock.
            for (int screen = 0; screen < API.ScreenCount; screen++)
            {
                uint timestamp_of_last_update;
                Functions.XRRTimes(API.DefaultDisplay, screen, out timestamp_of_last_update);
                lastConfigUpdate.Add(timestamp_of_last_update);

                List<DisplayResolution> available_res = new List<DisplayResolution>();

                // Add info for a new screen.
                screenResolutionToIndex.Add(new Dictionary<DisplayResolution, int>());

                int[] depths = FindAvailableDepths(screen);

                int resolution_count = 0;
                foreach (XRRScreenSize size in FindAvailableResolutions(screen))
                {
                    short[] rates = Functions.XRRRates(API.DefaultDisplay, screen, resolution_count);

                    // It seems that XRRRates returns 0 for modes that are larger than the screen
                    // can support, as well as for all supported modes. On Ubuntu 7.10 the tool
                    // "Screens and Graphics" does report these modes, though.
                    foreach (short rate in rates)
                    {
                        if (rate != 0)
                            foreach (int depth in depths)
                                available_res.Add(new DisplayResolution(size.Width, size.Height, depth, (float)rate));
                    }
                    // Keep the index of this resolution - we will need it for resolution changes later.
                    foreach (int depth in depths)
                        screenResolutionToIndex[screen].Add(new DisplayResolution(size.Width, size.Height, depth, 0),
                            resolution_count);
                    
                    ++resolution_count;
                }

                float current_refresh_rate = FindCurrentRefreshRate(screen);
                int current_depth = FindCurrentDepth(screen);

                // The default resolution (but not refresh rate) is the first one in available_res.
                // Its refresh rate is discovered by the FindCurrentRefreshRate call.
                // Its depth is discovered by the FindCurrentDepth call.
                deviceToScreen.Add(new DisplayDevice(new DisplayResolution(available_res[0].Width, available_res[0].Height, current_depth, current_refresh_rate),
                    screen == API.DefaultScreen, available_res), screen);
            }
        }

        internal X11XrandrDisplayDevice() { }

        #endregion

        #region --- Private Methods ---

        #region static int[] FindAvailableDepths(int screen)

        static int[] FindAvailableDepths(int screen)
        {
            return Functions.XListDepths(API.DefaultDisplay, screen);
        }

        #endregion

        #region static XRRScreenSize[] FindAvailableResolutions(int screen)

        static XRRScreenSize[] FindAvailableResolutions(int screen)
        {
            XRRScreenSize[] resolutions = Functions.XRRSizes(API.DefaultDisplay, screen);
            if (resolutions == null)
                throw new NotSupportedException("XRandR extensions not available.");
            return resolutions;
        }

        #endregion

        #region static float FindCurrentRefreshRate(int screen)

        static float FindCurrentRefreshRate(int screen)
        {
            IntPtr screen_config = Functions.XRRGetScreenInfo(API.DefaultDisplay, API.RootWindow);
            ushort rotation = 0;
            int size = Functions.XRRConfigCurrentConfiguration(screen_config, out rotation);
            short rate = Functions.XRRConfigCurrentRate(screen_config);
            Functions.XRRFreeScreenConfigInfo(screen_config);

            return (float)rate;
        }

        #endregion

        #region private static int FindCurrentDepth(int screen)

        private static int FindCurrentDepth(int screen)
        {
            return (int)Functions.XDefaultDepth(API.DefaultDisplay, screen);
        }

        #endregion

        #endregion

        #region --- IDisplayDeviceDriver Members ---

        public bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution)
        {
            // If resolution == null, restore to default resolution (new_resolution_index = 0).

            int screen = deviceToScreen[device];
            IntPtr root = Functions.XRootWindow(API.DefaultDisplay, screen);
            IntPtr screen_config = Functions.XRRGetScreenInfo(API.DefaultDisplay, root);

            ushort current_rotation;
            int current_resolution_index = Functions.XRRConfigCurrentConfiguration(screen_config, out current_rotation);
            int new_resolution_index;
            if (resolution != null)
                new_resolution_index = screenResolutionToIndex[screen]
                    [new DisplayResolution(resolution.Width, resolution.Height, resolution.BitsPerPixel, 0)];
            else
                new_resolution_index = 0;

            Debug.Print("Changing size of screen {0} from {1} to {2}",
                screen, current_resolution_index, new_resolution_index);

            return 0 == Functions.XRRSetScreenConfigAndRate(API.DefaultDisplay, screen_config, root, new_resolution_index,
                current_rotation, (short)(resolution != null ? resolution.RefreshRate : 0), lastConfigUpdate[screen]);
        }

        public bool TryRestoreResolution(DisplayDevice device)
        {
            return TryChangeResolution(device, null);
            //System.Diagnostics.Process.Start("xrandr", "-s -0").WaitForExit(); // Hack, but works ;)
        }

        #endregion
    }
}
