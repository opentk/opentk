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
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Provides access to keyboard devices. Note: this API is not implemented yet.
    /// </summary>
    public static class Keyboard
    {
        #region Fields

        static readonly IKeyboardDriver2 driver =
            Platform.Factory.Default.CreateKeyboardDriver();
        static readonly object SyncRoot = new object();

        #endregion

        #region Public Members

        /// <summary>
        /// Retrieves the combined <see cref="OpenTK.Input.KeyboardState"/> for all keyboard devices.
        /// </summary>
        /// <returns>An <see cref="OpenTK.Input.KeyboardState"/> structure containing the combined state for all keyboard devices.</returns>
        public static KeyboardState GetState()
        {
            lock (SyncRoot)
            {
                return driver.GetState();
            }
        }

        /// <summary>
        /// Retrieves the <see cref="OpenTK.Input.KeyboardState"/> for the specified keyboard device.
        /// </summary>
        /// <param name="index">The index of the keyboard device.</param>
        /// <returns>An <see cref="OpenTK.Input.KeyboardState"/> structure containing the state of the keyboard device.</returns>
        public static KeyboardState GetState(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index");

            lock (SyncRoot)
            {
                return driver.GetState(index);
            }
        }

#if false
        // Disabled until a correct, cross-platform API can be defined.

        /// <summary>
        /// Retrieves the device name for the keyboard device.
        /// </summary>
        /// <param name="index">The index of the keyboard device.</param>
        /// <returns>A <see cref="System.String"/> with the name of the specified device or <see cref="System.String.Empty"/>.</returns>
        /// <remarks>
        /// <para>If no device exists at the specified index, the return value is <see cref="System.String.Empty"/>.</para></remarks>
        public static string GetDeviceName(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index");

            lock (SyncRoot)
            {
                return driver.GetDeviceName(index);
            }
        }
#endif

         #endregion
    }
}
