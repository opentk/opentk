//
// JoystickState.cs
//
// Copyright (C) OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Windowing.Common.Input
{
    /// <summary>
    /// Encapsulates the state of a joystick device.
    /// </summary>{
    public interface IJoystickState
    {
        /// <summary>
        /// Gets the identity of the joystick this state describes.
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Gets the name of the joystick this state describes.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets a value indicating whether the joystick is active and connected.
        /// </summary>
        bool IsConnected { get; }

        /// <summary>
        /// Gets a <see cref="Hat"/> describing the state of a hat.
        /// </summary>
        /// <param name="index">The index of the hat to check.</param>
        /// <returns>A <see cref="Hat"/> describing the hat state.</returns>
        Hat GetHat(int index);

        /// <summary>
        /// Gets a <see cref="Hat"/> describing the previous state of a hat.
        /// </summary>
        /// <param name="index">The index of the hat to check.</param>
        /// <returns>A <see cref="Hat"/> describing the hat state.</returns>
        Hat GetHatPrevious(int index);

        /// <summary>
        /// Gets a <see cref="bool"/> describing the state of a button.
        /// </summary>
        /// <param name="index">The index of the button to check.</param>
        /// <returns><c>true</c> if the button is down; <c>false</c> otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool IsButtonDown(int index);

        /// <summary>
        /// Gets a <see cref="bool"/> describing whether the button was down and is now not down.
        /// </summary>
        /// <param name="index">The index of the button.</param>
        /// <returns>Returns true if the button was down, or false if the button was not down.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool WasButtonDown(int index);

        /// <summary>
        /// Gets a <see cref="float"/> between -1 and 1 describing the position of an axis.
        /// </summary>
        /// <param name="index">The index of the Axis to check.</param>
        /// <returns>A <see cref="float"/> between -1 and 1 describing the position of the axis.</returns>
        float GetAxis(int index);

        /// <summary>
        /// Gets a <see cref="float"/> between -1 and 1 describing the previous position of an axis.
        /// </summary>
        /// <param name="index">The index of the Axis to check.</param>
        /// <returns>A <see cref="float"/> between -1 and 1 describing the position of the axis.</returns>
        float GetAxisPrevious(int index);

        /// <summary>
        /// Gets an immutable snapshot of this JoystickState.
        /// </summary>
        /// <returns>Returns an immutable snapshot of this JoystickState.</returns>
        IJoystickState GetSnapshot();
    }
}
