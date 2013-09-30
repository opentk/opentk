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
using System.Diagnostics;
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

        MouseButton TranslateButton(uint button)
        {
            switch (button)
            {
                case SDL.SDL_BUTTON_LEFT:
                    return MouseButton.Left;

                case SDL.SDL_BUTTON_RIGHT:
                    return MouseButton.Right;

                case SDL.SDL_BUTTON_MIDDLE:
                    return MouseButton.Middle;

                case SDL.SDL_BUTTON_X1:
                    return MouseButton.Button1;

                case SDL.SDL_BUTTON_X2:
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

        public void ProcessWheelEvent(SDL.SDL_MouseWheelEvent wheel)
        {
            state.WheelPrecise += wheel.y;
        }

        public void ProcessMouseEvent(SDL.SDL_MouseMotionEvent motion)
        {
            state.X += motion.xrel;
            state.Y += motion.yrel;
        }

        public void ProcessMouseEvent(SDL.SDL_MouseButtonEvent button)
        {
            bool pressed = button.state == SDL.SDL_PRESSED;
            SetButtonState(TranslateButton(button.button), pressed);
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

        public void SetPosition(double x, double y)
        {
            SDL.SDL_WarpMouseInWindow(IntPtr.Zero, (int)x, (int)y);
        }

        #endregion
    }
}

