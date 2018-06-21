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
    public enum ExtMemoryObjectWin32
    {
        /// <summary>
        /// Original was GL_HANDLE_TYPE_OPAQUE_WIN32_EXT = 0x9587
        /// </summary>
        HandleTypeOpaqueWin32Ext = 0x9587,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT = 0x9588
        /// </summary>
        HandleTypeOpaqueWin32KmtExt = 0x9588,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT = 0x9589
        /// </summary>
        HandleTypeD3D12TilepoolExt = 0x9589,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D12_RESOURCE_EXT = 0x958A
        /// </summary>
        HandleTypeD3D12ResourceExt = 0x958a,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D11_IMAGE_EXT = 0x958B
        /// </summary>
        HandleTypeD3D11ImageExt = 0x958b,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT = 0x958C
        /// </summary>
        HandleTypeD3D11ImageKmtExt = 0x958c,

        /// <summary>
        /// Original was GL_DEVICE_LUID_EXT = 0x9599
        /// </summary>
        DeviceLuidExt = 0x9599,

        /// <summary>
        /// Original was GL_DEVICE_NODE_MASK_EXT = 0x959A
        /// </summary>
        DeviceNodeMaskExt = 0x959a,

        /// <summary>
        /// Original was GL_LUID_SIZE_EXT = 8
        /// </summary>
        LuidSizeExt = 8
    }
}
