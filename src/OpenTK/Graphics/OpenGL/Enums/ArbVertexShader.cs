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
    /// Not used directly.
    /// </summary>
    public enum ArbVertexShader
    {
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB = 0x8622
        /// </summary>
        VertexAttribArrayEnabledArb = 0x8622,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB = 0x8623
        /// </summary>
        VertexAttribArraySizeArb = 0x8623,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB = 0x8624
        /// </summary>
        VertexAttribArrayStrideArb = 0x8624,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB = 0x8625
        /// </summary>
        VertexAttribArrayTypeArb = 0x8625,

        /// <summary>
        /// Original was GL_CURRENT_VERTEX_ATTRIB_ARB = 0x8626
        /// </summary>
        CurrentVertexAttribArb = 0x8626,

        /// <summary>
        /// Original was GL_VERTEX_PROGRAM_POINT_SIZE_ARB = 0x8642
        /// </summary>
        VertexProgramPointSizeArb = 0x8642,

        /// <summary>
        /// Original was GL_VERTEX_PROGRAM_TWO_SIDE_ARB = 0x8643
        /// </summary>
        VertexProgramTwoSideArb = 0x8643,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB = 0x8645
        /// </summary>
        VertexAttribArrayPointerArb = 0x8645,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ATTRIBS_ARB = 0x8869
        /// </summary>
        MaxVertexAttribsArb = 0x8869,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB = 0x886A
        /// </summary>
        VertexAttribArrayNormalizedArb = 0x886a,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_COORDS_ARB = 0x8871
        /// </summary>
        MaxTextureCoordsArb = 0x8871,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_IMAGE_UNITS_ARB = 0x8872
        /// </summary>
        MaxTextureImageUnitsArb = 0x8872,

        /// <summary>
        /// Original was GL_VERTEX_SHADER_ARB = 0x8B31
        /// </summary>
        VertexShaderArb = 0x8b31,

        /// <summary>
        /// Original was GL_MAX_VERTEX_UNIFORM_COMPONENTS_ARB = 0x8B4A
        /// </summary>
        MaxVertexUniformComponentsArb = 0x8b4a,

        /// <summary>
        /// Original was GL_MAX_VARYING_FLOATS_ARB = 0x8B4B
        /// </summary>
        MaxVaryingFloatsArb = 0x8b4b,

        /// <summary>
        /// Original was GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB = 0x8B4C
        /// </summary>
        MaxVertexTextureImageUnitsArb = 0x8b4c,

        /// <summary>
        /// Original was GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB = 0x8B4D
        /// </summary>
        MaxCombinedTextureImageUnitsArb = 0x8b4d,

        /// <summary>
        /// Original was GL_FLOAT_VEC2_ARB = 0x8B50
        /// </summary>
        FloatVec2Arb = 0x8b50,

        /// <summary>
        /// Original was GL_FLOAT_VEC3_ARB = 0x8B51
        /// </summary>
        FloatVec3Arb = 0x8b51,

        /// <summary>
        /// Original was GL_FLOAT_VEC4_ARB = 0x8B52
        /// </summary>
        FloatVec4Arb = 0x8b52,

        /// <summary>
        /// Original was GL_FLOAT_MAT2_ARB = 0x8B5A
        /// </summary>
        FloatMat2Arb = 0x8b5a,

        /// <summary>
        /// Original was GL_FLOAT_MAT3_ARB = 0x8B5B
        /// </summary>
        FloatMat3Arb = 0x8b5b,

        /// <summary>
        /// Original was GL_FLOAT_MAT4_ARB = 0x8B5C
        /// </summary>
        FloatMat4Arb = 0x8b5c,

        /// <summary>
        /// Original was GL_OBJECT_ACTIVE_ATTRIBUTES_ARB = 0x8B89
        /// </summary>
        ObjectActiveAttributesArb = 0x8b89,

        /// <summary>
        /// Original was GL_OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB = 0x8B8A
        /// </summary>
        ObjectActiveAttributeMaxLengthArb = 0x8b8a
    }
}
