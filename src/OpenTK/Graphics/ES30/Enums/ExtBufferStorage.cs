//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;

namespace OpenTK.Graphics.ES30
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtBufferStorage
    {
        /// <summary>
        /// Original was GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT = 0x00004000
        /// </summary>
        ClientMappedBufferBarrierBitExt = ((int)0x00004000),

        /// <summary>
        /// Original was GL_MAP_READ_BIT = 0x0001
        /// </summary>
        MapReadBit = 0x0001,

        /// <summary>
        /// Original was GL_MAP_WRITE_BIT = 0x0002
        /// </summary>
        MapWriteBit = 0x0002,

        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT_EXT = 0x0040
        /// </summary>
        MapPersistentBitExt = 0x0040,

        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT_EXT = 0x0080
        /// </summary>
        MapCoherentBitExt = 0x0080,

        /// <summary>
        /// Original was GL_DYNAMIC_STORAGE_BIT_EXT = 0x0100
        /// </summary>
        DynamicStorageBitExt = 0x0100,

        /// <summary>
        /// Original was GL_CLIENT_STORAGE_BIT_EXT = 0x0200
        /// </summary>
        ClientStorageBitExt = 0x0200,

        /// <summary>
        /// Original was GL_BUFFER_IMMUTABLE_STORAGE_EXT = 0x821F
        /// </summary>
        BufferImmutableStorageExt = 0x821f,

        /// <summary>
        /// Original was GL_BUFFER_STORAGE_FLAGS_EXT = 0x8220
        /// </summary>
        BufferStorageFlagsExt = 0x8220
    }
}
