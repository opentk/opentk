//
// MP3BufferFormat.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.OpenAL.Extensions.EXT.MP3Format
{
    /// <summary>
    /// Defines valid format specifiers for sound samples. This covers the additions from the multi-channel buffers
    /// extension.
    /// </summary>
    public enum MP3BufferFormat
    {
        /// <summary>
        /// MP3 encoded data.
        /// </summary>
        MP3 = 0x10020,
    }
}
