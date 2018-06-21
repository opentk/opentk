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

namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// Used in GL.Ext.GetUnsignedByte, GL.Ext.TexStorageMem1D and 9 other functions
    /// </summary>
    public enum ExtMemoryObject
    {
        /// <summary>
        /// Original was GL_TEXTURE_TILING_EXT = 0x9580
        /// </summary>
        TextureTilingExt = 0x9580,

        /// <summary>
        /// Original was GL_DEDICATED_MEMORY_OBJECT_EXT = 0x9581
        /// </summary>
        DedicatedMemoryObjectExt = 0x9581,

        /// <summary>
        /// Original was GL_NUM_TILING_TYPES_EXT = 0x9582
        /// </summary>
        NumTilingTypesExt = 0x9582,

        /// <summary>
        /// Original was GL_TILING_TYPES_EXT = 0x9583
        /// </summary>
        TilingTypesExt = 0x9583,

        /// <summary>
        /// Original was GL_OPTIMAL_TILING_EXT = 0x9584
        /// </summary>
        OptimalTilingExt = 0x9584,

        /// <summary>
        /// Original was GL_LINEAR_TILING_EXT = 0x9585
        /// </summary>
        LinearTilingExt = 0x9585,

        /// <summary>
        /// Original was GL_NUM_DEVICE_UUIDS_EXT = 0x9596
        /// </summary>
        NumDeviceUuidsExt = 0x9596,

        /// <summary>
        /// Original was GL_DEVICE_UUID_EXT = 0x9597
        /// </summary>
        DeviceUuidExt = 0x9597,

        /// <summary>
        /// Original was GL_DRIVER_UUID_EXT = 0x9598
        /// </summary>
        DriverUuidExt = 0x9598,

        /// <summary>
        /// Original was GL_PROTECTED_MEMORY_OBJECT_EXT = 0x959B
        /// </summary>
        ProtectedMemoryObjectExt = 0x959b,

        /// <summary>
        /// Original was GL_UUID_SIZE_EXT = 16
        /// </summary>
        UuidSizeExt = 16
    }
}
