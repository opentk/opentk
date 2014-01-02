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
    /// Provides access to GamePad devices.
    /// </summary>
    public sealed class GamePad
    {
        internal const int MaxAxisCount = 10;
        internal const int MaxDPadCount = 2;

        static readonly IGamePadDriver driver =
            Platform.Factory.Default.CreateGamePadDriver();

        private GamePad() { }

        /// <summary>
        /// Retrieves a <c>GamePadCapabilities</c> structure describing the
        /// capabilities of a gamepad device.
        /// </summary>
        /// <param name="index">The zero-based index of a gamepad device.</param>
        /// <returns>A <c>GamePadCapabilities</c> structure describing the capabilities of the gamepad device.</returns>
        public static GamePadCapabilities GetCapabilities(int index)
        {
            if (index < 0)
                throw new IndexOutOfRangeException();

            return driver.GetCapabilities(index);
        }

        /// <summary>
        /// Retrieves the <c>GamePadState</c> for the specified gamepad device.
        /// </summary>
        /// <param name="index">The zero-based index of a gamepad device.</param>
        /// <returns>A <c>GamePadState</c> structure describing the state of the gamepad device.</returns>
        public static GamePadState GetState(int index)
        {
            return driver.GetState(index);
        }
    }
}
