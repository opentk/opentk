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
    /// Used in GL.Arb.GetHandle, GL.Arb.GetObjectParameter
    /// </summary>
    public enum ArbShaderObjects
    {
        /// <summary>
        /// Original was GL_PROGRAM_OBJECT_ARB = 0x8B40
        /// </summary>
        ProgramObjectArb = 0x8b40,

        /// <summary>
        /// Original was GL_SHADER_OBJECT_ARB = 0x8B48
        /// </summary>
        ShaderObjectArb = 0x8b48,

        /// <summary>
        /// Original was GL_OBJECT_TYPE_ARB = 0x8B4E
        /// </summary>
        ObjectTypeArb = 0x8b4e,

        /// <summary>
        /// Original was GL_OBJECT_SUBTYPE_ARB = 0x8B4F
        /// </summary>
        ObjectSubtypeArb = 0x8b4f,

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
        /// Original was GL_INT_VEC2_ARB = 0x8B53
        /// </summary>
        IntVec2Arb = 0x8b53,

        /// <summary>
        /// Original was GL_INT_VEC3_ARB = 0x8B54
        /// </summary>
        IntVec3Arb = 0x8b54,

        /// <summary>
        /// Original was GL_INT_VEC4_ARB = 0x8B55
        /// </summary>
        IntVec4Arb = 0x8b55,

        /// <summary>
        /// Original was GL_BOOL_ARB = 0x8B56
        /// </summary>
        BoolArb = 0x8b56,

        /// <summary>
        /// Original was GL_BOOL_VEC2_ARB = 0x8B57
        /// </summary>
        BoolVec2Arb = 0x8b57,

        /// <summary>
        /// Original was GL_BOOL_VEC3_ARB = 0x8B58
        /// </summary>
        BoolVec3Arb = 0x8b58,

        /// <summary>
        /// Original was GL_BOOL_VEC4_ARB = 0x8B59
        /// </summary>
        BoolVec4Arb = 0x8b59,

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
        /// Original was GL_SAMPLER_1D_ARB = 0x8B5D
        /// </summary>
        Sampler1DArb = 0x8b5d,

        /// <summary>
        /// Original was GL_SAMPLER_2D_ARB = 0x8B5E
        /// </summary>
        Sampler2DArb = 0x8b5e,

        /// <summary>
        /// Original was GL_SAMPLER_3D_ARB = 0x8B5F
        /// </summary>
        Sampler3DArb = 0x8b5f,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_ARB = 0x8B60
        /// </summary>
        SamplerCubeArb = 0x8b60,

        /// <summary>
        /// Original was GL_SAMPLER_1D_SHADOW_ARB = 0x8B61
        /// </summary>
        Sampler1DShadowArb = 0x8b61,

        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW_ARB = 0x8B62
        /// </summary>
        Sampler2DShadowArb = 0x8b62,

        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT_ARB = 0x8B63
        /// </summary>
        Sampler2DRectArb = 0x8b63,

        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64
        /// </summary>
        Sampler2DRectShadowArb = 0x8b64,

        /// <summary>
        /// Original was GL_OBJECT_DELETE_STATUS_ARB = 0x8B80
        /// </summary>
        ObjectDeleteStatusArb = 0x8b80,

        /// <summary>
        /// Original was GL_OBJECT_COMPILE_STATUS_ARB = 0x8B81
        /// </summary>
        ObjectCompileStatusArb = 0x8b81,

        /// <summary>
        /// Original was GL_OBJECT_LINK_STATUS_ARB = 0x8B82
        /// </summary>
        ObjectLinkStatusArb = 0x8b82,

        /// <summary>
        /// Original was GL_OBJECT_VALIDATE_STATUS_ARB = 0x8B83
        /// </summary>
        ObjectValidateStatusArb = 0x8b83,

        /// <summary>
        /// Original was GL_OBJECT_INFO_LOG_LENGTH_ARB = 0x8B84
        /// </summary>
        ObjectInfoLogLengthArb = 0x8b84,

        /// <summary>
        /// Original was GL_OBJECT_ATTACHED_OBJECTS_ARB = 0x8B85
        /// </summary>
        ObjectAttachedObjectsArb = 0x8b85,

        /// <summary>
        /// Original was GL_OBJECT_ACTIVE_UNIFORMS_ARB = 0x8B86
        /// </summary>
        ObjectActiveUniformsArb = 0x8b86,

        /// <summary>
        /// Original was GL_OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB = 0x8B87
        /// </summary>
        ObjectActiveUniformMaxLengthArb = 0x8b87,

        /// <summary>
        /// Original was GL_OBJECT_SHADER_SOURCE_LENGTH_ARB = 0x8B88
        /// </summary>
        ObjectShaderSourceLengthArb = 0x8b88
    }
}
