using OpenTK.Core.Platform;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.Windows
{
    internal enum WindowState
    {
        Restored,
        Maximized,
        Minimized,
    }


    internal class HWND : WindowHandle
    {
        public IntPtr HWnd { get; private set; }

        public HitTest? HitTest { get; set; }

        public bool Destroyed { get; set; } = false;

        /// <summary> The current cursor for this window. </summary>
        public HCursor? HCursor { get; set; }

        public HIcon? HIcon { get; set; }

        public bool TrackingMouse { get; set; }

        // FIXME: Initialize this property properly!
        public WindowState WindowState { get; set; }

        public int? MaxWidth { get; set; }
        public int? MaxHeight { get; set; }
        public int? MinWidth { get; set; }
        public int? MinHeight { get; set; }

        public CursorCaptureMode CaptureMode { get; set; } = CursorCaptureMode.Normal;
        public Vector2i LastMousePosition { get; set; }
        public Vector2 VirtualCursorPosition { get; set; }

        public HMonitor? FullscreenMonitor { get; set; }
        public bool ExclusiveFullscreen { get; set; }
        public Win32.WINDOWPLACEMENT PreviousPlacement { get; set; }
        public WindowBorderStyle PreviousBorderStyle { get; set; } = WindowBorderStyle.ResizableBorder;

        public bool RawMouseMotionEnabled { get; set; } = false;

        public HWND(IntPtr hWnd, GraphicsApiHints hints) : base(hints)
        {
            HWnd = hWnd;
        }
    }

    internal class HGLRC : OpenGLContextHandle
    {
        public IntPtr HGlrc { get; private set; }

        // Because we are using CS_OWNDC we can keep a reference to this DC.
        // - Noggin_bops 2023-01-11
        public IntPtr HDC { get; private set; }

        public HGLRC? SharedContext { get; private set; }

        public bool UseDwmFlush { get; set; } = false;

        public HGLRC(IntPtr hGlrc, IntPtr hdc, HGLRC? sharedContext)
        {
            HGlrc = hGlrc;
            HDC = hdc;
            SharedContext = sharedContext;
        }
    }

    internal class HCursor : CursorHandle
    {
        public IntPtr Cursor { get; set; }

        public CursorMode Mode { get; set; } = CursorMode.Uninitialized;

        public IntPtr ColorBitmap { get; set; }

        public IntPtr MaskBitmap { get; set; }

        internal enum CursorMode
        {
            Uninitialized,
            SystemCursor,
            Icon,
            FileIcon,
        }
    }

    internal class HIcon : IconHandle
    {
        public IconMode Mode { get; set; }

        public IntPtr Icon { get; set; }

        public IntPtr ColorBitmap { get; set; }

        public IntPtr MaskBitmap { get; set; }

        internal enum IconMode
        {
            Uninitialized,
            SystemIcon,
            Icon,
            FileIcon,
        }
    }

    internal class HMonitor : DisplayHandle
    {
        public IntPtr Monitor { get; set; }

        public string DeviceName { get; set; }

        public string AdapterName { get; set; }

        public string PublicName { get; set; }

        public bool IsPrimary { get; set; }

        public Win32.POINTL Position { get; set; }

        public DisplayResolution Resolution { get; set; }

        public Win32.RECT WorkArea { get; set; }

        public int RefreshRate { get; set; }

        public int BitsPerPixel { get; set; }

        public int DpiX { get; set; }

        public int DpiY { get; set; }
    }

    internal class Joystick : JoystickHandle
    {
        public int XInputIndex;

        public DirectInput.IDirectInputDevice8 Device;
        public Guid InstanceGuid;
        public string InstanceName;

        public Joystick(DirectInput.IDirectInputDevice8 device, Guid instanceGuid, string instanceName)
        {
            Device = device;
            InstanceGuid = instanceGuid;
            InstanceName = instanceName;
        }
    }
}
