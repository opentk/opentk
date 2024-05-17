using System;
using OpenTK.Core.Platform;
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
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.MiceInput)
            {
                throw new PalException(this, "MacOSMouseComponent can only initialize the MiceInput component.");
            }
        }

        internal static void GetPosition(out double x, out double y)
        {
            CGPoint p = objc_msgSend_CGPoint((IntPtr)NSEventClass, selMouseLocation);
            NFloat flippedY = CG.FlipYCoordinate(p.y);

            x = p.x;
            y = flippedY;
        }

        /// <inheritdoc/>
        public void GetPosition(out int x, out int y)
        {
            CGPoint p = objc_msgSend_CGPoint((IntPtr)NSEventClass, selMouseLocation);
            NFloat flippedY = CG.FlipYCoordinate(p.y);

            x = (int)p.x;
            y = (int)flippedY;
        }

        /// <inheritdoc/>
        public void SetPosition(int x, int y)
        {
            // CGWarpMouseCursorPosition uses top left relative coordinates.
            CGWarpMouseCursorPosition(new CGPoint(x, y));
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
        internal static void RegisterMouseWheelDelta(Vector2 delta)
        {
            ScrollPosition += delta;
        }

        /// <inheritdoc/>
        public void GetMouseState(out MouseState state)
        {
            CGPoint p = objc_msgSend_CGPoint((IntPtr)NSEventClass, selMouseLocation);
            NFloat flippedY = CG.FlipYCoordinate(p.y);

            // FIXME: NSUInteger
            ulong buttons = objc_msgSend_ulong((IntPtr)NSEventClass, selPressedMouseButtons);

            state.Position = new Vector2i((int)p.x, (int)flippedY);

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
    }
}
