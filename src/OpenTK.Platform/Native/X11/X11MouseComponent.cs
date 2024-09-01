using OpenTK.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.X11.LibX11;

namespace OpenTK.Platform.Native.X11
{
    public class X11MouseComponent : IMouseComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(X11MouseComponent);

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
        public bool SupportsRawMouseMotion => false;

        /// <inheritdoc/>
        public void GetGlobalPosition(out int x, out int y)
        {
            byte ret = XQueryPointer(X11.Display, X11.DefaultRootWindow, out XWindow root, out XWindow child, out int root_x, out int root_y, out int win_x, out int win_y, out _);

            x = root_x;
            y = root_y;
        }

        /// <inheritdoc/>
        public void GetPosition(WindowHandle window, out int x, out int y)
        {
            // FIXME: Client space or desktop space coords?
            XWindowHandle xwindow = window.As<XWindowHandle>(this);
            if (xwindow.CaptureMode == CursorCaptureMode.Locked)
            {
                x = (int)xwindow.VirtualCursorPosition.X;
                y = (int)xwindow.VirtualCursorPosition.Y;
            }
            else
            {
                // FIXME: When the user gets a MouseMoveEventArgs this function
                // will not return the same position as the event is reporting.
                // Is this something we want to fix?
                // - Noggin_bops 2024-09-01
                x = xwindow.LastMousePosition.X;
                y = xwindow.LastMousePosition.Y;
            }
        }

        /// <inheritdoc/>
        public void SetPosition(int x, int y)
        {
            XWarpPointer(X11.Display, XWindow.None, X11.DefaultRootWindow, 0, 0, 0, 0, x, y);
        }

        internal static MouseButtonFlags MouseButtonState = default;
        /// <returns>True if the state of the button changed.</returns>
        internal static bool RegisterButtonState(XWindowHandle? xwindow, MouseButton button, bool pressed)
        {
            MouseButtonFlags flag = (MouseButtonFlags)(1 << (int)button);

            if (xwindow != null)
            {
                // Record window local state
                if (pressed) xwindow.PressedMouseButtons |= flag;
                else         xwindow.PressedMouseButtons &= ~flag;
            }

            // Record global state.
            bool wasPressed = (MouseButtonState & flag) != 0;
            if (pressed) MouseButtonState |= flag;
            else         MouseButtonState &= ~flag;
            return wasPressed == pressed;
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
        internal static void RegisterMouseWheelDelta(XWindowHandle? xwindow, Vector2 delta)
        {
            if (xwindow != null)
            {
                xwindow.ScrollPosition += delta;
            }

            ScrollPosition += delta;
        }

        /// <inheritdoc/>
        public void GetGlobalMouseState(out MouseState state)
        {
            byte ret = XQueryPointer(X11.Display, X11.DefaultRootWindow, out XWindow root, out XWindow child, out int root_x, out int root_y, out int win_x, out int win_y, out _);

            state.Position = (root_x, root_y);
            state.PressedButtons = MouseButtonState;
            state.Scroll = ScrollPosition;
        }

        /// <inheritdoc/>
        public void GetMouseState(WindowHandle window, out MouseState state)
        {
            XWindowHandle xwindow = window.As<XWindowHandle>(this);

            state.Position = (xwindow.CaptureMode == CursorCaptureMode.Locked) ? (Vector2i)xwindow.VirtualCursorPosition : xwindow.LastMousePosition;
            state.PressedButtons = xwindow.PressedMouseButtons;
            state.Scroll = xwindow.ScrollPosition;
        }

        /// <inheritdoc/>
        public bool IsRawMouseMotionEnabled(WindowHandle window)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void EnableRawMouseMotion(WindowHandle window, bool enable)
        {
            throw new NotImplementedException();
        }
    }
}
