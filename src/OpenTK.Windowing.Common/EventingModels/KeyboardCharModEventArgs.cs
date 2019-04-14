//
// KeyboardCharModEventArgs.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.Windowing.Common;
using OpenToolkit.Windowing.Common.Input;

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the event data for the <see cref="IWindowEvents.KeyboardCharMod"/> event.
    /// </summary>
    public class KeyboardCharModEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyboardCharModEventArgs"/> class.
        /// </summary>
        public KeyboardCharModEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyboardCharModEventArgs"/> class.
        /// </summary>
        /// <param name="codepoint">The Unicode code point of the character.</param>
        /// <param name="mods">The <see cref="KeyModifiers"/> which where held down.</param>
        public KeyboardCharModEventArgs(uint codepoint, KeyModifiers mods)
        {
            this.Codepoint = codepoint;
            this.Mods = mods;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyboardCharModEventArgs"/> class.
        /// </summary>
        /// <param name="other">The <see cref="KeyboardCharModEventArgs" /> instance to clone.</param>
        public KeyboardCharModEventArgs(KeyboardCharModEventArgs other)
        {
            this.Codepoint = other.Codepoint;
            this.Mods = other.Mods;
        }

        /// <summary>
        /// Gets the Unicode code point of the character which triggered this event.
        /// </summary>
        public uint Codepoint { get; }

        /// <summary>
        /// Gets the <see cref="KeyModifiers"/> which where held down.
        /// </summary>
        public KeyModifiers Mods { get; }
    }
}
