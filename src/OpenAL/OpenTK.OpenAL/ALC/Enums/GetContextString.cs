﻿//
// GetContextString.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using OpenToolkit.OpenAL.Interfaces;

namespace OpenToolkit.OpenAL
{
    /// <summary>
    /// Defines available parameters for <see cref="IContextState.GetContextProperty(OpenToolkit.OpenAL.Device*,GetContextString)" />.
    /// </summary>
    public enum GetContextString
    {
        /// <summary>
        /// A list of available context extensions separated by spaces.
        /// </summary>
        Extensions = 0x1006,

        /// <summary>
        /// Gets the name of the provided device.
        /// </summary>
        DeviceSpecifier = 0x1005,
    }
}
