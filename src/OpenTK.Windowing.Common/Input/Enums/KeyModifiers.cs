//
// KeyModifiers.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenTK.Windowing.Common.Input
{
    /// <summary>
    /// Enumerates modifier keys.
    /// </summary>
    [Flags]
    public enum KeyModifiers : byte
    {
        /// <summary>
        /// On Windows & Linux: The Alt Key modifier.
        /// On Mac: The Option Key modifier.
        /// </summary>
        Alt = 1 << 0,

        /// <summary>
        /// The control key modifier.
        /// </summary>
        Control = 1 << 1,

        /// <summary>
        /// The shift key modifier.
        /// </summary>
        Shift = 1 << 2,

        /// <summary>
        /// On Windows: The Windows Key modifier.
        /// On Linux: The Meta or Super Key modifier.
        /// On Mac: The Command Key modifier.
        /// </summary>
        Command = 1 << 3,

        /// <summary>
        /// The CapsLock Key state.
        /// </summary>
        CapsLock = 1 << 4,

        /// <summary>
        /// The NumLock Key state.
        /// </summary>
        NumLock = 1 << 5,
    }
}
