//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.Diagnostics;
#if !MINIMAL
using Microsoft.Win32;
#endif

namespace OpenTK.Platform.Windows
{
    internal sealed class WinDisplayResolution : DisplayResolution
    {
        internal WinDisplayResolution(int x, int y, int width, int height, int bitsPerPixel, float refreshRate, int displayFlags)
            : base(x, y, width, height, bitsPerPixel, refreshRate)
        {
            this.DisplayFlags = displayFlags;
        }

        public readonly int DisplayFlags;
    }

    internal sealed class WinDisplayDeviceDriver : DisplayDeviceDriver
    {
        private readonly object display_lock = new object();

        // Small object for tracking name, available resolutions, and original resolution.
        private sealed class WinDevice
        {
            public int DevNum;
            public string Name;
            public DisplayResolution OriginalResolution;
            public List<DisplayResolution> AvailableResolutions;
        }

        public WinDisplayDeviceDriver()
        {
            RefreshDisplayDevices();
            SystemEvents.DisplaySettingsChanged += HandleDisplaySettingsChanged;
        }

        public override bool GetIsPrimary(object device)
        {
            var winDevice = (WinDevice)device;
            WindowsDisplayDevice dev1 = new WindowsDisplayDevice();
            if (!Functions.EnumDisplayDevices(null, winDevice.DevNum, dev1, 0))
            {
                Debug.Print(
                    "[Warning] DisplayDevice '{0}' not enumerated by EnumDisplayDevices. Please create a bug report at http://github.com/opentk/opentk/issues",
                    winDevice.Name);
                return false;
            }
            Debug.Print("GetIsPrimary.dev1:\n{0}", dev1);

            return (dev1.StateFlags & DisplayDeviceStateFlags.PrimaryDevice) != DisplayDeviceStateFlags.None;
        }

        public override DisplayResolution GetResolution(object device)
        {
            var winDevice = (WinDevice)device;
            var monitorMode = new DeviceMode();

            // The second function should only be executed when the first one fails
            // (e.g. when the monitor is disabled)
            if (Functions.EnumDisplaySettingsEx(winDevice.Name, DisplayModeSettingsEnum.CurrentSettings, monitorMode, 0) ||
                Functions.EnumDisplaySettingsEx(winDevice.Name, DisplayModeSettingsEnum.RegistrySettings, monitorMode, 0))
            {
                VerifyMode(winDevice.Name, monitorMode);

                float scale = GetScale(monitorMode);
                return new WinDisplayResolution(
                    (int)(monitorMode.Position.X / scale), (int)(monitorMode.Position.Y / scale),
                    (int)(monitorMode.PelsWidth / scale), (int)(monitorMode.PelsHeight / scale),
                    monitorMode.BitsPerPel, monitorMode.DisplayFrequency, monitorMode.DisplayFlags);
            }
            else
            {
                Debug.Print(
                    "[Warning] DisplayDevice '{0}' reported no resolution. Please create a bug report at http://github.com/opentk/opentk/issues",
                    winDevice.Name);
                return null;
            }
        }

        public override IList<DisplayResolution> GetAvailableResolutions(object device)
        {
            var winDevice = (WinDevice)device;
            return winDevice.AvailableResolutions.AsReadOnly();
        }

        public override bool TryChangeResolution(object device, DisplayResolution resolution)
        {
            var winResolution = (WinDisplayResolution)resolution;
            var winDevice = (WinDevice)device;
            DeviceMode mode = null;

            if (resolution != null)
            {
                mode = new DeviceMode();
                mode.PelsWidth = winResolution.Width;
                mode.PelsHeight = winResolution.Height;
                mode.BitsPerPel = winResolution.BitsPerPixel;
                mode.DisplayFrequency = (int)winResolution.RefreshRate;
                mode.DisplayFlags = winResolution.DisplayFlags;
                mode.Fields = Constants.DM_BITSPERPEL
                    | Constants.DM_PELSWIDTH
                    | Constants.DM_PELSHEIGHT
                    | Constants.DM_DISPLAYFREQUENCY
                    | Constants.DM_DISPLAYFLAGS;
            }

            var changeResult = Functions.ChangeDisplaySettingsEx(winDevice.Name, mode, IntPtr.Zero,
                ChangeDisplaySettingsEnum.Fullscreen, IntPtr.Zero);

            string reason;
            switch (changeResult)
            {
                case Constants.DISP_CHANGE_SUCCESSFUL:
                    return true;

                case Constants.DISP_CHANGE_BADDUALVIEW:
                    reason = "The settings change was unsuccessful because the system is DualView capable.";
                    break;
                case Constants.DISP_CHANGE_BADFLAGS:
                    reason = "An invalid set of flags was passed in.";
                    break;
                case Constants.DISP_CHANGE_BADMODE:
                    reason = "The graphics mode is not supported.";
                    break;
                case Constants.DISP_CHANGE_BADPARAM:
                    reason = "An invalid parameter was passed in. This can include an invalid flag or combination of flags.";
                    break;
                case Constants.DISP_CHANGE_FAILED:
                    reason = "The display driver failed the specified graphics mode.";
                    break;
                case Constants.DISP_CHANGE_NOTUPDATED:
                    reason = "Unable to write settings to the registry.";
                    break;
                case Constants.DISP_CHANGE_RESTART:
                    reason = "The computer must be restarted for the graphics mode to work.";
                    break;
                default:
                    reason = String.Format(
                        "Unknown reason '{0}'. Please create a bug report at http://github.com/opentk/opentk/issues.",
                        changeResult);
                    break;
            }

            Debug.Print(
                "[Warning] DisplayDevice '{0}' could not change resolution. {1}",
                winDevice.Name,
                reason);
            return false;
        }

