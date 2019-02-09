//
// KeyboardEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using OpenToolkit.Windowing.Common.Input;
using OpenToolkit.Windowing.Common.Input.Enums;
using System;

namespace OpenToolkit.Windowing.EventingModels
{
    /// <summary>
    /// Defines the event data for <see cref="KeyboardDevice" /> events.
    /// </summary>
    /// <remarks>
    ///  <para>
    /// Do not cache instances of this type outside their event handler.
    /// If necessary, you can clone a KeyboardEventArgs instance using the
    ///  <see cref="KeyboardKeyEventArgs(KeyboardKeyEventArgs)" /> constructor.
    ///  </para>
    /// </remarks>
    public class KeyboardKeyEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new KeyboardEventArgs instance.
        /// </summary>
        public KeyboardKeyEventArgs()
        {
        }

        /// <summary>
        /// Constructs a new KeyboardEventArgs instance.
        /// </summary>
        /// <param name="args">An existing KeyboardEventArgs instance to clone.</param>
        public KeyboardKeyEventArgs(KeyboardKeyEventArgs args)
        {
            Key = args.Key;
        }

        /// <summary>
        /// Gets the <see cref="Key" /> that generated this event.
        /// </summary>
        public Key Key { get; internal set; }

        /// <summary>
        /// Gets the scancode which generated this event.
        /// </summary>
        public uint ScanCode => (uint)Key;

        /// <summary>
        /// Gets a value indicating whether <see cref="OpenToolkit.Windowing.Common.Input.Enums.KeyModifiers.Alt" /> is pressed.
        /// </summary>
        /// <value><c>true</c> if pressed; otherwise, <c>false</c>.</value>
        public bool Alt => Keyboard[Key.AltLeft] || Keyboard[Key.AltRight];

        /// <summary>
        /// Gets a value indicating whether <see cref="OpenToolkit.Windowing.Common.Input.Enums.KeyModifiers.Control" /> is pressed.
        /// </summary>
        /// <value><c>true</c> if pressed; otherwise, <c>false</c>.</value>
        public bool Control => Keyboard[Key.ControlLeft] || Keyboard[Key.ControlRight];

        /// <summary>
        /// Gets a value indicating whether <see cref="OpenToolkit.Windowing.Common.Input.Enums.KeyModifiers.Shift" /> is pressed.
        /// </summary>
        /// <value><c>true</c> if pressed; otherwise, <c>false</c>.</value>
        public bool Shift => Keyboard[Key.ShiftLeft] || Keyboard[Key.ShiftRight];

        /// <summary>
        /// Gets a bitwise combination representing the <see cref="OpenToolkit.Windowing.Common.Input.Enums.KeyModifiers" />
        /// that are currently pressed.
        /// </summary>
        /// <value>The modifiers.</value>
        public KeyModifiers Modifiers
        {
            get
            {
                KeyModifiers mods = 0;
                mods |= Alt ? KeyModifiers.Alt : 0;
                mods |= Control ? KeyModifiers.Control : 0;
                mods |= Shift ? KeyModifiers.Shift : 0;
                return mods;
            }
        }

        /// <summary>
        /// Gets the current <see cref="OpenToolkit.Windowing.Common.Input.KeyboardState" />.
        /// </summary>
        /// <value>The keyboard.</value>
        public KeyboardState Keyboard { get; internal set; }

        /// <summary>
        /// Gets a <see cref="System.Boolean" /> indicating whether
        /// this key event is a repeat.
        /// </summary>
        /// <value>
        /// true, if this event was caused by the user holding down
        /// a key; false, if this was caused by the user pressing a
        /// key for the first time.
        /// </value>
        public bool IsRepeat { get; internal set; }
    }
}
