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

// ReSharper disable InconsistentNaming
#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// Original was GL_NO_ERROR = 0x0
        /// </summary>
        NoError = 0x0,

        /// <summary>
        /// Original was GL_INVALID_ENUM = 0x500
        /// </summary>
        InvalidEnum = 0x500,

        /// <summary>
        /// Original was GL_INVALID_VALUE = 0x501
        /// </summary>
        InvalidValue = 0x501,

        /// <summary>
        /// Original was GL_INVALID_OPERATION = 0x502
        /// </summary>
        InvalidOperation = 0x502,

        /// <summary>
        /// Original was GL_OUT_OF_MEMORY = 0x505
        /// </summary>
        OutOfMemory = 0x505,

        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION = 0x506
        /// </summary>
        InvalidFramebufferOperation = 0x506,

        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_EXT = 0x506
        /// </summary>
        InvalidFramebufferOperationExt = 0x506,

        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_OES = 0x506
        /// </summary>
        InvalidFramebufferOperationOes = 0x506,

        /// <summary>
        /// Original was GL_TABLE_TOO_LARGE = 0x8031
        /// </summary>
        TableTooLarge = 0x8031,

        /// <summary>
        /// Original was GL_TABLE_TOO_LARGE_EXT = 0x8031
        /// </summary>
        TableTooLargeExt = 0x8031,

        /// <summary>
        /// Original was GL_TEXTURE_TOO_LARGE_EXT = 0x8065
        /// </summary>
        TextureTooLargeExt = 0x8065
    }
}
