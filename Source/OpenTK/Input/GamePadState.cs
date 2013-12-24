 #region License
 //
 // The Open Toolkit Library License
 //
 // Copyright (c) 2006 - 2009 the Open Toolkit library.
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

namespace OpenTK.Input
{
    /// <summary>
    /// Encapsulates the state of a GamePad device.
    /// </summary>
    public struct GamePadState : IEquatable<GamePadState>
    {
        const float RangeMultiplier = 1.0f / (short.MaxValue + 1);

        Buttons buttons;
        short left_stick_x;
        short left_stick_y;
        short right_stick_x;
        short right_stick_y;
        byte left_trigger;
        byte right_trigger;
        bool is_connected;

        #region Public Members

        public GamePadThumbSticks ThumbSticks
        {
            get { return new GamePadThumbSticks(left_stick_x, left_stick_y, right_stick_x, right_stick_y); }
        }

        public GamePadButtons Buttons
        {
            get { return new GamePadButtons(buttons); }
        }

        public GamePadDPad DPad
        {
            get { return new GamePadDPad(buttons); }
        }

        public GamePadTriggers Triggers
        {
            get { return new GamePadTriggers(left_trigger, right_trigger); }
        }

        public bool IsConnected
        {
            get { return is_connected; }
        }

        public override string ToString()
        {
            return String.Format(
                "{{Sticks: {0}; Buttons: {1}; DPad: {2}; IsConnected: {3}",
                ThumbSticks, Buttons, DPad, IsConnected);
        }

        public override int GetHashCode()
        {
            return
                ThumbSticks.GetHashCode() ^ Buttons.GetHashCode() ^
                DPad.GetHashCode() ^ IsConnected.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return
                obj is GamePadState &&
                Equals((GamePadState)obj);
        }

        #endregion

        #region IEquatable<GamePadState> Members
        public bool Equals(GamePadState other)
        {
            return
                ThumbSticks == other.ThumbSticks &&
                Buttons == other.Buttons &&
                DPad == other.DPad &&
                IsConnected == other.IsConnected;
        }

        #endregion

        #region Internal Members

        internal void SetAxis(GamePadAxes axis, short value)
        {
            switch (axis)
            {
                case GamePadAxes.LeftX:
                    left_stick_x = value;
                    break;

                case GamePadAxes.LeftY:
                    left_stick_y = value;
                    break;

                case GamePadAxes.RightX:
                    right_stick_x = value;
                    break;

                case GamePadAxes.RightY:
                    right_stick_y = value;
                    break;

                default:
                    throw new ArgumentOutOfRangeException("axis");
            }
        }

        internal void SetButton(Buttons button, bool pressed)
        {
            if (pressed)
            {
                buttons |= button;
            }
            else
            {
                buttons &= ~button;
            }
        }

        internal void SetConnected(bool connected)
        {
            is_connected = connected;
        }

        internal void SetTriggers(byte left, byte right)
        {
            left_trigger = left;
            right_trigger = right;
        }

        #endregion

        #region Private Members

        bool IsAxisValid(GamePadAxes axis)
        {
            int index = (int)axis;
            return index >= 0 && index < GamePad.MaxAxisCount;
        }

        bool IsDPadValid(int index)
        {
            return index >= 0 && index < GamePad.MaxDPadCount;
        }

        #endregion
    }
}
