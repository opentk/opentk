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
    public enum ContextFlagMask
    {
        /// <summary>
        /// Original was GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001
        /// </summary>
        ContextFlagForwardCompatibleBit = 0x00000001,

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002
        /// </summary>
        ContextFlagDebugBit = 0x00000002,

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_DEBUG_BIT_KHR = 0x00000002
        /// </summary>
        ContextFlagDebugBitKhr = 0x00000002,

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004
        /// </summary>
        ContextFlagRobustAccessBit = 0x00000004,

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x00000004
        /// </summary>
        ContextFlagRobustAccessBitArb = 0x00000004,

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_NO_ERROR_BIT = 0x00000008
        /// </summary>
        ContextFlagNoErrorBit = 0x00000008,

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR = 0x00000008
        /// </summary>
        ContextFlagNoErrorBitKhr = 0x00000008,

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT = 0x00000010
        /// </summary>
        ContextFlagProtectedContentBitExt = 0x00000010
    }
}
