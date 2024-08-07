using OpenTK.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.Windows
{
    public class DisplayComponent : IDisplayComponent
    {
        /// <inheritdoc/>
        public string Name => "Win32DisplayComponent";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Display;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        private static readonly List<HMonitor> _displays = new List<HMonitor>();

        internal static HMonitor? FindMonitor(IntPtr hMonitor)
        {
            foreach (HMonitor display in _displays)
            {
                if (display.Monitor == hMonitor)
                {
                    return display;
                }
            }

            return null;
        }

        private static IntPtr FindMonitorHandle(string adapterName)
        {
            IntPtr monitorHandle = default;

            bool FindHandleCallback(IntPtr hMonitor, IntPtr hdcMonitor, ref Win32.RECT lprcMonitor, IntPtr dwData)
            {
                Win32.MONITORINFOEX info = default;
                info.cbSize = (uint)Marshal.SizeOf<Win32.MONITORINFOEX>();
                if (Win32.GetMonitorInfo(hMonitor, ref info))
                {
                    if (adapterName == info.szDevice)
                    {
                        monitorHandle = hMonitor;
                    }
                }

                return true;
            }

            bool success = Win32.EnumDisplayMonitors(IntPtr.Zero, in Unsafe.NullRef<Win32.RECT>(), FindHandleCallback, IntPtr.Zero);
            if (success == false)
            {
                throw new Exception("EnumDisplayMonitors failed.");
            }

            return monitorHandle;
        }

        internal static void UpdateMonitors(bool sendEvents, ILogger? logger)
        {
            List<HMonitor> newDisplays = new List<HMonitor>();

            // Create a list with all current displays,
            // we will remove from this list as we enumerate displays.
            List<HMonitor> removedDisplays = new List<HMonitor>(_displays);

            HMonitor? oldPrimary = _displays.Find(h => h.IsPrimary);

            const uint ENUM_CURRENT_SETTINGS = unchecked((uint)-1);

            Win32.DISPLAY_DEVICE adapter = default;
            adapter.cb = (uint)Marshal.SizeOf<Win32.DISPLAY_DEVICE>();
            const int EDD_GET_DEVICE_INTERFACE_NAME = 0x00000001;
            for (uint index = 0; Win32.EnumDisplayDevices(null, index, ref adapter, EDD_GET_DEVICE_INTERFACE_NAME); index++)
            {
                if (adapter.StateFlags.HasFlag(DisplayDeviceStateFlags.Active) == false)
                {
                    continue;
                }

                // Console.WriteLine($"Adapter Name: {adapter.DeviceName}");
                // Console.WriteLine($"Adapter String: {adapter.DeviceString}");
                // Console.WriteLine($"Adapter State flags: {adapter.StateFlags}");

                // Create/Update the cache of display settigns data
                Win32.DEVMODE lpDevMode = default;
                lpDevMode.dmSize = (ushort)Marshal.SizeOf<Win32.DEVMODE>();
                Win32.EnumDisplaySettings(adapter.DeviceName, 0, ref lpDevMode);

                lpDevMode = default;
                lpDevMode.dmSize = (ushort)Marshal.SizeOf<Win32.DEVMODE>();
                if (Win32.EnumDisplaySettings(adapter.DeviceName, ENUM_CURRENT_SETTINGS, ref lpDevMode))
                {
                    // Console.WriteLine("Current settings:");
                    // Console.WriteLine($"  DeviceName: {lpDevMode.dmDeviceName}");
                    // Console.WriteLine($"  Position: {lpDevMode.dmPosition}");
                    // Console.WriteLine($"  BitsPerPel: {lpDevMode.dmBitsPerPel}");
                    // Console.WriteLine($"  PelsWidth: {lpDevMode.dmPelsWidth}");
                    // Console.WriteLine($"  PelsHeight: {lpDevMode.dmPelsHeight}");
                    // Console.WriteLine($"  DisplayFrequency: {lpDevMode.dmDisplayFrequency}");
                    // Console.WriteLine($"  DisplayFlags: {lpDevMode.dmDisplayFlags}");
                    // Console.WriteLine("  " + lpDevMode.dmFields);
                }

                IntPtr hMonitor = FindMonitorHandle(adapter.DeviceName);

                Win32.RECT workArea = default;

                Win32.MONITORINFOEX monitorInfo = default;
                monitorInfo.cbSize = (uint)Marshal.SizeOf<Win32.MONITORINFOEX>();
                if (Win32.GetMonitorInfo(hMonitor, ref monitorInfo))
                {
                    workArea = monitorInfo.rcWork;
                }

                Win32.DISPLAY_DEVICE monitor = default;
                monitor.cb = (uint)Marshal.SizeOf<Win32.DISPLAY_DEVICE>();

                for (uint monitorIndex = 0; Win32.EnumDisplayDevices(adapter.DeviceName, monitorIndex, ref monitor, 0); monitorIndex++)
                {
                    // Console.WriteLine($"  Monitor: {monitor.DeviceName}");
                    // Console.WriteLine($"  Monitor String: {monitor.DeviceString}");
                    // Console.WriteLine($"  Monitor State Flags: {monitor.StateFlags}");

                    HMonitor? info = null;
                    foreach (HMonitor display in _displays)
                    {
                        if (monitor.DeviceName == display.DeviceName)
                        {
                            // This monitor already exists.
                            removedDisplays.Remove(display);
                            info = display;
                            break;
                        }
                    }

                    if (info == null)
                    {
                        // FIXME: It seems DeviceString isn't great at actually getting a useful name
                        // for the display itself. It often returns "Generic PnP Monitor".
                        // It seems like there are some other APIs that can be used to query this information:
                        // https://stackoverflow.com/questions/7767036/how-do-i-get-the-number-of-displays-in-windows/65013500#65013500
                        // https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-displayconfiggetdeviceinfo
                        // https://learn.microsoft.com/en-us/windows/win32/api/wingdi/ns-wingdi-displayconfig_target_device_name
                        // Seems like we have to enumerate these too and link them to the hmonitor we are working with...?
                        // - Noggin_bops 2023-09-05

                        // This display didn't exist before, which means it's now conncted.
                        info = new HMonitor()
                        {
                            Monitor = hMonitor,
                            DeviceName = monitor.DeviceName,
                            AdapterName = adapter.DeviceName,
                            PublicName = monitor.DeviceString,
                            IsPrimary = adapter.StateFlags.HasFlag(DisplayDeviceStateFlags.PrimaryDevice),
                            Position = lpDevMode.dmPosition,
                            RefreshRate = (int)lpDevMode.dmDisplayFrequency,
                            BitsPerPixel = (int)lpDevMode.dmBitsPerPel,
                            Resolution = new DisplayResolution((int)lpDevMode.dmPelsWidth, (int)lpDevMode.dmPelsHeight),
                            DpiX = -1,
                            DpiY = -1,
                            WorkArea = workArea,
                        };

                        newDisplays.Add(info);
                    }
                    else
                    {
                        info.Monitor = hMonitor;

                        Debug.Assert(info.DeviceName == monitor.DeviceName);
                        Debug.Assert(info.PublicName == monitor.DeviceString);

                        info.IsPrimary = adapter.StateFlags.HasFlag(DisplayDeviceStateFlags.PrimaryDevice);

                        info.Position = lpDevMode.dmPosition;
                        info.RefreshRate = (int)lpDevMode.dmDisplayFrequency;
                        info.BitsPerPixel = (int)lpDevMode.dmBitsPerPel;
                        info.Resolution = new DisplayResolution((int)lpDevMode.dmPelsWidth, (int)lpDevMode.dmPelsHeight);
                        info.WorkArea = workArea;
                    }
                }
            }

            // Console.WriteLine();
            // Console.WriteLine();

            // FIXME: Maybe we should just send all of the data at once to the user.

            foreach (HMonitor removed in removedDisplays)
            {
                _displays.Remove(removed);

                if (sendEvents)
                {
                    EventQueue.Raise(removed, PlatformEventType.DisplayConnectionChanged, new DisplayConnectionChangedEventArgs(removed, true));
                    logger?.LogDebug($"Removed: {removed.DeviceName} (WasPrimary: {removed.IsPrimary}, Refresh: {removed.RefreshRate}, Res: {removed.Resolution})");
                }
            }

            foreach (HMonitor connected in newDisplays)
            {
                _displays.Add(connected);

                if (sendEvents)
                {
                    EventQueue.Raise(connected, PlatformEventType.DisplayConnectionChanged, new DisplayConnectionChangedEventArgs(connected, false));
                    logger?.LogDebug($"Connected: {connected.DeviceName} (IsPrimary: {connected.IsPrimary}, Refresh: {connected.RefreshRate}, Res: {connected.Resolution})");
                }
            }

            // FIXME: Maybe make sure that the primary display is always at the beginning of the list?
            // Right now the primary display is not guaranteed to be first in the DisplayConnectionChanged events...
            // - Noggin_bops 2024-02-28

            HMonitor? primary = null;
            foreach (HMonitor display in _displays)
            {
                if (display.IsPrimary)
                {
                    primary = display;
                    break;
                }
            }

            // Place the primary monitor at the beginning of the list.
            if (primary != null)
            {
                int index = _displays.IndexOf(primary);
                _displays.RemoveAt(index);
                _displays.Insert(0, primary);

                if (primary != oldPrimary)
                {
                    
                    logger?.LogDebug("New primary monitor!");
                }
            }
            else
            {
                logger?.LogWarning("Could not find primary monitor!");
            }
        }

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
            // FIXME: Should the user have any way to control the DPI awareness?
            if (OperatingSystem.IsWindowsVersionAtLeast(10, 0))
            {
                bool success = Win32.SetProcessDpiAwarenessContext(new IntPtr((int)DpiAwarenessContext.PerMonitorAwareV2));
                if (success == false)
                {
                    throw new Win32Exception();
                }
            }
            else if (OperatingSystem.IsWindowsVersionAtLeast(6, 3)) // Windows 8.1
            {
                // FIXME: Figure out what kind of awareness
                int result = Win32.SetProcessDpiAwareness(ProcessDPIAwareness.PerMonitorDpiAware);
                if (result == Win32.E_INVALIDARG)
                {
                    throw new Exception("SetProcessDpiAwareness failed with E_INVALIDARG");
                }
                else if (result == Win32.E_ACCESSDENIED)
                {
                    throw new Exception("SetProcessDpiAwareness failed with E_ACCESSDENIED");
                }
                else if (result != Win32.S_OK)
                {
                    throw new Exception($"SetProcessDpiAwareness failed with unknown error {result}");
                }
            }
            else
            {
                // Windows vista function for setting the process as DPI aware
                // Equivalent to `SetProcessDpiAwarenessContext(DPI_AWARENESS_CONTEXT_SYSTEM_AWARE)`
                bool success = Win32.SetProcessDPIAware();
                if (success == false)
                {
                    throw new Exception("SetProcessDPIAware failed.");
                }
            }

            UpdateMonitors(false, Logger);
        }

        /// <inheritdoc/>
        public bool CanGetVirtualPosition => true;

        /// <inheritdoc/>
        public int GetDisplayCount()
        {
            // Better to just return how many displays we know of so we
            // don't get weird out of bounds exceptions for "legal" code.
            return _displays.Count;

            //int count = Win32.GetSystemMetrics(SystemMetric.CMonitors);
            //if (count == 0)
            //{
            //    throw new Exception("GetSystemMetrics(SM_CMONITOR) failed.");
            //}
        }

        // FIXME: Indices for monitors is ill defined.
        // Need to look more into documentation for the monitor API.

        /// <inheritdoc/>
        public DisplayHandle Open(int index)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index), $"Monitor index cannot be negative. {index}");
            if (index >= _displays.Count) throw new ArgumentOutOfRangeException(nameof(index), $"Monitor index cannot be larger or equal to the number of displays. Index: {index}, Display count: {_displays.Count}");

            return _displays[index];
        }

        /// <inheritdoc/>
        public DisplayHandle OpenPrimary()
        {
            for (int i = 0; i < _displays.Count; i++)
            {
                if (_displays[i].IsPrimary)
                {
                    return _displays[i];
                }
            }

            throw new PalException(this, "Could not find primary monitor!");
        }

        /// <inheritdoc/>
        public void Close(DisplayHandle handle)
        {
            // We basically don't need to do anything here.
            // Just check that we got the right kind of handle back.
            HMonitor hmonitor = handle.As<HMonitor>(this);
        }

        /// <inheritdoc/>
        public bool IsPrimary(DisplayHandle handle)
        {
            HMonitor hmonitor = handle.As<HMonitor>(this);

            return hmonitor.IsPrimary;
        }

        /// <inheritdoc/>
        public string GetName(DisplayHandle handle)
        {
            HMonitor hmonitor = handle.As<HMonitor>(this);

            return hmonitor.PublicName;
        }

        /// <inheritdoc/>
        public void GetVideoMode(DisplayHandle handle, out VideoMode mode)
        {
            HMonitor hmonitor = handle.As<HMonitor>(this);

            mode = new VideoMode(
                hmonitor.Resolution.ResolutionX,
                hmonitor.Resolution.ResolutionY,
                hmonitor.RefreshRate,
                hmonitor.BitsPerPixel);
        }

        /// <inheritdoc/>
        public VideoMode[] GetSupportedVideoModes(DisplayHandle handle)
        {
            HMonitor hmonitor = handle.As<HMonitor>(this);

            // Unfortunately we don't know the size of the array we are going to create in advance
            List<VideoMode> modes = new List<VideoMode>(32);

            int modeIndex = 0;
            Win32.DEVMODE lpDevMode = default;
            lpDevMode.dmSize = (ushort)Marshal.SizeOf<Win32.DEVMODE>();
            while (Win32.EnumDisplaySettings(hmonitor.AdapterName, (uint)modeIndex++, ref lpDevMode))
            {
                // FIXME: What do we do with duplicated video modes?
                // For now we keep them, but there is no possibility of
                // differentiating them.
                // Should we decide or should we pass platform specific info to the user?

                const DM RequiredFields = DM.PelsWidth | DM.PelsHeight | DM.DisplayFrequency;

                if ((lpDevMode.dmFields & RequiredFields) != RequiredFields)
                    throw new PalException(this, $"Adapter setting {modeIndex - 1} didn't have all required fields set. dmFields={lpDevMode.dmFields}, requiredFields={RequiredFields}");

                modes.Add(new VideoMode((int)lpDevMode.dmPelsWidth, (int)lpDevMode.dmPelsHeight, lpDevMode.dmDisplayFrequency, (int)lpDevMode.dmBitsPerPel));
            }

            return modes.ToArray();
        }

        /// <inheritdoc/>
        public void GetVirtualPosition(DisplayHandle handle, out int x, out int y)
        {
            HMonitor hmonitor = handle.As<HMonitor>(this);

            x = hmonitor.Position.X;
            y = hmonitor.Position.Y;
        }

        /// <inheritdoc/>
        public void GetResolution(DisplayHandle handle, out int width, out int height)
        {
            HMonitor hmonitor = handle.As<HMonitor>(this);

            width = hmonitor.Resolution.ResolutionX;
            height = hmonitor.Resolution.ResolutionY;
        }

        /// <inheritdoc/>
        public void GetWorkArea(DisplayHandle handle, out Box2i area)
        {
            HMonitor hmonitor = handle.As<HMonitor>(this);

            Win32.RECT workArea = hmonitor.WorkArea;

            area = new Box2i(workArea.left, workArea.top, workArea.right, workArea.bottom);
        }

        /// <inheritdoc/>
        public void GetRefreshRate(DisplayHandle handle, out float refreshRate)
        {
            HMonitor hmonitor = handle.As<HMonitor>(this);

            refreshRate = hmonitor.RefreshRate;
        }

        /// <inheritdoc/>
        public void GetDisplayScale(DisplayHandle handle, out float  scaleX, out float scaleY)
        {
            HMonitor hmonitor = handle.As<HMonitor>(this);

            int success = Win32.GetDpiForMonitor(hmonitor.Monitor, MonitorDpiType.EffectiveDpi, out uint dpiX, out uint dpiY);
            if (success != Win32.S_OK)
            {
                throw new Exception("GetDpiForMonitor failed.");
            }

            // This is the platform default DPI for windows.
            const float DefaultDPI = 96;

            scaleX = dpiX / DefaultDPI;
            scaleY = dpiY / DefaultDPI;
        }

        /// <summary>
        /// Returns the win32 adapter string associated with this display.
        /// </summary>
        /// <param name="handle">A handle to a display to get the adapter name for.</param>
        /// <returns>The win32 adapter name for the display.</returns>
        public string GetAdapter(DisplayHandle handle)
        {
            HMonitor hmonitor = handle.As<HMonitor>(this);

            return hmonitor.AdapterName;
        }

        /// <summary>
        /// Returns the win32 mointor device name string associated with this display.
        /// </summary>
        /// <param name="handle">A handle to a display to get the monitor name for.</param>
        /// <returns>The win32 monitor name for the display.</returns>
        public string GetMonitor(DisplayHandle handle)
        {
            HMonitor hmonitor = handle.As<HMonitor>(this);

            return hmonitor.DeviceName;
        }
    }
}
