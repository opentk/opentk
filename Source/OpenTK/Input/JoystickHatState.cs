#region License
//
// JoystickHatState.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
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
#endregion

using System;

namespace OpenTK.Input
{
    /// <summary>
    /// Describes the state of a joystick hat.
    /// </summary>
    public struct JoystickHatState
    {
        HatPosition position;

        internal JoystickHatState(HatPosition pos)
        {
            position = pos;
        }

        /// <summary>
        /// Gets a <see cref="HatPosition"/> value indicating
        /// the position of this hat. 
        /// </summary>
        /// <value>The position.</value>
        public HatPosition Position { get { return position; } }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating
        /// whether this hat lies in the top hemicircle.
        /// </summary>
        /// <value><c>true</c> if this hat lies in the top hemicircle; otherwise, <c>false</c>.</value>
        public bool IsUp
        {
            get
            {
                return
                    Position == HatPosition.Up ||
                    Position == HatPosition.UpLeft ||
                    Position == HatPosition.UpRight;
            }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating
        /// whether this hat lies in the bottom hemicircle.
        /// </summary>
        /// <value><c>true</c> if this hat lies in the bottom hemicircle; otherwise, <c>false</c>.</value>
        public bool IsDown
        {
            get
            {
                return
                    Position == HatPosition.Down ||
                    Position == HatPosition.DownLeft ||
                    Position == HatPosition.DownRight;
            }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating
        /// whether this hat lies in the left hemicircle.
        /// </summary>
        /// <value><c>true</c> if this hat lies in the left hemicircle; otherwise, <c>false</c>.</value>
        public bool IsLeft
        {
            get
            {
                return
                    Position == HatPosition.Left ||
                    Position == HatPosition.UpLeft ||
                    Position == HatPosition.DownLeft;
            }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating
        /// whether this hat lies in the right hemicircle.
        /// </summary>
        /// <value><c>true</c> if this hat lies in the right hemicircle; otherwise, <c>false</c>.</value>
        public bool IsRight
        {
            get
            {
                return
                    Position == HatPosition.Right ||
                    Position == HatPosition.UpRight ||
                    Position == HatPosition.DownRight;
            }
        }
    }
}

