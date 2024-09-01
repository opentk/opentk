using OpenTK.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Platform.Native.X11;

namespace OpenTK.Platform.Native.Windows
{
    public class MouseComponent : IMouseComponent
    {
        /// <inheritdoc/>
        public string Name => "Win32Mouse";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.MiceInput;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
        }

        /// <inheritdoc/>
        public bool CanSetMousePosition => true;

        /// <inheritdoc/>
        public bool SupportsRawMouseMotion => true;

        /// <inheritdoc/>
        public void GetGlobalPosition(out int x, out int y)
        {
            // FIXME: When hibernating (or going out of hibernate) this function fails with 0x5 Access denied.
            bool success = Win32.GetCursorPos(out Win32.POINT lpPoint);
            if (success == false)
            {
                //throw new Win32Exception();
            }

            x = lpPoint.X;
            y = lpPoint.Y;
        }

        /// <inheritdoc/>
        public void GetPosition(WindowHandle window, out int x, out int y)
        {
            HWND hwnd = window.As<HWND>(this);

            if (hwnd.CaptureMode == CursorCaptureMode.Locked)
            {
                x = (int)hwnd.VirtualCursorPosition.X;
                y = (int)hwnd.VirtualCursorPosition.Y;
            }
            else
            {
                x = hwnd.LastMousePosition.X;
                y = hwnd.LastMousePosition.Y;
            }
        }


        /// <inheritdoc/>
        public void SetPosition(int x, int y)
        {
            bool success = Win32.SetCursorPos(x, y);
            if (success == false)
            {
                throw new Win32Exception();
            }
        }

        internal static void RegisterButtonState(HWND? hwnd, MouseButton button, bool pressed)
        {
            MouseButtonFlags flag = (MouseButtonFlags)(1 << (int)button);

            if (hwnd != null)
            {
                // Record window local state
                if (pressed) hwnd.PressedMouseButtons |= flag;
                else hwnd.PressedMouseButtons &= ~flag;
            }
        }

        // FIXME: This is only a 32-bit float and
        // will quite quickly not be able to represent
        // deltas if the user continously scrolls in
        // one direction. Consider switching to doubles.
        // FIXME: This is only ever updated when we get
        // scroll messages to one of our windows, this is
        // not the "global" state of the scroll wheel.
        // Should we fix that? or is this what is expected?
        internal static Vector2 ScrollPosition = (0.0f, 0.0f);
        internal static void RegisterMouseWheelDelta(HWND? hwnd, Vector2 delta)
        {
            if (hwnd != null)
            {
                hwnd.ScrollPosition += delta;
            }

            ScrollPosition += delta;
        }

        /// <inheritdoc/>
        public void GetGlobalMouseState(out MouseState state)
        {
            Win32.GetCursorPos(out Win32.POINT lpPoint);
            state.Position.X = lpPoint.X;
            state.Position.Y = lpPoint.Y;

            state.Scroll = ScrollPosition;

            state.PressedButtons = default;
            if ((Win32.GetKeyState(VK.LeftButton) & 0x8000) != 0)
            {
                state.PressedButtons |= MouseButtonFlags.Button1;
            }

            if ((Win32.GetKeyState(VK.RightButton) & 0x8000) != 0)
            {
                state.PressedButtons |= MouseButtonFlags.Button2;
            }

            if ((Win32.GetKeyState(VK.MiddleButton) & 0x8000) != 0)
            {
                state.PressedButtons |= MouseButtonFlags.Button3;
            }

            if ((Win32.GetKeyState(VK.XButton1) & 0x8000) != 0)
            {
                state.PressedButtons |= MouseButtonFlags.Button4;
            }

            if ((Win32.GetKeyState(VK.XButton2) & 0x8000) != 0)
            {
                state.PressedButtons |= MouseButtonFlags.Button5;
            }
        }

        /// <inheritdoc/>
        public void GetMouseState(WindowHandle window, out MouseState state)
        {
            HWND hwnd = window.As<HWND>(this);
            state.Position = (hwnd.CaptureMode == CursorCaptureMode.Locked) ? (Vector2i)hwnd.VirtualCursorPosition : hwnd.LastMousePosition;
            state.Scroll = hwnd.ScrollPosition;
            state.PressedButtons = hwnd.PressedMouseButtons;
        }

        /// <inheritdoc/>
        public bool IsRawMouseMotionEnabled(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);
            return hwnd.RawMouseMotionEnabled;
        }

        /// <inheritdoc/>
        public void EnableRawMouseMotion(WindowHandle handle, bool enabled)
        {
            HWND hwnd = handle.As<HWND>(this);

            Win32.RAWINPUTDEVICE device;
            device.usUsagePage = HIDUsagePage.Generic;
            device.usUsage = (ushort)HIDUsageGeneric.Mouse;
            // FIXME: InputSink? ExInputSink?
            device.dwFlags = enabled ? 0 : RIDEV.Remove;
            device.hwndTarget = enabled ? hwnd.HWnd : 0;

            bool success = Win32.RegisterRawInputDevices(device, 1, (uint)Marshal.SizeOf<Win32.RAWINPUTDEVICE>());
            if (success == false)
            {
                throw new Win32Exception();
            }

            hwnd.RawMouseMotionEnabled = enabled;
        }
    }
}
