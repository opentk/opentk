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
    internal sealed class WinDisplayDevice : DisplayDevice
    {
        public readonly int DevNum;
        public readonly string Name;
        public readonly DisplayResolution OriginalResolution;
        public readonly List<DisplayResolution> Resolutions = new List<DisplayResolution>();
        private WindowsDisplayDevice _dev1 = new WindowsDisplayDevice();

        public WinDisplayDevice(int devNum, string name)
        {
            DevNum = devNum;
            Name = name;
            OriginalResolution = CurrentResolution;
        }

        public override bool IsPrimary
        {
            get
            {
                if (!Functions.EnumDisplayDevices(null, DevNum, _dev1, 0))
                {
                    Debug.Print(
                        "[Warning] DisplayDevice '{0}' not enumerated by EnumDisplayDevices. Please create a bug report at http://github.com/opentk/opentk/issues",
                        Name);
                    return false;
                }
                Debug.Print("GetIsPrimary.dev1:\n{0}", _dev1);

                return (_dev1.StateFlags & DisplayDeviceStateFlags.PrimaryDevice) != DisplayDeviceStateFlags.None;
            }
        }

        public override DisplayResolution CurrentResolution
        {
            get
            {
                var monitorMode = new DeviceMode();

                // The second function should only be executed when the first one fails
                // (e.g. when the monitor is disabled)
                if (Functions.EnumDisplaySettingsEx(Name, DisplayModeSettingsEnum.CurrentSettings, monitorMode, 0) ||
                    Functions.EnumDisplaySettingsEx(Name, DisplayModeSettingsEnum.RegistrySettings, monitorMode, 0))
                {
                    WinDisplayDeviceDriver.VerifyMode(Name, monitorMode);

                    float scale = WinDisplayDeviceDriver.GetScale(monitorMode);
                    return new WinDisplayResolution(
                        (int)(monitorMode.Position.X / scale), (int)(monitorMode.Position.Y / scale),
                        (int)(monitorMode.PelsWidth / scale), (int)(monitorMode.PelsHeight / scale),
                        monitorMode.BitsPerPel, monitorMode.DisplayFrequency, monitorMode.DisplayFlags);
                }
                else
                {
                    Debug.Print(
                        "[Warning] DisplayDevice '{0}' reported no resolution. Please create a bug report at http://github.com/opentk/opentk/issues",
                        Name);
                    return null;
                }
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
                return Resolutions.AsReadOnly();
            }
        }

        public override void ChangeResolution(DisplayResolution resolution)
        {
            DeviceMode mode = null;

            if (resolution != null)
            {
                var winResolution = (WinDisplayResolution)resolution;
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

            var changeResult = Functions.ChangeDisplaySettingsEx(Name, mode, IntPtr.Zero,
                ChangeDisplaySettingsEnum.Fullscreen, IntPtr.Zero);

            string reason;
            switch (changeResult)
            {
                case Constants.DISP_CHANGE_SUCCESSFUL:
                    return;

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

            throw new Graphics.GraphicsModeException(
                    string.Format("Device {0}: Failed to change resolution to {1}. {2}", this, resolution, reason));
        }

        public override void RestoreResolution()
        {
            ChangeResolution(null);
        }
    }

    internal sealed class WinDisplayResolution : DisplayResolution
    {
        internal WinDisplayResolution(int x, int y, int width, int height, int bitsPerPixel, float refreshRate, int displayFlags)
            : base(x, y, width, height, bitsPerPixel, refreshRate)
        {
            DisplayFlags = displayFlags;
        }

        public readonly int DisplayFlags;
    }

    internal sealed class WinDisplayDeviceDriver : DisplayDeviceDriver
    {
        private readonly object display_lock = new object();

        public WinDisplayDeviceDriver()
        {
            RefreshDisplayDevices();
            SystemEvents.DisplaySettingsChanged += HandleDisplaySettingsChanged;
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

                    var winDevice = new WinDisplayDevice(deviceCount - 1, dev1.DeviceName);
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

                        winDevice.Resolutions.Add(res);
                    }

                    // Set the original resolution if the DisplayDevice was previously available.
                    foreach (DisplayDevice existingDevice in previousDevices)
                    {
                        var winExistingDevice = (WinDisplayDevice)existingDevice;
                        if (winExistingDevice.Name == winDevice.Name)
                        {
                            winDevice = winExistingDevice;
                        }
                    }

                    Devices.Add(winDevice);

                    Debug.Print("DisplayDevice {0} ({1}) added.",
                        deviceCount, isPrimary ? "primary" : "secondary");
                }
            }
        }

        internal static float GetScale(DeviceMode monitor_mode)
        {
            var scale = 1.0f;
            if ((monitor_mode.Fields & Constants.DM_LOGPIXELS) != 0)
            {
                scale = monitor_mode.LogPixels / 96.0f;
            }
            return scale;
        }

        internal static void VerifyMode(string deviceName, DeviceMode mode)
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
