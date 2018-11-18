﻿/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;

namespace OpenTK.Input
{
    /// <summary>
    /// Represents a keyboard device and provides methods to query its status.
    /// </summary>
    public sealed class KeyboardDevice : IInputDevice
    {
        //private IKeyboard keyboard;

        private KeyboardState state;

        internal KeyboardDevice()
        {
        }

        /// <summary>
        /// Gets a value indicating the status of the specified Key.
        /// </summary>
        /// <param name="key">The Key to check.</param>
        /// <returns>True if the Key is pressed, false otherwise.</returns>
        public bool this[Key key] => state[key];

        /// <summary>
        /// Gets a value indicating the status of the specified Key.
        /// </summary>
        /// <param name="scancode">The scancode to check.</param>
        /// <returns>True if the scancode is pressed, false otherwise.</returns>
        public bool this[uint scancode] => scancode < (uint)Key.LastKey && state[(Key)scancode];

        /// <summary>
        /// Gets an integer representing the number of keys on this KeyboardDevice.
        /// </summary>
        public int NumberOfKeys { get; internal set; }

        /// <summary>
        /// Gets an integer representing the number of function keys (F-keys) on this KeyboardDevice.
        /// </summary>
        public int NumberOfFunctionKeys { get; internal set; }

        /// <summary>
        /// Gets a value indicating the number of led indicators on this KeyboardDevice.
        /// </summary>
        public int NumberOfLeds { get; internal set; }

        /// <summary>
        /// Gets an IntPtr representing a device dependent ID.
        /// </summary>
        public IntPtr DeviceID { get; internal set; }

        /// <summary>
        /// Gets or sets a System.Boolean indicating key repeat status.
        /// </summary>
        /// <remarks>
        /// If KeyRepeat is true, multiple KeyDown events will be generated while a key is being held.
        /// Otherwise only one KeyDown event will be reported.
        ///  <para>
        /// The rate of the generated KeyDown events is controlled by the Operating System. Usually,
        /// one KeyDown event will be reported, followed by a small (250-1000ms) pause and several
        /// more KeyDown events (6-30 events per second).
        ///  </para>
        ///  <para>
        /// Set to true to handle text input (where keyboard repeat is desirable), but set to false
        /// for game input.
        ///  </para>
        /// </remarks>
        public bool KeyRepeat { get; set; }

        /// <summary>
        /// Gets a <see cref="System.String" /> which describes this instance.
        /// </summary>
        public string Description { get; internal set; }

        /// <summary>
        /// Gets the <see cref="InputDeviceType" /> for this instance.
        /// </summary>
        public InputDeviceType DeviceType => InputDeviceType.Keyboard;

        /// <summary>
        /// Occurs when a key is pressed.
        /// </summary>
        public event EventHandler<KeyboardKeyEventArgs> KeyDown = delegate { };

        /// <summary>
        /// Occurs when a key is released.
        /// </summary>
        public event EventHandler<KeyboardKeyEventArgs> KeyUp = delegate { };

        /// <summary>
        /// Retrieves the combined <see cref="OpenTK.Input.KeyboardState" /> for all keyboard devices.
        /// This method is equivalent to <see cref="OpenTK.Input.Keyboard.GetState()" />.
        /// </summary>
        /// <returns>An <see cref="OpenTK.Input.KeyboardState" /> structure containing the combined state for all keyboard devices.</returns>
        /// <seealso cref="OpenTK.Input.Keyboard.GetState()" />
        public KeyboardState GetState()
        {
            return Keyboard.GetState();
        }

        /// <summary>
        /// Retrieves the <see cref="OpenTK.Input.KeyboardState" /> for the specified keyboard device.
        /// This method is equivalent to <see cref="OpenTK.Input.Keyboard.GetState(int)" />.
        /// </summary>
        /// <param name="index">The index of the keyboard device.</param>
        /// <returns>An <see cref="OpenTK.Input.KeyboardState" /> structure containing the combined state for all keyboard devices.</returns>
        /// <seealso cref="OpenTK.Input.Keyboard.GetState(int)" />
        public KeyboardState GetState(int index)
        {
            return Keyboard.GetState(index);
        }

        /// <summary>
        /// Returns the hash code for this KeyboardDevice.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return NumberOfKeys ^ NumberOfFunctionKeys ^ NumberOfLeds ^ DeviceID.GetHashCode() ^
                   Description.GetHashCode();
        }

        /// <summary>
        /// Returns a System.String representing this KeyboardDevice.
        /// </summary>
        /// <returns>A System.String representing this KeyboardDevice.</returns>
        public override string ToString()
        {
            //return base.ToString();
            return
                $"ID: {DeviceID} ({Description}). Keys: {NumberOfKeys}, Function keys: {NumberOfFunctionKeys}, Leds: {NumberOfLeds}";
        }

        internal void HandleKeyDown(object sender, KeyboardKeyEventArgs e)
        {
            state = e.Keyboard;
            // KeyRepeat IsRepeat KeyDown
            // False     False    True
            // False     True     False
            // True      False    True
            // True      True     True
            if (KeyRepeat || !e.IsRepeat)
            {
                KeyDown(this, e);
            }
        }

        internal void HandleKeyUp(object sender, KeyboardKeyEventArgs e)
        {
            state = e.Keyboard;
            KeyUp(this, e);
        }
    }
}
