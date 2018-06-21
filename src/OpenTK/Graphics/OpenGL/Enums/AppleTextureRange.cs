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
    /// Used in GL.Apple.GetTexParameterPointer, GL.Apple.TextureRange
    /// </summary>
    public enum AppleTextureRange
    {
        /// <summary>
        /// Original was GL_TEXTURE_RANGE_LENGTH_APPLE = 0x85B7
        /// </summary>
        TextureRangeLengthApple = 0x85b7,

        /// <summary>
        /// Original was GL_TEXTURE_RANGE_POINTER_APPLE = 0x85B8
        /// </summary>
        TextureRangePointerApple = 0x85b8,

        /// <summary>
        /// Original was GL_TEXTURE_STORAGE_HINT_APPLE = 0x85BC
        /// </summary>
        TextureStorageHintApple = 0x85bc,

        /// <summary>
        /// Original was GL_STORAGE_PRIVATE_APPLE = 0x85BD
        /// </summary>
        StoragePrivateApple = 0x85bd,

        /// <summary>
        /// Original was GL_STORAGE_CACHED_APPLE = 0x85BE
        /// </summary>
        StorageCachedApple = 0x85be,

        /// <summary>
        /// Original was GL_STORAGE_SHARED_APPLE = 0x85BF
        /// </summary>
        StorageSharedApple = 0x85bf
    }
}
