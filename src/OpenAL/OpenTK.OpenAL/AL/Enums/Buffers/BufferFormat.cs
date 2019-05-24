﻿//
// BufferFormat.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL
{
    /// <summary>
    /// Sound samples: Format specifier.
    /// </summary>
    public enum BufferFormat
    {
        /// <summary>
        /// 1 Channel, 8 bits per sample.
        /// </summary>
        Mono8 = 0x1100,

        /// <summary>
        /// 1 Channel, 16 bits per sample.
        /// </summary>
        Mono16 = 0x1101,

        /// <summary>
        /// 2 Channels, 8 bits per sample each.
        /// </summary>
        Stereo8 = 0x1102,

        /// <summary>
        /// 2 Channels, 16 bits per sample each.
        /// </summary>
        Stereo16 = 0x1103,
    }
}
