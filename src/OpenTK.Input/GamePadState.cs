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

using System;

namespace OpenTK.Input
{
    /// <summary>
    /// Describes the current state of a <see cref="GamePad" /> device.
    /// </summary>
    public struct GamePadState : IEquatable<GamePadState>
    {
        private const float RangeMultiplier = 1.0f / (short.MaxValue + 1);

        private Buttons buttons;
        private short left_stick_x;
        private short left_stick_y;
        private short right_stick_x;
        private short right_stick_y;
        private byte left_trigger;
        private byte right_trigger;

        /// <summary>
        /// Gets a <see cref="GamePadThumbSticks" /> structure describing the
        /// state of the <c>GamePad</c> thumb sticks.
        /// </summary>
        public GamePadThumbSticks ThumbSticks =>
            new GamePadThumbSticks(left_stick_x, left_stick_y, right_stick_x, right_stick_y);

        /// <summary>
        /// Gets a <see cref="GamePadButtons" /> structure describing the
        /// state of the <c>GamePad</c> buttons.
        /// </summary>
        public GamePadButtons Buttons => new GamePadButtons(buttons);

        /// <summary>
        /// Gets a <see cref="GamePadDPad" /> structure describing the
        /// state of the <c>GamePad</c> directional pad.
        /// </summary>
        public GamePadDPad DPad => new GamePadDPad(buttons);

        /// <summary>
        /// Gets a <see cref="GamePadTriggers" /> structure describing the
        /// state of the <c>GamePad</c> triggers.
        /// </summary>
        public GamePadTriggers Triggers => new GamePadTriggers(left_trigger, right_trigger);

        /// <summary>
        /// Gets a value indicating whether this <c>GamePad</c> instance is connected.
        /// </summary>
        /// <value><c>true</c> if this instance is connected; otherwise, <c>false</c>.</value>
        public bool IsConnected { get; private set; }

        /// <summary>
        /// Gets the packet number for this <c>GamePadState</c> instance.
        /// Use the packet number to determine whether the state of a
        ///  <c>GamePad</c> device has changed.
        /// </summary>
        public int PacketNumber { get; private set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents the current <see cref="OpenTK.Input.GamePadState" />.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents the current <see cref="OpenTK.Input.GamePadState" />.</returns>
        public override string ToString()
        {
            return
                $"{{Sticks: {ThumbSticks}; Triggers: {Triggers}; Buttons: {Buttons}; DPad: {DPad}; IsConnected: {IsConnected}}}";
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="OpenTK.Input.GamePadState" /> object.
        /// </summary>
        /// <returns>
        /// A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.
        /// </returns>
        public override int GetHashCode()
        {
            return
                ThumbSticks.GetHashCode() ^ Buttons.GetHashCode() ^
                DPad.GetHashCode() ^ IsConnected.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to the current
        ///  <see cref="OpenTK.Input.GamePadState" />.
        /// </summary>
        /// <param name="obj">
        /// The <see cref="System.Object" /> to compare with the current <see cref="OpenTK.Input.GamePadState" />
        /// .
        /// </param>
        /// <returns>
        ///  <c>true</c> if the specified <see cref="System.Object" /> is equal to the current
        ///  <see cref="OpenTK.Input.GamePadState" />; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return
                obj is GamePadState &&
                Equals((GamePadState)obj);
        }

        /// <summary>
        /// Determines whether the specified <see cref="OpenTK.Input.GamePadState" /> is equal to the current
        ///  <see cref="OpenTK.Input.GamePadState" />.
        /// </summary>
        /// <param name="other">
        /// The <see cref="OpenTK.Input.GamePadState" /> to compare with the current
        ///  <see cref="OpenTK.Input.GamePadState" />.
        /// </param>
        /// <returns>
        ///  <c>true</c> if the specified <see cref="OpenTK.Input.GamePadState" /> is equal to the current
        ///  <see cref="OpenTK.Input.GamePadState" />; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(GamePadState other)
        {
            return
                ThumbSticks == other.ThumbSticks &&
                Buttons == other.Buttons &&
                DPad == other.DPad &&
                IsConnected == other.IsConnected;
        }

        internal void SetAxis(GamePadAxes axis, short value)
        {
            if ((axis & GamePadAxes.LeftX) != 0)
            {
                left_stick_x = value;
            }

            if ((axis & GamePadAxes.LeftY) != 0)
            {
                left_stick_y = (short)~value;
            }

            if ((axis & GamePadAxes.RightX) != 0)
            {
                right_stick_x = value;
            }

            if ((axis & GamePadAxes.RightY) != 0)
            {
                right_stick_y = (short)~value;
            }

            if ((axis & GamePadAxes.LeftTrigger) != 0)
            {
                // Adjust from [-32768, 32767] to [0, 255]
                left_trigger = (byte)((value - short.MinValue) >> 8);
            }

            if ((axis & GamePadAxes.RightTrigger) != 0)
            {
                // Adjust from [-32768, 32767] to [0, 255]
                right_trigger = (byte)((value - short.MinValue) >> 8);
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
            IsConnected = connected;
        }

        internal void SetTriggers(byte left, byte right)
        {
            left_trigger = left;
            right_trigger = right;
        }

        internal void SetPacketNumber(int number)
        {
            PacketNumber = number;
        }

        private bool IsAxisValid(GamePadAxes axis)
        {
            var index = (int)axis;
            return index >= 0 && index < GamePad.MaxAxisCount;
        }

        private bool IsDPadValid(int index)
        {
            return index >= 0 && index < GamePad.MaxDPadCount;
        }
    }
}
