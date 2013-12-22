// #region License
//
// GamePadButtons.cs
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

    public struct GamePadButtons : IEquatable<GamePadButtons>
    {
        Buttons buttons;

        public GamePadButtons(Buttons state)
        {
            buttons = state;
        }

        #region Public Members

        public ButtonState A
        {
            get { return GetButton(Buttons.A); }
        }

        public ButtonState B
        {
            get { return GetButton(Buttons.B); }
        }

        public ButtonState X
        {
            get { return GetButton(Buttons.X); }
        }

        public ButtonState Y
        {
            get { return GetButton(Buttons.Y); }
        }

        public ButtonState Back
        {
            get { return GetButton(Buttons.Back); }
        }

        public ButtonState BigButton
        {
            get { return GetButton(Buttons.BigButton); }
        }

        public ButtonState LeftShoulder
        {
            get { return GetButton(Buttons.LeftShoulder); }
        }

        public ButtonState LeftStick
        {
            get { return GetButton(Buttons.LeftStick); }
        }

        public ButtonState RightShoulder
        {
            get { return GetButton(Buttons.RightShoulder); }
        }

        public ButtonState RightStick
        {
            get { return GetButton(Buttons.RightStick); }
        }

        public ButtonState Start
        {
            get { return GetButton(Buttons.Start); }
        }

        public static bool operator ==(GamePadButtons left, GamePadButtons right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GamePadButtons left, GamePadButtons right)
        {
            return !left.Equals(right);
        }

        public override string ToString()
        {
            return String.Format(
                "{{{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}}}",
                A == ButtonState.Pressed ? "A" : String.Empty,
                B == ButtonState.Pressed ? "B" : String.Empty,
                X == ButtonState.Pressed ? "X" : String.Empty,
                Y == ButtonState.Pressed ? "Y" : String.Empty,
                LeftShoulder == ButtonState.Pressed ? "L" : String.Empty,
                RightShoulder == ButtonState.Pressed ? "R" : String.Empty,
                Back == ButtonState.Pressed ? " Back" : String.Empty,
                BigButton == ButtonState.Pressed ? " Big" : String.Empty,
                LeftStick == ButtonState.Pressed ? " LStick" : String.Empty,
                RightStick == ButtonState.Pressed ? " RStick" : String.Empty);
        }

        public override int GetHashCode()
        {
            return buttons.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return
                obj is GamePadButtons &&
                Equals((GamePadButtons)obj);
        }

        #endregion

        #region IEquatable<GamePadButtons> Members

        public bool Equals(GamePadButtons other)
        {
            return buttons == other.buttons;
        }

        #endregion

        #region Private Members

        ButtonState GetButton(Buttons b)
        {
            return (buttons & b) != 0 ? ButtonState.Pressed : ButtonState.Released;
        }

        #endregion
    }
}

