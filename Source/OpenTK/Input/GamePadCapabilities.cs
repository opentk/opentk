// #region License
//
// GamePadCapabilities.cs
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

    public struct GamePadCapabilities : IEquatable<GamePadCapabilities>
    {
        Buttons buttons;
        byte gamepad_type;
        bool is_connected;

        #region Constructors

        public GamePadCapabilities(GamePadType type, Buttons buttons, bool is_connected)
            : this()
        {
            gamepad_type = (byte)type;
            this.buttons = buttons;
            this.is_connected = is_connected;
        }

        #endregion

        #region Public Members

        public GamePadType GamePadType
        {
            get { return (GamePadType)gamepad_type; }
        }

        public bool HasDPadUpButton
        {
            get { return (buttons & Buttons.DPadUp) != 0; }
        }

        public bool HasDPadLeftButton
        {
            get { return (buttons & Buttons.DPadLeft) != 0; }
        }

        public bool HasDPadDownButton
        {
            get { return (buttons & Buttons.DPadDown) != 0; }
        }

        public bool HasDPadRightButton
        {
            get { return (buttons & Buttons.DPadRight) != 0; }
        }

        public bool HasAButton
        {
            get { return (buttons & Buttons.A) != 0; }
        }

        public bool HasBButton
        {
            get { return (buttons & Buttons.B) != 0; }
        }

        public bool HasXButton
        {
            get { return (buttons & Buttons.X) != 0; }
        }

        public bool HasYButton
        {
            get { return (buttons & Buttons.Y) != 0; }
        }

        public bool HasLeftStickButton
        {
            get { return (buttons & Buttons.LeftStick) != 0; }
        }

        public bool HasRightStickButton
        {
            get { return (buttons & Buttons.RightStick) != 0; }
        }

        public bool HasLeftShoulderButton
        {
            get { return (buttons & Buttons.LeftShoulder) != 0; }
        }

        public bool HasRightShoulderButton
        {
            get { return (buttons & Buttons.RightShoulder) != 0; }
        }

        public bool HasBackButton
        {
            get { return (buttons & Buttons.Back) != 0; }
        }

        public bool HasBigButton
        {
            get { return (buttons & Buttons.BigButton) != 0; }
        }

        public bool HasStartButton
        {
            get { return (buttons & Buttons.Start) != 0; }
        }

        public bool HasLeftXThumbStick
        {
            get { return false; }
        }

        public bool HasLeftYThumbStick
        {
            get { return false; }
        }

        public bool HasRightXThumbStick
        {
            get { return false; }
        }

        public bool HasRightYThumbStick
        {
            get { return false; }
        }

        public bool HasLeftTrigger
        {
            get { return false; }
        }

        public bool HasRightTrigger
        {
            get { return false; }
        }

        public bool HasLeftVibrationMotor
        {
            get { return false; }
        }

        public bool HasRightVibrationMotor
        {
            get { return false; }
        }

        public bool HasVoiceSupport
        {
            get { return false; }
        }

        public bool IsConnected
        {
            get { return is_connected; }
        }

        public static bool operator ==(GamePadCapabilities left, GamePadCapabilities right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GamePadCapabilities left, GamePadCapabilities right)
        {
            return !left.Equals(right);
        }

        public override string ToString()
        {
            return String.Format(
                "{{Type: {0}; Buttons: {1}; Connected: {2}}}",
                GamePadType, Convert.ToString((int)buttons, 2), IsConnected);
        }

        public override int GetHashCode()
        {
            return
                buttons.GetHashCode() ^
                is_connected.GetHashCode() ^
                gamepad_type.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return
                obj is GamePadCapabilities &&
                Equals((GamePadCapabilities)obj);
        }

        #endregion

        #region IEquatable<GamePadCapabilities> Members

        public bool Equals(GamePadCapabilities other)
        {
            return
                buttons == other.buttons &&
                is_connected == other.is_connected &&
                gamepad_type == other.gamepad_type;
        }

        #endregion
    }
}

