#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
#if !MINIMAL
using System.Drawing;
#endif
using System.Runtime.InteropServices;

namespace OpenTK.Platform.X11
{
    sealed class X11DisplayDevice : DisplayDeviceBase
    {
        // Store a mapping between resolutions and their respective
        // size_index (needed for XRRSetScreenConfig). The size_index
        // is simply the sequence number of the resolution as returned by
        // XRRSizes. This is done per available screen.
        readonly List<Dictionary<DisplayResolution, int>> screenResolutionToIndex =
            new List<Dictionary<DisplayResolution, int>>();
        // Store a mapping between DisplayDevices and their default resolutions.
        readonly Dictionary<DisplayDevice, int> deviceToDefaultResolution = new Dictionary<DisplayDevice, int>();
        // Store a mapping between DisplayDevices and X11 screens.
        readonly Dictionary<DisplayDevice, int> deviceToScreen = new Dictionary<DisplayDevice, int>();
        // Keep the time when the config of each screen was last updated.
        readonly List<IntPtr> lastConfigUpdate = new List<IntPtr>();

        bool xinerama_supported, xrandr_supported, xf86_supported;
        
        #region Constructors

        public X11DisplayDevice()
        {
            RefreshDisplayDevices();
        }

        #endregion

        #region Private Methods

        void RefreshDisplayDevices()
        {
            using (new XLock(API.DefaultDisplay))
            {
                List<DisplayDevice> devices = new List<DisplayDevice>();
                xinerama_supported = false;
                try
                {
                    xinerama_supported = QueryXinerama(devices);
                }
                catch
                {
                    Debug.Print("Xinerama query failed.");
                }

                if (!xinerama_supported)
                {
                    // We assume that devices are equivalent to the number of available screens.
                    // Note: this won't work correctly in the case of distinct X servers.
                    for (int i = 0; i < API.ScreenCount; i++)
                    {
                        DisplayDevice dev = new DisplayDevice();
                        dev.IsPrimary = i == Functions.XDefaultScreen(API.DefaultDisplay);
                        devices.Add(dev);
                        deviceToScreen.Add(dev, i);
                    }
                }

                try
                {
                    xrandr_supported = QueryXRandR(devices);
                }
                catch { }

                if (!xrandr_supported)
                {
                    Debug.Print("XRandR query failed, falling back to XF86.");
                    try
                    {
                        xf86_supported = QueryXF86(devices);
                    }
                    catch { }

                    if (!xf86_supported)
                    {
                        Debug.Print("XF86 query failed, no DisplayDevice support available.");
                    }
                }

                AvailableDevices.Clear();
                AvailableDevices.AddRange(devices);
                Primary = FindDefaultDevice(devices);
            }
        }

        static DisplayDevice FindDefaultDevice(IEnumerable<DisplayDevice> devices)
        {
                foreach (DisplayDevice dev in devices)
                    if (dev.IsPrimary)
                        return dev;

            throw new InvalidOperationException("No primary display found. Please file a bug at http://www.opentk.com");
        }

        bool QueryXinerama(List<DisplayDevice> devices)
        {
            // Try to use Xinerama to obtain the geometry of all output devices.
            int event_base, error_base;
            if (NativeMethods.XineramaQueryExtension(API.DefaultDisplay, out event_base, out error_base) &&
                NativeMethods.XineramaIsActive(API.DefaultDisplay))
            {
                IList<XineramaScreenInfo> screens = NativeMethods.XineramaQueryScreens(API.DefaultDisplay);
                bool first = true;
                foreach (XineramaScreenInfo screen in screens)
                {
                    DisplayDevice dev = new DisplayDevice();
                    dev.Bounds = new Rectangle(screen.X, screen.Y, screen.Width, screen.Height);
                    if (first)
                    {
                        // We consider the first device returned by Xinerama as the primary one.
                        // Makes sense conceptually, but is there a way to verify this?
                        dev.IsPrimary = true;
                        first = false;
                    }
                    devices.Add(dev);
                    // It seems that all X screens are equal to 0 is Xinerama is enabled, at least on Nvidia (verify?)
                    deviceToScreen.Add(dev, 0 /*screen.ScreenNumber*/);
                }
            }
            return (devices.Count>0);
        }

