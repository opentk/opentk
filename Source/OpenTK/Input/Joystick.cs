#region License
//
// Joystick.cs
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
 
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Provides access to Joystick devices.
    /// Joystick devices provide a varying number of axes and buttons.
    /// Use <c>GetCapabilities</c> to retrieve the number of supported
    /// axes and buttons on a given device.
    /// Use <c>GetState</c> to retrieve the current state of a given device.
    /// </summary>
    /// <seealso cref="GamePad"/>
    public sealed class Joystick
    {
        static readonly IJoystickDriver2 implementation =
            Platform.Factory.Default.CreateJoystickDriver();

        private Joystick() { }

        /// <summary>
        /// Retrieves the <see cref="JoystickCapabilities"/> of the device connected
        /// at the specified index.
        /// </summary>
        /// <returns>
        /// A <see cref="JoystickCapabilities"/> structure describing
        /// the capabilities of the device at the specified index.
        /// If no device is connected at the specified index, the <c>IsConnected</c>
        /// property of the returned structure will be false.
        /// </returns>
        /// <param name="index">The zero-based index of the device to poll.</param>
        public static JoystickCapabilities GetCapabilities(int index)
        {
            return implementation.GetCapabilities(index);
        }

        /// <summary>
        /// Retrieves the <see cref="JoystickState"/> of the device connected
        /// at the specified index.
        /// </summary>
        /// <returns>A <see cref="JoystickState"/> structure describing
        /// the current state of the device at the specified index.
        /// If no device is connected at this index, the <c>IsConnected</c>
        /// property of the returned structure will be false.
        /// </returns>
        /// <param name="index">The zero-based index of the device to poll.</param>
        public static JoystickState GetState(int index)
        {
            return implementation.GetState(index);
        }

        internal static Guid GetGuid(int index)
        {
            return implementation.GetGuid(index);
        }

        //public string GetName(int index)
        //{
        //    return implementation.GetName(index);
        //}
    }
}
