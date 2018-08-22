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

namespace OpenTK.Graphics.ES11
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AccumOp
    {
        /// <summary>
        /// Original was GL_ACCUM = 0x0100
        /// </summary>
        Accum = 0x0100,

        /// <summary>
        /// Original was GL_LOAD = 0x0101
        /// </summary>
        Load = 0x0101,

        /// <summary>
        /// Original was GL_RETURN = 0x0102
        /// </summary>
        Return = 0x0102,

        /// <summary>
        /// Original was GL_MULT = 0x0103
        /// </summary>
        Mult = 0x0103,

        /// <summary>
        /// Original was GL_ADD = 0x0104
        /// </summary>
        Add = 0x0104,
    }

    /// <summary>
    /// Used in GL.Apple.ClientWaitSync, GL.Apple.FenceSync and 179 other functions
    /// </summary>
    public enum All
    {
        /// <summary>
        /// Original was GL_FALSE = 0
        /// </summary>
        False = 0,

        /// <summary>
        /// Original was GL_LAYOUT_DEFAULT_INTEL = 0
        /// </summary>
        LayoutDefaultIntel = 0,

        /// <summary>
        /// Original was GL_NO_ERROR = 0
        /// </summary>
        NoError = 0,

        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Original was GL_NONE_OES = 0
        /// </summary>
        NoneOes = 0,

        /// <summary>
        /// Original was GL_ZERO = 0
        /// </summary>
        Zero = 0,

        /// <summary>
        /// Original was GL_Points = 0X0000
        /// </summary>
        Points = 0X0000,

        /// <summary>
        /// Original was GL_CLIENT_PIXEL_STORE_BIT = 0x00000001
        /// </summary>
        ClientPixelStoreBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT0_QCOM = 0x00000001
        /// </summary>
        ColorBufferBit0Qcom = ((int)0x00000001),

        /// <summary>
        /// Original was GL_CONTEXT_CORE_PROFILE_BIT = 0x00000001
        /// </summary>
        ContextCoreProfileBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001
        /// </summary>
        ContextFlagForwardCompatibleBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_CURRENT_BIT = 0x00000001
        /// </summary>
        CurrentBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD = 0x00000001
        /// </summary>
        QueryDepthPassEventBitAmd = ((int)0x00000001),

        /// <summary>
        /// Original was GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001
        /// </summary>
        SyncFlushCommandsBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001
        /// </summary>
        SyncFlushCommandsBitApple = ((int)0x00000001),

        /// <summary>
        /// Original was GL_TEXTURE_STORAGE_SPARSE_BIT_AMD = 0x00000001
        /// </summary>
        TextureStorageSparseBitAmd = ((int)0x00000001),

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001
        /// </summary>
        VertexAttribArrayBarrierBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT = 0x00000001
        /// </summary>
        VertexAttribArrayBarrierBitExt = ((int)0x00000001),

        /// <summary>
        /// Original was GL_VERTEX_SHADER_BIT = 0x00000001
        /// </summary>
        VertexShaderBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_VERTEX_SHADER_BIT_EXT = 0x00000001
        /// </summary>
        VertexShaderBitExt = ((int)0x00000001),

        /// <summary>
        /// Original was GL_CLIENT_VERTEX_ARRAY_BIT = 0x00000002
        /// </summary>
        ClientVertexArrayBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT1_QCOM = 0x00000002
        /// </summary>
        ColorBufferBit1Qcom = ((int)0x00000002),

        /// <summary>
        /// Original was GL_CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002
        /// </summary>
        ContextCompatibilityProfileBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002
        /// </summary>
        ContextFlagDebugBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_DEBUG_BIT_KHR = 0x00000002
        /// </summary>
        ContextFlagDebugBitKhr = ((int)0x00000002),

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BARRIER_BIT = 0x00000002
        /// </summary>
        ElementArrayBarrierBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BARRIER_BIT_EXT = 0x00000002
        /// </summary>
        ElementArrayBarrierBitExt = ((int)0x00000002),

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_BIT = 0x00000002
        /// </summary>
        FragmentShaderBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_BIT_EXT = 0x00000002
        /// </summary>
        FragmentShaderBitExt = ((int)0x00000002),

        /// <summary>
        /// Original was GL_POINT_BIT = 0x00000002
        /// </summary>
        PointBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD = 0x00000002
        /// </summary>
        QueryDepthFailEventBitAmd = ((int)0x00000002),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT2_QCOM = 0x00000004
        /// </summary>
        ColorBufferBit2Qcom = ((int)0x00000004),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004
        /// </summary>
        ContextFlagRobustAccessBit = ((int)0x00000004),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x00000004
        /// </summary>
        ContextFlagRobustAccessBitArb = ((int)0x00000004),

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_BIT = 0x00000004
        /// </summary>
        GeometryShaderBit = ((int)0x00000004),

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_BIT_EXT = 0x00000004
        /// </summary>
        GeometryShaderBitExt = ((int)0x00000004),

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_BIT_OES = 0x00000004
        /// </summary>
        GeometryShaderBitOes = ((int)0x00000004),

        /// <summary>
        /// Original was GL_LINE_BIT = 0x00000004
        /// </summary>
        LineBit = ((int)0x00000004),

        /// <summary>
        /// Original was GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD = 0x00000004
        /// </summary>
        QueryStencilFailEventBitAmd = ((int)0x00000004),

        /// <summary>
        /// Original was GL_UNIFORM_BARRIER_BIT = 0x00000004
        /// </summary>
        UniformBarrierBit = ((int)0x00000004),

        /// <summary>
        /// Original was GL_UNIFORM_BARRIER_BIT_EXT = 0x00000004
        /// </summary>
        UniformBarrierBitExt = ((int)0x00000004),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT3_QCOM = 0x00000008
        /// </summary>
        ColorBufferBit3Qcom = ((int)0x00000008),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_NO_ERROR_BIT = 0x00000008
        /// </summary>
        ContextFlagNoErrorBit = ((int)0x00000008),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR = 0x00000008
        /// </summary>
        ContextFlagNoErrorBitKhr = ((int)0x00000008),

        /// <summary>
        /// Original was GL_POLYGON_BIT = 0x00000008
        /// </summary>
        PolygonBit = ((int)0x00000008),

        /// <summary>
        /// Original was GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD = 0x00000008
        /// </summary>
        QueryDepthBoundsFailEventBitAmd = ((int)0x00000008),

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER_BIT = 0x00000008
        /// </summary>
        TessControlShaderBit = ((int)0x00000008),

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER_BIT_EXT = 0x00000008
        /// </summary>
        TessControlShaderBitExt = ((int)0x00000008),

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER_BIT_OES = 0x00000008
        /// </summary>
        TessControlShaderBitOes = ((int)0x00000008),

        /// <summary>
        /// Original was GL_TEXTURE_FETCH_BARRIER_BIT = 0x00000008
        /// </summary>
        TextureFetchBarrierBit = ((int)0x00000008),

        /// <summary>
        /// Original was GL_TEXTURE_FETCH_BARRIER_BIT_EXT = 0x00000008
        /// </summary>
        TextureFetchBarrierBitExt = ((int)0x00000008),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT4_QCOM = 0x00000010
        /// </summary>
        ColorBufferBit4Qcom = ((int)0x00000010),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT = 0x00000010
        /// </summary>
        ContextFlagProtectedContentBitExt = ((int)0x00000010),

        /// <summary>
        /// Original was GL_POLYGON_STIPPLE_BIT = 0x00000010
        /// </summary>
        PolygonStippleBit = ((int)0x00000010),

        /// <summary>
        /// Original was GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV = 0x00000010
        /// </summary>
        ShaderGlobalAccessBarrierBitNv = ((int)0x00000010),

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER_BIT = 0x00000010
        /// </summary>
        TessEvaluationShaderBit = ((int)0x00000010),

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER_BIT_EXT = 0x00000010
        /// </summary>
        TessEvaluationShaderBitExt = ((int)0x00000010),

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER_BIT_OES = 0x00000010
        /// </summary>
        TessEvaluationShaderBitOes = ((int)0x00000010),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT5_QCOM = 0x00000020
        /// </summary>
        ColorBufferBit5Qcom = ((int)0x00000020),

        /// <summary>
        /// Original was GL_COMPUTE_SHADER_BIT = 0x00000020
        /// </summary>
        ComputeShaderBit = ((int)0x00000020),

        /// <summary>
        /// Original was GL_PIXEL_MODE_BIT = 0x00000020
        /// </summary>
        PixelModeBit = ((int)0x00000020),

        /// <summary>
        /// Original was GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020
        /// </summary>
        ShaderImageAccessBarrierBit = ((int)0x00000020),

        /// <summary>
        /// Original was GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT = 0x00000020
        /// </summary>
        ShaderImageAccessBarrierBitExt = ((int)0x00000020),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT6_QCOM = 0x00000040
        /// </summary>
        ColorBufferBit6Qcom = ((int)0x00000040),

        /// <summary>
        /// Original was GL_COMMAND_BARRIER_BIT = 0x00000040
        /// </summary>
        CommandBarrierBit = ((int)0x00000040),

        /// <summary>
        /// Original was GL_COMMAND_BARRIER_BIT_EXT = 0x00000040
        /// </summary>
        CommandBarrierBitExt = ((int)0x00000040),

        /// <summary>
        /// Original was GL_LIGHTING_BIT = 0x00000040
        /// </summary>
        LightingBit = ((int)0x00000040),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT7_QCOM = 0x00000080
        /// </summary>
        ColorBufferBit7Qcom = ((int)0x00000080),

        /// <summary>
        /// Original was GL_FOG_BIT = 0x00000080
        /// </summary>
        FogBit = ((int)0x00000080),

        /// <summary>
        /// Original was GL_PIXEL_BUFFER_BARRIER_BIT = 0x00000080
        /// </summary>
        PixelBufferBarrierBit = ((int)0x00000080),

        /// <summary>
        /// Original was GL_PIXEL_BUFFER_BARRIER_BIT_EXT = 0x00000080
        /// </summary>
        PixelBufferBarrierBitExt = ((int)0x00000080),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT = 0x00000100
        /// </summary>
        DepthBufferBit = ((int)0x00000100),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT0_QCOM = 0x00000100
        /// </summary>
        DepthBufferBit0Qcom = ((int)0x00000100),

        /// <summary>
        /// Original was GL_TEXTURE_UPDATE_BARRIER_BIT = 0x00000100
        /// </summary>
        TextureUpdateBarrierBit = ((int)0x00000100),

        /// <summary>
        /// Original was GL_TEXTURE_UPDATE_BARRIER_BIT_EXT = 0x00000100
        /// </summary>
        TextureUpdateBarrierBitExt = ((int)0x00000100),

        /// <summary>
        /// Original was GL_ACCUM_BUFFER_BIT = 0x00000200
        /// </summary>
        AccumBufferBit = ((int)0x00000200),

        /// <summary>
        /// Original was GL_BUFFER_UPDATE_BARRIER_BIT = 0x00000200
        /// </summary>
        BufferUpdateBarrierBit = ((int)0x00000200),

        /// <summary>
        /// Original was GL_BUFFER_UPDATE_BARRIER_BIT_EXT = 0x00000200
        /// </summary>
        BufferUpdateBarrierBitExt = ((int)0x00000200),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT1_QCOM = 0x00000200
        /// </summary>
        DepthBufferBit1Qcom = ((int)0x00000200),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT2_QCOM = 0x00000400
        /// </summary>
        DepthBufferBit2Qcom = ((int)0x00000400),

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BARRIER_BIT = 0x00000400
        /// </summary>
        FramebufferBarrierBit = ((int)0x00000400),

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BARRIER_BIT_EXT = 0x00000400
        /// </summary>
        FramebufferBarrierBitExt = ((int)0x00000400),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT = 0x00000400
        /// </summary>
        StencilBufferBit = ((int)0x00000400),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT3_QCOM = 0x00000800
        /// </summary>
        DepthBufferBit3Qcom = ((int)0x00000800),

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800
        /// </summary>
        TransformFeedbackBarrierBit = ((int)0x00000800),

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT = 0x00000800
        /// </summary>
        TransformFeedbackBarrierBitExt = ((int)0x00000800),

        /// <summary>
        /// Original was GL_VIEWPORT_BIT = 0x00000800
        /// </summary>
        ViewportBit = ((int)0x00000800),

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BARRIER_BIT = 0x00001000
        /// </summary>
        AtomicCounterBarrierBit = ((int)0x00001000),

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BARRIER_BIT_EXT = 0x00001000
        /// </summary>
        AtomicCounterBarrierBitExt = ((int)0x00001000),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT4_QCOM = 0x00001000
        /// </summary>
        DepthBufferBit4Qcom = ((int)0x00001000),

        /// <summary>
        /// Original was GL_TRANSFORM_BIT = 0x00001000
        /// </summary>
        TransformBit = ((int)0x00001000),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT5_QCOM = 0x00002000
        /// </summary>
        DepthBufferBit5Qcom = ((int)0x00002000),

        /// <summary>
        /// Original was GL_ENABLE_BIT = 0x00002000
        /// </summary>
        EnableBit = ((int)0x00002000),

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000
        /// </summary>
        ShaderStorageBarrierBit = ((int)0x00002000),

        /// <summary>
        /// Original was GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000
        /// </summary>
        ClientMappedBufferBarrierBit = ((int)0x00004000),

        /// <summary>
        /// Original was GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT = 0x00004000
        /// </summary>
        ClientMappedBufferBarrierBitExt = ((int)0x00004000),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT = 0x00004000
        /// </summary>
        ColorBufferBit = ((int)0x00004000),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT6_QCOM = 0x00004000
        /// </summary>
        DepthBufferBit6Qcom = ((int)0x00004000),

        /// <summary>
        /// Original was GL_COVERAGE_BUFFER_BIT_NV = 0x00008000
        /// </summary>
        CoverageBufferBitNv = ((int)0x00008000),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT7_QCOM = 0x00008000
        /// </summary>
        DepthBufferBit7Qcom = ((int)0x00008000),

        /// <summary>
        /// Original was GL_HINT_BIT = 0x00008000
        /// </summary>
        HintBit = ((int)0x00008000),

        /// <summary>
        /// Original was GL_QUERY_BUFFER_BARRIER_BIT = 0x00008000
        /// </summary>
        QueryBufferBarrierBit = ((int)0x00008000),

        /// <summary>
        /// Original was GL_MAP_READ_BIT = 0x0001
        /// </summary>
        MapReadBit = 0x0001,

        /// <summary>
        /// Original was GL_MAP_READ_BIT_EXT = 0x0001
        /// </summary>
        MapReadBitExt = 0x0001,

        /// <summary>
        /// Original was GL_Lines = 0X0001
        /// </summary>
        Lines = 0X0001,

        /// <summary>
        /// Original was GL_EVAL_BIT = 0x00010000
        /// </summary>
        EvalBit = ((int)0x00010000),

        /// <summary>
        /// Original was GL_FONT_X_MIN_BOUNDS_BIT_NV = 0x00010000
        /// </summary>
        FontXMinBoundsBitNv = ((int)0x00010000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT0_QCOM = 0x00010000
        /// </summary>
        StencilBufferBit0Qcom = ((int)0x00010000),

        /// <summary>
        /// Original was GL_LINE_LOOP = 0x0002
        /// </summary>
        LineLoop = 0x0002,

        /// <summary>
        /// Original was GL_MAP_WRITE_BIT = 0x0002
        /// </summary>
        MapWriteBit = 0x0002,

        /// <summary>
        /// Original was GL_MAP_WRITE_BIT_EXT = 0x0002
        /// </summary>
        MapWriteBitExt = 0x0002,

        /// <summary>
        /// Original was GL_FONT_Y_MIN_BOUNDS_BIT_NV = 0x00020000
        /// </summary>
        FontYMinBoundsBitNv = ((int)0x00020000),

        /// <summary>
        /// Original was GL_LIST_BIT = 0x00020000
        /// </summary>
        ListBit = ((int)0x00020000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT1_QCOM = 0x00020000
        /// </summary>
        StencilBufferBit1Qcom = ((int)0x00020000),

        /// <summary>
        /// Original was GL_LINE_STRIP = 0x0003
        /// </summary>
        LineStrip = 0x0003,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT = 0x0004
        /// </summary>
        MapInvalidateRangeBit = 0x0004,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004
        /// </summary>
        MapInvalidateRangeBitExt = 0x0004,

        /// <summary>
        /// Original was GL_Triangles = 0X0004
        /// </summary>
        Triangles = 0X0004,

        /// <summary>
        /// Original was GL_FONT_X_MAX_BOUNDS_BIT_NV = 0x00040000
        /// </summary>
        FontXMaxBoundsBitNv = ((int)0x00040000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT2_QCOM = 0x00040000
        /// </summary>
        StencilBufferBit2Qcom = ((int)0x00040000),

        /// <summary>
        /// Original was GL_TEXTURE_BIT = 0x00040000
        /// </summary>
        TextureBit = ((int)0x00040000),

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP = 0x0005
        /// </summary>
        TriangleStrip = 0x0005,

        /// <summary>
        /// Original was GL_TRIANGLE_FAN = 0x0006
        /// </summary>
        TriangleFan = 0x0006,

        /// <summary>
        /// Original was GL_QUADS = 0x0007
        /// </summary>
        Quads = 0x0007,

        /// <summary>
        /// Original was GL_QUADS_EXT = 0x0007
        /// </summary>
        QuadsExt = 0x0007,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008
        /// </summary>
        MapInvalidateBufferBit = 0x0008,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008
        /// </summary>
        MapInvalidateBufferBitExt = 0x0008,

        /// <summary>
        /// Original was GL_QUAD_STRIP = 0x0008
        /// </summary>
        QuadStrip = 0x0008,

        /// <summary>
        /// Original was GL_FONT_Y_MAX_BOUNDS_BIT_NV = 0x00080000
        /// </summary>
        FontYMaxBoundsBitNv = ((int)0x00080000),

        /// <summary>
        /// Original was GL_SCISSOR_BIT = 0x00080000
        /// </summary>
        ScissorBit = ((int)0x00080000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT3_QCOM = 0x00080000
        /// </summary>
        StencilBufferBit3Qcom = ((int)0x00080000),

        /// <summary>
        /// Original was GL_POLYGON = 0x0009
        /// </summary>
        Polygon = 0x0009,

        /// <summary>
        /// Original was GL_LINES_ADJACENCY = 0x000A
        /// </summary>
        LinesAdjacency = 0x000a,

        /// <summary>
        /// Original was GL_LINES_ADJACENCY_ARB = 0x000A
        /// </summary>
        LinesAdjacencyArb = 0x000a,

        /// <summary>
        /// Original was GL_LINES_ADJACENCY_EXT = 0x000A
        /// </summary>
        LinesAdjacencyExt = 0x000a,

        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY = 0x000B
        /// </summary>
        LineStripAdjacency = 0x000b,

        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY_ARB = 0x000B
        /// </summary>
        LineStripAdjacencyArb = 0x000b,

        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY_EXT = 0x000B
        /// </summary>
        LineStripAdjacencyExt = 0x000b,

        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY = 0x000C
        /// </summary>
        TrianglesAdjacency = 0x000c,

        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY_ARB = 0x000C
        /// </summary>
        TrianglesAdjacencyArb = 0x000c,

        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY_EXT = 0x000C
        /// </summary>
        TrianglesAdjacencyExt = 0x000c,

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY = 0x000D
        /// </summary>
        TriangleStripAdjacency = 0x000d,

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D
        /// </summary>
        TriangleStripAdjacencyArb = 0x000d,

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D
        /// </summary>
        TriangleStripAdjacencyExt = 0x000d,

        /// <summary>
        /// Original was GL_PATCHES = 0x000E
        /// </summary>
        Patches = 0x000e,

        /// <summary>
        /// Original was GL_PATCHES_EXT = 0x000E
        /// </summary>
        PatchesExt = 0x000e,

        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010
        /// </summary>
        MapFlushExplicitBit = 0x0010,

        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010
        /// </summary>
        MapFlushExplicitBitExt = 0x0010,

        /// <summary>
        /// Original was GL_FONT_UNITS_PER_EM_BIT_NV = 0x00100000
        /// </summary>
        FontUnitsPerEmBitNv = ((int)0x00100000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT4_QCOM = 0x00100000
        /// </summary>
        StencilBufferBit4Qcom = ((int)0x00100000),

        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT = 0x0020
        /// </summary>
        MapUnsynchronizedBit = 0x0020,

        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020
        /// </summary>
        MapUnsynchronizedBitExt = 0x0020,

        /// <summary>
        /// Original was GL_FONT_ASCENDER_BIT_NV = 0x00200000
        /// </summary>
        FontAscenderBitNv = ((int)0x00200000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT5_QCOM = 0x00200000
        /// </summary>
        StencilBufferBit5Qcom = ((int)0x00200000),

        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT = 0x0040
        /// </summary>
        MapPersistentBit = 0x0040,

        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT_EXT = 0x0040
        /// </summary>
        MapPersistentBitExt = 0x0040,

        /// <summary>
        /// Original was GL_FONT_DESCENDER_BIT_NV = 0x00400000
        /// </summary>
        FontDescenderBitNv = ((int)0x00400000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT6_QCOM = 0x00400000
        /// </summary>
        StencilBufferBit6Qcom = ((int)0x00400000),

        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT = 0x0080
        /// </summary>
        MapCoherentBit = 0x0080,

        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT_EXT = 0x0080
        /// </summary>
        MapCoherentBitExt = 0x0080,

        /// <summary>
        /// Original was GL_FONT_HEIGHT_BIT_NV = 0x00800000
        /// </summary>
        FontHeightBitNv = ((int)0x00800000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT7_QCOM = 0x00800000
        /// </summary>
        StencilBufferBit7Qcom = ((int)0x00800000),

        /// <summary>
        /// Original was GL_BOLD_BIT_NV = 0x01
        /// </summary>
        BoldBitNv = 0x01,

        /// <summary>
        /// Original was GL_GLYPH_WIDTH_BIT_NV = 0x01
        /// </summary>
        GlyphWidthBitNv = 0x01,

        /// <summary>
        /// Original was GL_ACCUM = 0x0100
        /// </summary>
        Accum = 0x0100,

        /// <summary>
        /// Original was GL_DYNAMIC_STORAGE_BIT = 0x0100
        /// </summary>
        DynamicStorageBit = 0x0100,

        /// <summary>
        /// Original was GL_DYNAMIC_STORAGE_BIT_EXT = 0x0100
        /// </summary>
        DynamicStorageBitExt = 0x0100,

        /// <summary>
        /// Original was GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV = 0x01000000
        /// </summary>
        FontMaxAdvanceWidthBitNv = ((int)0x01000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT0_QCOM = 0x01000000
        /// </summary>
        MultisampleBufferBit0Qcom = ((int)0x01000000),

        /// <summary>
        /// Original was GL_LOAD = 0x0101
        /// </summary>
        Load = 0x0101,

        /// <summary>
        /// Original was GL_RETURN = 0x0102
        /// </summary>
        Return = 0x0102,

        /// <summary>
        /// Original was GL_MULT = 0x0103
        /// </summary>
        Mult = 0x0103,

        /// <summary>
        /// Original was GL_ADD = 0x0104
        /// </summary>
        Add = 0x0104,

        /// <summary>
        /// Original was GL_GLYPH_HEIGHT_BIT_NV = 0x02
        /// </summary>
        GlyphHeightBitNv = 0x02,

        /// <summary>
        /// Original was GL_ITALIC_BIT_NV = 0x02
        /// </summary>
        ItalicBitNv = 0x02,

        /// <summary>
        /// Original was GL_CLIENT_STORAGE_BIT = 0x0200
        /// </summary>
        ClientStorageBit = 0x0200,

        /// <summary>
        /// Original was GL_CLIENT_STORAGE_BIT_EXT = 0x0200
        /// </summary>
        ClientStorageBitExt = 0x0200,

        /// <summary>
        /// Original was GL_NEVER = 0x0200
        /// </summary>
        Never = 0x0200,

        /// <summary>
        /// Original was GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV = 0x02000000
        /// </summary>
        FontMaxAdvanceHeightBitNv = ((int)0x02000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT1_QCOM = 0x02000000
        /// </summary>
        MultisampleBufferBit1Qcom = ((int)0x02000000),

        /// <summary>
        /// Original was GL_LESS = 0x0201
        /// </summary>
        Less = 0x0201,

        /// <summary>
        /// Original was GL_EQUAL = 0x0202
        /// </summary>
        Equal = 0x0202,

        /// <summary>
        /// Original was GL_LEQUAL = 0x0203
        /// </summary>
        Lequal = 0x0203,

        /// <summary>
        /// Original was GL_GREATER = 0x0204
        /// </summary>
        Greater = 0x0204,

        /// <summary>
        /// Original was GL_NOTEQUAL = 0x0205
        /// </summary>
        Notequal = 0x0205,

        /// <summary>
        /// Original was GL_GEQUAL = 0x0206
        /// </summary>
        Gequal = 0x0206,

        /// <summary>
        /// Original was GL_ALWAYS = 0x0207
        /// </summary>
        Always = 0x0207,

        /// <summary>
        /// Original was GL_SRC_COLOR = 0x0300
        /// </summary>
        SrcColor = 0x0300,

        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_COLOR = 0x0301
        /// </summary>
        OneMinusSrcColor = 0x0301,

        /// <summary>
        /// Original was GL_SRC_ALPHA = 0x0302
        /// </summary>
        SrcAlpha = 0x0302,

        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_ALPHA = 0x0303
        /// </summary>
        OneMinusSrcAlpha = 0x0303,

        /// <summary>
        /// Original was GL_DST_ALPHA = 0x0304
        /// </summary>
        DstAlpha = 0x0304,

        /// <summary>
        /// Original was GL_ONE_MINUS_DST_ALPHA = 0x0305
        /// </summary>
        OneMinusDstAlpha = 0x0305,

        /// <summary>
        /// Original was GL_DST_COLOR = 0x0306
        /// </summary>
        DstColor = 0x0306,

        /// <summary>
        /// Original was GL_ONE_MINUS_DST_COLOR = 0x0307
        /// </summary>
        OneMinusDstColor = 0x0307,

        /// <summary>
        /// Original was GL_SRC_ALPHA_SATURATE = 0x0308
        /// </summary>
        SrcAlphaSaturate = 0x0308,

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04
        /// </summary>
        GlyphHorizontalBearingXBitNv = 0x04,

        /// <summary>
        /// Original was GL_FRONT_LEFT = 0x0400
        /// </summary>
        FrontLeft = 0x0400,

        /// <summary>
        /// Original was GL_SPARSE_STORAGE_BIT_ARB = 0x0400
        /// </summary>
        SparseStorageBitArb = 0x0400,

        /// <summary>
        /// Original was GL_FONT_UNDERLINE_POSITION_BIT_NV = 0x04000000
        /// </summary>
        FontUnderlinePositionBitNv = ((int)0x04000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT2_QCOM = 0x04000000
        /// </summary>
        MultisampleBufferBit2Qcom = ((int)0x04000000),

        /// <summary>
        /// Original was GL_FRONT_RIGHT = 0x0401
        /// </summary>
        FrontRight = 0x0401,

        /// <summary>
        /// Original was GL_BACK_LEFT = 0x0402
        /// </summary>
        BackLeft = 0x0402,

        /// <summary>
        /// Original was GL_BACK_RIGHT = 0x0403
        /// </summary>
        BackRight = 0x0403,

        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = 0x0404,

        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = 0x0405,

        /// <summary>
        /// Original was GL_LEFT = 0x0406
        /// </summary>
        Left = 0x0406,

        /// <summary>
        /// Original was GL_RIGHT = 0x0407
        /// </summary>
        Right = 0x0407,

        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = 0x0408,

        /// <summary>
        /// Original was GL_AUX0 = 0x0409
        /// </summary>
        Aux0 = 0x0409,

        /// <summary>
        /// Original was GL_AUX1 = 0x040A
        /// </summary>
        Aux1 = 0x040a,

        /// <summary>
        /// Original was GL_AUX2 = 0x040B
        /// </summary>
        Aux2 = 0x040b,

        /// <summary>
        /// Original was GL_AUX3 = 0x040C
        /// </summary>
        Aux3 = 0x040c,

        /// <summary>
        /// Original was GL_INVALID_ENUM = 0x0500
        /// </summary>
        InvalidEnum = 0x0500,

        /// <summary>
        /// Original was GL_INVALID_VALUE = 0x0501
        /// </summary>
        InvalidValue = 0x0501,

        /// <summary>
        /// Original was GL_INVALID_OPERATION = 0x0502
        /// </summary>
        InvalidOperation = 0x0502,

        /// <summary>
        /// Original was GL_STACK_OVERFLOW = 0x0503
        /// </summary>
        StackOverflow = 0x0503,

        /// <summary>
        /// Original was GL_STACK_OVERFLOW_KHR = 0x0503
        /// </summary>
        StackOverflowKhr = 0x0503,

        /// <summary>
        /// Original was GL_STACK_UNDERFLOW = 0x0504
        /// </summary>
        StackUnderflow = 0x0504,

        /// <summary>
        /// Original was GL_STACK_UNDERFLOW_KHR = 0x0504
        /// </summary>
        StackUnderflowKhr = 0x0504,

        /// <summary>
        /// Original was GL_OUT_OF_MEMORY = 0x0505
        /// </summary>
        OutOfMemory = 0x0505,

        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506
        /// </summary>
        InvalidFramebufferOperation = 0x0506,

        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506
        /// </summary>
        InvalidFramebufferOperationExt = 0x0506,

        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506
        /// </summary>
        InvalidFramebufferOperationOes = 0x0506,

        /// <summary>
        /// Original was GL_2D = 0x0600
        /// </summary>
        Gl2D = 0x0600,

        /// <summary>
        /// Original was GL_3D = 0x0601
        /// </summary>
        Gl3D = 0x0601,

        /// <summary>
        /// Original was GL_3D_COLOR = 0x0602
        /// </summary>
        Gl3DColor = 0x0602,

        /// <summary>
        /// Original was GL_3D_COLOR_TEXTURE = 0x0603
        /// </summary>
        Gl3DColorTexture = 0x0603,

        /// <summary>
        /// Original was GL_4D_COLOR_TEXTURE = 0x0604
        /// </summary>
        Gl4DColorTexture = 0x0604,

        /// <summary>
        /// Original was GL_PASS_THROUGH_TOKEN = 0x0700
        /// </summary>
        PassThroughToken = 0x0700,

        /// <summary>
        /// Original was GL_POINT_TOKEN = 0x0701
        /// </summary>
        PointToken = 0x0701,

        /// <summary>
        /// Original was GL_LINE_TOKEN = 0x0702
        /// </summary>
        LineToken = 0x0702,

        /// <summary>
        /// Original was GL_POLYGON_TOKEN = 0x0703
        /// </summary>
        PolygonToken = 0x0703,

        /// <summary>
        /// Original was GL_BITMAP_TOKEN = 0x0704
        /// </summary>
        BitmapToken = 0x0704,

        /// <summary>
        /// Original was GL_DRAW_PIXEL_TOKEN = 0x0705
        /// </summary>
        DrawPixelToken = 0x0705,

        /// <summary>
        /// Original was GL_COPY_PIXEL_TOKEN = 0x0706
        /// </summary>
        CopyPixelToken = 0x0706,

        /// <summary>
        /// Original was GL_LINE_RESET_TOKEN = 0x0707
        /// </summary>
        LineResetToken = 0x0707,

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08
        /// </summary>
        GlyphHorizontalBearingYBitNv = 0x08,

        /// <summary>
        /// Original was GL_EXP = 0x0800
        /// </summary>
        Exp = 0x0800,

        /// <summary>
        /// Original was GL_LGPU_SEPARATE_STORAGE_BIT_NVX = 0x0800
        /// </summary>
        LgpuSeparateStorageBitNvx = 0x0800,

        /// <summary>
        /// Original was GL_PER_GPU_STORAGE_BIT_NV = 0x0800
        /// </summary>
        PerGpuStorageBitNv = 0x0800,

        /// <summary>
        /// Original was GL_FONT_UNDERLINE_THICKNESS_BIT_NV = 0x08000000
        /// </summary>
        FontUnderlineThicknessBitNv = ((int)0x08000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT3_QCOM = 0x08000000
        /// </summary>
        MultisampleBufferBit3Qcom = ((int)0x08000000),

        /// <summary>
        /// Original was GL_EXP2 = 0x0801
        /// </summary>
        Exp2 = 0x0801,

        /// <summary>
        /// Original was GL_CW = 0x0900
        /// </summary>
        Cw = 0x0900,

        /// <summary>
        /// Original was GL_CCW = 0x0901
        /// </summary>
        Ccw = 0x0901,

        /// <summary>
        /// Original was GL_COEFF = 0x0A00
        /// </summary>
        Coeff = 0x0a00,

        /// <summary>
        /// Original was GL_ORDER = 0x0A01
        /// </summary>
        Order = 0x0a01,

        /// <summary>
        /// Original was GL_DOMAIN = 0x0A02
        /// </summary>
        Domain = 0x0a02,

        /// <summary>
        /// Original was GL_CURRENT_COLOR = 0x0B00
        /// </summary>
        CurrentColor = 0x0b00,

        /// <summary>
        /// Original was GL_CURRENT_INDEX = 0x0B01
        /// </summary>
        CurrentIndex = 0x0b01,

        /// <summary>
        /// Original was GL_CURRENT_NORMAL = 0x0B02
        /// </summary>
        CurrentNormal = 0x0b02,

        /// <summary>
        /// Original was GL_CURRENT_TEXTURE_COORDS = 0x0B03
        /// </summary>
        CurrentTextureCoords = 0x0b03,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_COLOR = 0x0B04
        /// </summary>
        CurrentRasterColor = 0x0b04,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_INDEX = 0x0B05
        /// </summary>
        CurrentRasterIndex = 0x0b05,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06
        /// </summary>
        CurrentRasterTextureCoords = 0x0b06,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_POSITION = 0x0B07
        /// </summary>
        CurrentRasterPosition = 0x0b07,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_POSITION_VALID = 0x0B08
        /// </summary>
        CurrentRasterPositionValid = 0x0b08,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_DISTANCE = 0x0B09
        /// </summary>
        CurrentRasterDistance = 0x0b09,

        /// <summary>
        /// Original was GL_POINT_SMOOTH = 0x0B10
        /// </summary>
        PointSmooth = 0x0b10,

        /// <summary>
        /// Original was GL_POINT_SIZE = 0x0B11
        /// </summary>
        PointSize = 0x0b11,

        /// <summary>
        /// Original was GL_POINT_SIZE_RANGE = 0x0B12
        /// </summary>
        PointSizeRange = 0x0b12,

        /// <summary>
        /// Original was GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12
        /// </summary>
        SmoothPointSizeRange = 0x0b12,

        /// <summary>
        /// Original was GL_POINT_SIZE_GRANULARITY = 0x0B13
        /// </summary>
        PointSizeGranularity = 0x0b13,

        /// <summary>
        /// Original was GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13
        /// </summary>
        SmoothPointSizeGranularity = 0x0b13,

        /// <summary>
        /// Original was GL_LINE_SMOOTH = 0x0B20
        /// </summary>
        LineSmooth = 0x0b20,

        /// <summary>
        /// Original was GL_LINE_WIDTH = 0x0B21
        /// </summary>
        LineWidth = 0x0b21,

        /// <summary>
        /// Original was GL_LINE_WIDTH_RANGE = 0x0B22
        /// </summary>
        LineWidthRange = 0x0b22,

        /// <summary>
        /// Original was GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22
        /// </summary>
        SmoothLineWidthRange = 0x0b22,

        /// <summary>
        /// Original was GL_LINE_WIDTH_GRANULARITY = 0x0B23
        /// </summary>
        LineWidthGranularity = 0x0b23,

        /// <summary>
        /// Original was GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23
        /// </summary>
        SmoothLineWidthGranularity = 0x0b23,

        /// <summary>
        /// Original was GL_LINE_STIPPLE = 0x0B24
        /// </summary>
        LineStipple = 0x0b24,

        /// <summary>
        /// Original was GL_LINE_STIPPLE_PATTERN = 0x0B25
        /// </summary>
        LineStipplePattern = 0x0b25,

        /// <summary>
        /// Original was GL_LINE_STIPPLE_REPEAT = 0x0B26
        /// </summary>
        LineStippleRepeat = 0x0b26,

        /// <summary>
        /// Original was GL_LIST_MODE = 0x0B30
        /// </summary>
        ListMode = 0x0b30,

        /// <summary>
        /// Original was GL_MAX_LIST_NESTING = 0x0B31
        /// </summary>
        MaxListNesting = 0x0b31,

        /// <summary>
        /// Original was GL_LIST_BASE = 0x0B32
        /// </summary>
        ListBase = 0x0b32,

        /// <summary>
        /// Original was GL_LIST_INDEX = 0x0B33
        /// </summary>
        ListIndex = 0x0b33,

        /// <summary>
        /// Original was GL_POLYGON_MODE = 0x0B40
        /// </summary>
        PolygonMode = 0x0b40,

        /// <summary>
        /// Original was GL_POLYGON_SMOOTH = 0x0B41
        /// </summary>
        PolygonSmooth = 0x0b41,

        /// <summary>
        /// Original was GL_POLYGON_STIPPLE = 0x0B42
        /// </summary>
        PolygonStipple = 0x0b42,

        /// <summary>
        /// Original was GL_EDGE_FLAG = 0x0B43
        /// </summary>
        EdgeFlag = 0x0b43,

        /// <summary>
        /// Original was GL_CULL_FACE = 0x0B44
        /// </summary>
        CullFace = 0x0b44,

        /// <summary>
        /// Original was GL_CULL_FACE_MODE = 0x0B45
        /// </summary>
        CullFaceMode = 0x0b45,

        /// <summary>
        /// Original was GL_FRONT_FACE = 0x0B46
        /// </summary>
        FrontFace = 0x0b46,

        /// <summary>
        /// Original was GL_LIGHTING = 0x0B50
        /// </summary>
        Lighting = 0x0b50,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51
        /// </summary>
        LightModelLocalViewer = 0x0b51,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_TWO_SIDE = 0x0B52
        /// </summary>
        LightModelTwoSide = 0x0b52,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_AMBIENT = 0x0B53
        /// </summary>
        LightModelAmbient = 0x0b53,

        /// <summary>
        /// Original was GL_SHADE_MODEL = 0x0B54
        /// </summary>
        ShadeModel = 0x0b54,

        /// <summary>
        /// Original was GL_COLOR_MATERIAL_FACE = 0x0B55
        /// </summary>
        ColorMaterialFace = 0x0b55,

        /// <summary>
        /// Original was GL_COLOR_MATERIAL_PARAMETER = 0x0B56
        /// </summary>
        ColorMaterialParameter = 0x0b56,

        /// <summary>
        /// Original was GL_COLOR_MATERIAL = 0x0B57
        /// </summary>
        ColorMaterial = 0x0b57,

        /// <summary>
        /// Original was GL_FOG = 0x0B60
        /// </summary>
        Fog = 0x0b60,

        /// <summary>
        /// Original was GL_FOG_INDEX = 0x0B61
        /// </summary>
        FogIndex = 0x0b61,

        /// <summary>
        /// Original was GL_FOG_DENSITY = 0x0B62
        /// </summary>
        FogDensity = 0x0b62,

        /// <summary>
        /// Original was GL_FOG_START = 0x0B63
        /// </summary>
        FogStart = 0x0b63,

        /// <summary>
        /// Original was GL_FOG_END = 0x0B64
        /// </summary>
        FogEnd = 0x0b64,

        /// <summary>
        /// Original was GL_FOG_MODE = 0x0B65
        /// </summary>
        FogMode = 0x0b65,

        /// <summary>
        /// Original was GL_FOG_COLOR = 0x0B66
        /// </summary>
        FogColor = 0x0b66,

        /// <summary>
        /// Original was GL_DEPTH_RANGE = 0x0B70
        /// </summary>
        DepthRange = 0x0b70,

        /// <summary>
        /// Original was GL_DEPTH_TEST = 0x0B71
        /// </summary>
        DepthTest = 0x0b71,

        /// <summary>
        /// Original was GL_DEPTH_WRITEMASK = 0x0B72
        /// </summary>
        DepthWritemask = 0x0b72,

        /// <summary>
        /// Original was GL_DEPTH_CLEAR_VALUE = 0x0B73
        /// </summary>
        DepthClearValue = 0x0b73,

        /// <summary>
        /// Original was GL_DEPTH_FUNC = 0x0B74
        /// </summary>
        DepthFunc = 0x0b74,

        /// <summary>
        /// Original was GL_ACCUM_CLEAR_VALUE = 0x0B80
        /// </summary>
        AccumClearValue = 0x0b80,

        /// <summary>
        /// Original was GL_STENCIL_TEST = 0x0B90
        /// </summary>
        StencilTest = 0x0b90,

        /// <summary>
        /// Original was GL_STENCIL_CLEAR_VALUE = 0x0B91
        /// </summary>
        StencilClearValue = 0x0b91,

        /// <summary>
        /// Original was GL_STENCIL_FUNC = 0x0B92
        /// </summary>
        StencilFunc = 0x0b92,

        /// <summary>
        /// Original was GL_STENCIL_VALUE_MASK = 0x0B93
        /// </summary>
        StencilValueMask = 0x0b93,

        /// <summary>
        /// Original was GL_STENCIL_FAIL = 0x0B94
        /// </summary>
        StencilFail = 0x0b94,

        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95
        /// </summary>
        StencilPassDepthFail = 0x0b95,

        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_PASS = 0x0B96
        /// </summary>
        StencilPassDepthPass = 0x0b96,

        /// <summary>
        /// Original was GL_STENCIL_REF = 0x0B97
        /// </summary>
        StencilRef = 0x0b97,

        /// <summary>
        /// Original was GL_STENCIL_WRITEMASK = 0x0B98
        /// </summary>
        StencilWritemask = 0x0b98,

        /// <summary>
        /// Original was GL_MATRIX_MODE = 0x0BA0
        /// </summary>
        MatrixMode = 0x0ba0,

        /// <summary>
        /// Original was GL_NORMALIZE = 0x0BA1
        /// </summary>
        Normalize = 0x0ba1,

        /// <summary>
        /// Original was GL_VIEWPORT = 0x0BA2
        /// </summary>
        Viewport = 0x0ba2,

        /// <summary>
        /// Original was GL_MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3
        /// </summary>
        Modelview0StackDepthExt = 0x0ba3,

        /// <summary>
        /// Original was GL_MODELVIEW_STACK_DEPTH = 0x0BA3
        /// </summary>
        ModelviewStackDepth = 0x0ba3,

        /// <summary>
        /// Original was GL_PROJECTION_STACK_DEPTH = 0x0BA4
        /// </summary>
        ProjectionStackDepth = 0x0ba4,

        /// <summary>
        /// Original was GL_TEXTURE_STACK_DEPTH = 0x0BA5
        /// </summary>
        TextureStackDepth = 0x0ba5,

        /// <summary>
        /// Original was GL_MODELVIEW0_MATRIX_EXT = 0x0BA6
        /// </summary>
        Modelview0MatrixExt = 0x0ba6,

        /// <summary>
        /// Original was GL_MODELVIEW_MATRIX = 0x0BA6
        /// </summary>
        ModelviewMatrix = 0x0ba6,

        /// <summary>
        /// Original was GL_PROJECTION_MATRIX = 0x0BA7
        /// </summary>
        ProjectionMatrix = 0x0ba7,

        /// <summary>
        /// Original was GL_TEXTURE_MATRIX = 0x0BA8
        /// </summary>
        TextureMatrix = 0x0ba8,

        /// <summary>
        /// Original was GL_ATTRIB_STACK_DEPTH = 0x0BB0
        /// </summary>
        AttribStackDepth = 0x0bb0,

        /// <summary>
        /// Original was GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1
        /// </summary>
        ClientAttribStackDepth = 0x0bb1,

        /// <summary>
        /// Original was GL_ALPHA_TEST = 0x0BC0
        /// </summary>
        AlphaTest = 0x0bc0,

        /// <summary>
        /// Original was GL_ALPHA_TEST_QCOM = 0x0BC0
        /// </summary>
        AlphaTestQcom = 0x0bc0,

        /// <summary>
        /// Original was GL_ALPHA_TEST_FUNC = 0x0BC1
        /// </summary>
        AlphaTestFunc = 0x0bc1,

        /// <summary>
        /// Original was GL_ALPHA_TEST_FUNC_QCOM = 0x0BC1
        /// </summary>
        AlphaTestFuncQcom = 0x0bc1,

        /// <summary>
        /// Original was GL_ALPHA_TEST_REF = 0x0BC2
        /// </summary>
        AlphaTestRef = 0x0bc2,

        /// <summary>
        /// Original was GL_ALPHA_TEST_REF_QCOM = 0x0BC2
        /// </summary>
        AlphaTestRefQcom = 0x0bc2,

        /// <summary>
        /// Original was GL_DITHER = 0x0BD0
        /// </summary>
        Dither = 0x0bd0,

        /// <summary>
        /// Original was GL_BLEND_DST = 0x0BE0
        /// </summary>
        BlendDst = 0x0be0,

        /// <summary>
        /// Original was GL_BLEND_SRC = 0x0BE1
        /// </summary>
        BlendSrc = 0x0be1,

        /// <summary>
        /// Original was GL_BLEND = 0x0BE2
        /// </summary>
        Blend = 0x0be2,

        /// <summary>
        /// Original was GL_LOGIC_OP_MODE = 0x0BF0
        /// </summary>
        LogicOpMode = 0x0bf0,

        /// <summary>
        /// Original was GL_INDEX_LOGIC_OP = 0x0BF1
        /// </summary>
        IndexLogicOp = 0x0bf1,

        /// <summary>
        /// Original was GL_LOGIC_OP = 0x0BF1
        /// </summary>
        LogicOp = 0x0bf1,

        /// <summary>
        /// Original was GL_COLOR_LOGIC_OP = 0x0BF2
        /// </summary>
        ColorLogicOp = 0x0bf2,

        /// <summary>
        /// Original was GL_AUX_BUFFERS = 0x0C00
        /// </summary>
        AuxBuffers = 0x0c00,

        /// <summary>
        /// Original was GL_DRAW_BUFFER = 0x0C01
        /// </summary>
        DrawBuffer = 0x0c01,

        /// <summary>
        /// Original was GL_DRAW_BUFFER_EXT = 0x0C01
        /// </summary>
        DrawBufferExt = 0x0c01,

        /// <summary>
        /// Original was GL_READ_BUFFER = 0x0C02
        /// </summary>
        ReadBuffer = 0x0c02,

        /// <summary>
        /// Original was GL_READ_BUFFER_EXT = 0x0C02
        /// </summary>
        ReadBufferExt = 0x0c02,

        /// <summary>
        /// Original was GL_READ_BUFFER_NV = 0x0C02
        /// </summary>
        ReadBufferNv = 0x0c02,

        /// <summary>
        /// Original was GL_SCISSOR_BOX = 0x0C10
        /// </summary>
        ScissorBox = 0x0c10,

        /// <summary>
        /// Original was GL_SCISSOR_TEST = 0x0C11
        /// </summary>
        ScissorTest = 0x0c11,

        /// <summary>
        /// Original was GL_INDEX_CLEAR_VALUE = 0x0C20
        /// </summary>
        IndexClearValue = 0x0c20,

        /// <summary>
        /// Original was GL_INDEX_WRITEMASK = 0x0C21
        /// </summary>
        IndexWritemask = 0x0c21,

        /// <summary>
        /// Original was GL_COLOR_CLEAR_VALUE = 0x0C22
        /// </summary>
        ColorClearValue = 0x0c22,

        /// <summary>
        /// Original was GL_COLOR_WRITEMASK = 0x0C23
        /// </summary>
        ColorWritemask = 0x0c23,

        /// <summary>
        /// Original was GL_INDEX_MODE = 0x0C30
        /// </summary>
        IndexMode = 0x0c30,

        /// <summary>
        /// Original was GL_RGBA_MODE = 0x0C31
        /// </summary>
        RgbaMode = 0x0c31,

        /// <summary>
        /// Original was GL_DOUBLEBUFFER = 0x0C32
        /// </summary>
        Doublebuffer = 0x0c32,

        /// <summary>
        /// Original was GL_STEREO = 0x0C33
        /// </summary>
        Stereo = 0x0c33,

        /// <summary>
        /// Original was GL_RENDER_MODE = 0x0C40
        /// </summary>
        RenderMode = 0x0c40,

        /// <summary>
        /// Original was GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50
        /// </summary>
        PerspectiveCorrectionHint = 0x0c50,

        /// <summary>
        /// Original was GL_POINT_SMOOTH_HINT = 0x0C51
        /// </summary>
        PointSmoothHint = 0x0c51,

        /// <summary>
        /// Original was GL_LINE_SMOOTH_HINT = 0x0C52
        /// </summary>
        LineSmoothHint = 0x0c52,

        /// <summary>
        /// Original was GL_POLYGON_SMOOTH_HINT = 0x0C53
        /// </summary>
        PolygonSmoothHint = 0x0c53,

        /// <summary>
        /// Original was GL_FOG_HINT = 0x0C54
        /// </summary>
        FogHint = 0x0c54,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_S = 0x0C60
        /// </summary>
        TextureGenS = 0x0c60,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_T = 0x0C61
        /// </summary>
        TextureGenT = 0x0c61,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_R = 0x0C62
        /// </summary>
        TextureGenR = 0x0c62,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_Q = 0x0C63
        /// </summary>
        TextureGenQ = 0x0c63,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_I = 0x0C70
        /// </summary>
        PixelMapIToI = 0x0c70,

        /// <summary>
        /// Original was GL_PIXEL_MAP_S_TO_S = 0x0C71
        /// </summary>
        PixelMapSToS = 0x0c71,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_R = 0x0C72
        /// </summary>
        PixelMapIToR = 0x0c72,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_G = 0x0C73
        /// </summary>
        PixelMapIToG = 0x0c73,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_B = 0x0C74
        /// </summary>
        PixelMapIToB = 0x0c74,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_A = 0x0C75
        /// </summary>
        PixelMapIToA = 0x0c75,

        /// <summary>
        /// Original was GL_PIXEL_MAP_R_TO_R = 0x0C76
        /// </summary>
        PixelMapRToR = 0x0c76,

        /// <summary>
        /// Original was GL_PIXEL_MAP_G_TO_G = 0x0C77
        /// </summary>
        PixelMapGToG = 0x0c77,

        /// <summary>
        /// Original was GL_PIXEL_MAP_B_TO_B = 0x0C78
        /// </summary>
        PixelMapBToB = 0x0c78,

        /// <summary>
        /// Original was GL_PIXEL_MAP_A_TO_A = 0x0C79
        /// </summary>
        PixelMapAToA = 0x0c79,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0
        /// </summary>
        PixelMapIToISize = 0x0cb0,

        /// <summary>
        /// Original was GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1
        /// </summary>
        PixelMapSToSSize = 0x0cb1,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2
        /// </summary>
        PixelMapIToRSize = 0x0cb2,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3
        /// </summary>
        PixelMapIToGSize = 0x0cb3,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4
        /// </summary>
        PixelMapIToBSize = 0x0cb4,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5
        /// </summary>
        PixelMapIToASize = 0x0cb5,

        /// <summary>
        /// Original was GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6
        /// </summary>
        PixelMapRToRSize = 0x0cb6,

        /// <summary>
        /// Original was GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7
        /// </summary>
        PixelMapGToGSize = 0x0cb7,

        /// <summary>
        /// Original was GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8
        /// </summary>
        PixelMapBToBSize = 0x0cb8,

        /// <summary>
        /// Original was GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9
        /// </summary>
        PixelMapAToASize = 0x0cb9,

        /// <summary>
        /// Original was GL_UNPACK_SWAP_BYTES = 0x0CF0
        /// </summary>
        UnpackSwapBytes = 0x0cf0,

        /// <summary>
        /// Original was GL_UNPACK_LSB_FIRST = 0x0CF1
        /// </summary>
        UnpackLsbFirst = 0x0cf1,

        /// <summary>
        /// Original was GL_UNPACK_ROW_LENGTH = 0x0CF2
        /// </summary>
        UnpackRowLength = 0x0cf2,

        /// <summary>
        /// Original was GL_UNPACK_ROW_LENGTH_EXT = 0x0CF2
        /// </summary>
        UnpackRowLengthExt = 0x0cf2,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_ROWS = 0x0CF3
        /// </summary>
        UnpackSkipRows = 0x0cf3,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_ROWS_EXT = 0x0CF3
        /// </summary>
        UnpackSkipRowsExt = 0x0cf3,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_PIXELS = 0x0CF4
        /// </summary>
        UnpackSkipPixels = 0x0cf4,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_PIXELS_EXT = 0x0CF4
        /// </summary>
        UnpackSkipPixelsExt = 0x0cf4,

        /// <summary>
        /// Original was GL_UNPACK_ALIGNMENT = 0x0CF5
        /// </summary>
        UnpackAlignment = 0x0cf5,

        /// <summary>
        /// Original was GL_PACK_SWAP_BYTES = 0x0D00
        /// </summary>
        PackSwapBytes = 0x0d00,

        /// <summary>
        /// Original was GL_PACK_LSB_FIRST = 0x0D01
        /// </summary>
        PackLsbFirst = 0x0d01,

        /// <summary>
        /// Original was GL_PACK_ROW_LENGTH = 0x0D02
        /// </summary>
        PackRowLength = 0x0d02,

        /// <summary>
        /// Original was GL_PACK_SKIP_ROWS = 0x0D03
        /// </summary>
        PackSkipRows = 0x0d03,

        /// <summary>
        /// Original was GL_PACK_SKIP_PIXELS = 0x0D04
        /// </summary>
        PackSkipPixels = 0x0d04,

        /// <summary>
        /// Original was GL_PACK_ALIGNMENT = 0x0D05
        /// </summary>
        PackAlignment = 0x0d05,

        /// <summary>
        /// Original was GL_MAP_COLOR = 0x0D10
        /// </summary>
        MapColor = 0x0d10,

        /// <summary>
        /// Original was GL_MAP_STENCIL = 0x0D11
        /// </summary>
        MapStencil = 0x0d11,

        /// <summary>
        /// Original was GL_INDEX_SHIFT = 0x0D12
        /// </summary>
        IndexShift = 0x0d12,

        /// <summary>
        /// Original was GL_INDEX_OFFSET = 0x0D13
        /// </summary>
        IndexOffset = 0x0d13,

        /// <summary>
        /// Original was GL_RED_SCALE = 0x0D14
        /// </summary>
        RedScale = 0x0d14,

        /// <summary>
        /// Original was GL_RED_BIAS = 0x0D15
        /// </summary>
        RedBias = 0x0d15,

        /// <summary>
        /// Original was GL_ZOOM_X = 0x0D16
        /// </summary>
        ZoomX = 0x0d16,

        /// <summary>
        /// Original was GL_ZOOM_Y = 0x0D17
        /// </summary>
        ZoomY = 0x0d17,

        /// <summary>
        /// Original was GL_GREEN_SCALE = 0x0D18
        /// </summary>
        GreenScale = 0x0d18,

        /// <summary>
        /// Original was GL_GREEN_BIAS = 0x0D19
        /// </summary>
        GreenBias = 0x0d19,

        /// <summary>
        /// Original was GL_BLUE_SCALE = 0x0D1A
        /// </summary>
        BlueScale = 0x0d1a,

        /// <summary>
        /// Original was GL_BLUE_BIAS = 0x0D1B
        /// </summary>
        BlueBias = 0x0d1b,

        /// <summary>
        /// Original was GL_ALPHA_SCALE = 0x0D1C
        /// </summary>
        AlphaScale = 0x0d1c,

        /// <summary>
        /// Original was GL_ALPHA_BIAS = 0x0D1D
        /// </summary>
        AlphaBias = 0x0d1d,

        /// <summary>
        /// Original was GL_DEPTH_SCALE = 0x0D1E
        /// </summary>
        DepthScale = 0x0d1e,

        /// <summary>
        /// Original was GL_DEPTH_BIAS = 0x0D1F
        /// </summary>
        DepthBias = 0x0d1f,

        /// <summary>
        /// Original was GL_MAX_EVAL_ORDER = 0x0D30
        /// </summary>
        MaxEvalOrder = 0x0d30,

        /// <summary>
        /// Original was GL_MAX_LIGHTS = 0x0D31
        /// </summary>
        MaxLights = 0x0d31,

        /// <summary>
        /// Original was GL_MAX_CLIP_DISTANCES = 0x0D32
        /// </summary>
        MaxClipDistances = 0x0d32,

        /// <summary>
        /// Original was GL_MAX_CLIP_PLANES = 0x0D32
        /// </summary>
        MaxClipPlanes = 0x0d32,

        /// <summary>
        /// Original was GL_MAX_CLIP_PLANES_IMG = 0x0D32
        /// </summary>
        MaxClipPlanesImg = 0x0d32,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_SIZE = 0x0D33
        /// </summary>
        MaxTextureSize = 0x0d33,

        /// <summary>
        /// Original was GL_MAX_PIXEL_MAP_TABLE = 0x0D34
        /// </summary>
        MaxPixelMapTable = 0x0d34,

        /// <summary>
        /// Original was GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35
        /// </summary>
        MaxAttribStackDepth = 0x0d35,

        /// <summary>
        /// Original was GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36
        /// </summary>
        MaxModelviewStackDepth = 0x0d36,

        /// <summary>
        /// Original was GL_MAX_NAME_STACK_DEPTH = 0x0D37
        /// </summary>
        MaxNameStackDepth = 0x0d37,

        /// <summary>
        /// Original was GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38
        /// </summary>
        MaxProjectionStackDepth = 0x0d38,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39
        /// </summary>
        MaxTextureStackDepth = 0x0d39,

        /// <summary>
        /// Original was GL_MAX_VIEWPORT_DIMS = 0x0D3A
        /// </summary>
        MaxViewportDims = 0x0d3a,

        /// <summary>
        /// Original was GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B
        /// </summary>
        MaxClientAttribStackDepth = 0x0d3b,

        /// <summary>
        /// Original was GL_SUBPIXEL_BITS = 0x0D50
        /// </summary>
        SubpixelBits = 0x0d50,

        /// <summary>
        /// Original was GL_INDEX_BITS = 0x0D51
        /// </summary>
        IndexBits = 0x0d51,

        /// <summary>
        /// Original was GL_RED_BITS = 0x0D52
        /// </summary>
        RedBits = 0x0d52,

        /// <summary>
        /// Original was GL_GREEN_BITS = 0x0D53
        /// </summary>
        GreenBits = 0x0d53,

        /// <summary>
        /// Original was GL_BLUE_BITS = 0x0D54
        /// </summary>
        BlueBits = 0x0d54,

        /// <summary>
        /// Original was GL_ALPHA_BITS = 0x0D55
        /// </summary>
        AlphaBits = 0x0d55,

        /// <summary>
        /// Original was GL_DEPTH_BITS = 0x0D56
        /// </summary>
        DepthBits = 0x0d56,

        /// <summary>
        /// Original was GL_STENCIL_BITS = 0x0D57
        /// </summary>
        StencilBits = 0x0d57,

        /// <summary>
        /// Original was GL_ACCUM_RED_BITS = 0x0D58
        /// </summary>
        AccumRedBits = 0x0d58,

        /// <summary>
        /// Original was GL_ACCUM_GREEN_BITS = 0x0D59
        /// </summary>
        AccumGreenBits = 0x0d59,

        /// <summary>
        /// Original was GL_ACCUM_BLUE_BITS = 0x0D5A
        /// </summary>
        AccumBlueBits = 0x0d5a,

        /// <summary>
        /// Original was GL_ACCUM_ALPHA_BITS = 0x0D5B
        /// </summary>
        AccumAlphaBits = 0x0d5b,

        /// <summary>
        /// Original was GL_NAME_STACK_DEPTH = 0x0D70
        /// </summary>
        NameStackDepth = 0x0d70,

        /// <summary>
        /// Original was GL_AUTO_NORMAL = 0x0D80
        /// </summary>
        AutoNormal = 0x0d80,

        /// <summary>
        /// Original was GL_MAP1_COLOR_4 = 0x0D90
        /// </summary>
        Map1Color4 = 0x0d90,

        /// <summary>
        /// Original was GL_MAP1_INDEX = 0x0D91
        /// </summary>
        Map1Index = 0x0d91,

        /// <summary>
        /// Original was GL_MAP1_NORMAL = 0x0D92
        /// </summary>
        Map1Normal = 0x0d92,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_1 = 0x0D93
        /// </summary>
        Map1TextureCoord1 = 0x0d93,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_2 = 0x0D94
        /// </summary>
        Map1TextureCoord2 = 0x0d94,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_3 = 0x0D95
        /// </summary>
        Map1TextureCoord3 = 0x0d95,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_4 = 0x0D96
        /// </summary>
        Map1TextureCoord4 = 0x0d96,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_3 = 0x0D97
        /// </summary>
        Map1Vertex3 = 0x0d97,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_4 = 0x0D98
        /// </summary>
        Map1Vertex4 = 0x0d98,

        /// <summary>
        /// Original was GL_MAP2_COLOR_4 = 0x0DB0
        /// </summary>
        Map2Color4 = 0x0db0,

        /// <summary>
        /// Original was GL_MAP2_INDEX = 0x0DB1
        /// </summary>
        Map2Index = 0x0db1,

        /// <summary>
        /// Original was GL_MAP2_NORMAL = 0x0DB2
        /// </summary>
        Map2Normal = 0x0db2,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_1 = 0x0DB3
        /// </summary>
        Map2TextureCoord1 = 0x0db3,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_2 = 0x0DB4
        /// </summary>
        Map2TextureCoord2 = 0x0db4,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_3 = 0x0DB5
        /// </summary>
        Map2TextureCoord3 = 0x0db5,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_4 = 0x0DB6
        /// </summary>
        Map2TextureCoord4 = 0x0db6,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_3 = 0x0DB7
        /// </summary>
        Map2Vertex3 = 0x0db7,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_4 = 0x0DB8
        /// </summary>
        Map2Vertex4 = 0x0db8,

        /// <summary>
        /// Original was GL_MAP1_GRID_DOMAIN = 0x0DD0
        /// </summary>
        Map1GridDomain = 0x0dd0,

        /// <summary>
        /// Original was GL_MAP1_GRID_SEGMENTS = 0x0DD1
        /// </summary>
        Map1GridSegments = 0x0dd1,

        /// <summary>
        /// Original was GL_MAP2_GRID_DOMAIN = 0x0DD2
        /// </summary>
        Map2GridDomain = 0x0dd2,

        /// <summary>
        /// Original was GL_MAP2_GRID_SEGMENTS = 0x0DD3
        /// </summary>
        Map2GridSegments = 0x0dd3,

        /// <summary>
        /// Original was GL_TEXTURE_1D = 0x0DE0
        /// </summary>
        Texture1D = 0x0de0,

        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = 0x0de1,

        /// <summary>
        /// Original was GL_FEEDBACK_BUFFER_POINTER = 0x0DF0
        /// </summary>
        FeedbackBufferPointer = 0x0df0,

        /// <summary>
        /// Original was GL_FEEDBACK_BUFFER_SIZE = 0x0DF1
        /// </summary>
        FeedbackBufferSize = 0x0df1,

        /// <summary>
        /// Original was GL_FEEDBACK_BUFFER_TYPE = 0x0DF2
        /// </summary>
        FeedbackBufferType = 0x0df2,

        /// <summary>
        /// Original was GL_SELECTION_BUFFER_POINTER = 0x0DF3
        /// </summary>
        SelectionBufferPointer = 0x0df3,

        /// <summary>
        /// Original was GL_SELECTION_BUFFER_SIZE = 0x0DF4
        /// </summary>
        SelectionBufferSize = 0x0df4,

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10
        /// </summary>
        GlyphHorizontalBearingAdvanceBitNv = 0x10,

        /// <summary>
        /// Original was GL_GLYPH_HAS_KERNING_BIT_NV = 0x100
        /// </summary>
        GlyphHasKerningBitNv = 0x100,

        /// <summary>
        /// Original was GL_TEXTURE_WIDTH = 0x1000
        /// </summary>
        TextureWidth = 0x1000,

        /// <summary>
        /// Original was GL_FONT_HAS_KERNING_BIT_NV = 0x10000000
        /// </summary>
        FontHasKerningBitNv = ((int)0x10000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT4_QCOM = 0x10000000
        /// </summary>
        MultisampleBufferBit4Qcom = ((int)0x10000000),

        /// <summary>
        /// Original was GL_TEXTURE_HEIGHT = 0x1001
        /// </summary>
        TextureHeight = 0x1001,

        /// <summary>
        /// Original was GL_TEXTURE_COMPONENTS = 0x1003
        /// </summary>
        TextureComponents = 0x1003,

        /// <summary>
        /// Original was GL_TEXTURE_INTERNAL_FORMAT = 0x1003
        /// </summary>
        TextureInternalFormat = 0x1003,

        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR = 0x1004
        /// </summary>
        TextureBorderColor = 0x1004,

        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR_NV = 0x1004
        /// </summary>
        TextureBorderColorNv = 0x1004,

        /// <summary>
        /// Original was GL_TEXTURE_BORDER = 0x1005
        /// </summary>
        TextureBorder = 0x1005,

        /// <summary>
        /// Original was GL_DONT_CARE = 0x1100
        /// </summary>
        DontCare = 0x1100,

        /// <summary>
        /// Original was GL_FASTEST = 0x1101
        /// </summary>
        Fastest = 0x1101,

        /// <summary>
        /// Original was GL_NICEST = 0x1102
        /// </summary>
        Nicest = 0x1102,

        /// <summary>
        /// Original was GL_AMBIENT = 0x1200
        /// </summary>
        Ambient = 0x1200,

        /// <summary>
        /// Original was GL_DIFFUSE = 0x1201
        /// </summary>
        Diffuse = 0x1201,

        /// <summary>
        /// Original was GL_SPECULAR = 0x1202
        /// </summary>
        Specular = 0x1202,

        /// <summary>
        /// Original was GL_POSITION = 0x1203
        /// </summary>
        Position = 0x1203,

        /// <summary>
        /// Original was GL_SPOT_DIRECTION = 0x1204
        /// </summary>
        SpotDirection = 0x1204,

        /// <summary>
        /// Original was GL_SPOT_EXPONENT = 0x1205
        /// </summary>
        SpotExponent = 0x1205,

        /// <summary>
        /// Original was GL_SPOT_CUTOFF = 0x1206
        /// </summary>
        SpotCutoff = 0x1206,

        /// <summary>
        /// Original was GL_CONSTANT_ATTENUATION = 0x1207
        /// </summary>
        ConstantAttenuation = 0x1207,

        /// <summary>
        /// Original was GL_LINEAR_ATTENUATION = 0x1208
        /// </summary>
        LinearAttenuation = 0x1208,

        /// <summary>
        /// Original was GL_QUADRATIC_ATTENUATION = 0x1209
        /// </summary>
        QuadraticAttenuation = 0x1209,

        /// <summary>
        /// Original was GL_COMPILE = 0x1300
        /// </summary>
        Compile = 0x1300,

        /// <summary>
        /// Original was GL_COMPILE_AND_EXECUTE = 0x1301
        /// </summary>
        CompileAndExecute = 0x1301,

        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = 0x1400,

        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = 0x1401,

        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = 0x1402,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = 0x1403,

        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = 0x1404,

        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = 0x1405,

        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_2_BYTES = 0x1407
        /// </summary>
        Gl2Bytes = 0x1407,

        /// <summary>
        /// Original was GL_3_BYTES = 0x1408
        /// </summary>
        Gl3Bytes = 0x1408,

        /// <summary>
        /// Original was GL_4_BYTES = 0x1409
        /// </summary>
        Gl4Bytes = 0x1409,

        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = 0x140a,

        /// <summary>
        /// Original was GL_HALF_FLOAT = 0x140B
        /// </summary>
        HalfFloat = 0x140b,

        /// <summary>
        /// Original was GL_FIXED = 0x140C
        /// </summary>
        Fixed = 0x140c,

        /// <summary>
        /// Original was GL_FIXED_OES = 0x140C
        /// </summary>
        FixedOes = 0x140c,

        /// <summary>
        /// Original was GL_CLEAR = 0x1500
        /// </summary>
        Clear = 0x1500,

        /// <summary>
        /// Original was GL_AND = 0x1501
        /// </summary>
        And = 0x1501,

        /// <summary>
        /// Original was GL_AND_REVERSE = 0x1502
        /// </summary>
        AndReverse = 0x1502,

        /// <summary>
        /// Original was GL_COPY = 0x1503
        /// </summary>
        Copy = 0x1503,

        /// <summary>
        /// Original was GL_AND_INVERTED = 0x1504
        /// </summary>
        AndInverted = 0x1504,

        /// <summary>
        /// Original was GL_NOOP = 0x1505
        /// </summary>
        Noop = 0x1505,

        /// <summary>
        /// Original was GL_XOR = 0x1506
        /// </summary>
        Xor = 0x1506,

        /// <summary>
        /// Original was GL_OR = 0x1507
        /// </summary>
        Or = 0x1507,

        /// <summary>
        /// Original was GL_NOR = 0x1508
        /// </summary>
        Nor = 0x1508,

        /// <summary>
        /// Original was GL_EQUIV = 0x1509
        /// </summary>
        Equiv = 0x1509,

        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = 0x150a,

        /// <summary>
        /// Original was GL_OR_REVERSE = 0x150B
        /// </summary>
        OrReverse = 0x150b,

        /// <summary>
        /// Original was GL_COPY_INVERTED = 0x150C
        /// </summary>
        CopyInverted = 0x150c,

        /// <summary>
        /// Original was GL_OR_INVERTED = 0x150D
        /// </summary>
        OrInverted = 0x150d,

        /// <summary>
        /// Original was GL_NAND = 0x150E
        /// </summary>
        Nand = 0x150e,

        /// <summary>
        /// Original was GL_SET = 0x150F
        /// </summary>
        Set = 0x150f,

        /// <summary>
        /// Original was GL_EMISSION = 0x1600
        /// </summary>
        Emission = 0x1600,

        /// <summary>
        /// Original was GL_SHININESS = 0x1601
        /// </summary>
        Shininess = 0x1601,

        /// <summary>
        /// Original was GL_AMBIENT_AND_DIFFUSE = 0x1602
        /// </summary>
        AmbientAndDiffuse = 0x1602,

        /// <summary>
        /// Original was GL_COLOR_INDEXES = 0x1603
        /// </summary>
        ColorIndexes = 0x1603,

        /// <summary>
        /// Original was GL_MODELVIEW = 0x1700
        /// </summary>
        Modelview = 0x1700,

        /// <summary>
        /// Original was GL_MODELVIEW0_EXT = 0x1700
        /// </summary>
        Modelview0Ext = 0x1700,

        /// <summary>
        /// Original was GL_PROJECTION = 0x1701
        /// </summary>
        Projection = 0x1701,

        /// <summary>
        /// Original was GL_TEXTURE = 0x1702
        /// </summary>
        Texture = 0x1702,

        /// <summary>
        /// Original was GL_COLOR = 0x1800
        /// </summary>
        Color = 0x1800,

        /// <summary>
        /// Original was GL_COLOR_EXT = 0x1800
        /// </summary>
        ColorExt = 0x1800,

        /// <summary>
        /// Original was GL_DEPTH = 0x1801
        /// </summary>
        Depth = 0x1801,

        /// <summary>
        /// Original was GL_DEPTH_EXT = 0x1801
        /// </summary>
        DepthExt = 0x1801,

        /// <summary>
        /// Original was GL_STENCIL = 0x1802
        /// </summary>
        Stencil = 0x1802,

        /// <summary>
        /// Original was GL_STENCIL_EXT = 0x1802
        /// </summary>
        StencilExt = 0x1802,

        /// <summary>
        /// Original was GL_COLOR_INDEX = 0x1900
        /// </summary>
        ColorIndex = 0x1900,

        /// <summary>
        /// Original was GL_STENCIL_INDEX = 0x1901
        /// </summary>
        StencilIndex = 0x1901,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT = 0x1902
        /// </summary>
        DepthComponent = 0x1902,

        /// <summary>
        /// Original was GL_RED = 0x1903
        /// </summary>
        Red = 0x1903,

        /// <summary>
        /// Original was GL_RED_EXT = 0x1903
        /// </summary>
        RedExt = 0x1903,

        /// <summary>
        /// Original was GL_GREEN = 0x1904
        /// </summary>
        Green = 0x1904,

        /// <summary>
        /// Original was GL_BLUE = 0x1905
        /// </summary>
        Blue = 0x1905,

        /// <summary>
        /// Original was GL_ALPHA = 0x1906
        /// </summary>
        Alpha = 0x1906,

        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = 0x1907,

        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = 0x1908,

        /// <summary>
        /// Original was GL_LUMINANCE = 0x1909
        /// </summary>
        Luminance = 0x1909,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = 0x190a,

        /// <summary>
        /// Original was GL_BITMAP = 0x1A00
        /// </summary>
        Bitmap = 0x1a00,

        /// <summary>
        /// Original was GL_PREFER_DOUBLEBUFFER_HINT_PGI = 0x1A1F8
        /// </summary>
        PreferDoublebufferHintPgi = 0x1a1f8,

        /// <summary>
        /// Original was GL_CONSERVE_MEMORY_HINT_PGI = 0x1A1FD
        /// </summary>
        ConserveMemoryHintPgi = 0x1a1fd,

        /// <summary>
        /// Original was GL_RECLAIM_MEMORY_HINT_PGI = 0x1A1FE
        /// </summary>
        ReclaimMemoryHintPgi = 0x1a1fe,

        /// <summary>
        /// Original was GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203
        /// </summary>
        NativeGraphicsBeginHintPgi = 0x1a203,

        /// <summary>
        /// Original was GL_NATIVE_GRAPHICS_END_HINT_PGI = 0x1A204
        /// </summary>
        NativeGraphicsEndHintPgi = 0x1a204,

        /// <summary>
        /// Original was GL_ALWAYS_FAST_HINT_PGI = 0x1A20C
        /// </summary>
        AlwaysFastHintPgi = 0x1a20c,

        /// <summary>
        /// Original was GL_ALWAYS_SOFT_HINT_PGI = 0x1A20D
        /// </summary>
        AlwaysSoftHintPgi = 0x1a20d,

        /// <summary>
        /// Original was GL_ALLOW_DRAW_OBJ_HINT_PGI = 0x1A20E
        /// </summary>
        AllowDrawObjHintPgi = 0x1a20e,

        /// <summary>
        /// Original was GL_ALLOW_DRAW_WIN_HINT_PGI = 0x1A20F
        /// </summary>
        AllowDrawWinHintPgi = 0x1a20f,

        /// <summary>
        /// Original was GL_ALLOW_DRAW_FRG_HINT_PGI = 0x1A210
        /// </summary>
        AllowDrawFrgHintPgi = 0x1a210,

        /// <summary>
        /// Original was GL_ALLOW_DRAW_MEM_HINT_PGI = 0x1A211
        /// </summary>
        AllowDrawMemHintPgi = 0x1a211,

        /// <summary>
        /// Original was GL_STRICT_DEPTHFUNC_HINT_PGI = 0x1A216
        /// </summary>
        StrictDepthfuncHintPgi = 0x1a216,

        /// <summary>
        /// Original was GL_STRICT_LIGHTING_HINT_PGI = 0x1A217
        /// </summary>
        StrictLightingHintPgi = 0x1a217,

        /// <summary>
        /// Original was GL_STRICT_SCISSOR_HINT_PGI = 0x1A218
        /// </summary>
        StrictScissorHintPgi = 0x1a218,

        /// <summary>
        /// Original was GL_FULL_STIPPLE_HINT_PGI = 0x1A219
        /// </summary>
        FullStippleHintPgi = 0x1a219,

        /// <summary>
        /// Original was GL_CLIP_NEAR_HINT_PGI = 0x1A220
        /// </summary>
        ClipNearHintPgi = 0x1a220,

        /// <summary>
        /// Original was GL_CLIP_FAR_HINT_PGI = 0x1A221
        /// </summary>
        ClipFarHintPgi = 0x1a221,

        /// <summary>
        /// Original was GL_WIDE_LINE_HINT_PGI = 0x1A222
        /// </summary>
        WideLineHintPgi = 0x1a222,

        /// <summary>
        /// Original was GL_BACK_NORMALS_HINT_PGI = 0x1A223
        /// </summary>
        BackNormalsHintPgi = 0x1a223,

        /// <summary>
        /// Original was GL_VERTEX_DATA_HINT_PGI = 0x1A22A
        /// </summary>
        VertexDataHintPgi = 0x1a22a,

        /// <summary>
        /// Original was GL_VERTEX_CONSISTENT_HINT_PGI = 0x1A22B
        /// </summary>
        VertexConsistentHintPgi = 0x1a22b,

        /// <summary>
        /// Original was GL_MATERIAL_SIDE_HINT_PGI = 0x1A22C
        /// </summary>
        MaterialSideHintPgi = 0x1a22c,

        /// <summary>
        /// Original was GL_MAX_VERTEX_HINT_PGI = 0x1A22D
        /// </summary>
        MaxVertexHintPgi = 0x1a22d,

        /// <summary>
        /// Original was GL_POINT = 0x1B00
        /// </summary>
        Point = 0x1b00,

        /// <summary>
        /// Original was GL_LINE = 0x1B01
        /// </summary>
        Line = 0x1b01,

        /// <summary>
        /// Original was GL_FILL = 0x1B02
        /// </summary>
        Fill = 0x1b02,

        /// <summary>
        /// Original was GL_RENDER = 0x1C00
        /// </summary>
        Render = 0x1c00,

        /// <summary>
        /// Original was GL_FEEDBACK = 0x1C01
        /// </summary>
        Feedback = 0x1c01,

        /// <summary>
        /// Original was GL_SELECT = 0x1C02
        /// </summary>
        Select = 0x1c02,

        /// <summary>
        /// Original was GL_FLAT = 0x1D00
        /// </summary>
        Flat = 0x1d00,

        /// <summary>
        /// Original was GL_SMOOTH = 0x1D01
        /// </summary>
        Smooth = 0x1d01,

        /// <summary>
        /// Original was GL_KEEP = 0x1E00
        /// </summary>
        Keep = 0x1e00,

        /// <summary>
        /// Original was GL_REPLACE = 0x1E01
        /// </summary>
        Replace = 0x1e01,

        /// <summary>
        /// Original was GL_INCR = 0x1E02
        /// </summary>
        Incr = 0x1e02,

        /// <summary>
        /// Original was GL_DECR = 0x1E03
        /// </summary>
        Decr = 0x1e03,

        /// <summary>
        /// Original was GL_VENDOR = 0x1F00
        /// </summary>
        Vendor = 0x1f00,

        /// <summary>
        /// Original was GL_RENDERER = 0x1F01
        /// </summary>
        Renderer = 0x1f01,

        /// <summary>
        /// Original was GL_VERSION = 0x1F02
        /// </summary>
        Version = 0x1f02,

        /// <summary>
        /// Original was GL_EXTENSIONS = 0x1F03
        /// </summary>
        Extensions = 0x1f03,

        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20
        /// </summary>
        GlyphVerticalBearingXBitNv = 0x20,

        /// <summary>
        /// Original was GL_S = 0x2000
        /// </summary>
        S = 0x2000,

        /// <summary>
        /// Original was GL_FONT_NUM_GLYPH_INDICES_BIT_NV = 0x20000000
        /// </summary>
        FontNumGlyphIndicesBitNv = ((int)0x20000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BIT = 0x20000000
        /// </summary>
        MultisampleBit = ((int)0x20000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BIT_3DFX = 0x20000000
        /// </summary>
        MultisampleBit3Dfx = ((int)0x20000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BIT_ARB = 0x20000000
        /// </summary>
        MultisampleBitArb = ((int)0x20000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BIT_EXT = 0x20000000
        /// </summary>
        MultisampleBitExt = ((int)0x20000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT5_QCOM = 0x20000000
        /// </summary>
        MultisampleBufferBit5Qcom = ((int)0x20000000),

        /// <summary>
        /// Original was GL_T = 0x2001
        /// </summary>
        T = 0x2001,

        /// <summary>
        /// Original was GL_R = 0x2002
        /// </summary>
        R = 0x2002,

        /// <summary>
        /// Original was GL_Q = 0x2003
        /// </summary>
        Q = 0x2003,

        /// <summary>
        /// Original was GL_MODULATE = 0x2100
        /// </summary>
        Modulate = 0x2100,

        /// <summary>
        /// Original was GL_DECAL = 0x2101
        /// </summary>
        Decal = 0x2101,

        /// <summary>
        /// Original was GL_TEXTURE_ENV_MODE = 0x2200
        /// </summary>
        TextureEnvMode = 0x2200,

        /// <summary>
        /// Original was GL_TEXTURE_ENV_COLOR = 0x2201
        /// </summary>
        TextureEnvColor = 0x2201,

        /// <summary>
        /// Original was GL_TEXTURE_ENV = 0x2300
        /// </summary>
        TextureEnv = 0x2300,

        /// <summary>
        /// Original was GL_EYE_LINEAR = 0x2400
        /// </summary>
        EyeLinear = 0x2400,

        /// <summary>
        /// Original was GL_OBJECT_LINEAR = 0x2401
        /// </summary>
        ObjectLinear = 0x2401,

        /// <summary>
        /// Original was GL_SPHERE_MAP = 0x2402
        /// </summary>
        SphereMap = 0x2402,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_MODE = 0x2500
        /// </summary>
        TextureGenMode = 0x2500,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_MODE_OES = 0x2500
        /// </summary>
        TextureGenModeOes = 0x2500,

        /// <summary>
        /// Original was GL_OBJECT_PLANE = 0x2501
        /// </summary>
        ObjectPlane = 0x2501,

        /// <summary>
        /// Original was GL_EYE_PLANE = 0x2502
        /// </summary>
        EyePlane = 0x2502,

        /// <summary>
        /// Original was GL_NEAREST = 0x2600
        /// </summary>
        Nearest = 0x2600,

        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = 0x2601,

        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_NEAREST = 0x2700
        /// </summary>
        NearestMipmapNearest = 0x2700,

        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_NEAREST = 0x2701
        /// </summary>
        LinearMipmapNearest = 0x2701,

        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_LINEAR = 0x2702
        /// </summary>
        NearestMipmapLinear = 0x2702,

        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_LINEAR = 0x2703
        /// </summary>
        LinearMipmapLinear = 0x2703,

        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = 0x2800,

        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = 0x2801,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = 0x2802,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = 0x2803,

        /// <summary>
        /// Original was GL_CLAMP = 0x2900
        /// </summary>
        Clamp = 0x2900,

        /// <summary>
        /// Original was GL_REPEAT = 0x2901
        /// </summary>
        Repeat = 0x2901,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_UNITS = 0x2A00
        /// </summary>
        PolygonOffsetUnits = 0x2a00,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_POINT = 0x2A01
        /// </summary>
        PolygonOffsetPoint = 0x2a01,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_LINE = 0x2A02
        /// </summary>
        PolygonOffsetLine = 0x2a02,

        /// <summary>
        /// Original was GL_R3_G3_B2 = 0x2A10
        /// </summary>
        R3G3B2 = 0x2a10,

        /// <summary>
        /// Original was GL_V2F = 0x2A20
        /// </summary>
        V2f = 0x2a20,

        /// <summary>
        /// Original was GL_V3F = 0x2A21
        /// </summary>
        V3f = 0x2a21,

        /// <summary>
        /// Original was GL_C4UB_V2F = 0x2A22
        /// </summary>
        C4ubV2f = 0x2a22,

        /// <summary>
        /// Original was GL_C4UB_V3F = 0x2A23
        /// </summary>
        C4ubV3f = 0x2a23,

        /// <summary>
        /// Original was GL_C3F_V3F = 0x2A24
        /// </summary>
        C3fV3f = 0x2a24,

        /// <summary>
        /// Original was GL_N3F_V3F = 0x2A25
        /// </summary>
        N3fV3f = 0x2a25,

        /// <summary>
        /// Original was GL_C4F_N3F_V3F = 0x2A26
        /// </summary>
        C4fN3fV3f = 0x2a26,

        /// <summary>
        /// Original was GL_T2F_V3F = 0x2A27
        /// </summary>
        T2fV3f = 0x2a27,

        /// <summary>
        /// Original was GL_T4F_V4F = 0x2A28
        /// </summary>
        T4fV4f = 0x2a28,

        /// <summary>
        /// Original was GL_T2F_C4UB_V3F = 0x2A29
        /// </summary>
        T2fC4ubV3f = 0x2a29,

        /// <summary>
        /// Original was GL_T2F_C3F_V3F = 0x2A2A
        /// </summary>
        T2fC3fV3f = 0x2a2a,

        /// <summary>
        /// Original was GL_T2F_N3F_V3F = 0x2A2B
        /// </summary>
        T2fN3fV3f = 0x2a2b,

        /// <summary>
        /// Original was GL_T2F_C4F_N3F_V3F = 0x2A2C
        /// </summary>
        T2fC4fN3fV3f = 0x2a2c,

        /// <summary>
        /// Original was GL_T4F_C4F_N3F_V4F = 0x2A2D
        /// </summary>
        T4fC4fN3fV4f = 0x2a2d,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE0 = 0x3000
        /// </summary>
        ClipDistance0 = 0x3000,

        /// <summary>
        /// Original was GL_CLIP_PLANE0 = 0x3000
        /// </summary>
        ClipPlane0 = 0x3000,

        /// <summary>
        /// Original was GL_CLIP_PLANE0_IMG = 0x3000
        /// </summary>
        ClipPlane0Img = 0x3000,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE1 = 0x3001
        /// </summary>
        ClipDistance1 = 0x3001,

        /// <summary>
        /// Original was GL_CLIP_PLANE1 = 0x3001
        /// </summary>
        ClipPlane1 = 0x3001,

        /// <summary>
        /// Original was GL_CLIP_PLANE1_IMG = 0x3001
        /// </summary>
        ClipPlane1Img = 0x3001,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE2 = 0x3002
        /// </summary>
        ClipDistance2 = 0x3002,

        /// <summary>
        /// Original was GL_CLIP_PLANE2 = 0x3002
        /// </summary>
        ClipPlane2 = 0x3002,

        /// <summary>
        /// Original was GL_CLIP_PLANE2_IMG = 0x3002
        /// </summary>
        ClipPlane2Img = 0x3002,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE3 = 0x3003
        /// </summary>
        ClipDistance3 = 0x3003,

        /// <summary>
        /// Original was GL_CLIP_PLANE3 = 0x3003
        /// </summary>
        ClipPlane3 = 0x3003,

        /// <summary>
        /// Original was GL_CLIP_PLANE3_IMG = 0x3003
        /// </summary>
        ClipPlane3Img = 0x3003,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE4 = 0x3004
        /// </summary>
        ClipDistance4 = 0x3004,

        /// <summary>
        /// Original was GL_CLIP_PLANE4 = 0x3004
        /// </summary>
        ClipPlane4 = 0x3004,

        /// <summary>
        /// Original was GL_CLIP_PLANE4_IMG = 0x3004
        /// </summary>
        ClipPlane4Img = 0x3004,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE5 = 0x3005
        /// </summary>
        ClipDistance5 = 0x3005,

        /// <summary>
        /// Original was GL_CLIP_PLANE5 = 0x3005
        /// </summary>
        ClipPlane5 = 0x3005,

        /// <summary>
        /// Original was GL_CLIP_PLANE5_IMG = 0x3005
        /// </summary>
        ClipPlane5Img = 0x3005,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE6 = 0x3006
        /// </summary>
        ClipDistance6 = 0x3006,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE7 = 0x3007
        /// </summary>
        ClipDistance7 = 0x3007,

        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40
        /// </summary>
        GlyphVerticalBearingYBitNv = 0x40,

        /// <summary>
        /// Original was GL_LIGHT0 = 0x4000
        /// </summary>
        Light0 = 0x4000,

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT6_QCOM = 0x40000000
        /// </summary>
        MultisampleBufferBit6Qcom = ((int)0x40000000),

        /// <summary>
        /// Original was GL_LIGHT1 = 0x4001
        /// </summary>
        Light1 = 0x4001,

        /// <summary>
        /// Original was GL_LIGHT2 = 0x4002
        /// </summary>
        Light2 = 0x4002,

        /// <summary>
        /// Original was GL_LIGHT3 = 0x4003
        /// </summary>
        Light3 = 0x4003,

        /// <summary>
        /// Original was GL_LIGHT4 = 0x4004
        /// </summary>
        Light4 = 0x4004,

        /// <summary>
        /// Original was GL_LIGHT5 = 0x4005
        /// </summary>
        Light5 = 0x4005,

        /// <summary>
        /// Original was GL_LIGHT6 = 0x4006
        /// </summary>
        Light6 = 0x4006,

        /// <summary>
        /// Original was GL_LIGHT7 = 0x4007
        /// </summary>
        Light7 = 0x4007,

        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80
        /// </summary>
        GlyphVerticalBearingAdvanceBitNv = 0x80,

        /// <summary>
        /// Original was GL_ABGR_EXT = 0x8000
        /// </summary>
        AbgrExt = 0x8000,

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT7_QCOM = 0x80000000
        /// </summary>
        MultisampleBufferBit7Qcom = unchecked((int)0x80000000),

        /// <summary>
        /// Original was GL_CONSTANT_COLOR = 0x8001
        /// </summary>
        ConstantColor = 0x8001,

        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_COLOR = 0x8002
        /// </summary>
        OneMinusConstantColor = 0x8002,

        /// <summary>
        /// Original was GL_CONSTANT_ALPHA = 0x8003
        /// </summary>
        ConstantAlpha = 0x8003,

        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004
        /// </summary>
        OneMinusConstantAlpha = 0x8004,

        /// <summary>
        /// Original was GL_BLEND_COLOR_EXT = 0x8005
        /// </summary>
        BlendColorExt = 0x8005,

        /// <summary>
        /// Original was GL_FUNC_ADD = 0x8006
        /// </summary>
        FuncAdd = 0x8006,

        /// <summary>
        /// Original was GL_FUNC_ADD_EXT = 0x8006
        /// </summary>
        FuncAddExt = 0x8006,

        /// <summary>
        /// Original was GL_FUNC_ADD_OES = 0x8006
        /// </summary>
        FuncAddOes = 0x8006,

        /// <summary>
        /// Original was GL_MIN_EXT = 0x8007
        /// </summary>
        MinExt = 0x8007,

        /// <summary>
        /// Original was GL_MAX_EXT = 0x8008
        /// </summary>
        MaxExt = 0x8008,

        /// <summary>
        /// Original was GL_BLEND_EQUATION_EXT = 0x8009
        /// </summary>
        BlendEquationExt = 0x8009,

        /// <summary>
        /// Original was GL_BLEND_EQUATION_OES = 0x8009
        /// </summary>
        BlendEquationOes = 0x8009,

        /// <summary>
        /// Original was GL_BLEND_EQUATION_RGB_OES = 0x8009
        /// </summary>
        BlendEquationRgbOes = 0x8009,

        /// <summary>
        /// Original was GL_FUNC_SUBTRACT = 0x800A
        /// </summary>
        FuncSubtract = 0x800a,

        /// <summary>
        /// Original was GL_FUNC_SUBTRACT_EXT = 0x800A
        /// </summary>
        FuncSubtractExt = 0x800a,

        /// <summary>
        /// Original was GL_FUNC_SUBTRACT_OES = 0x800A
        /// </summary>
        FuncSubtractOes = 0x800a,

        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT = 0x800B
        /// </summary>
        FuncReverseSubtract = 0x800b,

        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT_EXT = 0x800B
        /// </summary>
        FuncReverseSubtractExt = 0x800b,

        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT_OES = 0x800B
        /// </summary>
        FuncReverseSubtractOes = 0x800b,

        /// <summary>
        /// Original was GL_CMYK_EXT = 0x800C
        /// </summary>
        CmykExt = 0x800c,

        /// <summary>
        /// Original was GL_CMYKA_EXT = 0x800D
        /// </summary>
        CmykaExt = 0x800d,

        /// <summary>
        /// Original was GL_PACK_CMYK_HINT_EXT = 0x800E
        /// </summary>
        PackCmykHintExt = 0x800e,

        /// <summary>
        /// Original was GL_UNPACK_CMYK_HINT_EXT = 0x800F
        /// </summary>
        UnpackCmykHintExt = 0x800f,

        /// <summary>
        /// Original was GL_CONVOLUTION_1D = 0x8010
        /// </summary>
        Convolution1D = 0x8010,

        /// <summary>
        /// Original was GL_CONVOLUTION_1D_EXT = 0x8010
        /// </summary>
        Convolution1DExt = 0x8010,

        /// <summary>
        /// Original was GL_CONVOLUTION_2D = 0x8011
        /// </summary>
        Convolution2D = 0x8011,

        /// <summary>
        /// Original was GL_CONVOLUTION_2D_EXT = 0x8011
        /// </summary>
        Convolution2DExt = 0x8011,

        /// <summary>
        /// Original was GL_SEPARABLE_2D = 0x8012
        /// </summary>
        Separable2D = 0x8012,

        /// <summary>
        /// Original was GL_SEPARABLE_2D_EXT = 0x8012
        /// </summary>
        Separable2DExt = 0x8012,

        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_MODE = 0x8013
        /// </summary>
        ConvolutionBorderMode = 0x8013,

        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_MODE_EXT = 0x8013
        /// </summary>
        ConvolutionBorderModeExt = 0x8013,

        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_SCALE = 0x8014
        /// </summary>
        ConvolutionFilterScale = 0x8014,

        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_SCALE_EXT = 0x8014
        /// </summary>
        ConvolutionFilterScaleExt = 0x8014,

        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_BIAS = 0x8015
        /// </summary>
        ConvolutionFilterBias = 0x8015,

        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_BIAS_EXT = 0x8015
        /// </summary>
        ConvolutionFilterBiasExt = 0x8015,

        /// <summary>
        /// Original was GL_REDUCE = 0x8016
        /// </summary>
        Reduce = 0x8016,

        /// <summary>
        /// Original was GL_REDUCE_EXT = 0x8016
        /// </summary>
        ReduceExt = 0x8016,

        /// <summary>
        /// Original was GL_CONVOLUTION_FORMAT = 0x8017
        /// </summary>
        ConvolutionFormat = 0x8017,

        /// <summary>
        /// Original was GL_CONVOLUTION_FORMAT_EXT = 0x8017
        /// </summary>
        ConvolutionFormatExt = 0x8017,

        /// <summary>
        /// Original was GL_CONVOLUTION_WIDTH = 0x8018
        /// </summary>
        ConvolutionWidth = 0x8018,

        /// <summary>
        /// Original was GL_CONVOLUTION_WIDTH_EXT = 0x8018
        /// </summary>
        ConvolutionWidthExt = 0x8018,

        /// <summary>
        /// Original was GL_CONVOLUTION_HEIGHT = 0x8019
        /// </summary>
        ConvolutionHeight = 0x8019,

        /// <summary>
        /// Original was GL_CONVOLUTION_HEIGHT_EXT = 0x8019
        /// </summary>
        ConvolutionHeightExt = 0x8019,

        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_WIDTH = 0x801A
        /// </summary>
        MaxConvolutionWidth = 0x801a,

        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_WIDTH_EXT = 0x801A
        /// </summary>
        MaxConvolutionWidthExt = 0x801a,

        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_HEIGHT = 0x801B
        /// </summary>
        MaxConvolutionHeight = 0x801b,

        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_HEIGHT_EXT = 0x801B
        /// </summary>
        MaxConvolutionHeightExt = 0x801b,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_SCALE = 0x801C
        /// </summary>
        PostConvolutionRedScale = 0x801c,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C
        /// </summary>
        PostConvolutionRedScaleExt = 0x801c,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D
        /// </summary>
        PostConvolutionGreenScale = 0x801d,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D
        /// </summary>
        PostConvolutionGreenScaleExt = 0x801d,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E
        /// </summary>
        PostConvolutionBlueScale = 0x801e,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E
        /// </summary>
        PostConvolutionBlueScaleExt = 0x801e,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F
        /// </summary>
        PostConvolutionAlphaScale = 0x801f,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F
        /// </summary>
        PostConvolutionAlphaScaleExt = 0x801f,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_BIAS = 0x8020
        /// </summary>
        PostConvolutionRedBias = 0x8020,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_BIAS_EXT = 0x8020
        /// </summary>
        PostConvolutionRedBiasExt = 0x8020,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021
        /// </summary>
        PostConvolutionGreenBias = 0x8021,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021
        /// </summary>
        PostConvolutionGreenBiasExt = 0x8021,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022
        /// </summary>
        PostConvolutionBlueBias = 0x8022,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022
        /// </summary>
        PostConvolutionBlueBiasExt = 0x8022,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023
        /// </summary>
        PostConvolutionAlphaBias = 0x8023,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023
        /// </summary>
        PostConvolutionAlphaBiasExt = 0x8023,

        /// <summary>
        /// Original was GL_HISTOGRAM = 0x8024
        /// </summary>
        Histogram = 0x8024,

        /// <summary>
        /// Original was GL_HISTOGRAM_EXT = 0x8024
        /// </summary>
        HistogramExt = 0x8024,

        /// <summary>
        /// Original was GL_PROXY_HISTOGRAM = 0x8025
        /// </summary>
        ProxyHistogram = 0x8025,

        /// <summary>
        /// Original was GL_PROXY_HISTOGRAM_EXT = 0x8025
        /// </summary>
        ProxyHistogramExt = 0x8025,

        /// <summary>
        /// Original was GL_HISTOGRAM_WIDTH = 0x8026
        /// </summary>
        HistogramWidth = 0x8026,

        /// <summary>
        /// Original was GL_HISTOGRAM_WIDTH_EXT = 0x8026
        /// </summary>
        HistogramWidthExt = 0x8026,

        /// <summary>
        /// Original was GL_HISTOGRAM_FORMAT = 0x8027
        /// </summary>
        HistogramFormat = 0x8027,

        /// <summary>
        /// Original was GL_HISTOGRAM_FORMAT_EXT = 0x8027
        /// </summary>
        HistogramFormatExt = 0x8027,

        /// <summary>
        /// Original was GL_HISTOGRAM_RED_SIZE = 0x8028
        /// </summary>
        HistogramRedSize = 0x8028,

        /// <summary>
        /// Original was GL_HISTOGRAM_RED_SIZE_EXT = 0x8028
        /// </summary>
        HistogramRedSizeExt = 0x8028,

        /// <summary>
        /// Original was GL_HISTOGRAM_GREEN_SIZE = 0x8029
        /// </summary>
        HistogramGreenSize = 0x8029,

        /// <summary>
        /// Original was GL_HISTOGRAM_GREEN_SIZE_EXT = 0x8029
        /// </summary>
        HistogramGreenSizeExt = 0x8029,

        /// <summary>
        /// Original was GL_HISTOGRAM_BLUE_SIZE = 0x802A
        /// </summary>
        HistogramBlueSize = 0x802a,

        /// <summary>
        /// Original was GL_HISTOGRAM_BLUE_SIZE_EXT = 0x802A
        /// </summary>
        HistogramBlueSizeExt = 0x802a,

        /// <summary>
        /// Original was GL_HISTOGRAM_ALPHA_SIZE = 0x802B
        /// </summary>
        HistogramAlphaSize = 0x802b,

        /// <summary>
        /// Original was GL_HISTOGRAM_ALPHA_SIZE_EXT = 0x802B
        /// </summary>
        HistogramAlphaSizeExt = 0x802b,

        /// <summary>
        /// Original was GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C
        /// </summary>
        HistogramLuminanceSize = 0x802c,

        /// <summary>
        /// Original was GL_HISTOGRAM_LUMINANCE_SIZE_EXT = 0x802C
        /// </summary>
        HistogramLuminanceSizeExt = 0x802c,

        /// <summary>
        /// Original was GL_HISTOGRAM_SINK = 0x802D
        /// </summary>
        HistogramSink = 0x802d,

        /// <summary>
        /// Original was GL_HISTOGRAM_SINK_EXT = 0x802D
        /// </summary>
        HistogramSinkExt = 0x802d,

        /// <summary>
        /// Original was GL_MINMAX = 0x802E
        /// </summary>
        Minmax = 0x802e,

        /// <summary>
        /// Original was GL_MINMAX_EXT = 0x802E
        /// </summary>
        MinmaxExt = 0x802e,

        /// <summary>
        /// Original was GL_MINMAX_FORMAT = 0x802F
        /// </summary>
        MinmaxFormat = 0x802f,

        /// <summary>
        /// Original was GL_MINMAX_FORMAT_EXT = 0x802F
        /// </summary>
        MinmaxFormatExt = 0x802f,

        /// <summary>
        /// Original was GL_MINMAX_SINK = 0x8030
        /// </summary>
        MinmaxSink = 0x8030,

        /// <summary>
        /// Original was GL_MINMAX_SINK_EXT = 0x8030
        /// </summary>
        MinmaxSinkExt = 0x8030,

        /// <summary>
        /// Original was GL_TABLE_TOO_LARGE = 0x8031
        /// </summary>
        TableTooLarge = 0x8031,

        /// <summary>
        /// Original was GL_TABLE_TOO_LARGE_EXT = 0x8031
        /// </summary>
        TableTooLargeExt = 0x8031,

        /// <summary>
        /// Original was GL_UNSIGNED_BYTE_3_3_2 = 0x8032
        /// </summary>
        UnsignedByte332 = 0x8032,

        /// <summary>
        /// Original was GL_UNSIGNED_BYTE_3_3_2_EXT = 0x8032
        /// </summary>
        UnsignedByte332Ext = 0x8032,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033
        /// </summary>
        UnsignedShort4444 = 0x8033,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033
        /// </summary>
        UnsignedShort4444Ext = 0x8033,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034
        /// </summary>
        UnsignedShort5551 = 0x8034,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034
        /// </summary>
        UnsignedShort5551Ext = 0x8034,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_8_8_8_8 = 0x8035
        /// </summary>
        UnsignedInt8888 = 0x8035,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_8_8_8_8_EXT = 0x8035
        /// </summary>
        UnsignedInt8888Ext = 0x8035,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_10_10_10_2 = 0x8036
        /// </summary>
        UnsignedInt1010102 = 0x8036,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_10_10_10_2_EXT = 0x8036
        /// </summary>
        UnsignedInt1010102Ext = 0x8036,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FILL = 0x8037
        /// </summary>
        PolygonOffsetFill = 0x8037,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FACTOR = 0x8038
        /// </summary>
        PolygonOffsetFactor = 0x8038,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_BIAS_EXT = 0x8039
        /// </summary>
        PolygonOffsetBiasExt = 0x8039,

        /// <summary>
        /// Original was GL_RESCALE_NORMAL = 0x803A
        /// </summary>
        RescaleNormal = 0x803a,

        /// <summary>
        /// Original was GL_RESCALE_NORMAL_EXT = 0x803A
        /// </summary>
        RescaleNormalExt = 0x803a,

        /// <summary>
        /// Original was GL_ALPHA4 = 0x803B
        /// </summary>
        Alpha4 = 0x803b,

        /// <summary>
        /// Original was GL_ALPHA8 = 0x803C
        /// </summary>
        Alpha8 = 0x803c,

        /// <summary>
        /// Original was GL_ALPHA8_EXT = 0x803C
        /// </summary>
        Alpha8Ext = 0x803c,

        /// <summary>
        /// Original was GL_ALPHA8_OES = 0x803C
        /// </summary>
        Alpha8Oes = 0x803c,

        /// <summary>
        /// Original was GL_ALPHA12 = 0x803D
        /// </summary>
        Alpha12 = 0x803d,

        /// <summary>
        /// Original was GL_ALPHA16 = 0x803E
        /// </summary>
        Alpha16 = 0x803e,

        /// <summary>
        /// Original was GL_LUMINANCE4 = 0x803F
        /// </summary>
        Luminance4 = 0x803f,

        /// <summary>
        /// Original was GL_LUMINANCE8 = 0x8040
        /// </summary>
        Luminance8 = 0x8040,

        /// <summary>
        /// Original was GL_LUMINANCE8_EXT = 0x8040
        /// </summary>
        Luminance8Ext = 0x8040,

        /// <summary>
        /// Original was GL_LUMINANCE8_OES = 0x8040
        /// </summary>
        Luminance8Oes = 0x8040,

        /// <summary>
        /// Original was GL_LUMINANCE12 = 0x8041
        /// </summary>
        Luminance12 = 0x8041,

        /// <summary>
        /// Original was GL_LUMINANCE16 = 0x8042
        /// </summary>
        Luminance16 = 0x8042,

        /// <summary>
        /// Original was GL_LUMINANCE4_ALPHA4 = 0x8043
        /// </summary>
        Luminance4Alpha4 = 0x8043,

        /// <summary>
        /// Original was GL_LUMINANCE4_ALPHA4_OES = 0x8043
        /// </summary>
        Luminance4Alpha4Oes = 0x8043,

        /// <summary>
        /// Original was GL_LUMINANCE6_ALPHA2 = 0x8044
        /// </summary>
        Luminance6Alpha2 = 0x8044,

        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8 = 0x8045
        /// </summary>
        Luminance8Alpha8 = 0x8045,

        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8_EXT = 0x8045
        /// </summary>
        Luminance8Alpha8Ext = 0x8045,

        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8_OES = 0x8045
        /// </summary>
        Luminance8Alpha8Oes = 0x8045,

        /// <summary>
        /// Original was GL_LUMINANCE12_ALPHA4 = 0x8046
        /// </summary>
        Luminance12Alpha4 = 0x8046,

        /// <summary>
        /// Original was GL_LUMINANCE12_ALPHA12 = 0x8047
        /// </summary>
        Luminance12Alpha12 = 0x8047,

        /// <summary>
        /// Original was GL_LUMINANCE16_ALPHA16 = 0x8048
        /// </summary>
        Luminance16Alpha16 = 0x8048,

        /// <summary>
        /// Original was GL_INTENSITY = 0x8049
        /// </summary>
        Intensity = 0x8049,

        /// <summary>
        /// Original was GL_INTENSITY4 = 0x804A
        /// </summary>
        Intensity4 = 0x804a,

        /// <summary>
        /// Original was GL_INTENSITY8 = 0x804B
        /// </summary>
        Intensity8 = 0x804b,

        /// <summary>
        /// Original was GL_INTENSITY12 = 0x804C
        /// </summary>
        Intensity12 = 0x804c,

        /// <summary>
        /// Original was GL_INTENSITY16 = 0x804D
        /// </summary>
        Intensity16 = 0x804d,

        /// <summary>
        /// Original was GL_RGB2_EXT = 0x804E
        /// </summary>
        Rgb2Ext = 0x804e,

        /// <summary>
        /// Original was GL_RGB4 = 0x804F
        /// </summary>
        Rgb4 = 0x804f,

        /// <summary>
        /// Original was GL_RGB4_EXT = 0x804F
        /// </summary>
        Rgb4Ext = 0x804f,

        /// <summary>
        /// Original was GL_RGB5 = 0x8050
        /// </summary>
        Rgb5 = 0x8050,

        /// <summary>
        /// Original was GL_RGB5_EXT = 0x8050
        /// </summary>
        Rgb5Ext = 0x8050,

        /// <summary>
        /// Original was GL_RGB8 = 0x8051
        /// </summary>
        Rgb8 = 0x8051,

        /// <summary>
        /// Original was GL_RGB8_EXT = 0x8051
        /// </summary>
        Rgb8Ext = 0x8051,

        /// <summary>
        /// Original was GL_RGB8_OES = 0x8051
        /// </summary>
        Rgb8Oes = 0x8051,

        /// <summary>
        /// Original was GL_RGB10 = 0x8052
        /// </summary>
        Rgb10 = 0x8052,

        /// <summary>
        /// Original was GL_RGB10_EXT = 0x8052
        /// </summary>
        Rgb10Ext = 0x8052,

        /// <summary>
        /// Original was GL_RGB12 = 0x8053
        /// </summary>
        Rgb12 = 0x8053,

        /// <summary>
        /// Original was GL_RGB12_EXT = 0x8053
        /// </summary>
        Rgb12Ext = 0x8053,

        /// <summary>
        /// Original was GL_RGB16 = 0x8054
        /// </summary>
        Rgb16 = 0x8054,

        /// <summary>
        /// Original was GL_RGB16_EXT = 0x8054
        /// </summary>
        Rgb16Ext = 0x8054,

        /// <summary>
        /// Original was GL_RGBA4 = 0x8056
        /// </summary>
        Rgba4 = 0x8056,

        /// <summary>
        /// Original was GL_RGBA4_EXT = 0x8056
        /// </summary>
        Rgba4Ext = 0x8056,

        /// <summary>
        /// Original was GL_RGBA4_OES = 0x8056
        /// </summary>
        Rgba4Oes = 0x8056,

        /// <summary>
        /// Original was GL_RGB5_A1 = 0x8057
        /// </summary>
        Rgb5A1 = 0x8057,

        /// <summary>
        /// Original was GL_RGB5_A1_EXT = 0x8057
        /// </summary>
        Rgb5A1Ext = 0x8057,

        /// <summary>
        /// Original was GL_RGB5_A1_OES = 0x8057
        /// </summary>
        Rgb5A1Oes = 0x8057,

        /// <summary>
        /// Original was GL_RGBA8 = 0x8058
        /// </summary>
        Rgba8 = 0x8058,

        /// <summary>
        /// Original was GL_RGBA8_EXT = 0x8058
        /// </summary>
        Rgba8Ext = 0x8058,

        /// <summary>
        /// Original was GL_RGBA8_OES = 0x8058
        /// </summary>
        Rgba8Oes = 0x8058,

        /// <summary>
        /// Original was GL_RGB10_A2 = 0x8059
        /// </summary>
        Rgb10A2 = 0x8059,

        /// <summary>
        /// Original was GL_RGB10_A2_EXT = 0x8059
        /// </summary>
        Rgb10A2Ext = 0x8059,

        /// <summary>
        /// Original was GL_RGBA12 = 0x805A
        /// </summary>
        Rgba12 = 0x805a,

        /// <summary>
        /// Original was GL_RGBA12_EXT = 0x805A
        /// </summary>
        Rgba12Ext = 0x805a,

        /// <summary>
        /// Original was GL_RGBA16 = 0x805B
        /// </summary>
        Rgba16 = 0x805b,

        /// <summary>
        /// Original was GL_RGBA16_EXT = 0x805B
        /// </summary>
        Rgba16Ext = 0x805b,

        /// <summary>
        /// Original was GL_TEXTURE_RED_SIZE = 0x805C
        /// </summary>
        TextureRedSize = 0x805c,

        /// <summary>
        /// Original was GL_TEXTURE_GREEN_SIZE = 0x805D
        /// </summary>
        TextureGreenSize = 0x805d,

        /// <summary>
        /// Original was GL_TEXTURE_BLUE_SIZE = 0x805E
        /// </summary>
        TextureBlueSize = 0x805e,

        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_SIZE = 0x805F
        /// </summary>
        TextureAlphaSize = 0x805f,

        /// <summary>
        /// Original was GL_TEXTURE_LUMINANCE_SIZE = 0x8060
        /// </summary>
        TextureLuminanceSize = 0x8060,

        /// <summary>
        /// Original was GL_TEXTURE_INTENSITY_SIZE = 0x8061
        /// </summary>
        TextureIntensitySize = 0x8061,

        /// <summary>
        /// Original was GL_REPLACE_EXT = 0x8062
        /// </summary>
        ReplaceExt = 0x8062,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D = 0x8063
        /// </summary>
        ProxyTexture1D = 0x8063,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_EXT = 0x8063
        /// </summary>
        ProxyTexture1DExt = 0x8063,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D = 0x8064
        /// </summary>
        ProxyTexture2D = 0x8064,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_EXT = 0x8064
        /// </summary>
        ProxyTexture2DExt = 0x8064,

        /// <summary>
        /// Original was GL_TEXTURE_TOO_LARGE_EXT = 0x8065
        /// </summary>
        TextureTooLargeExt = 0x8065,

        /// <summary>
        /// Original was GL_TEXTURE_PRIORITY = 0x8066
        /// </summary>
        TexturePriority = 0x8066,

        /// <summary>
        /// Original was GL_TEXTURE_PRIORITY_EXT = 0x8066
        /// </summary>
        TexturePriorityExt = 0x8066,

        /// <summary>
        /// Original was GL_TEXTURE_RESIDENT = 0x8067
        /// </summary>
        TextureResident = 0x8067,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_1D = 0x8068
        /// </summary>
        TextureBinding1D = 0x8068,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D = 0x8069
        /// </summary>
        TextureBinding2D = 0x8069,

        /// <summary>
        /// Original was GL_TEXTURE_3D_BINDING_EXT = 0x806A
        /// </summary>
        Texture3DBindingExt = 0x806a,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_3D = 0x806A
        /// </summary>
        TextureBinding3D = 0x806a,

        /// <summary>
        /// Original was GL_PACK_SKIP_IMAGES = 0x806B
        /// </summary>
        PackSkipImages = 0x806b,

        /// <summary>
        /// Original was GL_PACK_SKIP_IMAGES_EXT = 0x806B
        /// </summary>
        PackSkipImagesExt = 0x806b,

        /// <summary>
        /// Original was GL_PACK_IMAGE_HEIGHT = 0x806C
        /// </summary>
        PackImageHeight = 0x806c,

        /// <summary>
        /// Original was GL_PACK_IMAGE_HEIGHT_EXT = 0x806C
        /// </summary>
        PackImageHeightExt = 0x806c,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_IMAGES = 0x806D
        /// </summary>
        UnpackSkipImages = 0x806d,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_IMAGES_EXT = 0x806D
        /// </summary>
        UnpackSkipImagesExt = 0x806d,

        /// <summary>
        /// Original was GL_UNPACK_IMAGE_HEIGHT = 0x806E
        /// </summary>
        UnpackImageHeight = 0x806e,

        /// <summary>
        /// Original was GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E
        /// </summary>
        UnpackImageHeightExt = 0x806e,

        /// <summary>
        /// Original was GL_TEXTURE_3D = 0x806F
        /// </summary>
        Texture3D = 0x806f,

        /// <summary>
        /// Original was GL_TEXTURE_3D_EXT = 0x806F
        /// </summary>
        Texture3DExt = 0x806f,

        /// <summary>
        /// Original was GL_TEXTURE_3D_OES = 0x806F
        /// </summary>
        Texture3DOes = 0x806f,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_3D = 0x8070
        /// </summary>
        ProxyTexture3D = 0x8070,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_3D_EXT = 0x8070
        /// </summary>
        ProxyTexture3DExt = 0x8070,

        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_EXT = 0x8071
        /// </summary>
        TextureDepthExt = 0x8071,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R = 0x8072
        /// </summary>
        TextureWrapR = 0x8072,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R_EXT = 0x8072
        /// </summary>
        TextureWrapRExt = 0x8072,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R_OES = 0x8072
        /// </summary>
        TextureWrapROes = 0x8072,

        /// <summary>
        /// Original was GL_MAX_3D_TEXTURE_SIZE_EXT = 0x8073
        /// </summary>
        Max3DTextureSizeExt = 0x8073,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = 0x8074,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_KHR = 0x8074
        /// </summary>
        VertexArrayKhr = 0x8074,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY = 0x8075
        /// </summary>
        NormalArray = 0x8075,

        /// <summary>
        /// Original was GL_COLOR_ARRAY = 0x8076
        /// </summary>
        ColorArray = 0x8076,

        /// <summary>
        /// Original was GL_INDEX_ARRAY = 0x8077
        /// </summary>
        IndexArray = 0x8077,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY = 0x8078
        /// </summary>
        TextureCoordArray = 0x8078,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY = 0x8079
        /// </summary>
        EdgeFlagArray = 0x8079,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_SIZE = 0x807A
        /// </summary>
        VertexArraySize = 0x807a,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_TYPE = 0x807B
        /// </summary>
        VertexArrayType = 0x807b,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_STRIDE = 0x807C
        /// </summary>
        VertexArrayStride = 0x807c,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_COUNT_EXT = 0x807D
        /// </summary>
        VertexArrayCountExt = 0x807d,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_TYPE = 0x807E
        /// </summary>
        NormalArrayType = 0x807e,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_STRIDE = 0x807F
        /// </summary>
        NormalArrayStride = 0x807f,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_COUNT_EXT = 0x8080
        /// </summary>
        NormalArrayCountExt = 0x8080,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_SIZE = 0x8081
        /// </summary>
        ColorArraySize = 0x8081,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_TYPE = 0x8082
        /// </summary>
        ColorArrayType = 0x8082,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_STRIDE = 0x8083
        /// </summary>
        ColorArrayStride = 0x8083,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_COUNT_EXT = 0x8084
        /// </summary>
        ColorArrayCountExt = 0x8084,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_TYPE = 0x8085
        /// </summary>
        IndexArrayType = 0x8085,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_STRIDE = 0x8086
        /// </summary>
        IndexArrayStride = 0x8086,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_COUNT_EXT = 0x8087
        /// </summary>
        IndexArrayCountExt = 0x8087,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088
        /// </summary>
        TextureCoordArraySize = 0x8088,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089
        /// </summary>
        TextureCoordArrayType = 0x8089,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A
        /// </summary>
        TextureCoordArrayStride = 0x808a,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B
        /// </summary>
        TextureCoordArrayCountExt = 0x808b,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C
        /// </summary>
        EdgeFlagArrayStride = 0x808c,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D
        /// </summary>
        EdgeFlagArrayCountExt = 0x808d,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_POINTER = 0x808E
        /// </summary>
        VertexArrayPointer = 0x808e,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_POINTER_EXT = 0x808E
        /// </summary>
        VertexArrayPointerExt = 0x808e,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_POINTER = 0x808F
        /// </summary>
        NormalArrayPointer = 0x808f,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_POINTER_EXT = 0x808F
        /// </summary>
        NormalArrayPointerExt = 0x808f,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_POINTER = 0x8090
        /// </summary>
        ColorArrayPointer = 0x8090,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_POINTER_EXT = 0x8090
        /// </summary>
        ColorArrayPointerExt = 0x8090,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_POINTER = 0x8091
        /// </summary>
        IndexArrayPointer = 0x8091,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_POINTER_EXT = 0x8091
        /// </summary>
        IndexArrayPointerExt = 0x8091,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092
        /// </summary>
        TextureCoordArrayPointer = 0x8092,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092
        /// </summary>
        TextureCoordArrayPointerExt = 0x8092,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_POINTER = 0x8093
        /// </summary>
        EdgeFlagArrayPointer = 0x8093,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_POINTER_EXT = 0x8093
        /// </summary>
        EdgeFlagArrayPointerExt = 0x8093,

        /// <summary>
        /// Original was GL_INTERLACE_SGIX = 0x8094
        /// </summary>
        InterlaceSgix = 0x8094,

        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_2D_SGIS = 0x8095
        /// </summary>
        DetailTexture2DSgis = 0x8095,

        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096
        /// </summary>
        DetailTexture2DBindingSgis = 0x8096,

        /// <summary>
        /// Original was GL_LINEAR_DETAIL_SGIS = 0x8097
        /// </summary>
        LinearDetailSgis = 0x8097,

        /// <summary>
        /// Original was GL_LINEAR_DETAIL_ALPHA_SGIS = 0x8098
        /// </summary>
        LinearDetailAlphaSgis = 0x8098,

        /// <summary>
        /// Original was GL_LINEAR_DETAIL_COLOR_SGIS = 0x8099
        /// </summary>
        LinearDetailColorSgis = 0x8099,

        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_LEVEL_SGIS = 0x809A
        /// </summary>
        DetailTextureLevelSgis = 0x809a,

        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_MODE_SGIS = 0x809B
        /// </summary>
        DetailTextureModeSgis = 0x809b,

        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C
        /// </summary>
        DetailTextureFuncPointsSgis = 0x809c,

        /// <summary>
        /// Original was GL_MULTISAMPLE = 0x809D
        /// </summary>
        Multisample = 0x809d,

        /// <summary>
        /// Original was GL_MULTISAMPLE_SGIS = 0x809D
        /// </summary>
        MultisampleSgis = 0x809d,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E
        /// </summary>
        SampleAlphaToCoverage = 0x809e,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E
        /// </summary>
        SampleAlphaToMaskSgis = 0x809e,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE = 0x809F
        /// </summary>
        SampleAlphaToOne = 0x809f,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F
        /// </summary>
        SampleAlphaToOneSgis = 0x809f,

        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE = 0x80A0
        /// </summary>
        SampleCoverage = 0x80a0,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_SGIS = 0x80A0
        /// </summary>
        SampleMaskSgis = 0x80a0,

        /// <summary>
        /// Original was GL_1PASS_EXT = 0x80A1
        /// </summary>
        Gl1PassExt = 0x80a1,

        /// <summary>
        /// Original was GL_1PASS_SGIS = 0x80A1
        /// </summary>
        Gl1PassSgis = 0x80a1,

        /// <summary>
        /// Original was GL_2PASS_0_EXT = 0x80A2
        /// </summary>
        Gl2Pass0Ext = 0x80a2,

        /// <summary>
        /// Original was GL_2PASS_0_SGIS = 0x80A2
        /// </summary>
        Gl2Pass0Sgis = 0x80a2,

        /// <summary>
        /// Original was GL_2PASS_1_EXT = 0x80A3
        /// </summary>
        Gl2Pass1Ext = 0x80a3,

        /// <summary>
        /// Original was GL_2PASS_1_SGIS = 0x80A3
        /// </summary>
        Gl2Pass1Sgis = 0x80a3,

        /// <summary>
        /// Original was GL_4PASS_0_EXT = 0x80A4
        /// </summary>
        Gl4Pass0Ext = 0x80a4,

        /// <summary>
        /// Original was GL_4PASS_0_SGIS = 0x80A4
        /// </summary>
        Gl4Pass0Sgis = 0x80a4,

        /// <summary>
        /// Original was GL_4PASS_1_EXT = 0x80A5
        /// </summary>
        Gl4Pass1Ext = 0x80a5,

        /// <summary>
        /// Original was GL_4PASS_1_SGIS = 0x80A5
        /// </summary>
        Gl4Pass1Sgis = 0x80a5,

        /// <summary>
        /// Original was GL_4PASS_2_EXT = 0x80A6
        /// </summary>
        Gl4Pass2Ext = 0x80a6,

        /// <summary>
        /// Original was GL_4PASS_2_SGIS = 0x80A6
        /// </summary>
        Gl4Pass2Sgis = 0x80a6,

        /// <summary>
        /// Original was GL_4PASS_3_EXT = 0x80A7
        /// </summary>
        Gl4Pass3Ext = 0x80a7,

        /// <summary>
        /// Original was GL_4PASS_3_SGIS = 0x80A7
        /// </summary>
        Gl4Pass3Sgis = 0x80a7,

        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS = 0x80A8
        /// </summary>
        SampleBuffers = 0x80a8,

        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS_SGIS = 0x80A8
        /// </summary>
        SampleBuffersSgis = 0x80a8,

        /// <summary>
        /// Original was GL_SAMPLES = 0x80A9
        /// </summary>
        Samples = 0x80a9,

        /// <summary>
        /// Original was GL_SAMPLES_SGIS = 0x80A9
        /// </summary>
        SamplesSgis = 0x80a9,

        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_VALUE = 0x80AA
        /// </summary>
        SampleCoverageValue = 0x80aa,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_VALUE_SGIS = 0x80AA
        /// </summary>
        SampleMaskValueSgis = 0x80aa,

        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_INVERT = 0x80AB
        /// </summary>
        SampleCoverageInvert = 0x80ab,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_INVERT_SGIS = 0x80AB
        /// </summary>
        SampleMaskInvertSgis = 0x80ab,

        /// <summary>
        /// Original was GL_SAMPLE_PATTERN_SGIS = 0x80AC
        /// </summary>
        SamplePatternSgis = 0x80ac,

        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_SGIS = 0x80AD
        /// </summary>
        LinearSharpenSgis = 0x80ad,

        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE
        /// </summary>
        LinearSharpenAlphaSgis = 0x80ae,

        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_COLOR_SGIS = 0x80AF
        /// </summary>
        LinearSharpenColorSgis = 0x80af,

        /// <summary>
        /// Original was GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0
        /// </summary>
        SharpenTextureFuncPointsSgis = 0x80b0,

        /// <summary>
        /// Original was GL_COLOR_MATRIX_SGI = 0x80B1
        /// </summary>
        ColorMatrixSgi = 0x80b1,

        /// <summary>
        /// Original was GL_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2
        /// </summary>
        ColorMatrixStackDepthSgi = 0x80b2,

        /// <summary>
        /// Original was GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3
        /// </summary>
        MaxColorMatrixStackDepthSgi = 0x80b3,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4
        /// </summary>
        PostColorMatrixRedScale = 0x80b4,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4
        /// </summary>
        PostColorMatrixRedScaleSgi = 0x80b4,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5
        /// </summary>
        PostColorMatrixGreenScale = 0x80b5,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5
        /// </summary>
        PostColorMatrixGreenScaleSgi = 0x80b5,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6
        /// </summary>
        PostColorMatrixBlueScale = 0x80b6,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6
        /// </summary>
        PostColorMatrixBlueScaleSgi = 0x80b6,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7
        /// </summary>
        PostColorMatrixAlphaScale = 0x80b7,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7
        /// </summary>
        PostColorMatrixAlphaScaleSgi = 0x80b7,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8
        /// </summary>
        PostColorMatrixRedBias = 0x80b8,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8
        /// </summary>
        PostColorMatrixRedBiasSgi = 0x80b8,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9
        /// </summary>
        PostColorMatrixGreenBias = 0x80b9,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9
        /// </summary>
        PostColorMatrixGreenBiasSgi = 0x80b9,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA
        /// </summary>
        PostColorMatrixBlueBias = 0x80ba,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA
        /// </summary>
        PostColorMatrixBlueBiasSgi = 0x80ba,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB
        /// </summary>
        PostColorMatrixAlphaBias = 0x80bb,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB
        /// </summary>
        PostColorMatrixAlphaBiasSgi = 0x80bb,

        /// <summary>
        /// Original was GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
        /// </summary>
        TextureColorTableSgi = 0x80bc,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_COLOR_TABLE_SGI = 0x80BD
        /// </summary>
        ProxyTextureColorTableSgi = 0x80bd,

        /// <summary>
        /// Original was GL_TEXTURE_ENV_BIAS_SGIX = 0x80BE
        /// </summary>
        TextureEnvBiasSgix = 0x80be,

        /// <summary>
        /// Original was GL_SHADOW_AMBIENT_SGIX = 0x80BF
        /// </summary>
        ShadowAmbientSgix = 0x80bf,

        /// <summary>
        /// Original was GL_BLEND_DST_RGB_OES = 0x80C8
        /// </summary>
        BlendDstRgbOes = 0x80c8,

        /// <summary>
        /// Original was GL_BLEND_SRC_RGB_OES = 0x80C9
        /// </summary>
        BlendSrcRgbOes = 0x80c9,

        /// <summary>
        /// Original was GL_BLEND_DST_ALPHA_OES = 0x80CA
        /// </summary>
        BlendDstAlphaOes = 0x80ca,

        /// <summary>
        /// Original was GL_BLEND_SRC_ALPHA_OES = 0x80CB
        /// </summary>
        BlendSrcAlphaOes = 0x80cb,

        /// <summary>
        /// Original was GL_COLOR_TABLE = 0x80D0
        /// </summary>
        ColorTable = 0x80d0,

        /// <summary>
        /// Original was GL_COLOR_TABLE_SGI = 0x80D0
        /// </summary>
        ColorTableSgi = 0x80d0,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1
        /// </summary>
        PostConvolutionColorTable = 0x80d1,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
        /// </summary>
        PostConvolutionColorTableSgi = 0x80d1,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2
        /// </summary>
        PostColorMatrixColorTable = 0x80d2,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
        /// </summary>
        PostColorMatrixColorTableSgi = 0x80d2,

        /// <summary>
        /// Original was GL_PROXY_COLOR_TABLE = 0x80D3
        /// </summary>
        ProxyColorTable = 0x80d3,

        /// <summary>
        /// Original was GL_PROXY_COLOR_TABLE_SGI = 0x80D3
        /// </summary>
        ProxyColorTableSgi = 0x80d3,

        /// <summary>
        /// Original was GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4
        /// </summary>
        ProxyPostConvolutionColorTable = 0x80d4,

        /// <summary>
        /// Original was GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D4
        /// </summary>
        ProxyPostConvolutionColorTableSgi = 0x80d4,

        /// <summary>
        /// Original was GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5
        /// </summary>
        ProxyPostColorMatrixColorTable = 0x80d5,

        /// <summary>
        /// Original was GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D5
        /// </summary>
        ProxyPostColorMatrixColorTableSgi = 0x80d5,

        /// <summary>
        /// Original was GL_COLOR_TABLE_SCALE = 0x80D6
        /// </summary>
        ColorTableScale = 0x80d6,

        /// <summary>
        /// Original was GL_COLOR_TABLE_SCALE_SGI = 0x80D6
        /// </summary>
        ColorTableScaleSgi = 0x80d6,

        /// <summary>
        /// Original was GL_COLOR_TABLE_BIAS = 0x80D7
        /// </summary>
        ColorTableBias = 0x80d7,

        /// <summary>
        /// Original was GL_COLOR_TABLE_BIAS_SGI = 0x80D7
        /// </summary>
        ColorTableBiasSgi = 0x80d7,

        /// <summary>
        /// Original was GL_COLOR_TABLE_FORMAT = 0x80D8
        /// </summary>
        ColorTableFormat = 0x80d8,

        /// <summary>
        /// Original was GL_COLOR_TABLE_FORMAT_SGI = 0x80D8
        /// </summary>
        ColorTableFormatSgi = 0x80d8,

        /// <summary>
        /// Original was GL_COLOR_TABLE_WIDTH = 0x80D9
        /// </summary>
        ColorTableWidth = 0x80d9,

        /// <summary>
        /// Original was GL_COLOR_TABLE_WIDTH_SGI = 0x80D9
        /// </summary>
        ColorTableWidthSgi = 0x80d9,

        /// <summary>
        /// Original was GL_COLOR_TABLE_RED_SIZE = 0x80DA
        /// </summary>
        ColorTableRedSize = 0x80da,

        /// <summary>
        /// Original was GL_COLOR_TABLE_RED_SIZE_SGI = 0x80DA
        /// </summary>
        ColorTableRedSizeSgi = 0x80da,

        /// <summary>
        /// Original was GL_COLOR_TABLE_GREEN_SIZE = 0x80DB
        /// </summary>
        ColorTableGreenSize = 0x80db,

        /// <summary>
        /// Original was GL_COLOR_TABLE_GREEN_SIZE_SGI = 0x80DB
        /// </summary>
        ColorTableGreenSizeSgi = 0x80db,

        /// <summary>
        /// Original was GL_COLOR_TABLE_BLUE_SIZE = 0x80DC
        /// </summary>
        ColorTableBlueSize = 0x80dc,

        /// <summary>
        /// Original was GL_COLOR_TABLE_BLUE_SIZE_SGI = 0x80DC
        /// </summary>
        ColorTableBlueSizeSgi = 0x80dc,

        /// <summary>
        /// Original was GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD
        /// </summary>
        ColorTableAlphaSize = 0x80dd,

        /// <summary>
        /// Original was GL_COLOR_TABLE_ALPHA_SIZE_SGI = 0x80DD
        /// </summary>
        ColorTableAlphaSizeSgi = 0x80dd,

        /// <summary>
        /// Original was GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE
        /// </summary>
        ColorTableLuminanceSize = 0x80de,

        /// <summary>
        /// Original was GL_COLOR_TABLE_LUMINANCE_SIZE_SGI = 0x80DE
        /// </summary>
        ColorTableLuminanceSizeSgi = 0x80de,

        /// <summary>
        /// Original was GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF
        /// </summary>
        ColorTableIntensitySize = 0x80df,

        /// <summary>
        /// Original was GL_COLOR_TABLE_INTENSITY_SIZE_SGI = 0x80DF
        /// </summary>
        ColorTableIntensitySizeSgi = 0x80df,

        /// <summary>
        /// Original was GL_BGRA = 0x80E1
        /// </summary>
        Bgra = 0x80e1,

        /// <summary>
        /// Original was GL_BGRA_EXT = 0x80E1
        /// </summary>
        BgraExt = 0x80e1,

        /// <summary>
        /// Original was GL_BGRA_IMG = 0x80E1
        /// </summary>
        BgraImg = 0x80e1,

        /// <summary>
        /// Original was GL_PHONG_HINT_WIN = 0x80EB
        /// </summary>
        PhongHintWin = 0x80eb,

        /// <summary>
        /// Original was GL_CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0
        /// </summary>
        ClipVolumeClippingHintExt = 0x80f0,

        /// <summary>
        /// Original was GL_DUAL_ALPHA4_SGIS = 0x8110
        /// </summary>
        DualAlpha4Sgis = 0x8110,

        /// <summary>
        /// Original was GL_DUAL_ALPHA8_SGIS = 0x8111
        /// </summary>
        DualAlpha8Sgis = 0x8111,

        /// <summary>
        /// Original was GL_DUAL_ALPHA12_SGIS = 0x8112
        /// </summary>
        DualAlpha12Sgis = 0x8112,

        /// <summary>
        /// Original was GL_DUAL_ALPHA16_SGIS = 0x8113
        /// </summary>
        DualAlpha16Sgis = 0x8113,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE4_SGIS = 0x8114
        /// </summary>
        DualLuminance4Sgis = 0x8114,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE8_SGIS = 0x8115
        /// </summary>
        DualLuminance8Sgis = 0x8115,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE12_SGIS = 0x8116
        /// </summary>
        DualLuminance12Sgis = 0x8116,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE16_SGIS = 0x8117
        /// </summary>
        DualLuminance16Sgis = 0x8117,

        /// <summary>
        /// Original was GL_DUAL_INTENSITY4_SGIS = 0x8118
        /// </summary>
        DualIntensity4Sgis = 0x8118,

        /// <summary>
        /// Original was GL_DUAL_INTENSITY8_SGIS = 0x8119
        /// </summary>
        DualIntensity8Sgis = 0x8119,

        /// <summary>
        /// Original was GL_DUAL_INTENSITY12_SGIS = 0x811A
        /// </summary>
        DualIntensity12Sgis = 0x811a,

        /// <summary>
        /// Original was GL_DUAL_INTENSITY16_SGIS = 0x811B
        /// </summary>
        DualIntensity16Sgis = 0x811b,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C
        /// </summary>
        DualLuminanceAlpha4Sgis = 0x811c,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D
        /// </summary>
        DualLuminanceAlpha8Sgis = 0x811d,

        /// <summary>
        /// Original was GL_QUAD_ALPHA4_SGIS = 0x811E
        /// </summary>
        QuadAlpha4Sgis = 0x811e,

        /// <summary>
        /// Original was GL_QUAD_ALPHA8_SGIS = 0x811F
        /// </summary>
        QuadAlpha8Sgis = 0x811f,

        /// <summary>
        /// Original was GL_QUAD_LUMINANCE4_SGIS = 0x8120
        /// </summary>
        QuadLuminance4Sgis = 0x8120,

        /// <summary>
        /// Original was GL_QUAD_LUMINANCE8_SGIS = 0x8121
        /// </summary>
        QuadLuminance8Sgis = 0x8121,

        /// <summary>
        /// Original was GL_QUAD_INTENSITY4_SGIS = 0x8122
        /// </summary>
        QuadIntensity4Sgis = 0x8122,

        /// <summary>
        /// Original was GL_QUAD_INTENSITY8_SGIS = 0x8123
        /// </summary>
        QuadIntensity8Sgis = 0x8123,

        /// <summary>
        /// Original was GL_DUAL_TEXTURE_SELECT_SGIS = 0x8124
        /// </summary>
        DualTextureSelectSgis = 0x8124,

        /// <summary>
        /// Original was GL_QUAD_TEXTURE_SELECT_SGIS = 0x8125
        /// </summary>
        QuadTextureSelectSgis = 0x8125,

        /// <summary>
        /// Original was GL_POINT_SIZE_MIN = 0x8126
        /// </summary>
        PointSizeMin = 0x8126,

        /// <summary>
        /// Original was GL_POINT_SIZE_MIN_ARB = 0x8126
        /// </summary>
        PointSizeMinArb = 0x8126,

        /// <summary>
        /// Original was GL_POINT_SIZE_MIN_EXT = 0x8126
        /// </summary>
        PointSizeMinExt = 0x8126,

        /// <summary>
        /// Original was GL_POINT_SIZE_MIN_SGIS = 0x8126
        /// </summary>
        PointSizeMinSgis = 0x8126,

        /// <summary>
        /// Original was GL_POINT_SIZE_MAX = 0x8127
        /// </summary>
        PointSizeMax = 0x8127,

        /// <summary>
        /// Original was GL_POINT_SIZE_MAX_ARB = 0x8127
        /// </summary>
        PointSizeMaxArb = 0x8127,

        /// <summary>
        /// Original was GL_POINT_SIZE_MAX_EXT = 0x8127
        /// </summary>
        PointSizeMaxExt = 0x8127,

        /// <summary>
        /// Original was GL_POINT_SIZE_MAX_SGIS = 0x8127
        /// </summary>
        PointSizeMaxSgis = 0x8127,

        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE = 0x8128
        /// </summary>
        PointFadeThresholdSize = 0x8128,

        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128
        /// </summary>
        PointFadeThresholdSizeArb = 0x8128,

        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128
        /// </summary>
        PointFadeThresholdSizeExt = 0x8128,

        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128
        /// </summary>
        PointFadeThresholdSizeSgis = 0x8128,

        /// <summary>
        /// Original was GL_DISTANCE_ATTENUATION_EXT = 0x8129
        /// </summary>
        DistanceAttenuationExt = 0x8129,

        /// <summary>
        /// Original was GL_DISTANCE_ATTENUATION_SGIS = 0x8129
        /// </summary>
        DistanceAttenuationSgis = 0x8129,

        /// <summary>
        /// Original was GL_POINT_DISTANCE_ATTENUATION = 0x8129
        /// </summary>
        PointDistanceAttenuation = 0x8129,

        /// <summary>
        /// Original was GL_POINT_DISTANCE_ATTENUATION_ARB = 0x8129
        /// </summary>
        PointDistanceAttenuationArb = 0x8129,

        /// <summary>
        /// Original was GL_FOG_FUNC_SGIS = 0x812A
        /// </summary>
        FogFuncSgis = 0x812a,

        /// <summary>
        /// Original was GL_FOG_FUNC_POINTS_SGIS = 0x812B
        /// </summary>
        FogFuncPointsSgis = 0x812b,

        /// <summary>
        /// Original was GL_MAX_FOG_FUNC_POINTS_SGIS = 0x812C
        /// </summary>
        MaxFogFuncPointsSgis = 0x812c,

        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER = 0x812D
        /// </summary>
        ClampToBorder = 0x812d,

        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER_ARB = 0x812D
        /// </summary>
        ClampToBorderArb = 0x812d,

        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER_NV = 0x812D
        /// </summary>
        ClampToBorderNv = 0x812d,

        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER_SGIS = 0x812D
        /// </summary>
        ClampToBorderSgis = 0x812d,

        /// <summary>
        /// Original was GL_TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E
        /// </summary>
        TextureMultiBufferHintSgix = 0x812e,

        /// <summary>
        /// Original was GL_CLAMP_TO_EDGE = 0x812F
        /// </summary>
        ClampToEdge = 0x812f,

        /// <summary>
        /// Original was GL_CLAMP_TO_EDGE_SGIS = 0x812F
        /// </summary>
        ClampToEdgeSgis = 0x812f,

        /// <summary>
        /// Original was GL_PACK_SKIP_VOLUMES_SGIS = 0x8130
        /// </summary>
        PackSkipVolumesSgis = 0x8130,

        /// <summary>
        /// Original was GL_PACK_IMAGE_DEPTH_SGIS = 0x8131
        /// </summary>
        PackImageDepthSgis = 0x8131,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_VOLUMES_SGIS = 0x8132
        /// </summary>
        UnpackSkipVolumesSgis = 0x8132,

        /// <summary>
        /// Original was GL_UNPACK_IMAGE_DEPTH_SGIS = 0x8133
        /// </summary>
        UnpackImageDepthSgis = 0x8133,

        /// <summary>
        /// Original was GL_TEXTURE_4D_SGIS = 0x8134
        /// </summary>
        Texture4DSgis = 0x8134,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_4D_SGIS = 0x8135
        /// </summary>
        ProxyTexture4DSgis = 0x8135,

        /// <summary>
        /// Original was GL_TEXTURE_4DSIZE_SGIS = 0x8136
        /// </summary>
        Texture4DsizeSgis = 0x8136,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_Q_SGIS = 0x8137
        /// </summary>
        TextureWrapQSgis = 0x8137,

        /// <summary>
        /// Original was GL_MAX_4D_TEXTURE_SIZE_SGIS = 0x8138
        /// </summary>
        Max4DTextureSizeSgis = 0x8138,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_SGIX = 0x8139
        /// </summary>
        PixelTexGenSgix = 0x8139,

        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD = 0x813A
        /// </summary>
        TextureMinLod = 0x813a,

        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD_SGIS = 0x813A
        /// </summary>
        TextureMinLodSgis = 0x813a,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD = 0x813B
        /// </summary>
        TextureMaxLod = 0x813b,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD_SGIS = 0x813B
        /// </summary>
        TextureMaxLodSgis = 0x813b,

        /// <summary>
        /// Original was GL_TEXTURE_BASE_LEVEL = 0x813C
        /// </summary>
        TextureBaseLevel = 0x813c,

        /// <summary>
        /// Original was GL_TEXTURE_BASE_LEVEL_SGIS = 0x813C
        /// </summary>
        TextureBaseLevelSgis = 0x813c,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL = 0x813D
        /// </summary>
        TextureMaxLevel = 0x813d,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL_APPLE = 0x813D
        /// </summary>
        TextureMaxLevelApple = 0x813d,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL_SGIS = 0x813D
        /// </summary>
        TextureMaxLevelSgis = 0x813d,

        /// <summary>
        /// Original was GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E
        /// </summary>
        PixelTileBestAlignmentSgix = 0x813e,

        /// <summary>
        /// Original was GL_PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F
        /// </summary>
        PixelTileCacheIncrementSgix = 0x813f,

        /// <summary>
        /// Original was GL_PIXEL_TILE_WIDTH_SGIX = 0x8140
        /// </summary>
        PixelTileWidthSgix = 0x8140,

        /// <summary>
        /// Original was GL_PIXEL_TILE_HEIGHT_SGIX = 0x8141
        /// </summary>
        PixelTileHeightSgix = 0x8141,

        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142
        /// </summary>
        PixelTileGridWidthSgix = 0x8142,

        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143
        /// </summary>
        PixelTileGridHeightSgix = 0x8143,

        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144
        /// </summary>
        PixelTileGridDepthSgix = 0x8144,

        /// <summary>
        /// Original was GL_PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145
        /// </summary>
        PixelTileCacheSizeSgix = 0x8145,

        /// <summary>
        /// Original was GL_FILTER4_SGIS = 0x8146
        /// </summary>
        Filter4Sgis = 0x8146,

        /// <summary>
        /// Original was GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147
        /// </summary>
        TextureFilter4SizeSgis = 0x8147,

        /// <summary>
        /// Original was GL_SPRITE_SGIX = 0x8148
        /// </summary>
        SpriteSgix = 0x8148,

        /// <summary>
        /// Original was GL_SPRITE_MODE_SGIX = 0x8149
        /// </summary>
        SpriteModeSgix = 0x8149,

        /// <summary>
        /// Original was GL_SPRITE_AXIS_SGIX = 0x814A
        /// </summary>
        SpriteAxisSgix = 0x814a,

        /// <summary>
        /// Original was GL_SPRITE_TRANSLATION_SGIX = 0x814B
        /// </summary>
        SpriteTranslationSgix = 0x814b,

        /// <summary>
        /// Original was GL_TEXTURE_4D_BINDING_SGIS = 0x814F
        /// </summary>
        Texture4DBindingSgis = 0x814f,

        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_COLOR = 0x8154
        /// </summary>
        ConvolutionBorderColor = 0x8154,

        /// <summary>
        /// Original was GL_LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170
        /// </summary>
        LinearClipmapLinearSgix = 0x8170,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171
        /// </summary>
        TextureClipmapCenterSgix = 0x8171,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172
        /// </summary>
        TextureClipmapFrameSgix = 0x8172,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173
        /// </summary>
        TextureClipmapOffsetSgix = 0x8173,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174
        /// </summary>
        TextureClipmapVirtualDepthSgix = 0x8174,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175
        /// </summary>
        TextureClipmapLodOffsetSgix = 0x8175,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176
        /// </summary>
        TextureClipmapDepthSgix = 0x8176,

        /// <summary>
        /// Original was GL_MAX_CLIPMAP_DEPTH_SGIX = 0x8177
        /// </summary>
        MaxClipmapDepthSgix = 0x8177,

        /// <summary>
        /// Original was GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178
        /// </summary>
        MaxClipmapVirtualDepthSgix = 0x8178,

        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179
        /// </summary>
        PostTextureFilterBiasSgix = 0x8179,

        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A
        /// </summary>
        PostTextureFilterScaleSgix = 0x817a,

        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B
        /// </summary>
        PostTextureFilterBiasRangeSgix = 0x817b,

        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C
        /// </summary>
        PostTextureFilterScaleRangeSgix = 0x817c,

        /// <summary>
        /// Original was GL_REFERENCE_PLANE_SGIX = 0x817D
        /// </summary>
        ReferencePlaneSgix = 0x817d,

        /// <summary>
        /// Original was GL_REFERENCE_PLANE_EQUATION_SGIX = 0x817E
        /// </summary>
        ReferencePlaneEquationSgix = 0x817e,

        /// <summary>
        /// Original was GL_IR_INSTRUMENT1_SGIX = 0x817F
        /// </summary>
        IrInstrument1Sgix = 0x817f,

        /// <summary>
        /// Original was GL_INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180
        /// </summary>
        InstrumentBufferPointerSgix = 0x8180,

        /// <summary>
        /// Original was GL_INSTRUMENT_MEASUREMENTS_SGIX = 0x8181
        /// </summary>
        InstrumentMeasurementsSgix = 0x8181,

        /// <summary>
        /// Original was GL_LIST_PRIORITY_SGIX = 0x8182
        /// </summary>
        ListPrioritySgix = 0x8182,

        /// <summary>
        /// Original was GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183
        /// </summary>
        CalligraphicFragmentSgix = 0x8183,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184
        /// </summary>
        PixelTexGenQCeilingSgix = 0x8184,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185
        /// </summary>
        PixelTexGenQRoundSgix = 0x8185,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186
        /// </summary>
        PixelTexGenQFloorSgix = 0x8186,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX = 0x8187
        /// </summary>
        PixelTexGenAlphaReplaceSgix = 0x8187,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX = 0x8188
        /// </summary>
        PixelTexGenAlphaNoReplaceSgix = 0x8188,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_ALPHA_LS_SGIX = 0x8189
        /// </summary>
        PixelTexGenAlphaLsSgix = 0x8189,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_ALPHA_MS_SGIX = 0x818A
        /// </summary>
        PixelTexGenAlphaMsSgix = 0x818a,

        /// <summary>
        /// Original was GL_FRAMEZOOM_SGIX = 0x818B
        /// </summary>
        FramezoomSgix = 0x818b,

        /// <summary>
        /// Original was GL_FRAMEZOOM_FACTOR_SGIX = 0x818C
        /// </summary>
        FramezoomFactorSgix = 0x818c,

        /// <summary>
        /// Original was GL_MAX_FRAMEZOOM_FACTOR_SGIX = 0x818D
        /// </summary>
        MaxFramezoomFactorSgix = 0x818d,

        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_S_SGIX = 0x818E
        /// </summary>
        TextureLodBiasSSgix = 0x818e,

        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_T_SGIX = 0x818F
        /// </summary>
        TextureLodBiasTSgix = 0x818f,

        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_R_SGIX = 0x8190
        /// </summary>
        TextureLodBiasRSgix = 0x8190,

        /// <summary>
        /// Original was GL_GENERATE_MIPMAP = 0x8191
        /// </summary>
        GenerateMipmap = 0x8191,

        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_SGIS = 0x8191
        /// </summary>
        GenerateMipmapSgis = 0x8191,

        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT = 0x8192
        /// </summary>
        GenerateMipmapHint = 0x8192,

        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192
        /// </summary>
        GenerateMipmapHintSgis = 0x8192,

        /// <summary>
        /// Original was GL_GEOMETRY_DEFORMATION_SGIX = 0x8194
        /// </summary>
        GeometryDeformationSgix = 0x8194,

        /// <summary>
        /// Original was GL_TEXTURE_DEFORMATION_SGIX = 0x8195
        /// </summary>
        TextureDeformationSgix = 0x8195,

        /// <summary>
        /// Original was GL_DEFORMATIONS_MASK_SGIX = 0x8196
        /// </summary>
        DeformationsMaskSgix = 0x8196,

        /// <summary>
        /// Original was GL_FOG_OFFSET_SGIX = 0x8198
        /// </summary>
        FogOffsetSgix = 0x8198,

        /// <summary>
        /// Original was GL_FOG_OFFSET_VALUE_SGIX = 0x8199
        /// </summary>
        FogOffsetValueSgix = 0x8199,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_SGIX = 0x819A
        /// </summary>
        TextureCompareSgix = 0x819a,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B
        /// </summary>
        TextureCompareOperatorSgix = 0x819b,

        /// <summary>
        /// Original was GL_TEXTURE_LEQUAL_R_SGIX = 0x819C
        /// </summary>
        TextureLequalRSgix = 0x819c,

        /// <summary>
        /// Original was GL_TEXTURE_GEQUAL_R_SGIX = 0x819D
        /// </summary>
        TextureGequalRSgix = 0x819d,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16 = 0x81A5
        /// </summary>
        DepthComponent16 = 0x81a5,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_ARB = 0x81A5
        /// </summary>
        DepthComponent16Arb = 0x81a5,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_OES = 0x81A5
        /// </summary>
        DepthComponent16Oes = 0x81a5,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_SGIX = 0x81A5
        /// </summary>
        DepthComponent16Sgix = 0x81a5,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_ARB = 0x81A6
        /// </summary>
        DepthComponent24Arb = 0x81a6,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_OES = 0x81A6
        /// </summary>
        DepthComponent24Oes = 0x81a6,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_SGIX = 0x81A6
        /// </summary>
        DepthComponent24Sgix = 0x81a6,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_ARB = 0x81A7
        /// </summary>
        DepthComponent32Arb = 0x81a7,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        /// </summary>
        DepthComponent32Oes = 0x81a7,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_SGIX = 0x81A7
        /// </summary>
        DepthComponent32Sgix = 0x81a7,

        /// <summary>
        /// Original was GL_YCRCB_422_SGIX = 0x81BB
        /// </summary>
        Ycrcb422Sgix = 0x81bb,

        /// <summary>
        /// Original was GL_YCRCB_444_SGIX = 0x81BC
        /// </summary>
        Ycrcb444Sgix = 0x81bc,

        /// <summary>
        /// Original was GL_EYE_DISTANCE_TO_POINT_SGIS = 0x81F0
        /// </summary>
        EyeDistanceToPointSgis = 0x81f0,

        /// <summary>
        /// Original was GL_OBJECT_DISTANCE_TO_POINT_SGIS = 0x81F1
        /// </summary>
        ObjectDistanceToPointSgis = 0x81f1,

        /// <summary>
        /// Original was GL_EYE_DISTANCE_TO_LINE_SGIS = 0x81F2
        /// </summary>
        EyeDistanceToLineSgis = 0x81f2,

        /// <summary>
        /// Original was GL_OBJECT_DISTANCE_TO_LINE_SGIS = 0x81F3
        /// </summary>
        ObjectDistanceToLineSgis = 0x81f3,

        /// <summary>
        /// Original was GL_EYE_POINT_SGIS = 0x81F4
        /// </summary>
        EyePointSgis = 0x81f4,

        /// <summary>
        /// Original was GL_OBJECT_POINT_SGIS = 0x81F5
        /// </summary>
        ObjectPointSgis = 0x81f5,

        /// <summary>
        /// Original was GL_EYE_LINE_SGIS = 0x81F6
        /// </summary>
        EyeLineSgis = 0x81f6,

        /// <summary>
        /// Original was GL_OBJECT_LINE_SGIS = 0x81F7
        /// </summary>
        ObjectLineSgis = 0x81f7,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8
        /// </summary>
        LightModelColorControl = 0x81f8,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_COLOR_CONTROL_EXT = 0x81F8
        /// </summary>
        LightModelColorControlExt = 0x81f8,

        /// <summary>
        /// Original was GL_SINGLE_COLOR = 0x81F9
        /// </summary>
        SingleColor = 0x81f9,

        /// <summary>
        /// Original was GL_SINGLE_COLOR_EXT = 0x81F9
        /// </summary>
        SingleColorExt = 0x81f9,

        /// <summary>
        /// Original was GL_SEPARATE_SPECULAR_COLOR = 0x81FA
        /// </summary>
        SeparateSpecularColor = 0x81fa,

        /// <summary>
        /// Original was GL_SEPARATE_SPECULAR_COLOR_EXT = 0x81FA
        /// </summary>
        SeparateSpecularColorExt = 0x81fa,

        /// <summary>
        /// Original was GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB
        /// </summary>
        SharedTexturePaletteExt = 0x81fb,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210
        /// </summary>
        FramebufferAttachmentColorEncoding = 0x8210,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT = 0x8210
        /// </summary>
        FramebufferAttachmentColorEncodingExt = 0x8210,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211
        /// </summary>
        FramebufferAttachmentComponentType = 0x8211,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212
        /// </summary>
        FramebufferAttachmentRedSize = 0x8212,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213
        /// </summary>
        FramebufferAttachmentGreenSize = 0x8213,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214
        /// </summary>
        FramebufferAttachmentBlueSize = 0x8214,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215
        /// </summary>
        FramebufferAttachmentAlphaSize = 0x8215,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216
        /// </summary>
        FramebufferAttachmentDepthSize = 0x8216,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217
        /// </summary>
        FramebufferAttachmentStencilSize = 0x8217,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNDEFINED = 0x8219
        /// </summary>
        FramebufferUndefined = 0x8219,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNDEFINED_OES = 0x8219
        /// </summary>
        FramebufferUndefinedOes = 0x8219,

        /// <summary>
        /// Original was GL_BUFFER_IMMUTABLE_STORAGE = 0x821F
        /// </summary>
        BufferImmutableStorage = 0x821f,

        /// <summary>
        /// Original was GL_BUFFER_STORAGE_FLAGS = 0x8220
        /// </summary>
        BufferStorageFlags = 0x8220,

        /// <summary>
        /// Original was GL_COMPRESSED_RED = 0x8225
        /// </summary>
        CompressedRed = 0x8225,

        /// <summary>
        /// Original was GL_COMPRESSED_RG = 0x8226
        /// </summary>
        CompressedRg = 0x8226,

        /// <summary>
        /// Original was GL_RG = 0x8227
        /// </summary>
        Rg = 0x8227,

        /// <summary>
        /// Original was GL_R8 = 0x8229
        /// </summary>
        R8 = 0x8229,

        /// <summary>
        /// Original was GL_R8_EXT = 0x8229
        /// </summary>
        R8Ext = 0x8229,

        /// <summary>
        /// Original was GL_R16 = 0x822A
        /// </summary>
        R16 = 0x822a,

        /// <summary>
        /// Original was GL_R16_EXT = 0x822A
        /// </summary>
        R16Ext = 0x822a,

        /// <summary>
        /// Original was GL_RG8 = 0x822B
        /// </summary>
        Rg8 = 0x822b,

        /// <summary>
        /// Original was GL_RG8_EXT = 0x822B
        /// </summary>
        Rg8Ext = 0x822b,

        /// <summary>
        /// Original was GL_RG16 = 0x822C
        /// </summary>
        Rg16 = 0x822c,

        /// <summary>
        /// Original was GL_RG16_EXT = 0x822C
        /// </summary>
        Rg16Ext = 0x822c,

        /// <summary>
        /// Original was GL_R16F = 0x822D
        /// </summary>
        R16f = 0x822d,

        /// <summary>
        /// Original was GL_R16F_EXT = 0x822D
        /// </summary>
        R16fExt = 0x822d,

        /// <summary>
        /// Original was GL_R32F = 0x822E
        /// </summary>
        R32f = 0x822e,

        /// <summary>
        /// Original was GL_R32F_EXT = 0x822E
        /// </summary>
        R32fExt = 0x822e,

        /// <summary>
        /// Original was GL_RG16F = 0x822F
        /// </summary>
        Rg16f = 0x822f,

        /// <summary>
        /// Original was GL_RG16F_EXT = 0x822F
        /// </summary>
        Rg16fExt = 0x822f,

        /// <summary>
        /// Original was GL_RG32F = 0x8230
        /// </summary>
        Rg32f = 0x8230,

        /// <summary>
        /// Original was GL_RG32F_EXT = 0x8230
        /// </summary>
        Rg32fExt = 0x8230,

        /// <summary>
        /// Original was GL_R8I = 0x8231
        /// </summary>
        R8i = 0x8231,

        /// <summary>
        /// Original was GL_R8UI = 0x8232
        /// </summary>
        R8ui = 0x8232,

        /// <summary>
        /// Original was GL_R16I = 0x8233
        /// </summary>
        R16i = 0x8233,

        /// <summary>
        /// Original was GL_R16UI = 0x8234
        /// </summary>
        R16ui = 0x8234,

        /// <summary>
        /// Original was GL_R32I = 0x8235
        /// </summary>
        R32i = 0x8235,

        /// <summary>
        /// Original was GL_R32UI = 0x8236
        /// </summary>
        R32ui = 0x8236,

        /// <summary>
        /// Original was GL_RG8I = 0x8237
        /// </summary>
        Rg8i = 0x8237,

        /// <summary>
        /// Original was GL_RG8UI = 0x8238
        /// </summary>
        Rg8ui = 0x8238,

        /// <summary>
        /// Original was GL_RG16I = 0x8239
        /// </summary>
        Rg16i = 0x8239,

        /// <summary>
        /// Original was GL_RG16UI = 0x823A
        /// </summary>
        Rg16ui = 0x823a,

        /// <summary>
        /// Original was GL_RG32I = 0x823B
        /// </summary>
        Rg32i = 0x823b,

        /// <summary>
        /// Original was GL_RG32UI = 0x823C
        /// </summary>
        Rg32ui = 0x823c,

        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242
        /// </summary>
        DebugOutputSynchronous = 0x8242,

        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_SYNCHRONOUS_KHR = 0x8242
        /// </summary>
        DebugOutputSynchronousKhr = 0x8242,

        /// <summary>
        /// Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243
        /// </summary>
        DebugNextLoggedMessageLength = 0x8243,

        /// <summary>
        /// Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_KHR = 0x8243
        /// </summary>
        DebugNextLoggedMessageLengthKhr = 0x8243,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_FUNCTION = 0x8244
        /// </summary>
        DebugCallbackFunction = 0x8244,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_FUNCTION_KHR = 0x8244
        /// </summary>
        DebugCallbackFunctionKhr = 0x8244,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_USER_PARAM = 0x8245
        /// </summary>
        DebugCallbackUserParam = 0x8245,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_USER_PARAM_KHR = 0x8245
        /// </summary>
        DebugCallbackUserParamKhr = 0x8245,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_API = 0x8246
        /// </summary>
        DebugSourceApi = 0x8246,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_API_KHR = 0x8246
        /// </summary>
        DebugSourceApiKhr = 0x8246,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247
        /// </summary>
        DebugSourceWindowSystem = 0x8247,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM_KHR = 0x8247
        /// </summary>
        DebugSourceWindowSystemKhr = 0x8247,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248
        /// </summary>
        DebugSourceShaderCompiler = 0x8248,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_SHADER_COMPILER_KHR = 0x8248
        /// </summary>
        DebugSourceShaderCompilerKhr = 0x8248,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249
        /// </summary>
        DebugSourceThirdParty = 0x8249,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_THIRD_PARTY_KHR = 0x8249
        /// </summary>
        DebugSourceThirdPartyKhr = 0x8249,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_APPLICATION = 0x824A
        /// </summary>
        DebugSourceApplication = 0x824a,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_APPLICATION_KHR = 0x824A
        /// </summary>
        DebugSourceApplicationKhr = 0x824a,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_OTHER = 0x824B
        /// </summary>
        DebugSourceOther = 0x824b,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_OTHER_KHR = 0x824B
        /// </summary>
        DebugSourceOtherKhr = 0x824b,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_ERROR = 0x824C
        /// </summary>
        DebugTypeError = 0x824c,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_ERROR_KHR = 0x824C
        /// </summary>
        DebugTypeErrorKhr = 0x824c,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D
        /// </summary>
        DebugTypeDeprecatedBehavior = 0x824d,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_KHR = 0x824D
        /// </summary>
        DebugTypeDeprecatedBehaviorKhr = 0x824d,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E
        /// </summary>
        DebugTypeUndefinedBehavior = 0x824e,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_KHR = 0x824E
        /// </summary>
        DebugTypeUndefinedBehaviorKhr = 0x824e,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PORTABILITY = 0x824F
        /// </summary>
        DebugTypePortability = 0x824f,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PORTABILITY_KHR = 0x824F
        /// </summary>
        DebugTypePortabilityKhr = 0x824f,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PERFORMANCE = 0x8250
        /// </summary>
        DebugTypePerformance = 0x8250,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PERFORMANCE_KHR = 0x8250
        /// </summary>
        DebugTypePerformanceKhr = 0x8250,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_OTHER = 0x8251
        /// </summary>
        DebugTypeOther = 0x8251,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_OTHER_KHR = 0x8251
        /// </summary>
        DebugTypeOtherKhr = 0x8251,

        /// <summary>
        /// Original was GL_LOSE_CONTEXT_ON_RESET_EXT = 0x8252
        /// </summary>
        LoseContextOnResetExt = 0x8252,

        /// <summary>
        /// Original was GL_GUILTY_CONTEXT_RESET = 0x8253
        /// </summary>
        GuiltyContextReset = 0x8253,

        /// <summary>
        /// Original was GL_GUILTY_CONTEXT_RESET_EXT = 0x8253
        /// </summary>
        GuiltyContextResetExt = 0x8253,

        /// <summary>
        /// Original was GL_INNOCENT_CONTEXT_RESET = 0x8254
        /// </summary>
        InnocentContextReset = 0x8254,

        /// <summary>
        /// Original was GL_INNOCENT_CONTEXT_RESET_EXT = 0x8254
        /// </summary>
        InnocentContextResetExt = 0x8254,

        /// <summary>
        /// Original was GL_UNKNOWN_CONTEXT_RESET = 0x8255
        /// </summary>
        UnknownContextReset = 0x8255,

        /// <summary>
        /// Original was GL_UNKNOWN_CONTEXT_RESET_EXT = 0x8255
        /// </summary>
        UnknownContextResetExt = 0x8255,

        /// <summary>
        /// Original was GL_RESET_NOTIFICATION_STRATEGY_EXT = 0x8256
        /// </summary>
        ResetNotificationStrategyExt = 0x8256,

        /// <summary>
        /// Original was GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
        /// </summary>
        ProgramBinaryRetrievableHint = 0x8257,

        /// <summary>
        /// Original was GL_PROGRAM_SEPARABLE = 0x8258
        /// </summary>
        ProgramSeparable = 0x8258,

        /// <summary>
        /// Original was GL_ACTIVE_PROGRAM = 0x8259
        /// </summary>
        ActiveProgram = 0x8259,

        /// <summary>
        /// Original was GL_NO_RESET_NOTIFICATION_EXT = 0x8261
        /// </summary>
        NoResetNotificationExt = 0x8261,

        /// <summary>
        /// Original was GL_COMPUTE_WORK_GROUP_SIZE = 0x8267
        /// </summary>
        ComputeWorkGroupSize = 0x8267,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_MARKER = 0x8268
        /// </summary>
        DebugTypeMarker = 0x8268,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_MARKER_KHR = 0x8268
        /// </summary>
        DebugTypeMarkerKhr = 0x8268,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PUSH_GROUP = 0x8269
        /// </summary>
        DebugTypePushGroup = 0x8269,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PUSH_GROUP_KHR = 0x8269
        /// </summary>
        DebugTypePushGroupKhr = 0x8269,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_POP_GROUP = 0x826A
        /// </summary>
        DebugTypePopGroup = 0x826a,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_POP_GROUP_KHR = 0x826A
        /// </summary>
        DebugTypePopGroupKhr = 0x826a,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B
        /// </summary>
        DebugSeverityNotification = 0x826b,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_NOTIFICATION_KHR = 0x826B
        /// </summary>
        DebugSeverityNotificationKhr = 0x826b,

        /// <summary>
        /// Original was GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C
        /// </summary>
        MaxDebugGroupStackDepth = 0x826c,

        /// <summary>
        /// Original was GL_MAX_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826C
        /// </summary>
        MaxDebugGroupStackDepthKhr = 0x826c,

        /// <summary>
        /// Original was GL_DEBUG_GROUP_STACK_DEPTH = 0x826D
        /// </summary>
        DebugGroupStackDepth = 0x826d,

        /// <summary>
        /// Original was GL_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826D
        /// </summary>
        DebugGroupStackDepthKhr = 0x826d,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_SUPPORTED = 0x826F
        /// </summary>
        InternalformatSupported = 0x826f,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_PREFERRED = 0x8270
        /// </summary>
        InternalformatPreferred = 0x8270,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_RED_SIZE = 0x8271
        /// </summary>
        InternalformatRedSize = 0x8271,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_GREEN_SIZE = 0x8272
        /// </summary>
        InternalformatGreenSize = 0x8272,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_BLUE_SIZE = 0x8273
        /// </summary>
        InternalformatBlueSize = 0x8273,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274
        /// </summary>
        InternalformatAlphaSize = 0x8274,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275
        /// </summary>
        InternalformatDepthSize = 0x8275,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276
        /// </summary>
        InternalformatStencilSize = 0x8276,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_SHARED_SIZE = 0x8277
        /// </summary>
        InternalformatSharedSize = 0x8277,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_RED_TYPE = 0x8278
        /// </summary>
        InternalformatRedType = 0x8278,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_GREEN_TYPE = 0x8279
        /// </summary>
        InternalformatGreenType = 0x8279,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_BLUE_TYPE = 0x827A
        /// </summary>
        InternalformatBlueType = 0x827a,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B
        /// </summary>
        InternalformatAlphaType = 0x827b,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C
        /// </summary>
        InternalformatDepthType = 0x827c,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D
        /// </summary>
        InternalformatStencilType = 0x827d,

        /// <summary>
        /// Original was GL_MAX_WIDTH = 0x827E
        /// </summary>
        MaxWidth = 0x827e,

        /// <summary>
        /// Original was GL_MAX_HEIGHT = 0x827F
        /// </summary>
        MaxHeight = 0x827f,

        /// <summary>
        /// Original was GL_MAX_DEPTH = 0x8280
        /// </summary>
        MaxDepth = 0x8280,

        /// <summary>
        /// Original was GL_MAX_LAYERS = 0x8281
        /// </summary>
        MaxLayers = 0x8281,

        /// <summary>
        /// Original was GL_COLOR_COMPONENTS = 0x8283
        /// </summary>
        ColorComponents = 0x8283,

        /// <summary>
        /// Original was GL_COLOR_RENDERABLE = 0x8286
        /// </summary>
        ColorRenderable = 0x8286,

        /// <summary>
        /// Original was GL_DEPTH_RENDERABLE = 0x8287
        /// </summary>
        DepthRenderable = 0x8287,

        /// <summary>
        /// Original was GL_STENCIL_RENDERABLE = 0x8288
        /// </summary>
        StencilRenderable = 0x8288,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_RENDERABLE = 0x8289
        /// </summary>
        FramebufferRenderable = 0x8289,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A
        /// </summary>
        FramebufferRenderableLayered = 0x828a,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BLEND = 0x828B
        /// </summary>
        FramebufferBlend = 0x828b,

        /// <summary>
        /// Original was GL_READ_PIXELS = 0x828C
        /// </summary>
        ReadPixels = 0x828c,

        /// <summary>
        /// Original was GL_READ_PIXELS_FORMAT = 0x828D
        /// </summary>
        ReadPixelsFormat = 0x828d,

        /// <summary>
        /// Original was GL_READ_PIXELS_TYPE = 0x828E
        /// </summary>
        ReadPixelsType = 0x828e,

        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_FORMAT = 0x828F
        /// </summary>
        TextureImageFormat = 0x828f,

        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_TYPE = 0x8290
        /// </summary>
        TextureImageType = 0x8290,

        /// <summary>
        /// Original was GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291
        /// </summary>
        GetTextureImageFormat = 0x8291,

        /// <summary>
        /// Original was GL_GET_TEXTURE_IMAGE_TYPE = 0x8292
        /// </summary>
        GetTextureImageType = 0x8292,

        /// <summary>
        /// Original was GL_MIPMAP = 0x8293
        /// </summary>
        Mipmap = 0x8293,

        /// <summary>
        /// Original was GL_AUTO_GENERATE_MIPMAP = 0x8295
        /// </summary>
        AutoGenerateMipmap = 0x8295,

        /// <summary>
        /// Original was GL_COLOR_ENCODING = 0x8296
        /// </summary>
        ColorEncoding = 0x8296,

        /// <summary>
        /// Original was GL_SRGB_READ = 0x8297
        /// </summary>
        SrgbRead = 0x8297,

        /// <summary>
        /// Original was GL_SRGB_WRITE = 0x8298
        /// </summary>
        SrgbWrite = 0x8298,

        /// <summary>
        /// Original was GL_FILTER = 0x829A
        /// </summary>
        Filter = 0x829a,

        /// <summary>
        /// Original was GL_VERTEX_TEXTURE = 0x829B
        /// </summary>
        VertexTexture = 0x829b,

        /// <summary>
        /// Original was GL_TESS_CONTROL_TEXTURE = 0x829C
        /// </summary>
        TessControlTexture = 0x829c,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_TEXTURE = 0x829D
        /// </summary>
        TessEvaluationTexture = 0x829d,

        /// <summary>
        /// Original was GL_GEOMETRY_TEXTURE = 0x829E
        /// </summary>
        GeometryTexture = 0x829e,

        /// <summary>
        /// Original was GL_FRAGMENT_TEXTURE = 0x829F
        /// </summary>
        FragmentTexture = 0x829f,

        /// <summary>
        /// Original was GL_COMPUTE_TEXTURE = 0x82A0
        /// </summary>
        ComputeTexture = 0x82a0,

        /// <summary>
        /// Original was GL_TEXTURE_SHADOW = 0x82A1
        /// </summary>
        TextureShadow = 0x82a1,

        /// <summary>
        /// Original was GL_TEXTURE_GATHER = 0x82A2
        /// </summary>
        TextureGather = 0x82a2,

        /// <summary>
        /// Original was GL_TEXTURE_GATHER_SHADOW = 0x82A3
        /// </summary>
        TextureGatherShadow = 0x82a3,

        /// <summary>
        /// Original was GL_SHADER_IMAGE_LOAD = 0x82A4
        /// </summary>
        ShaderImageLoad = 0x82a4,

        /// <summary>
        /// Original was GL_SHADER_IMAGE_STORE = 0x82A5
        /// </summary>
        ShaderImageStore = 0x82a5,

        /// <summary>
        /// Original was GL_SHADER_IMAGE_ATOMIC = 0x82A6
        /// </summary>
        ShaderImageAtomic = 0x82a6,

        /// <summary>
        /// Original was GL_IMAGE_TEXEL_SIZE = 0x82A7
        /// </summary>
        ImageTexelSize = 0x82a7,

        /// <summary>
        /// Original was GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8
        /// </summary>
        ImageCompatibilityClass = 0x82a8,

        /// <summary>
        /// Original was GL_IMAGE_PIXEL_FORMAT = 0x82A9
        /// </summary>
        ImagePixelFormat = 0x82a9,

        /// <summary>
        /// Original was GL_IMAGE_PIXEL_TYPE = 0x82AA
        /// </summary>
        ImagePixelType = 0x82aa,

        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC
        /// </summary>
        SimultaneousTextureAndDepthTest = 0x82ac,

        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD
        /// </summary>
        SimultaneousTextureAndStencilTest = 0x82ad,

        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE
        /// </summary>
        SimultaneousTextureAndDepthWrite = 0x82ae,

        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF
        /// </summary>
        SimultaneousTextureAndStencilWrite = 0x82af,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1
        /// </summary>
        TextureCompressedBlockWidth = 0x82b1,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2
        /// </summary>
        TextureCompressedBlockHeight = 0x82b2,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3
        /// </summary>
        TextureCompressedBlockSize = 0x82b3,

        /// <summary>
        /// Original was GL_CLEAR_BUFFER = 0x82B4
        /// </summary>
        ClearBuffer = 0x82b4,

        /// <summary>
        /// Original was GL_TEXTURE_VIEW = 0x82B5
        /// </summary>
        TextureView = 0x82b5,

        /// <summary>
        /// Original was GL_VIEW_COMPATIBILITY_CLASS = 0x82B6
        /// </summary>
        ViewCompatibilityClass = 0x82b6,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5
        /// </summary>
        VertexAttribRelativeOffset = 0x82d5,

        /// <summary>
        /// Original was GL_BUFFER = 0x82E0
        /// </summary>
        Buffer = 0x82e0,

        /// <summary>
        /// Original was GL_BUFFER_KHR = 0x82E0
        /// </summary>
        BufferKhr = 0x82e0,

        /// <summary>
        /// Original was GL_SHADER = 0x82E1
        /// </summary>
        Shader = 0x82e1,

        /// <summary>
        /// Original was GL_SHADER_KHR = 0x82E1
        /// </summary>
        ShaderKhr = 0x82e1,

        /// <summary>
        /// Original was GL_PROGRAM = 0x82E2
        /// </summary>
        Program = 0x82e2,

        /// <summary>
        /// Original was GL_PROGRAM_KHR = 0x82E2
        /// </summary>
        ProgramKhr = 0x82e2,

        /// <summary>
        /// Original was GL_QUERY = 0x82E3
        /// </summary>
        Query = 0x82e3,

        /// <summary>
        /// Original was GL_QUERY_KHR = 0x82E3
        /// </summary>
        QueryKhr = 0x82e3,

        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE = 0x82E4
        /// </summary>
        ProgramPipeline = 0x82e4,

        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE_KHR = 0x82E4
        /// </summary>
        ProgramPipelineKhr = 0x82e4,

        /// <summary>
        /// Original was GL_SAMPLER = 0x82E6
        /// </summary>
        Sampler = 0x82e6,

        /// <summary>
        /// Original was GL_SAMPLER_KHR = 0x82E6
        /// </summary>
        SamplerKhr = 0x82e6,

        /// <summary>
        /// Original was GL_DISPLAY_LIST = 0x82E7
        /// </summary>
        DisplayList = 0x82e7,

        /// <summary>
        /// Original was GL_MAX_LABEL_LENGTH = 0x82E8
        /// </summary>
        MaxLabelLength = 0x82e8,

        /// <summary>
        /// Original was GL_MAX_LABEL_LENGTH_KHR = 0x82E8
        /// </summary>
        MaxLabelLengthKhr = 0x82e8,

        /// <summary>
        /// Original was GL_QUERY_TARGET = 0x82EA
        /// </summary>
        QueryTarget = 0x82ea,

        /// <summary>
        /// Original was GL_CONVOLUTION_HINT_SGIX = 0x8316
        /// </summary>
        ConvolutionHintSgix = 0x8316,

        /// <summary>
        /// Original was GL_ALPHA_MIN_SGIX = 0x8320
        /// </summary>
        AlphaMinSgix = 0x8320,

        /// <summary>
        /// Original was GL_ALPHA_MAX_SGIX = 0x8321
        /// </summary>
        AlphaMaxSgix = 0x8321,

        /// <summary>
        /// Original was GL_SCALEBIAS_HINT_SGIX = 0x8322
        /// </summary>
        ScalebiasHintSgix = 0x8322,

        /// <summary>
        /// Original was GL_ASYNC_MARKER_SGIX = 0x8329
        /// </summary>
        AsyncMarkerSgix = 0x8329,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_MODE_SGIX = 0x832B
        /// </summary>
        PixelTexGenModeSgix = 0x832b,

        /// <summary>
        /// Original was GL_ASYNC_HISTOGRAM_SGIX = 0x832C
        /// </summary>
        AsyncHistogramSgix = 0x832c,

        /// <summary>
        /// Original was GL_MAX_ASYNC_HISTOGRAM_SGIX = 0x832D
        /// </summary>
        MaxAsyncHistogramSgix = 0x832d,

        /// <summary>
        /// Original was GL_PIXEL_TEXTURE_SGIS = 0x8353
        /// </summary>
        PixelTextureSgis = 0x8353,

        /// <summary>
        /// Original was GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354
        /// </summary>
        PixelFragmentRgbSourceSgis = 0x8354,

        /// <summary>
        /// Original was GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355
        /// </summary>
        PixelFragmentAlphaSourceSgis = 0x8355,

        /// <summary>
        /// Original was GL_LINE_QUALITY_HINT_SGIX = 0x835B
        /// </summary>
        LineQualityHintSgix = 0x835b,

        /// <summary>
        /// Original was GL_ASYNC_TEX_IMAGE_SGIX = 0x835C
        /// </summary>
        AsyncTexImageSgix = 0x835c,

        /// <summary>
        /// Original was GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D
        /// </summary>
        AsyncDrawPixelsSgix = 0x835d,

        /// <summary>
        /// Original was GL_ASYNC_READ_PIXELS_SGIX = 0x835E
        /// </summary>
        AsyncReadPixelsSgix = 0x835e,

        /// <summary>
        /// Original was GL_MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F
        /// </summary>
        MaxAsyncTexImageSgix = 0x835f,

        /// <summary>
        /// Original was GL_MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360
        /// </summary>
        MaxAsyncDrawPixelsSgix = 0x8360,

        /// <summary>
        /// Original was GL_MAX_ASYNC_READ_PIXELS_SGIX = 0x8361
        /// </summary>
        MaxAsyncReadPixelsSgix = 0x8361,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_6_5 = 0x8363
        /// </summary>
        UnsignedShort565 = 0x8363,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365
        /// </summary>
        UnsignedShort4444Rev = 0x8365,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT = 0x8365
        /// </summary>
        UnsignedShort4444RevExt = 0x8365,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG = 0x8365
        /// </summary>
        UnsignedShort4444RevImg = 0x8365,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366
        /// </summary>
        UnsignedShort1555Rev = 0x8366,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT = 0x8366
        /// </summary>
        UnsignedShort1555RevExt = 0x8366,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368
        /// </summary>
        UnsignedInt2101010Rev = 0x8368,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_S_SGIX = 0x8369
        /// </summary>
        TextureMaxClampSSgix = 0x8369,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_T_SGIX = 0x836A
        /// </summary>
        TextureMaxClampTSgix = 0x836a,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_R_SGIX = 0x836B
        /// </summary>
        TextureMaxClampRSgix = 0x836b,

        /// <summary>
        /// Original was GL_MIRRORED_REPEAT_OES = 0x8370
        /// </summary>
        MirroredRepeatOes = 0x8370,

        /// <summary>
        /// Original was GL_VERTEX_PRECLIP_SGIX = 0x83EE
        /// </summary>
        VertexPreclipSgix = 0x83ee,

        /// <summary>
        /// Original was GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF
        /// </summary>
        VertexPreclipHintSgix = 0x83ef,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0
        /// </summary>
        CompressedRgbS3tcDxt1Ext = 0x83f0,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1
        /// </summary>
        CompressedRgbaS3tcDxt1Ext = 0x83f1,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2
        /// </summary>
        CompressedRgbaS3tcDxt3Ext = 0x83f2,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3
        /// </summary>
        CompressedRgbaS3tcDxt5Ext = 0x83f3,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHTING_SGIX = 0x8400
        /// </summary>
        FragmentLightingSgix = 0x8400,

        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401
        /// </summary>
        FragmentColorMaterialSgix = 0x8401,

        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX = 0x8402
        /// </summary>
        FragmentColorMaterialFaceSgix = 0x8402,

        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = 0x8403
        /// </summary>
        FragmentColorMaterialParameterSgix = 0x8403,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_LIGHTS_SGIX = 0x8404
        /// </summary>
        MaxFragmentLightsSgix = 0x8404,

        /// <summary>
        /// Original was GL_MAX_ACTIVE_LIGHTS_SGIX = 0x8405
        /// </summary>
        MaxActiveLightsSgix = 0x8405,

        /// <summary>
        /// Original was GL_LIGHT_ENV_MODE_SGIX = 0x8407
        /// </summary>
        LightEnvModeSgix = 0x8407,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408
        /// </summary>
        FragmentLightModelLocalViewerSgix = 0x8408,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409
        /// </summary>
        FragmentLightModelTwoSideSgix = 0x8409,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A
        /// </summary>
        FragmentLightModelAmbientSgix = 0x840a,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B
        /// </summary>
        FragmentLightModelNormalInterpolationSgix = 0x840b,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT0_SGIX = 0x840C
        /// </summary>
        FragmentLight0Sgix = 0x840c,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT1_SGIX = 0x840D
        /// </summary>
        FragmentLight1Sgix = 0x840d,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT2_SGIX = 0x840E
        /// </summary>
        FragmentLight2Sgix = 0x840e,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT3_SGIX = 0x840F
        /// </summary>
        FragmentLight3Sgix = 0x840f,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT4_SGIX = 0x8410
        /// </summary>
        FragmentLight4Sgix = 0x8410,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT5_SGIX = 0x8411
        /// </summary>
        FragmentLight5Sgix = 0x8411,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT6_SGIX = 0x8412
        /// </summary>
        FragmentLight6Sgix = 0x8412,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT7_SGIX = 0x8413
        /// </summary>
        FragmentLight7Sgix = 0x8413,

        /// <summary>
        /// Original was GL_PACK_RESAMPLE_SGIX = 0x842E
        /// </summary>
        PackResampleSgix = 0x842e,

        /// <summary>
        /// Original was GL_UNPACK_RESAMPLE_SGIX = 0x842F
        /// </summary>
        UnpackResampleSgix = 0x842f,

        /// <summary>
        /// Original was GL_RESAMPLE_DECIMATE_SGIX = 0x8430
        /// </summary>
        ResampleDecimateSgix = 0x8430,

        /// <summary>
        /// Original was GL_RESAMPLE_REPLICATE_SGIX = 0x8433
        /// </summary>
        ResampleReplicateSgix = 0x8433,

        /// <summary>
        /// Original was GL_RESAMPLE_ZERO_FILL_SGIX = 0x8434
        /// </summary>
        ResampleZeroFillSgix = 0x8434,

        /// <summary>
        /// Original was GL_NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D
        /// </summary>
        NearestClipmapNearestSgix = 0x844d,

        /// <summary>
        /// Original was GL_NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E
        /// </summary>
        NearestClipmapLinearSgix = 0x844e,

        /// <summary>
        /// Original was GL_LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F
        /// </summary>
        LinearClipmapNearestSgix = 0x844f,

        /// <summary>
        /// Original was GL_FOG_COORD_SRC = 0x8450
        /// </summary>
        FogCoordSrc = 0x8450,

        /// <summary>
        /// Original was GL_ALIASED_POINT_SIZE_RANGE = 0x846D
        /// </summary>
        AliasedPointSizeRange = 0x846d,

        /// <summary>
        /// Original was GL_ALIASED_LINE_WIDTH_RANGE = 0x846E
        /// </summary>
        AliasedLineWidthRange = 0x846e,

        /// <summary>
        /// Original was GL_TEXTURE0 = 0x84C0
        /// </summary>
        Texture0 = 0x84c0,

        /// <summary>
        /// Original was GL_TEXTURE1 = 0x84C1
        /// </summary>
        Texture1 = 0x84c1,

        /// <summary>
        /// Original was GL_TEXTURE2 = 0x84C2
        /// </summary>
        Texture2 = 0x84c2,

        /// <summary>
        /// Original was GL_TEXTURE3 = 0x84C3
        /// </summary>
        Texture3 = 0x84c3,

        /// <summary>
        /// Original was GL_TEXTURE4 = 0x84C4
        /// </summary>
        Texture4 = 0x84c4,

        /// <summary>
        /// Original was GL_TEXTURE5 = 0x84C5
        /// </summary>
        Texture5 = 0x84c5,

        /// <summary>
        /// Original was GL_TEXTURE6 = 0x84C6
        /// </summary>
        Texture6 = 0x84c6,

        /// <summary>
        /// Original was GL_TEXTURE7 = 0x84C7
        /// </summary>
        Texture7 = 0x84c7,

        /// <summary>
        /// Original was GL_TEXTURE8 = 0x84C8
        /// </summary>
        Texture8 = 0x84c8,

        /// <summary>
        /// Original was GL_TEXTURE9 = 0x84C9
        /// </summary>
        Texture9 = 0x84c9,

        /// <summary>
        /// Original was GL_TEXTURE10 = 0x84CA
        /// </summary>
        Texture10 = 0x84ca,

        /// <summary>
        /// Original was GL_TEXTURE11 = 0x84CB
        /// </summary>
        Texture11 = 0x84cb,

        /// <summary>
        /// Original was GL_TEXTURE12 = 0x84CC
        /// </summary>
        Texture12 = 0x84cc,

        /// <summary>
        /// Original was GL_TEXTURE13 = 0x84CD
        /// </summary>
        Texture13 = 0x84cd,

        /// <summary>
        /// Original was GL_TEXTURE14 = 0x84CE
        /// </summary>
        Texture14 = 0x84ce,

        /// <summary>
        /// Original was GL_TEXTURE15 = 0x84CF
        /// </summary>
        Texture15 = 0x84cf,

        /// <summary>
        /// Original was GL_TEXTURE16 = 0x84D0
        /// </summary>
        Texture16 = 0x84d0,

        /// <summary>
        /// Original was GL_TEXTURE17 = 0x84D1
        /// </summary>
        Texture17 = 0x84d1,

        /// <summary>
        /// Original was GL_TEXTURE18 = 0x84D2
        /// </summary>
        Texture18 = 0x84d2,

        /// <summary>
        /// Original was GL_TEXTURE19 = 0x84D3
        /// </summary>
        Texture19 = 0x84d3,

        /// <summary>
        /// Original was GL_TEXTURE20 = 0x84D4
        /// </summary>
        Texture20 = 0x84d4,

        /// <summary>
        /// Original was GL_TEXTURE21 = 0x84D5
        /// </summary>
        Texture21 = 0x84d5,

        /// <summary>
        /// Original was GL_TEXTURE22 = 0x84D6
        /// </summary>
        Texture22 = 0x84d6,

        /// <summary>
        /// Original was GL_TEXTURE23 = 0x84D7
        /// </summary>
        Texture23 = 0x84d7,

        /// <summary>
        /// Original was GL_TEXTURE24 = 0x84D8
        /// </summary>
        Texture24 = 0x84d8,

        /// <summary>
        /// Original was GL_TEXTURE25 = 0x84D9
        /// </summary>
        Texture25 = 0x84d9,

        /// <summary>
        /// Original was GL_TEXTURE26 = 0x84DA
        /// </summary>
        Texture26 = 0x84da,

        /// <summary>
        /// Original was GL_TEXTURE27 = 0x84DB
        /// </summary>
        Texture27 = 0x84db,

        /// <summary>
        /// Original was GL_TEXTURE28 = 0x84DC
        /// </summary>
        Texture28 = 0x84dc,

        /// <summary>
        /// Original was GL_TEXTURE29 = 0x84DD
        /// </summary>
        Texture29 = 0x84dd,

        /// <summary>
        /// Original was GL_TEXTURE30 = 0x84DE
        /// </summary>
        Texture30 = 0x84de,

        /// <summary>
        /// Original was GL_TEXTURE31 = 0x84DF
        /// </summary>
        Texture31 = 0x84df,

        /// <summary>
        /// Original was GL_ACTIVE_TEXTURE = 0x84E0
        /// </summary>
        ActiveTexture = 0x84e0,

        /// <summary>
        /// Original was GL_CLIENT_ACTIVE_TEXTURE = 0x84E1
        /// </summary>
        ClientActiveTexture = 0x84e1,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_UNITS = 0x84E2
        /// </summary>
        MaxTextureUnits = 0x84e2,

        /// <summary>
        /// Original was GL_SUBTRACT = 0x84E7
        /// </summary>
        Subtract = 0x84e7,

        /// <summary>
        /// Original was GL_MAX_RENDERBUFFER_SIZE_OES = 0x84E8
        /// </summary>
        MaxRenderbufferSizeOes = 0x84e8,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB = 0x84ED
        /// </summary>
        CompressedRgb = 0x84ed,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA = 0x84EE
        /// </summary>
        CompressedRgba = 0x84ee,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSION_HINT = 0x84EF
        /// </summary>
        TextureCompressionHint = 0x84ef,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF
        /// </summary>
        TextureCompressionHintArb = 0x84ef,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0
        /// </summary>
        UniformBlockReferencedByTessControlShader = 0x84f0,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1
        /// </summary>
        UniformBlockReferencedByTessEvaluationShader = 0x84f1,

        /// <summary>
        /// Original was GL_ALL_COMPLETED_NV = 0x84F2
        /// </summary>
        AllCompletedNv = 0x84f2,

        /// <summary>
        /// Original was GL_FENCE_STATUS_NV = 0x84F3
        /// </summary>
        FenceStatusNv = 0x84f3,

        /// <summary>
        /// Original was GL_FENCE_CONDITION_NV = 0x84F4
        /// </summary>
        FenceConditionNv = 0x84f4,

        /// <summary>
        /// Original was GL_TEXTURE_RECTANGLE = 0x84F5
        /// </summary>
        TextureRectangle = 0x84f5,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE = 0x84F7
        /// </summary>
        ProxyTextureRectangle = 0x84f7,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7
        /// </summary>
        ProxyTextureRectangleArb = 0x84f7,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE_NV = 0x84F7
        /// </summary>
        ProxyTextureRectangleNv = 0x84f7,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL = 0x84F9
        /// </summary>
        DepthStencil = 0x84f9,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_EXT = 0x84F9
        /// </summary>
        DepthStencilExt = 0x84f9,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_NV = 0x84F9
        /// </summary>
        DepthStencilNv = 0x84f9,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_OES = 0x84F9
        /// </summary>
        DepthStencilOes = 0x84f9,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_24_8_OES = 0x84FA
        /// </summary>
        UnsignedInt248Oes = 0x84fa,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_LOD_BIAS_EXT = 0x84FD
        /// </summary>
        MaxTextureLodBiasExt = 0x84fd,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE
        /// </summary>
        TextureMaxAnisotropyExt = 0x84fe,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF
        /// </summary>
        MaxTextureMaxAnisotropyExt = 0x84ff,

        /// <summary>
        /// Original was GL_TEXTURE_FILTER_CONTROL_EXT = 0x8500
        /// </summary>
        TextureFilterControlExt = 0x8500,

        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS = 0x8501
        /// </summary>
        TextureLodBias = 0x8501,

        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_EXT = 0x8501
        /// </summary>
        TextureLodBiasExt = 0x8501,

        /// <summary>
        /// Original was GL_INCR_WRAP_OES = 0x8507
        /// </summary>
        IncrWrapOes = 0x8507,

        /// <summary>
        /// Original was GL_DECR_WRAP_OES = 0x8508
        /// </summary>
        DecrWrapOes = 0x8508,

        /// <summary>
        /// Original was GL_NORMAL_MAP_OES = 0x8511
        /// </summary>
        NormalMapOes = 0x8511,

        /// <summary>
        /// Original was GL_REFLECTION_MAP_OES = 0x8512
        /// </summary>
        ReflectionMapOes = 0x8512,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP = 0x8513
        /// </summary>
        TextureCubeMap = 0x8513,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_OES = 0x8513
        /// </summary>
        TextureCubeMapOes = 0x8513,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP_OES = 0x8514
        /// </summary>
        TextureBindingCubeMapOes = 0x8514,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515
        /// </summary>
        TextureCubeMapPositiveX = 0x8515,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES = 0x8515
        /// </summary>
        TextureCubeMapPositiveXOes = 0x8515,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516
        /// </summary>
        TextureCubeMapNegativeX = 0x8516,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES = 0x8516
        /// </summary>
        TextureCubeMapNegativeXOes = 0x8516,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517
        /// </summary>
        TextureCubeMapPositiveY = 0x8517,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES = 0x8517
        /// </summary>
        TextureCubeMapPositiveYOes = 0x8517,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518
        /// </summary>
        TextureCubeMapNegativeY = 0x8518,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES = 0x8518
        /// </summary>
        TextureCubeMapNegativeYOes = 0x8518,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519
        /// </summary>
        TextureCubeMapPositiveZ = 0x8519,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES = 0x8519
        /// </summary>
        TextureCubeMapPositiveZOes = 0x8519,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A
        /// </summary>
        TextureCubeMapNegativeZ = 0x851a,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES = 0x851A
        /// </summary>
        TextureCubeMapNegativeZOes = 0x851a,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP = 0x851B
        /// </summary>
        ProxyTextureCubeMap = 0x851b,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B
        /// </summary>
        ProxyTextureCubeMapArb = 0x851b,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B
        /// </summary>
        ProxyTextureCubeMapExt = 0x851b,

        /// <summary>
        /// Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES = 0x851C
        /// </summary>
        MaxCubeMapTextureSizeOes = 0x851c,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F
        /// </summary>
        VertexArrayStorageHintApple = 0x851f,

        /// <summary>
        /// Original was GL_PRIMARY_COLOR_NV = 0x852C
        /// </summary>
        PrimaryColorNv = 0x852c,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_NV = 0x852D
        /// </summary>
        SecondaryColorNv = 0x852d,

        /// <summary>
        /// Original was GL_MULTISAMPLE_FILTER_HINT_NV = 0x8534
        /// </summary>
        MultisampleFilterHintNv = 0x8534,

        /// <summary>
        /// Original was GL_COMBINE = 0x8570
        /// </summary>
        Combine = 0x8570,

        /// <summary>
        /// Original was GL_COMBINE_RGB = 0x8571
        /// </summary>
        CombineRgb = 0x8571,

        /// <summary>
        /// Original was GL_COMBINE_ALPHA = 0x8572
        /// </summary>
        CombineAlpha = 0x8572,

        /// <summary>
        /// Original was GL_RGB_SCALE = 0x8573
        /// </summary>
        RgbScale = 0x8573,

        /// <summary>
        /// Original was GL_ADD_SIGNED = 0x8574
        /// </summary>
        AddSigned = 0x8574,

        /// <summary>
        /// Original was GL_INTERPOLATE = 0x8575
        /// </summary>
        Interpolate = 0x8575,

        /// <summary>
        /// Original was GL_CONSTANT = 0x8576
        /// </summary>
        Constant = 0x8576,

        /// <summary>
        /// Original was GL_PRIMARY_COLOR = 0x8577
        /// </summary>
        PrimaryColor = 0x8577,

        /// <summary>
        /// Original was GL_PREVIOUS = 0x8578
        /// </summary>
        Previous = 0x8578,

        /// <summary>
        /// Original was GL_SRC0_RGB = 0x8580
        /// </summary>
        Src0Rgb = 0x8580,

        /// <summary>
        /// Original was GL_SRC1_RGB = 0x8581
        /// </summary>
        Src1Rgb = 0x8581,

        /// <summary>
        /// Original was GL_SRC2_RGB = 0x8582
        /// </summary>
        Src2Rgb = 0x8582,

        /// <summary>
        /// Original was GL_SRC0_ALPHA = 0x8588
        /// </summary>
        Src0Alpha = 0x8588,

        /// <summary>
        /// Original was GL_SRC1_ALPHA = 0x8589
        /// </summary>
        Src1Alpha = 0x8589,

        /// <summary>
        /// Original was GL_SRC2_ALPHA = 0x858A
        /// </summary>
        Src2Alpha = 0x858a,

        /// <summary>
        /// Original was GL_OPERAND0_RGB = 0x8590
        /// </summary>
        Operand0Rgb = 0x8590,

        /// <summary>
        /// Original was GL_OPERAND1_RGB = 0x8591
        /// </summary>
        Operand1Rgb = 0x8591,

        /// <summary>
        /// Original was GL_OPERAND2_RGB = 0x8592
        /// </summary>
        Operand2Rgb = 0x8592,

        /// <summary>
        /// Original was GL_OPERAND0_ALPHA = 0x8598
        /// </summary>
        Operand0Alpha = 0x8598,

        /// <summary>
        /// Original was GL_OPERAND1_ALPHA = 0x8599
        /// </summary>
        Operand1Alpha = 0x8599,

        /// <summary>
        /// Original was GL_OPERAND2_ALPHA = 0x859A
        /// </summary>
        Operand2Alpha = 0x859a,

        /// <summary>
        /// Original was GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0
        /// </summary>
        PackSubsampleRateSgix = 0x85a0,

        /// <summary>
        /// Original was GL_UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1
        /// </summary>
        UnpackSubsampleRateSgix = 0x85a1,

        /// <summary>
        /// Original was GL_PIXEL_SUBSAMPLE_4444_SGIX = 0x85A2
        /// </summary>
        PixelSubsample4444Sgix = 0x85a2,

        /// <summary>
        /// Original was GL_PIXEL_SUBSAMPLE_2424_SGIX = 0x85A3
        /// </summary>
        PixelSubsample2424Sgix = 0x85a3,

        /// <summary>
        /// Original was GL_PIXEL_SUBSAMPLE_4242_SGIX = 0x85A4
        /// </summary>
        PixelSubsample4242Sgix = 0x85a4,

        /// <summary>
        /// Original was GL_TRANSFORM_HINT_APPLE = 0x85B1
        /// </summary>
        TransformHintApple = 0x85b1,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BINDING_OES = 0x85B5
        /// </summary>
        VertexArrayBindingOes = 0x85b5,

        /// <summary>
        /// Original was GL_TEXTURE_STORAGE_HINT_APPLE = 0x85BC
        /// </summary>
        TextureStorageHintApple = 0x85bc,

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
        /// Original was GL_TEXTURE_COMPRESSED = 0x86A1
        /// </summary>
        TextureCompressed = 0x86a1,

        /// <summary>
        /// Original was GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2
        /// </summary>
        NumCompressedTextureFormats = 0x86a2,

        /// <summary>
        /// Original was GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3
        /// </summary>
        CompressedTextureFormats = 0x86a3,

        /// <summary>
        /// Original was GL_MAX_VERTEX_UNITS_OES = 0x86A4
        /// </summary>
        MaxVertexUnitsOes = 0x86a4,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_TYPE_OES = 0x86A9
        /// </summary>
        WeightArrayTypeOes = 0x86a9,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_STRIDE_OES = 0x86AA
        /// </summary>
        WeightArrayStrideOes = 0x86aa,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_SIZE_OES = 0x86AB
        /// </summary>
        WeightArraySizeOes = 0x86ab,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_POINTER_OES = 0x86AC
        /// </summary>
        WeightArrayPointerOes = 0x86ac,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_OES = 0x86AD
        /// </summary>
        WeightArrayOes = 0x86ad,

        /// <summary>
        /// Original was GL_DOT3_RGB = 0x86AE
        /// </summary>
        Dot3Rgb = 0x86ae,

        /// <summary>
        /// Original was GL_DOT3_RGBA = 0x86AF
        /// </summary>
        Dot3Rgba = 0x86af,

        /// <summary>
        /// Original was GL_DOT3_RGBA_IMG = 0x86AF
        /// </summary>
        Dot3RgbaImg = 0x86af,

        /// <summary>
        /// Original was GL_PROGRAM_BINARY_LENGTH = 0x8741
        /// </summary>
        ProgramBinaryLength = 0x8741,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E
        /// </summary>
        VertexAttribArrayLong = 0x874e,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_MESA = 0x8750
        /// </summary>
        DepthStencilMesa = 0x8750,

        /// <summary>
        /// Original was GL_BUFFER_SIZE = 0x8764
        /// </summary>
        BufferSize = 0x8764,

        /// <summary>
        /// Original was GL_BUFFER_USAGE = 0x8765
        /// </summary>
        BufferUsage = 0x8765,

        /// <summary>
        /// Original was GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE
        /// </summary>
        AtcRgbaInterpolatedAlphaAmd = 0x87ee,

        /// <summary>
        /// Original was GL_3DC_X_AMD = 0x87F9
        /// </summary>
        Gl3DcXAmd = 0x87f9,

        /// <summary>
        /// Original was GL_3DC_XY_AMD = 0x87FA
        /// </summary>
        Gl3DcXyAmd = 0x87fa,

        /// <summary>
        /// Original was GL_RGBA32F = 0x8814
        /// </summary>
        Rgba32f = 0x8814,

        /// <summary>
        /// Original was GL_RGBA32F_ARB = 0x8814
        /// </summary>
        Rgba32fArb = 0x8814,

        /// <summary>
        /// Original was GL_RGBA32F_EXT = 0x8814
        /// </summary>
        Rgba32fExt = 0x8814,

        /// <summary>
        /// Original was GL_RGB32F_EXT = 0x8815
        /// </summary>
        Rgb32fExt = 0x8815,

        /// <summary>
        /// Original was GL_ALPHA32F_EXT = 0x8816
        /// </summary>
        Alpha32fExt = 0x8816,

        /// <summary>
        /// Original was GL_LUMINANCE32F_EXT = 0x8818
        /// </summary>
        Luminance32fExt = 0x8818,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA32F_EXT = 0x8819
        /// </summary>
        LuminanceAlpha32fExt = 0x8819,

        /// <summary>
        /// Original was GL_RGBA16F = 0x881A
        /// </summary>
        Rgba16f = 0x881a,

        /// <summary>
        /// Original was GL_RGBA16F_ARB = 0x881A
        /// </summary>
        Rgba16fArb = 0x881a,

        /// <summary>
        /// Original was GL_RGBA16F_EXT = 0x881A
        /// </summary>
        Rgba16fExt = 0x881a,

        /// <summary>
        /// Original was GL_RGB16F = 0x881B
        /// </summary>
        Rgb16f = 0x881b,

        /// <summary>
        /// Original was GL_RGB16F_ARB = 0x881B
        /// </summary>
        Rgb16fArb = 0x881b,

        /// <summary>
        /// Original was GL_RGB16F_EXT = 0x881B
        /// </summary>
        Rgb16fExt = 0x881b,

        /// <summary>
        /// Original was GL_ALPHA16F_EXT = 0x881C
        /// </summary>
        Alpha16fExt = 0x881c,

        /// <summary>
        /// Original was GL_LUMINANCE16F_EXT = 0x881E
        /// </summary>
        Luminance16fExt = 0x881e,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA16F_EXT = 0x881F
        /// </summary>
        LuminanceAlpha16fExt = 0x881f,

        /// <summary>
        /// Original was GL_WRITEONLY_RENDERING_QCOM = 0x8823
        /// </summary>
        WriteonlyRenderingQcom = 0x8823,

        /// <summary>
        /// Original was GL_BLEND_EQUATION_ALPHA_OES = 0x883D
        /// </summary>
        BlendEquationAlphaOes = 0x883d,

        /// <summary>
        /// Original was GL_MATRIX_PALETTE_OES = 0x8840
        /// </summary>
        MatrixPaletteOes = 0x8840,

        /// <summary>
        /// Original was GL_MAX_PALETTE_MATRICES_OES = 0x8842
        /// </summary>
        MaxPaletteMatricesOes = 0x8842,

        /// <summary>
        /// Original was GL_CURRENT_PALETTE_MATRIX_OES = 0x8843
        /// </summary>
        CurrentPaletteMatrixOes = 0x8843,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_OES = 0x8844
        /// </summary>
        MatrixIndexArrayOes = 0x8844,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_SIZE_OES = 0x8846
        /// </summary>
        MatrixIndexArraySizeOes = 0x8846,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_TYPE_OES = 0x8847
        /// </summary>
        MatrixIndexArrayTypeOes = 0x8847,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_STRIDE_OES = 0x8848
        /// </summary>
        MatrixIndexArrayStrideOes = 0x8848,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_POINTER_OES = 0x8849
        /// </summary>
        MatrixIndexArrayPointerOes = 0x8849,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_MODE = 0x884C
        /// </summary>
        TextureCompareMode = 0x884c,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
        /// </summary>
        TextureCompareFunc = 0x884d,

        /// <summary>
        /// Original was GL_POINT_SPRITE_OES = 0x8861
        /// </summary>
        PointSpriteOes = 0x8861,

        /// <summary>
        /// Original was GL_COORD_REPLACE_OES = 0x8862
        /// </summary>
        CoordReplaceOes = 0x8862,

        /// <summary>
        /// Original was GL_QUERY_COUNTER_BITS = 0x8864
        /// </summary>
        QueryCounterBits = 0x8864,

        /// <summary>
        /// Original was GL_CURRENT_QUERY = 0x8865
        /// </summary>
        CurrentQuery = 0x8865,

        /// <summary>
        /// Original was GL_QUERY_RESULT = 0x8866
        /// </summary>
        QueryResult = 0x8866,

        /// <summary>
        /// Original was GL_QUERY_RESULT_AVAILABLE = 0x8867
        /// </summary>
        QueryResultAvailable = 0x8867,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A
        /// </summary>
        VertexAttribArrayNormalized = 0x886a,

        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = 0x8892,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = 0x8893,

        /// <summary>
        /// Original was GL_ARRAY_BUFFER_BINDING = 0x8894
        /// </summary>
        ArrayBufferBinding = 0x8894,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895
        /// </summary>
        ElementArrayBufferBinding = 0x8895,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896
        /// </summary>
        VertexArrayBufferBinding = 0x8896,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897
        /// </summary>
        NormalArrayBufferBinding = 0x8897,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898
        /// </summary>
        ColorArrayBufferBinding = 0x8898,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A
        /// </summary>
        TextureCoordArrayBufferBinding = 0x889a,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_BUFFER_BINDING_OES = 0x889E
        /// </summary>
        WeightArrayBufferBindingOes = 0x889e,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F
        /// </summary>
        VertexAttribArrayBufferBinding = 0x889f,

        /// <summary>
        /// Original was GL_READ_ONLY = 0x88B8
        /// </summary>
        ReadOnly = 0x88b8,

        /// <summary>
        /// Original was GL_WRITE_ONLY = 0x88B9
        /// </summary>
        WriteOnly = 0x88b9,

        /// <summary>
        /// Original was GL_WRITE_ONLY_OES = 0x88B9
        /// </summary>
        WriteOnlyOes = 0x88b9,

        /// <summary>
        /// Original was GL_READ_WRITE = 0x88BA
        /// </summary>
        ReadWrite = 0x88ba,

        /// <summary>
        /// Original was GL_BUFFER_ACCESS = 0x88BB
        /// </summary>
        BufferAccess = 0x88bb,

        /// <summary>
        /// Original was GL_BUFFER_ACCESS_OES = 0x88BB
        /// </summary>
        BufferAccessOes = 0x88bb,

        /// <summary>
        /// Original was GL_BUFFER_MAPPED = 0x88BC
        /// </summary>
        BufferMapped = 0x88bc,

        /// <summary>
        /// Original was GL_BUFFER_MAPPED_OES = 0x88BC
        /// </summary>
        BufferMappedOes = 0x88bc,

        /// <summary>
        /// Original was GL_BUFFER_MAP_POINTER_OES = 0x88BD
        /// </summary>
        BufferMapPointerOes = 0x88bd,

        /// <summary>
        /// Original was GL_TIME_ELAPSED = 0x88BF
        /// </summary>
        TimeElapsed = 0x88bf,

        /// <summary>
        /// Original was GL_STREAM_DRAW = 0x88E0
        /// </summary>
        StreamDraw = 0x88e0,

        /// <summary>
        /// Original was GL_STREAM_READ = 0x88E1
        /// </summary>
        StreamRead = 0x88e1,

        /// <summary>
        /// Original was GL_STREAM_COPY = 0x88E2
        /// </summary>
        StreamCopy = 0x88e2,

        /// <summary>
        /// Original was GL_STATIC_DRAW = 0x88E4
        /// </summary>
        StaticDraw = 0x88e4,

        /// <summary>
        /// Original was GL_STATIC_READ = 0x88E5
        /// </summary>
        StaticRead = 0x88e5,

        /// <summary>
        /// Original was GL_STATIC_COPY = 0x88E6
        /// </summary>
        StaticCopy = 0x88e6,

        /// <summary>
        /// Original was GL_DYNAMIC_DRAW = 0x88E8
        /// </summary>
        DynamicDraw = 0x88e8,

        /// <summary>
        /// Original was GL_DYNAMIC_READ = 0x88E9
        /// </summary>
        DynamicRead = 0x88e9,

        /// <summary>
        /// Original was GL_DYNAMIC_COPY = 0x88EA
        /// </summary>
        DynamicCopy = 0x88ea,

        /// <summary>
        /// Original was GL_PIXEL_PACK_BUFFER = 0x88EB
        /// </summary>
        PixelPackBuffer = 0x88eb,

        /// <summary>
        /// Original was GL_PIXEL_UNPACK_BUFFER = 0x88EC
        /// </summary>
        PixelUnpackBuffer = 0x88ec,

        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8 = 0x88F0
        /// </summary>
        Depth24Stencil8 = 0x88f0,

        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_EXT = 0x88F0
        /// </summary>
        Depth24Stencil8Ext = 0x88f0,

        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        /// </summary>
        Depth24Stencil8Oes = 0x88f0,

        /// <summary>
        /// Original was GL_SRC1_COLOR = 0x88F9
        /// </summary>
        Src1Color = 0x88f9,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD
        /// </summary>
        VertexAttribArrayInteger = 0x88fd,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE
        /// </summary>
        VertexAttribArrayDivisor = 0x88fe,

        /// <summary>
        /// Original was GL_SAMPLES_PASSED = 0x8914
        /// </summary>
        SamplesPassed = 0x8914,

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
        /// Original was GL_MOV_ATI = 0x8961
        /// </summary>
        MovAti = 0x8961,

        /// <summary>
        /// Original was GL_ADD_ATI = 0x8963
        /// </summary>
        AddAti = 0x8963,

        /// <summary>
        /// Original was GL_MUL_ATI = 0x8964
        /// </summary>
        MulAti = 0x8964,

        /// <summary>
        /// Original was GL_SUB_ATI = 0x8965
        /// </summary>
        SubAti = 0x8965,

        /// <summary>
        /// Original was GL_DOT3_ATI = 0x8966
        /// </summary>
        Dot3Ati = 0x8966,

        /// <summary>
        /// Original was GL_DOT4_ATI = 0x8967
        /// </summary>
        Dot4Ati = 0x8967,

        /// <summary>
        /// Original was GL_MAD_ATI = 0x8968
        /// </summary>
        MadAti = 0x8968,

        /// <summary>
        /// Original was GL_LERP_ATI = 0x8969
        /// </summary>
        LerpAti = 0x8969,

        /// <summary>
        /// Original was GL_CND_ATI = 0x896A
        /// </summary>
        CndAti = 0x896a,

        /// <summary>
        /// Original was GL_CND0_ATI = 0x896B
        /// </summary>
        Cnd0Ati = 0x896b,

        /// <summary>
        /// Original was GL_DOT2_ADD_ATI = 0x896C
        /// </summary>
        Dot2AddAti = 0x896c,

        /// <summary>
        /// Original was GL_PACK_RESAMPLE_OML = 0x8984
        /// </summary>
        PackResampleOml = 0x8984,

        /// <summary>
        /// Original was GL_UNPACK_RESAMPLE_OML = 0x8985
        /// </summary>
        UnpackResampleOml = 0x8985,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_TYPE_OES = 0x898A
        /// </summary>
        PointSizeArrayTypeOes = 0x898a,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_STRIDE_OES = 0x898B
        /// </summary>
        PointSizeArrayStrideOes = 0x898b,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_POINTER_OES = 0x898C
        /// </summary>
        PointSizeArrayPointerOes = 0x898c,

        /// <summary>
        /// Original was GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898D
        /// </summary>
        ModelviewMatrixFloatAsIntBitsOes = 0x898d,

        /// <summary>
        /// Original was GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898E
        /// </summary>
        ProjectionMatrixFloatAsIntBitsOes = 0x898e,

        /// <summary>
        /// Original was GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898F
        /// </summary>
        TextureMatrixFloatAsIntBitsOes = 0x898f,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER = 0x8A11
        /// </summary>
        UniformBuffer = 0x8a11,

        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35
        /// </summary>
        ActiveUniformBlockMaxNameLength = 0x8a35,

        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36
        /// </summary>
        ActiveUniformBlocks = 0x8a36,

        /// <summary>
        /// Original was GL_UNIFORM_TYPE = 0x8A37
        /// </summary>
        UniformType = 0x8a37,

        /// <summary>
        /// Original was GL_UNIFORM_SIZE = 0x8A38
        /// </summary>
        UniformSize = 0x8a38,

        /// <summary>
        /// Original was GL_UNIFORM_NAME_LENGTH = 0x8A39
        /// </summary>
        UniformNameLength = 0x8a39,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_INDEX = 0x8A3A
        /// </summary>
        UniformBlockIndex = 0x8a3a,

        /// <summary>
        /// Original was GL_UNIFORM_OFFSET = 0x8A3B
        /// </summary>
        UniformOffset = 0x8a3b,

        /// <summary>
        /// Original was GL_UNIFORM_ARRAY_STRIDE = 0x8A3C
        /// </summary>
        UniformArrayStride = 0x8a3c,

        /// <summary>
        /// Original was GL_UNIFORM_MATRIX_STRIDE = 0x8A3D
        /// </summary>
        UniformMatrixStride = 0x8a3d,

        /// <summary>
        /// Original was GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E
        /// </summary>
        UniformIsRowMajor = 0x8a3e,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_BINDING = 0x8A3F
        /// </summary>
        UniformBlockBinding = 0x8a3f,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40
        /// </summary>
        UniformBlockDataSize = 0x8a40,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41
        /// </summary>
        UniformBlockNameLength = 0x8a41,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42
        /// </summary>
        UniformBlockActiveUniforms = 0x8a42,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43
        /// </summary>
        UniformBlockActiveUniformIndices = 0x8a43,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44
        /// </summary>
        UniformBlockReferencedByVertexShader = 0x8a44,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45
        /// </summary>
        UniformBlockReferencedByGeometryShader = 0x8a45,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46
        /// </summary>
        UniformBlockReferencedByFragmentShader = 0x8a46,

        /// <summary>
        /// Original was GL_SYNC_OBJECT_APPLE = 0x8A53
        /// </summary>
        SyncObjectApple = 0x8a53,

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER = 0x8B30
        /// </summary>
        FragmentShader = 0x8b30,

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_ARB = 0x8B30
        /// </summary>
        FragmentShaderArb = 0x8b30,

        /// <summary>
        /// Original was GL_VERTEX_SHADER = 0x8B31
        /// </summary>
        VertexShader = 0x8b31,

        /// <summary>
        /// Original was GL_VERTEX_SHADER_ARB = 0x8B31
        /// </summary>
        VertexShaderArb = 0x8b31,

        /// <summary>
        /// Original was GL_SHADER_TYPE = 0x8B4F
        /// </summary>
        ShaderType = 0x8b4f,

        /// <summary>
        /// Original was GL_FLOAT_VEC2 = 0x8B50
        /// </summary>
        FloatVec2 = 0x8b50,

        /// <summary>
        /// Original was GL_FLOAT_VEC2_ARB = 0x8B50
        /// </summary>
        FloatVec2Arb = 0x8b50,

        /// <summary>
        /// Original was GL_FLOAT_VEC3 = 0x8B51
        /// </summary>
        FloatVec3 = 0x8b51,

        /// <summary>
        /// Original was GL_FLOAT_VEC3_ARB = 0x8B51
        /// </summary>
        FloatVec3Arb = 0x8b51,

        /// <summary>
        /// Original was GL_FLOAT_VEC4 = 0x8B52
        /// </summary>
        FloatVec4 = 0x8b52,

        /// <summary>
        /// Original was GL_FLOAT_VEC4_ARB = 0x8B52
        /// </summary>
        FloatVec4Arb = 0x8b52,

        /// <summary>
        /// Original was GL_INT_VEC2 = 0x8B53
        /// </summary>
        IntVec2 = 0x8b53,

        /// <summary>
        /// Original was GL_INT_VEC2_ARB = 0x8B53
        /// </summary>
        IntVec2Arb = 0x8b53,

        /// <summary>
        /// Original was GL_INT_VEC3 = 0x8B54
        /// </summary>
        IntVec3 = 0x8b54,

        /// <summary>
        /// Original was GL_INT_VEC3_ARB = 0x8B54
        /// </summary>
        IntVec3Arb = 0x8b54,

        /// <summary>
        /// Original was GL_INT_VEC4 = 0x8B55
        /// </summary>
        IntVec4 = 0x8b55,

        /// <summary>
        /// Original was GL_INT_VEC4_ARB = 0x8B55
        /// </summary>
        IntVec4Arb = 0x8b55,

        /// <summary>
        /// Original was GL_BOOL = 0x8B56
        /// </summary>
        Bool = 0x8b56,

        /// <summary>
        /// Original was GL_BOOL_ARB = 0x8B56
        /// </summary>
        BoolArb = 0x8b56,

        /// <summary>
        /// Original was GL_BOOL_VEC2 = 0x8B57
        /// </summary>
        BoolVec2 = 0x8b57,

        /// <summary>
        /// Original was GL_BOOL_VEC2_ARB = 0x8B57
        /// </summary>
        BoolVec2Arb = 0x8b57,

        /// <summary>
        /// Original was GL_BOOL_VEC3 = 0x8B58
        /// </summary>
        BoolVec3 = 0x8b58,

        /// <summary>
        /// Original was GL_BOOL_VEC3_ARB = 0x8B58
        /// </summary>
        BoolVec3Arb = 0x8b58,

        /// <summary>
        /// Original was GL_BOOL_VEC4 = 0x8B59
        /// </summary>
        BoolVec4 = 0x8b59,

        /// <summary>
        /// Original was GL_BOOL_VEC4_ARB = 0x8B59
        /// </summary>
        BoolVec4Arb = 0x8b59,

        /// <summary>
        /// Original was GL_FLOAT_MAT2 = 0x8B5A
        /// </summary>
        FloatMat2 = 0x8b5a,

        /// <summary>
        /// Original was GL_FLOAT_MAT2_ARB = 0x8B5A
        /// </summary>
        FloatMat2Arb = 0x8b5a,

        /// <summary>
        /// Original was GL_FLOAT_MAT3 = 0x8B5B
        /// </summary>
        FloatMat3 = 0x8b5b,

        /// <summary>
        /// Original was GL_FLOAT_MAT3_ARB = 0x8B5B
        /// </summary>
        FloatMat3Arb = 0x8b5b,

        /// <summary>
        /// Original was GL_FLOAT_MAT4 = 0x8B5C
        /// </summary>
        FloatMat4 = 0x8b5c,

        /// <summary>
        /// Original was GL_FLOAT_MAT4_ARB = 0x8B5C
        /// </summary>
        FloatMat4Arb = 0x8b5c,

        /// <summary>
        /// Original was GL_SAMPLER_1D = 0x8B5D
        /// </summary>
        Sampler1D = 0x8b5d,

        /// <summary>
        /// Original was GL_SAMPLER_1D_ARB = 0x8B5D
        /// </summary>
        Sampler1DArb = 0x8b5d,

        /// <summary>
        /// Original was GL_SAMPLER_2D = 0x8B5E
        /// </summary>
        Sampler2D = 0x8b5e,

        /// <summary>
        /// Original was GL_SAMPLER_2D_ARB = 0x8B5E
        /// </summary>
        Sampler2DArb = 0x8b5e,

        /// <summary>
        /// Original was GL_SAMPLER_3D = 0x8B5F
        /// </summary>
        Sampler3D = 0x8b5f,

        /// <summary>
        /// Original was GL_SAMPLER_3D_ARB = 0x8B5F
        /// </summary>
        Sampler3DArb = 0x8b5f,

        /// <summary>
        /// Original was GL_SAMPLER_3D_OES = 0x8B5F
        /// </summary>
        Sampler3DOes = 0x8b5f,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE = 0x8B60
        /// </summary>
        SamplerCube = 0x8b60,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_ARB = 0x8B60
        /// </summary>
        SamplerCubeArb = 0x8b60,

        /// <summary>
        /// Original was GL_SAMPLER_1D_SHADOW = 0x8B61
        /// </summary>
        Sampler1DShadow = 0x8b61,

        /// <summary>
        /// Original was GL_SAMPLER_1D_SHADOW_ARB = 0x8B61
        /// </summary>
        Sampler1DShadowArb = 0x8b61,

        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW = 0x8B62
        /// </summary>
        Sampler2DShadow = 0x8b62,

        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW_ARB = 0x8B62
        /// </summary>
        Sampler2DShadowArb = 0x8b62,

        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW_EXT = 0x8B62
        /// </summary>
        Sampler2DShadowExt = 0x8b62,

        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT = 0x8B63
        /// </summary>
        Sampler2DRect = 0x8b63,

        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT_ARB = 0x8B63
        /// </summary>
        Sampler2DRectArb = 0x8b63,

        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT_SHADOW = 0x8B64
        /// </summary>
        Sampler2DRectShadow = 0x8b64,

        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64
        /// </summary>
        Sampler2DRectShadowArb = 0x8b64,

        /// <summary>
        /// Original was GL_FLOAT_MAT2x3 = 0x8B65
        /// </summary>
        FloatMat2x3 = 0x8b65,

        /// <summary>
        /// Original was GL_FLOAT_MAT2x3_NV = 0x8B65
        /// </summary>
        FloatMat2x3Nv = 0x8b65,

        /// <summary>
        /// Original was GL_FLOAT_MAT2x4 = 0x8B66
        /// </summary>
        FloatMat2x4 = 0x8b66,

        /// <summary>
        /// Original was GL_FLOAT_MAT2x4_NV = 0x8B66
        /// </summary>
        FloatMat2x4Nv = 0x8b66,

        /// <summary>
        /// Original was GL_FLOAT_MAT3x2 = 0x8B67
        /// </summary>
        FloatMat3x2 = 0x8b67,

        /// <summary>
        /// Original was GL_FLOAT_MAT3x2_NV = 0x8B67
        /// </summary>
        FloatMat3x2Nv = 0x8b67,

        /// <summary>
        /// Original was GL_FLOAT_MAT3x4 = 0x8B68
        /// </summary>
        FloatMat3x4 = 0x8b68,

        /// <summary>
        /// Original was GL_FLOAT_MAT3x4_NV = 0x8B68
        /// </summary>
        FloatMat3x4Nv = 0x8b68,

        /// <summary>
        /// Original was GL_FLOAT_MAT4x2 = 0x8B69
        /// </summary>
        FloatMat4x2 = 0x8b69,

        /// <summary>
        /// Original was GL_FLOAT_MAT4x2_NV = 0x8B69
        /// </summary>
        FloatMat4x2Nv = 0x8b69,

        /// <summary>
        /// Original was GL_FLOAT_MAT4x3 = 0x8B6A
        /// </summary>
        FloatMat4x3 = 0x8b6a,

        /// <summary>
        /// Original was GL_FLOAT_MAT4x3_NV = 0x8B6A
        /// </summary>
        FloatMat4x3Nv = 0x8b6a,

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
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHintArb = 0x8b8b,

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHintOes = 0x8b8b,

        /// <summary>
        /// Original was GL_SHADING_LANGUAGE_VERSION = 0x8B8C
        /// </summary>
        ShadingLanguageVersion = 0x8b8c,

        /// <summary>
        /// Original was GL_PALETTE4_RGB8_OES = 0x8B90
        /// </summary>
        Palette4Rgb8Oes = 0x8b90,

        /// <summary>
        /// Original was GL_PALETTE4_RGBA8_OES = 0x8B91
        /// </summary>
        Palette4Rgba8Oes = 0x8b91,

        /// <summary>
        /// Original was GL_PALETTE4_R5_G6_B5_OES = 0x8B92
        /// </summary>
        Palette4R5G6B5Oes = 0x8b92,

        /// <summary>
        /// Original was GL_PALETTE4_RGBA4_OES = 0x8B93
        /// </summary>
        Palette4Rgba4Oes = 0x8b93,

        /// <summary>
        /// Original was GL_PALETTE4_RGB5_A1_OES = 0x8B94
        /// </summary>
        Palette4Rgb5A1Oes = 0x8b94,

        /// <summary>
        /// Original was GL_PALETTE8_RGB8_OES = 0x8B95
        /// </summary>
        Palette8Rgb8Oes = 0x8b95,

        /// <summary>
        /// Original was GL_PALETTE8_RGBA8_OES = 0x8B96
        /// </summary>
        Palette8Rgba8Oes = 0x8b96,

        /// <summary>
        /// Original was GL_PALETTE8_R5_G6_B5_OES = 0x8B97
        /// </summary>
        Palette8R5G6B5Oes = 0x8b97,

        /// <summary>
        /// Original was GL_PALETTE8_RGBA4_OES = 0x8B98
        /// </summary>
        Palette8Rgba4Oes = 0x8b98,

        /// <summary>
        /// Original was GL_PALETTE8_RGB5_A1_OES = 0x8B99
        /// </summary>
        Palette8Rgb5A1Oes = 0x8b99,

        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A
        /// </summary>
        ImplementationColorReadType = 0x8b9a,

        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_TYPE_OES = 0x8B9A
        /// </summary>
        ImplementationColorReadTypeOes = 0x8b9a,

        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B
        /// </summary>
        ImplementationColorReadFormat = 0x8b9b,

        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES = 0x8B9B
        /// </summary>
        ImplementationColorReadFormatOes = 0x8b9b,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_OES = 0x8B9C
        /// </summary>
        PointSizeArrayOes = 0x8b9c,

        /// <summary>
        /// Original was GL_TEXTURE_CROP_RECT_OES = 0x8B9D
        /// </summary>
        TextureCropRectOes = 0x8b9d,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES = 0x8B9E
        /// </summary>
        MatrixIndexArrayBufferBindingOes = 0x8b9e,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES = 0x8B9F
        /// </summary>
        PointSizeArrayBufferBindingOes = 0x8b9f,

        /// <summary>
        /// Original was GL_TEXTURE_WIDTH_QCOM = 0x8BD2
        /// </summary>
        TextureWidthQcom = 0x8bd2,

        /// <summary>
        /// Original was GL_TEXTURE_HEIGHT_QCOM = 0x8BD3
        /// </summary>
        TextureHeightQcom = 0x8bd3,

        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_QCOM = 0x8BD4
        /// </summary>
        TextureDepthQcom = 0x8bd4,

        /// <summary>
        /// Original was GL_TEXTURE_INTERNAL_FORMAT_QCOM = 0x8BD5
        /// </summary>
        TextureInternalFormatQcom = 0x8bd5,

        /// <summary>
        /// Original was GL_TEXTURE_FORMAT_QCOM = 0x8BD6
        /// </summary>
        TextureFormatQcom = 0x8bd6,

        /// <summary>
        /// Original was GL_TEXTURE_TYPE_QCOM = 0x8BD7
        /// </summary>
        TextureTypeQcom = 0x8bd7,

        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_VALID_QCOM = 0x8BD8
        /// </summary>
        TextureImageValidQcom = 0x8bd8,

        /// <summary>
        /// Original was GL_TEXTURE_NUM_LEVELS_QCOM = 0x8BD9
        /// </summary>
        TextureNumLevelsQcom = 0x8bd9,

        /// <summary>
        /// Original was GL_TEXTURE_TARGET_QCOM = 0x8BDA
        /// </summary>
        TextureTargetQcom = 0x8bda,

        /// <summary>
        /// Original was GL_TEXTURE_OBJECT_VALID_QCOM = 0x8BDB
        /// </summary>
        TextureObjectValidQcom = 0x8bdb,

        /// <summary>
        /// Original was GL_STATE_RESTORE = 0x8BDC
        /// </summary>
        StateRestore = 0x8bdc,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG = 0x8C00
        /// </summary>
        CompressedRgbPvrtc4Bppv1Img = 0x8c00,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG = 0x8C01
        /// </summary>
        CompressedRgbPvrtc2Bppv1Img = 0x8c01,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG = 0x8C02
        /// </summary>
        CompressedRgbaPvrtc4Bppv1Img = 0x8c02,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG = 0x8C03
        /// </summary>
        CompressedRgbaPvrtc2Bppv1Img = 0x8c03,

        /// <summary>
        /// Original was GL_MODULATE_COLOR_IMG = 0x8C04
        /// </summary>
        ModulateColorImg = 0x8c04,

        /// <summary>
        /// Original was GL_RECIP_ADD_SIGNED_ALPHA_IMG = 0x8C05
        /// </summary>
        RecipAddSignedAlphaImg = 0x8c05,

        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_MODULATE_IMG = 0x8C06
        /// </summary>
        TextureAlphaModulateImg = 0x8c06,

        /// <summary>
        /// Original was GL_FACTOR_ALPHA_MODULATE_IMG = 0x8C07
        /// </summary>
        FactorAlphaModulateImg = 0x8c07,

        /// <summary>
        /// Original was GL_FRAGMENT_ALPHA_MODULATE_IMG = 0x8C08
        /// </summary>
        FragmentAlphaModulateImg = 0x8c08,

        /// <summary>
        /// Original was GL_ADD_BLEND_IMG = 0x8C09
        /// </summary>
        AddBlendImg = 0x8c09,

        /// <summary>
        /// Original was GL_TEXTURE_1D_ARRAY = 0x8C18
        /// </summary>
        Texture1DArray = 0x8c18,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19
        /// </summary>
        ProxyTexture1DArray = 0x8c19,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19
        /// </summary>
        ProxyTexture1DArrayExt = 0x8c19,

        /// <summary>
        /// Original was GL_TEXTURE_2D_ARRAY = 0x8C1A
        /// </summary>
        Texture2DArray = 0x8c1a,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B
        /// </summary>
        ProxyTexture2DArray = 0x8c1b,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B
        /// </summary>
        ProxyTexture2DArrayExt = 0x8c1b,

        /// <summary>
        /// Original was GL_TEXTURE_BUFFER = 0x8C2A
        /// </summary>
        TextureBuffer = 0x8c2a,

        /// <summary>
        /// Original was GL_ANY_SAMPLES_PASSED = 0x8C2F
        /// </summary>
        AnySamplesPassed = 0x8c2f,

        /// <summary>
        /// Original was GL_R11F_G11F_B10F = 0x8C3A
        /// </summary>
        R11fG11fB10f = 0x8c3a,

        /// <summary>
        /// Original was GL_R11F_G11F_B10F_APPLE = 0x8C3A
        /// </summary>
        R11fG11fB10fApple = 0x8c3a,

        /// <summary>
        /// Original was GL_R11F_G11F_B10F_EXT = 0x8C3A
        /// </summary>
        R11fG11fB10fExt = 0x8c3a,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        /// </summary>
        UnsignedInt10F11F11FRev = 0x8c3b,

        /// <summary>
        /// Original was GL_RGB9_E5 = 0x8C3D
        /// </summary>
        Rgb9E5 = 0x8c3d,

        /// <summary>
        /// Original was GL_RGB9_E5_APPLE = 0x8C3D
        /// </summary>
        Rgb9E5Apple = 0x8c3d,

        /// <summary>
        /// Original was GL_RGB9_E5_EXT = 0x8C3D
        /// </summary>
        Rgb9E5Ext = 0x8c3d,

        /// <summary>
        /// Original was GL_SRGB = 0x8C40
        /// </summary>
        Srgb = 0x8c40,

        /// <summary>
        /// Original was GL_SRGB_EXT = 0x8C40
        /// </summary>
        SrgbExt = 0x8c40,

        /// <summary>
        /// Original was GL_SRGB8 = 0x8C41
        /// </summary>
        Srgb8 = 0x8c41,

        /// <summary>
        /// Original was GL_SRGB8_EXT = 0x8C41
        /// </summary>
        Srgb8Ext = 0x8c41,

        /// <summary>
        /// Original was GL_SRGB8_NV = 0x8C41
        /// </summary>
        Srgb8Nv = 0x8c41,

        /// <summary>
        /// Original was GL_SRGB_ALPHA = 0x8C42
        /// </summary>
        SrgbAlpha = 0x8c42,

        /// <summary>
        /// Original was GL_SRGB_ALPHA_EXT = 0x8C42
        /// </summary>
        SrgbAlphaExt = 0x8c42,

        /// <summary>
        /// Original was GL_SRGB8_ALPHA8 = 0x8C43
        /// </summary>
        Srgb8Alpha8 = 0x8c43,

        /// <summary>
        /// Original was GL_SRGB8_ALPHA8_EXT = 0x8C43
        /// </summary>
        Srgb8Alpha8Ext = 0x8c43,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB = 0x8C48
        /// </summary>
        CompressedSrgb = 0x8c48,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA = 0x8C49
        /// </summary>
        CompressedSrgbAlpha = 0x8c49,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C
        /// </summary>
        CompressedSrgbS3tcDxt1Ext = 0x8c4c,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D
        /// </summary>
        CompressedSrgbAlphaS3tcDxt1Ext = 0x8c4d,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E
        /// </summary>
        CompressedSrgbAlphaS3tcDxt3Ext = 0x8c4e,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F
        /// </summary>
        CompressedSrgbAlphaS3tcDxt5Ext = 0x8c4f,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76
        /// </summary>
        TransformFeedbackVaryingMaxLength = 0x8c76,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F
        /// </summary>
        TransformFeedbackBufferMode = 0x8c7f,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83
        /// </summary>
        TransformFeedbackVaryings = 0x8c83,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84
        /// </summary>
        TransformFeedbackBufferStart = 0x8c84,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85
        /// </summary>
        TransformFeedbackBufferSize = 0x8c85,

        /// <summary>
        /// Original was GL_PRIMITIVES_GENERATED = 0x8C87
        /// </summary>
        PrimitivesGenerated = 0x8c87,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88
        /// </summary>
        TransformFeedbackPrimitivesWritten = 0x8c88,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        /// </summary>
        TransformFeedbackBuffer = 0x8c8e,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F
        /// </summary>
        TransformFeedbackBufferBinding = 0x8c8f,

        /// <summary>
        /// Original was GL_ATC_RGB_AMD = 0x8C92
        /// </summary>
        AtcRgbAmd = 0x8c92,

        /// <summary>
        /// Original was GL_ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93
        /// </summary>
        AtcRgbaExplicitAlphaAmd = 0x8c93,

        /// <summary>
        /// Original was GL_LOWER_LEFT = 0x8CA1
        /// </summary>
        LowerLeft = 0x8ca1,

        /// <summary>
        /// Original was GL_UPPER_LEFT = 0x8CA2
        /// </summary>
        UpperLeft = 0x8ca2,

        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_BINDING_APPLE = 0x8CA6
        /// </summary>
        DrawFramebufferBindingApple = 0x8ca6,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BINDING_OES = 0x8CA6
        /// </summary>
        FramebufferBindingOes = 0x8ca6,

        /// <summary>
        /// Original was GL_RENDERBUFFER_BINDING_OES = 0x8CA7
        /// </summary>
        RenderbufferBindingOes = 0x8ca7,

        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER = 0x8CA8
        /// </summary>
        ReadFramebuffer = 0x8ca8,

        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_APPLE = 0x8CA8
        /// </summary>
        ReadFramebufferApple = 0x8ca8,

        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER = 0x8CA9
        /// </summary>
        DrawFramebuffer = 0x8ca9,

        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_APPLE = 0x8CA9
        /// </summary>
        DrawFramebufferApple = 0x8ca9,

        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_BINDING_APPLE = 0x8CAA
        /// </summary>
        ReadFramebufferBindingApple = 0x8caa,

        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES = 0x8CAB
        /// </summary>
        RenderbufferSamples = 0x8cab,

        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_APPLE = 0x8CAB
        /// </summary>
        RenderbufferSamplesApple = 0x8cab,

        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_EXT = 0x8CAB
        /// </summary>
        RenderbufferSamplesExt = 0x8cab,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        /// </summary>
        DepthComponent32f = 0x8cac,

        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        /// </summary>
        Depth32fStencil8 = 0x8cad,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES = 0x8CD0
        /// </summary>
        FramebufferAttachmentObjectTypeOes = 0x8cd0,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectName = 0x8cd1,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectNameOes = 0x8cd1,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevel = 0x8cd2,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevelOes = 0x8cd2,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFace = 0x8cd3,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFaceOes = 0x8cd3,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4
        /// </summary>
        FramebufferAttachmentTextureLayer = 0x8cd4,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE = 0x8CD5
        /// </summary>
        FramebufferComplete = 0x8cd5,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE_OES = 0x8CD5
        /// </summary>
        FramebufferCompleteOes = 0x8cd5,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachment = 0x8cd6,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachmentOes = 0x8cd6,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachment = 0x8cd7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachmentOes = 0x8cd7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES = 0x8CD9
        /// </summary>
        FramebufferIncompleteDimensionsOes = 0x8cd9,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES = 0x8CDA
        /// </summary>
        FramebufferIncompleteFormatsOes = 0x8cda,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB
        /// </summary>
        FramebufferIncompleteDrawBuffer = 0x8cdb,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC
        /// </summary>
        FramebufferIncompleteReadBuffer = 0x8cdc,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD
        /// </summary>
        FramebufferUnsupported = 0x8cdd,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED_OES = 0x8CDD
        /// </summary>
        FramebufferUnsupportedOes = 0x8cdd,

        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS = 0x8CDF
        /// </summary>
        MaxColorAttachments = 0x8cdf,

        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS_EXT = 0x8CDF
        /// </summary>
        MaxColorAttachmentsExt = 0x8cdf,

        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS_NV = 0x8CDF
        /// </summary>
        MaxColorAttachmentsNv = 0x8cdf,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        /// </summary>
        ColorAttachment0 = 0x8ce0,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_EXT = 0x8CE0
        /// </summary>
        ColorAttachment0Ext = 0x8ce0,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_NV = 0x8CE0
        /// </summary>
        ColorAttachment0Nv = 0x8ce0,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_OES = 0x8CE0
        /// </summary>
        ColorAttachment0Oes = 0x8ce0,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        /// </summary>
        ColorAttachment1 = 0x8ce1,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1_EXT = 0x8CE1
        /// </summary>
        ColorAttachment1Ext = 0x8ce1,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1_NV = 0x8CE1
        /// </summary>
        ColorAttachment1Nv = 0x8ce1,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        /// </summary>
        ColorAttachment2 = 0x8ce2,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2_EXT = 0x8CE2
        /// </summary>
        ColorAttachment2Ext = 0x8ce2,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2_NV = 0x8CE2
        /// </summary>
        ColorAttachment2Nv = 0x8ce2,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        /// </summary>
        ColorAttachment3 = 0x8ce3,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3_EXT = 0x8CE3
        /// </summary>
        ColorAttachment3Ext = 0x8ce3,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3_NV = 0x8CE3
        /// </summary>
        ColorAttachment3Nv = 0x8ce3,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        /// </summary>
        ColorAttachment4 = 0x8ce4,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4_EXT = 0x8CE4
        /// </summary>
        ColorAttachment4Ext = 0x8ce4,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4_NV = 0x8CE4
        /// </summary>
        ColorAttachment4Nv = 0x8ce4,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        /// </summary>
        ColorAttachment5 = 0x8ce5,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5_EXT = 0x8CE5
        /// </summary>
        ColorAttachment5Ext = 0x8ce5,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5_NV = 0x8CE5
        /// </summary>
        ColorAttachment5Nv = 0x8ce5,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        /// </summary>
        ColorAttachment6 = 0x8ce6,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6_EXT = 0x8CE6
        /// </summary>
        ColorAttachment6Ext = 0x8ce6,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6_NV = 0x8CE6
        /// </summary>
        ColorAttachment6Nv = 0x8ce6,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        /// </summary>
        ColorAttachment7 = 0x8ce7,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7_EXT = 0x8CE7
        /// </summary>
        ColorAttachment7Ext = 0x8ce7,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7_NV = 0x8CE7
        /// </summary>
        ColorAttachment7Nv = 0x8ce7,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        /// </summary>
        ColorAttachment8 = 0x8ce8,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8_EXT = 0x8CE8
        /// </summary>
        ColorAttachment8Ext = 0x8ce8,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8_NV = 0x8CE8
        /// </summary>
        ColorAttachment8Nv = 0x8ce8,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        /// </summary>
        ColorAttachment9 = 0x8ce9,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9_EXT = 0x8CE9
        /// </summary>
        ColorAttachment9Ext = 0x8ce9,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9_NV = 0x8CE9
        /// </summary>
        ColorAttachment9Nv = 0x8ce9,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        /// </summary>
        ColorAttachment10 = 0x8cea,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10_EXT = 0x8CEA
        /// </summary>
        ColorAttachment10Ext = 0x8cea,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10_NV = 0x8CEA
        /// </summary>
        ColorAttachment10Nv = 0x8cea,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        /// </summary>
        ColorAttachment11 = 0x8ceb,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11_EXT = 0x8CEB
        /// </summary>
        ColorAttachment11Ext = 0x8ceb,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11_NV = 0x8CEB
        /// </summary>
        ColorAttachment11Nv = 0x8ceb,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        /// </summary>
        ColorAttachment12 = 0x8cec,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12_EXT = 0x8CEC
        /// </summary>
        ColorAttachment12Ext = 0x8cec,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12_NV = 0x8CEC
        /// </summary>
        ColorAttachment12Nv = 0x8cec,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        /// </summary>
        ColorAttachment13 = 0x8ced,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13_EXT = 0x8CED
        /// </summary>
        ColorAttachment13Ext = 0x8ced,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13_NV = 0x8CED
        /// </summary>
        ColorAttachment13Nv = 0x8ced,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        /// </summary>
        ColorAttachment14 = 0x8cee,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14_EXT = 0x8CEE
        /// </summary>
        ColorAttachment14Ext = 0x8cee,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14_NV = 0x8CEE
        /// </summary>
        ColorAttachment14Nv = 0x8cee,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        /// </summary>
        ColorAttachment15 = 0x8cef,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15_EXT = 0x8CEF
        /// </summary>
        ColorAttachment15Ext = 0x8cef,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15_NV = 0x8CEF
        /// </summary>
        ColorAttachment15Nv = 0x8cef,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT16 = 0x8CF0
        /// </summary>
        ColorAttachment16 = 0x8cf0,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT17 = 0x8CF1
        /// </summary>
        ColorAttachment17 = 0x8cf1,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT18 = 0x8CF2
        /// </summary>
        ColorAttachment18 = 0x8cf2,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT19 = 0x8CF3
        /// </summary>
        ColorAttachment19 = 0x8cf3,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT20 = 0x8CF4
        /// </summary>
        ColorAttachment20 = 0x8cf4,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT21 = 0x8CF5
        /// </summary>
        ColorAttachment21 = 0x8cf5,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT22 = 0x8CF6
        /// </summary>
        ColorAttachment22 = 0x8cf6,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT23 = 0x8CF7
        /// </summary>
        ColorAttachment23 = 0x8cf7,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT24 = 0x8CF8
        /// </summary>
        ColorAttachment24 = 0x8cf8,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT25 = 0x8CF9
        /// </summary>
        ColorAttachment25 = 0x8cf9,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT26 = 0x8CFA
        /// </summary>
        ColorAttachment26 = 0x8cfa,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT27 = 0x8CFB
        /// </summary>
        ColorAttachment27 = 0x8cfb,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT28 = 0x8CFC
        /// </summary>
        ColorAttachment28 = 0x8cfc,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT29 = 0x8CFD
        /// </summary>
        ColorAttachment29 = 0x8cfd,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT30 = 0x8CFE
        /// </summary>
        ColorAttachment30 = 0x8cfe,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT31 = 0x8CFF
        /// </summary>
        ColorAttachment31 = 0x8cff,

        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT = 0x8D00
        /// </summary>
        DepthAttachment = 0x8d00,

        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_EXT = 0x8D00
        /// </summary>
        DepthAttachmentExt = 0x8d00,

        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_OES = 0x8D00
        /// </summary>
        DepthAttachmentOes = 0x8d00,

        /// <summary>
        /// Original was GL_STENCIL_ATTACHMENT_OES = 0x8D20
        /// </summary>
        StencilAttachmentOes = 0x8d20,

        /// <summary>
        /// Original was GL_FRAMEBUFFER = 0x8D40
        /// </summary>
        Framebuffer = 0x8d40,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_OES = 0x8D40
        /// </summary>
        FramebufferOes = 0x8d40,

        /// <summary>
        /// Original was GL_RENDERBUFFER = 0x8D41
        /// </summary>
        Renderbuffer = 0x8d41,

        /// <summary>
        /// Original was GL_RENDERBUFFER_OES = 0x8D41
        /// </summary>
        RenderbufferOes = 0x8d41,

        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH = 0x8D42
        /// </summary>
        RenderbufferWidth = 0x8d42,

        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH_OES = 0x8D42
        /// </summary>
        RenderbufferWidthOes = 0x8d42,

        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT = 0x8D43
        /// </summary>
        RenderbufferHeight = 0x8d43,

        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT_OES = 0x8D43
        /// </summary>
        RenderbufferHeightOes = 0x8d43,

        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44
        /// </summary>
        RenderbufferInternalFormat = 0x8d44,

        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT_OES = 0x8D44
        /// </summary>
        RenderbufferInternalFormatOes = 0x8d44,

        /// <summary>
        /// Original was GL_STENCIL_INDEX1_OES = 0x8D46
        /// </summary>
        StencilIndex1Oes = 0x8d46,

        /// <summary>
        /// Original was GL_STENCIL_INDEX4_OES = 0x8D47
        /// </summary>
        StencilIndex4Oes = 0x8d47,

        /// <summary>
        /// Original was GL_STENCIL_INDEX8_OES = 0x8D48
        /// </summary>
        StencilIndex8Oes = 0x8d48,

        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE = 0x8D50
        /// </summary>
        RenderbufferRedSize = 0x8d50,

        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE_OES = 0x8D50
        /// </summary>
        RenderbufferRedSizeOes = 0x8d50,

        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE = 0x8D51
        /// </summary>
        RenderbufferGreenSize = 0x8d51,

        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE_OES = 0x8D51
        /// </summary>
        RenderbufferGreenSizeOes = 0x8d51,

        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE = 0x8D52
        /// </summary>
        RenderbufferBlueSize = 0x8d52,

        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE_OES = 0x8D52
        /// </summary>
        RenderbufferBlueSizeOes = 0x8d52,

        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53
        /// </summary>
        RenderbufferAlphaSize = 0x8d53,

        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE_OES = 0x8D53
        /// </summary>
        RenderbufferAlphaSizeOes = 0x8d53,

        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54
        /// </summary>
        RenderbufferDepthSize = 0x8d54,

        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE_OES = 0x8D54
        /// </summary>
        RenderbufferDepthSizeOes = 0x8d54,

        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55
        /// </summary>
        RenderbufferStencilSize = 0x8d55,

        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE_OES = 0x8D55
        /// </summary>
        RenderbufferStencilSizeOes = 0x8d55,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisample = 0x8d56,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisampleApple = 0x8d56,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisampleExt = 0x8d56,

        /// <summary>
        /// Original was GL_MAX_SAMPLES_APPLE = 0x8D57
        /// </summary>
        MaxSamplesApple = 0x8d57,

        /// <summary>
        /// Original was GL_MAX_SAMPLES_EXT = 0x8D57
        /// </summary>
        MaxSamplesExt = 0x8d57,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_STR_OES = 0x8D60
        /// </summary>
        TextureGenStrOes = 0x8d60,

        /// <summary>
        /// Original was GL_RGB565_OES = 0x8D62
        /// </summary>
        Rgb565Oes = 0x8d62,

        /// <summary>
        /// Original was GL_ETC1_RGB8_OES = 0x8D64
        /// </summary>
        Etc1Rgb8Oes = 0x8d64,

        /// <summary>
        /// Original was GL_TEXTURE_EXTERNAL_OES = 0x8D65
        /// </summary>
        TextureExternalOes = 0x8d65,

        /// <summary>
        /// Original was GL_SAMPLER_EXTERNAL_OES = 0x8D66
        /// </summary>
        SamplerExternalOes = 0x8d66,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_EXTERNAL_OES = 0x8D67
        /// </summary>
        TextureBindingExternalOes = 0x8d67,

        /// <summary>
        /// Original was GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES = 0x8D68
        /// </summary>
        RequiredTextureImageUnitsOes = 0x8d68,

        /// <summary>
        /// Original was GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A
        /// </summary>
        AnySamplesPassedConservative = 0x8d6a,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT = 0x8D6C
        /// </summary>
        FramebufferAttachmentTextureSamplesExt = 0x8d6c,

        /// <summary>
        /// Original was GL_RGBA32UI = 0x8D70
        /// </summary>
        Rgba32ui = 0x8d70,

        /// <summary>
        /// Original was GL_RGB32UI = 0x8D71
        /// </summary>
        Rgb32ui = 0x8d71,

        /// <summary>
        /// Original was GL_RGBA16UI = 0x8D76
        /// </summary>
        Rgba16ui = 0x8d76,

        /// <summary>
        /// Original was GL_RGB16UI = 0x8D77
        /// </summary>
        Rgb16ui = 0x8d77,

        /// <summary>
        /// Original was GL_RGBA8UI = 0x8D7C
        /// </summary>
        Rgba8ui = 0x8d7c,

        /// <summary>
        /// Original was GL_RGB8UI = 0x8D7D
        /// </summary>
        Rgb8ui = 0x8d7d,

        /// <summary>
        /// Original was GL_RGBA32I = 0x8D82
        /// </summary>
        Rgba32i = 0x8d82,

        /// <summary>
        /// Original was GL_RGB32I = 0x8D83
        /// </summary>
        Rgb32i = 0x8d83,

        /// <summary>
        /// Original was GL_RGBA16I = 0x8D88
        /// </summary>
        Rgba16i = 0x8d88,

        /// <summary>
        /// Original was GL_RGB16I = 0x8D89
        /// </summary>
        Rgb16i = 0x8d89,

        /// <summary>
        /// Original was GL_RGBA8I = 0x8D8E
        /// </summary>
        Rgba8i = 0x8d8e,

        /// <summary>
        /// Original was GL_RGB8I = 0x8D8F
        /// </summary>
        Rgb8i = 0x8d8f,

        /// <summary>
        /// Original was GL_INT_2_10_10_10_REV = 0x8D9F
        /// </summary>
        Int2101010Rev = 0x8d9f,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7
        /// </summary>
        FramebufferAttachmentLayered = 0x8da7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8
        /// </summary>
        FramebufferIncompleteLayerTargets = 0x8da8,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F_NV = 0x8DAB
        /// </summary>
        DepthComponent32fNv = 0x8dab,

        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8_NV = 0x8DAC
        /// </summary>
        Depth32fStencil8Nv = 0x8dac,

        /// <summary>
        /// Original was GL_COMPRESSED_RED_RGTC1 = 0x8DBB
        /// </summary>
        CompressedRedRgtc1 = 0x8dbb,

        /// <summary>
        /// Original was GL_COMPRESSED_RED_RGTC1_EXT = 0x8DBB
        /// </summary>
        CompressedRedRgtc1Ext = 0x8dbb,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC
        /// </summary>
        CompressedSignedRedRgtc1 = 0x8dbc,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC
        /// </summary>
        CompressedSignedRedRgtc1Ext = 0x8dbc,

        /// <summary>
        /// Original was GL_COMPRESSED_RG_RGTC2 = 0x8DBD
        /// </summary>
        CompressedRgRgtc2 = 0x8dbd,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE
        /// </summary>
        CompressedSignedRgRgtc2 = 0x8dbe,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER = 0x8DD9
        /// </summary>
        GeometryShader = 0x8dd9,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINES = 0x8DE5
        /// </summary>
        ActiveSubroutines = 0x8de5,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6
        /// </summary>
        ActiveSubroutineUniforms = 0x8de6,

        /// <summary>
        /// Original was GL_LOW_FLOAT = 0x8DF0
        /// </summary>
        LowFloat = 0x8df0,

        /// <summary>
        /// Original was GL_MEDIUM_FLOAT = 0x8DF1
        /// </summary>
        MediumFloat = 0x8df1,

        /// <summary>
        /// Original was GL_HIGH_FLOAT = 0x8DF2
        /// </summary>
        HighFloat = 0x8df2,

        /// <summary>
        /// Original was GL_LOW_INT = 0x8DF3
        /// </summary>
        LowInt = 0x8df3,

        /// <summary>
        /// Original was GL_MEDIUM_INT = 0x8DF4
        /// </summary>
        MediumInt = 0x8df4,

        /// <summary>
        /// Original was GL_HIGH_INT = 0x8DF5
        /// </summary>
        HighInt = 0x8df5,

        /// <summary>
        /// Original was GL_QUERY_WAIT = 0x8E13
        /// </summary>
        QueryWait = 0x8e13,

        /// <summary>
        /// Original was GL_QUERY_NO_WAIT = 0x8E14
        /// </summary>
        QueryNoWait = 0x8e14,

        /// <summary>
        /// Original was GL_QUERY_BY_REGION_WAIT = 0x8E15
        /// </summary>
        QueryByRegionWait = 0x8e15,

        /// <summary>
        /// Original was GL_QUERY_BY_REGION_NO_WAIT = 0x8E16
        /// </summary>
        QueryByRegionNoWait = 0x8e16,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK = 0x8E22
        /// </summary>
        TransformFeedback = 0x8e22,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23
        /// </summary>
        TransformFeedbackPaused = 0x8e23,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24
        /// </summary>
        TransformFeedbackActive = 0x8e24,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_R = 0x8E42
        /// </summary>
        TextureSwizzleR = 0x8e42,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_G = 0x8E43
        /// </summary>
        TextureSwizzleG = 0x8e43,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_B = 0x8E44
        /// </summary>
        TextureSwizzleB = 0x8e44,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_A = 0x8E45
        /// </summary>
        TextureSwizzleA = 0x8e45,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_RGBA = 0x8E46
        /// </summary>
        TextureSwizzleRgba = 0x8e46,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47
        /// </summary>
        ActiveSubroutineUniformLocations = 0x8e47,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48
        /// </summary>
        ActiveSubroutineMaxLength = 0x8e48,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49
        /// </summary>
        ActiveSubroutineUniformMaxLength = 0x8e49,

        /// <summary>
        /// Original was GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A
        /// </summary>
        NumCompatibleSubroutines = 0x8e4a,

        /// <summary>
        /// Original was GL_COMPATIBLE_SUBROUTINES = 0x8E4B
        /// </summary>
        CompatibleSubroutines = 0x8e4b,

        /// <summary>
        /// Original was GL_FIRST_VERTEX_CONVENTION = 0x8E4D
        /// </summary>
        FirstVertexConvention = 0x8e4d,

        /// <summary>
        /// Original was GL_LAST_VERTEX_CONVENTION = 0x8E4E
        /// </summary>
        LastVertexConvention = 0x8e4e,

        /// <summary>
        /// Original was GL_PATCH_VERTICES = 0x8E72
        /// </summary>
        PatchVertices = 0x8e72,

        /// <summary>
        /// Original was GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73
        /// </summary>
        PatchDefaultInnerLevel = 0x8e73,

        /// <summary>
        /// Original was GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74
        /// </summary>
        PatchDefaultOuterLevel = 0x8e74,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER = 0x8E87
        /// </summary>
        TessEvaluationShader = 0x8e87,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER = 0x8E88
        /// </summary>
        TessControlShader = 0x8e88,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
        /// </summary>
        CompressedRgbaBptcUnorm = 0x8e8c,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D
        /// </summary>
        CompressedSrgbAlphaBptcUnorm = 0x8e8d,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
        /// </summary>
        CompressedRgbBptcSignedFloat = 0x8e8e,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
        /// </summary>
        CompressedRgbBptcUnsignedFloat = 0x8e8f,

        /// <summary>
        /// Original was GL_COPY_READ_BUFFER = 0x8F36
        /// </summary>
        CopyReadBuffer = 0x8f36,

        /// <summary>
        /// Original was GL_COPY_WRITE_BUFFER = 0x8F37
        /// </summary>
        CopyWriteBuffer = 0x8f37,

        /// <summary>
        /// Original was GL_DRAW_INDIRECT_BUFFER = 0x8F3F
        /// </summary>
        DrawIndirectBuffer = 0x8f3f,

        /// <summary>
        /// Original was GL_R8_SNORM = 0x8F94
        /// </summary>
        R8Snorm = 0x8f94,

        /// <summary>
        /// Original was GL_RG8_SNORM = 0x8F95
        /// </summary>
        Rg8Snorm = 0x8f95,

        /// <summary>
        /// Original was GL_RGB8_SNORM = 0x8F96
        /// </summary>
        Rgb8Snorm = 0x8f96,

        /// <summary>
        /// Original was GL_RGBA8_SNORM = 0x8F97
        /// </summary>
        Rgba8Snorm = 0x8f97,

        /// <summary>
        /// Original was GL_R16_SNORM = 0x8F98
        /// </summary>
        R16Snorm = 0x8f98,

        /// <summary>
        /// Original was GL_R16_SNORM_EXT = 0x8F98
        /// </summary>
        R16SnormExt = 0x8f98,

        /// <summary>
        /// Original was GL_RG16_SNORM = 0x8F99
        /// </summary>
        Rg16Snorm = 0x8f99,

        /// <summary>
        /// Original was GL_RG16_SNORM_EXT = 0x8F99
        /// </summary>
        Rg16SnormExt = 0x8f99,

        /// <summary>
        /// Original was GL_RGB16_SNORM = 0x8F9A
        /// </summary>
        Rgb16Snorm = 0x8f9a,

        /// <summary>
        /// Original was GL_RGB16_SNORM_EXT = 0x8F9A
        /// </summary>
        Rgb16SnormExt = 0x8f9a,

        /// <summary>
        /// Original was GL_PERFMON_GLOBAL_MODE_QCOM = 0x8FA0
        /// </summary>
        PerfmonGlobalModeQcom = 0x8fa0,

        /// <summary>
        /// Original was GL_BINNING_CONTROL_HINT_QCOM = 0x8FB0
        /// </summary>
        BinningControlHintQcom = 0x8fb0,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009
        /// </summary>
        TextureCubeMapArray = 0x9009,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009
        /// </summary>
        TextureCubeMapArrayArb = 0x9009,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_EXT = 0x9009
        /// </summary>
        TextureCubeMapArrayExt = 0x9009,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_OES = 0x9009
        /// </summary>
        TextureCubeMapArrayOes = 0x9009,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B
        /// </summary>
        ProxyTextureCubeMapArray = 0x900b,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B
        /// </summary>
        ProxyTextureCubeMapArrayArb = 0x900b,

        /// <summary>
        /// Original was GL_RGB10_A2UI = 0x906F
        /// </summary>
        Rgb10A2ui = 0x906f,

        /// <summary>
        /// Original was GL_PATH_FORMAT_SVG_NV = 0x9070
        /// </summary>
        PathFormatSvgNv = 0x9070,

        /// <summary>
        /// Original was GL_PATH_FORMAT_PS_NV = 0x9071
        /// </summary>
        PathFormatPsNv = 0x9071,

        /// <summary>
        /// Original was GL_STANDARD_FONT_NAME_NV = 0x9072
        /// </summary>
        StandardFontNameNv = 0x9072,

        /// <summary>
        /// Original was GL_SYSTEM_FONT_NAME_NV = 0x9073
        /// </summary>
        SystemFontNameNv = 0x9073,

        /// <summary>
        /// Original was GL_FILE_NAME_NV = 0x9074
        /// </summary>
        FileNameNv = 0x9074,

        /// <summary>
        /// Original was GL_PATH_STROKE_WIDTH_NV = 0x9075
        /// </summary>
        PathStrokeWidthNv = 0x9075,

        /// <summary>
        /// Original was GL_PATH_END_CAPS_NV = 0x9076
        /// </summary>
        PathEndCapsNv = 0x9076,

        /// <summary>
        /// Original was GL_PATH_INITIAL_END_CAP_NV = 0x9077
        /// </summary>
        PathInitialEndCapNv = 0x9077,

        /// <summary>
        /// Original was GL_PATH_TERMINAL_END_CAP_NV = 0x9078
        /// </summary>
        PathTerminalEndCapNv = 0x9078,

        /// <summary>
        /// Original was GL_PATH_JOIN_STYLE_NV = 0x9079
        /// </summary>
        PathJoinStyleNv = 0x9079,

        /// <summary>
        /// Original was GL_PATH_MITER_LIMIT_NV = 0x907A
        /// </summary>
        PathMiterLimitNv = 0x907a,

        /// <summary>
        /// Original was GL_PATH_DASH_CAPS_NV = 0x907B
        /// </summary>
        PathDashCapsNv = 0x907b,

        /// <summary>
        /// Original was GL_PATH_INITIAL_DASH_CAP_NV = 0x907C
        /// </summary>
        PathInitialDashCapNv = 0x907c,

        /// <summary>
        /// Original was GL_PATH_TERMINAL_DASH_CAP_NV = 0x907D
        /// </summary>
        PathTerminalDashCapNv = 0x907d,

        /// <summary>
        /// Original was GL_PATH_DASH_OFFSET_NV = 0x907E
        /// </summary>
        PathDashOffsetNv = 0x907e,

        /// <summary>
        /// Original was GL_PATH_CLIENT_LENGTH_NV = 0x907F
        /// </summary>
        PathClientLengthNv = 0x907f,

        /// <summary>
        /// Original was GL_PATH_FILL_MODE_NV = 0x9080
        /// </summary>
        PathFillModeNv = 0x9080,

        /// <summary>
        /// Original was GL_PATH_FILL_MASK_NV = 0x9081
        /// </summary>
        PathFillMaskNv = 0x9081,

        /// <summary>
        /// Original was GL_PATH_FILL_COVER_MODE_NV = 0x9082
        /// </summary>
        PathFillCoverModeNv = 0x9082,

        /// <summary>
        /// Original was GL_PATH_STROKE_COVER_MODE_NV = 0x9083
        /// </summary>
        PathStrokeCoverModeNv = 0x9083,

        /// <summary>
        /// Original was GL_PATH_STROKE_MASK_NV = 0x9084
        /// </summary>
        PathStrokeMaskNv = 0x9084,

        /// <summary>
        /// Original was GL_COUNT_UP_NV = 0x9088
        /// </summary>
        CountUpNv = 0x9088,

        /// <summary>
        /// Original was GL_COUNT_DOWN_NV = 0x9089
        /// </summary>
        CountDownNv = 0x9089,

        /// <summary>
        /// Original was GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A
        /// </summary>
        PathObjectBoundingBoxNv = 0x908a,

        /// <summary>
        /// Original was GL_CONVEX_HULL_NV = 0x908B
        /// </summary>
        ConvexHullNv = 0x908b,

        /// <summary>
        /// Original was GL_BOUNDING_BOX_NV = 0x908D
        /// </summary>
        BoundingBoxNv = 0x908d,

        /// <summary>
        /// Original was GL_TRANSLATE_X_NV = 0x908E
        /// </summary>
        TranslateXNv = 0x908e,

        /// <summary>
        /// Original was GL_TRANSLATE_Y_NV = 0x908F
        /// </summary>
        TranslateYNv = 0x908f,

        /// <summary>
        /// Original was GL_TRANSLATE_2D_NV = 0x9090
        /// </summary>
        Translate2DNv = 0x9090,

        /// <summary>
        /// Original was GL_TRANSLATE_3D_NV = 0x9091
        /// </summary>
        Translate3DNv = 0x9091,

        /// <summary>
        /// Original was GL_AFFINE_2D_NV = 0x9092
        /// </summary>
        Affine2DNv = 0x9092,

        /// <summary>
        /// Original was GL_AFFINE_3D_NV = 0x9094
        /// </summary>
        Affine3DNv = 0x9094,

        /// <summary>
        /// Original was GL_TRANSPOSE_AFFINE_2D_NV = 0x9096
        /// </summary>
        TransposeAffine2DNv = 0x9096,

        /// <summary>
        /// Original was GL_TRANSPOSE_AFFINE_3D_NV = 0x9098
        /// </summary>
        TransposeAffine3DNv = 0x9098,

        /// <summary>
        /// Original was GL_UTF8_NV = 0x909A
        /// </summary>
        Utf8Nv = 0x909a,

        /// <summary>
        /// Original was GL_UTF16_NV = 0x909B
        /// </summary>
        Utf16Nv = 0x909b,

        /// <summary>
        /// Original was GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C
        /// </summary>
        BoundingBoxOfBoundingBoxesNv = 0x909c,

        /// <summary>
        /// Original was GL_PATH_COMMAND_COUNT_NV = 0x909D
        /// </summary>
        PathCommandCountNv = 0x909d,

        /// <summary>
        /// Original was GL_PATH_COORD_COUNT_NV = 0x909E
        /// </summary>
        PathCoordCountNv = 0x909e,

        /// <summary>
        /// Original was GL_PATH_DASH_ARRAY_COUNT_NV = 0x909F
        /// </summary>
        PathDashArrayCountNv = 0x909f,

        /// <summary>
        /// Original was GL_PATH_COMPUTED_LENGTH_NV = 0x90A0
        /// </summary>
        PathComputedLengthNv = 0x90a0,

        /// <summary>
        /// Original was GL_PATH_FILL_BOUNDING_BOX_NV = 0x90A1
        /// </summary>
        PathFillBoundingBoxNv = 0x90a1,

        /// <summary>
        /// Original was GL_PATH_STROKE_BOUNDING_BOX_NV = 0x90A2
        /// </summary>
        PathStrokeBoundingBoxNv = 0x90a2,

        /// <summary>
        /// Original was GL_SKIP_MISSING_GLYPH_NV = 0x90A9
        /// </summary>
        SkipMissingGlyphNv = 0x90a9,

        /// <summary>
        /// Original was GL_USE_MISSING_GLYPH_NV = 0x90AA
        /// </summary>
        UseMissingGlyphNv = 0x90aa,

        /// <summary>
        /// Original was GL_ACCUM_ADJACENT_PAIRS_NV = 0x90AD
        /// </summary>
        AccumAdjacentPairsNv = 0x90ad,

        /// <summary>
        /// Original was GL_ADJACENT_PAIRS_NV = 0x90AE
        /// </summary>
        AdjacentPairsNv = 0x90ae,

        /// <summary>
        /// Original was GL_FIRST_TO_REST_NV = 0x90AF
        /// </summary>
        FirstToRestNv = 0x90af,

        /// <summary>
        /// Original was GL_PATH_DASH_OFFSET_RESET_NV = 0x90B4
        /// </summary>
        PathDashOffsetResetNv = 0x90b4,

        /// <summary>
        /// Original was GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7
        /// </summary>
        ImageFormatCompatibilityType = 0x90c7,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER = 0x90D2
        /// </summary>
        ShaderStorageBuffer = 0x90d2,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA
        /// </summary>
        DepthStencilTextureMode = 0x90ea,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC
        /// </summary>
        UniformBlockReferencedByComputeShader = 0x90ec,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED
        /// </summary>
        AtomicCounterBufferReferencedByComputeShader = 0x90ed,

        /// <summary>
        /// Original was GL_DISPATCH_INDIRECT_BUFFER = 0x90EE
        /// </summary>
        DispatchIndirectBuffer = 0x90ee,

        /// <summary>
        /// Original was GL_CONTEXT_ROBUST_ACCESS_EXT = 0x90F3
        /// </summary>
        ContextRobustAccessExt = 0x90f3,

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
        /// Original was GL_MAX_SERVER_WAIT_TIMEOUT_APPLE = 0x9111
        /// </summary>
        MaxServerWaitTimeoutApple = 0x9111,

        /// <summary>
        /// Original was GL_OBJECT_TYPE = 0x9112
        /// </summary>
        ObjectType = 0x9112,

        /// <summary>
        /// Original was GL_OBJECT_TYPE_APPLE = 0x9112
        /// </summary>
        ObjectTypeApple = 0x9112,

        /// <summary>
        /// Original was GL_SYNC_CONDITION = 0x9113
        /// </summary>
        SyncCondition = 0x9113,

        /// <summary>
        /// Original was GL_SYNC_CONDITION_APPLE = 0x9113
        /// </summary>
        SyncConditionApple = 0x9113,

        /// <summary>
        /// Original was GL_SYNC_STATUS = 0x9114
        /// </summary>
        SyncStatus = 0x9114,

        /// <summary>
        /// Original was GL_SYNC_STATUS_APPLE = 0x9114
        /// </summary>
        SyncStatusApple = 0x9114,

        /// <summary>
        /// Original was GL_SYNC_FLAGS = 0x9115
        /// </summary>
        SyncFlags = 0x9115,

        /// <summary>
        /// Original was GL_SYNC_FLAGS_APPLE = 0x9115
        /// </summary>
        SyncFlagsApple = 0x9115,

        /// <summary>
        /// Original was GL_SYNC_FENCE_APPLE = 0x9116
        /// </summary>
        SyncFenceApple = 0x9116,

        /// <summary>
        /// Original was GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117
        /// </summary>
        SyncGpuCommandsComplete = 0x9117,

        /// <summary>
        /// Original was GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE = 0x9117
        /// </summary>
        SyncGpuCommandsCompleteApple = 0x9117,

        /// <summary>
        /// Original was GL_UNSIGNALED_APPLE = 0x9118
        /// </summary>
        UnsignaledApple = 0x9118,

        /// <summary>
        /// Original was GL_SIGNALED_APPLE = 0x9119
        /// </summary>
        SignaledApple = 0x9119,

        /// <summary>
        /// Original was GL_ALREADY_SIGNALED = 0x911A
        /// </summary>
        AlreadySignaled = 0x911a,

        /// <summary>
        /// Original was GL_ALREADY_SIGNALED_APPLE = 0x911A
        /// </summary>
        AlreadySignaledApple = 0x911a,

        /// <summary>
        /// Original was GL_TIMEOUT_EXPIRED = 0x911B
        /// </summary>
        TimeoutExpired = 0x911b,

        /// <summary>
        /// Original was GL_TIMEOUT_EXPIRED_APPLE = 0x911B
        /// </summary>
        TimeoutExpiredApple = 0x911b,

        /// <summary>
        /// Original was GL_CONDITION_SATISFIED = 0x911C
        /// </summary>
        ConditionSatisfied = 0x911c,

        /// <summary>
        /// Original was GL_CONDITION_SATISFIED_APPLE = 0x911C
        /// </summary>
        ConditionSatisfiedApple = 0x911c,

        /// <summary>
        /// Original was GL_WAIT_FAILED = 0x911D
        /// </summary>
        WaitFailed = 0x911d,

        /// <summary>
        /// Original was GL_WAIT_FAILED_APPLE = 0x911D
        /// </summary>
        WaitFailedApple = 0x911d,

        /// <summary>
        /// Original was GL_BUFFER_ACCESS_FLAGS = 0x911F
        /// </summary>
        BufferAccessFlags = 0x911f,

        /// <summary>
        /// Original was GL_BUFFER_MAP_LENGTH = 0x9120
        /// </summary>
        BufferMapLength = 0x9120,

        /// <summary>
        /// Original was GL_BUFFER_MAP_OFFSET = 0x9121
        /// </summary>
        BufferMapOffset = 0x9121,

        /// <summary>
        /// Original was GL_TEXTURE_IMMUTABLE_FORMAT_EXT = 0x912F
        /// </summary>
        TextureImmutableFormatExt = 0x912f,

        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_IMG = 0x9133
        /// </summary>
        RenderbufferSamplesImg = 0x9133,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG = 0x9134
        /// </summary>
        FramebufferIncompleteMultisampleImg = 0x9134,

        /// <summary>
        /// Original was GL_MAX_SAMPLES_IMG = 0x9135
        /// </summary>
        MaxSamplesImg = 0x9135,

        /// <summary>
        /// Original was GL_TEXTURE_SAMPLES_IMG = 0x9136
        /// </summary>
        TextureSamplesImg = 0x9136,

        /// <summary>
        /// Original was GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143
        /// </summary>
        MaxDebugMessageLength = 0x9143,

        /// <summary>
        /// Original was GL_MAX_DEBUG_MESSAGE_LENGTH_KHR = 0x9143
        /// </summary>
        MaxDebugMessageLengthKhr = 0x9143,

        /// <summary>
        /// Original was GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144
        /// </summary>
        MaxDebugLoggedMessages = 0x9144,

        /// <summary>
        /// Original was GL_MAX_DEBUG_LOGGED_MESSAGES_KHR = 0x9144
        /// </summary>
        MaxDebugLoggedMessagesKhr = 0x9144,

        /// <summary>
        /// Original was GL_DEBUG_LOGGED_MESSAGES = 0x9145
        /// </summary>
        DebugLoggedMessages = 0x9145,

        /// <summary>
        /// Original was GL_DEBUG_LOGGED_MESSAGES_KHR = 0x9145
        /// </summary>
        DebugLoggedMessagesKhr = 0x9145,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_HIGH = 0x9146
        /// </summary>
        DebugSeverityHigh = 0x9146,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_HIGH_KHR = 0x9146
        /// </summary>
        DebugSeverityHighKhr = 0x9146,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_MEDIUM = 0x9147
        /// </summary>
        DebugSeverityMedium = 0x9147,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_MEDIUM_KHR = 0x9147
        /// </summary>
        DebugSeverityMediumKhr = 0x9147,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_LOW = 0x9148
        /// </summary>
        DebugSeverityLow = 0x9148,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_LOW_KHR = 0x9148
        /// </summary>
        DebugSeverityLowKhr = 0x9148,

        /// <summary>
        /// Original was GL_QUERY_BUFFER = 0x9192
        /// </summary>
        QueryBuffer = 0x9192,

        /// <summary>
        /// Original was GL_QUERY_RESULT_NO_WAIT = 0x9194
        /// </summary>
        QueryResultNoWait = 0x9194,

        /// <summary>
        /// Original was GL_COMPUTE_SHADER = 0x91B9
        /// </summary>
        ComputeShader = 0x91b9,

        /// <summary>
        /// Original was GL_COMPRESSED_R11_EAC = 0x9270
        /// </summary>
        CompressedR11Eac = 0x9270,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_R11_EAC = 0x9271
        /// </summary>
        CompressedSignedR11Eac = 0x9271,

        /// <summary>
        /// Original was GL_COMPRESSED_RG11_EAC = 0x9272
        /// </summary>
        CompressedRg11Eac = 0x9272,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273
        /// </summary>
        CompressedSignedRg11Eac = 0x9273,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB8_ETC2 = 0x9274
        /// </summary>
        CompressedRgb8Etc2 = 0x9274,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ETC2 = 0x9275
        /// </summary>
        CompressedSrgb8Etc2 = 0x9275,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276
        /// </summary>
        CompressedRgb8PunchthroughAlpha1Etc2 = 0x9276,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277
        /// </summary>
        CompressedSrgb8PunchthroughAlpha1Etc2 = 0x9277,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278
        /// </summary>
        CompressedRgba8Etc2Eac = 0x9278,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279
        /// </summary>
        CompressedSrgb8Alpha8Etc2Eac = 0x9279,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        /// </summary>
        AtomicCounterBuffer = 0x92c0,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1
        /// </summary>
        AtomicCounterBufferBinding = 0x92c1,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4
        /// </summary>
        AtomicCounterBufferDataSize = 0x92c4,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5
        /// </summary>
        AtomicCounterBufferActiveAtomicCounters = 0x92c5,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6
        /// </summary>
        AtomicCounterBufferActiveAtomicCounterIndices = 0x92c6,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7
        /// </summary>
        AtomicCounterBufferReferencedByVertexShader = 0x92c7,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8
        /// </summary>
        AtomicCounterBufferReferencedByTessControlShader = 0x92c8,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9
        /// </summary>
        AtomicCounterBufferReferencedByTessEvaluationShader = 0x92c9,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA
        /// </summary>
        AtomicCounterBufferReferencedByGeometryShader = 0x92ca,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB
        /// </summary>
        AtomicCounterBufferReferencedByFragmentShader = 0x92cb,

        /// <summary>
        /// Original was GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9
        /// </summary>
        ActiveAtomicCounterBuffers = 0x92d9,

        /// <summary>
        /// Original was GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA
        /// </summary>
        UniformAtomicCounterBufferIndex = 0x92da,

        /// <summary>
        /// Original was GL_DEBUG_OUTPUT = 0x92E0
        /// </summary>
        DebugOutput = 0x92e0,

        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_KHR = 0x92E0
        /// </summary>
        DebugOutputKhr = 0x92e0,

        /// <summary>
        /// Original was GL_UNIFORM = 0x92E1
        /// </summary>
        Uniform = 0x92e1,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK = 0x92E2
        /// </summary>
        UniformBlock = 0x92e2,

        /// <summary>
        /// Original was GL_PROGRAM_INPUT = 0x92E3
        /// </summary>
        ProgramInput = 0x92e3,

        /// <summary>
        /// Original was GL_PROGRAM_OUTPUT = 0x92E4
        /// </summary>
        ProgramOutput = 0x92e4,

        /// <summary>
        /// Original was GL_BUFFER_VARIABLE = 0x92E5
        /// </summary>
        BufferVariable = 0x92e5,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BLOCK = 0x92E6
        /// </summary>
        ShaderStorageBlock = 0x92e6,

        /// <summary>
        /// Original was GL_VERTEX_SUBROUTINE = 0x92E8
        /// </summary>
        VertexSubroutine = 0x92e8,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SUBROUTINE = 0x92E9
        /// </summary>
        TessControlSubroutine = 0x92e9,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SUBROUTINE = 0x92EA
        /// </summary>
        TessEvaluationSubroutine = 0x92ea,

        /// <summary>
        /// Original was GL_GEOMETRY_SUBROUTINE = 0x92EB
        /// </summary>
        GeometrySubroutine = 0x92eb,

        /// <summary>
        /// Original was GL_FRAGMENT_SUBROUTINE = 0x92EC
        /// </summary>
        FragmentSubroutine = 0x92ec,

        /// <summary>
        /// Original was GL_COMPUTE_SUBROUTINE = 0x92ED
        /// </summary>
        ComputeSubroutine = 0x92ed,

        /// <summary>
        /// Original was GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE
        /// </summary>
        VertexSubroutineUniform = 0x92ee,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF
        /// </summary>
        TessControlSubroutineUniform = 0x92ef,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0
        /// </summary>
        TessEvaluationSubroutineUniform = 0x92f0,

        /// <summary>
        /// Original was GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1
        /// </summary>
        GeometrySubroutineUniform = 0x92f1,

        /// <summary>
        /// Original was GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2
        /// </summary>
        FragmentSubroutineUniform = 0x92f2,

        /// <summary>
        /// Original was GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3
        /// </summary>
        ComputeSubroutineUniform = 0x92f3,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4
        /// </summary>
        TransformFeedbackVarying = 0x92f4,

        /// <summary>
        /// Original was GL_ACTIVE_RESOURCES = 0x92F5
        /// </summary>
        ActiveResources = 0x92f5,

        /// <summary>
        /// Original was GL_MAX_NAME_LENGTH = 0x92F6
        /// </summary>
        MaxNameLength = 0x92f6,

        /// <summary>
        /// Original was GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7
        /// </summary>
        MaxNumActiveVariables = 0x92f7,

        /// <summary>
        /// Original was GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8
        /// </summary>
        MaxNumCompatibleSubroutines = 0x92f8,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310
        /// </summary>
        FramebufferDefaultWidth = 0x9310,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311
        /// </summary>
        FramebufferDefaultHeight = 0x9311,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312
        /// </summary>
        FramebufferDefaultLayers = 0x9312,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313
        /// </summary>
        FramebufferDefaultSamples = 0x9313,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314
        /// </summary>
        FramebufferDefaultFixedSampleLocations = 0x9314,

        /// <summary>
        /// Original was GL_NEGATIVE_ONE_TO_ONE = 0x935E
        /// </summary>
        NegativeOneToOne = 0x935e,

        /// <summary>
        /// Original was GL_ZERO_TO_ONE = 0x935F
        /// </summary>
        ZeroToOne = 0x935f,

        /// <summary>
        /// Original was GL_CLEAR_TEXTURE = 0x9365
        /// </summary>
        ClearTexture = 0x9365,

        /// <summary>
        /// Original was GL_NUM_SAMPLE_COUNTS = 0x9380
        /// </summary>
        NumSampleCounts = 0x9380,

        /// <summary>
        /// Original was GL_BGRA8_EXT = 0x93A1
        /// </summary>
        Bgra8Ext = 0x93a1,

        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT = 0x9530
        /// </summary>
        LayoutDepthReadOnlyStencilAttachmentExt = 0x9530,

        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT = 0x9531
        /// </summary>
        LayoutDepthAttachmentStencilReadOnlyExt = 0x9531,

        /// <summary>
        /// Original was GL_TEXTURE_TILING_EXT = 0x9580
        /// </summary>
        TextureTilingExt = 0x9580,

        /// <summary>
        /// Original was GL_DEDICATED_MEMORY_OBJECT_EXT = 0x9581
        /// </summary>
        DedicatedMemoryObjectExt = 0x9581,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_OPAQUE_FD_EXT = 0x9586
        /// </summary>
        HandleTypeOpaqueFdExt = 0x9586,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_OPAQUE_WIN32_EXT = 0x9587
        /// </summary>
        HandleTypeOpaqueWin32Ext = 0x9587,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT = 0x9588
        /// </summary>
        HandleTypeOpaqueWin32KmtExt = 0x9588,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT = 0x9589
        /// </summary>
        HandleTypeD3D12TilepoolExt = 0x9589,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D12_RESOURCE_EXT = 0x958A
        /// </summary>
        HandleTypeD3D12ResourceExt = 0x958a,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D11_IMAGE_EXT = 0x958B
        /// </summary>
        HandleTypeD3D11ImageExt = 0x958b,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT = 0x958C
        /// </summary>
        HandleTypeD3D11ImageKmtExt = 0x958c,

        /// <summary>
        /// Original was GL_LAYOUT_GENERAL_EXT = 0x958D
        /// </summary>
        LayoutGeneralExt = 0x958d,

        /// <summary>
        /// Original was GL_LAYOUT_COLOR_ATTACHMENT_EXT = 0x958E
        /// </summary>
        LayoutColorAttachmentExt = 0x958e,

        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT = 0x958F
        /// </summary>
        LayoutDepthStencilAttachmentExt = 0x958f,

        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT = 0x9590
        /// </summary>
        LayoutDepthStencilReadOnlyExt = 0x9590,

        /// <summary>
        /// Original was GL_LAYOUT_SHADER_READ_ONLY_EXT = 0x9591
        /// </summary>
        LayoutShaderReadOnlyExt = 0x9591,

        /// <summary>
        /// Original was GL_LAYOUT_TRANSFER_SRC_EXT = 0x9592
        /// </summary>
        LayoutTransferSrcExt = 0x9592,

        /// <summary>
        /// Original was GL_LAYOUT_TRANSFER_DST_EXT = 0x9593
        /// </summary>
        LayoutTransferDstExt = 0x9593,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D12_FENCE_EXT = 0x9594
        /// </summary>
        HandleTypeD3D12FenceExt = 0x9594,

        /// <summary>
        /// Original was GL_D3D12_FENCE_VALUE_EXT = 0x9595
        /// </summary>
        D3D12FenceValueExt = 0x9595,

        /// <summary>
        /// Original was GL_DEVICE_UUID_EXT = 0x9597
        /// </summary>
        DeviceUuidExt = 0x9597,

        /// <summary>
        /// Original was GL_DRIVER_UUID_EXT = 0x9598
        /// </summary>
        DriverUuidExt = 0x9598,

        /// <summary>
        /// Original was GL_DEVICE_LUID_EXT = 0x9599
        /// </summary>
        DeviceLuidExt = 0x9599,

        /// <summary>
        /// Original was GL_DEVICE_NODE_MASK_EXT = 0x959A
        /// </summary>
        DeviceNodeMaskExt = 0x959a,

        /// <summary>
        /// Original was GL_PROTECTED_MEMORY_OBJECT_EXT = 0x959B
        /// </summary>
        ProtectedMemoryObjectExt = 0x959b,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM = 0x96A2
        /// </summary>
        FramebufferFetchNoncoherentQcom = 0x96a2,

        /// <summary>
        /// Original was GL_ALL_ATTRIB_BITS = 0xFFFFFFFF
        /// </summary>
        AllAttribBits = unchecked((int)0xffffffff),

        /// <summary>
        /// Original was GL_ALL_BARRIER_BITS = 0xFFFFFFFF
        /// </summary>
        AllBarrierBits = unchecked((int)0xffffffff),

        /// <summary>
        /// Original was GL_ALL_BARRIER_BITS_EXT = 0xFFFFFFFF
        /// </summary>
        AllBarrierBitsExt = unchecked((int)0xffffffff),

        /// <summary>
        /// Original was GL_ALL_SHADER_BITS = 0xFFFFFFFF
        /// </summary>
        AllShaderBits = unchecked((int)0xffffffff),

        /// <summary>
        /// Original was GL_ALL_SHADER_BITS_EXT = 0xFFFFFFFF
        /// </summary>
        AllShaderBitsExt = unchecked((int)0xffffffff),

        /// <summary>
        /// Original was GL_CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF
        /// </summary>
        ClientAllAttribBits = unchecked((int)0xffffffff),

        /// <summary>
        /// Original was GL_QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF
        /// </summary>
        QueryAllEventBitsAmd = unchecked((int)0xffffffff),

        /// <summary>
        /// Original was GL_TIMEOUT_IGNORED_APPLE = 0xFFFFFFFFFFFFFFFF
        /// </summary>
        TimeoutIgnoredApple = unchecked((int)0xffffffffffffffff),

        /// <summary>
        /// Original was GL_AMD_compressed_3DC_texture = 1
        /// </summary>
        AmdCompressed3DcTexture = 1,

        /// <summary>
        /// Original was GL_AMD_compressed_ATC_texture = 1
        /// </summary>
        AmdCompressedAtcTexture = 1,

        /// <summary>
        /// Original was GL_EXT_texture_filter_anisotropic = 1
        /// </summary>
        ExtTextureFilterAnisotropic = 1,

        /// <summary>
        /// Original was GL_EXT_texture_format_BGRA8888 = 1
        /// </summary>
        ExtTextureFormatBgra8888 = 1,

        /// <summary>
        /// Original was GL_IMG_read_format = 1
        /// </summary>
        ImgReadFormat = 1,

        /// <summary>
        /// Original was GL_IMG_texture_compression_pvrtc = 1
        /// </summary>
        ImgTextureCompressionPvrtc = 1,

        /// <summary>
        /// Original was GL_IMG_texture_env_enhanced_fixed_function = 1
        /// </summary>
        ImgTextureEnvEnhancedFixedFunction = 1,

        /// <summary>
        /// Original was GL_IMG_user_clip_plane = 1
        /// </summary>
        ImgUserClipPlane = 1,

        /// <summary>
        /// Original was GL_LAYOUT_LINEAR_INTEL = 1
        /// </summary>
        LayoutLinearIntel = 1,

        /// <summary>
        /// Original was GL_NV_fence = 1
        /// </summary>
        NvFence = 1,

        /// <summary>
        /// Original was GL_OES_blend_equation_separate = 1
        /// </summary>
        OesBlendEquationSeparate = 1,

        /// <summary>
        /// Original was GL_OES_blend_func_separate = 1
        /// </summary>
        OesBlendFuncSeparate = 1,

        /// <summary>
        /// Original was GL_OES_blend_subtract = 1
        /// </summary>
        OesBlendSubtract = 1,

        /// <summary>
        /// Original was GL_OES_byte_coordinates = 1
        /// </summary>
        OesByteCoordinates = 1,

        /// <summary>
        /// Original was GL_OES_compressed_ETC1_RGB8_texture = 1
        /// </summary>
        OesCompressedEtc1Rgb8Texture = 1,

        /// <summary>
        /// Original was GL_OES_compressed_paletted_texture = 1
        /// </summary>
        OesCompressedPalettedTexture = 1,

        /// <summary>
        /// Original was GL_OES_depth24 = 1
        /// </summary>
        OesDepth24 = 1,

        /// <summary>
        /// Original was GL_OES_depth32 = 1
        /// </summary>
        OesDepth32 = 1,

        /// <summary>
        /// Original was GL_OES_draw_texture = 1
        /// </summary>
        OesDrawTexture = 1,

        /// <summary>
        /// Original was GL_OES_EGL_image = 1
        /// </summary>
        OesEglImage = 1,

        /// <summary>
        /// Original was GL_OES_element_index_uint = 1
        /// </summary>
        OesElementIndexUint = 1,

        /// <summary>
        /// Original was GL_OES_extended_matrix_palette = 1
        /// </summary>
        OesExtendedMatrixPalette = 1,

        /// <summary>
        /// Original was GL_OES_fbo_render_mipmap = 1
        /// </summary>
        OesFboRenderMipmap = 1,

        /// <summary>
        /// Original was GL_OES_fixed_point = 1
        /// </summary>
        OesFixedPoint = 1,

        /// <summary>
        /// Original was GL_OES_framebuffer_object = 1
        /// </summary>
        OesFramebufferObject = 1,

        /// <summary>
        /// Original was GL_OES_mapbuffer = 1
        /// </summary>
        OesMapbuffer = 1,

        /// <summary>
        /// Original was GL_OES_matrix_get = 1
        /// </summary>
        OesMatrixGet = 1,

        /// <summary>
        /// Original was GL_OES_matrix_palette = 1
        /// </summary>
        OesMatrixPalette = 1,

        /// <summary>
        /// Original was GL_OES_packed_depth_stencil = 1
        /// </summary>
        OesPackedDepthStencil = 1,

        /// <summary>
        /// Original was GL_OES_point_size_array = 1
        /// </summary>
        OesPointSizeArray = 1,

        /// <summary>
        /// Original was GL_OES_point_sprite = 1
        /// </summary>
        OesPointSprite = 1,

        /// <summary>
        /// Original was GL_OES_query_matrix = 1
        /// </summary>
        OesQueryMatrix = 1,

        /// <summary>
        /// Original was GL_OES_read_format = 1
        /// </summary>
        OesReadFormat = 1,

        /// <summary>
        /// Original was GL_OES_rgb8_rgba8 = 1
        /// </summary>
        OesRgb8Rgba8 = 1,

        /// <summary>
        /// Original was GL_OES_single_precision = 1
        /// </summary>
        OesSinglePrecision = 1,

        /// <summary>
        /// Original was GL_OES_stencil1 = 1
        /// </summary>
        OesStencil1 = 1,

        /// <summary>
        /// Original was GL_OES_stencil4 = 1
        /// </summary>
        OesStencil4 = 1,

        /// <summary>
        /// Original was GL_OES_stencil8 = 1
        /// </summary>
        OesStencil8 = 1,

        /// <summary>
        /// Original was GL_OES_stencil_wrap = 1
        /// </summary>
        OesStencilWrap = 1,

        /// <summary>
        /// Original was GL_OES_texture_cube_map = 1
        /// </summary>
        OesTextureCubeMap = 1,

        /// <summary>
        /// Original was GL_OES_texture_env_crossbar = 1
        /// </summary>
        OesTextureEnvCrossbar = 1,

        /// <summary>
        /// Original was GL_OES_texture_mirrored_repeat = 1
        /// </summary>
        OesTextureMirroredRepeat = 1,

        /// <summary>
        /// Original was GL_ONE = 1
        /// </summary>
        One = 1,

        /// <summary>
        /// Original was GL_QCOM_driver_control = 1
        /// </summary>
        QcomDriverControl = 1,

        /// <summary>
        /// Original was GL_QCOM_perfmon_global_mode = 1
        /// </summary>
        QcomPerfmonGlobalMode = 1,

        /// <summary>
        /// Original was GL_TRUE = 1
        /// </summary>
        True = 1,

        /// <summary>
        /// Original was GL_VERSION_ES_CL_1_0 = 1
        /// </summary>
        VersionEsCl10 = 1,

        /// <summary>
        /// Original was GL_VERSION_ES_CL_1_1 = 1
        /// </summary>
        VersionEsCl11 = 1,

        /// <summary>
        /// Original was GL_VERSION_ES_CM_1_0 = 1
        /// </summary>
        VersionEsCm10 = 1,

        /// <summary>
        /// Original was GL_VERSION_ES_CM_1_1 = 1
        /// </summary>
        VersionEsCm11 = 1,

        /// <summary>
        /// Original was GL_LAYOUT_LINEAR_CPU_CACHED_INTEL = 2
        /// </summary>
        LayoutLinearCpuCachedIntel = 2,
    }

    /// <summary>
    /// Used in GL.AlphaFunc, GL.AlphaFuncx and 1 other function
    /// </summary>
    public enum AlphaFunction
    {
        /// <summary>
        /// Original was GL_NEVER = 0x0200
        /// </summary>
        Never = 0x0200,

        /// <summary>
        /// Original was GL_LESS = 0x0201
        /// </summary>
        Less = 0x0201,

        /// <summary>
        /// Original was GL_EQUAL = 0x0202
        /// </summary>
        Equal = 0x0202,

        /// <summary>
        /// Original was GL_LEQUAL = 0x0203
        /// </summary>
        Lequal = 0x0203,

        /// <summary>
        /// Original was GL_GREATER = 0x0204
        /// </summary>
        Greater = 0x0204,

        /// <summary>
        /// Original was GL_NOTEQUAL = 0x0205
        /// </summary>
        Notequal = 0x0205,

        /// <summary>
        /// Original was GL_GEQUAL = 0x0206
        /// </summary>
        Gequal = 0x0206,

        /// <summary>
        /// Original was GL_ALWAYS = 0x0207
        /// </summary>
        Always = 0x0207,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum Amdcompressed3Dctexture
    {
        /// <summary>
        /// Original was GL_3DC_X_AMD = 0x87F9
        /// </summary>
        Gl3DcXAmd = 0x87f9,

        /// <summary>
        /// Original was GL_3DC_XY_AMD = 0x87FA
        /// </summary>
        Gl3DcXyAmd = 0x87fa,

        /// <summary>
        /// Original was GL_AMD_compressed_3DC_texture = 1
        /// </summary>
        AmdCompressed3DcTexture = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdCompressed3DcTexture
    {
        /// <summary>
        /// Original was GL_3DC_X_AMD = 0x87F9
        /// </summary>
        Gl3DcXAmd = 0x87f9,

        /// <summary>
        /// Original was GL_3DC_XY_AMD = 0x87FA
        /// </summary>
        Gl3DcXyAmd = 0x87fa,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum AmdcompressedAtctexture
    {
        /// <summary>
        /// Original was GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE
        /// </summary>
        AtcRgbaInterpolatedAlphaAmd = 0x87ee,

        /// <summary>
        /// Original was GL_ATC_RGB_AMD = 0x8C92
        /// </summary>
        AtcRgbAmd = 0x8c92,

        /// <summary>
        /// Original was GL_ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93
        /// </summary>
        AtcRgbaExplicitAlphaAmd = 0x8c93,

        /// <summary>
        /// Original was GL_AMD_compressed_ATC_texture = 1
        /// </summary>
        AmdCompressedAtcTexture = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdCompressedAtcTexture
    {
        /// <summary>
        /// Original was GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE
        /// </summary>
        AtcRgbaInterpolatedAlphaAmd = 0x87ee,

        /// <summary>
        /// Original was GL_ATC_RGB_AMD = 0x8C92
        /// </summary>
        AtcRgbAmd = 0x8c92,

        /// <summary>
        /// Original was GL_ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93
        /// </summary>
        AtcRgbaExplicitAlphaAmd = 0x8c93,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleCopyTextureLevels
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleFramebufferMultisample
    {
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_BINDING_APPLE = 0x8CA6
        /// </summary>
        DrawFramebufferBindingApple = 0x8ca6,

        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_APPLE = 0x8CA8
        /// </summary>
        ReadFramebufferApple = 0x8ca8,

        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_APPLE = 0x8CA9
        /// </summary>
        DrawFramebufferApple = 0x8ca9,

        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_BINDING_APPLE = 0x8CAA
        /// </summary>
        ReadFramebufferBindingApple = 0x8caa,

        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_APPLE = 0x8CAB
        /// </summary>
        RenderbufferSamplesApple = 0x8cab,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisampleApple = 0x8d56,

        /// <summary>
        /// Original was GL_MAX_SAMPLES_APPLE = 0x8D57
        /// </summary>
        MaxSamplesApple = 0x8d57,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleSync
    {
        /// <summary>
        /// Original was GL_SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001
        /// </summary>
        SyncFlushCommandsBitApple = ((int)0x00000001),

        /// <summary>
        /// Original was GL_SYNC_OBJECT_APPLE = 0x8A53
        /// </summary>
        SyncObjectApple = 0x8a53,

        /// <summary>
        /// Original was GL_MAX_SERVER_WAIT_TIMEOUT_APPLE = 0x9111
        /// </summary>
        MaxServerWaitTimeoutApple = 0x9111,

        /// <summary>
        /// Original was GL_OBJECT_TYPE_APPLE = 0x9112
        /// </summary>
        ObjectTypeApple = 0x9112,

        /// <summary>
        /// Original was GL_SYNC_CONDITION_APPLE = 0x9113
        /// </summary>
        SyncConditionApple = 0x9113,

        /// <summary>
        /// Original was GL_SYNC_STATUS_APPLE = 0x9114
        /// </summary>
        SyncStatusApple = 0x9114,

        /// <summary>
        /// Original was GL_SYNC_FLAGS_APPLE = 0x9115
        /// </summary>
        SyncFlagsApple = 0x9115,

        /// <summary>
        /// Original was GL_SYNC_FENCE_APPLE = 0x9116
        /// </summary>
        SyncFenceApple = 0x9116,

        /// <summary>
        /// Original was GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE = 0x9117
        /// </summary>
        SyncGpuCommandsCompleteApple = 0x9117,

        /// <summary>
        /// Original was GL_UNSIGNALED_APPLE = 0x9118
        /// </summary>
        UnsignaledApple = 0x9118,

        /// <summary>
        /// Original was GL_SIGNALED_APPLE = 0x9119
        /// </summary>
        SignaledApple = 0x9119,

        /// <summary>
        /// Original was GL_ALREADY_SIGNALED_APPLE = 0x911A
        /// </summary>
        AlreadySignaledApple = 0x911a,

        /// <summary>
        /// Original was GL_TIMEOUT_EXPIRED_APPLE = 0x911B
        /// </summary>
        TimeoutExpiredApple = 0x911b,

        /// <summary>
        /// Original was GL_CONDITION_SATISFIED_APPLE = 0x911C
        /// </summary>
        ConditionSatisfiedApple = 0x911c,

        /// <summary>
        /// Original was GL_WAIT_FAILED_APPLE = 0x911D
        /// </summary>
        WaitFailedApple = 0x911d,

        /// <summary>
        /// Original was GL_TIMEOUT_IGNORED_APPLE = 0xFFFFFFFFFFFFFFFF
        /// </summary>
        TimeoutIgnoredApple = unchecked((int)0xffffffffffffffff),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleTexture2DLimitedNpot
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleTextureFormatBgra8888
    {
        /// <summary>
        /// Original was GL_BGRA_EXT = 0x80E1
        /// </summary>
        BgraExt = 0x80e1,

        /// <summary>
        /// Original was GL_BGRA8_EXT = 0x93A1
        /// </summary>
        Bgra8Ext = 0x93a1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleTextureMaxLevel
    {
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL_APPLE = 0x813D
        /// </summary>
        TextureMaxLevelApple = 0x813d,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArmRgba8
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AtomicCounterBufferPName
    {
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED
        /// </summary>
        AtomicCounterBufferReferencedByComputeShader = 0x90ed,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1
        /// </summary>
        AtomicCounterBufferBinding = 0x92c1,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4
        /// </summary>
        AtomicCounterBufferDataSize = 0x92c4,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5
        /// </summary>
        AtomicCounterBufferActiveAtomicCounters = 0x92c5,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6
        /// </summary>
        AtomicCounterBufferActiveAtomicCounterIndices = 0x92c6,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7
        /// </summary>
        AtomicCounterBufferReferencedByVertexShader = 0x92c7,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8
        /// </summary>
        AtomicCounterBufferReferencedByTessControlShader = 0x92c8,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9
        /// </summary>
        AtomicCounterBufferReferencedByTessEvaluationShader = 0x92c9,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA
        /// </summary>
        AtomicCounterBufferReferencedByGeometryShader = 0x92ca,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB
        /// </summary>
        AtomicCounterBufferReferencedByFragmentShader = 0x92cb,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum AttribMask
    {
        /// <summary>
        /// Original was GL_CURRENT_BIT = 0x00000001
        /// </summary>
        CurrentBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_POINT_BIT = 0x00000002
        /// </summary>
        PointBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_LINE_BIT = 0x00000004
        /// </summary>
        LineBit = ((int)0x00000004),

        /// <summary>
        /// Original was GL_POLYGON_BIT = 0x00000008
        /// </summary>
        PolygonBit = ((int)0x00000008),

        /// <summary>
        /// Original was GL_POLYGON_STIPPLE_BIT = 0x00000010
        /// </summary>
        PolygonStippleBit = ((int)0x00000010),

        /// <summary>
        /// Original was GL_PIXEL_MODE_BIT = 0x00000020
        /// </summary>
        PixelModeBit = ((int)0x00000020),

        /// <summary>
        /// Original was GL_LIGHTING_BIT = 0x00000040
        /// </summary>
        LightingBit = ((int)0x00000040),

        /// <summary>
        /// Original was GL_FOG_BIT = 0x00000080
        /// </summary>
        FogBit = ((int)0x00000080),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT = 0x00000100
        /// </summary>
        DepthBufferBit = ((int)0x00000100),

        /// <summary>
        /// Original was GL_ACCUM_BUFFER_BIT = 0x00000200
        /// </summary>
        AccumBufferBit = ((int)0x00000200),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT = 0x00000400
        /// </summary>
        StencilBufferBit = ((int)0x00000400),

        /// <summary>
        /// Original was GL_VIEWPORT_BIT = 0x00000800
        /// </summary>
        ViewportBit = ((int)0x00000800),

        /// <summary>
        /// Original was GL_TRANSFORM_BIT = 0x00001000
        /// </summary>
        TransformBit = ((int)0x00001000),

        /// <summary>
        /// Original was GL_ENABLE_BIT = 0x00002000
        /// </summary>
        EnableBit = ((int)0x00002000),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT = 0x00004000
        /// </summary>
        ColorBufferBit = ((int)0x00004000),

        /// <summary>
        /// Original was GL_HINT_BIT = 0x00008000
        /// </summary>
        HintBit = ((int)0x00008000),

        /// <summary>
        /// Original was GL_EVAL_BIT = 0x00010000
        /// </summary>
        EvalBit = ((int)0x00010000),

        /// <summary>
        /// Original was GL_LIST_BIT = 0x00020000
        /// </summary>
        ListBit = ((int)0x00020000),

        /// <summary>
        /// Original was GL_TEXTURE_BIT = 0x00040000
        /// </summary>
        TextureBit = ((int)0x00040000),

        /// <summary>
        /// Original was GL_SCISSOR_BIT = 0x00080000
        /// </summary>
        ScissorBit = ((int)0x00080000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BIT = 0x20000000
        /// </summary>
        MultisampleBit = ((int)0x20000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BIT_3DFX = 0x20000000
        /// </summary>
        MultisampleBit3Dfx = ((int)0x20000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BIT_ARB = 0x20000000
        /// </summary>
        MultisampleBitArb = ((int)0x20000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BIT_EXT = 0x20000000
        /// </summary>
        MultisampleBitExt = ((int)0x20000000),

        /// <summary>
        /// Original was GL_ALL_ATTRIB_BITS = 0xFFFFFFFF
        /// </summary>
        AllAttribBits = unchecked((int)0xffffffff),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AttributeType
    {
        /// <summary>
        /// Original was GL_FLOAT_VEC2 = 0x8B50
        /// </summary>
        FloatVec2 = 0x8b50,

        /// <summary>
        /// Original was GL_FLOAT_VEC2_ARB = 0x8B50
        /// </summary>
        FloatVec2Arb = 0x8b50,

        /// <summary>
        /// Original was GL_FLOAT_VEC3 = 0x8B51
        /// </summary>
        FloatVec3 = 0x8b51,

        /// <summary>
        /// Original was GL_FLOAT_VEC3_ARB = 0x8B51
        /// </summary>
        FloatVec3Arb = 0x8b51,

        /// <summary>
        /// Original was GL_FLOAT_VEC4 = 0x8B52
        /// </summary>
        FloatVec4 = 0x8b52,

        /// <summary>
        /// Original was GL_FLOAT_VEC4_ARB = 0x8B52
        /// </summary>
        FloatVec4Arb = 0x8b52,

        /// <summary>
        /// Original was GL_INT_VEC2 = 0x8B53
        /// </summary>
        IntVec2 = 0x8b53,

        /// <summary>
        /// Original was GL_INT_VEC2_ARB = 0x8B53
        /// </summary>
        IntVec2Arb = 0x8b53,

        /// <summary>
        /// Original was GL_INT_VEC3 = 0x8B54
        /// </summary>
        IntVec3 = 0x8b54,

        /// <summary>
        /// Original was GL_INT_VEC3_ARB = 0x8B54
        /// </summary>
        IntVec3Arb = 0x8b54,

        /// <summary>
        /// Original was GL_INT_VEC4 = 0x8B55
        /// </summary>
        IntVec4 = 0x8b55,

        /// <summary>
        /// Original was GL_INT_VEC4_ARB = 0x8B55
        /// </summary>
        IntVec4Arb = 0x8b55,

        /// <summary>
        /// Original was GL_BOOL = 0x8B56
        /// </summary>
        Bool = 0x8b56,

        /// <summary>
        /// Original was GL_BOOL_ARB = 0x8B56
        /// </summary>
        BoolArb = 0x8b56,

        /// <summary>
        /// Original was GL_BOOL_VEC2 = 0x8B57
        /// </summary>
        BoolVec2 = 0x8b57,

        /// <summary>
        /// Original was GL_BOOL_VEC2_ARB = 0x8B57
        /// </summary>
        BoolVec2Arb = 0x8b57,

        /// <summary>
        /// Original was GL_BOOL_VEC3 = 0x8B58
        /// </summary>
        BoolVec3 = 0x8b58,

        /// <summary>
        /// Original was GL_BOOL_VEC3_ARB = 0x8B58
        /// </summary>
        BoolVec3Arb = 0x8b58,

        /// <summary>
        /// Original was GL_BOOL_VEC4 = 0x8B59
        /// </summary>
        BoolVec4 = 0x8b59,

        /// <summary>
        /// Original was GL_BOOL_VEC4_ARB = 0x8B59
        /// </summary>
        BoolVec4Arb = 0x8b59,

        /// <summary>
        /// Original was GL_FLOAT_MAT2 = 0x8B5A
        /// </summary>
        FloatMat2 = 0x8b5a,

        /// <summary>
        /// Original was GL_FLOAT_MAT2_ARB = 0x8B5A
        /// </summary>
        FloatMat2Arb = 0x8b5a,

        /// <summary>
        /// Original was GL_FLOAT_MAT3 = 0x8B5B
        /// </summary>
        FloatMat3 = 0x8b5b,

        /// <summary>
        /// Original was GL_FLOAT_MAT3_ARB = 0x8B5B
        /// </summary>
        FloatMat3Arb = 0x8b5b,

        /// <summary>
        /// Original was GL_FLOAT_MAT4 = 0x8B5C
        /// </summary>
        FloatMat4 = 0x8b5c,

        /// <summary>
        /// Original was GL_FLOAT_MAT4_ARB = 0x8B5C
        /// </summary>
        FloatMat4Arb = 0x8b5c,

        /// <summary>
        /// Original was GL_SAMPLER_1D = 0x8B5D
        /// </summary>
        Sampler1D = 0x8b5d,

        /// <summary>
        /// Original was GL_SAMPLER_1D_ARB = 0x8B5D
        /// </summary>
        Sampler1DArb = 0x8b5d,

        /// <summary>
        /// Original was GL_SAMPLER_2D = 0x8B5E
        /// </summary>
        Sampler2D = 0x8b5e,

        /// <summary>
        /// Original was GL_SAMPLER_2D_ARB = 0x8B5E
        /// </summary>
        Sampler2DArb = 0x8b5e,

        /// <summary>
        /// Original was GL_SAMPLER_3D = 0x8B5F
        /// </summary>
        Sampler3D = 0x8b5f,

        /// <summary>
        /// Original was GL_SAMPLER_3D_ARB = 0x8B5F
        /// </summary>
        Sampler3DArb = 0x8b5f,

        /// <summary>
        /// Original was GL_SAMPLER_3D_OES = 0x8B5F
        /// </summary>
        Sampler3DOes = 0x8b5f,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE = 0x8B60
        /// </summary>
        SamplerCube = 0x8b60,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_ARB = 0x8B60
        /// </summary>
        SamplerCubeArb = 0x8b60,

        /// <summary>
        /// Original was GL_SAMPLER_1D_SHADOW = 0x8B61
        /// </summary>
        Sampler1DShadow = 0x8b61,

        /// <summary>
        /// Original was GL_SAMPLER_1D_SHADOW_ARB = 0x8B61
        /// </summary>
        Sampler1DShadowArb = 0x8b61,

        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW = 0x8B62
        /// </summary>
        Sampler2DShadow = 0x8b62,

        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW_ARB = 0x8B62
        /// </summary>
        Sampler2DShadowArb = 0x8b62,

        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW_EXT = 0x8B62
        /// </summary>
        Sampler2DShadowExt = 0x8b62,

        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT = 0x8B63
        /// </summary>
        Sampler2DRect = 0x8b63,

        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT_ARB = 0x8B63
        /// </summary>
        Sampler2DRectArb = 0x8b63,

        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT_SHADOW = 0x8B64
        /// </summary>
        Sampler2DRectShadow = 0x8b64,

        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64
        /// </summary>
        Sampler2DRectShadowArb = 0x8b64,

        /// <summary>
        /// Original was GL_FLOAT_MAT2x3 = 0x8B65
        /// </summary>
        FloatMat2x3 = 0x8b65,

        /// <summary>
        /// Original was GL_FLOAT_MAT2x3_NV = 0x8B65
        /// </summary>
        FloatMat2x3Nv = 0x8b65,

        /// <summary>
        /// Original was GL_FLOAT_MAT2x4 = 0x8B66
        /// </summary>
        FloatMat2x4 = 0x8b66,

        /// <summary>
        /// Original was GL_FLOAT_MAT2x4_NV = 0x8B66
        /// </summary>
        FloatMat2x4Nv = 0x8b66,

        /// <summary>
        /// Original was GL_FLOAT_MAT3x2 = 0x8B67
        /// </summary>
        FloatMat3x2 = 0x8b67,

        /// <summary>
        /// Original was GL_FLOAT_MAT3x2_NV = 0x8B67
        /// </summary>
        FloatMat3x2Nv = 0x8b67,

        /// <summary>
        /// Original was GL_FLOAT_MAT3x4 = 0x8B68
        /// </summary>
        FloatMat3x4 = 0x8b68,

        /// <summary>
        /// Original was GL_FLOAT_MAT3x4_NV = 0x8B68
        /// </summary>
        FloatMat3x4Nv = 0x8b68,

        /// <summary>
        /// Original was GL_FLOAT_MAT4x2 = 0x8B69
        /// </summary>
        FloatMat4x2 = 0x8b69,

        /// <summary>
        /// Original was GL_FLOAT_MAT4x2_NV = 0x8B69
        /// </summary>
        FloatMat4x2Nv = 0x8b69,

        /// <summary>
        /// Original was GL_FLOAT_MAT4x3 = 0x8B6A
        /// </summary>
        FloatMat4x3 = 0x8b6a,

        /// <summary>
        /// Original was GL_FLOAT_MAT4x3_NV = 0x8B6A
        /// </summary>
        FloatMat4x3Nv = 0x8b6a,
    }

    /// <summary>
    /// Used in GL.DrawArrays, GL.DrawElements
    /// </summary>
    public enum BeginMode
    {
        /// <summary>
        /// Original was GL_Points = 0X0000
        /// </summary>
        Points = 0X0000,

        /// <summary>
        /// Original was GL_Lines = 0X0001
        /// </summary>
        Lines = 0X0001,

        /// <summary>
        /// Original was GL_LineLoop = 0X0002
        /// </summary>
        LineLoop = 0X0002,

        /// <summary>
        /// Original was GL_LineStrip = 0X0003
        /// </summary>
        LineStrip = 0X0003,

        /// <summary>
        /// Original was GL_Triangles = 0X0004
        /// </summary>
        Triangles = 0X0004,

        /// <summary>
        /// Original was GL_TriangleStrip = 0X0005
        /// </summary>
        TriangleStrip = 0X0005,

        /// <summary>
        /// Original was GL_TriangleFan = 0X0006
        /// </summary>
        TriangleFan = 0X0006,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BindTransformFeedbackTarget
    {
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK = 0x8E22
        /// </summary>
        TransformFeedback = 0x8e22,
    }

    /// <summary>
    /// Used in GL.Ext.BlendEquation, GL.Oes.BlendEquation and 1 other function
    /// </summary>
    public enum BlendEquationModeExt
    {
        /// <summary>
        /// Original was GL_LOGIC_OP = 0x0BF1
        /// </summary>
        LogicOp = 0x0bf1,

        /// <summary>
        /// Original was GL_FUNC_ADD = 0x8006
        /// </summary>
        FuncAdd = 0x8006,

        /// <summary>
        /// Original was GL_FUNC_ADD_EXT = 0x8006
        /// </summary>
        FuncAddExt = 0x8006,

        /// <summary>
        /// Original was GL_MIN_EXT = 0x8007
        /// </summary>
        MinExt = 0x8007,

        /// <summary>
        /// Original was GL_MAX_EXT = 0x8008
        /// </summary>
        MaxExt = 0x8008,

        /// <summary>
        /// Original was GL_FUNC_SUBTRACT = 0x800A
        /// </summary>
        FuncSubtract = 0x800a,

        /// <summary>
        /// Original was GL_FUNC_SUBTRACT_EXT = 0x800A
        /// </summary>
        FuncSubtractExt = 0x800a,

        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT = 0x800B
        /// </summary>
        FuncReverseSubtract = 0x800b,

        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT_EXT = 0x800B
        /// </summary>
        FuncReverseSubtractExt = 0x800b,

        /// <summary>
        /// Original was GL_ALPHA_MIN_SGIX = 0x8320
        /// </summary>
        AlphaMinSgix = 0x8320,

        /// <summary>
        /// Original was GL_ALPHA_MAX_SGIX = 0x8321
        /// </summary>
        AlphaMaxSgix = 0x8321,
    }

    /// <summary>
    /// Used in GL.BlendFunc, GL.Oes.BlendFuncSeparate
    /// </summary>
    public enum BlendingFactor
    {
        /// <summary>
        /// Original was GL_ZERO = 0
        /// </summary>
        Zero = 0,

        /// <summary>
        /// Original was GL_SRC_COLOR = 0x0300
        /// </summary>
        SrcColor = 0x0300,

        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_COLOR = 0x0301
        /// </summary>
        OneMinusSrcColor = 0x0301,

        /// <summary>
        /// Original was GL_SRC_ALPHA = 0x0302
        /// </summary>
        SrcAlpha = 0x0302,

        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_ALPHA = 0x0303
        /// </summary>
        OneMinusSrcAlpha = 0x0303,

        /// <summary>
        /// Original was GL_DST_ALPHA = 0x0304
        /// </summary>
        DstAlpha = 0x0304,

        /// <summary>
        /// Original was GL_ONE_MINUS_DST_ALPHA = 0x0305
        /// </summary>
        OneMinusDstAlpha = 0x0305,

        /// <summary>
        /// Original was GL_DST_COLOR = 0x0306
        /// </summary>
        DstColor = 0x0306,

        /// <summary>
        /// Original was GL_ONE_MINUS_DST_COLOR = 0x0307
        /// </summary>
        OneMinusDstColor = 0x0307,

        /// <summary>
        /// Original was GL_SRC_ALPHA_SATURATE = 0x0308
        /// </summary>
        SrcAlphaSaturate = 0x0308,

        /// <summary>
        /// Original was GL_CONSTANT_COLOR = 0x8001
        /// </summary>
        ConstantColor = 0x8001,

        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_COLOR = 0x8002
        /// </summary>
        OneMinusConstantColor = 0x8002,

        /// <summary>
        /// Original was GL_CONSTANT_ALPHA = 0x8003
        /// </summary>
        ConstantAlpha = 0x8003,

        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004
        /// </summary>
        OneMinusConstantAlpha = 0x8004,

        /// <summary>
        /// Original was GL_SRC1_ALPHA = 0x8589
        /// </summary>
        Src1Alpha = 0x8589,

        /// <summary>
        /// Original was GL_SRC1_COLOR = 0x88F9
        /// </summary>
        Src1Color = 0x88f9,

        /// <summary>
        /// Original was GL_ONE = 1
        /// </summary>
        One = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BlitFramebufferFilter
    {
        /// <summary>
        /// Original was GL_NEAREST = 0x2600
        /// </summary>
        Nearest = 0x2600,

        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = 0x2601,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Boolean
    {
        /// <summary>
        /// Original was GL_FALSE = 0
        /// </summary>
        False = 0,

        /// <summary>
        /// Original was GL_TRUE = 1
        /// </summary>
        True = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Buffer
    {
        /// <summary>
        /// Original was GL_COLOR = 0x1800
        /// </summary>
        Color = 0x1800,

        /// <summary>
        /// Original was GL_DEPTH = 0x1801
        /// </summary>
        Depth = 0x1801,

        /// <summary>
        /// Original was GL_STENCIL = 0x1802
        /// </summary>
        Stencil = 0x1802,
    }

    /// <summary>
    /// Used in GL.Oes.MapBuffer
    /// </summary>
    public enum BufferAccessArb
    {
        /// <summary>
        /// Original was GL_READ_ONLY = 0x88B8
        /// </summary>
        ReadOnly = 0x88b8,

        /// <summary>
        /// Original was GL_WRITE_ONLY = 0x88B9
        /// </summary>
        WriteOnly = 0x88b9,

        /// <summary>
        /// Original was GL_READ_WRITE = 0x88BA
        /// </summary>
        ReadWrite = 0x88ba,
    }

    /// <summary>
    /// Used in GL.Ext.MapBufferRange
    /// </summary>
    [Flags]
    public enum BufferAccessMask
    {
        /// <summary>
        /// Original was GL_MAP_READ_BIT = 0x0001
        /// </summary>
        MapReadBit = 0x0001,

        /// <summary>
        /// Original was GL_MAP_READ_BIT_EXT = 0x0001
        /// </summary>
        MapReadBitExt = 0x0001,

        /// <summary>
        /// Original was GL_MAP_WRITE_BIT = 0x0002
        /// </summary>
        MapWriteBit = 0x0002,

        /// <summary>
        /// Original was GL_MAP_WRITE_BIT_EXT = 0x0002
        /// </summary>
        MapWriteBitExt = 0x0002,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT = 0x0004
        /// </summary>
        MapInvalidateRangeBit = 0x0004,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004
        /// </summary>
        MapInvalidateRangeBitExt = 0x0004,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008
        /// </summary>
        MapInvalidateBufferBit = 0x0008,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008
        /// </summary>
        MapInvalidateBufferBitExt = 0x0008,

        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010
        /// </summary>
        MapFlushExplicitBit = 0x0010,

        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010
        /// </summary>
        MapFlushExplicitBitExt = 0x0010,

        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT = 0x0020
        /// </summary>
        MapUnsynchronizedBit = 0x0020,

        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020
        /// </summary>
        MapUnsynchronizedBitExt = 0x0020,

        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT = 0x0040
        /// </summary>
        MapPersistentBit = 0x0040,

        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT_EXT = 0x0040
        /// </summary>
        MapPersistentBitExt = 0x0040,

        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT = 0x0080
        /// </summary>
        MapCoherentBit = 0x0080,

        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT_EXT = 0x0080
        /// </summary>
        MapCoherentBitExt = 0x0080,
    }

    /// <summary>
    /// Used in GL.Qcom.EndTiling, GL.Qcom.StartTiling
    /// </summary>
    public enum BufferBitQcom
    {
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT0_QCOM = 0x00000001
        /// </summary>
        ColorBufferBit0Qcom = ((int)0x00000001),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT1_QCOM = 0x00000002
        /// </summary>
        ColorBufferBit1Qcom = ((int)0x00000002),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT2_QCOM = 0x00000004
        /// </summary>
        ColorBufferBit2Qcom = ((int)0x00000004),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT3_QCOM = 0x00000008
        /// </summary>
        ColorBufferBit3Qcom = ((int)0x00000008),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT4_QCOM = 0x00000010
        /// </summary>
        ColorBufferBit4Qcom = ((int)0x00000010),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT5_QCOM = 0x00000020
        /// </summary>
        ColorBufferBit5Qcom = ((int)0x00000020),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT6_QCOM = 0x00000040
        /// </summary>
        ColorBufferBit6Qcom = ((int)0x00000040),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT7_QCOM = 0x00000080
        /// </summary>
        ColorBufferBit7Qcom = ((int)0x00000080),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT0_QCOM = 0x00000100
        /// </summary>
        DepthBufferBit0Qcom = ((int)0x00000100),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT1_QCOM = 0x00000200
        /// </summary>
        DepthBufferBit1Qcom = ((int)0x00000200),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT2_QCOM = 0x00000400
        /// </summary>
        DepthBufferBit2Qcom = ((int)0x00000400),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT3_QCOM = 0x00000800
        /// </summary>
        DepthBufferBit3Qcom = ((int)0x00000800),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT4_QCOM = 0x00001000
        /// </summary>
        DepthBufferBit4Qcom = ((int)0x00001000),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT5_QCOM = 0x00002000
        /// </summary>
        DepthBufferBit5Qcom = ((int)0x00002000),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT6_QCOM = 0x00004000
        /// </summary>
        DepthBufferBit6Qcom = ((int)0x00004000),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT7_QCOM = 0x00008000
        /// </summary>
        DepthBufferBit7Qcom = ((int)0x00008000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT0_QCOM = 0x00010000
        /// </summary>
        StencilBufferBit0Qcom = ((int)0x00010000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT1_QCOM = 0x00020000
        /// </summary>
        StencilBufferBit1Qcom = ((int)0x00020000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT2_QCOM = 0x00040000
        /// </summary>
        StencilBufferBit2Qcom = ((int)0x00040000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT3_QCOM = 0x00080000
        /// </summary>
        StencilBufferBit3Qcom = ((int)0x00080000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT4_QCOM = 0x00100000
        /// </summary>
        StencilBufferBit4Qcom = ((int)0x00100000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT5_QCOM = 0x00200000
        /// </summary>
        StencilBufferBit5Qcom = ((int)0x00200000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT6_QCOM = 0x00400000
        /// </summary>
        StencilBufferBit6Qcom = ((int)0x00400000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT7_QCOM = 0x00800000
        /// </summary>
        StencilBufferBit7Qcom = ((int)0x00800000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT0_QCOM = 0x01000000
        /// </summary>
        MultisampleBufferBit0Qcom = ((int)0x01000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT1_QCOM = 0x02000000
        /// </summary>
        MultisampleBufferBit1Qcom = ((int)0x02000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT2_QCOM = 0x04000000
        /// </summary>
        MultisampleBufferBit2Qcom = ((int)0x04000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT3_QCOM = 0x08000000
        /// </summary>
        MultisampleBufferBit3Qcom = ((int)0x08000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT4_QCOM = 0x10000000
        /// </summary>
        MultisampleBufferBit4Qcom = ((int)0x10000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT5_QCOM = 0x20000000
        /// </summary>
        MultisampleBufferBit5Qcom = ((int)0x20000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT6_QCOM = 0x40000000
        /// </summary>
        MultisampleBufferBit6Qcom = ((int)0x40000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT7_QCOM = 0x80000000
        /// </summary>
        MultisampleBufferBit7Qcom = unchecked((int)0x80000000),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BufferObjects
    {
        /// <summary>
        /// Original was GL_BUFFER_SIZE = 0x8764
        /// </summary>
        BufferSize = 0x8764,

        /// <summary>
        /// Original was GL_BUFFER_USAGE = 0x8765
        /// </summary>
        BufferUsage = 0x8765,

        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = 0x8892,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = 0x8893,

        /// <summary>
        /// Original was GL_ARRAY_BUFFER_BINDING = 0x8894
        /// </summary>
        ArrayBufferBinding = 0x8894,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895
        /// </summary>
        ElementArrayBufferBinding = 0x8895,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896
        /// </summary>
        VertexArrayBufferBinding = 0x8896,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897
        /// </summary>
        NormalArrayBufferBinding = 0x8897,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898
        /// </summary>
        ColorArrayBufferBinding = 0x8898,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A
        /// </summary>
        TextureCoordArrayBufferBinding = 0x889a,

        /// <summary>
        /// Original was GL_STATIC_DRAW = 0x88E4
        /// </summary>
        StaticDraw = 0x88e4,

        /// <summary>
        /// Original was GL_DYNAMIC_DRAW = 0x88E8
        /// </summary>
        DynamicDraw = 0x88e8,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BufferStorageTarget
    {
        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = 0x8892,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = 0x8893,

        /// <summary>
        /// Original was GL_PIXEL_PACK_BUFFER = 0x88EB
        /// </summary>
        PixelPackBuffer = 0x88eb,

        /// <summary>
        /// Original was GL_PIXEL_UNPACK_BUFFER = 0x88EC
        /// </summary>
        PixelUnpackBuffer = 0x88ec,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER = 0x8A11
        /// </summary>
        UniformBuffer = 0x8a11,

        /// <summary>
        /// Original was GL_TEXTURE_BUFFER = 0x8C2A
        /// </summary>
        TextureBuffer = 0x8c2a,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        /// </summary>
        TransformFeedbackBuffer = 0x8c8e,

        /// <summary>
        /// Original was GL_COPY_READ_BUFFER = 0x8F36
        /// </summary>
        CopyReadBuffer = 0x8f36,

        /// <summary>
        /// Original was GL_COPY_WRITE_BUFFER = 0x8F37
        /// </summary>
        CopyWriteBuffer = 0x8f37,

        /// <summary>
        /// Original was GL_DRAW_INDIRECT_BUFFER = 0x8F3F
        /// </summary>
        DrawIndirectBuffer = 0x8f3f,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER = 0x90D2
        /// </summary>
        ShaderStorageBuffer = 0x90d2,

        /// <summary>
        /// Original was GL_DISPATCH_INDIRECT_BUFFER = 0x90EE
        /// </summary>
        DispatchIndirectBuffer = 0x90ee,

        /// <summary>
        /// Original was GL_QUERY_BUFFER = 0x9192
        /// </summary>
        QueryBuffer = 0x9192,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        /// </summary>
        AtomicCounterBuffer = 0x92c0,
    }

    /// <summary>
    /// Used in GL.BindBuffer, GL.BufferData and 6 other functions
    /// </summary>
    public enum BufferTargetArb
    {
        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = 0x8892,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = 0x8893,

        /// <summary>
        /// Original was GL_PIXEL_PACK_BUFFER = 0x88EB
        /// </summary>
        PixelPackBuffer = 0x88eb,

        /// <summary>
        /// Original was GL_PIXEL_UNPACK_BUFFER = 0x88EC
        /// </summary>
        PixelUnpackBuffer = 0x88ec,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER = 0x8A11
        /// </summary>
        UniformBuffer = 0x8a11,

        /// <summary>
        /// Original was GL_TEXTURE_BUFFER = 0x8C2A
        /// </summary>
        TextureBuffer = 0x8c2a,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        /// </summary>
        TransformFeedbackBuffer = 0x8c8e,

        /// <summary>
        /// Original was GL_COPY_READ_BUFFER = 0x8F36
        /// </summary>
        CopyReadBuffer = 0x8f36,

        /// <summary>
        /// Original was GL_COPY_WRITE_BUFFER = 0x8F37
        /// </summary>
        CopyWriteBuffer = 0x8f37,

        /// <summary>
        /// Original was GL_DRAW_INDIRECT_BUFFER = 0x8F3F
        /// </summary>
        DrawIndirectBuffer = 0x8f3f,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER = 0x90D2
        /// </summary>
        ShaderStorageBuffer = 0x90d2,

        /// <summary>
        /// Original was GL_DISPATCH_INDIRECT_BUFFER = 0x90EE
        /// </summary>
        DispatchIndirectBuffer = 0x90ee,

        /// <summary>
        /// Original was GL_QUERY_BUFFER = 0x9192
        /// </summary>
        QueryBuffer = 0x9192,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        /// </summary>
        AtomicCounterBuffer = 0x92c0,
    }

    /// <summary>
    /// Used in GL.BufferData
    /// </summary>
    public enum BufferUsageArb
    {
        /// <summary>
        /// Original was GL_STREAM_DRAW = 0x88E0
        /// </summary>
        StreamDraw = 0x88e0,

        /// <summary>
        /// Original was GL_STREAM_READ = 0x88E1
        /// </summary>
        StreamRead = 0x88e1,

        /// <summary>
        /// Original was GL_STREAM_COPY = 0x88E2
        /// </summary>
        StreamCopy = 0x88e2,

        /// <summary>
        /// Original was GL_STATIC_DRAW = 0x88E4
        /// </summary>
        StaticDraw = 0x88e4,

        /// <summary>
        /// Original was GL_STATIC_READ = 0x88E5
        /// </summary>
        StaticRead = 0x88e5,

        /// <summary>
        /// Original was GL_STATIC_COPY = 0x88E6
        /// </summary>
        StaticCopy = 0x88e6,

        /// <summary>
        /// Original was GL_DYNAMIC_DRAW = 0x88E8
        /// </summary>
        DynamicDraw = 0x88e8,

        /// <summary>
        /// Original was GL_DYNAMIC_READ = 0x88E9
        /// </summary>
        DynamicRead = 0x88e9,

        /// <summary>
        /// Original was GL_DYNAMIC_COPY = 0x88EA
        /// </summary>
        DynamicCopy = 0x88ea,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum CheckFramebufferStatusTarget
    {
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER = 0x8CA8
        /// </summary>
        ReadFramebuffer = 0x8ca8,

        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER = 0x8CA9
        /// </summary>
        DrawFramebuffer = 0x8ca9,

        /// <summary>
        /// Original was GL_FRAMEBUFFER = 0x8D40
        /// </summary>
        Framebuffer = 0x8d40,
    }

    /// <summary>
    /// Used in GL.Clear
    /// </summary>
    [Flags]
    public enum ClearBufferMask
    {
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT = 0x00000100
        /// </summary>
        DepthBufferBit = ((int)0x00000100),

        /// <summary>
        /// Original was GL_ACCUM_BUFFER_BIT = 0x00000200
        /// </summary>
        AccumBufferBit = ((int)0x00000200),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT = 0x00000400
        /// </summary>
        StencilBufferBit = ((int)0x00000400),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT = 0x00004000
        /// </summary>
        ColorBufferBit = ((int)0x00004000),

        /// <summary>
        /// Original was GL_COVERAGE_BUFFER_BIT_NV = 0x00008000
        /// </summary>
        CoverageBufferBitNv = ((int)0x00008000),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum ClientAttribMask
    {
        /// <summary>
        /// Original was GL_CLIENT_PIXEL_STORE_BIT = 0x00000001
        /// </summary>
        ClientPixelStoreBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_CLIENT_VERTEX_ARRAY_BIT = 0x00000002
        /// </summary>
        ClientVertexArrayBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF
        /// </summary>
        ClientAllAttribBits = unchecked((int)0xffffffff),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ClipControlDepth
    {
        /// <summary>
        /// Original was GL_NEGATIVE_ONE_TO_ONE = 0x935E
        /// </summary>
        NegativeOneToOne = 0x935e,

        /// <summary>
        /// Original was GL_ZERO_TO_ONE = 0x935F
        /// </summary>
        ZeroToOne = 0x935f,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ClipControlOrigin
    {
        /// <summary>
        /// Original was GL_LOWER_LEFT = 0x8CA1
        /// </summary>
        LowerLeft = 0x8ca1,

        /// <summary>
        /// Original was GL_UPPER_LEFT = 0x8CA2
        /// </summary>
        UpperLeft = 0x8ca2,
    }

    /// <summary>
    /// Used in GL.ClipPlane, GL.ClipPlanex and 8 other functions
    /// </summary>
    public enum ClipPlaneName
    {
        /// <summary>
        /// Original was GL_CLIP_DISTANCE0 = 0x3000
        /// </summary>
        ClipDistance0 = 0x3000,

        /// <summary>
        /// Original was GL_CLIP_PLANE0 = 0x3000
        /// </summary>
        ClipPlane0 = 0x3000,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE1 = 0x3001
        /// </summary>
        ClipDistance1 = 0x3001,

        /// <summary>
        /// Original was GL_CLIP_PLANE1 = 0x3001
        /// </summary>
        ClipPlane1 = 0x3001,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE2 = 0x3002
        /// </summary>
        ClipDistance2 = 0x3002,

        /// <summary>
        /// Original was GL_CLIP_PLANE2 = 0x3002
        /// </summary>
        ClipPlane2 = 0x3002,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE3 = 0x3003
        /// </summary>
        ClipDistance3 = 0x3003,

        /// <summary>
        /// Original was GL_CLIP_PLANE3 = 0x3003
        /// </summary>
        ClipPlane3 = 0x3003,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE4 = 0x3004
        /// </summary>
        ClipDistance4 = 0x3004,

        /// <summary>
        /// Original was GL_CLIP_PLANE4 = 0x3004
        /// </summary>
        ClipPlane4 = 0x3004,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE5 = 0x3005
        /// </summary>
        ClipDistance5 = 0x3005,

        /// <summary>
        /// Original was GL_CLIP_PLANE5 = 0x3005
        /// </summary>
        ClipPlane5 = 0x3005,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE6 = 0x3006
        /// </summary>
        ClipDistance6 = 0x3006,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE7 = 0x3007
        /// </summary>
        ClipDistance7 = 0x3007,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ColorBuffer
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Original was GL_FRONT_LEFT = 0x0400
        /// </summary>
        FrontLeft = 0x0400,

        /// <summary>
        /// Original was GL_FRONT_RIGHT = 0x0401
        /// </summary>
        FrontRight = 0x0401,

        /// <summary>
        /// Original was GL_BACK_LEFT = 0x0402
        /// </summary>
        BackLeft = 0x0402,

        /// <summary>
        /// Original was GL_BACK_RIGHT = 0x0403
        /// </summary>
        BackRight = 0x0403,

        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = 0x0404,

        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = 0x0405,

        /// <summary>
        /// Original was GL_LEFT = 0x0406
        /// </summary>
        Left = 0x0406,

        /// <summary>
        /// Original was GL_RIGHT = 0x0407
        /// </summary>
        Right = 0x0407,

        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = 0x0408,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        /// </summary>
        ColorAttachment0 = 0x8ce0,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        /// </summary>
        ColorAttachment1 = 0x8ce1,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        /// </summary>
        ColorAttachment2 = 0x8ce2,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        /// </summary>
        ColorAttachment3 = 0x8ce3,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        /// </summary>
        ColorAttachment4 = 0x8ce4,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        /// </summary>
        ColorAttachment5 = 0x8ce5,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        /// </summary>
        ColorAttachment6 = 0x8ce6,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        /// </summary>
        ColorAttachment7 = 0x8ce7,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        /// </summary>
        ColorAttachment8 = 0x8ce8,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        /// </summary>
        ColorAttachment9 = 0x8ce9,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        /// </summary>
        ColorAttachment10 = 0x8cea,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        /// </summary>
        ColorAttachment11 = 0x8ceb,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        /// </summary>
        ColorAttachment12 = 0x8cec,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        /// </summary>
        ColorAttachment13 = 0x8ced,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        /// </summary>
        ColorAttachment14 = 0x8cee,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        /// </summary>
        ColorAttachment15 = 0x8cef,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT16 = 0x8CF0
        /// </summary>
        ColorAttachment16 = 0x8cf0,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT17 = 0x8CF1
        /// </summary>
        ColorAttachment17 = 0x8cf1,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT18 = 0x8CF2
        /// </summary>
        ColorAttachment18 = 0x8cf2,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT19 = 0x8CF3
        /// </summary>
        ColorAttachment19 = 0x8cf3,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT20 = 0x8CF4
        /// </summary>
        ColorAttachment20 = 0x8cf4,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT21 = 0x8CF5
        /// </summary>
        ColorAttachment21 = 0x8cf5,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT22 = 0x8CF6
        /// </summary>
        ColorAttachment22 = 0x8cf6,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT23 = 0x8CF7
        /// </summary>
        ColorAttachment23 = 0x8cf7,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT24 = 0x8CF8
        /// </summary>
        ColorAttachment24 = 0x8cf8,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT25 = 0x8CF9
        /// </summary>
        ColorAttachment25 = 0x8cf9,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT26 = 0x8CFA
        /// </summary>
        ColorAttachment26 = 0x8cfa,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT27 = 0x8CFB
        /// </summary>
        ColorAttachment27 = 0x8cfb,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT28 = 0x8CFC
        /// </summary>
        ColorAttachment28 = 0x8cfc,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT29 = 0x8CFD
        /// </summary>
        ColorAttachment29 = 0x8cfd,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT30 = 0x8CFE
        /// </summary>
        ColorAttachment30 = 0x8cfe,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT31 = 0x8CFF
        /// </summary>
        ColorAttachment31 = 0x8cff,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ColorMaterialFace
    {
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = 0x0404,

        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = 0x0405,

        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = 0x0408,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ColorMaterialParameter
    {
        /// <summary>
        /// Original was GL_AMBIENT = 0x1200
        /// </summary>
        Ambient = 0x1200,

        /// <summary>
        /// Original was GL_DIFFUSE = 0x1201
        /// </summary>
        Diffuse = 0x1201,

        /// <summary>
        /// Original was GL_SPECULAR = 0x1202
        /// </summary>
        Specular = 0x1202,

        /// <summary>
        /// Original was GL_EMISSION = 0x1600
        /// </summary>
        Emission = 0x1600,

        /// <summary>
        /// Original was GL_AMBIENT_AND_DIFFUSE = 0x1602
        /// </summary>
        AmbientAndDiffuse = 0x1602,
    }

    /// <summary>
    /// Used in GL.ColorPointer
    /// </summary>
    public enum ColorPointerType
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = 0x1400,

        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = 0x1401,

        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = 0x1402,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = 0x1403,

        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = 0x1404,

        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = 0x1405,

        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = 0x140a,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ColorTableParameterPNameSgi
    {
        /// <summary>
        /// Original was GL_COLOR_TABLE_SCALE = 0x80D6
        /// </summary>
        ColorTableScale = 0x80d6,

        /// <summary>
        /// Original was GL_COLOR_TABLE_SCALE_SGI = 0x80D6
        /// </summary>
        ColorTableScaleSgi = 0x80d6,

        /// <summary>
        /// Original was GL_COLOR_TABLE_BIAS = 0x80D7
        /// </summary>
        ColorTableBias = 0x80d7,

        /// <summary>
        /// Original was GL_COLOR_TABLE_BIAS_SGI = 0x80D7
        /// </summary>
        ColorTableBiasSgi = 0x80d7,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ColorTableTarget
    {
        /// <summary>
        /// Original was GL_COLOR_TABLE = 0x80D0
        /// </summary>
        ColorTable = 0x80d0,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1
        /// </summary>
        PostConvolutionColorTable = 0x80d1,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2
        /// </summary>
        PostColorMatrixColorTable = 0x80d2,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ColorTableTargetSgi
    {
        /// <summary>
        /// Original was GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
        /// </summary>
        TextureColorTableSgi = 0x80bc,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_COLOR_TABLE_SGI = 0x80BD
        /// </summary>
        ProxyTextureColorTableSgi = 0x80bd,

        /// <summary>
        /// Original was GL_COLOR_TABLE = 0x80D0
        /// </summary>
        ColorTable = 0x80d0,

        /// <summary>
        /// Original was GL_COLOR_TABLE_SGI = 0x80D0
        /// </summary>
        ColorTableSgi = 0x80d0,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1
        /// </summary>
        PostConvolutionColorTable = 0x80d1,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
        /// </summary>
        PostConvolutionColorTableSgi = 0x80d1,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2
        /// </summary>
        PostColorMatrixColorTable = 0x80d2,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
        /// </summary>
        PostColorMatrixColorTableSgi = 0x80d2,

        /// <summary>
        /// Original was GL_PROXY_COLOR_TABLE = 0x80D3
        /// </summary>
        ProxyColorTable = 0x80d3,

        /// <summary>
        /// Original was GL_PROXY_COLOR_TABLE_SGI = 0x80D3
        /// </summary>
        ProxyColorTableSgi = 0x80d3,

        /// <summary>
        /// Original was GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4
        /// </summary>
        ProxyPostConvolutionColorTable = 0x80d4,

        /// <summary>
        /// Original was GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D4
        /// </summary>
        ProxyPostConvolutionColorTableSgi = 0x80d4,

        /// <summary>
        /// Original was GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5
        /// </summary>
        ProxyPostColorMatrixColorTable = 0x80d5,

        /// <summary>
        /// Original was GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D5
        /// </summary>
        ProxyPostColorMatrixColorTableSgi = 0x80d5,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum ContextFlagMask
    {
        /// <summary>
        /// Original was GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001
        /// </summary>
        ContextFlagForwardCompatibleBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002
        /// </summary>
        ContextFlagDebugBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_DEBUG_BIT_KHR = 0x00000002
        /// </summary>
        ContextFlagDebugBitKhr = ((int)0x00000002),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004
        /// </summary>
        ContextFlagRobustAccessBit = ((int)0x00000004),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x00000004
        /// </summary>
        ContextFlagRobustAccessBitArb = ((int)0x00000004),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_NO_ERROR_BIT = 0x00000008
        /// </summary>
        ContextFlagNoErrorBit = ((int)0x00000008),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR = 0x00000008
        /// </summary>
        ContextFlagNoErrorBitKhr = ((int)0x00000008),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT = 0x00000010
        /// </summary>
        ContextFlagProtectedContentBitExt = ((int)0x00000010),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum ContextProfileMask
    {
        /// <summary>
        /// Original was GL_CONTEXT_CORE_PROFILE_BIT = 0x00000001
        /// </summary>
        ContextCoreProfileBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002
        /// </summary>
        ContextCompatibilityProfileBit = ((int)0x00000002),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ConvolutionBorderModeExt
    {
        /// <summary>
        /// Original was GL_REDUCE = 0x8016
        /// </summary>
        Reduce = 0x8016,

        /// <summary>
        /// Original was GL_REDUCE_EXT = 0x8016
        /// </summary>
        ReduceExt = 0x8016,
    }

    /// <summary>
    /// Used in GL.Oes.ConvolutionParameterx
    /// </summary>
    public enum ConvolutionParameterExt
    {
        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_MODE = 0x8013
        /// </summary>
        ConvolutionBorderMode = 0x8013,

        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_MODE_EXT = 0x8013
        /// </summary>
        ConvolutionBorderModeExt = 0x8013,

        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_SCALE = 0x8014
        /// </summary>
        ConvolutionFilterScale = 0x8014,

        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_SCALE_EXT = 0x8014
        /// </summary>
        ConvolutionFilterScaleExt = 0x8014,

        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_BIAS = 0x8015
        /// </summary>
        ConvolutionFilterBias = 0x8015,

        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_BIAS_EXT = 0x8015
        /// </summary>
        ConvolutionFilterBiasExt = 0x8015,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ConvolutionTarget
    {
        /// <summary>
        /// Original was GL_CONVOLUTION_1D = 0x8010
        /// </summary>
        Convolution1D = 0x8010,

        /// <summary>
        /// Original was GL_CONVOLUTION_2D = 0x8011
        /// </summary>
        Convolution2D = 0x8011,
    }

    /// <summary>
    /// Used in GL.Oes.ConvolutionParameterx
    /// </summary>
    public enum ConvolutionTargetExt
    {
        /// <summary>
        /// Original was GL_CONVOLUTION_1D = 0x8010
        /// </summary>
        Convolution1D = 0x8010,

        /// <summary>
        /// Original was GL_CONVOLUTION_1D_EXT = 0x8010
        /// </summary>
        Convolution1DExt = 0x8010,

        /// <summary>
        /// Original was GL_CONVOLUTION_2D = 0x8011
        /// </summary>
        Convolution2D = 0x8011,

        /// <summary>
        /// Original was GL_CONVOLUTION_2D_EXT = 0x8011
        /// </summary>
        Convolution2DExt = 0x8011,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum CopyBufferSubDataTarget
    {
        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = 0x8892,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = 0x8893,

        /// <summary>
        /// Original was GL_PIXEL_PACK_BUFFER = 0x88EB
        /// </summary>
        PixelPackBuffer = 0x88eb,

        /// <summary>
        /// Original was GL_PIXEL_UNPACK_BUFFER = 0x88EC
        /// </summary>
        PixelUnpackBuffer = 0x88ec,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER = 0x8A11
        /// </summary>
        UniformBuffer = 0x8a11,

        /// <summary>
        /// Original was GL_TEXTURE_BUFFER = 0x8C2A
        /// </summary>
        TextureBuffer = 0x8c2a,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        /// </summary>
        TransformFeedbackBuffer = 0x8c8e,

        /// <summary>
        /// Original was GL_COPY_READ_BUFFER = 0x8F36
        /// </summary>
        CopyReadBuffer = 0x8f36,

        /// <summary>
        /// Original was GL_COPY_WRITE_BUFFER = 0x8F37
        /// </summary>
        CopyWriteBuffer = 0x8f37,

        /// <summary>
        /// Original was GL_DRAW_INDIRECT_BUFFER = 0x8F3F
        /// </summary>
        DrawIndirectBuffer = 0x8f3f,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER = 0x90D2
        /// </summary>
        ShaderStorageBuffer = 0x90d2,

        /// <summary>
        /// Original was GL_DISPATCH_INDIRECT_BUFFER = 0x90EE
        /// </summary>
        DispatchIndirectBuffer = 0x90ee,

        /// <summary>
        /// Original was GL_QUERY_BUFFER = 0x9192
        /// </summary>
        QueryBuffer = 0x9192,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        /// </summary>
        AtomicCounterBuffer = 0x92c0,
    }

    /// <summary>
    /// Used in GL.CullFace
    /// </summary>
    public enum CullFaceMode
    {
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = 0x0404,

        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = 0x0405,

        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = 0x0408,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum DataType
    {
    }

    /// <summary>
    /// Used in GL.DebugMessageControl, GL.DebugMessageInsert and 4 other functions
    /// </summary>
    public enum DebugSeverity
    {
        /// <summary>
        /// Original was GL_DONT_CARE = 0x1100
        /// </summary>
        DontCare = 0x1100,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_HIGH = 0x9146
        /// </summary>
        DebugSeverityHigh = 0x9146,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_MEDIUM = 0x9147
        /// </summary>
        DebugSeverityMedium = 0x9147,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_LOW = 0x9148
        /// </summary>
        DebugSeverityLow = 0x9148,
    }

    /// <summary>
    /// Used in GL.DebugMessageControl, GL.DebugMessageInsert and 6 other functions
    /// </summary>
    public enum DebugSource
    {
        /// <summary>
        /// Original was GL_DONT_CARE = 0x1100
        /// </summary>
        DontCare = 0x1100,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_API = 0x8246
        /// </summary>
        DebugSourceApi = 0x8246,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247
        /// </summary>
        DebugSourceWindowSystem = 0x8247,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248
        /// </summary>
        DebugSourceShaderCompiler = 0x8248,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249
        /// </summary>
        DebugSourceThirdParty = 0x8249,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_APPLICATION = 0x824A
        /// </summary>
        DebugSourceApplication = 0x824a,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_OTHER = 0x824B
        /// </summary>
        DebugSourceOther = 0x824b,
    }

    /// <summary>
    /// Used in GL.DebugMessageControl, GL.DebugMessageInsert and 4 other functions
    /// </summary>
    public enum DebugType
    {
        /// <summary>
        /// Original was GL_DONT_CARE = 0x1100
        /// </summary>
        DontCare = 0x1100,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_ERROR = 0x824C
        /// </summary>
        DebugTypeError = 0x824c,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D
        /// </summary>
        DebugTypeDeprecatedBehavior = 0x824d,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E
        /// </summary>
        DebugTypeUndefinedBehavior = 0x824e,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PORTABILITY = 0x824F
        /// </summary>
        DebugTypePortability = 0x824f,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PERFORMANCE = 0x8250
        /// </summary>
        DebugTypePerformance = 0x8250,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_OTHER = 0x8251
        /// </summary>
        DebugTypeOther = 0x8251,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_MARKER = 0x8268
        /// </summary>
        DebugTypeMarker = 0x8268,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PUSH_GROUP = 0x8269
        /// </summary>
        DebugTypePushGroup = 0x8269,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_POP_GROUP = 0x826A
        /// </summary>
        DebugTypePopGroup = 0x826a,
    }

    /// <summary>
    /// Used in GL.DepthFunc
    /// </summary>
    public enum DepthFunction
    {
        /// <summary>
        /// Original was GL_NEVER = 0x0200
        /// </summary>
        Never = 0x0200,

        /// <summary>
        /// Original was GL_LESS = 0x0201
        /// </summary>
        Less = 0x0201,

        /// <summary>
        /// Original was GL_EQUAL = 0x0202
        /// </summary>
        Equal = 0x0202,

        /// <summary>
        /// Original was GL_LEQUAL = 0x0203
        /// </summary>
        Lequal = 0x0203,

        /// <summary>
        /// Original was GL_GREATER = 0x0204
        /// </summary>
        Greater = 0x0204,

        /// <summary>
        /// Original was GL_NOTEQUAL = 0x0205
        /// </summary>
        Notequal = 0x0205,

        /// <summary>
        /// Original was GL_GEQUAL = 0x0206
        /// </summary>
        Gequal = 0x0206,

        /// <summary>
        /// Original was GL_ALWAYS = 0x0207
        /// </summary>
        Always = 0x0207,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum DrawBufferMode
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Original was GL_NONE_OES = 0
        /// </summary>
        NoneOes = 0,

        /// <summary>
        /// Original was GL_FRONT_LEFT = 0x0400
        /// </summary>
        FrontLeft = 0x0400,

        /// <summary>
        /// Original was GL_FRONT_RIGHT = 0x0401
        /// </summary>
        FrontRight = 0x0401,

        /// <summary>
        /// Original was GL_BACK_LEFT = 0x0402
        /// </summary>
        BackLeft = 0x0402,

        /// <summary>
        /// Original was GL_BACK_RIGHT = 0x0403
        /// </summary>
        BackRight = 0x0403,

        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = 0x0404,

        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = 0x0405,

        /// <summary>
        /// Original was GL_LEFT = 0x0406
        /// </summary>
        Left = 0x0406,

        /// <summary>
        /// Original was GL_RIGHT = 0x0407
        /// </summary>
        Right = 0x0407,

        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = 0x0408,

        /// <summary>
        /// Original was GL_AUX0 = 0x0409
        /// </summary>
        Aux0 = 0x0409,

        /// <summary>
        /// Original was GL_AUX1 = 0x040A
        /// </summary>
        Aux1 = 0x040a,

        /// <summary>
        /// Original was GL_AUX2 = 0x040B
        /// </summary>
        Aux2 = 0x040b,

        /// <summary>
        /// Original was GL_AUX3 = 0x040C
        /// </summary>
        Aux3 = 0x040c,
    }

    /// <summary>
    /// Used in GL.DrawElements, GL.Ext.MultiDrawElements
    /// </summary>
    public enum DrawElementsType
    {
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = 0x1401,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = 0x1403,

        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = 0x1405,
    }

    /// <summary>
    /// Used in GL.Disable, GL.DisableClientState and 3 other functions
    /// </summary>
    public enum EnableCap
    {
        /// <summary>
        /// Original was GL_POINT_SMOOTH = 0x0B10
        /// </summary>
        PointSmooth = 0x0b10,

        /// <summary>
        /// Original was GL_LINE_SMOOTH = 0x0B20
        /// </summary>
        LineSmooth = 0x0b20,

        /// <summary>
        /// Original was GL_LINE_STIPPLE = 0x0B24
        /// </summary>
        LineStipple = 0x0b24,

        /// <summary>
        /// Original was GL_POLYGON_SMOOTH = 0x0B41
        /// </summary>
        PolygonSmooth = 0x0b41,

        /// <summary>
        /// Original was GL_POLYGON_STIPPLE = 0x0B42
        /// </summary>
        PolygonStipple = 0x0b42,

        /// <summary>
        /// Original was GL_CULL_FACE = 0x0B44
        /// </summary>
        CullFace = 0x0b44,

        /// <summary>
        /// Original was GL_LIGHTING = 0x0B50
        /// </summary>
        Lighting = 0x0b50,

        /// <summary>
        /// Original was GL_COLOR_MATERIAL = 0x0B57
        /// </summary>
        ColorMaterial = 0x0b57,

        /// <summary>
        /// Original was GL_FOG = 0x0B60
        /// </summary>
        Fog = 0x0b60,

        /// <summary>
        /// Original was GL_DEPTH_TEST = 0x0B71
        /// </summary>
        DepthTest = 0x0b71,

        /// <summary>
        /// Original was GL_STENCIL_TEST = 0x0B90
        /// </summary>
        StencilTest = 0x0b90,

        /// <summary>
        /// Original was GL_NORMALIZE = 0x0BA1
        /// </summary>
        Normalize = 0x0ba1,

        /// <summary>
        /// Original was GL_ALPHA_TEST = 0x0BC0
        /// </summary>
        AlphaTest = 0x0bc0,

        /// <summary>
        /// Original was GL_DITHER = 0x0BD0
        /// </summary>
        Dither = 0x0bd0,

        /// <summary>
        /// Original was GL_BLEND = 0x0BE2
        /// </summary>
        Blend = 0x0be2,

        /// <summary>
        /// Original was GL_INDEX_LOGIC_OP = 0x0BF1
        /// </summary>
        IndexLogicOp = 0x0bf1,

        /// <summary>
        /// Original was GL_COLOR_LOGIC_OP = 0x0BF2
        /// </summary>
        ColorLogicOp = 0x0bf2,

        /// <summary>
        /// Original was GL_SCISSOR_TEST = 0x0C11
        /// </summary>
        ScissorTest = 0x0c11,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_S = 0x0C60
        /// </summary>
        TextureGenS = 0x0c60,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_T = 0x0C61
        /// </summary>
        TextureGenT = 0x0c61,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_R = 0x0C62
        /// </summary>
        TextureGenR = 0x0c62,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_Q = 0x0C63
        /// </summary>
        TextureGenQ = 0x0c63,

        /// <summary>
        /// Original was GL_AUTO_NORMAL = 0x0D80
        /// </summary>
        AutoNormal = 0x0d80,

        /// <summary>
        /// Original was GL_MAP1_COLOR_4 = 0x0D90
        /// </summary>
        Map1Color4 = 0x0d90,

        /// <summary>
        /// Original was GL_MAP1_INDEX = 0x0D91
        /// </summary>
        Map1Index = 0x0d91,

        /// <summary>
        /// Original was GL_MAP1_NORMAL = 0x0D92
        /// </summary>
        Map1Normal = 0x0d92,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_1 = 0x0D93
        /// </summary>
        Map1TextureCoord1 = 0x0d93,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_2 = 0x0D94
        /// </summary>
        Map1TextureCoord2 = 0x0d94,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_3 = 0x0D95
        /// </summary>
        Map1TextureCoord3 = 0x0d95,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_4 = 0x0D96
        /// </summary>
        Map1TextureCoord4 = 0x0d96,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_3 = 0x0D97
        /// </summary>
        Map1Vertex3 = 0x0d97,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_4 = 0x0D98
        /// </summary>
        Map1Vertex4 = 0x0d98,

        /// <summary>
        /// Original was GL_MAP2_COLOR_4 = 0x0DB0
        /// </summary>
        Map2Color4 = 0x0db0,

        /// <summary>
        /// Original was GL_MAP2_INDEX = 0x0DB1
        /// </summary>
        Map2Index = 0x0db1,

        /// <summary>
        /// Original was GL_MAP2_NORMAL = 0x0DB2
        /// </summary>
        Map2Normal = 0x0db2,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_1 = 0x0DB3
        /// </summary>
        Map2TextureCoord1 = 0x0db3,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_2 = 0x0DB4
        /// </summary>
        Map2TextureCoord2 = 0x0db4,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_3 = 0x0DB5
        /// </summary>
        Map2TextureCoord3 = 0x0db5,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_4 = 0x0DB6
        /// </summary>
        Map2TextureCoord4 = 0x0db6,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_3 = 0x0DB7
        /// </summary>
        Map2Vertex3 = 0x0db7,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_4 = 0x0DB8
        /// </summary>
        Map2Vertex4 = 0x0db8,

        /// <summary>
        /// Original was GL_TEXTURE_1D = 0x0DE0
        /// </summary>
        Texture1D = 0x0de0,

        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = 0x0de1,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_POINT = 0x2A01
        /// </summary>
        PolygonOffsetPoint = 0x2a01,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_LINE = 0x2A02
        /// </summary>
        PolygonOffsetLine = 0x2a02,

        /// <summary>
        /// Original was GL_CLIP_PLANE0 = 0x3000
        /// </summary>
        ClipPlane0 = 0x3000,

        /// <summary>
        /// Original was GL_CLIP_PLANE1 = 0x3001
        /// </summary>
        ClipPlane1 = 0x3001,

        /// <summary>
        /// Original was GL_CLIP_PLANE2 = 0x3002
        /// </summary>
        ClipPlane2 = 0x3002,

        /// <summary>
        /// Original was GL_CLIP_PLANE3 = 0x3003
        /// </summary>
        ClipPlane3 = 0x3003,

        /// <summary>
        /// Original was GL_CLIP_PLANE4 = 0x3004
        /// </summary>
        ClipPlane4 = 0x3004,

        /// <summary>
        /// Original was GL_CLIP_PLANE5 = 0x3005
        /// </summary>
        ClipPlane5 = 0x3005,

        /// <summary>
        /// Original was GL_LIGHT0 = 0x4000
        /// </summary>
        Light0 = 0x4000,

        /// <summary>
        /// Original was GL_LIGHT1 = 0x4001
        /// </summary>
        Light1 = 0x4001,

        /// <summary>
        /// Original was GL_LIGHT2 = 0x4002
        /// </summary>
        Light2 = 0x4002,

        /// <summary>
        /// Original was GL_LIGHT3 = 0x4003
        /// </summary>
        Light3 = 0x4003,

        /// <summary>
        /// Original was GL_LIGHT4 = 0x4004
        /// </summary>
        Light4 = 0x4004,

        /// <summary>
        /// Original was GL_LIGHT5 = 0x4005
        /// </summary>
        Light5 = 0x4005,

        /// <summary>
        /// Original was GL_LIGHT6 = 0x4006
        /// </summary>
        Light6 = 0x4006,

        /// <summary>
        /// Original was GL_LIGHT7 = 0x4007
        /// </summary>
        Light7 = 0x4007,

        /// <summary>
        /// Original was GL_CONVOLUTION_1D_EXT = 0x8010
        /// </summary>
        Convolution1DExt = 0x8010,

        /// <summary>
        /// Original was GL_CONVOLUTION_2D_EXT = 0x8011
        /// </summary>
        Convolution2DExt = 0x8011,

        /// <summary>
        /// Original was GL_SEPARABLE_2D_EXT = 0x8012
        /// </summary>
        Separable2DExt = 0x8012,

        /// <summary>
        /// Original was GL_HISTOGRAM_EXT = 0x8024
        /// </summary>
        HistogramExt = 0x8024,

        /// <summary>
        /// Original was GL_MINMAX_EXT = 0x802E
        /// </summary>
        MinmaxExt = 0x802e,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FILL = 0x8037
        /// </summary>
        PolygonOffsetFill = 0x8037,

        /// <summary>
        /// Original was GL_RESCALE_NORMAL_EXT = 0x803A
        /// </summary>
        RescaleNormalExt = 0x803a,

        /// <summary>
        /// Original was GL_TEXTURE_3D_EXT = 0x806F
        /// </summary>
        Texture3DExt = 0x806f,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = 0x8074,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY = 0x8075
        /// </summary>
        NormalArray = 0x8075,

        /// <summary>
        /// Original was GL_COLOR_ARRAY = 0x8076
        /// </summary>
        ColorArray = 0x8076,

        /// <summary>
        /// Original was GL_INDEX_ARRAY = 0x8077
        /// </summary>
        IndexArray = 0x8077,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY = 0x8078
        /// </summary>
        TextureCoordArray = 0x8078,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY = 0x8079
        /// </summary>
        EdgeFlagArray = 0x8079,

        /// <summary>
        /// Original was GL_INTERLACE_SGIX = 0x8094
        /// </summary>
        InterlaceSgix = 0x8094,

        /// <summary>
        /// Original was GL_MULTISAMPLE_SGIS = 0x809D
        /// </summary>
        MultisampleSgis = 0x809d,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E
        /// </summary>
        SampleAlphaToMaskSgis = 0x809e,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F
        /// </summary>
        SampleAlphaToOneSgis = 0x809f,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_SGIS = 0x80A0
        /// </summary>
        SampleMaskSgis = 0x80a0,

        /// <summary>
        /// Original was GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
        /// </summary>
        TextureColorTableSgi = 0x80bc,

        /// <summary>
        /// Original was GL_COLOR_TABLE_SGI = 0x80D0
        /// </summary>
        ColorTableSgi = 0x80d0,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
        /// </summary>
        PostConvolutionColorTableSgi = 0x80d1,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
        /// </summary>
        PostColorMatrixColorTableSgi = 0x80d2,

        /// <summary>
        /// Original was GL_TEXTURE_4D_SGIS = 0x8134
        /// </summary>
        Texture4DSgis = 0x8134,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_SGIX = 0x8139
        /// </summary>
        PixelTexGenSgix = 0x8139,

        /// <summary>
        /// Original was GL_SPRITE_SGIX = 0x8148
        /// </summary>
        SpriteSgix = 0x8148,

        /// <summary>
        /// Original was GL_REFERENCE_PLANE_SGIX = 0x817D
        /// </summary>
        ReferencePlaneSgix = 0x817d,

        /// <summary>
        /// Original was GL_IR_INSTRUMENT1_SGIX = 0x817F
        /// </summary>
        IrInstrument1Sgix = 0x817f,

        /// <summary>
        /// Original was GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183
        /// </summary>
        CalligraphicFragmentSgix = 0x8183,

        /// <summary>
        /// Original was GL_FRAMEZOOM_SGIX = 0x818B
        /// </summary>
        FramezoomSgix = 0x818b,

        /// <summary>
        /// Original was GL_FOG_OFFSET_SGIX = 0x8198
        /// </summary>
        FogOffsetSgix = 0x8198,

        /// <summary>
        /// Original was GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB
        /// </summary>
        SharedTexturePaletteExt = 0x81fb,

        /// <summary>
        /// Original was GL_ASYNC_HISTOGRAM_SGIX = 0x832C
        /// </summary>
        AsyncHistogramSgix = 0x832c,

        /// <summary>
        /// Original was GL_PIXEL_TEXTURE_SGIS = 0x8353
        /// </summary>
        PixelTextureSgis = 0x8353,

        /// <summary>
        /// Original was GL_ASYNC_TEX_IMAGE_SGIX = 0x835C
        /// </summary>
        AsyncTexImageSgix = 0x835c,

        /// <summary>
        /// Original was GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D
        /// </summary>
        AsyncDrawPixelsSgix = 0x835d,

        /// <summary>
        /// Original was GL_ASYNC_READ_PIXELS_SGIX = 0x835E
        /// </summary>
        AsyncReadPixelsSgix = 0x835e,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHTING_SGIX = 0x8400
        /// </summary>
        FragmentLightingSgix = 0x8400,

        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401
        /// </summary>
        FragmentColorMaterialSgix = 0x8401,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT0_SGIX = 0x840C
        /// </summary>
        FragmentLight0Sgix = 0x840c,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT1_SGIX = 0x840D
        /// </summary>
        FragmentLight1Sgix = 0x840d,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT2_SGIX = 0x840E
        /// </summary>
        FragmentLight2Sgix = 0x840e,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT3_SGIX = 0x840F
        /// </summary>
        FragmentLight3Sgix = 0x840f,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT4_SGIX = 0x8410
        /// </summary>
        FragmentLight4Sgix = 0x8410,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT5_SGIX = 0x8411
        /// </summary>
        FragmentLight5Sgix = 0x8411,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT6_SGIX = 0x8412
        /// </summary>
        FragmentLight6Sgix = 0x8412,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT7_SGIX = 0x8413
        /// </summary>
        FragmentLight7Sgix = 0x8413,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// Original was GL_NO_ERROR = 0
        /// </summary>
        NoError = 0,

        /// <summary>
        /// Original was GL_INVALID_ENUM = 0x0500
        /// </summary>
        InvalidEnum = 0x0500,

        /// <summary>
        /// Original was GL_INVALID_VALUE = 0x0501
        /// </summary>
        InvalidValue = 0x0501,

        /// <summary>
        /// Original was GL_INVALID_OPERATION = 0x0502
        /// </summary>
        InvalidOperation = 0x0502,

        /// <summary>
        /// Original was GL_STACK_OVERFLOW = 0x0503
        /// </summary>
        StackOverflow = 0x0503,

        /// <summary>
        /// Original was GL_STACK_UNDERFLOW = 0x0504
        /// </summary>
        StackUnderflow = 0x0504,

        /// <summary>
        /// Original was GL_OUT_OF_MEMORY = 0x0505
        /// </summary>
        OutOfMemory = 0x0505,

        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506
        /// </summary>
        InvalidFramebufferOperation = 0x0506,

        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506
        /// </summary>
        InvalidFramebufferOperationExt = 0x0506,

        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506
        /// </summary>
        InvalidFramebufferOperationOes = 0x0506,

        /// <summary>
        /// Original was GL_TABLE_TOO_LARGE = 0x8031
        /// </summary>
        TableTooLarge = 0x8031,

        /// <summary>
        /// Original was GL_TABLE_TOO_LARGE_EXT = 0x8031
        /// </summary>
        TableTooLargeExt = 0x8031,

        /// <summary>
        /// Original was GL_TEXTURE_TOO_LARGE_EXT = 0x8065
        /// </summary>
        TextureTooLargeExt = 0x8065,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtBlendMinmax
    {
        /// <summary>
        /// Original was GL_FUNC_ADD_EXT = 0x8006
        /// </summary>
        FuncAddExt = 0x8006,

        /// <summary>
        /// Original was GL_MIN_EXT = 0x8007
        /// </summary>
        MinExt = 0x8007,

        /// <summary>
        /// Original was GL_MAX_EXT = 0x8008
        /// </summary>
        MaxExt = 0x8008,

        /// <summary>
        /// Original was GL_BLEND_EQUATION_EXT = 0x8009
        /// </summary>
        BlendEquationExt = 0x8009,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtDebugMarker
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtDiscardFramebuffer
    {
        /// <summary>
        /// Original was GL_COLOR_EXT = 0x1800
        /// </summary>
        ColorExt = 0x1800,

        /// <summary>
        /// Original was GL_DEPTH_EXT = 0x1801
        /// </summary>
        DepthExt = 0x1801,

        /// <summary>
        /// Original was GL_STENCIL_EXT = 0x1802
        /// </summary>
        StencilExt = 0x1802,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExternalHandleType
    {
        /// <summary>
        /// Original was GL_HANDLE_TYPE_OPAQUE_FD_EXT = 0x9586
        /// </summary>
        HandleTypeOpaqueFdExt = 0x9586,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_OPAQUE_WIN32_EXT = 0x9587
        /// </summary>
        HandleTypeOpaqueWin32Ext = 0x9587,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT = 0x9588
        /// </summary>
        HandleTypeOpaqueWin32KmtExt = 0x9588,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT = 0x9589
        /// </summary>
        HandleTypeD3D12TilepoolExt = 0x9589,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D12_RESOURCE_EXT = 0x958A
        /// </summary>
        HandleTypeD3D12ResourceExt = 0x958a,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D11_IMAGE_EXT = 0x958B
        /// </summary>
        HandleTypeD3D11ImageExt = 0x958b,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT = 0x958C
        /// </summary>
        HandleTypeD3D11ImageKmtExt = 0x958c,

        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D12_FENCE_EXT = 0x9594
        /// </summary>
        HandleTypeD3D12FenceExt = 0x9594,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtMapBufferRange
    {
        /// <summary>
        /// Original was GL_MAP_READ_BIT_EXT = 0x0001
        /// </summary>
        MapReadBitExt = 0x0001,

        /// <summary>
        /// Original was GL_MAP_WRITE_BIT_EXT = 0x0002
        /// </summary>
        MapWriteBitExt = 0x0002,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004
        /// </summary>
        MapInvalidateRangeBitExt = 0x0004,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008
        /// </summary>
        MapInvalidateBufferBitExt = 0x0008,

        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010
        /// </summary>
        MapFlushExplicitBitExt = 0x0010,

        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020
        /// </summary>
        MapUnsynchronizedBitExt = 0x0020,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtMultiDrawArrays
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtMultisampledRenderToTexture
    {
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_EXT = 0x8CAB
        /// </summary>
        RenderbufferSamplesExt = 0x8cab,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisampleExt = 0x8d56,

        /// <summary>
        /// Original was GL_MAX_SAMPLES_EXT = 0x8D57
        /// </summary>
        MaxSamplesExt = 0x8d57,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT = 0x8D6C
        /// </summary>
        FramebufferAttachmentTextureSamplesExt = 0x8d6c,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtReadFormatBgra
    {
        /// <summary>
        /// Original was GL_BGRA_EXT = 0x80E1
        /// </summary>
        BgraExt = 0x80e1,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT = 0x8365
        /// </summary>
        UnsignedShort4444RevExt = 0x8365,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT = 0x8366
        /// </summary>
        UnsignedShort1555RevExt = 0x8366,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtRobustness
    {
        /// <summary>
        /// Original was GL_NO_ERROR = 0
        /// </summary>
        NoError = 0,

        /// <summary>
        /// Original was GL_LOSE_CONTEXT_ON_RESET_EXT = 0x8252
        /// </summary>
        LoseContextOnResetExt = 0x8252,

        /// <summary>
        /// Original was GL_GUILTY_CONTEXT_RESET_EXT = 0x8253
        /// </summary>
        GuiltyContextResetExt = 0x8253,

        /// <summary>
        /// Original was GL_INNOCENT_CONTEXT_RESET_EXT = 0x8254
        /// </summary>
        InnocentContextResetExt = 0x8254,

        /// <summary>
        /// Original was GL_UNKNOWN_CONTEXT_RESET_EXT = 0x8255
        /// </summary>
        UnknownContextResetExt = 0x8255,

        /// <summary>
        /// Original was GL_RESET_NOTIFICATION_STRATEGY_EXT = 0x8256
        /// </summary>
        ResetNotificationStrategyExt = 0x8256,

        /// <summary>
        /// Original was GL_NO_RESET_NOTIFICATION_EXT = 0x8261
        /// </summary>
        NoResetNotificationExt = 0x8261,

        /// <summary>
        /// Original was GL_CONTEXT_ROBUST_ACCESS_EXT = 0x90F3
        /// </summary>
        ContextRobustAccessExt = 0x90f3,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtSrgb
    {
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT = 0x8210
        /// </summary>
        FramebufferAttachmentColorEncodingExt = 0x8210,

        /// <summary>
        /// Original was GL_SRGB_EXT = 0x8C40
        /// </summary>
        SrgbExt = 0x8c40,

        /// <summary>
        /// Original was GL_SRGB_ALPHA_EXT = 0x8C42
        /// </summary>
        SrgbAlphaExt = 0x8c42,

        /// <summary>
        /// Original was GL_SRGB8_ALPHA8_EXT = 0x8C43
        /// </summary>
        Srgb8Alpha8Ext = 0x8c43,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureCompressionDxt1
    {
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0
        /// </summary>
        CompressedRgbS3tcDxt1Ext = 0x83f0,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1
        /// </summary>
        CompressedRgbaS3tcDxt1Ext = 0x83f1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum ExttextureFilterAnisotropic
    {
        /// <summary>
        /// Original was GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE
        /// </summary>
        TextureMaxAnisotropyExt = 0x84fe,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF
        /// </summary>
        MaxTextureMaxAnisotropyExt = 0x84ff,

        /// <summary>
        /// Original was GL_EXT_texture_filter_anisotropic = 1
        /// </summary>
        ExtTextureFilterAnisotropic = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureFilterAnisotropic
    {
        /// <summary>
        /// Original was GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE
        /// </summary>
        TextureMaxAnisotropyExt = 0x84fe,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF
        /// </summary>
        MaxTextureMaxAnisotropyExt = 0x84ff,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum ExttextureFormatBgra8888
    {
        /// <summary>
        /// Original was GL_BGRA = 0x80E1
        /// </summary>
        Bgra = 0x80e1,

        /// <summary>
        /// Original was GL_EXT_texture_format_BGRA8888 = 1
        /// </summary>
        ExtTextureFormatBgra8888 = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureFormatBgra8888
    {
        /// <summary>
        /// Original was GL_BGRA_EXT = 0x80E1
        /// </summary>
        BgraExt = 0x80e1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureLodBias
    {
        /// <summary>
        /// Original was GL_MAX_TEXTURE_LOD_BIAS_EXT = 0x84FD
        /// </summary>
        MaxTextureLodBiasExt = 0x84fd,

        /// <summary>
        /// Original was GL_TEXTURE_FILTER_CONTROL_EXT = 0x8500
        /// </summary>
        TextureFilterControlExt = 0x8500,

        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_EXT = 0x8501
        /// </summary>
        TextureLodBiasExt = 0x8501,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureStorage
    {
        /// <summary>
        /// Original was GL_ALPHA8_EXT = 0x803C
        /// </summary>
        Alpha8Ext = 0x803c,

        /// <summary>
        /// Original was GL_LUMINANCE8_EXT = 0x8040
        /// </summary>
        Luminance8Ext = 0x8040,

        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8_EXT = 0x8045
        /// </summary>
        Luminance8Alpha8Ext = 0x8045,

        /// <summary>
        /// Original was GL_RGB10_EXT = 0x8052
        /// </summary>
        Rgb10Ext = 0x8052,

        /// <summary>
        /// Original was GL_RGB10_A2_EXT = 0x8059
        /// </summary>
        Rgb10A2Ext = 0x8059,

        /// <summary>
        /// Original was GL_R8_EXT = 0x8229
        /// </summary>
        R8Ext = 0x8229,

        /// <summary>
        /// Original was GL_RG8_EXT = 0x822B
        /// </summary>
        Rg8Ext = 0x822b,

        /// <summary>
        /// Original was GL_R16F_EXT = 0x822D
        /// </summary>
        R16fExt = 0x822d,

        /// <summary>
        /// Original was GL_R32F_EXT = 0x822E
        /// </summary>
        R32fExt = 0x822e,

        /// <summary>
        /// Original was GL_RG16F_EXT = 0x822F
        /// </summary>
        Rg16fExt = 0x822f,

        /// <summary>
        /// Original was GL_RG32F_EXT = 0x8230
        /// </summary>
        Rg32fExt = 0x8230,

        /// <summary>
        /// Original was GL_RGBA32F_EXT = 0x8814
        /// </summary>
        Rgba32fExt = 0x8814,

        /// <summary>
        /// Original was GL_RGB32F_EXT = 0x8815
        /// </summary>
        Rgb32fExt = 0x8815,

        /// <summary>
        /// Original was GL_ALPHA32F_EXT = 0x8816
        /// </summary>
        Alpha32fExt = 0x8816,

        /// <summary>
        /// Original was GL_LUMINANCE32F_EXT = 0x8818
        /// </summary>
        Luminance32fExt = 0x8818,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA32F_EXT = 0x8819
        /// </summary>
        LuminanceAlpha32fExt = 0x8819,

        /// <summary>
        /// Original was GL_RGBA16F_EXT = 0x881A
        /// </summary>
        Rgba16fExt = 0x881a,

        /// <summary>
        /// Original was GL_RGB16F_EXT = 0x881B
        /// </summary>
        Rgb16fExt = 0x881b,

        /// <summary>
        /// Original was GL_ALPHA16F_EXT = 0x881C
        /// </summary>
        Alpha16fExt = 0x881c,

        /// <summary>
        /// Original was GL_LUMINANCE16F_EXT = 0x881E
        /// </summary>
        Luminance16fExt = 0x881e,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA16F_EXT = 0x881F
        /// </summary>
        LuminanceAlpha16fExt = 0x881f,

        /// <summary>
        /// Original was GL_TEXTURE_IMMUTABLE_FORMAT_EXT = 0x912F
        /// </summary>
        TextureImmutableFormatExt = 0x912f,

        /// <summary>
        /// Original was GL_BGRA8_EXT = 0x93A1
        /// </summary>
        Bgra8Ext = 0x93a1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FeedBackToken
    {
        /// <summary>
        /// Original was GL_PASS_THROUGH_TOKEN = 0x0700
        /// </summary>
        PassThroughToken = 0x0700,

        /// <summary>
        /// Original was GL_POINT_TOKEN = 0x0701
        /// </summary>
        PointToken = 0x0701,

        /// <summary>
        /// Original was GL_LINE_TOKEN = 0x0702
        /// </summary>
        LineToken = 0x0702,

        /// <summary>
        /// Original was GL_POLYGON_TOKEN = 0x0703
        /// </summary>
        PolygonToken = 0x0703,

        /// <summary>
        /// Original was GL_BITMAP_TOKEN = 0x0704
        /// </summary>
        BitmapToken = 0x0704,

        /// <summary>
        /// Original was GL_DRAW_PIXEL_TOKEN = 0x0705
        /// </summary>
        DrawPixelToken = 0x0705,

        /// <summary>
        /// Original was GL_COPY_PIXEL_TOKEN = 0x0706
        /// </summary>
        CopyPixelToken = 0x0706,

        /// <summary>
        /// Original was GL_LINE_RESET_TOKEN = 0x0707
        /// </summary>
        LineResetToken = 0x0707,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FeedbackType
    {
        /// <summary>
        /// Original was GL_2D = 0x0600
        /// </summary>
        Gl2D = 0x0600,

        /// <summary>
        /// Original was GL_3D = 0x0601
        /// </summary>
        Gl3D = 0x0601,

        /// <summary>
        /// Original was GL_3D_COLOR = 0x0602
        /// </summary>
        Gl3DColor = 0x0602,

        /// <summary>
        /// Original was GL_3D_COLOR_TEXTURE = 0x0603
        /// </summary>
        Gl3DColorTexture = 0x0603,

        /// <summary>
        /// Original was GL_4D_COLOR_TEXTURE = 0x0604
        /// </summary>
        Gl4DColorTexture = 0x0604,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum FfdMaskSgix
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FfdTargetSgix
    {
        /// <summary>
        /// Original was GL_GEOMETRY_DEFORMATION_SGIX = 0x8194
        /// </summary>
        GeometryDeformationSgix = 0x8194,

        /// <summary>
        /// Original was GL_TEXTURE_DEFORMATION_SGIX = 0x8195
        /// </summary>
        TextureDeformationSgix = 0x8195,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogCoordinatePointerType
    {
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = 0x140a,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogMode
    {
        /// <summary>
        /// Original was GL_EXP = 0x0800
        /// </summary>
        Exp = 0x0800,

        /// <summary>
        /// Original was GL_EXP2 = 0x0801
        /// </summary>
        Exp2 = 0x0801,

        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = 0x2601,

        /// <summary>
        /// Original was GL_FOG_FUNC_SGIS = 0x812A
        /// </summary>
        FogFuncSgis = 0x812a,
    }

    /// <summary>
    /// Used in GL.Fog
    /// </summary>
    public enum FogParameter
    {
        /// <summary>
        /// Original was GL_FOG_INDEX = 0x0B61
        /// </summary>
        FogIndex = 0x0b61,

        /// <summary>
        /// Original was GL_FOG_DENSITY = 0x0B62
        /// </summary>
        FogDensity = 0x0b62,

        /// <summary>
        /// Original was GL_FOG_START = 0x0B63
        /// </summary>
        FogStart = 0x0b63,

        /// <summary>
        /// Original was GL_FOG_END = 0x0B64
        /// </summary>
        FogEnd = 0x0b64,

        /// <summary>
        /// Original was GL_FOG_MODE = 0x0B65
        /// </summary>
        FogMode = 0x0b65,

        /// <summary>
        /// Original was GL_FOG_COLOR = 0x0B66
        /// </summary>
        FogColor = 0x0b66,

        /// <summary>
        /// Original was GL_FOG_OFFSET_VALUE_SGIX = 0x8199
        /// </summary>
        FogOffsetValueSgix = 0x8199,
    }

    /// <summary>
    /// Used in GL.Fogx, GL.Oes.Fogx
    /// </summary>
    public enum FogPName
    {
        /// <summary>
        /// Original was GL_FOG_INDEX = 0x0B61
        /// </summary>
        FogIndex = 0x0b61,

        /// <summary>
        /// Original was GL_FOG_DENSITY = 0x0B62
        /// </summary>
        FogDensity = 0x0b62,

        /// <summary>
        /// Original was GL_FOG_START = 0x0B63
        /// </summary>
        FogStart = 0x0b63,

        /// <summary>
        /// Original was GL_FOG_END = 0x0B64
        /// </summary>
        FogEnd = 0x0b64,

        /// <summary>
        /// Original was GL_FOG_MODE = 0x0B65
        /// </summary>
        FogMode = 0x0b65,

        /// <summary>
        /// Original was GL_FOG_COORD_SRC = 0x8450
        /// </summary>
        FogCoordSrc = 0x8450,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogPointerTypeExt
    {
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = 0x140a,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogPointerTypeIbm
    {
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = 0x140a,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FragmentLightModelParameterSgix
    {
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408
        /// </summary>
        FragmentLightModelLocalViewerSgix = 0x8408,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409
        /// </summary>
        FragmentLightModelTwoSideSgix = 0x8409,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A
        /// </summary>
        FragmentLightModelAmbientSgix = 0x840a,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B
        /// </summary>
        FragmentLightModelNormalInterpolationSgix = 0x840b,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FragmentOpAti
    {
        /// <summary>
        /// Original was GL_MOV_ATI = 0x8961
        /// </summary>
        MovAti = 0x8961,

        /// <summary>
        /// Original was GL_ADD_ATI = 0x8963
        /// </summary>
        AddAti = 0x8963,

        /// <summary>
        /// Original was GL_MUL_ATI = 0x8964
        /// </summary>
        MulAti = 0x8964,

        /// <summary>
        /// Original was GL_SUB_ATI = 0x8965
        /// </summary>
        SubAti = 0x8965,

        /// <summary>
        /// Original was GL_DOT3_ATI = 0x8966
        /// </summary>
        Dot3Ati = 0x8966,

        /// <summary>
        /// Original was GL_DOT4_ATI = 0x8967
        /// </summary>
        Dot4Ati = 0x8967,

        /// <summary>
        /// Original was GL_MAD_ATI = 0x8968
        /// </summary>
        MadAti = 0x8968,

        /// <summary>
        /// Original was GL_LERP_ATI = 0x8969
        /// </summary>
        LerpAti = 0x8969,

        /// <summary>
        /// Original was GL_CND_ATI = 0x896A
        /// </summary>
        CndAti = 0x896a,

        /// <summary>
        /// Original was GL_CND0_ATI = 0x896B
        /// </summary>
        Cnd0Ati = 0x896b,

        /// <summary>
        /// Original was GL_DOT2_ADD_ATI = 0x896C
        /// </summary>
        Dot2AddAti = 0x896c,
    }

    /// <summary>
    /// Used in GL.Ext.FramebufferTexture2DMultisample, GL.Img.FramebufferTexture2DMultisample and 3 other functions
    /// </summary>
    public enum FramebufferAttachment
    {
        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS = 0x8CDF
        /// </summary>
        MaxColorAttachments = 0x8cdf,

        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS_EXT = 0x8CDF
        /// </summary>
        MaxColorAttachmentsExt = 0x8cdf,

        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS_NV = 0x8CDF
        /// </summary>
        MaxColorAttachmentsNv = 0x8cdf,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        /// </summary>
        ColorAttachment0 = 0x8ce0,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_EXT = 0x8CE0
        /// </summary>
        ColorAttachment0Ext = 0x8ce0,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_NV = 0x8CE0
        /// </summary>
        ColorAttachment0Nv = 0x8ce0,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_OES = 0x8CE0
        /// </summary>
        ColorAttachment0Oes = 0x8ce0,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        /// </summary>
        ColorAttachment1 = 0x8ce1,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1_EXT = 0x8CE1
        /// </summary>
        ColorAttachment1Ext = 0x8ce1,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1_NV = 0x8CE1
        /// </summary>
        ColorAttachment1Nv = 0x8ce1,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        /// </summary>
        ColorAttachment2 = 0x8ce2,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2_EXT = 0x8CE2
        /// </summary>
        ColorAttachment2Ext = 0x8ce2,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2_NV = 0x8CE2
        /// </summary>
        ColorAttachment2Nv = 0x8ce2,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        /// </summary>
        ColorAttachment3 = 0x8ce3,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3_EXT = 0x8CE3
        /// </summary>
        ColorAttachment3Ext = 0x8ce3,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3_NV = 0x8CE3
        /// </summary>
        ColorAttachment3Nv = 0x8ce3,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        /// </summary>
        ColorAttachment4 = 0x8ce4,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4_EXT = 0x8CE4
        /// </summary>
        ColorAttachment4Ext = 0x8ce4,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4_NV = 0x8CE4
        /// </summary>
        ColorAttachment4Nv = 0x8ce4,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        /// </summary>
        ColorAttachment5 = 0x8ce5,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5_EXT = 0x8CE5
        /// </summary>
        ColorAttachment5Ext = 0x8ce5,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5_NV = 0x8CE5
        /// </summary>
        ColorAttachment5Nv = 0x8ce5,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        /// </summary>
        ColorAttachment6 = 0x8ce6,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6_EXT = 0x8CE6
        /// </summary>
        ColorAttachment6Ext = 0x8ce6,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6_NV = 0x8CE6
        /// </summary>
        ColorAttachment6Nv = 0x8ce6,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        /// </summary>
        ColorAttachment7 = 0x8ce7,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7_EXT = 0x8CE7
        /// </summary>
        ColorAttachment7Ext = 0x8ce7,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7_NV = 0x8CE7
        /// </summary>
        ColorAttachment7Nv = 0x8ce7,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        /// </summary>
        ColorAttachment8 = 0x8ce8,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8_EXT = 0x8CE8
        /// </summary>
        ColorAttachment8Ext = 0x8ce8,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8_NV = 0x8CE8
        /// </summary>
        ColorAttachment8Nv = 0x8ce8,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        /// </summary>
        ColorAttachment9 = 0x8ce9,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9_EXT = 0x8CE9
        /// </summary>
        ColorAttachment9Ext = 0x8ce9,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9_NV = 0x8CE9
        /// </summary>
        ColorAttachment9Nv = 0x8ce9,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        /// </summary>
        ColorAttachment10 = 0x8cea,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10_EXT = 0x8CEA
        /// </summary>
        ColorAttachment10Ext = 0x8cea,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10_NV = 0x8CEA
        /// </summary>
        ColorAttachment10Nv = 0x8cea,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        /// </summary>
        ColorAttachment11 = 0x8ceb,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11_EXT = 0x8CEB
        /// </summary>
        ColorAttachment11Ext = 0x8ceb,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11_NV = 0x8CEB
        /// </summary>
        ColorAttachment11Nv = 0x8ceb,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        /// </summary>
        ColorAttachment12 = 0x8cec,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12_EXT = 0x8CEC
        /// </summary>
        ColorAttachment12Ext = 0x8cec,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12_NV = 0x8CEC
        /// </summary>
        ColorAttachment12Nv = 0x8cec,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        /// </summary>
        ColorAttachment13 = 0x8ced,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13_EXT = 0x8CED
        /// </summary>
        ColorAttachment13Ext = 0x8ced,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13_NV = 0x8CED
        /// </summary>
        ColorAttachment13Nv = 0x8ced,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        /// </summary>
        ColorAttachment14 = 0x8cee,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14_EXT = 0x8CEE
        /// </summary>
        ColorAttachment14Ext = 0x8cee,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14_NV = 0x8CEE
        /// </summary>
        ColorAttachment14Nv = 0x8cee,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        /// </summary>
        ColorAttachment15 = 0x8cef,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15_EXT = 0x8CEF
        /// </summary>
        ColorAttachment15Ext = 0x8cef,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15_NV = 0x8CEF
        /// </summary>
        ColorAttachment15Nv = 0x8cef,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT16 = 0x8CF0
        /// </summary>
        ColorAttachment16 = 0x8cf0,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT17 = 0x8CF1
        /// </summary>
        ColorAttachment17 = 0x8cf1,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT18 = 0x8CF2
        /// </summary>
        ColorAttachment18 = 0x8cf2,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT19 = 0x8CF3
        /// </summary>
        ColorAttachment19 = 0x8cf3,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT20 = 0x8CF4
        /// </summary>
        ColorAttachment20 = 0x8cf4,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT21 = 0x8CF5
        /// </summary>
        ColorAttachment21 = 0x8cf5,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT22 = 0x8CF6
        /// </summary>
        ColorAttachment22 = 0x8cf6,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT23 = 0x8CF7
        /// </summary>
        ColorAttachment23 = 0x8cf7,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT24 = 0x8CF8
        /// </summary>
        ColorAttachment24 = 0x8cf8,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT25 = 0x8CF9
        /// </summary>
        ColorAttachment25 = 0x8cf9,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT26 = 0x8CFA
        /// </summary>
        ColorAttachment26 = 0x8cfa,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT27 = 0x8CFB
        /// </summary>
        ColorAttachment27 = 0x8cfb,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT28 = 0x8CFC
        /// </summary>
        ColorAttachment28 = 0x8cfc,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT29 = 0x8CFD
        /// </summary>
        ColorAttachment29 = 0x8cfd,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT30 = 0x8CFE
        /// </summary>
        ColorAttachment30 = 0x8cfe,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT31 = 0x8CFF
        /// </summary>
        ColorAttachment31 = 0x8cff,

        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT = 0x8D00
        /// </summary>
        DepthAttachment = 0x8d00,

        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_EXT = 0x8D00
        /// </summary>
        DepthAttachmentExt = 0x8d00,

        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_OES = 0x8D00
        /// </summary>
        DepthAttachmentOes = 0x8d00,
    }

    /// <summary>
    /// Used in GL.Oes.GetFramebufferAttachmentParameter
    /// </summary>
    public enum FramebufferAttachmentParameterName
    {
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210
        /// </summary>
        FramebufferAttachmentColorEncoding = 0x8210,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211
        /// </summary>
        FramebufferAttachmentComponentType = 0x8211,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212
        /// </summary>
        FramebufferAttachmentRedSize = 0x8212,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213
        /// </summary>
        FramebufferAttachmentGreenSize = 0x8213,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214
        /// </summary>
        FramebufferAttachmentBlueSize = 0x8214,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215
        /// </summary>
        FramebufferAttachmentAlphaSize = 0x8215,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216
        /// </summary>
        FramebufferAttachmentDepthSize = 0x8216,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217
        /// </summary>
        FramebufferAttachmentStencilSize = 0x8217,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectName = 0x8cd1,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevel = 0x8cd2,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFace = 0x8cd3,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4
        /// </summary>
        FramebufferAttachmentTextureLayer = 0x8cd4,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7
        /// </summary>
        FramebufferAttachmentLayered = 0x8da7,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FramebufferFetchNoncoherent
    {
        /// <summary>
        /// Original was GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM = 0x96A2
        /// </summary>
        FramebufferFetchNoncoherentQcom = 0x96a2,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FramebufferParameterName
    {
        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310
        /// </summary>
        FramebufferDefaultWidth = 0x9310,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311
        /// </summary>
        FramebufferDefaultHeight = 0x9311,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312
        /// </summary>
        FramebufferDefaultLayers = 0x9312,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313
        /// </summary>
        FramebufferDefaultSamples = 0x9313,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314
        /// </summary>
        FramebufferDefaultFixedSampleLocations = 0x9314,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FramebufferStatus
    {
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNDEFINED = 0x8219
        /// </summary>
        FramebufferUndefined = 0x8219,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE = 0x8CD5
        /// </summary>
        FramebufferComplete = 0x8cd5,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachment = 0x8cd6,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachment = 0x8cd7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB
        /// </summary>
        FramebufferIncompleteDrawBuffer = 0x8cdb,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC
        /// </summary>
        FramebufferIncompleteReadBuffer = 0x8cdc,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD
        /// </summary>
        FramebufferUnsupported = 0x8cdd,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisample = 0x8d56,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8
        /// </summary>
        FramebufferIncompleteLayerTargets = 0x8da8,
    }

    /// <summary>
    /// Used in GL.Ext.FramebufferTexture2DMultisample, GL.Img.FramebufferTexture2DMultisample and 5 other functions
    /// </summary>
    public enum FramebufferTarget
    {
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER = 0x8CA8
        /// </summary>
        ReadFramebuffer = 0x8ca8,

        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER = 0x8CA9
        /// </summary>
        DrawFramebuffer = 0x8ca9,

        /// <summary>
        /// Original was GL_FRAMEBUFFER = 0x8D40
        /// </summary>
        Framebuffer = 0x8d40,
    }

    /// <summary>
    /// Used in GL.FrontFace
    /// </summary>
    public enum FrontFaceDirection
    {
        /// <summary>
        /// Original was GL_CW = 0x0900
        /// </summary>
        Cw = 0x0900,

        /// <summary>
        /// Original was GL_CCW = 0x0901
        /// </summary>
        Ccw = 0x0901,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetColorTableParameterPNameSgi
    {
        /// <summary>
        /// Original was GL_COLOR_TABLE_SCALE = 0x80D6
        /// </summary>
        ColorTableScale = 0x80d6,

        /// <summary>
        /// Original was GL_COLOR_TABLE_SCALE_SGI = 0x80D6
        /// </summary>
        ColorTableScaleSgi = 0x80d6,

        /// <summary>
        /// Original was GL_COLOR_TABLE_BIAS = 0x80D7
        /// </summary>
        ColorTableBias = 0x80d7,

        /// <summary>
        /// Original was GL_COLOR_TABLE_BIAS_SGI = 0x80D7
        /// </summary>
        ColorTableBiasSgi = 0x80d7,

        /// <summary>
        /// Original was GL_COLOR_TABLE_FORMAT = 0x80D8
        /// </summary>
        ColorTableFormat = 0x80d8,

        /// <summary>
        /// Original was GL_COLOR_TABLE_FORMAT_SGI = 0x80D8
        /// </summary>
        ColorTableFormatSgi = 0x80d8,

        /// <summary>
        /// Original was GL_COLOR_TABLE_WIDTH = 0x80D9
        /// </summary>
        ColorTableWidth = 0x80d9,

        /// <summary>
        /// Original was GL_COLOR_TABLE_WIDTH_SGI = 0x80D9
        /// </summary>
        ColorTableWidthSgi = 0x80d9,

        /// <summary>
        /// Original was GL_COLOR_TABLE_RED_SIZE = 0x80DA
        /// </summary>
        ColorTableRedSize = 0x80da,

        /// <summary>
        /// Original was GL_COLOR_TABLE_RED_SIZE_SGI = 0x80DA
        /// </summary>
        ColorTableRedSizeSgi = 0x80da,

        /// <summary>
        /// Original was GL_COLOR_TABLE_GREEN_SIZE = 0x80DB
        /// </summary>
        ColorTableGreenSize = 0x80db,

        /// <summary>
        /// Original was GL_COLOR_TABLE_GREEN_SIZE_SGI = 0x80DB
        /// </summary>
        ColorTableGreenSizeSgi = 0x80db,

        /// <summary>
        /// Original was GL_COLOR_TABLE_BLUE_SIZE = 0x80DC
        /// </summary>
        ColorTableBlueSize = 0x80dc,

        /// <summary>
        /// Original was GL_COLOR_TABLE_BLUE_SIZE_SGI = 0x80DC
        /// </summary>
        ColorTableBlueSizeSgi = 0x80dc,

        /// <summary>
        /// Original was GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD
        /// </summary>
        ColorTableAlphaSize = 0x80dd,

        /// <summary>
        /// Original was GL_COLOR_TABLE_ALPHA_SIZE_SGI = 0x80DD
        /// </summary>
        ColorTableAlphaSizeSgi = 0x80dd,

        /// <summary>
        /// Original was GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE
        /// </summary>
        ColorTableLuminanceSize = 0x80de,

        /// <summary>
        /// Original was GL_COLOR_TABLE_LUMINANCE_SIZE_SGI = 0x80DE
        /// </summary>
        ColorTableLuminanceSizeSgi = 0x80de,

        /// <summary>
        /// Original was GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF
        /// </summary>
        ColorTableIntensitySize = 0x80df,

        /// <summary>
        /// Original was GL_COLOR_TABLE_INTENSITY_SIZE_SGI = 0x80DF
        /// </summary>
        ColorTableIntensitySizeSgi = 0x80df,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetConvolutionParameter
    {
        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_MODE = 0x8013
        /// </summary>
        ConvolutionBorderMode = 0x8013,

        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_MODE_EXT = 0x8013
        /// </summary>
        ConvolutionBorderModeExt = 0x8013,

        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_SCALE = 0x8014
        /// </summary>
        ConvolutionFilterScale = 0x8014,

        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_SCALE_EXT = 0x8014
        /// </summary>
        ConvolutionFilterScaleExt = 0x8014,

        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_BIAS = 0x8015
        /// </summary>
        ConvolutionFilterBias = 0x8015,

        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_BIAS_EXT = 0x8015
        /// </summary>
        ConvolutionFilterBiasExt = 0x8015,

        /// <summary>
        /// Original was GL_CONVOLUTION_FORMAT = 0x8017
        /// </summary>
        ConvolutionFormat = 0x8017,

        /// <summary>
        /// Original was GL_CONVOLUTION_FORMAT_EXT = 0x8017
        /// </summary>
        ConvolutionFormatExt = 0x8017,

        /// <summary>
        /// Original was GL_CONVOLUTION_WIDTH = 0x8018
        /// </summary>
        ConvolutionWidth = 0x8018,

        /// <summary>
        /// Original was GL_CONVOLUTION_WIDTH_EXT = 0x8018
        /// </summary>
        ConvolutionWidthExt = 0x8018,

        /// <summary>
        /// Original was GL_CONVOLUTION_HEIGHT = 0x8019
        /// </summary>
        ConvolutionHeight = 0x8019,

        /// <summary>
        /// Original was GL_CONVOLUTION_HEIGHT_EXT = 0x8019
        /// </summary>
        ConvolutionHeightExt = 0x8019,

        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_WIDTH = 0x801A
        /// </summary>
        MaxConvolutionWidth = 0x801a,

        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_WIDTH_EXT = 0x801A
        /// </summary>
        MaxConvolutionWidthExt = 0x801a,

        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_HEIGHT = 0x801B
        /// </summary>
        MaxConvolutionHeight = 0x801b,

        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_HEIGHT_EXT = 0x801B
        /// </summary>
        MaxConvolutionHeightExt = 0x801b,

        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_COLOR = 0x8154
        /// </summary>
        ConvolutionBorderColor = 0x8154,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetFramebufferParameter
    {
        /// <summary>
        /// Original was GL_DOUBLEBUFFER = 0x0C32
        /// </summary>
        Doublebuffer = 0x0c32,

        /// <summary>
        /// Original was GL_STEREO = 0x0C33
        /// </summary>
        Stereo = 0x0c33,

        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS = 0x80A8
        /// </summary>
        SampleBuffers = 0x80a8,

        /// <summary>
        /// Original was GL_SAMPLES = 0x80A9
        /// </summary>
        Samples = 0x80a9,

        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A
        /// </summary>
        ImplementationColorReadType = 0x8b9a,

        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B
        /// </summary>
        ImplementationColorReadFormat = 0x8b9b,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310
        /// </summary>
        FramebufferDefaultWidth = 0x9310,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311
        /// </summary>
        FramebufferDefaultHeight = 0x9311,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312
        /// </summary>
        FramebufferDefaultLayers = 0x9312,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313
        /// </summary>
        FramebufferDefaultSamples = 0x9313,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314
        /// </summary>
        FramebufferDefaultFixedSampleLocations = 0x9314,
    }

    /// <summary>
    /// Used in GL.Oes.GetHistogramParameterx
    /// </summary>
    public enum GetHistogramParameterPNameExt
    {
        /// <summary>
        /// Original was GL_HISTOGRAM_WIDTH = 0x8026
        /// </summary>
        HistogramWidth = 0x8026,

        /// <summary>
        /// Original was GL_HISTOGRAM_WIDTH_EXT = 0x8026
        /// </summary>
        HistogramWidthExt = 0x8026,

        /// <summary>
        /// Original was GL_HISTOGRAM_FORMAT = 0x8027
        /// </summary>
        HistogramFormat = 0x8027,

        /// <summary>
        /// Original was GL_HISTOGRAM_FORMAT_EXT = 0x8027
        /// </summary>
        HistogramFormatExt = 0x8027,

        /// <summary>
        /// Original was GL_HISTOGRAM_RED_SIZE = 0x8028
        /// </summary>
        HistogramRedSize = 0x8028,

        /// <summary>
        /// Original was GL_HISTOGRAM_RED_SIZE_EXT = 0x8028
        /// </summary>
        HistogramRedSizeExt = 0x8028,

        /// <summary>
        /// Original was GL_HISTOGRAM_GREEN_SIZE = 0x8029
        /// </summary>
        HistogramGreenSize = 0x8029,

        /// <summary>
        /// Original was GL_HISTOGRAM_GREEN_SIZE_EXT = 0x8029
        /// </summary>
        HistogramGreenSizeExt = 0x8029,

        /// <summary>
        /// Original was GL_HISTOGRAM_BLUE_SIZE = 0x802A
        /// </summary>
        HistogramBlueSize = 0x802a,

        /// <summary>
        /// Original was GL_HISTOGRAM_BLUE_SIZE_EXT = 0x802A
        /// </summary>
        HistogramBlueSizeExt = 0x802a,

        /// <summary>
        /// Original was GL_HISTOGRAM_ALPHA_SIZE = 0x802B
        /// </summary>
        HistogramAlphaSize = 0x802b,

        /// <summary>
        /// Original was GL_HISTOGRAM_ALPHA_SIZE_EXT = 0x802B
        /// </summary>
        HistogramAlphaSizeExt = 0x802b,

        /// <summary>
        /// Original was GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C
        /// </summary>
        HistogramLuminanceSize = 0x802c,

        /// <summary>
        /// Original was GL_HISTOGRAM_LUMINANCE_SIZE_EXT = 0x802C
        /// </summary>
        HistogramLuminanceSizeExt = 0x802c,

        /// <summary>
        /// Original was GL_HISTOGRAM_SINK = 0x802D
        /// </summary>
        HistogramSink = 0x802d,

        /// <summary>
        /// Original was GL_HISTOGRAM_SINK_EXT = 0x802D
        /// </summary>
        HistogramSinkExt = 0x802d,
    }

    /// <summary>
    /// Used in GL.Oes.GetMapx
    /// </summary>
    public enum GetMapQuery
    {
        /// <summary>
        /// Original was GL_COEFF = 0x0A00
        /// </summary>
        Coeff = 0x0a00,

        /// <summary>
        /// Original was GL_ORDER = 0x0A01
        /// </summary>
        Order = 0x0a01,

        /// <summary>
        /// Original was GL_DOMAIN = 0x0A02
        /// </summary>
        Domain = 0x0a02,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetMinmaxParameterPNameExt
    {
        /// <summary>
        /// Original was GL_MINMAX_FORMAT = 0x802F
        /// </summary>
        MinmaxFormat = 0x802f,

        /// <summary>
        /// Original was GL_MINMAX_FORMAT_EXT = 0x802F
        /// </summary>
        MinmaxFormatExt = 0x802f,

        /// <summary>
        /// Original was GL_MINMAX_SINK = 0x8030
        /// </summary>
        MinmaxSink = 0x8030,

        /// <summary>
        /// Original was GL_MINMAX_SINK_EXT = 0x8030
        /// </summary>
        MinmaxSinkExt = 0x8030,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetPixelMap
    {
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_I = 0x0C70
        /// </summary>
        PixelMapIToI = 0x0c70,

        /// <summary>
        /// Original was GL_PIXEL_MAP_S_TO_S = 0x0C71
        /// </summary>
        PixelMapSToS = 0x0c71,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_R = 0x0C72
        /// </summary>
        PixelMapIToR = 0x0c72,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_G = 0x0C73
        /// </summary>
        PixelMapIToG = 0x0c73,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_B = 0x0C74
        /// </summary>
        PixelMapIToB = 0x0c74,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_A = 0x0C75
        /// </summary>
        PixelMapIToA = 0x0c75,

        /// <summary>
        /// Original was GL_PIXEL_MAP_R_TO_R = 0x0C76
        /// </summary>
        PixelMapRToR = 0x0c76,

        /// <summary>
        /// Original was GL_PIXEL_MAP_G_TO_G = 0x0C77
        /// </summary>
        PixelMapGToG = 0x0c77,

        /// <summary>
        /// Original was GL_PIXEL_MAP_B_TO_B = 0x0C78
        /// </summary>
        PixelMapBToB = 0x0c78,

        /// <summary>
        /// Original was GL_PIXEL_MAP_A_TO_A = 0x0C79
        /// </summary>
        PixelMapAToA = 0x0c79,
    }

    /// <summary>
    /// Used in GL.Apple.GetInteger64, GL.GetBoolean and 4 other functions
    /// </summary>
    public enum GetPName
    {
        /// <summary>
        /// Original was GL_CURRENT_COLOR = 0x0B00
        /// </summary>
        CurrentColor = 0x0b00,

        /// <summary>
        /// Original was GL_CURRENT_INDEX = 0x0B01
        /// </summary>
        CurrentIndex = 0x0b01,

        /// <summary>
        /// Original was GL_CURRENT_NORMAL = 0x0B02
        /// </summary>
        CurrentNormal = 0x0b02,

        /// <summary>
        /// Original was GL_CURRENT_TEXTURE_COORDS = 0x0B03
        /// </summary>
        CurrentTextureCoords = 0x0b03,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_COLOR = 0x0B04
        /// </summary>
        CurrentRasterColor = 0x0b04,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_INDEX = 0x0B05
        /// </summary>
        CurrentRasterIndex = 0x0b05,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06
        /// </summary>
        CurrentRasterTextureCoords = 0x0b06,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_POSITION = 0x0B07
        /// </summary>
        CurrentRasterPosition = 0x0b07,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_POSITION_VALID = 0x0B08
        /// </summary>
        CurrentRasterPositionValid = 0x0b08,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_DISTANCE = 0x0B09
        /// </summary>
        CurrentRasterDistance = 0x0b09,

        /// <summary>
        /// Original was GL_POINT_SMOOTH = 0x0B10
        /// </summary>
        PointSmooth = 0x0b10,

        /// <summary>
        /// Original was GL_POINT_SIZE = 0x0B11
        /// </summary>
        PointSize = 0x0b11,

        /// <summary>
        /// Original was GL_POINT_SIZE_RANGE = 0x0B12
        /// </summary>
        PointSizeRange = 0x0b12,

        /// <summary>
        /// Original was GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12
        /// </summary>
        SmoothPointSizeRange = 0x0b12,

        /// <summary>
        /// Original was GL_POINT_SIZE_GRANULARITY = 0x0B13
        /// </summary>
        PointSizeGranularity = 0x0b13,

        /// <summary>
        /// Original was GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13
        /// </summary>
        SmoothPointSizeGranularity = 0x0b13,

        /// <summary>
        /// Original was GL_LINE_SMOOTH = 0x0B20
        /// </summary>
        LineSmooth = 0x0b20,

        /// <summary>
        /// Original was GL_LINE_WIDTH = 0x0B21
        /// </summary>
        LineWidth = 0x0b21,

        /// <summary>
        /// Original was GL_LINE_WIDTH_RANGE = 0x0B22
        /// </summary>
        LineWidthRange = 0x0b22,

        /// <summary>
        /// Original was GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22
        /// </summary>
        SmoothLineWidthRange = 0x0b22,

        /// <summary>
        /// Original was GL_LINE_WIDTH_GRANULARITY = 0x0B23
        /// </summary>
        LineWidthGranularity = 0x0b23,

        /// <summary>
        /// Original was GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23
        /// </summary>
        SmoothLineWidthGranularity = 0x0b23,

        /// <summary>
        /// Original was GL_LINE_STIPPLE = 0x0B24
        /// </summary>
        LineStipple = 0x0b24,

        /// <summary>
        /// Original was GL_LINE_STIPPLE_PATTERN = 0x0B25
        /// </summary>
        LineStipplePattern = 0x0b25,

        /// <summary>
        /// Original was GL_LINE_STIPPLE_REPEAT = 0x0B26
        /// </summary>
        LineStippleRepeat = 0x0b26,

        /// <summary>
        /// Original was GL_LIST_MODE = 0x0B30
        /// </summary>
        ListMode = 0x0b30,

        /// <summary>
        /// Original was GL_MAX_LIST_NESTING = 0x0B31
        /// </summary>
        MaxListNesting = 0x0b31,

        /// <summary>
        /// Original was GL_LIST_BASE = 0x0B32
        /// </summary>
        ListBase = 0x0b32,

        /// <summary>
        /// Original was GL_LIST_INDEX = 0x0B33
        /// </summary>
        ListIndex = 0x0b33,

        /// <summary>
        /// Original was GL_POLYGON_MODE = 0x0B40
        /// </summary>
        PolygonMode = 0x0b40,

        /// <summary>
        /// Original was GL_POLYGON_SMOOTH = 0x0B41
        /// </summary>
        PolygonSmooth = 0x0b41,

        /// <summary>
        /// Original was GL_POLYGON_STIPPLE = 0x0B42
        /// </summary>
        PolygonStipple = 0x0b42,

        /// <summary>
        /// Original was GL_EDGE_FLAG = 0x0B43
        /// </summary>
        EdgeFlag = 0x0b43,

        /// <summary>
        /// Original was GL_CULL_FACE = 0x0B44
        /// </summary>
        CullFace = 0x0b44,

        /// <summary>
        /// Original was GL_CULL_FACE_MODE = 0x0B45
        /// </summary>
        CullFaceMode = 0x0b45,

        /// <summary>
        /// Original was GL_FRONT_FACE = 0x0B46
        /// </summary>
        FrontFace = 0x0b46,

        /// <summary>
        /// Original was GL_LIGHTING = 0x0B50
        /// </summary>
        Lighting = 0x0b50,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51
        /// </summary>
        LightModelLocalViewer = 0x0b51,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_TWO_SIDE = 0x0B52
        /// </summary>
        LightModelTwoSide = 0x0b52,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_AMBIENT = 0x0B53
        /// </summary>
        LightModelAmbient = 0x0b53,

        /// <summary>
        /// Original was GL_SHADE_MODEL = 0x0B54
        /// </summary>
        ShadeModel = 0x0b54,

        /// <summary>
        /// Original was GL_COLOR_MATERIAL_FACE = 0x0B55
        /// </summary>
        ColorMaterialFace = 0x0b55,

        /// <summary>
        /// Original was GL_COLOR_MATERIAL_PARAMETER = 0x0B56
        /// </summary>
        ColorMaterialParameter = 0x0b56,

        /// <summary>
        /// Original was GL_COLOR_MATERIAL = 0x0B57
        /// </summary>
        ColorMaterial = 0x0b57,

        /// <summary>
        /// Original was GL_FOG = 0x0B60
        /// </summary>
        Fog = 0x0b60,

        /// <summary>
        /// Original was GL_FOG_INDEX = 0x0B61
        /// </summary>
        FogIndex = 0x0b61,

        /// <summary>
        /// Original was GL_FOG_DENSITY = 0x0B62
        /// </summary>
        FogDensity = 0x0b62,

        /// <summary>
        /// Original was GL_FOG_START = 0x0B63
        /// </summary>
        FogStart = 0x0b63,

        /// <summary>
        /// Original was GL_FOG_END = 0x0B64
        /// </summary>
        FogEnd = 0x0b64,

        /// <summary>
        /// Original was GL_FOG_MODE = 0x0B65
        /// </summary>
        FogMode = 0x0b65,

        /// <summary>
        /// Original was GL_FOG_COLOR = 0x0B66
        /// </summary>
        FogColor = 0x0b66,

        /// <summary>
        /// Original was GL_DEPTH_RANGE = 0x0B70
        /// </summary>
        DepthRange = 0x0b70,

        /// <summary>
        /// Original was GL_DEPTH_TEST = 0x0B71
        /// </summary>
        DepthTest = 0x0b71,

        /// <summary>
        /// Original was GL_DEPTH_WRITEMASK = 0x0B72
        /// </summary>
        DepthWritemask = 0x0b72,

        /// <summary>
        /// Original was GL_DEPTH_CLEAR_VALUE = 0x0B73
        /// </summary>
        DepthClearValue = 0x0b73,

        /// <summary>
        /// Original was GL_DEPTH_FUNC = 0x0B74
        /// </summary>
        DepthFunc = 0x0b74,

        /// <summary>
        /// Original was GL_ACCUM_CLEAR_VALUE = 0x0B80
        /// </summary>
        AccumClearValue = 0x0b80,

        /// <summary>
        /// Original was GL_STENCIL_TEST = 0x0B90
        /// </summary>
        StencilTest = 0x0b90,

        /// <summary>
        /// Original was GL_STENCIL_CLEAR_VALUE = 0x0B91
        /// </summary>
        StencilClearValue = 0x0b91,

        /// <summary>
        /// Original was GL_STENCIL_FUNC = 0x0B92
        /// </summary>
        StencilFunc = 0x0b92,

        /// <summary>
        /// Original was GL_STENCIL_VALUE_MASK = 0x0B93
        /// </summary>
        StencilValueMask = 0x0b93,

        /// <summary>
        /// Original was GL_STENCIL_FAIL = 0x0B94
        /// </summary>
        StencilFail = 0x0b94,

        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95
        /// </summary>
        StencilPassDepthFail = 0x0b95,

        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_PASS = 0x0B96
        /// </summary>
        StencilPassDepthPass = 0x0b96,

        /// <summary>
        /// Original was GL_STENCIL_REF = 0x0B97
        /// </summary>
        StencilRef = 0x0b97,

        /// <summary>
        /// Original was GL_STENCIL_WRITEMASK = 0x0B98
        /// </summary>
        StencilWritemask = 0x0b98,

        /// <summary>
        /// Original was GL_MATRIX_MODE = 0x0BA0
        /// </summary>
        MatrixMode = 0x0ba0,

        /// <summary>
        /// Original was GL_NORMALIZE = 0x0BA1
        /// </summary>
        Normalize = 0x0ba1,

        /// <summary>
        /// Original was GL_VIEWPORT = 0x0BA2
        /// </summary>
        Viewport = 0x0ba2,

        /// <summary>
        /// Original was GL_MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3
        /// </summary>
        Modelview0StackDepthExt = 0x0ba3,

        /// <summary>
        /// Original was GL_MODELVIEW_STACK_DEPTH = 0x0BA3
        /// </summary>
        ModelviewStackDepth = 0x0ba3,

        /// <summary>
        /// Original was GL_PROJECTION_STACK_DEPTH = 0x0BA4
        /// </summary>
        ProjectionStackDepth = 0x0ba4,

        /// <summary>
        /// Original was GL_TEXTURE_STACK_DEPTH = 0x0BA5
        /// </summary>
        TextureStackDepth = 0x0ba5,

        /// <summary>
        /// Original was GL_MODELVIEW0_MATRIX_EXT = 0x0BA6
        /// </summary>
        Modelview0MatrixExt = 0x0ba6,

        /// <summary>
        /// Original was GL_MODELVIEW_MATRIX = 0x0BA6
        /// </summary>
        ModelviewMatrix = 0x0ba6,

        /// <summary>
        /// Original was GL_PROJECTION_MATRIX = 0x0BA7
        /// </summary>
        ProjectionMatrix = 0x0ba7,

        /// <summary>
        /// Original was GL_TEXTURE_MATRIX = 0x0BA8
        /// </summary>
        TextureMatrix = 0x0ba8,

        /// <summary>
        /// Original was GL_ATTRIB_STACK_DEPTH = 0x0BB0
        /// </summary>
        AttribStackDepth = 0x0bb0,

        /// <summary>
        /// Original was GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1
        /// </summary>
        ClientAttribStackDepth = 0x0bb1,

        /// <summary>
        /// Original was GL_ALPHA_TEST = 0x0BC0
        /// </summary>
        AlphaTest = 0x0bc0,

        /// <summary>
        /// Original was GL_ALPHA_TEST_QCOM = 0x0BC0
        /// </summary>
        AlphaTestQcom = 0x0bc0,

        /// <summary>
        /// Original was GL_ALPHA_TEST_FUNC = 0x0BC1
        /// </summary>
        AlphaTestFunc = 0x0bc1,

        /// <summary>
        /// Original was GL_ALPHA_TEST_FUNC_QCOM = 0x0BC1
        /// </summary>
        AlphaTestFuncQcom = 0x0bc1,

        /// <summary>
        /// Original was GL_ALPHA_TEST_REF = 0x0BC2
        /// </summary>
        AlphaTestRef = 0x0bc2,

        /// <summary>
        /// Original was GL_ALPHA_TEST_REF_QCOM = 0x0BC2
        /// </summary>
        AlphaTestRefQcom = 0x0bc2,

        /// <summary>
        /// Original was GL_DITHER = 0x0BD0
        /// </summary>
        Dither = 0x0bd0,

        /// <summary>
        /// Original was GL_BLEND_DST = 0x0BE0
        /// </summary>
        BlendDst = 0x0be0,

        /// <summary>
        /// Original was GL_BLEND_SRC = 0x0BE1
        /// </summary>
        BlendSrc = 0x0be1,

        /// <summary>
        /// Original was GL_BLEND = 0x0BE2
        /// </summary>
        Blend = 0x0be2,

        /// <summary>
        /// Original was GL_LOGIC_OP_MODE = 0x0BF0
        /// </summary>
        LogicOpMode = 0x0bf0,

        /// <summary>
        /// Original was GL_INDEX_LOGIC_OP = 0x0BF1
        /// </summary>
        IndexLogicOp = 0x0bf1,

        /// <summary>
        /// Original was GL_LOGIC_OP = 0x0BF1
        /// </summary>
        LogicOp = 0x0bf1,

        /// <summary>
        /// Original was GL_COLOR_LOGIC_OP = 0x0BF2
        /// </summary>
        ColorLogicOp = 0x0bf2,

        /// <summary>
        /// Original was GL_AUX_BUFFERS = 0x0C00
        /// </summary>
        AuxBuffers = 0x0c00,

        /// <summary>
        /// Original was GL_DRAW_BUFFER = 0x0C01
        /// </summary>
        DrawBuffer = 0x0c01,

        /// <summary>
        /// Original was GL_DRAW_BUFFER_EXT = 0x0C01
        /// </summary>
        DrawBufferExt = 0x0c01,

        /// <summary>
        /// Original was GL_READ_BUFFER = 0x0C02
        /// </summary>
        ReadBuffer = 0x0c02,

        /// <summary>
        /// Original was GL_READ_BUFFER_EXT = 0x0C02
        /// </summary>
        ReadBufferExt = 0x0c02,

        /// <summary>
        /// Original was GL_READ_BUFFER_NV = 0x0C02
        /// </summary>
        ReadBufferNv = 0x0c02,

        /// <summary>
        /// Original was GL_SCISSOR_BOX = 0x0C10
        /// </summary>
        ScissorBox = 0x0c10,

        /// <summary>
        /// Original was GL_SCISSOR_TEST = 0x0C11
        /// </summary>
        ScissorTest = 0x0c11,

        /// <summary>
        /// Original was GL_INDEX_CLEAR_VALUE = 0x0C20
        /// </summary>
        IndexClearValue = 0x0c20,

        /// <summary>
        /// Original was GL_INDEX_WRITEMASK = 0x0C21
        /// </summary>
        IndexWritemask = 0x0c21,

        /// <summary>
        /// Original was GL_COLOR_CLEAR_VALUE = 0x0C22
        /// </summary>
        ColorClearValue = 0x0c22,

        /// <summary>
        /// Original was GL_COLOR_WRITEMASK = 0x0C23
        /// </summary>
        ColorWritemask = 0x0c23,

        /// <summary>
        /// Original was GL_INDEX_MODE = 0x0C30
        /// </summary>
        IndexMode = 0x0c30,

        /// <summary>
        /// Original was GL_RGBA_MODE = 0x0C31
        /// </summary>
        RgbaMode = 0x0c31,

        /// <summary>
        /// Original was GL_DOUBLEBUFFER = 0x0C32
        /// </summary>
        Doublebuffer = 0x0c32,

        /// <summary>
        /// Original was GL_STEREO = 0x0C33
        /// </summary>
        Stereo = 0x0c33,

        /// <summary>
        /// Original was GL_RENDER_MODE = 0x0C40
        /// </summary>
        RenderMode = 0x0c40,

        /// <summary>
        /// Original was GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50
        /// </summary>
        PerspectiveCorrectionHint = 0x0c50,

        /// <summary>
        /// Original was GL_POINT_SMOOTH_HINT = 0x0C51
        /// </summary>
        PointSmoothHint = 0x0c51,

        /// <summary>
        /// Original was GL_LINE_SMOOTH_HINT = 0x0C52
        /// </summary>
        LineSmoothHint = 0x0c52,

        /// <summary>
        /// Original was GL_POLYGON_SMOOTH_HINT = 0x0C53
        /// </summary>
        PolygonSmoothHint = 0x0c53,

        /// <summary>
        /// Original was GL_FOG_HINT = 0x0C54
        /// </summary>
        FogHint = 0x0c54,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_S = 0x0C60
        /// </summary>
        TextureGenS = 0x0c60,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_T = 0x0C61
        /// </summary>
        TextureGenT = 0x0c61,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_R = 0x0C62
        /// </summary>
        TextureGenR = 0x0c62,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_Q = 0x0C63
        /// </summary>
        TextureGenQ = 0x0c63,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0
        /// </summary>
        PixelMapIToISize = 0x0cb0,

        /// <summary>
        /// Original was GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1
        /// </summary>
        PixelMapSToSSize = 0x0cb1,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2
        /// </summary>
        PixelMapIToRSize = 0x0cb2,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3
        /// </summary>
        PixelMapIToGSize = 0x0cb3,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4
        /// </summary>
        PixelMapIToBSize = 0x0cb4,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5
        /// </summary>
        PixelMapIToASize = 0x0cb5,

        /// <summary>
        /// Original was GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6
        /// </summary>
        PixelMapRToRSize = 0x0cb6,

        /// <summary>
        /// Original was GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7
        /// </summary>
        PixelMapGToGSize = 0x0cb7,

        /// <summary>
        /// Original was GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8
        /// </summary>
        PixelMapBToBSize = 0x0cb8,

        /// <summary>
        /// Original was GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9
        /// </summary>
        PixelMapAToASize = 0x0cb9,

        /// <summary>
        /// Original was GL_UNPACK_SWAP_BYTES = 0x0CF0
        /// </summary>
        UnpackSwapBytes = 0x0cf0,

        /// <summary>
        /// Original was GL_UNPACK_LSB_FIRST = 0x0CF1
        /// </summary>
        UnpackLsbFirst = 0x0cf1,

        /// <summary>
        /// Original was GL_UNPACK_ROW_LENGTH = 0x0CF2
        /// </summary>
        UnpackRowLength = 0x0cf2,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_ROWS = 0x0CF3
        /// </summary>
        UnpackSkipRows = 0x0cf3,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_PIXELS = 0x0CF4
        /// </summary>
        UnpackSkipPixels = 0x0cf4,

        /// <summary>
        /// Original was GL_UNPACK_ALIGNMENT = 0x0CF5
        /// </summary>
        UnpackAlignment = 0x0cf5,

        /// <summary>
        /// Original was GL_PACK_SWAP_BYTES = 0x0D00
        /// </summary>
        PackSwapBytes = 0x0d00,

        /// <summary>
        /// Original was GL_PACK_LSB_FIRST = 0x0D01
        /// </summary>
        PackLsbFirst = 0x0d01,

        /// <summary>
        /// Original was GL_PACK_ROW_LENGTH = 0x0D02
        /// </summary>
        PackRowLength = 0x0d02,

        /// <summary>
        /// Original was GL_PACK_SKIP_ROWS = 0x0D03
        /// </summary>
        PackSkipRows = 0x0d03,

        /// <summary>
        /// Original was GL_PACK_SKIP_PIXELS = 0x0D04
        /// </summary>
        PackSkipPixels = 0x0d04,

        /// <summary>
        /// Original was GL_PACK_ALIGNMENT = 0x0D05
        /// </summary>
        PackAlignment = 0x0d05,

        /// <summary>
        /// Original was GL_MAP_COLOR = 0x0D10
        /// </summary>
        MapColor = 0x0d10,

        /// <summary>
        /// Original was GL_MAP_STENCIL = 0x0D11
        /// </summary>
        MapStencil = 0x0d11,

        /// <summary>
        /// Original was GL_INDEX_SHIFT = 0x0D12
        /// </summary>
        IndexShift = 0x0d12,

        /// <summary>
        /// Original was GL_INDEX_OFFSET = 0x0D13
        /// </summary>
        IndexOffset = 0x0d13,

        /// <summary>
        /// Original was GL_RED_SCALE = 0x0D14
        /// </summary>
        RedScale = 0x0d14,

        /// <summary>
        /// Original was GL_RED_BIAS = 0x0D15
        /// </summary>
        RedBias = 0x0d15,

        /// <summary>
        /// Original was GL_ZOOM_X = 0x0D16
        /// </summary>
        ZoomX = 0x0d16,

        /// <summary>
        /// Original was GL_ZOOM_Y = 0x0D17
        /// </summary>
        ZoomY = 0x0d17,

        /// <summary>
        /// Original was GL_GREEN_SCALE = 0x0D18
        /// </summary>
        GreenScale = 0x0d18,

        /// <summary>
        /// Original was GL_GREEN_BIAS = 0x0D19
        /// </summary>
        GreenBias = 0x0d19,

        /// <summary>
        /// Original was GL_BLUE_SCALE = 0x0D1A
        /// </summary>
        BlueScale = 0x0d1a,

        /// <summary>
        /// Original was GL_BLUE_BIAS = 0x0D1B
        /// </summary>
        BlueBias = 0x0d1b,

        /// <summary>
        /// Original was GL_ALPHA_SCALE = 0x0D1C
        /// </summary>
        AlphaScale = 0x0d1c,

        /// <summary>
        /// Original was GL_ALPHA_BIAS = 0x0D1D
        /// </summary>
        AlphaBias = 0x0d1d,

        /// <summary>
        /// Original was GL_DEPTH_SCALE = 0x0D1E
        /// </summary>
        DepthScale = 0x0d1e,

        /// <summary>
        /// Original was GL_DEPTH_BIAS = 0x0D1F
        /// </summary>
        DepthBias = 0x0d1f,

        /// <summary>
        /// Original was GL_MAX_EVAL_ORDER = 0x0D30
        /// </summary>
        MaxEvalOrder = 0x0d30,

        /// <summary>
        /// Original was GL_MAX_LIGHTS = 0x0D31
        /// </summary>
        MaxLights = 0x0d31,

        /// <summary>
        /// Original was GL_MAX_CLIP_DISTANCES = 0x0D32
        /// </summary>
        MaxClipDistances = 0x0d32,

        /// <summary>
        /// Original was GL_MAX_CLIP_PLANES = 0x0D32
        /// </summary>
        MaxClipPlanes = 0x0d32,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_SIZE = 0x0D33
        /// </summary>
        MaxTextureSize = 0x0d33,

        /// <summary>
        /// Original was GL_MAX_PIXEL_MAP_TABLE = 0x0D34
        /// </summary>
        MaxPixelMapTable = 0x0d34,

        /// <summary>
        /// Original was GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35
        /// </summary>
        MaxAttribStackDepth = 0x0d35,

        /// <summary>
        /// Original was GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36
        /// </summary>
        MaxModelviewStackDepth = 0x0d36,

        /// <summary>
        /// Original was GL_MAX_NAME_STACK_DEPTH = 0x0D37
        /// </summary>
        MaxNameStackDepth = 0x0d37,

        /// <summary>
        /// Original was GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38
        /// </summary>
        MaxProjectionStackDepth = 0x0d38,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39
        /// </summary>
        MaxTextureStackDepth = 0x0d39,

        /// <summary>
        /// Original was GL_MAX_VIEWPORT_DIMS = 0x0D3A
        /// </summary>
        MaxViewportDims = 0x0d3a,

        /// <summary>
        /// Original was GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B
        /// </summary>
        MaxClientAttribStackDepth = 0x0d3b,

        /// <summary>
        /// Original was GL_SUBPIXEL_BITS = 0x0D50
        /// </summary>
        SubpixelBits = 0x0d50,

        /// <summary>
        /// Original was GL_INDEX_BITS = 0x0D51
        /// </summary>
        IndexBits = 0x0d51,

        /// <summary>
        /// Original was GL_RED_BITS = 0x0D52
        /// </summary>
        RedBits = 0x0d52,

        /// <summary>
        /// Original was GL_GREEN_BITS = 0x0D53
        /// </summary>
        GreenBits = 0x0d53,

        /// <summary>
        /// Original was GL_BLUE_BITS = 0x0D54
        /// </summary>
        BlueBits = 0x0d54,

        /// <summary>
        /// Original was GL_ALPHA_BITS = 0x0D55
        /// </summary>
        AlphaBits = 0x0d55,

        /// <summary>
        /// Original was GL_DEPTH_BITS = 0x0D56
        /// </summary>
        DepthBits = 0x0d56,

        /// <summary>
        /// Original was GL_STENCIL_BITS = 0x0D57
        /// </summary>
        StencilBits = 0x0d57,

        /// <summary>
        /// Original was GL_ACCUM_RED_BITS = 0x0D58
        /// </summary>
        AccumRedBits = 0x0d58,

        /// <summary>
        /// Original was GL_ACCUM_GREEN_BITS = 0x0D59
        /// </summary>
        AccumGreenBits = 0x0d59,

        /// <summary>
        /// Original was GL_ACCUM_BLUE_BITS = 0x0D5A
        /// </summary>
        AccumBlueBits = 0x0d5a,

        /// <summary>
        /// Original was GL_ACCUM_ALPHA_BITS = 0x0D5B
        /// </summary>
        AccumAlphaBits = 0x0d5b,

        /// <summary>
        /// Original was GL_NAME_STACK_DEPTH = 0x0D70
        /// </summary>
        NameStackDepth = 0x0d70,

        /// <summary>
        /// Original was GL_AUTO_NORMAL = 0x0D80
        /// </summary>
        AutoNormal = 0x0d80,

        /// <summary>
        /// Original was GL_MAP1_COLOR_4 = 0x0D90
        /// </summary>
        Map1Color4 = 0x0d90,

        /// <summary>
        /// Original was GL_MAP1_INDEX = 0x0D91
        /// </summary>
        Map1Index = 0x0d91,

        /// <summary>
        /// Original was GL_MAP1_NORMAL = 0x0D92
        /// </summary>
        Map1Normal = 0x0d92,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_1 = 0x0D93
        /// </summary>
        Map1TextureCoord1 = 0x0d93,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_2 = 0x0D94
        /// </summary>
        Map1TextureCoord2 = 0x0d94,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_3 = 0x0D95
        /// </summary>
        Map1TextureCoord3 = 0x0d95,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_4 = 0x0D96
        /// </summary>
        Map1TextureCoord4 = 0x0d96,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_3 = 0x0D97
        /// </summary>
        Map1Vertex3 = 0x0d97,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_4 = 0x0D98
        /// </summary>
        Map1Vertex4 = 0x0d98,

        /// <summary>
        /// Original was GL_MAP2_COLOR_4 = 0x0DB0
        /// </summary>
        Map2Color4 = 0x0db0,

        /// <summary>
        /// Original was GL_MAP2_INDEX = 0x0DB1
        /// </summary>
        Map2Index = 0x0db1,

        /// <summary>
        /// Original was GL_MAP2_NORMAL = 0x0DB2
        /// </summary>
        Map2Normal = 0x0db2,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_1 = 0x0DB3
        /// </summary>
        Map2TextureCoord1 = 0x0db3,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_2 = 0x0DB4
        /// </summary>
        Map2TextureCoord2 = 0x0db4,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_3 = 0x0DB5
        /// </summary>
        Map2TextureCoord3 = 0x0db5,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_4 = 0x0DB6
        /// </summary>
        Map2TextureCoord4 = 0x0db6,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_3 = 0x0DB7
        /// </summary>
        Map2Vertex3 = 0x0db7,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_4 = 0x0DB8
        /// </summary>
        Map2Vertex4 = 0x0db8,

        /// <summary>
        /// Original was GL_MAP1_GRID_DOMAIN = 0x0DD0
        /// </summary>
        Map1GridDomain = 0x0dd0,

        /// <summary>
        /// Original was GL_MAP1_GRID_SEGMENTS = 0x0DD1
        /// </summary>
        Map1GridSegments = 0x0dd1,

        /// <summary>
        /// Original was GL_MAP2_GRID_DOMAIN = 0x0DD2
        /// </summary>
        Map2GridDomain = 0x0dd2,

        /// <summary>
        /// Original was GL_MAP2_GRID_SEGMENTS = 0x0DD3
        /// </summary>
        Map2GridSegments = 0x0dd3,

        /// <summary>
        /// Original was GL_TEXTURE_1D = 0x0DE0
        /// </summary>
        Texture1D = 0x0de0,

        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = 0x0de1,

        /// <summary>
        /// Original was GL_FEEDBACK_BUFFER_SIZE = 0x0DF1
        /// </summary>
        FeedbackBufferSize = 0x0df1,

        /// <summary>
        /// Original was GL_FEEDBACK_BUFFER_TYPE = 0x0DF2
        /// </summary>
        FeedbackBufferType = 0x0df2,

        /// <summary>
        /// Original was GL_SELECTION_BUFFER_SIZE = 0x0DF4
        /// </summary>
        SelectionBufferSize = 0x0df4,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_UNITS = 0x2A00
        /// </summary>
        PolygonOffsetUnits = 0x2a00,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_POINT = 0x2A01
        /// </summary>
        PolygonOffsetPoint = 0x2a01,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_LINE = 0x2A02
        /// </summary>
        PolygonOffsetLine = 0x2a02,

        /// <summary>
        /// Original was GL_CLIP_PLANE0 = 0x3000
        /// </summary>
        ClipPlane0 = 0x3000,

        /// <summary>
        /// Original was GL_CLIP_PLANE1 = 0x3001
        /// </summary>
        ClipPlane1 = 0x3001,

        /// <summary>
        /// Original was GL_CLIP_PLANE2 = 0x3002
        /// </summary>
        ClipPlane2 = 0x3002,

        /// <summary>
        /// Original was GL_CLIP_PLANE3 = 0x3003
        /// </summary>
        ClipPlane3 = 0x3003,

        /// <summary>
        /// Original was GL_CLIP_PLANE4 = 0x3004
        /// </summary>
        ClipPlane4 = 0x3004,

        /// <summary>
        /// Original was GL_CLIP_PLANE5 = 0x3005
        /// </summary>
        ClipPlane5 = 0x3005,

        /// <summary>
        /// Original was GL_LIGHT0 = 0x4000
        /// </summary>
        Light0 = 0x4000,

        /// <summary>
        /// Original was GL_LIGHT1 = 0x4001
        /// </summary>
        Light1 = 0x4001,

        /// <summary>
        /// Original was GL_LIGHT2 = 0x4002
        /// </summary>
        Light2 = 0x4002,

        /// <summary>
        /// Original was GL_LIGHT3 = 0x4003
        /// </summary>
        Light3 = 0x4003,

        /// <summary>
        /// Original was GL_LIGHT4 = 0x4004
        /// </summary>
        Light4 = 0x4004,

        /// <summary>
        /// Original was GL_LIGHT5 = 0x4005
        /// </summary>
        Light5 = 0x4005,

        /// <summary>
        /// Original was GL_LIGHT6 = 0x4006
        /// </summary>
        Light6 = 0x4006,

        /// <summary>
        /// Original was GL_LIGHT7 = 0x4007
        /// </summary>
        Light7 = 0x4007,

        /// <summary>
        /// Original was GL_BLEND_COLOR_EXT = 0x8005
        /// </summary>
        BlendColorExt = 0x8005,

        /// <summary>
        /// Original was GL_BLEND_EQUATION_EXT = 0x8009
        /// </summary>
        BlendEquationExt = 0x8009,

        /// <summary>
        /// Original was GL_PACK_CMYK_HINT_EXT = 0x800E
        /// </summary>
        PackCmykHintExt = 0x800e,

        /// <summary>
        /// Original was GL_UNPACK_CMYK_HINT_EXT = 0x800F
        /// </summary>
        UnpackCmykHintExt = 0x800f,

        /// <summary>
        /// Original was GL_CONVOLUTION_1D_EXT = 0x8010
        /// </summary>
        Convolution1DExt = 0x8010,

        /// <summary>
        /// Original was GL_CONVOLUTION_2D_EXT = 0x8011
        /// </summary>
        Convolution2DExt = 0x8011,

        /// <summary>
        /// Original was GL_SEPARABLE_2D_EXT = 0x8012
        /// </summary>
        Separable2DExt = 0x8012,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C
        /// </summary>
        PostConvolutionRedScaleExt = 0x801c,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D
        /// </summary>
        PostConvolutionGreenScaleExt = 0x801d,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E
        /// </summary>
        PostConvolutionBlueScaleExt = 0x801e,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F
        /// </summary>
        PostConvolutionAlphaScaleExt = 0x801f,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_BIAS_EXT = 0x8020
        /// </summary>
        PostConvolutionRedBiasExt = 0x8020,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021
        /// </summary>
        PostConvolutionGreenBiasExt = 0x8021,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022
        /// </summary>
        PostConvolutionBlueBiasExt = 0x8022,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023
        /// </summary>
        PostConvolutionAlphaBiasExt = 0x8023,

        /// <summary>
        /// Original was GL_HISTOGRAM_EXT = 0x8024
        /// </summary>
        HistogramExt = 0x8024,

        /// <summary>
        /// Original was GL_MINMAX_EXT = 0x802E
        /// </summary>
        MinmaxExt = 0x802e,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FILL = 0x8037
        /// </summary>
        PolygonOffsetFill = 0x8037,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FACTOR = 0x8038
        /// </summary>
        PolygonOffsetFactor = 0x8038,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_BIAS_EXT = 0x8039
        /// </summary>
        PolygonOffsetBiasExt = 0x8039,

        /// <summary>
        /// Original was GL_RESCALE_NORMAL_EXT = 0x803A
        /// </summary>
        RescaleNormalExt = 0x803a,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_1D = 0x8068
        /// </summary>
        TextureBinding1D = 0x8068,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D = 0x8069
        /// </summary>
        TextureBinding2D = 0x8069,

        /// <summary>
        /// Original was GL_TEXTURE_3D_BINDING_EXT = 0x806A
        /// </summary>
        Texture3DBindingExt = 0x806a,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_3D = 0x806A
        /// </summary>
        TextureBinding3D = 0x806a,

        /// <summary>
        /// Original was GL_PACK_SKIP_IMAGES_EXT = 0x806B
        /// </summary>
        PackSkipImagesExt = 0x806b,

        /// <summary>
        /// Original was GL_PACK_IMAGE_HEIGHT_EXT = 0x806C
        /// </summary>
        PackImageHeightExt = 0x806c,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_IMAGES_EXT = 0x806D
        /// </summary>
        UnpackSkipImagesExt = 0x806d,

        /// <summary>
        /// Original was GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E
        /// </summary>
        UnpackImageHeightExt = 0x806e,

        /// <summary>
        /// Original was GL_TEXTURE_3D_EXT = 0x806F
        /// </summary>
        Texture3DExt = 0x806f,

        /// <summary>
        /// Original was GL_MAX_3D_TEXTURE_SIZE_EXT = 0x8073
        /// </summary>
        Max3DTextureSizeExt = 0x8073,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = 0x8074,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY = 0x8075
        /// </summary>
        NormalArray = 0x8075,

        /// <summary>
        /// Original was GL_COLOR_ARRAY = 0x8076
        /// </summary>
        ColorArray = 0x8076,

        /// <summary>
        /// Original was GL_INDEX_ARRAY = 0x8077
        /// </summary>
        IndexArray = 0x8077,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY = 0x8078
        /// </summary>
        TextureCoordArray = 0x8078,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY = 0x8079
        /// </summary>
        EdgeFlagArray = 0x8079,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_SIZE = 0x807A
        /// </summary>
        VertexArraySize = 0x807a,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_TYPE = 0x807B
        /// </summary>
        VertexArrayType = 0x807b,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_STRIDE = 0x807C
        /// </summary>
        VertexArrayStride = 0x807c,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_COUNT_EXT = 0x807D
        /// </summary>
        VertexArrayCountExt = 0x807d,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_TYPE = 0x807E
        /// </summary>
        NormalArrayType = 0x807e,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_STRIDE = 0x807F
        /// </summary>
        NormalArrayStride = 0x807f,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_COUNT_EXT = 0x8080
        /// </summary>
        NormalArrayCountExt = 0x8080,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_SIZE = 0x8081
        /// </summary>
        ColorArraySize = 0x8081,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_TYPE = 0x8082
        /// </summary>
        ColorArrayType = 0x8082,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_STRIDE = 0x8083
        /// </summary>
        ColorArrayStride = 0x8083,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_COUNT_EXT = 0x8084
        /// </summary>
        ColorArrayCountExt = 0x8084,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_TYPE = 0x8085
        /// </summary>
        IndexArrayType = 0x8085,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_STRIDE = 0x8086
        /// </summary>
        IndexArrayStride = 0x8086,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_COUNT_EXT = 0x8087
        /// </summary>
        IndexArrayCountExt = 0x8087,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088
        /// </summary>
        TextureCoordArraySize = 0x8088,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089
        /// </summary>
        TextureCoordArrayType = 0x8089,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A
        /// </summary>
        TextureCoordArrayStride = 0x808a,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B
        /// </summary>
        TextureCoordArrayCountExt = 0x808b,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C
        /// </summary>
        EdgeFlagArrayStride = 0x808c,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D
        /// </summary>
        EdgeFlagArrayCountExt = 0x808d,

        /// <summary>
        /// Original was GL_INTERLACE_SGIX = 0x8094
        /// </summary>
        InterlaceSgix = 0x8094,

        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096
        /// </summary>
        DetailTexture2DBindingSgis = 0x8096,

        /// <summary>
        /// Original was GL_MULTISAMPLE_SGIS = 0x809D
        /// </summary>
        MultisampleSgis = 0x809d,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E
        /// </summary>
        SampleAlphaToMaskSgis = 0x809e,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F
        /// </summary>
        SampleAlphaToOneSgis = 0x809f,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_SGIS = 0x80A0
        /// </summary>
        SampleMaskSgis = 0x80a0,

        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS_SGIS = 0x80A8
        /// </summary>
        SampleBuffersSgis = 0x80a8,

        /// <summary>
        /// Original was GL_SAMPLES_SGIS = 0x80A9
        /// </summary>
        SamplesSgis = 0x80a9,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_VALUE_SGIS = 0x80AA
        /// </summary>
        SampleMaskValueSgis = 0x80aa,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_INVERT_SGIS = 0x80AB
        /// </summary>
        SampleMaskInvertSgis = 0x80ab,

        /// <summary>
        /// Original was GL_SAMPLE_PATTERN_SGIS = 0x80AC
        /// </summary>
        SamplePatternSgis = 0x80ac,

        /// <summary>
        /// Original was GL_COLOR_MATRIX_SGI = 0x80B1
        /// </summary>
        ColorMatrixSgi = 0x80b1,

        /// <summary>
        /// Original was GL_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2
        /// </summary>
        ColorMatrixStackDepthSgi = 0x80b2,

        /// <summary>
        /// Original was GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3
        /// </summary>
        MaxColorMatrixStackDepthSgi = 0x80b3,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4
        /// </summary>
        PostColorMatrixRedScaleSgi = 0x80b4,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5
        /// </summary>
        PostColorMatrixGreenScaleSgi = 0x80b5,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6
        /// </summary>
        PostColorMatrixBlueScaleSgi = 0x80b6,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7
        /// </summary>
        PostColorMatrixAlphaScaleSgi = 0x80b7,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8
        /// </summary>
        PostColorMatrixRedBiasSgi = 0x80b8,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9
        /// </summary>
        PostColorMatrixGreenBiasSgi = 0x80b9,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA
        /// </summary>
        PostColorMatrixBlueBiasSgi = 0x80ba,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB
        /// </summary>
        PostColorMatrixAlphaBiasSgi = 0x80bb,

        /// <summary>
        /// Original was GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
        /// </summary>
        TextureColorTableSgi = 0x80bc,

        /// <summary>
        /// Original was GL_COLOR_TABLE_SGI = 0x80D0
        /// </summary>
        ColorTableSgi = 0x80d0,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
        /// </summary>
        PostConvolutionColorTableSgi = 0x80d1,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
        /// </summary>
        PostColorMatrixColorTableSgi = 0x80d2,

        /// <summary>
        /// Original was GL_POINT_SIZE_MIN_SGIS = 0x8126
        /// </summary>
        PointSizeMinSgis = 0x8126,

        /// <summary>
        /// Original was GL_POINT_SIZE_MAX_SGIS = 0x8127
        /// </summary>
        PointSizeMaxSgis = 0x8127,

        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128
        /// </summary>
        PointFadeThresholdSizeSgis = 0x8128,

        /// <summary>
        /// Original was GL_DISTANCE_ATTENUATION_SGIS = 0x8129
        /// </summary>
        DistanceAttenuationSgis = 0x8129,

        /// <summary>
        /// Original was GL_FOG_FUNC_POINTS_SGIS = 0x812B
        /// </summary>
        FogFuncPointsSgis = 0x812b,

        /// <summary>
        /// Original was GL_MAX_FOG_FUNC_POINTS_SGIS = 0x812C
        /// </summary>
        MaxFogFuncPointsSgis = 0x812c,

        /// <summary>
        /// Original was GL_PACK_SKIP_VOLUMES_SGIS = 0x8130
        /// </summary>
        PackSkipVolumesSgis = 0x8130,

        /// <summary>
        /// Original was GL_PACK_IMAGE_DEPTH_SGIS = 0x8131
        /// </summary>
        PackImageDepthSgis = 0x8131,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_VOLUMES_SGIS = 0x8132
        /// </summary>
        UnpackSkipVolumesSgis = 0x8132,

        /// <summary>
        /// Original was GL_UNPACK_IMAGE_DEPTH_SGIS = 0x8133
        /// </summary>
        UnpackImageDepthSgis = 0x8133,

        /// <summary>
        /// Original was GL_TEXTURE_4D_SGIS = 0x8134
        /// </summary>
        Texture4DSgis = 0x8134,

        /// <summary>
        /// Original was GL_MAX_4D_TEXTURE_SIZE_SGIS = 0x8138
        /// </summary>
        Max4DTextureSizeSgis = 0x8138,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_SGIX = 0x8139
        /// </summary>
        PixelTexGenSgix = 0x8139,

        /// <summary>
        /// Original was GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E
        /// </summary>
        PixelTileBestAlignmentSgix = 0x813e,

        /// <summary>
        /// Original was GL_PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F
        /// </summary>
        PixelTileCacheIncrementSgix = 0x813f,

        /// <summary>
        /// Original was GL_PIXEL_TILE_WIDTH_SGIX = 0x8140
        /// </summary>
        PixelTileWidthSgix = 0x8140,

        /// <summary>
        /// Original was GL_PIXEL_TILE_HEIGHT_SGIX = 0x8141
        /// </summary>
        PixelTileHeightSgix = 0x8141,

        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142
        /// </summary>
        PixelTileGridWidthSgix = 0x8142,

        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143
        /// </summary>
        PixelTileGridHeightSgix = 0x8143,

        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144
        /// </summary>
        PixelTileGridDepthSgix = 0x8144,

        /// <summary>
        /// Original was GL_PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145
        /// </summary>
        PixelTileCacheSizeSgix = 0x8145,

        /// <summary>
        /// Original was GL_SPRITE_SGIX = 0x8148
        /// </summary>
        SpriteSgix = 0x8148,

        /// <summary>
        /// Original was GL_SPRITE_MODE_SGIX = 0x8149
        /// </summary>
        SpriteModeSgix = 0x8149,

        /// <summary>
        /// Original was GL_SPRITE_AXIS_SGIX = 0x814A
        /// </summary>
        SpriteAxisSgix = 0x814a,

        /// <summary>
        /// Original was GL_SPRITE_TRANSLATION_SGIX = 0x814B
        /// </summary>
        SpriteTranslationSgix = 0x814b,

        /// <summary>
        /// Original was GL_TEXTURE_4D_BINDING_SGIS = 0x814F
        /// </summary>
        Texture4DBindingSgis = 0x814f,

        /// <summary>
        /// Original was GL_MAX_CLIPMAP_DEPTH_SGIX = 0x8177
        /// </summary>
        MaxClipmapDepthSgix = 0x8177,

        /// <summary>
        /// Original was GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178
        /// </summary>
        MaxClipmapVirtualDepthSgix = 0x8178,

        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B
        /// </summary>
        PostTextureFilterBiasRangeSgix = 0x817b,

        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C
        /// </summary>
        PostTextureFilterScaleRangeSgix = 0x817c,

        /// <summary>
        /// Original was GL_REFERENCE_PLANE_SGIX = 0x817D
        /// </summary>
        ReferencePlaneSgix = 0x817d,

        /// <summary>
        /// Original was GL_REFERENCE_PLANE_EQUATION_SGIX = 0x817E
        /// </summary>
        ReferencePlaneEquationSgix = 0x817e,

        /// <summary>
        /// Original was GL_IR_INSTRUMENT1_SGIX = 0x817F
        /// </summary>
        IrInstrument1Sgix = 0x817f,

        /// <summary>
        /// Original was GL_INSTRUMENT_MEASUREMENTS_SGIX = 0x8181
        /// </summary>
        InstrumentMeasurementsSgix = 0x8181,

        /// <summary>
        /// Original was GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183
        /// </summary>
        CalligraphicFragmentSgix = 0x8183,

        /// <summary>
        /// Original was GL_FRAMEZOOM_SGIX = 0x818B
        /// </summary>
        FramezoomSgix = 0x818b,

        /// <summary>
        /// Original was GL_FRAMEZOOM_FACTOR_SGIX = 0x818C
        /// </summary>
        FramezoomFactorSgix = 0x818c,

        /// <summary>
        /// Original was GL_MAX_FRAMEZOOM_FACTOR_SGIX = 0x818D
        /// </summary>
        MaxFramezoomFactorSgix = 0x818d,

        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192
        /// </summary>
        GenerateMipmapHintSgis = 0x8192,

        /// <summary>
        /// Original was GL_DEFORMATIONS_MASK_SGIX = 0x8196
        /// </summary>
        DeformationsMaskSgix = 0x8196,

        /// <summary>
        /// Original was GL_FOG_OFFSET_SGIX = 0x8198
        /// </summary>
        FogOffsetSgix = 0x8198,

        /// <summary>
        /// Original was GL_FOG_OFFSET_VALUE_SGIX = 0x8199
        /// </summary>
        FogOffsetValueSgix = 0x8199,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8
        /// </summary>
        LightModelColorControl = 0x81f8,

        /// <summary>
        /// Original was GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB
        /// </summary>
        SharedTexturePaletteExt = 0x81fb,

        /// <summary>
        /// Original was GL_CONVOLUTION_HINT_SGIX = 0x8316
        /// </summary>
        ConvolutionHintSgix = 0x8316,

        /// <summary>
        /// Original was GL_ASYNC_MARKER_SGIX = 0x8329
        /// </summary>
        AsyncMarkerSgix = 0x8329,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_MODE_SGIX = 0x832B
        /// </summary>
        PixelTexGenModeSgix = 0x832b,

        /// <summary>
        /// Original was GL_ASYNC_HISTOGRAM_SGIX = 0x832C
        /// </summary>
        AsyncHistogramSgix = 0x832c,

        /// <summary>
        /// Original was GL_MAX_ASYNC_HISTOGRAM_SGIX = 0x832D
        /// </summary>
        MaxAsyncHistogramSgix = 0x832d,

        /// <summary>
        /// Original was GL_PIXEL_TEXTURE_SGIS = 0x8353
        /// </summary>
        PixelTextureSgis = 0x8353,

        /// <summary>
        /// Original was GL_ASYNC_TEX_IMAGE_SGIX = 0x835C
        /// </summary>
        AsyncTexImageSgix = 0x835c,

        /// <summary>
        /// Original was GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D
        /// </summary>
        AsyncDrawPixelsSgix = 0x835d,

        /// <summary>
        /// Original was GL_ASYNC_READ_PIXELS_SGIX = 0x835E
        /// </summary>
        AsyncReadPixelsSgix = 0x835e,

        /// <summary>
        /// Original was GL_MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F
        /// </summary>
        MaxAsyncTexImageSgix = 0x835f,

        /// <summary>
        /// Original was GL_MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360
        /// </summary>
        MaxAsyncDrawPixelsSgix = 0x8360,

        /// <summary>
        /// Original was GL_MAX_ASYNC_READ_PIXELS_SGIX = 0x8361
        /// </summary>
        MaxAsyncReadPixelsSgix = 0x8361,

        /// <summary>
        /// Original was GL_VERTEX_PRECLIP_SGIX = 0x83EE
        /// </summary>
        VertexPreclipSgix = 0x83ee,

        /// <summary>
        /// Original was GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF
        /// </summary>
        VertexPreclipHintSgix = 0x83ef,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHTING_SGIX = 0x8400
        /// </summary>
        FragmentLightingSgix = 0x8400,

        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401
        /// </summary>
        FragmentColorMaterialSgix = 0x8401,

        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX = 0x8402
        /// </summary>
        FragmentColorMaterialFaceSgix = 0x8402,

        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = 0x8403
        /// </summary>
        FragmentColorMaterialParameterSgix = 0x8403,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_LIGHTS_SGIX = 0x8404
        /// </summary>
        MaxFragmentLightsSgix = 0x8404,

        /// <summary>
        /// Original was GL_MAX_ACTIVE_LIGHTS_SGIX = 0x8405
        /// </summary>
        MaxActiveLightsSgix = 0x8405,

        /// <summary>
        /// Original was GL_LIGHT_ENV_MODE_SGIX = 0x8407
        /// </summary>
        LightEnvModeSgix = 0x8407,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408
        /// </summary>
        FragmentLightModelLocalViewerSgix = 0x8408,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409
        /// </summary>
        FragmentLightModelTwoSideSgix = 0x8409,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A
        /// </summary>
        FragmentLightModelAmbientSgix = 0x840a,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B
        /// </summary>
        FragmentLightModelNormalInterpolationSgix = 0x840b,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT0_SGIX = 0x840C
        /// </summary>
        FragmentLight0Sgix = 0x840c,

        /// <summary>
        /// Original was GL_PACK_RESAMPLE_SGIX = 0x842E
        /// </summary>
        PackResampleSgix = 0x842e,

        /// <summary>
        /// Original was GL_UNPACK_RESAMPLE_SGIX = 0x842F
        /// </summary>
        UnpackResampleSgix = 0x842f,

        /// <summary>
        /// Original was GL_ALIASED_POINT_SIZE_RANGE = 0x846D
        /// </summary>
        AliasedPointSizeRange = 0x846d,

        /// <summary>
        /// Original was GL_ALIASED_LINE_WIDTH_RANGE = 0x846E
        /// </summary>
        AliasedLineWidthRange = 0x846e,

        /// <summary>
        /// Original was GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0
        /// </summary>
        PackSubsampleRateSgix = 0x85a0,

        /// <summary>
        /// Original was GL_UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1
        /// </summary>
        UnpackSubsampleRateSgix = 0x85a1,

        /// <summary>
        /// Original was GL_DEVICE_UUID_EXT = 0x9597
        /// </summary>
        DeviceUuidExt = 0x9597,

        /// <summary>
        /// Original was GL_DRIVER_UUID_EXT = 0x9598
        /// </summary>
        DriverUuidExt = 0x9598,

        /// <summary>
        /// Original was GL_DEVICE_LUID_EXT = 0x9599
        /// </summary>
        DeviceLuidExt = 0x9599,

        /// <summary>
        /// Original was GL_DEVICE_NODE_MASK_EXT = 0x959A
        /// </summary>
        DeviceNodeMaskExt = 0x959a,
    }

    /// <summary>
    /// Used in GL.GetPointer
    /// </summary>
    public enum GetPointervPName
    {
        /// <summary>
        /// Original was GL_FEEDBACK_BUFFER_POINTER = 0x0DF0
        /// </summary>
        FeedbackBufferPointer = 0x0df0,

        /// <summary>
        /// Original was GL_SELECTION_BUFFER_POINTER = 0x0DF3
        /// </summary>
        SelectionBufferPointer = 0x0df3,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_POINTER = 0x808E
        /// </summary>
        VertexArrayPointer = 0x808e,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_POINTER_EXT = 0x808E
        /// </summary>
        VertexArrayPointerExt = 0x808e,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_POINTER = 0x808F
        /// </summary>
        NormalArrayPointer = 0x808f,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_POINTER_EXT = 0x808F
        /// </summary>
        NormalArrayPointerExt = 0x808f,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_POINTER = 0x8090
        /// </summary>
        ColorArrayPointer = 0x8090,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_POINTER_EXT = 0x8090
        /// </summary>
        ColorArrayPointerExt = 0x8090,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_POINTER = 0x8091
        /// </summary>
        IndexArrayPointer = 0x8091,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_POINTER_EXT = 0x8091
        /// </summary>
        IndexArrayPointerExt = 0x8091,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092
        /// </summary>
        TextureCoordArrayPointer = 0x8092,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092
        /// </summary>
        TextureCoordArrayPointerExt = 0x8092,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_POINTER = 0x8093
        /// </summary>
        EdgeFlagArrayPointer = 0x8093,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_POINTER_EXT = 0x8093
        /// </summary>
        EdgeFlagArrayPointerExt = 0x8093,

        /// <summary>
        /// Original was GL_INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180
        /// </summary>
        InstrumentBufferPointerSgix = 0x8180,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_FUNCTION = 0x8244
        /// </summary>
        DebugCallbackFunction = 0x8244,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_USER_PARAM = 0x8245
        /// </summary>
        DebugCallbackUserParam = 0x8245,
    }

    /// <summary>
    /// Used in GL.GetTexParameter, GL.GetTexParameterx and 4 other functions
    /// </summary>
    public enum GetTextureParameter
    {
        /// <summary>
        /// Original was GL_TEXTURE_WIDTH = 0x1000
        /// </summary>
        TextureWidth = 0x1000,

        /// <summary>
        /// Original was GL_TEXTURE_HEIGHT = 0x1001
        /// </summary>
        TextureHeight = 0x1001,

        /// <summary>
        /// Original was GL_TEXTURE_COMPONENTS = 0x1003
        /// </summary>
        TextureComponents = 0x1003,

        /// <summary>
        /// Original was GL_TEXTURE_INTERNAL_FORMAT = 0x1003
        /// </summary>
        TextureInternalFormat = 0x1003,

        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR = 0x1004
        /// </summary>
        TextureBorderColor = 0x1004,

        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR_NV = 0x1004
        /// </summary>
        TextureBorderColorNv = 0x1004,

        /// <summary>
        /// Original was GL_TEXTURE_BORDER = 0x1005
        /// </summary>
        TextureBorder = 0x1005,

        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = 0x2800,

        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = 0x2801,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = 0x2802,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = 0x2803,

        /// <summary>
        /// Original was GL_TEXTURE_RED_SIZE = 0x805C
        /// </summary>
        TextureRedSize = 0x805c,

        /// <summary>
        /// Original was GL_TEXTURE_GREEN_SIZE = 0x805D
        /// </summary>
        TextureGreenSize = 0x805d,

        /// <summary>
        /// Original was GL_TEXTURE_BLUE_SIZE = 0x805E
        /// </summary>
        TextureBlueSize = 0x805e,

        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_SIZE = 0x805F
        /// </summary>
        TextureAlphaSize = 0x805f,

        /// <summary>
        /// Original was GL_TEXTURE_LUMINANCE_SIZE = 0x8060
        /// </summary>
        TextureLuminanceSize = 0x8060,

        /// <summary>
        /// Original was GL_TEXTURE_INTENSITY_SIZE = 0x8061
        /// </summary>
        TextureIntensitySize = 0x8061,

        /// <summary>
        /// Original was GL_TEXTURE_PRIORITY = 0x8066
        /// </summary>
        TexturePriority = 0x8066,

        /// <summary>
        /// Original was GL_TEXTURE_RESIDENT = 0x8067
        /// </summary>
        TextureResident = 0x8067,

        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_EXT = 0x8071
        /// </summary>
        TextureDepthExt = 0x8071,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R_EXT = 0x8072
        /// </summary>
        TextureWrapRExt = 0x8072,

        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_LEVEL_SGIS = 0x809A
        /// </summary>
        DetailTextureLevelSgis = 0x809a,

        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_MODE_SGIS = 0x809B
        /// </summary>
        DetailTextureModeSgis = 0x809b,

        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C
        /// </summary>
        DetailTextureFuncPointsSgis = 0x809c,

        /// <summary>
        /// Original was GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0
        /// </summary>
        SharpenTextureFuncPointsSgis = 0x80b0,

        /// <summary>
        /// Original was GL_SHADOW_AMBIENT_SGIX = 0x80BF
        /// </summary>
        ShadowAmbientSgix = 0x80bf,

        /// <summary>
        /// Original was GL_DUAL_TEXTURE_SELECT_SGIS = 0x8124
        /// </summary>
        DualTextureSelectSgis = 0x8124,

        /// <summary>
        /// Original was GL_QUAD_TEXTURE_SELECT_SGIS = 0x8125
        /// </summary>
        QuadTextureSelectSgis = 0x8125,

        /// <summary>
        /// Original was GL_TEXTURE_4DSIZE_SGIS = 0x8136
        /// </summary>
        Texture4DsizeSgis = 0x8136,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_Q_SGIS = 0x8137
        /// </summary>
        TextureWrapQSgis = 0x8137,

        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD_SGIS = 0x813A
        /// </summary>
        TextureMinLodSgis = 0x813a,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD_SGIS = 0x813B
        /// </summary>
        TextureMaxLodSgis = 0x813b,

        /// <summary>
        /// Original was GL_TEXTURE_BASE_LEVEL_SGIS = 0x813C
        /// </summary>
        TextureBaseLevelSgis = 0x813c,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL_SGIS = 0x813D
        /// </summary>
        TextureMaxLevelSgis = 0x813d,

        /// <summary>
        /// Original was GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147
        /// </summary>
        TextureFilter4SizeSgis = 0x8147,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171
        /// </summary>
        TextureClipmapCenterSgix = 0x8171,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172
        /// </summary>
        TextureClipmapFrameSgix = 0x8172,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173
        /// </summary>
        TextureClipmapOffsetSgix = 0x8173,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174
        /// </summary>
        TextureClipmapVirtualDepthSgix = 0x8174,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175
        /// </summary>
        TextureClipmapLodOffsetSgix = 0x8175,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176
        /// </summary>
        TextureClipmapDepthSgix = 0x8176,

        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179
        /// </summary>
        PostTextureFilterBiasSgix = 0x8179,

        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A
        /// </summary>
        PostTextureFilterScaleSgix = 0x817a,

        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_S_SGIX = 0x818E
        /// </summary>
        TextureLodBiasSSgix = 0x818e,

        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_T_SGIX = 0x818F
        /// </summary>
        TextureLodBiasTSgix = 0x818f,

        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_R_SGIX = 0x8190
        /// </summary>
        TextureLodBiasRSgix = 0x8190,

        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_SGIS = 0x8191
        /// </summary>
        GenerateMipmapSgis = 0x8191,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_SGIX = 0x819A
        /// </summary>
        TextureCompareSgix = 0x819a,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B
        /// </summary>
        TextureCompareOperatorSgix = 0x819b,

        /// <summary>
        /// Original was GL_TEXTURE_LEQUAL_R_SGIX = 0x819C
        /// </summary>
        TextureLequalRSgix = 0x819c,

        /// <summary>
        /// Original was GL_TEXTURE_GEQUAL_R_SGIX = 0x819D
        /// </summary>
        TextureGequalRSgix = 0x819d,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_S_SGIX = 0x8369
        /// </summary>
        TextureMaxClampSSgix = 0x8369,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_T_SGIX = 0x836A
        /// </summary>
        TextureMaxClampTSgix = 0x836a,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_R_SGIX = 0x836B
        /// </summary>
        TextureMaxClampRSgix = 0x836b,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GraphicsResetStatus
    {
        /// <summary>
        /// Original was GL_NO_ERROR = 0
        /// </summary>
        NoError = 0,

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
    }

    /// <summary>
    /// Used in GL.Hint
    /// </summary>
    public enum HintMode
    {
        /// <summary>
        /// Original was GL_DONT_CARE = 0x1100
        /// </summary>
        DontCare = 0x1100,

        /// <summary>
        /// Original was GL_FASTEST = 0x1101
        /// </summary>
        Fastest = 0x1101,

        /// <summary>
        /// Original was GL_NICEST = 0x1102
        /// </summary>
        Nicest = 0x1102,
    }

    /// <summary>
    /// Used in GL.Hint
    /// </summary>
    public enum HintTarget
    {
        /// <summary>
        /// Original was GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50
        /// </summary>
        PerspectiveCorrectionHint = 0x0c50,

        /// <summary>
        /// Original was GL_POINT_SMOOTH_HINT = 0x0C51
        /// </summary>
        PointSmoothHint = 0x0c51,

        /// <summary>
        /// Original was GL_LINE_SMOOTH_HINT = 0x0C52
        /// </summary>
        LineSmoothHint = 0x0c52,

        /// <summary>
        /// Original was GL_POLYGON_SMOOTH_HINT = 0x0C53
        /// </summary>
        PolygonSmoothHint = 0x0c53,

        /// <summary>
        /// Original was GL_FOG_HINT = 0x0C54
        /// </summary>
        FogHint = 0x0c54,

        /// <summary>
        /// Original was GL_PREFER_DOUBLEBUFFER_HINT_PGI = 0x1A1F8
        /// </summary>
        PreferDoublebufferHintPgi = 0x1a1f8,

        /// <summary>
        /// Original was GL_CONSERVE_MEMORY_HINT_PGI = 0x1A1FD
        /// </summary>
        ConserveMemoryHintPgi = 0x1a1fd,

        /// <summary>
        /// Original was GL_RECLAIM_MEMORY_HINT_PGI = 0x1A1FE
        /// </summary>
        ReclaimMemoryHintPgi = 0x1a1fe,

        /// <summary>
        /// Original was GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203
        /// </summary>
        NativeGraphicsBeginHintPgi = 0x1a203,

        /// <summary>
        /// Original was GL_NATIVE_GRAPHICS_END_HINT_PGI = 0x1A204
        /// </summary>
        NativeGraphicsEndHintPgi = 0x1a204,

        /// <summary>
        /// Original was GL_ALWAYS_FAST_HINT_PGI = 0x1A20C
        /// </summary>
        AlwaysFastHintPgi = 0x1a20c,

        /// <summary>
        /// Original was GL_ALWAYS_SOFT_HINT_PGI = 0x1A20D
        /// </summary>
        AlwaysSoftHintPgi = 0x1a20d,

        /// <summary>
        /// Original was GL_ALLOW_DRAW_OBJ_HINT_PGI = 0x1A20E
        /// </summary>
        AllowDrawObjHintPgi = 0x1a20e,

        /// <summary>
        /// Original was GL_ALLOW_DRAW_WIN_HINT_PGI = 0x1A20F
        /// </summary>
        AllowDrawWinHintPgi = 0x1a20f,

        /// <summary>
        /// Original was GL_ALLOW_DRAW_FRG_HINT_PGI = 0x1A210
        /// </summary>
        AllowDrawFrgHintPgi = 0x1a210,

        /// <summary>
        /// Original was GL_ALLOW_DRAW_MEM_HINT_PGI = 0x1A211
        /// </summary>
        AllowDrawMemHintPgi = 0x1a211,

        /// <summary>
        /// Original was GL_STRICT_DEPTHFUNC_HINT_PGI = 0x1A216
        /// </summary>
        StrictDepthfuncHintPgi = 0x1a216,

        /// <summary>
        /// Original was GL_STRICT_LIGHTING_HINT_PGI = 0x1A217
        /// </summary>
        StrictLightingHintPgi = 0x1a217,

        /// <summary>
        /// Original was GL_STRICT_SCISSOR_HINT_PGI = 0x1A218
        /// </summary>
        StrictScissorHintPgi = 0x1a218,

        /// <summary>
        /// Original was GL_FULL_STIPPLE_HINT_PGI = 0x1A219
        /// </summary>
        FullStippleHintPgi = 0x1a219,

        /// <summary>
        /// Original was GL_CLIP_NEAR_HINT_PGI = 0x1A220
        /// </summary>
        ClipNearHintPgi = 0x1a220,

        /// <summary>
        /// Original was GL_CLIP_FAR_HINT_PGI = 0x1A221
        /// </summary>
        ClipFarHintPgi = 0x1a221,

        /// <summary>
        /// Original was GL_WIDE_LINE_HINT_PGI = 0x1A222
        /// </summary>
        WideLineHintPgi = 0x1a222,

        /// <summary>
        /// Original was GL_BACK_NORMALS_HINT_PGI = 0x1A223
        /// </summary>
        BackNormalsHintPgi = 0x1a223,

        /// <summary>
        /// Original was GL_VERTEX_DATA_HINT_PGI = 0x1A22A
        /// </summary>
        VertexDataHintPgi = 0x1a22a,

        /// <summary>
        /// Original was GL_VERTEX_CONSISTENT_HINT_PGI = 0x1A22B
        /// </summary>
        VertexConsistentHintPgi = 0x1a22b,

        /// <summary>
        /// Original was GL_MATERIAL_SIDE_HINT_PGI = 0x1A22C
        /// </summary>
        MaterialSideHintPgi = 0x1a22c,

        /// <summary>
        /// Original was GL_MAX_VERTEX_HINT_PGI = 0x1A22D
        /// </summary>
        MaxVertexHintPgi = 0x1a22d,

        /// <summary>
        /// Original was GL_PACK_CMYK_HINT_EXT = 0x800E
        /// </summary>
        PackCmykHintExt = 0x800e,

        /// <summary>
        /// Original was GL_UNPACK_CMYK_HINT_EXT = 0x800F
        /// </summary>
        UnpackCmykHintExt = 0x800f,

        /// <summary>
        /// Original was GL_PHONG_HINT_WIN = 0x80EB
        /// </summary>
        PhongHintWin = 0x80eb,

        /// <summary>
        /// Original was GL_CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0
        /// </summary>
        ClipVolumeClippingHintExt = 0x80f0,

        /// <summary>
        /// Original was GL_TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E
        /// </summary>
        TextureMultiBufferHintSgix = 0x812e,

        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT = 0x8192
        /// </summary>
        GenerateMipmapHint = 0x8192,

        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192
        /// </summary>
        GenerateMipmapHintSgis = 0x8192,

        /// <summary>
        /// Original was GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
        /// </summary>
        ProgramBinaryRetrievableHint = 0x8257,

        /// <summary>
        /// Original was GL_CONVOLUTION_HINT_SGIX = 0x8316
        /// </summary>
        ConvolutionHintSgix = 0x8316,

        /// <summary>
        /// Original was GL_SCALEBIAS_HINT_SGIX = 0x8322
        /// </summary>
        ScalebiasHintSgix = 0x8322,

        /// <summary>
        /// Original was GL_LINE_QUALITY_HINT_SGIX = 0x835B
        /// </summary>
        LineQualityHintSgix = 0x835b,

        /// <summary>
        /// Original was GL_VERTEX_PRECLIP_SGIX = 0x83EE
        /// </summary>
        VertexPreclipSgix = 0x83ee,

        /// <summary>
        /// Original was GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF
        /// </summary>
        VertexPreclipHintSgix = 0x83ef,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSION_HINT = 0x84EF
        /// </summary>
        TextureCompressionHint = 0x84ef,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF
        /// </summary>
        TextureCompressionHintArb = 0x84ef,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F
        /// </summary>
        VertexArrayStorageHintApple = 0x851f,

        /// <summary>
        /// Original was GL_MULTISAMPLE_FILTER_HINT_NV = 0x8534
        /// </summary>
        MultisampleFilterHintNv = 0x8534,

        /// <summary>
        /// Original was GL_TRANSFORM_HINT_APPLE = 0x85B1
        /// </summary>
        TransformHintApple = 0x85b1,

        /// <summary>
        /// Original was GL_TEXTURE_STORAGE_HINT_APPLE = 0x85BC
        /// </summary>
        TextureStorageHintApple = 0x85bc,

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHint = 0x8b8b,

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHintArb = 0x8b8b,

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHintOes = 0x8b8b,

        /// <summary>
        /// Original was GL_BINNING_CONTROL_HINT_QCOM = 0x8FB0
        /// </summary>
        BinningControlHintQcom = 0x8fb0,
    }

    /// <summary>
    /// Used in GL.Oes.GetHistogramParameterx
    /// </summary>
    public enum HistogramTargetExt
    {
        /// <summary>
        /// Original was GL_HISTOGRAM = 0x8024
        /// </summary>
        Histogram = 0x8024,

        /// <summary>
        /// Original was GL_HISTOGRAM_EXT = 0x8024
        /// </summary>
        HistogramExt = 0x8024,

        /// <summary>
        /// Original was GL_PROXY_HISTOGRAM = 0x8025
        /// </summary>
        ProxyHistogram = 0x8025,

        /// <summary>
        /// Original was GL_PROXY_HISTOGRAM_EXT = 0x8025
        /// </summary>
        ProxyHistogramExt = 0x8025,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgMultisampledRenderToTexture
    {
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_IMG = 0x9133
        /// </summary>
        RenderbufferSamplesImg = 0x9133,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG = 0x9134
        /// </summary>
        FramebufferIncompleteMultisampleImg = 0x9134,

        /// <summary>
        /// Original was GL_MAX_SAMPLES_IMG = 0x9135
        /// </summary>
        MaxSamplesImg = 0x9135,

        /// <summary>
        /// Original was GL_TEXTURE_SAMPLES_IMG = 0x9136
        /// </summary>
        TextureSamplesImg = 0x9136,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum ImgreadFormat
    {
        /// <summary>
        /// Original was GL_BGRA = 0x80E1
        /// </summary>
        Bgra = 0x80e1,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365
        /// </summary>
        UnsignedShort4444Rev = 0x8365,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366
        /// </summary>
        UnsignedShort1555Rev = 0x8366,

        /// <summary>
        /// Original was GL_IMG_read_format = 1
        /// </summary>
        ImgReadFormat = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgReadFormat
    {
        /// <summary>
        /// Original was GL_BGRA_IMG = 0x80E1
        /// </summary>
        BgraImg = 0x80e1,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG = 0x8365
        /// </summary>
        UnsignedShort4444RevImg = 0x8365,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum ImgtextureCompressionPvrtc
    {
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG = 0x8C00
        /// </summary>
        CompressedRgbPvrtc4Bppv1Img = 0x8c00,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG = 0x8C01
        /// </summary>
        CompressedRgbPvrtc2Bppv1Img = 0x8c01,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG = 0x8C02
        /// </summary>
        CompressedRgbaPvrtc4Bppv1Img = 0x8c02,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG = 0x8C03
        /// </summary>
        CompressedRgbaPvrtc2Bppv1Img = 0x8c03,

        /// <summary>
        /// Original was GL_IMG_texture_compression_pvrtc = 1
        /// </summary>
        ImgTextureCompressionPvrtc = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgTextureCompressionPvrtc
    {
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG = 0x8C00
        /// </summary>
        CompressedRgbPvrtc4Bppv1Img = 0x8c00,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG = 0x8C01
        /// </summary>
        CompressedRgbPvrtc2Bppv1Img = 0x8c01,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG = 0x8C02
        /// </summary>
        CompressedRgbaPvrtc4Bppv1Img = 0x8c02,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG = 0x8C03
        /// </summary>
        CompressedRgbaPvrtc2Bppv1Img = 0x8c03,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum ImgtextureEnvEnhancedFixedFunction
    {
        /// <summary>
        /// Original was GL_DOT3_RGBA_IMG = 0x86AF
        /// </summary>
        Dot3RgbaImg = 0x86af,

        /// <summary>
        /// Original was GL_MODULATE_COLOR_IMG = 0x8C04
        /// </summary>
        ModulateColorImg = 0x8c04,

        /// <summary>
        /// Original was GL_RECIP_ADD_SIGNED_ALPHA_IMG = 0x8C05
        /// </summary>
        RecipAddSignedAlphaImg = 0x8c05,

        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_MODULATE_IMG = 0x8C06
        /// </summary>
        TextureAlphaModulateImg = 0x8c06,

        /// <summary>
        /// Original was GL_FACTOR_ALPHA_MODULATE_IMG = 0x8C07
        /// </summary>
        FactorAlphaModulateImg = 0x8c07,

        /// <summary>
        /// Original was GL_FRAGMENT_ALPHA_MODULATE_IMG = 0x8C08
        /// </summary>
        FragmentAlphaModulateImg = 0x8c08,

        /// <summary>
        /// Original was GL_ADD_BLEND_IMG = 0x8C09
        /// </summary>
        AddBlendImg = 0x8c09,

        /// <summary>
        /// Original was GL_IMG_texture_env_enhanced_fixed_function = 1
        /// </summary>
        ImgTextureEnvEnhancedFixedFunction = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgTextureEnvEnhancedFixedFunction
    {
        /// <summary>
        /// Original was GL_DOT3_RGBA_IMG = 0x86AF
        /// </summary>
        Dot3RgbaImg = 0x86af,

        /// <summary>
        /// Original was GL_MODULATE_COLOR_IMG = 0x8C04
        /// </summary>
        ModulateColorImg = 0x8c04,

        /// <summary>
        /// Original was GL_RECIP_ADD_SIGNED_ALPHA_IMG = 0x8C05
        /// </summary>
        RecipAddSignedAlphaImg = 0x8c05,

        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_MODULATE_IMG = 0x8C06
        /// </summary>
        TextureAlphaModulateImg = 0x8c06,

        /// <summary>
        /// Original was GL_FACTOR_ALPHA_MODULATE_IMG = 0x8C07
        /// </summary>
        FactorAlphaModulateImg = 0x8c07,

        /// <summary>
        /// Original was GL_FRAGMENT_ALPHA_MODULATE_IMG = 0x8C08
        /// </summary>
        FragmentAlphaModulateImg = 0x8c08,

        /// <summary>
        /// Original was GL_ADD_BLEND_IMG = 0x8C09
        /// </summary>
        AddBlendImg = 0x8c09,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum ImguserClipPlane
    {
        /// <summary>
        /// Original was GL_MAX_CLIP_PLANES_IMG = 0x0D32
        /// </summary>
        MaxClipPlanesImg = 0x0d32,

        /// <summary>
        /// Original was GL_CLIP_PLANE0_IMG = 0x3000
        /// </summary>
        ClipPlane0Img = 0x3000,

        /// <summary>
        /// Original was GL_CLIP_PLANE1_IMG = 0x3001
        /// </summary>
        ClipPlane1Img = 0x3001,

        /// <summary>
        /// Original was GL_CLIP_PLANE2_IMG = 0x3002
        /// </summary>
        ClipPlane2Img = 0x3002,

        /// <summary>
        /// Original was GL_CLIP_PLANE3_IMG = 0x3003
        /// </summary>
        ClipPlane3Img = 0x3003,

        /// <summary>
        /// Original was GL_CLIP_PLANE4_IMG = 0x3004
        /// </summary>
        ClipPlane4Img = 0x3004,

        /// <summary>
        /// Original was GL_CLIP_PLANE5_IMG = 0x3005
        /// </summary>
        ClipPlane5Img = 0x3005,

        /// <summary>
        /// Original was GL_IMG_user_clip_plane = 1
        /// </summary>
        ImgUserClipPlane = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgUserClipPlane
    {
        /// <summary>
        /// Original was GL_MAX_CLIP_PLANES_IMG = 0x0D32
        /// </summary>
        MaxClipPlanesImg = 0x0d32,

        /// <summary>
        /// Original was GL_CLIP_PLANE0_IMG = 0x3000
        /// </summary>
        ClipPlane0Img = 0x3000,

        /// <summary>
        /// Original was GL_CLIP_PLANE1_IMG = 0x3001
        /// </summary>
        ClipPlane1Img = 0x3001,

        /// <summary>
        /// Original was GL_CLIP_PLANE2_IMG = 0x3002
        /// </summary>
        ClipPlane2Img = 0x3002,

        /// <summary>
        /// Original was GL_CLIP_PLANE3_IMG = 0x3003
        /// </summary>
        ClipPlane3Img = 0x3003,

        /// <summary>
        /// Original was GL_CLIP_PLANE4_IMG = 0x3004
        /// </summary>
        ClipPlane4Img = 0x3004,

        /// <summary>
        /// Original was GL_CLIP_PLANE5_IMG = 0x3005
        /// </summary>
        ClipPlane5Img = 0x3005,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum IndexPointerType
    {
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = 0x1402,

        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = 0x1404,

        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = 0x140a,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum InterleavedArrayFormat
    {
        /// <summary>
        /// Original was GL_V2F = 0x2A20
        /// </summary>
        V2f = 0x2a20,

        /// <summary>
        /// Original was GL_V3F = 0x2A21
        /// </summary>
        V3f = 0x2a21,

        /// <summary>
        /// Original was GL_C4UB_V2F = 0x2A22
        /// </summary>
        C4ubV2f = 0x2a22,

        /// <summary>
        /// Original was GL_C4UB_V3F = 0x2A23
        /// </summary>
        C4ubV3f = 0x2a23,

        /// <summary>
        /// Original was GL_C3F_V3F = 0x2A24
        /// </summary>
        C3fV3f = 0x2a24,

        /// <summary>
        /// Original was GL_N3F_V3F = 0x2A25
        /// </summary>
        N3fV3f = 0x2a25,

        /// <summary>
        /// Original was GL_C4F_N3F_V3F = 0x2A26
        /// </summary>
        C4fN3fV3f = 0x2a26,

        /// <summary>
        /// Original was GL_T2F_V3F = 0x2A27
        /// </summary>
        T2fV3f = 0x2a27,

        /// <summary>
        /// Original was GL_T4F_V4F = 0x2A28
        /// </summary>
        T4fV4f = 0x2a28,

        /// <summary>
        /// Original was GL_T2F_C4UB_V3F = 0x2A29
        /// </summary>
        T2fC4ubV3f = 0x2a29,

        /// <summary>
        /// Original was GL_T2F_C3F_V3F = 0x2A2A
        /// </summary>
        T2fC3fV3f = 0x2a2a,

        /// <summary>
        /// Original was GL_T2F_N3F_V3F = 0x2A2B
        /// </summary>
        T2fN3fV3f = 0x2a2b,

        /// <summary>
        /// Original was GL_T2F_C4F_N3F_V3F = 0x2A2C
        /// </summary>
        T2fC4fN3fV3f = 0x2a2c,

        /// <summary>
        /// Original was GL_T4F_C4F_N3F_V4F = 0x2A2D
        /// </summary>
        T4fC4fN3fV4f = 0x2a2d,
    }

    /// <summary>
    /// Used in GL.Apple.RenderbufferStorageMultisample, GL.CompressedTexImage2D and 11 other functions
    /// </summary>
    public enum InternalFormat
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT = 0x1902
        /// </summary>
        DepthComponent = 0x1902,

        /// <summary>
        /// Original was GL_RED = 0x1903
        /// </summary>
        Red = 0x1903,

        /// <summary>
        /// Original was GL_RED_EXT = 0x1903
        /// </summary>
        RedExt = 0x1903,

        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = 0x1907,

        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = 0x1908,

        /// <summary>
        /// Original was GL_R3_G3_B2 = 0x2A10
        /// </summary>
        R3G3B2 = 0x2a10,

        /// <summary>
        /// Original was GL_ALPHA4 = 0x803B
        /// </summary>
        Alpha4 = 0x803b,

        /// <summary>
        /// Original was GL_ALPHA8 = 0x803C
        /// </summary>
        Alpha8 = 0x803c,

        /// <summary>
        /// Original was GL_ALPHA12 = 0x803D
        /// </summary>
        Alpha12 = 0x803d,

        /// <summary>
        /// Original was GL_ALPHA16 = 0x803E
        /// </summary>
        Alpha16 = 0x803e,

        /// <summary>
        /// Original was GL_LUMINANCE4 = 0x803F
        /// </summary>
        Luminance4 = 0x803f,

        /// <summary>
        /// Original was GL_LUMINANCE8 = 0x8040
        /// </summary>
        Luminance8 = 0x8040,

        /// <summary>
        /// Original was GL_LUMINANCE12 = 0x8041
        /// </summary>
        Luminance12 = 0x8041,

        /// <summary>
        /// Original was GL_LUMINANCE16 = 0x8042
        /// </summary>
        Luminance16 = 0x8042,

        /// <summary>
        /// Original was GL_LUMINANCE4_ALPHA4 = 0x8043
        /// </summary>
        Luminance4Alpha4 = 0x8043,

        /// <summary>
        /// Original was GL_LUMINANCE6_ALPHA2 = 0x8044
        /// </summary>
        Luminance6Alpha2 = 0x8044,

        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8 = 0x8045
        /// </summary>
        Luminance8Alpha8 = 0x8045,

        /// <summary>
        /// Original was GL_LUMINANCE12_ALPHA4 = 0x8046
        /// </summary>
        Luminance12Alpha4 = 0x8046,

        /// <summary>
        /// Original was GL_LUMINANCE12_ALPHA12 = 0x8047
        /// </summary>
        Luminance12Alpha12 = 0x8047,

        /// <summary>
        /// Original was GL_LUMINANCE16_ALPHA16 = 0x8048
        /// </summary>
        Luminance16Alpha16 = 0x8048,

        /// <summary>
        /// Original was GL_INTENSITY = 0x8049
        /// </summary>
        Intensity = 0x8049,

        /// <summary>
        /// Original was GL_INTENSITY4 = 0x804A
        /// </summary>
        Intensity4 = 0x804a,

        /// <summary>
        /// Original was GL_INTENSITY8 = 0x804B
        /// </summary>
        Intensity8 = 0x804b,

        /// <summary>
        /// Original was GL_INTENSITY12 = 0x804C
        /// </summary>
        Intensity12 = 0x804c,

        /// <summary>
        /// Original was GL_INTENSITY16 = 0x804D
        /// </summary>
        Intensity16 = 0x804d,

        /// <summary>
        /// Original was GL_RGB2_EXT = 0x804E
        /// </summary>
        Rgb2Ext = 0x804e,

        /// <summary>
        /// Original was GL_RGB4 = 0x804F
        /// </summary>
        Rgb4 = 0x804f,

        /// <summary>
        /// Original was GL_RGB4_EXT = 0x804F
        /// </summary>
        Rgb4Ext = 0x804f,

        /// <summary>
        /// Original was GL_RGB5 = 0x8050
        /// </summary>
        Rgb5 = 0x8050,

        /// <summary>
        /// Original was GL_RGB5_EXT = 0x8050
        /// </summary>
        Rgb5Ext = 0x8050,

        /// <summary>
        /// Original was GL_RGB8 = 0x8051
        /// </summary>
        Rgb8 = 0x8051,

        /// <summary>
        /// Original was GL_RGB8_EXT = 0x8051
        /// </summary>
        Rgb8Ext = 0x8051,

        /// <summary>
        /// Original was GL_RGB8_OES = 0x8051
        /// </summary>
        Rgb8Oes = 0x8051,

        /// <summary>
        /// Original was GL_RGB10 = 0x8052
        /// </summary>
        Rgb10 = 0x8052,

        /// <summary>
        /// Original was GL_RGB10_EXT = 0x8052
        /// </summary>
        Rgb10Ext = 0x8052,

        /// <summary>
        /// Original was GL_RGB12 = 0x8053
        /// </summary>
        Rgb12 = 0x8053,

        /// <summary>
        /// Original was GL_RGB12_EXT = 0x8053
        /// </summary>
        Rgb12Ext = 0x8053,

        /// <summary>
        /// Original was GL_RGB16 = 0x8054
        /// </summary>
        Rgb16 = 0x8054,

        /// <summary>
        /// Original was GL_RGB16_EXT = 0x8054
        /// </summary>
        Rgb16Ext = 0x8054,

        /// <summary>
        /// Original was GL_RGBA4 = 0x8056
        /// </summary>
        Rgba4 = 0x8056,

        /// <summary>
        /// Original was GL_RGBA4_EXT = 0x8056
        /// </summary>
        Rgba4Ext = 0x8056,

        /// <summary>
        /// Original was GL_RGBA4_OES = 0x8056
        /// </summary>
        Rgba4Oes = 0x8056,

        /// <summary>
        /// Original was GL_RGB5_A1 = 0x8057
        /// </summary>
        Rgb5A1 = 0x8057,

        /// <summary>
        /// Original was GL_RGB5_A1_EXT = 0x8057
        /// </summary>
        Rgb5A1Ext = 0x8057,

        /// <summary>
        /// Original was GL_RGB5_A1_OES = 0x8057
        /// </summary>
        Rgb5A1Oes = 0x8057,

        /// <summary>
        /// Original was GL_RGBA8 = 0x8058
        /// </summary>
        Rgba8 = 0x8058,

        /// <summary>
        /// Original was GL_RGBA8_EXT = 0x8058
        /// </summary>
        Rgba8Ext = 0x8058,

        /// <summary>
        /// Original was GL_RGBA8_OES = 0x8058
        /// </summary>
        Rgba8Oes = 0x8058,

        /// <summary>
        /// Original was GL_RGB10_A2 = 0x8059
        /// </summary>
        Rgb10A2 = 0x8059,

        /// <summary>
        /// Original was GL_RGB10_A2_EXT = 0x8059
        /// </summary>
        Rgb10A2Ext = 0x8059,

        /// <summary>
        /// Original was GL_RGBA12 = 0x805A
        /// </summary>
        Rgba12 = 0x805a,

        /// <summary>
        /// Original was GL_RGBA12_EXT = 0x805A
        /// </summary>
        Rgba12Ext = 0x805a,

        /// <summary>
        /// Original was GL_RGBA16 = 0x805B
        /// </summary>
        Rgba16 = 0x805b,

        /// <summary>
        /// Original was GL_RGBA16_EXT = 0x805B
        /// </summary>
        Rgba16Ext = 0x805b,

        /// <summary>
        /// Original was GL_DUAL_ALPHA4_SGIS = 0x8110
        /// </summary>
        DualAlpha4Sgis = 0x8110,

        /// <summary>
        /// Original was GL_DUAL_ALPHA8_SGIS = 0x8111
        /// </summary>
        DualAlpha8Sgis = 0x8111,

        /// <summary>
        /// Original was GL_DUAL_ALPHA12_SGIS = 0x8112
        /// </summary>
        DualAlpha12Sgis = 0x8112,

        /// <summary>
        /// Original was GL_DUAL_ALPHA16_SGIS = 0x8113
        /// </summary>
        DualAlpha16Sgis = 0x8113,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE4_SGIS = 0x8114
        /// </summary>
        DualLuminance4Sgis = 0x8114,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE8_SGIS = 0x8115
        /// </summary>
        DualLuminance8Sgis = 0x8115,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE12_SGIS = 0x8116
        /// </summary>
        DualLuminance12Sgis = 0x8116,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE16_SGIS = 0x8117
        /// </summary>
        DualLuminance16Sgis = 0x8117,

        /// <summary>
        /// Original was GL_DUAL_INTENSITY4_SGIS = 0x8118
        /// </summary>
        DualIntensity4Sgis = 0x8118,

        /// <summary>
        /// Original was GL_DUAL_INTENSITY8_SGIS = 0x8119
        /// </summary>
        DualIntensity8Sgis = 0x8119,

        /// <summary>
        /// Original was GL_DUAL_INTENSITY12_SGIS = 0x811A
        /// </summary>
        DualIntensity12Sgis = 0x811a,

        /// <summary>
        /// Original was GL_DUAL_INTENSITY16_SGIS = 0x811B
        /// </summary>
        DualIntensity16Sgis = 0x811b,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C
        /// </summary>
        DualLuminanceAlpha4Sgis = 0x811c,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D
        /// </summary>
        DualLuminanceAlpha8Sgis = 0x811d,

        /// <summary>
        /// Original was GL_QUAD_ALPHA4_SGIS = 0x811E
        /// </summary>
        QuadAlpha4Sgis = 0x811e,

        /// <summary>
        /// Original was GL_QUAD_ALPHA8_SGIS = 0x811F
        /// </summary>
        QuadAlpha8Sgis = 0x811f,

        /// <summary>
        /// Original was GL_QUAD_LUMINANCE4_SGIS = 0x8120
        /// </summary>
        QuadLuminance4Sgis = 0x8120,

        /// <summary>
        /// Original was GL_QUAD_LUMINANCE8_SGIS = 0x8121
        /// </summary>
        QuadLuminance8Sgis = 0x8121,

        /// <summary>
        /// Original was GL_QUAD_INTENSITY4_SGIS = 0x8122
        /// </summary>
        QuadIntensity4Sgis = 0x8122,

        /// <summary>
        /// Original was GL_QUAD_INTENSITY8_SGIS = 0x8123
        /// </summary>
        QuadIntensity8Sgis = 0x8123,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16 = 0x81A5
        /// </summary>
        DepthComponent16 = 0x81a5,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_ARB = 0x81A5
        /// </summary>
        DepthComponent16Arb = 0x81a5,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_OES = 0x81A5
        /// </summary>
        DepthComponent16Oes = 0x81a5,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_SGIX = 0x81A5
        /// </summary>
        DepthComponent16Sgix = 0x81a5,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_ARB = 0x81A6
        /// </summary>
        DepthComponent24Arb = 0x81a6,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_OES = 0x81A6
        /// </summary>
        DepthComponent24Oes = 0x81a6,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_SGIX = 0x81A6
        /// </summary>
        DepthComponent24Sgix = 0x81a6,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_ARB = 0x81A7
        /// </summary>
        DepthComponent32Arb = 0x81a7,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        /// </summary>
        DepthComponent32Oes = 0x81a7,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_SGIX = 0x81A7
        /// </summary>
        DepthComponent32Sgix = 0x81a7,

        /// <summary>
        /// Original was GL_COMPRESSED_RED = 0x8225
        /// </summary>
        CompressedRed = 0x8225,

        /// <summary>
        /// Original was GL_COMPRESSED_RG = 0x8226
        /// </summary>
        CompressedRg = 0x8226,

        /// <summary>
        /// Original was GL_RG = 0x8227
        /// </summary>
        Rg = 0x8227,

        /// <summary>
        /// Original was GL_R8 = 0x8229
        /// </summary>
        R8 = 0x8229,

        /// <summary>
        /// Original was GL_R8_EXT = 0x8229
        /// </summary>
        R8Ext = 0x8229,

        /// <summary>
        /// Original was GL_R16 = 0x822A
        /// </summary>
        R16 = 0x822a,

        /// <summary>
        /// Original was GL_R16_EXT = 0x822A
        /// </summary>
        R16Ext = 0x822a,

        /// <summary>
        /// Original was GL_RG8 = 0x822B
        /// </summary>
        Rg8 = 0x822b,

        /// <summary>
        /// Original was GL_RG8_EXT = 0x822B
        /// </summary>
        Rg8Ext = 0x822b,

        /// <summary>
        /// Original was GL_RG16 = 0x822C
        /// </summary>
        Rg16 = 0x822c,

        /// <summary>
        /// Original was GL_RG16_EXT = 0x822C
        /// </summary>
        Rg16Ext = 0x822c,

        /// <summary>
        /// Original was GL_R16F = 0x822D
        /// </summary>
        R16f = 0x822d,

        /// <summary>
        /// Original was GL_R16F_EXT = 0x822D
        /// </summary>
        R16fExt = 0x822d,

        /// <summary>
        /// Original was GL_R32F = 0x822E
        /// </summary>
        R32f = 0x822e,

        /// <summary>
        /// Original was GL_R32F_EXT = 0x822E
        /// </summary>
        R32fExt = 0x822e,

        /// <summary>
        /// Original was GL_RG16F = 0x822F
        /// </summary>
        Rg16f = 0x822f,

        /// <summary>
        /// Original was GL_RG16F_EXT = 0x822F
        /// </summary>
        Rg16fExt = 0x822f,

        /// <summary>
        /// Original was GL_RG32F = 0x8230
        /// </summary>
        Rg32f = 0x8230,

        /// <summary>
        /// Original was GL_RG32F_EXT = 0x8230
        /// </summary>
        Rg32fExt = 0x8230,

        /// <summary>
        /// Original was GL_R8I = 0x8231
        /// </summary>
        R8i = 0x8231,

        /// <summary>
        /// Original was GL_R8UI = 0x8232
        /// </summary>
        R8ui = 0x8232,

        /// <summary>
        /// Original was GL_R16I = 0x8233
        /// </summary>
        R16i = 0x8233,

        /// <summary>
        /// Original was GL_R16UI = 0x8234
        /// </summary>
        R16ui = 0x8234,

        /// <summary>
        /// Original was GL_R32I = 0x8235
        /// </summary>
        R32i = 0x8235,

        /// <summary>
        /// Original was GL_R32UI = 0x8236
        /// </summary>
        R32ui = 0x8236,

        /// <summary>
        /// Original was GL_RG8I = 0x8237
        /// </summary>
        Rg8i = 0x8237,

        /// <summary>
        /// Original was GL_RG8UI = 0x8238
        /// </summary>
        Rg8ui = 0x8238,

        /// <summary>
        /// Original was GL_RG16I = 0x8239
        /// </summary>
        Rg16i = 0x8239,

        /// <summary>
        /// Original was GL_RG16UI = 0x823A
        /// </summary>
        Rg16ui = 0x823a,

        /// <summary>
        /// Original was GL_RG32I = 0x823B
        /// </summary>
        Rg32i = 0x823b,

        /// <summary>
        /// Original was GL_RG32UI = 0x823C
        /// </summary>
        Rg32ui = 0x823c,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0
        /// </summary>
        CompressedRgbS3tcDxt1Ext = 0x83f0,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1
        /// </summary>
        CompressedRgbaS3tcDxt1Ext = 0x83f1,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2
        /// </summary>
        CompressedRgbaS3tcDxt3Ext = 0x83f2,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3
        /// </summary>
        CompressedRgbaS3tcDxt5Ext = 0x83f3,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB = 0x84ED
        /// </summary>
        CompressedRgb = 0x84ed,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA = 0x84EE
        /// </summary>
        CompressedRgba = 0x84ee,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL = 0x84F9
        /// </summary>
        DepthStencil = 0x84f9,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_EXT = 0x84F9
        /// </summary>
        DepthStencilExt = 0x84f9,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_NV = 0x84F9
        /// </summary>
        DepthStencilNv = 0x84f9,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_OES = 0x84F9
        /// </summary>
        DepthStencilOes = 0x84f9,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_MESA = 0x8750
        /// </summary>
        DepthStencilMesa = 0x8750,

        /// <summary>
        /// Original was GL_RGBA32F = 0x8814
        /// </summary>
        Rgba32f = 0x8814,

        /// <summary>
        /// Original was GL_RGBA32F_ARB = 0x8814
        /// </summary>
        Rgba32fArb = 0x8814,

        /// <summary>
        /// Original was GL_RGBA32F_EXT = 0x8814
        /// </summary>
        Rgba32fExt = 0x8814,

        /// <summary>
        /// Original was GL_RGBA16F = 0x881A
        /// </summary>
        Rgba16f = 0x881a,

        /// <summary>
        /// Original was GL_RGBA16F_ARB = 0x881A
        /// </summary>
        Rgba16fArb = 0x881a,

        /// <summary>
        /// Original was GL_RGBA16F_EXT = 0x881A
        /// </summary>
        Rgba16fExt = 0x881a,

        /// <summary>
        /// Original was GL_RGB16F = 0x881B
        /// </summary>
        Rgb16f = 0x881b,

        /// <summary>
        /// Original was GL_RGB16F_ARB = 0x881B
        /// </summary>
        Rgb16fArb = 0x881b,

        /// <summary>
        /// Original was GL_RGB16F_EXT = 0x881B
        /// </summary>
        Rgb16fExt = 0x881b,

        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8 = 0x88F0
        /// </summary>
        Depth24Stencil8 = 0x88f0,

        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_EXT = 0x88F0
        /// </summary>
        Depth24Stencil8Ext = 0x88f0,

        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        /// </summary>
        Depth24Stencil8Oes = 0x88f0,

        /// <summary>
        /// Original was GL_R11F_G11F_B10F = 0x8C3A
        /// </summary>
        R11fG11fB10f = 0x8c3a,

        /// <summary>
        /// Original was GL_R11F_G11F_B10F_APPLE = 0x8C3A
        /// </summary>
        R11fG11fB10fApple = 0x8c3a,

        /// <summary>
        /// Original was GL_R11F_G11F_B10F_EXT = 0x8C3A
        /// </summary>
        R11fG11fB10fExt = 0x8c3a,

        /// <summary>
        /// Original was GL_RGB9_E5 = 0x8C3D
        /// </summary>
        Rgb9E5 = 0x8c3d,

        /// <summary>
        /// Original was GL_RGB9_E5_APPLE = 0x8C3D
        /// </summary>
        Rgb9E5Apple = 0x8c3d,

        /// <summary>
        /// Original was GL_RGB9_E5_EXT = 0x8C3D
        /// </summary>
        Rgb9E5Ext = 0x8c3d,

        /// <summary>
        /// Original was GL_SRGB = 0x8C40
        /// </summary>
        Srgb = 0x8c40,

        /// <summary>
        /// Original was GL_SRGB_EXT = 0x8C40
        /// </summary>
        SrgbExt = 0x8c40,

        /// <summary>
        /// Original was GL_SRGB8 = 0x8C41
        /// </summary>
        Srgb8 = 0x8c41,

        /// <summary>
        /// Original was GL_SRGB8_EXT = 0x8C41
        /// </summary>
        Srgb8Ext = 0x8c41,

        /// <summary>
        /// Original was GL_SRGB8_NV = 0x8C41
        /// </summary>
        Srgb8Nv = 0x8c41,

        /// <summary>
        /// Original was GL_SRGB_ALPHA = 0x8C42
        /// </summary>
        SrgbAlpha = 0x8c42,

        /// <summary>
        /// Original was GL_SRGB_ALPHA_EXT = 0x8C42
        /// </summary>
        SrgbAlphaExt = 0x8c42,

        /// <summary>
        /// Original was GL_SRGB8_ALPHA8 = 0x8C43
        /// </summary>
        Srgb8Alpha8 = 0x8c43,

        /// <summary>
        /// Original was GL_SRGB8_ALPHA8_EXT = 0x8C43
        /// </summary>
        Srgb8Alpha8Ext = 0x8c43,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB = 0x8C48
        /// </summary>
        CompressedSrgb = 0x8c48,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA = 0x8C49
        /// </summary>
        CompressedSrgbAlpha = 0x8c49,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C
        /// </summary>
        CompressedSrgbS3tcDxt1Ext = 0x8c4c,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D
        /// </summary>
        CompressedSrgbAlphaS3tcDxt1Ext = 0x8c4d,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E
        /// </summary>
        CompressedSrgbAlphaS3tcDxt3Ext = 0x8c4e,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F
        /// </summary>
        CompressedSrgbAlphaS3tcDxt5Ext = 0x8c4f,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        /// </summary>
        DepthComponent32f = 0x8cac,

        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        /// </summary>
        Depth32fStencil8 = 0x8cad,

        /// <summary>
        /// Original was GL_RGBA32UI = 0x8D70
        /// </summary>
        Rgba32ui = 0x8d70,

        /// <summary>
        /// Original was GL_RGB32UI = 0x8D71
        /// </summary>
        Rgb32ui = 0x8d71,

        /// <summary>
        /// Original was GL_RGBA16UI = 0x8D76
        /// </summary>
        Rgba16ui = 0x8d76,

        /// <summary>
        /// Original was GL_RGB16UI = 0x8D77
        /// </summary>
        Rgb16ui = 0x8d77,

        /// <summary>
        /// Original was GL_RGBA8UI = 0x8D7C
        /// </summary>
        Rgba8ui = 0x8d7c,

        /// <summary>
        /// Original was GL_RGB8UI = 0x8D7D
        /// </summary>
        Rgb8ui = 0x8d7d,

        /// <summary>
        /// Original was GL_RGBA32I = 0x8D82
        /// </summary>
        Rgba32i = 0x8d82,

        /// <summary>
        /// Original was GL_RGB32I = 0x8D83
        /// </summary>
        Rgb32i = 0x8d83,

        /// <summary>
        /// Original was GL_RGBA16I = 0x8D88
        /// </summary>
        Rgba16i = 0x8d88,

        /// <summary>
        /// Original was GL_RGB16I = 0x8D89
        /// </summary>
        Rgb16i = 0x8d89,

        /// <summary>
        /// Original was GL_RGBA8I = 0x8D8E
        /// </summary>
        Rgba8i = 0x8d8e,

        /// <summary>
        /// Original was GL_RGB8I = 0x8D8F
        /// </summary>
        Rgb8i = 0x8d8f,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F_NV = 0x8DAB
        /// </summary>
        DepthComponent32fNv = 0x8dab,

        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8_NV = 0x8DAC
        /// </summary>
        Depth32fStencil8Nv = 0x8dac,

        /// <summary>
        /// Original was GL_COMPRESSED_RED_RGTC1 = 0x8DBB
        /// </summary>
        CompressedRedRgtc1 = 0x8dbb,

        /// <summary>
        /// Original was GL_COMPRESSED_RED_RGTC1_EXT = 0x8DBB
        /// </summary>
        CompressedRedRgtc1Ext = 0x8dbb,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC
        /// </summary>
        CompressedSignedRedRgtc1 = 0x8dbc,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC
        /// </summary>
        CompressedSignedRedRgtc1Ext = 0x8dbc,

        /// <summary>
        /// Original was GL_COMPRESSED_RG_RGTC2 = 0x8DBD
        /// </summary>
        CompressedRgRgtc2 = 0x8dbd,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE
        /// </summary>
        CompressedSignedRgRgtc2 = 0x8dbe,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
        /// </summary>
        CompressedRgbaBptcUnorm = 0x8e8c,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D
        /// </summary>
        CompressedSrgbAlphaBptcUnorm = 0x8e8d,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
        /// </summary>
        CompressedRgbBptcSignedFloat = 0x8e8e,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
        /// </summary>
        CompressedRgbBptcUnsignedFloat = 0x8e8f,

        /// <summary>
        /// Original was GL_R8_SNORM = 0x8F94
        /// </summary>
        R8Snorm = 0x8f94,

        /// <summary>
        /// Original was GL_RG8_SNORM = 0x8F95
        /// </summary>
        Rg8Snorm = 0x8f95,

        /// <summary>
        /// Original was GL_RGB8_SNORM = 0x8F96
        /// </summary>
        Rgb8Snorm = 0x8f96,

        /// <summary>
        /// Original was GL_RGBA8_SNORM = 0x8F97
        /// </summary>
        Rgba8Snorm = 0x8f97,

        /// <summary>
        /// Original was GL_R16_SNORM = 0x8F98
        /// </summary>
        R16Snorm = 0x8f98,

        /// <summary>
        /// Original was GL_R16_SNORM_EXT = 0x8F98
        /// </summary>
        R16SnormExt = 0x8f98,

        /// <summary>
        /// Original was GL_RG16_SNORM = 0x8F99
        /// </summary>
        Rg16Snorm = 0x8f99,

        /// <summary>
        /// Original was GL_RG16_SNORM_EXT = 0x8F99
        /// </summary>
        Rg16SnormExt = 0x8f99,

        /// <summary>
        /// Original was GL_RGB16_SNORM = 0x8F9A
        /// </summary>
        Rgb16Snorm = 0x8f9a,

        /// <summary>
        /// Original was GL_RGB16_SNORM_EXT = 0x8F9A
        /// </summary>
        Rgb16SnormExt = 0x8f9a,

        /// <summary>
        /// Original was GL_RGB10_A2UI = 0x906F
        /// </summary>
        Rgb10A2ui = 0x906f,

        /// <summary>
        /// Original was GL_COMPRESSED_R11_EAC = 0x9270
        /// </summary>
        CompressedR11Eac = 0x9270,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_R11_EAC = 0x9271
        /// </summary>
        CompressedSignedR11Eac = 0x9271,

        /// <summary>
        /// Original was GL_COMPRESSED_RG11_EAC = 0x9272
        /// </summary>
        CompressedRg11Eac = 0x9272,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273
        /// </summary>
        CompressedSignedRg11Eac = 0x9273,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB8_ETC2 = 0x9274
        /// </summary>
        CompressedRgb8Etc2 = 0x9274,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ETC2 = 0x9275
        /// </summary>
        CompressedSrgb8Etc2 = 0x9275,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276
        /// </summary>
        CompressedRgb8PunchthroughAlpha1Etc2 = 0x9276,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277
        /// </summary>
        CompressedSrgb8PunchthroughAlpha1Etc2 = 0x9277,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278
        /// </summary>
        CompressedRgba8Etc2Eac = 0x9278,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279
        /// </summary>
        CompressedSrgb8Alpha8Etc2Eac = 0x9279,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum InternalFormatPName
    {
        /// <summary>
        /// Original was GL_SAMPLES = 0x80A9
        /// </summary>
        Samples = 0x80a9,

        /// <summary>
        /// Original was GL_GENERATE_MIPMAP = 0x8191
        /// </summary>
        GenerateMipmap = 0x8191,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_SUPPORTED = 0x826F
        /// </summary>
        InternalformatSupported = 0x826f,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_PREFERRED = 0x8270
        /// </summary>
        InternalformatPreferred = 0x8270,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_RED_SIZE = 0x8271
        /// </summary>
        InternalformatRedSize = 0x8271,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_GREEN_SIZE = 0x8272
        /// </summary>
        InternalformatGreenSize = 0x8272,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_BLUE_SIZE = 0x8273
        /// </summary>
        InternalformatBlueSize = 0x8273,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274
        /// </summary>
        InternalformatAlphaSize = 0x8274,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275
        /// </summary>
        InternalformatDepthSize = 0x8275,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276
        /// </summary>
        InternalformatStencilSize = 0x8276,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_SHARED_SIZE = 0x8277
        /// </summary>
        InternalformatSharedSize = 0x8277,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_RED_TYPE = 0x8278
        /// </summary>
        InternalformatRedType = 0x8278,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_GREEN_TYPE = 0x8279
        /// </summary>
        InternalformatGreenType = 0x8279,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_BLUE_TYPE = 0x827A
        /// </summary>
        InternalformatBlueType = 0x827a,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B
        /// </summary>
        InternalformatAlphaType = 0x827b,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C
        /// </summary>
        InternalformatDepthType = 0x827c,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D
        /// </summary>
        InternalformatStencilType = 0x827d,

        /// <summary>
        /// Original was GL_MAX_WIDTH = 0x827E
        /// </summary>
        MaxWidth = 0x827e,

        /// <summary>
        /// Original was GL_MAX_HEIGHT = 0x827F
        /// </summary>
        MaxHeight = 0x827f,

        /// <summary>
        /// Original was GL_MAX_DEPTH = 0x8280
        /// </summary>
        MaxDepth = 0x8280,

        /// <summary>
        /// Original was GL_MAX_LAYERS = 0x8281
        /// </summary>
        MaxLayers = 0x8281,

        /// <summary>
        /// Original was GL_COLOR_COMPONENTS = 0x8283
        /// </summary>
        ColorComponents = 0x8283,

        /// <summary>
        /// Original was GL_COLOR_RENDERABLE = 0x8286
        /// </summary>
        ColorRenderable = 0x8286,

        /// <summary>
        /// Original was GL_DEPTH_RENDERABLE = 0x8287
        /// </summary>
        DepthRenderable = 0x8287,

        /// <summary>
        /// Original was GL_STENCIL_RENDERABLE = 0x8288
        /// </summary>
        StencilRenderable = 0x8288,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_RENDERABLE = 0x8289
        /// </summary>
        FramebufferRenderable = 0x8289,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A
        /// </summary>
        FramebufferRenderableLayered = 0x828a,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BLEND = 0x828B
        /// </summary>
        FramebufferBlend = 0x828b,

        /// <summary>
        /// Original was GL_READ_PIXELS = 0x828C
        /// </summary>
        ReadPixels = 0x828c,

        /// <summary>
        /// Original was GL_READ_PIXELS_FORMAT = 0x828D
        /// </summary>
        ReadPixelsFormat = 0x828d,

        /// <summary>
        /// Original was GL_READ_PIXELS_TYPE = 0x828E
        /// </summary>
        ReadPixelsType = 0x828e,

        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_FORMAT = 0x828F
        /// </summary>
        TextureImageFormat = 0x828f,

        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_TYPE = 0x8290
        /// </summary>
        TextureImageType = 0x8290,

        /// <summary>
        /// Original was GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291
        /// </summary>
        GetTextureImageFormat = 0x8291,

        /// <summary>
        /// Original was GL_GET_TEXTURE_IMAGE_TYPE = 0x8292
        /// </summary>
        GetTextureImageType = 0x8292,

        /// <summary>
        /// Original was GL_MIPMAP = 0x8293
        /// </summary>
        Mipmap = 0x8293,

        /// <summary>
        /// Original was GL_AUTO_GENERATE_MIPMAP = 0x8295
        /// </summary>
        AutoGenerateMipmap = 0x8295,

        /// <summary>
        /// Original was GL_COLOR_ENCODING = 0x8296
        /// </summary>
        ColorEncoding = 0x8296,

        /// <summary>
        /// Original was GL_SRGB_READ = 0x8297
        /// </summary>
        SrgbRead = 0x8297,

        /// <summary>
        /// Original was GL_SRGB_WRITE = 0x8298
        /// </summary>
        SrgbWrite = 0x8298,

        /// <summary>
        /// Original was GL_FILTER = 0x829A
        /// </summary>
        Filter = 0x829a,

        /// <summary>
        /// Original was GL_VERTEX_TEXTURE = 0x829B
        /// </summary>
        VertexTexture = 0x829b,

        /// <summary>
        /// Original was GL_TESS_CONTROL_TEXTURE = 0x829C
        /// </summary>
        TessControlTexture = 0x829c,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_TEXTURE = 0x829D
        /// </summary>
        TessEvaluationTexture = 0x829d,

        /// <summary>
        /// Original was GL_GEOMETRY_TEXTURE = 0x829E
        /// </summary>
        GeometryTexture = 0x829e,

        /// <summary>
        /// Original was GL_FRAGMENT_TEXTURE = 0x829F
        /// </summary>
        FragmentTexture = 0x829f,

        /// <summary>
        /// Original was GL_COMPUTE_TEXTURE = 0x82A0
        /// </summary>
        ComputeTexture = 0x82a0,

        /// <summary>
        /// Original was GL_TEXTURE_SHADOW = 0x82A1
        /// </summary>
        TextureShadow = 0x82a1,

        /// <summary>
        /// Original was GL_TEXTURE_GATHER = 0x82A2
        /// </summary>
        TextureGather = 0x82a2,

        /// <summary>
        /// Original was GL_TEXTURE_GATHER_SHADOW = 0x82A3
        /// </summary>
        TextureGatherShadow = 0x82a3,

        /// <summary>
        /// Original was GL_SHADER_IMAGE_LOAD = 0x82A4
        /// </summary>
        ShaderImageLoad = 0x82a4,

        /// <summary>
        /// Original was GL_SHADER_IMAGE_STORE = 0x82A5
        /// </summary>
        ShaderImageStore = 0x82a5,

        /// <summary>
        /// Original was GL_SHADER_IMAGE_ATOMIC = 0x82A6
        /// </summary>
        ShaderImageAtomic = 0x82a6,

        /// <summary>
        /// Original was GL_IMAGE_TEXEL_SIZE = 0x82A7
        /// </summary>
        ImageTexelSize = 0x82a7,

        /// <summary>
        /// Original was GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8
        /// </summary>
        ImageCompatibilityClass = 0x82a8,

        /// <summary>
        /// Original was GL_IMAGE_PIXEL_FORMAT = 0x82A9
        /// </summary>
        ImagePixelFormat = 0x82a9,

        /// <summary>
        /// Original was GL_IMAGE_PIXEL_TYPE = 0x82AA
        /// </summary>
        ImagePixelType = 0x82aa,

        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC
        /// </summary>
        SimultaneousTextureAndDepthTest = 0x82ac,

        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD
        /// </summary>
        SimultaneousTextureAndStencilTest = 0x82ad,

        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE
        /// </summary>
        SimultaneousTextureAndDepthWrite = 0x82ae,

        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF
        /// </summary>
        SimultaneousTextureAndStencilWrite = 0x82af,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1
        /// </summary>
        TextureCompressedBlockWidth = 0x82b1,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2
        /// </summary>
        TextureCompressedBlockHeight = 0x82b2,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3
        /// </summary>
        TextureCompressedBlockSize = 0x82b3,

        /// <summary>
        /// Original was GL_CLEAR_BUFFER = 0x82B4
        /// </summary>
        ClearBuffer = 0x82b4,

        /// <summary>
        /// Original was GL_TEXTURE_VIEW = 0x82B5
        /// </summary>
        TextureView = 0x82b5,

        /// <summary>
        /// Original was GL_VIEW_COMPATIBILITY_CLASS = 0x82B6
        /// </summary>
        ViewCompatibilityClass = 0x82b6,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED = 0x86A1
        /// </summary>
        TextureCompressed = 0x86a1,

        /// <summary>
        /// Original was GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7
        /// </summary>
        ImageFormatCompatibilityType = 0x90c7,

        /// <summary>
        /// Original was GL_CLEAR_TEXTURE = 0x9365
        /// </summary>
        ClearTexture = 0x9365,

        /// <summary>
        /// Original was GL_NUM_SAMPLE_COUNTS = 0x9380
        /// </summary>
        NumSampleCounts = 0x9380,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum KhrDebug
    {
        /// <summary>
        /// Original was GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002
        /// </summary>
        ContextFlagDebugBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_DEBUG_BIT_KHR = 0x00000002
        /// </summary>
        ContextFlagDebugBitKhr = ((int)0x00000002),

        /// <summary>
        /// Original was GL_STACK_OVERFLOW = 0x0503
        /// </summary>
        StackOverflow = 0x0503,

        /// <summary>
        /// Original was GL_STACK_OVERFLOW_KHR = 0x0503
        /// </summary>
        StackOverflowKhr = 0x0503,

        /// <summary>
        /// Original was GL_STACK_UNDERFLOW = 0x0504
        /// </summary>
        StackUnderflow = 0x0504,

        /// <summary>
        /// Original was GL_STACK_UNDERFLOW_KHR = 0x0504
        /// </summary>
        StackUnderflowKhr = 0x0504,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = 0x8074,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_KHR = 0x8074
        /// </summary>
        VertexArrayKhr = 0x8074,

        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242
        /// </summary>
        DebugOutputSynchronous = 0x8242,

        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_SYNCHRONOUS_KHR = 0x8242
        /// </summary>
        DebugOutputSynchronousKhr = 0x8242,

        /// <summary>
        /// Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243
        /// </summary>
        DebugNextLoggedMessageLength = 0x8243,

        /// <summary>
        /// Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_KHR = 0x8243
        /// </summary>
        DebugNextLoggedMessageLengthKhr = 0x8243,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_FUNCTION = 0x8244
        /// </summary>
        DebugCallbackFunction = 0x8244,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_FUNCTION_KHR = 0x8244
        /// </summary>
        DebugCallbackFunctionKhr = 0x8244,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_USER_PARAM = 0x8245
        /// </summary>
        DebugCallbackUserParam = 0x8245,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_USER_PARAM_KHR = 0x8245
        /// </summary>
        DebugCallbackUserParamKhr = 0x8245,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_API = 0x8246
        /// </summary>
        DebugSourceApi = 0x8246,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_API_KHR = 0x8246
        /// </summary>
        DebugSourceApiKhr = 0x8246,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247
        /// </summary>
        DebugSourceWindowSystem = 0x8247,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM_KHR = 0x8247
        /// </summary>
        DebugSourceWindowSystemKhr = 0x8247,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248
        /// </summary>
        DebugSourceShaderCompiler = 0x8248,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_SHADER_COMPILER_KHR = 0x8248
        /// </summary>
        DebugSourceShaderCompilerKhr = 0x8248,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249
        /// </summary>
        DebugSourceThirdParty = 0x8249,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_THIRD_PARTY_KHR = 0x8249
        /// </summary>
        DebugSourceThirdPartyKhr = 0x8249,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_APPLICATION = 0x824A
        /// </summary>
        DebugSourceApplication = 0x824a,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_APPLICATION_KHR = 0x824A
        /// </summary>
        DebugSourceApplicationKhr = 0x824a,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_OTHER = 0x824B
        /// </summary>
        DebugSourceOther = 0x824b,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_OTHER_KHR = 0x824B
        /// </summary>
        DebugSourceOtherKhr = 0x824b,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_ERROR = 0x824C
        /// </summary>
        DebugTypeError = 0x824c,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_ERROR_KHR = 0x824C
        /// </summary>
        DebugTypeErrorKhr = 0x824c,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D
        /// </summary>
        DebugTypeDeprecatedBehavior = 0x824d,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_KHR = 0x824D
        /// </summary>
        DebugTypeDeprecatedBehaviorKhr = 0x824d,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E
        /// </summary>
        DebugTypeUndefinedBehavior = 0x824e,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_KHR = 0x824E
        /// </summary>
        DebugTypeUndefinedBehaviorKhr = 0x824e,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PORTABILITY = 0x824F
        /// </summary>
        DebugTypePortability = 0x824f,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PORTABILITY_KHR = 0x824F
        /// </summary>
        DebugTypePortabilityKhr = 0x824f,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PERFORMANCE = 0x8250
        /// </summary>
        DebugTypePerformance = 0x8250,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PERFORMANCE_KHR = 0x8250
        /// </summary>
        DebugTypePerformanceKhr = 0x8250,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_OTHER = 0x8251
        /// </summary>
        DebugTypeOther = 0x8251,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_OTHER_KHR = 0x8251
        /// </summary>
        DebugTypeOtherKhr = 0x8251,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_MARKER = 0x8268
        /// </summary>
        DebugTypeMarker = 0x8268,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_MARKER_KHR = 0x8268
        /// </summary>
        DebugTypeMarkerKhr = 0x8268,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PUSH_GROUP = 0x8269
        /// </summary>
        DebugTypePushGroup = 0x8269,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PUSH_GROUP_KHR = 0x8269
        /// </summary>
        DebugTypePushGroupKhr = 0x8269,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_POP_GROUP = 0x826A
        /// </summary>
        DebugTypePopGroup = 0x826a,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_POP_GROUP_KHR = 0x826A
        /// </summary>
        DebugTypePopGroupKhr = 0x826a,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B
        /// </summary>
        DebugSeverityNotification = 0x826b,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_NOTIFICATION_KHR = 0x826B
        /// </summary>
        DebugSeverityNotificationKhr = 0x826b,

        /// <summary>
        /// Original was GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C
        /// </summary>
        MaxDebugGroupStackDepth = 0x826c,

        /// <summary>
        /// Original was GL_MAX_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826C
        /// </summary>
        MaxDebugGroupStackDepthKhr = 0x826c,

        /// <summary>
        /// Original was GL_DEBUG_GROUP_STACK_DEPTH = 0x826D
        /// </summary>
        DebugGroupStackDepth = 0x826d,

        /// <summary>
        /// Original was GL_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826D
        /// </summary>
        DebugGroupStackDepthKhr = 0x826d,

        /// <summary>
        /// Original was GL_BUFFER = 0x82E0
        /// </summary>
        Buffer = 0x82e0,

        /// <summary>
        /// Original was GL_BUFFER_KHR = 0x82E0
        /// </summary>
        BufferKhr = 0x82e0,

        /// <summary>
        /// Original was GL_SHADER = 0x82E1
        /// </summary>
        Shader = 0x82e1,

        /// <summary>
        /// Original was GL_SHADER_KHR = 0x82E1
        /// </summary>
        ShaderKhr = 0x82e1,

        /// <summary>
        /// Original was GL_PROGRAM = 0x82E2
        /// </summary>
        Program = 0x82e2,

        /// <summary>
        /// Original was GL_PROGRAM_KHR = 0x82E2
        /// </summary>
        ProgramKhr = 0x82e2,

        /// <summary>
        /// Original was GL_QUERY = 0x82E3
        /// </summary>
        Query = 0x82e3,

        /// <summary>
        /// Original was GL_QUERY_KHR = 0x82E3
        /// </summary>
        QueryKhr = 0x82e3,

        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE = 0x82E4
        /// </summary>
        ProgramPipeline = 0x82e4,

        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE_KHR = 0x82E4
        /// </summary>
        ProgramPipelineKhr = 0x82e4,

        /// <summary>
        /// Original was GL_SAMPLER = 0x82E6
        /// </summary>
        Sampler = 0x82e6,

        /// <summary>
        /// Original was GL_SAMPLER_KHR = 0x82E6
        /// </summary>
        SamplerKhr = 0x82e6,

        /// <summary>
        /// Original was GL_DISPLAY_LIST = 0x82E7
        /// </summary>
        DisplayList = 0x82e7,

        /// <summary>
        /// Original was GL_MAX_LABEL_LENGTH = 0x82E8
        /// </summary>
        MaxLabelLength = 0x82e8,

        /// <summary>
        /// Original was GL_MAX_LABEL_LENGTH_KHR = 0x82E8
        /// </summary>
        MaxLabelLengthKhr = 0x82e8,

        /// <summary>
        /// Original was GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143
        /// </summary>
        MaxDebugMessageLength = 0x9143,

        /// <summary>
        /// Original was GL_MAX_DEBUG_MESSAGE_LENGTH_KHR = 0x9143
        /// </summary>
        MaxDebugMessageLengthKhr = 0x9143,

        /// <summary>
        /// Original was GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144
        /// </summary>
        MaxDebugLoggedMessages = 0x9144,

        /// <summary>
        /// Original was GL_MAX_DEBUG_LOGGED_MESSAGES_KHR = 0x9144
        /// </summary>
        MaxDebugLoggedMessagesKhr = 0x9144,

        /// <summary>
        /// Original was GL_DEBUG_LOGGED_MESSAGES = 0x9145
        /// </summary>
        DebugLoggedMessages = 0x9145,

        /// <summary>
        /// Original was GL_DEBUG_LOGGED_MESSAGES_KHR = 0x9145
        /// </summary>
        DebugLoggedMessagesKhr = 0x9145,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_HIGH = 0x9146
        /// </summary>
        DebugSeverityHigh = 0x9146,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_HIGH_KHR = 0x9146
        /// </summary>
        DebugSeverityHighKhr = 0x9146,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_MEDIUM = 0x9147
        /// </summary>
        DebugSeverityMedium = 0x9147,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_MEDIUM_KHR = 0x9147
        /// </summary>
        DebugSeverityMediumKhr = 0x9147,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_LOW = 0x9148
        /// </summary>
        DebugSeverityLow = 0x9148,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_LOW_KHR = 0x9148
        /// </summary>
        DebugSeverityLowKhr = 0x9148,

        /// <summary>
        /// Original was GL_DEBUG_OUTPUT = 0x92E0
        /// </summary>
        DebugOutput = 0x92e0,

        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_KHR = 0x92E0
        /// </summary>
        DebugOutputKhr = 0x92e0,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum LightEnvModeSgix
    {
        /// <summary>
        /// Original was GL_ADD = 0x0104
        /// </summary>
        Add = 0x0104,

        /// <summary>
        /// Original was GL_REPLACE = 0x1E01
        /// </summary>
        Replace = 0x1e01,

        /// <summary>
        /// Original was GL_MODULATE = 0x2100
        /// </summary>
        Modulate = 0x2100,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum LightEnvParameterSgix
    {
        /// <summary>
        /// Original was GL_LIGHT_ENV_MODE_SGIX = 0x8407
        /// </summary>
        LightEnvModeSgix = 0x8407,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum LightModelColorControl
    {
        /// <summary>
        /// Original was GL_SINGLE_COLOR = 0x81F9
        /// </summary>
        SingleColor = 0x81f9,

        /// <summary>
        /// Original was GL_SINGLE_COLOR_EXT = 0x81F9
        /// </summary>
        SingleColorExt = 0x81f9,

        /// <summary>
        /// Original was GL_SEPARATE_SPECULAR_COLOR = 0x81FA
        /// </summary>
        SeparateSpecularColor = 0x81fa,

        /// <summary>
        /// Original was GL_SEPARATE_SPECULAR_COLOR_EXT = 0x81FA
        /// </summary>
        SeparateSpecularColorExt = 0x81fa,
    }

    /// <summary>
    /// Used in GL.LightModel, GL.LightModelx and 1 other function
    /// </summary>
    public enum LightModelParameter
    {
        /// <summary>
        /// Original was GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51
        /// </summary>
        LightModelLocalViewer = 0x0b51,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_TWO_SIDE = 0x0B52
        /// </summary>
        LightModelTwoSide = 0x0b52,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_AMBIENT = 0x0B53
        /// </summary>
        LightModelAmbient = 0x0b53,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8
        /// </summary>
        LightModelColorControl = 0x81f8,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_COLOR_CONTROL_EXT = 0x81F8
        /// </summary>
        LightModelColorControlExt = 0x81f8,
    }

    /// <summary>
    /// Used in GL.GetLight, GL.GetLightx and 4 other functions
    /// </summary>
    public enum LightName
    {
        /// <summary>
        /// Original was GL_LIGHT0 = 0x4000
        /// </summary>
        Light0 = 0x4000,

        /// <summary>
        /// Original was GL_LIGHT1 = 0x4001
        /// </summary>
        Light1 = 0x4001,

        /// <summary>
        /// Original was GL_LIGHT2 = 0x4002
        /// </summary>
        Light2 = 0x4002,

        /// <summary>
        /// Original was GL_LIGHT3 = 0x4003
        /// </summary>
        Light3 = 0x4003,

        /// <summary>
        /// Original was GL_LIGHT4 = 0x4004
        /// </summary>
        Light4 = 0x4004,

        /// <summary>
        /// Original was GL_LIGHT5 = 0x4005
        /// </summary>
        Light5 = 0x4005,

        /// <summary>
        /// Original was GL_LIGHT6 = 0x4006
        /// </summary>
        Light6 = 0x4006,

        /// <summary>
        /// Original was GL_LIGHT7 = 0x4007
        /// </summary>
        Light7 = 0x4007,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT0_SGIX = 0x840C
        /// </summary>
        FragmentLight0Sgix = 0x840c,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT1_SGIX = 0x840D
        /// </summary>
        FragmentLight1Sgix = 0x840d,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT2_SGIX = 0x840E
        /// </summary>
        FragmentLight2Sgix = 0x840e,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT3_SGIX = 0x840F
        /// </summary>
        FragmentLight3Sgix = 0x840f,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT4_SGIX = 0x8410
        /// </summary>
        FragmentLight4Sgix = 0x8410,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT5_SGIX = 0x8411
        /// </summary>
        FragmentLight5Sgix = 0x8411,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT6_SGIX = 0x8412
        /// </summary>
        FragmentLight6Sgix = 0x8412,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT7_SGIX = 0x8413
        /// </summary>
        FragmentLight7Sgix = 0x8413,
    }

    /// <summary>
    /// Used in GL.GetLight, GL.GetLightx and 4 other functions
    /// </summary>
    public enum LightParameter
    {
        /// <summary>
        /// Original was GL_AMBIENT = 0x1200
        /// </summary>
        Ambient = 0x1200,

        /// <summary>
        /// Original was GL_DIFFUSE = 0x1201
        /// </summary>
        Diffuse = 0x1201,

        /// <summary>
        /// Original was GL_SPECULAR = 0x1202
        /// </summary>
        Specular = 0x1202,

        /// <summary>
        /// Original was GL_POSITION = 0x1203
        /// </summary>
        Position = 0x1203,

        /// <summary>
        /// Original was GL_SPOT_DIRECTION = 0x1204
        /// </summary>
        SpotDirection = 0x1204,

        /// <summary>
        /// Original was GL_SPOT_EXPONENT = 0x1205
        /// </summary>
        SpotExponent = 0x1205,

        /// <summary>
        /// Original was GL_SPOT_CUTOFF = 0x1206
        /// </summary>
        SpotCutoff = 0x1206,

        /// <summary>
        /// Original was GL_CONSTANT_ATTENUATION = 0x1207
        /// </summary>
        ConstantAttenuation = 0x1207,

        /// <summary>
        /// Original was GL_LINEAR_ATTENUATION = 0x1208
        /// </summary>
        LinearAttenuation = 0x1208,

        /// <summary>
        /// Original was GL_QUADRATIC_ATTENUATION = 0x1209
        /// </summary>
        QuadraticAttenuation = 0x1209,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ListMode
    {
        /// <summary>
        /// Original was GL_COMPILE = 0x1300
        /// </summary>
        Compile = 0x1300,

        /// <summary>
        /// Original was GL_COMPILE_AND_EXECUTE = 0x1301
        /// </summary>
        CompileAndExecute = 0x1301,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ListNameType
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = 0x1400,

        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = 0x1401,

        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = 0x1402,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = 0x1403,

        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = 0x1404,

        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = 0x1405,

        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_2_BYTES = 0x1407
        /// </summary>
        Gl2Bytes = 0x1407,

        /// <summary>
        /// Original was GL_3_BYTES = 0x1408
        /// </summary>
        Gl3Bytes = 0x1408,

        /// <summary>
        /// Original was GL_4_BYTES = 0x1409
        /// </summary>
        Gl4Bytes = 0x1409,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ListParameterName
    {
        /// <summary>
        /// Original was GL_LIST_PRIORITY_SGIX = 0x8182
        /// </summary>
        ListPrioritySgix = 0x8182,
    }

    /// <summary>
    /// Used in GL.LogicOp
    /// </summary>
    public enum LogicOp
    {
        /// <summary>
        /// Original was GL_CLEAR = 0x1500
        /// </summary>
        Clear = 0x1500,

        /// <summary>
        /// Original was GL_AND = 0x1501
        /// </summary>
        And = 0x1501,

        /// <summary>
        /// Original was GL_AND_REVERSE = 0x1502
        /// </summary>
        AndReverse = 0x1502,

        /// <summary>
        /// Original was GL_COPY = 0x1503
        /// </summary>
        Copy = 0x1503,

        /// <summary>
        /// Original was GL_AND_INVERTED = 0x1504
        /// </summary>
        AndInverted = 0x1504,

        /// <summary>
        /// Original was GL_NOOP = 0x1505
        /// </summary>
        Noop = 0x1505,

        /// <summary>
        /// Original was GL_XOR = 0x1506
        /// </summary>
        Xor = 0x1506,

        /// <summary>
        /// Original was GL_OR = 0x1507
        /// </summary>
        Or = 0x1507,

        /// <summary>
        /// Original was GL_NOR = 0x1508
        /// </summary>
        Nor = 0x1508,

        /// <summary>
        /// Original was GL_EQUIV = 0x1509
        /// </summary>
        Equiv = 0x1509,

        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = 0x150a,

        /// <summary>
        /// Original was GL_OR_REVERSE = 0x150B
        /// </summary>
        OrReverse = 0x150b,

        /// <summary>
        /// Original was GL_COPY_INVERTED = 0x150C
        /// </summary>
        CopyInverted = 0x150c,

        /// <summary>
        /// Original was GL_OR_INVERTED = 0x150D
        /// </summary>
        OrInverted = 0x150d,

        /// <summary>
        /// Original was GL_NAND = 0x150E
        /// </summary>
        Nand = 0x150e,

        /// <summary>
        /// Original was GL_SET = 0x150F
        /// </summary>
        Set = 0x150f,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum MapBufferUsageMask
    {
        /// <summary>
        /// Original was GL_MAP_READ_BIT = 0x0001
        /// </summary>
        MapReadBit = 0x0001,

        /// <summary>
        /// Original was GL_MAP_READ_BIT_EXT = 0x0001
        /// </summary>
        MapReadBitExt = 0x0001,

        /// <summary>
        /// Original was GL_MAP_WRITE_BIT = 0x0002
        /// </summary>
        MapWriteBit = 0x0002,

        /// <summary>
        /// Original was GL_MAP_WRITE_BIT_EXT = 0x0002
        /// </summary>
        MapWriteBitExt = 0x0002,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT = 0x0004
        /// </summary>
        MapInvalidateRangeBit = 0x0004,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004
        /// </summary>
        MapInvalidateRangeBitExt = 0x0004,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008
        /// </summary>
        MapInvalidateBufferBit = 0x0008,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008
        /// </summary>
        MapInvalidateBufferBitExt = 0x0008,

        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010
        /// </summary>
        MapFlushExplicitBit = 0x0010,

        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010
        /// </summary>
        MapFlushExplicitBitExt = 0x0010,

        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT = 0x0020
        /// </summary>
        MapUnsynchronizedBit = 0x0020,

        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020
        /// </summary>
        MapUnsynchronizedBitExt = 0x0020,

        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT = 0x0040
        /// </summary>
        MapPersistentBit = 0x0040,

        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT_EXT = 0x0040
        /// </summary>
        MapPersistentBitExt = 0x0040,

        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT = 0x0080
        /// </summary>
        MapCoherentBit = 0x0080,

        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT_EXT = 0x0080
        /// </summary>
        MapCoherentBitExt = 0x0080,

        /// <summary>
        /// Original was GL_DYNAMIC_STORAGE_BIT = 0x0100
        /// </summary>
        DynamicStorageBit = 0x0100,

        /// <summary>
        /// Original was GL_DYNAMIC_STORAGE_BIT_EXT = 0x0100
        /// </summary>
        DynamicStorageBitExt = 0x0100,

        /// <summary>
        /// Original was GL_CLIENT_STORAGE_BIT = 0x0200
        /// </summary>
        ClientStorageBit = 0x0200,

        /// <summary>
        /// Original was GL_CLIENT_STORAGE_BIT_EXT = 0x0200
        /// </summary>
        ClientStorageBitExt = 0x0200,

        /// <summary>
        /// Original was GL_SPARSE_STORAGE_BIT_ARB = 0x0400
        /// </summary>
        SparseStorageBitArb = 0x0400,

        /// <summary>
        /// Original was GL_LGPU_SEPARATE_STORAGE_BIT_NVX = 0x0800
        /// </summary>
        LgpuSeparateStorageBitNvx = 0x0800,

        /// <summary>
        /// Original was GL_PER_GPU_STORAGE_BIT_NV = 0x0800
        /// </summary>
        PerGpuStorageBitNv = 0x0800,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MapQuery
    {
        /// <summary>
        /// Original was GL_COEFF = 0x0A00
        /// </summary>
        Coeff = 0x0a00,

        /// <summary>
        /// Original was GL_ORDER = 0x0A01
        /// </summary>
        Order = 0x0a01,

        /// <summary>
        /// Original was GL_DOMAIN = 0x0A02
        /// </summary>
        Domain = 0x0a02,
    }

    /// <summary>
    /// Used in GL.Oes.GetMapx, GL.Oes.Map1x and 1 other function
    /// </summary>
    public enum MapTarget
    {
        /// <summary>
        /// Original was GL_MAP1_COLOR_4 = 0x0D90
        /// </summary>
        Map1Color4 = 0x0d90,

        /// <summary>
        /// Original was GL_MAP1_INDEX = 0x0D91
        /// </summary>
        Map1Index = 0x0d91,

        /// <summary>
        /// Original was GL_MAP1_NORMAL = 0x0D92
        /// </summary>
        Map1Normal = 0x0d92,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_1 = 0x0D93
        /// </summary>
        Map1TextureCoord1 = 0x0d93,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_2 = 0x0D94
        /// </summary>
        Map1TextureCoord2 = 0x0d94,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_3 = 0x0D95
        /// </summary>
        Map1TextureCoord3 = 0x0d95,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_4 = 0x0D96
        /// </summary>
        Map1TextureCoord4 = 0x0d96,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_3 = 0x0D97
        /// </summary>
        Map1Vertex3 = 0x0d97,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_4 = 0x0D98
        /// </summary>
        Map1Vertex4 = 0x0d98,

        /// <summary>
        /// Original was GL_MAP2_COLOR_4 = 0x0DB0
        /// </summary>
        Map2Color4 = 0x0db0,

        /// <summary>
        /// Original was GL_MAP2_INDEX = 0x0DB1
        /// </summary>
        Map2Index = 0x0db1,

        /// <summary>
        /// Original was GL_MAP2_NORMAL = 0x0DB2
        /// </summary>
        Map2Normal = 0x0db2,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_1 = 0x0DB3
        /// </summary>
        Map2TextureCoord1 = 0x0db3,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_2 = 0x0DB4
        /// </summary>
        Map2TextureCoord2 = 0x0db4,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_3 = 0x0DB5
        /// </summary>
        Map2TextureCoord3 = 0x0db5,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_4 = 0x0DB6
        /// </summary>
        Map2TextureCoord4 = 0x0db6,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_3 = 0x0DB7
        /// </summary>
        Map2Vertex3 = 0x0db7,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_4 = 0x0DB8
        /// </summary>
        Map2Vertex4 = 0x0db8,

        /// <summary>
        /// Original was GL_GEOMETRY_DEFORMATION_SGIX = 0x8194
        /// </summary>
        GeometryDeformationSgix = 0x8194,

        /// <summary>
        /// Original was GL_TEXTURE_DEFORMATION_SGIX = 0x8195
        /// </summary>
        TextureDeformationSgix = 0x8195,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MapTextureFormatIntel
    {
        /// <summary>
        /// Original was GL_LAYOUT_DEFAULT_INTEL = 0
        /// </summary>
        LayoutDefaultIntel = 0,

        /// <summary>
        /// Original was GL_LAYOUT_LINEAR_INTEL = 1
        /// </summary>
        LayoutLinearIntel = 1,

        /// <summary>
        /// Original was GL_LAYOUT_LINEAR_CPU_CACHED_INTEL = 2
        /// </summary>
        LayoutLinearCpuCachedIntel = 2,
    }

    /// <summary>
    /// Used in GL.GetMaterial, GL.GetMaterialx and 4 other functions
    /// </summary>
    public enum MaterialFace
    {
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = 0x0404,

        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = 0x0405,

        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = 0x0408,
    }

    /// <summary>
    /// Used in GL.GetMaterial, GL.GetMaterialx and 4 other functions
    /// </summary>
    public enum MaterialParameter
    {
        /// <summary>
        /// Original was GL_AMBIENT = 0x1200
        /// </summary>
        Ambient = 0x1200,

        /// <summary>
        /// Original was GL_DIFFUSE = 0x1201
        /// </summary>
        Diffuse = 0x1201,

        /// <summary>
        /// Original was GL_SPECULAR = 0x1202
        /// </summary>
        Specular = 0x1202,

        /// <summary>
        /// Original was GL_EMISSION = 0x1600
        /// </summary>
        Emission = 0x1600,

        /// <summary>
        /// Original was GL_SHININESS = 0x1601
        /// </summary>
        Shininess = 0x1601,

        /// <summary>
        /// Original was GL_AMBIENT_AND_DIFFUSE = 0x1602
        /// </summary>
        AmbientAndDiffuse = 0x1602,

        /// <summary>
        /// Original was GL_COLOR_INDEXES = 0x1603
        /// </summary>
        ColorIndexes = 0x1603,
    }

    /// <summary>
    /// Used in GL.MatrixMode
    /// </summary>
    public enum MatrixMode
    {
        /// <summary>
        /// Original was GL_MODELVIEW = 0x1700
        /// </summary>
        Modelview = 0x1700,

        /// <summary>
        /// Original was GL_MODELVIEW0_EXT = 0x1700
        /// </summary>
        Modelview0Ext = 0x1700,

        /// <summary>
        /// Original was GL_PROJECTION = 0x1701
        /// </summary>
        Projection = 0x1701,

        /// <summary>
        /// Original was GL_TEXTURE = 0x1702
        /// </summary>
        Texture = 0x1702,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum MemoryBarrierMask
    {
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001
        /// </summary>
        VertexAttribArrayBarrierBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT = 0x00000001
        /// </summary>
        VertexAttribArrayBarrierBitExt = ((int)0x00000001),

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BARRIER_BIT = 0x00000002
        /// </summary>
        ElementArrayBarrierBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BARRIER_BIT_EXT = 0x00000002
        /// </summary>
        ElementArrayBarrierBitExt = ((int)0x00000002),

        /// <summary>
        /// Original was GL_UNIFORM_BARRIER_BIT = 0x00000004
        /// </summary>
        UniformBarrierBit = ((int)0x00000004),

        /// <summary>
        /// Original was GL_UNIFORM_BARRIER_BIT_EXT = 0x00000004
        /// </summary>
        UniformBarrierBitExt = ((int)0x00000004),

        /// <summary>
        /// Original was GL_TEXTURE_FETCH_BARRIER_BIT = 0x00000008
        /// </summary>
        TextureFetchBarrierBit = ((int)0x00000008),

        /// <summary>
        /// Original was GL_TEXTURE_FETCH_BARRIER_BIT_EXT = 0x00000008
        /// </summary>
        TextureFetchBarrierBitExt = ((int)0x00000008),

        /// <summary>
        /// Original was GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV = 0x00000010
        /// </summary>
        ShaderGlobalAccessBarrierBitNv = ((int)0x00000010),

        /// <summary>
        /// Original was GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020
        /// </summary>
        ShaderImageAccessBarrierBit = ((int)0x00000020),

        /// <summary>
        /// Original was GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT = 0x00000020
        /// </summary>
        ShaderImageAccessBarrierBitExt = ((int)0x00000020),

        /// <summary>
        /// Original was GL_COMMAND_BARRIER_BIT = 0x00000040
        /// </summary>
        CommandBarrierBit = ((int)0x00000040),

        /// <summary>
        /// Original was GL_COMMAND_BARRIER_BIT_EXT = 0x00000040
        /// </summary>
        CommandBarrierBitExt = ((int)0x00000040),

        /// <summary>
        /// Original was GL_PIXEL_BUFFER_BARRIER_BIT = 0x00000080
        /// </summary>
        PixelBufferBarrierBit = ((int)0x00000080),

        /// <summary>
        /// Original was GL_PIXEL_BUFFER_BARRIER_BIT_EXT = 0x00000080
        /// </summary>
        PixelBufferBarrierBitExt = ((int)0x00000080),

        /// <summary>
        /// Original was GL_TEXTURE_UPDATE_BARRIER_BIT = 0x00000100
        /// </summary>
        TextureUpdateBarrierBit = ((int)0x00000100),

        /// <summary>
        /// Original was GL_TEXTURE_UPDATE_BARRIER_BIT_EXT = 0x00000100
        /// </summary>
        TextureUpdateBarrierBitExt = ((int)0x00000100),

        /// <summary>
        /// Original was GL_BUFFER_UPDATE_BARRIER_BIT = 0x00000200
        /// </summary>
        BufferUpdateBarrierBit = ((int)0x00000200),

        /// <summary>
        /// Original was GL_BUFFER_UPDATE_BARRIER_BIT_EXT = 0x00000200
        /// </summary>
        BufferUpdateBarrierBitExt = ((int)0x00000200),

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BARRIER_BIT = 0x00000400
        /// </summary>
        FramebufferBarrierBit = ((int)0x00000400),

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BARRIER_BIT_EXT = 0x00000400
        /// </summary>
        FramebufferBarrierBitExt = ((int)0x00000400),

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800
        /// </summary>
        TransformFeedbackBarrierBit = ((int)0x00000800),

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT = 0x00000800
        /// </summary>
        TransformFeedbackBarrierBitExt = ((int)0x00000800),

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BARRIER_BIT = 0x00001000
        /// </summary>
        AtomicCounterBarrierBit = ((int)0x00001000),

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BARRIER_BIT_EXT = 0x00001000
        /// </summary>
        AtomicCounterBarrierBitExt = ((int)0x00001000),

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000
        /// </summary>
        ShaderStorageBarrierBit = ((int)0x00002000),

        /// <summary>
        /// Original was GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000
        /// </summary>
        ClientMappedBufferBarrierBit = ((int)0x00004000),

        /// <summary>
        /// Original was GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT = 0x00004000
        /// </summary>
        ClientMappedBufferBarrierBitExt = ((int)0x00004000),

        /// <summary>
        /// Original was GL_QUERY_BUFFER_BARRIER_BIT = 0x00008000
        /// </summary>
        QueryBufferBarrierBit = ((int)0x00008000),

        /// <summary>
        /// Original was GL_ALL_BARRIER_BITS = 0xFFFFFFFF
        /// </summary>
        AllBarrierBits = unchecked((int)0xffffffff),

        /// <summary>
        /// Original was GL_ALL_BARRIER_BITS_EXT = 0xFFFFFFFF
        /// </summary>
        AllBarrierBitsExt = unchecked((int)0xffffffff),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MemoryObjectParameterName
    {
        /// <summary>
        /// Original was GL_DEDICATED_MEMORY_OBJECT_EXT = 0x9581
        /// </summary>
        DedicatedMemoryObjectExt = 0x9581,

        /// <summary>
        /// Original was GL_PROTECTED_MEMORY_OBJECT_EXT = 0x959B
        /// </summary>
        ProtectedMemoryObjectExt = 0x959b,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MeshMode1
    {
        /// <summary>
        /// Original was GL_POINT = 0x1B00
        /// </summary>
        Point = 0x1b00,

        /// <summary>
        /// Original was GL_LINE = 0x1B01
        /// </summary>
        Line = 0x1b01,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MeshMode2
    {
        /// <summary>
        /// Original was GL_POINT = 0x1B00
        /// </summary>
        Point = 0x1b00,

        /// <summary>
        /// Original was GL_LINE = 0x1B01
        /// </summary>
        Line = 0x1b01,

        /// <summary>
        /// Original was GL_FILL = 0x1B02
        /// </summary>
        Fill = 0x1b02,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MinmaxTargetExt
    {
        /// <summary>
        /// Original was GL_MINMAX = 0x802E
        /// </summary>
        Minmax = 0x802e,

        /// <summary>
        /// Original was GL_MINMAX_EXT = 0x802E
        /// </summary>
        MinmaxExt = 0x802e,
    }

    /// <summary>
    /// Used in GL.NormalPointer
    /// </summary>
    public enum NormalPointerType
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = 0x1400,

        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = 0x1402,

        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = 0x1404,

        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = 0x140a,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum Nvfence
    {
        /// <summary>
        /// Original was GL_ALL_COMPLETED_NV = 0x84F2
        /// </summary>
        AllCompletedNv = 0x84f2,

        /// <summary>
        /// Original was GL_FENCE_STATUS_NV = 0x84F3
        /// </summary>
        FenceStatusNv = 0x84f3,

        /// <summary>
        /// Original was GL_FENCE_CONDITION_NV = 0x84F4
        /// </summary>
        FenceConditionNv = 0x84f4,

        /// <summary>
        /// Original was GL_NV_fence = 1
        /// </summary>
        NvFence = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvFence
    {
        /// <summary>
        /// Original was GL_ALL_COMPLETED_NV = 0x84F2
        /// </summary>
        AllCompletedNv = 0x84f2,

        /// <summary>
        /// Original was GL_FENCE_STATUS_NV = 0x84F3
        /// </summary>
        FenceStatusNv = 0x84f3,

        /// <summary>
        /// Original was GL_FENCE_CONDITION_NV = 0x84F4
        /// </summary>
        FenceConditionNv = 0x84f4,
    }

    /// <summary>
    /// Used in GL.ObjectLabel, GL.Khr.ObjectLabel
    /// </summary>
    public enum ObjectIdentifier
    {
        /// <summary>
        /// Original was GL_TEXTURE = 0x1702
        /// </summary>
        Texture = 0x1702,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = 0x8074,

        /// <summary>
        /// Original was GL_BUFFER = 0x82E0
        /// </summary>
        Buffer = 0x82e0,

        /// <summary>
        /// Original was GL_SHADER = 0x82E1
        /// </summary>
        Shader = 0x82e1,

        /// <summary>
        /// Original was GL_PROGRAM = 0x82E2
        /// </summary>
        Program = 0x82e2,

        /// <summary>
        /// Original was GL_QUERY = 0x82E3
        /// </summary>
        Query = 0x82e3,

        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE = 0x82E4
        /// </summary>
        ProgramPipeline = 0x82e4,

        /// <summary>
        /// Original was GL_SAMPLER = 0x82E6
        /// </summary>
        Sampler = 0x82e6,

        /// <summary>
        /// Original was GL_FRAMEBUFFER = 0x8D40
        /// </summary>
        Framebuffer = 0x8d40,

        /// <summary>
        /// Original was GL_RENDERBUFFER = 0x8D41
        /// </summary>
        Renderbuffer = 0x8d41,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK = 0x8E22
        /// </summary>
        TransformFeedback = 0x8e22,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum OcclusionQueryEventMaskAmd
    {
        /// <summary>
        /// Original was GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD = 0x00000001
        /// </summary>
        QueryDepthPassEventBitAmd = ((int)0x00000001),

        /// <summary>
        /// Original was GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD = 0x00000002
        /// </summary>
        QueryDepthFailEventBitAmd = ((int)0x00000002),

        /// <summary>
        /// Original was GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD = 0x00000004
        /// </summary>
        QueryStencilFailEventBitAmd = ((int)0x00000004),

        /// <summary>
        /// Original was GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD = 0x00000008
        /// </summary>
        QueryDepthBoundsFailEventBitAmd = ((int)0x00000008),

        /// <summary>
        /// Original was GL_QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF
        /// </summary>
        QueryAllEventBitsAmd = unchecked((int)0xffffffff),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OesblendEquationSeparate
    {
        /// <summary>
        /// Original was GL_BLEND_EQUATION_RGB_OES = 0x8009
        /// </summary>
        BlendEquationRgbOes = 0x8009,

        /// <summary>
        /// Original was GL_BLEND_EQUATION_ALPHA_OES = 0x883D
        /// </summary>
        BlendEquationAlphaOes = 0x883d,

        /// <summary>
        /// Original was GL_OES_blend_equation_separate = 1
        /// </summary>
        OesBlendEquationSeparate = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesBlendEquationSeparate
    {
        /// <summary>
        /// Original was GL_BLEND_EQUATION_RGB_OES = 0x8009
        /// </summary>
        BlendEquationRgbOes = 0x8009,

        /// <summary>
        /// Original was GL_BLEND_EQUATION_ALPHA_OES = 0x883D
        /// </summary>
        BlendEquationAlphaOes = 0x883d,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OesblendFuncSeparate
    {
        /// <summary>
        /// Original was GL_BLEND_DST_RGB_OES = 0x80C8
        /// </summary>
        BlendDstRgbOes = 0x80c8,

        /// <summary>
        /// Original was GL_BLEND_SRC_RGB_OES = 0x80C9
        /// </summary>
        BlendSrcRgbOes = 0x80c9,

        /// <summary>
        /// Original was GL_BLEND_DST_ALPHA_OES = 0x80CA
        /// </summary>
        BlendDstAlphaOes = 0x80ca,

        /// <summary>
        /// Original was GL_BLEND_SRC_ALPHA_OES = 0x80CB
        /// </summary>
        BlendSrcAlphaOes = 0x80cb,

        /// <summary>
        /// Original was GL_OES_blend_func_separate = 1
        /// </summary>
        OesBlendFuncSeparate = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesBlendFuncSeparate
    {
        /// <summary>
        /// Original was GL_BLEND_DST_RGB_OES = 0x80C8
        /// </summary>
        BlendDstRgbOes = 0x80c8,

        /// <summary>
        /// Original was GL_BLEND_SRC_RGB_OES = 0x80C9
        /// </summary>
        BlendSrcRgbOes = 0x80c9,

        /// <summary>
        /// Original was GL_BLEND_DST_ALPHA_OES = 0x80CA
        /// </summary>
        BlendDstAlphaOes = 0x80ca,

        /// <summary>
        /// Original was GL_BLEND_SRC_ALPHA_OES = 0x80CB
        /// </summary>
        BlendSrcAlphaOes = 0x80cb,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OesblendSubtract
    {
        /// <summary>
        /// Original was GL_FUNC_ADD_OES = 0x8006
        /// </summary>
        FuncAddOes = 0x8006,

        /// <summary>
        /// Original was GL_BLEND_EQUATION_OES = 0x8009
        /// </summary>
        BlendEquationOes = 0x8009,

        /// <summary>
        /// Original was GL_FUNC_SUBTRACT_OES = 0x800A
        /// </summary>
        FuncSubtractOes = 0x800a,

        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT_OES = 0x800B
        /// </summary>
        FuncReverseSubtractOes = 0x800b,

        /// <summary>
        /// Original was GL_OES_blend_subtract = 1
        /// </summary>
        OesBlendSubtract = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesBlendSubtract
    {
        /// <summary>
        /// Original was GL_FUNC_ADD_OES = 0x8006
        /// </summary>
        FuncAddOes = 0x8006,

        /// <summary>
        /// Original was GL_BLEND_EQUATION_OES = 0x8009
        /// </summary>
        BlendEquationOes = 0x8009,

        /// <summary>
        /// Original was GL_FUNC_SUBTRACT_OES = 0x800A
        /// </summary>
        FuncSubtractOes = 0x800a,

        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT_OES = 0x800B
        /// </summary>
        FuncReverseSubtractOes = 0x800b,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OesbyteCoordinates
    {
        /// <summary>
        /// Original was GL_OES_byte_coordinates = 1
        /// </summary>
        OesByteCoordinates = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesByteCoordinates
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = 0x1400,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesCompressedEtc1Rgb8SubTexture
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OescompressedEtc1Rgb8Texture
    {
        /// <summary>
        /// Original was GL_ETC1_RGB8_OES = 0x8D64
        /// </summary>
        Etc1Rgb8Oes = 0x8d64,

        /// <summary>
        /// Original was GL_OES_compressed_ETC1_RGB8_texture = 1
        /// </summary>
        OesCompressedEtc1Rgb8Texture = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesCompressedEtc1Rgb8Texture
    {
        /// <summary>
        /// Original was GL_ETC1_RGB8_OES = 0x8D64
        /// </summary>
        Etc1Rgb8Oes = 0x8d64,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OescompressedPalettedTexture
    {
        /// <summary>
        /// Original was GL_PALETTE4_RGB8_OES = 0x8B90
        /// </summary>
        Palette4Rgb8Oes = 0x8b90,

        /// <summary>
        /// Original was GL_PALETTE4_RGBA8_OES = 0x8B91
        /// </summary>
        Palette4Rgba8Oes = 0x8b91,

        /// <summary>
        /// Original was GL_PALETTE4_R5_G6_B5_OES = 0x8B92
        /// </summary>
        Palette4R5G6B5Oes = 0x8b92,

        /// <summary>
        /// Original was GL_PALETTE4_RGBA4_OES = 0x8B93
        /// </summary>
        Palette4Rgba4Oes = 0x8b93,

        /// <summary>
        /// Original was GL_PALETTE4_RGB5_A1_OES = 0x8B94
        /// </summary>
        Palette4Rgb5A1Oes = 0x8b94,

        /// <summary>
        /// Original was GL_PALETTE8_RGB8_OES = 0x8B95
        /// </summary>
        Palette8Rgb8Oes = 0x8b95,

        /// <summary>
        /// Original was GL_PALETTE8_RGBA8_OES = 0x8B96
        /// </summary>
        Palette8Rgba8Oes = 0x8b96,

        /// <summary>
        /// Original was GL_PALETTE8_R5_G6_B5_OES = 0x8B97
        /// </summary>
        Palette8R5G6B5Oes = 0x8b97,

        /// <summary>
        /// Original was GL_PALETTE8_RGBA4_OES = 0x8B98
        /// </summary>
        Palette8Rgba4Oes = 0x8b98,

        /// <summary>
        /// Original was GL_PALETTE8_RGB5_A1_OES = 0x8B99
        /// </summary>
        Palette8Rgb5A1Oes = 0x8b99,

        /// <summary>
        /// Original was GL_OES_compressed_paletted_texture = 1
        /// </summary>
        OesCompressedPalettedTexture = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesCompressedPalettedTexture
    {
        /// <summary>
        /// Original was GL_PALETTE4_RGB8_OES = 0x8B90
        /// </summary>
        Palette4Rgb8Oes = 0x8b90,

        /// <summary>
        /// Original was GL_PALETTE4_RGBA8_OES = 0x8B91
        /// </summary>
        Palette4Rgba8Oes = 0x8b91,

        /// <summary>
        /// Original was GL_PALETTE4_R5_G6_B5_OES = 0x8B92
        /// </summary>
        Palette4R5G6B5Oes = 0x8b92,

        /// <summary>
        /// Original was GL_PALETTE4_RGBA4_OES = 0x8B93
        /// </summary>
        Palette4Rgba4Oes = 0x8b93,

        /// <summary>
        /// Original was GL_PALETTE4_RGB5_A1_OES = 0x8B94
        /// </summary>
        Palette4Rgb5A1Oes = 0x8b94,

        /// <summary>
        /// Original was GL_PALETTE8_RGB8_OES = 0x8B95
        /// </summary>
        Palette8Rgb8Oes = 0x8b95,

        /// <summary>
        /// Original was GL_PALETTE8_RGBA8_OES = 0x8B96
        /// </summary>
        Palette8Rgba8Oes = 0x8b96,

        /// <summary>
        /// Original was GL_PALETTE8_R5_G6_B5_OES = 0x8B97
        /// </summary>
        Palette8R5G6B5Oes = 0x8b97,

        /// <summary>
        /// Original was GL_PALETTE8_RGBA4_OES = 0x8B98
        /// </summary>
        Palette8Rgba4Oes = 0x8b98,

        /// <summary>
        /// Original was GL_PALETTE8_RGB5_A1_OES = 0x8B99
        /// </summary>
        Palette8Rgb5A1Oes = 0x8b99,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum Oesdepth24
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_OES = 0x81A6
        /// </summary>
        DepthComponent24Oes = 0x81a6,

        /// <summary>
        /// Original was GL_OES_depth24 = 1
        /// </summary>
        OesDepth24 = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesDepth24
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_OES = 0x81A6
        /// </summary>
        DepthComponent24Oes = 0x81a6,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum Oesdepth32
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        /// </summary>
        DepthComponent32Oes = 0x81a7,

        /// <summary>
        /// Original was GL_OES_depth32 = 1
        /// </summary>
        OesDepth32 = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesDepth32
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        /// </summary>
        DepthComponent32Oes = 0x81a7,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OesdrawTexture
    {
        /// <summary>
        /// Original was GL_TEXTURE_CROP_RECT_OES = 0x8B9D
        /// </summary>
        TextureCropRectOes = 0x8b9d,

        /// <summary>
        /// Original was GL_OES_draw_texture = 1
        /// </summary>
        OesDrawTexture = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesDrawTexture
    {
        /// <summary>
        /// Original was GL_TEXTURE_CROP_RECT_OES = 0x8B9D
        /// </summary>
        TextureCropRectOes = 0x8b9d,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum Oeseglimage
    {
        /// <summary>
        /// Original was GL_OES_EGL_image = 1
        /// </summary>
        OesEglImage = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesEglImage
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesEglImageExternal
    {
        /// <summary>
        /// Original was GL_TEXTURE_EXTERNAL_OES = 0x8D65
        /// </summary>
        TextureExternalOes = 0x8d65,

        /// <summary>
        /// Original was GL_SAMPLER_EXTERNAL_OES = 0x8D66
        /// </summary>
        SamplerExternalOes = 0x8d66,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_EXTERNAL_OES = 0x8D67
        /// </summary>
        TextureBindingExternalOes = 0x8d67,

        /// <summary>
        /// Original was GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES = 0x8D68
        /// </summary>
        RequiredTextureImageUnitsOes = 0x8d68,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OeselementIndexUint
    {
        /// <summary>
        /// Original was GL_OES_element_index_uint = 1
        /// </summary>
        OesElementIndexUint = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesElementIndexUint
    {
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = 0x1405,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OesextendedMatrixPalette
    {
        /// <summary>
        /// Original was GL_OES_extended_matrix_palette = 1
        /// </summary>
        OesExtendedMatrixPalette = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesExtendedMatrixPalette
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OesfboRenderMipmap
    {
        /// <summary>
        /// Original was GL_OES_fbo_render_mipmap = 1
        /// </summary>
        OesFboRenderMipmap = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesFboRenderMipmap
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OesfixedPoint
    {
        /// <summary>
        /// Original was GL_FIXED_OES = 0x140C
        /// </summary>
        FixedOes = 0x140c,

        /// <summary>
        /// Original was GL_OES_fixed_point = 1
        /// </summary>
        OesFixedPoint = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesFixedPoint
    {
        /// <summary>
        /// Original was GL_FIXED_OES = 0x140C
        /// </summary>
        FixedOes = 0x140c,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OesframebufferObject
    {
        /// <summary>
        /// Original was GL_NONE_OES = 0
        /// </summary>
        NoneOes = 0,

        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506
        /// </summary>
        InvalidFramebufferOperationOes = 0x0506,

        /// <summary>
        /// Original was GL_RGBA4_OES = 0x8056
        /// </summary>
        Rgba4Oes = 0x8056,

        /// <summary>
        /// Original was GL_RGB5_A1_OES = 0x8057
        /// </summary>
        Rgb5A1Oes = 0x8057,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_OES = 0x81A5
        /// </summary>
        DepthComponent16Oes = 0x81a5,

        /// <summary>
        /// Original was GL_MAX_RENDERBUFFER_SIZE_OES = 0x84E8
        /// </summary>
        MaxRenderbufferSizeOes = 0x84e8,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BINDING_OES = 0x8CA6
        /// </summary>
        FramebufferBindingOes = 0x8ca6,

        /// <summary>
        /// Original was GL_RENDERBUFFER_BINDING_OES = 0x8CA7
        /// </summary>
        RenderbufferBindingOes = 0x8ca7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES = 0x8CD0
        /// </summary>
        FramebufferAttachmentObjectTypeOes = 0x8cd0,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectNameOes = 0x8cd1,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevelOes = 0x8cd2,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFaceOes = 0x8cd3,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE_OES = 0x8CD5
        /// </summary>
        FramebufferCompleteOes = 0x8cd5,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachmentOes = 0x8cd6,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachmentOes = 0x8cd7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES = 0x8CD9
        /// </summary>
        FramebufferIncompleteDimensionsOes = 0x8cd9,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES = 0x8CDA
        /// </summary>
        FramebufferIncompleteFormatsOes = 0x8cda,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED_OES = 0x8CDD
        /// </summary>
        FramebufferUnsupportedOes = 0x8cdd,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_OES = 0x8CE0
        /// </summary>
        ColorAttachment0Oes = 0x8ce0,

        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_OES = 0x8D00
        /// </summary>
        DepthAttachmentOes = 0x8d00,

        /// <summary>
        /// Original was GL_STENCIL_ATTACHMENT_OES = 0x8D20
        /// </summary>
        StencilAttachmentOes = 0x8d20,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_OES = 0x8D40
        /// </summary>
        FramebufferOes = 0x8d40,

        /// <summary>
        /// Original was GL_RENDERBUFFER_OES = 0x8D41
        /// </summary>
        RenderbufferOes = 0x8d41,

        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH_OES = 0x8D42
        /// </summary>
        RenderbufferWidthOes = 0x8d42,

        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT_OES = 0x8D43
        /// </summary>
        RenderbufferHeightOes = 0x8d43,

        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT_OES = 0x8D44
        /// </summary>
        RenderbufferInternalFormatOes = 0x8d44,

        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE_OES = 0x8D50
        /// </summary>
        RenderbufferRedSizeOes = 0x8d50,

        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE_OES = 0x8D51
        /// </summary>
        RenderbufferGreenSizeOes = 0x8d51,

        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE_OES = 0x8D52
        /// </summary>
        RenderbufferBlueSizeOes = 0x8d52,

        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE_OES = 0x8D53
        /// </summary>
        RenderbufferAlphaSizeOes = 0x8d53,

        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE_OES = 0x8D54
        /// </summary>
        RenderbufferDepthSizeOes = 0x8d54,

        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE_OES = 0x8D55
        /// </summary>
        RenderbufferStencilSizeOes = 0x8d55,

        /// <summary>
        /// Original was GL_RGB565_OES = 0x8D62
        /// </summary>
        Rgb565Oes = 0x8d62,

        /// <summary>
        /// Original was GL_OES_framebuffer_object = 1
        /// </summary>
        OesFramebufferObject = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesFramebufferObject
    {
        /// <summary>
        /// Original was GL_NONE_OES = 0
        /// </summary>
        NoneOes = 0,

        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506
        /// </summary>
        InvalidFramebufferOperationOes = 0x0506,

        /// <summary>
        /// Original was GL_RGBA4_OES = 0x8056
        /// </summary>
        Rgba4Oes = 0x8056,

        /// <summary>
        /// Original was GL_RGB5_A1_OES = 0x8057
        /// </summary>
        Rgb5A1Oes = 0x8057,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_OES = 0x81A5
        /// </summary>
        DepthComponent16Oes = 0x81a5,

        /// <summary>
        /// Original was GL_MAX_RENDERBUFFER_SIZE_OES = 0x84E8
        /// </summary>
        MaxRenderbufferSizeOes = 0x84e8,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BINDING_OES = 0x8CA6
        /// </summary>
        FramebufferBindingOes = 0x8ca6,

        /// <summary>
        /// Original was GL_RENDERBUFFER_BINDING_OES = 0x8CA7
        /// </summary>
        RenderbufferBindingOes = 0x8ca7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES = 0x8CD0
        /// </summary>
        FramebufferAttachmentObjectTypeOes = 0x8cd0,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectNameOes = 0x8cd1,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevelOes = 0x8cd2,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFaceOes = 0x8cd3,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE_OES = 0x8CD5
        /// </summary>
        FramebufferCompleteOes = 0x8cd5,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachmentOes = 0x8cd6,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachmentOes = 0x8cd7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES = 0x8CD9
        /// </summary>
        FramebufferIncompleteDimensionsOes = 0x8cd9,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES = 0x8CDA
        /// </summary>
        FramebufferIncompleteFormatsOes = 0x8cda,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED_OES = 0x8CDD
        /// </summary>
        FramebufferUnsupportedOes = 0x8cdd,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_OES = 0x8CE0
        /// </summary>
        ColorAttachment0Oes = 0x8ce0,

        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_OES = 0x8D00
        /// </summary>
        DepthAttachmentOes = 0x8d00,

        /// <summary>
        /// Original was GL_STENCIL_ATTACHMENT_OES = 0x8D20
        /// </summary>
        StencilAttachmentOes = 0x8d20,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_OES = 0x8D40
        /// </summary>
        FramebufferOes = 0x8d40,

        /// <summary>
        /// Original was GL_RENDERBUFFER_OES = 0x8D41
        /// </summary>
        RenderbufferOes = 0x8d41,

        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH_OES = 0x8D42
        /// </summary>
        RenderbufferWidthOes = 0x8d42,

        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT_OES = 0x8D43
        /// </summary>
        RenderbufferHeightOes = 0x8d43,

        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT_OES = 0x8D44
        /// </summary>
        RenderbufferInternalFormatOes = 0x8d44,

        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE_OES = 0x8D50
        /// </summary>
        RenderbufferRedSizeOes = 0x8d50,

        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE_OES = 0x8D51
        /// </summary>
        RenderbufferGreenSizeOes = 0x8d51,

        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE_OES = 0x8D52
        /// </summary>
        RenderbufferBlueSizeOes = 0x8d52,

        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE_OES = 0x8D53
        /// </summary>
        RenderbufferAlphaSizeOes = 0x8d53,

        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE_OES = 0x8D54
        /// </summary>
        RenderbufferDepthSizeOes = 0x8d54,

        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE_OES = 0x8D55
        /// </summary>
        RenderbufferStencilSizeOes = 0x8d55,

        /// <summary>
        /// Original was GL_RGB565_OES = 0x8D62
        /// </summary>
        Rgb565Oes = 0x8d62,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum Oesmapbuffer
    {
        /// <summary>
        /// Original was GL_WRITE_ONLY_OES = 0x88B9
        /// </summary>
        WriteOnlyOes = 0x88b9,

        /// <summary>
        /// Original was GL_BUFFER_ACCESS_OES = 0x88BB
        /// </summary>
        BufferAccessOes = 0x88bb,

        /// <summary>
        /// Original was GL_BUFFER_MAPPED_OES = 0x88BC
        /// </summary>
        BufferMappedOes = 0x88bc,

        /// <summary>
        /// Original was GL_BUFFER_MAP_POINTER_OES = 0x88BD
        /// </summary>
        BufferMapPointerOes = 0x88bd,

        /// <summary>
        /// Original was GL_OES_mapbuffer = 1
        /// </summary>
        OesMapbuffer = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesMapbuffer
    {
        /// <summary>
        /// Original was GL_WRITE_ONLY_OES = 0x88B9
        /// </summary>
        WriteOnlyOes = 0x88b9,

        /// <summary>
        /// Original was GL_BUFFER_ACCESS_OES = 0x88BB
        /// </summary>
        BufferAccessOes = 0x88bb,

        /// <summary>
        /// Original was GL_BUFFER_MAPPED_OES = 0x88BC
        /// </summary>
        BufferMappedOes = 0x88bc,

        /// <summary>
        /// Original was GL_BUFFER_MAP_POINTER_OES = 0x88BD
        /// </summary>
        BufferMapPointerOes = 0x88bd,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OesmatrixGet
    {
        /// <summary>
        /// Original was GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898D
        /// </summary>
        ModelviewMatrixFloatAsIntBitsOes = 0x898d,

        /// <summary>
        /// Original was GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898E
        /// </summary>
        ProjectionMatrixFloatAsIntBitsOes = 0x898e,

        /// <summary>
        /// Original was GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898F
        /// </summary>
        TextureMatrixFloatAsIntBitsOes = 0x898f,

        /// <summary>
        /// Original was GL_OES_matrix_get = 1
        /// </summary>
        OesMatrixGet = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesMatrixGet
    {
        /// <summary>
        /// Original was GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898D
        /// </summary>
        ModelviewMatrixFloatAsIntBitsOes = 0x898d,

        /// <summary>
        /// Original was GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898E
        /// </summary>
        ProjectionMatrixFloatAsIntBitsOes = 0x898e,

        /// <summary>
        /// Original was GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898F
        /// </summary>
        TextureMatrixFloatAsIntBitsOes = 0x898f,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OesmatrixPalette
    {
        /// <summary>
        /// Original was GL_MAX_VERTEX_UNITS_OES = 0x86A4
        /// </summary>
        MaxVertexUnitsOes = 0x86a4,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_TYPE_OES = 0x86A9
        /// </summary>
        WeightArrayTypeOes = 0x86a9,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_STRIDE_OES = 0x86AA
        /// </summary>
        WeightArrayStrideOes = 0x86aa,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_SIZE_OES = 0x86AB
        /// </summary>
        WeightArraySizeOes = 0x86ab,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_POINTER_OES = 0x86AC
        /// </summary>
        WeightArrayPointerOes = 0x86ac,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_OES = 0x86AD
        /// </summary>
        WeightArrayOes = 0x86ad,

        /// <summary>
        /// Original was GL_MATRIX_PALETTE_OES = 0x8840
        /// </summary>
        MatrixPaletteOes = 0x8840,

        /// <summary>
        /// Original was GL_MAX_PALETTE_MATRICES_OES = 0x8842
        /// </summary>
        MaxPaletteMatricesOes = 0x8842,

        /// <summary>
        /// Original was GL_CURRENT_PALETTE_MATRIX_OES = 0x8843
        /// </summary>
        CurrentPaletteMatrixOes = 0x8843,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_OES = 0x8844
        /// </summary>
        MatrixIndexArrayOes = 0x8844,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_SIZE_OES = 0x8846
        /// </summary>
        MatrixIndexArraySizeOes = 0x8846,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_TYPE_OES = 0x8847
        /// </summary>
        MatrixIndexArrayTypeOes = 0x8847,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_STRIDE_OES = 0x8848
        /// </summary>
        MatrixIndexArrayStrideOes = 0x8848,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_POINTER_OES = 0x8849
        /// </summary>
        MatrixIndexArrayPointerOes = 0x8849,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_BUFFER_BINDING_OES = 0x889E
        /// </summary>
        WeightArrayBufferBindingOes = 0x889e,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES = 0x8B9E
        /// </summary>
        MatrixIndexArrayBufferBindingOes = 0x8b9e,

        /// <summary>
        /// Original was GL_OES_matrix_palette = 1
        /// </summary>
        OesMatrixPalette = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesMatrixPalette
    {
        /// <summary>
        /// Original was GL_MAX_VERTEX_UNITS_OES = 0x86A4
        /// </summary>
        MaxVertexUnitsOes = 0x86a4,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_TYPE_OES = 0x86A9
        /// </summary>
        WeightArrayTypeOes = 0x86a9,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_STRIDE_OES = 0x86AA
        /// </summary>
        WeightArrayStrideOes = 0x86aa,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_SIZE_OES = 0x86AB
        /// </summary>
        WeightArraySizeOes = 0x86ab,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_POINTER_OES = 0x86AC
        /// </summary>
        WeightArrayPointerOes = 0x86ac,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_OES = 0x86AD
        /// </summary>
        WeightArrayOes = 0x86ad,

        /// <summary>
        /// Original was GL_MATRIX_PALETTE_OES = 0x8840
        /// </summary>
        MatrixPaletteOes = 0x8840,

        /// <summary>
        /// Original was GL_MAX_PALETTE_MATRICES_OES = 0x8842
        /// </summary>
        MaxPaletteMatricesOes = 0x8842,

        /// <summary>
        /// Original was GL_CURRENT_PALETTE_MATRIX_OES = 0x8843
        /// </summary>
        CurrentPaletteMatrixOes = 0x8843,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_OES = 0x8844
        /// </summary>
        MatrixIndexArrayOes = 0x8844,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_SIZE_OES = 0x8846
        /// </summary>
        MatrixIndexArraySizeOes = 0x8846,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_TYPE_OES = 0x8847
        /// </summary>
        MatrixIndexArrayTypeOes = 0x8847,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_STRIDE_OES = 0x8848
        /// </summary>
        MatrixIndexArrayStrideOes = 0x8848,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_POINTER_OES = 0x8849
        /// </summary>
        MatrixIndexArrayPointerOes = 0x8849,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_BUFFER_BINDING_OES = 0x889E
        /// </summary>
        WeightArrayBufferBindingOes = 0x889e,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES = 0x8B9E
        /// </summary>
        MatrixIndexArrayBufferBindingOes = 0x8b9e,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OespackedDepthStencil
    {
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_OES = 0x84F9
        /// </summary>
        DepthStencilOes = 0x84f9,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_24_8_OES = 0x84FA
        /// </summary>
        UnsignedInt248Oes = 0x84fa,

        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        /// </summary>
        Depth24Stencil8Oes = 0x88f0,

        /// <summary>
        /// Original was GL_OES_packed_depth_stencil = 1
        /// </summary>
        OesPackedDepthStencil = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesPackedDepthStencil
    {
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_OES = 0x84F9
        /// </summary>
        DepthStencilOes = 0x84f9,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_24_8_OES = 0x84FA
        /// </summary>
        UnsignedInt248Oes = 0x84fa,

        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        /// </summary>
        Depth24Stencil8Oes = 0x88f0,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OespointSizeArray
    {
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_TYPE_OES = 0x898A
        /// </summary>
        PointSizeArrayTypeOes = 0x898a,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_STRIDE_OES = 0x898B
        /// </summary>
        PointSizeArrayStrideOes = 0x898b,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_POINTER_OES = 0x898C
        /// </summary>
        PointSizeArrayPointerOes = 0x898c,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_OES = 0x8B9C
        /// </summary>
        PointSizeArrayOes = 0x8b9c,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES = 0x8B9F
        /// </summary>
        PointSizeArrayBufferBindingOes = 0x8b9f,

        /// <summary>
        /// Original was GL_OES_point_size_array = 1
        /// </summary>
        OesPointSizeArray = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesPointSizeArray
    {
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_TYPE_OES = 0x898A
        /// </summary>
        PointSizeArrayTypeOes = 0x898a,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_STRIDE_OES = 0x898B
        /// </summary>
        PointSizeArrayStrideOes = 0x898b,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_POINTER_OES = 0x898C
        /// </summary>
        PointSizeArrayPointerOes = 0x898c,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_OES = 0x8B9C
        /// </summary>
        PointSizeArrayOes = 0x8b9c,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES = 0x8B9F
        /// </summary>
        PointSizeArrayBufferBindingOes = 0x8b9f,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OespointSprite
    {
        /// <summary>
        /// Original was GL_POINT_SPRITE_OES = 0x8861
        /// </summary>
        PointSpriteOes = 0x8861,

        /// <summary>
        /// Original was GL_COORD_REPLACE_OES = 0x8862
        /// </summary>
        CoordReplaceOes = 0x8862,

        /// <summary>
        /// Original was GL_OES_point_sprite = 1
        /// </summary>
        OesPointSprite = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesPointSprite
    {
        /// <summary>
        /// Original was GL_POINT_SPRITE_OES = 0x8861
        /// </summary>
        PointSpriteOes = 0x8861,

        /// <summary>
        /// Original was GL_COORD_REPLACE_OES = 0x8862
        /// </summary>
        CoordReplaceOes = 0x8862,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OesqueryMatrix
    {
        /// <summary>
        /// Original was GL_OES_query_matrix = 1
        /// </summary>
        OesQueryMatrix = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesQueryMatrix
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OesreadFormat
    {
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_TYPE_OES = 0x8B9A
        /// </summary>
        ImplementationColorReadTypeOes = 0x8b9a,

        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES = 0x8B9B
        /// </summary>
        ImplementationColorReadFormatOes = 0x8b9b,

        /// <summary>
        /// Original was GL_OES_read_format = 1
        /// </summary>
        OesReadFormat = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesReadFormat
    {
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_TYPE_OES = 0x8B9A
        /// </summary>
        ImplementationColorReadTypeOes = 0x8b9a,

        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES = 0x8B9B
        /// </summary>
        ImplementationColorReadFormatOes = 0x8b9b,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesRequiredInternalformat
    {
        /// <summary>
        /// Original was GL_ALPHA8_OES = 0x803C
        /// </summary>
        Alpha8Oes = 0x803c,

        /// <summary>
        /// Original was GL_LUMINANCE8_OES = 0x8040
        /// </summary>
        Luminance8Oes = 0x8040,

        /// <summary>
        /// Original was GL_LUMINANCE4_ALPHA4_OES = 0x8043
        /// </summary>
        Luminance4Alpha4Oes = 0x8043,

        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8_OES = 0x8045
        /// </summary>
        Luminance8Alpha8Oes = 0x8045,

        /// <summary>
        /// Original was GL_RGB8_OES = 0x8051
        /// </summary>
        Rgb8Oes = 0x8051,

        /// <summary>
        /// Original was GL_RGB10_EXT = 0x8052
        /// </summary>
        Rgb10Ext = 0x8052,

        /// <summary>
        /// Original was GL_RGBA4_OES = 0x8056
        /// </summary>
        Rgba4Oes = 0x8056,

        /// <summary>
        /// Original was GL_RGB5_A1_OES = 0x8057
        /// </summary>
        Rgb5A1Oes = 0x8057,

        /// <summary>
        /// Original was GL_RGBA8_OES = 0x8058
        /// </summary>
        Rgba8Oes = 0x8058,

        /// <summary>
        /// Original was GL_RGB10_A2_EXT = 0x8059
        /// </summary>
        Rgb10A2Ext = 0x8059,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_OES = 0x81A5
        /// </summary>
        DepthComponent16Oes = 0x81a5,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_OES = 0x81A6
        /// </summary>
        DepthComponent24Oes = 0x81a6,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        /// </summary>
        DepthComponent32Oes = 0x81a7,

        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        /// </summary>
        Depth24Stencil8Oes = 0x88f0,

        /// <summary>
        /// Original was GL_RGB565_OES = 0x8D62
        /// </summary>
        Rgb565Oes = 0x8d62,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum Oesrgb8Rgba8
    {
        /// <summary>
        /// Original was GL_RGB8_OES = 0x8051
        /// </summary>
        Rgb8Oes = 0x8051,

        /// <summary>
        /// Original was GL_RGBA8_OES = 0x8058
        /// </summary>
        Rgba8Oes = 0x8058,

        /// <summary>
        /// Original was GL_OES_rgb8_rgba8 = 1
        /// </summary>
        OesRgb8Rgba8 = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesRgb8Rgba8
    {
        /// <summary>
        /// Original was GL_RGB8_OES = 0x8051
        /// </summary>
        Rgb8Oes = 0x8051,

        /// <summary>
        /// Original was GL_RGBA8_OES = 0x8058
        /// </summary>
        Rgba8Oes = 0x8058,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OessinglePrecision
    {
        /// <summary>
        /// Original was GL_OES_single_precision = 1
        /// </summary>
        OesSinglePrecision = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesSinglePrecision
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum Oesstencil1
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX1_OES = 0x8D46
        /// </summary>
        StencilIndex1Oes = 0x8d46,

        /// <summary>
        /// Original was GL_OES_stencil1 = 1
        /// </summary>
        OesStencil1 = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesStencil1
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX1_OES = 0x8D46
        /// </summary>
        StencilIndex1Oes = 0x8d46,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum Oesstencil4
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX4_OES = 0x8D47
        /// </summary>
        StencilIndex4Oes = 0x8d47,

        /// <summary>
        /// Original was GL_OES_stencil4 = 1
        /// </summary>
        OesStencil4 = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesStencil4
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX4_OES = 0x8D47
        /// </summary>
        StencilIndex4Oes = 0x8d47,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum Oesstencil8
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX8_OES = 0x8D48
        /// </summary>
        StencilIndex8Oes = 0x8d48,

        /// <summary>
        /// Original was GL_OES_stencil8 = 1
        /// </summary>
        OesStencil8 = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesStencil8
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX8_OES = 0x8D48
        /// </summary>
        StencilIndex8Oes = 0x8d48,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OesstencilWrap
    {
        /// <summary>
        /// Original was GL_INCR_WRAP_OES = 0x8507
        /// </summary>
        IncrWrapOes = 0x8507,

        /// <summary>
        /// Original was GL_DECR_WRAP_OES = 0x8508
        /// </summary>
        DecrWrapOes = 0x8508,

        /// <summary>
        /// Original was GL_OES_stencil_wrap = 1
        /// </summary>
        OesStencilWrap = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesStencilWrap
    {
        /// <summary>
        /// Original was GL_INCR_WRAP_OES = 0x8507
        /// </summary>
        IncrWrapOes = 0x8507,

        /// <summary>
        /// Original was GL_DECR_WRAP_OES = 0x8508
        /// </summary>
        DecrWrapOes = 0x8508,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesSurfacelessContext
    {
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNDEFINED_OES = 0x8219
        /// </summary>
        FramebufferUndefinedOes = 0x8219,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OestextureCubeMap
    {
        /// <summary>
        /// Original was GL_TEXTURE_GEN_MODE_OES = 0x2500
        /// </summary>
        TextureGenModeOes = 0x2500,

        /// <summary>
        /// Original was GL_NORMAL_MAP_OES = 0x8511
        /// </summary>
        NormalMapOes = 0x8511,

        /// <summary>
        /// Original was GL_REFLECTION_MAP_OES = 0x8512
        /// </summary>
        ReflectionMapOes = 0x8512,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_OES = 0x8513
        /// </summary>
        TextureCubeMapOes = 0x8513,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP_OES = 0x8514
        /// </summary>
        TextureBindingCubeMapOes = 0x8514,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES = 0x8515
        /// </summary>
        TextureCubeMapPositiveXOes = 0x8515,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES = 0x8516
        /// </summary>
        TextureCubeMapNegativeXOes = 0x8516,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES = 0x8517
        /// </summary>
        TextureCubeMapPositiveYOes = 0x8517,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES = 0x8518
        /// </summary>
        TextureCubeMapNegativeYOes = 0x8518,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES = 0x8519
        /// </summary>
        TextureCubeMapPositiveZOes = 0x8519,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES = 0x851A
        /// </summary>
        TextureCubeMapNegativeZOes = 0x851a,

        /// <summary>
        /// Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES = 0x851C
        /// </summary>
        MaxCubeMapTextureSizeOes = 0x851c,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_STR_OES = 0x8D60
        /// </summary>
        TextureGenStrOes = 0x8d60,

        /// <summary>
        /// Original was GL_OES_texture_cube_map = 1
        /// </summary>
        OesTextureCubeMap = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureCubeMap
    {
        /// <summary>
        /// Original was GL_TEXTURE_GEN_MODE_OES = 0x2500
        /// </summary>
        TextureGenModeOes = 0x2500,

        /// <summary>
        /// Original was GL_NORMAL_MAP_OES = 0x8511
        /// </summary>
        NormalMapOes = 0x8511,

        /// <summary>
        /// Original was GL_REFLECTION_MAP_OES = 0x8512
        /// </summary>
        ReflectionMapOes = 0x8512,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_OES = 0x8513
        /// </summary>
        TextureCubeMapOes = 0x8513,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP_OES = 0x8514
        /// </summary>
        TextureBindingCubeMapOes = 0x8514,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES = 0x8515
        /// </summary>
        TextureCubeMapPositiveXOes = 0x8515,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES = 0x8516
        /// </summary>
        TextureCubeMapNegativeXOes = 0x8516,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES = 0x8517
        /// </summary>
        TextureCubeMapPositiveYOes = 0x8517,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES = 0x8518
        /// </summary>
        TextureCubeMapNegativeYOes = 0x8518,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES = 0x8519
        /// </summary>
        TextureCubeMapPositiveZOes = 0x8519,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES = 0x851A
        /// </summary>
        TextureCubeMapNegativeZOes = 0x851a,

        /// <summary>
        /// Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES = 0x851C
        /// </summary>
        MaxCubeMapTextureSizeOes = 0x851c,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_STR_OES = 0x8D60
        /// </summary>
        TextureGenStrOes = 0x8d60,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OestextureEnvCrossbar
    {
        /// <summary>
        /// Original was GL_OES_texture_env_crossbar = 1
        /// </summary>
        OesTextureEnvCrossbar = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureEnvCrossbar
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OestextureMirroredRepeat
    {
        /// <summary>
        /// Original was GL_MIRRORED_REPEAT_OES = 0x8370
        /// </summary>
        MirroredRepeatOes = 0x8370,

        /// <summary>
        /// Original was GL_OES_texture_mirrored_repeat = 1
        /// </summary>
        OesTextureMirroredRepeat = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureMirroredRepeat
    {
        /// <summary>
        /// Original was GL_MIRRORED_REPEAT_OES = 0x8370
        /// </summary>
        MirroredRepeatOes = 0x8370,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureNpot
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesVertexArrayObject
    {
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BINDING_OES = 0x85B5
        /// </summary>
        VertexArrayBindingOes = 0x85b5,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OpenGlescoreVersions
    {
        /// <summary>
        /// Original was GL_VERSION_ES_CL_1_0 = 1
        /// </summary>
        VersionEsCl10 = 1,

        /// <summary>
        /// Original was GL_VERSION_ES_CL_1_1 = 1
        /// </summary>
        VersionEsCl11 = 1,

        /// <summary>
        /// Original was GL_VERSION_ES_CM_1_0 = 1
        /// </summary>
        VersionEsCm10 = 1,

        /// <summary>
        /// Original was GL_VERSION_ES_CM_1_1 = 1
        /// </summary>
        VersionEsCm11 = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PatchParameterName
    {
        /// <summary>
        /// Original was GL_PATCH_VERTICES = 0x8E72
        /// </summary>
        PatchVertices = 0x8e72,

        /// <summary>
        /// Original was GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73
        /// </summary>
        PatchDefaultInnerLevel = 0x8e73,

        /// <summary>
        /// Original was GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74
        /// </summary>
        PatchDefaultOuterLevel = 0x8e74,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathColor
    {
        /// <summary>
        /// Original was GL_PRIMARY_COLOR_NV = 0x852C
        /// </summary>
        PrimaryColorNv = 0x852c,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_NV = 0x852D
        /// </summary>
        SecondaryColorNv = 0x852d,

        /// <summary>
        /// Original was GL_PRIMARY_COLOR = 0x8577
        /// </summary>
        PrimaryColor = 0x8577,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathCoverMode
    {
        /// <summary>
        /// Original was GL_PATH_FILL_COVER_MODE_NV = 0x9082
        /// </summary>
        PathFillCoverModeNv = 0x9082,

        /// <summary>
        /// Original was GL_CONVEX_HULL_NV = 0x908B
        /// </summary>
        ConvexHullNv = 0x908b,

        /// <summary>
        /// Original was GL_BOUNDING_BOX_NV = 0x908D
        /// </summary>
        BoundingBoxNv = 0x908d,

        /// <summary>
        /// Original was GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C
        /// </summary>
        BoundingBoxOfBoundingBoxesNv = 0x909c,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathElementType
    {
        /// <summary>
        /// Original was GL_UTF8_NV = 0x909A
        /// </summary>
        Utf8Nv = 0x909a,

        /// <summary>
        /// Original was GL_UTF16_NV = 0x909B
        /// </summary>
        Utf16Nv = 0x909b,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathFillMode
    {
        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = 0x150a,

        /// <summary>
        /// Original was GL_PATH_FILL_MODE_NV = 0x9080
        /// </summary>
        PathFillModeNv = 0x9080,

        /// <summary>
        /// Original was GL_COUNT_UP_NV = 0x9088
        /// </summary>
        CountUpNv = 0x9088,

        /// <summary>
        /// Original was GL_COUNT_DOWN_NV = 0x9089
        /// </summary>
        CountDownNv = 0x9089,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathFontStyle
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Original was GL_BOLD_BIT_NV = 0x01
        /// </summary>
        BoldBitNv = 0x01,

        /// <summary>
        /// Original was GL_ITALIC_BIT_NV = 0x02
        /// </summary>
        ItalicBitNv = 0x02,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathFontTarget
    {
        /// <summary>
        /// Original was GL_STANDARD_FONT_NAME_NV = 0x9072
        /// </summary>
        StandardFontNameNv = 0x9072,

        /// <summary>
        /// Original was GL_SYSTEM_FONT_NAME_NV = 0x9073
        /// </summary>
        SystemFontNameNv = 0x9073,

        /// <summary>
        /// Original was GL_FILE_NAME_NV = 0x9074
        /// </summary>
        FileNameNv = 0x9074,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathGenMode
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Original was GL_EYE_LINEAR = 0x2400
        /// </summary>
        EyeLinear = 0x2400,

        /// <summary>
        /// Original was GL_OBJECT_LINEAR = 0x2401
        /// </summary>
        ObjectLinear = 0x2401,

        /// <summary>
        /// Original was GL_CONSTANT = 0x8576
        /// </summary>
        Constant = 0x8576,

        /// <summary>
        /// Original was GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A
        /// </summary>
        PathObjectBoundingBoxNv = 0x908a,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathHandleMissingGlyphs
    {
        /// <summary>
        /// Original was GL_SKIP_MISSING_GLYPH_NV = 0x90A9
        /// </summary>
        SkipMissingGlyphNv = 0x90a9,

        /// <summary>
        /// Original was GL_USE_MISSING_GLYPH_NV = 0x90AA
        /// </summary>
        UseMissingGlyphNv = 0x90aa,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathListMode
    {
        /// <summary>
        /// Original was GL_ACCUM_ADJACENT_PAIRS_NV = 0x90AD
        /// </summary>
        AccumAdjacentPairsNv = 0x90ad,

        /// <summary>
        /// Original was GL_ADJACENT_PAIRS_NV = 0x90AE
        /// </summary>
        AdjacentPairsNv = 0x90ae,

        /// <summary>
        /// Original was GL_FIRST_TO_REST_NV = 0x90AF
        /// </summary>
        FirstToRestNv = 0x90af,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum PathMetricMask
    {
        /// <summary>
        /// Original was GL_FONT_X_MIN_BOUNDS_BIT_NV = 0x00010000
        /// </summary>
        FontXMinBoundsBitNv = ((int)0x00010000),

        /// <summary>
        /// Original was GL_FONT_Y_MIN_BOUNDS_BIT_NV = 0x00020000
        /// </summary>
        FontYMinBoundsBitNv = ((int)0x00020000),

        /// <summary>
        /// Original was GL_FONT_X_MAX_BOUNDS_BIT_NV = 0x00040000
        /// </summary>
        FontXMaxBoundsBitNv = ((int)0x00040000),

        /// <summary>
        /// Original was GL_FONT_Y_MAX_BOUNDS_BIT_NV = 0x00080000
        /// </summary>
        FontYMaxBoundsBitNv = ((int)0x00080000),

        /// <summary>
        /// Original was GL_FONT_UNITS_PER_EM_BIT_NV = 0x00100000
        /// </summary>
        FontUnitsPerEmBitNv = ((int)0x00100000),

        /// <summary>
        /// Original was GL_FONT_ASCENDER_BIT_NV = 0x00200000
        /// </summary>
        FontAscenderBitNv = ((int)0x00200000),

        /// <summary>
        /// Original was GL_FONT_DESCENDER_BIT_NV = 0x00400000
        /// </summary>
        FontDescenderBitNv = ((int)0x00400000),

        /// <summary>
        /// Original was GL_FONT_HEIGHT_BIT_NV = 0x00800000
        /// </summary>
        FontHeightBitNv = ((int)0x00800000),

        /// <summary>
        /// Original was GL_GLYPH_WIDTH_BIT_NV = 0x01
        /// </summary>
        GlyphWidthBitNv = 0x01,

        /// <summary>
        /// Original was GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV = 0x01000000
        /// </summary>
        FontMaxAdvanceWidthBitNv = ((int)0x01000000),

        /// <summary>
        /// Original was GL_GLYPH_HEIGHT_BIT_NV = 0x02
        /// </summary>
        GlyphHeightBitNv = 0x02,

        /// <summary>
        /// Original was GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV = 0x02000000
        /// </summary>
        FontMaxAdvanceHeightBitNv = ((int)0x02000000),

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04
        /// </summary>
        GlyphHorizontalBearingXBitNv = 0x04,

        /// <summary>
        /// Original was GL_FONT_UNDERLINE_POSITION_BIT_NV = 0x04000000
        /// </summary>
        FontUnderlinePositionBitNv = ((int)0x04000000),

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08
        /// </summary>
        GlyphHorizontalBearingYBitNv = 0x08,

        /// <summary>
        /// Original was GL_FONT_UNDERLINE_THICKNESS_BIT_NV = 0x08000000
        /// </summary>
        FontUnderlineThicknessBitNv = ((int)0x08000000),

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10
        /// </summary>
        GlyphHorizontalBearingAdvanceBitNv = 0x10,

        /// <summary>
        /// Original was GL_GLYPH_HAS_KERNING_BIT_NV = 0x100
        /// </summary>
        GlyphHasKerningBitNv = 0x100,

        /// <summary>
        /// Original was GL_FONT_HAS_KERNING_BIT_NV = 0x10000000
        /// </summary>
        FontHasKerningBitNv = ((int)0x10000000),

        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20
        /// </summary>
        GlyphVerticalBearingXBitNv = 0x20,

        /// <summary>
        /// Original was GL_FONT_NUM_GLYPH_INDICES_BIT_NV = 0x20000000
        /// </summary>
        FontNumGlyphIndicesBitNv = ((int)0x20000000),

        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40
        /// </summary>
        GlyphVerticalBearingYBitNv = 0x40,

        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80
        /// </summary>
        GlyphVerticalBearingAdvanceBitNv = 0x80,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathParameter
    {
        /// <summary>
        /// Original was GL_PATH_STROKE_WIDTH_NV = 0x9075
        /// </summary>
        PathStrokeWidthNv = 0x9075,

        /// <summary>
        /// Original was GL_PATH_END_CAPS_NV = 0x9076
        /// </summary>
        PathEndCapsNv = 0x9076,

        /// <summary>
        /// Original was GL_PATH_INITIAL_END_CAP_NV = 0x9077
        /// </summary>
        PathInitialEndCapNv = 0x9077,

        /// <summary>
        /// Original was GL_PATH_TERMINAL_END_CAP_NV = 0x9078
        /// </summary>
        PathTerminalEndCapNv = 0x9078,

        /// <summary>
        /// Original was GL_PATH_JOIN_STYLE_NV = 0x9079
        /// </summary>
        PathJoinStyleNv = 0x9079,

        /// <summary>
        /// Original was GL_PATH_MITER_LIMIT_NV = 0x907A
        /// </summary>
        PathMiterLimitNv = 0x907a,

        /// <summary>
        /// Original was GL_PATH_DASH_CAPS_NV = 0x907B
        /// </summary>
        PathDashCapsNv = 0x907b,

        /// <summary>
        /// Original was GL_PATH_INITIAL_DASH_CAP_NV = 0x907C
        /// </summary>
        PathInitialDashCapNv = 0x907c,

        /// <summary>
        /// Original was GL_PATH_TERMINAL_DASH_CAP_NV = 0x907D
        /// </summary>
        PathTerminalDashCapNv = 0x907d,

        /// <summary>
        /// Original was GL_PATH_DASH_OFFSET_NV = 0x907E
        /// </summary>
        PathDashOffsetNv = 0x907e,

        /// <summary>
        /// Original was GL_PATH_CLIENT_LENGTH_NV = 0x907F
        /// </summary>
        PathClientLengthNv = 0x907f,

        /// <summary>
        /// Original was GL_PATH_FILL_MODE_NV = 0x9080
        /// </summary>
        PathFillModeNv = 0x9080,

        /// <summary>
        /// Original was GL_PATH_FILL_MASK_NV = 0x9081
        /// </summary>
        PathFillMaskNv = 0x9081,

        /// <summary>
        /// Original was GL_PATH_FILL_COVER_MODE_NV = 0x9082
        /// </summary>
        PathFillCoverModeNv = 0x9082,

        /// <summary>
        /// Original was GL_PATH_STROKE_COVER_MODE_NV = 0x9083
        /// </summary>
        PathStrokeCoverModeNv = 0x9083,

        /// <summary>
        /// Original was GL_PATH_STROKE_MASK_NV = 0x9084
        /// </summary>
        PathStrokeMaskNv = 0x9084,

        /// <summary>
        /// Original was GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A
        /// </summary>
        PathObjectBoundingBoxNv = 0x908a,

        /// <summary>
        /// Original was GL_PATH_COMMAND_COUNT_NV = 0x909D
        /// </summary>
        PathCommandCountNv = 0x909d,

        /// <summary>
        /// Original was GL_PATH_COORD_COUNT_NV = 0x909E
        /// </summary>
        PathCoordCountNv = 0x909e,

        /// <summary>
        /// Original was GL_PATH_DASH_ARRAY_COUNT_NV = 0x909F
        /// </summary>
        PathDashArrayCountNv = 0x909f,

        /// <summary>
        /// Original was GL_PATH_COMPUTED_LENGTH_NV = 0x90A0
        /// </summary>
        PathComputedLengthNv = 0x90a0,

        /// <summary>
        /// Original was GL_PATH_FILL_BOUNDING_BOX_NV = 0x90A1
        /// </summary>
        PathFillBoundingBoxNv = 0x90a1,

        /// <summary>
        /// Original was GL_PATH_STROKE_BOUNDING_BOX_NV = 0x90A2
        /// </summary>
        PathStrokeBoundingBoxNv = 0x90a2,

        /// <summary>
        /// Original was GL_PATH_DASH_OFFSET_RESET_NV = 0x90B4
        /// </summary>
        PathDashOffsetResetNv = 0x90b4,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathStringFormat
    {
        /// <summary>
        /// Original was GL_PATH_FORMAT_SVG_NV = 0x9070
        /// </summary>
        PathFormatSvgNv = 0x9070,

        /// <summary>
        /// Original was GL_PATH_FORMAT_PS_NV = 0x9071
        /// </summary>
        PathFormatPsNv = 0x9071,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathTransformType
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Original was GL_TRANSLATE_X_NV = 0x908E
        /// </summary>
        TranslateXNv = 0x908e,

        /// <summary>
        /// Original was GL_TRANSLATE_Y_NV = 0x908F
        /// </summary>
        TranslateYNv = 0x908f,

        /// <summary>
        /// Original was GL_TRANSLATE_2D_NV = 0x9090
        /// </summary>
        Translate2DNv = 0x9090,

        /// <summary>
        /// Original was GL_TRANSLATE_3D_NV = 0x9091
        /// </summary>
        Translate3DNv = 0x9091,

        /// <summary>
        /// Original was GL_AFFINE_2D_NV = 0x9092
        /// </summary>
        Affine2DNv = 0x9092,

        /// <summary>
        /// Original was GL_AFFINE_3D_NV = 0x9094
        /// </summary>
        Affine3DNv = 0x9094,

        /// <summary>
        /// Original was GL_TRANSPOSE_AFFINE_2D_NV = 0x9096
        /// </summary>
        TransposeAffine2DNv = 0x9096,

        /// <summary>
        /// Original was GL_TRANSPOSE_AFFINE_3D_NV = 0x9098
        /// </summary>
        TransposeAffine3DNv = 0x9098,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PipelineParameterName
    {
        /// <summary>
        /// Original was GL_ACTIVE_PROGRAM = 0x8259
        /// </summary>
        ActiveProgram = 0x8259,

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER = 0x8B30
        /// </summary>
        FragmentShader = 0x8b30,

        /// <summary>
        /// Original was GL_VERTEX_SHADER = 0x8B31
        /// </summary>
        VertexShader = 0x8b31,

        /// <summary>
        /// Original was GL_INFO_LOG_LENGTH = 0x8B84
        /// </summary>
        InfoLogLength = 0x8b84,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER = 0x8DD9
        /// </summary>
        GeometryShader = 0x8dd9,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER = 0x8E87
        /// </summary>
        TessEvaluationShader = 0x8e87,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER = 0x8E88
        /// </summary>
        TessControlShader = 0x8e88,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelCopyType
    {
        /// <summary>
        /// Original was GL_COLOR = 0x1800
        /// </summary>
        Color = 0x1800,

        /// <summary>
        /// Original was GL_COLOR_EXT = 0x1800
        /// </summary>
        ColorExt = 0x1800,

        /// <summary>
        /// Original was GL_DEPTH = 0x1801
        /// </summary>
        Depth = 0x1801,

        /// <summary>
        /// Original was GL_DEPTH_EXT = 0x1801
        /// </summary>
        DepthExt = 0x1801,

        /// <summary>
        /// Original was GL_STENCIL = 0x1802
        /// </summary>
        Stencil = 0x1802,

        /// <summary>
        /// Original was GL_STENCIL_EXT = 0x1802
        /// </summary>
        StencilExt = 0x1802,
    }

    /// <summary>
    /// Used in GL.CompressedTexSubImage2D, GL.ReadPixels and 4 other functions
    /// </summary>
    public enum PixelFormat
    {
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = 0x1403,

        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = 0x1405,

        /// <summary>
        /// Original was GL_COLOR_INDEX = 0x1900
        /// </summary>
        ColorIndex = 0x1900,

        /// <summary>
        /// Original was GL_STENCIL_INDEX = 0x1901
        /// </summary>
        StencilIndex = 0x1901,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT = 0x1902
        /// </summary>
        DepthComponent = 0x1902,

        /// <summary>
        /// Original was GL_RED = 0x1903
        /// </summary>
        Red = 0x1903,

        /// <summary>
        /// Original was GL_RED_EXT = 0x1903
        /// </summary>
        RedExt = 0x1903,

        /// <summary>
        /// Original was GL_GREEN = 0x1904
        /// </summary>
        Green = 0x1904,

        /// <summary>
        /// Original was GL_BLUE = 0x1905
        /// </summary>
        Blue = 0x1905,

        /// <summary>
        /// Original was GL_ALPHA = 0x1906
        /// </summary>
        Alpha = 0x1906,

        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = 0x1907,

        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = 0x1908,

        /// <summary>
        /// Original was GL_LUMINANCE = 0x1909
        /// </summary>
        Luminance = 0x1909,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = 0x190a,

        /// <summary>
        /// Original was GL_ABGR_EXT = 0x8000
        /// </summary>
        AbgrExt = 0x8000,

        /// <summary>
        /// Original was GL_CMYK_EXT = 0x800C
        /// </summary>
        CmykExt = 0x800c,

        /// <summary>
        /// Original was GL_CMYKA_EXT = 0x800D
        /// </summary>
        CmykaExt = 0x800d,

        /// <summary>
        /// Original was GL_YCRCB_422_SGIX = 0x81BB
        /// </summary>
        Ycrcb422Sgix = 0x81bb,

        /// <summary>
        /// Original was GL_YCRCB_444_SGIX = 0x81BC
        /// </summary>
        Ycrcb444Sgix = 0x81bc,
    }

    /// <summary>
    /// Used in GL.GetPixelMapx, GL.PixelMapx
    /// </summary>
    public enum PixelMap
    {
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_I = 0x0C70
        /// </summary>
        PixelMapIToI = 0x0c70,

        /// <summary>
        /// Original was GL_PIXEL_MAP_S_TO_S = 0x0C71
        /// </summary>
        PixelMapSToS = 0x0c71,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_R = 0x0C72
        /// </summary>
        PixelMapIToR = 0x0c72,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_G = 0x0C73
        /// </summary>
        PixelMapIToG = 0x0c73,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_B = 0x0C74
        /// </summary>
        PixelMapIToB = 0x0c74,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_A = 0x0C75
        /// </summary>
        PixelMapIToA = 0x0c75,

        /// <summary>
        /// Original was GL_PIXEL_MAP_R_TO_R = 0x0C76
        /// </summary>
        PixelMapRToR = 0x0c76,

        /// <summary>
        /// Original was GL_PIXEL_MAP_G_TO_G = 0x0C77
        /// </summary>
        PixelMapGToG = 0x0c77,

        /// <summary>
        /// Original was GL_PIXEL_MAP_B_TO_B = 0x0C78
        /// </summary>
        PixelMapBToB = 0x0c78,

        /// <summary>
        /// Original was GL_PIXEL_MAP_A_TO_A = 0x0C79
        /// </summary>
        PixelMapAToA = 0x0c79,
    }

    /// <summary>
    /// Used in GL.PixelStore, GL.PixelStorex
    /// </summary>
    public enum PixelStoreParameter
    {
        /// <summary>
        /// Original was GL_UNPACK_SWAP_BYTES = 0x0CF0
        /// </summary>
        UnpackSwapBytes = 0x0cf0,

        /// <summary>
        /// Original was GL_UNPACK_LSB_FIRST = 0x0CF1
        /// </summary>
        UnpackLsbFirst = 0x0cf1,

        /// <summary>
        /// Original was GL_UNPACK_ROW_LENGTH = 0x0CF2
        /// </summary>
        UnpackRowLength = 0x0cf2,

        /// <summary>
        /// Original was GL_UNPACK_ROW_LENGTH_EXT = 0x0CF2
        /// </summary>
        UnpackRowLengthExt = 0x0cf2,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_ROWS = 0x0CF3
        /// </summary>
        UnpackSkipRows = 0x0cf3,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_ROWS_EXT = 0x0CF3
        /// </summary>
        UnpackSkipRowsExt = 0x0cf3,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_PIXELS = 0x0CF4
        /// </summary>
        UnpackSkipPixels = 0x0cf4,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_PIXELS_EXT = 0x0CF4
        /// </summary>
        UnpackSkipPixelsExt = 0x0cf4,

        /// <summary>
        /// Original was GL_UNPACK_ALIGNMENT = 0x0CF5
        /// </summary>
        UnpackAlignment = 0x0cf5,

        /// <summary>
        /// Original was GL_PACK_SWAP_BYTES = 0x0D00
        /// </summary>
        PackSwapBytes = 0x0d00,

        /// <summary>
        /// Original was GL_PACK_LSB_FIRST = 0x0D01
        /// </summary>
        PackLsbFirst = 0x0d01,

        /// <summary>
        /// Original was GL_PACK_ROW_LENGTH = 0x0D02
        /// </summary>
        PackRowLength = 0x0d02,

        /// <summary>
        /// Original was GL_PACK_SKIP_ROWS = 0x0D03
        /// </summary>
        PackSkipRows = 0x0d03,

        /// <summary>
        /// Original was GL_PACK_SKIP_PIXELS = 0x0D04
        /// </summary>
        PackSkipPixels = 0x0d04,

        /// <summary>
        /// Original was GL_PACK_ALIGNMENT = 0x0D05
        /// </summary>
        PackAlignment = 0x0d05,

        /// <summary>
        /// Original was GL_PACK_SKIP_IMAGES = 0x806B
        /// </summary>
        PackSkipImages = 0x806b,

        /// <summary>
        /// Original was GL_PACK_SKIP_IMAGES_EXT = 0x806B
        /// </summary>
        PackSkipImagesExt = 0x806b,

        /// <summary>
        /// Original was GL_PACK_IMAGE_HEIGHT = 0x806C
        /// </summary>
        PackImageHeight = 0x806c,

        /// <summary>
        /// Original was GL_PACK_IMAGE_HEIGHT_EXT = 0x806C
        /// </summary>
        PackImageHeightExt = 0x806c,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_IMAGES = 0x806D
        /// </summary>
        UnpackSkipImages = 0x806d,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_IMAGES_EXT = 0x806D
        /// </summary>
        UnpackSkipImagesExt = 0x806d,

        /// <summary>
        /// Original was GL_UNPACK_IMAGE_HEIGHT = 0x806E
        /// </summary>
        UnpackImageHeight = 0x806e,

        /// <summary>
        /// Original was GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E
        /// </summary>
        UnpackImageHeightExt = 0x806e,

        /// <summary>
        /// Original was GL_PACK_SKIP_VOLUMES_SGIS = 0x8130
        /// </summary>
        PackSkipVolumesSgis = 0x8130,

        /// <summary>
        /// Original was GL_PACK_IMAGE_DEPTH_SGIS = 0x8131
        /// </summary>
        PackImageDepthSgis = 0x8131,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_VOLUMES_SGIS = 0x8132
        /// </summary>
        UnpackSkipVolumesSgis = 0x8132,

        /// <summary>
        /// Original was GL_UNPACK_IMAGE_DEPTH_SGIS = 0x8133
        /// </summary>
        UnpackImageDepthSgis = 0x8133,

        /// <summary>
        /// Original was GL_PIXEL_TILE_WIDTH_SGIX = 0x8140
        /// </summary>
        PixelTileWidthSgix = 0x8140,

        /// <summary>
        /// Original was GL_PIXEL_TILE_HEIGHT_SGIX = 0x8141
        /// </summary>
        PixelTileHeightSgix = 0x8141,

        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142
        /// </summary>
        PixelTileGridWidthSgix = 0x8142,

        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143
        /// </summary>
        PixelTileGridHeightSgix = 0x8143,

        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144
        /// </summary>
        PixelTileGridDepthSgix = 0x8144,

        /// <summary>
        /// Original was GL_PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145
        /// </summary>
        PixelTileCacheSizeSgix = 0x8145,

        /// <summary>
        /// Original was GL_PACK_RESAMPLE_SGIX = 0x842E
        /// </summary>
        PackResampleSgix = 0x842e,

        /// <summary>
        /// Original was GL_UNPACK_RESAMPLE_SGIX = 0x842F
        /// </summary>
        UnpackResampleSgix = 0x842f,

        /// <summary>
        /// Original was GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0
        /// </summary>
        PackSubsampleRateSgix = 0x85a0,

        /// <summary>
        /// Original was GL_UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1
        /// </summary>
        UnpackSubsampleRateSgix = 0x85a1,

        /// <summary>
        /// Original was GL_PACK_RESAMPLE_OML = 0x8984
        /// </summary>
        PackResampleOml = 0x8984,

        /// <summary>
        /// Original was GL_UNPACK_RESAMPLE_OML = 0x8985
        /// </summary>
        UnpackResampleOml = 0x8985,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelStoreResampleMode
    {
        /// <summary>
        /// Original was GL_RESAMPLE_DECIMATE_SGIX = 0x8430
        /// </summary>
        ResampleDecimateSgix = 0x8430,

        /// <summary>
        /// Original was GL_RESAMPLE_REPLICATE_SGIX = 0x8433
        /// </summary>
        ResampleReplicateSgix = 0x8433,

        /// <summary>
        /// Original was GL_RESAMPLE_ZERO_FILL_SGIX = 0x8434
        /// </summary>
        ResampleZeroFillSgix = 0x8434,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelStoreSubsampleRate
    {
        /// <summary>
        /// Original was GL_PIXEL_SUBSAMPLE_4444_SGIX = 0x85A2
        /// </summary>
        PixelSubsample4444Sgix = 0x85a2,

        /// <summary>
        /// Original was GL_PIXEL_SUBSAMPLE_2424_SGIX = 0x85A3
        /// </summary>
        PixelSubsample2424Sgix = 0x85a3,

        /// <summary>
        /// Original was GL_PIXEL_SUBSAMPLE_4242_SGIX = 0x85A4
        /// </summary>
        PixelSubsample4242Sgix = 0x85a4,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelTexGenMode
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = 0x1907,

        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = 0x1908,

        /// <summary>
        /// Original was GL_LUMINANCE = 0x1909
        /// </summary>
        Luminance = 0x1909,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = 0x190a,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX = 0x8187
        /// </summary>
        PixelTexGenAlphaReplaceSgix = 0x8187,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX = 0x8188
        /// </summary>
        PixelTexGenAlphaNoReplaceSgix = 0x8188,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_ALPHA_LS_SGIX = 0x8189
        /// </summary>
        PixelTexGenAlphaLsSgix = 0x8189,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_ALPHA_MS_SGIX = 0x818A
        /// </summary>
        PixelTexGenAlphaMsSgix = 0x818a,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelTexGenParameterNameSgis
    {
        /// <summary>
        /// Original was GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354
        /// </summary>
        PixelFragmentRgbSourceSgis = 0x8354,

        /// <summary>
        /// Original was GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355
        /// </summary>
        PixelFragmentAlphaSourceSgis = 0x8355,
    }

    /// <summary>
    /// Used in GL.Oes.PixelTransferx
    /// </summary>
    public enum PixelTransferParameter
    {
        /// <summary>
        /// Original was GL_MAP_COLOR = 0x0D10
        /// </summary>
        MapColor = 0x0d10,

        /// <summary>
        /// Original was GL_MAP_STENCIL = 0x0D11
        /// </summary>
        MapStencil = 0x0d11,

        /// <summary>
        /// Original was GL_INDEX_SHIFT = 0x0D12
        /// </summary>
        IndexShift = 0x0d12,

        /// <summary>
        /// Original was GL_INDEX_OFFSET = 0x0D13
        /// </summary>
        IndexOffset = 0x0d13,

        /// <summary>
        /// Original was GL_RED_SCALE = 0x0D14
        /// </summary>
        RedScale = 0x0d14,

        /// <summary>
        /// Original was GL_RED_BIAS = 0x0D15
        /// </summary>
        RedBias = 0x0d15,

        /// <summary>
        /// Original was GL_GREEN_SCALE = 0x0D18
        /// </summary>
        GreenScale = 0x0d18,

        /// <summary>
        /// Original was GL_GREEN_BIAS = 0x0D19
        /// </summary>
        GreenBias = 0x0d19,

        /// <summary>
        /// Original was GL_BLUE_SCALE = 0x0D1A
        /// </summary>
        BlueScale = 0x0d1a,

        /// <summary>
        /// Original was GL_BLUE_BIAS = 0x0D1B
        /// </summary>
        BlueBias = 0x0d1b,

        /// <summary>
        /// Original was GL_ALPHA_SCALE = 0x0D1C
        /// </summary>
        AlphaScale = 0x0d1c,

        /// <summary>
        /// Original was GL_ALPHA_BIAS = 0x0D1D
        /// </summary>
        AlphaBias = 0x0d1d,

        /// <summary>
        /// Original was GL_DEPTH_SCALE = 0x0D1E
        /// </summary>
        DepthScale = 0x0d1e,

        /// <summary>
        /// Original was GL_DEPTH_BIAS = 0x0D1F
        /// </summary>
        DepthBias = 0x0d1f,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_SCALE = 0x801C
        /// </summary>
        PostConvolutionRedScale = 0x801c,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C
        /// </summary>
        PostConvolutionRedScaleExt = 0x801c,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D
        /// </summary>
        PostConvolutionGreenScale = 0x801d,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D
        /// </summary>
        PostConvolutionGreenScaleExt = 0x801d,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E
        /// </summary>
        PostConvolutionBlueScale = 0x801e,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E
        /// </summary>
        PostConvolutionBlueScaleExt = 0x801e,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F
        /// </summary>
        PostConvolutionAlphaScale = 0x801f,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F
        /// </summary>
        PostConvolutionAlphaScaleExt = 0x801f,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_BIAS = 0x8020
        /// </summary>
        PostConvolutionRedBias = 0x8020,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_BIAS_EXT = 0x8020
        /// </summary>
        PostConvolutionRedBiasExt = 0x8020,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021
        /// </summary>
        PostConvolutionGreenBias = 0x8021,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021
        /// </summary>
        PostConvolutionGreenBiasExt = 0x8021,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022
        /// </summary>
        PostConvolutionBlueBias = 0x8022,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022
        /// </summary>
        PostConvolutionBlueBiasExt = 0x8022,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023
        /// </summary>
        PostConvolutionAlphaBias = 0x8023,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023
        /// </summary>
        PostConvolutionAlphaBiasExt = 0x8023,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4
        /// </summary>
        PostColorMatrixRedScale = 0x80b4,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4
        /// </summary>
        PostColorMatrixRedScaleSgi = 0x80b4,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5
        /// </summary>
        PostColorMatrixGreenScale = 0x80b5,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5
        /// </summary>
        PostColorMatrixGreenScaleSgi = 0x80b5,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6
        /// </summary>
        PostColorMatrixBlueScale = 0x80b6,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6
        /// </summary>
        PostColorMatrixBlueScaleSgi = 0x80b6,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7
        /// </summary>
        PostColorMatrixAlphaScale = 0x80b7,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7
        /// </summary>
        PostColorMatrixAlphaScaleSgi = 0x80b7,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8
        /// </summary>
        PostColorMatrixRedBias = 0x80b8,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8
        /// </summary>
        PostColorMatrixRedBiasSgi = 0x80b8,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9
        /// </summary>
        PostColorMatrixGreenBias = 0x80b9,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9
        /// </summary>
        PostColorMatrixGreenBiasSgi = 0x80b9,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA
        /// </summary>
        PostColorMatrixBlueBias = 0x80ba,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA
        /// </summary>
        PostColorMatrixBlueBiasSgi = 0x80ba,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB
        /// </summary>
        PostColorMatrixAlphaBias = 0x80bb,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB
        /// </summary>
        PostColorMatrixAlphaBiasSgi = 0x80bb,
    }

    /// <summary>
    /// Used in GL.ReadPixels, GL.TexImage2D and 3 other functions
    /// </summary>
    public enum PixelType
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = 0x1400,

        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = 0x1401,

        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = 0x1402,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = 0x1403,

        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = 0x1404,

        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = 0x1405,

        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_BITMAP = 0x1A00
        /// </summary>
        Bitmap = 0x1a00,

        /// <summary>
        /// Original was GL_UNSIGNED_BYTE_3_3_2 = 0x8032
        /// </summary>
        UnsignedByte332 = 0x8032,

        /// <summary>
        /// Original was GL_UNSIGNED_BYTE_3_3_2_EXT = 0x8032
        /// </summary>
        UnsignedByte332Ext = 0x8032,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033
        /// </summary>
        UnsignedShort4444 = 0x8033,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033
        /// </summary>
        UnsignedShort4444Ext = 0x8033,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034
        /// </summary>
        UnsignedShort5551 = 0x8034,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034
        /// </summary>
        UnsignedShort5551Ext = 0x8034,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_8_8_8_8 = 0x8035
        /// </summary>
        UnsignedInt8888 = 0x8035,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_8_8_8_8_EXT = 0x8035
        /// </summary>
        UnsignedInt8888Ext = 0x8035,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_10_10_10_2 = 0x8036
        /// </summary>
        UnsignedInt1010102 = 0x8036,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_10_10_10_2_EXT = 0x8036
        /// </summary>
        UnsignedInt1010102Ext = 0x8036,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PointParameterNameSgis
    {
        /// <summary>
        /// Original was GL_POINT_SIZE_MIN = 0x8126
        /// </summary>
        PointSizeMin = 0x8126,

        /// <summary>
        /// Original was GL_POINT_SIZE_MIN_ARB = 0x8126
        /// </summary>
        PointSizeMinArb = 0x8126,

        /// <summary>
        /// Original was GL_POINT_SIZE_MIN_EXT = 0x8126
        /// </summary>
        PointSizeMinExt = 0x8126,

        /// <summary>
        /// Original was GL_POINT_SIZE_MIN_SGIS = 0x8126
        /// </summary>
        PointSizeMinSgis = 0x8126,

        /// <summary>
        /// Original was GL_POINT_SIZE_MAX = 0x8127
        /// </summary>
        PointSizeMax = 0x8127,

        /// <summary>
        /// Original was GL_POINT_SIZE_MAX_ARB = 0x8127
        /// </summary>
        PointSizeMaxArb = 0x8127,

        /// <summary>
        /// Original was GL_POINT_SIZE_MAX_EXT = 0x8127
        /// </summary>
        PointSizeMaxExt = 0x8127,

        /// <summary>
        /// Original was GL_POINT_SIZE_MAX_SGIS = 0x8127
        /// </summary>
        PointSizeMaxSgis = 0x8127,

        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE = 0x8128
        /// </summary>
        PointFadeThresholdSize = 0x8128,

        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128
        /// </summary>
        PointFadeThresholdSizeArb = 0x8128,

        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128
        /// </summary>
        PointFadeThresholdSizeExt = 0x8128,

        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128
        /// </summary>
        PointFadeThresholdSizeSgis = 0x8128,

        /// <summary>
        /// Original was GL_DISTANCE_ATTENUATION_EXT = 0x8129
        /// </summary>
        DistanceAttenuationExt = 0x8129,

        /// <summary>
        /// Original was GL_DISTANCE_ATTENUATION_SGIS = 0x8129
        /// </summary>
        DistanceAttenuationSgis = 0x8129,

        /// <summary>
        /// Original was GL_POINT_DISTANCE_ATTENUATION = 0x8129
        /// </summary>
        PointDistanceAttenuation = 0x8129,

        /// <summary>
        /// Original was GL_POINT_DISTANCE_ATTENUATION_ARB = 0x8129
        /// </summary>
        PointDistanceAttenuationArb = 0x8129,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PolygonMode
    {
        /// <summary>
        /// Original was GL_POINT = 0x1B00
        /// </summary>
        Point = 0x1b00,

        /// <summary>
        /// Original was GL_LINE = 0x1B01
        /// </summary>
        Line = 0x1b01,

        /// <summary>
        /// Original was GL_FILL = 0x1B02
        /// </summary>
        Fill = 0x1b02,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PrecisionType
    {
        /// <summary>
        /// Original was GL_LOW_FLOAT = 0x8DF0
        /// </summary>
        LowFloat = 0x8df0,

        /// <summary>
        /// Original was GL_MEDIUM_FLOAT = 0x8DF1
        /// </summary>
        MediumFloat = 0x8df1,

        /// <summary>
        /// Original was GL_HIGH_FLOAT = 0x8DF2
        /// </summary>
        HighFloat = 0x8df2,

        /// <summary>
        /// Original was GL_LOW_INT = 0x8DF3
        /// </summary>
        LowInt = 0x8df3,

        /// <summary>
        /// Original was GL_MEDIUM_INT = 0x8DF4
        /// </summary>
        MediumInt = 0x8df4,

        /// <summary>
        /// Original was GL_HIGH_INT = 0x8DF5
        /// </summary>
        HighInt = 0x8df5,
    }

    /// <summary>
    /// Used in GL.DrawArrays, GL.DrawElements and 2 other functions
    /// </summary>
    public enum PrimitiveType
    {
        /// <summary>
        /// Original was GL_POINTS = 0x0000
        /// </summary>
        Points = 0x0000,

        /// <summary>
        /// Original was GL_LINES = 0x0001
        /// </summary>
        Lines = 0x0001,

        /// <summary>
        /// Original was GL_LINE_LOOP = 0x0002
        /// </summary>
        LineLoop = 0x0002,

        /// <summary>
        /// Original was GL_LINE_STRIP = 0x0003
        /// </summary>
        LineStrip = 0x0003,

        /// <summary>
        /// Original was GL_TRIANGLES = 0x0004
        /// </summary>
        Triangles = 0x0004,

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP = 0x0005
        /// </summary>
        TriangleStrip = 0x0005,

        /// <summary>
        /// Original was GL_TRIANGLE_FAN = 0x0006
        /// </summary>
        TriangleFan = 0x0006,

        /// <summary>
        /// Original was GL_QUADS = 0x0007
        /// </summary>
        Quads = 0x0007,

        /// <summary>
        /// Original was GL_QUADS_EXT = 0x0007
        /// </summary>
        QuadsExt = 0x0007,

        /// <summary>
        /// Original was GL_QUAD_STRIP = 0x0008
        /// </summary>
        QuadStrip = 0x0008,

        /// <summary>
        /// Original was GL_POLYGON = 0x0009
        /// </summary>
        Polygon = 0x0009,

        /// <summary>
        /// Original was GL_LINES_ADJACENCY = 0x000A
        /// </summary>
        LinesAdjacency = 0x000a,

        /// <summary>
        /// Original was GL_LINES_ADJACENCY_ARB = 0x000A
        /// </summary>
        LinesAdjacencyArb = 0x000a,

        /// <summary>
        /// Original was GL_LINES_ADJACENCY_EXT = 0x000A
        /// </summary>
        LinesAdjacencyExt = 0x000a,

        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY = 0x000B
        /// </summary>
        LineStripAdjacency = 0x000b,

        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY_ARB = 0x000B
        /// </summary>
        LineStripAdjacencyArb = 0x000b,

        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY_EXT = 0x000B
        /// </summary>
        LineStripAdjacencyExt = 0x000b,

        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY = 0x000C
        /// </summary>
        TrianglesAdjacency = 0x000c,

        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY_ARB = 0x000C
        /// </summary>
        TrianglesAdjacencyArb = 0x000c,

        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY_EXT = 0x000C
        /// </summary>
        TrianglesAdjacencyExt = 0x000c,

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY = 0x000D
        /// </summary>
        TriangleStripAdjacency = 0x000d,

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D
        /// </summary>
        TriangleStripAdjacencyArb = 0x000d,

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D
        /// </summary>
        TriangleStripAdjacencyExt = 0x000d,

        /// <summary>
        /// Original was GL_PATCHES = 0x000E
        /// </summary>
        Patches = 0x000e,

        /// <summary>
        /// Original was GL_PATCHES_EXT = 0x000E
        /// </summary>
        PatchesExt = 0x000e,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ProgramInterface
    {
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        /// </summary>
        TransformFeedbackBuffer = 0x8c8e,

        /// <summary>
        /// Original was GL_UNIFORM = 0x92E1
        /// </summary>
        Uniform = 0x92e1,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK = 0x92E2
        /// </summary>
        UniformBlock = 0x92e2,

        /// <summary>
        /// Original was GL_PROGRAM_INPUT = 0x92E3
        /// </summary>
        ProgramInput = 0x92e3,

        /// <summary>
        /// Original was GL_PROGRAM_OUTPUT = 0x92E4
        /// </summary>
        ProgramOutput = 0x92e4,

        /// <summary>
        /// Original was GL_BUFFER_VARIABLE = 0x92E5
        /// </summary>
        BufferVariable = 0x92e5,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BLOCK = 0x92E6
        /// </summary>
        ShaderStorageBlock = 0x92e6,

        /// <summary>
        /// Original was GL_VERTEX_SUBROUTINE = 0x92E8
        /// </summary>
        VertexSubroutine = 0x92e8,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SUBROUTINE = 0x92E9
        /// </summary>
        TessControlSubroutine = 0x92e9,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SUBROUTINE = 0x92EA
        /// </summary>
        TessEvaluationSubroutine = 0x92ea,

        /// <summary>
        /// Original was GL_GEOMETRY_SUBROUTINE = 0x92EB
        /// </summary>
        GeometrySubroutine = 0x92eb,

        /// <summary>
        /// Original was GL_FRAGMENT_SUBROUTINE = 0x92EC
        /// </summary>
        FragmentSubroutine = 0x92ec,

        /// <summary>
        /// Original was GL_COMPUTE_SUBROUTINE = 0x92ED
        /// </summary>
        ComputeSubroutine = 0x92ed,

        /// <summary>
        /// Original was GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE
        /// </summary>
        VertexSubroutineUniform = 0x92ee,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF
        /// </summary>
        TessControlSubroutineUniform = 0x92ef,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0
        /// </summary>
        TessEvaluationSubroutineUniform = 0x92f0,

        /// <summary>
        /// Original was GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1
        /// </summary>
        GeometrySubroutineUniform = 0x92f1,

        /// <summary>
        /// Original was GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2
        /// </summary>
        FragmentSubroutineUniform = 0x92f2,

        /// <summary>
        /// Original was GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3
        /// </summary>
        ComputeSubroutineUniform = 0x92f3,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4
        /// </summary>
        TransformFeedbackVarying = 0x92f4,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ProgramInterfacePName
    {
        /// <summary>
        /// Original was GL_ACTIVE_RESOURCES = 0x92F5
        /// </summary>
        ActiveResources = 0x92f5,

        /// <summary>
        /// Original was GL_MAX_NAME_LENGTH = 0x92F6
        /// </summary>
        MaxNameLength = 0x92f6,

        /// <summary>
        /// Original was GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7
        /// </summary>
        MaxNumActiveVariables = 0x92f7,

        /// <summary>
        /// Original was GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8
        /// </summary>
        MaxNumCompatibleSubroutines = 0x92f8,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ProgramParameterPName
    {
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
        /// </summary>
        ProgramBinaryRetrievableHint = 0x8257,

        /// <summary>
        /// Original was GL_PROGRAM_SEPARABLE = 0x8258
        /// </summary>
        ProgramSeparable = 0x8258,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ProgramPropertyArb
    {
        /// <summary>
        /// Original was GL_COMPUTE_WORK_GROUP_SIZE = 0x8267
        /// </summary>
        ComputeWorkGroupSize = 0x8267,

        /// <summary>
        /// Original was GL_PROGRAM_BINARY_LENGTH = 0x8741
        /// </summary>
        ProgramBinaryLength = 0x8741,

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
        /// Original was GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35
        /// </summary>
        ActiveUniformBlockMaxNameLength = 0x8a35,

        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36
        /// </summary>
        ActiveUniformBlocks = 0x8a36,

        /// <summary>
        /// Original was GL_DELETE_STATUS = 0x8B80
        /// </summary>
        DeleteStatus = 0x8b80,

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
        /// Original was GL_ACTIVE_ATTRIBUTES = 0x8B89
        /// </summary>
        ActiveAttributes = 0x8b89,

        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A
        /// </summary>
        ActiveAttributeMaxLength = 0x8b8a,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76
        /// </summary>
        TransformFeedbackVaryingMaxLength = 0x8c76,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F
        /// </summary>
        TransformFeedbackBufferMode = 0x8c7f,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83
        /// </summary>
        TransformFeedbackVaryings = 0x8c83,

        /// <summary>
        /// Original was GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9
        /// </summary>
        ActiveAtomicCounterBuffers = 0x92d9,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ProgramStagePName
    {
        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINES = 0x8DE5
        /// </summary>
        ActiveSubroutines = 0x8de5,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6
        /// </summary>
        ActiveSubroutineUniforms = 0x8de6,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47
        /// </summary>
        ActiveSubroutineUniformLocations = 0x8e47,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48
        /// </summary>
        ActiveSubroutineMaxLength = 0x8e48,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49
        /// </summary>
        ActiveSubroutineUniformMaxLength = 0x8e49,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum QcomdriverControl
    {
        /// <summary>
        /// Original was GL_QCOM_driver_control = 1
        /// </summary>
        QcomDriverControl = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomDriverControl
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomExtendedGet
    {
        /// <summary>
        /// Original was GL_TEXTURE_WIDTH_QCOM = 0x8BD2
        /// </summary>
        TextureWidthQcom = 0x8bd2,

        /// <summary>
        /// Original was GL_TEXTURE_HEIGHT_QCOM = 0x8BD3
        /// </summary>
        TextureHeightQcom = 0x8bd3,

        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_QCOM = 0x8BD4
        /// </summary>
        TextureDepthQcom = 0x8bd4,

        /// <summary>
        /// Original was GL_TEXTURE_INTERNAL_FORMAT_QCOM = 0x8BD5
        /// </summary>
        TextureInternalFormatQcom = 0x8bd5,

        /// <summary>
        /// Original was GL_TEXTURE_FORMAT_QCOM = 0x8BD6
        /// </summary>
        TextureFormatQcom = 0x8bd6,

        /// <summary>
        /// Original was GL_TEXTURE_TYPE_QCOM = 0x8BD7
        /// </summary>
        TextureTypeQcom = 0x8bd7,

        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_VALID_QCOM = 0x8BD8
        /// </summary>
        TextureImageValidQcom = 0x8bd8,

        /// <summary>
        /// Original was GL_TEXTURE_NUM_LEVELS_QCOM = 0x8BD9
        /// </summary>
        TextureNumLevelsQcom = 0x8bd9,

        /// <summary>
        /// Original was GL_TEXTURE_TARGET_QCOM = 0x8BDA
        /// </summary>
        TextureTargetQcom = 0x8bda,

        /// <summary>
        /// Original was GL_TEXTURE_OBJECT_VALID_QCOM = 0x8BDB
        /// </summary>
        TextureObjectValidQcom = 0x8bdb,

        /// <summary>
        /// Original was GL_STATE_RESTORE = 0x8BDC
        /// </summary>
        StateRestore = 0x8bdc,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomExtendedGet2
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum QcomperfmonGlobalMode
    {
        /// <summary>
        /// Original was GL_PERFMON_GLOBAL_MODE_QCOM = 0x8FA0
        /// </summary>
        PerfmonGlobalModeQcom = 0x8fa0,

        /// <summary>
        /// Original was GL_QCOM_perfmon_global_mode = 1
        /// </summary>
        QcomPerfmonGlobalMode = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomPerfmonGlobalMode
    {
        /// <summary>
        /// Original was GL_PERFMON_GLOBAL_MODE_QCOM = 0x8FA0
        /// </summary>
        PerfmonGlobalModeQcom = 0x8fa0,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomTiledRendering
    {
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT0_QCOM = 0x00000001
        /// </summary>
        ColorBufferBit0Qcom = ((int)0x00000001),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT1_QCOM = 0x00000002
        /// </summary>
        ColorBufferBit1Qcom = ((int)0x00000002),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT2_QCOM = 0x00000004
        /// </summary>
        ColorBufferBit2Qcom = ((int)0x00000004),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT3_QCOM = 0x00000008
        /// </summary>
        ColorBufferBit3Qcom = ((int)0x00000008),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT4_QCOM = 0x00000010
        /// </summary>
        ColorBufferBit4Qcom = ((int)0x00000010),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT5_QCOM = 0x00000020
        /// </summary>
        ColorBufferBit5Qcom = ((int)0x00000020),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT6_QCOM = 0x00000040
        /// </summary>
        ColorBufferBit6Qcom = ((int)0x00000040),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT7_QCOM = 0x00000080
        /// </summary>
        ColorBufferBit7Qcom = ((int)0x00000080),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT0_QCOM = 0x00000100
        /// </summary>
        DepthBufferBit0Qcom = ((int)0x00000100),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT1_QCOM = 0x00000200
        /// </summary>
        DepthBufferBit1Qcom = ((int)0x00000200),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT2_QCOM = 0x00000400
        /// </summary>
        DepthBufferBit2Qcom = ((int)0x00000400),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT3_QCOM = 0x00000800
        /// </summary>
        DepthBufferBit3Qcom = ((int)0x00000800),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT4_QCOM = 0x00001000
        /// </summary>
        DepthBufferBit4Qcom = ((int)0x00001000),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT5_QCOM = 0x00002000
        /// </summary>
        DepthBufferBit5Qcom = ((int)0x00002000),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT6_QCOM = 0x00004000
        /// </summary>
        DepthBufferBit6Qcom = ((int)0x00004000),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT7_QCOM = 0x00008000
        /// </summary>
        DepthBufferBit7Qcom = ((int)0x00008000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT0_QCOM = 0x00010000
        /// </summary>
        StencilBufferBit0Qcom = ((int)0x00010000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT1_QCOM = 0x00020000
        /// </summary>
        StencilBufferBit1Qcom = ((int)0x00020000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT2_QCOM = 0x00040000
        /// </summary>
        StencilBufferBit2Qcom = ((int)0x00040000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT3_QCOM = 0x00080000
        /// </summary>
        StencilBufferBit3Qcom = ((int)0x00080000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT4_QCOM = 0x00100000
        /// </summary>
        StencilBufferBit4Qcom = ((int)0x00100000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT5_QCOM = 0x00200000
        /// </summary>
        StencilBufferBit5Qcom = ((int)0x00200000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT6_QCOM = 0x00400000
        /// </summary>
        StencilBufferBit6Qcom = ((int)0x00400000),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT7_QCOM = 0x00800000
        /// </summary>
        StencilBufferBit7Qcom = ((int)0x00800000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT0_QCOM = 0x01000000
        /// </summary>
        MultisampleBufferBit0Qcom = ((int)0x01000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT1_QCOM = 0x02000000
        /// </summary>
        MultisampleBufferBit1Qcom = ((int)0x02000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT2_QCOM = 0x04000000
        /// </summary>
        MultisampleBufferBit2Qcom = ((int)0x04000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT3_QCOM = 0x08000000
        /// </summary>
        MultisampleBufferBit3Qcom = ((int)0x08000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT4_QCOM = 0x10000000
        /// </summary>
        MultisampleBufferBit4Qcom = ((int)0x10000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT5_QCOM = 0x20000000
        /// </summary>
        MultisampleBufferBit5Qcom = ((int)0x20000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT6_QCOM = 0x40000000
        /// </summary>
        MultisampleBufferBit6Qcom = ((int)0x40000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT7_QCOM = 0x80000000
        /// </summary>
        MultisampleBufferBit7Qcom = unchecked((int)0x80000000),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomWriteonlyRendering
    {
        /// <summary>
        /// Original was GL_WRITEONLY_RENDERING_QCOM = 0x8823
        /// </summary>
        WriteonlyRenderingQcom = 0x8823,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QueryObjectParameterName
    {
        /// <summary>
        /// Original was GL_QUERY_TARGET = 0x82EA
        /// </summary>
        QueryTarget = 0x82ea,

        /// <summary>
        /// Original was GL_QUERY_RESULT = 0x8866
        /// </summary>
        QueryResult = 0x8866,

        /// <summary>
        /// Original was GL_QUERY_RESULT_AVAILABLE = 0x8867
        /// </summary>
        QueryResultAvailable = 0x8867,

        /// <summary>
        /// Original was GL_QUERY_RESULT_NO_WAIT = 0x9194
        /// </summary>
        QueryResultNoWait = 0x9194,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QueryParameterName
    {
        /// <summary>
        /// Original was GL_QUERY_COUNTER_BITS = 0x8864
        /// </summary>
        QueryCounterBits = 0x8864,

        /// <summary>
        /// Original was GL_CURRENT_QUERY = 0x8865
        /// </summary>
        CurrentQuery = 0x8865,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QueryTarget
    {
        /// <summary>
        /// Original was GL_TIME_ELAPSED = 0x88BF
        /// </summary>
        TimeElapsed = 0x88bf,

        /// <summary>
        /// Original was GL_SAMPLES_PASSED = 0x8914
        /// </summary>
        SamplesPassed = 0x8914,

        /// <summary>
        /// Original was GL_ANY_SAMPLES_PASSED = 0x8C2F
        /// </summary>
        AnySamplesPassed = 0x8c2f,

        /// <summary>
        /// Original was GL_PRIMITIVES_GENERATED = 0x8C87
        /// </summary>
        PrimitivesGenerated = 0x8c87,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88
        /// </summary>
        TransformFeedbackPrimitivesWritten = 0x8c88,

        /// <summary>
        /// Original was GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A
        /// </summary>
        AnySamplesPassedConservative = 0x8d6a,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ReadBufferMode
    {
        /// <summary>
        /// Original was GL_FRONT_LEFT = 0x0400
        /// </summary>
        FrontLeft = 0x0400,

        /// <summary>
        /// Original was GL_FRONT_RIGHT = 0x0401
        /// </summary>
        FrontRight = 0x0401,

        /// <summary>
        /// Original was GL_BACK_LEFT = 0x0402
        /// </summary>
        BackLeft = 0x0402,

        /// <summary>
        /// Original was GL_BACK_RIGHT = 0x0403
        /// </summary>
        BackRight = 0x0403,

        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = 0x0404,

        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = 0x0405,

        /// <summary>
        /// Original was GL_LEFT = 0x0406
        /// </summary>
        Left = 0x0406,

        /// <summary>
        /// Original was GL_RIGHT = 0x0407
        /// </summary>
        Right = 0x0407,

        /// <summary>
        /// Original was GL_AUX0 = 0x0409
        /// </summary>
        Aux0 = 0x0409,

        /// <summary>
        /// Original was GL_AUX1 = 0x040A
        /// </summary>
        Aux1 = 0x040a,

        /// <summary>
        /// Original was GL_AUX2 = 0x040B
        /// </summary>
        Aux2 = 0x040b,

        /// <summary>
        /// Original was GL_AUX3 = 0x040C
        /// </summary>
        Aux3 = 0x040c,
    }

    /// <summary>
    /// Used in GL.Oes.GetRenderbufferParameter
    /// </summary>
    public enum RenderbufferParameterName
    {
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES = 0x8CAB
        /// </summary>
        RenderbufferSamples = 0x8cab,

        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH = 0x8D42
        /// </summary>
        RenderbufferWidth = 0x8d42,

        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT = 0x8D43
        /// </summary>
        RenderbufferHeight = 0x8d43,

        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44
        /// </summary>
        RenderbufferInternalFormat = 0x8d44,

        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE = 0x8D50
        /// </summary>
        RenderbufferRedSize = 0x8d50,

        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE = 0x8D51
        /// </summary>
        RenderbufferGreenSize = 0x8d51,

        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE = 0x8D52
        /// </summary>
        RenderbufferBlueSize = 0x8d52,

        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53
        /// </summary>
        RenderbufferAlphaSize = 0x8d53,

        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54
        /// </summary>
        RenderbufferDepthSize = 0x8d54,

        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55
        /// </summary>
        RenderbufferStencilSize = 0x8d55,
    }

    /// <summary>
    /// Used in GL.Apple.RenderbufferStorageMultisample, GL.Ext.RenderbufferStorageMultisample and 5 other functions
    /// </summary>
    public enum RenderbufferTarget
    {
        /// <summary>
        /// Original was GL_RENDERBUFFER = 0x8D41
        /// </summary>
        Renderbuffer = 0x8d41,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum RenderingMode
    {
        /// <summary>
        /// Original was GL_RENDER = 0x1C00
        /// </summary>
        Render = 0x1c00,

        /// <summary>
        /// Original was GL_FEEDBACK = 0x1C01
        /// </summary>
        Feedback = 0x1c01,

        /// <summary>
        /// Original was GL_SELECT = 0x1C02
        /// </summary>
        Select = 0x1c02,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SamplePatternSgis
    {
        /// <summary>
        /// Original was GL_1PASS_EXT = 0x80A1
        /// </summary>
        Gl1PassExt = 0x80a1,

        /// <summary>
        /// Original was GL_1PASS_SGIS = 0x80A1
        /// </summary>
        Gl1PassSgis = 0x80a1,

        /// <summary>
        /// Original was GL_2PASS_0_EXT = 0x80A2
        /// </summary>
        Gl2Pass0Ext = 0x80a2,

        /// <summary>
        /// Original was GL_2PASS_0_SGIS = 0x80A2
        /// </summary>
        Gl2Pass0Sgis = 0x80a2,

        /// <summary>
        /// Original was GL_2PASS_1_EXT = 0x80A3
        /// </summary>
        Gl2Pass1Ext = 0x80a3,

        /// <summary>
        /// Original was GL_2PASS_1_SGIS = 0x80A3
        /// </summary>
        Gl2Pass1Sgis = 0x80a3,

        /// <summary>
        /// Original was GL_4PASS_0_EXT = 0x80A4
        /// </summary>
        Gl4Pass0Ext = 0x80a4,

        /// <summary>
        /// Original was GL_4PASS_0_SGIS = 0x80A4
        /// </summary>
        Gl4Pass0Sgis = 0x80a4,

        /// <summary>
        /// Original was GL_4PASS_1_EXT = 0x80A5
        /// </summary>
        Gl4Pass1Ext = 0x80a5,

        /// <summary>
        /// Original was GL_4PASS_1_SGIS = 0x80A5
        /// </summary>
        Gl4Pass1Sgis = 0x80a5,

        /// <summary>
        /// Original was GL_4PASS_2_EXT = 0x80A6
        /// </summary>
        Gl4Pass2Ext = 0x80a6,

        /// <summary>
        /// Original was GL_4PASS_2_SGIS = 0x80A6
        /// </summary>
        Gl4Pass2Sgis = 0x80a6,

        /// <summary>
        /// Original was GL_4PASS_3_EXT = 0x80A7
        /// </summary>
        Gl4Pass3Ext = 0x80a7,

        /// <summary>
        /// Original was GL_4PASS_3_SGIS = 0x80A7
        /// </summary>
        Gl4Pass3Sgis = 0x80a7,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SamplerParameterName
    {
        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR = 0x1004
        /// </summary>
        TextureBorderColor = 0x1004,

        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = 0x2800,

        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = 0x2801,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = 0x2802,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = 0x2803,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R = 0x8072
        /// </summary>
        TextureWrapR = 0x8072,

        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD = 0x813A
        /// </summary>
        TextureMinLod = 0x813a,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD = 0x813B
        /// </summary>
        TextureMaxLod = 0x813b,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_MODE = 0x884C
        /// </summary>
        TextureCompareMode = 0x884c,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
        /// </summary>
        TextureCompareFunc = 0x884d,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SemaphoreParameterName
    {
        /// <summary>
        /// Original was GL_D3D12_FENCE_VALUE_EXT = 0x9595
        /// </summary>
        D3D12FenceValueExt = 0x9595,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SeparableTargetExt
    {
        /// <summary>
        /// Original was GL_SEPARABLE_2D = 0x8012
        /// </summary>
        Separable2D = 0x8012,

        /// <summary>
        /// Original was GL_SEPARABLE_2D_EXT = 0x8012
        /// </summary>
        Separable2DExt = 0x8012,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ShaderParameterName
    {
        /// <summary>
        /// Original was GL_SHADER_TYPE = 0x8B4F
        /// </summary>
        ShaderType = 0x8b4f,

        /// <summary>
        /// Original was GL_DELETE_STATUS = 0x8B80
        /// </summary>
        DeleteStatus = 0x8b80,

        /// <summary>
        /// Original was GL_COMPILE_STATUS = 0x8B81
        /// </summary>
        CompileStatus = 0x8b81,

        /// <summary>
        /// Original was GL_INFO_LOG_LENGTH = 0x8B84
        /// </summary>
        InfoLogLength = 0x8b84,

        /// <summary>
        /// Original was GL_SHADER_SOURCE_LENGTH = 0x8B88
        /// </summary>
        ShaderSourceLength = 0x8b88,
    }

    /// <summary>
    /// Used in GL.Qcom.ExtGetProgramBinarySource
    /// </summary>
    public enum ShaderType
    {
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER = 0x8B30
        /// </summary>
        FragmentShader = 0x8b30,

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_ARB = 0x8B30
        /// </summary>
        FragmentShaderArb = 0x8b30,

        /// <summary>
        /// Original was GL_VERTEX_SHADER = 0x8B31
        /// </summary>
        VertexShader = 0x8b31,

        /// <summary>
        /// Original was GL_VERTEX_SHADER_ARB = 0x8B31
        /// </summary>
        VertexShaderArb = 0x8b31,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER = 0x8DD9
        /// </summary>
        GeometryShader = 0x8dd9,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER = 0x8E87
        /// </summary>
        TessEvaluationShader = 0x8e87,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER = 0x8E88
        /// </summary>
        TessControlShader = 0x8e88,

        /// <summary>
        /// Original was GL_COMPUTE_SHADER = 0x91B9
        /// </summary>
        ComputeShader = 0x91b9,
    }

    /// <summary>
    /// Used in GL.ShadeModel
    /// </summary>
    public enum ShadingModel
    {
        /// <summary>
        /// Original was GL_FLAT = 0x1D00
        /// </summary>
        Flat = 0x1d00,

        /// <summary>
        /// Original was GL_SMOOTH = 0x1D01
        /// </summary>
        Smooth = 0x1d01,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum StencilFaceDirection
    {
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = 0x0404,

        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = 0x0405,

        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = 0x0408,
    }

    /// <summary>
    /// Used in GL.StencilFunc
    /// </summary>
    public enum StencilFunction
    {
        /// <summary>
        /// Original was GL_NEVER = 0x0200
        /// </summary>
        Never = 0x0200,

        /// <summary>
        /// Original was GL_LESS = 0x0201
        /// </summary>
        Less = 0x0201,

        /// <summary>
        /// Original was GL_EQUAL = 0x0202
        /// </summary>
        Equal = 0x0202,

        /// <summary>
        /// Original was GL_LEQUAL = 0x0203
        /// </summary>
        Lequal = 0x0203,

        /// <summary>
        /// Original was GL_GREATER = 0x0204
        /// </summary>
        Greater = 0x0204,

        /// <summary>
        /// Original was GL_NOTEQUAL = 0x0205
        /// </summary>
        Notequal = 0x0205,

        /// <summary>
        /// Original was GL_GEQUAL = 0x0206
        /// </summary>
        Gequal = 0x0206,

        /// <summary>
        /// Original was GL_ALWAYS = 0x0207
        /// </summary>
        Always = 0x0207,
    }

    /// <summary>
    /// Used in GL.StencilOp
    /// </summary>
    public enum StencilOp
    {
        /// <summary>
        /// Original was GL_ZERO = 0
        /// </summary>
        Zero = 0,

        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = 0x150a,

        /// <summary>
        /// Original was GL_KEEP = 0x1E00
        /// </summary>
        Keep = 0x1e00,

        /// <summary>
        /// Original was GL_REPLACE = 0x1E01
        /// </summary>
        Replace = 0x1e01,

        /// <summary>
        /// Original was GL_INCR = 0x1E02
        /// </summary>
        Incr = 0x1e02,

        /// <summary>
        /// Original was GL_DECR = 0x1E03
        /// </summary>
        Decr = 0x1e03,
    }

    /// <summary>
    /// Used in GL.GetString
    /// </summary>
    public enum StringName
    {
        /// <summary>
        /// Original was GL_VENDOR = 0x1F00
        /// </summary>
        Vendor = 0x1f00,

        /// <summary>
        /// Original was GL_RENDERER = 0x1F01
        /// </summary>
        Renderer = 0x1f01,

        /// <summary>
        /// Original was GL_VERSION = 0x1F02
        /// </summary>
        Version = 0x1f02,

        /// <summary>
        /// Original was GL_EXTENSIONS = 0x1F03
        /// </summary>
        Extensions = 0x1f03,

        /// <summary>
        /// Original was GL_SHADING_LANGUAGE_VERSION = 0x8B8C
        /// </summary>
        ShadingLanguageVersion = 0x8b8c,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SubroutineParameterName
    {
        /// <summary>
        /// Original was GL_UNIFORM_SIZE = 0x8A38
        /// </summary>
        UniformSize = 0x8a38,

        /// <summary>
        /// Original was GL_UNIFORM_NAME_LENGTH = 0x8A39
        /// </summary>
        UniformNameLength = 0x8a39,

        /// <summary>
        /// Original was GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A
        /// </summary>
        NumCompatibleSubroutines = 0x8e4a,

        /// <summary>
        /// Original was GL_COMPATIBLE_SUBROUTINES = 0x8E4B
        /// </summary>
        CompatibleSubroutines = 0x8e4b,
    }

    /// <summary>
    /// Used in GL.Apple.FenceSync
    /// </summary>
    public enum SyncCondition
    {
        /// <summary>
        /// Original was GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117
        /// </summary>
        SyncGpuCommandsComplete = 0x9117,
    }

    /// <summary>
    /// Used in GL.Apple.ClientWaitSync
    /// </summary>
    [Flags]
    public enum SyncObjectMask
    {
        /// <summary>
        /// Original was GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001
        /// </summary>
        SyncFlushCommandsBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001
        /// </summary>
        SyncFlushCommandsBitApple = ((int)0x00000001),
    }

    /// <summary>
    /// Used in GL.Apple.GetSync
    /// </summary>
    public enum SyncParameterName
    {
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
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SyncStatus
    {
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
    }

    /// <summary>
    /// Used in GL.TexCoordPointer
    /// </summary>
    public enum TexCoordPointerType
    {
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = 0x1402,

        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = 0x1404,

        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = 0x140a,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum TextureCombineDot3
    {
        /// <summary>
        /// Original was GL_ALPHA_SCALE = 0x0D1C
        /// </summary>
        AlphaScale = 0x0d1c,

        /// <summary>
        /// Original was GL_SUBTRACT = 0x84E7
        /// </summary>
        Subtract = 0x84e7,

        /// <summary>
        /// Original was GL_COMBINE = 0x8570
        /// </summary>
        Combine = 0x8570,

        /// <summary>
        /// Original was GL_COMBINE_RGB = 0x8571
        /// </summary>
        CombineRgb = 0x8571,

        /// <summary>
        /// Original was GL_COMBINE_ALPHA = 0x8572
        /// </summary>
        CombineAlpha = 0x8572,

        /// <summary>
        /// Original was GL_RGB_SCALE = 0x8573
        /// </summary>
        RgbScale = 0x8573,

        /// <summary>
        /// Original was GL_ADD_SIGNED = 0x8574
        /// </summary>
        AddSigned = 0x8574,

        /// <summary>
        /// Original was GL_INTERPOLATE = 0x8575
        /// </summary>
        Interpolate = 0x8575,

        /// <summary>
        /// Original was GL_CONSTANT = 0x8576
        /// </summary>
        Constant = 0x8576,

        /// <summary>
        /// Original was GL_PRIMARY_COLOR = 0x8577
        /// </summary>
        PrimaryColor = 0x8577,

        /// <summary>
        /// Original was GL_PREVIOUS = 0x8578
        /// </summary>
        Previous = 0x8578,

        /// <summary>
        /// Original was GL_SRC0_RGB = 0x8580
        /// </summary>
        Src0Rgb = 0x8580,

        /// <summary>
        /// Original was GL_SRC1_RGB = 0x8581
        /// </summary>
        Src1Rgb = 0x8581,

        /// <summary>
        /// Original was GL_SRC2_RGB = 0x8582
        /// </summary>
        Src2Rgb = 0x8582,

        /// <summary>
        /// Original was GL_SRC0_ALPHA = 0x8588
        /// </summary>
        Src0Alpha = 0x8588,

        /// <summary>
        /// Original was GL_SRC1_ALPHA = 0x8589
        /// </summary>
        Src1Alpha = 0x8589,

        /// <summary>
        /// Original was GL_SRC2_ALPHA = 0x858A
        /// </summary>
        Src2Alpha = 0x858a,

        /// <summary>
        /// Original was GL_OPERAND0_RGB = 0x8590
        /// </summary>
        Operand0Rgb = 0x8590,

        /// <summary>
        /// Original was GL_OPERAND1_RGB = 0x8591
        /// </summary>
        Operand1Rgb = 0x8591,

        /// <summary>
        /// Original was GL_OPERAND2_RGB = 0x8592
        /// </summary>
        Operand2Rgb = 0x8592,

        /// <summary>
        /// Original was GL_OPERAND0_ALPHA = 0x8598
        /// </summary>
        Operand0Alpha = 0x8598,

        /// <summary>
        /// Original was GL_OPERAND1_ALPHA = 0x8599
        /// </summary>
        Operand1Alpha = 0x8599,

        /// <summary>
        /// Original was GL_OPERAND2_ALPHA = 0x859A
        /// </summary>
        Operand2Alpha = 0x859a,

        /// <summary>
        /// Original was GL_DOT3_RGB = 0x86AE
        /// </summary>
        Dot3Rgb = 0x86ae,

        /// <summary>
        /// Original was GL_DOT3_RGBA = 0x86AF
        /// </summary>
        Dot3Rgba = 0x86af,
    }

    /// <summary>
    /// Used in GL.Oes.GetTexGen, GL.Oes.GetTexGenx and 2 other functions
    /// </summary>
    public enum TextureCoordName
    {
        /// <summary>
        /// Original was GL_S = 0x2000
        /// </summary>
        S = 0x2000,

        /// <summary>
        /// Original was GL_T = 0x2001
        /// </summary>
        T = 0x2001,

        /// <summary>
        /// Original was GL_R = 0x2002
        /// </summary>
        R = 0x2002,

        /// <summary>
        /// Original was GL_Q = 0x2003
        /// </summary>
        Q = 0x2003,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureEnvMode
    {
        /// <summary>
        /// Original was GL_ADD = 0x0104
        /// </summary>
        Add = 0x0104,

        /// <summary>
        /// Original was GL_BLEND = 0x0BE2
        /// </summary>
        Blend = 0x0be2,

        /// <summary>
        /// Original was GL_MODULATE = 0x2100
        /// </summary>
        Modulate = 0x2100,

        /// <summary>
        /// Original was GL_DECAL = 0x2101
        /// </summary>
        Decal = 0x2101,

        /// <summary>
        /// Original was GL_REPLACE_EXT = 0x8062
        /// </summary>
        ReplaceExt = 0x8062,

        /// <summary>
        /// Original was GL_TEXTURE_ENV_BIAS_SGIX = 0x80BE
        /// </summary>
        TextureEnvBiasSgix = 0x80be,
    }

    /// <summary>
    /// Used in GL.GetTexEnv, GL.GetTexEnvx and 4 other functions
    /// </summary>
    public enum TextureEnvParameter
    {
        /// <summary>
        /// Original was GL_TEXTURE_ENV_MODE = 0x2200
        /// </summary>
        TextureEnvMode = 0x2200,

        /// <summary>
        /// Original was GL_TEXTURE_ENV_COLOR = 0x2201
        /// </summary>
        TextureEnvColor = 0x2201,
    }

    /// <summary>
    /// Used in GL.GetTexEnv, GL.GetTexEnvx and 4 other functions
    /// </summary>
    public enum TextureEnvTarget
    {
        /// <summary>
        /// Original was GL_TEXTURE_ENV = 0x2300
        /// </summary>
        TextureEnv = 0x2300,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureFilterFuncSgis
    {
        /// <summary>
        /// Original was GL_FILTER4_SGIS = 0x8146
        /// </summary>
        Filter4Sgis = 0x8146,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureGenMode
    {
        /// <summary>
        /// Original was GL_EYE_LINEAR = 0x2400
        /// </summary>
        EyeLinear = 0x2400,

        /// <summary>
        /// Original was GL_OBJECT_LINEAR = 0x2401
        /// </summary>
        ObjectLinear = 0x2401,

        /// <summary>
        /// Original was GL_SPHERE_MAP = 0x2402
        /// </summary>
        SphereMap = 0x2402,

        /// <summary>
        /// Original was GL_EYE_DISTANCE_TO_POINT_SGIS = 0x81F0
        /// </summary>
        EyeDistanceToPointSgis = 0x81f0,

        /// <summary>
        /// Original was GL_OBJECT_DISTANCE_TO_POINT_SGIS = 0x81F1
        /// </summary>
        ObjectDistanceToPointSgis = 0x81f1,

        /// <summary>
        /// Original was GL_EYE_DISTANCE_TO_LINE_SGIS = 0x81F2
        /// </summary>
        EyeDistanceToLineSgis = 0x81f2,

        /// <summary>
        /// Original was GL_OBJECT_DISTANCE_TO_LINE_SGIS = 0x81F3
        /// </summary>
        ObjectDistanceToLineSgis = 0x81f3,
    }

    /// <summary>
    /// Used in GL.Oes.GetTexGen, GL.Oes.GetTexGenx and 2 other functions
    /// </summary>
    public enum TextureGenParameter
    {
        /// <summary>
        /// Original was GL_TEXTURE_GEN_MODE = 0x2500
        /// </summary>
        TextureGenMode = 0x2500,

        /// <summary>
        /// Original was GL_OBJECT_PLANE = 0x2501
        /// </summary>
        ObjectPlane = 0x2501,

        /// <summary>
        /// Original was GL_EYE_PLANE = 0x2502
        /// </summary>
        EyePlane = 0x2502,

        /// <summary>
        /// Original was GL_EYE_POINT_SGIS = 0x81F4
        /// </summary>
        EyePointSgis = 0x81f4,

        /// <summary>
        /// Original was GL_OBJECT_POINT_SGIS = 0x81F5
        /// </summary>
        ObjectPointSgis = 0x81f5,

        /// <summary>
        /// Original was GL_EYE_LINE_SGIS = 0x81F6
        /// </summary>
        EyeLineSgis = 0x81f6,

        /// <summary>
        /// Original was GL_OBJECT_LINE_SGIS = 0x81F7
        /// </summary>
        ObjectLineSgis = 0x81f7,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureLayout
    {
        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT = 0x9530
        /// </summary>
        LayoutDepthReadOnlyStencilAttachmentExt = 0x9530,

        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT = 0x9531
        /// </summary>
        LayoutDepthAttachmentStencilReadOnlyExt = 0x9531,

        /// <summary>
        /// Original was GL_LAYOUT_GENERAL_EXT = 0x958D
        /// </summary>
        LayoutGeneralExt = 0x958d,

        /// <summary>
        /// Original was GL_LAYOUT_COLOR_ATTACHMENT_EXT = 0x958E
        /// </summary>
        LayoutColorAttachmentExt = 0x958e,

        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT = 0x958F
        /// </summary>
        LayoutDepthStencilAttachmentExt = 0x958f,

        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT = 0x9590
        /// </summary>
        LayoutDepthStencilReadOnlyExt = 0x9590,

        /// <summary>
        /// Original was GL_LAYOUT_SHADER_READ_ONLY_EXT = 0x9591
        /// </summary>
        LayoutShaderReadOnlyExt = 0x9591,

        /// <summary>
        /// Original was GL_LAYOUT_TRANSFER_SRC_EXT = 0x9592
        /// </summary>
        LayoutTransferSrcExt = 0x9592,

        /// <summary>
        /// Original was GL_LAYOUT_TRANSFER_DST_EXT = 0x9593
        /// </summary>
        LayoutTransferDstExt = 0x9593,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureMagFilter
    {
        /// <summary>
        /// Original was GL_NEAREST = 0x2600
        /// </summary>
        Nearest = 0x2600,

        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = 0x2601,

        /// <summary>
        /// Original was GL_LINEAR_DETAIL_SGIS = 0x8097
        /// </summary>
        LinearDetailSgis = 0x8097,

        /// <summary>
        /// Original was GL_LINEAR_DETAIL_ALPHA_SGIS = 0x8098
        /// </summary>
        LinearDetailAlphaSgis = 0x8098,

        /// <summary>
        /// Original was GL_LINEAR_DETAIL_COLOR_SGIS = 0x8099
        /// </summary>
        LinearDetailColorSgis = 0x8099,

        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_SGIS = 0x80AD
        /// </summary>
        LinearSharpenSgis = 0x80ad,

        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE
        /// </summary>
        LinearSharpenAlphaSgis = 0x80ae,

        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_COLOR_SGIS = 0x80AF
        /// </summary>
        LinearSharpenColorSgis = 0x80af,

        /// <summary>
        /// Original was GL_FILTER4_SGIS = 0x8146
        /// </summary>
        Filter4Sgis = 0x8146,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184
        /// </summary>
        PixelTexGenQCeilingSgix = 0x8184,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185
        /// </summary>
        PixelTexGenQRoundSgix = 0x8185,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186
        /// </summary>
        PixelTexGenQFloorSgix = 0x8186,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureMinFilter
    {
        /// <summary>
        /// Original was GL_NEAREST = 0x2600
        /// </summary>
        Nearest = 0x2600,

        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = 0x2601,

        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_NEAREST = 0x2700
        /// </summary>
        NearestMipmapNearest = 0x2700,

        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_NEAREST = 0x2701
        /// </summary>
        LinearMipmapNearest = 0x2701,

        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_LINEAR = 0x2702
        /// </summary>
        NearestMipmapLinear = 0x2702,

        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_LINEAR = 0x2703
        /// </summary>
        LinearMipmapLinear = 0x2703,

        /// <summary>
        /// Original was GL_FILTER4_SGIS = 0x8146
        /// </summary>
        Filter4Sgis = 0x8146,

        /// <summary>
        /// Original was GL_LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170
        /// </summary>
        LinearClipmapLinearSgix = 0x8170,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184
        /// </summary>
        PixelTexGenQCeilingSgix = 0x8184,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185
        /// </summary>
        PixelTexGenQRoundSgix = 0x8185,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186
        /// </summary>
        PixelTexGenQFloorSgix = 0x8186,

        /// <summary>
        /// Original was GL_NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D
        /// </summary>
        NearestClipmapNearestSgix = 0x844d,

        /// <summary>
        /// Original was GL_NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E
        /// </summary>
        NearestClipmapLinearSgix = 0x844e,

        /// <summary>
        /// Original was GL_LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F
        /// </summary>
        LinearClipmapNearestSgix = 0x844f,
    }

    /// <summary>
    /// Used in GL.TexParameter
    /// </summary>
    public enum TextureParameterName
    {
        /// <summary>
        /// Original was GL_TEXTURE_WIDTH = 0x1000
        /// </summary>
        TextureWidth = 0x1000,

        /// <summary>
        /// Original was GL_TEXTURE_HEIGHT = 0x1001
        /// </summary>
        TextureHeight = 0x1001,

        /// <summary>
        /// Original was GL_TEXTURE_COMPONENTS = 0x1003
        /// </summary>
        TextureComponents = 0x1003,

        /// <summary>
        /// Original was GL_TEXTURE_INTERNAL_FORMAT = 0x1003
        /// </summary>
        TextureInternalFormat = 0x1003,

        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR = 0x1004
        /// </summary>
        TextureBorderColor = 0x1004,

        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR_NV = 0x1004
        /// </summary>
        TextureBorderColorNv = 0x1004,

        /// <summary>
        /// Original was GL_TEXTURE_BORDER = 0x1005
        /// </summary>
        TextureBorder = 0x1005,

        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = 0x2800,

        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = 0x2801,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = 0x2802,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = 0x2803,

        /// <summary>
        /// Original was GL_TEXTURE_RED_SIZE = 0x805C
        /// </summary>
        TextureRedSize = 0x805c,

        /// <summary>
        /// Original was GL_TEXTURE_GREEN_SIZE = 0x805D
        /// </summary>
        TextureGreenSize = 0x805d,

        /// <summary>
        /// Original was GL_TEXTURE_BLUE_SIZE = 0x805E
        /// </summary>
        TextureBlueSize = 0x805e,

        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_SIZE = 0x805F
        /// </summary>
        TextureAlphaSize = 0x805f,

        /// <summary>
        /// Original was GL_TEXTURE_LUMINANCE_SIZE = 0x8060
        /// </summary>
        TextureLuminanceSize = 0x8060,

        /// <summary>
        /// Original was GL_TEXTURE_INTENSITY_SIZE = 0x8061
        /// </summary>
        TextureIntensitySize = 0x8061,

        /// <summary>
        /// Original was GL_TEXTURE_PRIORITY = 0x8066
        /// </summary>
        TexturePriority = 0x8066,

        /// <summary>
        /// Original was GL_TEXTURE_PRIORITY_EXT = 0x8066
        /// </summary>
        TexturePriorityExt = 0x8066,

        /// <summary>
        /// Original was GL_TEXTURE_RESIDENT = 0x8067
        /// </summary>
        TextureResident = 0x8067,

        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_EXT = 0x8071
        /// </summary>
        TextureDepthExt = 0x8071,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R = 0x8072
        /// </summary>
        TextureWrapR = 0x8072,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R_EXT = 0x8072
        /// </summary>
        TextureWrapRExt = 0x8072,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R_OES = 0x8072
        /// </summary>
        TextureWrapROes = 0x8072,

        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_LEVEL_SGIS = 0x809A
        /// </summary>
        DetailTextureLevelSgis = 0x809a,

        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_MODE_SGIS = 0x809B
        /// </summary>
        DetailTextureModeSgis = 0x809b,

        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C
        /// </summary>
        DetailTextureFuncPointsSgis = 0x809c,

        /// <summary>
        /// Original was GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0
        /// </summary>
        SharpenTextureFuncPointsSgis = 0x80b0,

        /// <summary>
        /// Original was GL_SHADOW_AMBIENT_SGIX = 0x80BF
        /// </summary>
        ShadowAmbientSgix = 0x80bf,

        /// <summary>
        /// Original was GL_DUAL_TEXTURE_SELECT_SGIS = 0x8124
        /// </summary>
        DualTextureSelectSgis = 0x8124,

        /// <summary>
        /// Original was GL_QUAD_TEXTURE_SELECT_SGIS = 0x8125
        /// </summary>
        QuadTextureSelectSgis = 0x8125,

        /// <summary>
        /// Original was GL_TEXTURE_4DSIZE_SGIS = 0x8136
        /// </summary>
        Texture4DsizeSgis = 0x8136,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_Q_SGIS = 0x8137
        /// </summary>
        TextureWrapQSgis = 0x8137,

        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD = 0x813A
        /// </summary>
        TextureMinLod = 0x813a,

        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD_SGIS = 0x813A
        /// </summary>
        TextureMinLodSgis = 0x813a,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD = 0x813B
        /// </summary>
        TextureMaxLod = 0x813b,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD_SGIS = 0x813B
        /// </summary>
        TextureMaxLodSgis = 0x813b,

        /// <summary>
        /// Original was GL_TEXTURE_BASE_LEVEL = 0x813C
        /// </summary>
        TextureBaseLevel = 0x813c,

        /// <summary>
        /// Original was GL_TEXTURE_BASE_LEVEL_SGIS = 0x813C
        /// </summary>
        TextureBaseLevelSgis = 0x813c,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL = 0x813D
        /// </summary>
        TextureMaxLevel = 0x813d,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL_SGIS = 0x813D
        /// </summary>
        TextureMaxLevelSgis = 0x813d,

        /// <summary>
        /// Original was GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147
        /// </summary>
        TextureFilter4SizeSgis = 0x8147,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171
        /// </summary>
        TextureClipmapCenterSgix = 0x8171,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172
        /// </summary>
        TextureClipmapFrameSgix = 0x8172,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173
        /// </summary>
        TextureClipmapOffsetSgix = 0x8173,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174
        /// </summary>
        TextureClipmapVirtualDepthSgix = 0x8174,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175
        /// </summary>
        TextureClipmapLodOffsetSgix = 0x8175,

        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176
        /// </summary>
        TextureClipmapDepthSgix = 0x8176,

        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179
        /// </summary>
        PostTextureFilterBiasSgix = 0x8179,

        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A
        /// </summary>
        PostTextureFilterScaleSgix = 0x817a,

        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_S_SGIX = 0x818E
        /// </summary>
        TextureLodBiasSSgix = 0x818e,

        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_T_SGIX = 0x818F
        /// </summary>
        TextureLodBiasTSgix = 0x818f,

        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_R_SGIX = 0x8190
        /// </summary>
        TextureLodBiasRSgix = 0x8190,

        /// <summary>
        /// Original was GL_GENERATE_MIPMAP = 0x8191
        /// </summary>
        GenerateMipmap = 0x8191,

        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_SGIS = 0x8191
        /// </summary>
        GenerateMipmapSgis = 0x8191,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_SGIX = 0x819A
        /// </summary>
        TextureCompareSgix = 0x819a,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B
        /// </summary>
        TextureCompareOperatorSgix = 0x819b,

        /// <summary>
        /// Original was GL_TEXTURE_LEQUAL_R_SGIX = 0x819C
        /// </summary>
        TextureLequalRSgix = 0x819c,

        /// <summary>
        /// Original was GL_TEXTURE_GEQUAL_R_SGIX = 0x819D
        /// </summary>
        TextureGequalRSgix = 0x819d,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_S_SGIX = 0x8369
        /// </summary>
        TextureMaxClampSSgix = 0x8369,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_T_SGIX = 0x836A
        /// </summary>
        TextureMaxClampTSgix = 0x836a,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_R_SGIX = 0x836B
        /// </summary>
        TextureMaxClampRSgix = 0x836b,

        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS = 0x8501
        /// </summary>
        TextureLodBias = 0x8501,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_MODE = 0x884C
        /// </summary>
        TextureCompareMode = 0x884c,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
        /// </summary>
        TextureCompareFunc = 0x884d,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_R = 0x8E42
        /// </summary>
        TextureSwizzleR = 0x8e42,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_G = 0x8E43
        /// </summary>
        TextureSwizzleG = 0x8e43,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_B = 0x8E44
        /// </summary>
        TextureSwizzleB = 0x8e44,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_A = 0x8E45
        /// </summary>
        TextureSwizzleA = 0x8e45,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_RGBA = 0x8E46
        /// </summary>
        TextureSwizzleRgba = 0x8e46,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA
        /// </summary>
        DepthStencilTextureMode = 0x90ea,

        /// <summary>
        /// Original was GL_TEXTURE_TILING_EXT = 0x9580
        /// </summary>
        TextureTilingExt = 0x9580,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum TextureStorageMaskAmd
    {
        /// <summary>
        /// Original was GL_TEXTURE_STORAGE_SPARSE_BIT_AMD = 0x00000001
        /// </summary>
        TextureStorageSparseBitAmd = ((int)0x00000001),
    }

    /// <summary>
    /// Used in GL.BindTexture, GL.CompressedTexImage2D and 19 other functions
    /// </summary>
    public enum TextureTarget
    {
        /// <summary>
        /// Original was GL_TEXTURE_1D = 0x0DE0
        /// </summary>
        Texture1D = 0x0de0,

        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = 0x0de1,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D = 0x8063
        /// </summary>
        ProxyTexture1D = 0x8063,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_EXT = 0x8063
        /// </summary>
        ProxyTexture1DExt = 0x8063,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D = 0x8064
        /// </summary>
        ProxyTexture2D = 0x8064,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_EXT = 0x8064
        /// </summary>
        ProxyTexture2DExt = 0x8064,

        /// <summary>
        /// Original was GL_TEXTURE_3D = 0x806F
        /// </summary>
        Texture3D = 0x806f,

        /// <summary>
        /// Original was GL_TEXTURE_3D_EXT = 0x806F
        /// </summary>
        Texture3DExt = 0x806f,

        /// <summary>
        /// Original was GL_TEXTURE_3D_OES = 0x806F
        /// </summary>
        Texture3DOes = 0x806f,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_3D = 0x8070
        /// </summary>
        ProxyTexture3D = 0x8070,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_3D_EXT = 0x8070
        /// </summary>
        ProxyTexture3DExt = 0x8070,

        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_2D_SGIS = 0x8095
        /// </summary>
        DetailTexture2DSgis = 0x8095,

        /// <summary>
        /// Original was GL_TEXTURE_4D_SGIS = 0x8134
        /// </summary>
        Texture4DSgis = 0x8134,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_4D_SGIS = 0x8135
        /// </summary>
        ProxyTexture4DSgis = 0x8135,

        /// <summary>
        /// Original was GL_TEXTURE_RECTANGLE = 0x84F5
        /// </summary>
        TextureRectangle = 0x84f5,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE = 0x84F7
        /// </summary>
        ProxyTextureRectangle = 0x84f7,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7
        /// </summary>
        ProxyTextureRectangleArb = 0x84f7,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE_NV = 0x84F7
        /// </summary>
        ProxyTextureRectangleNv = 0x84f7,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP = 0x8513
        /// </summary>
        TextureCubeMap = 0x8513,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515
        /// </summary>
        TextureCubeMapPositiveX = 0x8515,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516
        /// </summary>
        TextureCubeMapNegativeX = 0x8516,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517
        /// </summary>
        TextureCubeMapPositiveY = 0x8517,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518
        /// </summary>
        TextureCubeMapNegativeY = 0x8518,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519
        /// </summary>
        TextureCubeMapPositiveZ = 0x8519,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A
        /// </summary>
        TextureCubeMapNegativeZ = 0x851a,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP = 0x851B
        /// </summary>
        ProxyTextureCubeMap = 0x851b,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B
        /// </summary>
        ProxyTextureCubeMapArb = 0x851b,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B
        /// </summary>
        ProxyTextureCubeMapExt = 0x851b,

        /// <summary>
        /// Original was GL_TEXTURE_1D_ARRAY = 0x8C18
        /// </summary>
        Texture1DArray = 0x8c18,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19
        /// </summary>
        ProxyTexture1DArray = 0x8c19,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19
        /// </summary>
        ProxyTexture1DArrayExt = 0x8c19,

        /// <summary>
        /// Original was GL_TEXTURE_2D_ARRAY = 0x8C1A
        /// </summary>
        Texture2DArray = 0x8c1a,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B
        /// </summary>
        ProxyTexture2DArray = 0x8c1b,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B
        /// </summary>
        ProxyTexture2DArrayExt = 0x8c1b,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009
        /// </summary>
        TextureCubeMapArray = 0x9009,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009
        /// </summary>
        TextureCubeMapArrayArb = 0x9009,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_EXT = 0x9009
        /// </summary>
        TextureCubeMapArrayExt = 0x9009,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_OES = 0x9009
        /// </summary>
        TextureCubeMapArrayOes = 0x9009,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B
        /// </summary>
        ProxyTextureCubeMapArray = 0x900b,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B
        /// </summary>
        ProxyTextureCubeMapArrayArb = 0x900b,

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
    }

    /// <summary>
    /// Used in GL.ActiveTexture, GL.ClientActiveTexture and 10 other functions
    /// </summary>
    public enum TextureUnit
    {
        /// <summary>
        /// Original was GL_TEXTURE0 = 0x84C0
        /// </summary>
        Texture0 = 0x84c0,

        /// <summary>
        /// Original was GL_TEXTURE1 = 0x84C1
        /// </summary>
        Texture1 = 0x84c1,

        /// <summary>
        /// Original was GL_TEXTURE2 = 0x84C2
        /// </summary>
        Texture2 = 0x84c2,

        /// <summary>
        /// Original was GL_TEXTURE3 = 0x84C3
        /// </summary>
        Texture3 = 0x84c3,

        /// <summary>
        /// Original was GL_TEXTURE4 = 0x84C4
        /// </summary>
        Texture4 = 0x84c4,

        /// <summary>
        /// Original was GL_TEXTURE5 = 0x84C5
        /// </summary>
        Texture5 = 0x84c5,

        /// <summary>
        /// Original was GL_TEXTURE6 = 0x84C6
        /// </summary>
        Texture6 = 0x84c6,

        /// <summary>
        /// Original was GL_TEXTURE7 = 0x84C7
        /// </summary>
        Texture7 = 0x84c7,

        /// <summary>
        /// Original was GL_TEXTURE8 = 0x84C8
        /// </summary>
        Texture8 = 0x84c8,

        /// <summary>
        /// Original was GL_TEXTURE9 = 0x84C9
        /// </summary>
        Texture9 = 0x84c9,

        /// <summary>
        /// Original was GL_TEXTURE10 = 0x84CA
        /// </summary>
        Texture10 = 0x84ca,

        /// <summary>
        /// Original was GL_TEXTURE11 = 0x84CB
        /// </summary>
        Texture11 = 0x84cb,

        /// <summary>
        /// Original was GL_TEXTURE12 = 0x84CC
        /// </summary>
        Texture12 = 0x84cc,

        /// <summary>
        /// Original was GL_TEXTURE13 = 0x84CD
        /// </summary>
        Texture13 = 0x84cd,

        /// <summary>
        /// Original was GL_TEXTURE14 = 0x84CE
        /// </summary>
        Texture14 = 0x84ce,

        /// <summary>
        /// Original was GL_TEXTURE15 = 0x84CF
        /// </summary>
        Texture15 = 0x84cf,

        /// <summary>
        /// Original was GL_TEXTURE16 = 0x84D0
        /// </summary>
        Texture16 = 0x84d0,

        /// <summary>
        /// Original was GL_TEXTURE17 = 0x84D1
        /// </summary>
        Texture17 = 0x84d1,

        /// <summary>
        /// Original was GL_TEXTURE18 = 0x84D2
        /// </summary>
        Texture18 = 0x84d2,

        /// <summary>
        /// Original was GL_TEXTURE19 = 0x84D3
        /// </summary>
        Texture19 = 0x84d3,

        /// <summary>
        /// Original was GL_TEXTURE20 = 0x84D4
        /// </summary>
        Texture20 = 0x84d4,

        /// <summary>
        /// Original was GL_TEXTURE21 = 0x84D5
        /// </summary>
        Texture21 = 0x84d5,

        /// <summary>
        /// Original was GL_TEXTURE22 = 0x84D6
        /// </summary>
        Texture22 = 0x84d6,

        /// <summary>
        /// Original was GL_TEXTURE23 = 0x84D7
        /// </summary>
        Texture23 = 0x84d7,

        /// <summary>
        /// Original was GL_TEXTURE24 = 0x84D8
        /// </summary>
        Texture24 = 0x84d8,

        /// <summary>
        /// Original was GL_TEXTURE25 = 0x84D9
        /// </summary>
        Texture25 = 0x84d9,

        /// <summary>
        /// Original was GL_TEXTURE26 = 0x84DA
        /// </summary>
        Texture26 = 0x84da,

        /// <summary>
        /// Original was GL_TEXTURE27 = 0x84DB
        /// </summary>
        Texture27 = 0x84db,

        /// <summary>
        /// Original was GL_TEXTURE28 = 0x84DC
        /// </summary>
        Texture28 = 0x84dc,

        /// <summary>
        /// Original was GL_TEXTURE29 = 0x84DD
        /// </summary>
        Texture29 = 0x84dd,

        /// <summary>
        /// Original was GL_TEXTURE30 = 0x84DE
        /// </summary>
        Texture30 = 0x84de,

        /// <summary>
        /// Original was GL_TEXTURE31 = 0x84DF
        /// </summary>
        Texture31 = 0x84df,

        /// <summary>
        /// Original was GL_ACTIVE_TEXTURE = 0x84E0
        /// </summary>
        ActiveTexture = 0x84e0,

        /// <summary>
        /// Original was GL_CLIENT_ACTIVE_TEXTURE = 0x84E1
        /// </summary>
        ClientActiveTexture = 0x84e1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureWrapMode
    {
        /// <summary>
        /// Original was GL_CLAMP = 0x2900
        /// </summary>
        Clamp = 0x2900,

        /// <summary>
        /// Original was GL_REPEAT = 0x2901
        /// </summary>
        Repeat = 0x2901,

        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER = 0x812D
        /// </summary>
        ClampToBorder = 0x812d,

        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER_ARB = 0x812D
        /// </summary>
        ClampToBorderArb = 0x812d,

        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER_NV = 0x812D
        /// </summary>
        ClampToBorderNv = 0x812d,

        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER_SGIS = 0x812D
        /// </summary>
        ClampToBorderSgis = 0x812d,

        /// <summary>
        /// Original was GL_CLAMP_TO_EDGE = 0x812F
        /// </summary>
        ClampToEdge = 0x812f,

        /// <summary>
        /// Original was GL_CLAMP_TO_EDGE_SGIS = 0x812F
        /// </summary>
        ClampToEdgeSgis = 0x812f,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TransformFeedbackPName
    {
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84
        /// </summary>
        TransformFeedbackBufferStart = 0x8c84,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85
        /// </summary>
        TransformFeedbackBufferSize = 0x8c85,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F
        /// </summary>
        TransformFeedbackBufferBinding = 0x8c8f,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23
        /// </summary>
        TransformFeedbackPaused = 0x8e23,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24
        /// </summary>
        TransformFeedbackActive = 0x8e24,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TypeEnum
    {
        /// <summary>
        /// Original was GL_QUERY_WAIT = 0x8E13
        /// </summary>
        QueryWait = 0x8e13,

        /// <summary>
        /// Original was GL_QUERY_NO_WAIT = 0x8E14
        /// </summary>
        QueryNoWait = 0x8e14,

        /// <summary>
        /// Original was GL_QUERY_BY_REGION_WAIT = 0x8E15
        /// </summary>
        QueryByRegionWait = 0x8e15,

        /// <summary>
        /// Original was GL_QUERY_BY_REGION_NO_WAIT = 0x8E16
        /// </summary>
        QueryByRegionNoWait = 0x8e16,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum UniformBlockPName
    {
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0
        /// </summary>
        UniformBlockReferencedByTessControlShader = 0x84f0,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1
        /// </summary>
        UniformBlockReferencedByTessEvaluationShader = 0x84f1,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_BINDING = 0x8A3F
        /// </summary>
        UniformBlockBinding = 0x8a3f,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40
        /// </summary>
        UniformBlockDataSize = 0x8a40,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41
        /// </summary>
        UniformBlockNameLength = 0x8a41,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42
        /// </summary>
        UniformBlockActiveUniforms = 0x8a42,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43
        /// </summary>
        UniformBlockActiveUniformIndices = 0x8a43,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44
        /// </summary>
        UniformBlockReferencedByVertexShader = 0x8a44,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45
        /// </summary>
        UniformBlockReferencedByGeometryShader = 0x8a45,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46
        /// </summary>
        UniformBlockReferencedByFragmentShader = 0x8a46,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC
        /// </summary>
        UniformBlockReferencedByComputeShader = 0x90ec,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum UniformPName
    {
        /// <summary>
        /// Original was GL_UNIFORM_TYPE = 0x8A37
        /// </summary>
        UniformType = 0x8a37,

        /// <summary>
        /// Original was GL_UNIFORM_SIZE = 0x8A38
        /// </summary>
        UniformSize = 0x8a38,

        /// <summary>
        /// Original was GL_UNIFORM_NAME_LENGTH = 0x8A39
        /// </summary>
        UniformNameLength = 0x8a39,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_INDEX = 0x8A3A
        /// </summary>
        UniformBlockIndex = 0x8a3a,

        /// <summary>
        /// Original was GL_UNIFORM_OFFSET = 0x8A3B
        /// </summary>
        UniformOffset = 0x8a3b,

        /// <summary>
        /// Original was GL_UNIFORM_ARRAY_STRIDE = 0x8A3C
        /// </summary>
        UniformArrayStride = 0x8a3c,

        /// <summary>
        /// Original was GL_UNIFORM_MATRIX_STRIDE = 0x8A3D
        /// </summary>
        UniformMatrixStride = 0x8a3d,

        /// <summary>
        /// Original was GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E
        /// </summary>
        UniformIsRowMajor = 0x8a3e,

        /// <summary>
        /// Original was GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA
        /// </summary>
        UniformAtomicCounterBufferIndex = 0x92da,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum UseProgramStageMask
    {
        /// <summary>
        /// Original was GL_VERTEX_SHADER_BIT = 0x00000001
        /// </summary>
        VertexShaderBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_VERTEX_SHADER_BIT_EXT = 0x00000001
        /// </summary>
        VertexShaderBitExt = ((int)0x00000001),

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_BIT = 0x00000002
        /// </summary>
        FragmentShaderBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_BIT_EXT = 0x00000002
        /// </summary>
        FragmentShaderBitExt = ((int)0x00000002),

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_BIT = 0x00000004
        /// </summary>
        GeometryShaderBit = ((int)0x00000004),

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_BIT_EXT = 0x00000004
        /// </summary>
        GeometryShaderBitExt = ((int)0x00000004),

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_BIT_OES = 0x00000004
        /// </summary>
        GeometryShaderBitOes = ((int)0x00000004),

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER_BIT = 0x00000008
        /// </summary>
        TessControlShaderBit = ((int)0x00000008),

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER_BIT_EXT = 0x00000008
        /// </summary>
        TessControlShaderBitExt = ((int)0x00000008),

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER_BIT_OES = 0x00000008
        /// </summary>
        TessControlShaderBitOes = ((int)0x00000008),

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER_BIT = 0x00000010
        /// </summary>
        TessEvaluationShaderBit = ((int)0x00000010),

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER_BIT_EXT = 0x00000010
        /// </summary>
        TessEvaluationShaderBitExt = ((int)0x00000010),

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER_BIT_OES = 0x00000010
        /// </summary>
        TessEvaluationShaderBitOes = ((int)0x00000010),

        /// <summary>
        /// Original was GL_COMPUTE_SHADER_BIT = 0x00000020
        /// </summary>
        ComputeShaderBit = ((int)0x00000020),

        /// <summary>
        /// Original was GL_ALL_SHADER_BITS = 0xFFFFFFFF
        /// </summary>
        AllShaderBits = unchecked((int)0xffffffff),

        /// <summary>
        /// Original was GL_ALL_SHADER_BITS_EXT = 0xFFFFFFFF
        /// </summary>
        AllShaderBitsExt = unchecked((int)0xffffffff),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VersionEsCm10
    {
        /// <summary>
        /// Original was GL_FALSE = 0
        /// </summary>
        False = 0,

        /// <summary>
        /// Original was GL_NO_ERROR = 0
        /// </summary>
        NoError = 0,

        /// <summary>
        /// Original was GL_ZERO = 0
        /// </summary>
        Zero = 0,

        /// <summary>
        /// Original was GL_POINTS = 0x0000
        /// </summary>
        Points = 0x0000,

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT = 0x00000100
        /// </summary>
        DepthBufferBit = ((int)0x00000100),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT = 0x00000400
        /// </summary>
        StencilBufferBit = ((int)0x00000400),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT = 0x00004000
        /// </summary>
        ColorBufferBit = ((int)0x00004000),

        /// <summary>
        /// Original was GL_LINES = 0x0001
        /// </summary>
        Lines = 0x0001,

        /// <summary>
        /// Original was GL_LINE_LOOP = 0x0002
        /// </summary>
        LineLoop = 0x0002,

        /// <summary>
        /// Original was GL_LINE_STRIP = 0x0003
        /// </summary>
        LineStrip = 0x0003,

        /// <summary>
        /// Original was GL_TRIANGLES = 0x0004
        /// </summary>
        Triangles = 0x0004,

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP = 0x0005
        /// </summary>
        TriangleStrip = 0x0005,

        /// <summary>
        /// Original was GL_TRIANGLE_FAN = 0x0006
        /// </summary>
        TriangleFan = 0x0006,

        /// <summary>
        /// Original was GL_ADD = 0x0104
        /// </summary>
        Add = 0x0104,

        /// <summary>
        /// Original was GL_NEVER = 0x0200
        /// </summary>
        Never = 0x0200,

        /// <summary>
        /// Original was GL_LESS = 0x0201
        /// </summary>
        Less = 0x0201,

        /// <summary>
        /// Original was GL_EQUAL = 0x0202
        /// </summary>
        Equal = 0x0202,

        /// <summary>
        /// Original was GL_LEQUAL = 0x0203
        /// </summary>
        Lequal = 0x0203,

        /// <summary>
        /// Original was GL_GREATER = 0x0204
        /// </summary>
        Greater = 0x0204,

        /// <summary>
        /// Original was GL_NOTEQUAL = 0x0205
        /// </summary>
        Notequal = 0x0205,

        /// <summary>
        /// Original was GL_GEQUAL = 0x0206
        /// </summary>
        Gequal = 0x0206,

        /// <summary>
        /// Original was GL_ALWAYS = 0x0207
        /// </summary>
        Always = 0x0207,

        /// <summary>
        /// Original was GL_SRC_COLOR = 0x0300
        /// </summary>
        SrcColor = 0x0300,

        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_COLOR = 0x0301
        /// </summary>
        OneMinusSrcColor = 0x0301,

        /// <summary>
        /// Original was GL_SRC_ALPHA = 0x0302
        /// </summary>
        SrcAlpha = 0x0302,

        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_ALPHA = 0x0303
        /// </summary>
        OneMinusSrcAlpha = 0x0303,

        /// <summary>
        /// Original was GL_DST_ALPHA = 0x0304
        /// </summary>
        DstAlpha = 0x0304,

        /// <summary>
        /// Original was GL_ONE_MINUS_DST_ALPHA = 0x0305
        /// </summary>
        OneMinusDstAlpha = 0x0305,

        /// <summary>
        /// Original was GL_DST_COLOR = 0x0306
        /// </summary>
        DstColor = 0x0306,

        /// <summary>
        /// Original was GL_ONE_MINUS_DST_COLOR = 0x0307
        /// </summary>
        OneMinusDstColor = 0x0307,

        /// <summary>
        /// Original was GL_SRC_ALPHA_SATURATE = 0x0308
        /// </summary>
        SrcAlphaSaturate = 0x0308,

        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = 0x0404,

        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = 0x0405,

        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = 0x0408,

        /// <summary>
        /// Original was GL_INVALID_ENUM = 0x0500
        /// </summary>
        InvalidEnum = 0x0500,

        /// <summary>
        /// Original was GL_INVALID_VALUE = 0x0501
        /// </summary>
        InvalidValue = 0x0501,

        /// <summary>
        /// Original was GL_INVALID_OPERATION = 0x0502
        /// </summary>
        InvalidOperation = 0x0502,

        /// <summary>
        /// Original was GL_STACK_OVERFLOW = 0x0503
        /// </summary>
        StackOverflow = 0x0503,

        /// <summary>
        /// Original was GL_STACK_UNDERFLOW = 0x0504
        /// </summary>
        StackUnderflow = 0x0504,

        /// <summary>
        /// Original was GL_OUT_OF_MEMORY = 0x0505
        /// </summary>
        OutOfMemory = 0x0505,

        /// <summary>
        /// Original was GL_EXP = 0x0800
        /// </summary>
        Exp = 0x0800,

        /// <summary>
        /// Original was GL_EXP2 = 0x0801
        /// </summary>
        Exp2 = 0x0801,

        /// <summary>
        /// Original was GL_CW = 0x0900
        /// </summary>
        Cw = 0x0900,

        /// <summary>
        /// Original was GL_CCW = 0x0901
        /// </summary>
        Ccw = 0x0901,

        /// <summary>
        /// Original was GL_CURRENT_COLOR = 0x0B00
        /// </summary>
        CurrentColor = 0x0b00,

        /// <summary>
        /// Original was GL_CURRENT_NORMAL = 0x0B02
        /// </summary>
        CurrentNormal = 0x0b02,

        /// <summary>
        /// Original was GL_CURRENT_TEXTURE_COORDS = 0x0B03
        /// </summary>
        CurrentTextureCoords = 0x0b03,

        /// <summary>
        /// Original was GL_POINT_SMOOTH = 0x0B10
        /// </summary>
        PointSmooth = 0x0b10,

        /// <summary>
        /// Original was GL_POINT_SIZE = 0x0B11
        /// </summary>
        PointSize = 0x0b11,

        /// <summary>
        /// Original was GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12
        /// </summary>
        SmoothPointSizeRange = 0x0b12,

        /// <summary>
        /// Original was GL_LINE_SMOOTH = 0x0B20
        /// </summary>
        LineSmooth = 0x0b20,

        /// <summary>
        /// Original was GL_LINE_WIDTH = 0x0B21
        /// </summary>
        LineWidth = 0x0b21,

        /// <summary>
        /// Original was GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22
        /// </summary>
        SmoothLineWidthRange = 0x0b22,

        /// <summary>
        /// Original was GL_CULL_FACE = 0x0B44
        /// </summary>
        CullFace = 0x0b44,

        /// <summary>
        /// Original was GL_CULL_FACE_MODE = 0x0B45
        /// </summary>
        CullFaceMode = 0x0b45,

        /// <summary>
        /// Original was GL_FRONT_FACE = 0x0B46
        /// </summary>
        FrontFace = 0x0b46,

        /// <summary>
        /// Original was GL_LIGHTING = 0x0B50
        /// </summary>
        Lighting = 0x0b50,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_TWO_SIDE = 0x0B52
        /// </summary>
        LightModelTwoSide = 0x0b52,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_AMBIENT = 0x0B53
        /// </summary>
        LightModelAmbient = 0x0b53,

        /// <summary>
        /// Original was GL_SHADE_MODEL = 0x0B54
        /// </summary>
        ShadeModel = 0x0b54,

        /// <summary>
        /// Original was GL_COLOR_MATERIAL = 0x0B57
        /// </summary>
        ColorMaterial = 0x0b57,

        /// <summary>
        /// Original was GL_FOG = 0x0B60
        /// </summary>
        Fog = 0x0b60,

        /// <summary>
        /// Original was GL_FOG_DENSITY = 0x0B62
        /// </summary>
        FogDensity = 0x0b62,

        /// <summary>
        /// Original was GL_FOG_START = 0x0B63
        /// </summary>
        FogStart = 0x0b63,

        /// <summary>
        /// Original was GL_FOG_END = 0x0B64
        /// </summary>
        FogEnd = 0x0b64,

        /// <summary>
        /// Original was GL_FOG_MODE = 0x0B65
        /// </summary>
        FogMode = 0x0b65,

        /// <summary>
        /// Original was GL_FOG_COLOR = 0x0B66
        /// </summary>
        FogColor = 0x0b66,

        /// <summary>
        /// Original was GL_DEPTH_RANGE = 0x0B70
        /// </summary>
        DepthRange = 0x0b70,

        /// <summary>
        /// Original was GL_DEPTH_TEST = 0x0B71
        /// </summary>
        DepthTest = 0x0b71,

        /// <summary>
        /// Original was GL_DEPTH_WRITEMASK = 0x0B72
        /// </summary>
        DepthWritemask = 0x0b72,

        /// <summary>
        /// Original was GL_DEPTH_CLEAR_VALUE = 0x0B73
        /// </summary>
        DepthClearValue = 0x0b73,

        /// <summary>
        /// Original was GL_DEPTH_FUNC = 0x0B74
        /// </summary>
        DepthFunc = 0x0b74,

        /// <summary>
        /// Original was GL_STENCIL_TEST = 0x0B90
        /// </summary>
        StencilTest = 0x0b90,

        /// <summary>
        /// Original was GL_STENCIL_CLEAR_VALUE = 0x0B91
        /// </summary>
        StencilClearValue = 0x0b91,

        /// <summary>
        /// Original was GL_STENCIL_FUNC = 0x0B92
        /// </summary>
        StencilFunc = 0x0b92,

        /// <summary>
        /// Original was GL_STENCIL_VALUE_MASK = 0x0B93
        /// </summary>
        StencilValueMask = 0x0b93,

        /// <summary>
        /// Original was GL_STENCIL_FAIL = 0x0B94
        /// </summary>
        StencilFail = 0x0b94,

        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95
        /// </summary>
        StencilPassDepthFail = 0x0b95,

        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_PASS = 0x0B96
        /// </summary>
        StencilPassDepthPass = 0x0b96,

        /// <summary>
        /// Original was GL_STENCIL_REF = 0x0B97
        /// </summary>
        StencilRef = 0x0b97,

        /// <summary>
        /// Original was GL_STENCIL_WRITEMASK = 0x0B98
        /// </summary>
        StencilWritemask = 0x0b98,

        /// <summary>
        /// Original was GL_MATRIX_MODE = 0x0BA0
        /// </summary>
        MatrixMode = 0x0ba0,

        /// <summary>
        /// Original was GL_NORMALIZE = 0x0BA1
        /// </summary>
        Normalize = 0x0ba1,

        /// <summary>
        /// Original was GL_VIEWPORT = 0x0BA2
        /// </summary>
        Viewport = 0x0ba2,

        /// <summary>
        /// Original was GL_MODELVIEW_STACK_DEPTH = 0x0BA3
        /// </summary>
        ModelviewStackDepth = 0x0ba3,

        /// <summary>
        /// Original was GL_PROJECTION_STACK_DEPTH = 0x0BA4
        /// </summary>
        ProjectionStackDepth = 0x0ba4,

        /// <summary>
        /// Original was GL_TEXTURE_STACK_DEPTH = 0x0BA5
        /// </summary>
        TextureStackDepth = 0x0ba5,

        /// <summary>
        /// Original was GL_MODELVIEW_MATRIX = 0x0BA6
        /// </summary>
        ModelviewMatrix = 0x0ba6,

        /// <summary>
        /// Original was GL_PROJECTION_MATRIX = 0x0BA7
        /// </summary>
        ProjectionMatrix = 0x0ba7,

        /// <summary>
        /// Original was GL_TEXTURE_MATRIX = 0x0BA8
        /// </summary>
        TextureMatrix = 0x0ba8,

        /// <summary>
        /// Original was GL_ALPHA_TEST = 0x0BC0
        /// </summary>
        AlphaTest = 0x0bc0,

        /// <summary>
        /// Original was GL_ALPHA_TEST_FUNC = 0x0BC1
        /// </summary>
        AlphaTestFunc = 0x0bc1,

        /// <summary>
        /// Original was GL_ALPHA_TEST_REF = 0x0BC2
        /// </summary>
        AlphaTestRef = 0x0bc2,

        /// <summary>
        /// Original was GL_DITHER = 0x0BD0
        /// </summary>
        Dither = 0x0bd0,

        /// <summary>
        /// Original was GL_BLEND_DST = 0x0BE0
        /// </summary>
        BlendDst = 0x0be0,

        /// <summary>
        /// Original was GL_BLEND_SRC = 0x0BE1
        /// </summary>
        BlendSrc = 0x0be1,

        /// <summary>
        /// Original was GL_BLEND = 0x0BE2
        /// </summary>
        Blend = 0x0be2,

        /// <summary>
        /// Original was GL_LOGIC_OP_MODE = 0x0BF0
        /// </summary>
        LogicOpMode = 0x0bf0,

        /// <summary>
        /// Original was GL_COLOR_LOGIC_OP = 0x0BF2
        /// </summary>
        ColorLogicOp = 0x0bf2,

        /// <summary>
        /// Original was GL_SCISSOR_BOX = 0x0C10
        /// </summary>
        ScissorBox = 0x0c10,

        /// <summary>
        /// Original was GL_SCISSOR_TEST = 0x0C11
        /// </summary>
        ScissorTest = 0x0c11,

        /// <summary>
        /// Original was GL_COLOR_CLEAR_VALUE = 0x0C22
        /// </summary>
        ColorClearValue = 0x0c22,

        /// <summary>
        /// Original was GL_COLOR_WRITEMASK = 0x0C23
        /// </summary>
        ColorWritemask = 0x0c23,

        /// <summary>
        /// Original was GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50
        /// </summary>
        PerspectiveCorrectionHint = 0x0c50,

        /// <summary>
        /// Original was GL_POINT_SMOOTH_HINT = 0x0C51
        /// </summary>
        PointSmoothHint = 0x0c51,

        /// <summary>
        /// Original was GL_LINE_SMOOTH_HINT = 0x0C52
        /// </summary>
        LineSmoothHint = 0x0c52,

        /// <summary>
        /// Original was GL_FOG_HINT = 0x0C54
        /// </summary>
        FogHint = 0x0c54,

        /// <summary>
        /// Original was GL_UNPACK_ALIGNMENT = 0x0CF5
        /// </summary>
        UnpackAlignment = 0x0cf5,

        /// <summary>
        /// Original was GL_PACK_ALIGNMENT = 0x0D05
        /// </summary>
        PackAlignment = 0x0d05,

        /// <summary>
        /// Original was GL_ALPHA_SCALE = 0x0D1C
        /// </summary>
        AlphaScale = 0x0d1c,

        /// <summary>
        /// Original was GL_MAX_LIGHTS = 0x0D31
        /// </summary>
        MaxLights = 0x0d31,

        /// <summary>
        /// Original was GL_MAX_CLIP_PLANES = 0x0D32
        /// </summary>
        MaxClipPlanes = 0x0d32,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_SIZE = 0x0D33
        /// </summary>
        MaxTextureSize = 0x0d33,

        /// <summary>
        /// Original was GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36
        /// </summary>
        MaxModelviewStackDepth = 0x0d36,

        /// <summary>
        /// Original was GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38
        /// </summary>
        MaxProjectionStackDepth = 0x0d38,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39
        /// </summary>
        MaxTextureStackDepth = 0x0d39,

        /// <summary>
        /// Original was GL_MAX_VIEWPORT_DIMS = 0x0D3A
        /// </summary>
        MaxViewportDims = 0x0d3a,

        /// <summary>
        /// Original was GL_SUBPIXEL_BITS = 0x0D50
        /// </summary>
        SubpixelBits = 0x0d50,

        /// <summary>
        /// Original was GL_RED_BITS = 0x0D52
        /// </summary>
        RedBits = 0x0d52,

        /// <summary>
        /// Original was GL_GREEN_BITS = 0x0D53
        /// </summary>
        GreenBits = 0x0d53,

        /// <summary>
        /// Original was GL_BLUE_BITS = 0x0D54
        /// </summary>
        BlueBits = 0x0d54,

        /// <summary>
        /// Original was GL_ALPHA_BITS = 0x0D55
        /// </summary>
        AlphaBits = 0x0d55,

        /// <summary>
        /// Original was GL_DEPTH_BITS = 0x0D56
        /// </summary>
        DepthBits = 0x0d56,

        /// <summary>
        /// Original was GL_STENCIL_BITS = 0x0D57
        /// </summary>
        StencilBits = 0x0d57,

        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = 0x0de1,

        /// <summary>
        /// Original was GL_DONT_CARE = 0x1100
        /// </summary>
        DontCare = 0x1100,

        /// <summary>
        /// Original was GL_FASTEST = 0x1101
        /// </summary>
        Fastest = 0x1101,

        /// <summary>
        /// Original was GL_NICEST = 0x1102
        /// </summary>
        Nicest = 0x1102,

        /// <summary>
        /// Original was GL_AMBIENT = 0x1200
        /// </summary>
        Ambient = 0x1200,

        /// <summary>
        /// Original was GL_DIFFUSE = 0x1201
        /// </summary>
        Diffuse = 0x1201,

        /// <summary>
        /// Original was GL_SPECULAR = 0x1202
        /// </summary>
        Specular = 0x1202,

        /// <summary>
        /// Original was GL_POSITION = 0x1203
        /// </summary>
        Position = 0x1203,

        /// <summary>
        /// Original was GL_SPOT_DIRECTION = 0x1204
        /// </summary>
        SpotDirection = 0x1204,

        /// <summary>
        /// Original was GL_SPOT_EXPONENT = 0x1205
        /// </summary>
        SpotExponent = 0x1205,

        /// <summary>
        /// Original was GL_SPOT_CUTOFF = 0x1206
        /// </summary>
        SpotCutoff = 0x1206,

        /// <summary>
        /// Original was GL_CONSTANT_ATTENUATION = 0x1207
        /// </summary>
        ConstantAttenuation = 0x1207,

        /// <summary>
        /// Original was GL_LINEAR_ATTENUATION = 0x1208
        /// </summary>
        LinearAttenuation = 0x1208,

        /// <summary>
        /// Original was GL_QUADRATIC_ATTENUATION = 0x1209
        /// </summary>
        QuadraticAttenuation = 0x1209,

        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = 0x1400,

        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = 0x1401,

        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = 0x1402,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = 0x1403,

        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_FIXED = 0x140C
        /// </summary>
        Fixed = 0x140c,

        /// <summary>
        /// Original was GL_CLEAR = 0x1500
        /// </summary>
        Clear = 0x1500,

        /// <summary>
        /// Original was GL_AND = 0x1501
        /// </summary>
        And = 0x1501,

        /// <summary>
        /// Original was GL_AND_REVERSE = 0x1502
        /// </summary>
        AndReverse = 0x1502,

        /// <summary>
        /// Original was GL_COPY = 0x1503
        /// </summary>
        Copy = 0x1503,

        /// <summary>
        /// Original was GL_AND_INVERTED = 0x1504
        /// </summary>
        AndInverted = 0x1504,

        /// <summary>
        /// Original was GL_NOOP = 0x1505
        /// </summary>
        Noop = 0x1505,

        /// <summary>
        /// Original was GL_XOR = 0x1506
        /// </summary>
        Xor = 0x1506,

        /// <summary>
        /// Original was GL_OR = 0x1507
        /// </summary>
        Or = 0x1507,

        /// <summary>
        /// Original was GL_NOR = 0x1508
        /// </summary>
        Nor = 0x1508,

        /// <summary>
        /// Original was GL_EQUIV = 0x1509
        /// </summary>
        Equiv = 0x1509,

        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = 0x150a,

        /// <summary>
        /// Original was GL_OR_REVERSE = 0x150B
        /// </summary>
        OrReverse = 0x150b,

        /// <summary>
        /// Original was GL_COPY_INVERTED = 0x150C
        /// </summary>
        CopyInverted = 0x150c,

        /// <summary>
        /// Original was GL_OR_INVERTED = 0x150D
        /// </summary>
        OrInverted = 0x150d,

        /// <summary>
        /// Original was GL_NAND = 0x150E
        /// </summary>
        Nand = 0x150e,

        /// <summary>
        /// Original was GL_SET = 0x150F
        /// </summary>
        Set = 0x150f,

        /// <summary>
        /// Original was GL_EMISSION = 0x1600
        /// </summary>
        Emission = 0x1600,

        /// <summary>
        /// Original was GL_SHININESS = 0x1601
        /// </summary>
        Shininess = 0x1601,

        /// <summary>
        /// Original was GL_AMBIENT_AND_DIFFUSE = 0x1602
        /// </summary>
        AmbientAndDiffuse = 0x1602,

        /// <summary>
        /// Original was GL_MODELVIEW = 0x1700
        /// </summary>
        Modelview = 0x1700,

        /// <summary>
        /// Original was GL_PROJECTION = 0x1701
        /// </summary>
        Projection = 0x1701,

        /// <summary>
        /// Original was GL_TEXTURE = 0x1702
        /// </summary>
        Texture = 0x1702,

        /// <summary>
        /// Original was GL_ALPHA = 0x1906
        /// </summary>
        Alpha = 0x1906,

        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = 0x1907,

        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = 0x1908,

        /// <summary>
        /// Original was GL_LUMINANCE = 0x1909
        /// </summary>
        Luminance = 0x1909,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = 0x190a,

        /// <summary>
        /// Original was GL_FLAT = 0x1D00
        /// </summary>
        Flat = 0x1d00,

        /// <summary>
        /// Original was GL_SMOOTH = 0x1D01
        /// </summary>
        Smooth = 0x1d01,

        /// <summary>
        /// Original was GL_KEEP = 0x1E00
        /// </summary>
        Keep = 0x1e00,

        /// <summary>
        /// Original was GL_REPLACE = 0x1E01
        /// </summary>
        Replace = 0x1e01,

        /// <summary>
        /// Original was GL_INCR = 0x1E02
        /// </summary>
        Incr = 0x1e02,

        /// <summary>
        /// Original was GL_DECR = 0x1E03
        /// </summary>
        Decr = 0x1e03,

        /// <summary>
        /// Original was GL_VENDOR = 0x1F00
        /// </summary>
        Vendor = 0x1f00,

        /// <summary>
        /// Original was GL_RENDERER = 0x1F01
        /// </summary>
        Renderer = 0x1f01,

        /// <summary>
        /// Original was GL_VERSION = 0x1F02
        /// </summary>
        Version = 0x1f02,

        /// <summary>
        /// Original was GL_EXTENSIONS = 0x1F03
        /// </summary>
        Extensions = 0x1f03,

        /// <summary>
        /// Original was GL_MODULATE = 0x2100
        /// </summary>
        Modulate = 0x2100,

        /// <summary>
        /// Original was GL_DECAL = 0x2101
        /// </summary>
        Decal = 0x2101,

        /// <summary>
        /// Original was GL_TEXTURE_ENV_MODE = 0x2200
        /// </summary>
        TextureEnvMode = 0x2200,

        /// <summary>
        /// Original was GL_TEXTURE_ENV_COLOR = 0x2201
        /// </summary>
        TextureEnvColor = 0x2201,

        /// <summary>
        /// Original was GL_TEXTURE_ENV = 0x2300
        /// </summary>
        TextureEnv = 0x2300,

        /// <summary>
        /// Original was GL_NEAREST = 0x2600
        /// </summary>
        Nearest = 0x2600,

        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = 0x2601,

        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_NEAREST = 0x2700
        /// </summary>
        NearestMipmapNearest = 0x2700,

        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_NEAREST = 0x2701
        /// </summary>
        LinearMipmapNearest = 0x2701,

        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_LINEAR = 0x2702
        /// </summary>
        NearestMipmapLinear = 0x2702,

        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_LINEAR = 0x2703
        /// </summary>
        LinearMipmapLinear = 0x2703,

        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = 0x2800,

        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = 0x2801,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = 0x2802,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = 0x2803,

        /// <summary>
        /// Original was GL_REPEAT = 0x2901
        /// </summary>
        Repeat = 0x2901,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_UNITS = 0x2A00
        /// </summary>
        PolygonOffsetUnits = 0x2a00,

        /// <summary>
        /// Original was GL_CLIP_PLANE0 = 0x3000
        /// </summary>
        ClipPlane0 = 0x3000,

        /// <summary>
        /// Original was GL_CLIP_PLANE1 = 0x3001
        /// </summary>
        ClipPlane1 = 0x3001,

        /// <summary>
        /// Original was GL_CLIP_PLANE2 = 0x3002
        /// </summary>
        ClipPlane2 = 0x3002,

        /// <summary>
        /// Original was GL_CLIP_PLANE3 = 0x3003
        /// </summary>
        ClipPlane3 = 0x3003,

        /// <summary>
        /// Original was GL_CLIP_PLANE4 = 0x3004
        /// </summary>
        ClipPlane4 = 0x3004,

        /// <summary>
        /// Original was GL_CLIP_PLANE5 = 0x3005
        /// </summary>
        ClipPlane5 = 0x3005,

        /// <summary>
        /// Original was GL_LIGHT0 = 0x4000
        /// </summary>
        Light0 = 0x4000,

        /// <summary>
        /// Original was GL_LIGHT1 = 0x4001
        /// </summary>
        Light1 = 0x4001,

        /// <summary>
        /// Original was GL_LIGHT2 = 0x4002
        /// </summary>
        Light2 = 0x4002,

        /// <summary>
        /// Original was GL_LIGHT3 = 0x4003
        /// </summary>
        Light3 = 0x4003,

        /// <summary>
        /// Original was GL_LIGHT4 = 0x4004
        /// </summary>
        Light4 = 0x4004,

        /// <summary>
        /// Original was GL_LIGHT5 = 0x4005
        /// </summary>
        Light5 = 0x4005,

        /// <summary>
        /// Original was GL_LIGHT6 = 0x4006
        /// </summary>
        Light6 = 0x4006,

        /// <summary>
        /// Original was GL_LIGHT7 = 0x4007
        /// </summary>
        Light7 = 0x4007,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033
        /// </summary>
        UnsignedShort4444 = 0x8033,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034
        /// </summary>
        UnsignedShort5551 = 0x8034,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FILL = 0x8037
        /// </summary>
        PolygonOffsetFill = 0x8037,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FACTOR = 0x8038
        /// </summary>
        PolygonOffsetFactor = 0x8038,

        /// <summary>
        /// Original was GL_RESCALE_NORMAL = 0x803A
        /// </summary>
        RescaleNormal = 0x803a,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D = 0x8069
        /// </summary>
        TextureBinding2D = 0x8069,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = 0x8074,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY = 0x8075
        /// </summary>
        NormalArray = 0x8075,

        /// <summary>
        /// Original was GL_COLOR_ARRAY = 0x8076
        /// </summary>
        ColorArray = 0x8076,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY = 0x8078
        /// </summary>
        TextureCoordArray = 0x8078,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_SIZE = 0x807A
        /// </summary>
        VertexArraySize = 0x807a,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_TYPE = 0x807B
        /// </summary>
        VertexArrayType = 0x807b,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_STRIDE = 0x807C
        /// </summary>
        VertexArrayStride = 0x807c,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_TYPE = 0x807E
        /// </summary>
        NormalArrayType = 0x807e,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_STRIDE = 0x807F
        /// </summary>
        NormalArrayStride = 0x807f,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_SIZE = 0x8081
        /// </summary>
        ColorArraySize = 0x8081,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_TYPE = 0x8082
        /// </summary>
        ColorArrayType = 0x8082,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_STRIDE = 0x8083
        /// </summary>
        ColorArrayStride = 0x8083,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088
        /// </summary>
        TextureCoordArraySize = 0x8088,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089
        /// </summary>
        TextureCoordArrayType = 0x8089,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A
        /// </summary>
        TextureCoordArrayStride = 0x808a,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_POINTER = 0x808E
        /// </summary>
        VertexArrayPointer = 0x808e,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_POINTER = 0x808F
        /// </summary>
        NormalArrayPointer = 0x808f,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_POINTER = 0x8090
        /// </summary>
        ColorArrayPointer = 0x8090,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092
        /// </summary>
        TextureCoordArrayPointer = 0x8092,

        /// <summary>
        /// Original was GL_MULTISAMPLE = 0x809D
        /// </summary>
        Multisample = 0x809d,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E
        /// </summary>
        SampleAlphaToCoverage = 0x809e,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE = 0x809F
        /// </summary>
        SampleAlphaToOne = 0x809f,

        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE = 0x80A0
        /// </summary>
        SampleCoverage = 0x80a0,

        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS = 0x80A8
        /// </summary>
        SampleBuffers = 0x80a8,

        /// <summary>
        /// Original was GL_SAMPLES = 0x80A9
        /// </summary>
        Samples = 0x80a9,

        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_VALUE = 0x80AA
        /// </summary>
        SampleCoverageValue = 0x80aa,

        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_INVERT = 0x80AB
        /// </summary>
        SampleCoverageInvert = 0x80ab,

        /// <summary>
        /// Original was GL_POINT_SIZE_MIN = 0x8126
        /// </summary>
        PointSizeMin = 0x8126,

        /// <summary>
        /// Original was GL_POINT_SIZE_MAX = 0x8127
        /// </summary>
        PointSizeMax = 0x8127,

        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE = 0x8128
        /// </summary>
        PointFadeThresholdSize = 0x8128,

        /// <summary>
        /// Original was GL_POINT_DISTANCE_ATTENUATION = 0x8129
        /// </summary>
        PointDistanceAttenuation = 0x8129,

        /// <summary>
        /// Original was GL_CLAMP_TO_EDGE = 0x812F
        /// </summary>
        ClampToEdge = 0x812f,

        /// <summary>
        /// Original was GL_GENERATE_MIPMAP = 0x8191
        /// </summary>
        GenerateMipmap = 0x8191,

        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT = 0x8192
        /// </summary>
        GenerateMipmapHint = 0x8192,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_6_5 = 0x8363
        /// </summary>
        UnsignedShort565 = 0x8363,

        /// <summary>
        /// Original was GL_ALIASED_POINT_SIZE_RANGE = 0x846D
        /// </summary>
        AliasedPointSizeRange = 0x846d,

        /// <summary>
        /// Original was GL_ALIASED_LINE_WIDTH_RANGE = 0x846E
        /// </summary>
        AliasedLineWidthRange = 0x846e,

        /// <summary>
        /// Original was GL_TEXTURE0 = 0x84C0
        /// </summary>
        Texture0 = 0x84c0,

        /// <summary>
        /// Original was GL_TEXTURE1 = 0x84C1
        /// </summary>
        Texture1 = 0x84c1,

        /// <summary>
        /// Original was GL_TEXTURE2 = 0x84C2
        /// </summary>
        Texture2 = 0x84c2,

        /// <summary>
        /// Original was GL_TEXTURE3 = 0x84C3
        /// </summary>
        Texture3 = 0x84c3,

        /// <summary>
        /// Original was GL_TEXTURE4 = 0x84C4
        /// </summary>
        Texture4 = 0x84c4,

        /// <summary>
        /// Original was GL_TEXTURE5 = 0x84C5
        /// </summary>
        Texture5 = 0x84c5,

        /// <summary>
        /// Original was GL_TEXTURE6 = 0x84C6
        /// </summary>
        Texture6 = 0x84c6,

        /// <summary>
        /// Original was GL_TEXTURE7 = 0x84C7
        /// </summary>
        Texture7 = 0x84c7,

        /// <summary>
        /// Original was GL_TEXTURE8 = 0x84C8
        /// </summary>
        Texture8 = 0x84c8,

        /// <summary>
        /// Original was GL_TEXTURE9 = 0x84C9
        /// </summary>
        Texture9 = 0x84c9,

        /// <summary>
        /// Original was GL_TEXTURE10 = 0x84CA
        /// </summary>
        Texture10 = 0x84ca,

        /// <summary>
        /// Original was GL_TEXTURE11 = 0x84CB
        /// </summary>
        Texture11 = 0x84cb,

        /// <summary>
        /// Original was GL_TEXTURE12 = 0x84CC
        /// </summary>
        Texture12 = 0x84cc,

        /// <summary>
        /// Original was GL_TEXTURE13 = 0x84CD
        /// </summary>
        Texture13 = 0x84cd,

        /// <summary>
        /// Original was GL_TEXTURE14 = 0x84CE
        /// </summary>
        Texture14 = 0x84ce,

        /// <summary>
        /// Original was GL_TEXTURE15 = 0x84CF
        /// </summary>
        Texture15 = 0x84cf,

        /// <summary>
        /// Original was GL_TEXTURE16 = 0x84D0
        /// </summary>
        Texture16 = 0x84d0,

        /// <summary>
        /// Original was GL_TEXTURE17 = 0x84D1
        /// </summary>
        Texture17 = 0x84d1,

        /// <summary>
        /// Original was GL_TEXTURE18 = 0x84D2
        /// </summary>
        Texture18 = 0x84d2,

        /// <summary>
        /// Original was GL_TEXTURE19 = 0x84D3
        /// </summary>
        Texture19 = 0x84d3,

        /// <summary>
        /// Original was GL_TEXTURE20 = 0x84D4
        /// </summary>
        Texture20 = 0x84d4,

        /// <summary>
        /// Original was GL_TEXTURE21 = 0x84D5
        /// </summary>
        Texture21 = 0x84d5,

        /// <summary>
        /// Original was GL_TEXTURE22 = 0x84D6
        /// </summary>
        Texture22 = 0x84d6,

        /// <summary>
        /// Original was GL_TEXTURE23 = 0x84D7
        /// </summary>
        Texture23 = 0x84d7,

        /// <summary>
        /// Original was GL_TEXTURE24 = 0x84D8
        /// </summary>
        Texture24 = 0x84d8,

        /// <summary>
        /// Original was GL_TEXTURE25 = 0x84D9
        /// </summary>
        Texture25 = 0x84d9,

        /// <summary>
        /// Original was GL_TEXTURE26 = 0x84DA
        /// </summary>
        Texture26 = 0x84da,

        /// <summary>
        /// Original was GL_TEXTURE27 = 0x84DB
        /// </summary>
        Texture27 = 0x84db,

        /// <summary>
        /// Original was GL_TEXTURE28 = 0x84DC
        /// </summary>
        Texture28 = 0x84dc,

        /// <summary>
        /// Original was GL_TEXTURE29 = 0x84DD
        /// </summary>
        Texture29 = 0x84dd,

        /// <summary>
        /// Original was GL_TEXTURE30 = 0x84DE
        /// </summary>
        Texture30 = 0x84de,

        /// <summary>
        /// Original was GL_TEXTURE31 = 0x84DF
        /// </summary>
        Texture31 = 0x84df,

        /// <summary>
        /// Original was GL_ACTIVE_TEXTURE = 0x84E0
        /// </summary>
        ActiveTexture = 0x84e0,

        /// <summary>
        /// Original was GL_CLIENT_ACTIVE_TEXTURE = 0x84E1
        /// </summary>
        ClientActiveTexture = 0x84e1,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_UNITS = 0x84E2
        /// </summary>
        MaxTextureUnits = 0x84e2,

        /// <summary>
        /// Original was GL_SUBTRACT = 0x84E7
        /// </summary>
        Subtract = 0x84e7,

        /// <summary>
        /// Original was GL_COMBINE = 0x8570
        /// </summary>
        Combine = 0x8570,

        /// <summary>
        /// Original was GL_COMBINE_RGB = 0x8571
        /// </summary>
        CombineRgb = 0x8571,

        /// <summary>
        /// Original was GL_COMBINE_ALPHA = 0x8572
        /// </summary>
        CombineAlpha = 0x8572,

        /// <summary>
        /// Original was GL_RGB_SCALE = 0x8573
        /// </summary>
        RgbScale = 0x8573,

        /// <summary>
        /// Original was GL_ADD_SIGNED = 0x8574
        /// </summary>
        AddSigned = 0x8574,

        /// <summary>
        /// Original was GL_INTERPOLATE = 0x8575
        /// </summary>
        Interpolate = 0x8575,

        /// <summary>
        /// Original was GL_CONSTANT = 0x8576
        /// </summary>
        Constant = 0x8576,

        /// <summary>
        /// Original was GL_PRIMARY_COLOR = 0x8577
        /// </summary>
        PrimaryColor = 0x8577,

        /// <summary>
        /// Original was GL_PREVIOUS = 0x8578
        /// </summary>
        Previous = 0x8578,

        /// <summary>
        /// Original was GL_SRC0_RGB = 0x8580
        /// </summary>
        Src0Rgb = 0x8580,

        /// <summary>
        /// Original was GL_SRC1_RGB = 0x8581
        /// </summary>
        Src1Rgb = 0x8581,

        /// <summary>
        /// Original was GL_SRC2_RGB = 0x8582
        /// </summary>
        Src2Rgb = 0x8582,

        /// <summary>
        /// Original was GL_SRC0_ALPHA = 0x8588
        /// </summary>
        Src0Alpha = 0x8588,

        /// <summary>
        /// Original was GL_SRC1_ALPHA = 0x8589
        /// </summary>
        Src1Alpha = 0x8589,

        /// <summary>
        /// Original was GL_SRC2_ALPHA = 0x858A
        /// </summary>
        Src2Alpha = 0x858a,

        /// <summary>
        /// Original was GL_OPERAND0_RGB = 0x8590
        /// </summary>
        Operand0Rgb = 0x8590,

        /// <summary>
        /// Original was GL_OPERAND1_RGB = 0x8591
        /// </summary>
        Operand1Rgb = 0x8591,

        /// <summary>
        /// Original was GL_OPERAND2_RGB = 0x8592
        /// </summary>
        Operand2Rgb = 0x8592,

        /// <summary>
        /// Original was GL_OPERAND0_ALPHA = 0x8598
        /// </summary>
        Operand0Alpha = 0x8598,

        /// <summary>
        /// Original was GL_OPERAND1_ALPHA = 0x8599
        /// </summary>
        Operand1Alpha = 0x8599,

        /// <summary>
        /// Original was GL_OPERAND2_ALPHA = 0x859A
        /// </summary>
        Operand2Alpha = 0x859a,

        /// <summary>
        /// Original was GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2
        /// </summary>
        NumCompressedTextureFormats = 0x86a2,

        /// <summary>
        /// Original was GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3
        /// </summary>
        CompressedTextureFormats = 0x86a3,

        /// <summary>
        /// Original was GL_DOT3_RGB = 0x86AE
        /// </summary>
        Dot3Rgb = 0x86ae,

        /// <summary>
        /// Original was GL_DOT3_RGBA = 0x86AF
        /// </summary>
        Dot3Rgba = 0x86af,

        /// <summary>
        /// Original was GL_BUFFER_SIZE = 0x8764
        /// </summary>
        BufferSize = 0x8764,

        /// <summary>
        /// Original was GL_BUFFER_USAGE = 0x8765
        /// </summary>
        BufferUsage = 0x8765,

        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = 0x8892,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = 0x8893,

        /// <summary>
        /// Original was GL_ARRAY_BUFFER_BINDING = 0x8894
        /// </summary>
        ArrayBufferBinding = 0x8894,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895
        /// </summary>
        ElementArrayBufferBinding = 0x8895,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896
        /// </summary>
        VertexArrayBufferBinding = 0x8896,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897
        /// </summary>
        NormalArrayBufferBinding = 0x8897,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898
        /// </summary>
        ColorArrayBufferBinding = 0x8898,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A
        /// </summary>
        TextureCoordArrayBufferBinding = 0x889a,

        /// <summary>
        /// Original was GL_STATIC_DRAW = 0x88E4
        /// </summary>
        StaticDraw = 0x88e4,

        /// <summary>
        /// Original was GL_DYNAMIC_DRAW = 0x88E8
        /// </summary>
        DynamicDraw = 0x88e8,

        /// <summary>
        /// Original was GL_ONE = 1
        /// </summary>
        One = 1,

        /// <summary>
        /// Original was GL_TRUE = 1
        /// </summary>
        True = 1,

        /// <summary>
        /// Original was GL_VERSION_ES_CL_1_0 = 1
        /// </summary>
        VersionEsCl10 = 1,

        /// <summary>
        /// Original was GL_VERSION_ES_CL_1_1 = 1
        /// </summary>
        VersionEsCl11 = 1,

        /// <summary>
        /// Original was GL_VERSION_ES_CM_1_1 = 1
        /// </summary>
        VersionEsCm11 = 1,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexArrayPName
    {
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5
        /// </summary>
        VertexAttribRelativeOffset = 0x82d5,

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
        /// Original was GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E
        /// </summary>
        VertexAttribArrayLong = 0x874e,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A
        /// </summary>
        VertexAttribArrayNormalized = 0x886a,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD
        /// </summary>
        VertexAttribArrayInteger = 0x88fd,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE
        /// </summary>
        VertexAttribArrayDivisor = 0x88fe,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexAttribEnum
    {
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
        /// Original was GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A
        /// </summary>
        VertexAttribArrayNormalized = 0x886a,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F
        /// </summary>
        VertexAttribArrayBufferBinding = 0x889f,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD
        /// </summary>
        VertexAttribArrayInteger = 0x88fd,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE
        /// </summary>
        VertexAttribArrayDivisor = 0x88fe,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexAttribPointerType
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = 0x1400,

        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = 0x1401,

        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = 0x1402,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = 0x1403,

        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = 0x1404,

        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = 0x1405,

        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = 0x140a,

        /// <summary>
        /// Original was GL_HALF_FLOAT = 0x140B
        /// </summary>
        HalfFloat = 0x140b,

        /// <summary>
        /// Original was GL_FIXED = 0x140C
        /// </summary>
        Fixed = 0x140c,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368
        /// </summary>
        UnsignedInt2101010Rev = 0x8368,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        /// </summary>
        UnsignedInt10F11F11FRev = 0x8c3b,

        /// <summary>
        /// Original was GL_INT_2_10_10_10_REV = 0x8D9F
        /// </summary>
        Int2101010Rev = 0x8d9f,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexAttribType
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = 0x1400,

        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = 0x1401,

        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = 0x1402,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = 0x1403,

        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = 0x1404,

        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = 0x1405,

        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = 0x140a,

        /// <summary>
        /// Original was GL_HALF_FLOAT = 0x140B
        /// </summary>
        HalfFloat = 0x140b,

        /// <summary>
        /// Original was GL_FIXED = 0x140C
        /// </summary>
        Fixed = 0x140c,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368
        /// </summary>
        UnsignedInt2101010Rev = 0x8368,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        /// </summary>
        UnsignedInt10F11F11FRev = 0x8c3b,

        /// <summary>
        /// Original was GL_INT_2_10_10_10_REV = 0x8D9F
        /// </summary>
        Int2101010Rev = 0x8d9f,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexBufferObjectParameter
    {
        /// <summary>
        /// Original was GL_BUFFER_IMMUTABLE_STORAGE = 0x821F
        /// </summary>
        BufferImmutableStorage = 0x821f,

        /// <summary>
        /// Original was GL_BUFFER_STORAGE_FLAGS = 0x8220
        /// </summary>
        BufferStorageFlags = 0x8220,

        /// <summary>
        /// Original was GL_BUFFER_SIZE = 0x8764
        /// </summary>
        BufferSize = 0x8764,

        /// <summary>
        /// Original was GL_BUFFER_USAGE = 0x8765
        /// </summary>
        BufferUsage = 0x8765,

        /// <summary>
        /// Original was GL_BUFFER_ACCESS = 0x88BB
        /// </summary>
        BufferAccess = 0x88bb,

        /// <summary>
        /// Original was GL_BUFFER_MAPPED = 0x88BC
        /// </summary>
        BufferMapped = 0x88bc,

        /// <summary>
        /// Original was GL_BUFFER_ACCESS_FLAGS = 0x911F
        /// </summary>
        BufferAccessFlags = 0x911f,

        /// <summary>
        /// Original was GL_BUFFER_MAP_LENGTH = 0x9120
        /// </summary>
        BufferMapLength = 0x9120,

        /// <summary>
        /// Original was GL_BUFFER_MAP_OFFSET = 0x9121
        /// </summary>
        BufferMapOffset = 0x9121,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexBufferObjectUsage
    {
        /// <summary>
        /// Original was GL_STREAM_DRAW = 0x88E0
        /// </summary>
        StreamDraw = 0x88e0,

        /// <summary>
        /// Original was GL_STREAM_READ = 0x88E1
        /// </summary>
        StreamRead = 0x88e1,

        /// <summary>
        /// Original was GL_STREAM_COPY = 0x88E2
        /// </summary>
        StreamCopy = 0x88e2,

        /// <summary>
        /// Original was GL_STATIC_DRAW = 0x88E4
        /// </summary>
        StaticDraw = 0x88e4,

        /// <summary>
        /// Original was GL_STATIC_READ = 0x88E5
        /// </summary>
        StaticRead = 0x88e5,

        /// <summary>
        /// Original was GL_STATIC_COPY = 0x88E6
        /// </summary>
        StaticCopy = 0x88e6,

        /// <summary>
        /// Original was GL_DYNAMIC_DRAW = 0x88E8
        /// </summary>
        DynamicDraw = 0x88e8,

        /// <summary>
        /// Original was GL_DYNAMIC_READ = 0x88E9
        /// </summary>
        DynamicRead = 0x88e9,

        /// <summary>
        /// Original was GL_DYNAMIC_COPY = 0x88EA
        /// </summary>
        DynamicCopy = 0x88ea,
    }

    /// <summary>
    /// Used in GL.VertexPointer
    /// </summary>
    public enum VertexPointerType
    {
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = 0x1402,

        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = 0x1404,

        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = 0x140a,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexProvokingMode
    {
        /// <summary>
        /// Original was GL_FIRST_VERTEX_CONVENTION = 0x8E4D
        /// </summary>
        FirstVertexConvention = 0x8e4d,

        /// <summary>
        /// Original was GL_LAST_VERTEX_CONVENTION = 0x8E4E
        /// </summary>
        LastVertexConvention = 0x8e4e,
    }

}
