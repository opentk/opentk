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
    /// Used in GL.NV.GetCommandHeader and GL.NV.StateCapture.
    /// </summary>
    public enum NvCommandList
    {
        /// <summary>
        /// Original was GL_TERMINATE_SEQUENCE_COMMAND_NV = 0x0000
        /// </summary>
        TerminateSequenceCommandNv = 0x0000,

        /// <summary>
        /// Original was GL_NOP_COMMAND_NV = 0x0001
        /// </summary>
        NopCommandNv = 0x0001,

        /// <summary>
        /// Original was GL_DRAW_ELEMENTS_COMMAND_NV = 0x0002
        /// </summary>
        DrawElementsCommandNv = 0x0002,

        /// <summary>
        /// Original was GL_DRAW_ARRAYS_COMMAND_NV = 0x0003
        /// </summary>
        DrawArraysCommandNv = 0x0003,

        /// <summary>
        /// Original was GL_DRAW_ELEMENTS_STRIP_COMMAND_NV = 0x0004
        /// </summary>
        DrawElementsStripCommandNv = 0x0004,

        /// <summary>
        /// Original was GL_DRAW_ARRAYS_STRIP_COMMAND_NV = 0x0005
        /// </summary>
        DrawArraysStripCommandNv = 0x0005,

        /// <summary>
        /// Original was GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV = 0x0006
        /// </summary>
        DrawElementsInstancedCommandNv = 0x0006,

        /// <summary>
        /// Original was GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV = 0x0007
        /// </summary>
        DrawArraysInstancedCommandNv = 0x0007,

        /// <summary>
        /// Original was GL_ELEMENT_ADDRESS_COMMAND_NV = 0x0008
        /// </summary>
        ElementAddressCommandNv = 0x0008,

        /// <summary>
        /// Original was GL_ATTRIBUTE_ADDRESS_COMMAND_NV = 0x0009
        /// </summary>
        AttributeAddressCommandNv = 0x0009,

        /// <summary>
        /// Original was GL_UNIFORM_ADDRESS_COMMAND_NV = 0x000A
        /// </summary>
        UniformAddressCommandNv = 0x000a,

        /// <summary>
        /// Original was GL_BLEND_COLOR_COMMAND_NV = 0x000B
        /// </summary>
        BlendColorCommandNv = 0x000b,

        /// <summary>
        /// Original was GL_STENCIL_REF_COMMAND_NV = 0x000C
        /// </summary>
        StencilRefCommandNv = 0x000c,

        /// <summary>
        /// Original was GL_LINE_WIDTH_COMMAND_NV = 0x000D
        /// </summary>
        LineWidthCommandNv = 0x000d,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_COMMAND_NV = 0x000E
        /// </summary>
        PolygonOffsetCommandNv = 0x000e,

        /// <summary>
        /// Original was GL_ALPHA_REF_COMMAND_NV = 0x000F
        /// </summary>
        AlphaRefCommandNv = 0x000f,

        /// <summary>
        /// Original was GL_VIEWPORT_COMMAND_NV = 0x0010
        /// </summary>
        ViewportCommandNv = 0x0010,

        /// <summary>
        /// Original was GL_SCISSOR_COMMAND_NV = 0x0011
        /// </summary>
        ScissorCommandNv = 0x0011,

        /// <summary>
        /// Original was GL_FRONT_FACE_COMMAND_NV = 0x0012
        /// </summary>
        FrontFaceCommandNv = 0x0012
    }
}
