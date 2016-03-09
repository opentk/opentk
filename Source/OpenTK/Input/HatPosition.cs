// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;

namespace OpenTK.Input
{
    /// <summary>
    /// Enumerates discrete positions for a joystick hat.
    /// </summary>
    public enum HatPosition : byte
    {
        /// <summary>
        /// The hat is in its centered (neutral) position
        /// </summary>
        Centered = 0,
        /// <summary>
        /// The hat is in its top position.
        /// </summary>
        Up,
        /// <summary>
        /// The hat is in its top-right position.
        /// </summary>
        UpRight,
        /// <summary>
        /// The hat is in its right position.
        /// </summary>
        Right,
        /// <summary>
        /// The hat is in its bottom-right position.
        /// </summary>
        DownRight,
        /// <summary>
        /// The hat is in its bottom position.
        /// </summary>
        Down,
        /// <summary>
        /// The hat is in its bottom-left position.
        /// </summary>
        DownLeft,
        /// <summary>
        /// The hat is in its left position.
        /// </summary>
        Left,
        /// <summary>
        /// The hat is in its top-left position.
        /// </summary>
        UpLeft,
    }
}

