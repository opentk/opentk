//
// KeyPressEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.EventingModels
{
    /// <summary>
    /// Defines the event arguments for KeyPress events. Instances of this class are cached:
    /// KeyPressEventArgs should only be used inside the relevant event, unless manually cloned.
    /// </summary>
    public class KeyPressEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="keyChar">The ASCII character that was typed.</param>
        public KeyPressEventArgs(char keyChar)
        {
            KeyChar = keyChar;
        }

        /// <summary>
        /// Gets a <see cref="System.Char" /> that defines the ASCII character that was typed.
        /// </summary>
        public char KeyChar { get; internal set; }
    }
}
