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
        static object display_lock = new object();
        static Dictionary<DisplayDevice, string> available_device_names =
            new Dictionary<DisplayDevice, string>();    // Needed for ChangeDisplaySettingsEx

        #region --- Constructors ---

        /// <summary>Queries available display devices and display resolutions.</summary>
        static WinDisplayDeviceDriver()
        {
            lock (display_lock)
            {
                // To minimize the need to add static methods to OpenTK.Graphics.DisplayDevice
                // we only allow settings to be set through its constructor.
                // Thus, we save all necessary parameters in temporary variables
                // and construct the device when every needed detail is available.
                // The main DisplayDevice constructor adds the newly constructed device
                // to the list of available devices.
                DisplayDevice opentk_dev;
                DisplayResolution opentk_dev_current_res = null;
                List<DisplayResolution> opentk_dev_available_res = new List<DisplayResolution>();
                bool opentk_dev_primary = false;
                int device_count = 0, mode_count = 0;

                // Get available video adapters and enumerate all monitors
                WindowsDisplayDevice dev1 = new WindowsDisplayDevice(), dev2 = new WindowsDisplayDevice();
                while (Functions.EnumDisplayDevices(null, device_count++, dev1, 0))
                {
                    if ((dev1.StateFlags & DisplayDeviceStateFlags.AttachedToDesktop) == DisplayDeviceStateFlags.None)
                        continue;

                    DeviceMode monitor_mode = new DeviceMode();

                    // The second function should only be executed when the first one fails
                    // (e.g. when the monitor is disabled)
                    if (Functions.EnumDisplaySettingsEx(dev1.DeviceName.ToString(), DisplayModeSettingsEnum.CurrentSettings, monitor_mode, 0) ||
                        Functions.EnumDisplaySettingsEx(dev1.DeviceName.ToString(), DisplayModeSettingsEnum.RegistrySettings, monitor_mode, 0))
                    {
                        opentk_dev_current_res = new DisplayResolution(
                            monitor_mode.Position.X, monitor_mode.Position.Y,
                            monitor_mode.PelsWidth, monitor_mode.PelsHeight,
                            monitor_mode.BitsPerPel, monitor_mode.DisplayFrequency);
                        opentk_dev_primary =
                            (dev1.StateFlags & DisplayDeviceStateFlags.PrimaryDevice) != DisplayDeviceStateFlags.None;
                    }

                    opentk_dev_available_res.Clear();
                    mode_count = 0;
                    while (Functions.EnumDisplaySettings(dev1.DeviceName.ToString(), mode_count++, monitor_mode))
                    {
                        DisplayResolution res = new DisplayResolution(
                            monitor_mode.Position.X, monitor_mode.Position.Y,
                            monitor_mode.PelsWidth, monitor_mode.PelsHeight,
                            monitor_mode.BitsPerPel, monitor_mode.DisplayFrequency);

                        opentk_dev_available_res.Add(res);
                    }

                    // Construct the OpenTK DisplayDevice through the accumulated parameters.
                    // The constructor will automatically add the DisplayDevice to the list
                    // of available devices.
                    opentk_dev = new DisplayDevice(
                        opentk_dev_current_res,
                        opentk_dev_primary,
                        opentk_dev_available_res,
                        opentk_dev_current_res.Bounds);

                    available_device_names.Add(opentk_dev, dev1.DeviceName);
                }
            }
        }

        public WinDisplayDeviceDriver()
        {
        }

        #endregion

        #region --- IDisplayDeviceDriver Members ---

        #region public bool TryChangeResolution(OpenTK.Graphics.DisplayDevice device, DisplayResolution resolution)

        public bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution)
        {
            DeviceMode mode = null;

            if (resolution != null)
            {
                mode = new DeviceMode();
                mode.PelsWidth = resolution.Width;
                mode.PelsHeight = resolution.Height;
                mode.BitsPerPel = resolution.BitsPerPixel;
                mode.DisplayFrequency = (int)resolution.RefreshRate;
                mode.Fields = Constants.DM_BITSPERPEL
                    | Constants.DM_PELSWIDTH
                    | Constants.DM_PELSHEIGHT
                    | Constants.DM_DISPLAYFREQUENCY;
            }

            return Constants.DISP_CHANGE_SUCCESSFUL == 
                Functions.ChangeDisplaySettingsEx(available_device_names[device], mode, IntPtr.Zero,
                    ChangeDisplaySettingsEnum.Fullscreen, IntPtr.Zero);
        }

        #endregion

        #region public TryRestoreResolution TryRestoreResolution(OpenTK.Graphics.DisplayDevice device)

        public bool TryRestoreResolution(DisplayDevice device)
        {
            return TryChangeResolution(device, null);
        }

        #endregion

        #endregion
    }
}
