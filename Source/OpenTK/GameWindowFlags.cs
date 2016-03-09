// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;

namespace OpenTK
{
    /// <summary>
    /// Defines bitwise combianations of GameWindow construction options.
    /// </summary>
    [Flags]
    public enum GameWindowFlags
    {
        /// <summary>
        /// Indicates default construction options.
        /// </summary>
        Default = 0,
        
        /// <summary>
        /// Indicates that the GameWindow should cover the whole screen.
        /// </summary>
        Fullscreen = 1,

        /// <summary>
        /// Indicates that the GameWindow should be a fixed window.
        /// </summary>
        FixedWindow = 2,
    }
}