using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

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
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.MiceInput)
            {
                throw new Exception("OpenGLComponent can only initialize the OpenGL component.");
            }
        }

        /// <inheritdoc/>
        public bool CanSetMousePosition => true;

        /// <inheritdoc/>
        public void GetPosition(out int x, out int y)
        {
            // FIXME: Check the handle!

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
        public void SetPosition(int x, int y)
        {
            // FIXME: Check the handle!

            bool success = Win32.SetCursorPos(x, y);
            if (success == false)
            {
                throw new Win32Exception();
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
        internal static void RegisterMouseWheelDelta(Vector2 delta)
        {
            ScrollPosition += delta;
        }

        /// <inheritdoc/>
        public void GetMouseState(out MouseState state)
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
    }
}
