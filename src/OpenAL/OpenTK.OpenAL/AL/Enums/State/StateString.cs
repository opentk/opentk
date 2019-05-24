﻿//
// StateString.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL
{
    /// <summary>
    /// A list of valid string AL.Get() parameters.
    /// </summary>
    public enum StateString
    {
        /// <summary>
        /// Gets the Vendor name.
        /// </summary>
        Vendor = 0xB001,

        /// <summary>
        /// Gets the driver version.
        /// </summary>
        Version = 0xB002,

        /// <summary>
        /// Gets the renderer mode.
        /// </summary>
        Renderer = 0xB003,

        /// <summary>
        /// Gets a list of all available Extensions, separated with spaces.
        /// </summary>
        Extensions = 0xB004,
    }
}
