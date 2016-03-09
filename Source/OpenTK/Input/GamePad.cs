// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;

namespace OpenTK.Input
{
    /// <summary>
    /// Provides access to GamePad devices.
    /// A GamePad device offers a well-defined layout with
    /// one direction-pad, two thumbsticks, two triggers,
    /// four main buttons (A, B, X, Y) and up to seven
    /// auxilliary buttons.
    /// Use <c>GetCapabilities</c> to retrieve the exact
    /// capabilities of a given device.
    /// Use <c>GetState</c> to retrieve the current state
    /// of a given device.
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

        /// <summary>
        /// Sets the vibration intensity for the left and right motors of this <see cref="GamePad"/>
        /// </summary>
        /// <returns>
        /// <c>true</c>, if vibration was set, <c>false</c> otherwise. This method can return false
        /// if the <c>GamePad</c> hardware does not support vibration or if it cannot respond to
        /// the command for any reason. Do not loop until this becomes true, but rather ignore
        /// a return value of false.
        /// </returns>
        /// <param name="index">A zero-based device index for the <c>GamePad</c> device to affect</param>
        /// <param name="left">The vibration intensity for the left motor, between 0.0 and 1.0.</param>
        /// <param name="right">The vibration intensity for the right motor, between 0.0 and 1.0.</param>
        public static bool SetVibration(int index, float left, float right)
        {
            return driver.SetVibration(index, left, right);
        }

        /// <summary>
        /// Gets the name of this <see cref="GamePad"/>
        /// </summary>
        /// <returns>
        /// Returns the name of the gamepad if the gamepad is connected.
        /// Otherwise returns an empty string.
        /// </returns>
        /// <param name="index">A zero-based device index for the <c>GamePad</c> device to affect</param>
        public static string GetName(int index)
        {
            return driver.GetName(index);
        }
    }
}