        bool QueryXRandR(List<DisplayDevice> devices)
        {
            // Get available resolutions. Then, for each resolution get all available rates.
            foreach (DisplayDevice dev in devices)
            {
                int screen = deviceToScreen[dev];

                IntPtr timestamp_of_last_update;
                Functions.XRRTimes(API.DefaultDisplay, screen, out timestamp_of_last_update);
                lastConfigUpdate.Add(timestamp_of_last_update);

                List<DisplayResolution> available_res = new List<DisplayResolution>();

                // Add info for a new screen.
                screenResolutionToIndex.Add(new Dictionary<DisplayResolution, int>());

                int[] depths = FindAvailableDepths(screen);

                int resolution_count = 0;
                foreach (XRRScreenSize size in FindAvailableResolutions(screen))
                {
                    if (size.Width == 0 || size.Height == 0)
                    {
                        Debug.Print("[Warning] XRandR returned an invalid resolution ({0}) for display device {1}", size, screen);
                        continue;
                    }
                    short[] rates = null;
                    rates = Functions.XRRRates(API.DefaultDisplay, screen, resolution_count);

                    // It seems that XRRRates returns 0 for modes that are larger than the screen
                    // can support, as well as for all supported modes. On Ubuntu 7.10 the tool
                    // "Screens and Graphics" does report these modes, though.
                    foreach (short rate in rates)
                    {
                        // Note: some X servers (like Xming on Windows) do not report any rates other than 0.
                        // If we only have 1 rate, add it even if it is 0.
                        if (rate != 0 || rates.Length == 1)
                            foreach (int depth in depths)
                                available_res.Add(new DisplayResolution(0, 0, size.Width, size.Height, depth, (float)rate));
                    }
                    // Keep the index of this resolution - we will need it for resolution changes later.
                    foreach (int depth in depths)
                    {
                        // Note that Xinerama may return multiple devices for a single screen. XRandR will
                        // not distinguish between the two as far as resolutions are supported (since XRandR
                        // operates on X screens, not display devices) - we need to be careful not to add the
                        // same resolution twice!
                        DisplayResolution res = new DisplayResolution(0, 0, size.Width, size.Height, depth, 0);
                        if (!screenResolutionToIndex[screen].ContainsKey(res))
                            screenResolutionToIndex[screen].Add(res, resolution_count);
                    }

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

                if (dev.Bounds == Rectangle.Empty)
                {
                    // We have added depths.Length copies of each resolution
                    // Adjust the return value of XRRGetScreenInfo to retrieve the correct resolution
                    int index = current_resolution_index * depths.Length;
                    
                    // Make sure we are within the bounds of the available_res array
                    if (index >= available_res.Count)
                    {
                        // If not, use the return value of XRRGetScreenInfo directly
                        index = current_resolution_index;
                    }
                    DisplayResolution current_resolution = available_res[index];
                    dev.Bounds = new Rectangle(0, 0, current_resolution.Width, current_resolution.Height);
                }
                dev.BitsPerPixel = current_depth;
                dev.RefreshRate = current_refresh_rate;
                dev.AvailableResolutions = available_res;

                deviceToDefaultResolution.Add(dev, current_resolution_index);
            }

            return true;
        }

        bool QueryXF86(List<DisplayDevice> devices)
        {
            int major;
            int minor;

            try
            {
                if (!API.XF86VidModeQueryVersion(API.DefaultDisplay, out major, out minor))
                    return false;
            }
            catch (DllNotFoundException)
            {
                return false;
            }
            
            int currentScreen = 0;
            Debug.Print("Using XF86 v" + major.ToString() + "." + minor.ToString());

            foreach (DisplayDevice dev in devices)
            {
                int count;

                IntPtr srcArray;
                API.XF86VidModeGetAllModeLines(API.DefaultDisplay, currentScreen, out count, out srcArray);
                Debug.Print(count.ToString() + " modes detected on screen " + currentScreen.ToString());
                IntPtr[] array = new IntPtr[count];
                Marshal.Copy(srcArray, array, 0, count);
                API.XF86VidModeModeInfo Mode = new API.XF86VidModeModeInfo();

                int x;
                int y;
                API.XF86VidModeGetViewPort(API.DefaultDisplay, currentScreen, out x, out y);
                List<DisplayResolution> resolutions = new List<DisplayResolution>();
                for (int i = 0; i < count; i++)
                {
                    Mode = (API.XF86VidModeModeInfo)Marshal.PtrToStructure(array[i], typeof(API.XF86VidModeModeInfo));
                    resolutions.Add(new DisplayResolution(x, y, Mode.hdisplay, Mode.vdisplay, 24, (Mode.dotclock * 1000F) / (Mode.vtotal * Mode.htotal)));
                }

                dev.AvailableResolutions = resolutions;
                int pixelClock;
                API.XF86VidModeModeLine currentMode;
                API.XF86VidModeGetModeLine(API.DefaultDisplay, currentScreen, out pixelClock, out currentMode);
                dev.Bounds = new Rectangle(x, y, currentMode.hdisplay, (currentMode.vdisplay == 0) ? currentMode.vsyncstart : currentMode.vdisplay);
                dev.BitsPerPixel = FindCurrentDepth(currentScreen);
                dev.RefreshRate = (pixelClock * 1000F) / (currentMode.vtotal * currentMode.htotal);
                currentScreen++;
            }
            return true;
        }

        #region static int[] FindAvailableDepths(int screen)

        static int[] FindAvailableDepths(int screen)
        {
            return Functions.XListDepths(API.DefaultDisplay, screen);
        }

        #endregion

        #region static XRRScreenSize[] FindAvailableResolutions(int screen)

        static XRRScreenSize[] FindAvailableResolutions(int screen)
        {
            XRRScreenSize[] resolutions = null;
            resolutions = Functions.XRRSizes(API.DefaultDisplay, screen);
            if (resolutions == null)
                throw new NotSupportedException("XRandR extensions not available.");
            return resolutions;
        }

        #endregion

        #region static float FindCurrentRefreshRate(int screen)

        static float FindCurrentRefreshRate(int screen)
        {
            short rate = 0;
            IntPtr screen_config = Functions.XRRGetScreenInfo(API.DefaultDisplay, Functions.XRootWindow(API.DefaultDisplay, screen));
            rate = Functions.XRRConfigCurrentRate(screen_config);
            Functions.XRRFreeScreenConfigInfo(screen_config);
            return (float)rate;
        }

        #endregion

        #region private static int FindCurrentDepth(int screen)

        static int FindCurrentDepth(int screen)
        {
            return (int)Functions.XDefaultDepth(API.DefaultDisplay, screen);
        }

        #endregion

        bool ChangeResolutionXRandR(DisplayDevice device, DisplayResolution resolution)
        {
            using (new XLock(API.DefaultDisplay))
            {
                int screen = deviceToScreen[device];
                IntPtr root = Functions.XRootWindow(API.DefaultDisplay, screen);
                IntPtr screen_config = Functions.XRRGetScreenInfo(API.DefaultDisplay, root);

                ushort current_rotation;
                int current_resolution_index = Functions.XRRConfigCurrentConfiguration(screen_config, out current_rotation);
                int new_resolution_index;
                if (resolution != null)
                    new_resolution_index = screenResolutionToIndex[screen]
                        [new DisplayResolution(0, 0, resolution.Width, resolution.Height, resolution.BitsPerPixel, 0)];
                else
                    new_resolution_index = deviceToDefaultResolution[device];

                Debug.Print("Changing size of screen {0} from {1} to {2}",
                    screen, current_resolution_index, new_resolution_index);

                int ret = 0;
                short refresh_rate =(short)(resolution != null ? resolution.RefreshRate : 0);
                if (refresh_rate > 0)
                {
                    ret = Functions.XRRSetScreenConfigAndRate(API.DefaultDisplay,
                    screen_config, root, new_resolution_index, current_rotation,
                    refresh_rate, IntPtr.Zero);
                }
                else
                {
                    ret = Functions.XRRSetScreenConfig(API.DefaultDisplay,
                    screen_config, root, new_resolution_index, current_rotation,
                    IntPtr.Zero);
                }

                if (ret != 0)
                {
                    Debug.Print("[Error] Change to resolution {0} failed with error {1}.",
                        resolution, (ErrorCode)ret);
                }

                return ret == 0;
            }
        }

        static bool ChangeResolutionXF86(DisplayDevice device, DisplayResolution resolution)
        {
            return false;
        }

        #endregion

        #region IDisplayDeviceDriver Members

        public sealed override bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution)
        {
            // If resolution is null, restore the default resolution (new_resolution_index = 0).

            if (xrandr_supported)
            {
                return ChangeResolutionXRandR(device, resolution);
            }
            else if (xf86_supported)
            {
                return ChangeResolutionXF86(device, resolution);
            }
            else
            {
                return false;
            }
        }

