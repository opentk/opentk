#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using OpenTK.Input;

namespace OpenTK.Platform.SDL2
{
    class Sdl2Mouse : IMouseDriver2
    {
        MouseState state;

        public Sdl2Mouse()
        {
            state.IsConnected = true;
        }

        #region Private Members

        static internal MouseButton TranslateButton(Button button)
        {
            switch (button)
            {
                case Button.Left:
                    return MouseButton.Left;

                case Button.Right:
                    return MouseButton.Right;

                case Button.Middle:
                    return MouseButton.Middle;

                case Button.X1:
                    return MouseButton.Button1;

                case Button.X2:
                    return MouseButton.Button2;

                default:
                    Debug.Print("SDL2 unknown button {0}", button);
                    return MouseButton.Left;
            }
        }

        void SetButtonState(MouseButton button, bool pressed)
        {
            if (pressed)
            {
                state.EnableBit((int)button);
            }
            else
            {
                state.DisableBit((int)button);
            }
        }

        #endregion

        #region Public Members

        public void ProcessWheelEvent(MouseWheelEvent wheel)
        {
            state.SetScrollRelative(wheel.X, wheel.Y);
        }

        public void ProcessMouseEvent(MouseMotionEvent motion)
        {
            state.X += motion.Xrel;
            state.Y += motion.Yrel;
        }

        public void ProcessMouseEvent(MouseButtonEvent button)
        {
            bool pressed = button.State == State.Pressed;
            SetButtonState(TranslateButton(button.Button), pressed);
        }

        #endregion

        #region IMouseDriver2 Members

        public MouseState GetState()
        {
            return state;
        }

        public MouseState GetState(int index)
        {
            if (index == 0)
                return state;
            else
                return new MouseState();
        }

        public MouseState GetCursorState()
        {
            int x, y;
            var buttons = SDL.GetMouseState(out x, out y);

            var c = new MouseState();
            c.SetIsConnected(true);
            c.X = x;
            c.Y = y;
            c.SetScrollAbsolute(state.Scroll.X, state.Scroll.Y); // we cannot query the scrollwheel directly
            c[MouseButton.Left] = (buttons & ButtonFlags.Left) != 0;
            c[MouseButton.Middle] = (buttons & ButtonFlags.Middle) != 0;
            c[MouseButton.Right] = (buttons & ButtonFlags.Right) != 0;
            c[MouseButton.Button1] = (buttons & ButtonFlags.X1) != 0;
            c[MouseButton.Button2] = (buttons & ButtonFlags.X2) != 0;

            return state;
        }

        public void SetPosition(double x, double y)
        {
            SDL.WarpMouseInWindow(IntPtr.Zero, (int)x, (int)y);
        }

        #endregion
    }
}

