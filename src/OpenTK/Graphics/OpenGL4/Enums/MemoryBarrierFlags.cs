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
    /// Used in GL.MemoryBarrier.
    /// </summary>
    public enum MemoryBarrierFlags
    {
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x1
        /// </summary>
        VertexAttribArrayBarrierBit = 0x1,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BARRIER_BIT = 0x2
        /// </summary>
        ElementArrayBarrierBit = 0x2,

        /// <summary>
        /// Original was GL_UNIFORM_BARRIER_BIT = 0x4
        /// </summary>
        UniformBarrierBit = 0x4,

        /// <summary>
        /// Original was GL_TEXTURE_FETCH_BARRIER_BIT = 0x8
        /// </summary>
        TextureFetchBarrierBit = 0x8,

        /// <summary>
        /// Original was GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x20
        /// </summary>
        ShaderImageAccessBarrierBit = 0x20,

        /// <summary>
        /// Original was GL_COMMAND_BARRIER_BIT = 0x40
        /// </summary>
        CommandBarrierBit = 0x40,

        /// <summary>
        /// Original was GL_PIXEL_BUFFER_BARRIER_BIT = 0x80
        /// </summary>
        PixelBufferBarrierBit = 0x80,

        /// <summary>
        /// Original was GL_TEXTURE_UPDATE_BARRIER_BIT = 0x100
        /// </summary>
        TextureUpdateBarrierBit = 0x100,

        /// <summary>
        /// Original was GL_BUFFER_UPDATE_BARRIER_BIT = 0x200
        /// </summary>
        BufferUpdateBarrierBit = 0x200,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BARRIER_BIT = 0x400
        /// </summary>
        FramebufferBarrierBit = 0x400,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x800
        /// </summary>
        TransformFeedbackBarrierBit = 0x800,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BARRIER_BIT = 0x1000
        /// </summary>
        AtomicCounterBarrierBit = 0x1000,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BARRIER_BIT = 0x2000
        /// </summary>
        ShaderStorageBarrierBit = 0x2000,

        /// <summary>
        /// Original was GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x4000
        /// </summary>
        ClientMappedBufferBarrierBit = 0x4000,

        /// <summary>
        /// Original was GL_QUERY_BUFFER_BARRIER_BIT = 0x8000
        /// </summary>
        QueryBufferBarrierBit = 0x8000,

        /// <summary>
        /// Original was GL_ALL_BARRIER_BITS = 0xFFFFFFFF
        /// </summary>
        AllBarrierBits = unchecked((int)0xFFFFFFFF)
    }
}
