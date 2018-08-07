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
    /// Used in GL.NV.DrawCommandsAddres and GL.NV.DrawCommands, as well as 2 other functions.
    /// </summary>
    public enum NVCommandList
    {
        /// <summary>
        /// Original was GL_TERMINATE_SEQUENCE_COMMAND_NV = 0x0
        /// </summary>
        TerminateSequenceCommandNV = 0x0,

        /// <summary>
        /// Original was GL_NOP_COMMAND_NV = 0x1
        /// </summary>
        NopCommandNV = 0x1,

        /// <summary>
        /// Original was GL_DRAW_ELEMENTS_COMMAND_NV = 0x2
        /// </summary>
        DrawElementsCommandNV = 0x2,

        /// <summary>
        /// Original was GL_DRAW_ARRAYS_COMMAND_NV = 0x3
        /// </summary>
        DrawArraysCommandNV = 0x3,

        /// <summary>
        /// Original was GL_DRAW_ELEMENTS_STRIP_COMMAND_NV = 0x4
        /// </summary>
        DrawElementsStripCommandNV = 0x4,

        /// <summary>
        /// Original was GL_DRAW_ARRAYS_STRIP_COMMAND_NV = 0x5
        /// </summary>
        DrawArraysStripCommandNV = 0x5,

        /// <summary>
        /// Original was GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV = 0x6
        /// </summary>
        DrawElementsInstancedCommandNV = 0x6,

        /// <summary>
        /// Original was GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV = 0x7
        /// </summary>
        DrawArraysInstancedCommandNV = 0x7,

        /// <summary>
        /// Original was GL_ELEMENT_ADDRESS_COMMAND_NV = 0x8
        /// </summary>
        ElementAddressCommandNV = 0x8,

        /// <summary>
        /// Original was GL_ATTRIBUTE_ADDRESS_COMMAND_NV = 0x9
        /// </summary>
        AttributeAddressCommandNV = 0x9,

        /// <summary>
        /// Original was GL_UNIFORM_ADDRESS_COMMAND_NV = 0xA
        /// </summary>
        UniformAddressCommandNV = 0xA,

        /// <summary>
        /// Original was GL_BLEND_COLOR_COMMAND_NV = 0xB
        /// </summary>
        BlendColorCommandNV = 0xB,

        /// <summary>
        /// Original was GL_STENCIL_REF_COMMAND_NV = 0xC
        /// </summary>
        StencilRefCommandNV = 0xC,

        /// <summary>
        /// Original was GL_LINE_WIDTH_COMMAND_NV = 0xD
        /// </summary>
        LineWidthCommandNV = 0xD,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_COMMAND_NV = 0xE
        /// </summary>
        PolygonOffsetCommandNV = 0xE,

        /// <summary>
        /// Original was GL_ALPHA_REF_COMMAND_NV = 0xF
        /// </summary>
        AlphaRefCommandNV = 0xF,

        /// <summary>
        /// Original was GL_VIEWPORT_COMMAND_NV = 0x10
        /// </summary>
        ViewportCommandNV = 0x10,

        /// <summary>
        /// Original was GL_SCISSOR_COMMAND_NV = 0x11
        /// </summary>
        ScissorCommandNV = 0x11,

        /// <summary>
        /// Original was GL_FRONT_FACE_COMMAND_NV = 0x12
        /// </summary>
        FrontFaceCommandNV = 0x12
    }
}
