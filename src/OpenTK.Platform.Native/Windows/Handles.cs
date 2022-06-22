using OpenTK.Core.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace OpenTK.Platform.Native.Windows
{
#pragma warning disable SA1649 // File name should match first type name
    internal class HWND : WindowHandle
    {
        public IntPtr HWnd { get; private set; }

        /// <summary> The current cursor for this window. </summary>
        public HCursor? HCursor { get; set; }

        public HIcon? HIcon { get; set; }

        // FIXME: Is this a good place for this?
        public SimpleEventQueue<WindowEventType, WindowEventArgs> EventQueue { get; private set; } = new SimpleEventQueue<WindowEventType, WindowEventArgs>();

        // FIXME: This is kind of a hack so that we can get access to the window component in the WndProc...
        public WindowComponent WindowComponent { get; private set; }

        public HWND(IntPtr hWnd, WindowComponent windowComponent, GraphicsApiHints hints)
        {
            HWnd = hWnd;
            WindowComponent = windowComponent;
            GraphicsApiHints = hints;
        }
    }

    internal class HGLRC : OpenGLContextHandle
    {
        public IntPtr HGlrc { get; private set; }

        // FIXME: How do we want to handle this??
        public IntPtr HDC { get; private set; }

        // FIXME: Is this needed?
        public OpenGLComponent OpenGLComponent { get; private set; }

        public HGLRC(IntPtr hGlrc, IntPtr hdc, OpenGLComponent openglComponent)
        {
            HGlrc = hGlrc;
            HDC = hdc;
            OpenGLComponent = openglComponent;
        }
    }

    internal class HCursor : CursorHandle
    {
        public IntPtr Cursor { get; set; }

        public int HotSpotX { get; set; }

        public int HotSpotY { get; set; }

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

        public string Name { get; set; }

        public bool IsPrimary { get; set; }

        public Win32.POINTL Position { get; set; }

        public DisplayResolution Resolution { get; set; }

        public Win32.RECT WorkArea { get; set; }

        public int RefreshRate { get; set; }

        public int DpiX { get; set; }

        public int DpiY { get; set; }
    }

    internal class Win32EventQueue : IEventQueue<WindowEventType, WindowEventArgs>
    {
        public event QueueEventHandler<WindowEventType, WindowEventArgs> EventRaised;

        public void ProcessEvents()
        {
            throw new NotImplementedException();
        }

        public void IgnoreEvents()
        {
            throw new NotImplementedException();
        }

        public void DefaultEventHandler(object sender, WindowEventType type, WindowEventArgs arguments)
        {
            throw new NotImplementedException();
        }
    }

#pragma warning restore SA1649 // File name should match first type name
}
