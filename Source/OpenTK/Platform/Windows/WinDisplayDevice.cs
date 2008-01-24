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
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace OpenTK.Platform.Windows
{
    internal class WinDisplayDeviceDriver : IDisplayDeviceDriver
    {
        // In OpenTK nomenclature, a DisplayDevice is a screen, not a video card!
        static object display_lock = new object();

        #region --- Constructors ---

        static WinDisplayDeviceDriver()
        {
            lock (display_lock)
            {
                // To minimize the need to add static methods to OpenTK.Graphics.DisplayDevice
                // we only allow settings to be set through its constructor.
                // Thus, we save all necessary parameters in temporary variables
                // and construct the device when every needed detail is available.
                OpenTK.Graphics.DisplayDevice opentk_dev;
                DisplayResolution opentk_dev_current_res = null;
                List<DisplayResolution> opentk_dev_available_res = new List<DisplayResolution>();
                bool opentk_dev_primary = false;
                int device_count = 0, mode_count = 0;

                // Get available video adapters and enumerate all monitors
                DisplayDevice dev1 = new DisplayDevice(), dev2 = new DisplayDevice();
                while (Functions.EnumDisplayDevices(null, device_count++, dev1, 0))
                {
                    if ((dev1.StateFlags & DisplayDeviceStateFlags.AttachedToDesktop) == DisplayDeviceStateFlags.None)
                        continue;

                    DeviceMode monitor_mode = new DeviceMode();

                    // The second function should only be executed when the first one fails
                    // (e.g. when the monitor is disabled)
                    if (Functions.EnumDisplaySettings(dev1.DeviceName.ToString(), DisplayModeSettingsEnum.CurrentSettings, monitor_mode) ||
                        Functions.EnumDisplaySettings(dev1.DeviceName.ToString(), DisplayModeSettingsEnum.RegistrySettings, monitor_mode))
                    {
                        opentk_dev_current_res = new DisplayResolution(monitor_mode.PelsWidth, monitor_mode.PelsHeight,
                            monitor_mode.BitsPerPel, monitor_mode.DisplayFrequency);
                        opentk_dev_primary =
                            (dev1.StateFlags & DisplayDeviceStateFlags.PrimaryDevice) != DisplayDeviceStateFlags.None;
                    }

                    opentk_dev_available_res.Clear();
                    mode_count = 0;
                    while (Functions.EnumDisplaySettings(dev1.DeviceName.ToString(), mode_count++, monitor_mode))
                    {
                        DisplayResolution res = new DisplayResolution(
                            monitor_mode.PelsWidth, monitor_mode.PelsHeight,
                            monitor_mode.BitsPerPel, monitor_mode.DisplayFrequency);

                        opentk_dev_available_res.Add(res);
                    }

                    // Construct the OpenTK DisplayDevice through the accumulated parameters.
                    opentk_dev = new OpenTK.Graphics.DisplayDevice(opentk_dev_current_res, opentk_dev_primary,
                        opentk_dev_available_res);
                }
            }
        }

        public WinDisplayDeviceDriver()
        {
        }

        #endregion

        #region --- IDisplayDeviceDriver Members ---

        #region public bool TryChangeResolution(int width, int height, int bitsPerPixel, float refreshRate)

        public bool TryChangeResolution(int width, int height, int bitsPerPixel, float refreshRate)
        {
            DeviceMode settings = new DeviceMode();
            settings.PelsWidth = width;
            settings.PelsHeight = height;
            settings.BitsPerPel = bitsPerPixel;
            settings.DisplayFrequency = (int)refreshRate;
            settings.Fields = Constants.DM_BITSPERPEL
                | Constants.DM_PELSWIDTH
                | Constants.DM_PELSHEIGHT;

            return Functions.ChangeDisplaySettings(settings, ChangeDisplaySettingsEnum.Fullscreen) ==
                Constants.DISP_CHANGE_SUCCESSFUL;
        }

        #endregion

        #region public void RestoreResolution()

        public void RestoreResolution()
        {
            Functions.ChangeDisplaySettings(null, (ChangeDisplaySettingsEnum)0);
            //Functions.ChangeDisplaySettings(
        }

        #endregion

        #region public DisplayDevice[] AvailableDevices

        public OpenTK.Graphics.DisplayDevice[] AvailableDevices
        {
            get { return null; }
        }

        #endregion

        #endregion
    }
}
