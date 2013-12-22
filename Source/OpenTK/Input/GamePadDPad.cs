// #region License
//
// GamePadDPad.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2013 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
// #endregion
using System;

namespace OpenTK.Input
{

    public struct GamePadDPad : IEquatable<GamePadDPad>
    {
        [Flags]
        enum DPadButtons : byte
        {
            Up = Buttons.DPadUp,
            Down = Buttons.DPadDown,
            Left = Buttons.DPadLeft,
            Right = Buttons.DPadRight
        }

        DPadButtons buttons;

        #region Public Members

        internal GamePadDPad(Buttons state)
        {
            // DPad butons are stored in the lower 4bits
            // of the Buttons enumeration.
            buttons = (DPadButtons)((int)state & 0x0f);
        }

        public bool IsUp
        {
            get { return (buttons  & DPadButtons.Up) != 0; }
            internal set { SetButton(DPadButtons.Up, value); }
        }

        public bool IsDown
        {
            get { return (buttons & DPadButtons.Down) != 0; }
            internal set { SetButton(DPadButtons.Down, value); }
        }

        public bool IsLeft
        {
            get { return (buttons & DPadButtons.Left) != 0; }
            internal set { SetButton(DPadButtons.Left, value); }
        }

        public bool IsRight
        {
            get { return (buttons & DPadButtons.Right) != 0; }
            internal set { SetButton(DPadButtons.Right, value); }
        }

        public static bool operator ==(GamePadDPad left, GamePadDPad right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GamePadDPad left, GamePadDPad right)
        {
            return !left.Equals(right);
        }

        public override string ToString()
        {
            return String.Format(
                "{{{0}{1}{2}{3}}}",
                IsUp ? "U" : String.Empty,
                IsLeft ? "L" : String.Empty,
                IsDown ? "D" : String.Empty,
                IsRight ? "R" : String.Empty);
        }

        public override int GetHashCode()
        {
            return buttons.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return
                obj is GamePadDPad &&
                Equals((GamePadDPad)obj);
        }

        #endregion

        #region Private Members

        void SetButton(DPadButtons button, bool value)
        {
            if (value)
            {
                buttons |= button;
            }
            else
            {
                buttons &= ~button;
            }
        }

        #endregion

        #region IEquatable<GamePadDPad> Members

        public bool Equals(GamePadDPad other)
        {
            return buttons == other.buttons;
        }

        #endregion
    }
}
