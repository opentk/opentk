#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
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
        // Store a mapping between resolutions and their respective
        // size_index (needed for XRRSetScreenConfig). The size_index
        // is simply the sequence number of the resolution as returned by
        // XRRSizes. This is done per available screen.
        static List<Dictionary<DisplayResolution, int>> screenResolutionToIndex =
            new List<Dictionary<DisplayResolution, int>>();
        // Store a mapping between DisplayDevices and their default resolutions.
        static Dictionary<DisplayDevice, int> deviceToDefaultResolution = new Dictionary<DisplayDevice, int>();
        // Store a mapping between DisplayDevices and X11 screens.
        static Dictionary<DisplayDevice, int> deviceToScreen = new Dictionary<DisplayDevice, int>();
        // Keep the time when the config of each screen was last updated.
        static List<uint> lastConfigUpdate = new List<uint>();
        
        #region --- Constructors ---

        static X11XrandrDisplayDevice()
        {
            // Get available resolutions. Then, for each resolution get all
            // available rates.
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


                // The resolution of the current DisplayDevice is discovered through XRRConfigCurrentConfiguration.
                // Its refresh rate is discovered by the FindCurrentRefreshRate call.
                // Its depth is discovered by the FindCurrentDepth call.
                float current_refresh_rate = FindCurrentRefreshRate(screen);
                int current_depth = FindCurrentDepth(screen);
                IntPtr screen_config = Functions.XRRGetScreenInfo(API.DefaultDisplay, Functions.XRootWindow(API.DefaultDisplay, screen));
                ushort current_rotation;  // Not needed.
                int current_resolution_index = Functions.XRRConfigCurrentConfiguration(screen_config, out current_rotation);
                
                DisplayDevice current_device = new DisplayDevice(
                    new DisplayResolution(available_res[current_resolution_index].Width, available_res[current_resolution_index].Height,
                                          current_depth, current_refresh_rate),
                    screen == Functions.XDefaultScreen(API.DefaultDisplay),
                    available_res);

                deviceToScreen.Add(current_device, screen);
                deviceToDefaultResolution.Add(current_device, current_resolution_index);
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
            IntPtr screen_config = Functions.XRRGetScreenInfo(API.DefaultDisplay, Functions.XRootWindow(API.DefaultDisplay, screen));
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
                new_resolution_index = deviceToDefaultResolution[device];

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
