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
    /// Used in GL.NV.QueryResource
    /// </summary>
    public enum NvQueryResource
    {
        /// <summary>
        /// Original was GL_QUERY_RESOURCE_TYPE_VIDMEM_ALLOC_NV = 0x9540
        /// </summary>
        QueryResourceTypeVidmemAllocNv = 0x9540,

        /// <summary>
        /// Original was GL_QUERY_RESOURCE_MEMTYPE_VIDMEM_NV = 0x9542
        /// </summary>
        QueryResourceMemtypeVidmemNv = 0x9542,

        /// <summary>
        /// Original was GL_QUERY_RESOURCE_SYS_RESERVED_NV = 0x9544
        /// </summary>
        QueryResourceSysReservedNv = 0x9544,

        /// <summary>
        /// Original was GL_QUERY_RESOURCE_TEXTURE_NV = 0x9545
        /// </summary>
        QueryResourceTextureNv = 0x9545,

        /// <summary>
        /// Original was GL_QUERY_RESOURCE_RENDERBUFFER_NV = 0x9546
        /// </summary>
        QueryResourceRenderbufferNv = 0x9546,

        /// <summary>
        /// Original was GL_QUERY_RESOURCE_BUFFEROBJECT_NV = 0x9547
        /// </summary>
        QueryResourceBufferobjectNv = 0x9547
    }
}
