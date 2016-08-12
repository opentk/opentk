#region License
//
// GamePadType.cs
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
#endregion

namespace OpenTK.Input
{
    /// <summary>
    /// Enumerates available <see cref="GamePad"/> types.
    /// </summary>
    public enum GamePadType
    {
        /// <summary>
        /// The <c>GamePad</c> is of an unknown type.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// The <c>GamePad</c> is an arcade stick.
        /// </summary>
        ArcadeStick,

        /// <summary>
        /// The <c>GamePad</c> is a dance pad.
        /// </summary>
        DancePad,

        /// <summary>
        /// The <c>GamePad</c> is a flight stick.
        /// </summary>
        FlightStick,

        /// <summary>
        /// The <c>GamePad</c> is a guitar.
        /// </summary>
        Guitar,

        /// <summary>
        /// The <c>GamePad</c> is a driving wheel.
        /// </summary>
        Wheel,

        /// <summary>
        /// The <c>GamePad</c> is an alternate guitar.
        /// </summary>
        AlternateGuitar,

        /// <summary>
        /// The <c>GamePad</c> is a big button pad.
        /// </summary>
        BigButtonPad,

        /// <summary>
        /// The <c>GamePad</c> is a drum kit.
        /// </summary>
        DrumKit,

        /// <summary>
        /// The <c>GamePad</c> is a game pad.
        /// </summary>
        GamePad,

        /// <summary>
        /// The <c>GamePad</c> is an arcade pad.
        /// </summary>
        ArcadePad,

        /// <summary>
        /// The <c>GamePad</c> is a bass guitar.
        /// </summary>
        BassGuitar,
    }
}
