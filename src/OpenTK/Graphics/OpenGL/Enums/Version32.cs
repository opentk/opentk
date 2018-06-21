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
    public enum Version32
    {
        /// <summary>
        /// Original was GL_CONTEXT_CORE_PROFILE_BIT = 0x00000001
        /// </summary>
        ContextCoreProfileBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001
        /// </summary>
        SyncFlushCommandsBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002
        /// </summary>
        ContextCompatibilityProfileBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_LINES_ADJACENCY = 0x000A
        /// </summary>
        LinesAdjacency = 0x000a,

        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY = 0x000B
        /// </summary>
        LineStripAdjacency = 0x000b,

        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY = 0x000C
        /// </summary>
        TrianglesAdjacency = 0x000c,

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY = 0x000D
        /// </summary>
        TriangleStripAdjacency = 0x000d,

        /// <summary>
        /// Original was GL_PROGRAM_POINT_SIZE = 0x8642
        /// </summary>
        ProgramPointSize = 0x8642,

        /// <summary>
        /// Original was GL_DEPTH_CLAMP = 0x864F
        /// </summary>
        DepthClamp = 0x864f,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F
        /// </summary>
        TextureCubeMapSeamless = 0x884f,

        /// <summary>
        /// Original was GL_GEOMETRY_VERTICES_OUT = 0x8916
        /// </summary>
        GeometryVerticesOut = 0x8916,

        /// <summary>
        /// Original was GL_GEOMETRY_INPUT_TYPE = 0x8917
        /// </summary>
        GeometryInputType = 0x8917,

        /// <summary>
        /// Original was GL_GEOMETRY_OUTPUT_TYPE = 0x8918
        /// </summary>
        GeometryOutputType = 0x8918,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29
        /// </summary>
        MaxGeometryTextureImageUnits = 0x8c29,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7
        /// </summary>
        FramebufferAttachmentLayered = 0x8da7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8
        /// </summary>
        FramebufferIncompleteLayerTargets = 0x8da8,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER = 0x8DD9
        /// </summary>
        GeometryShader = 0x8dd9,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF
        /// </summary>
        MaxGeometryUniformComponents = 0x8ddf,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0
        /// </summary>
        MaxGeometryOutputVertices = 0x8de0,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1
        /// </summary>
        MaxGeometryTotalOutputComponents = 0x8de1,

        /// <summary>
        /// Original was GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C
        /// </summary>
        QuadsFollowProvokingVertexConvention = 0x8e4c,

        /// <summary>
        /// Original was GL_FIRST_VERTEX_CONVENTION = 0x8E4D
        /// </summary>
        FirstVertexConvention = 0x8e4d,

        /// <summary>
        /// Original was GL_LAST_VERTEX_CONVENTION = 0x8E4E
        /// </summary>
        LastVertexConvention = 0x8e4e,

        /// <summary>
        /// Original was GL_PROVOKING_VERTEX = 0x8E4F
        /// </summary>
        ProvokingVertex = 0x8e4f,

        /// <summary>
        /// Original was GL_SAMPLE_POSITION = 0x8E50
        /// </summary>
        SamplePosition = 0x8e50,

        /// <summary>
        /// Original was GL_SAMPLE_MASK = 0x8E51
        /// </summary>
        SampleMask = 0x8e51,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_VALUE = 0x8E52
        /// </summary>
        SampleMaskValue = 0x8e52,

        /// <summary>
        /// Original was GL_MAX_SAMPLE_MASK_WORDS = 0x8E59
        /// </summary>
        MaxSampleMaskWords = 0x8e59,

        /// <summary>
        /// Original was GL_TEXTURE_2D_MULTISAMPLE = 0x9100
        /// </summary>
        Texture2DMultisample = 0x9100,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101
        /// </summary>
        ProxyTexture2DMultisample = 0x9101,

        /// <summary>
        /// Original was GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102
        /// </summary>
        Texture2DMultisampleArray = 0x9102,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103
        /// </summary>
        ProxyTexture2DMultisampleArray = 0x9103,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104
        /// </summary>
        TextureBinding2DMultisample = 0x9104,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105
        /// </summary>
        TextureBinding2DMultisampleArray = 0x9105,

        /// <summary>
        /// Original was GL_TEXTURE_SAMPLES = 0x9106
        /// </summary>
        TextureSamples = 0x9106,

        /// <summary>
        /// Original was GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107
        /// </summary>
        TextureFixedSampleLocations = 0x9107,

        /// <summary>
        /// Original was GL_SAMPLER_2D_MULTISAMPLE = 0x9108
        /// </summary>
        Sampler2DMultisample = 0x9108,

        /// <summary>
        /// Original was GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109
        /// </summary>
        IntSampler2DMultisample = 0x9109,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A
        /// </summary>
        UnsignedIntSampler2DMultisample = 0x910a,

        /// <summary>
        /// Original was GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B
        /// </summary>
        Sampler2DMultisampleArray = 0x910b,

        /// <summary>
        /// Original was GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C
        /// </summary>
        IntSampler2DMultisampleArray = 0x910c,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D
        /// </summary>
        UnsignedIntSampler2DMultisampleArray = 0x910d,

        /// <summary>
        /// Original was GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E
        /// </summary>
        MaxColorTextureSamples = 0x910e,

        /// <summary>
        /// Original was GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F
        /// </summary>
        MaxDepthTextureSamples = 0x910f,

        /// <summary>
        /// Original was GL_MAX_INTEGER_SAMPLES = 0x9110
        /// </summary>
        MaxIntegerSamples = 0x9110,

        /// <summary>
        /// Original was GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111
        /// </summary>
        MaxServerWaitTimeout = 0x9111,

        /// <summary>
        /// Original was GL_OBJECT_TYPE = 0x9112
        /// </summary>
        ObjectType = 0x9112,

        /// <summary>
        /// Original was GL_SYNC_CONDITION = 0x9113
        /// </summary>
        SyncCondition = 0x9113,

        /// <summary>
        /// Original was GL_SYNC_STATUS = 0x9114
        /// </summary>
        SyncStatus = 0x9114,

        /// <summary>
        /// Original was GL_SYNC_FLAGS = 0x9115
        /// </summary>
        SyncFlags = 0x9115,

        /// <summary>
        /// Original was GL_SYNC_FENCE = 0x9116
        /// </summary>
        SyncFence = 0x9116,

        /// <summary>
        /// Original was GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117
        /// </summary>
        SyncGpuCommandsComplete = 0x9117,

        /// <summary>
        /// Original was GL_UNSIGNALED = 0x9118
        /// </summary>
        Unsignaled = 0x9118,

        /// <summary>
        /// Original was GL_SIGNALED = 0x9119
        /// </summary>
        Signaled = 0x9119,

        /// <summary>
        /// Original was GL_ALREADY_SIGNALED = 0x911A
        /// </summary>
        AlreadySignaled = 0x911a,

        /// <summary>
        /// Original was GL_TIMEOUT_EXPIRED = 0x911B
        /// </summary>
        TimeoutExpired = 0x911b,

        /// <summary>
        /// Original was GL_CONDITION_SATISFIED = 0x911C
        /// </summary>
        ConditionSatisfied = 0x911c,

        /// <summary>
        /// Original was GL_WAIT_FAILED = 0x911D
        /// </summary>
        WaitFailed = 0x911d,

        /// <summary>
        /// Original was GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122
        /// </summary>
        MaxVertexOutputComponents = 0x9122,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123
        /// </summary>
        MaxGeometryInputComponents = 0x9123,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124
        /// </summary>
        MaxGeometryOutputComponents = 0x9124,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125
        /// </summary>
        MaxFragmentInputComponents = 0x9125,

        /// <summary>
        /// Original was GL_CONTEXT_PROFILE_MASK = 0x9126
        /// </summary>
        ContextProfileMask = 0x9126,

        /// <summary>
        /// Original was GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF
        /// </summary>
        TimeoutIgnored = unchecked((int)0xffffffffffffffff)
    }
}
