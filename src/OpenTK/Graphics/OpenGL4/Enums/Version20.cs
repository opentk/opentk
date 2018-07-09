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
    public enum Version20
    {
        /// <summary>
        /// Original was GL_BLEND_EQUATION_RGB = 0x8009
        /// </summary>
        BlendEquationRgb = 0x8009,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622
        /// </summary>
        VertexAttribArrayEnabled = 0x8622,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623
        /// </summary>
        VertexAttribArraySize = 0x8623,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624
        /// </summary>
        VertexAttribArrayStride = 0x8624,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625
        /// </summary>
        VertexAttribArrayType = 0x8625,

        /// <summary>
        /// Original was GL_CURRENT_VERTEX_ATTRIB = 0x8626
        /// </summary>
        CurrentVertexAttrib = 0x8626,

        /// <summary>
        /// Original was GL_VERTEX_PROGRAM_POINT_SIZE = 0x8642
        /// </summary>
        VertexProgramPointSize = 0x8642,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645
        /// </summary>
        VertexAttribArrayPointer = 0x8645,

        /// <summary>
        /// Original was GL_STENCIL_BACK_FUNC = 0x8800
        /// </summary>
        StencilBackFunc = 0x8800,

        /// <summary>
        /// Original was GL_STENCIL_BACK_FAIL = 0x8801
        /// </summary>
        StencilBackFail = 0x8801,

        /// <summary>
        /// Original was GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802
        /// </summary>
        StencilBackPassDepthFail = 0x8802,

        /// <summary>
        /// Original was GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803
        /// </summary>
        StencilBackPassDepthPass = 0x8803,

        /// <summary>
        /// Original was GL_MAX_DRAW_BUFFERS = 0x8824
        /// </summary>
        MaxDrawBuffers = 0x8824,

        /// <summary>
        /// Original was GL_DRAW_BUFFER0 = 0x8825
        /// </summary>
        DrawBuffer0 = 0x8825,

        /// <summary>
        /// Original was GL_DRAW_BUFFER1 = 0x8826
        /// </summary>
        DrawBuffer1 = 0x8826,

        /// <summary>
        /// Original was GL_DRAW_BUFFER2 = 0x8827
        /// </summary>
        DrawBuffer2 = 0x8827,

        /// <summary>
        /// Original was GL_DRAW_BUFFER3 = 0x8828
        /// </summary>
        DrawBuffer3 = 0x8828,

        /// <summary>
        /// Original was GL_DRAW_BUFFER4 = 0x8829
        /// </summary>
        DrawBuffer4 = 0x8829,

        /// <summary>
        /// Original was GL_DRAW_BUFFER5 = 0x882A
        /// </summary>
        DrawBuffer5 = 0x882a,

        /// <summary>
        /// Original was GL_DRAW_BUFFER6 = 0x882B
        /// </summary>
        DrawBuffer6 = 0x882b,

        /// <summary>
        /// Original was GL_DRAW_BUFFER7 = 0x882C
        /// </summary>
        DrawBuffer7 = 0x882c,

        /// <summary>
        /// Original was GL_DRAW_BUFFER8 = 0x882D
        /// </summary>
        DrawBuffer8 = 0x882d,

        /// <summary>
        /// Original was GL_DRAW_BUFFER9 = 0x882E
        /// </summary>
        DrawBuffer9 = 0x882e,

        /// <summary>
        /// Original was GL_DRAW_BUFFER10 = 0x882F
        /// </summary>
        DrawBuffer10 = 0x882f,

        /// <summary>
        /// Original was GL_DRAW_BUFFER11 = 0x8830
        /// </summary>
        DrawBuffer11 = 0x8830,

        /// <summary>
        /// Original was GL_DRAW_BUFFER12 = 0x8831
        /// </summary>
        DrawBuffer12 = 0x8831,

        /// <summary>
        /// Original was GL_DRAW_BUFFER13 = 0x8832
        /// </summary>
        DrawBuffer13 = 0x8832,

        /// <summary>
        /// Original was GL_DRAW_BUFFER14 = 0x8833
        /// </summary>
        DrawBuffer14 = 0x8833,

        /// <summary>
        /// Original was GL_DRAW_BUFFER15 = 0x8834
        /// </summary>
        DrawBuffer15 = 0x8834,

        /// <summary>
        /// Original was GL_BLEND_EQUATION_ALPHA = 0x883D
        /// </summary>
        BlendEquationAlpha = 0x883d,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ATTRIBS = 0x8869
        /// </summary>
        MaxVertexAttribs = 0x8869,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A
        /// </summary>
        VertexAttribArrayNormalized = 0x886a,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872
        /// </summary>
        MaxTextureImageUnits = 0x8872,

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER = 0x8B30
        /// </summary>
        FragmentShader = 0x8b30,

        /// <summary>
        /// Original was GL_VERTEX_SHADER = 0x8B31
        /// </summary>
        VertexShader = 0x8b31,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49
        /// </summary>
        MaxFragmentUniformComponents = 0x8b49,

        /// <summary>
        /// Original was GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A
        /// </summary>
        MaxVertexUniformComponents = 0x8b4a,

        /// <summary>
        /// Original was GL_MAX_VARYING_FLOATS = 0x8B4B
        /// </summary>
        MaxVaryingFloats = 0x8b4b,

        /// <summary>
        /// Original was GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C
        /// </summary>
        MaxVertexTextureImageUnits = 0x8b4c,

        /// <summary>
        /// Original was GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D
        /// </summary>
        MaxCombinedTextureImageUnits = 0x8b4d,

        /// <summary>
        /// Original was GL_SHADER_TYPE = 0x8B4F
        /// </summary>
        ShaderType = 0x8b4f,

        /// <summary>
        /// Original was GL_FLOAT_VEC2 = 0x8B50
        /// </summary>
        FloatVec2 = 0x8b50,

        /// <summary>
        /// Original was GL_FLOAT_VEC3 = 0x8B51
        /// </summary>
        FloatVec3 = 0x8b51,

        /// <summary>
        /// Original was GL_FLOAT_VEC4 = 0x8B52
        /// </summary>
        FloatVec4 = 0x8b52,

        /// <summary>
        /// Original was GL_INT_VEC2 = 0x8B53
        /// </summary>
        IntVec2 = 0x8b53,

        /// <summary>
        /// Original was GL_INT_VEC3 = 0x8B54
        /// </summary>
        IntVec3 = 0x8b54,

        /// <summary>
        /// Original was GL_INT_VEC4 = 0x8B55
        /// </summary>
        IntVec4 = 0x8b55,

        /// <summary>
        /// Original was GL_BOOL = 0x8B56
        /// </summary>
        Bool = 0x8b56,

        /// <summary>
        /// Original was GL_BOOL_VEC2 = 0x8B57
        /// </summary>
        BoolVec2 = 0x8b57,

        /// <summary>
        /// Original was GL_BOOL_VEC3 = 0x8B58
        /// </summary>
        BoolVec3 = 0x8b58,

        /// <summary>
        /// Original was GL_BOOL_VEC4 = 0x8B59
        /// </summary>
        BoolVec4 = 0x8b59,

        /// <summary>
        /// Original was GL_FLOAT_MAT2 = 0x8B5A
        /// </summary>
        FloatMat2 = 0x8b5a,

        /// <summary>
        /// Original was GL_FLOAT_MAT3 = 0x8B5B
        /// </summary>
        FloatMat3 = 0x8b5b,

        /// <summary>
        /// Original was GL_FLOAT_MAT4 = 0x8B5C
        /// </summary>
        FloatMat4 = 0x8b5c,

        /// <summary>
        /// Original was GL_SAMPLER_1D = 0x8B5D
        /// </summary>
        Sampler1D = 0x8b5d,

        /// <summary>
        /// Original was GL_SAMPLER_2D = 0x8B5E
        /// </summary>
        Sampler2D = 0x8b5e,

        /// <summary>
        /// Original was GL_SAMPLER_3D = 0x8B5F
        /// </summary>
        Sampler3D = 0x8b5f,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE = 0x8B60
        /// </summary>
        SamplerCube = 0x8b60,

        /// <summary>
        /// Original was GL_SAMPLER_1D_SHADOW = 0x8B61
        /// </summary>
        Sampler1DShadow = 0x8b61,

        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW = 0x8B62
        /// </summary>
        Sampler2DShadow = 0x8b62,

        /// <summary>
        /// Original was GL_DELETE_STATUS = 0x8B80
        /// </summary>
        DeleteStatus = 0x8b80,

        /// <summary>
        /// Original was GL_COMPILE_STATUS = 0x8B81
        /// </summary>
        CompileStatus = 0x8b81,

        /// <summary>
        /// Original was GL_LINK_STATUS = 0x8B82
        /// </summary>
        LinkStatus = 0x8b82,

        /// <summary>
        /// Original was GL_VALIDATE_STATUS = 0x8B83
        /// </summary>
        ValidateStatus = 0x8b83,

        /// <summary>
        /// Original was GL_INFO_LOG_LENGTH = 0x8B84
        /// </summary>
        InfoLogLength = 0x8b84,

        /// <summary>
        /// Original was GL_ATTACHED_SHADERS = 0x8B85
        /// </summary>
        AttachedShaders = 0x8b85,

        /// <summary>
        /// Original was GL_ACTIVE_UNIFORMS = 0x8B86
        /// </summary>
        ActiveUniforms = 0x8b86,

        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87
        /// </summary>
        ActiveUniformMaxLength = 0x8b87,

        /// <summary>
        /// Original was GL_SHADER_SOURCE_LENGTH = 0x8B88
        /// </summary>
        ShaderSourceLength = 0x8b88,

        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTES = 0x8B89
        /// </summary>
        ActiveAttributes = 0x8b89,

        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A
        /// </summary>
        ActiveAttributeMaxLength = 0x8b8a,

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHint = 0x8b8b,

        /// <summary>
        /// Original was GL_SHADING_LANGUAGE_VERSION = 0x8B8C
        /// </summary>
        ShadingLanguageVersion = 0x8b8c,

        /// <summary>
        /// Original was GL_CURRENT_PROGRAM = 0x8B8D
        /// </summary>
        CurrentProgram = 0x8b8d,

        /// <summary>
        /// Original was GL_POINT_SPRITE_COORD_ORIGIN = 0x8CA0
        /// </summary>
        PointSpriteCoordOrigin = 0x8ca0,

        /// <summary>
        /// Original was GL_LOWER_LEFT = 0x8CA1
        /// </summary>
        LowerLeft = 0x8ca1,

        /// <summary>
        /// Original was GL_UPPER_LEFT = 0x8CA2
        /// </summary>
        UpperLeft = 0x8ca2,

        /// <summary>
        /// Original was GL_STENCIL_BACK_REF = 0x8CA3
        /// </summary>
        StencilBackRef = 0x8ca3,

        /// <summary>
        /// Original was GL_STENCIL_BACK_VALUE_MASK = 0x8CA4
        /// </summary>
        StencilBackValueMask = 0x8ca4,

        /// <summary>
        /// Original was GL_STENCIL_BACK_WRITEMASK = 0x8CA5
        /// </summary>
        StencilBackWritemask = 0x8ca5
    }
}
