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
using System.Runtime.InteropServices;
#if !MINIMAL
using Microsoft.Win32;
using OpenTK.NT.Native;

#endif

namespace OpenTK.Platform.Windows
{
    internal sealed class WinDisplayDeviceDriver : DisplayDeviceBase
    {
        private readonly object display_lock = new object();

        public WinDisplayDeviceDriver()
        {
            RefreshDisplayDevices();
            SystemEvents.DisplaySettingsChanged += HandleDisplaySettingsChanged;
        }

        public override bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution)
        {
            var ptr = IntPtr.Zero;

            if (resolution != null)
            {
                var mode = new DeviceMode
                {
                    WidthInPixels = (uint)resolution.Width,
                    HeightInPixels = (uint)resolution.Height,
                    BitsPerPixel = (uint)resolution.BitsPerPixel,
                    DisplayFrequency = (uint)Math.Round(resolution.RefreshRate),
                    Fields = DeviceModeFieldFlags.BitsPerPixel
                            | DeviceModeFieldFlags.WidthInPixels
                            | DeviceModeFieldFlags.HeightInPixels
                            | DeviceModeFieldFlags.DisplayFrequency
                };

                Marshal.StructureToPtr(mode, ptr, true);
            }

            var result = User32.DeviceContext.ChangeDisplaySettingsEx(
                (string)device.Id,
                ptr,
                IntPtr.Zero,
                DisplaySettingsChanges.Fullscreen,
                IntPtr.Zero
            );

            return result == ChangeDisplaySettingsResult.Successful;
        }

        public override bool TryRestoreResolution(DisplayDevice device)
            => TryChangeResolution(device, null);

        public void RefreshDisplayDevices()
        {
            lock (display_lock)
            {
                // Store an array of the current available DisplayDevice objects.
                // This is needed to preserve the original resolution.
                var previousDevices = AvailableDevices.ToArray();

                AvailableDevices.Clear();

                // We save all necessary parameters in temporary variables
                // and construct the device when every needed detail is available.
                // The main DisplayDevice constructor adds the newly constructed device
                // to the list of available devices.
                DisplayDevice opentk_dev;
                DisplayResolution opentk_dev_current_res = null;
                var opentk_dev_available_res = new List<DisplayResolution>();
                bool opentk_dev_primary = false;
                uint device_count = 0, mode_count = 0;

                // Get available video adapters and enumerate all monitors
                while (User32.DeviceContext.EnumDisplayDevices(null, device_count++, out var dev1, 0))
                {
                    if ((dev1.StateFlags & DisplayDeviceStateFlags.AttachedToDesktop) == 0)
                        continue;

                    // The second function should only be executed when the first one fails
                    // (e.g. when the monitor is disabled)
                    if (User32.DeviceContext.EnumDisplaySettingsEx(dev1.DeviceName, DisplayModeSetting.CurrentSettings,
                            out DeviceMode monitor_mode, 0) ||
                        User32.DeviceContext.EnumDisplaySettingsEx(dev1.DeviceName, DisplayModeSetting.RegistrySettings,
                            out monitor_mode, 0))
                    {
                        VerifyMode(dev1, monitor_mode);

                        var scale = GetScale(ref monitor_mode);
                        opentk_dev_current_res = new DisplayResolution(
                            (int)(monitor_mode.DisplayOptions.Position.X / scale),
                            (int)(monitor_mode.DisplayOptions.Position.Y / scale),
                            (int)(monitor_mode.WidthInPixels / scale),
                            (int)(monitor_mode.HeightInPixels / scale),
                            (int)monitor_mode.BitsPerPixel,
                            monitor_mode.DisplayFrequency
                        );

                        opentk_dev_primary = (dev1.StateFlags & DisplayDeviceStateFlags.PrimaryDevice) != 0;
                    }

                    opentk_dev_available_res.Clear();
                    mode_count = 0;
                    while (User32.DeviceContext.EnumDisplaySettingsEx(dev1.DeviceName, (DisplayModeSetting)mode_count++, out monitor_mode, 0))
                    {
                        VerifyMode(dev1, monitor_mode);

                        var scale = GetScale(ref monitor_mode);
                        var res = new DisplayResolution(
                            (int)(monitor_mode.DisplayOptions.Position.X / scale),
                            (int)(monitor_mode.DisplayOptions.Position.Y / scale),
                            (int)(monitor_mode.WidthInPixels / scale),
                            (int)(monitor_mode.HeightInPixels / scale),
                            (int)monitor_mode.BitsPerPixel,
                            monitor_mode.DisplayFrequency
                        );

                        opentk_dev_available_res.Add(res);
                    }

                    // Construct the OpenTK DisplayDevice through the accumulated parameters.
                    // The constructor will automatically add the DisplayDevice to the list
                    // of available devices.
#pragma warning disable 612,618
                    opentk_dev = new DisplayDevice(
                        opentk_dev_current_res,
                        opentk_dev_primary,
                        opentk_dev_available_res,
                        opentk_dev_current_res.Bounds,
                        dev1.DeviceName
                    );
#pragma warning restore 612,618

                    // Set the original resolution if the DisplayDevice was previously available.
                    foreach (var existingDevice in previousDevices)
                        if ((string)existingDevice.Id == (string)opentk_dev.Id)
                            opentk_dev.OriginalResolution = existingDevice.OriginalResolution;

                    AvailableDevices.Add(opentk_dev);

                    if (opentk_dev_primary)
                        Primary = opentk_dev;

                    Debug.Print("DisplayDevice {0} ({1}) supports {2} resolutions.",
                        device_count, opentk_dev.IsPrimary ? "primary" : "secondary",
                        opentk_dev.AvailableResolutions.Count);
                }
            }
        }

        private float GetScale(ref DeviceMode monitor_mode)
        {
            float scale = 1.0f;
            if ((monitor_mode.Fields & DeviceModeFieldFlags.LogPixels) != 0)
                scale = monitor_mode.LogPixels / 96.0f;

            return scale;
        }

        private static void VerifyMode(NT.Native.DisplayDevice device, DeviceMode mode)
        {
            if (mode.BitsPerPixel == 0)
            {
                Debug.Print(
                    "[Warning] DisplayDevice '{0}' reported a mode with 0 bpp. Please create a bug report at https://github.com/opentk/opentk/issues",
                    device.DeviceName);
                mode.BitsPerPixel = 32;
            }
        }

        private void HandleDisplaySettingsChanged(object sender, EventArgs e)
            => RefreshDisplayDevices();

        ~WinDisplayDeviceDriver()
        {
            SystemEvents.DisplaySettingsChanged -= HandleDisplaySettingsChanged;
        }
    }
}