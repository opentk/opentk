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
    public enum Version45
    {
        /// <summary>
        /// Original was GL_NO_ERROR = 0x0
        /// </summary>
        NoError = 0x0,

        /// <summary>
        /// Original was GL_NONE = 0x0
        /// </summary>
        None = 0x0,

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x4
        /// </summary>
        ContextFlagRobustAccessBit = 0x4,

        /// <summary>
        /// Original was GL_BACK = 0x405
        /// </summary>
        Back = 0x405,

        /// <summary>
        /// Original was GL_CONTEXT_LOST = 0x507
        /// </summary>
        ContextLost = 0x507,

        /// <summary>
        /// Original was GL_CONTEXT_LOST = 0x507
        /// </summary>
        ContextLost = 0x507,

        /// <summary>
        /// Original was GL_TEXTURE_TARGET = 0x1006
        /// </summary>
        TextureTarget = 0x1006,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING1_D = 0x8068
        /// </summary>
        TextureBinding1D = 0x8068,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING2_D = 0x8069
        /// </summary>
        TextureBinding2D = 0x8069,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING3_D = 0x806A
        /// </summary>
        TextureBinding3D = 0x806A,

        /// <summary>
        /// Original was GL_LOSE_CONTEXT_ON_RESET = 0x8252
        /// </summary>
        LoseContextOnReset = 0x8252,

        /// <summary>
        /// Original was GL_GUILTY_CONTEXT_RESET = 0x8253
        /// </summary>
        GuiltyContextReset = 0x8253,

        /// <summary>
        /// Original was GL_INNOCENT_CONTEXT_RESET = 0x8254
        /// </summary>
        InnocentContextReset = 0x8254,

        /// <summary>
        /// Original was GL_UNKNOWN_CONTEXT_RESET = 0x8255
        /// </summary>
        UnknownContextReset = 0x8255,

        /// <summary>
        /// Original was GL_RESET_NOTIFICATION_STRATEGY = 0x8256
        /// </summary>
        ResetNotificationStrategy = 0x8256,

        /// <summary>
        /// Original was GL_NO_RESET_NOTIFICATION = 0x8261
        /// </summary>
        NoResetNotification = 0x8261,

        /// <summary>
        /// Original was GL_QUERY_TARGET = 0x82EA
        /// </summary>
        QueryTarget = 0x82EA,

        /// <summary>
        /// Original was GL_MAX_CULL_DISTANCES = 0x82F9
        /// </summary>
        MaxCullDistances = 0x82F9,

        /// <summary>
        /// Original was GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA
        /// </summary>
        MaxCombinedClipAndCullDistances = 0x82FA,

        /// <summary>
        /// Original was GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB
        /// </summary>
        ContextReleaseBehavior = 0x82FB,

        /// <summary>
        /// Original was GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC
        /// </summary>
        ContextReleaseBehaviorFlush = 0x82FC,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_RECTANGLE = 0x84F6
        /// </summary>
        TextureBindingRectangle = 0x84F6,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP = 0x8514
        /// </summary>
        TextureBindingCubeMap = 0x8514,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING1_D_ARRAY = 0x8C1C
        /// </summary>
        TextureBinding1DArray = 0x8C1C,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING2_D_ARRAY = 0x8C1D
        /// </summary>
        TextureBinding2DArray = 0x8C1D,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_BUFFER = 0x8C2C
        /// </summary>
        TextureBindingBuffer = 0x8C2C,

        /// <summary>
        /// Original was GL_LOWER_LEFT = 0x8CA1
        /// </summary>
        LowerLeft = 0x8CA1,

        /// <summary>
        /// Original was GL_UPPER_LEFT = 0x8CA2
        /// </summary>
        UpperLeft = 0x8CA2,

        /// <summary>
        /// Original was GL_QUERY_WAIT_INVERTED = 0x8E17
        /// </summary>
        QueryWaitInverted = 0x8E17,

        /// <summary>
        /// Original was GL_QUERY_NO_WAIT_INVERTED = 0x8E18
        /// </summary>
        QueryNoWaitInverted = 0x8E18,

        /// <summary>
        /// Original was GL_QUERY_BY_REGION_WAIT_INVERTED = 0x8E19
        /// </summary>
        QueryByRegionWaitInverted = 0x8E19,

        /// <summary>
        /// Original was GL_QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A
        /// </summary>
        QueryByRegionNoWaitInverted = 0x8E1A,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A
        /// </summary>
        TextureBindingCubeMapArray = 0x900A,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING2_D_MULTISAMPLE = 0x9104
        /// </summary>
        TextureBinding2DMultisample = 0x9104,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING2_D_MULTISAMPLE_ARRAY = 0x9105
        /// </summary>
        TextureBinding2DMultisampleArray = 0x9105,

        /// <summary>
        /// Original was GL_CLIP_ORIGIN = 0x935C
        /// </summary>
        ClipOrigin = 0x935C,

        /// <summary>
        /// Original was GL_CLIP_DEPTH_MODE = 0x935D
        /// </summary>
        ClipDepthMode = 0x935D,

        /// <summary>
        /// Original was GL_NEGATIVE_ONE_TO_ONE = 0x935E
        /// </summary>
        NegativeOneToOne = 0x935E,

        /// <summary>
        /// Original was GL_ZERO_TO_ONE = 0x935F
        /// </summary>
        ZeroToOne = 0x935F
    }
}
