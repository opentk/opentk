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

// ReSharper disable InconsistentNaming
#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum MapBufferUsageMask
    {
        /// <summary>
        /// Original was GL_MAP_READ_BIT = 0x1
        /// </summary>
        MapReadBit = 0x1,

        /// <summary>
        /// Original was GL_MAP_READ_BIT_EXT = 0x1
        /// </summary>
        MapReadBitExt = 0x1,

        /// <summary>
        /// Original was GL_MAP_WRITE_BIT = 0x2
        /// </summary>
        MapWriteBit = 0x2,

        /// <summary>
        /// Original was GL_MAP_WRITE_BIT_EXT = 0x2
        /// </summary>
        MapWriteBitExt = 0x2,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT = 0x4
        /// </summary>
        MapInvalidateRangeBit = 0x4,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT_EXT = 0x4
        /// </summary>
        MapInvalidateRangeBitExt = 0x4,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT = 0x8
        /// </summary>
        MapInvalidateBufferBit = 0x8,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x8
        /// </summary>
        MapInvalidateBufferBitExt = 0x8,

        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT = 0x10
        /// </summary>
        MapFlushExplicitBit = 0x10,

        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT_EXT = 0x10
        /// </summary>
        MapFlushExplicitBitExt = 0x10,

        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT = 0x20
        /// </summary>
        MapUnsynchronizedBit = 0x20,

        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x20
        /// </summary>
        MapUnsynchronizedBitExt = 0x20,

        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT = 0x40
        /// </summary>
        MapPersistentBit = 0x40,

        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT_EXT = 0x40
        /// </summary>
        MapPersistentBitExt = 0x40,

        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT = 0x80
        /// </summary>
        MapCoherentBit = 0x80,

        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT_EXT = 0x80
        /// </summary>
        MapCoherentBitExt = 0x80,

        /// <summary>
        /// Original was GL_DYNAMIC_STORAGE_BIT = 0x100
        /// </summary>
        DynamicStorageBit = 0x100,

        /// <summary>
        /// Original was GL_DYNAMIC_STORAGE_BIT_EXT = 0x100
        /// </summary>
        DynamicStorageBitExt = 0x100,

        /// <summary>
        /// Original was GL_CLIENT_STORAGE_BIT = 0x200
        /// </summary>
        ClientStorageBit = 0x200,

        /// <summary>
        /// Original was GL_CLIENT_STORAGE_BIT_EXT = 0x200
        /// </summary>
        ClientStorageBitExt = 0x200,

        /// <summary>
        /// Original was GL_SPARSE_STORAGE_BIT_ARB = 0x400
        /// </summary>
        SparseStorageBitArb = 0x400,

        /// <summary>
        /// Original was GL_LGPU_SEPARATE_STORAGE_BIT_NVX = 0x800
        /// </summary>
        LgpuSeparateStorageBitNvx = 0x800,

        /// <summary>
        /// Original was GL_PER_GPU_STORAGE_BIT_NV = 0x800
        /// </summary>
        PerGpuStorageBitNV = 0x800
    }
}
