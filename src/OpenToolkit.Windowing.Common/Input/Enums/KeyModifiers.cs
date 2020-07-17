//
// KeyModifiers.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.Common.Input
{
    /// <summary>
    /// Enumerates modifier keys.
    /// </summary>
    [Flags]
    public enum KeyModifiers : byte
    {
        /// <summary>
        /// The alt key modifier (option on Mac).
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
        /// The command key modifier on a Mac
        /// </summary>
        Command = 1 << 3,

        /// <summary>
        /// If the caps lock is enabled.
        /// </summary>
        CapsLock = 1 << 4,

        /// <summary>
        /// If the num lock is enabled.
        /// </summary>
        NumLock = 1 << 5,
    }
}
