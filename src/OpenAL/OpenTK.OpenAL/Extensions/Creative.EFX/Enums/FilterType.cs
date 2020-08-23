﻿//
// FilterType.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Audio.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// Filter type definitions to be used with EfxFilteri.FilterType.
    /// </summary>
    public enum FilterType
    {
        /// <summary>
        /// No Filter, disable. This Filter type is used when a Filter object is initially created.
        /// </summary>
        Null = 0x0000,

        /// <summary>
        /// A low-pass filter is used to remove high frequency content from a signal.
        /// </summary>
        Lowpass = 0x0001,

        /// <summary>
        /// Currently not implemented. A high-pass filter is used to remove low frequency content from a signal.
        /// </summary>
        Highpass = 0x0002,

        /// <summary>
        /// Currently not implemented. A band-pass filter is used to remove high and low frequency content from a signal.
        /// </summary>
        Bandpass = 0x0003,
    }
}
