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

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum MapBufferUsageMask
    {
        /// <summary>
        /// Original was GL_MAP_READ_BIT = 0x0001
        /// </summary>
        MapReadBit = 0x0001,

        /// <summary>
        /// Original was GL_MAP_READ_BIT_EXT = 0x0001
        /// </summary>
        MapReadBitExt = 0x0001,

        /// <summary>
        /// Original was GL_MAP_WRITE_BIT = 0x0002
        /// </summary>
        MapWriteBit = 0x0002,

        /// <summary>
        /// Original was GL_MAP_WRITE_BIT_EXT = 0x0002
        /// </summary>
        MapWriteBitExt = 0x0002,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT = 0x0004
        /// </summary>
        MapInvalidateRangeBit = 0x0004,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004
        /// </summary>
        MapInvalidateRangeBitExt = 0x0004,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008
        /// </summary>
        MapInvalidateBufferBit = 0x0008,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008
        /// </summary>
        MapInvalidateBufferBitExt = 0x0008,

        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010
        /// </summary>
        MapFlushExplicitBit = 0x0010,

        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010
        /// </summary>
        MapFlushExplicitBitExt = 0x0010,

        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT = 0x0020
        /// </summary>
        MapUnsynchronizedBit = 0x0020,

        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020
        /// </summary>
        MapUnsynchronizedBitExt = 0x0020,

        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT = 0x0040
        /// </summary>
        MapPersistentBit = 0x0040,

        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT_EXT = 0x0040
        /// </summary>
        MapPersistentBitExt = 0x0040,

        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT = 0x0080
        /// </summary>
        MapCoherentBit = 0x0080,

        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT_EXT = 0x0080
        /// </summary>
        MapCoherentBitExt = 0x0080,

        /// <summary>
        /// Original was GL_DYNAMIC_STORAGE_BIT = 0x0100
        /// </summary>
        DynamicStorageBit = 0x0100,

        /// <summary>
        /// Original was GL_DYNAMIC_STORAGE_BIT_EXT = 0x0100
        /// </summary>
        DynamicStorageBitExt = 0x0100,

        /// <summary>
        /// Original was GL_CLIENT_STORAGE_BIT = 0x0200
        /// </summary>
        ClientStorageBit = 0x0200,

        /// <summary>
        /// Original was GL_CLIENT_STORAGE_BIT_EXT = 0x0200
        /// </summary>
        ClientStorageBitExt = 0x0200,

        /// <summary>
        /// Original was GL_SPARSE_STORAGE_BIT_ARB = 0x0400
        /// </summary>
        SparseStorageBitArb = 0x0400,

        /// <summary>
        /// Original was GL_LGPU_SEPARATE_STORAGE_BIT_NVX = 0x0800
        /// </summary>
        LgpuSeparateStorageBitNvx = 0x0800,

        /// <summary>
        /// Original was GL_PER_GPU_STORAGE_BIT_NV = 0x0800
        /// </summary>
        PerGpuStorageBitNv = 0x0800
    }
}
