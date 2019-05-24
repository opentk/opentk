﻿//
// SourceType.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL
{
    /// <summary>
    /// Source type information,  can be retrieved by AL.Source() with SourceInteger.SourceType.
    /// </summary>
    public enum SourceType
    {
        /// <summary>
        /// Source is Static if a Buffer has been attached using AL.Source with the parameter Sourcei.Buffer.
        /// </summary>
        Static = 0x1028,

        /// <summary>
        /// Source is Streaming if one or more Buffers have been attached using AL.SourceQueueBuffers.
        /// </summary>
        Streaming = 0x1029,

        /// <summary>
        /// Source is undetermined when it has a null Buffer attached.
        /// </summary>
        Undetermined = 0x1030,
    }
}
