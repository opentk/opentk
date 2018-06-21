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
    public enum ExtShaderImageLoadStore
    {
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT = 0x00000001
        /// </summary>
        VertexAttribArrayBarrierBitExt = ((int)0x00000001),

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BARRIER_BIT_EXT = 0x00000002
        /// </summary>
        ElementArrayBarrierBitExt = ((int)0x00000002),

        /// <summary>
        /// Original was GL_UNIFORM_BARRIER_BIT_EXT = 0x00000004
        /// </summary>
        UniformBarrierBitExt = ((int)0x00000004),

        /// <summary>
        /// Original was GL_TEXTURE_FETCH_BARRIER_BIT_EXT = 0x00000008
        /// </summary>
        TextureFetchBarrierBitExt = ((int)0x00000008),

        /// <summary>
        /// Original was GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT = 0x00000020
        /// </summary>
        ShaderImageAccessBarrierBitExt = ((int)0x00000020),

        /// <summary>
        /// Original was GL_COMMAND_BARRIER_BIT_EXT = 0x00000040
        /// </summary>
        CommandBarrierBitExt = ((int)0x00000040),

        /// <summary>
        /// Original was GL_PIXEL_BUFFER_BARRIER_BIT_EXT = 0x00000080
        /// </summary>
        PixelBufferBarrierBitExt = ((int)0x00000080),

        /// <summary>
        /// Original was GL_TEXTURE_UPDATE_BARRIER_BIT_EXT = 0x00000100
        /// </summary>
        TextureUpdateBarrierBitExt = ((int)0x00000100),

        /// <summary>
        /// Original was GL_BUFFER_UPDATE_BARRIER_BIT_EXT = 0x00000200
        /// </summary>
        BufferUpdateBarrierBitExt = ((int)0x00000200),

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BARRIER_BIT_EXT = 0x00000400
        /// </summary>
        FramebufferBarrierBitExt = ((int)0x00000400),

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT = 0x00000800
        /// </summary>
        TransformFeedbackBarrierBitExt = ((int)0x00000800),

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BARRIER_BIT_EXT = 0x00001000
        /// </summary>
        AtomicCounterBarrierBitExt = ((int)0x00001000),

        /// <summary>
        /// Original was GL_MAX_IMAGE_UNITS_EXT = 0x8F38
        /// </summary>
        MaxImageUnitsExt = 0x8f38,

        /// <summary>
        /// Original was GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT = 0x8F39
        /// </summary>
        MaxCombinedImageUnitsAndFragmentOutputsExt = 0x8f39,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_NAME_EXT = 0x8F3A
        /// </summary>
        ImageBindingNameExt = 0x8f3a,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_LEVEL_EXT = 0x8F3B
        /// </summary>
        ImageBindingLevelExt = 0x8f3b,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_LAYERED_EXT = 0x8F3C
        /// </summary>
        ImageBindingLayeredExt = 0x8f3c,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_LAYER_EXT = 0x8F3D
        /// </summary>
        ImageBindingLayerExt = 0x8f3d,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_ACCESS_EXT = 0x8F3E
        /// </summary>
        ImageBindingAccessExt = 0x8f3e,

        /// <summary>
        /// Original was GL_IMAGE_1D_EXT = 0x904C
        /// </summary>
        Image1DExt = 0x904c,

        /// <summary>
        /// Original was GL_IMAGE_2D_EXT = 0x904D
        /// </summary>
        Image2DExt = 0x904d,

        /// <summary>
        /// Original was GL_IMAGE_3D_EXT = 0x904E
        /// </summary>
        Image3DExt = 0x904e,

        /// <summary>
        /// Original was GL_IMAGE_2D_RECT_EXT = 0x904F
        /// </summary>
        Image2DRectExt = 0x904f,

        /// <summary>
        /// Original was GL_IMAGE_CUBE_EXT = 0x9050
        /// </summary>
        ImageCubeExt = 0x9050,

        /// <summary>
        /// Original was GL_IMAGE_BUFFER_EXT = 0x9051
        /// </summary>
        ImageBufferExt = 0x9051,

        /// <summary>
        /// Original was GL_IMAGE_1D_ARRAY_EXT = 0x9052
        /// </summary>
        Image1DArrayExt = 0x9052,

        /// <summary>
        /// Original was GL_IMAGE_2D_ARRAY_EXT = 0x9053
        /// </summary>
        Image2DArrayExt = 0x9053,

        /// <summary>
        /// Original was GL_IMAGE_CUBE_MAP_ARRAY_EXT = 0x9054
        /// </summary>
        ImageCubeMapArrayExt = 0x9054,

        /// <summary>
        /// Original was GL_IMAGE_2D_MULTISAMPLE_EXT = 0x9055
        /// </summary>
        Image2DMultisampleExt = 0x9055,

        /// <summary>
        /// Original was GL_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9056
        /// </summary>
        Image2DMultisampleArrayExt = 0x9056,

        /// <summary>
        /// Original was GL_INT_IMAGE_1D_EXT = 0x9057
        /// </summary>
        IntImage1DExt = 0x9057,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D_EXT = 0x9058
        /// </summary>
        IntImage2DExt = 0x9058,

        /// <summary>
        /// Original was GL_INT_IMAGE_3D_EXT = 0x9059
        /// </summary>
        IntImage3DExt = 0x9059,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D_RECT_EXT = 0x905A
        /// </summary>
        IntImage2DRectExt = 0x905a,

        /// <summary>
        /// Original was GL_INT_IMAGE_CUBE_EXT = 0x905B
        /// </summary>
        IntImageCubeExt = 0x905b,

        /// <summary>
        /// Original was GL_INT_IMAGE_BUFFER_EXT = 0x905C
        /// </summary>
        IntImageBufferExt = 0x905c,

        /// <summary>
        /// Original was GL_INT_IMAGE_1D_ARRAY_EXT = 0x905D
        /// </summary>
        IntImage1DArrayExt = 0x905d,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D_ARRAY_EXT = 0x905E
        /// </summary>
        IntImage2DArrayExt = 0x905e,

        /// <summary>
        /// Original was GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x905F
        /// </summary>
        IntImageCubeMapArrayExt = 0x905f,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x9060
        /// </summary>
        IntImage2DMultisampleExt = 0x9060,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9061
        /// </summary>
        IntImage2DMultisampleArrayExt = 0x9061,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_1D_EXT = 0x9062
        /// </summary>
        UnsignedIntImage1DExt = 0x9062,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D_EXT = 0x9063
        /// </summary>
        UnsignedIntImage2DExt = 0x9063,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_3D_EXT = 0x9064
        /// </summary>
        UnsignedIntImage3DExt = 0x9064,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D_RECT_EXT = 0x9065
        /// </summary>
        UnsignedIntImage2DRectExt = 0x9065,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_CUBE_EXT = 0x9066
        /// </summary>
        UnsignedIntImageCubeExt = 0x9066,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_BUFFER_EXT = 0x9067
        /// </summary>
        UnsignedIntImageBufferExt = 0x9067,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_1D_ARRAY_EXT = 0x9068
        /// </summary>
        UnsignedIntImage1DArrayExt = 0x9068,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D_ARRAY_EXT = 0x9069
        /// </summary>
        UnsignedIntImage2DArrayExt = 0x9069,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x906A
        /// </summary>
        UnsignedIntImageCubeMapArrayExt = 0x906a,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x906B
        /// </summary>
        UnsignedIntImage2DMultisampleExt = 0x906b,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x906C
        /// </summary>
        UnsignedIntImage2DMultisampleArrayExt = 0x906c,

        /// <summary>
        /// Original was GL_MAX_IMAGE_SAMPLES_EXT = 0x906D
        /// </summary>
        MaxImageSamplesExt = 0x906d,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_FORMAT_EXT = 0x906E
        /// </summary>
        ImageBindingFormatExt = 0x906e,

        /// <summary>
        /// Original was GL_ALL_BARRIER_BITS_EXT = 0xFFFFFFFF
        /// </summary>
        AllBarrierBitsExt = unchecked((int)0xffffffff)
    }
}
