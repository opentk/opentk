//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2018 the Open Toolkit library.
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

using System;

namespace OpenToolkit.Input
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
        /// Retrieves the combined <see cref="OpenToolkit.Input.KeyboardState" /> for all keyboard devices.
        /// This method is equivalent to <see cref="OpenToolkit.Input.Keyboard.GetState()" />.
        /// </summary>
        /// <returns>An <see cref="OpenToolkit.Input.KeyboardState" /> structure containing the combined state for all keyboard devices.</returns>
        /// <seealso cref="OpenToolkit.Input.Keyboard.GetState()" />
        public KeyboardState GetState()
        {
            return Keyboard.GetState();
        }

        /// <summary>
        /// Retrieves the <see cref="OpenToolkit.Input.KeyboardState" /> for the specified keyboard device.
        /// This method is equivalent to <see cref="OpenToolkit.Input.Keyboard.GetState(int)" />.
        /// </summary>
        /// <param name="index">The index of the keyboard device.</param>
        /// <returns>An <see cref="OpenToolkit.Input.KeyboardState" /> structure containing the combined state for all keyboard devices.</returns>
        /// <seealso cref="OpenToolkit.Input.Keyboard.GetState(int)" />
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
