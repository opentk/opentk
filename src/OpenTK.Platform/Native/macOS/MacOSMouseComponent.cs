using System;
using OpenTK.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using static OpenTK.Platform.Native.macOS.ObjC;
using static OpenTK.Platform.Native.macOS.CG;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.macOS
{
    public class MacOSMouseComponent : IMouseComponent
    {
        internal static readonly ObjCClass NSEventClass = objc_getClass("NSEvent"u8);
        internal static readonly ObjCClass NSScreenClass = objc_getClass("NSScreen"u8);

        internal static readonly SEL selMouseLocation = sel_registerName("mouseLocation"u8);
        internal static readonly SEL selPressedMouseButtons = sel_registerName("pressedMouseButtons"u8);

        internal static readonly SEL selScreens = sel_registerName("screens"u8);
        internal static readonly SEL selObjectAtIndex = sel_registerName("objectAtIndex:"u8);
        internal static readonly SEL selFrame = sel_registerName("frame"u8);

        /// <inheritdoc/>
        public string Name => nameof(MacOSMouseComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.MiceInput;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public bool CanSetMousePosition => true;

        /// <inheritdoc/>
        public bool SupportsRawMouseMotion => false;

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
        }

        internal static void GetPosition(out double x, out double y)
        {
            CGPoint p = objc_msgSend_CGPoint((IntPtr)NSEventClass, selMouseLocation);
            NFloat flippedY = CG.FlipYCoordinate(p.y);

            x = p.x;
            y = flippedY;
        }

        /// <inheritdoc/>
        public void GetGlobalPosition(out Vector2 globalPosition)
        {
            CGPoint p = objc_msgSend_CGPoint((IntPtr)NSEventClass, selMouseLocation);
            NFloat flippedY = CG.FlipYCoordinate(p.y);

            globalPosition.X = (float)p.x;
            globalPosition.Y = (float)flippedY;
        }

        /// <inheritdoc/>
        public void GetPosition(WindowHandle window, out Vector2 position)
        {
            NSWindowHandle nswindow = window.As<NSWindowHandle>(this);

            if (nswindow.CursorCaptureMode == CursorCaptureMode.Locked)
            {
                position = (Vector2)nswindow.VirtualCursorPosition;
            }
            else
            {
                position = (Vector2)nswindow.LastMousePosition;
            }
        }

        /// <inheritdoc/>
        public void SetGlobalPosition(Vector2 newGlobalPosition)
        {
            // CGWarpMouseCursorPosition uses top left relative coordinates.
            CGWarpMouseCursorPosition(new CGPoint(newGlobalPosition.X, newGlobalPosition.Y));
        }

        internal static void RegisterButtonState(NSWindowHandle? nswindow, MouseButton button, bool pressed)
        {
            MouseButtonFlags flag = (MouseButtonFlags)(1 << (int)button);

            if (nswindow != null)
            {
                if (pressed) nswindow.PressedMouseButtons |= flag;
                else nswindow.PressedMouseButtons &= ~flag;
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
        internal static void RegisterMouseWheelDelta(NSWindowHandle? nswindow, Vector2 delta)
        {
            if (nswindow != null)
            {
                nswindow.ScrollPosition += delta;
            }

            ScrollPosition += delta;
        }

        /// <inheritdoc/>
        public void GetGlobalMouseState(out MouseState state)
        {
            CGPoint p = objc_msgSend_CGPoint((IntPtr)NSEventClass, selMouseLocation);
            NFloat flippedY = CG.FlipYCoordinate(p.y);

            // FIXME: NSUInteger
            ulong buttons = objc_msgSend_ulong((IntPtr)NSEventClass, selPressedMouseButtons);

            state.Position = new Vector2((float)p.x, (float)flippedY);

            state.Scroll = ScrollPosition;

            state.PressedButtons = default;
            if ((buttons & 1 << 0) != 0)
                state.PressedButtons |= MouseButtonFlags.Button1;
            if ((buttons & 1 << 1) != 0)
                state.PressedButtons |= MouseButtonFlags.Button2;
            if ((buttons & 1 << 2) != 0)
                state.PressedButtons |= MouseButtonFlags.Button3;
            if ((buttons & 1 << 3) != 0)
                state.PressedButtons |= MouseButtonFlags.Button4;
            if ((buttons & 1 << 4) != 0)
                state.PressedButtons |= MouseButtonFlags.Button5;
            if ((buttons & 1 << 5) != 0)
                state.PressedButtons |= MouseButtonFlags.Button6;
            if ((buttons & 1 << 6) != 0)
                state.PressedButtons |= MouseButtonFlags.Button7;
            if ((buttons & 1 << 7) != 0)
                state.PressedButtons |= MouseButtonFlags.Button8;
        }

        /// <inheritdoc/>
        public void GetMouseState(WindowHandle window, out MouseState state)
        {
            NSWindowHandle nswindow = window.As<NSWindowHandle>(this);

            state.Position = (nswindow.CursorCaptureMode == CursorCaptureMode.Locked) ? (Vector2)nswindow.VirtualCursorPosition : (Vector2)nswindow.LastMousePosition;
            state.Scroll = nswindow.ScrollPosition;
            state.PressedButtons = nswindow.PressedMouseButtons;
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
