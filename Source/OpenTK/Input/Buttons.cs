//
// GamePadButton.cs
//
// Author:
//       robert <${AuthorEmail}>
//
// Copyright (c) 2012 robert
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
using System;

namespace OpenTK.Input
{
    /// <summary>
    /// Enumerates available buttons for a <c>GamePad</c> device.
    /// </summary>
    [Flags]
    public enum Buttons
    {
        /// <summary>
        /// DPad up direction button
        /// </summary>
        DPadUp = 1 << 0,

        /// <summary>
        /// DPad down direction button
        /// </summary>
        DPadDown = 1 << 1,

        /// <summary>
        /// DPad left direction button
        /// </summary>
        DPadLeft = 1 << 2,

        /// <summary>
        /// DPad right direction button
        /// </summary>
        DPadRight = 1 << 3,

        /// <summary>
        /// Start button
        /// </summary>
        Start = 1 << 4,

        /// <summary>
        /// Back button
        /// </summary>
        Back = 1 << 5,

        /// <summary>
        /// Left stick button
        /// </summary>
        LeftStick = 1 << 6,

        /// <summary>
        /// Right stick button
        /// </summary>
        RightStick = 1 << 7,

        /// <summary>
        /// Left shoulder button
        /// </summary>
        LeftShoulder = 1 << 8,

        /// <summary>
        /// Right shoulder button
        /// </summary>
        RightShoulder = 1 << 9,

        /// <summary>
        /// Home button
        /// </summary>
        Home = 1 << 11,

        /// <summary>
        /// Home button
        /// </summary>
        BigButton = Home,

        /// <summary>
        /// A button
        /// </summary>
        A = 1 << 12,

        /// <summary>
        /// B button
        /// </summary>
        B = 1 << 13,

        /// <summary>
        /// X button
        /// </summary>
        X = 1 << 14,

        /// <summary>
        /// Y button
        /// </summary>
        Y = 1 << 15,

        /// <summary>
        /// Left thumbstick left direction button
        /// </summary>
        LeftThumbstickLeft = 1 << 21,

        /// <summary>
        /// Right trigger button
        /// </summary>
        RightTrigger = 1 << 22,

        /// <summary>
        /// Left trigger button
        /// </summary>
        LeftTrigger = 1 << 23,

        /// <summary>
        /// Right thumbstick up direction button
        /// </summary>
        RightThumbstickUp = 1 << 24,

        /// <summary>
        /// Right thumbstick down direction button
        /// </summary>
        RightThumbstickDown = 1 << 25,

        /// <summary>
        /// Right stick right direction button
        /// </summary>
        RightThumbstickRight = 1 << 26,

        /// <summary>
        /// Right stick left direction button
        /// </summary>
        RightThumbstickLeft = 1 << 27,

        /// <summary>
        /// Left stick up direction button
        /// </summary>
        LeftThumbstickUp = 1 << 28,

        /// <summary>
        /// Left stick down direction button
        /// </summary>
        LeftThumbstickDown = 1 << 29,

        /// <summary>
        /// Left stick right direction button
        /// </summary>
        LeftThumbstickRight = 1 << 30,
    }
}
