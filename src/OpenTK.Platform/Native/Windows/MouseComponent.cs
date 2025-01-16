using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using System.ComponentModel;
using System.Runtime.InteropServices;

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
        public void Uninitialize()
        {
        }

        /// <inheritdoc/>
        public bool CanSetMousePosition => true;

        /// <inheritdoc/>
        public bool SupportsRawMouseMotion => true;

        /// <inheritdoc/>
        public void GetGlobalPosition(out Vector2 globalPosition)
        {
            // FIXME: When hibernating (or going out of hibernate) this function fails with 0x5 Access denied.
            bool success = Win32.GetCursorPos(out Win32.POINT lpPoint);
            if (success == false)
            {
                //throw new Win32Exception();
            }

            globalPosition.X = lpPoint.X;
            globalPosition.Y = lpPoint.Y;
        }

        /// <inheritdoc/>
        public void GetPosition(WindowHandle window, out Vector2 position)
        {
            HWND hwnd = window.As<HWND>(this);

            if (hwnd.CaptureMode == CursorCaptureMode.Locked)
            {
                position = hwnd.VirtualCursorPosition;
            }
            else
            {
                position = hwnd.LastMousePosition;
            }
        }

        /// <inheritdoc/>
        public void SetGlobalPosition(Vector2 newGlobalPosition)
        {
            bool success = Win32.SetCursorPos((int)newGlobalPosition.X, (int)newGlobalPosition.Y);
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
            state.Position = (lpPoint.X, lpPoint.Y);

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
            state.Position = (hwnd.CaptureMode == CursorCaptureMode.Locked) ? hwnd.VirtualCursorPosition : hwnd.LastMousePosition;
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
