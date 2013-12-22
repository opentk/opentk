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
                "{{ABXYLR: {0}{1}{2}{3}{4}{5}; Back: {6}; BigButton: {7}; LStick: {8}; RStick: {9}}}",
                A == ButtonState.Pressed ? "1" : "0",
                B == ButtonState.Pressed ? "1" : "0",
                X == ButtonState.Pressed ? "1" : "0",
                Y == ButtonState.Pressed ? "1" : "0",
                LeftShoulder == ButtonState.Pressed ? "1" : "0",
                RightShoulder == ButtonState.Pressed ? "1" : "0",
                Back == ButtonState.Pressed ? "1" : "0",
                BigButton == ButtonState.Pressed ? "1" : "0",
                LeftStick == ButtonState.Pressed ? "1" : "0",
                RightStick == ButtonState.Pressed ? "1" : "0");
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