        public sealed override bool TryRestoreResolution(DisplayDevice device)
        {
            return TryChangeResolution(device, null);
        }

        #endregion

        #region NativeMethods

        static class NativeMethods
        {
            const string Xinerama = "libXinerama";

            [DllImport(Xinerama)]
            public static extern bool XineramaQueryExtension(IntPtr dpy, out int event_basep, out int error_basep);

            [DllImport(Xinerama)]
            public static extern int XineramaQueryVersion (IntPtr dpy, out int major_versionp, out int minor_versionp);

            [DllImport(Xinerama)]
            public static extern bool XineramaIsActive(IntPtr dpy);

            [DllImport(Xinerama)]
            static extern IntPtr XineramaQueryScreens(IntPtr dpy, out int number);

            public static IList<XineramaScreenInfo> XineramaQueryScreens(IntPtr dpy)
            {
                int number;
                IntPtr screen_ptr = XineramaQueryScreens(dpy, out number);
                List<XineramaScreenInfo> screens = new List<XineramaScreenInfo>(number);

                unsafe
                {
                    XineramaScreenInfo* ptr = (XineramaScreenInfo*)screen_ptr;
                    while (--number >= 0)
                    {
                        screens.Add(*ptr);
                        ptr++;
                    }
                }

                return screens;
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        struct XineramaScreenInfo
        {
            public int ScreenNumber;
            public short X;
            public short Y;
            public short Width;
            public short Height;
        }

        #endregion
    }
}
