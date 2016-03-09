// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

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
