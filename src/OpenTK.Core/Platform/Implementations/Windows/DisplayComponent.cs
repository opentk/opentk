using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform.Implementations.Windows
{
    public class DisplayComponent : IDisplayComponent
    {
        public string Name => "Win32DisplayComponent";

        public PalComponents Provides => PalComponents.Display;

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Display)
            {
                throw new Exception("DisplayComponent can only initialize the Display component.");
            }

            IntPtr hDC = Win32.GetDC(IntPtr.Zero);

            static bool Callback(IntPtr hMonitor, IntPtr hdcMonitor, ref Win32.RECT lprcMonitor, IntPtr dwData)
            {
                Win32.MONITORINFOEX info = default;
                info.cbSize = (uint)Marshal.SizeOf<Win32.MONITORINFOEX>();
                Win32.GetMonitorInfo(hMonitor, ref info);

                Console.WriteLine("Device: " + info.szDevice);

                return true;
            }

            bool success = Win32.EnumDisplayMonitors(IntPtr.Zero, in Unsafe.NullRef<Win32.RECT>(), Callback, IntPtr.Zero);
            if (success == false)
            {
                throw new Exception("EnumDisplayMonitors failed.");
            }
        }

        public bool CanSetVideoMode => throw new NotImplementedException();

        public bool CanGetVirtualPosition => throw new NotImplementedException();

        public bool CanGetDisplaySize => throw new NotImplementedException();

        public int GetDisplayCount()
        {
            int count = Win32.GetSystemMetrics(SystemMetric.CMonitors);
            if (count == 0)
            {
                throw new Exception("GetSystemMetrics(SM_CMONITOR) failed.");
            }

            return count;
        }

        // FIXME: You probably shouldn't "create" a monitor handle.
        public DisplayHandle Create(int index)
        {
            throw new NotImplementedException();
        }

        public DisplayHandle CreatePrimary()
        {
            throw new NotImplementedException();
        }

        // FIXME: You probably also don't Destroy a monitor
        public void Destroy(DisplayHandle handle)
        {
            throw new NotImplementedException();
        }

        public string GetName(DisplayHandle handle)
        {
            throw new NotImplementedException();
        }

        public void GetVideoMode(DisplayHandle handle, out VideoMode mode)
        {
            throw new NotImplementedException();
        }

        public void SetVideoMode(DisplayHandle handle, in VideoMode mode)
        {
            throw new NotImplementedException();
        }

        public int GetSupportedVideoModeCount(DisplayHandle handle)
        {
            throw new NotImplementedException();
        }

        public void GetSupportedVideoModes(DisplayHandle handle, Span<VideoMode> modes)
        {
            throw new NotImplementedException();
        }

        public void GetDisplaySize(DisplayHandle handle, out float width, out float height)
        {
            throw new NotImplementedException();
        }

        public void GetVirtualPosition(DisplayHandle handle, out int x, out int y)
        {
            throw new NotImplementedException();
        }
    }
}