        public override bool TryRestoreResolution(object device)
        {
            return TryChangeResolution(device, null);
        }

        public void RefreshDisplayDevices()
        {
            lock (display_lock)
            {
                // Store an array of the current available DisplayDevice objects.
                // This is needed to preserve the original resolution.
                var previousDevices = Devices.ToArray();

                Devices.Clear();

                var deviceCount = 0;

                // Get available video adapters and enumerate all monitors
                var dev1 = new WindowsDisplayDevice();
                while (Functions.EnumDisplayDevices(null, deviceCount++, dev1, 0))
                {
                    Debug.Print("RefreshDisplayDevices.EnumDisplayDevices[{0}]:\n{1}", deviceCount - 1, dev1);

                    var monitorCount = 0;
                    var mon1 = new WindowsDisplayDevice();
                    while (Functions.EnumDisplayDevices(dev1.DeviceName, monitorCount++, mon1, 0))
                    {
                        Debug.Print("RefreshDisplayDevices.EnumDisplayDevices[{0}]:\n{1}", monitorCount - 1, mon1);
                    }

                    if ((dev1.StateFlags & DisplayDeviceStateFlags.AttachedToDesktop) == DisplayDeviceStateFlags.None)
                    {
                        continue;
                    }

                    var isPrimary =
                        (dev1.StateFlags & DisplayDeviceStateFlags.PrimaryDevice) != DisplayDeviceStateFlags.None;

                    var winDevice = new WinDevice()
                    {
                        DevNum = deviceCount - 1,
                        Name = dev1.DeviceName,
                    };

                    winDevice.AvailableResolutions = new List<DisplayResolution>();
                    var modeCount = 0;
                    var monitorMode = new DeviceMode();
                    while (Functions.EnumDisplaySettingsEx(dev1.DeviceName, modeCount++, monitorMode, 0))
                    {
                        Debug.Print("RefreshDisplayDevices.EnumDisplaySettingsEx[{0}]: {{{1}, {2}, {3}, {4}, {5}, {6}}}",
                            modeCount - 1,
                            monitorMode.Position.X, monitorMode.Position.Y,
                            monitorMode.PelsWidth, monitorMode.PelsHeight,
                            monitorMode.BitsPerPel, monitorMode.DisplayFrequency,
                            monitorMode.DisplayFlags);

                        VerifyMode(dev1.DeviceName, monitorMode);
                        var scale = GetScale(monitorMode);
                        var res = new WinDisplayResolution(
                            (int)(monitorMode.Position.X / scale), (int)(monitorMode.Position.Y / scale),
                            (int)(monitorMode.PelsWidth / scale), (int)(monitorMode.PelsHeight / scale),
                            monitorMode.BitsPerPel, monitorMode.DisplayFrequency, monitorMode.DisplayFlags);

                        winDevice.AvailableResolutions.Add(res);
                    }

                    // Set the original resolution if the DisplayDevice was previously available.
                    foreach (DisplayDevice existingDevice in previousDevices)
                    {
                        var winExistingDevice = (WinDevice)existingDevice.id;
                        if (winExistingDevice.Name == winDevice.Name)
                        {
                            winDevice.OriginalResolution = winExistingDevice.OriginalResolution;
                        }
                    }

                    // New device, need to get it's current resolution to save
                    if (winDevice.OriginalResolution == null)
                    {
                        winDevice.OriginalResolution = GetResolution(winDevice);
                    }

                    var displayDevice = new DisplayDevice(winDevice);
                    Devices.Add(displayDevice);

                    Debug.Print("DisplayDevice {0} ({1}) added.",
                        deviceCount, isPrimary ? "primary" : "secondary");
                }
            }
        }

        private float GetScale(DeviceMode monitor_mode)
        {
            var scale = 1.0f;
            if ((monitor_mode.Fields & Constants.DM_LOGPIXELS) != 0)
            {
                scale = monitor_mode.LogPixels / 96.0f;
            }
            return scale;
        }

        private static void VerifyMode(string deviceName, DeviceMode mode)
        {
            if (mode.BitsPerPel == 0)
            {
                Debug.Print(
                    "[Warning] DisplayDevice '{0}' reported a mode with 0 bpp. Please create a bug report at http://github.com/opentk/opentk/issues",
                    deviceName);
                mode.BitsPerPel = 32;
            }
        }

        private void HandleDisplaySettingsChanged(object sender, EventArgs e)
        {
            Debug.Print("Display Settings Changed");
            RefreshDisplayDevices();
        }

        ~WinDisplayDeviceDriver()
        {
            SystemEvents.DisplaySettingsChanged -= HandleDisplaySettingsChanged;
        }
    }
}
