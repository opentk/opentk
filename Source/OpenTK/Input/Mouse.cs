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
    /// Provides access to mouse devices. Note: this API is not implemented yet.
    /// </summary>
    public static class Mouse
    {
        #region Fields

        static readonly IMouseDriver2 driver =
            Platform.Factory.Default.CreateMouseDriver();
        static readonly object SyncRoot = new object();

        #endregion

        #region Public Members

        /// <summary>
        /// Retrieves the combined <see cref="OpenTK.Input.MouseState"/> for all specified mouse devices.
        /// </summary>
        /// <returns>A <see cref="OpenTK.Input.MouseState"/> structure containing the combined state of all mouse devices.</returns>
        public static MouseState GetState()
        {
            lock (SyncRoot)
            {
                return driver.GetState();
            }
        }

        /// <summary>
        /// Retrieves the <see cref="OpenTK.Input.MouseState"/> for the specified mouse device.
        /// </summary>
        /// <param name="index">The index of the mouse device.</param>
        /// <returns>A <see cref="OpenTK.Input.MouseState"/> structure containing the state for the specified mouse device.</returns>
        public static MouseState GetState(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index");

            lock (SyncRoot)
            {
                return driver.GetState(index);
            }
        }

        /// <summary>
        ///Moves the mouse cursor to the specified screen position.
        /// </summary>
        /// <param name="x">
        /// A <see cref="System.Double"/> that represents the absolute x position of the cursor in screen coordinates.
        /// </param>
        /// <param name="y">
        /// A <see cref="System.Double"/> that represents the absolute y position of the cursor in screen coordinates.
        /// </param>
        public static void SetPosition(double x, double y)
        {
            lock (SyncRoot)
            {
                driver.SetPosition(x, y);
            }
        }

        #endregion
    }
}
