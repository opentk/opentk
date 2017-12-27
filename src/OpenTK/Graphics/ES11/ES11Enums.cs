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
    public enum AccumOp : int
    {
        /// <summary>
        /// Original was GL_ACCUM = 0x0100
        /// </summary>
        Accum = ((int)0x0100),
        /// <summary>
        /// Original was GL_LOAD = 0x0101
        /// </summary>
        Load = ((int)0x0101),
        /// <summary>
        /// Original was GL_RETURN = 0x0102
        /// </summary>
        Return = ((int)0x0102),
        /// <summary>
        /// Original was GL_MULT = 0x0103
        /// </summary>
        Mult = ((int)0x0103),
        /// <summary>
        /// Original was GL_ADD = 0x0104
        /// </summary>
        Add = ((int)0x0104),
    }

    /// <summary>
    /// Used in GL.Apple.ClientWaitSync, GL.Apple.FenceSync and 179 other functions
    /// </summary>
    public enum All : int
    {
        /// <summary>
        /// Original was GL_FALSE = 0
        /// </summary>
        False = ((int)0),
        /// <summary>
        /// Original was GL_LAYOUT_DEFAULT_INTEL = 0
        /// </summary>
        LayoutDefaultIntel = ((int)0),
        /// <summary>
        /// Original was GL_NO_ERROR = 0
        /// </summary>
        NoError = ((int)0),
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = ((int)0),
        /// <summary>
        /// Original was GL_NONE_OES = 0
        /// </summary>
        NoneOes = ((int)0),
        /// <summary>
        /// Original was GL_ZERO = 0
        /// </summary>
        Zero = ((int)0),
        /// <summary>
        /// Original was GL_Points = 0X0000
        /// </summary>
        Points = ((int)0X0000),
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
        MapReadBit = ((int)0x0001),
        /// <summary>
        /// Original was GL_MAP_READ_BIT_EXT = 0x0001
        /// </summary>
        MapReadBitExt = ((int)0x0001),
        /// <summary>
        /// Original was GL_Lines = 0X0001
        /// </summary>
        Lines = ((int)0X0001),
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
        LineLoop = ((int)0x0002),
        /// <summary>
        /// Original was GL_MAP_WRITE_BIT = 0x0002
        /// </summary>
        MapWriteBit = ((int)0x0002),
        /// <summary>
        /// Original was GL_MAP_WRITE_BIT_EXT = 0x0002
        /// </summary>
        MapWriteBitExt = ((int)0x0002),
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
        LineStrip = ((int)0x0003),
        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT = 0x0004
        /// </summary>
        MapInvalidateRangeBit = ((int)0x0004),
        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004
        /// </summary>
        MapInvalidateRangeBitExt = ((int)0x0004),
        /// <summary>
        /// Original was GL_Triangles = 0X0004
        /// </summary>
        Triangles = ((int)0X0004),
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
        TriangleStrip = ((int)0x0005),
        /// <summary>
        /// Original was GL_TRIANGLE_FAN = 0x0006
        /// </summary>
        TriangleFan = ((int)0x0006),
        /// <summary>
        /// Original was GL_QUADS = 0x0007
        /// </summary>
        Quads = ((int)0x0007),
        /// <summary>
        /// Original was GL_QUADS_EXT = 0x0007
        /// </summary>
        QuadsExt = ((int)0x0007),
        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008
        /// </summary>
        MapInvalidateBufferBit = ((int)0x0008),
        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008
        /// </summary>
        MapInvalidateBufferBitExt = ((int)0x0008),
        /// <summary>
        /// Original was GL_QUAD_STRIP = 0x0008
        /// </summary>
        QuadStrip = ((int)0x0008),
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
        Polygon = ((int)0x0009),
        /// <summary>
        /// Original was GL_LINES_ADJACENCY = 0x000A
        /// </summary>
        LinesAdjacency = ((int)0x000A),
        /// <summary>
        /// Original was GL_LINES_ADJACENCY_ARB = 0x000A
        /// </summary>
        LinesAdjacencyArb = ((int)0x000A),
        /// <summary>
        /// Original was GL_LINES_ADJACENCY_EXT = 0x000A
        /// </summary>
        LinesAdjacencyExt = ((int)0x000A),
        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY = 0x000B
        /// </summary>
        LineStripAdjacency = ((int)0x000B),
        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY_ARB = 0x000B
        /// </summary>
        LineStripAdjacencyArb = ((int)0x000B),
        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY_EXT = 0x000B
        /// </summary>
        LineStripAdjacencyExt = ((int)0x000B),
        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY = 0x000C
        /// </summary>
        TrianglesAdjacency = ((int)0x000C),
        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY_ARB = 0x000C
        /// </summary>
        TrianglesAdjacencyArb = ((int)0x000C),
        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY_EXT = 0x000C
        /// </summary>
        TrianglesAdjacencyExt = ((int)0x000C),
        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY = 0x000D
        /// </summary>
        TriangleStripAdjacency = ((int)0x000D),
        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D
        /// </summary>
        TriangleStripAdjacencyArb = ((int)0x000D),
        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D
        /// </summary>
        TriangleStripAdjacencyExt = ((int)0x000D),
        /// <summary>
        /// Original was GL_PATCHES = 0x000E
        /// </summary>
        Patches = ((int)0x000E),
        /// <summary>
        /// Original was GL_PATCHES_EXT = 0x000E
        /// </summary>
        PatchesExt = ((int)0x000E),
        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010
        /// </summary>
        MapFlushExplicitBit = ((int)0x0010),
        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010
        /// </summary>
        MapFlushExplicitBitExt = ((int)0x0010),
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
        MapUnsynchronizedBit = ((int)0x0020),
        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020
        /// </summary>
        MapUnsynchronizedBitExt = ((int)0x0020),
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
        MapPersistentBit = ((int)0x0040),
        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT_EXT = 0x0040
        /// </summary>
        MapPersistentBitExt = ((int)0x0040),
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
        MapCoherentBit = ((int)0x0080),
        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT_EXT = 0x0080
        /// </summary>
        MapCoherentBitExt = ((int)0x0080),
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
        BoldBitNv = ((int)0x01),
        /// <summary>
        /// Original was GL_GLYPH_WIDTH_BIT_NV = 0x01
        /// </summary>
        GlyphWidthBitNv = ((int)0x01),
        /// <summary>
        /// Original was GL_ACCUM = 0x0100
        /// </summary>
        Accum = ((int)0x0100),
        /// <summary>
        /// Original was GL_DYNAMIC_STORAGE_BIT = 0x0100
        /// </summary>
        DynamicStorageBit = ((int)0x0100),
        /// <summary>
        /// Original was GL_DYNAMIC_STORAGE_BIT_EXT = 0x0100
        /// </summary>
        DynamicStorageBitExt = ((int)0x0100),
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
        Load = ((int)0x0101),
        /// <summary>
        /// Original was GL_RETURN = 0x0102
        /// </summary>
        Return = ((int)0x0102),
        /// <summary>
        /// Original was GL_MULT = 0x0103
        /// </summary>
        Mult = ((int)0x0103),
        /// <summary>
        /// Original was GL_ADD = 0x0104
        /// </summary>
        Add = ((int)0x0104),
        /// <summary>
        /// Original was GL_GLYPH_HEIGHT_BIT_NV = 0x02
        /// </summary>
        GlyphHeightBitNv = ((int)0x02),
        /// <summary>
        /// Original was GL_ITALIC_BIT_NV = 0x02
        /// </summary>
        ItalicBitNv = ((int)0x02),
        /// <summary>
        /// Original was GL_CLIENT_STORAGE_BIT = 0x0200
        /// </summary>
        ClientStorageBit = ((int)0x0200),
        /// <summary>
        /// Original was GL_CLIENT_STORAGE_BIT_EXT = 0x0200
        /// </summary>
        ClientStorageBitExt = ((int)0x0200),
        /// <summary>
        /// Original was GL_NEVER = 0x0200
        /// </summary>
        Never = ((int)0x0200),
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
        Less = ((int)0x0201),
        /// <summary>
        /// Original was GL_EQUAL = 0x0202
        /// </summary>
        Equal = ((int)0x0202),
        /// <summary>
        /// Original was GL_LEQUAL = 0x0203
        /// </summary>
        Lequal = ((int)0x0203),
        /// <summary>
        /// Original was GL_GREATER = 0x0204
        /// </summary>
        Greater = ((int)0x0204),
        /// <summary>
        /// Original was GL_NOTEQUAL = 0x0205
        /// </summary>
        Notequal = ((int)0x0205),
        /// <summary>
        /// Original was GL_GEQUAL = 0x0206
        /// </summary>
        Gequal = ((int)0x0206),
        /// <summary>
        /// Original was GL_ALWAYS = 0x0207
        /// </summary>
        Always = ((int)0x0207),
        /// <summary>
        /// Original was GL_SRC_COLOR = 0x0300
        /// </summary>
        SrcColor = ((int)0x0300),
        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_COLOR = 0x0301
        /// </summary>
        OneMinusSrcColor = ((int)0x0301),
        /// <summary>
        /// Original was GL_SRC_ALPHA = 0x0302
        /// </summary>
        SrcAlpha = ((int)0x0302),
        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_ALPHA = 0x0303
        /// </summary>
        OneMinusSrcAlpha = ((int)0x0303),
        /// <summary>
        /// Original was GL_DST_ALPHA = 0x0304
        /// </summary>
        DstAlpha = ((int)0x0304),
        /// <summary>
        /// Original was GL_ONE_MINUS_DST_ALPHA = 0x0305
        /// </summary>
        OneMinusDstAlpha = ((int)0x0305),
        /// <summary>
        /// Original was GL_DST_COLOR = 0x0306
        /// </summary>
        DstColor = ((int)0x0306),
        /// <summary>
        /// Original was GL_ONE_MINUS_DST_COLOR = 0x0307
        /// </summary>
        OneMinusDstColor = ((int)0x0307),
        /// <summary>
        /// Original was GL_SRC_ALPHA_SATURATE = 0x0308
        /// </summary>
        SrcAlphaSaturate = ((int)0x0308),
        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04
        /// </summary>
        GlyphHorizontalBearingXBitNv = ((int)0x04),
        /// <summary>
        /// Original was GL_FRONT_LEFT = 0x0400
        /// </summary>
        FrontLeft = ((int)0x0400),
        /// <summary>
        /// Original was GL_SPARSE_STORAGE_BIT_ARB = 0x0400
        /// </summary>
        SparseStorageBitArb = ((int)0x0400),
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
        FrontRight = ((int)0x0401),
        /// <summary>
        /// Original was GL_BACK_LEFT = 0x0402
        /// </summary>
        BackLeft = ((int)0x0402),
        /// <summary>
        /// Original was GL_BACK_RIGHT = 0x0403
        /// </summary>
        BackRight = ((int)0x0403),
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = ((int)0x0404),
        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = ((int)0x0405),
        /// <summary>
        /// Original was GL_LEFT = 0x0406
        /// </summary>
        Left = ((int)0x0406),
        /// <summary>
        /// Original was GL_RIGHT = 0x0407
        /// </summary>
        Right = ((int)0x0407),
        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = ((int)0x0408),
        /// <summary>
        /// Original was GL_AUX0 = 0x0409
        /// </summary>
        Aux0 = ((int)0x0409),
        /// <summary>
        /// Original was GL_AUX1 = 0x040A
        /// </summary>
        Aux1 = ((int)0x040A),
        /// <summary>
        /// Original was GL_AUX2 = 0x040B
        /// </summary>
        Aux2 = ((int)0x040B),
        /// <summary>
        /// Original was GL_AUX3 = 0x040C
        /// </summary>
        Aux3 = ((int)0x040C),
        /// <summary>
        /// Original was GL_INVALID_ENUM = 0x0500
        /// </summary>
        InvalidEnum = ((int)0x0500),
        /// <summary>
        /// Original was GL_INVALID_VALUE = 0x0501
        /// </summary>
        InvalidValue = ((int)0x0501),
        /// <summary>
        /// Original was GL_INVALID_OPERATION = 0x0502
        /// </summary>
        InvalidOperation = ((int)0x0502),
        /// <summary>
        /// Original was GL_STACK_OVERFLOW = 0x0503
        /// </summary>
        StackOverflow = ((int)0x0503),
        /// <summary>
        /// Original was GL_STACK_OVERFLOW_KHR = 0x0503
        /// </summary>
        StackOverflowKhr = ((int)0x0503),
        /// <summary>
        /// Original was GL_STACK_UNDERFLOW = 0x0504
        /// </summary>
        StackUnderflow = ((int)0x0504),
        /// <summary>
        /// Original was GL_STACK_UNDERFLOW_KHR = 0x0504
        /// </summary>
        StackUnderflowKhr = ((int)0x0504),
        /// <summary>
        /// Original was GL_OUT_OF_MEMORY = 0x0505
        /// </summary>
        OutOfMemory = ((int)0x0505),
        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506
        /// </summary>
        InvalidFramebufferOperation = ((int)0x0506),
        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506
        /// </summary>
        InvalidFramebufferOperationExt = ((int)0x0506),
        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506
        /// </summary>
        InvalidFramebufferOperationOes = ((int)0x0506),
        /// <summary>
        /// Original was GL_2D = 0x0600
        /// </summary>
        Gl2D = ((int)0x0600),
        /// <summary>
        /// Original was GL_3D = 0x0601
        /// </summary>
        Gl3D = ((int)0x0601),
        /// <summary>
        /// Original was GL_3D_COLOR = 0x0602
        /// </summary>
        Gl3DColor = ((int)0x0602),
        /// <summary>
        /// Original was GL_3D_COLOR_TEXTURE = 0x0603
        /// </summary>
        Gl3DColorTexture = ((int)0x0603),
        /// <summary>
        /// Original was GL_4D_COLOR_TEXTURE = 0x0604
        /// </summary>
        Gl4DColorTexture = ((int)0x0604),
        /// <summary>
        /// Original was GL_PASS_THROUGH_TOKEN = 0x0700
        /// </summary>
        PassThroughToken = ((int)0x0700),
        /// <summary>
        /// Original was GL_POINT_TOKEN = 0x0701
        /// </summary>
        PointToken = ((int)0x0701),
        /// <summary>
        /// Original was GL_LINE_TOKEN = 0x0702
        /// </summary>
        LineToken = ((int)0x0702),
        /// <summary>
        /// Original was GL_POLYGON_TOKEN = 0x0703
        /// </summary>
        PolygonToken = ((int)0x0703),
        /// <summary>
        /// Original was GL_BITMAP_TOKEN = 0x0704
        /// </summary>
        BitmapToken = ((int)0x0704),
        /// <summary>
        /// Original was GL_DRAW_PIXEL_TOKEN = 0x0705
        /// </summary>
        DrawPixelToken = ((int)0x0705),
        /// <summary>
        /// Original was GL_COPY_PIXEL_TOKEN = 0x0706
        /// </summary>
        CopyPixelToken = ((int)0x0706),
        /// <summary>
        /// Original was GL_LINE_RESET_TOKEN = 0x0707
        /// </summary>
        LineResetToken = ((int)0x0707),
        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08
        /// </summary>
        GlyphHorizontalBearingYBitNv = ((int)0x08),
        /// <summary>
        /// Original was GL_EXP = 0x0800
        /// </summary>
        Exp = ((int)0x0800),
        /// <summary>
        /// Original was GL_LGPU_SEPARATE_STORAGE_BIT_NVX = 0x0800
        /// </summary>
        LgpuSeparateStorageBitNvx = ((int)0x0800),
        /// <summary>
        /// Original was GL_PER_GPU_STORAGE_BIT_NV = 0x0800
        /// </summary>
        PerGpuStorageBitNv = ((int)0x0800),
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
        Exp2 = ((int)0x0801),
        /// <summary>
        /// Original was GL_CW = 0x0900
        /// </summary>
        Cw = ((int)0x0900),
        /// <summary>
        /// Original was GL_CCW = 0x0901
        /// </summary>
        Ccw = ((int)0x0901),
        /// <summary>
        /// Original was GL_COEFF = 0x0A00
        /// </summary>
        Coeff = ((int)0x0A00),
        /// <summary>
        /// Original was GL_ORDER = 0x0A01
        /// </summary>
        Order = ((int)0x0A01),
        /// <summary>
        /// Original was GL_DOMAIN = 0x0A02
        /// </summary>
        Domain = ((int)0x0A02),
        /// <summary>
        /// Original was GL_CURRENT_COLOR = 0x0B00
        /// </summary>
        CurrentColor = ((int)0x0B00),
        /// <summary>
        /// Original was GL_CURRENT_INDEX = 0x0B01
        /// </summary>
        CurrentIndex = ((int)0x0B01),
        /// <summary>
        /// Original was GL_CURRENT_NORMAL = 0x0B02
        /// </summary>
        CurrentNormal = ((int)0x0B02),
        /// <summary>
        /// Original was GL_CURRENT_TEXTURE_COORDS = 0x0B03
        /// </summary>
        CurrentTextureCoords = ((int)0x0B03),
        /// <summary>
        /// Original was GL_CURRENT_RASTER_COLOR = 0x0B04
        /// </summary>
        CurrentRasterColor = ((int)0x0B04),
        /// <summary>
        /// Original was GL_CURRENT_RASTER_INDEX = 0x0B05
        /// </summary>
        CurrentRasterIndex = ((int)0x0B05),
        /// <summary>
        /// Original was GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06
        /// </summary>
        CurrentRasterTextureCoords = ((int)0x0B06),
        /// <summary>
        /// Original was GL_CURRENT_RASTER_POSITION = 0x0B07
        /// </summary>
        CurrentRasterPosition = ((int)0x0B07),
        /// <summary>
        /// Original was GL_CURRENT_RASTER_POSITION_VALID = 0x0B08
        /// </summary>
        CurrentRasterPositionValid = ((int)0x0B08),
        /// <summary>
        /// Original was GL_CURRENT_RASTER_DISTANCE = 0x0B09
        /// </summary>
        CurrentRasterDistance = ((int)0x0B09),
        /// <summary>
        /// Original was GL_POINT_SMOOTH = 0x0B10
        /// </summary>
        PointSmooth = ((int)0x0B10),
        /// <summary>
        /// Original was GL_POINT_SIZE = 0x0B11
        /// </summary>
        PointSize = ((int)0x0B11),
        /// <summary>
        /// Original was GL_POINT_SIZE_RANGE = 0x0B12
        /// </summary>
        PointSizeRange = ((int)0x0B12),
        /// <summary>
        /// Original was GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12
        /// </summary>
        SmoothPointSizeRange = ((int)0x0B12),
        /// <summary>
        /// Original was GL_POINT_SIZE_GRANULARITY = 0x0B13
        /// </summary>
        PointSizeGranularity = ((int)0x0B13),
        /// <summary>
        /// Original was GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13
        /// </summary>
        SmoothPointSizeGranularity = ((int)0x0B13),
        /// <summary>
        /// Original was GL_LINE_SMOOTH = 0x0B20
        /// </summary>
        LineSmooth = ((int)0x0B20),
        /// <summary>
        /// Original was GL_LINE_WIDTH = 0x0B21
        /// </summary>
        LineWidth = ((int)0x0B21),
        /// <summary>
        /// Original was GL_LINE_WIDTH_RANGE = 0x0B22
        /// </summary>
        LineWidthRange = ((int)0x0B22),
        /// <summary>
        /// Original was GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22
        /// </summary>
        SmoothLineWidthRange = ((int)0x0B22),
        /// <summary>
        /// Original was GL_LINE_WIDTH_GRANULARITY = 0x0B23
        /// </summary>
        LineWidthGranularity = ((int)0x0B23),
        /// <summary>
        /// Original was GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23
        /// </summary>
        SmoothLineWidthGranularity = ((int)0x0B23),
        /// <summary>
        /// Original was GL_LINE_STIPPLE = 0x0B24
        /// </summary>
        LineStipple = ((int)0x0B24),
        /// <summary>
        /// Original was GL_LINE_STIPPLE_PATTERN = 0x0B25
        /// </summary>
        LineStipplePattern = ((int)0x0B25),
        /// <summary>
        /// Original was GL_LINE_STIPPLE_REPEAT = 0x0B26
        /// </summary>
        LineStippleRepeat = ((int)0x0B26),
        /// <summary>
        /// Original was GL_LIST_MODE = 0x0B30
        /// </summary>
        ListMode = ((int)0x0B30),
        /// <summary>
        /// Original was GL_MAX_LIST_NESTING = 0x0B31
        /// </summary>
        MaxListNesting = ((int)0x0B31),
        /// <summary>
        /// Original was GL_LIST_BASE = 0x0B32
        /// </summary>
        ListBase = ((int)0x0B32),
        /// <summary>
        /// Original was GL_LIST_INDEX = 0x0B33
        /// </summary>
        ListIndex = ((int)0x0B33),
        /// <summary>
        /// Original was GL_POLYGON_MODE = 0x0B40
        /// </summary>
        PolygonMode = ((int)0x0B40),
        /// <summary>
        /// Original was GL_POLYGON_SMOOTH = 0x0B41
        /// </summary>
        PolygonSmooth = ((int)0x0B41),
        /// <summary>
        /// Original was GL_POLYGON_STIPPLE = 0x0B42
        /// </summary>
        PolygonStipple = ((int)0x0B42),
        /// <summary>
        /// Original was GL_EDGE_FLAG = 0x0B43
        /// </summary>
        EdgeFlag = ((int)0x0B43),
        /// <summary>
        /// Original was GL_CULL_FACE = 0x0B44
        /// </summary>
        CullFace = ((int)0x0B44),
        /// <summary>
        /// Original was GL_CULL_FACE_MODE = 0x0B45
        /// </summary>
        CullFaceMode = ((int)0x0B45),
        /// <summary>
        /// Original was GL_FRONT_FACE = 0x0B46
        /// </summary>
        FrontFace = ((int)0x0B46),
        /// <summary>
        /// Original was GL_LIGHTING = 0x0B50
        /// </summary>
        Lighting = ((int)0x0B50),
        /// <summary>
        /// Original was GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51
        /// </summary>
        LightModelLocalViewer = ((int)0x0B51),
        /// <summary>
        /// Original was GL_LIGHT_MODEL_TWO_SIDE = 0x0B52
        /// </summary>
        LightModelTwoSide = ((int)0x0B52),
        /// <summary>
        /// Original was GL_LIGHT_MODEL_AMBIENT = 0x0B53
        /// </summary>
        LightModelAmbient = ((int)0x0B53),
        /// <summary>
        /// Original was GL_SHADE_MODEL = 0x0B54
        /// </summary>
        ShadeModel = ((int)0x0B54),
        /// <summary>
        /// Original was GL_COLOR_MATERIAL_FACE = 0x0B55
        /// </summary>
        ColorMaterialFace = ((int)0x0B55),
        /// <summary>
        /// Original was GL_COLOR_MATERIAL_PARAMETER = 0x0B56
        /// </summary>
        ColorMaterialParameter = ((int)0x0B56),
        /// <summary>
        /// Original was GL_COLOR_MATERIAL = 0x0B57
        /// </summary>
        ColorMaterial = ((int)0x0B57),
        /// <summary>
        /// Original was GL_FOG = 0x0B60
        /// </summary>
        Fog = ((int)0x0B60),
        /// <summary>
        /// Original was GL_FOG_INDEX = 0x0B61
        /// </summary>
        FogIndex = ((int)0x0B61),
        /// <summary>
        /// Original was GL_FOG_DENSITY = 0x0B62
        /// </summary>
        FogDensity = ((int)0x0B62),
        /// <summary>
        /// Original was GL_FOG_START = 0x0B63
        /// </summary>
        FogStart = ((int)0x0B63),
        /// <summary>
        /// Original was GL_FOG_END = 0x0B64
        /// </summary>
        FogEnd = ((int)0x0B64),
        /// <summary>
        /// Original was GL_FOG_MODE = 0x0B65
        /// </summary>
        FogMode = ((int)0x0B65),
        /// <summary>
        /// Original was GL_FOG_COLOR = 0x0B66
        /// </summary>
        FogColor = ((int)0x0B66),
        /// <summary>
        /// Original was GL_DEPTH_RANGE = 0x0B70
        /// </summary>
        DepthRange = ((int)0x0B70),
        /// <summary>
        /// Original was GL_DEPTH_TEST = 0x0B71
        /// </summary>
        DepthTest = ((int)0x0B71),
        /// <summary>
        /// Original was GL_DEPTH_WRITEMASK = 0x0B72
        /// </summary>
        DepthWritemask = ((int)0x0B72),
        /// <summary>
        /// Original was GL_DEPTH_CLEAR_VALUE = 0x0B73
        /// </summary>
        DepthClearValue = ((int)0x0B73),
        /// <summary>
        /// Original was GL_DEPTH_FUNC = 0x0B74
        /// </summary>
        DepthFunc = ((int)0x0B74),
        /// <summary>
        /// Original was GL_ACCUM_CLEAR_VALUE = 0x0B80
        /// </summary>
        AccumClearValue = ((int)0x0B80),
        /// <summary>
        /// Original was GL_STENCIL_TEST = 0x0B90
        /// </summary>
        StencilTest = ((int)0x0B90),
        /// <summary>
        /// Original was GL_STENCIL_CLEAR_VALUE = 0x0B91
        /// </summary>
        StencilClearValue = ((int)0x0B91),
        /// <summary>
        /// Original was GL_STENCIL_FUNC = 0x0B92
        /// </summary>
        StencilFunc = ((int)0x0B92),
        /// <summary>
        /// Original was GL_STENCIL_VALUE_MASK = 0x0B93
        /// </summary>
        StencilValueMask = ((int)0x0B93),
        /// <summary>
        /// Original was GL_STENCIL_FAIL = 0x0B94
        /// </summary>
        StencilFail = ((int)0x0B94),
        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95
        /// </summary>
        StencilPassDepthFail = ((int)0x0B95),
        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_PASS = 0x0B96
        /// </summary>
        StencilPassDepthPass = ((int)0x0B96),
        /// <summary>
        /// Original was GL_STENCIL_REF = 0x0B97
        /// </summary>
        StencilRef = ((int)0x0B97),
        /// <summary>
        /// Original was GL_STENCIL_WRITEMASK = 0x0B98
        /// </summary>
        StencilWritemask = ((int)0x0B98),
        /// <summary>
        /// Original was GL_MATRIX_MODE = 0x0BA0
        /// </summary>
        MatrixMode = ((int)0x0BA0),
        /// <summary>
        /// Original was GL_NORMALIZE = 0x0BA1
        /// </summary>
        Normalize = ((int)0x0BA1),
        /// <summary>
        /// Original was GL_VIEWPORT = 0x0BA2
        /// </summary>
        Viewport = ((int)0x0BA2),
        /// <summary>
        /// Original was GL_MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3
        /// </summary>
        Modelview0StackDepthExt = ((int)0x0BA3),
        /// <summary>
        /// Original was GL_MODELVIEW_STACK_DEPTH = 0x0BA3
        /// </summary>
        ModelviewStackDepth = ((int)0x0BA3),
        /// <summary>
        /// Original was GL_PROJECTION_STACK_DEPTH = 0x0BA4
        /// </summary>
        ProjectionStackDepth = ((int)0x0BA4),
        /// <summary>
        /// Original was GL_TEXTURE_STACK_DEPTH = 0x0BA5
        /// </summary>
        TextureStackDepth = ((int)0x0BA5),
        /// <summary>
        /// Original was GL_MODELVIEW0_MATRIX_EXT = 0x0BA6
        /// </summary>
        Modelview0MatrixExt = ((int)0x0BA6),
        /// <summary>
        /// Original was GL_MODELVIEW_MATRIX = 0x0BA6
        /// </summary>
        ModelviewMatrix = ((int)0x0BA6),
        /// <summary>
        /// Original was GL_PROJECTION_MATRIX = 0x0BA7
        /// </summary>
        ProjectionMatrix = ((int)0x0BA7),
        /// <summary>
        /// Original was GL_TEXTURE_MATRIX = 0x0BA8
        /// </summary>
        TextureMatrix = ((int)0x0BA8),
        /// <summary>
        /// Original was GL_ATTRIB_STACK_DEPTH = 0x0BB0
        /// </summary>
        AttribStackDepth = ((int)0x0BB0),
        /// <summary>
        /// Original was GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1
        /// </summary>
        ClientAttribStackDepth = ((int)0x0BB1),
        /// <summary>
        /// Original was GL_ALPHA_TEST = 0x0BC0
        /// </summary>
        AlphaTest = ((int)0x0BC0),
        /// <summary>
        /// Original was GL_ALPHA_TEST_QCOM = 0x0BC0
        /// </summary>
        AlphaTestQcom = ((int)0x0BC0),
        /// <summary>
        /// Original was GL_ALPHA_TEST_FUNC = 0x0BC1
        /// </summary>
        AlphaTestFunc = ((int)0x0BC1),
        /// <summary>
        /// Original was GL_ALPHA_TEST_FUNC_QCOM = 0x0BC1
        /// </summary>
        AlphaTestFuncQcom = ((int)0x0BC1),
        /// <summary>
        /// Original was GL_ALPHA_TEST_REF = 0x0BC2
        /// </summary>
        AlphaTestRef = ((int)0x0BC2),
        /// <summary>
        /// Original was GL_ALPHA_TEST_REF_QCOM = 0x0BC2
        /// </summary>
        AlphaTestRefQcom = ((int)0x0BC2),
        /// <summary>
        /// Original was GL_DITHER = 0x0BD0
        /// </summary>
        Dither = ((int)0x0BD0),
        /// <summary>
        /// Original was GL_BLEND_DST = 0x0BE0
        /// </summary>
        BlendDst = ((int)0x0BE0),
        /// <summary>
        /// Original was GL_BLEND_SRC = 0x0BE1
        /// </summary>
        BlendSrc = ((int)0x0BE1),
        /// <summary>
        /// Original was GL_BLEND = 0x0BE2
        /// </summary>
        Blend = ((int)0x0BE2),
        /// <summary>
        /// Original was GL_LOGIC_OP_MODE = 0x0BF0
        /// </summary>
        LogicOpMode = ((int)0x0BF0),
        /// <summary>
        /// Original was GL_INDEX_LOGIC_OP = 0x0BF1
        /// </summary>
        IndexLogicOp = ((int)0x0BF1),
        /// <summary>
        /// Original was GL_LOGIC_OP = 0x0BF1
        /// </summary>
        LogicOp = ((int)0x0BF1),
        /// <summary>
        /// Original was GL_COLOR_LOGIC_OP = 0x0BF2
        /// </summary>
        ColorLogicOp = ((int)0x0BF2),
        /// <summary>
        /// Original was GL_AUX_BUFFERS = 0x0C00
        /// </summary>
        AuxBuffers = ((int)0x0C00),
        /// <summary>
        /// Original was GL_DRAW_BUFFER = 0x0C01
        /// </summary>
        DrawBuffer = ((int)0x0C01),
        /// <summary>
        /// Original was GL_DRAW_BUFFER_EXT = 0x0C01
        /// </summary>
        DrawBufferExt = ((int)0x0C01),
        /// <summary>
        /// Original was GL_READ_BUFFER = 0x0C02
        /// </summary>
        ReadBuffer = ((int)0x0C02),
        /// <summary>
        /// Original was GL_READ_BUFFER_EXT = 0x0C02
        /// </summary>
        ReadBufferExt = ((int)0x0C02),
        /// <summary>
        /// Original was GL_READ_BUFFER_NV = 0x0C02
        /// </summary>
        ReadBufferNv = ((int)0x0C02),
        /// <summary>
        /// Original was GL_SCISSOR_BOX = 0x0C10
        /// </summary>
        ScissorBox = ((int)0x0C10),
        /// <summary>
        /// Original was GL_SCISSOR_TEST = 0x0C11
        /// </summary>
        ScissorTest = ((int)0x0C11),
        /// <summary>
        /// Original was GL_INDEX_CLEAR_VALUE = 0x0C20
        /// </summary>
        IndexClearValue = ((int)0x0C20),
        /// <summary>
        /// Original was GL_INDEX_WRITEMASK = 0x0C21
        /// </summary>
        IndexWritemask = ((int)0x0C21),
        /// <summary>
        /// Original was GL_COLOR_CLEAR_VALUE = 0x0C22
        /// </summary>
        ColorClearValue = ((int)0x0C22),
        /// <summary>
        /// Original was GL_COLOR_WRITEMASK = 0x0C23
        /// </summary>
        ColorWritemask = ((int)0x0C23),
        /// <summary>
        /// Original was GL_INDEX_MODE = 0x0C30
        /// </summary>
        IndexMode = ((int)0x0C30),
        /// <summary>
        /// Original was GL_RGBA_MODE = 0x0C31
        /// </summary>
        RgbaMode = ((int)0x0C31),
        /// <summary>
        /// Original was GL_DOUBLEBUFFER = 0x0C32
        /// </summary>
        Doublebuffer = ((int)0x0C32),
        /// <summary>
        /// Original was GL_STEREO = 0x0C33
        /// </summary>
        Stereo = ((int)0x0C33),
        /// <summary>
        /// Original was GL_RENDER_MODE = 0x0C40
        /// </summary>
        RenderMode = ((int)0x0C40),
        /// <summary>
        /// Original was GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50
        /// </summary>
        PerspectiveCorrectionHint = ((int)0x0C50),
        /// <summary>
        /// Original was GL_POINT_SMOOTH_HINT = 0x0C51
        /// </summary>
        PointSmoothHint = ((int)0x0C51),
        /// <summary>
        /// Original was GL_LINE_SMOOTH_HINT = 0x0C52
        /// </summary>
        LineSmoothHint = ((int)0x0C52),
        /// <summary>
        /// Original was GL_POLYGON_SMOOTH_HINT = 0x0C53
        /// </summary>
        PolygonSmoothHint = ((int)0x0C53),
        /// <summary>
        /// Original was GL_FOG_HINT = 0x0C54
        /// </summary>
        FogHint = ((int)0x0C54),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_S = 0x0C60
        /// </summary>
        TextureGenS = ((int)0x0C60),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_T = 0x0C61
        /// </summary>
        TextureGenT = ((int)0x0C61),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_R = 0x0C62
        /// </summary>
        TextureGenR = ((int)0x0C62),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_Q = 0x0C63
        /// </summary>
        TextureGenQ = ((int)0x0C63),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_I = 0x0C70
        /// </summary>
        PixelMapIToI = ((int)0x0C70),
        /// <summary>
        /// Original was GL_PIXEL_MAP_S_TO_S = 0x0C71
        /// </summary>
        PixelMapSToS = ((int)0x0C71),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_R = 0x0C72
        /// </summary>
        PixelMapIToR = ((int)0x0C72),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_G = 0x0C73
        /// </summary>
        PixelMapIToG = ((int)0x0C73),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_B = 0x0C74
        /// </summary>
        PixelMapIToB = ((int)0x0C74),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_A = 0x0C75
        /// </summary>
        PixelMapIToA = ((int)0x0C75),
        /// <summary>
        /// Original was GL_PIXEL_MAP_R_TO_R = 0x0C76
        /// </summary>
        PixelMapRToR = ((int)0x0C76),
        /// <summary>
        /// Original was GL_PIXEL_MAP_G_TO_G = 0x0C77
        /// </summary>
        PixelMapGToG = ((int)0x0C77),
        /// <summary>
        /// Original was GL_PIXEL_MAP_B_TO_B = 0x0C78
        /// </summary>
        PixelMapBToB = ((int)0x0C78),
        /// <summary>
        /// Original was GL_PIXEL_MAP_A_TO_A = 0x0C79
        /// </summary>
        PixelMapAToA = ((int)0x0C79),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0
        /// </summary>
        PixelMapIToISize = ((int)0x0CB0),
        /// <summary>
        /// Original was GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1
        /// </summary>
        PixelMapSToSSize = ((int)0x0CB1),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2
        /// </summary>
        PixelMapIToRSize = ((int)0x0CB2),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3
        /// </summary>
        PixelMapIToGSize = ((int)0x0CB3),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4
        /// </summary>
        PixelMapIToBSize = ((int)0x0CB4),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5
        /// </summary>
        PixelMapIToASize = ((int)0x0CB5),
        /// <summary>
        /// Original was GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6
        /// </summary>
        PixelMapRToRSize = ((int)0x0CB6),
        /// <summary>
        /// Original was GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7
        /// </summary>
        PixelMapGToGSize = ((int)0x0CB7),
        /// <summary>
        /// Original was GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8
        /// </summary>
        PixelMapBToBSize = ((int)0x0CB8),
        /// <summary>
        /// Original was GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9
        /// </summary>
        PixelMapAToASize = ((int)0x0CB9),
        /// <summary>
        /// Original was GL_UNPACK_SWAP_BYTES = 0x0CF0
        /// </summary>
        UnpackSwapBytes = ((int)0x0CF0),
        /// <summary>
        /// Original was GL_UNPACK_LSB_FIRST = 0x0CF1
        /// </summary>
        UnpackLsbFirst = ((int)0x0CF1),
        /// <summary>
        /// Original was GL_UNPACK_ROW_LENGTH = 0x0CF2
        /// </summary>
        UnpackRowLength = ((int)0x0CF2),
        /// <summary>
        /// Original was GL_UNPACK_ROW_LENGTH_EXT = 0x0CF2
        /// </summary>
        UnpackRowLengthExt = ((int)0x0CF2),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_ROWS = 0x0CF3
        /// </summary>
        UnpackSkipRows = ((int)0x0CF3),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_ROWS_EXT = 0x0CF3
        /// </summary>
        UnpackSkipRowsExt = ((int)0x0CF3),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_PIXELS = 0x0CF4
        /// </summary>
        UnpackSkipPixels = ((int)0x0CF4),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_PIXELS_EXT = 0x0CF4
        /// </summary>
        UnpackSkipPixelsExt = ((int)0x0CF4),
        /// <summary>
        /// Original was GL_UNPACK_ALIGNMENT = 0x0CF5
        /// </summary>
        UnpackAlignment = ((int)0x0CF5),
        /// <summary>
        /// Original was GL_PACK_SWAP_BYTES = 0x0D00
        /// </summary>
        PackSwapBytes = ((int)0x0D00),
        /// <summary>
        /// Original was GL_PACK_LSB_FIRST = 0x0D01
        /// </summary>
        PackLsbFirst = ((int)0x0D01),
        /// <summary>
        /// Original was GL_PACK_ROW_LENGTH = 0x0D02
        /// </summary>
        PackRowLength = ((int)0x0D02),
        /// <summary>
        /// Original was GL_PACK_SKIP_ROWS = 0x0D03
        /// </summary>
        PackSkipRows = ((int)0x0D03),
        /// <summary>
        /// Original was GL_PACK_SKIP_PIXELS = 0x0D04
        /// </summary>
        PackSkipPixels = ((int)0x0D04),
        /// <summary>
        /// Original was GL_PACK_ALIGNMENT = 0x0D05
        /// </summary>
        PackAlignment = ((int)0x0D05),
        /// <summary>
        /// Original was GL_MAP_COLOR = 0x0D10
        /// </summary>
        MapColor = ((int)0x0D10),
        /// <summary>
        /// Original was GL_MAP_STENCIL = 0x0D11
        /// </summary>
        MapStencil = ((int)0x0D11),
        /// <summary>
        /// Original was GL_INDEX_SHIFT = 0x0D12
        /// </summary>
        IndexShift = ((int)0x0D12),
        /// <summary>
        /// Original was GL_INDEX_OFFSET = 0x0D13
        /// </summary>
        IndexOffset = ((int)0x0D13),
        /// <summary>
        /// Original was GL_RED_SCALE = 0x0D14
        /// </summary>
        RedScale = ((int)0x0D14),
        /// <summary>
        /// Original was GL_RED_BIAS = 0x0D15
        /// </summary>
        RedBias = ((int)0x0D15),
        /// <summary>
        /// Original was GL_ZOOM_X = 0x0D16
        /// </summary>
        ZoomX = ((int)0x0D16),
        /// <summary>
        /// Original was GL_ZOOM_Y = 0x0D17
        /// </summary>
        ZoomY = ((int)0x0D17),
        /// <summary>
        /// Original was GL_GREEN_SCALE = 0x0D18
        /// </summary>
        GreenScale = ((int)0x0D18),
        /// <summary>
        /// Original was GL_GREEN_BIAS = 0x0D19
        /// </summary>
        GreenBias = ((int)0x0D19),
        /// <summary>
        /// Original was GL_BLUE_SCALE = 0x0D1A
        /// </summary>
        BlueScale = ((int)0x0D1A),
        /// <summary>
        /// Original was GL_BLUE_BIAS = 0x0D1B
        /// </summary>
        BlueBias = ((int)0x0D1B),
        /// <summary>
        /// Original was GL_ALPHA_SCALE = 0x0D1C
        /// </summary>
        AlphaScale = ((int)0x0D1C),
        /// <summary>
        /// Original was GL_ALPHA_BIAS = 0x0D1D
        /// </summary>
        AlphaBias = ((int)0x0D1D),
        /// <summary>
        /// Original was GL_DEPTH_SCALE = 0x0D1E
        /// </summary>
        DepthScale = ((int)0x0D1E),
        /// <summary>
        /// Original was GL_DEPTH_BIAS = 0x0D1F
        /// </summary>
        DepthBias = ((int)0x0D1F),
        /// <summary>
        /// Original was GL_MAX_EVAL_ORDER = 0x0D30
        /// </summary>
        MaxEvalOrder = ((int)0x0D30),
        /// <summary>
        /// Original was GL_MAX_LIGHTS = 0x0D31
        /// </summary>
        MaxLights = ((int)0x0D31),
        /// <summary>
        /// Original was GL_MAX_CLIP_DISTANCES = 0x0D32
        /// </summary>
        MaxClipDistances = ((int)0x0D32),
        /// <summary>
        /// Original was GL_MAX_CLIP_PLANES = 0x0D32
        /// </summary>
        MaxClipPlanes = ((int)0x0D32),
        /// <summary>
        /// Original was GL_MAX_CLIP_PLANES_IMG = 0x0D32
        /// </summary>
        MaxClipPlanesImg = ((int)0x0D32),
        /// <summary>
        /// Original was GL_MAX_TEXTURE_SIZE = 0x0D33
        /// </summary>
        MaxTextureSize = ((int)0x0D33),
        /// <summary>
        /// Original was GL_MAX_PIXEL_MAP_TABLE = 0x0D34
        /// </summary>
        MaxPixelMapTable = ((int)0x0D34),
        /// <summary>
        /// Original was GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35
        /// </summary>
        MaxAttribStackDepth = ((int)0x0D35),
        /// <summary>
        /// Original was GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36
        /// </summary>
        MaxModelviewStackDepth = ((int)0x0D36),
        /// <summary>
        /// Original was GL_MAX_NAME_STACK_DEPTH = 0x0D37
        /// </summary>
        MaxNameStackDepth = ((int)0x0D37),
        /// <summary>
        /// Original was GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38
        /// </summary>
        MaxProjectionStackDepth = ((int)0x0D38),
        /// <summary>
        /// Original was GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39
        /// </summary>
        MaxTextureStackDepth = ((int)0x0D39),
        /// <summary>
        /// Original was GL_MAX_VIEWPORT_DIMS = 0x0D3A
        /// </summary>
        MaxViewportDims = ((int)0x0D3A),
        /// <summary>
        /// Original was GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B
        /// </summary>
        MaxClientAttribStackDepth = ((int)0x0D3B),
        /// <summary>
        /// Original was GL_SUBPIXEL_BITS = 0x0D50
        /// </summary>
        SubpixelBits = ((int)0x0D50),
        /// <summary>
        /// Original was GL_INDEX_BITS = 0x0D51
        /// </summary>
        IndexBits = ((int)0x0D51),
        /// <summary>
        /// Original was GL_RED_BITS = 0x0D52
        /// </summary>
        RedBits = ((int)0x0D52),
        /// <summary>
        /// Original was GL_GREEN_BITS = 0x0D53
        /// </summary>
        GreenBits = ((int)0x0D53),
        /// <summary>
        /// Original was GL_BLUE_BITS = 0x0D54
        /// </summary>
        BlueBits = ((int)0x0D54),
        /// <summary>
        /// Original was GL_ALPHA_BITS = 0x0D55
        /// </summary>
        AlphaBits = ((int)0x0D55),
        /// <summary>
        /// Original was GL_DEPTH_BITS = 0x0D56
        /// </summary>
        DepthBits = ((int)0x0D56),
        /// <summary>
        /// Original was GL_STENCIL_BITS = 0x0D57
        /// </summary>
        StencilBits = ((int)0x0D57),
        /// <summary>
        /// Original was GL_ACCUM_RED_BITS = 0x0D58
        /// </summary>
        AccumRedBits = ((int)0x0D58),
        /// <summary>
        /// Original was GL_ACCUM_GREEN_BITS = 0x0D59
        /// </summary>
        AccumGreenBits = ((int)0x0D59),
        /// <summary>
        /// Original was GL_ACCUM_BLUE_BITS = 0x0D5A
        /// </summary>
        AccumBlueBits = ((int)0x0D5A),
        /// <summary>
        /// Original was GL_ACCUM_ALPHA_BITS = 0x0D5B
        /// </summary>
        AccumAlphaBits = ((int)0x0D5B),
        /// <summary>
        /// Original was GL_NAME_STACK_DEPTH = 0x0D70
        /// </summary>
        NameStackDepth = ((int)0x0D70),
        /// <summary>
        /// Original was GL_AUTO_NORMAL = 0x0D80
        /// </summary>
        AutoNormal = ((int)0x0D80),
        /// <summary>
        /// Original was GL_MAP1_COLOR_4 = 0x0D90
        /// </summary>
        Map1Color4 = ((int)0x0D90),
        /// <summary>
        /// Original was GL_MAP1_INDEX = 0x0D91
        /// </summary>
        Map1Index = ((int)0x0D91),
        /// <summary>
        /// Original was GL_MAP1_NORMAL = 0x0D92
        /// </summary>
        Map1Normal = ((int)0x0D92),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_1 = 0x0D93
        /// </summary>
        Map1TextureCoord1 = ((int)0x0D93),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_2 = 0x0D94
        /// </summary>
        Map1TextureCoord2 = ((int)0x0D94),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_3 = 0x0D95
        /// </summary>
        Map1TextureCoord3 = ((int)0x0D95),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_4 = 0x0D96
        /// </summary>
        Map1TextureCoord4 = ((int)0x0D96),
        /// <summary>
        /// Original was GL_MAP1_VERTEX_3 = 0x0D97
        /// </summary>
        Map1Vertex3 = ((int)0x0D97),
        /// <summary>
        /// Original was GL_MAP1_VERTEX_4 = 0x0D98
        /// </summary>
        Map1Vertex4 = ((int)0x0D98),
        /// <summary>
        /// Original was GL_MAP2_COLOR_4 = 0x0DB0
        /// </summary>
        Map2Color4 = ((int)0x0DB0),
        /// <summary>
        /// Original was GL_MAP2_INDEX = 0x0DB1
        /// </summary>
        Map2Index = ((int)0x0DB1),
        /// <summary>
        /// Original was GL_MAP2_NORMAL = 0x0DB2
        /// </summary>
        Map2Normal = ((int)0x0DB2),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_1 = 0x0DB3
        /// </summary>
        Map2TextureCoord1 = ((int)0x0DB3),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_2 = 0x0DB4
        /// </summary>
        Map2TextureCoord2 = ((int)0x0DB4),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_3 = 0x0DB5
        /// </summary>
        Map2TextureCoord3 = ((int)0x0DB5),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_4 = 0x0DB6
        /// </summary>
        Map2TextureCoord4 = ((int)0x0DB6),
        /// <summary>
        /// Original was GL_MAP2_VERTEX_3 = 0x0DB7
        /// </summary>
        Map2Vertex3 = ((int)0x0DB7),
        /// <summary>
        /// Original was GL_MAP2_VERTEX_4 = 0x0DB8
        /// </summary>
        Map2Vertex4 = ((int)0x0DB8),
        /// <summary>
        /// Original was GL_MAP1_GRID_DOMAIN = 0x0DD0
        /// </summary>
        Map1GridDomain = ((int)0x0DD0),
        /// <summary>
        /// Original was GL_MAP1_GRID_SEGMENTS = 0x0DD1
        /// </summary>
        Map1GridSegments = ((int)0x0DD1),
        /// <summary>
        /// Original was GL_MAP2_GRID_DOMAIN = 0x0DD2
        /// </summary>
        Map2GridDomain = ((int)0x0DD2),
        /// <summary>
        /// Original was GL_MAP2_GRID_SEGMENTS = 0x0DD3
        /// </summary>
        Map2GridSegments = ((int)0x0DD3),
        /// <summary>
        /// Original was GL_TEXTURE_1D = 0x0DE0
        /// </summary>
        Texture1D = ((int)0x0DE0),
        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = ((int)0x0DE1),
        /// <summary>
        /// Original was GL_FEEDBACK_BUFFER_POINTER = 0x0DF0
        /// </summary>
        FeedbackBufferPointer = ((int)0x0DF0),
        /// <summary>
        /// Original was GL_FEEDBACK_BUFFER_SIZE = 0x0DF1
        /// </summary>
        FeedbackBufferSize = ((int)0x0DF1),
        /// <summary>
        /// Original was GL_FEEDBACK_BUFFER_TYPE = 0x0DF2
        /// </summary>
        FeedbackBufferType = ((int)0x0DF2),
        /// <summary>
        /// Original was GL_SELECTION_BUFFER_POINTER = 0x0DF3
        /// </summary>
        SelectionBufferPointer = ((int)0x0DF3),
        /// <summary>
        /// Original was GL_SELECTION_BUFFER_SIZE = 0x0DF4
        /// </summary>
        SelectionBufferSize = ((int)0x0DF4),
        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10
        /// </summary>
        GlyphHorizontalBearingAdvanceBitNv = ((int)0x10),
        /// <summary>
        /// Original was GL_GLYPH_HAS_KERNING_BIT_NV = 0x100
        /// </summary>
        GlyphHasKerningBitNv = ((int)0x100),
        /// <summary>
        /// Original was GL_TEXTURE_WIDTH = 0x1000
        /// </summary>
        TextureWidth = ((int)0x1000),
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
        TextureHeight = ((int)0x1001),
        /// <summary>
        /// Original was GL_TEXTURE_COMPONENTS = 0x1003
        /// </summary>
        TextureComponents = ((int)0x1003),
        /// <summary>
        /// Original was GL_TEXTURE_INTERNAL_FORMAT = 0x1003
        /// </summary>
        TextureInternalFormat = ((int)0x1003),
        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR = 0x1004
        /// </summary>
        TextureBorderColor = ((int)0x1004),
        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR_NV = 0x1004
        /// </summary>
        TextureBorderColorNv = ((int)0x1004),
        /// <summary>
        /// Original was GL_TEXTURE_BORDER = 0x1005
        /// </summary>
        TextureBorder = ((int)0x1005),
        /// <summary>
        /// Original was GL_DONT_CARE = 0x1100
        /// </summary>
        DontCare = ((int)0x1100),
        /// <summary>
        /// Original was GL_FASTEST = 0x1101
        /// </summary>
        Fastest = ((int)0x1101),
        /// <summary>
        /// Original was GL_NICEST = 0x1102
        /// </summary>
        Nicest = ((int)0x1102),
        /// <summary>
        /// Original was GL_AMBIENT = 0x1200
        /// </summary>
        Ambient = ((int)0x1200),
        /// <summary>
        /// Original was GL_DIFFUSE = 0x1201
        /// </summary>
        Diffuse = ((int)0x1201),
        /// <summary>
        /// Original was GL_SPECULAR = 0x1202
        /// </summary>
        Specular = ((int)0x1202),
        /// <summary>
        /// Original was GL_POSITION = 0x1203
        /// </summary>
        Position = ((int)0x1203),
        /// <summary>
        /// Original was GL_SPOT_DIRECTION = 0x1204
        /// </summary>
        SpotDirection = ((int)0x1204),
        /// <summary>
        /// Original was GL_SPOT_EXPONENT = 0x1205
        /// </summary>
        SpotExponent = ((int)0x1205),
        /// <summary>
        /// Original was GL_SPOT_CUTOFF = 0x1206
        /// </summary>
        SpotCutoff = ((int)0x1206),
        /// <summary>
        /// Original was GL_CONSTANT_ATTENUATION = 0x1207
        /// </summary>
        ConstantAttenuation = ((int)0x1207),
        /// <summary>
        /// Original was GL_LINEAR_ATTENUATION = 0x1208
        /// </summary>
        LinearAttenuation = ((int)0x1208),
        /// <summary>
        /// Original was GL_QUADRATIC_ATTENUATION = 0x1209
        /// </summary>
        QuadraticAttenuation = ((int)0x1209),
        /// <summary>
        /// Original was GL_COMPILE = 0x1300
        /// </summary>
        Compile = ((int)0x1300),
        /// <summary>
        /// Original was GL_COMPILE_AND_EXECUTE = 0x1301
        /// </summary>
        CompileAndExecute = ((int)0x1301),
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = ((int)0x1400),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = ((int)0x1401),
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = ((int)0x1402),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = ((int)0x1403),
        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = ((int)0x1404),
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405),
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406),
        /// <summary>
        /// Original was GL_2_BYTES = 0x1407
        /// </summary>
        Gl2Bytes = ((int)0x1407),
        /// <summary>
        /// Original was GL_3_BYTES = 0x1408
        /// </summary>
        Gl3Bytes = ((int)0x1408),
        /// <summary>
        /// Original was GL_4_BYTES = 0x1409
        /// </summary>
        Gl4Bytes = ((int)0x1409),
        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = ((int)0x140A),
        /// <summary>
        /// Original was GL_HALF_FLOAT = 0x140B
        /// </summary>
        HalfFloat = ((int)0x140B),
        /// <summary>
        /// Original was GL_FIXED = 0x140C
        /// </summary>
        Fixed = ((int)0x140C),
        /// <summary>
        /// Original was GL_FIXED_OES = 0x140C
        /// </summary>
        FixedOes = ((int)0x140C),
        /// <summary>
        /// Original was GL_CLEAR = 0x1500
        /// </summary>
        Clear = ((int)0x1500),
        /// <summary>
        /// Original was GL_AND = 0x1501
        /// </summary>
        And = ((int)0x1501),
        /// <summary>
        /// Original was GL_AND_REVERSE = 0x1502
        /// </summary>
        AndReverse = ((int)0x1502),
        /// <summary>
        /// Original was GL_COPY = 0x1503
        /// </summary>
        Copy = ((int)0x1503),
        /// <summary>
        /// Original was GL_AND_INVERTED = 0x1504
        /// </summary>
        AndInverted = ((int)0x1504),
        /// <summary>
        /// Original was GL_NOOP = 0x1505
        /// </summary>
        Noop = ((int)0x1505),
        /// <summary>
        /// Original was GL_XOR = 0x1506
        /// </summary>
        Xor = ((int)0x1506),
        /// <summary>
        /// Original was GL_OR = 0x1507
        /// </summary>
        Or = ((int)0x1507),
        /// <summary>
        /// Original was GL_NOR = 0x1508
        /// </summary>
        Nor = ((int)0x1508),
        /// <summary>
        /// Original was GL_EQUIV = 0x1509
        /// </summary>
        Equiv = ((int)0x1509),
        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = ((int)0x150A),
        /// <summary>
        /// Original was GL_OR_REVERSE = 0x150B
        /// </summary>
        OrReverse = ((int)0x150B),
        /// <summary>
        /// Original was GL_COPY_INVERTED = 0x150C
        /// </summary>
        CopyInverted = ((int)0x150C),
        /// <summary>
        /// Original was GL_OR_INVERTED = 0x150D
        /// </summary>
        OrInverted = ((int)0x150D),
        /// <summary>
        /// Original was GL_NAND = 0x150E
        /// </summary>
        Nand = ((int)0x150E),
        /// <summary>
        /// Original was GL_SET = 0x150F
        /// </summary>
        Set = ((int)0x150F),
        /// <summary>
        /// Original was GL_EMISSION = 0x1600
        /// </summary>
        Emission = ((int)0x1600),
        /// <summary>
        /// Original was GL_SHININESS = 0x1601
        /// </summary>
        Shininess = ((int)0x1601),
        /// <summary>
        /// Original was GL_AMBIENT_AND_DIFFUSE = 0x1602
        /// </summary>
        AmbientAndDiffuse = ((int)0x1602),
        /// <summary>
        /// Original was GL_COLOR_INDEXES = 0x1603
        /// </summary>
        ColorIndexes = ((int)0x1603),
        /// <summary>
        /// Original was GL_MODELVIEW = 0x1700
        /// </summary>
        Modelview = ((int)0x1700),
        /// <summary>
        /// Original was GL_MODELVIEW0_EXT = 0x1700
        /// </summary>
        Modelview0Ext = ((int)0x1700),
        /// <summary>
        /// Original was GL_PROJECTION = 0x1701
        /// </summary>
        Projection = ((int)0x1701),
        /// <summary>
        /// Original was GL_TEXTURE = 0x1702
        /// </summary>
        Texture = ((int)0x1702),
        /// <summary>
        /// Original was GL_COLOR = 0x1800
        /// </summary>
        Color = ((int)0x1800),
        /// <summary>
        /// Original was GL_COLOR_EXT = 0x1800
        /// </summary>
        ColorExt = ((int)0x1800),
        /// <summary>
        /// Original was GL_DEPTH = 0x1801
        /// </summary>
        Depth = ((int)0x1801),
        /// <summary>
        /// Original was GL_DEPTH_EXT = 0x1801
        /// </summary>
        DepthExt = ((int)0x1801),
        /// <summary>
        /// Original was GL_STENCIL = 0x1802
        /// </summary>
        Stencil = ((int)0x1802),
        /// <summary>
        /// Original was GL_STENCIL_EXT = 0x1802
        /// </summary>
        StencilExt = ((int)0x1802),
        /// <summary>
        /// Original was GL_COLOR_INDEX = 0x1900
        /// </summary>
        ColorIndex = ((int)0x1900),
        /// <summary>
        /// Original was GL_STENCIL_INDEX = 0x1901
        /// </summary>
        StencilIndex = ((int)0x1901),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT = 0x1902
        /// </summary>
        DepthComponent = ((int)0x1902),
        /// <summary>
        /// Original was GL_RED = 0x1903
        /// </summary>
        Red = ((int)0x1903),
        /// <summary>
        /// Original was GL_RED_EXT = 0x1903
        /// </summary>
        RedExt = ((int)0x1903),
        /// <summary>
        /// Original was GL_GREEN = 0x1904
        /// </summary>
        Green = ((int)0x1904),
        /// <summary>
        /// Original was GL_BLUE = 0x1905
        /// </summary>
        Blue = ((int)0x1905),
        /// <summary>
        /// Original was GL_ALPHA = 0x1906
        /// </summary>
        Alpha = ((int)0x1906),
        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = ((int)0x1907),
        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = ((int)0x1908),
        /// <summary>
        /// Original was GL_LUMINANCE = 0x1909
        /// </summary>
        Luminance = ((int)0x1909),
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = ((int)0x190A),
        /// <summary>
        /// Original was GL_BITMAP = 0x1A00
        /// </summary>
        Bitmap = ((int)0x1A00),
        /// <summary>
        /// Original was GL_PREFER_DOUBLEBUFFER_HINT_PGI = 0x1A1F8
        /// </summary>
        PreferDoublebufferHintPgi = ((int)0x1A1F8),
        /// <summary>
        /// Original was GL_CONSERVE_MEMORY_HINT_PGI = 0x1A1FD
        /// </summary>
        ConserveMemoryHintPgi = ((int)0x1A1FD),
        /// <summary>
        /// Original was GL_RECLAIM_MEMORY_HINT_PGI = 0x1A1FE
        /// </summary>
        ReclaimMemoryHintPgi = ((int)0x1A1FE),
        /// <summary>
        /// Original was GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203
        /// </summary>
        NativeGraphicsBeginHintPgi = ((int)0x1A203),
        /// <summary>
        /// Original was GL_NATIVE_GRAPHICS_END_HINT_PGI = 0x1A204
        /// </summary>
        NativeGraphicsEndHintPgi = ((int)0x1A204),
        /// <summary>
        /// Original was GL_ALWAYS_FAST_HINT_PGI = 0x1A20C
        /// </summary>
        AlwaysFastHintPgi = ((int)0x1A20C),
        /// <summary>
        /// Original was GL_ALWAYS_SOFT_HINT_PGI = 0x1A20D
        /// </summary>
        AlwaysSoftHintPgi = ((int)0x1A20D),
        /// <summary>
        /// Original was GL_ALLOW_DRAW_OBJ_HINT_PGI = 0x1A20E
        /// </summary>
        AllowDrawObjHintPgi = ((int)0x1A20E),
        /// <summary>
        /// Original was GL_ALLOW_DRAW_WIN_HINT_PGI = 0x1A20F
        /// </summary>
        AllowDrawWinHintPgi = ((int)0x1A20F),
        /// <summary>
        /// Original was GL_ALLOW_DRAW_FRG_HINT_PGI = 0x1A210
        /// </summary>
        AllowDrawFrgHintPgi = ((int)0x1A210),
        /// <summary>
        /// Original was GL_ALLOW_DRAW_MEM_HINT_PGI = 0x1A211
        /// </summary>
        AllowDrawMemHintPgi = ((int)0x1A211),
        /// <summary>
        /// Original was GL_STRICT_DEPTHFUNC_HINT_PGI = 0x1A216
        /// </summary>
        StrictDepthfuncHintPgi = ((int)0x1A216),
        /// <summary>
        /// Original was GL_STRICT_LIGHTING_HINT_PGI = 0x1A217
        /// </summary>
        StrictLightingHintPgi = ((int)0x1A217),
        /// <summary>
        /// Original was GL_STRICT_SCISSOR_HINT_PGI = 0x1A218
        /// </summary>
        StrictScissorHintPgi = ((int)0x1A218),
        /// <summary>
        /// Original was GL_FULL_STIPPLE_HINT_PGI = 0x1A219
        /// </summary>
        FullStippleHintPgi = ((int)0x1A219),
        /// <summary>
        /// Original was GL_CLIP_NEAR_HINT_PGI = 0x1A220
        /// </summary>
        ClipNearHintPgi = ((int)0x1A220),
        /// <summary>
        /// Original was GL_CLIP_FAR_HINT_PGI = 0x1A221
        /// </summary>
        ClipFarHintPgi = ((int)0x1A221),
        /// <summary>
        /// Original was GL_WIDE_LINE_HINT_PGI = 0x1A222
        /// </summary>
        WideLineHintPgi = ((int)0x1A222),
        /// <summary>
        /// Original was GL_BACK_NORMALS_HINT_PGI = 0x1A223
        /// </summary>
        BackNormalsHintPgi = ((int)0x1A223),
        /// <summary>
        /// Original was GL_VERTEX_DATA_HINT_PGI = 0x1A22A
        /// </summary>
        VertexDataHintPgi = ((int)0x1A22A),
        /// <summary>
        /// Original was GL_VERTEX_CONSISTENT_HINT_PGI = 0x1A22B
        /// </summary>
        VertexConsistentHintPgi = ((int)0x1A22B),
        /// <summary>
        /// Original was GL_MATERIAL_SIDE_HINT_PGI = 0x1A22C
        /// </summary>
        MaterialSideHintPgi = ((int)0x1A22C),
        /// <summary>
        /// Original was GL_MAX_VERTEX_HINT_PGI = 0x1A22D
        /// </summary>
        MaxVertexHintPgi = ((int)0x1A22D),
        /// <summary>
        /// Original was GL_POINT = 0x1B00
        /// </summary>
        Point = ((int)0x1B00),
        /// <summary>
        /// Original was GL_LINE = 0x1B01
        /// </summary>
        Line = ((int)0x1B01),
        /// <summary>
        /// Original was GL_FILL = 0x1B02
        /// </summary>
        Fill = ((int)0x1B02),
        /// <summary>
        /// Original was GL_RENDER = 0x1C00
        /// </summary>
        Render = ((int)0x1C00),
        /// <summary>
        /// Original was GL_FEEDBACK = 0x1C01
        /// </summary>
        Feedback = ((int)0x1C01),
        /// <summary>
        /// Original was GL_SELECT = 0x1C02
        /// </summary>
        Select = ((int)0x1C02),
        /// <summary>
        /// Original was GL_FLAT = 0x1D00
        /// </summary>
        Flat = ((int)0x1D00),
        /// <summary>
        /// Original was GL_SMOOTH = 0x1D01
        /// </summary>
        Smooth = ((int)0x1D01),
        /// <summary>
        /// Original was GL_KEEP = 0x1E00
        /// </summary>
        Keep = ((int)0x1E00),
        /// <summary>
        /// Original was GL_REPLACE = 0x1E01
        /// </summary>
        Replace = ((int)0x1E01),
        /// <summary>
        /// Original was GL_INCR = 0x1E02
        /// </summary>
        Incr = ((int)0x1E02),
        /// <summary>
        /// Original was GL_DECR = 0x1E03
        /// </summary>
        Decr = ((int)0x1E03),
        /// <summary>
        /// Original was GL_VENDOR = 0x1F00
        /// </summary>
        Vendor = ((int)0x1F00),
        /// <summary>
        /// Original was GL_RENDERER = 0x1F01
        /// </summary>
        Renderer = ((int)0x1F01),
        /// <summary>
        /// Original was GL_VERSION = 0x1F02
        /// </summary>
        Version = ((int)0x1F02),
        /// <summary>
        /// Original was GL_EXTENSIONS = 0x1F03
        /// </summary>
        Extensions = ((int)0x1F03),
        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20
        /// </summary>
        GlyphVerticalBearingXBitNv = ((int)0x20),
        /// <summary>
        /// Original was GL_S = 0x2000
        /// </summary>
        S = ((int)0x2000),
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
        T = ((int)0x2001),
        /// <summary>
        /// Original was GL_R = 0x2002
        /// </summary>
        R = ((int)0x2002),
        /// <summary>
        /// Original was GL_Q = 0x2003
        /// </summary>
        Q = ((int)0x2003),
        /// <summary>
        /// Original was GL_MODULATE = 0x2100
        /// </summary>
        Modulate = ((int)0x2100),
        /// <summary>
        /// Original was GL_DECAL = 0x2101
        /// </summary>
        Decal = ((int)0x2101),
        /// <summary>
        /// Original was GL_TEXTURE_ENV_MODE = 0x2200
        /// </summary>
        TextureEnvMode = ((int)0x2200),
        /// <summary>
        /// Original was GL_TEXTURE_ENV_COLOR = 0x2201
        /// </summary>
        TextureEnvColor = ((int)0x2201),
        /// <summary>
        /// Original was GL_TEXTURE_ENV = 0x2300
        /// </summary>
        TextureEnv = ((int)0x2300),
        /// <summary>
        /// Original was GL_EYE_LINEAR = 0x2400
        /// </summary>
        EyeLinear = ((int)0x2400),
        /// <summary>
        /// Original was GL_OBJECT_LINEAR = 0x2401
        /// </summary>
        ObjectLinear = ((int)0x2401),
        /// <summary>
        /// Original was GL_SPHERE_MAP = 0x2402
        /// </summary>
        SphereMap = ((int)0x2402),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_MODE = 0x2500
        /// </summary>
        TextureGenMode = ((int)0x2500),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_MODE_OES = 0x2500
        /// </summary>
        TextureGenModeOes = ((int)0x2500),
        /// <summary>
        /// Original was GL_OBJECT_PLANE = 0x2501
        /// </summary>
        ObjectPlane = ((int)0x2501),
        /// <summary>
        /// Original was GL_EYE_PLANE = 0x2502
        /// </summary>
        EyePlane = ((int)0x2502),
        /// <summary>
        /// Original was GL_NEAREST = 0x2600
        /// </summary>
        Nearest = ((int)0x2600),
        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = ((int)0x2601),
        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_NEAREST = 0x2700
        /// </summary>
        NearestMipmapNearest = ((int)0x2700),
        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_NEAREST = 0x2701
        /// </summary>
        LinearMipmapNearest = ((int)0x2701),
        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_LINEAR = 0x2702
        /// </summary>
        NearestMipmapLinear = ((int)0x2702),
        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_LINEAR = 0x2703
        /// </summary>
        LinearMipmapLinear = ((int)0x2703),
        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = ((int)0x2800),
        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = ((int)0x2801),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = ((int)0x2802),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = ((int)0x2803),
        /// <summary>
        /// Original was GL_CLAMP = 0x2900
        /// </summary>
        Clamp = ((int)0x2900),
        /// <summary>
        /// Original was GL_REPEAT = 0x2901
        /// </summary>
        Repeat = ((int)0x2901),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_UNITS = 0x2A00
        /// </summary>
        PolygonOffsetUnits = ((int)0x2A00),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_POINT = 0x2A01
        /// </summary>
        PolygonOffsetPoint = ((int)0x2A01),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_LINE = 0x2A02
        /// </summary>
        PolygonOffsetLine = ((int)0x2A02),
        /// <summary>
        /// Original was GL_R3_G3_B2 = 0x2A10
        /// </summary>
        R3G3B2 = ((int)0x2A10),
        /// <summary>
        /// Original was GL_V2F = 0x2A20
        /// </summary>
        V2f = ((int)0x2A20),
        /// <summary>
        /// Original was GL_V3F = 0x2A21
        /// </summary>
        V3f = ((int)0x2A21),
        /// <summary>
        /// Original was GL_C4UB_V2F = 0x2A22
        /// </summary>
        C4ubV2f = ((int)0x2A22),
        /// <summary>
        /// Original was GL_C4UB_V3F = 0x2A23
        /// </summary>
        C4ubV3f = ((int)0x2A23),
        /// <summary>
        /// Original was GL_C3F_V3F = 0x2A24
        /// </summary>
        C3fV3f = ((int)0x2A24),
        /// <summary>
        /// Original was GL_N3F_V3F = 0x2A25
        /// </summary>
        N3fV3f = ((int)0x2A25),
        /// <summary>
        /// Original was GL_C4F_N3F_V3F = 0x2A26
        /// </summary>
        C4fN3fV3f = ((int)0x2A26),
        /// <summary>
        /// Original was GL_T2F_V3F = 0x2A27
        /// </summary>
        T2fV3f = ((int)0x2A27),
        /// <summary>
        /// Original was GL_T4F_V4F = 0x2A28
        /// </summary>
        T4fV4f = ((int)0x2A28),
        /// <summary>
        /// Original was GL_T2F_C4UB_V3F = 0x2A29
        /// </summary>
        T2fC4ubV3f = ((int)0x2A29),
        /// <summary>
        /// Original was GL_T2F_C3F_V3F = 0x2A2A
        /// </summary>
        T2fC3fV3f = ((int)0x2A2A),
        /// <summary>
        /// Original was GL_T2F_N3F_V3F = 0x2A2B
        /// </summary>
        T2fN3fV3f = ((int)0x2A2B),
        /// <summary>
        /// Original was GL_T2F_C4F_N3F_V3F = 0x2A2C
        /// </summary>
        T2fC4fN3fV3f = ((int)0x2A2C),
        /// <summary>
        /// Original was GL_T4F_C4F_N3F_V4F = 0x2A2D
        /// </summary>
        T4fC4fN3fV4f = ((int)0x2A2D),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE0 = 0x3000
        /// </summary>
        ClipDistance0 = ((int)0x3000),
        /// <summary>
        /// Original was GL_CLIP_PLANE0 = 0x3000
        /// </summary>
        ClipPlane0 = ((int)0x3000),
        /// <summary>
        /// Original was GL_CLIP_PLANE0_IMG = 0x3000
        /// </summary>
        ClipPlane0Img = ((int)0x3000),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE1 = 0x3001
        /// </summary>
        ClipDistance1 = ((int)0x3001),
        /// <summary>
        /// Original was GL_CLIP_PLANE1 = 0x3001
        /// </summary>
        ClipPlane1 = ((int)0x3001),
        /// <summary>
        /// Original was GL_CLIP_PLANE1_IMG = 0x3001
        /// </summary>
        ClipPlane1Img = ((int)0x3001),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE2 = 0x3002
        /// </summary>
        ClipDistance2 = ((int)0x3002),
        /// <summary>
        /// Original was GL_CLIP_PLANE2 = 0x3002
        /// </summary>
        ClipPlane2 = ((int)0x3002),
        /// <summary>
        /// Original was GL_CLIP_PLANE2_IMG = 0x3002
        /// </summary>
        ClipPlane2Img = ((int)0x3002),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE3 = 0x3003
        /// </summary>
        ClipDistance3 = ((int)0x3003),
        /// <summary>
        /// Original was GL_CLIP_PLANE3 = 0x3003
        /// </summary>
        ClipPlane3 = ((int)0x3003),
        /// <summary>
        /// Original was GL_CLIP_PLANE3_IMG = 0x3003
        /// </summary>
        ClipPlane3Img = ((int)0x3003),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE4 = 0x3004
        /// </summary>
        ClipDistance4 = ((int)0x3004),
        /// <summary>
        /// Original was GL_CLIP_PLANE4 = 0x3004
        /// </summary>
        ClipPlane4 = ((int)0x3004),
        /// <summary>
        /// Original was GL_CLIP_PLANE4_IMG = 0x3004
        /// </summary>
        ClipPlane4Img = ((int)0x3004),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE5 = 0x3005
        /// </summary>
        ClipDistance5 = ((int)0x3005),
        /// <summary>
        /// Original was GL_CLIP_PLANE5 = 0x3005
        /// </summary>
        ClipPlane5 = ((int)0x3005),
        /// <summary>
        /// Original was GL_CLIP_PLANE5_IMG = 0x3005
        /// </summary>
        ClipPlane5Img = ((int)0x3005),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE6 = 0x3006
        /// </summary>
        ClipDistance6 = ((int)0x3006),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE7 = 0x3007
        /// </summary>
        ClipDistance7 = ((int)0x3007),
        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40
        /// </summary>
        GlyphVerticalBearingYBitNv = ((int)0x40),
        /// <summary>
        /// Original was GL_LIGHT0 = 0x4000
        /// </summary>
        Light0 = ((int)0x4000),
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT6_QCOM = 0x40000000
        /// </summary>
        MultisampleBufferBit6Qcom = ((int)0x40000000),
        /// <summary>
        /// Original was GL_LIGHT1 = 0x4001
        /// </summary>
        Light1 = ((int)0x4001),
        /// <summary>
        /// Original was GL_LIGHT2 = 0x4002
        /// </summary>
        Light2 = ((int)0x4002),
        /// <summary>
        /// Original was GL_LIGHT3 = 0x4003
        /// </summary>
        Light3 = ((int)0x4003),
        /// <summary>
        /// Original was GL_LIGHT4 = 0x4004
        /// </summary>
        Light4 = ((int)0x4004),
        /// <summary>
        /// Original was GL_LIGHT5 = 0x4005
        /// </summary>
        Light5 = ((int)0x4005),
        /// <summary>
        /// Original was GL_LIGHT6 = 0x4006
        /// </summary>
        Light6 = ((int)0x4006),
        /// <summary>
        /// Original was GL_LIGHT7 = 0x4007
        /// </summary>
        Light7 = ((int)0x4007),
        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80
        /// </summary>
        GlyphVerticalBearingAdvanceBitNv = ((int)0x80),
        /// <summary>
        /// Original was GL_ABGR_EXT = 0x8000
        /// </summary>
        AbgrExt = ((int)0x8000),
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT7_QCOM = 0x80000000
        /// </summary>
        MultisampleBufferBit7Qcom = unchecked((int)0x80000000),
        /// <summary>
        /// Original was GL_CONSTANT_COLOR = 0x8001
        /// </summary>
        ConstantColor = ((int)0x8001),
        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_COLOR = 0x8002
        /// </summary>
        OneMinusConstantColor = ((int)0x8002),
        /// <summary>
        /// Original was GL_CONSTANT_ALPHA = 0x8003
        /// </summary>
        ConstantAlpha = ((int)0x8003),
        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004
        /// </summary>
        OneMinusConstantAlpha = ((int)0x8004),
        /// <summary>
        /// Original was GL_BLEND_COLOR_EXT = 0x8005
        /// </summary>
        BlendColorExt = ((int)0x8005),
        /// <summary>
        /// Original was GL_FUNC_ADD = 0x8006
        /// </summary>
        FuncAdd = ((int)0x8006),
        /// <summary>
        /// Original was GL_FUNC_ADD_EXT = 0x8006
        /// </summary>
        FuncAddExt = ((int)0x8006),
        /// <summary>
        /// Original was GL_FUNC_ADD_OES = 0x8006
        /// </summary>
        FuncAddOes = ((int)0x8006),
        /// <summary>
        /// Original was GL_MIN_EXT = 0x8007
        /// </summary>
        MinExt = ((int)0x8007),
        /// <summary>
        /// Original was GL_MAX_EXT = 0x8008
        /// </summary>
        MaxExt = ((int)0x8008),
        /// <summary>
        /// Original was GL_BLEND_EQUATION_EXT = 0x8009
        /// </summary>
        BlendEquationExt = ((int)0x8009),
        /// <summary>
        /// Original was GL_BLEND_EQUATION_OES = 0x8009
        /// </summary>
        BlendEquationOes = ((int)0x8009),
        /// <summary>
        /// Original was GL_BLEND_EQUATION_RGB_OES = 0x8009
        /// </summary>
        BlendEquationRgbOes = ((int)0x8009),
        /// <summary>
        /// Original was GL_FUNC_SUBTRACT = 0x800A
        /// </summary>
        FuncSubtract = ((int)0x800A),
        /// <summary>
        /// Original was GL_FUNC_SUBTRACT_EXT = 0x800A
        /// </summary>
        FuncSubtractExt = ((int)0x800A),
        /// <summary>
        /// Original was GL_FUNC_SUBTRACT_OES = 0x800A
        /// </summary>
        FuncSubtractOes = ((int)0x800A),
        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT = 0x800B
        /// </summary>
        FuncReverseSubtract = ((int)0x800B),
        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT_EXT = 0x800B
        /// </summary>
        FuncReverseSubtractExt = ((int)0x800B),
        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT_OES = 0x800B
        /// </summary>
        FuncReverseSubtractOes = ((int)0x800B),
        /// <summary>
        /// Original was GL_CMYK_EXT = 0x800C
        /// </summary>
        CmykExt = ((int)0x800C),
        /// <summary>
        /// Original was GL_CMYKA_EXT = 0x800D
        /// </summary>
        CmykaExt = ((int)0x800D),
        /// <summary>
        /// Original was GL_PACK_CMYK_HINT_EXT = 0x800E
        /// </summary>
        PackCmykHintExt = ((int)0x800E),
        /// <summary>
        /// Original was GL_UNPACK_CMYK_HINT_EXT = 0x800F
        /// </summary>
        UnpackCmykHintExt = ((int)0x800F),
        /// <summary>
        /// Original was GL_CONVOLUTION_1D = 0x8010
        /// </summary>
        Convolution1D = ((int)0x8010),
        /// <summary>
        /// Original was GL_CONVOLUTION_1D_EXT = 0x8010
        /// </summary>
        Convolution1DExt = ((int)0x8010),
        /// <summary>
        /// Original was GL_CONVOLUTION_2D = 0x8011
        /// </summary>
        Convolution2D = ((int)0x8011),
        /// <summary>
        /// Original was GL_CONVOLUTION_2D_EXT = 0x8011
        /// </summary>
        Convolution2DExt = ((int)0x8011),
        /// <summary>
        /// Original was GL_SEPARABLE_2D = 0x8012
        /// </summary>
        Separable2D = ((int)0x8012),
        /// <summary>
        /// Original was GL_SEPARABLE_2D_EXT = 0x8012
        /// </summary>
        Separable2DExt = ((int)0x8012),
        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_MODE = 0x8013
        /// </summary>
        ConvolutionBorderMode = ((int)0x8013),
        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_MODE_EXT = 0x8013
        /// </summary>
        ConvolutionBorderModeExt = ((int)0x8013),
        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_SCALE = 0x8014
        /// </summary>
        ConvolutionFilterScale = ((int)0x8014),
        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_SCALE_EXT = 0x8014
        /// </summary>
        ConvolutionFilterScaleExt = ((int)0x8014),
        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_BIAS = 0x8015
        /// </summary>
        ConvolutionFilterBias = ((int)0x8015),
        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_BIAS_EXT = 0x8015
        /// </summary>
        ConvolutionFilterBiasExt = ((int)0x8015),
        /// <summary>
        /// Original was GL_REDUCE = 0x8016
        /// </summary>
        Reduce = ((int)0x8016),
        /// <summary>
        /// Original was GL_REDUCE_EXT = 0x8016
        /// </summary>
        ReduceExt = ((int)0x8016),
        /// <summary>
        /// Original was GL_CONVOLUTION_FORMAT = 0x8017
        /// </summary>
        ConvolutionFormat = ((int)0x8017),
        /// <summary>
        /// Original was GL_CONVOLUTION_FORMAT_EXT = 0x8017
        /// </summary>
        ConvolutionFormatExt = ((int)0x8017),
        /// <summary>
        /// Original was GL_CONVOLUTION_WIDTH = 0x8018
        /// </summary>
        ConvolutionWidth = ((int)0x8018),
        /// <summary>
        /// Original was GL_CONVOLUTION_WIDTH_EXT = 0x8018
        /// </summary>
        ConvolutionWidthExt = ((int)0x8018),
        /// <summary>
        /// Original was GL_CONVOLUTION_HEIGHT = 0x8019
        /// </summary>
        ConvolutionHeight = ((int)0x8019),
        /// <summary>
        /// Original was GL_CONVOLUTION_HEIGHT_EXT = 0x8019
        /// </summary>
        ConvolutionHeightExt = ((int)0x8019),
        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_WIDTH = 0x801A
        /// </summary>
        MaxConvolutionWidth = ((int)0x801A),
        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_WIDTH_EXT = 0x801A
        /// </summary>
        MaxConvolutionWidthExt = ((int)0x801A),
        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_HEIGHT = 0x801B
        /// </summary>
        MaxConvolutionHeight = ((int)0x801B),
        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_HEIGHT_EXT = 0x801B
        /// </summary>
        MaxConvolutionHeightExt = ((int)0x801B),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_SCALE = 0x801C
        /// </summary>
        PostConvolutionRedScale = ((int)0x801C),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C
        /// </summary>
        PostConvolutionRedScaleExt = ((int)0x801C),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D
        /// </summary>
        PostConvolutionGreenScale = ((int)0x801D),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D
        /// </summary>
        PostConvolutionGreenScaleExt = ((int)0x801D),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E
        /// </summary>
        PostConvolutionBlueScale = ((int)0x801E),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E
        /// </summary>
        PostConvolutionBlueScaleExt = ((int)0x801E),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F
        /// </summary>
        PostConvolutionAlphaScale = ((int)0x801F),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F
        /// </summary>
        PostConvolutionAlphaScaleExt = ((int)0x801F),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_BIAS = 0x8020
        /// </summary>
        PostConvolutionRedBias = ((int)0x8020),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_BIAS_EXT = 0x8020
        /// </summary>
        PostConvolutionRedBiasExt = ((int)0x8020),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021
        /// </summary>
        PostConvolutionGreenBias = ((int)0x8021),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021
        /// </summary>
        PostConvolutionGreenBiasExt = ((int)0x8021),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022
        /// </summary>
        PostConvolutionBlueBias = ((int)0x8022),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022
        /// </summary>
        PostConvolutionBlueBiasExt = ((int)0x8022),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023
        /// </summary>
        PostConvolutionAlphaBias = ((int)0x8023),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023
        /// </summary>
        PostConvolutionAlphaBiasExt = ((int)0x8023),
        /// <summary>
        /// Original was GL_HISTOGRAM = 0x8024
        /// </summary>
        Histogram = ((int)0x8024),
        /// <summary>
        /// Original was GL_HISTOGRAM_EXT = 0x8024
        /// </summary>
        HistogramExt = ((int)0x8024),
        /// <summary>
        /// Original was GL_PROXY_HISTOGRAM = 0x8025
        /// </summary>
        ProxyHistogram = ((int)0x8025),
        /// <summary>
        /// Original was GL_PROXY_HISTOGRAM_EXT = 0x8025
        /// </summary>
        ProxyHistogramExt = ((int)0x8025),
        /// <summary>
        /// Original was GL_HISTOGRAM_WIDTH = 0x8026
        /// </summary>
        HistogramWidth = ((int)0x8026),
        /// <summary>
        /// Original was GL_HISTOGRAM_WIDTH_EXT = 0x8026
        /// </summary>
        HistogramWidthExt = ((int)0x8026),
        /// <summary>
        /// Original was GL_HISTOGRAM_FORMAT = 0x8027
        /// </summary>
        HistogramFormat = ((int)0x8027),
        /// <summary>
        /// Original was GL_HISTOGRAM_FORMAT_EXT = 0x8027
        /// </summary>
        HistogramFormatExt = ((int)0x8027),
        /// <summary>
        /// Original was GL_HISTOGRAM_RED_SIZE = 0x8028
        /// </summary>
        HistogramRedSize = ((int)0x8028),
        /// <summary>
        /// Original was GL_HISTOGRAM_RED_SIZE_EXT = 0x8028
        /// </summary>
        HistogramRedSizeExt = ((int)0x8028),
        /// <summary>
        /// Original was GL_HISTOGRAM_GREEN_SIZE = 0x8029
        /// </summary>
        HistogramGreenSize = ((int)0x8029),
        /// <summary>
        /// Original was GL_HISTOGRAM_GREEN_SIZE_EXT = 0x8029
        /// </summary>
        HistogramGreenSizeExt = ((int)0x8029),
        /// <summary>
        /// Original was GL_HISTOGRAM_BLUE_SIZE = 0x802A
        /// </summary>
        HistogramBlueSize = ((int)0x802A),
        /// <summary>
        /// Original was GL_HISTOGRAM_BLUE_SIZE_EXT = 0x802A
        /// </summary>
        HistogramBlueSizeExt = ((int)0x802A),
        /// <summary>
        /// Original was GL_HISTOGRAM_ALPHA_SIZE = 0x802B
        /// </summary>
        HistogramAlphaSize = ((int)0x802B),
        /// <summary>
        /// Original was GL_HISTOGRAM_ALPHA_SIZE_EXT = 0x802B
        /// </summary>
        HistogramAlphaSizeExt = ((int)0x802B),
        /// <summary>
        /// Original was GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C
        /// </summary>
        HistogramLuminanceSize = ((int)0x802C),
        /// <summary>
        /// Original was GL_HISTOGRAM_LUMINANCE_SIZE_EXT = 0x802C
        /// </summary>
        HistogramLuminanceSizeExt = ((int)0x802C),
        /// <summary>
        /// Original was GL_HISTOGRAM_SINK = 0x802D
        /// </summary>
        HistogramSink = ((int)0x802D),
        /// <summary>
        /// Original was GL_HISTOGRAM_SINK_EXT = 0x802D
        /// </summary>
        HistogramSinkExt = ((int)0x802D),
        /// <summary>
        /// Original was GL_MINMAX = 0x802E
        /// </summary>
        Minmax = ((int)0x802E),
        /// <summary>
        /// Original was GL_MINMAX_EXT = 0x802E
        /// </summary>
        MinmaxExt = ((int)0x802E),
        /// <summary>
        /// Original was GL_MINMAX_FORMAT = 0x802F
        /// </summary>
        MinmaxFormat = ((int)0x802F),
        /// <summary>
        /// Original was GL_MINMAX_FORMAT_EXT = 0x802F
        /// </summary>
        MinmaxFormatExt = ((int)0x802F),
        /// <summary>
        /// Original was GL_MINMAX_SINK = 0x8030
        /// </summary>
        MinmaxSink = ((int)0x8030),
        /// <summary>
        /// Original was GL_MINMAX_SINK_EXT = 0x8030
        /// </summary>
        MinmaxSinkExt = ((int)0x8030),
        /// <summary>
        /// Original was GL_TABLE_TOO_LARGE = 0x8031
        /// </summary>
        TableTooLarge = ((int)0x8031),
        /// <summary>
        /// Original was GL_TABLE_TOO_LARGE_EXT = 0x8031
        /// </summary>
        TableTooLargeExt = ((int)0x8031),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE_3_3_2 = 0x8032
        /// </summary>
        UnsignedByte332 = ((int)0x8032),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE_3_3_2_EXT = 0x8032
        /// </summary>
        UnsignedByte332Ext = ((int)0x8032),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033
        /// </summary>
        UnsignedShort4444 = ((int)0x8033),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033
        /// </summary>
        UnsignedShort4444Ext = ((int)0x8033),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034
        /// </summary>
        UnsignedShort5551 = ((int)0x8034),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034
        /// </summary>
        UnsignedShort5551Ext = ((int)0x8034),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_8_8_8_8 = 0x8035
        /// </summary>
        UnsignedInt8888 = ((int)0x8035),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_8_8_8_8_EXT = 0x8035
        /// </summary>
        UnsignedInt8888Ext = ((int)0x8035),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_10_10_10_2 = 0x8036
        /// </summary>
        UnsignedInt1010102 = ((int)0x8036),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_10_10_10_2_EXT = 0x8036
        /// </summary>
        UnsignedInt1010102Ext = ((int)0x8036),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FILL = 0x8037
        /// </summary>
        PolygonOffsetFill = ((int)0x8037),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FACTOR = 0x8038
        /// </summary>
        PolygonOffsetFactor = ((int)0x8038),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_BIAS_EXT = 0x8039
        /// </summary>
        PolygonOffsetBiasExt = ((int)0x8039),
        /// <summary>
        /// Original was GL_RESCALE_NORMAL = 0x803A
        /// </summary>
        RescaleNormal = ((int)0x803A),
        /// <summary>
        /// Original was GL_RESCALE_NORMAL_EXT = 0x803A
        /// </summary>
        RescaleNormalExt = ((int)0x803A),
        /// <summary>
        /// Original was GL_ALPHA4 = 0x803B
        /// </summary>
        Alpha4 = ((int)0x803B),
        /// <summary>
        /// Original was GL_ALPHA8 = 0x803C
        /// </summary>
        Alpha8 = ((int)0x803C),
        /// <summary>
        /// Original was GL_ALPHA8_EXT = 0x803C
        /// </summary>
        Alpha8Ext = ((int)0x803C),
        /// <summary>
        /// Original was GL_ALPHA8_OES = 0x803C
        /// </summary>
        Alpha8Oes = ((int)0x803C),
        /// <summary>
        /// Original was GL_ALPHA12 = 0x803D
        /// </summary>
        Alpha12 = ((int)0x803D),
        /// <summary>
        /// Original was GL_ALPHA16 = 0x803E
        /// </summary>
        Alpha16 = ((int)0x803E),
        /// <summary>
        /// Original was GL_LUMINANCE4 = 0x803F
        /// </summary>
        Luminance4 = ((int)0x803F),
        /// <summary>
        /// Original was GL_LUMINANCE8 = 0x8040
        /// </summary>
        Luminance8 = ((int)0x8040),
        /// <summary>
        /// Original was GL_LUMINANCE8_EXT = 0x8040
        /// </summary>
        Luminance8Ext = ((int)0x8040),
        /// <summary>
        /// Original was GL_LUMINANCE8_OES = 0x8040
        /// </summary>
        Luminance8Oes = ((int)0x8040),
        /// <summary>
        /// Original was GL_LUMINANCE12 = 0x8041
        /// </summary>
        Luminance12 = ((int)0x8041),
        /// <summary>
        /// Original was GL_LUMINANCE16 = 0x8042
        /// </summary>
        Luminance16 = ((int)0x8042),
        /// <summary>
        /// Original was GL_LUMINANCE4_ALPHA4 = 0x8043
        /// </summary>
        Luminance4Alpha4 = ((int)0x8043),
        /// <summary>
        /// Original was GL_LUMINANCE4_ALPHA4_OES = 0x8043
        /// </summary>
        Luminance4Alpha4Oes = ((int)0x8043),
        /// <summary>
        /// Original was GL_LUMINANCE6_ALPHA2 = 0x8044
        /// </summary>
        Luminance6Alpha2 = ((int)0x8044),
        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8 = 0x8045
        /// </summary>
        Luminance8Alpha8 = ((int)0x8045),
        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8_EXT = 0x8045
        /// </summary>
        Luminance8Alpha8Ext = ((int)0x8045),
        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8_OES = 0x8045
        /// </summary>
        Luminance8Alpha8Oes = ((int)0x8045),
        /// <summary>
        /// Original was GL_LUMINANCE12_ALPHA4 = 0x8046
        /// </summary>
        Luminance12Alpha4 = ((int)0x8046),
        /// <summary>
        /// Original was GL_LUMINANCE12_ALPHA12 = 0x8047
        /// </summary>
        Luminance12Alpha12 = ((int)0x8047),
        /// <summary>
        /// Original was GL_LUMINANCE16_ALPHA16 = 0x8048
        /// </summary>
        Luminance16Alpha16 = ((int)0x8048),
        /// <summary>
        /// Original was GL_INTENSITY = 0x8049
        /// </summary>
        Intensity = ((int)0x8049),
        /// <summary>
        /// Original was GL_INTENSITY4 = 0x804A
        /// </summary>
        Intensity4 = ((int)0x804A),
        /// <summary>
        /// Original was GL_INTENSITY8 = 0x804B
        /// </summary>
        Intensity8 = ((int)0x804B),
        /// <summary>
        /// Original was GL_INTENSITY12 = 0x804C
        /// </summary>
        Intensity12 = ((int)0x804C),
        /// <summary>
        /// Original was GL_INTENSITY16 = 0x804D
        /// </summary>
        Intensity16 = ((int)0x804D),
        /// <summary>
        /// Original was GL_RGB2_EXT = 0x804E
        /// </summary>
        Rgb2Ext = ((int)0x804E),
        /// <summary>
        /// Original was GL_RGB4 = 0x804F
        /// </summary>
        Rgb4 = ((int)0x804F),
        /// <summary>
        /// Original was GL_RGB4_EXT = 0x804F
        /// </summary>
        Rgb4Ext = ((int)0x804F),
        /// <summary>
        /// Original was GL_RGB5 = 0x8050
        /// </summary>
        Rgb5 = ((int)0x8050),
        /// <summary>
        /// Original was GL_RGB5_EXT = 0x8050
        /// </summary>
        Rgb5Ext = ((int)0x8050),
        /// <summary>
        /// Original was GL_RGB8 = 0x8051
        /// </summary>
        Rgb8 = ((int)0x8051),
        /// <summary>
        /// Original was GL_RGB8_EXT = 0x8051
        /// </summary>
        Rgb8Ext = ((int)0x8051),
        /// <summary>
        /// Original was GL_RGB8_OES = 0x8051
        /// </summary>
        Rgb8Oes = ((int)0x8051),
        /// <summary>
        /// Original was GL_RGB10 = 0x8052
        /// </summary>
        Rgb10 = ((int)0x8052),
        /// <summary>
        /// Original was GL_RGB10_EXT = 0x8052
        /// </summary>
        Rgb10Ext = ((int)0x8052),
        /// <summary>
        /// Original was GL_RGB12 = 0x8053
        /// </summary>
        Rgb12 = ((int)0x8053),
        /// <summary>
        /// Original was GL_RGB12_EXT = 0x8053
        /// </summary>
        Rgb12Ext = ((int)0x8053),
        /// <summary>
        /// Original was GL_RGB16 = 0x8054
        /// </summary>
        Rgb16 = ((int)0x8054),
        /// <summary>
        /// Original was GL_RGB16_EXT = 0x8054
        /// </summary>
        Rgb16Ext = ((int)0x8054),
        /// <summary>
        /// Original was GL_RGBA4 = 0x8056
        /// </summary>
        Rgba4 = ((int)0x8056),
        /// <summary>
        /// Original was GL_RGBA4_EXT = 0x8056
        /// </summary>
        Rgba4Ext = ((int)0x8056),
        /// <summary>
        /// Original was GL_RGBA4_OES = 0x8056
        /// </summary>
        Rgba4Oes = ((int)0x8056),
        /// <summary>
        /// Original was GL_RGB5_A1 = 0x8057
        /// </summary>
        Rgb5A1 = ((int)0x8057),
        /// <summary>
        /// Original was GL_RGB5_A1_EXT = 0x8057
        /// </summary>
        Rgb5A1Ext = ((int)0x8057),
        /// <summary>
        /// Original was GL_RGB5_A1_OES = 0x8057
        /// </summary>
        Rgb5A1Oes = ((int)0x8057),
        /// <summary>
        /// Original was GL_RGBA8 = 0x8058
        /// </summary>
        Rgba8 = ((int)0x8058),
        /// <summary>
        /// Original was GL_RGBA8_EXT = 0x8058
        /// </summary>
        Rgba8Ext = ((int)0x8058),
        /// <summary>
        /// Original was GL_RGBA8_OES = 0x8058
        /// </summary>
        Rgba8Oes = ((int)0x8058),
        /// <summary>
        /// Original was GL_RGB10_A2 = 0x8059
        /// </summary>
        Rgb10A2 = ((int)0x8059),
        /// <summary>
        /// Original was GL_RGB10_A2_EXT = 0x8059
        /// </summary>
        Rgb10A2Ext = ((int)0x8059),
        /// <summary>
        /// Original was GL_RGBA12 = 0x805A
        /// </summary>
        Rgba12 = ((int)0x805A),
        /// <summary>
        /// Original was GL_RGBA12_EXT = 0x805A
        /// </summary>
        Rgba12Ext = ((int)0x805A),
        /// <summary>
        /// Original was GL_RGBA16 = 0x805B
        /// </summary>
        Rgba16 = ((int)0x805B),
        /// <summary>
        /// Original was GL_RGBA16_EXT = 0x805B
        /// </summary>
        Rgba16Ext = ((int)0x805B),
        /// <summary>
        /// Original was GL_TEXTURE_RED_SIZE = 0x805C
        /// </summary>
        TextureRedSize = ((int)0x805C),
        /// <summary>
        /// Original was GL_TEXTURE_GREEN_SIZE = 0x805D
        /// </summary>
        TextureGreenSize = ((int)0x805D),
        /// <summary>
        /// Original was GL_TEXTURE_BLUE_SIZE = 0x805E
        /// </summary>
        TextureBlueSize = ((int)0x805E),
        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_SIZE = 0x805F
        /// </summary>
        TextureAlphaSize = ((int)0x805F),
        /// <summary>
        /// Original was GL_TEXTURE_LUMINANCE_SIZE = 0x8060
        /// </summary>
        TextureLuminanceSize = ((int)0x8060),
        /// <summary>
        /// Original was GL_TEXTURE_INTENSITY_SIZE = 0x8061
        /// </summary>
        TextureIntensitySize = ((int)0x8061),
        /// <summary>
        /// Original was GL_REPLACE_EXT = 0x8062
        /// </summary>
        ReplaceExt = ((int)0x8062),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D = 0x8063
        /// </summary>
        ProxyTexture1D = ((int)0x8063),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_EXT = 0x8063
        /// </summary>
        ProxyTexture1DExt = ((int)0x8063),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D = 0x8064
        /// </summary>
        ProxyTexture2D = ((int)0x8064),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_EXT = 0x8064
        /// </summary>
        ProxyTexture2DExt = ((int)0x8064),
        /// <summary>
        /// Original was GL_TEXTURE_TOO_LARGE_EXT = 0x8065
        /// </summary>
        TextureTooLargeExt = ((int)0x8065),
        /// <summary>
        /// Original was GL_TEXTURE_PRIORITY = 0x8066
        /// </summary>
        TexturePriority = ((int)0x8066),
        /// <summary>
        /// Original was GL_TEXTURE_PRIORITY_EXT = 0x8066
        /// </summary>
        TexturePriorityExt = ((int)0x8066),
        /// <summary>
        /// Original was GL_TEXTURE_RESIDENT = 0x8067
        /// </summary>
        TextureResident = ((int)0x8067),
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_1D = 0x8068
        /// </summary>
        TextureBinding1D = ((int)0x8068),
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D = 0x8069
        /// </summary>
        TextureBinding2D = ((int)0x8069),
        /// <summary>
        /// Original was GL_TEXTURE_3D_BINDING_EXT = 0x806A
        /// </summary>
        Texture3DBindingExt = ((int)0x806A),
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_3D = 0x806A
        /// </summary>
        TextureBinding3D = ((int)0x806A),
        /// <summary>
        /// Original was GL_PACK_SKIP_IMAGES = 0x806B
        /// </summary>
        PackSkipImages = ((int)0x806B),
        /// <summary>
        /// Original was GL_PACK_SKIP_IMAGES_EXT = 0x806B
        /// </summary>
        PackSkipImagesExt = ((int)0x806B),
        /// <summary>
        /// Original was GL_PACK_IMAGE_HEIGHT = 0x806C
        /// </summary>
        PackImageHeight = ((int)0x806C),
        /// <summary>
        /// Original was GL_PACK_IMAGE_HEIGHT_EXT = 0x806C
        /// </summary>
        PackImageHeightExt = ((int)0x806C),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_IMAGES = 0x806D
        /// </summary>
        UnpackSkipImages = ((int)0x806D),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_IMAGES_EXT = 0x806D
        /// </summary>
        UnpackSkipImagesExt = ((int)0x806D),
        /// <summary>
        /// Original was GL_UNPACK_IMAGE_HEIGHT = 0x806E
        /// </summary>
        UnpackImageHeight = ((int)0x806E),
        /// <summary>
        /// Original was GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E
        /// </summary>
        UnpackImageHeightExt = ((int)0x806E),
        /// <summary>
        /// Original was GL_TEXTURE_3D = 0x806F
        /// </summary>
        Texture3D = ((int)0x806F),
        /// <summary>
        /// Original was GL_TEXTURE_3D_EXT = 0x806F
        /// </summary>
        Texture3DExt = ((int)0x806F),
        /// <summary>
        /// Original was GL_TEXTURE_3D_OES = 0x806F
        /// </summary>
        Texture3DOes = ((int)0x806F),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_3D = 0x8070
        /// </summary>
        ProxyTexture3D = ((int)0x8070),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_3D_EXT = 0x8070
        /// </summary>
        ProxyTexture3DExt = ((int)0x8070),
        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_EXT = 0x8071
        /// </summary>
        TextureDepthExt = ((int)0x8071),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R = 0x8072
        /// </summary>
        TextureWrapR = ((int)0x8072),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R_EXT = 0x8072
        /// </summary>
        TextureWrapRExt = ((int)0x8072),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R_OES = 0x8072
        /// </summary>
        TextureWrapROes = ((int)0x8072),
        /// <summary>
        /// Original was GL_MAX_3D_TEXTURE_SIZE_EXT = 0x8073
        /// </summary>
        Max3DTextureSizeExt = ((int)0x8073),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = ((int)0x8074),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_KHR = 0x8074
        /// </summary>
        VertexArrayKhr = ((int)0x8074),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY = 0x8075
        /// </summary>
        NormalArray = ((int)0x8075),
        /// <summary>
        /// Original was GL_COLOR_ARRAY = 0x8076
        /// </summary>
        ColorArray = ((int)0x8076),
        /// <summary>
        /// Original was GL_INDEX_ARRAY = 0x8077
        /// </summary>
        IndexArray = ((int)0x8077),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY = 0x8078
        /// </summary>
        TextureCoordArray = ((int)0x8078),
        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY = 0x8079
        /// </summary>
        EdgeFlagArray = ((int)0x8079),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_SIZE = 0x807A
        /// </summary>
        VertexArraySize = ((int)0x807A),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_TYPE = 0x807B
        /// </summary>
        VertexArrayType = ((int)0x807B),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_STRIDE = 0x807C
        /// </summary>
        VertexArrayStride = ((int)0x807C),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_COUNT_EXT = 0x807D
        /// </summary>
        VertexArrayCountExt = ((int)0x807D),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_TYPE = 0x807E
        /// </summary>
        NormalArrayType = ((int)0x807E),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_STRIDE = 0x807F
        /// </summary>
        NormalArrayStride = ((int)0x807F),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_COUNT_EXT = 0x8080
        /// </summary>
        NormalArrayCountExt = ((int)0x8080),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_SIZE = 0x8081
        /// </summary>
        ColorArraySize = ((int)0x8081),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_TYPE = 0x8082
        /// </summary>
        ColorArrayType = ((int)0x8082),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_STRIDE = 0x8083
        /// </summary>
        ColorArrayStride = ((int)0x8083),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_COUNT_EXT = 0x8084
        /// </summary>
        ColorArrayCountExt = ((int)0x8084),
        /// <summary>
        /// Original was GL_INDEX_ARRAY_TYPE = 0x8085
        /// </summary>
        IndexArrayType = ((int)0x8085),
        /// <summary>
        /// Original was GL_INDEX_ARRAY_STRIDE = 0x8086
        /// </summary>
        IndexArrayStride = ((int)0x8086),
        /// <summary>
        /// Original was GL_INDEX_ARRAY_COUNT_EXT = 0x8087
        /// </summary>
        IndexArrayCountExt = ((int)0x8087),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088
        /// </summary>
        TextureCoordArraySize = ((int)0x8088),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089
        /// </summary>
        TextureCoordArrayType = ((int)0x8089),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A
        /// </summary>
        TextureCoordArrayStride = ((int)0x808A),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B
        /// </summary>
        TextureCoordArrayCountExt = ((int)0x808B),
        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C
        /// </summary>
        EdgeFlagArrayStride = ((int)0x808C),
        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D
        /// </summary>
        EdgeFlagArrayCountExt = ((int)0x808D),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_POINTER = 0x808E
        /// </summary>
        VertexArrayPointer = ((int)0x808E),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_POINTER_EXT = 0x808E
        /// </summary>
        VertexArrayPointerExt = ((int)0x808E),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_POINTER = 0x808F
        /// </summary>
        NormalArrayPointer = ((int)0x808F),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_POINTER_EXT = 0x808F
        /// </summary>
        NormalArrayPointerExt = ((int)0x808F),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_POINTER = 0x8090
        /// </summary>
        ColorArrayPointer = ((int)0x8090),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_POINTER_EXT = 0x8090
        /// </summary>
        ColorArrayPointerExt = ((int)0x8090),
        /// <summary>
        /// Original was GL_INDEX_ARRAY_POINTER = 0x8091
        /// </summary>
        IndexArrayPointer = ((int)0x8091),
        /// <summary>
        /// Original was GL_INDEX_ARRAY_POINTER_EXT = 0x8091
        /// </summary>
        IndexArrayPointerExt = ((int)0x8091),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092
        /// </summary>
        TextureCoordArrayPointer = ((int)0x8092),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092
        /// </summary>
        TextureCoordArrayPointerExt = ((int)0x8092),
        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_POINTER = 0x8093
        /// </summary>
        EdgeFlagArrayPointer = ((int)0x8093),
        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_POINTER_EXT = 0x8093
        /// </summary>
        EdgeFlagArrayPointerExt = ((int)0x8093),
        /// <summary>
        /// Original was GL_INTERLACE_SGIX = 0x8094
        /// </summary>
        InterlaceSgix = ((int)0x8094),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_2D_SGIS = 0x8095
        /// </summary>
        DetailTexture2DSgis = ((int)0x8095),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096
        /// </summary>
        DetailTexture2DBindingSgis = ((int)0x8096),
        /// <summary>
        /// Original was GL_LINEAR_DETAIL_SGIS = 0x8097
        /// </summary>
        LinearDetailSgis = ((int)0x8097),
        /// <summary>
        /// Original was GL_LINEAR_DETAIL_ALPHA_SGIS = 0x8098
        /// </summary>
        LinearDetailAlphaSgis = ((int)0x8098),
        /// <summary>
        /// Original was GL_LINEAR_DETAIL_COLOR_SGIS = 0x8099
        /// </summary>
        LinearDetailColorSgis = ((int)0x8099),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_LEVEL_SGIS = 0x809A
        /// </summary>
        DetailTextureLevelSgis = ((int)0x809A),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_MODE_SGIS = 0x809B
        /// </summary>
        DetailTextureModeSgis = ((int)0x809B),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C
        /// </summary>
        DetailTextureFuncPointsSgis = ((int)0x809C),
        /// <summary>
        /// Original was GL_MULTISAMPLE = 0x809D
        /// </summary>
        Multisample = ((int)0x809D),
        /// <summary>
        /// Original was GL_MULTISAMPLE_SGIS = 0x809D
        /// </summary>
        MultisampleSgis = ((int)0x809D),
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E
        /// </summary>
        SampleAlphaToCoverage = ((int)0x809E),
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E
        /// </summary>
        SampleAlphaToMaskSgis = ((int)0x809E),
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE = 0x809F
        /// </summary>
        SampleAlphaToOne = ((int)0x809F),
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F
        /// </summary>
        SampleAlphaToOneSgis = ((int)0x809F),
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE = 0x80A0
        /// </summary>
        SampleCoverage = ((int)0x80A0),
        /// <summary>
        /// Original was GL_SAMPLE_MASK_SGIS = 0x80A0
        /// </summary>
        SampleMaskSgis = ((int)0x80A0),
        /// <summary>
        /// Original was GL_1PASS_EXT = 0x80A1
        /// </summary>
        Gl1PassExt = ((int)0x80A1),
        /// <summary>
        /// Original was GL_1PASS_SGIS = 0x80A1
        /// </summary>
        Gl1PassSgis = ((int)0x80A1),
        /// <summary>
        /// Original was GL_2PASS_0_EXT = 0x80A2
        /// </summary>
        Gl2Pass0Ext = ((int)0x80A2),
        /// <summary>
        /// Original was GL_2PASS_0_SGIS = 0x80A2
        /// </summary>
        Gl2Pass0Sgis = ((int)0x80A2),
        /// <summary>
        /// Original was GL_2PASS_1_EXT = 0x80A3
        /// </summary>
        Gl2Pass1Ext = ((int)0x80A3),
        /// <summary>
        /// Original was GL_2PASS_1_SGIS = 0x80A3
        /// </summary>
        Gl2Pass1Sgis = ((int)0x80A3),
        /// <summary>
        /// Original was GL_4PASS_0_EXT = 0x80A4
        /// </summary>
        Gl4Pass0Ext = ((int)0x80A4),
        /// <summary>
        /// Original was GL_4PASS_0_SGIS = 0x80A4
        /// </summary>
        Gl4Pass0Sgis = ((int)0x80A4),
        /// <summary>
        /// Original was GL_4PASS_1_EXT = 0x80A5
        /// </summary>
        Gl4Pass1Ext = ((int)0x80A5),
        /// <summary>
        /// Original was GL_4PASS_1_SGIS = 0x80A5
        /// </summary>
        Gl4Pass1Sgis = ((int)0x80A5),
        /// <summary>
        /// Original was GL_4PASS_2_EXT = 0x80A6
        /// </summary>
        Gl4Pass2Ext = ((int)0x80A6),
        /// <summary>
        /// Original was GL_4PASS_2_SGIS = 0x80A6
        /// </summary>
        Gl4Pass2Sgis = ((int)0x80A6),
        /// <summary>
        /// Original was GL_4PASS_3_EXT = 0x80A7
        /// </summary>
        Gl4Pass3Ext = ((int)0x80A7),
        /// <summary>
        /// Original was GL_4PASS_3_SGIS = 0x80A7
        /// </summary>
        Gl4Pass3Sgis = ((int)0x80A7),
        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS = 0x80A8
        /// </summary>
        SampleBuffers = ((int)0x80A8),
        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS_SGIS = 0x80A8
        /// </summary>
        SampleBuffersSgis = ((int)0x80A8),
        /// <summary>
        /// Original was GL_SAMPLES = 0x80A9
        /// </summary>
        Samples = ((int)0x80A9),
        /// <summary>
        /// Original was GL_SAMPLES_SGIS = 0x80A9
        /// </summary>
        SamplesSgis = ((int)0x80A9),
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_VALUE = 0x80AA
        /// </summary>
        SampleCoverageValue = ((int)0x80AA),
        /// <summary>
        /// Original was GL_SAMPLE_MASK_VALUE_SGIS = 0x80AA
        /// </summary>
        SampleMaskValueSgis = ((int)0x80AA),
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_INVERT = 0x80AB
        /// </summary>
        SampleCoverageInvert = ((int)0x80AB),
        /// <summary>
        /// Original was GL_SAMPLE_MASK_INVERT_SGIS = 0x80AB
        /// </summary>
        SampleMaskInvertSgis = ((int)0x80AB),
        /// <summary>
        /// Original was GL_SAMPLE_PATTERN_SGIS = 0x80AC
        /// </summary>
        SamplePatternSgis = ((int)0x80AC),
        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_SGIS = 0x80AD
        /// </summary>
        LinearSharpenSgis = ((int)0x80AD),
        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE
        /// </summary>
        LinearSharpenAlphaSgis = ((int)0x80AE),
        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_COLOR_SGIS = 0x80AF
        /// </summary>
        LinearSharpenColorSgis = ((int)0x80AF),
        /// <summary>
        /// Original was GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0
        /// </summary>
        SharpenTextureFuncPointsSgis = ((int)0x80B0),
        /// <summary>
        /// Original was GL_COLOR_MATRIX_SGI = 0x80B1
        /// </summary>
        ColorMatrixSgi = ((int)0x80B1),
        /// <summary>
        /// Original was GL_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2
        /// </summary>
        ColorMatrixStackDepthSgi = ((int)0x80B2),
        /// <summary>
        /// Original was GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3
        /// </summary>
        MaxColorMatrixStackDepthSgi = ((int)0x80B3),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4
        /// </summary>
        PostColorMatrixRedScale = ((int)0x80B4),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4
        /// </summary>
        PostColorMatrixRedScaleSgi = ((int)0x80B4),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5
        /// </summary>
        PostColorMatrixGreenScale = ((int)0x80B5),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5
        /// </summary>
        PostColorMatrixGreenScaleSgi = ((int)0x80B5),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6
        /// </summary>
        PostColorMatrixBlueScale = ((int)0x80B6),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6
        /// </summary>
        PostColorMatrixBlueScaleSgi = ((int)0x80B6),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7
        /// </summary>
        PostColorMatrixAlphaScale = ((int)0x80B7),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7
        /// </summary>
        PostColorMatrixAlphaScaleSgi = ((int)0x80B7),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8
        /// </summary>
        PostColorMatrixRedBias = ((int)0x80B8),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8
        /// </summary>
        PostColorMatrixRedBiasSgi = ((int)0x80B8),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9
        /// </summary>
        PostColorMatrixGreenBias = ((int)0x80B9),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9
        /// </summary>
        PostColorMatrixGreenBiasSgi = ((int)0x80B9),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA
        /// </summary>
        PostColorMatrixBlueBias = ((int)0x80BA),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA
        /// </summary>
        PostColorMatrixBlueBiasSgi = ((int)0x80BA),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB
        /// </summary>
        PostColorMatrixAlphaBias = ((int)0x80BB),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB
        /// </summary>
        PostColorMatrixAlphaBiasSgi = ((int)0x80BB),
        /// <summary>
        /// Original was GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
        /// </summary>
        TextureColorTableSgi = ((int)0x80BC),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_COLOR_TABLE_SGI = 0x80BD
        /// </summary>
        ProxyTextureColorTableSgi = ((int)0x80BD),
        /// <summary>
        /// Original was GL_TEXTURE_ENV_BIAS_SGIX = 0x80BE
        /// </summary>
        TextureEnvBiasSgix = ((int)0x80BE),
        /// <summary>
        /// Original was GL_SHADOW_AMBIENT_SGIX = 0x80BF
        /// </summary>
        ShadowAmbientSgix = ((int)0x80BF),
        /// <summary>
        /// Original was GL_BLEND_DST_RGB_OES = 0x80C8
        /// </summary>
        BlendDstRgbOes = ((int)0x80C8),
        /// <summary>
        /// Original was GL_BLEND_SRC_RGB_OES = 0x80C9
        /// </summary>
        BlendSrcRgbOes = ((int)0x80C9),
        /// <summary>
        /// Original was GL_BLEND_DST_ALPHA_OES = 0x80CA
        /// </summary>
        BlendDstAlphaOes = ((int)0x80CA),
        /// <summary>
        /// Original was GL_BLEND_SRC_ALPHA_OES = 0x80CB
        /// </summary>
        BlendSrcAlphaOes = ((int)0x80CB),
        /// <summary>
        /// Original was GL_COLOR_TABLE = 0x80D0
        /// </summary>
        ColorTable = ((int)0x80D0),
        /// <summary>
        /// Original was GL_COLOR_TABLE_SGI = 0x80D0
        /// </summary>
        ColorTableSgi = ((int)0x80D0),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1
        /// </summary>
        PostConvolutionColorTable = ((int)0x80D1),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
        /// </summary>
        PostConvolutionColorTableSgi = ((int)0x80D1),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2
        /// </summary>
        PostColorMatrixColorTable = ((int)0x80D2),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
        /// </summary>
        PostColorMatrixColorTableSgi = ((int)0x80D2),
        /// <summary>
        /// Original was GL_PROXY_COLOR_TABLE = 0x80D3
        /// </summary>
        ProxyColorTable = ((int)0x80D3),
        /// <summary>
        /// Original was GL_PROXY_COLOR_TABLE_SGI = 0x80D3
        /// </summary>
        ProxyColorTableSgi = ((int)0x80D3),
        /// <summary>
        /// Original was GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4
        /// </summary>
        ProxyPostConvolutionColorTable = ((int)0x80D4),
        /// <summary>
        /// Original was GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D4
        /// </summary>
        ProxyPostConvolutionColorTableSgi = ((int)0x80D4),
        /// <summary>
        /// Original was GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5
        /// </summary>
        ProxyPostColorMatrixColorTable = ((int)0x80D5),
        /// <summary>
        /// Original was GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D5
        /// </summary>
        ProxyPostColorMatrixColorTableSgi = ((int)0x80D5),
        /// <summary>
        /// Original was GL_COLOR_TABLE_SCALE = 0x80D6
        /// </summary>
        ColorTableScale = ((int)0x80D6),
        /// <summary>
        /// Original was GL_COLOR_TABLE_SCALE_SGI = 0x80D6
        /// </summary>
        ColorTableScaleSgi = ((int)0x80D6),
        /// <summary>
        /// Original was GL_COLOR_TABLE_BIAS = 0x80D7
        /// </summary>
        ColorTableBias = ((int)0x80D7),
        /// <summary>
        /// Original was GL_COLOR_TABLE_BIAS_SGI = 0x80D7
        /// </summary>
        ColorTableBiasSgi = ((int)0x80D7),
        /// <summary>
        /// Original was GL_COLOR_TABLE_FORMAT = 0x80D8
        /// </summary>
        ColorTableFormat = ((int)0x80D8),
        /// <summary>
        /// Original was GL_COLOR_TABLE_FORMAT_SGI = 0x80D8
        /// </summary>
        ColorTableFormatSgi = ((int)0x80D8),
        /// <summary>
        /// Original was GL_COLOR_TABLE_WIDTH = 0x80D9
        /// </summary>
        ColorTableWidth = ((int)0x80D9),
        /// <summary>
        /// Original was GL_COLOR_TABLE_WIDTH_SGI = 0x80D9
        /// </summary>
        ColorTableWidthSgi = ((int)0x80D9),
        /// <summary>
        /// Original was GL_COLOR_TABLE_RED_SIZE = 0x80DA
        /// </summary>
        ColorTableRedSize = ((int)0x80DA),
        /// <summary>
        /// Original was GL_COLOR_TABLE_RED_SIZE_SGI = 0x80DA
        /// </summary>
        ColorTableRedSizeSgi = ((int)0x80DA),
        /// <summary>
        /// Original was GL_COLOR_TABLE_GREEN_SIZE = 0x80DB
        /// </summary>
        ColorTableGreenSize = ((int)0x80DB),
        /// <summary>
        /// Original was GL_COLOR_TABLE_GREEN_SIZE_SGI = 0x80DB
        /// </summary>
        ColorTableGreenSizeSgi = ((int)0x80DB),
        /// <summary>
        /// Original was GL_COLOR_TABLE_BLUE_SIZE = 0x80DC
        /// </summary>
        ColorTableBlueSize = ((int)0x80DC),
        /// <summary>
        /// Original was GL_COLOR_TABLE_BLUE_SIZE_SGI = 0x80DC
        /// </summary>
        ColorTableBlueSizeSgi = ((int)0x80DC),
        /// <summary>
        /// Original was GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD
        /// </summary>
        ColorTableAlphaSize = ((int)0x80DD),
        /// <summary>
        /// Original was GL_COLOR_TABLE_ALPHA_SIZE_SGI = 0x80DD
        /// </summary>
        ColorTableAlphaSizeSgi = ((int)0x80DD),
        /// <summary>
        /// Original was GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE
        /// </summary>
        ColorTableLuminanceSize = ((int)0x80DE),
        /// <summary>
        /// Original was GL_COLOR_TABLE_LUMINANCE_SIZE_SGI = 0x80DE
        /// </summary>
        ColorTableLuminanceSizeSgi = ((int)0x80DE),
        /// <summary>
        /// Original was GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF
        /// </summary>
        ColorTableIntensitySize = ((int)0x80DF),
        /// <summary>
        /// Original was GL_COLOR_TABLE_INTENSITY_SIZE_SGI = 0x80DF
        /// </summary>
        ColorTableIntensitySizeSgi = ((int)0x80DF),
        /// <summary>
        /// Original was GL_BGRA = 0x80E1
        /// </summary>
        Bgra = ((int)0x80E1),
        /// <summary>
        /// Original was GL_BGRA_EXT = 0x80E1
        /// </summary>
        BgraExt = ((int)0x80E1),
        /// <summary>
        /// Original was GL_BGRA_IMG = 0x80E1
        /// </summary>
        BgraImg = ((int)0x80E1),
        /// <summary>
        /// Original was GL_PHONG_HINT_WIN = 0x80EB
        /// </summary>
        PhongHintWin = ((int)0x80EB),
        /// <summary>
        /// Original was GL_CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0
        /// </summary>
        ClipVolumeClippingHintExt = ((int)0x80F0),
        /// <summary>
        /// Original was GL_DUAL_ALPHA4_SGIS = 0x8110
        /// </summary>
        DualAlpha4Sgis = ((int)0x8110),
        /// <summary>
        /// Original was GL_DUAL_ALPHA8_SGIS = 0x8111
        /// </summary>
        DualAlpha8Sgis = ((int)0x8111),
        /// <summary>
        /// Original was GL_DUAL_ALPHA12_SGIS = 0x8112
        /// </summary>
        DualAlpha12Sgis = ((int)0x8112),
        /// <summary>
        /// Original was GL_DUAL_ALPHA16_SGIS = 0x8113
        /// </summary>
        DualAlpha16Sgis = ((int)0x8113),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE4_SGIS = 0x8114
        /// </summary>
        DualLuminance4Sgis = ((int)0x8114),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE8_SGIS = 0x8115
        /// </summary>
        DualLuminance8Sgis = ((int)0x8115),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE12_SGIS = 0x8116
        /// </summary>
        DualLuminance12Sgis = ((int)0x8116),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE16_SGIS = 0x8117
        /// </summary>
        DualLuminance16Sgis = ((int)0x8117),
        /// <summary>
        /// Original was GL_DUAL_INTENSITY4_SGIS = 0x8118
        /// </summary>
        DualIntensity4Sgis = ((int)0x8118),
        /// <summary>
        /// Original was GL_DUAL_INTENSITY8_SGIS = 0x8119
        /// </summary>
        DualIntensity8Sgis = ((int)0x8119),
        /// <summary>
        /// Original was GL_DUAL_INTENSITY12_SGIS = 0x811A
        /// </summary>
        DualIntensity12Sgis = ((int)0x811A),
        /// <summary>
        /// Original was GL_DUAL_INTENSITY16_SGIS = 0x811B
        /// </summary>
        DualIntensity16Sgis = ((int)0x811B),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C
        /// </summary>
        DualLuminanceAlpha4Sgis = ((int)0x811C),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D
        /// </summary>
        DualLuminanceAlpha8Sgis = ((int)0x811D),
        /// <summary>
        /// Original was GL_QUAD_ALPHA4_SGIS = 0x811E
        /// </summary>
        QuadAlpha4Sgis = ((int)0x811E),
        /// <summary>
        /// Original was GL_QUAD_ALPHA8_SGIS = 0x811F
        /// </summary>
        QuadAlpha8Sgis = ((int)0x811F),
        /// <summary>
        /// Original was GL_QUAD_LUMINANCE4_SGIS = 0x8120
        /// </summary>
        QuadLuminance4Sgis = ((int)0x8120),
        /// <summary>
        /// Original was GL_QUAD_LUMINANCE8_SGIS = 0x8121
        /// </summary>
        QuadLuminance8Sgis = ((int)0x8121),
        /// <summary>
        /// Original was GL_QUAD_INTENSITY4_SGIS = 0x8122
        /// </summary>
        QuadIntensity4Sgis = ((int)0x8122),
        /// <summary>
        /// Original was GL_QUAD_INTENSITY8_SGIS = 0x8123
        /// </summary>
        QuadIntensity8Sgis = ((int)0x8123),
        /// <summary>
        /// Original was GL_DUAL_TEXTURE_SELECT_SGIS = 0x8124
        /// </summary>
        DualTextureSelectSgis = ((int)0x8124),
        /// <summary>
        /// Original was GL_QUAD_TEXTURE_SELECT_SGIS = 0x8125
        /// </summary>
        QuadTextureSelectSgis = ((int)0x8125),
        /// <summary>
        /// Original was GL_POINT_SIZE_MIN = 0x8126
        /// </summary>
        PointSizeMin = ((int)0x8126),
        /// <summary>
        /// Original was GL_POINT_SIZE_MIN_ARB = 0x8126
        /// </summary>
        PointSizeMinArb = ((int)0x8126),
        /// <summary>
        /// Original was GL_POINT_SIZE_MIN_EXT = 0x8126
        /// </summary>
        PointSizeMinExt = ((int)0x8126),
        /// <summary>
        /// Original was GL_POINT_SIZE_MIN_SGIS = 0x8126
        /// </summary>
        PointSizeMinSgis = ((int)0x8126),
        /// <summary>
        /// Original was GL_POINT_SIZE_MAX = 0x8127
        /// </summary>
        PointSizeMax = ((int)0x8127),
        /// <summary>
        /// Original was GL_POINT_SIZE_MAX_ARB = 0x8127
        /// </summary>
        PointSizeMaxArb = ((int)0x8127),
        /// <summary>
        /// Original was GL_POINT_SIZE_MAX_EXT = 0x8127
        /// </summary>
        PointSizeMaxExt = ((int)0x8127),
        /// <summary>
        /// Original was GL_POINT_SIZE_MAX_SGIS = 0x8127
        /// </summary>
        PointSizeMaxSgis = ((int)0x8127),
        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE = 0x8128
        /// </summary>
        PointFadeThresholdSize = ((int)0x8128),
        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128
        /// </summary>
        PointFadeThresholdSizeArb = ((int)0x8128),
        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128
        /// </summary>
        PointFadeThresholdSizeExt = ((int)0x8128),
        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128
        /// </summary>
        PointFadeThresholdSizeSgis = ((int)0x8128),
        /// <summary>
        /// Original was GL_DISTANCE_ATTENUATION_EXT = 0x8129
        /// </summary>
        DistanceAttenuationExt = ((int)0x8129),
        /// <summary>
        /// Original was GL_DISTANCE_ATTENUATION_SGIS = 0x8129
        /// </summary>
        DistanceAttenuationSgis = ((int)0x8129),
        /// <summary>
        /// Original was GL_POINT_DISTANCE_ATTENUATION = 0x8129
        /// </summary>
        PointDistanceAttenuation = ((int)0x8129),
        /// <summary>
        /// Original was GL_POINT_DISTANCE_ATTENUATION_ARB = 0x8129
        /// </summary>
        PointDistanceAttenuationArb = ((int)0x8129),
        /// <summary>
        /// Original was GL_FOG_FUNC_SGIS = 0x812A
        /// </summary>
        FogFuncSgis = ((int)0x812A),
        /// <summary>
        /// Original was GL_FOG_FUNC_POINTS_SGIS = 0x812B
        /// </summary>
        FogFuncPointsSgis = ((int)0x812B),
        /// <summary>
        /// Original was GL_MAX_FOG_FUNC_POINTS_SGIS = 0x812C
        /// </summary>
        MaxFogFuncPointsSgis = ((int)0x812C),
        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER = 0x812D
        /// </summary>
        ClampToBorder = ((int)0x812D),
        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER_ARB = 0x812D
        /// </summary>
        ClampToBorderArb = ((int)0x812D),
        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER_NV = 0x812D
        /// </summary>
        ClampToBorderNv = ((int)0x812D),
        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER_SGIS = 0x812D
        /// </summary>
        ClampToBorderSgis = ((int)0x812D),
        /// <summary>
        /// Original was GL_TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E
        /// </summary>
        TextureMultiBufferHintSgix = ((int)0x812E),
        /// <summary>
        /// Original was GL_CLAMP_TO_EDGE = 0x812F
        /// </summary>
        ClampToEdge = ((int)0x812F),
        /// <summary>
        /// Original was GL_CLAMP_TO_EDGE_SGIS = 0x812F
        /// </summary>
        ClampToEdgeSgis = ((int)0x812F),
        /// <summary>
        /// Original was GL_PACK_SKIP_VOLUMES_SGIS = 0x8130
        /// </summary>
        PackSkipVolumesSgis = ((int)0x8130),
        /// <summary>
        /// Original was GL_PACK_IMAGE_DEPTH_SGIS = 0x8131
        /// </summary>
        PackImageDepthSgis = ((int)0x8131),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_VOLUMES_SGIS = 0x8132
        /// </summary>
        UnpackSkipVolumesSgis = ((int)0x8132),
        /// <summary>
        /// Original was GL_UNPACK_IMAGE_DEPTH_SGIS = 0x8133
        /// </summary>
        UnpackImageDepthSgis = ((int)0x8133),
        /// <summary>
        /// Original was GL_TEXTURE_4D_SGIS = 0x8134
        /// </summary>
        Texture4DSgis = ((int)0x8134),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_4D_SGIS = 0x8135
        /// </summary>
        ProxyTexture4DSgis = ((int)0x8135),
        /// <summary>
        /// Original was GL_TEXTURE_4DSIZE_SGIS = 0x8136
        /// </summary>
        Texture4DsizeSgis = ((int)0x8136),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_Q_SGIS = 0x8137
        /// </summary>
        TextureWrapQSgis = ((int)0x8137),
        /// <summary>
        /// Original was GL_MAX_4D_TEXTURE_SIZE_SGIS = 0x8138
        /// </summary>
        Max4DTextureSizeSgis = ((int)0x8138),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_SGIX = 0x8139
        /// </summary>
        PixelTexGenSgix = ((int)0x8139),
        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD = 0x813A
        /// </summary>
        TextureMinLod = ((int)0x813A),
        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD_SGIS = 0x813A
        /// </summary>
        TextureMinLodSgis = ((int)0x813A),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD = 0x813B
        /// </summary>
        TextureMaxLod = ((int)0x813B),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD_SGIS = 0x813B
        /// </summary>
        TextureMaxLodSgis = ((int)0x813B),
        /// <summary>
        /// Original was GL_TEXTURE_BASE_LEVEL = 0x813C
        /// </summary>
        TextureBaseLevel = ((int)0x813C),
        /// <summary>
        /// Original was GL_TEXTURE_BASE_LEVEL_SGIS = 0x813C
        /// </summary>
        TextureBaseLevelSgis = ((int)0x813C),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL = 0x813D
        /// </summary>
        TextureMaxLevel = ((int)0x813D),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL_APPLE = 0x813D
        /// </summary>
        TextureMaxLevelApple = ((int)0x813D),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL_SGIS = 0x813D
        /// </summary>
        TextureMaxLevelSgis = ((int)0x813D),
        /// <summary>
        /// Original was GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E
        /// </summary>
        PixelTileBestAlignmentSgix = ((int)0x813E),
        /// <summary>
        /// Original was GL_PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F
        /// </summary>
        PixelTileCacheIncrementSgix = ((int)0x813F),
        /// <summary>
        /// Original was GL_PIXEL_TILE_WIDTH_SGIX = 0x8140
        /// </summary>
        PixelTileWidthSgix = ((int)0x8140),
        /// <summary>
        /// Original was GL_PIXEL_TILE_HEIGHT_SGIX = 0x8141
        /// </summary>
        PixelTileHeightSgix = ((int)0x8141),
        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142
        /// </summary>
        PixelTileGridWidthSgix = ((int)0x8142),
        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143
        /// </summary>
        PixelTileGridHeightSgix = ((int)0x8143),
        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144
        /// </summary>
        PixelTileGridDepthSgix = ((int)0x8144),
        /// <summary>
        /// Original was GL_PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145
        /// </summary>
        PixelTileCacheSizeSgix = ((int)0x8145),
        /// <summary>
        /// Original was GL_FILTER4_SGIS = 0x8146
        /// </summary>
        Filter4Sgis = ((int)0x8146),
        /// <summary>
        /// Original was GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147
        /// </summary>
        TextureFilter4SizeSgis = ((int)0x8147),
        /// <summary>
        /// Original was GL_SPRITE_SGIX = 0x8148
        /// </summary>
        SpriteSgix = ((int)0x8148),
        /// <summary>
        /// Original was GL_SPRITE_MODE_SGIX = 0x8149
        /// </summary>
        SpriteModeSgix = ((int)0x8149),
        /// <summary>
        /// Original was GL_SPRITE_AXIS_SGIX = 0x814A
        /// </summary>
        SpriteAxisSgix = ((int)0x814A),
        /// <summary>
        /// Original was GL_SPRITE_TRANSLATION_SGIX = 0x814B
        /// </summary>
        SpriteTranslationSgix = ((int)0x814B),
        /// <summary>
        /// Original was GL_TEXTURE_4D_BINDING_SGIS = 0x814F
        /// </summary>
        Texture4DBindingSgis = ((int)0x814F),
        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_COLOR = 0x8154
        /// </summary>
        ConvolutionBorderColor = ((int)0x8154),
        /// <summary>
        /// Original was GL_LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170
        /// </summary>
        LinearClipmapLinearSgix = ((int)0x8170),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171
        /// </summary>
        TextureClipmapCenterSgix = ((int)0x8171),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172
        /// </summary>
        TextureClipmapFrameSgix = ((int)0x8172),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173
        /// </summary>
        TextureClipmapOffsetSgix = ((int)0x8173),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174
        /// </summary>
        TextureClipmapVirtualDepthSgix = ((int)0x8174),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175
        /// </summary>
        TextureClipmapLodOffsetSgix = ((int)0x8175),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176
        /// </summary>
        TextureClipmapDepthSgix = ((int)0x8176),
        /// <summary>
        /// Original was GL_MAX_CLIPMAP_DEPTH_SGIX = 0x8177
        /// </summary>
        MaxClipmapDepthSgix = ((int)0x8177),
        /// <summary>
        /// Original was GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178
        /// </summary>
        MaxClipmapVirtualDepthSgix = ((int)0x8178),
        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179
        /// </summary>
        PostTextureFilterBiasSgix = ((int)0x8179),
        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A
        /// </summary>
        PostTextureFilterScaleSgix = ((int)0x817A),
        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B
        /// </summary>
        PostTextureFilterBiasRangeSgix = ((int)0x817B),
        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C
        /// </summary>
        PostTextureFilterScaleRangeSgix = ((int)0x817C),
        /// <summary>
        /// Original was GL_REFERENCE_PLANE_SGIX = 0x817D
        /// </summary>
        ReferencePlaneSgix = ((int)0x817D),
        /// <summary>
        /// Original was GL_REFERENCE_PLANE_EQUATION_SGIX = 0x817E
        /// </summary>
        ReferencePlaneEquationSgix = ((int)0x817E),
        /// <summary>
        /// Original was GL_IR_INSTRUMENT1_SGIX = 0x817F
        /// </summary>
        IrInstrument1Sgix = ((int)0x817F),
        /// <summary>
        /// Original was GL_INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180
        /// </summary>
        InstrumentBufferPointerSgix = ((int)0x8180),
        /// <summary>
        /// Original was GL_INSTRUMENT_MEASUREMENTS_SGIX = 0x8181
        /// </summary>
        InstrumentMeasurementsSgix = ((int)0x8181),
        /// <summary>
        /// Original was GL_LIST_PRIORITY_SGIX = 0x8182
        /// </summary>
        ListPrioritySgix = ((int)0x8182),
        /// <summary>
        /// Original was GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183
        /// </summary>
        CalligraphicFragmentSgix = ((int)0x8183),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184
        /// </summary>
        PixelTexGenQCeilingSgix = ((int)0x8184),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185
        /// </summary>
        PixelTexGenQRoundSgix = ((int)0x8185),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186
        /// </summary>
        PixelTexGenQFloorSgix = ((int)0x8186),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX = 0x8187
        /// </summary>
        PixelTexGenAlphaReplaceSgix = ((int)0x8187),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX = 0x8188
        /// </summary>
        PixelTexGenAlphaNoReplaceSgix = ((int)0x8188),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_ALPHA_LS_SGIX = 0x8189
        /// </summary>
        PixelTexGenAlphaLsSgix = ((int)0x8189),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_ALPHA_MS_SGIX = 0x818A
        /// </summary>
        PixelTexGenAlphaMsSgix = ((int)0x818A),
        /// <summary>
        /// Original was GL_FRAMEZOOM_SGIX = 0x818B
        /// </summary>
        FramezoomSgix = ((int)0x818B),
        /// <summary>
        /// Original was GL_FRAMEZOOM_FACTOR_SGIX = 0x818C
        /// </summary>
        FramezoomFactorSgix = ((int)0x818C),
        /// <summary>
        /// Original was GL_MAX_FRAMEZOOM_FACTOR_SGIX = 0x818D
        /// </summary>
        MaxFramezoomFactorSgix = ((int)0x818D),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_S_SGIX = 0x818E
        /// </summary>
        TextureLodBiasSSgix = ((int)0x818E),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_T_SGIX = 0x818F
        /// </summary>
        TextureLodBiasTSgix = ((int)0x818F),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_R_SGIX = 0x8190
        /// </summary>
        TextureLodBiasRSgix = ((int)0x8190),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP = 0x8191
        /// </summary>
        GenerateMipmap = ((int)0x8191),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_SGIS = 0x8191
        /// </summary>
        GenerateMipmapSgis = ((int)0x8191),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT = 0x8192
        /// </summary>
        GenerateMipmapHint = ((int)0x8192),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192
        /// </summary>
        GenerateMipmapHintSgis = ((int)0x8192),
        /// <summary>
        /// Original was GL_GEOMETRY_DEFORMATION_SGIX = 0x8194
        /// </summary>
        GeometryDeformationSgix = ((int)0x8194),
        /// <summary>
        /// Original was GL_TEXTURE_DEFORMATION_SGIX = 0x8195
        /// </summary>
        TextureDeformationSgix = ((int)0x8195),
        /// <summary>
        /// Original was GL_DEFORMATIONS_MASK_SGIX = 0x8196
        /// </summary>
        DeformationsMaskSgix = ((int)0x8196),
        /// <summary>
        /// Original was GL_FOG_OFFSET_SGIX = 0x8198
        /// </summary>
        FogOffsetSgix = ((int)0x8198),
        /// <summary>
        /// Original was GL_FOG_OFFSET_VALUE_SGIX = 0x8199
        /// </summary>
        FogOffsetValueSgix = ((int)0x8199),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_SGIX = 0x819A
        /// </summary>
        TextureCompareSgix = ((int)0x819A),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B
        /// </summary>
        TextureCompareOperatorSgix = ((int)0x819B),
        /// <summary>
        /// Original was GL_TEXTURE_LEQUAL_R_SGIX = 0x819C
        /// </summary>
        TextureLequalRSgix = ((int)0x819C),
        /// <summary>
        /// Original was GL_TEXTURE_GEQUAL_R_SGIX = 0x819D
        /// </summary>
        TextureGequalRSgix = ((int)0x819D),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16 = 0x81A5
        /// </summary>
        DepthComponent16 = ((int)0x81A5),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_ARB = 0x81A5
        /// </summary>
        DepthComponent16Arb = ((int)0x81A5),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_OES = 0x81A5
        /// </summary>
        DepthComponent16Oes = ((int)0x81A5),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_SGIX = 0x81A5
        /// </summary>
        DepthComponent16Sgix = ((int)0x81A5),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_ARB = 0x81A6
        /// </summary>
        DepthComponent24Arb = ((int)0x81A6),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_OES = 0x81A6
        /// </summary>
        DepthComponent24Oes = ((int)0x81A6),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_SGIX = 0x81A6
        /// </summary>
        DepthComponent24Sgix = ((int)0x81A6),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_ARB = 0x81A7
        /// </summary>
        DepthComponent32Arb = ((int)0x81A7),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        /// </summary>
        DepthComponent32Oes = ((int)0x81A7),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_SGIX = 0x81A7
        /// </summary>
        DepthComponent32Sgix = ((int)0x81A7),
        /// <summary>
        /// Original was GL_YCRCB_422_SGIX = 0x81BB
        /// </summary>
        Ycrcb422Sgix = ((int)0x81BB),
        /// <summary>
        /// Original was GL_YCRCB_444_SGIX = 0x81BC
        /// </summary>
        Ycrcb444Sgix = ((int)0x81BC),
        /// <summary>
        /// Original was GL_EYE_DISTANCE_TO_POINT_SGIS = 0x81F0
        /// </summary>
        EyeDistanceToPointSgis = ((int)0x81F0),
        /// <summary>
        /// Original was GL_OBJECT_DISTANCE_TO_POINT_SGIS = 0x81F1
        /// </summary>
        ObjectDistanceToPointSgis = ((int)0x81F1),
        /// <summary>
        /// Original was GL_EYE_DISTANCE_TO_LINE_SGIS = 0x81F2
        /// </summary>
        EyeDistanceToLineSgis = ((int)0x81F2),
        /// <summary>
        /// Original was GL_OBJECT_DISTANCE_TO_LINE_SGIS = 0x81F3
        /// </summary>
        ObjectDistanceToLineSgis = ((int)0x81F3),
        /// <summary>
        /// Original was GL_EYE_POINT_SGIS = 0x81F4
        /// </summary>
        EyePointSgis = ((int)0x81F4),
        /// <summary>
        /// Original was GL_OBJECT_POINT_SGIS = 0x81F5
        /// </summary>
        ObjectPointSgis = ((int)0x81F5),
        /// <summary>
        /// Original was GL_EYE_LINE_SGIS = 0x81F6
        /// </summary>
        EyeLineSgis = ((int)0x81F6),
        /// <summary>
        /// Original was GL_OBJECT_LINE_SGIS = 0x81F7
        /// </summary>
        ObjectLineSgis = ((int)0x81F7),
        /// <summary>
        /// Original was GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8
        /// </summary>
        LightModelColorControl = ((int)0x81F8),
        /// <summary>
        /// Original was GL_LIGHT_MODEL_COLOR_CONTROL_EXT = 0x81F8
        /// </summary>
        LightModelColorControlExt = ((int)0x81F8),
        /// <summary>
        /// Original was GL_SINGLE_COLOR = 0x81F9
        /// </summary>
        SingleColor = ((int)0x81F9),
        /// <summary>
        /// Original was GL_SINGLE_COLOR_EXT = 0x81F9
        /// </summary>
        SingleColorExt = ((int)0x81F9),
        /// <summary>
        /// Original was GL_SEPARATE_SPECULAR_COLOR = 0x81FA
        /// </summary>
        SeparateSpecularColor = ((int)0x81FA),
        /// <summary>
        /// Original was GL_SEPARATE_SPECULAR_COLOR_EXT = 0x81FA
        /// </summary>
        SeparateSpecularColorExt = ((int)0x81FA),
        /// <summary>
        /// Original was GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB
        /// </summary>
        SharedTexturePaletteExt = ((int)0x81FB),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210
        /// </summary>
        FramebufferAttachmentColorEncoding = ((int)0x8210),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT = 0x8210
        /// </summary>
        FramebufferAttachmentColorEncodingExt = ((int)0x8210),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211
        /// </summary>
        FramebufferAttachmentComponentType = ((int)0x8211),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212
        /// </summary>
        FramebufferAttachmentRedSize = ((int)0x8212),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213
        /// </summary>
        FramebufferAttachmentGreenSize = ((int)0x8213),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214
        /// </summary>
        FramebufferAttachmentBlueSize = ((int)0x8214),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215
        /// </summary>
        FramebufferAttachmentAlphaSize = ((int)0x8215),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216
        /// </summary>
        FramebufferAttachmentDepthSize = ((int)0x8216),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217
        /// </summary>
        FramebufferAttachmentStencilSize = ((int)0x8217),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNDEFINED = 0x8219
        /// </summary>
        FramebufferUndefined = ((int)0x8219),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNDEFINED_OES = 0x8219
        /// </summary>
        FramebufferUndefinedOes = ((int)0x8219),
        /// <summary>
        /// Original was GL_BUFFER_IMMUTABLE_STORAGE = 0x821F
        /// </summary>
        BufferImmutableStorage = ((int)0x821F),
        /// <summary>
        /// Original was GL_BUFFER_STORAGE_FLAGS = 0x8220
        /// </summary>
        BufferStorageFlags = ((int)0x8220),
        /// <summary>
        /// Original was GL_COMPRESSED_RED = 0x8225
        /// </summary>
        CompressedRed = ((int)0x8225),
        /// <summary>
        /// Original was GL_COMPRESSED_RG = 0x8226
        /// </summary>
        CompressedRg = ((int)0x8226),
        /// <summary>
        /// Original was GL_RG = 0x8227
        /// </summary>
        Rg = ((int)0x8227),
        /// <summary>
        /// Original was GL_R8 = 0x8229
        /// </summary>
        R8 = ((int)0x8229),
        /// <summary>
        /// Original was GL_R8_EXT = 0x8229
        /// </summary>
        R8Ext = ((int)0x8229),
        /// <summary>
        /// Original was GL_R16 = 0x822A
        /// </summary>
        R16 = ((int)0x822A),
        /// <summary>
        /// Original was GL_R16_EXT = 0x822A
        /// </summary>
        R16Ext = ((int)0x822A),
        /// <summary>
        /// Original was GL_RG8 = 0x822B
        /// </summary>
        Rg8 = ((int)0x822B),
        /// <summary>
        /// Original was GL_RG8_EXT = 0x822B
        /// </summary>
        Rg8Ext = ((int)0x822B),
        /// <summary>
        /// Original was GL_RG16 = 0x822C
        /// </summary>
        Rg16 = ((int)0x822C),
        /// <summary>
        /// Original was GL_RG16_EXT = 0x822C
        /// </summary>
        Rg16Ext = ((int)0x822C),
        /// <summary>
        /// Original was GL_R16F = 0x822D
        /// </summary>
        R16f = ((int)0x822D),
        /// <summary>
        /// Original was GL_R16F_EXT = 0x822D
        /// </summary>
        R16fExt = ((int)0x822D),
        /// <summary>
        /// Original was GL_R32F = 0x822E
        /// </summary>
        R32f = ((int)0x822E),
        /// <summary>
        /// Original was GL_R32F_EXT = 0x822E
        /// </summary>
        R32fExt = ((int)0x822E),
        /// <summary>
        /// Original was GL_RG16F = 0x822F
        /// </summary>
        Rg16f = ((int)0x822F),
        /// <summary>
        /// Original was GL_RG16F_EXT = 0x822F
        /// </summary>
        Rg16fExt = ((int)0x822F),
        /// <summary>
        /// Original was GL_RG32F = 0x8230
        /// </summary>
        Rg32f = ((int)0x8230),
        /// <summary>
        /// Original was GL_RG32F_EXT = 0x8230
        /// </summary>
        Rg32fExt = ((int)0x8230),
        /// <summary>
        /// Original was GL_R8I = 0x8231
        /// </summary>
        R8i = ((int)0x8231),
        /// <summary>
        /// Original was GL_R8UI = 0x8232
        /// </summary>
        R8ui = ((int)0x8232),
        /// <summary>
        /// Original was GL_R16I = 0x8233
        /// </summary>
        R16i = ((int)0x8233),
        /// <summary>
        /// Original was GL_R16UI = 0x8234
        /// </summary>
        R16ui = ((int)0x8234),
        /// <summary>
        /// Original was GL_R32I = 0x8235
        /// </summary>
        R32i = ((int)0x8235),
        /// <summary>
        /// Original was GL_R32UI = 0x8236
        /// </summary>
        R32ui = ((int)0x8236),
        /// <summary>
        /// Original was GL_RG8I = 0x8237
        /// </summary>
        Rg8i = ((int)0x8237),
        /// <summary>
        /// Original was GL_RG8UI = 0x8238
        /// </summary>
        Rg8ui = ((int)0x8238),
        /// <summary>
        /// Original was GL_RG16I = 0x8239
        /// </summary>
        Rg16i = ((int)0x8239),
        /// <summary>
        /// Original was GL_RG16UI = 0x823A
        /// </summary>
        Rg16ui = ((int)0x823A),
        /// <summary>
        /// Original was GL_RG32I = 0x823B
        /// </summary>
        Rg32i = ((int)0x823B),
        /// <summary>
        /// Original was GL_RG32UI = 0x823C
        /// </summary>
        Rg32ui = ((int)0x823C),
        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242
        /// </summary>
        DebugOutputSynchronous = ((int)0x8242),
        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_SYNCHRONOUS_KHR = 0x8242
        /// </summary>
        DebugOutputSynchronousKhr = ((int)0x8242),
        /// <summary>
        /// Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243
        /// </summary>
        DebugNextLoggedMessageLength = ((int)0x8243),
        /// <summary>
        /// Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_KHR = 0x8243
        /// </summary>
        DebugNextLoggedMessageLengthKhr = ((int)0x8243),
        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_FUNCTION = 0x8244
        /// </summary>
        DebugCallbackFunction = ((int)0x8244),
        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_FUNCTION_KHR = 0x8244
        /// </summary>
        DebugCallbackFunctionKhr = ((int)0x8244),
        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_USER_PARAM = 0x8245
        /// </summary>
        DebugCallbackUserParam = ((int)0x8245),
        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_USER_PARAM_KHR = 0x8245
        /// </summary>
        DebugCallbackUserParamKhr = ((int)0x8245),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_API = 0x8246
        /// </summary>
        DebugSourceApi = ((int)0x8246),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_API_KHR = 0x8246
        /// </summary>
        DebugSourceApiKhr = ((int)0x8246),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247
        /// </summary>
        DebugSourceWindowSystem = ((int)0x8247),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM_KHR = 0x8247
        /// </summary>
        DebugSourceWindowSystemKhr = ((int)0x8247),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248
        /// </summary>
        DebugSourceShaderCompiler = ((int)0x8248),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_SHADER_COMPILER_KHR = 0x8248
        /// </summary>
        DebugSourceShaderCompilerKhr = ((int)0x8248),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249
        /// </summary>
        DebugSourceThirdParty = ((int)0x8249),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_THIRD_PARTY_KHR = 0x8249
        /// </summary>
        DebugSourceThirdPartyKhr = ((int)0x8249),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_APPLICATION = 0x824A
        /// </summary>
        DebugSourceApplication = ((int)0x824A),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_APPLICATION_KHR = 0x824A
        /// </summary>
        DebugSourceApplicationKhr = ((int)0x824A),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_OTHER = 0x824B
        /// </summary>
        DebugSourceOther = ((int)0x824B),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_OTHER_KHR = 0x824B
        /// </summary>
        DebugSourceOtherKhr = ((int)0x824B),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_ERROR = 0x824C
        /// </summary>
        DebugTypeError = ((int)0x824C),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_ERROR_KHR = 0x824C
        /// </summary>
        DebugTypeErrorKhr = ((int)0x824C),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D
        /// </summary>
        DebugTypeDeprecatedBehavior = ((int)0x824D),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_KHR = 0x824D
        /// </summary>
        DebugTypeDeprecatedBehaviorKhr = ((int)0x824D),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E
        /// </summary>
        DebugTypeUndefinedBehavior = ((int)0x824E),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_KHR = 0x824E
        /// </summary>
        DebugTypeUndefinedBehaviorKhr = ((int)0x824E),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_PORTABILITY = 0x824F
        /// </summary>
        DebugTypePortability = ((int)0x824F),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_PORTABILITY_KHR = 0x824F
        /// </summary>
        DebugTypePortabilityKhr = ((int)0x824F),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_PERFORMANCE = 0x8250
        /// </summary>
        DebugTypePerformance = ((int)0x8250),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_PERFORMANCE_KHR = 0x8250
        /// </summary>
        DebugTypePerformanceKhr = ((int)0x8250),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_OTHER = 0x8251
        /// </summary>
        DebugTypeOther = ((int)0x8251),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_OTHER_KHR = 0x8251
        /// </summary>
        DebugTypeOtherKhr = ((int)0x8251),
        /// <summary>
        /// Original was GL_LOSE_CONTEXT_ON_RESET_EXT = 0x8252
        /// </summary>
        LoseContextOnResetExt = ((int)0x8252),
        /// <summary>
        /// Original was GL_GUILTY_CONTEXT_RESET = 0x8253
        /// </summary>
        GuiltyContextReset = ((int)0x8253),
        /// <summary>
        /// Original was GL_GUILTY_CONTEXT_RESET_EXT = 0x8253
        /// </summary>
        GuiltyContextResetExt = ((int)0x8253),
        /// <summary>
        /// Original was GL_INNOCENT_CONTEXT_RESET = 0x8254
        /// </summary>
        InnocentContextReset = ((int)0x8254),
        /// <summary>
        /// Original was GL_INNOCENT_CONTEXT_RESET_EXT = 0x8254
        /// </summary>
        InnocentContextResetExt = ((int)0x8254),
        /// <summary>
        /// Original was GL_UNKNOWN_CONTEXT_RESET = 0x8255
        /// </summary>
        UnknownContextReset = ((int)0x8255),
        /// <summary>
        /// Original was GL_UNKNOWN_CONTEXT_RESET_EXT = 0x8255
        /// </summary>
        UnknownContextResetExt = ((int)0x8255),
        /// <summary>
        /// Original was GL_RESET_NOTIFICATION_STRATEGY_EXT = 0x8256
        /// </summary>
        ResetNotificationStrategyExt = ((int)0x8256),
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
        /// </summary>
        ProgramBinaryRetrievableHint = ((int)0x8257),
        /// <summary>
        /// Original was GL_PROGRAM_SEPARABLE = 0x8258
        /// </summary>
        ProgramSeparable = ((int)0x8258),
        /// <summary>
        /// Original was GL_ACTIVE_PROGRAM = 0x8259
        /// </summary>
        ActiveProgram = ((int)0x8259),
        /// <summary>
        /// Original was GL_NO_RESET_NOTIFICATION_EXT = 0x8261
        /// </summary>
        NoResetNotificationExt = ((int)0x8261),
        /// <summary>
        /// Original was GL_COMPUTE_WORK_GROUP_SIZE = 0x8267
        /// </summary>
        ComputeWorkGroupSize = ((int)0x8267),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_MARKER = 0x8268
        /// </summary>
        DebugTypeMarker = ((int)0x8268),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_MARKER_KHR = 0x8268
        /// </summary>
        DebugTypeMarkerKhr = ((int)0x8268),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_PUSH_GROUP = 0x8269
        /// </summary>
        DebugTypePushGroup = ((int)0x8269),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_PUSH_GROUP_KHR = 0x8269
        /// </summary>
        DebugTypePushGroupKhr = ((int)0x8269),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_POP_GROUP = 0x826A
        /// </summary>
        DebugTypePopGroup = ((int)0x826A),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_POP_GROUP_KHR = 0x826A
        /// </summary>
        DebugTypePopGroupKhr = ((int)0x826A),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B
        /// </summary>
        DebugSeverityNotification = ((int)0x826B),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_NOTIFICATION_KHR = 0x826B
        /// </summary>
        DebugSeverityNotificationKhr = ((int)0x826B),
        /// <summary>
        /// Original was GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C
        /// </summary>
        MaxDebugGroupStackDepth = ((int)0x826C),
        /// <summary>
        /// Original was GL_MAX_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826C
        /// </summary>
        MaxDebugGroupStackDepthKhr = ((int)0x826C),
        /// <summary>
        /// Original was GL_DEBUG_GROUP_STACK_DEPTH = 0x826D
        /// </summary>
        DebugGroupStackDepth = ((int)0x826D),
        /// <summary>
        /// Original was GL_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826D
        /// </summary>
        DebugGroupStackDepthKhr = ((int)0x826D),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_SUPPORTED = 0x826F
        /// </summary>
        InternalformatSupported = ((int)0x826F),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_PREFERRED = 0x8270
        /// </summary>
        InternalformatPreferred = ((int)0x8270),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_RED_SIZE = 0x8271
        /// </summary>
        InternalformatRedSize = ((int)0x8271),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_GREEN_SIZE = 0x8272
        /// </summary>
        InternalformatGreenSize = ((int)0x8272),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_BLUE_SIZE = 0x8273
        /// </summary>
        InternalformatBlueSize = ((int)0x8273),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274
        /// </summary>
        InternalformatAlphaSize = ((int)0x8274),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275
        /// </summary>
        InternalformatDepthSize = ((int)0x8275),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276
        /// </summary>
        InternalformatStencilSize = ((int)0x8276),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_SHARED_SIZE = 0x8277
        /// </summary>
        InternalformatSharedSize = ((int)0x8277),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_RED_TYPE = 0x8278
        /// </summary>
        InternalformatRedType = ((int)0x8278),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_GREEN_TYPE = 0x8279
        /// </summary>
        InternalformatGreenType = ((int)0x8279),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_BLUE_TYPE = 0x827A
        /// </summary>
        InternalformatBlueType = ((int)0x827A),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B
        /// </summary>
        InternalformatAlphaType = ((int)0x827B),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C
        /// </summary>
        InternalformatDepthType = ((int)0x827C),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D
        /// </summary>
        InternalformatStencilType = ((int)0x827D),
        /// <summary>
        /// Original was GL_MAX_WIDTH = 0x827E
        /// </summary>
        MaxWidth = ((int)0x827E),
        /// <summary>
        /// Original was GL_MAX_HEIGHT = 0x827F
        /// </summary>
        MaxHeight = ((int)0x827F),
        /// <summary>
        /// Original was GL_MAX_DEPTH = 0x8280
        /// </summary>
        MaxDepth = ((int)0x8280),
        /// <summary>
        /// Original was GL_MAX_LAYERS = 0x8281
        /// </summary>
        MaxLayers = ((int)0x8281),
        /// <summary>
        /// Original was GL_COLOR_COMPONENTS = 0x8283
        /// </summary>
        ColorComponents = ((int)0x8283),
        /// <summary>
        /// Original was GL_COLOR_RENDERABLE = 0x8286
        /// </summary>
        ColorRenderable = ((int)0x8286),
        /// <summary>
        /// Original was GL_DEPTH_RENDERABLE = 0x8287
        /// </summary>
        DepthRenderable = ((int)0x8287),
        /// <summary>
        /// Original was GL_STENCIL_RENDERABLE = 0x8288
        /// </summary>
        StencilRenderable = ((int)0x8288),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_RENDERABLE = 0x8289
        /// </summary>
        FramebufferRenderable = ((int)0x8289),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A
        /// </summary>
        FramebufferRenderableLayered = ((int)0x828A),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_BLEND = 0x828B
        /// </summary>
        FramebufferBlend = ((int)0x828B),
        /// <summary>
        /// Original was GL_READ_PIXELS = 0x828C
        /// </summary>
        ReadPixels = ((int)0x828C),
        /// <summary>
        /// Original was GL_READ_PIXELS_FORMAT = 0x828D
        /// </summary>
        ReadPixelsFormat = ((int)0x828D),
        /// <summary>
        /// Original was GL_READ_PIXELS_TYPE = 0x828E
        /// </summary>
        ReadPixelsType = ((int)0x828E),
        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_FORMAT = 0x828F
        /// </summary>
        TextureImageFormat = ((int)0x828F),
        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_TYPE = 0x8290
        /// </summary>
        TextureImageType = ((int)0x8290),
        /// <summary>
        /// Original was GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291
        /// </summary>
        GetTextureImageFormat = ((int)0x8291),
        /// <summary>
        /// Original was GL_GET_TEXTURE_IMAGE_TYPE = 0x8292
        /// </summary>
        GetTextureImageType = ((int)0x8292),
        /// <summary>
        /// Original was GL_MIPMAP = 0x8293
        /// </summary>
        Mipmap = ((int)0x8293),
        /// <summary>
        /// Original was GL_AUTO_GENERATE_MIPMAP = 0x8295
        /// </summary>
        AutoGenerateMipmap = ((int)0x8295),
        /// <summary>
        /// Original was GL_COLOR_ENCODING = 0x8296
        /// </summary>
        ColorEncoding = ((int)0x8296),
        /// <summary>
        /// Original was GL_SRGB_READ = 0x8297
        /// </summary>
        SrgbRead = ((int)0x8297),
        /// <summary>
        /// Original was GL_SRGB_WRITE = 0x8298
        /// </summary>
        SrgbWrite = ((int)0x8298),
        /// <summary>
        /// Original was GL_FILTER = 0x829A
        /// </summary>
        Filter = ((int)0x829A),
        /// <summary>
        /// Original was GL_VERTEX_TEXTURE = 0x829B
        /// </summary>
        VertexTexture = ((int)0x829B),
        /// <summary>
        /// Original was GL_TESS_CONTROL_TEXTURE = 0x829C
        /// </summary>
        TessControlTexture = ((int)0x829C),
        /// <summary>
        /// Original was GL_TESS_EVALUATION_TEXTURE = 0x829D
        /// </summary>
        TessEvaluationTexture = ((int)0x829D),
        /// <summary>
        /// Original was GL_GEOMETRY_TEXTURE = 0x829E
        /// </summary>
        GeometryTexture = ((int)0x829E),
        /// <summary>
        /// Original was GL_FRAGMENT_TEXTURE = 0x829F
        /// </summary>
        FragmentTexture = ((int)0x829F),
        /// <summary>
        /// Original was GL_COMPUTE_TEXTURE = 0x82A0
        /// </summary>
        ComputeTexture = ((int)0x82A0),
        /// <summary>
        /// Original was GL_TEXTURE_SHADOW = 0x82A1
        /// </summary>
        TextureShadow = ((int)0x82A1),
        /// <summary>
        /// Original was GL_TEXTURE_GATHER = 0x82A2
        /// </summary>
        TextureGather = ((int)0x82A2),
        /// <summary>
        /// Original was GL_TEXTURE_GATHER_SHADOW = 0x82A3
        /// </summary>
        TextureGatherShadow = ((int)0x82A3),
        /// <summary>
        /// Original was GL_SHADER_IMAGE_LOAD = 0x82A4
        /// </summary>
        ShaderImageLoad = ((int)0x82A4),
        /// <summary>
        /// Original was GL_SHADER_IMAGE_STORE = 0x82A5
        /// </summary>
        ShaderImageStore = ((int)0x82A5),
        /// <summary>
        /// Original was GL_SHADER_IMAGE_ATOMIC = 0x82A6
        /// </summary>
        ShaderImageAtomic = ((int)0x82A6),
        /// <summary>
        /// Original was GL_IMAGE_TEXEL_SIZE = 0x82A7
        /// </summary>
        ImageTexelSize = ((int)0x82A7),
        /// <summary>
        /// Original was GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8
        /// </summary>
        ImageCompatibilityClass = ((int)0x82A8),
        /// <summary>
        /// Original was GL_IMAGE_PIXEL_FORMAT = 0x82A9
        /// </summary>
        ImagePixelFormat = ((int)0x82A9),
        /// <summary>
        /// Original was GL_IMAGE_PIXEL_TYPE = 0x82AA
        /// </summary>
        ImagePixelType = ((int)0x82AA),
        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC
        /// </summary>
        SimultaneousTextureAndDepthTest = ((int)0x82AC),
        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD
        /// </summary>
        SimultaneousTextureAndStencilTest = ((int)0x82AD),
        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE
        /// </summary>
        SimultaneousTextureAndDepthWrite = ((int)0x82AE),
        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF
        /// </summary>
        SimultaneousTextureAndStencilWrite = ((int)0x82AF),
        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1
        /// </summary>
        TextureCompressedBlockWidth = ((int)0x82B1),
        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2
        /// </summary>
        TextureCompressedBlockHeight = ((int)0x82B2),
        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3
        /// </summary>
        TextureCompressedBlockSize = ((int)0x82B3),
        /// <summary>
        /// Original was GL_CLEAR_BUFFER = 0x82B4
        /// </summary>
        ClearBuffer = ((int)0x82B4),
        /// <summary>
        /// Original was GL_TEXTURE_VIEW = 0x82B5
        /// </summary>
        TextureView = ((int)0x82B5),
        /// <summary>
        /// Original was GL_VIEW_COMPATIBILITY_CLASS = 0x82B6
        /// </summary>
        ViewCompatibilityClass = ((int)0x82B6),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5
        /// </summary>
        VertexAttribRelativeOffset = ((int)0x82D5),
        /// <summary>
        /// Original was GL_BUFFER = 0x82E0
        /// </summary>
        Buffer = ((int)0x82E0),
        /// <summary>
        /// Original was GL_BUFFER_KHR = 0x82E0
        /// </summary>
        BufferKhr = ((int)0x82E0),
        /// <summary>
        /// Original was GL_SHADER = 0x82E1
        /// </summary>
        Shader = ((int)0x82E1),
        /// <summary>
        /// Original was GL_SHADER_KHR = 0x82E1
        /// </summary>
        ShaderKhr = ((int)0x82E1),
        /// <summary>
        /// Original was GL_PROGRAM = 0x82E2
        /// </summary>
        Program = ((int)0x82E2),
        /// <summary>
        /// Original was GL_PROGRAM_KHR = 0x82E2
        /// </summary>
        ProgramKhr = ((int)0x82E2),
        /// <summary>
        /// Original was GL_QUERY = 0x82E3
        /// </summary>
        Query = ((int)0x82E3),
        /// <summary>
        /// Original was GL_QUERY_KHR = 0x82E3
        /// </summary>
        QueryKhr = ((int)0x82E3),
        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE = 0x82E4
        /// </summary>
        ProgramPipeline = ((int)0x82E4),
        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE_KHR = 0x82E4
        /// </summary>
        ProgramPipelineKhr = ((int)0x82E4),
        /// <summary>
        /// Original was GL_SAMPLER = 0x82E6
        /// </summary>
        Sampler = ((int)0x82E6),
        /// <summary>
        /// Original was GL_SAMPLER_KHR = 0x82E6
        /// </summary>
        SamplerKhr = ((int)0x82E6),
        /// <summary>
        /// Original was GL_DISPLAY_LIST = 0x82E7
        /// </summary>
        DisplayList = ((int)0x82E7),
        /// <summary>
        /// Original was GL_MAX_LABEL_LENGTH = 0x82E8
        /// </summary>
        MaxLabelLength = ((int)0x82E8),
        /// <summary>
        /// Original was GL_MAX_LABEL_LENGTH_KHR = 0x82E8
        /// </summary>
        MaxLabelLengthKhr = ((int)0x82E8),
        /// <summary>
        /// Original was GL_QUERY_TARGET = 0x82EA
        /// </summary>
        QueryTarget = ((int)0x82EA),
        /// <summary>
        /// Original was GL_CONVOLUTION_HINT_SGIX = 0x8316
        /// </summary>
        ConvolutionHintSgix = ((int)0x8316),
        /// <summary>
        /// Original was GL_ALPHA_MIN_SGIX = 0x8320
        /// </summary>
        AlphaMinSgix = ((int)0x8320),
        /// <summary>
        /// Original was GL_ALPHA_MAX_SGIX = 0x8321
        /// </summary>
        AlphaMaxSgix = ((int)0x8321),
        /// <summary>
        /// Original was GL_SCALEBIAS_HINT_SGIX = 0x8322
        /// </summary>
        ScalebiasHintSgix = ((int)0x8322),
        /// <summary>
        /// Original was GL_ASYNC_MARKER_SGIX = 0x8329
        /// </summary>
        AsyncMarkerSgix = ((int)0x8329),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_MODE_SGIX = 0x832B
        /// </summary>
        PixelTexGenModeSgix = ((int)0x832B),
        /// <summary>
        /// Original was GL_ASYNC_HISTOGRAM_SGIX = 0x832C
        /// </summary>
        AsyncHistogramSgix = ((int)0x832C),
        /// <summary>
        /// Original was GL_MAX_ASYNC_HISTOGRAM_SGIX = 0x832D
        /// </summary>
        MaxAsyncHistogramSgix = ((int)0x832D),
        /// <summary>
        /// Original was GL_PIXEL_TEXTURE_SGIS = 0x8353
        /// </summary>
        PixelTextureSgis = ((int)0x8353),
        /// <summary>
        /// Original was GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354
        /// </summary>
        PixelFragmentRgbSourceSgis = ((int)0x8354),
        /// <summary>
        /// Original was GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355
        /// </summary>
        PixelFragmentAlphaSourceSgis = ((int)0x8355),
        /// <summary>
        /// Original was GL_LINE_QUALITY_HINT_SGIX = 0x835B
        /// </summary>
        LineQualityHintSgix = ((int)0x835B),
        /// <summary>
        /// Original was GL_ASYNC_TEX_IMAGE_SGIX = 0x835C
        /// </summary>
        AsyncTexImageSgix = ((int)0x835C),
        /// <summary>
        /// Original was GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D
        /// </summary>
        AsyncDrawPixelsSgix = ((int)0x835D),
        /// <summary>
        /// Original was GL_ASYNC_READ_PIXELS_SGIX = 0x835E
        /// </summary>
        AsyncReadPixelsSgix = ((int)0x835E),
        /// <summary>
        /// Original was GL_MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F
        /// </summary>
        MaxAsyncTexImageSgix = ((int)0x835F),
        /// <summary>
        /// Original was GL_MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360
        /// </summary>
        MaxAsyncDrawPixelsSgix = ((int)0x8360),
        /// <summary>
        /// Original was GL_MAX_ASYNC_READ_PIXELS_SGIX = 0x8361
        /// </summary>
        MaxAsyncReadPixelsSgix = ((int)0x8361),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_6_5 = 0x8363
        /// </summary>
        UnsignedShort565 = ((int)0x8363),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365
        /// </summary>
        UnsignedShort4444Rev = ((int)0x8365),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT = 0x8365
        /// </summary>
        UnsignedShort4444RevExt = ((int)0x8365),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG = 0x8365
        /// </summary>
        UnsignedShort4444RevImg = ((int)0x8365),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366
        /// </summary>
        UnsignedShort1555Rev = ((int)0x8366),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT = 0x8366
        /// </summary>
        UnsignedShort1555RevExt = ((int)0x8366),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368
        /// </summary>
        UnsignedInt2101010Rev = ((int)0x8368),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_S_SGIX = 0x8369
        /// </summary>
        TextureMaxClampSSgix = ((int)0x8369),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_T_SGIX = 0x836A
        /// </summary>
        TextureMaxClampTSgix = ((int)0x836A),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_R_SGIX = 0x836B
        /// </summary>
        TextureMaxClampRSgix = ((int)0x836B),
        /// <summary>
        /// Original was GL_MIRRORED_REPEAT_OES = 0x8370
        /// </summary>
        MirroredRepeatOes = ((int)0x8370),
        /// <summary>
        /// Original was GL_VERTEX_PRECLIP_SGIX = 0x83EE
        /// </summary>
        VertexPreclipSgix = ((int)0x83EE),
        /// <summary>
        /// Original was GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF
        /// </summary>
        VertexPreclipHintSgix = ((int)0x83EF),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0
        /// </summary>
        CompressedRgbS3tcDxt1Ext = ((int)0x83F0),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1
        /// </summary>
        CompressedRgbaS3tcDxt1Ext = ((int)0x83F1),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2
        /// </summary>
        CompressedRgbaS3tcDxt3Ext = ((int)0x83F2),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3
        /// </summary>
        CompressedRgbaS3tcDxt5Ext = ((int)0x83F3),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHTING_SGIX = 0x8400
        /// </summary>
        FragmentLightingSgix = ((int)0x8400),
        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401
        /// </summary>
        FragmentColorMaterialSgix = ((int)0x8401),
        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX = 0x8402
        /// </summary>
        FragmentColorMaterialFaceSgix = ((int)0x8402),
        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = 0x8403
        /// </summary>
        FragmentColorMaterialParameterSgix = ((int)0x8403),
        /// <summary>
        /// Original was GL_MAX_FRAGMENT_LIGHTS_SGIX = 0x8404
        /// </summary>
        MaxFragmentLightsSgix = ((int)0x8404),
        /// <summary>
        /// Original was GL_MAX_ACTIVE_LIGHTS_SGIX = 0x8405
        /// </summary>
        MaxActiveLightsSgix = ((int)0x8405),
        /// <summary>
        /// Original was GL_LIGHT_ENV_MODE_SGIX = 0x8407
        /// </summary>
        LightEnvModeSgix = ((int)0x8407),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408
        /// </summary>
        FragmentLightModelLocalViewerSgix = ((int)0x8408),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409
        /// </summary>
        FragmentLightModelTwoSideSgix = ((int)0x8409),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A
        /// </summary>
        FragmentLightModelAmbientSgix = ((int)0x840A),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B
        /// </summary>
        FragmentLightModelNormalInterpolationSgix = ((int)0x840B),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT0_SGIX = 0x840C
        /// </summary>
        FragmentLight0Sgix = ((int)0x840C),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT1_SGIX = 0x840D
        /// </summary>
        FragmentLight1Sgix = ((int)0x840D),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT2_SGIX = 0x840E
        /// </summary>
        FragmentLight2Sgix = ((int)0x840E),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT3_SGIX = 0x840F
        /// </summary>
        FragmentLight3Sgix = ((int)0x840F),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT4_SGIX = 0x8410
        /// </summary>
        FragmentLight4Sgix = ((int)0x8410),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT5_SGIX = 0x8411
        /// </summary>
        FragmentLight5Sgix = ((int)0x8411),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT6_SGIX = 0x8412
        /// </summary>
        FragmentLight6Sgix = ((int)0x8412),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT7_SGIX = 0x8413
        /// </summary>
        FragmentLight7Sgix = ((int)0x8413),
        /// <summary>
        /// Original was GL_PACK_RESAMPLE_SGIX = 0x842E
        /// </summary>
        PackResampleSgix = ((int)0x842E),
        /// <summary>
        /// Original was GL_UNPACK_RESAMPLE_SGIX = 0x842F
        /// </summary>
        UnpackResampleSgix = ((int)0x842F),
        /// <summary>
        /// Original was GL_RESAMPLE_DECIMATE_SGIX = 0x8430
        /// </summary>
        ResampleDecimateSgix = ((int)0x8430),
        /// <summary>
        /// Original was GL_RESAMPLE_REPLICATE_SGIX = 0x8433
        /// </summary>
        ResampleReplicateSgix = ((int)0x8433),
        /// <summary>
        /// Original was GL_RESAMPLE_ZERO_FILL_SGIX = 0x8434
        /// </summary>
        ResampleZeroFillSgix = ((int)0x8434),
        /// <summary>
        /// Original was GL_NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D
        /// </summary>
        NearestClipmapNearestSgix = ((int)0x844D),
        /// <summary>
        /// Original was GL_NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E
        /// </summary>
        NearestClipmapLinearSgix = ((int)0x844E),
        /// <summary>
        /// Original was GL_LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F
        /// </summary>
        LinearClipmapNearestSgix = ((int)0x844F),
        /// <summary>
        /// Original was GL_FOG_COORD_SRC = 0x8450
        /// </summary>
        FogCoordSrc = ((int)0x8450),
        /// <summary>
        /// Original was GL_ALIASED_POINT_SIZE_RANGE = 0x846D
        /// </summary>
        AliasedPointSizeRange = ((int)0x846D),
        /// <summary>
        /// Original was GL_ALIASED_LINE_WIDTH_RANGE = 0x846E
        /// </summary>
        AliasedLineWidthRange = ((int)0x846E),
        /// <summary>
        /// Original was GL_TEXTURE0 = 0x84C0
        /// </summary>
        Texture0 = ((int)0x84C0),
        /// <summary>
        /// Original was GL_TEXTURE1 = 0x84C1
        /// </summary>
        Texture1 = ((int)0x84C1),
        /// <summary>
        /// Original was GL_TEXTURE2 = 0x84C2
        /// </summary>
        Texture2 = ((int)0x84C2),
        /// <summary>
        /// Original was GL_TEXTURE3 = 0x84C3
        /// </summary>
        Texture3 = ((int)0x84C3),
        /// <summary>
        /// Original was GL_TEXTURE4 = 0x84C4
        /// </summary>
        Texture4 = ((int)0x84C4),
        /// <summary>
        /// Original was GL_TEXTURE5 = 0x84C5
        /// </summary>
        Texture5 = ((int)0x84C5),
        /// <summary>
        /// Original was GL_TEXTURE6 = 0x84C6
        /// </summary>
        Texture6 = ((int)0x84C6),
        /// <summary>
        /// Original was GL_TEXTURE7 = 0x84C7
        /// </summary>
        Texture7 = ((int)0x84C7),
        /// <summary>
        /// Original was GL_TEXTURE8 = 0x84C8
        /// </summary>
        Texture8 = ((int)0x84C8),
        /// <summary>
        /// Original was GL_TEXTURE9 = 0x84C9
        /// </summary>
        Texture9 = ((int)0x84C9),
        /// <summary>
        /// Original was GL_TEXTURE10 = 0x84CA
        /// </summary>
        Texture10 = ((int)0x84CA),
        /// <summary>
        /// Original was GL_TEXTURE11 = 0x84CB
        /// </summary>
        Texture11 = ((int)0x84CB),
        /// <summary>
        /// Original was GL_TEXTURE12 = 0x84CC
        /// </summary>
        Texture12 = ((int)0x84CC),
        /// <summary>
        /// Original was GL_TEXTURE13 = 0x84CD
        /// </summary>
        Texture13 = ((int)0x84CD),
        /// <summary>
        /// Original was GL_TEXTURE14 = 0x84CE
        /// </summary>
        Texture14 = ((int)0x84CE),
        /// <summary>
        /// Original was GL_TEXTURE15 = 0x84CF
        /// </summary>
        Texture15 = ((int)0x84CF),
        /// <summary>
        /// Original was GL_TEXTURE16 = 0x84D0
        /// </summary>
        Texture16 = ((int)0x84D0),
        /// <summary>
        /// Original was GL_TEXTURE17 = 0x84D1
        /// </summary>
        Texture17 = ((int)0x84D1),
        /// <summary>
        /// Original was GL_TEXTURE18 = 0x84D2
        /// </summary>
        Texture18 = ((int)0x84D2),
        /// <summary>
        /// Original was GL_TEXTURE19 = 0x84D3
        /// </summary>
        Texture19 = ((int)0x84D3),
        /// <summary>
        /// Original was GL_TEXTURE20 = 0x84D4
        /// </summary>
        Texture20 = ((int)0x84D4),
        /// <summary>
        /// Original was GL_TEXTURE21 = 0x84D5
        /// </summary>
        Texture21 = ((int)0x84D5),
        /// <summary>
        /// Original was GL_TEXTURE22 = 0x84D6
        /// </summary>
        Texture22 = ((int)0x84D6),
        /// <summary>
        /// Original was GL_TEXTURE23 = 0x84D7
        /// </summary>
        Texture23 = ((int)0x84D7),
        /// <summary>
        /// Original was GL_TEXTURE24 = 0x84D8
        /// </summary>
        Texture24 = ((int)0x84D8),
        /// <summary>
        /// Original was GL_TEXTURE25 = 0x84D9
        /// </summary>
        Texture25 = ((int)0x84D9),
        /// <summary>
        /// Original was GL_TEXTURE26 = 0x84DA
        /// </summary>
        Texture26 = ((int)0x84DA),
        /// <summary>
        /// Original was GL_TEXTURE27 = 0x84DB
        /// </summary>
        Texture27 = ((int)0x84DB),
        /// <summary>
        /// Original was GL_TEXTURE28 = 0x84DC
        /// </summary>
        Texture28 = ((int)0x84DC),
        /// <summary>
        /// Original was GL_TEXTURE29 = 0x84DD
        /// </summary>
        Texture29 = ((int)0x84DD),
        /// <summary>
        /// Original was GL_TEXTURE30 = 0x84DE
        /// </summary>
        Texture30 = ((int)0x84DE),
        /// <summary>
        /// Original was GL_TEXTURE31 = 0x84DF
        /// </summary>
        Texture31 = ((int)0x84DF),
        /// <summary>
        /// Original was GL_ACTIVE_TEXTURE = 0x84E0
        /// </summary>
        ActiveTexture = ((int)0x84E0),
        /// <summary>
        /// Original was GL_CLIENT_ACTIVE_TEXTURE = 0x84E1
        /// </summary>
        ClientActiveTexture = ((int)0x84E1),
        /// <summary>
        /// Original was GL_MAX_TEXTURE_UNITS = 0x84E2
        /// </summary>
        MaxTextureUnits = ((int)0x84E2),
        /// <summary>
        /// Original was GL_SUBTRACT = 0x84E7
        /// </summary>
        Subtract = ((int)0x84E7),
        /// <summary>
        /// Original was GL_MAX_RENDERBUFFER_SIZE_OES = 0x84E8
        /// </summary>
        MaxRenderbufferSizeOes = ((int)0x84E8),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB = 0x84ED
        /// </summary>
        CompressedRgb = ((int)0x84ED),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA = 0x84EE
        /// </summary>
        CompressedRgba = ((int)0x84EE),
        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSION_HINT = 0x84EF
        /// </summary>
        TextureCompressionHint = ((int)0x84EF),
        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF
        /// </summary>
        TextureCompressionHintArb = ((int)0x84EF),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0
        /// </summary>
        UniformBlockReferencedByTessControlShader = ((int)0x84F0),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1
        /// </summary>
        UniformBlockReferencedByTessEvaluationShader = ((int)0x84F1),
        /// <summary>
        /// Original was GL_ALL_COMPLETED_NV = 0x84F2
        /// </summary>
        AllCompletedNv = ((int)0x84F2),
        /// <summary>
        /// Original was GL_FENCE_STATUS_NV = 0x84F3
        /// </summary>
        FenceStatusNv = ((int)0x84F3),
        /// <summary>
        /// Original was GL_FENCE_CONDITION_NV = 0x84F4
        /// </summary>
        FenceConditionNv = ((int)0x84F4),
        /// <summary>
        /// Original was GL_TEXTURE_RECTANGLE = 0x84F5
        /// </summary>
        TextureRectangle = ((int)0x84F5),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE = 0x84F7
        /// </summary>
        ProxyTextureRectangle = ((int)0x84F7),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7
        /// </summary>
        ProxyTextureRectangleArb = ((int)0x84F7),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE_NV = 0x84F7
        /// </summary>
        ProxyTextureRectangleNv = ((int)0x84F7),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL = 0x84F9
        /// </summary>
        DepthStencil = ((int)0x84F9),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_EXT = 0x84F9
        /// </summary>
        DepthStencilExt = ((int)0x84F9),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_NV = 0x84F9
        /// </summary>
        DepthStencilNv = ((int)0x84F9),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_OES = 0x84F9
        /// </summary>
        DepthStencilOes = ((int)0x84F9),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_24_8_OES = 0x84FA
        /// </summary>
        UnsignedInt248Oes = ((int)0x84FA),
        /// <summary>
        /// Original was GL_MAX_TEXTURE_LOD_BIAS_EXT = 0x84FD
        /// </summary>
        MaxTextureLodBiasExt = ((int)0x84FD),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE
        /// </summary>
        TextureMaxAnisotropyExt = ((int)0x84FE),
        /// <summary>
        /// Original was GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF
        /// </summary>
        MaxTextureMaxAnisotropyExt = ((int)0x84FF),
        /// <summary>
        /// Original was GL_TEXTURE_FILTER_CONTROL_EXT = 0x8500
        /// </summary>
        TextureFilterControlExt = ((int)0x8500),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS = 0x8501
        /// </summary>
        TextureLodBias = ((int)0x8501),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_EXT = 0x8501
        /// </summary>
        TextureLodBiasExt = ((int)0x8501),
        /// <summary>
        /// Original was GL_INCR_WRAP_OES = 0x8507
        /// </summary>
        IncrWrapOes = ((int)0x8507),
        /// <summary>
        /// Original was GL_DECR_WRAP_OES = 0x8508
        /// </summary>
        DecrWrapOes = ((int)0x8508),
        /// <summary>
        /// Original was GL_NORMAL_MAP_OES = 0x8511
        /// </summary>
        NormalMapOes = ((int)0x8511),
        /// <summary>
        /// Original was GL_REFLECTION_MAP_OES = 0x8512
        /// </summary>
        ReflectionMapOes = ((int)0x8512),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP = 0x8513
        /// </summary>
        TextureCubeMap = ((int)0x8513),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_OES = 0x8513
        /// </summary>
        TextureCubeMapOes = ((int)0x8513),
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP_OES = 0x8514
        /// </summary>
        TextureBindingCubeMapOes = ((int)0x8514),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515
        /// </summary>
        TextureCubeMapPositiveX = ((int)0x8515),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES = 0x8515
        /// </summary>
        TextureCubeMapPositiveXOes = ((int)0x8515),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516
        /// </summary>
        TextureCubeMapNegativeX = ((int)0x8516),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES = 0x8516
        /// </summary>
        TextureCubeMapNegativeXOes = ((int)0x8516),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517
        /// </summary>
        TextureCubeMapPositiveY = ((int)0x8517),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES = 0x8517
        /// </summary>
        TextureCubeMapPositiveYOes = ((int)0x8517),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518
        /// </summary>
        TextureCubeMapNegativeY = ((int)0x8518),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES = 0x8518
        /// </summary>
        TextureCubeMapNegativeYOes = ((int)0x8518),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519
        /// </summary>
        TextureCubeMapPositiveZ = ((int)0x8519),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES = 0x8519
        /// </summary>
        TextureCubeMapPositiveZOes = ((int)0x8519),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A
        /// </summary>
        TextureCubeMapNegativeZ = ((int)0x851A),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES = 0x851A
        /// </summary>
        TextureCubeMapNegativeZOes = ((int)0x851A),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP = 0x851B
        /// </summary>
        ProxyTextureCubeMap = ((int)0x851B),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B
        /// </summary>
        ProxyTextureCubeMapArb = ((int)0x851B),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B
        /// </summary>
        ProxyTextureCubeMapExt = ((int)0x851B),
        /// <summary>
        /// Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES = 0x851C
        /// </summary>
        MaxCubeMapTextureSizeOes = ((int)0x851C),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F
        /// </summary>
        VertexArrayStorageHintApple = ((int)0x851F),
        /// <summary>
        /// Original was GL_PRIMARY_COLOR_NV = 0x852C
        /// </summary>
        PrimaryColorNv = ((int)0x852C),
        /// <summary>
        /// Original was GL_SECONDARY_COLOR_NV = 0x852D
        /// </summary>
        SecondaryColorNv = ((int)0x852D),
        /// <summary>
        /// Original was GL_MULTISAMPLE_FILTER_HINT_NV = 0x8534
        /// </summary>
        MultisampleFilterHintNv = ((int)0x8534),
        /// <summary>
        /// Original was GL_COMBINE = 0x8570
        /// </summary>
        Combine = ((int)0x8570),
        /// <summary>
        /// Original was GL_COMBINE_RGB = 0x8571
        /// </summary>
        CombineRgb = ((int)0x8571),
        /// <summary>
        /// Original was GL_COMBINE_ALPHA = 0x8572
        /// </summary>
        CombineAlpha = ((int)0x8572),
        /// <summary>
        /// Original was GL_RGB_SCALE = 0x8573
        /// </summary>
        RgbScale = ((int)0x8573),
        /// <summary>
        /// Original was GL_ADD_SIGNED = 0x8574
        /// </summary>
        AddSigned = ((int)0x8574),
        /// <summary>
        /// Original was GL_INTERPOLATE = 0x8575
        /// </summary>
        Interpolate = ((int)0x8575),
        /// <summary>
        /// Original was GL_CONSTANT = 0x8576
        /// </summary>
        Constant = ((int)0x8576),
        /// <summary>
        /// Original was GL_PRIMARY_COLOR = 0x8577
        /// </summary>
        PrimaryColor = ((int)0x8577),
        /// <summary>
        /// Original was GL_PREVIOUS = 0x8578
        /// </summary>
        Previous = ((int)0x8578),
        /// <summary>
        /// Original was GL_SRC0_RGB = 0x8580
        /// </summary>
        Src0Rgb = ((int)0x8580),
        /// <summary>
        /// Original was GL_SRC1_RGB = 0x8581
        /// </summary>
        Src1Rgb = ((int)0x8581),
        /// <summary>
        /// Original was GL_SRC2_RGB = 0x8582
        /// </summary>
        Src2Rgb = ((int)0x8582),
        /// <summary>
        /// Original was GL_SRC0_ALPHA = 0x8588
        /// </summary>
        Src0Alpha = ((int)0x8588),
        /// <summary>
        /// Original was GL_SRC1_ALPHA = 0x8589
        /// </summary>
        Src1Alpha = ((int)0x8589),
        /// <summary>
        /// Original was GL_SRC2_ALPHA = 0x858A
        /// </summary>
        Src2Alpha = ((int)0x858A),
        /// <summary>
        /// Original was GL_OPERAND0_RGB = 0x8590
        /// </summary>
        Operand0Rgb = ((int)0x8590),
        /// <summary>
        /// Original was GL_OPERAND1_RGB = 0x8591
        /// </summary>
        Operand1Rgb = ((int)0x8591),
        /// <summary>
        /// Original was GL_OPERAND2_RGB = 0x8592
        /// </summary>
        Operand2Rgb = ((int)0x8592),
        /// <summary>
        /// Original was GL_OPERAND0_ALPHA = 0x8598
        /// </summary>
        Operand0Alpha = ((int)0x8598),
        /// <summary>
        /// Original was GL_OPERAND1_ALPHA = 0x8599
        /// </summary>
        Operand1Alpha = ((int)0x8599),
        /// <summary>
        /// Original was GL_OPERAND2_ALPHA = 0x859A
        /// </summary>
        Operand2Alpha = ((int)0x859A),
        /// <summary>
        /// Original was GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0
        /// </summary>
        PackSubsampleRateSgix = ((int)0x85A0),
        /// <summary>
        /// Original was GL_UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1
        /// </summary>
        UnpackSubsampleRateSgix = ((int)0x85A1),
        /// <summary>
        /// Original was GL_PIXEL_SUBSAMPLE_4444_SGIX = 0x85A2
        /// </summary>
        PixelSubsample4444Sgix = ((int)0x85A2),
        /// <summary>
        /// Original was GL_PIXEL_SUBSAMPLE_2424_SGIX = 0x85A3
        /// </summary>
        PixelSubsample2424Sgix = ((int)0x85A3),
        /// <summary>
        /// Original was GL_PIXEL_SUBSAMPLE_4242_SGIX = 0x85A4
        /// </summary>
        PixelSubsample4242Sgix = ((int)0x85A4),
        /// <summary>
        /// Original was GL_TRANSFORM_HINT_APPLE = 0x85B1
        /// </summary>
        TransformHintApple = ((int)0x85B1),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BINDING_OES = 0x85B5
        /// </summary>
        VertexArrayBindingOes = ((int)0x85B5),
        /// <summary>
        /// Original was GL_TEXTURE_STORAGE_HINT_APPLE = 0x85BC
        /// </summary>
        TextureStorageHintApple = ((int)0x85BC),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622
        /// </summary>
        VertexAttribArrayEnabled = ((int)0x8622),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623
        /// </summary>
        VertexAttribArraySize = ((int)0x8623),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624
        /// </summary>
        VertexAttribArrayStride = ((int)0x8624),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625
        /// </summary>
        VertexAttribArrayType = ((int)0x8625),
        /// <summary>
        /// Original was GL_CURRENT_VERTEX_ATTRIB = 0x8626
        /// </summary>
        CurrentVertexAttrib = ((int)0x8626),
        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED = 0x86A1
        /// </summary>
        TextureCompressed = ((int)0x86A1),
        /// <summary>
        /// Original was GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2
        /// </summary>
        NumCompressedTextureFormats = ((int)0x86A2),
        /// <summary>
        /// Original was GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3
        /// </summary>
        CompressedTextureFormats = ((int)0x86A3),
        /// <summary>
        /// Original was GL_MAX_VERTEX_UNITS_OES = 0x86A4
        /// </summary>
        MaxVertexUnitsOes = ((int)0x86A4),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_TYPE_OES = 0x86A9
        /// </summary>
        WeightArrayTypeOes = ((int)0x86A9),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_STRIDE_OES = 0x86AA
        /// </summary>
        WeightArrayStrideOes = ((int)0x86AA),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_SIZE_OES = 0x86AB
        /// </summary>
        WeightArraySizeOes = ((int)0x86AB),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_POINTER_OES = 0x86AC
        /// </summary>
        WeightArrayPointerOes = ((int)0x86AC),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_OES = 0x86AD
        /// </summary>
        WeightArrayOes = ((int)0x86AD),
        /// <summary>
        /// Original was GL_DOT3_RGB = 0x86AE
        /// </summary>
        Dot3Rgb = ((int)0x86AE),
        /// <summary>
        /// Original was GL_DOT3_RGBA = 0x86AF
        /// </summary>
        Dot3Rgba = ((int)0x86AF),
        /// <summary>
        /// Original was GL_DOT3_RGBA_IMG = 0x86AF
        /// </summary>
        Dot3RgbaImg = ((int)0x86AF),
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_LENGTH = 0x8741
        /// </summary>
        ProgramBinaryLength = ((int)0x8741),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E
        /// </summary>
        VertexAttribArrayLong = ((int)0x874E),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_MESA = 0x8750
        /// </summary>
        DepthStencilMesa = ((int)0x8750),
        /// <summary>
        /// Original was GL_BUFFER_SIZE = 0x8764
        /// </summary>
        BufferSize = ((int)0x8764),
        /// <summary>
        /// Original was GL_BUFFER_USAGE = 0x8765
        /// </summary>
        BufferUsage = ((int)0x8765),
        /// <summary>
        /// Original was GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE
        /// </summary>
        AtcRgbaInterpolatedAlphaAmd = ((int)0x87EE),
        /// <summary>
        /// Original was GL_3DC_X_AMD = 0x87F9
        /// </summary>
        Gl3DcXAmd = ((int)0x87F9),
        /// <summary>
        /// Original was GL_3DC_XY_AMD = 0x87FA
        /// </summary>
        Gl3DcXyAmd = ((int)0x87FA),
        /// <summary>
        /// Original was GL_RGBA32F = 0x8814
        /// </summary>
        Rgba32f = ((int)0x8814),
        /// <summary>
        /// Original was GL_RGBA32F_ARB = 0x8814
        /// </summary>
        Rgba32fArb = ((int)0x8814),
        /// <summary>
        /// Original was GL_RGBA32F_EXT = 0x8814
        /// </summary>
        Rgba32fExt = ((int)0x8814),
        /// <summary>
        /// Original was GL_RGB32F_EXT = 0x8815
        /// </summary>
        Rgb32fExt = ((int)0x8815),
        /// <summary>
        /// Original was GL_ALPHA32F_EXT = 0x8816
        /// </summary>
        Alpha32fExt = ((int)0x8816),
        /// <summary>
        /// Original was GL_LUMINANCE32F_EXT = 0x8818
        /// </summary>
        Luminance32fExt = ((int)0x8818),
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA32F_EXT = 0x8819
        /// </summary>
        LuminanceAlpha32fExt = ((int)0x8819),
        /// <summary>
        /// Original was GL_RGBA16F = 0x881A
        /// </summary>
        Rgba16f = ((int)0x881A),
        /// <summary>
        /// Original was GL_RGBA16F_ARB = 0x881A
        /// </summary>
        Rgba16fArb = ((int)0x881A),
        /// <summary>
        /// Original was GL_RGBA16F_EXT = 0x881A
        /// </summary>
        Rgba16fExt = ((int)0x881A),
        /// <summary>
        /// Original was GL_RGB16F = 0x881B
        /// </summary>
        Rgb16f = ((int)0x881B),
        /// <summary>
        /// Original was GL_RGB16F_ARB = 0x881B
        /// </summary>
        Rgb16fArb = ((int)0x881B),
        /// <summary>
        /// Original was GL_RGB16F_EXT = 0x881B
        /// </summary>
        Rgb16fExt = ((int)0x881B),
        /// <summary>
        /// Original was GL_ALPHA16F_EXT = 0x881C
        /// </summary>
        Alpha16fExt = ((int)0x881C),
        /// <summary>
        /// Original was GL_LUMINANCE16F_EXT = 0x881E
        /// </summary>
        Luminance16fExt = ((int)0x881E),
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA16F_EXT = 0x881F
        /// </summary>
        LuminanceAlpha16fExt = ((int)0x881F),
        /// <summary>
        /// Original was GL_WRITEONLY_RENDERING_QCOM = 0x8823
        /// </summary>
        WriteonlyRenderingQcom = ((int)0x8823),
        /// <summary>
        /// Original was GL_BLEND_EQUATION_ALPHA_OES = 0x883D
        /// </summary>
        BlendEquationAlphaOes = ((int)0x883D),
        /// <summary>
        /// Original was GL_MATRIX_PALETTE_OES = 0x8840
        /// </summary>
        MatrixPaletteOes = ((int)0x8840),
        /// <summary>
        /// Original was GL_MAX_PALETTE_MATRICES_OES = 0x8842
        /// </summary>
        MaxPaletteMatricesOes = ((int)0x8842),
        /// <summary>
        /// Original was GL_CURRENT_PALETTE_MATRIX_OES = 0x8843
        /// </summary>
        CurrentPaletteMatrixOes = ((int)0x8843),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_OES = 0x8844
        /// </summary>
        MatrixIndexArrayOes = ((int)0x8844),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_SIZE_OES = 0x8846
        /// </summary>
        MatrixIndexArraySizeOes = ((int)0x8846),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_TYPE_OES = 0x8847
        /// </summary>
        MatrixIndexArrayTypeOes = ((int)0x8847),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_STRIDE_OES = 0x8848
        /// </summary>
        MatrixIndexArrayStrideOes = ((int)0x8848),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_POINTER_OES = 0x8849
        /// </summary>
        MatrixIndexArrayPointerOes = ((int)0x8849),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_MODE = 0x884C
        /// </summary>
        TextureCompareMode = ((int)0x884C),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
        /// </summary>
        TextureCompareFunc = ((int)0x884D),
        /// <summary>
        /// Original was GL_POINT_SPRITE_OES = 0x8861
        /// </summary>
        PointSpriteOes = ((int)0x8861),
        /// <summary>
        /// Original was GL_COORD_REPLACE_OES = 0x8862
        /// </summary>
        CoordReplaceOes = ((int)0x8862),
        /// <summary>
        /// Original was GL_QUERY_COUNTER_BITS = 0x8864
        /// </summary>
        QueryCounterBits = ((int)0x8864),
        /// <summary>
        /// Original was GL_CURRENT_QUERY = 0x8865
        /// </summary>
        CurrentQuery = ((int)0x8865),
        /// <summary>
        /// Original was GL_QUERY_RESULT = 0x8866
        /// </summary>
        QueryResult = ((int)0x8866),
        /// <summary>
        /// Original was GL_QUERY_RESULT_AVAILABLE = 0x8867
        /// </summary>
        QueryResultAvailable = ((int)0x8867),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A
        /// </summary>
        VertexAttribArrayNormalized = ((int)0x886A),
        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = ((int)0x8892),
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = ((int)0x8893),
        /// <summary>
        /// Original was GL_ARRAY_BUFFER_BINDING = 0x8894
        /// </summary>
        ArrayBufferBinding = ((int)0x8894),
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895
        /// </summary>
        ElementArrayBufferBinding = ((int)0x8895),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896
        /// </summary>
        VertexArrayBufferBinding = ((int)0x8896),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897
        /// </summary>
        NormalArrayBufferBinding = ((int)0x8897),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898
        /// </summary>
        ColorArrayBufferBinding = ((int)0x8898),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A
        /// </summary>
        TextureCoordArrayBufferBinding = ((int)0x889A),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_BUFFER_BINDING_OES = 0x889E
        /// </summary>
        WeightArrayBufferBindingOes = ((int)0x889E),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F
        /// </summary>
        VertexAttribArrayBufferBinding = ((int)0x889F),
        /// <summary>
        /// Original was GL_READ_ONLY = 0x88B8
        /// </summary>
        ReadOnly = ((int)0x88B8),
        /// <summary>
        /// Original was GL_WRITE_ONLY = 0x88B9
        /// </summary>
        WriteOnly = ((int)0x88B9),
        /// <summary>
        /// Original was GL_WRITE_ONLY_OES = 0x88B9
        /// </summary>
        WriteOnlyOes = ((int)0x88B9),
        /// <summary>
        /// Original was GL_READ_WRITE = 0x88BA
        /// </summary>
        ReadWrite = ((int)0x88BA),
        /// <summary>
        /// Original was GL_BUFFER_ACCESS = 0x88BB
        /// </summary>
        BufferAccess = ((int)0x88BB),
        /// <summary>
        /// Original was GL_BUFFER_ACCESS_OES = 0x88BB
        /// </summary>
        BufferAccessOes = ((int)0x88BB),
        /// <summary>
        /// Original was GL_BUFFER_MAPPED = 0x88BC
        /// </summary>
        BufferMapped = ((int)0x88BC),
        /// <summary>
        /// Original was GL_BUFFER_MAPPED_OES = 0x88BC
        /// </summary>
        BufferMappedOes = ((int)0x88BC),
        /// <summary>
        /// Original was GL_BUFFER_MAP_POINTER_OES = 0x88BD
        /// </summary>
        BufferMapPointerOes = ((int)0x88BD),
        /// <summary>
        /// Original was GL_TIME_ELAPSED = 0x88BF
        /// </summary>
        TimeElapsed = ((int)0x88BF),
        /// <summary>
        /// Original was GL_STREAM_DRAW = 0x88E0
        /// </summary>
        StreamDraw = ((int)0x88E0),
        /// <summary>
        /// Original was GL_STREAM_READ = 0x88E1
        /// </summary>
        StreamRead = ((int)0x88E1),
        /// <summary>
        /// Original was GL_STREAM_COPY = 0x88E2
        /// </summary>
        StreamCopy = ((int)0x88E2),
        /// <summary>
        /// Original was GL_STATIC_DRAW = 0x88E4
        /// </summary>
        StaticDraw = ((int)0x88E4),
        /// <summary>
        /// Original was GL_STATIC_READ = 0x88E5
        /// </summary>
        StaticRead = ((int)0x88E5),
        /// <summary>
        /// Original was GL_STATIC_COPY = 0x88E6
        /// </summary>
        StaticCopy = ((int)0x88E6),
        /// <summary>
        /// Original was GL_DYNAMIC_DRAW = 0x88E8
        /// </summary>
        DynamicDraw = ((int)0x88E8),
        /// <summary>
        /// Original was GL_DYNAMIC_READ = 0x88E9
        /// </summary>
        DynamicRead = ((int)0x88E9),
        /// <summary>
        /// Original was GL_DYNAMIC_COPY = 0x88EA
        /// </summary>
        DynamicCopy = ((int)0x88EA),
        /// <summary>
        /// Original was GL_PIXEL_PACK_BUFFER = 0x88EB
        /// </summary>
        PixelPackBuffer = ((int)0x88EB),
        /// <summary>
        /// Original was GL_PIXEL_UNPACK_BUFFER = 0x88EC
        /// </summary>
        PixelUnpackBuffer = ((int)0x88EC),
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8 = 0x88F0
        /// </summary>
        Depth24Stencil8 = ((int)0x88F0),
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_EXT = 0x88F0
        /// </summary>
        Depth24Stencil8Ext = ((int)0x88F0),
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        /// </summary>
        Depth24Stencil8Oes = ((int)0x88F0),
        /// <summary>
        /// Original was GL_SRC1_COLOR = 0x88F9
        /// </summary>
        Src1Color = ((int)0x88F9),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD
        /// </summary>
        VertexAttribArrayInteger = ((int)0x88FD),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE
        /// </summary>
        VertexAttribArrayDivisor = ((int)0x88FE),
        /// <summary>
        /// Original was GL_SAMPLES_PASSED = 0x8914
        /// </summary>
        SamplesPassed = ((int)0x8914),
        /// <summary>
        /// Original was GL_GEOMETRY_VERTICES_OUT = 0x8916
        /// </summary>
        GeometryVerticesOut = ((int)0x8916),
        /// <summary>
        /// Original was GL_GEOMETRY_INPUT_TYPE = 0x8917
        /// </summary>
        GeometryInputType = ((int)0x8917),
        /// <summary>
        /// Original was GL_GEOMETRY_OUTPUT_TYPE = 0x8918
        /// </summary>
        GeometryOutputType = ((int)0x8918),
        /// <summary>
        /// Original was GL_MOV_ATI = 0x8961
        /// </summary>
        MovAti = ((int)0x8961),
        /// <summary>
        /// Original was GL_ADD_ATI = 0x8963
        /// </summary>
        AddAti = ((int)0x8963),
        /// <summary>
        /// Original was GL_MUL_ATI = 0x8964
        /// </summary>
        MulAti = ((int)0x8964),
        /// <summary>
        /// Original was GL_SUB_ATI = 0x8965
        /// </summary>
        SubAti = ((int)0x8965),
        /// <summary>
        /// Original was GL_DOT3_ATI = 0x8966
        /// </summary>
        Dot3Ati = ((int)0x8966),
        /// <summary>
        /// Original was GL_DOT4_ATI = 0x8967
        /// </summary>
        Dot4Ati = ((int)0x8967),
        /// <summary>
        /// Original was GL_MAD_ATI = 0x8968
        /// </summary>
        MadAti = ((int)0x8968),
        /// <summary>
        /// Original was GL_LERP_ATI = 0x8969
        /// </summary>
        LerpAti = ((int)0x8969),
        /// <summary>
        /// Original was GL_CND_ATI = 0x896A
        /// </summary>
        CndAti = ((int)0x896A),
        /// <summary>
        /// Original was GL_CND0_ATI = 0x896B
        /// </summary>
        Cnd0Ati = ((int)0x896B),
        /// <summary>
        /// Original was GL_DOT2_ADD_ATI = 0x896C
        /// </summary>
        Dot2AddAti = ((int)0x896C),
        /// <summary>
        /// Original was GL_PACK_RESAMPLE_OML = 0x8984
        /// </summary>
        PackResampleOml = ((int)0x8984),
        /// <summary>
        /// Original was GL_UNPACK_RESAMPLE_OML = 0x8985
        /// </summary>
        UnpackResampleOml = ((int)0x8985),
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_TYPE_OES = 0x898A
        /// </summary>
        PointSizeArrayTypeOes = ((int)0x898A),
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_STRIDE_OES = 0x898B
        /// </summary>
        PointSizeArrayStrideOes = ((int)0x898B),
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_POINTER_OES = 0x898C
        /// </summary>
        PointSizeArrayPointerOes = ((int)0x898C),
        /// <summary>
        /// Original was GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898D
        /// </summary>
        ModelviewMatrixFloatAsIntBitsOes = ((int)0x898D),
        /// <summary>
        /// Original was GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898E
        /// </summary>
        ProjectionMatrixFloatAsIntBitsOes = ((int)0x898E),
        /// <summary>
        /// Original was GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898F
        /// </summary>
        TextureMatrixFloatAsIntBitsOes = ((int)0x898F),
        /// <summary>
        /// Original was GL_UNIFORM_BUFFER = 0x8A11
        /// </summary>
        UniformBuffer = ((int)0x8A11),
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35
        /// </summary>
        ActiveUniformBlockMaxNameLength = ((int)0x8A35),
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36
        /// </summary>
        ActiveUniformBlocks = ((int)0x8A36),
        /// <summary>
        /// Original was GL_UNIFORM_TYPE = 0x8A37
        /// </summary>
        UniformType = ((int)0x8A37),
        /// <summary>
        /// Original was GL_UNIFORM_SIZE = 0x8A38
        /// </summary>
        UniformSize = ((int)0x8A38),
        /// <summary>
        /// Original was GL_UNIFORM_NAME_LENGTH = 0x8A39
        /// </summary>
        UniformNameLength = ((int)0x8A39),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_INDEX = 0x8A3A
        /// </summary>
        UniformBlockIndex = ((int)0x8A3A),
        /// <summary>
        /// Original was GL_UNIFORM_OFFSET = 0x8A3B
        /// </summary>
        UniformOffset = ((int)0x8A3B),
        /// <summary>
        /// Original was GL_UNIFORM_ARRAY_STRIDE = 0x8A3C
        /// </summary>
        UniformArrayStride = ((int)0x8A3C),
        /// <summary>
        /// Original was GL_UNIFORM_MATRIX_STRIDE = 0x8A3D
        /// </summary>
        UniformMatrixStride = ((int)0x8A3D),
        /// <summary>
        /// Original was GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E
        /// </summary>
        UniformIsRowMajor = ((int)0x8A3E),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_BINDING = 0x8A3F
        /// </summary>
        UniformBlockBinding = ((int)0x8A3F),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40
        /// </summary>
        UniformBlockDataSize = ((int)0x8A40),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41
        /// </summary>
        UniformBlockNameLength = ((int)0x8A41),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42
        /// </summary>
        UniformBlockActiveUniforms = ((int)0x8A42),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43
        /// </summary>
        UniformBlockActiveUniformIndices = ((int)0x8A43),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44
        /// </summary>
        UniformBlockReferencedByVertexShader = ((int)0x8A44),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45
        /// </summary>
        UniformBlockReferencedByGeometryShader = ((int)0x8A45),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46
        /// </summary>
        UniformBlockReferencedByFragmentShader = ((int)0x8A46),
        /// <summary>
        /// Original was GL_SYNC_OBJECT_APPLE = 0x8A53
        /// </summary>
        SyncObjectApple = ((int)0x8A53),
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER = 0x8B30
        /// </summary>
        FragmentShader = ((int)0x8B30),
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_ARB = 0x8B30
        /// </summary>
        FragmentShaderArb = ((int)0x8B30),
        /// <summary>
        /// Original was GL_VERTEX_SHADER = 0x8B31
        /// </summary>
        VertexShader = ((int)0x8B31),
        /// <summary>
        /// Original was GL_VERTEX_SHADER_ARB = 0x8B31
        /// </summary>
        VertexShaderArb = ((int)0x8B31),
        /// <summary>
        /// Original was GL_SHADER_TYPE = 0x8B4F
        /// </summary>
        ShaderType = ((int)0x8B4F),
        /// <summary>
        /// Original was GL_FLOAT_VEC2 = 0x8B50
        /// </summary>
        FloatVec2 = ((int)0x8B50),
        /// <summary>
        /// Original was GL_FLOAT_VEC2_ARB = 0x8B50
        /// </summary>
        FloatVec2Arb = ((int)0x8B50),
        /// <summary>
        /// Original was GL_FLOAT_VEC3 = 0x8B51
        /// </summary>
        FloatVec3 = ((int)0x8B51),
        /// <summary>
        /// Original was GL_FLOAT_VEC3_ARB = 0x8B51
        /// </summary>
        FloatVec3Arb = ((int)0x8B51),
        /// <summary>
        /// Original was GL_FLOAT_VEC4 = 0x8B52
        /// </summary>
        FloatVec4 = ((int)0x8B52),
        /// <summary>
        /// Original was GL_FLOAT_VEC4_ARB = 0x8B52
        /// </summary>
        FloatVec4Arb = ((int)0x8B52),
        /// <summary>
        /// Original was GL_INT_VEC2 = 0x8B53
        /// </summary>
        IntVec2 = ((int)0x8B53),
        /// <summary>
        /// Original was GL_INT_VEC2_ARB = 0x8B53
        /// </summary>
        IntVec2Arb = ((int)0x8B53),
        /// <summary>
        /// Original was GL_INT_VEC3 = 0x8B54
        /// </summary>
        IntVec3 = ((int)0x8B54),
        /// <summary>
        /// Original was GL_INT_VEC3_ARB = 0x8B54
        /// </summary>
        IntVec3Arb = ((int)0x8B54),
        /// <summary>
        /// Original was GL_INT_VEC4 = 0x8B55
        /// </summary>
        IntVec4 = ((int)0x8B55),
        /// <summary>
        /// Original was GL_INT_VEC4_ARB = 0x8B55
        /// </summary>
        IntVec4Arb = ((int)0x8B55),
        /// <summary>
        /// Original was GL_BOOL = 0x8B56
        /// </summary>
        Bool = ((int)0x8B56),
        /// <summary>
        /// Original was GL_BOOL_ARB = 0x8B56
        /// </summary>
        BoolArb = ((int)0x8B56),
        /// <summary>
        /// Original was GL_BOOL_VEC2 = 0x8B57
        /// </summary>
        BoolVec2 = ((int)0x8B57),
        /// <summary>
        /// Original was GL_BOOL_VEC2_ARB = 0x8B57
        /// </summary>
        BoolVec2Arb = ((int)0x8B57),
        /// <summary>
        /// Original was GL_BOOL_VEC3 = 0x8B58
        /// </summary>
        BoolVec3 = ((int)0x8B58),
        /// <summary>
        /// Original was GL_BOOL_VEC3_ARB = 0x8B58
        /// </summary>
        BoolVec3Arb = ((int)0x8B58),
        /// <summary>
        /// Original was GL_BOOL_VEC4 = 0x8B59
        /// </summary>
        BoolVec4 = ((int)0x8B59),
        /// <summary>
        /// Original was GL_BOOL_VEC4_ARB = 0x8B59
        /// </summary>
        BoolVec4Arb = ((int)0x8B59),
        /// <summary>
        /// Original was GL_FLOAT_MAT2 = 0x8B5A
        /// </summary>
        FloatMat2 = ((int)0x8B5A),
        /// <summary>
        /// Original was GL_FLOAT_MAT2_ARB = 0x8B5A
        /// </summary>
        FloatMat2Arb = ((int)0x8B5A),
        /// <summary>
        /// Original was GL_FLOAT_MAT3 = 0x8B5B
        /// </summary>
        FloatMat3 = ((int)0x8B5B),
        /// <summary>
        /// Original was GL_FLOAT_MAT3_ARB = 0x8B5B
        /// </summary>
        FloatMat3Arb = ((int)0x8B5B),
        /// <summary>
        /// Original was GL_FLOAT_MAT4 = 0x8B5C
        /// </summary>
        FloatMat4 = ((int)0x8B5C),
        /// <summary>
        /// Original was GL_FLOAT_MAT4_ARB = 0x8B5C
        /// </summary>
        FloatMat4Arb = ((int)0x8B5C),
        /// <summary>
        /// Original was GL_SAMPLER_1D = 0x8B5D
        /// </summary>
        Sampler1D = ((int)0x8B5D),
        /// <summary>
        /// Original was GL_SAMPLER_1D_ARB = 0x8B5D
        /// </summary>
        Sampler1DArb = ((int)0x8B5D),
        /// <summary>
        /// Original was GL_SAMPLER_2D = 0x8B5E
        /// </summary>
        Sampler2D = ((int)0x8B5E),
        /// <summary>
        /// Original was GL_SAMPLER_2D_ARB = 0x8B5E
        /// </summary>
        Sampler2DArb = ((int)0x8B5E),
        /// <summary>
        /// Original was GL_SAMPLER_3D = 0x8B5F
        /// </summary>
        Sampler3D = ((int)0x8B5F),
        /// <summary>
        /// Original was GL_SAMPLER_3D_ARB = 0x8B5F
        /// </summary>
        Sampler3DArb = ((int)0x8B5F),
        /// <summary>
        /// Original was GL_SAMPLER_3D_OES = 0x8B5F
        /// </summary>
        Sampler3DOes = ((int)0x8B5F),
        /// <summary>
        /// Original was GL_SAMPLER_CUBE = 0x8B60
        /// </summary>
        SamplerCube = ((int)0x8B60),
        /// <summary>
        /// Original was GL_SAMPLER_CUBE_ARB = 0x8B60
        /// </summary>
        SamplerCubeArb = ((int)0x8B60),
        /// <summary>
        /// Original was GL_SAMPLER_1D_SHADOW = 0x8B61
        /// </summary>
        Sampler1DShadow = ((int)0x8B61),
        /// <summary>
        /// Original was GL_SAMPLER_1D_SHADOW_ARB = 0x8B61
        /// </summary>
        Sampler1DShadowArb = ((int)0x8B61),
        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW = 0x8B62
        /// </summary>
        Sampler2DShadow = ((int)0x8B62),
        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW_ARB = 0x8B62
        /// </summary>
        Sampler2DShadowArb = ((int)0x8B62),
        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW_EXT = 0x8B62
        /// </summary>
        Sampler2DShadowExt = ((int)0x8B62),
        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT = 0x8B63
        /// </summary>
        Sampler2DRect = ((int)0x8B63),
        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT_ARB = 0x8B63
        /// </summary>
        Sampler2DRectArb = ((int)0x8B63),
        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT_SHADOW = 0x8B64
        /// </summary>
        Sampler2DRectShadow = ((int)0x8B64),
        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64
        /// </summary>
        Sampler2DRectShadowArb = ((int)0x8B64),
        /// <summary>
        /// Original was GL_FLOAT_MAT2x3 = 0x8B65
        /// </summary>
        FloatMat2x3 = ((int)0x8B65),
        /// <summary>
        /// Original was GL_FLOAT_MAT2x3_NV = 0x8B65
        /// </summary>
        FloatMat2x3Nv = ((int)0x8B65),
        /// <summary>
        /// Original was GL_FLOAT_MAT2x4 = 0x8B66
        /// </summary>
        FloatMat2x4 = ((int)0x8B66),
        /// <summary>
        /// Original was GL_FLOAT_MAT2x4_NV = 0x8B66
        /// </summary>
        FloatMat2x4Nv = ((int)0x8B66),
        /// <summary>
        /// Original was GL_FLOAT_MAT3x2 = 0x8B67
        /// </summary>
        FloatMat3x2 = ((int)0x8B67),
        /// <summary>
        /// Original was GL_FLOAT_MAT3x2_NV = 0x8B67
        /// </summary>
        FloatMat3x2Nv = ((int)0x8B67),
        /// <summary>
        /// Original was GL_FLOAT_MAT3x4 = 0x8B68
        /// </summary>
        FloatMat3x4 = ((int)0x8B68),
        /// <summary>
        /// Original was GL_FLOAT_MAT3x4_NV = 0x8B68
        /// </summary>
        FloatMat3x4Nv = ((int)0x8B68),
        /// <summary>
        /// Original was GL_FLOAT_MAT4x2 = 0x8B69
        /// </summary>
        FloatMat4x2 = ((int)0x8B69),
        /// <summary>
        /// Original was GL_FLOAT_MAT4x2_NV = 0x8B69
        /// </summary>
        FloatMat4x2Nv = ((int)0x8B69),
        /// <summary>
        /// Original was GL_FLOAT_MAT4x3 = 0x8B6A
        /// </summary>
        FloatMat4x3 = ((int)0x8B6A),
        /// <summary>
        /// Original was GL_FLOAT_MAT4x3_NV = 0x8B6A
        /// </summary>
        FloatMat4x3Nv = ((int)0x8B6A),
        /// <summary>
        /// Original was GL_DELETE_STATUS = 0x8B80
        /// </summary>
        DeleteStatus = ((int)0x8B80),
        /// <summary>
        /// Original was GL_COMPILE_STATUS = 0x8B81
        /// </summary>
        CompileStatus = ((int)0x8B81),
        /// <summary>
        /// Original was GL_LINK_STATUS = 0x8B82
        /// </summary>
        LinkStatus = ((int)0x8B82),
        /// <summary>
        /// Original was GL_VALIDATE_STATUS = 0x8B83
        /// </summary>
        ValidateStatus = ((int)0x8B83),
        /// <summary>
        /// Original was GL_INFO_LOG_LENGTH = 0x8B84
        /// </summary>
        InfoLogLength = ((int)0x8B84),
        /// <summary>
        /// Original was GL_ATTACHED_SHADERS = 0x8B85
        /// </summary>
        AttachedShaders = ((int)0x8B85),
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORMS = 0x8B86
        /// </summary>
        ActiveUniforms = ((int)0x8B86),
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87
        /// </summary>
        ActiveUniformMaxLength = ((int)0x8B87),
        /// <summary>
        /// Original was GL_SHADER_SOURCE_LENGTH = 0x8B88
        /// </summary>
        ShaderSourceLength = ((int)0x8B88),
        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTES = 0x8B89
        /// </summary>
        ActiveAttributes = ((int)0x8B89),
        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A
        /// </summary>
        ActiveAttributeMaxLength = ((int)0x8B8A),
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHint = ((int)0x8B8B),
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHintArb = ((int)0x8B8B),
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHintOes = ((int)0x8B8B),
        /// <summary>
        /// Original was GL_SHADING_LANGUAGE_VERSION = 0x8B8C
        /// </summary>
        ShadingLanguageVersion = ((int)0x8B8C),
        /// <summary>
        /// Original was GL_PALETTE4_RGB8_OES = 0x8B90
        /// </summary>
        Palette4Rgb8Oes = ((int)0x8B90),
        /// <summary>
        /// Original was GL_PALETTE4_RGBA8_OES = 0x8B91
        /// </summary>
        Palette4Rgba8Oes = ((int)0x8B91),
        /// <summary>
        /// Original was GL_PALETTE4_R5_G6_B5_OES = 0x8B92
        /// </summary>
        Palette4R5G6B5Oes = ((int)0x8B92),
        /// <summary>
        /// Original was GL_PALETTE4_RGBA4_OES = 0x8B93
        /// </summary>
        Palette4Rgba4Oes = ((int)0x8B93),
        /// <summary>
        /// Original was GL_PALETTE4_RGB5_A1_OES = 0x8B94
        /// </summary>
        Palette4Rgb5A1Oes = ((int)0x8B94),
        /// <summary>
        /// Original was GL_PALETTE8_RGB8_OES = 0x8B95
        /// </summary>
        Palette8Rgb8Oes = ((int)0x8B95),
        /// <summary>
        /// Original was GL_PALETTE8_RGBA8_OES = 0x8B96
        /// </summary>
        Palette8Rgba8Oes = ((int)0x8B96),
        /// <summary>
        /// Original was GL_PALETTE8_R5_G6_B5_OES = 0x8B97
        /// </summary>
        Palette8R5G6B5Oes = ((int)0x8B97),
        /// <summary>
        /// Original was GL_PALETTE8_RGBA4_OES = 0x8B98
        /// </summary>
        Palette8Rgba4Oes = ((int)0x8B98),
        /// <summary>
        /// Original was GL_PALETTE8_RGB5_A1_OES = 0x8B99
        /// </summary>
        Palette8Rgb5A1Oes = ((int)0x8B99),
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A
        /// </summary>
        ImplementationColorReadType = ((int)0x8B9A),
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_TYPE_OES = 0x8B9A
        /// </summary>
        ImplementationColorReadTypeOes = ((int)0x8B9A),
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B
        /// </summary>
        ImplementationColorReadFormat = ((int)0x8B9B),
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES = 0x8B9B
        /// </summary>
        ImplementationColorReadFormatOes = ((int)0x8B9B),
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_OES = 0x8B9C
        /// </summary>
        PointSizeArrayOes = ((int)0x8B9C),
        /// <summary>
        /// Original was GL_TEXTURE_CROP_RECT_OES = 0x8B9D
        /// </summary>
        TextureCropRectOes = ((int)0x8B9D),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES = 0x8B9E
        /// </summary>
        MatrixIndexArrayBufferBindingOes = ((int)0x8B9E),
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES = 0x8B9F
        /// </summary>
        PointSizeArrayBufferBindingOes = ((int)0x8B9F),
        /// <summary>
        /// Original was GL_TEXTURE_WIDTH_QCOM = 0x8BD2
        /// </summary>
        TextureWidthQcom = ((int)0x8BD2),
        /// <summary>
        /// Original was GL_TEXTURE_HEIGHT_QCOM = 0x8BD3
        /// </summary>
        TextureHeightQcom = ((int)0x8BD3),
        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_QCOM = 0x8BD4
        /// </summary>
        TextureDepthQcom = ((int)0x8BD4),
        /// <summary>
        /// Original was GL_TEXTURE_INTERNAL_FORMAT_QCOM = 0x8BD5
        /// </summary>
        TextureInternalFormatQcom = ((int)0x8BD5),
        /// <summary>
        /// Original was GL_TEXTURE_FORMAT_QCOM = 0x8BD6
        /// </summary>
        TextureFormatQcom = ((int)0x8BD6),
        /// <summary>
        /// Original was GL_TEXTURE_TYPE_QCOM = 0x8BD7
        /// </summary>
        TextureTypeQcom = ((int)0x8BD7),
        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_VALID_QCOM = 0x8BD8
        /// </summary>
        TextureImageValidQcom = ((int)0x8BD8),
        /// <summary>
        /// Original was GL_TEXTURE_NUM_LEVELS_QCOM = 0x8BD9
        /// </summary>
        TextureNumLevelsQcom = ((int)0x8BD9),
        /// <summary>
        /// Original was GL_TEXTURE_TARGET_QCOM = 0x8BDA
        /// </summary>
        TextureTargetQcom = ((int)0x8BDA),
        /// <summary>
        /// Original was GL_TEXTURE_OBJECT_VALID_QCOM = 0x8BDB
        /// </summary>
        TextureObjectValidQcom = ((int)0x8BDB),
        /// <summary>
        /// Original was GL_STATE_RESTORE = 0x8BDC
        /// </summary>
        StateRestore = ((int)0x8BDC),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG = 0x8C00
        /// </summary>
        CompressedRgbPvrtc4Bppv1Img = ((int)0x8C00),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG = 0x8C01
        /// </summary>
        CompressedRgbPvrtc2Bppv1Img = ((int)0x8C01),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG = 0x8C02
        /// </summary>
        CompressedRgbaPvrtc4Bppv1Img = ((int)0x8C02),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG = 0x8C03
        /// </summary>
        CompressedRgbaPvrtc2Bppv1Img = ((int)0x8C03),
        /// <summary>
        /// Original was GL_MODULATE_COLOR_IMG = 0x8C04
        /// </summary>
        ModulateColorImg = ((int)0x8C04),
        /// <summary>
        /// Original was GL_RECIP_ADD_SIGNED_ALPHA_IMG = 0x8C05
        /// </summary>
        RecipAddSignedAlphaImg = ((int)0x8C05),
        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_MODULATE_IMG = 0x8C06
        /// </summary>
        TextureAlphaModulateImg = ((int)0x8C06),
        /// <summary>
        /// Original was GL_FACTOR_ALPHA_MODULATE_IMG = 0x8C07
        /// </summary>
        FactorAlphaModulateImg = ((int)0x8C07),
        /// <summary>
        /// Original was GL_FRAGMENT_ALPHA_MODULATE_IMG = 0x8C08
        /// </summary>
        FragmentAlphaModulateImg = ((int)0x8C08),
        /// <summary>
        /// Original was GL_ADD_BLEND_IMG = 0x8C09
        /// </summary>
        AddBlendImg = ((int)0x8C09),
        /// <summary>
        /// Original was GL_TEXTURE_1D_ARRAY = 0x8C18
        /// </summary>
        Texture1DArray = ((int)0x8C18),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19
        /// </summary>
        ProxyTexture1DArray = ((int)0x8C19),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19
        /// </summary>
        ProxyTexture1DArrayExt = ((int)0x8C19),
        /// <summary>
        /// Original was GL_TEXTURE_2D_ARRAY = 0x8C1A
        /// </summary>
        Texture2DArray = ((int)0x8C1A),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B
        /// </summary>
        ProxyTexture2DArray = ((int)0x8C1B),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B
        /// </summary>
        ProxyTexture2DArrayExt = ((int)0x8C1B),
        /// <summary>
        /// Original was GL_TEXTURE_BUFFER = 0x8C2A
        /// </summary>
        TextureBuffer = ((int)0x8C2A),
        /// <summary>
        /// Original was GL_ANY_SAMPLES_PASSED = 0x8C2F
        /// </summary>
        AnySamplesPassed = ((int)0x8C2F),
        /// <summary>
        /// Original was GL_R11F_G11F_B10F = 0x8C3A
        /// </summary>
        R11fG11fB10f = ((int)0x8C3A),
        /// <summary>
        /// Original was GL_R11F_G11F_B10F_APPLE = 0x8C3A
        /// </summary>
        R11fG11fB10fApple = ((int)0x8C3A),
        /// <summary>
        /// Original was GL_R11F_G11F_B10F_EXT = 0x8C3A
        /// </summary>
        R11fG11fB10fExt = ((int)0x8C3A),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        /// </summary>
        UnsignedInt10F11F11FRev = ((int)0x8C3B),
        /// <summary>
        /// Original was GL_RGB9_E5 = 0x8C3D
        /// </summary>
        Rgb9E5 = ((int)0x8C3D),
        /// <summary>
        /// Original was GL_RGB9_E5_APPLE = 0x8C3D
        /// </summary>
        Rgb9E5Apple = ((int)0x8C3D),
        /// <summary>
        /// Original was GL_RGB9_E5_EXT = 0x8C3D
        /// </summary>
        Rgb9E5Ext = ((int)0x8C3D),
        /// <summary>
        /// Original was GL_SRGB = 0x8C40
        /// </summary>
        Srgb = ((int)0x8C40),
        /// <summary>
        /// Original was GL_SRGB_EXT = 0x8C40
        /// </summary>
        SrgbExt = ((int)0x8C40),
        /// <summary>
        /// Original was GL_SRGB8 = 0x8C41
        /// </summary>
        Srgb8 = ((int)0x8C41),
        /// <summary>
        /// Original was GL_SRGB8_EXT = 0x8C41
        /// </summary>
        Srgb8Ext = ((int)0x8C41),
        /// <summary>
        /// Original was GL_SRGB8_NV = 0x8C41
        /// </summary>
        Srgb8Nv = ((int)0x8C41),
        /// <summary>
        /// Original was GL_SRGB_ALPHA = 0x8C42
        /// </summary>
        SrgbAlpha = ((int)0x8C42),
        /// <summary>
        /// Original was GL_SRGB_ALPHA_EXT = 0x8C42
        /// </summary>
        SrgbAlphaExt = ((int)0x8C42),
        /// <summary>
        /// Original was GL_SRGB8_ALPHA8 = 0x8C43
        /// </summary>
        Srgb8Alpha8 = ((int)0x8C43),
        /// <summary>
        /// Original was GL_SRGB8_ALPHA8_EXT = 0x8C43
        /// </summary>
        Srgb8Alpha8Ext = ((int)0x8C43),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB = 0x8C48
        /// </summary>
        CompressedSrgb = ((int)0x8C48),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA = 0x8C49
        /// </summary>
        CompressedSrgbAlpha = ((int)0x8C49),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C
        /// </summary>
        CompressedSrgbS3tcDxt1Ext = ((int)0x8C4C),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D
        /// </summary>
        CompressedSrgbAlphaS3tcDxt1Ext = ((int)0x8C4D),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E
        /// </summary>
        CompressedSrgbAlphaS3tcDxt3Ext = ((int)0x8C4E),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F
        /// </summary>
        CompressedSrgbAlphaS3tcDxt5Ext = ((int)0x8C4F),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76
        /// </summary>
        TransformFeedbackVaryingMaxLength = ((int)0x8C76),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F
        /// </summary>
        TransformFeedbackBufferMode = ((int)0x8C7F),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83
        /// </summary>
        TransformFeedbackVaryings = ((int)0x8C83),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84
        /// </summary>
        TransformFeedbackBufferStart = ((int)0x8C84),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85
        /// </summary>
        TransformFeedbackBufferSize = ((int)0x8C85),
        /// <summary>
        /// Original was GL_PRIMITIVES_GENERATED = 0x8C87
        /// </summary>
        PrimitivesGenerated = ((int)0x8C87),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88
        /// </summary>
        TransformFeedbackPrimitivesWritten = ((int)0x8C88),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        /// </summary>
        TransformFeedbackBuffer = ((int)0x8C8E),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F
        /// </summary>
        TransformFeedbackBufferBinding = ((int)0x8C8F),
        /// <summary>
        /// Original was GL_ATC_RGB_AMD = 0x8C92
        /// </summary>
        AtcRgbAmd = ((int)0x8C92),
        /// <summary>
        /// Original was GL_ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93
        /// </summary>
        AtcRgbaExplicitAlphaAmd = ((int)0x8C93),
        /// <summary>
        /// Original was GL_LOWER_LEFT = 0x8CA1
        /// </summary>
        LowerLeft = ((int)0x8CA1),
        /// <summary>
        /// Original was GL_UPPER_LEFT = 0x8CA2
        /// </summary>
        UpperLeft = ((int)0x8CA2),
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_BINDING_APPLE = 0x8CA6
        /// </summary>
        DrawFramebufferBindingApple = ((int)0x8CA6),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_BINDING_OES = 0x8CA6
        /// </summary>
        FramebufferBindingOes = ((int)0x8CA6),
        /// <summary>
        /// Original was GL_RENDERBUFFER_BINDING_OES = 0x8CA7
        /// </summary>
        RenderbufferBindingOes = ((int)0x8CA7),
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER = 0x8CA8
        /// </summary>
        ReadFramebuffer = ((int)0x8CA8),
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_APPLE = 0x8CA8
        /// </summary>
        ReadFramebufferApple = ((int)0x8CA8),
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER = 0x8CA9
        /// </summary>
        DrawFramebuffer = ((int)0x8CA9),
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_APPLE = 0x8CA9
        /// </summary>
        DrawFramebufferApple = ((int)0x8CA9),
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_BINDING_APPLE = 0x8CAA
        /// </summary>
        ReadFramebufferBindingApple = ((int)0x8CAA),
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES = 0x8CAB
        /// </summary>
        RenderbufferSamples = ((int)0x8CAB),
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_APPLE = 0x8CAB
        /// </summary>
        RenderbufferSamplesApple = ((int)0x8CAB),
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_EXT = 0x8CAB
        /// </summary>
        RenderbufferSamplesExt = ((int)0x8CAB),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        /// </summary>
        DepthComponent32f = ((int)0x8CAC),
        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        /// </summary>
        Depth32fStencil8 = ((int)0x8CAD),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES = 0x8CD0
        /// </summary>
        FramebufferAttachmentObjectTypeOes = ((int)0x8CD0),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectName = ((int)0x8CD1),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectNameOes = ((int)0x8CD1),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevel = ((int)0x8CD2),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevelOes = ((int)0x8CD2),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFaceOes = ((int)0x8CD3),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4
        /// </summary>
        FramebufferAttachmentTextureLayer = ((int)0x8CD4),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE = 0x8CD5
        /// </summary>
        FramebufferComplete = ((int)0x8CD5),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE_OES = 0x8CD5
        /// </summary>
        FramebufferCompleteOes = ((int)0x8CD5),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachment = ((int)0x8CD6),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachmentOes = ((int)0x8CD6),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachment = ((int)0x8CD7),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachmentOes = ((int)0x8CD7),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES = 0x8CD9
        /// </summary>
        FramebufferIncompleteDimensionsOes = ((int)0x8CD9),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES = 0x8CDA
        /// </summary>
        FramebufferIncompleteFormatsOes = ((int)0x8CDA),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB
        /// </summary>
        FramebufferIncompleteDrawBuffer = ((int)0x8CDB),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC
        /// </summary>
        FramebufferIncompleteReadBuffer = ((int)0x8CDC),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD
        /// </summary>
        FramebufferUnsupported = ((int)0x8CDD),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED_OES = 0x8CDD
        /// </summary>
        FramebufferUnsupportedOes = ((int)0x8CDD),
        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS = 0x8CDF
        /// </summary>
        MaxColorAttachments = ((int)0x8CDF),
        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS_EXT = 0x8CDF
        /// </summary>
        MaxColorAttachmentsExt = ((int)0x8CDF),
        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS_NV = 0x8CDF
        /// </summary>
        MaxColorAttachmentsNv = ((int)0x8CDF),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        /// </summary>
        ColorAttachment0 = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_EXT = 0x8CE0
        /// </summary>
        ColorAttachment0Ext = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_NV = 0x8CE0
        /// </summary>
        ColorAttachment0Nv = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_OES = 0x8CE0
        /// </summary>
        ColorAttachment0Oes = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        /// </summary>
        ColorAttachment1 = ((int)0x8CE1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1_EXT = 0x8CE1
        /// </summary>
        ColorAttachment1Ext = ((int)0x8CE1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1_NV = 0x8CE1
        /// </summary>
        ColorAttachment1Nv = ((int)0x8CE1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        /// </summary>
        ColorAttachment2 = ((int)0x8CE2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2_EXT = 0x8CE2
        /// </summary>
        ColorAttachment2Ext = ((int)0x8CE2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2_NV = 0x8CE2
        /// </summary>
        ColorAttachment2Nv = ((int)0x8CE2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        /// </summary>
        ColorAttachment3 = ((int)0x8CE3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3_EXT = 0x8CE3
        /// </summary>
        ColorAttachment3Ext = ((int)0x8CE3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3_NV = 0x8CE3
        /// </summary>
        ColorAttachment3Nv = ((int)0x8CE3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        /// </summary>
        ColorAttachment4 = ((int)0x8CE4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4_EXT = 0x8CE4
        /// </summary>
        ColorAttachment4Ext = ((int)0x8CE4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4_NV = 0x8CE4
        /// </summary>
        ColorAttachment4Nv = ((int)0x8CE4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        /// </summary>
        ColorAttachment5 = ((int)0x8CE5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5_EXT = 0x8CE5
        /// </summary>
        ColorAttachment5Ext = ((int)0x8CE5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5_NV = 0x8CE5
        /// </summary>
        ColorAttachment5Nv = ((int)0x8CE5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        /// </summary>
        ColorAttachment6 = ((int)0x8CE6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6_EXT = 0x8CE6
        /// </summary>
        ColorAttachment6Ext = ((int)0x8CE6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6_NV = 0x8CE6
        /// </summary>
        ColorAttachment6Nv = ((int)0x8CE6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        /// </summary>
        ColorAttachment7 = ((int)0x8CE7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7_EXT = 0x8CE7
        /// </summary>
        ColorAttachment7Ext = ((int)0x8CE7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7_NV = 0x8CE7
        /// </summary>
        ColorAttachment7Nv = ((int)0x8CE7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        /// </summary>
        ColorAttachment8 = ((int)0x8CE8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8_EXT = 0x8CE8
        /// </summary>
        ColorAttachment8Ext = ((int)0x8CE8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8_NV = 0x8CE8
        /// </summary>
        ColorAttachment8Nv = ((int)0x8CE8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        /// </summary>
        ColorAttachment9 = ((int)0x8CE9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9_EXT = 0x8CE9
        /// </summary>
        ColorAttachment9Ext = ((int)0x8CE9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9_NV = 0x8CE9
        /// </summary>
        ColorAttachment9Nv = ((int)0x8CE9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        /// </summary>
        ColorAttachment10 = ((int)0x8CEA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10_EXT = 0x8CEA
        /// </summary>
        ColorAttachment10Ext = ((int)0x8CEA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10_NV = 0x8CEA
        /// </summary>
        ColorAttachment10Nv = ((int)0x8CEA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        /// </summary>
        ColorAttachment11 = ((int)0x8CEB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11_EXT = 0x8CEB
        /// </summary>
        ColorAttachment11Ext = ((int)0x8CEB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11_NV = 0x8CEB
        /// </summary>
        ColorAttachment11Nv = ((int)0x8CEB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        /// </summary>
        ColorAttachment12 = ((int)0x8CEC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12_EXT = 0x8CEC
        /// </summary>
        ColorAttachment12Ext = ((int)0x8CEC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12_NV = 0x8CEC
        /// </summary>
        ColorAttachment12Nv = ((int)0x8CEC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        /// </summary>
        ColorAttachment13 = ((int)0x8CED),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13_EXT = 0x8CED
        /// </summary>
        ColorAttachment13Ext = ((int)0x8CED),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13_NV = 0x8CED
        /// </summary>
        ColorAttachment13Nv = ((int)0x8CED),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        /// </summary>
        ColorAttachment14 = ((int)0x8CEE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14_EXT = 0x8CEE
        /// </summary>
        ColorAttachment14Ext = ((int)0x8CEE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14_NV = 0x8CEE
        /// </summary>
        ColorAttachment14Nv = ((int)0x8CEE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        /// </summary>
        ColorAttachment15 = ((int)0x8CEF),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15_EXT = 0x8CEF
        /// </summary>
        ColorAttachment15Ext = ((int)0x8CEF),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15_NV = 0x8CEF
        /// </summary>
        ColorAttachment15Nv = ((int)0x8CEF),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT16 = 0x8CF0
        /// </summary>
        ColorAttachment16 = ((int)0x8CF0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT17 = 0x8CF1
        /// </summary>
        ColorAttachment17 = ((int)0x8CF1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT18 = 0x8CF2
        /// </summary>
        ColorAttachment18 = ((int)0x8CF2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT19 = 0x8CF3
        /// </summary>
        ColorAttachment19 = ((int)0x8CF3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT20 = 0x8CF4
        /// </summary>
        ColorAttachment20 = ((int)0x8CF4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT21 = 0x8CF5
        /// </summary>
        ColorAttachment21 = ((int)0x8CF5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT22 = 0x8CF6
        /// </summary>
        ColorAttachment22 = ((int)0x8CF6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT23 = 0x8CF7
        /// </summary>
        ColorAttachment23 = ((int)0x8CF7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT24 = 0x8CF8
        /// </summary>
        ColorAttachment24 = ((int)0x8CF8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT25 = 0x8CF9
        /// </summary>
        ColorAttachment25 = ((int)0x8CF9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT26 = 0x8CFA
        /// </summary>
        ColorAttachment26 = ((int)0x8CFA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT27 = 0x8CFB
        /// </summary>
        ColorAttachment27 = ((int)0x8CFB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT28 = 0x8CFC
        /// </summary>
        ColorAttachment28 = ((int)0x8CFC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT29 = 0x8CFD
        /// </summary>
        ColorAttachment29 = ((int)0x8CFD),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT30 = 0x8CFE
        /// </summary>
        ColorAttachment30 = ((int)0x8CFE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT31 = 0x8CFF
        /// </summary>
        ColorAttachment31 = ((int)0x8CFF),
        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT = 0x8D00
        /// </summary>
        DepthAttachment = ((int)0x8D00),
        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_EXT = 0x8D00
        /// </summary>
        DepthAttachmentExt = ((int)0x8D00),
        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_OES = 0x8D00
        /// </summary>
        DepthAttachmentOes = ((int)0x8D00),
        /// <summary>
        /// Original was GL_STENCIL_ATTACHMENT_OES = 0x8D20
        /// </summary>
        StencilAttachmentOes = ((int)0x8D20),
        /// <summary>
        /// Original was GL_FRAMEBUFFER = 0x8D40
        /// </summary>
        Framebuffer = ((int)0x8D40),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_OES = 0x8D40
        /// </summary>
        FramebufferOes = ((int)0x8D40),
        /// <summary>
        /// Original was GL_RENDERBUFFER = 0x8D41
        /// </summary>
        Renderbuffer = ((int)0x8D41),
        /// <summary>
        /// Original was GL_RENDERBUFFER_OES = 0x8D41
        /// </summary>
        RenderbufferOes = ((int)0x8D41),
        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH = 0x8D42
        /// </summary>
        RenderbufferWidth = ((int)0x8D42),
        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH_OES = 0x8D42
        /// </summary>
        RenderbufferWidthOes = ((int)0x8D42),
        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT = 0x8D43
        /// </summary>
        RenderbufferHeight = ((int)0x8D43),
        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT_OES = 0x8D43
        /// </summary>
        RenderbufferHeightOes = ((int)0x8D43),
        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44
        /// </summary>
        RenderbufferInternalFormat = ((int)0x8D44),
        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT_OES = 0x8D44
        /// </summary>
        RenderbufferInternalFormatOes = ((int)0x8D44),
        /// <summary>
        /// Original was GL_STENCIL_INDEX1_OES = 0x8D46
        /// </summary>
        StencilIndex1Oes = ((int)0x8D46),
        /// <summary>
        /// Original was GL_STENCIL_INDEX4_OES = 0x8D47
        /// </summary>
        StencilIndex4Oes = ((int)0x8D47),
        /// <summary>
        /// Original was GL_STENCIL_INDEX8_OES = 0x8D48
        /// </summary>
        StencilIndex8Oes = ((int)0x8D48),
        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE = 0x8D50
        /// </summary>
        RenderbufferRedSize = ((int)0x8D50),
        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE_OES = 0x8D50
        /// </summary>
        RenderbufferRedSizeOes = ((int)0x8D50),
        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE = 0x8D51
        /// </summary>
        RenderbufferGreenSize = ((int)0x8D51),
        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE_OES = 0x8D51
        /// </summary>
        RenderbufferGreenSizeOes = ((int)0x8D51),
        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE = 0x8D52
        /// </summary>
        RenderbufferBlueSize = ((int)0x8D52),
        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE_OES = 0x8D52
        /// </summary>
        RenderbufferBlueSizeOes = ((int)0x8D52),
        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53
        /// </summary>
        RenderbufferAlphaSize = ((int)0x8D53),
        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE_OES = 0x8D53
        /// </summary>
        RenderbufferAlphaSizeOes = ((int)0x8D53),
        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54
        /// </summary>
        RenderbufferDepthSize = ((int)0x8D54),
        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE_OES = 0x8D54
        /// </summary>
        RenderbufferDepthSizeOes = ((int)0x8D54),
        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55
        /// </summary>
        RenderbufferStencilSize = ((int)0x8D55),
        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE_OES = 0x8D55
        /// </summary>
        RenderbufferStencilSizeOes = ((int)0x8D55),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisample = ((int)0x8D56),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisampleApple = ((int)0x8D56),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisampleExt = ((int)0x8D56),
        /// <summary>
        /// Original was GL_MAX_SAMPLES_APPLE = 0x8D57
        /// </summary>
        MaxSamplesApple = ((int)0x8D57),
        /// <summary>
        /// Original was GL_MAX_SAMPLES_EXT = 0x8D57
        /// </summary>
        MaxSamplesExt = ((int)0x8D57),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_STR_OES = 0x8D60
        /// </summary>
        TextureGenStrOes = ((int)0x8D60),
        /// <summary>
        /// Original was GL_RGB565_OES = 0x8D62
        /// </summary>
        Rgb565Oes = ((int)0x8D62),
        /// <summary>
        /// Original was GL_ETC1_RGB8_OES = 0x8D64
        /// </summary>
        Etc1Rgb8Oes = ((int)0x8D64),
        /// <summary>
        /// Original was GL_TEXTURE_EXTERNAL_OES = 0x8D65
        /// </summary>
        TextureExternalOes = ((int)0x8D65),
        /// <summary>
        /// Original was GL_SAMPLER_EXTERNAL_OES = 0x8D66
        /// </summary>
        SamplerExternalOes = ((int)0x8D66),
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_EXTERNAL_OES = 0x8D67
        /// </summary>
        TextureBindingExternalOes = ((int)0x8D67),
        /// <summary>
        /// Original was GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES = 0x8D68
        /// </summary>
        RequiredTextureImageUnitsOes = ((int)0x8D68),
        /// <summary>
        /// Original was GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A
        /// </summary>
        AnySamplesPassedConservative = ((int)0x8D6A),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT = 0x8D6C
        /// </summary>
        FramebufferAttachmentTextureSamplesExt = ((int)0x8D6C),
        /// <summary>
        /// Original was GL_RGBA32UI = 0x8D70
        /// </summary>
        Rgba32ui = ((int)0x8D70),
        /// <summary>
        /// Original was GL_RGB32UI = 0x8D71
        /// </summary>
        Rgb32ui = ((int)0x8D71),
        /// <summary>
        /// Original was GL_RGBA16UI = 0x8D76
        /// </summary>
        Rgba16ui = ((int)0x8D76),
        /// <summary>
        /// Original was GL_RGB16UI = 0x8D77
        /// </summary>
        Rgb16ui = ((int)0x8D77),
        /// <summary>
        /// Original was GL_RGBA8UI = 0x8D7C
        /// </summary>
        Rgba8ui = ((int)0x8D7C),
        /// <summary>
        /// Original was GL_RGB8UI = 0x8D7D
        /// </summary>
        Rgb8ui = ((int)0x8D7D),
        /// <summary>
        /// Original was GL_RGBA32I = 0x8D82
        /// </summary>
        Rgba32i = ((int)0x8D82),
        /// <summary>
        /// Original was GL_RGB32I = 0x8D83
        /// </summary>
        Rgb32i = ((int)0x8D83),
        /// <summary>
        /// Original was GL_RGBA16I = 0x8D88
        /// </summary>
        Rgba16i = ((int)0x8D88),
        /// <summary>
        /// Original was GL_RGB16I = 0x8D89
        /// </summary>
        Rgb16i = ((int)0x8D89),
        /// <summary>
        /// Original was GL_RGBA8I = 0x8D8E
        /// </summary>
        Rgba8i = ((int)0x8D8E),
        /// <summary>
        /// Original was GL_RGB8I = 0x8D8F
        /// </summary>
        Rgb8i = ((int)0x8D8F),
        /// <summary>
        /// Original was GL_INT_2_10_10_10_REV = 0x8D9F
        /// </summary>
        Int2101010Rev = ((int)0x8D9F),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7
        /// </summary>
        FramebufferAttachmentLayered = ((int)0x8DA7),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8
        /// </summary>
        FramebufferIncompleteLayerTargets = ((int)0x8DA8),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F_NV = 0x8DAB
        /// </summary>
        DepthComponent32fNv = ((int)0x8DAB),
        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8_NV = 0x8DAC
        /// </summary>
        Depth32fStencil8Nv = ((int)0x8DAC),
        /// <summary>
        /// Original was GL_COMPRESSED_RED_RGTC1 = 0x8DBB
        /// </summary>
        CompressedRedRgtc1 = ((int)0x8DBB),
        /// <summary>
        /// Original was GL_COMPRESSED_RED_RGTC1_EXT = 0x8DBB
        /// </summary>
        CompressedRedRgtc1Ext = ((int)0x8DBB),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC
        /// </summary>
        CompressedSignedRedRgtc1 = ((int)0x8DBC),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC
        /// </summary>
        CompressedSignedRedRgtc1Ext = ((int)0x8DBC),
        /// <summary>
        /// Original was GL_COMPRESSED_RG_RGTC2 = 0x8DBD
        /// </summary>
        CompressedRgRgtc2 = ((int)0x8DBD),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE
        /// </summary>
        CompressedSignedRgRgtc2 = ((int)0x8DBE),
        /// <summary>
        /// Original was GL_GEOMETRY_SHADER = 0x8DD9
        /// </summary>
        GeometryShader = ((int)0x8DD9),
        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINES = 0x8DE5
        /// </summary>
        ActiveSubroutines = ((int)0x8DE5),
        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6
        /// </summary>
        ActiveSubroutineUniforms = ((int)0x8DE6),
        /// <summary>
        /// Original was GL_LOW_FLOAT = 0x8DF0
        /// </summary>
        LowFloat = ((int)0x8DF0),
        /// <summary>
        /// Original was GL_MEDIUM_FLOAT = 0x8DF1
        /// </summary>
        MediumFloat = ((int)0x8DF1),
        /// <summary>
        /// Original was GL_HIGH_FLOAT = 0x8DF2
        /// </summary>
        HighFloat = ((int)0x8DF2),
        /// <summary>
        /// Original was GL_LOW_INT = 0x8DF3
        /// </summary>
        LowInt = ((int)0x8DF3),
        /// <summary>
        /// Original was GL_MEDIUM_INT = 0x8DF4
        /// </summary>
        MediumInt = ((int)0x8DF4),
        /// <summary>
        /// Original was GL_HIGH_INT = 0x8DF5
        /// </summary>
        HighInt = ((int)0x8DF5),
        /// <summary>
        /// Original was GL_QUERY_WAIT = 0x8E13
        /// </summary>
        QueryWait = ((int)0x8E13),
        /// <summary>
        /// Original was GL_QUERY_NO_WAIT = 0x8E14
        /// </summary>
        QueryNoWait = ((int)0x8E14),
        /// <summary>
        /// Original was GL_QUERY_BY_REGION_WAIT = 0x8E15
        /// </summary>
        QueryByRegionWait = ((int)0x8E15),
        /// <summary>
        /// Original was GL_QUERY_BY_REGION_NO_WAIT = 0x8E16
        /// </summary>
        QueryByRegionNoWait = ((int)0x8E16),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK = 0x8E22
        /// </summary>
        TransformFeedback = ((int)0x8E22),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23
        /// </summary>
        TransformFeedbackPaused = ((int)0x8E23),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24
        /// </summary>
        TransformFeedbackActive = ((int)0x8E24),
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_R = 0x8E42
        /// </summary>
        TextureSwizzleR = ((int)0x8E42),
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_G = 0x8E43
        /// </summary>
        TextureSwizzleG = ((int)0x8E43),
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_B = 0x8E44
        /// </summary>
        TextureSwizzleB = ((int)0x8E44),
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_A = 0x8E45
        /// </summary>
        TextureSwizzleA = ((int)0x8E45),
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_RGBA = 0x8E46
        /// </summary>
        TextureSwizzleRgba = ((int)0x8E46),
        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47
        /// </summary>
        ActiveSubroutineUniformLocations = ((int)0x8E47),
        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48
        /// </summary>
        ActiveSubroutineMaxLength = ((int)0x8E48),
        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49
        /// </summary>
        ActiveSubroutineUniformMaxLength = ((int)0x8E49),
        /// <summary>
        /// Original was GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A
        /// </summary>
        NumCompatibleSubroutines = ((int)0x8E4A),
        /// <summary>
        /// Original was GL_COMPATIBLE_SUBROUTINES = 0x8E4B
        /// </summary>
        CompatibleSubroutines = ((int)0x8E4B),
        /// <summary>
        /// Original was GL_FIRST_VERTEX_CONVENTION = 0x8E4D
        /// </summary>
        FirstVertexConvention = ((int)0x8E4D),
        /// <summary>
        /// Original was GL_LAST_VERTEX_CONVENTION = 0x8E4E
        /// </summary>
        LastVertexConvention = ((int)0x8E4E),
        /// <summary>
        /// Original was GL_PATCH_VERTICES = 0x8E72
        /// </summary>
        PatchVertices = ((int)0x8E72),
        /// <summary>
        /// Original was GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73
        /// </summary>
        PatchDefaultInnerLevel = ((int)0x8E73),
        /// <summary>
        /// Original was GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74
        /// </summary>
        PatchDefaultOuterLevel = ((int)0x8E74),
        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER = 0x8E87
        /// </summary>
        TessEvaluationShader = ((int)0x8E87),
        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER = 0x8E88
        /// </summary>
        TessControlShader = ((int)0x8E88),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
        /// </summary>
        CompressedRgbaBptcUnorm = ((int)0x8E8C),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D
        /// </summary>
        CompressedSrgbAlphaBptcUnorm = ((int)0x8E8D),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
        /// </summary>
        CompressedRgbBptcSignedFloat = ((int)0x8E8E),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
        /// </summary>
        CompressedRgbBptcUnsignedFloat = ((int)0x8E8F),
        /// <summary>
        /// Original was GL_COPY_READ_BUFFER = 0x8F36
        /// </summary>
        CopyReadBuffer = ((int)0x8F36),
        /// <summary>
        /// Original was GL_COPY_WRITE_BUFFER = 0x8F37
        /// </summary>
        CopyWriteBuffer = ((int)0x8F37),
        /// <summary>
        /// Original was GL_DRAW_INDIRECT_BUFFER = 0x8F3F
        /// </summary>
        DrawIndirectBuffer = ((int)0x8F3F),
        /// <summary>
        /// Original was GL_R8_SNORM = 0x8F94
        /// </summary>
        R8Snorm = ((int)0x8F94),
        /// <summary>
        /// Original was GL_RG8_SNORM = 0x8F95
        /// </summary>
        Rg8Snorm = ((int)0x8F95),
        /// <summary>
        /// Original was GL_RGB8_SNORM = 0x8F96
        /// </summary>
        Rgb8Snorm = ((int)0x8F96),
        /// <summary>
        /// Original was GL_RGBA8_SNORM = 0x8F97
        /// </summary>
        Rgba8Snorm = ((int)0x8F97),
        /// <summary>
        /// Original was GL_R16_SNORM = 0x8F98
        /// </summary>
        R16Snorm = ((int)0x8F98),
        /// <summary>
        /// Original was GL_R16_SNORM_EXT = 0x8F98
        /// </summary>
        R16SnormExt = ((int)0x8F98),
        /// <summary>
        /// Original was GL_RG16_SNORM = 0x8F99
        /// </summary>
        Rg16Snorm = ((int)0x8F99),
        /// <summary>
        /// Original was GL_RG16_SNORM_EXT = 0x8F99
        /// </summary>
        Rg16SnormExt = ((int)0x8F99),
        /// <summary>
        /// Original was GL_RGB16_SNORM = 0x8F9A
        /// </summary>
        Rgb16Snorm = ((int)0x8F9A),
        /// <summary>
        /// Original was GL_RGB16_SNORM_EXT = 0x8F9A
        /// </summary>
        Rgb16SnormExt = ((int)0x8F9A),
        /// <summary>
        /// Original was GL_PERFMON_GLOBAL_MODE_QCOM = 0x8FA0
        /// </summary>
        PerfmonGlobalModeQcom = ((int)0x8FA0),
        /// <summary>
        /// Original was GL_BINNING_CONTROL_HINT_QCOM = 0x8FB0
        /// </summary>
        BinningControlHintQcom = ((int)0x8FB0),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009
        /// </summary>
        TextureCubeMapArray = ((int)0x9009),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009
        /// </summary>
        TextureCubeMapArrayArb = ((int)0x9009),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_EXT = 0x9009
        /// </summary>
        TextureCubeMapArrayExt = ((int)0x9009),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_OES = 0x9009
        /// </summary>
        TextureCubeMapArrayOes = ((int)0x9009),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B
        /// </summary>
        ProxyTextureCubeMapArray = ((int)0x900B),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B
        /// </summary>
        ProxyTextureCubeMapArrayArb = ((int)0x900B),
        /// <summary>
        /// Original was GL_RGB10_A2UI = 0x906F
        /// </summary>
        Rgb10A2ui = ((int)0x906F),
        /// <summary>
        /// Original was GL_PATH_FORMAT_SVG_NV = 0x9070
        /// </summary>
        PathFormatSvgNv = ((int)0x9070),
        /// <summary>
        /// Original was GL_PATH_FORMAT_PS_NV = 0x9071
        /// </summary>
        PathFormatPsNv = ((int)0x9071),
        /// <summary>
        /// Original was GL_STANDARD_FONT_NAME_NV = 0x9072
        /// </summary>
        StandardFontNameNv = ((int)0x9072),
        /// <summary>
        /// Original was GL_SYSTEM_FONT_NAME_NV = 0x9073
        /// </summary>
        SystemFontNameNv = ((int)0x9073),
        /// <summary>
        /// Original was GL_FILE_NAME_NV = 0x9074
        /// </summary>
        FileNameNv = ((int)0x9074),
        /// <summary>
        /// Original was GL_PATH_STROKE_WIDTH_NV = 0x9075
        /// </summary>
        PathStrokeWidthNv = ((int)0x9075),
        /// <summary>
        /// Original was GL_PATH_END_CAPS_NV = 0x9076
        /// </summary>
        PathEndCapsNv = ((int)0x9076),
        /// <summary>
        /// Original was GL_PATH_INITIAL_END_CAP_NV = 0x9077
        /// </summary>
        PathInitialEndCapNv = ((int)0x9077),
        /// <summary>
        /// Original was GL_PATH_TERMINAL_END_CAP_NV = 0x9078
        /// </summary>
        PathTerminalEndCapNv = ((int)0x9078),
        /// <summary>
        /// Original was GL_PATH_JOIN_STYLE_NV = 0x9079
        /// </summary>
        PathJoinStyleNv = ((int)0x9079),
        /// <summary>
        /// Original was GL_PATH_MITER_LIMIT_NV = 0x907A
        /// </summary>
        PathMiterLimitNv = ((int)0x907A),
        /// <summary>
        /// Original was GL_PATH_DASH_CAPS_NV = 0x907B
        /// </summary>
        PathDashCapsNv = ((int)0x907B),
        /// <summary>
        /// Original was GL_PATH_INITIAL_DASH_CAP_NV = 0x907C
        /// </summary>
        PathInitialDashCapNv = ((int)0x907C),
        /// <summary>
        /// Original was GL_PATH_TERMINAL_DASH_CAP_NV = 0x907D
        /// </summary>
        PathTerminalDashCapNv = ((int)0x907D),
        /// <summary>
        /// Original was GL_PATH_DASH_OFFSET_NV = 0x907E
        /// </summary>
        PathDashOffsetNv = ((int)0x907E),
        /// <summary>
        /// Original was GL_PATH_CLIENT_LENGTH_NV = 0x907F
        /// </summary>
        PathClientLengthNv = ((int)0x907F),
        /// <summary>
        /// Original was GL_PATH_FILL_MODE_NV = 0x9080
        /// </summary>
        PathFillModeNv = ((int)0x9080),
        /// <summary>
        /// Original was GL_PATH_FILL_MASK_NV = 0x9081
        /// </summary>
        PathFillMaskNv = ((int)0x9081),
        /// <summary>
        /// Original was GL_PATH_FILL_COVER_MODE_NV = 0x9082
        /// </summary>
        PathFillCoverModeNv = ((int)0x9082),
        /// <summary>
        /// Original was GL_PATH_STROKE_COVER_MODE_NV = 0x9083
        /// </summary>
        PathStrokeCoverModeNv = ((int)0x9083),
        /// <summary>
        /// Original was GL_PATH_STROKE_MASK_NV = 0x9084
        /// </summary>
        PathStrokeMaskNv = ((int)0x9084),
        /// <summary>
        /// Original was GL_COUNT_UP_NV = 0x9088
        /// </summary>
        CountUpNv = ((int)0x9088),
        /// <summary>
        /// Original was GL_COUNT_DOWN_NV = 0x9089
        /// </summary>
        CountDownNv = ((int)0x9089),
        /// <summary>
        /// Original was GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A
        /// </summary>
        PathObjectBoundingBoxNv = ((int)0x908A),
        /// <summary>
        /// Original was GL_CONVEX_HULL_NV = 0x908B
        /// </summary>
        ConvexHullNv = ((int)0x908B),
        /// <summary>
        /// Original was GL_BOUNDING_BOX_NV = 0x908D
        /// </summary>
        BoundingBoxNv = ((int)0x908D),
        /// <summary>
        /// Original was GL_TRANSLATE_X_NV = 0x908E
        /// </summary>
        TranslateXNv = ((int)0x908E),
        /// <summary>
        /// Original was GL_TRANSLATE_Y_NV = 0x908F
        /// </summary>
        TranslateYNv = ((int)0x908F),
        /// <summary>
        /// Original was GL_TRANSLATE_2D_NV = 0x9090
        /// </summary>
        Translate2DNv = ((int)0x9090),
        /// <summary>
        /// Original was GL_TRANSLATE_3D_NV = 0x9091
        /// </summary>
        Translate3DNv = ((int)0x9091),
        /// <summary>
        /// Original was GL_AFFINE_2D_NV = 0x9092
        /// </summary>
        Affine2DNv = ((int)0x9092),
        /// <summary>
        /// Original was GL_AFFINE_3D_NV = 0x9094
        /// </summary>
        Affine3DNv = ((int)0x9094),
        /// <summary>
        /// Original was GL_TRANSPOSE_AFFINE_2D_NV = 0x9096
        /// </summary>
        TransposeAffine2DNv = ((int)0x9096),
        /// <summary>
        /// Original was GL_TRANSPOSE_AFFINE_3D_NV = 0x9098
        /// </summary>
        TransposeAffine3DNv = ((int)0x9098),
        /// <summary>
        /// Original was GL_UTF8_NV = 0x909A
        /// </summary>
        Utf8Nv = ((int)0x909A),
        /// <summary>
        /// Original was GL_UTF16_NV = 0x909B
        /// </summary>
        Utf16Nv = ((int)0x909B),
        /// <summary>
        /// Original was GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C
        /// </summary>
        BoundingBoxOfBoundingBoxesNv = ((int)0x909C),
        /// <summary>
        /// Original was GL_PATH_COMMAND_COUNT_NV = 0x909D
        /// </summary>
        PathCommandCountNv = ((int)0x909D),
        /// <summary>
        /// Original was GL_PATH_COORD_COUNT_NV = 0x909E
        /// </summary>
        PathCoordCountNv = ((int)0x909E),
        /// <summary>
        /// Original was GL_PATH_DASH_ARRAY_COUNT_NV = 0x909F
        /// </summary>
        PathDashArrayCountNv = ((int)0x909F),
        /// <summary>
        /// Original was GL_PATH_COMPUTED_LENGTH_NV = 0x90A0
        /// </summary>
        PathComputedLengthNv = ((int)0x90A0),
        /// <summary>
        /// Original was GL_PATH_FILL_BOUNDING_BOX_NV = 0x90A1
        /// </summary>
        PathFillBoundingBoxNv = ((int)0x90A1),
        /// <summary>
        /// Original was GL_PATH_STROKE_BOUNDING_BOX_NV = 0x90A2
        /// </summary>
        PathStrokeBoundingBoxNv = ((int)0x90A2),
        /// <summary>
        /// Original was GL_SKIP_MISSING_GLYPH_NV = 0x90A9
        /// </summary>
        SkipMissingGlyphNv = ((int)0x90A9),
        /// <summary>
        /// Original was GL_USE_MISSING_GLYPH_NV = 0x90AA
        /// </summary>
        UseMissingGlyphNv = ((int)0x90AA),
        /// <summary>
        /// Original was GL_ACCUM_ADJACENT_PAIRS_NV = 0x90AD
        /// </summary>
        AccumAdjacentPairsNv = ((int)0x90AD),
        /// <summary>
        /// Original was GL_ADJACENT_PAIRS_NV = 0x90AE
        /// </summary>
        AdjacentPairsNv = ((int)0x90AE),
        /// <summary>
        /// Original was GL_FIRST_TO_REST_NV = 0x90AF
        /// </summary>
        FirstToRestNv = ((int)0x90AF),
        /// <summary>
        /// Original was GL_PATH_DASH_OFFSET_RESET_NV = 0x90B4
        /// </summary>
        PathDashOffsetResetNv = ((int)0x90B4),
        /// <summary>
        /// Original was GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7
        /// </summary>
        ImageFormatCompatibilityType = ((int)0x90C7),
        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER = 0x90D2
        /// </summary>
        ShaderStorageBuffer = ((int)0x90D2),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA
        /// </summary>
        DepthStencilTextureMode = ((int)0x90EA),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC
        /// </summary>
        UniformBlockReferencedByComputeShader = ((int)0x90EC),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED
        /// </summary>
        AtomicCounterBufferReferencedByComputeShader = ((int)0x90ED),
        /// <summary>
        /// Original was GL_DISPATCH_INDIRECT_BUFFER = 0x90EE
        /// </summary>
        DispatchIndirectBuffer = ((int)0x90EE),
        /// <summary>
        /// Original was GL_CONTEXT_ROBUST_ACCESS_EXT = 0x90F3
        /// </summary>
        ContextRobustAccessExt = ((int)0x90F3),
        /// <summary>
        /// Original was GL_TEXTURE_2D_MULTISAMPLE = 0x9100
        /// </summary>
        Texture2DMultisample = ((int)0x9100),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101
        /// </summary>
        ProxyTexture2DMultisample = ((int)0x9101),
        /// <summary>
        /// Original was GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102
        /// </summary>
        Texture2DMultisampleArray = ((int)0x9102),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103
        /// </summary>
        ProxyTexture2DMultisampleArray = ((int)0x9103),
        /// <summary>
        /// Original was GL_MAX_SERVER_WAIT_TIMEOUT_APPLE = 0x9111
        /// </summary>
        MaxServerWaitTimeoutApple = ((int)0x9111),
        /// <summary>
        /// Original was GL_OBJECT_TYPE = 0x9112
        /// </summary>
        ObjectType = ((int)0x9112),
        /// <summary>
        /// Original was GL_OBJECT_TYPE_APPLE = 0x9112
        /// </summary>
        ObjectTypeApple = ((int)0x9112),
        /// <summary>
        /// Original was GL_SYNC_CONDITION = 0x9113
        /// </summary>
        SyncCondition = ((int)0x9113),
        /// <summary>
        /// Original was GL_SYNC_CONDITION_APPLE = 0x9113
        /// </summary>
        SyncConditionApple = ((int)0x9113),
        /// <summary>
        /// Original was GL_SYNC_STATUS = 0x9114
        /// </summary>
        SyncStatus = ((int)0x9114),
        /// <summary>
        /// Original was GL_SYNC_STATUS_APPLE = 0x9114
        /// </summary>
        SyncStatusApple = ((int)0x9114),
        /// <summary>
        /// Original was GL_SYNC_FLAGS = 0x9115
        /// </summary>
        SyncFlags = ((int)0x9115),
        /// <summary>
        /// Original was GL_SYNC_FLAGS_APPLE = 0x9115
        /// </summary>
        SyncFlagsApple = ((int)0x9115),
        /// <summary>
        /// Original was GL_SYNC_FENCE_APPLE = 0x9116
        /// </summary>
        SyncFenceApple = ((int)0x9116),
        /// <summary>
        /// Original was GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117
        /// </summary>
        SyncGpuCommandsComplete = ((int)0x9117),
        /// <summary>
        /// Original was GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE = 0x9117
        /// </summary>
        SyncGpuCommandsCompleteApple = ((int)0x9117),
        /// <summary>
        /// Original was GL_UNSIGNALED_APPLE = 0x9118
        /// </summary>
        UnsignaledApple = ((int)0x9118),
        /// <summary>
        /// Original was GL_SIGNALED_APPLE = 0x9119
        /// </summary>
        SignaledApple = ((int)0x9119),
        /// <summary>
        /// Original was GL_ALREADY_SIGNALED = 0x911A
        /// </summary>
        AlreadySignaled = ((int)0x911A),
        /// <summary>
        /// Original was GL_ALREADY_SIGNALED_APPLE = 0x911A
        /// </summary>
        AlreadySignaledApple = ((int)0x911A),
        /// <summary>
        /// Original was GL_TIMEOUT_EXPIRED = 0x911B
        /// </summary>
        TimeoutExpired = ((int)0x911B),
        /// <summary>
        /// Original was GL_TIMEOUT_EXPIRED_APPLE = 0x911B
        /// </summary>
        TimeoutExpiredApple = ((int)0x911B),
        /// <summary>
        /// Original was GL_CONDITION_SATISFIED = 0x911C
        /// </summary>
        ConditionSatisfied = ((int)0x911C),
        /// <summary>
        /// Original was GL_CONDITION_SATISFIED_APPLE = 0x911C
        /// </summary>
        ConditionSatisfiedApple = ((int)0x911C),
        /// <summary>
        /// Original was GL_WAIT_FAILED = 0x911D
        /// </summary>
        WaitFailed = ((int)0x911D),
        /// <summary>
        /// Original was GL_WAIT_FAILED_APPLE = 0x911D
        /// </summary>
        WaitFailedApple = ((int)0x911D),
        /// <summary>
        /// Original was GL_BUFFER_ACCESS_FLAGS = 0x911F
        /// </summary>
        BufferAccessFlags = ((int)0x911F),
        /// <summary>
        /// Original was GL_BUFFER_MAP_LENGTH = 0x9120
        /// </summary>
        BufferMapLength = ((int)0x9120),
        /// <summary>
        /// Original was GL_BUFFER_MAP_OFFSET = 0x9121
        /// </summary>
        BufferMapOffset = ((int)0x9121),
        /// <summary>
        /// Original was GL_TEXTURE_IMMUTABLE_FORMAT_EXT = 0x912F
        /// </summary>
        TextureImmutableFormatExt = ((int)0x912F),
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_IMG = 0x9133
        /// </summary>
        RenderbufferSamplesImg = ((int)0x9133),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG = 0x9134
        /// </summary>
        FramebufferIncompleteMultisampleImg = ((int)0x9134),
        /// <summary>
        /// Original was GL_MAX_SAMPLES_IMG = 0x9135
        /// </summary>
        MaxSamplesImg = ((int)0x9135),
        /// <summary>
        /// Original was GL_TEXTURE_SAMPLES_IMG = 0x9136
        /// </summary>
        TextureSamplesImg = ((int)0x9136),
        /// <summary>
        /// Original was GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143
        /// </summary>
        MaxDebugMessageLength = ((int)0x9143),
        /// <summary>
        /// Original was GL_MAX_DEBUG_MESSAGE_LENGTH_KHR = 0x9143
        /// </summary>
        MaxDebugMessageLengthKhr = ((int)0x9143),
        /// <summary>
        /// Original was GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144
        /// </summary>
        MaxDebugLoggedMessages = ((int)0x9144),
        /// <summary>
        /// Original was GL_MAX_DEBUG_LOGGED_MESSAGES_KHR = 0x9144
        /// </summary>
        MaxDebugLoggedMessagesKhr = ((int)0x9144),
        /// <summary>
        /// Original was GL_DEBUG_LOGGED_MESSAGES = 0x9145
        /// </summary>
        DebugLoggedMessages = ((int)0x9145),
        /// <summary>
        /// Original was GL_DEBUG_LOGGED_MESSAGES_KHR = 0x9145
        /// </summary>
        DebugLoggedMessagesKhr = ((int)0x9145),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_HIGH = 0x9146
        /// </summary>
        DebugSeverityHigh = ((int)0x9146),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_HIGH_KHR = 0x9146
        /// </summary>
        DebugSeverityHighKhr = ((int)0x9146),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_MEDIUM = 0x9147
        /// </summary>
        DebugSeverityMedium = ((int)0x9147),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_MEDIUM_KHR = 0x9147
        /// </summary>
        DebugSeverityMediumKhr = ((int)0x9147),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_LOW = 0x9148
        /// </summary>
        DebugSeverityLow = ((int)0x9148),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_LOW_KHR = 0x9148
        /// </summary>
        DebugSeverityLowKhr = ((int)0x9148),
        /// <summary>
        /// Original was GL_QUERY_BUFFER = 0x9192
        /// </summary>
        QueryBuffer = ((int)0x9192),
        /// <summary>
        /// Original was GL_QUERY_RESULT_NO_WAIT = 0x9194
        /// </summary>
        QueryResultNoWait = ((int)0x9194),
        /// <summary>
        /// Original was GL_COMPUTE_SHADER = 0x91B9
        /// </summary>
        ComputeShader = ((int)0x91B9),
        /// <summary>
        /// Original was GL_COMPRESSED_R11_EAC = 0x9270
        /// </summary>
        CompressedR11Eac = ((int)0x9270),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_R11_EAC = 0x9271
        /// </summary>
        CompressedSignedR11Eac = ((int)0x9271),
        /// <summary>
        /// Original was GL_COMPRESSED_RG11_EAC = 0x9272
        /// </summary>
        CompressedRg11Eac = ((int)0x9272),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273
        /// </summary>
        CompressedSignedRg11Eac = ((int)0x9273),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB8_ETC2 = 0x9274
        /// </summary>
        CompressedRgb8Etc2 = ((int)0x9274),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ETC2 = 0x9275
        /// </summary>
        CompressedSrgb8Etc2 = ((int)0x9275),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276
        /// </summary>
        CompressedRgb8PunchthroughAlpha1Etc2 = ((int)0x9276),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277
        /// </summary>
        CompressedSrgb8PunchthroughAlpha1Etc2 = ((int)0x9277),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278
        /// </summary>
        CompressedRgba8Etc2Eac = ((int)0x9278),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279
        /// </summary>
        CompressedSrgb8Alpha8Etc2Eac = ((int)0x9279),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        /// </summary>
        AtomicCounterBuffer = ((int)0x92C0),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1
        /// </summary>
        AtomicCounterBufferBinding = ((int)0x92C1),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4
        /// </summary>
        AtomicCounterBufferDataSize = ((int)0x92C4),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5
        /// </summary>
        AtomicCounterBufferActiveAtomicCounters = ((int)0x92C5),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6
        /// </summary>
        AtomicCounterBufferActiveAtomicCounterIndices = ((int)0x92C6),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7
        /// </summary>
        AtomicCounterBufferReferencedByVertexShader = ((int)0x92C7),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8
        /// </summary>
        AtomicCounterBufferReferencedByTessControlShader = ((int)0x92C8),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9
        /// </summary>
        AtomicCounterBufferReferencedByTessEvaluationShader = ((int)0x92C9),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA
        /// </summary>
        AtomicCounterBufferReferencedByGeometryShader = ((int)0x92CA),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB
        /// </summary>
        AtomicCounterBufferReferencedByFragmentShader = ((int)0x92CB),
        /// <summary>
        /// Original was GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9
        /// </summary>
        ActiveAtomicCounterBuffers = ((int)0x92D9),
        /// <summary>
        /// Original was GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA
        /// </summary>
        UniformAtomicCounterBufferIndex = ((int)0x92DA),
        /// <summary>
        /// Original was GL_DEBUG_OUTPUT = 0x92E0
        /// </summary>
        DebugOutput = ((int)0x92E0),
        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_KHR = 0x92E0
        /// </summary>
        DebugOutputKhr = ((int)0x92E0),
        /// <summary>
        /// Original was GL_UNIFORM = 0x92E1
        /// </summary>
        Uniform = ((int)0x92E1),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK = 0x92E2
        /// </summary>
        UniformBlock = ((int)0x92E2),
        /// <summary>
        /// Original was GL_PROGRAM_INPUT = 0x92E3
        /// </summary>
        ProgramInput = ((int)0x92E3),
        /// <summary>
        /// Original was GL_PROGRAM_OUTPUT = 0x92E4
        /// </summary>
        ProgramOutput = ((int)0x92E4),
        /// <summary>
        /// Original was GL_BUFFER_VARIABLE = 0x92E5
        /// </summary>
        BufferVariable = ((int)0x92E5),
        /// <summary>
        /// Original was GL_SHADER_STORAGE_BLOCK = 0x92E6
        /// </summary>
        ShaderStorageBlock = ((int)0x92E6),
        /// <summary>
        /// Original was GL_VERTEX_SUBROUTINE = 0x92E8
        /// </summary>
        VertexSubroutine = ((int)0x92E8),
        /// <summary>
        /// Original was GL_TESS_CONTROL_SUBROUTINE = 0x92E9
        /// </summary>
        TessControlSubroutine = ((int)0x92E9),
        /// <summary>
        /// Original was GL_TESS_EVALUATION_SUBROUTINE = 0x92EA
        /// </summary>
        TessEvaluationSubroutine = ((int)0x92EA),
        /// <summary>
        /// Original was GL_GEOMETRY_SUBROUTINE = 0x92EB
        /// </summary>
        GeometrySubroutine = ((int)0x92EB),
        /// <summary>
        /// Original was GL_FRAGMENT_SUBROUTINE = 0x92EC
        /// </summary>
        FragmentSubroutine = ((int)0x92EC),
        /// <summary>
        /// Original was GL_COMPUTE_SUBROUTINE = 0x92ED
        /// </summary>
        ComputeSubroutine = ((int)0x92ED),
        /// <summary>
        /// Original was GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE
        /// </summary>
        VertexSubroutineUniform = ((int)0x92EE),
        /// <summary>
        /// Original was GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF
        /// </summary>
        TessControlSubroutineUniform = ((int)0x92EF),
        /// <summary>
        /// Original was GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0
        /// </summary>
        TessEvaluationSubroutineUniform = ((int)0x92F0),
        /// <summary>
        /// Original was GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1
        /// </summary>
        GeometrySubroutineUniform = ((int)0x92F1),
        /// <summary>
        /// Original was GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2
        /// </summary>
        FragmentSubroutineUniform = ((int)0x92F2),
        /// <summary>
        /// Original was GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3
        /// </summary>
        ComputeSubroutineUniform = ((int)0x92F3),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4
        /// </summary>
        TransformFeedbackVarying = ((int)0x92F4),
        /// <summary>
        /// Original was GL_ACTIVE_RESOURCES = 0x92F5
        /// </summary>
        ActiveResources = ((int)0x92F5),
        /// <summary>
        /// Original was GL_MAX_NAME_LENGTH = 0x92F6
        /// </summary>
        MaxNameLength = ((int)0x92F6),
        /// <summary>
        /// Original was GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7
        /// </summary>
        MaxNumActiveVariables = ((int)0x92F7),
        /// <summary>
        /// Original was GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8
        /// </summary>
        MaxNumCompatibleSubroutines = ((int)0x92F8),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310
        /// </summary>
        FramebufferDefaultWidth = ((int)0x9310),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311
        /// </summary>
        FramebufferDefaultHeight = ((int)0x9311),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312
        /// </summary>
        FramebufferDefaultLayers = ((int)0x9312),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313
        /// </summary>
        FramebufferDefaultSamples = ((int)0x9313),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314
        /// </summary>
        FramebufferDefaultFixedSampleLocations = ((int)0x9314),
        /// <summary>
        /// Original was GL_NEGATIVE_ONE_TO_ONE = 0x935E
        /// </summary>
        NegativeOneToOne = ((int)0x935E),
        /// <summary>
        /// Original was GL_ZERO_TO_ONE = 0x935F
        /// </summary>
        ZeroToOne = ((int)0x935F),
        /// <summary>
        /// Original was GL_CLEAR_TEXTURE = 0x9365
        /// </summary>
        ClearTexture = ((int)0x9365),
        /// <summary>
        /// Original was GL_NUM_SAMPLE_COUNTS = 0x9380
        /// </summary>
        NumSampleCounts = ((int)0x9380),
        /// <summary>
        /// Original was GL_BGRA8_EXT = 0x93A1
        /// </summary>
        Bgra8Ext = ((int)0x93A1),
        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT = 0x9530
        /// </summary>
        LayoutDepthReadOnlyStencilAttachmentExt = ((int)0x9530),
        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT = 0x9531
        /// </summary>
        LayoutDepthAttachmentStencilReadOnlyExt = ((int)0x9531),
        /// <summary>
        /// Original was GL_TEXTURE_TILING_EXT = 0x9580
        /// </summary>
        TextureTilingExt = ((int)0x9580),
        /// <summary>
        /// Original was GL_DEDICATED_MEMORY_OBJECT_EXT = 0x9581
        /// </summary>
        DedicatedMemoryObjectExt = ((int)0x9581),
        /// <summary>
        /// Original was GL_HANDLE_TYPE_OPAQUE_FD_EXT = 0x9586
        /// </summary>
        HandleTypeOpaqueFdExt = ((int)0x9586),
        /// <summary>
        /// Original was GL_HANDLE_TYPE_OPAQUE_WIN32_EXT = 0x9587
        /// </summary>
        HandleTypeOpaqueWin32Ext = ((int)0x9587),
        /// <summary>
        /// Original was GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT = 0x9588
        /// </summary>
        HandleTypeOpaqueWin32KmtExt = ((int)0x9588),
        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT = 0x9589
        /// </summary>
        HandleTypeD3D12TilepoolExt = ((int)0x9589),
        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D12_RESOURCE_EXT = 0x958A
        /// </summary>
        HandleTypeD3D12ResourceExt = ((int)0x958A),
        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D11_IMAGE_EXT = 0x958B
        /// </summary>
        HandleTypeD3D11ImageExt = ((int)0x958B),
        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT = 0x958C
        /// </summary>
        HandleTypeD3D11ImageKmtExt = ((int)0x958C),
        /// <summary>
        /// Original was GL_LAYOUT_GENERAL_EXT = 0x958D
        /// </summary>
        LayoutGeneralExt = ((int)0x958D),
        /// <summary>
        /// Original was GL_LAYOUT_COLOR_ATTACHMENT_EXT = 0x958E
        /// </summary>
        LayoutColorAttachmentExt = ((int)0x958E),
        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT = 0x958F
        /// </summary>
        LayoutDepthStencilAttachmentExt = ((int)0x958F),
        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT = 0x9590
        /// </summary>
        LayoutDepthStencilReadOnlyExt = ((int)0x9590),
        /// <summary>
        /// Original was GL_LAYOUT_SHADER_READ_ONLY_EXT = 0x9591
        /// </summary>
        LayoutShaderReadOnlyExt = ((int)0x9591),
        /// <summary>
        /// Original was GL_LAYOUT_TRANSFER_SRC_EXT = 0x9592
        /// </summary>
        LayoutTransferSrcExt = ((int)0x9592),
        /// <summary>
        /// Original was GL_LAYOUT_TRANSFER_DST_EXT = 0x9593
        /// </summary>
        LayoutTransferDstExt = ((int)0x9593),
        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D12_FENCE_EXT = 0x9594
        /// </summary>
        HandleTypeD3D12FenceExt = ((int)0x9594),
        /// <summary>
        /// Original was GL_D3D12_FENCE_VALUE_EXT = 0x9595
        /// </summary>
        D3D12FenceValueExt = ((int)0x9595),
        /// <summary>
        /// Original was GL_DEVICE_UUID_EXT = 0x9597
        /// </summary>
        DeviceUuidExt = ((int)0x9597),
        /// <summary>
        /// Original was GL_DRIVER_UUID_EXT = 0x9598
        /// </summary>
        DriverUuidExt = ((int)0x9598),
        /// <summary>
        /// Original was GL_DEVICE_LUID_EXT = 0x9599
        /// </summary>
        DeviceLuidExt = ((int)0x9599),
        /// <summary>
        /// Original was GL_DEVICE_NODE_MASK_EXT = 0x959A
        /// </summary>
        DeviceNodeMaskExt = ((int)0x959A),
        /// <summary>
        /// Original was GL_PROTECTED_MEMORY_OBJECT_EXT = 0x959B
        /// </summary>
        ProtectedMemoryObjectExt = ((int)0x959B),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM = 0x96A2
        /// </summary>
        FramebufferFetchNoncoherentQcom = ((int)0x96A2),
        /// <summary>
        /// Original was GL_ALL_ATTRIB_BITS = 0xFFFFFFFF
        /// </summary>
        AllAttribBits = unchecked((int)0xFFFFFFFF),
        /// <summary>
        /// Original was GL_ALL_BARRIER_BITS = 0xFFFFFFFF
        /// </summary>
        AllBarrierBits = unchecked((int)0xFFFFFFFF),
        /// <summary>
        /// Original was GL_ALL_BARRIER_BITS_EXT = 0xFFFFFFFF
        /// </summary>
        AllBarrierBitsExt = unchecked((int)0xFFFFFFFF),
        /// <summary>
        /// Original was GL_ALL_SHADER_BITS = 0xFFFFFFFF
        /// </summary>
        AllShaderBits = unchecked((int)0xFFFFFFFF),
        /// <summary>
        /// Original was GL_ALL_SHADER_BITS_EXT = 0xFFFFFFFF
        /// </summary>
        AllShaderBitsExt = unchecked((int)0xFFFFFFFF),
        /// <summary>
        /// Original was GL_CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF
        /// </summary>
        ClientAllAttribBits = unchecked((int)0xFFFFFFFF),
        /// <summary>
        /// Original was GL_QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF
        /// </summary>
        QueryAllEventBitsAmd = unchecked((int)0xFFFFFFFF),
        /// <summary>
        /// Original was GL_TIMEOUT_IGNORED_APPLE = 0xFFFFFFFFFFFFFFFF
        /// </summary>
        TimeoutIgnoredApple = unchecked((int)0xFFFFFFFFFFFFFFFF),
        /// <summary>
        /// Original was GL_AMD_compressed_3DC_texture = 1
        /// </summary>
        AmdCompressed3DcTexture = ((int)1),
        /// <summary>
        /// Original was GL_AMD_compressed_ATC_texture = 1
        /// </summary>
        AmdCompressedAtcTexture = ((int)1),
        /// <summary>
        /// Original was GL_EXT_texture_filter_anisotropic = 1
        /// </summary>
        ExtTextureFilterAnisotropic = ((int)1),
        /// <summary>
        /// Original was GL_EXT_texture_format_BGRA8888 = 1
        /// </summary>
        ExtTextureFormatBgra8888 = ((int)1),
        /// <summary>
        /// Original was GL_IMG_read_format = 1
        /// </summary>
        ImgReadFormat = ((int)1),
        /// <summary>
        /// Original was GL_IMG_texture_compression_pvrtc = 1
        /// </summary>
        ImgTextureCompressionPvrtc = ((int)1),
        /// <summary>
        /// Original was GL_IMG_texture_env_enhanced_fixed_function = 1
        /// </summary>
        ImgTextureEnvEnhancedFixedFunction = ((int)1),
        /// <summary>
        /// Original was GL_IMG_user_clip_plane = 1
        /// </summary>
        ImgUserClipPlane = ((int)1),
        /// <summary>
        /// Original was GL_LAYOUT_LINEAR_INTEL = 1
        /// </summary>
        LayoutLinearIntel = ((int)1),
        /// <summary>
        /// Original was GL_NV_fence = 1
        /// </summary>
        NvFence = ((int)1),
        /// <summary>
        /// Original was GL_OES_blend_equation_separate = 1
        /// </summary>
        OesBlendEquationSeparate = ((int)1),
        /// <summary>
        /// Original was GL_OES_blend_func_separate = 1
        /// </summary>
        OesBlendFuncSeparate = ((int)1),
        /// <summary>
        /// Original was GL_OES_blend_subtract = 1
        /// </summary>
        OesBlendSubtract = ((int)1),
        /// <summary>
        /// Original was GL_OES_byte_coordinates = 1
        /// </summary>
        OesByteCoordinates = ((int)1),
        /// <summary>
        /// Original was GL_OES_compressed_ETC1_RGB8_texture = 1
        /// </summary>
        OesCompressedEtc1Rgb8Texture = ((int)1),
        /// <summary>
        /// Original was GL_OES_compressed_paletted_texture = 1
        /// </summary>
        OesCompressedPalettedTexture = ((int)1),
        /// <summary>
        /// Original was GL_OES_depth24 = 1
        /// </summary>
        OesDepth24 = ((int)1),
        /// <summary>
        /// Original was GL_OES_depth32 = 1
        /// </summary>
        OesDepth32 = ((int)1),
        /// <summary>
        /// Original was GL_OES_draw_texture = 1
        /// </summary>
        OesDrawTexture = ((int)1),
        /// <summary>
        /// Original was GL_OES_EGL_image = 1
        /// </summary>
        OesEglImage = ((int)1),
        /// <summary>
        /// Original was GL_OES_element_index_uint = 1
        /// </summary>
        OesElementIndexUint = ((int)1),
        /// <summary>
        /// Original was GL_OES_extended_matrix_palette = 1
        /// </summary>
        OesExtendedMatrixPalette = ((int)1),
        /// <summary>
        /// Original was GL_OES_fbo_render_mipmap = 1
        /// </summary>
        OesFboRenderMipmap = ((int)1),
        /// <summary>
        /// Original was GL_OES_fixed_point = 1
        /// </summary>
        OesFixedPoint = ((int)1),
        /// <summary>
        /// Original was GL_OES_framebuffer_object = 1
        /// </summary>
        OesFramebufferObject = ((int)1),
        /// <summary>
        /// Original was GL_OES_mapbuffer = 1
        /// </summary>
        OesMapbuffer = ((int)1),
        /// <summary>
        /// Original was GL_OES_matrix_get = 1
        /// </summary>
        OesMatrixGet = ((int)1),
        /// <summary>
        /// Original was GL_OES_matrix_palette = 1
        /// </summary>
        OesMatrixPalette = ((int)1),
        /// <summary>
        /// Original was GL_OES_packed_depth_stencil = 1
        /// </summary>
        OesPackedDepthStencil = ((int)1),
        /// <summary>
        /// Original was GL_OES_point_size_array = 1
        /// </summary>
        OesPointSizeArray = ((int)1),
        /// <summary>
        /// Original was GL_OES_point_sprite = 1
        /// </summary>
        OesPointSprite = ((int)1),
        /// <summary>
        /// Original was GL_OES_query_matrix = 1
        /// </summary>
        OesQueryMatrix = ((int)1),
        /// <summary>
        /// Original was GL_OES_read_format = 1
        /// </summary>
        OesReadFormat = ((int)1),
        /// <summary>
        /// Original was GL_OES_rgb8_rgba8 = 1
        /// </summary>
        OesRgb8Rgba8 = ((int)1),
        /// <summary>
        /// Original was GL_OES_single_precision = 1
        /// </summary>
        OesSinglePrecision = ((int)1),
        /// <summary>
        /// Original was GL_OES_stencil1 = 1
        /// </summary>
        OesStencil1 = ((int)1),
        /// <summary>
        /// Original was GL_OES_stencil4 = 1
        /// </summary>
        OesStencil4 = ((int)1),
        /// <summary>
        /// Original was GL_OES_stencil8 = 1
        /// </summary>
        OesStencil8 = ((int)1),
        /// <summary>
        /// Original was GL_OES_stencil_wrap = 1
        /// </summary>
        OesStencilWrap = ((int)1),
        /// <summary>
        /// Original was GL_OES_texture_cube_map = 1
        /// </summary>
        OesTextureCubeMap = ((int)1),
        /// <summary>
        /// Original was GL_OES_texture_env_crossbar = 1
        /// </summary>
        OesTextureEnvCrossbar = ((int)1),
        /// <summary>
        /// Original was GL_OES_texture_mirrored_repeat = 1
        /// </summary>
        OesTextureMirroredRepeat = ((int)1),
        /// <summary>
        /// Original was GL_ONE = 1
        /// </summary>
        One = ((int)1),
        /// <summary>
        /// Original was GL_QCOM_driver_control = 1
        /// </summary>
        QcomDriverControl = ((int)1),
        /// <summary>
        /// Original was GL_QCOM_perfmon_global_mode = 1
        /// </summary>
        QcomPerfmonGlobalMode = ((int)1),
        /// <summary>
        /// Original was GL_TRUE = 1
        /// </summary>
        True = ((int)1),
        /// <summary>
        /// Original was GL_VERSION_ES_CL_1_0 = 1
        /// </summary>
        VersionEsCl10 = ((int)1),
        /// <summary>
        /// Original was GL_VERSION_ES_CL_1_1 = 1
        /// </summary>
        VersionEsCl11 = ((int)1),
        /// <summary>
        /// Original was GL_VERSION_ES_CM_1_0 = 1
        /// </summary>
        VersionEsCm10 = ((int)1),
        /// <summary>
        /// Original was GL_VERSION_ES_CM_1_1 = 1
        /// </summary>
        VersionEsCm11 = ((int)1),
        /// <summary>
        /// Original was GL_LAYOUT_LINEAR_CPU_CACHED_INTEL = 2
        /// </summary>
        LayoutLinearCpuCachedIntel = ((int)2),
    }

    /// <summary>
    /// Used in GL.AlphaFunc, GL.AlphaFuncx and 1 other function
    /// </summary>
    public enum AlphaFunction : int
    {
        /// <summary>
        /// Original was GL_NEVER = 0x0200
        /// </summary>
        Never = ((int)0x0200),
        /// <summary>
        /// Original was GL_LESS = 0x0201
        /// </summary>
        Less = ((int)0x0201),
        /// <summary>
        /// Original was GL_EQUAL = 0x0202
        /// </summary>
        Equal = ((int)0x0202),
        /// <summary>
        /// Original was GL_LEQUAL = 0x0203
        /// </summary>
        Lequal = ((int)0x0203),
        /// <summary>
        /// Original was GL_GREATER = 0x0204
        /// </summary>
        Greater = ((int)0x0204),
        /// <summary>
        /// Original was GL_NOTEQUAL = 0x0205
        /// </summary>
        Notequal = ((int)0x0205),
        /// <summary>
        /// Original was GL_GEQUAL = 0x0206
        /// </summary>
        Gequal = ((int)0x0206),
        /// <summary>
        /// Original was GL_ALWAYS = 0x0207
        /// </summary>
        Always = ((int)0x0207),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum Amdcompressed3Dctexture : int
    {
        /// <summary>
        /// Original was GL_3DC_X_AMD = 0x87F9
        /// </summary>
        Gl3DcXAmd = ((int)0x87F9),
        /// <summary>
        /// Original was GL_3DC_XY_AMD = 0x87FA
        /// </summary>
        Gl3DcXyAmd = ((int)0x87FA),
        /// <summary>
        /// Original was GL_AMD_compressed_3DC_texture = 1
        /// </summary>
        AmdCompressed3DcTexture = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum AmdCompressed3DcTexture : int
    {
        /// <summary>
        /// Original was GL_3DC_X_AMD = 0x87F9
        /// </summary>
        Gl3DcXAmd = ((int)0x87F9),
        /// <summary>
        /// Original was GL_3DC_XY_AMD = 0x87FA
        /// </summary>
        Gl3DcXyAmd = ((int)0x87FA),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum AmdcompressedAtctexture : int
    {
        /// <summary>
        /// Original was GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE
        /// </summary>
        AtcRgbaInterpolatedAlphaAmd = ((int)0x87EE),
        /// <summary>
        /// Original was GL_ATC_RGB_AMD = 0x8C92
        /// </summary>
        AtcRgbAmd = ((int)0x8C92),
        /// <summary>
        /// Original was GL_ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93
        /// </summary>
        AtcRgbaExplicitAlphaAmd = ((int)0x8C93),
        /// <summary>
        /// Original was GL_AMD_compressed_ATC_texture = 1
        /// </summary>
        AmdCompressedAtcTexture = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum AmdCompressedAtcTexture : int
    {
        /// <summary>
        /// Original was GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE
        /// </summary>
        AtcRgbaInterpolatedAlphaAmd = ((int)0x87EE),
        /// <summary>
        /// Original was GL_ATC_RGB_AMD = 0x8C92
        /// </summary>
        AtcRgbAmd = ((int)0x8C92),
        /// <summary>
        /// Original was GL_ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93
        /// </summary>
        AtcRgbaExplicitAlphaAmd = ((int)0x8C93),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleCopyTextureLevels : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleFramebufferMultisample : int
    {
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_BINDING_APPLE = 0x8CA6
        /// </summary>
        DrawFramebufferBindingApple = ((int)0x8CA6),
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_APPLE = 0x8CA8
        /// </summary>
        ReadFramebufferApple = ((int)0x8CA8),
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_APPLE = 0x8CA9
        /// </summary>
        DrawFramebufferApple = ((int)0x8CA9),
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_BINDING_APPLE = 0x8CAA
        /// </summary>
        ReadFramebufferBindingApple = ((int)0x8CAA),
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_APPLE = 0x8CAB
        /// </summary>
        RenderbufferSamplesApple = ((int)0x8CAB),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisampleApple = ((int)0x8D56),
        /// <summary>
        /// Original was GL_MAX_SAMPLES_APPLE = 0x8D57
        /// </summary>
        MaxSamplesApple = ((int)0x8D57),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleSync : int
    {
        /// <summary>
        /// Original was GL_SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001
        /// </summary>
        SyncFlushCommandsBitApple = ((int)0x00000001),
        /// <summary>
        /// Original was GL_SYNC_OBJECT_APPLE = 0x8A53
        /// </summary>
        SyncObjectApple = ((int)0x8A53),
        /// <summary>
        /// Original was GL_MAX_SERVER_WAIT_TIMEOUT_APPLE = 0x9111
        /// </summary>
        MaxServerWaitTimeoutApple = ((int)0x9111),
        /// <summary>
        /// Original was GL_OBJECT_TYPE_APPLE = 0x9112
        /// </summary>
        ObjectTypeApple = ((int)0x9112),
        /// <summary>
        /// Original was GL_SYNC_CONDITION_APPLE = 0x9113
        /// </summary>
        SyncConditionApple = ((int)0x9113),
        /// <summary>
        /// Original was GL_SYNC_STATUS_APPLE = 0x9114
        /// </summary>
        SyncStatusApple = ((int)0x9114),
        /// <summary>
        /// Original was GL_SYNC_FLAGS_APPLE = 0x9115
        /// </summary>
        SyncFlagsApple = ((int)0x9115),
        /// <summary>
        /// Original was GL_SYNC_FENCE_APPLE = 0x9116
        /// </summary>
        SyncFenceApple = ((int)0x9116),
        /// <summary>
        /// Original was GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE = 0x9117
        /// </summary>
        SyncGpuCommandsCompleteApple = ((int)0x9117),
        /// <summary>
        /// Original was GL_UNSIGNALED_APPLE = 0x9118
        /// </summary>
        UnsignaledApple = ((int)0x9118),
        /// <summary>
        /// Original was GL_SIGNALED_APPLE = 0x9119
        /// </summary>
        SignaledApple = ((int)0x9119),
        /// <summary>
        /// Original was GL_ALREADY_SIGNALED_APPLE = 0x911A
        /// </summary>
        AlreadySignaledApple = ((int)0x911A),
        /// <summary>
        /// Original was GL_TIMEOUT_EXPIRED_APPLE = 0x911B
        /// </summary>
        TimeoutExpiredApple = ((int)0x911B),
        /// <summary>
        /// Original was GL_CONDITION_SATISFIED_APPLE = 0x911C
        /// </summary>
        ConditionSatisfiedApple = ((int)0x911C),
        /// <summary>
        /// Original was GL_WAIT_FAILED_APPLE = 0x911D
        /// </summary>
        WaitFailedApple = ((int)0x911D),
        /// <summary>
        /// Original was GL_TIMEOUT_IGNORED_APPLE = 0xFFFFFFFFFFFFFFFF
        /// </summary>
        TimeoutIgnoredApple = unchecked((int)0xFFFFFFFFFFFFFFFF),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleTexture2DLimitedNpot : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleTextureFormatBgra8888 : int
    {
        /// <summary>
        /// Original was GL_BGRA_EXT = 0x80E1
        /// </summary>
        BgraExt = ((int)0x80E1),
        /// <summary>
        /// Original was GL_BGRA8_EXT = 0x93A1
        /// </summary>
        Bgra8Ext = ((int)0x93A1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleTextureMaxLevel : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL_APPLE = 0x813D
        /// </summary>
        TextureMaxLevelApple = ((int)0x813D),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArmRgba8 : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AtomicCounterBufferPName : int
    {
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED
        /// </summary>
        AtomicCounterBufferReferencedByComputeShader = ((int)0x90ED),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1
        /// </summary>
        AtomicCounterBufferBinding = ((int)0x92C1),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4
        /// </summary>
        AtomicCounterBufferDataSize = ((int)0x92C4),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5
        /// </summary>
        AtomicCounterBufferActiveAtomicCounters = ((int)0x92C5),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6
        /// </summary>
        AtomicCounterBufferActiveAtomicCounterIndices = ((int)0x92C6),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7
        /// </summary>
        AtomicCounterBufferReferencedByVertexShader = ((int)0x92C7),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8
        /// </summary>
        AtomicCounterBufferReferencedByTessControlShader = ((int)0x92C8),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9
        /// </summary>
        AtomicCounterBufferReferencedByTessEvaluationShader = ((int)0x92C9),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA
        /// </summary>
        AtomicCounterBufferReferencedByGeometryShader = ((int)0x92CA),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB
        /// </summary>
        AtomicCounterBufferReferencedByFragmentShader = ((int)0x92CB),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum AttribMask : int
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
        AllAttribBits = unchecked((int)0xFFFFFFFF),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AttributeType : int
    {
        /// <summary>
        /// Original was GL_FLOAT_VEC2 = 0x8B50
        /// </summary>
        FloatVec2 = ((int)0x8B50),
        /// <summary>
        /// Original was GL_FLOAT_VEC2_ARB = 0x8B50
        /// </summary>
        FloatVec2Arb = ((int)0x8B50),
        /// <summary>
        /// Original was GL_FLOAT_VEC3 = 0x8B51
        /// </summary>
        FloatVec3 = ((int)0x8B51),
        /// <summary>
        /// Original was GL_FLOAT_VEC3_ARB = 0x8B51
        /// </summary>
        FloatVec3Arb = ((int)0x8B51),
        /// <summary>
        /// Original was GL_FLOAT_VEC4 = 0x8B52
        /// </summary>
        FloatVec4 = ((int)0x8B52),
        /// <summary>
        /// Original was GL_FLOAT_VEC4_ARB = 0x8B52
        /// </summary>
        FloatVec4Arb = ((int)0x8B52),
        /// <summary>
        /// Original was GL_INT_VEC2 = 0x8B53
        /// </summary>
        IntVec2 = ((int)0x8B53),
        /// <summary>
        /// Original was GL_INT_VEC2_ARB = 0x8B53
        /// </summary>
        IntVec2Arb = ((int)0x8B53),
        /// <summary>
        /// Original was GL_INT_VEC3 = 0x8B54
        /// </summary>
        IntVec3 = ((int)0x8B54),
        /// <summary>
        /// Original was GL_INT_VEC3_ARB = 0x8B54
        /// </summary>
        IntVec3Arb = ((int)0x8B54),
        /// <summary>
        /// Original was GL_INT_VEC4 = 0x8B55
        /// </summary>
        IntVec4 = ((int)0x8B55),
        /// <summary>
        /// Original was GL_INT_VEC4_ARB = 0x8B55
        /// </summary>
        IntVec4Arb = ((int)0x8B55),
        /// <summary>
        /// Original was GL_BOOL = 0x8B56
        /// </summary>
        Bool = ((int)0x8B56),
        /// <summary>
        /// Original was GL_BOOL_ARB = 0x8B56
        /// </summary>
        BoolArb = ((int)0x8B56),
        /// <summary>
        /// Original was GL_BOOL_VEC2 = 0x8B57
        /// </summary>
        BoolVec2 = ((int)0x8B57),
        /// <summary>
        /// Original was GL_BOOL_VEC2_ARB = 0x8B57
        /// </summary>
        BoolVec2Arb = ((int)0x8B57),
        /// <summary>
        /// Original was GL_BOOL_VEC3 = 0x8B58
        /// </summary>
        BoolVec3 = ((int)0x8B58),
        /// <summary>
        /// Original was GL_BOOL_VEC3_ARB = 0x8B58
        /// </summary>
        BoolVec3Arb = ((int)0x8B58),
        /// <summary>
        /// Original was GL_BOOL_VEC4 = 0x8B59
        /// </summary>
        BoolVec4 = ((int)0x8B59),
        /// <summary>
        /// Original was GL_BOOL_VEC4_ARB = 0x8B59
        /// </summary>
        BoolVec4Arb = ((int)0x8B59),
        /// <summary>
        /// Original was GL_FLOAT_MAT2 = 0x8B5A
        /// </summary>
        FloatMat2 = ((int)0x8B5A),
        /// <summary>
        /// Original was GL_FLOAT_MAT2_ARB = 0x8B5A
        /// </summary>
        FloatMat2Arb = ((int)0x8B5A),
        /// <summary>
        /// Original was GL_FLOAT_MAT3 = 0x8B5B
        /// </summary>
        FloatMat3 = ((int)0x8B5B),
        /// <summary>
        /// Original was GL_FLOAT_MAT3_ARB = 0x8B5B
        /// </summary>
        FloatMat3Arb = ((int)0x8B5B),
        /// <summary>
        /// Original was GL_FLOAT_MAT4 = 0x8B5C
        /// </summary>
        FloatMat4 = ((int)0x8B5C),
        /// <summary>
        /// Original was GL_FLOAT_MAT4_ARB = 0x8B5C
        /// </summary>
        FloatMat4Arb = ((int)0x8B5C),
        /// <summary>
        /// Original was GL_SAMPLER_1D = 0x8B5D
        /// </summary>
        Sampler1D = ((int)0x8B5D),
        /// <summary>
        /// Original was GL_SAMPLER_1D_ARB = 0x8B5D
        /// </summary>
        Sampler1DArb = ((int)0x8B5D),
        /// <summary>
        /// Original was GL_SAMPLER_2D = 0x8B5E
        /// </summary>
        Sampler2D = ((int)0x8B5E),
        /// <summary>
        /// Original was GL_SAMPLER_2D_ARB = 0x8B5E
        /// </summary>
        Sampler2DArb = ((int)0x8B5E),
        /// <summary>
        /// Original was GL_SAMPLER_3D = 0x8B5F
        /// </summary>
        Sampler3D = ((int)0x8B5F),
        /// <summary>
        /// Original was GL_SAMPLER_3D_ARB = 0x8B5F
        /// </summary>
        Sampler3DArb = ((int)0x8B5F),
        /// <summary>
        /// Original was GL_SAMPLER_3D_OES = 0x8B5F
        /// </summary>
        Sampler3DOes = ((int)0x8B5F),
        /// <summary>
        /// Original was GL_SAMPLER_CUBE = 0x8B60
        /// </summary>
        SamplerCube = ((int)0x8B60),
        /// <summary>
        /// Original was GL_SAMPLER_CUBE_ARB = 0x8B60
        /// </summary>
        SamplerCubeArb = ((int)0x8B60),
        /// <summary>
        /// Original was GL_SAMPLER_1D_SHADOW = 0x8B61
        /// </summary>
        Sampler1DShadow = ((int)0x8B61),
        /// <summary>
        /// Original was GL_SAMPLER_1D_SHADOW_ARB = 0x8B61
        /// </summary>
        Sampler1DShadowArb = ((int)0x8B61),
        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW = 0x8B62
        /// </summary>
        Sampler2DShadow = ((int)0x8B62),
        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW_ARB = 0x8B62
        /// </summary>
        Sampler2DShadowArb = ((int)0x8B62),
        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW_EXT = 0x8B62
        /// </summary>
        Sampler2DShadowExt = ((int)0x8B62),
        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT = 0x8B63
        /// </summary>
        Sampler2DRect = ((int)0x8B63),
        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT_ARB = 0x8B63
        /// </summary>
        Sampler2DRectArb = ((int)0x8B63),
        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT_SHADOW = 0x8B64
        /// </summary>
        Sampler2DRectShadow = ((int)0x8B64),
        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64
        /// </summary>
        Sampler2DRectShadowArb = ((int)0x8B64),
        /// <summary>
        /// Original was GL_FLOAT_MAT2x3 = 0x8B65
        /// </summary>
        FloatMat2x3 = ((int)0x8B65),
        /// <summary>
        /// Original was GL_FLOAT_MAT2x3_NV = 0x8B65
        /// </summary>
        FloatMat2x3Nv = ((int)0x8B65),
        /// <summary>
        /// Original was GL_FLOAT_MAT2x4 = 0x8B66
        /// </summary>
        FloatMat2x4 = ((int)0x8B66),
        /// <summary>
        /// Original was GL_FLOAT_MAT2x4_NV = 0x8B66
        /// </summary>
        FloatMat2x4Nv = ((int)0x8B66),
        /// <summary>
        /// Original was GL_FLOAT_MAT3x2 = 0x8B67
        /// </summary>
        FloatMat3x2 = ((int)0x8B67),
        /// <summary>
        /// Original was GL_FLOAT_MAT3x2_NV = 0x8B67
        /// </summary>
        FloatMat3x2Nv = ((int)0x8B67),
        /// <summary>
        /// Original was GL_FLOAT_MAT3x4 = 0x8B68
        /// </summary>
        FloatMat3x4 = ((int)0x8B68),
        /// <summary>
        /// Original was GL_FLOAT_MAT3x4_NV = 0x8B68
        /// </summary>
        FloatMat3x4Nv = ((int)0x8B68),
        /// <summary>
        /// Original was GL_FLOAT_MAT4x2 = 0x8B69
        /// </summary>
        FloatMat4x2 = ((int)0x8B69),
        /// <summary>
        /// Original was GL_FLOAT_MAT4x2_NV = 0x8B69
        /// </summary>
        FloatMat4x2Nv = ((int)0x8B69),
        /// <summary>
        /// Original was GL_FLOAT_MAT4x3 = 0x8B6A
        /// </summary>
        FloatMat4x3 = ((int)0x8B6A),
        /// <summary>
        /// Original was GL_FLOAT_MAT4x3_NV = 0x8B6A
        /// </summary>
        FloatMat4x3Nv = ((int)0x8B6A),
    }

    /// <summary>
    /// Used in GL.DrawArrays, GL.DrawElements
    /// </summary>
    public enum BeginMode : int
    {
        /// <summary>
        /// Original was GL_Points = 0X0000
        /// </summary>
        Points = ((int)0X0000),
        /// <summary>
        /// Original was GL_Lines = 0X0001
        /// </summary>
        Lines = ((int)0X0001),
        /// <summary>
        /// Original was GL_LineLoop = 0X0002
        /// </summary>
        LineLoop = ((int)0X0002),
        /// <summary>
        /// Original was GL_LineStrip = 0X0003
        /// </summary>
        LineStrip = ((int)0X0003),
        /// <summary>
        /// Original was GL_Triangles = 0X0004
        /// </summary>
        Triangles = ((int)0X0004),
        /// <summary>
        /// Original was GL_TriangleStrip = 0X0005
        /// </summary>
        TriangleStrip = ((int)0X0005),
        /// <summary>
        /// Original was GL_TriangleFan = 0X0006
        /// </summary>
        TriangleFan = ((int)0X0006),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BindTransformFeedbackTarget : int
    {
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK = 0x8E22
        /// </summary>
        TransformFeedback = ((int)0x8E22),
    }

    /// <summary>
    /// Used in GL.Ext.BlendEquation, GL.Oes.BlendEquation and 1 other function
    /// </summary>
    public enum BlendEquationModeExt : int
    {
        /// <summary>
        /// Original was GL_LOGIC_OP = 0x0BF1
        /// </summary>
        LogicOp = ((int)0x0BF1),
        /// <summary>
        /// Original was GL_FUNC_ADD = 0x8006
        /// </summary>
        FuncAdd = ((int)0x8006),
        /// <summary>
        /// Original was GL_FUNC_ADD_EXT = 0x8006
        /// </summary>
        FuncAddExt = ((int)0x8006),
        /// <summary>
        /// Original was GL_MIN_EXT = 0x8007
        /// </summary>
        MinExt = ((int)0x8007),
        /// <summary>
        /// Original was GL_MAX_EXT = 0x8008
        /// </summary>
        MaxExt = ((int)0x8008),
        /// <summary>
        /// Original was GL_FUNC_SUBTRACT = 0x800A
        /// </summary>
        FuncSubtract = ((int)0x800A),
        /// <summary>
        /// Original was GL_FUNC_SUBTRACT_EXT = 0x800A
        /// </summary>
        FuncSubtractExt = ((int)0x800A),
        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT = 0x800B
        /// </summary>
        FuncReverseSubtract = ((int)0x800B),
        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT_EXT = 0x800B
        /// </summary>
        FuncReverseSubtractExt = ((int)0x800B),
        /// <summary>
        /// Original was GL_ALPHA_MIN_SGIX = 0x8320
        /// </summary>
        AlphaMinSgix = ((int)0x8320),
        /// <summary>
        /// Original was GL_ALPHA_MAX_SGIX = 0x8321
        /// </summary>
        AlphaMaxSgix = ((int)0x8321),
    }

    /// <summary>
    /// Used in GL.BlendFunc, GL.Oes.BlendFuncSeparate
    /// </summary>
    public enum BlendingFactor : int
    {
        /// <summary>
        /// Original was GL_ZERO = 0
        /// </summary>
        Zero = ((int)0),
        /// <summary>
        /// Original was GL_SRC_COLOR = 0x0300
        /// </summary>
        SrcColor = ((int)0x0300),
        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_COLOR = 0x0301
        /// </summary>
        OneMinusSrcColor = ((int)0x0301),
        /// <summary>
        /// Original was GL_SRC_ALPHA = 0x0302
        /// </summary>
        SrcAlpha = ((int)0x0302),
        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_ALPHA = 0x0303
        /// </summary>
        OneMinusSrcAlpha = ((int)0x0303),
        /// <summary>
        /// Original was GL_DST_ALPHA = 0x0304
        /// </summary>
        DstAlpha = ((int)0x0304),
        /// <summary>
        /// Original was GL_ONE_MINUS_DST_ALPHA = 0x0305
        /// </summary>
        OneMinusDstAlpha = ((int)0x0305),
        /// <summary>
        /// Original was GL_DST_COLOR = 0x0306
        /// </summary>
        DstColor = ((int)0x0306),
        /// <summary>
        /// Original was GL_ONE_MINUS_DST_COLOR = 0x0307
        /// </summary>
        OneMinusDstColor = ((int)0x0307),
        /// <summary>
        /// Original was GL_SRC_ALPHA_SATURATE = 0x0308
        /// </summary>
        SrcAlphaSaturate = ((int)0x0308),
        /// <summary>
        /// Original was GL_CONSTANT_COLOR = 0x8001
        /// </summary>
        ConstantColor = ((int)0x8001),
        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_COLOR = 0x8002
        /// </summary>
        OneMinusConstantColor = ((int)0x8002),
        /// <summary>
        /// Original was GL_CONSTANT_ALPHA = 0x8003
        /// </summary>
        ConstantAlpha = ((int)0x8003),
        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004
        /// </summary>
        OneMinusConstantAlpha = ((int)0x8004),
        /// <summary>
        /// Original was GL_SRC1_ALPHA = 0x8589
        /// </summary>
        Src1Alpha = ((int)0x8589),
        /// <summary>
        /// Original was GL_SRC1_COLOR = 0x88F9
        /// </summary>
        Src1Color = ((int)0x88F9),
        /// <summary>
        /// Original was GL_ONE = 1
        /// </summary>
        One = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BlitFramebufferFilter : int
    {
        /// <summary>
        /// Original was GL_NEAREST = 0x2600
        /// </summary>
        Nearest = ((int)0x2600),
        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = ((int)0x2601),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Boolean : int
    {
        /// <summary>
        /// Original was GL_FALSE = 0
        /// </summary>
        False = ((int)0),
        /// <summary>
        /// Original was GL_TRUE = 1
        /// </summary>
        True = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Buffer : int
    {
        /// <summary>
        /// Original was GL_COLOR = 0x1800
        /// </summary>
        Color = ((int)0x1800),
        /// <summary>
        /// Original was GL_DEPTH = 0x1801
        /// </summary>
        Depth = ((int)0x1801),
        /// <summary>
        /// Original was GL_STENCIL = 0x1802
        /// </summary>
        Stencil = ((int)0x1802),
    }

    /// <summary>
    /// Used in GL.Oes.MapBuffer
    /// </summary>
    public enum BufferAccessArb : int
    {
        /// <summary>
        /// Original was GL_READ_ONLY = 0x88B8
        /// </summary>
        ReadOnly = ((int)0x88B8),
        /// <summary>
        /// Original was GL_WRITE_ONLY = 0x88B9
        /// </summary>
        WriteOnly = ((int)0x88B9),
        /// <summary>
        /// Original was GL_READ_WRITE = 0x88BA
        /// </summary>
        ReadWrite = ((int)0x88BA),
    }

    /// <summary>
    /// Used in GL.Ext.MapBufferRange
    /// </summary>
    [Flags]
    public enum BufferAccessMask : int
    {
        /// <summary>
        /// Original was GL_MAP_READ_BIT = 0x0001
        /// </summary>
        MapReadBit = ((int)0x0001),
        /// <summary>
        /// Original was GL_MAP_READ_BIT_EXT = 0x0001
        /// </summary>
        MapReadBitExt = ((int)0x0001),
        /// <summary>
        /// Original was GL_MAP_WRITE_BIT = 0x0002
        /// </summary>
        MapWriteBit = ((int)0x0002),
        /// <summary>
        /// Original was GL_MAP_WRITE_BIT_EXT = 0x0002
        /// </summary>
        MapWriteBitExt = ((int)0x0002),
        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT = 0x0004
        /// </summary>
        MapInvalidateRangeBit = ((int)0x0004),
        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004
        /// </summary>
        MapInvalidateRangeBitExt = ((int)0x0004),
        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008
        /// </summary>
        MapInvalidateBufferBit = ((int)0x0008),
        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008
        /// </summary>
        MapInvalidateBufferBitExt = ((int)0x0008),
        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010
        /// </summary>
        MapFlushExplicitBit = ((int)0x0010),
        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010
        /// </summary>
        MapFlushExplicitBitExt = ((int)0x0010),
        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT = 0x0020
        /// </summary>
        MapUnsynchronizedBit = ((int)0x0020),
        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020
        /// </summary>
        MapUnsynchronizedBitExt = ((int)0x0020),
        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT = 0x0040
        /// </summary>
        MapPersistentBit = ((int)0x0040),
        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT_EXT = 0x0040
        /// </summary>
        MapPersistentBitExt = ((int)0x0040),
        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT = 0x0080
        /// </summary>
        MapCoherentBit = ((int)0x0080),
        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT_EXT = 0x0080
        /// </summary>
        MapCoherentBitExt = ((int)0x0080),
    }

    /// <summary>
    /// Used in GL.Qcom.EndTiling, GL.Qcom.StartTiling
    /// </summary>
    public enum BufferBitQcom : int
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
    public enum BufferObjects : int
    {
        /// <summary>
        /// Original was GL_BUFFER_SIZE = 0x8764
        /// </summary>
        BufferSize = ((int)0x8764),
        /// <summary>
        /// Original was GL_BUFFER_USAGE = 0x8765
        /// </summary>
        BufferUsage = ((int)0x8765),
        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = ((int)0x8892),
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = ((int)0x8893),
        /// <summary>
        /// Original was GL_ARRAY_BUFFER_BINDING = 0x8894
        /// </summary>
        ArrayBufferBinding = ((int)0x8894),
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895
        /// </summary>
        ElementArrayBufferBinding = ((int)0x8895),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896
        /// </summary>
        VertexArrayBufferBinding = ((int)0x8896),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897
        /// </summary>
        NormalArrayBufferBinding = ((int)0x8897),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898
        /// </summary>
        ColorArrayBufferBinding = ((int)0x8898),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A
        /// </summary>
        TextureCoordArrayBufferBinding = ((int)0x889A),
        /// <summary>
        /// Original was GL_STATIC_DRAW = 0x88E4
        /// </summary>
        StaticDraw = ((int)0x88E4),
        /// <summary>
        /// Original was GL_DYNAMIC_DRAW = 0x88E8
        /// </summary>
        DynamicDraw = ((int)0x88E8),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BufferStorageTarget : int
    {
        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = ((int)0x8892),
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = ((int)0x8893),
        /// <summary>
        /// Original was GL_PIXEL_PACK_BUFFER = 0x88EB
        /// </summary>
        PixelPackBuffer = ((int)0x88EB),
        /// <summary>
        /// Original was GL_PIXEL_UNPACK_BUFFER = 0x88EC
        /// </summary>
        PixelUnpackBuffer = ((int)0x88EC),
        /// <summary>
        /// Original was GL_UNIFORM_BUFFER = 0x8A11
        /// </summary>
        UniformBuffer = ((int)0x8A11),
        /// <summary>
        /// Original was GL_TEXTURE_BUFFER = 0x8C2A
        /// </summary>
        TextureBuffer = ((int)0x8C2A),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        /// </summary>
        TransformFeedbackBuffer = ((int)0x8C8E),
        /// <summary>
        /// Original was GL_COPY_READ_BUFFER = 0x8F36
        /// </summary>
        CopyReadBuffer = ((int)0x8F36),
        /// <summary>
        /// Original was GL_COPY_WRITE_BUFFER = 0x8F37
        /// </summary>
        CopyWriteBuffer = ((int)0x8F37),
        /// <summary>
        /// Original was GL_DRAW_INDIRECT_BUFFER = 0x8F3F
        /// </summary>
        DrawIndirectBuffer = ((int)0x8F3F),
        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER = 0x90D2
        /// </summary>
        ShaderStorageBuffer = ((int)0x90D2),
        /// <summary>
        /// Original was GL_DISPATCH_INDIRECT_BUFFER = 0x90EE
        /// </summary>
        DispatchIndirectBuffer = ((int)0x90EE),
        /// <summary>
        /// Original was GL_QUERY_BUFFER = 0x9192
        /// </summary>
        QueryBuffer = ((int)0x9192),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        /// </summary>
        AtomicCounterBuffer = ((int)0x92C0),
    }

    /// <summary>
    /// Used in GL.BindBuffer, GL.BufferData and 6 other functions
    /// </summary>
    public enum BufferTargetArb : int
    {
        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = ((int)0x8892),
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = ((int)0x8893),
        /// <summary>
        /// Original was GL_PIXEL_PACK_BUFFER = 0x88EB
        /// </summary>
        PixelPackBuffer = ((int)0x88EB),
        /// <summary>
        /// Original was GL_PIXEL_UNPACK_BUFFER = 0x88EC
        /// </summary>
        PixelUnpackBuffer = ((int)0x88EC),
        /// <summary>
        /// Original was GL_UNIFORM_BUFFER = 0x8A11
        /// </summary>
        UniformBuffer = ((int)0x8A11),
        /// <summary>
        /// Original was GL_TEXTURE_BUFFER = 0x8C2A
        /// </summary>
        TextureBuffer = ((int)0x8C2A),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        /// </summary>
        TransformFeedbackBuffer = ((int)0x8C8E),
        /// <summary>
        /// Original was GL_COPY_READ_BUFFER = 0x8F36
        /// </summary>
        CopyReadBuffer = ((int)0x8F36),
        /// <summary>
        /// Original was GL_COPY_WRITE_BUFFER = 0x8F37
        /// </summary>
        CopyWriteBuffer = ((int)0x8F37),
        /// <summary>
        /// Original was GL_DRAW_INDIRECT_BUFFER = 0x8F3F
        /// </summary>
        DrawIndirectBuffer = ((int)0x8F3F),
        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER = 0x90D2
        /// </summary>
        ShaderStorageBuffer = ((int)0x90D2),
        /// <summary>
        /// Original was GL_DISPATCH_INDIRECT_BUFFER = 0x90EE
        /// </summary>
        DispatchIndirectBuffer = ((int)0x90EE),
        /// <summary>
        /// Original was GL_QUERY_BUFFER = 0x9192
        /// </summary>
        QueryBuffer = ((int)0x9192),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        /// </summary>
        AtomicCounterBuffer = ((int)0x92C0),
    }

    /// <summary>
    /// Used in GL.BufferData
    /// </summary>
    public enum BufferUsageArb : int
    {
        /// <summary>
        /// Original was GL_STREAM_DRAW = 0x88E0
        /// </summary>
        StreamDraw = ((int)0x88E0),
        /// <summary>
        /// Original was GL_STREAM_READ = 0x88E1
        /// </summary>
        StreamRead = ((int)0x88E1),
        /// <summary>
        /// Original was GL_STREAM_COPY = 0x88E2
        /// </summary>
        StreamCopy = ((int)0x88E2),
        /// <summary>
        /// Original was GL_STATIC_DRAW = 0x88E4
        /// </summary>
        StaticDraw = ((int)0x88E4),
        /// <summary>
        /// Original was GL_STATIC_READ = 0x88E5
        /// </summary>
        StaticRead = ((int)0x88E5),
        /// <summary>
        /// Original was GL_STATIC_COPY = 0x88E6
        /// </summary>
        StaticCopy = ((int)0x88E6),
        /// <summary>
        /// Original was GL_DYNAMIC_DRAW = 0x88E8
        /// </summary>
        DynamicDraw = ((int)0x88E8),
        /// <summary>
        /// Original was GL_DYNAMIC_READ = 0x88E9
        /// </summary>
        DynamicRead = ((int)0x88E9),
        /// <summary>
        /// Original was GL_DYNAMIC_COPY = 0x88EA
        /// </summary>
        DynamicCopy = ((int)0x88EA),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum CheckFramebufferStatusTarget : int
    {
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER = 0x8CA8
        /// </summary>
        ReadFramebuffer = ((int)0x8CA8),
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER = 0x8CA9
        /// </summary>
        DrawFramebuffer = ((int)0x8CA9),
        /// <summary>
        /// Original was GL_FRAMEBUFFER = 0x8D40
        /// </summary>
        Framebuffer = ((int)0x8D40),
    }

    /// <summary>
    /// Used in GL.Clear
    /// </summary>
    [Flags]
    public enum ClearBufferMask : int
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
    public enum ClientAttribMask : int
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
        ClientAllAttribBits = unchecked((int)0xFFFFFFFF),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ClipControlDepth : int
    {
        /// <summary>
        /// Original was GL_NEGATIVE_ONE_TO_ONE = 0x935E
        /// </summary>
        NegativeOneToOne = ((int)0x935E),
        /// <summary>
        /// Original was GL_ZERO_TO_ONE = 0x935F
        /// </summary>
        ZeroToOne = ((int)0x935F),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ClipControlOrigin : int
    {
        /// <summary>
        /// Original was GL_LOWER_LEFT = 0x8CA1
        /// </summary>
        LowerLeft = ((int)0x8CA1),
        /// <summary>
        /// Original was GL_UPPER_LEFT = 0x8CA2
        /// </summary>
        UpperLeft = ((int)0x8CA2),
    }

    /// <summary>
    /// Used in GL.ClipPlane, GL.ClipPlanex and 8 other functions
    /// </summary>
    public enum ClipPlaneName : int
    {
        /// <summary>
        /// Original was GL_CLIP_DISTANCE0 = 0x3000
        /// </summary>
        ClipDistance0 = ((int)0x3000),
        /// <summary>
        /// Original was GL_CLIP_PLANE0 = 0x3000
        /// </summary>
        ClipPlane0 = ((int)0x3000),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE1 = 0x3001
        /// </summary>
        ClipDistance1 = ((int)0x3001),
        /// <summary>
        /// Original was GL_CLIP_PLANE1 = 0x3001
        /// </summary>
        ClipPlane1 = ((int)0x3001),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE2 = 0x3002
        /// </summary>
        ClipDistance2 = ((int)0x3002),
        /// <summary>
        /// Original was GL_CLIP_PLANE2 = 0x3002
        /// </summary>
        ClipPlane2 = ((int)0x3002),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE3 = 0x3003
        /// </summary>
        ClipDistance3 = ((int)0x3003),
        /// <summary>
        /// Original was GL_CLIP_PLANE3 = 0x3003
        /// </summary>
        ClipPlane3 = ((int)0x3003),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE4 = 0x3004
        /// </summary>
        ClipDistance4 = ((int)0x3004),
        /// <summary>
        /// Original was GL_CLIP_PLANE4 = 0x3004
        /// </summary>
        ClipPlane4 = ((int)0x3004),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE5 = 0x3005
        /// </summary>
        ClipDistance5 = ((int)0x3005),
        /// <summary>
        /// Original was GL_CLIP_PLANE5 = 0x3005
        /// </summary>
        ClipPlane5 = ((int)0x3005),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE6 = 0x3006
        /// </summary>
        ClipDistance6 = ((int)0x3006),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE7 = 0x3007
        /// </summary>
        ClipDistance7 = ((int)0x3007),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ColorBuffer : int
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = ((int)0),
        /// <summary>
        /// Original was GL_FRONT_LEFT = 0x0400
        /// </summary>
        FrontLeft = ((int)0x0400),
        /// <summary>
        /// Original was GL_FRONT_RIGHT = 0x0401
        /// </summary>
        FrontRight = ((int)0x0401),
        /// <summary>
        /// Original was GL_BACK_LEFT = 0x0402
        /// </summary>
        BackLeft = ((int)0x0402),
        /// <summary>
        /// Original was GL_BACK_RIGHT = 0x0403
        /// </summary>
        BackRight = ((int)0x0403),
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = ((int)0x0404),
        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = ((int)0x0405),
        /// <summary>
        /// Original was GL_LEFT = 0x0406
        /// </summary>
        Left = ((int)0x0406),
        /// <summary>
        /// Original was GL_RIGHT = 0x0407
        /// </summary>
        Right = ((int)0x0407),
        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = ((int)0x0408),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        /// </summary>
        ColorAttachment0 = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        /// </summary>
        ColorAttachment1 = ((int)0x8CE1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        /// </summary>
        ColorAttachment2 = ((int)0x8CE2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        /// </summary>
        ColorAttachment3 = ((int)0x8CE3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        /// </summary>
        ColorAttachment4 = ((int)0x8CE4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        /// </summary>
        ColorAttachment5 = ((int)0x8CE5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        /// </summary>
        ColorAttachment6 = ((int)0x8CE6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        /// </summary>
        ColorAttachment7 = ((int)0x8CE7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        /// </summary>
        ColorAttachment8 = ((int)0x8CE8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        /// </summary>
        ColorAttachment9 = ((int)0x8CE9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        /// </summary>
        ColorAttachment10 = ((int)0x8CEA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        /// </summary>
        ColorAttachment11 = ((int)0x8CEB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        /// </summary>
        ColorAttachment12 = ((int)0x8CEC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        /// </summary>
        ColorAttachment13 = ((int)0x8CED),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        /// </summary>
        ColorAttachment14 = ((int)0x8CEE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        /// </summary>
        ColorAttachment15 = ((int)0x8CEF),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT16 = 0x8CF0
        /// </summary>
        ColorAttachment16 = ((int)0x8CF0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT17 = 0x8CF1
        /// </summary>
        ColorAttachment17 = ((int)0x8CF1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT18 = 0x8CF2
        /// </summary>
        ColorAttachment18 = ((int)0x8CF2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT19 = 0x8CF3
        /// </summary>
        ColorAttachment19 = ((int)0x8CF3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT20 = 0x8CF4
        /// </summary>
        ColorAttachment20 = ((int)0x8CF4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT21 = 0x8CF5
        /// </summary>
        ColorAttachment21 = ((int)0x8CF5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT22 = 0x8CF6
        /// </summary>
        ColorAttachment22 = ((int)0x8CF6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT23 = 0x8CF7
        /// </summary>
        ColorAttachment23 = ((int)0x8CF7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT24 = 0x8CF8
        /// </summary>
        ColorAttachment24 = ((int)0x8CF8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT25 = 0x8CF9
        /// </summary>
        ColorAttachment25 = ((int)0x8CF9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT26 = 0x8CFA
        /// </summary>
        ColorAttachment26 = ((int)0x8CFA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT27 = 0x8CFB
        /// </summary>
        ColorAttachment27 = ((int)0x8CFB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT28 = 0x8CFC
        /// </summary>
        ColorAttachment28 = ((int)0x8CFC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT29 = 0x8CFD
        /// </summary>
        ColorAttachment29 = ((int)0x8CFD),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT30 = 0x8CFE
        /// </summary>
        ColorAttachment30 = ((int)0x8CFE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT31 = 0x8CFF
        /// </summary>
        ColorAttachment31 = ((int)0x8CFF),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ColorMaterialFace : int
    {
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = ((int)0x0404),
        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = ((int)0x0405),
        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = ((int)0x0408),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ColorMaterialParameter : int
    {
        /// <summary>
        /// Original was GL_AMBIENT = 0x1200
        /// </summary>
        Ambient = ((int)0x1200),
        /// <summary>
        /// Original was GL_DIFFUSE = 0x1201
        /// </summary>
        Diffuse = ((int)0x1201),
        /// <summary>
        /// Original was GL_SPECULAR = 0x1202
        /// </summary>
        Specular = ((int)0x1202),
        /// <summary>
        /// Original was GL_EMISSION = 0x1600
        /// </summary>
        Emission = ((int)0x1600),
        /// <summary>
        /// Original was GL_AMBIENT_AND_DIFFUSE = 0x1602
        /// </summary>
        AmbientAndDiffuse = ((int)0x1602),
    }

    /// <summary>
    /// Used in GL.ColorPointer
    /// </summary>
    public enum ColorPointerType : int
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = ((int)0x1400),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = ((int)0x1401),
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = ((int)0x1402),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = ((int)0x1403),
        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = ((int)0x1404),
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405),
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406),
        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = ((int)0x140A),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ColorTableParameterPNameSgi : int
    {
        /// <summary>
        /// Original was GL_COLOR_TABLE_SCALE = 0x80D6
        /// </summary>
        ColorTableScale = ((int)0x80D6),
        /// <summary>
        /// Original was GL_COLOR_TABLE_SCALE_SGI = 0x80D6
        /// </summary>
        ColorTableScaleSgi = ((int)0x80D6),
        /// <summary>
        /// Original was GL_COLOR_TABLE_BIAS = 0x80D7
        /// </summary>
        ColorTableBias = ((int)0x80D7),
        /// <summary>
        /// Original was GL_COLOR_TABLE_BIAS_SGI = 0x80D7
        /// </summary>
        ColorTableBiasSgi = ((int)0x80D7),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ColorTableTarget : int
    {
        /// <summary>
        /// Original was GL_COLOR_TABLE = 0x80D0
        /// </summary>
        ColorTable = ((int)0x80D0),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1
        /// </summary>
        PostConvolutionColorTable = ((int)0x80D1),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2
        /// </summary>
        PostColorMatrixColorTable = ((int)0x80D2),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ColorTableTargetSgi : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
        /// </summary>
        TextureColorTableSgi = ((int)0x80BC),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_COLOR_TABLE_SGI = 0x80BD
        /// </summary>
        ProxyTextureColorTableSgi = ((int)0x80BD),
        /// <summary>
        /// Original was GL_COLOR_TABLE = 0x80D0
        /// </summary>
        ColorTable = ((int)0x80D0),
        /// <summary>
        /// Original was GL_COLOR_TABLE_SGI = 0x80D0
        /// </summary>
        ColorTableSgi = ((int)0x80D0),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1
        /// </summary>
        PostConvolutionColorTable = ((int)0x80D1),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
        /// </summary>
        PostConvolutionColorTableSgi = ((int)0x80D1),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2
        /// </summary>
        PostColorMatrixColorTable = ((int)0x80D2),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
        /// </summary>
        PostColorMatrixColorTableSgi = ((int)0x80D2),
        /// <summary>
        /// Original was GL_PROXY_COLOR_TABLE = 0x80D3
        /// </summary>
        ProxyColorTable = ((int)0x80D3),
        /// <summary>
        /// Original was GL_PROXY_COLOR_TABLE_SGI = 0x80D3
        /// </summary>
        ProxyColorTableSgi = ((int)0x80D3),
        /// <summary>
        /// Original was GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4
        /// </summary>
        ProxyPostConvolutionColorTable = ((int)0x80D4),
        /// <summary>
        /// Original was GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D4
        /// </summary>
        ProxyPostConvolutionColorTableSgi = ((int)0x80D4),
        /// <summary>
        /// Original was GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5
        /// </summary>
        ProxyPostColorMatrixColorTable = ((int)0x80D5),
        /// <summary>
        /// Original was GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D5
        /// </summary>
        ProxyPostColorMatrixColorTableSgi = ((int)0x80D5),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum ContextFlagMask : int
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
    public enum ContextProfileMask : int
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
    public enum ConvolutionBorderModeExt : int
    {
        /// <summary>
        /// Original was GL_REDUCE = 0x8016
        /// </summary>
        Reduce = ((int)0x8016),
        /// <summary>
        /// Original was GL_REDUCE_EXT = 0x8016
        /// </summary>
        ReduceExt = ((int)0x8016),
    }

    /// <summary>
    /// Used in GL.Oes.ConvolutionParameterx
    /// </summary>
    public enum ConvolutionParameterExt : int
    {
        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_MODE = 0x8013
        /// </summary>
        ConvolutionBorderMode = ((int)0x8013),
        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_MODE_EXT = 0x8013
        /// </summary>
        ConvolutionBorderModeExt = ((int)0x8013),
        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_SCALE = 0x8014
        /// </summary>
        ConvolutionFilterScale = ((int)0x8014),
        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_SCALE_EXT = 0x8014
        /// </summary>
        ConvolutionFilterScaleExt = ((int)0x8014),
        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_BIAS = 0x8015
        /// </summary>
        ConvolutionFilterBias = ((int)0x8015),
        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_BIAS_EXT = 0x8015
        /// </summary>
        ConvolutionFilterBiasExt = ((int)0x8015),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ConvolutionTarget : int
    {
        /// <summary>
        /// Original was GL_CONVOLUTION_1D = 0x8010
        /// </summary>
        Convolution1D = ((int)0x8010),
        /// <summary>
        /// Original was GL_CONVOLUTION_2D = 0x8011
        /// </summary>
        Convolution2D = ((int)0x8011),
    }

    /// <summary>
    /// Used in GL.Oes.ConvolutionParameterx
    /// </summary>
    public enum ConvolutionTargetExt : int
    {
        /// <summary>
        /// Original was GL_CONVOLUTION_1D = 0x8010
        /// </summary>
        Convolution1D = ((int)0x8010),
        /// <summary>
        /// Original was GL_CONVOLUTION_1D_EXT = 0x8010
        /// </summary>
        Convolution1DExt = ((int)0x8010),
        /// <summary>
        /// Original was GL_CONVOLUTION_2D = 0x8011
        /// </summary>
        Convolution2D = ((int)0x8011),
        /// <summary>
        /// Original was GL_CONVOLUTION_2D_EXT = 0x8011
        /// </summary>
        Convolution2DExt = ((int)0x8011),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum CopyBufferSubDataTarget : int
    {
        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = ((int)0x8892),
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = ((int)0x8893),
        /// <summary>
        /// Original was GL_PIXEL_PACK_BUFFER = 0x88EB
        /// </summary>
        PixelPackBuffer = ((int)0x88EB),
        /// <summary>
        /// Original was GL_PIXEL_UNPACK_BUFFER = 0x88EC
        /// </summary>
        PixelUnpackBuffer = ((int)0x88EC),
        /// <summary>
        /// Original was GL_UNIFORM_BUFFER = 0x8A11
        /// </summary>
        UniformBuffer = ((int)0x8A11),
        /// <summary>
        /// Original was GL_TEXTURE_BUFFER = 0x8C2A
        /// </summary>
        TextureBuffer = ((int)0x8C2A),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        /// </summary>
        TransformFeedbackBuffer = ((int)0x8C8E),
        /// <summary>
        /// Original was GL_COPY_READ_BUFFER = 0x8F36
        /// </summary>
        CopyReadBuffer = ((int)0x8F36),
        /// <summary>
        /// Original was GL_COPY_WRITE_BUFFER = 0x8F37
        /// </summary>
        CopyWriteBuffer = ((int)0x8F37),
        /// <summary>
        /// Original was GL_DRAW_INDIRECT_BUFFER = 0x8F3F
        /// </summary>
        DrawIndirectBuffer = ((int)0x8F3F),
        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER = 0x90D2
        /// </summary>
        ShaderStorageBuffer = ((int)0x90D2),
        /// <summary>
        /// Original was GL_DISPATCH_INDIRECT_BUFFER = 0x90EE
        /// </summary>
        DispatchIndirectBuffer = ((int)0x90EE),
        /// <summary>
        /// Original was GL_QUERY_BUFFER = 0x9192
        /// </summary>
        QueryBuffer = ((int)0x9192),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        /// </summary>
        AtomicCounterBuffer = ((int)0x92C0),
    }

    /// <summary>
    /// Used in GL.CullFace
    /// </summary>
    public enum CullFaceMode : int
    {
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = ((int)0x0404),
        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = ((int)0x0405),
        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = ((int)0x0408),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum DataType : int
    {
    }

    /// <summary>
    /// Used in GL.DebugMessageControl, GL.DebugMessageInsert and 4 other functions
    /// </summary>
    public enum DebugSeverity : int
    {
        /// <summary>
        /// Original was GL_DONT_CARE = 0x1100
        /// </summary>
        DontCare = ((int)0x1100),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_HIGH = 0x9146
        /// </summary>
        DebugSeverityHigh = ((int)0x9146),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_MEDIUM = 0x9147
        /// </summary>
        DebugSeverityMedium = ((int)0x9147),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_LOW = 0x9148
        /// </summary>
        DebugSeverityLow = ((int)0x9148),
    }

    /// <summary>
    /// Used in GL.DebugMessageControl, GL.DebugMessageInsert and 6 other functions
    /// </summary>
    public enum DebugSource : int
    {
        /// <summary>
        /// Original was GL_DONT_CARE = 0x1100
        /// </summary>
        DontCare = ((int)0x1100),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_API = 0x8246
        /// </summary>
        DebugSourceApi = ((int)0x8246),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247
        /// </summary>
        DebugSourceWindowSystem = ((int)0x8247),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248
        /// </summary>
        DebugSourceShaderCompiler = ((int)0x8248),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249
        /// </summary>
        DebugSourceThirdParty = ((int)0x8249),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_APPLICATION = 0x824A
        /// </summary>
        DebugSourceApplication = ((int)0x824A),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_OTHER = 0x824B
        /// </summary>
        DebugSourceOther = ((int)0x824B),
    }

    /// <summary>
    /// Used in GL.DebugMessageControl, GL.DebugMessageInsert and 4 other functions
    /// </summary>
    public enum DebugType : int
    {
        /// <summary>
        /// Original was GL_DONT_CARE = 0x1100
        /// </summary>
        DontCare = ((int)0x1100),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_ERROR = 0x824C
        /// </summary>
        DebugTypeError = ((int)0x824C),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D
        /// </summary>
        DebugTypeDeprecatedBehavior = ((int)0x824D),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E
        /// </summary>
        DebugTypeUndefinedBehavior = ((int)0x824E),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_PORTABILITY = 0x824F
        /// </summary>
        DebugTypePortability = ((int)0x824F),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_PERFORMANCE = 0x8250
        /// </summary>
        DebugTypePerformance = ((int)0x8250),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_OTHER = 0x8251
        /// </summary>
        DebugTypeOther = ((int)0x8251),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_MARKER = 0x8268
        /// </summary>
        DebugTypeMarker = ((int)0x8268),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_PUSH_GROUP = 0x8269
        /// </summary>
        DebugTypePushGroup = ((int)0x8269),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_POP_GROUP = 0x826A
        /// </summary>
        DebugTypePopGroup = ((int)0x826A),
    }

    /// <summary>
    /// Used in GL.DepthFunc
    /// </summary>
    public enum DepthFunction : int
    {
        /// <summary>
        /// Original was GL_NEVER = 0x0200
        /// </summary>
        Never = ((int)0x0200),
        /// <summary>
        /// Original was GL_LESS = 0x0201
        /// </summary>
        Less = ((int)0x0201),
        /// <summary>
        /// Original was GL_EQUAL = 0x0202
        /// </summary>
        Equal = ((int)0x0202),
        /// <summary>
        /// Original was GL_LEQUAL = 0x0203
        /// </summary>
        Lequal = ((int)0x0203),
        /// <summary>
        /// Original was GL_GREATER = 0x0204
        /// </summary>
        Greater = ((int)0x0204),
        /// <summary>
        /// Original was GL_NOTEQUAL = 0x0205
        /// </summary>
        Notequal = ((int)0x0205),
        /// <summary>
        /// Original was GL_GEQUAL = 0x0206
        /// </summary>
        Gequal = ((int)0x0206),
        /// <summary>
        /// Original was GL_ALWAYS = 0x0207
        /// </summary>
        Always = ((int)0x0207),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum DrawBufferMode : int
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = ((int)0),
        /// <summary>
        /// Original was GL_NONE_OES = 0
        /// </summary>
        NoneOes = ((int)0),
        /// <summary>
        /// Original was GL_FRONT_LEFT = 0x0400
        /// </summary>
        FrontLeft = ((int)0x0400),
        /// <summary>
        /// Original was GL_FRONT_RIGHT = 0x0401
        /// </summary>
        FrontRight = ((int)0x0401),
        /// <summary>
        /// Original was GL_BACK_LEFT = 0x0402
        /// </summary>
        BackLeft = ((int)0x0402),
        /// <summary>
        /// Original was GL_BACK_RIGHT = 0x0403
        /// </summary>
        BackRight = ((int)0x0403),
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = ((int)0x0404),
        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = ((int)0x0405),
        /// <summary>
        /// Original was GL_LEFT = 0x0406
        /// </summary>
        Left = ((int)0x0406),
        /// <summary>
        /// Original was GL_RIGHT = 0x0407
        /// </summary>
        Right = ((int)0x0407),
        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = ((int)0x0408),
        /// <summary>
        /// Original was GL_AUX0 = 0x0409
        /// </summary>
        Aux0 = ((int)0x0409),
        /// <summary>
        /// Original was GL_AUX1 = 0x040A
        /// </summary>
        Aux1 = ((int)0x040A),
        /// <summary>
        /// Original was GL_AUX2 = 0x040B
        /// </summary>
        Aux2 = ((int)0x040B),
        /// <summary>
        /// Original was GL_AUX3 = 0x040C
        /// </summary>
        Aux3 = ((int)0x040C),
    }

    /// <summary>
    /// Used in GL.DrawElements, GL.Ext.MultiDrawElements
    /// </summary>
    public enum DrawElementsType : int
    {
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = ((int)0x1401),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = ((int)0x1403),
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405),
    }

    /// <summary>
    /// Used in GL.Disable, GL.DisableClientState and 3 other functions
    /// </summary>
    public enum EnableCap : int
    {
        /// <summary>
        /// Original was GL_POINT_SMOOTH = 0x0B10
        /// </summary>
        PointSmooth = ((int)0x0B10),
        /// <summary>
        /// Original was GL_LINE_SMOOTH = 0x0B20
        /// </summary>
        LineSmooth = ((int)0x0B20),
        /// <summary>
        /// Original was GL_LINE_STIPPLE = 0x0B24
        /// </summary>
        LineStipple = ((int)0x0B24),
        /// <summary>
        /// Original was GL_POLYGON_SMOOTH = 0x0B41
        /// </summary>
        PolygonSmooth = ((int)0x0B41),
        /// <summary>
        /// Original was GL_POLYGON_STIPPLE = 0x0B42
        /// </summary>
        PolygonStipple = ((int)0x0B42),
        /// <summary>
        /// Original was GL_CULL_FACE = 0x0B44
        /// </summary>
        CullFace = ((int)0x0B44),
        /// <summary>
        /// Original was GL_LIGHTING = 0x0B50
        /// </summary>
        Lighting = ((int)0x0B50),
        /// <summary>
        /// Original was GL_COLOR_MATERIAL = 0x0B57
        /// </summary>
        ColorMaterial = ((int)0x0B57),
        /// <summary>
        /// Original was GL_FOG = 0x0B60
        /// </summary>
        Fog = ((int)0x0B60),
        /// <summary>
        /// Original was GL_DEPTH_TEST = 0x0B71
        /// </summary>
        DepthTest = ((int)0x0B71),
        /// <summary>
        /// Original was GL_STENCIL_TEST = 0x0B90
        /// </summary>
        StencilTest = ((int)0x0B90),
        /// <summary>
        /// Original was GL_NORMALIZE = 0x0BA1
        /// </summary>
        Normalize = ((int)0x0BA1),
        /// <summary>
        /// Original was GL_ALPHA_TEST = 0x0BC0
        /// </summary>
        AlphaTest = ((int)0x0BC0),
        /// <summary>
        /// Original was GL_DITHER = 0x0BD0
        /// </summary>
        Dither = ((int)0x0BD0),
        /// <summary>
        /// Original was GL_BLEND = 0x0BE2
        /// </summary>
        Blend = ((int)0x0BE2),
        /// <summary>
        /// Original was GL_INDEX_LOGIC_OP = 0x0BF1
        /// </summary>
        IndexLogicOp = ((int)0x0BF1),
        /// <summary>
        /// Original was GL_COLOR_LOGIC_OP = 0x0BF2
        /// </summary>
        ColorLogicOp = ((int)0x0BF2),
        /// <summary>
        /// Original was GL_SCISSOR_TEST = 0x0C11
        /// </summary>
        ScissorTest = ((int)0x0C11),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_S = 0x0C60
        /// </summary>
        TextureGenS = ((int)0x0C60),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_T = 0x0C61
        /// </summary>
        TextureGenT = ((int)0x0C61),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_R = 0x0C62
        /// </summary>
        TextureGenR = ((int)0x0C62),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_Q = 0x0C63
        /// </summary>
        TextureGenQ = ((int)0x0C63),
        /// <summary>
        /// Original was GL_AUTO_NORMAL = 0x0D80
        /// </summary>
        AutoNormal = ((int)0x0D80),
        /// <summary>
        /// Original was GL_MAP1_COLOR_4 = 0x0D90
        /// </summary>
        Map1Color4 = ((int)0x0D90),
        /// <summary>
        /// Original was GL_MAP1_INDEX = 0x0D91
        /// </summary>
        Map1Index = ((int)0x0D91),
        /// <summary>
        /// Original was GL_MAP1_NORMAL = 0x0D92
        /// </summary>
        Map1Normal = ((int)0x0D92),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_1 = 0x0D93
        /// </summary>
        Map1TextureCoord1 = ((int)0x0D93),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_2 = 0x0D94
        /// </summary>
        Map1TextureCoord2 = ((int)0x0D94),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_3 = 0x0D95
        /// </summary>
        Map1TextureCoord3 = ((int)0x0D95),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_4 = 0x0D96
        /// </summary>
        Map1TextureCoord4 = ((int)0x0D96),
        /// <summary>
        /// Original was GL_MAP1_VERTEX_3 = 0x0D97
        /// </summary>
        Map1Vertex3 = ((int)0x0D97),
        /// <summary>
        /// Original was GL_MAP1_VERTEX_4 = 0x0D98
        /// </summary>
        Map1Vertex4 = ((int)0x0D98),
        /// <summary>
        /// Original was GL_MAP2_COLOR_4 = 0x0DB0
        /// </summary>
        Map2Color4 = ((int)0x0DB0),
        /// <summary>
        /// Original was GL_MAP2_INDEX = 0x0DB1
        /// </summary>
        Map2Index = ((int)0x0DB1),
        /// <summary>
        /// Original was GL_MAP2_NORMAL = 0x0DB2
        /// </summary>
        Map2Normal = ((int)0x0DB2),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_1 = 0x0DB3
        /// </summary>
        Map2TextureCoord1 = ((int)0x0DB3),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_2 = 0x0DB4
        /// </summary>
        Map2TextureCoord2 = ((int)0x0DB4),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_3 = 0x0DB5
        /// </summary>
        Map2TextureCoord3 = ((int)0x0DB5),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_4 = 0x0DB6
        /// </summary>
        Map2TextureCoord4 = ((int)0x0DB6),
        /// <summary>
        /// Original was GL_MAP2_VERTEX_3 = 0x0DB7
        /// </summary>
        Map2Vertex3 = ((int)0x0DB7),
        /// <summary>
        /// Original was GL_MAP2_VERTEX_4 = 0x0DB8
        /// </summary>
        Map2Vertex4 = ((int)0x0DB8),
        /// <summary>
        /// Original was GL_TEXTURE_1D = 0x0DE0
        /// </summary>
        Texture1D = ((int)0x0DE0),
        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = ((int)0x0DE1),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_POINT = 0x2A01
        /// </summary>
        PolygonOffsetPoint = ((int)0x2A01),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_LINE = 0x2A02
        /// </summary>
        PolygonOffsetLine = ((int)0x2A02),
        /// <summary>
        /// Original was GL_CLIP_PLANE0 = 0x3000
        /// </summary>
        ClipPlane0 = ((int)0x3000),
        /// <summary>
        /// Original was GL_CLIP_PLANE1 = 0x3001
        /// </summary>
        ClipPlane1 = ((int)0x3001),
        /// <summary>
        /// Original was GL_CLIP_PLANE2 = 0x3002
        /// </summary>
        ClipPlane2 = ((int)0x3002),
        /// <summary>
        /// Original was GL_CLIP_PLANE3 = 0x3003
        /// </summary>
        ClipPlane3 = ((int)0x3003),
        /// <summary>
        /// Original was GL_CLIP_PLANE4 = 0x3004
        /// </summary>
        ClipPlane4 = ((int)0x3004),
        /// <summary>
        /// Original was GL_CLIP_PLANE5 = 0x3005
        /// </summary>
        ClipPlane5 = ((int)0x3005),
        /// <summary>
        /// Original was GL_LIGHT0 = 0x4000
        /// </summary>
        Light0 = ((int)0x4000),
        /// <summary>
        /// Original was GL_LIGHT1 = 0x4001
        /// </summary>
        Light1 = ((int)0x4001),
        /// <summary>
        /// Original was GL_LIGHT2 = 0x4002
        /// </summary>
        Light2 = ((int)0x4002),
        /// <summary>
        /// Original was GL_LIGHT3 = 0x4003
        /// </summary>
        Light3 = ((int)0x4003),
        /// <summary>
        /// Original was GL_LIGHT4 = 0x4004
        /// </summary>
        Light4 = ((int)0x4004),
        /// <summary>
        /// Original was GL_LIGHT5 = 0x4005
        /// </summary>
        Light5 = ((int)0x4005),
        /// <summary>
        /// Original was GL_LIGHT6 = 0x4006
        /// </summary>
        Light6 = ((int)0x4006),
        /// <summary>
        /// Original was GL_LIGHT7 = 0x4007
        /// </summary>
        Light7 = ((int)0x4007),
        /// <summary>
        /// Original was GL_CONVOLUTION_1D_EXT = 0x8010
        /// </summary>
        Convolution1DExt = ((int)0x8010),
        /// <summary>
        /// Original was GL_CONVOLUTION_2D_EXT = 0x8011
        /// </summary>
        Convolution2DExt = ((int)0x8011),
        /// <summary>
        /// Original was GL_SEPARABLE_2D_EXT = 0x8012
        /// </summary>
        Separable2DExt = ((int)0x8012),
        /// <summary>
        /// Original was GL_HISTOGRAM_EXT = 0x8024
        /// </summary>
        HistogramExt = ((int)0x8024),
        /// <summary>
        /// Original was GL_MINMAX_EXT = 0x802E
        /// </summary>
        MinmaxExt = ((int)0x802E),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FILL = 0x8037
        /// </summary>
        PolygonOffsetFill = ((int)0x8037),
        /// <summary>
        /// Original was GL_RESCALE_NORMAL_EXT = 0x803A
        /// </summary>
        RescaleNormalExt = ((int)0x803A),
        /// <summary>
        /// Original was GL_TEXTURE_3D_EXT = 0x806F
        /// </summary>
        Texture3DExt = ((int)0x806F),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = ((int)0x8074),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY = 0x8075
        /// </summary>
        NormalArray = ((int)0x8075),
        /// <summary>
        /// Original was GL_COLOR_ARRAY = 0x8076
        /// </summary>
        ColorArray = ((int)0x8076),
        /// <summary>
        /// Original was GL_INDEX_ARRAY = 0x8077
        /// </summary>
        IndexArray = ((int)0x8077),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY = 0x8078
        /// </summary>
        TextureCoordArray = ((int)0x8078),
        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY = 0x8079
        /// </summary>
        EdgeFlagArray = ((int)0x8079),
        /// <summary>
        /// Original was GL_INTERLACE_SGIX = 0x8094
        /// </summary>
        InterlaceSgix = ((int)0x8094),
        /// <summary>
        /// Original was GL_MULTISAMPLE_SGIS = 0x809D
        /// </summary>
        MultisampleSgis = ((int)0x809D),
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E
        /// </summary>
        SampleAlphaToMaskSgis = ((int)0x809E),
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F
        /// </summary>
        SampleAlphaToOneSgis = ((int)0x809F),
        /// <summary>
        /// Original was GL_SAMPLE_MASK_SGIS = 0x80A0
        /// </summary>
        SampleMaskSgis = ((int)0x80A0),
        /// <summary>
        /// Original was GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
        /// </summary>
        TextureColorTableSgi = ((int)0x80BC),
        /// <summary>
        /// Original was GL_COLOR_TABLE_SGI = 0x80D0
        /// </summary>
        ColorTableSgi = ((int)0x80D0),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
        /// </summary>
        PostConvolutionColorTableSgi = ((int)0x80D1),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
        /// </summary>
        PostColorMatrixColorTableSgi = ((int)0x80D2),
        /// <summary>
        /// Original was GL_TEXTURE_4D_SGIS = 0x8134
        /// </summary>
        Texture4DSgis = ((int)0x8134),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_SGIX = 0x8139
        /// </summary>
        PixelTexGenSgix = ((int)0x8139),
        /// <summary>
        /// Original was GL_SPRITE_SGIX = 0x8148
        /// </summary>
        SpriteSgix = ((int)0x8148),
        /// <summary>
        /// Original was GL_REFERENCE_PLANE_SGIX = 0x817D
        /// </summary>
        ReferencePlaneSgix = ((int)0x817D),
        /// <summary>
        /// Original was GL_IR_INSTRUMENT1_SGIX = 0x817F
        /// </summary>
        IrInstrument1Sgix = ((int)0x817F),
        /// <summary>
        /// Original was GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183
        /// </summary>
        CalligraphicFragmentSgix = ((int)0x8183),
        /// <summary>
        /// Original was GL_FRAMEZOOM_SGIX = 0x818B
        /// </summary>
        FramezoomSgix = ((int)0x818B),
        /// <summary>
        /// Original was GL_FOG_OFFSET_SGIX = 0x8198
        /// </summary>
        FogOffsetSgix = ((int)0x8198),
        /// <summary>
        /// Original was GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB
        /// </summary>
        SharedTexturePaletteExt = ((int)0x81FB),
        /// <summary>
        /// Original was GL_ASYNC_HISTOGRAM_SGIX = 0x832C
        /// </summary>
        AsyncHistogramSgix = ((int)0x832C),
        /// <summary>
        /// Original was GL_PIXEL_TEXTURE_SGIS = 0x8353
        /// </summary>
        PixelTextureSgis = ((int)0x8353),
        /// <summary>
        /// Original was GL_ASYNC_TEX_IMAGE_SGIX = 0x835C
        /// </summary>
        AsyncTexImageSgix = ((int)0x835C),
        /// <summary>
        /// Original was GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D
        /// </summary>
        AsyncDrawPixelsSgix = ((int)0x835D),
        /// <summary>
        /// Original was GL_ASYNC_READ_PIXELS_SGIX = 0x835E
        /// </summary>
        AsyncReadPixelsSgix = ((int)0x835E),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHTING_SGIX = 0x8400
        /// </summary>
        FragmentLightingSgix = ((int)0x8400),
        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401
        /// </summary>
        FragmentColorMaterialSgix = ((int)0x8401),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT0_SGIX = 0x840C
        /// </summary>
        FragmentLight0Sgix = ((int)0x840C),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT1_SGIX = 0x840D
        /// </summary>
        FragmentLight1Sgix = ((int)0x840D),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT2_SGIX = 0x840E
        /// </summary>
        FragmentLight2Sgix = ((int)0x840E),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT3_SGIX = 0x840F
        /// </summary>
        FragmentLight3Sgix = ((int)0x840F),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT4_SGIX = 0x8410
        /// </summary>
        FragmentLight4Sgix = ((int)0x8410),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT5_SGIX = 0x8411
        /// </summary>
        FragmentLight5Sgix = ((int)0x8411),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT6_SGIX = 0x8412
        /// </summary>
        FragmentLight6Sgix = ((int)0x8412),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT7_SGIX = 0x8413
        /// </summary>
        FragmentLight7Sgix = ((int)0x8413),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ErrorCode : int
    {
        /// <summary>
        /// Original was GL_NO_ERROR = 0
        /// </summary>
        NoError = ((int)0),
        /// <summary>
        /// Original was GL_INVALID_ENUM = 0x0500
        /// </summary>
        InvalidEnum = ((int)0x0500),
        /// <summary>
        /// Original was GL_INVALID_VALUE = 0x0501
        /// </summary>
        InvalidValue = ((int)0x0501),
        /// <summary>
        /// Original was GL_INVALID_OPERATION = 0x0502
        /// </summary>
        InvalidOperation = ((int)0x0502),
        /// <summary>
        /// Original was GL_STACK_OVERFLOW = 0x0503
        /// </summary>
        StackOverflow = ((int)0x0503),
        /// <summary>
        /// Original was GL_STACK_UNDERFLOW = 0x0504
        /// </summary>
        StackUnderflow = ((int)0x0504),
        /// <summary>
        /// Original was GL_OUT_OF_MEMORY = 0x0505
        /// </summary>
        OutOfMemory = ((int)0x0505),
        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506
        /// </summary>
        InvalidFramebufferOperation = ((int)0x0506),
        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506
        /// </summary>
        InvalidFramebufferOperationExt = ((int)0x0506),
        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506
        /// </summary>
        InvalidFramebufferOperationOes = ((int)0x0506),
        /// <summary>
        /// Original was GL_TABLE_TOO_LARGE = 0x8031
        /// </summary>
        TableTooLarge = ((int)0x8031),
        /// <summary>
        /// Original was GL_TABLE_TOO_LARGE_EXT = 0x8031
        /// </summary>
        TableTooLargeExt = ((int)0x8031),
        /// <summary>
        /// Original was GL_TEXTURE_TOO_LARGE_EXT = 0x8065
        /// </summary>
        TextureTooLargeExt = ((int)0x8065),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtBlendMinmax : int
    {
        /// <summary>
        /// Original was GL_FUNC_ADD_EXT = 0x8006
        /// </summary>
        FuncAddExt = ((int)0x8006),
        /// <summary>
        /// Original was GL_MIN_EXT = 0x8007
        /// </summary>
        MinExt = ((int)0x8007),
        /// <summary>
        /// Original was GL_MAX_EXT = 0x8008
        /// </summary>
        MaxExt = ((int)0x8008),
        /// <summary>
        /// Original was GL_BLEND_EQUATION_EXT = 0x8009
        /// </summary>
        BlendEquationExt = ((int)0x8009),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtDebugMarker : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtDiscardFramebuffer : int
    {
        /// <summary>
        /// Original was GL_COLOR_EXT = 0x1800
        /// </summary>
        ColorExt = ((int)0x1800),
        /// <summary>
        /// Original was GL_DEPTH_EXT = 0x1801
        /// </summary>
        DepthExt = ((int)0x1801),
        /// <summary>
        /// Original was GL_STENCIL_EXT = 0x1802
        /// </summary>
        StencilExt = ((int)0x1802),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExternalHandleType : int
    {
        /// <summary>
        /// Original was GL_HANDLE_TYPE_OPAQUE_FD_EXT = 0x9586
        /// </summary>
        HandleTypeOpaqueFdExt = ((int)0x9586),
        /// <summary>
        /// Original was GL_HANDLE_TYPE_OPAQUE_WIN32_EXT = 0x9587
        /// </summary>
        HandleTypeOpaqueWin32Ext = ((int)0x9587),
        /// <summary>
        /// Original was GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT = 0x9588
        /// </summary>
        HandleTypeOpaqueWin32KmtExt = ((int)0x9588),
        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT = 0x9589
        /// </summary>
        HandleTypeD3D12TilepoolExt = ((int)0x9589),
        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D12_RESOURCE_EXT = 0x958A
        /// </summary>
        HandleTypeD3D12ResourceExt = ((int)0x958A),
        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D11_IMAGE_EXT = 0x958B
        /// </summary>
        HandleTypeD3D11ImageExt = ((int)0x958B),
        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT = 0x958C
        /// </summary>
        HandleTypeD3D11ImageKmtExt = ((int)0x958C),
        /// <summary>
        /// Original was GL_HANDLE_TYPE_D3D12_FENCE_EXT = 0x9594
        /// </summary>
        HandleTypeD3D12FenceExt = ((int)0x9594),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtMapBufferRange : int
    {
        /// <summary>
        /// Original was GL_MAP_READ_BIT_EXT = 0x0001
        /// </summary>
        MapReadBitExt = ((int)0x0001),
        /// <summary>
        /// Original was GL_MAP_WRITE_BIT_EXT = 0x0002
        /// </summary>
        MapWriteBitExt = ((int)0x0002),
        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004
        /// </summary>
        MapInvalidateRangeBitExt = ((int)0x0004),
        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008
        /// </summary>
        MapInvalidateBufferBitExt = ((int)0x0008),
        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010
        /// </summary>
        MapFlushExplicitBitExt = ((int)0x0010),
        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020
        /// </summary>
        MapUnsynchronizedBitExt = ((int)0x0020),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtMultiDrawArrays : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtMultisampledRenderToTexture : int
    {
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_EXT = 0x8CAB
        /// </summary>
        RenderbufferSamplesExt = ((int)0x8CAB),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisampleExt = ((int)0x8D56),
        /// <summary>
        /// Original was GL_MAX_SAMPLES_EXT = 0x8D57
        /// </summary>
        MaxSamplesExt = ((int)0x8D57),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT = 0x8D6C
        /// </summary>
        FramebufferAttachmentTextureSamplesExt = ((int)0x8D6C),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtReadFormatBgra : int
    {
        /// <summary>
        /// Original was GL_BGRA_EXT = 0x80E1
        /// </summary>
        BgraExt = ((int)0x80E1),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT = 0x8365
        /// </summary>
        UnsignedShort4444RevExt = ((int)0x8365),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT = 0x8366
        /// </summary>
        UnsignedShort1555RevExt = ((int)0x8366),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtRobustness : int
    {
        /// <summary>
        /// Original was GL_NO_ERROR = 0
        /// </summary>
        NoError = ((int)0),
        /// <summary>
        /// Original was GL_LOSE_CONTEXT_ON_RESET_EXT = 0x8252
        /// </summary>
        LoseContextOnResetExt = ((int)0x8252),
        /// <summary>
        /// Original was GL_GUILTY_CONTEXT_RESET_EXT = 0x8253
        /// </summary>
        GuiltyContextResetExt = ((int)0x8253),
        /// <summary>
        /// Original was GL_INNOCENT_CONTEXT_RESET_EXT = 0x8254
        /// </summary>
        InnocentContextResetExt = ((int)0x8254),
        /// <summary>
        /// Original was GL_UNKNOWN_CONTEXT_RESET_EXT = 0x8255
        /// </summary>
        UnknownContextResetExt = ((int)0x8255),
        /// <summary>
        /// Original was GL_RESET_NOTIFICATION_STRATEGY_EXT = 0x8256
        /// </summary>
        ResetNotificationStrategyExt = ((int)0x8256),
        /// <summary>
        /// Original was GL_NO_RESET_NOTIFICATION_EXT = 0x8261
        /// </summary>
        NoResetNotificationExt = ((int)0x8261),
        /// <summary>
        /// Original was GL_CONTEXT_ROBUST_ACCESS_EXT = 0x90F3
        /// </summary>
        ContextRobustAccessExt = ((int)0x90F3),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtSrgb : int
    {
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT = 0x8210
        /// </summary>
        FramebufferAttachmentColorEncodingExt = ((int)0x8210),
        /// <summary>
        /// Original was GL_SRGB_EXT = 0x8C40
        /// </summary>
        SrgbExt = ((int)0x8C40),
        /// <summary>
        /// Original was GL_SRGB_ALPHA_EXT = 0x8C42
        /// </summary>
        SrgbAlphaExt = ((int)0x8C42),
        /// <summary>
        /// Original was GL_SRGB8_ALPHA8_EXT = 0x8C43
        /// </summary>
        Srgb8Alpha8Ext = ((int)0x8C43),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureCompressionDxt1 : int
    {
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0
        /// </summary>
        CompressedRgbS3tcDxt1Ext = ((int)0x83F0),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1
        /// </summary>
        CompressedRgbaS3tcDxt1Ext = ((int)0x83F1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum ExttextureFilterAnisotropic : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE
        /// </summary>
        TextureMaxAnisotropyExt = ((int)0x84FE),
        /// <summary>
        /// Original was GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF
        /// </summary>
        MaxTextureMaxAnisotropyExt = ((int)0x84FF),
        /// <summary>
        /// Original was GL_EXT_texture_filter_anisotropic = 1
        /// </summary>
        ExtTextureFilterAnisotropic = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum ExtTextureFilterAnisotropic : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE
        /// </summary>
        TextureMaxAnisotropyExt = ((int)0x84FE),
        /// <summary>
        /// Original was GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF
        /// </summary>
        MaxTextureMaxAnisotropyExt = ((int)0x84FF),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum ExttextureFormatBgra8888 : int
    {
        /// <summary>
        /// Original was GL_BGRA = 0x80E1
        /// </summary>
        Bgra = ((int)0x80E1),
        /// <summary>
        /// Original was GL_EXT_texture_format_BGRA8888 = 1
        /// </summary>
        ExtTextureFormatBgra8888 = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum ExtTextureFormatBgra8888 : int
    {
        /// <summary>
        /// Original was GL_BGRA_EXT = 0x80E1
        /// </summary>
        BgraExt = ((int)0x80E1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureLodBias : int
    {
        /// <summary>
        /// Original was GL_MAX_TEXTURE_LOD_BIAS_EXT = 0x84FD
        /// </summary>
        MaxTextureLodBiasExt = ((int)0x84FD),
        /// <summary>
        /// Original was GL_TEXTURE_FILTER_CONTROL_EXT = 0x8500
        /// </summary>
        TextureFilterControlExt = ((int)0x8500),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_EXT = 0x8501
        /// </summary>
        TextureLodBiasExt = ((int)0x8501),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureStorage : int
    {
        /// <summary>
        /// Original was GL_ALPHA8_EXT = 0x803C
        /// </summary>
        Alpha8Ext = ((int)0x803C),
        /// <summary>
        /// Original was GL_LUMINANCE8_EXT = 0x8040
        /// </summary>
        Luminance8Ext = ((int)0x8040),
        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8_EXT = 0x8045
        /// </summary>
        Luminance8Alpha8Ext = ((int)0x8045),
        /// <summary>
        /// Original was GL_RGB10_EXT = 0x8052
        /// </summary>
        Rgb10Ext = ((int)0x8052),
        /// <summary>
        /// Original was GL_RGB10_A2_EXT = 0x8059
        /// </summary>
        Rgb10A2Ext = ((int)0x8059),
        /// <summary>
        /// Original was GL_R8_EXT = 0x8229
        /// </summary>
        R8Ext = ((int)0x8229),
        /// <summary>
        /// Original was GL_RG8_EXT = 0x822B
        /// </summary>
        Rg8Ext = ((int)0x822B),
        /// <summary>
        /// Original was GL_R16F_EXT = 0x822D
        /// </summary>
        R16fExt = ((int)0x822D),
        /// <summary>
        /// Original was GL_R32F_EXT = 0x822E
        /// </summary>
        R32fExt = ((int)0x822E),
        /// <summary>
        /// Original was GL_RG16F_EXT = 0x822F
        /// </summary>
        Rg16fExt = ((int)0x822F),
        /// <summary>
        /// Original was GL_RG32F_EXT = 0x8230
        /// </summary>
        Rg32fExt = ((int)0x8230),
        /// <summary>
        /// Original was GL_RGBA32F_EXT = 0x8814
        /// </summary>
        Rgba32fExt = ((int)0x8814),
        /// <summary>
        /// Original was GL_RGB32F_EXT = 0x8815
        /// </summary>
        Rgb32fExt = ((int)0x8815),
        /// <summary>
        /// Original was GL_ALPHA32F_EXT = 0x8816
        /// </summary>
        Alpha32fExt = ((int)0x8816),
        /// <summary>
        /// Original was GL_LUMINANCE32F_EXT = 0x8818
        /// </summary>
        Luminance32fExt = ((int)0x8818),
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA32F_EXT = 0x8819
        /// </summary>
        LuminanceAlpha32fExt = ((int)0x8819),
        /// <summary>
        /// Original was GL_RGBA16F_EXT = 0x881A
        /// </summary>
        Rgba16fExt = ((int)0x881A),
        /// <summary>
        /// Original was GL_RGB16F_EXT = 0x881B
        /// </summary>
        Rgb16fExt = ((int)0x881B),
        /// <summary>
        /// Original was GL_ALPHA16F_EXT = 0x881C
        /// </summary>
        Alpha16fExt = ((int)0x881C),
        /// <summary>
        /// Original was GL_LUMINANCE16F_EXT = 0x881E
        /// </summary>
        Luminance16fExt = ((int)0x881E),
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA16F_EXT = 0x881F
        /// </summary>
        LuminanceAlpha16fExt = ((int)0x881F),
        /// <summary>
        /// Original was GL_TEXTURE_IMMUTABLE_FORMAT_EXT = 0x912F
        /// </summary>
        TextureImmutableFormatExt = ((int)0x912F),
        /// <summary>
        /// Original was GL_BGRA8_EXT = 0x93A1
        /// </summary>
        Bgra8Ext = ((int)0x93A1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FeedBackToken : int
    {
        /// <summary>
        /// Original was GL_PASS_THROUGH_TOKEN = 0x0700
        /// </summary>
        PassThroughToken = ((int)0x0700),
        /// <summary>
        /// Original was GL_POINT_TOKEN = 0x0701
        /// </summary>
        PointToken = ((int)0x0701),
        /// <summary>
        /// Original was GL_LINE_TOKEN = 0x0702
        /// </summary>
        LineToken = ((int)0x0702),
        /// <summary>
        /// Original was GL_POLYGON_TOKEN = 0x0703
        /// </summary>
        PolygonToken = ((int)0x0703),
        /// <summary>
        /// Original was GL_BITMAP_TOKEN = 0x0704
        /// </summary>
        BitmapToken = ((int)0x0704),
        /// <summary>
        /// Original was GL_DRAW_PIXEL_TOKEN = 0x0705
        /// </summary>
        DrawPixelToken = ((int)0x0705),
        /// <summary>
        /// Original was GL_COPY_PIXEL_TOKEN = 0x0706
        /// </summary>
        CopyPixelToken = ((int)0x0706),
        /// <summary>
        /// Original was GL_LINE_RESET_TOKEN = 0x0707
        /// </summary>
        LineResetToken = ((int)0x0707),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FeedbackType : int
    {
        /// <summary>
        /// Original was GL_2D = 0x0600
        /// </summary>
        Gl2D = ((int)0x0600),
        /// <summary>
        /// Original was GL_3D = 0x0601
        /// </summary>
        Gl3D = ((int)0x0601),
        /// <summary>
        /// Original was GL_3D_COLOR = 0x0602
        /// </summary>
        Gl3DColor = ((int)0x0602),
        /// <summary>
        /// Original was GL_3D_COLOR_TEXTURE = 0x0603
        /// </summary>
        Gl3DColorTexture = ((int)0x0603),
        /// <summary>
        /// Original was GL_4D_COLOR_TEXTURE = 0x0604
        /// </summary>
        Gl4DColorTexture = ((int)0x0604),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum FfdMaskSgix : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FfdTargetSgix : int
    {
        /// <summary>
        /// Original was GL_GEOMETRY_DEFORMATION_SGIX = 0x8194
        /// </summary>
        GeometryDeformationSgix = ((int)0x8194),
        /// <summary>
        /// Original was GL_TEXTURE_DEFORMATION_SGIX = 0x8195
        /// </summary>
        TextureDeformationSgix = ((int)0x8195),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogCoordinatePointerType : int
    {
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406),
        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = ((int)0x140A),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogMode : int
    {
        /// <summary>
        /// Original was GL_EXP = 0x0800
        /// </summary>
        Exp = ((int)0x0800),
        /// <summary>
        /// Original was GL_EXP2 = 0x0801
        /// </summary>
        Exp2 = ((int)0x0801),
        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = ((int)0x2601),
        /// <summary>
        /// Original was GL_FOG_FUNC_SGIS = 0x812A
        /// </summary>
        FogFuncSgis = ((int)0x812A),
    }

    /// <summary>
    /// Used in GL.Fog
    /// </summary>
    public enum FogParameter : int
    {
        /// <summary>
        /// Original was GL_FOG_INDEX = 0x0B61
        /// </summary>
        FogIndex = ((int)0x0B61),
        /// <summary>
        /// Original was GL_FOG_DENSITY = 0x0B62
        /// </summary>
        FogDensity = ((int)0x0B62),
        /// <summary>
        /// Original was GL_FOG_START = 0x0B63
        /// </summary>
        FogStart = ((int)0x0B63),
        /// <summary>
        /// Original was GL_FOG_END = 0x0B64
        /// </summary>
        FogEnd = ((int)0x0B64),
        /// <summary>
        /// Original was GL_FOG_MODE = 0x0B65
        /// </summary>
        FogMode = ((int)0x0B65),
        /// <summary>
        /// Original was GL_FOG_COLOR = 0x0B66
        /// </summary>
        FogColor = ((int)0x0B66),
        /// <summary>
        /// Original was GL_FOG_OFFSET_VALUE_SGIX = 0x8199
        /// </summary>
        FogOffsetValueSgix = ((int)0x8199),
    }

    /// <summary>
    /// Used in GL.Fogx, GL.Oes.Fogx
    /// </summary>
    public enum FogPName : int
    {
        /// <summary>
        /// Original was GL_FOG_INDEX = 0x0B61
        /// </summary>
        FogIndex = ((int)0x0B61),
        /// <summary>
        /// Original was GL_FOG_DENSITY = 0x0B62
        /// </summary>
        FogDensity = ((int)0x0B62),
        /// <summary>
        /// Original was GL_FOG_START = 0x0B63
        /// </summary>
        FogStart = ((int)0x0B63),
        /// <summary>
        /// Original was GL_FOG_END = 0x0B64
        /// </summary>
        FogEnd = ((int)0x0B64),
        /// <summary>
        /// Original was GL_FOG_MODE = 0x0B65
        /// </summary>
        FogMode = ((int)0x0B65),
        /// <summary>
        /// Original was GL_FOG_COORD_SRC = 0x8450
        /// </summary>
        FogCoordSrc = ((int)0x8450),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogPointerTypeExt : int
    {
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406),
        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = ((int)0x140A),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogPointerTypeIbm : int
    {
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406),
        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = ((int)0x140A),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FragmentLightModelParameterSgix : int
    {
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408
        /// </summary>
        FragmentLightModelLocalViewerSgix = ((int)0x8408),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409
        /// </summary>
        FragmentLightModelTwoSideSgix = ((int)0x8409),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A
        /// </summary>
        FragmentLightModelAmbientSgix = ((int)0x840A),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B
        /// </summary>
        FragmentLightModelNormalInterpolationSgix = ((int)0x840B),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FragmentOpAti : int
    {
        /// <summary>
        /// Original was GL_MOV_ATI = 0x8961
        /// </summary>
        MovAti = ((int)0x8961),
        /// <summary>
        /// Original was GL_ADD_ATI = 0x8963
        /// </summary>
        AddAti = ((int)0x8963),
        /// <summary>
        /// Original was GL_MUL_ATI = 0x8964
        /// </summary>
        MulAti = ((int)0x8964),
        /// <summary>
        /// Original was GL_SUB_ATI = 0x8965
        /// </summary>
        SubAti = ((int)0x8965),
        /// <summary>
        /// Original was GL_DOT3_ATI = 0x8966
        /// </summary>
        Dot3Ati = ((int)0x8966),
        /// <summary>
        /// Original was GL_DOT4_ATI = 0x8967
        /// </summary>
        Dot4Ati = ((int)0x8967),
        /// <summary>
        /// Original was GL_MAD_ATI = 0x8968
        /// </summary>
        MadAti = ((int)0x8968),
        /// <summary>
        /// Original was GL_LERP_ATI = 0x8969
        /// </summary>
        LerpAti = ((int)0x8969),
        /// <summary>
        /// Original was GL_CND_ATI = 0x896A
        /// </summary>
        CndAti = ((int)0x896A),
        /// <summary>
        /// Original was GL_CND0_ATI = 0x896B
        /// </summary>
        Cnd0Ati = ((int)0x896B),
        /// <summary>
        /// Original was GL_DOT2_ADD_ATI = 0x896C
        /// </summary>
        Dot2AddAti = ((int)0x896C),
    }

    /// <summary>
    /// Used in GL.Ext.FramebufferTexture2DMultisample, GL.Img.FramebufferTexture2DMultisample and 3 other functions
    /// </summary>
    public enum FramebufferAttachment : int
    {
        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS = 0x8CDF
        /// </summary>
        MaxColorAttachments = ((int)0x8CDF),
        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS_EXT = 0x8CDF
        /// </summary>
        MaxColorAttachmentsExt = ((int)0x8CDF),
        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS_NV = 0x8CDF
        /// </summary>
        MaxColorAttachmentsNv = ((int)0x8CDF),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        /// </summary>
        ColorAttachment0 = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_EXT = 0x8CE0
        /// </summary>
        ColorAttachment0Ext = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_NV = 0x8CE0
        /// </summary>
        ColorAttachment0Nv = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_OES = 0x8CE0
        /// </summary>
        ColorAttachment0Oes = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        /// </summary>
        ColorAttachment1 = ((int)0x8CE1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1_EXT = 0x8CE1
        /// </summary>
        ColorAttachment1Ext = ((int)0x8CE1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1_NV = 0x8CE1
        /// </summary>
        ColorAttachment1Nv = ((int)0x8CE1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        /// </summary>
        ColorAttachment2 = ((int)0x8CE2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2_EXT = 0x8CE2
        /// </summary>
        ColorAttachment2Ext = ((int)0x8CE2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2_NV = 0x8CE2
        /// </summary>
        ColorAttachment2Nv = ((int)0x8CE2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        /// </summary>
        ColorAttachment3 = ((int)0x8CE3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3_EXT = 0x8CE3
        /// </summary>
        ColorAttachment3Ext = ((int)0x8CE3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3_NV = 0x8CE3
        /// </summary>
        ColorAttachment3Nv = ((int)0x8CE3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        /// </summary>
        ColorAttachment4 = ((int)0x8CE4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4_EXT = 0x8CE4
        /// </summary>
        ColorAttachment4Ext = ((int)0x8CE4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4_NV = 0x8CE4
        /// </summary>
        ColorAttachment4Nv = ((int)0x8CE4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        /// </summary>
        ColorAttachment5 = ((int)0x8CE5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5_EXT = 0x8CE5
        /// </summary>
        ColorAttachment5Ext = ((int)0x8CE5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5_NV = 0x8CE5
        /// </summary>
        ColorAttachment5Nv = ((int)0x8CE5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        /// </summary>
        ColorAttachment6 = ((int)0x8CE6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6_EXT = 0x8CE6
        /// </summary>
        ColorAttachment6Ext = ((int)0x8CE6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6_NV = 0x8CE6
        /// </summary>
        ColorAttachment6Nv = ((int)0x8CE6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        /// </summary>
        ColorAttachment7 = ((int)0x8CE7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7_EXT = 0x8CE7
        /// </summary>
        ColorAttachment7Ext = ((int)0x8CE7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7_NV = 0x8CE7
        /// </summary>
        ColorAttachment7Nv = ((int)0x8CE7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        /// </summary>
        ColorAttachment8 = ((int)0x8CE8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8_EXT = 0x8CE8
        /// </summary>
        ColorAttachment8Ext = ((int)0x8CE8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8_NV = 0x8CE8
        /// </summary>
        ColorAttachment8Nv = ((int)0x8CE8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        /// </summary>
        ColorAttachment9 = ((int)0x8CE9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9_EXT = 0x8CE9
        /// </summary>
        ColorAttachment9Ext = ((int)0x8CE9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9_NV = 0x8CE9
        /// </summary>
        ColorAttachment9Nv = ((int)0x8CE9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        /// </summary>
        ColorAttachment10 = ((int)0x8CEA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10_EXT = 0x8CEA
        /// </summary>
        ColorAttachment10Ext = ((int)0x8CEA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10_NV = 0x8CEA
        /// </summary>
        ColorAttachment10Nv = ((int)0x8CEA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        /// </summary>
        ColorAttachment11 = ((int)0x8CEB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11_EXT = 0x8CEB
        /// </summary>
        ColorAttachment11Ext = ((int)0x8CEB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11_NV = 0x8CEB
        /// </summary>
        ColorAttachment11Nv = ((int)0x8CEB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        /// </summary>
        ColorAttachment12 = ((int)0x8CEC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12_EXT = 0x8CEC
        /// </summary>
        ColorAttachment12Ext = ((int)0x8CEC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12_NV = 0x8CEC
        /// </summary>
        ColorAttachment12Nv = ((int)0x8CEC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        /// </summary>
        ColorAttachment13 = ((int)0x8CED),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13_EXT = 0x8CED
        /// </summary>
        ColorAttachment13Ext = ((int)0x8CED),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13_NV = 0x8CED
        /// </summary>
        ColorAttachment13Nv = ((int)0x8CED),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        /// </summary>
        ColorAttachment14 = ((int)0x8CEE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14_EXT = 0x8CEE
        /// </summary>
        ColorAttachment14Ext = ((int)0x8CEE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14_NV = 0x8CEE
        /// </summary>
        ColorAttachment14Nv = ((int)0x8CEE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        /// </summary>
        ColorAttachment15 = ((int)0x8CEF),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15_EXT = 0x8CEF
        /// </summary>
        ColorAttachment15Ext = ((int)0x8CEF),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15_NV = 0x8CEF
        /// </summary>
        ColorAttachment15Nv = ((int)0x8CEF),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT16 = 0x8CF0
        /// </summary>
        ColorAttachment16 = ((int)0x8CF0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT17 = 0x8CF1
        /// </summary>
        ColorAttachment17 = ((int)0x8CF1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT18 = 0x8CF2
        /// </summary>
        ColorAttachment18 = ((int)0x8CF2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT19 = 0x8CF3
        /// </summary>
        ColorAttachment19 = ((int)0x8CF3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT20 = 0x8CF4
        /// </summary>
        ColorAttachment20 = ((int)0x8CF4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT21 = 0x8CF5
        /// </summary>
        ColorAttachment21 = ((int)0x8CF5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT22 = 0x8CF6
        /// </summary>
        ColorAttachment22 = ((int)0x8CF6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT23 = 0x8CF7
        /// </summary>
        ColorAttachment23 = ((int)0x8CF7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT24 = 0x8CF8
        /// </summary>
        ColorAttachment24 = ((int)0x8CF8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT25 = 0x8CF9
        /// </summary>
        ColorAttachment25 = ((int)0x8CF9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT26 = 0x8CFA
        /// </summary>
        ColorAttachment26 = ((int)0x8CFA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT27 = 0x8CFB
        /// </summary>
        ColorAttachment27 = ((int)0x8CFB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT28 = 0x8CFC
        /// </summary>
        ColorAttachment28 = ((int)0x8CFC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT29 = 0x8CFD
        /// </summary>
        ColorAttachment29 = ((int)0x8CFD),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT30 = 0x8CFE
        /// </summary>
        ColorAttachment30 = ((int)0x8CFE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT31 = 0x8CFF
        /// </summary>
        ColorAttachment31 = ((int)0x8CFF),
        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT = 0x8D00
        /// </summary>
        DepthAttachment = ((int)0x8D00),
        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_EXT = 0x8D00
        /// </summary>
        DepthAttachmentExt = ((int)0x8D00),
        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_OES = 0x8D00
        /// </summary>
        DepthAttachmentOes = ((int)0x8D00),
    }

    /// <summary>
    /// Used in GL.Oes.GetFramebufferAttachmentParameter
    /// </summary>
    public enum FramebufferAttachmentParameterName : int
    {
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210
        /// </summary>
        FramebufferAttachmentColorEncoding = ((int)0x8210),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211
        /// </summary>
        FramebufferAttachmentComponentType = ((int)0x8211),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212
        /// </summary>
        FramebufferAttachmentRedSize = ((int)0x8212),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213
        /// </summary>
        FramebufferAttachmentGreenSize = ((int)0x8213),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214
        /// </summary>
        FramebufferAttachmentBlueSize = ((int)0x8214),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215
        /// </summary>
        FramebufferAttachmentAlphaSize = ((int)0x8215),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216
        /// </summary>
        FramebufferAttachmentDepthSize = ((int)0x8216),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217
        /// </summary>
        FramebufferAttachmentStencilSize = ((int)0x8217),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectName = ((int)0x8CD1),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevel = ((int)0x8CD2),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4
        /// </summary>
        FramebufferAttachmentTextureLayer = ((int)0x8CD4),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7
        /// </summary>
        FramebufferAttachmentLayered = ((int)0x8DA7),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FramebufferFetchNoncoherent : int
    {
        /// <summary>
        /// Original was GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM = 0x96A2
        /// </summary>
        FramebufferFetchNoncoherentQcom = ((int)0x96A2),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FramebufferParameterName : int
    {
        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310
        /// </summary>
        FramebufferDefaultWidth = ((int)0x9310),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311
        /// </summary>
        FramebufferDefaultHeight = ((int)0x9311),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312
        /// </summary>
        FramebufferDefaultLayers = ((int)0x9312),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313
        /// </summary>
        FramebufferDefaultSamples = ((int)0x9313),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314
        /// </summary>
        FramebufferDefaultFixedSampleLocations = ((int)0x9314),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FramebufferStatus : int
    {
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNDEFINED = 0x8219
        /// </summary>
        FramebufferUndefined = ((int)0x8219),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE = 0x8CD5
        /// </summary>
        FramebufferComplete = ((int)0x8CD5),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachment = ((int)0x8CD6),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachment = ((int)0x8CD7),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB
        /// </summary>
        FramebufferIncompleteDrawBuffer = ((int)0x8CDB),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC
        /// </summary>
        FramebufferIncompleteReadBuffer = ((int)0x8CDC),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD
        /// </summary>
        FramebufferUnsupported = ((int)0x8CDD),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisample = ((int)0x8D56),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8
        /// </summary>
        FramebufferIncompleteLayerTargets = ((int)0x8DA8),
    }

    /// <summary>
    /// Used in GL.Ext.FramebufferTexture2DMultisample, GL.Img.FramebufferTexture2DMultisample and 5 other functions
    /// </summary>
    public enum FramebufferTarget : int
    {
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER = 0x8CA8
        /// </summary>
        ReadFramebuffer = ((int)0x8CA8),
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER = 0x8CA9
        /// </summary>
        DrawFramebuffer = ((int)0x8CA9),
        /// <summary>
        /// Original was GL_FRAMEBUFFER = 0x8D40
        /// </summary>
        Framebuffer = ((int)0x8D40),
    }

    /// <summary>
    /// Used in GL.FrontFace
    /// </summary>
    public enum FrontFaceDirection : int
    {
        /// <summary>
        /// Original was GL_CW = 0x0900
        /// </summary>
        Cw = ((int)0x0900),
        /// <summary>
        /// Original was GL_CCW = 0x0901
        /// </summary>
        Ccw = ((int)0x0901),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetColorTableParameterPNameSgi : int
    {
        /// <summary>
        /// Original was GL_COLOR_TABLE_SCALE = 0x80D6
        /// </summary>
        ColorTableScale = ((int)0x80D6),
        /// <summary>
        /// Original was GL_COLOR_TABLE_SCALE_SGI = 0x80D6
        /// </summary>
        ColorTableScaleSgi = ((int)0x80D6),
        /// <summary>
        /// Original was GL_COLOR_TABLE_BIAS = 0x80D7
        /// </summary>
        ColorTableBias = ((int)0x80D7),
        /// <summary>
        /// Original was GL_COLOR_TABLE_BIAS_SGI = 0x80D7
        /// </summary>
        ColorTableBiasSgi = ((int)0x80D7),
        /// <summary>
        /// Original was GL_COLOR_TABLE_FORMAT = 0x80D8
        /// </summary>
        ColorTableFormat = ((int)0x80D8),
        /// <summary>
        /// Original was GL_COLOR_TABLE_FORMAT_SGI = 0x80D8
        /// </summary>
        ColorTableFormatSgi = ((int)0x80D8),
        /// <summary>
        /// Original was GL_COLOR_TABLE_WIDTH = 0x80D9
        /// </summary>
        ColorTableWidth = ((int)0x80D9),
        /// <summary>
        /// Original was GL_COLOR_TABLE_WIDTH_SGI = 0x80D9
        /// </summary>
        ColorTableWidthSgi = ((int)0x80D9),
        /// <summary>
        /// Original was GL_COLOR_TABLE_RED_SIZE = 0x80DA
        /// </summary>
        ColorTableRedSize = ((int)0x80DA),
        /// <summary>
        /// Original was GL_COLOR_TABLE_RED_SIZE_SGI = 0x80DA
        /// </summary>
        ColorTableRedSizeSgi = ((int)0x80DA),
        /// <summary>
        /// Original was GL_COLOR_TABLE_GREEN_SIZE = 0x80DB
        /// </summary>
        ColorTableGreenSize = ((int)0x80DB),
        /// <summary>
        /// Original was GL_COLOR_TABLE_GREEN_SIZE_SGI = 0x80DB
        /// </summary>
        ColorTableGreenSizeSgi = ((int)0x80DB),
        /// <summary>
        /// Original was GL_COLOR_TABLE_BLUE_SIZE = 0x80DC
        /// </summary>
        ColorTableBlueSize = ((int)0x80DC),
        /// <summary>
        /// Original was GL_COLOR_TABLE_BLUE_SIZE_SGI = 0x80DC
        /// </summary>
        ColorTableBlueSizeSgi = ((int)0x80DC),
        /// <summary>
        /// Original was GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD
        /// </summary>
        ColorTableAlphaSize = ((int)0x80DD),
        /// <summary>
        /// Original was GL_COLOR_TABLE_ALPHA_SIZE_SGI = 0x80DD
        /// </summary>
        ColorTableAlphaSizeSgi = ((int)0x80DD),
        /// <summary>
        /// Original was GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE
        /// </summary>
        ColorTableLuminanceSize = ((int)0x80DE),
        /// <summary>
        /// Original was GL_COLOR_TABLE_LUMINANCE_SIZE_SGI = 0x80DE
        /// </summary>
        ColorTableLuminanceSizeSgi = ((int)0x80DE),
        /// <summary>
        /// Original was GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF
        /// </summary>
        ColorTableIntensitySize = ((int)0x80DF),
        /// <summary>
        /// Original was GL_COLOR_TABLE_INTENSITY_SIZE_SGI = 0x80DF
        /// </summary>
        ColorTableIntensitySizeSgi = ((int)0x80DF),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetConvolutionParameter : int
    {
        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_MODE = 0x8013
        /// </summary>
        ConvolutionBorderMode = ((int)0x8013),
        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_MODE_EXT = 0x8013
        /// </summary>
        ConvolutionBorderModeExt = ((int)0x8013),
        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_SCALE = 0x8014
        /// </summary>
        ConvolutionFilterScale = ((int)0x8014),
        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_SCALE_EXT = 0x8014
        /// </summary>
        ConvolutionFilterScaleExt = ((int)0x8014),
        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_BIAS = 0x8015
        /// </summary>
        ConvolutionFilterBias = ((int)0x8015),
        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_BIAS_EXT = 0x8015
        /// </summary>
        ConvolutionFilterBiasExt = ((int)0x8015),
        /// <summary>
        /// Original was GL_CONVOLUTION_FORMAT = 0x8017
        /// </summary>
        ConvolutionFormat = ((int)0x8017),
        /// <summary>
        /// Original was GL_CONVOLUTION_FORMAT_EXT = 0x8017
        /// </summary>
        ConvolutionFormatExt = ((int)0x8017),
        /// <summary>
        /// Original was GL_CONVOLUTION_WIDTH = 0x8018
        /// </summary>
        ConvolutionWidth = ((int)0x8018),
        /// <summary>
        /// Original was GL_CONVOLUTION_WIDTH_EXT = 0x8018
        /// </summary>
        ConvolutionWidthExt = ((int)0x8018),
        /// <summary>
        /// Original was GL_CONVOLUTION_HEIGHT = 0x8019
        /// </summary>
        ConvolutionHeight = ((int)0x8019),
        /// <summary>
        /// Original was GL_CONVOLUTION_HEIGHT_EXT = 0x8019
        /// </summary>
        ConvolutionHeightExt = ((int)0x8019),
        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_WIDTH = 0x801A
        /// </summary>
        MaxConvolutionWidth = ((int)0x801A),
        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_WIDTH_EXT = 0x801A
        /// </summary>
        MaxConvolutionWidthExt = ((int)0x801A),
        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_HEIGHT = 0x801B
        /// </summary>
        MaxConvolutionHeight = ((int)0x801B),
        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_HEIGHT_EXT = 0x801B
        /// </summary>
        MaxConvolutionHeightExt = ((int)0x801B),
        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_COLOR = 0x8154
        /// </summary>
        ConvolutionBorderColor = ((int)0x8154),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetFramebufferParameter : int
    {
        /// <summary>
        /// Original was GL_DOUBLEBUFFER = 0x0C32
        /// </summary>
        Doublebuffer = ((int)0x0C32),
        /// <summary>
        /// Original was GL_STEREO = 0x0C33
        /// </summary>
        Stereo = ((int)0x0C33),
        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS = 0x80A8
        /// </summary>
        SampleBuffers = ((int)0x80A8),
        /// <summary>
        /// Original was GL_SAMPLES = 0x80A9
        /// </summary>
        Samples = ((int)0x80A9),
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A
        /// </summary>
        ImplementationColorReadType = ((int)0x8B9A),
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B
        /// </summary>
        ImplementationColorReadFormat = ((int)0x8B9B),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310
        /// </summary>
        FramebufferDefaultWidth = ((int)0x9310),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311
        /// </summary>
        FramebufferDefaultHeight = ((int)0x9311),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312
        /// </summary>
        FramebufferDefaultLayers = ((int)0x9312),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313
        /// </summary>
        FramebufferDefaultSamples = ((int)0x9313),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314
        /// </summary>
        FramebufferDefaultFixedSampleLocations = ((int)0x9314),
    }

    /// <summary>
    /// Used in GL.Oes.GetHistogramParameterx
    /// </summary>
    public enum GetHistogramParameterPNameExt : int
    {
        /// <summary>
        /// Original was GL_HISTOGRAM_WIDTH = 0x8026
        /// </summary>
        HistogramWidth = ((int)0x8026),
        /// <summary>
        /// Original was GL_HISTOGRAM_WIDTH_EXT = 0x8026
        /// </summary>
        HistogramWidthExt = ((int)0x8026),
        /// <summary>
        /// Original was GL_HISTOGRAM_FORMAT = 0x8027
        /// </summary>
        HistogramFormat = ((int)0x8027),
        /// <summary>
        /// Original was GL_HISTOGRAM_FORMAT_EXT = 0x8027
        /// </summary>
        HistogramFormatExt = ((int)0x8027),
        /// <summary>
        /// Original was GL_HISTOGRAM_RED_SIZE = 0x8028
        /// </summary>
        HistogramRedSize = ((int)0x8028),
        /// <summary>
        /// Original was GL_HISTOGRAM_RED_SIZE_EXT = 0x8028
        /// </summary>
        HistogramRedSizeExt = ((int)0x8028),
        /// <summary>
        /// Original was GL_HISTOGRAM_GREEN_SIZE = 0x8029
        /// </summary>
        HistogramGreenSize = ((int)0x8029),
        /// <summary>
        /// Original was GL_HISTOGRAM_GREEN_SIZE_EXT = 0x8029
        /// </summary>
        HistogramGreenSizeExt = ((int)0x8029),
        /// <summary>
        /// Original was GL_HISTOGRAM_BLUE_SIZE = 0x802A
        /// </summary>
        HistogramBlueSize = ((int)0x802A),
        /// <summary>
        /// Original was GL_HISTOGRAM_BLUE_SIZE_EXT = 0x802A
        /// </summary>
        HistogramBlueSizeExt = ((int)0x802A),
        /// <summary>
        /// Original was GL_HISTOGRAM_ALPHA_SIZE = 0x802B
        /// </summary>
        HistogramAlphaSize = ((int)0x802B),
        /// <summary>
        /// Original was GL_HISTOGRAM_ALPHA_SIZE_EXT = 0x802B
        /// </summary>
        HistogramAlphaSizeExt = ((int)0x802B),
        /// <summary>
        /// Original was GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C
        /// </summary>
        HistogramLuminanceSize = ((int)0x802C),
        /// <summary>
        /// Original was GL_HISTOGRAM_LUMINANCE_SIZE_EXT = 0x802C
        /// </summary>
        HistogramLuminanceSizeExt = ((int)0x802C),
        /// <summary>
        /// Original was GL_HISTOGRAM_SINK = 0x802D
        /// </summary>
        HistogramSink = ((int)0x802D),
        /// <summary>
        /// Original was GL_HISTOGRAM_SINK_EXT = 0x802D
        /// </summary>
        HistogramSinkExt = ((int)0x802D),
    }

    /// <summary>
    /// Used in GL.Oes.GetMapx
    /// </summary>
    public enum GetMapQuery : int
    {
        /// <summary>
        /// Original was GL_COEFF = 0x0A00
        /// </summary>
        Coeff = ((int)0x0A00),
        /// <summary>
        /// Original was GL_ORDER = 0x0A01
        /// </summary>
        Order = ((int)0x0A01),
        /// <summary>
        /// Original was GL_DOMAIN = 0x0A02
        /// </summary>
        Domain = ((int)0x0A02),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetMinmaxParameterPNameExt : int
    {
        /// <summary>
        /// Original was GL_MINMAX_FORMAT = 0x802F
        /// </summary>
        MinmaxFormat = ((int)0x802F),
        /// <summary>
        /// Original was GL_MINMAX_FORMAT_EXT = 0x802F
        /// </summary>
        MinmaxFormatExt = ((int)0x802F),
        /// <summary>
        /// Original was GL_MINMAX_SINK = 0x8030
        /// </summary>
        MinmaxSink = ((int)0x8030),
        /// <summary>
        /// Original was GL_MINMAX_SINK_EXT = 0x8030
        /// </summary>
        MinmaxSinkExt = ((int)0x8030),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetPixelMap : int
    {
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_I = 0x0C70
        /// </summary>
        PixelMapIToI = ((int)0x0C70),
        /// <summary>
        /// Original was GL_PIXEL_MAP_S_TO_S = 0x0C71
        /// </summary>
        PixelMapSToS = ((int)0x0C71),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_R = 0x0C72
        /// </summary>
        PixelMapIToR = ((int)0x0C72),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_G = 0x0C73
        /// </summary>
        PixelMapIToG = ((int)0x0C73),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_B = 0x0C74
        /// </summary>
        PixelMapIToB = ((int)0x0C74),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_A = 0x0C75
        /// </summary>
        PixelMapIToA = ((int)0x0C75),
        /// <summary>
        /// Original was GL_PIXEL_MAP_R_TO_R = 0x0C76
        /// </summary>
        PixelMapRToR = ((int)0x0C76),
        /// <summary>
        /// Original was GL_PIXEL_MAP_G_TO_G = 0x0C77
        /// </summary>
        PixelMapGToG = ((int)0x0C77),
        /// <summary>
        /// Original was GL_PIXEL_MAP_B_TO_B = 0x0C78
        /// </summary>
        PixelMapBToB = ((int)0x0C78),
        /// <summary>
        /// Original was GL_PIXEL_MAP_A_TO_A = 0x0C79
        /// </summary>
        PixelMapAToA = ((int)0x0C79),
    }

    /// <summary>
    /// Used in GL.Apple.GetInteger64, GL.GetBoolean and 4 other functions
    /// </summary>
    public enum GetPName : int
    {
        /// <summary>
        /// Original was GL_CURRENT_COLOR = 0x0B00
        /// </summary>
        CurrentColor = ((int)0x0B00),
        /// <summary>
        /// Original was GL_CURRENT_INDEX = 0x0B01
        /// </summary>
        CurrentIndex = ((int)0x0B01),
        /// <summary>
        /// Original was GL_CURRENT_NORMAL = 0x0B02
        /// </summary>
        CurrentNormal = ((int)0x0B02),
        /// <summary>
        /// Original was GL_CURRENT_TEXTURE_COORDS = 0x0B03
        /// </summary>
        CurrentTextureCoords = ((int)0x0B03),
        /// <summary>
        /// Original was GL_CURRENT_RASTER_COLOR = 0x0B04
        /// </summary>
        CurrentRasterColor = ((int)0x0B04),
        /// <summary>
        /// Original was GL_CURRENT_RASTER_INDEX = 0x0B05
        /// </summary>
        CurrentRasterIndex = ((int)0x0B05),
        /// <summary>
        /// Original was GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06
        /// </summary>
        CurrentRasterTextureCoords = ((int)0x0B06),
        /// <summary>
        /// Original was GL_CURRENT_RASTER_POSITION = 0x0B07
        /// </summary>
        CurrentRasterPosition = ((int)0x0B07),
        /// <summary>
        /// Original was GL_CURRENT_RASTER_POSITION_VALID = 0x0B08
        /// </summary>
        CurrentRasterPositionValid = ((int)0x0B08),
        /// <summary>
        /// Original was GL_CURRENT_RASTER_DISTANCE = 0x0B09
        /// </summary>
        CurrentRasterDistance = ((int)0x0B09),
        /// <summary>
        /// Original was GL_POINT_SMOOTH = 0x0B10
        /// </summary>
        PointSmooth = ((int)0x0B10),
        /// <summary>
        /// Original was GL_POINT_SIZE = 0x0B11
        /// </summary>
        PointSize = ((int)0x0B11),
        /// <summary>
        /// Original was GL_POINT_SIZE_RANGE = 0x0B12
        /// </summary>
        PointSizeRange = ((int)0x0B12),
        /// <summary>
        /// Original was GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12
        /// </summary>
        SmoothPointSizeRange = ((int)0x0B12),
        /// <summary>
        /// Original was GL_POINT_SIZE_GRANULARITY = 0x0B13
        /// </summary>
        PointSizeGranularity = ((int)0x0B13),
        /// <summary>
        /// Original was GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13
        /// </summary>
        SmoothPointSizeGranularity = ((int)0x0B13),
        /// <summary>
        /// Original was GL_LINE_SMOOTH = 0x0B20
        /// </summary>
        LineSmooth = ((int)0x0B20),
        /// <summary>
        /// Original was GL_LINE_WIDTH = 0x0B21
        /// </summary>
        LineWidth = ((int)0x0B21),
        /// <summary>
        /// Original was GL_LINE_WIDTH_RANGE = 0x0B22
        /// </summary>
        LineWidthRange = ((int)0x0B22),
        /// <summary>
        /// Original was GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22
        /// </summary>
        SmoothLineWidthRange = ((int)0x0B22),
        /// <summary>
        /// Original was GL_LINE_WIDTH_GRANULARITY = 0x0B23
        /// </summary>
        LineWidthGranularity = ((int)0x0B23),
        /// <summary>
        /// Original was GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23
        /// </summary>
        SmoothLineWidthGranularity = ((int)0x0B23),
        /// <summary>
        /// Original was GL_LINE_STIPPLE = 0x0B24
        /// </summary>
        LineStipple = ((int)0x0B24),
        /// <summary>
        /// Original was GL_LINE_STIPPLE_PATTERN = 0x0B25
        /// </summary>
        LineStipplePattern = ((int)0x0B25),
        /// <summary>
        /// Original was GL_LINE_STIPPLE_REPEAT = 0x0B26
        /// </summary>
        LineStippleRepeat = ((int)0x0B26),
        /// <summary>
        /// Original was GL_LIST_MODE = 0x0B30
        /// </summary>
        ListMode = ((int)0x0B30),
        /// <summary>
        /// Original was GL_MAX_LIST_NESTING = 0x0B31
        /// </summary>
        MaxListNesting = ((int)0x0B31),
        /// <summary>
        /// Original was GL_LIST_BASE = 0x0B32
        /// </summary>
        ListBase = ((int)0x0B32),
        /// <summary>
        /// Original was GL_LIST_INDEX = 0x0B33
        /// </summary>
        ListIndex = ((int)0x0B33),
        /// <summary>
        /// Original was GL_POLYGON_MODE = 0x0B40
        /// </summary>
        PolygonMode = ((int)0x0B40),
        /// <summary>
        /// Original was GL_POLYGON_SMOOTH = 0x0B41
        /// </summary>
        PolygonSmooth = ((int)0x0B41),
        /// <summary>
        /// Original was GL_POLYGON_STIPPLE = 0x0B42
        /// </summary>
        PolygonStipple = ((int)0x0B42),
        /// <summary>
        /// Original was GL_EDGE_FLAG = 0x0B43
        /// </summary>
        EdgeFlag = ((int)0x0B43),
        /// <summary>
        /// Original was GL_CULL_FACE = 0x0B44
        /// </summary>
        CullFace = ((int)0x0B44),
        /// <summary>
        /// Original was GL_CULL_FACE_MODE = 0x0B45
        /// </summary>
        CullFaceMode = ((int)0x0B45),
        /// <summary>
        /// Original was GL_FRONT_FACE = 0x0B46
        /// </summary>
        FrontFace = ((int)0x0B46),
        /// <summary>
        /// Original was GL_LIGHTING = 0x0B50
        /// </summary>
        Lighting = ((int)0x0B50),
        /// <summary>
        /// Original was GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51
        /// </summary>
        LightModelLocalViewer = ((int)0x0B51),
        /// <summary>
        /// Original was GL_LIGHT_MODEL_TWO_SIDE = 0x0B52
        /// </summary>
        LightModelTwoSide = ((int)0x0B52),
        /// <summary>
        /// Original was GL_LIGHT_MODEL_AMBIENT = 0x0B53
        /// </summary>
        LightModelAmbient = ((int)0x0B53),
        /// <summary>
        /// Original was GL_SHADE_MODEL = 0x0B54
        /// </summary>
        ShadeModel = ((int)0x0B54),
        /// <summary>
        /// Original was GL_COLOR_MATERIAL_FACE = 0x0B55
        /// </summary>
        ColorMaterialFace = ((int)0x0B55),
        /// <summary>
        /// Original was GL_COLOR_MATERIAL_PARAMETER = 0x0B56
        /// </summary>
        ColorMaterialParameter = ((int)0x0B56),
        /// <summary>
        /// Original was GL_COLOR_MATERIAL = 0x0B57
        /// </summary>
        ColorMaterial = ((int)0x0B57),
        /// <summary>
        /// Original was GL_FOG = 0x0B60
        /// </summary>
        Fog = ((int)0x0B60),
        /// <summary>
        /// Original was GL_FOG_INDEX = 0x0B61
        /// </summary>
        FogIndex = ((int)0x0B61),
        /// <summary>
        /// Original was GL_FOG_DENSITY = 0x0B62
        /// </summary>
        FogDensity = ((int)0x0B62),
        /// <summary>
        /// Original was GL_FOG_START = 0x0B63
        /// </summary>
        FogStart = ((int)0x0B63),
        /// <summary>
        /// Original was GL_FOG_END = 0x0B64
        /// </summary>
        FogEnd = ((int)0x0B64),
        /// <summary>
        /// Original was GL_FOG_MODE = 0x0B65
        /// </summary>
        FogMode = ((int)0x0B65),
        /// <summary>
        /// Original was GL_FOG_COLOR = 0x0B66
        /// </summary>
        FogColor = ((int)0x0B66),
        /// <summary>
        /// Original was GL_DEPTH_RANGE = 0x0B70
        /// </summary>
        DepthRange = ((int)0x0B70),
        /// <summary>
        /// Original was GL_DEPTH_TEST = 0x0B71
        /// </summary>
        DepthTest = ((int)0x0B71),
        /// <summary>
        /// Original was GL_DEPTH_WRITEMASK = 0x0B72
        /// </summary>
        DepthWritemask = ((int)0x0B72),
        /// <summary>
        /// Original was GL_DEPTH_CLEAR_VALUE = 0x0B73
        /// </summary>
        DepthClearValue = ((int)0x0B73),
        /// <summary>
        /// Original was GL_DEPTH_FUNC = 0x0B74
        /// </summary>
        DepthFunc = ((int)0x0B74),
        /// <summary>
        /// Original was GL_ACCUM_CLEAR_VALUE = 0x0B80
        /// </summary>
        AccumClearValue = ((int)0x0B80),
        /// <summary>
        /// Original was GL_STENCIL_TEST = 0x0B90
        /// </summary>
        StencilTest = ((int)0x0B90),
        /// <summary>
        /// Original was GL_STENCIL_CLEAR_VALUE = 0x0B91
        /// </summary>
        StencilClearValue = ((int)0x0B91),
        /// <summary>
        /// Original was GL_STENCIL_FUNC = 0x0B92
        /// </summary>
        StencilFunc = ((int)0x0B92),
        /// <summary>
        /// Original was GL_STENCIL_VALUE_MASK = 0x0B93
        /// </summary>
        StencilValueMask = ((int)0x0B93),
        /// <summary>
        /// Original was GL_STENCIL_FAIL = 0x0B94
        /// </summary>
        StencilFail = ((int)0x0B94),
        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95
        /// </summary>
        StencilPassDepthFail = ((int)0x0B95),
        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_PASS = 0x0B96
        /// </summary>
        StencilPassDepthPass = ((int)0x0B96),
        /// <summary>
        /// Original was GL_STENCIL_REF = 0x0B97
        /// </summary>
        StencilRef = ((int)0x0B97),
        /// <summary>
        /// Original was GL_STENCIL_WRITEMASK = 0x0B98
        /// </summary>
        StencilWritemask = ((int)0x0B98),
        /// <summary>
        /// Original was GL_MATRIX_MODE = 0x0BA0
        /// </summary>
        MatrixMode = ((int)0x0BA0),
        /// <summary>
        /// Original was GL_NORMALIZE = 0x0BA1
        /// </summary>
        Normalize = ((int)0x0BA1),
        /// <summary>
        /// Original was GL_VIEWPORT = 0x0BA2
        /// </summary>
        Viewport = ((int)0x0BA2),
        /// <summary>
        /// Original was GL_MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3
        /// </summary>
        Modelview0StackDepthExt = ((int)0x0BA3),
        /// <summary>
        /// Original was GL_MODELVIEW_STACK_DEPTH = 0x0BA3
        /// </summary>
        ModelviewStackDepth = ((int)0x0BA3),
        /// <summary>
        /// Original was GL_PROJECTION_STACK_DEPTH = 0x0BA4
        /// </summary>
        ProjectionStackDepth = ((int)0x0BA4),
        /// <summary>
        /// Original was GL_TEXTURE_STACK_DEPTH = 0x0BA5
        /// </summary>
        TextureStackDepth = ((int)0x0BA5),
        /// <summary>
        /// Original was GL_MODELVIEW0_MATRIX_EXT = 0x0BA6
        /// </summary>
        Modelview0MatrixExt = ((int)0x0BA6),
        /// <summary>
        /// Original was GL_MODELVIEW_MATRIX = 0x0BA6
        /// </summary>
        ModelviewMatrix = ((int)0x0BA6),
        /// <summary>
        /// Original was GL_PROJECTION_MATRIX = 0x0BA7
        /// </summary>
        ProjectionMatrix = ((int)0x0BA7),
        /// <summary>
        /// Original was GL_TEXTURE_MATRIX = 0x0BA8
        /// </summary>
        TextureMatrix = ((int)0x0BA8),
        /// <summary>
        /// Original was GL_ATTRIB_STACK_DEPTH = 0x0BB0
        /// </summary>
        AttribStackDepth = ((int)0x0BB0),
        /// <summary>
        /// Original was GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1
        /// </summary>
        ClientAttribStackDepth = ((int)0x0BB1),
        /// <summary>
        /// Original was GL_ALPHA_TEST = 0x0BC0
        /// </summary>
        AlphaTest = ((int)0x0BC0),
        /// <summary>
        /// Original was GL_ALPHA_TEST_QCOM = 0x0BC0
        /// </summary>
        AlphaTestQcom = ((int)0x0BC0),
        /// <summary>
        /// Original was GL_ALPHA_TEST_FUNC = 0x0BC1
        /// </summary>
        AlphaTestFunc = ((int)0x0BC1),
        /// <summary>
        /// Original was GL_ALPHA_TEST_FUNC_QCOM = 0x0BC1
        /// </summary>
        AlphaTestFuncQcom = ((int)0x0BC1),
        /// <summary>
        /// Original was GL_ALPHA_TEST_REF = 0x0BC2
        /// </summary>
        AlphaTestRef = ((int)0x0BC2),
        /// <summary>
        /// Original was GL_ALPHA_TEST_REF_QCOM = 0x0BC2
        /// </summary>
        AlphaTestRefQcom = ((int)0x0BC2),
        /// <summary>
        /// Original was GL_DITHER = 0x0BD0
        /// </summary>
        Dither = ((int)0x0BD0),
        /// <summary>
        /// Original was GL_BLEND_DST = 0x0BE0
        /// </summary>
        BlendDst = ((int)0x0BE0),
        /// <summary>
        /// Original was GL_BLEND_SRC = 0x0BE1
        /// </summary>
        BlendSrc = ((int)0x0BE1),
        /// <summary>
        /// Original was GL_BLEND = 0x0BE2
        /// </summary>
        Blend = ((int)0x0BE2),
        /// <summary>
        /// Original was GL_LOGIC_OP_MODE = 0x0BF0
        /// </summary>
        LogicOpMode = ((int)0x0BF0),
        /// <summary>
        /// Original was GL_INDEX_LOGIC_OP = 0x0BF1
        /// </summary>
        IndexLogicOp = ((int)0x0BF1),
        /// <summary>
        /// Original was GL_LOGIC_OP = 0x0BF1
        /// </summary>
        LogicOp = ((int)0x0BF1),
        /// <summary>
        /// Original was GL_COLOR_LOGIC_OP = 0x0BF2
        /// </summary>
        ColorLogicOp = ((int)0x0BF2),
        /// <summary>
        /// Original was GL_AUX_BUFFERS = 0x0C00
        /// </summary>
        AuxBuffers = ((int)0x0C00),
        /// <summary>
        /// Original was GL_DRAW_BUFFER = 0x0C01
        /// </summary>
        DrawBuffer = ((int)0x0C01),
        /// <summary>
        /// Original was GL_DRAW_BUFFER_EXT = 0x0C01
        /// </summary>
        DrawBufferExt = ((int)0x0C01),
        /// <summary>
        /// Original was GL_READ_BUFFER = 0x0C02
        /// </summary>
        ReadBuffer = ((int)0x0C02),
        /// <summary>
        /// Original was GL_READ_BUFFER_EXT = 0x0C02
        /// </summary>
        ReadBufferExt = ((int)0x0C02),
        /// <summary>
        /// Original was GL_READ_BUFFER_NV = 0x0C02
        /// </summary>
        ReadBufferNv = ((int)0x0C02),
        /// <summary>
        /// Original was GL_SCISSOR_BOX = 0x0C10
        /// </summary>
        ScissorBox = ((int)0x0C10),
        /// <summary>
        /// Original was GL_SCISSOR_TEST = 0x0C11
        /// </summary>
        ScissorTest = ((int)0x0C11),
        /// <summary>
        /// Original was GL_INDEX_CLEAR_VALUE = 0x0C20
        /// </summary>
        IndexClearValue = ((int)0x0C20),
        /// <summary>
        /// Original was GL_INDEX_WRITEMASK = 0x0C21
        /// </summary>
        IndexWritemask = ((int)0x0C21),
        /// <summary>
        /// Original was GL_COLOR_CLEAR_VALUE = 0x0C22
        /// </summary>
        ColorClearValue = ((int)0x0C22),
        /// <summary>
        /// Original was GL_COLOR_WRITEMASK = 0x0C23
        /// </summary>
        ColorWritemask = ((int)0x0C23),
        /// <summary>
        /// Original was GL_INDEX_MODE = 0x0C30
        /// </summary>
        IndexMode = ((int)0x0C30),
        /// <summary>
        /// Original was GL_RGBA_MODE = 0x0C31
        /// </summary>
        RgbaMode = ((int)0x0C31),
        /// <summary>
        /// Original was GL_DOUBLEBUFFER = 0x0C32
        /// </summary>
        Doublebuffer = ((int)0x0C32),
        /// <summary>
        /// Original was GL_STEREO = 0x0C33
        /// </summary>
        Stereo = ((int)0x0C33),
        /// <summary>
        /// Original was GL_RENDER_MODE = 0x0C40
        /// </summary>
        RenderMode = ((int)0x0C40),
        /// <summary>
        /// Original was GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50
        /// </summary>
        PerspectiveCorrectionHint = ((int)0x0C50),
        /// <summary>
        /// Original was GL_POINT_SMOOTH_HINT = 0x0C51
        /// </summary>
        PointSmoothHint = ((int)0x0C51),
        /// <summary>
        /// Original was GL_LINE_SMOOTH_HINT = 0x0C52
        /// </summary>
        LineSmoothHint = ((int)0x0C52),
        /// <summary>
        /// Original was GL_POLYGON_SMOOTH_HINT = 0x0C53
        /// </summary>
        PolygonSmoothHint = ((int)0x0C53),
        /// <summary>
        /// Original was GL_FOG_HINT = 0x0C54
        /// </summary>
        FogHint = ((int)0x0C54),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_S = 0x0C60
        /// </summary>
        TextureGenS = ((int)0x0C60),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_T = 0x0C61
        /// </summary>
        TextureGenT = ((int)0x0C61),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_R = 0x0C62
        /// </summary>
        TextureGenR = ((int)0x0C62),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_Q = 0x0C63
        /// </summary>
        TextureGenQ = ((int)0x0C63),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0
        /// </summary>
        PixelMapIToISize = ((int)0x0CB0),
        /// <summary>
        /// Original was GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1
        /// </summary>
        PixelMapSToSSize = ((int)0x0CB1),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2
        /// </summary>
        PixelMapIToRSize = ((int)0x0CB2),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3
        /// </summary>
        PixelMapIToGSize = ((int)0x0CB3),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4
        /// </summary>
        PixelMapIToBSize = ((int)0x0CB4),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5
        /// </summary>
        PixelMapIToASize = ((int)0x0CB5),
        /// <summary>
        /// Original was GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6
        /// </summary>
        PixelMapRToRSize = ((int)0x0CB6),
        /// <summary>
        /// Original was GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7
        /// </summary>
        PixelMapGToGSize = ((int)0x0CB7),
        /// <summary>
        /// Original was GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8
        /// </summary>
        PixelMapBToBSize = ((int)0x0CB8),
        /// <summary>
        /// Original was GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9
        /// </summary>
        PixelMapAToASize = ((int)0x0CB9),
        /// <summary>
        /// Original was GL_UNPACK_SWAP_BYTES = 0x0CF0
        /// </summary>
        UnpackSwapBytes = ((int)0x0CF0),
        /// <summary>
        /// Original was GL_UNPACK_LSB_FIRST = 0x0CF1
        /// </summary>
        UnpackLsbFirst = ((int)0x0CF1),
        /// <summary>
        /// Original was GL_UNPACK_ROW_LENGTH = 0x0CF2
        /// </summary>
        UnpackRowLength = ((int)0x0CF2),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_ROWS = 0x0CF3
        /// </summary>
        UnpackSkipRows = ((int)0x0CF3),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_PIXELS = 0x0CF4
        /// </summary>
        UnpackSkipPixels = ((int)0x0CF4),
        /// <summary>
        /// Original was GL_UNPACK_ALIGNMENT = 0x0CF5
        /// </summary>
        UnpackAlignment = ((int)0x0CF5),
        /// <summary>
        /// Original was GL_PACK_SWAP_BYTES = 0x0D00
        /// </summary>
        PackSwapBytes = ((int)0x0D00),
        /// <summary>
        /// Original was GL_PACK_LSB_FIRST = 0x0D01
        /// </summary>
        PackLsbFirst = ((int)0x0D01),
        /// <summary>
        /// Original was GL_PACK_ROW_LENGTH = 0x0D02
        /// </summary>
        PackRowLength = ((int)0x0D02),
        /// <summary>
        /// Original was GL_PACK_SKIP_ROWS = 0x0D03
        /// </summary>
        PackSkipRows = ((int)0x0D03),
        /// <summary>
        /// Original was GL_PACK_SKIP_PIXELS = 0x0D04
        /// </summary>
        PackSkipPixels = ((int)0x0D04),
        /// <summary>
        /// Original was GL_PACK_ALIGNMENT = 0x0D05
        /// </summary>
        PackAlignment = ((int)0x0D05),
        /// <summary>
        /// Original was GL_MAP_COLOR = 0x0D10
        /// </summary>
        MapColor = ((int)0x0D10),
        /// <summary>
        /// Original was GL_MAP_STENCIL = 0x0D11
        /// </summary>
        MapStencil = ((int)0x0D11),
        /// <summary>
        /// Original was GL_INDEX_SHIFT = 0x0D12
        /// </summary>
        IndexShift = ((int)0x0D12),
        /// <summary>
        /// Original was GL_INDEX_OFFSET = 0x0D13
        /// </summary>
        IndexOffset = ((int)0x0D13),
        /// <summary>
        /// Original was GL_RED_SCALE = 0x0D14
        /// </summary>
        RedScale = ((int)0x0D14),
        /// <summary>
        /// Original was GL_RED_BIAS = 0x0D15
        /// </summary>
        RedBias = ((int)0x0D15),
        /// <summary>
        /// Original was GL_ZOOM_X = 0x0D16
        /// </summary>
        ZoomX = ((int)0x0D16),
        /// <summary>
        /// Original was GL_ZOOM_Y = 0x0D17
        /// </summary>
        ZoomY = ((int)0x0D17),
        /// <summary>
        /// Original was GL_GREEN_SCALE = 0x0D18
        /// </summary>
        GreenScale = ((int)0x0D18),
        /// <summary>
        /// Original was GL_GREEN_BIAS = 0x0D19
        /// </summary>
        GreenBias = ((int)0x0D19),
        /// <summary>
        /// Original was GL_BLUE_SCALE = 0x0D1A
        /// </summary>
        BlueScale = ((int)0x0D1A),
        /// <summary>
        /// Original was GL_BLUE_BIAS = 0x0D1B
        /// </summary>
        BlueBias = ((int)0x0D1B),
        /// <summary>
        /// Original was GL_ALPHA_SCALE = 0x0D1C
        /// </summary>
        AlphaScale = ((int)0x0D1C),
        /// <summary>
        /// Original was GL_ALPHA_BIAS = 0x0D1D
        /// </summary>
        AlphaBias = ((int)0x0D1D),
        /// <summary>
        /// Original was GL_DEPTH_SCALE = 0x0D1E
        /// </summary>
        DepthScale = ((int)0x0D1E),
        /// <summary>
        /// Original was GL_DEPTH_BIAS = 0x0D1F
        /// </summary>
        DepthBias = ((int)0x0D1F),
        /// <summary>
        /// Original was GL_MAX_EVAL_ORDER = 0x0D30
        /// </summary>
        MaxEvalOrder = ((int)0x0D30),
        /// <summary>
        /// Original was GL_MAX_LIGHTS = 0x0D31
        /// </summary>
        MaxLights = ((int)0x0D31),
        /// <summary>
        /// Original was GL_MAX_CLIP_DISTANCES = 0x0D32
        /// </summary>
        MaxClipDistances = ((int)0x0D32),
        /// <summary>
        /// Original was GL_MAX_CLIP_PLANES = 0x0D32
        /// </summary>
        MaxClipPlanes = ((int)0x0D32),
        /// <summary>
        /// Original was GL_MAX_TEXTURE_SIZE = 0x0D33
        /// </summary>
        MaxTextureSize = ((int)0x0D33),
        /// <summary>
        /// Original was GL_MAX_PIXEL_MAP_TABLE = 0x0D34
        /// </summary>
        MaxPixelMapTable = ((int)0x0D34),
        /// <summary>
        /// Original was GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35
        /// </summary>
        MaxAttribStackDepth = ((int)0x0D35),
        /// <summary>
        /// Original was GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36
        /// </summary>
        MaxModelviewStackDepth = ((int)0x0D36),
        /// <summary>
        /// Original was GL_MAX_NAME_STACK_DEPTH = 0x0D37
        /// </summary>
        MaxNameStackDepth = ((int)0x0D37),
        /// <summary>
        /// Original was GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38
        /// </summary>
        MaxProjectionStackDepth = ((int)0x0D38),
        /// <summary>
        /// Original was GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39
        /// </summary>
        MaxTextureStackDepth = ((int)0x0D39),
        /// <summary>
        /// Original was GL_MAX_VIEWPORT_DIMS = 0x0D3A
        /// </summary>
        MaxViewportDims = ((int)0x0D3A),
        /// <summary>
        /// Original was GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B
        /// </summary>
        MaxClientAttribStackDepth = ((int)0x0D3B),
        /// <summary>
        /// Original was GL_SUBPIXEL_BITS = 0x0D50
        /// </summary>
        SubpixelBits = ((int)0x0D50),
        /// <summary>
        /// Original was GL_INDEX_BITS = 0x0D51
        /// </summary>
        IndexBits = ((int)0x0D51),
        /// <summary>
        /// Original was GL_RED_BITS = 0x0D52
        /// </summary>
        RedBits = ((int)0x0D52),
        /// <summary>
        /// Original was GL_GREEN_BITS = 0x0D53
        /// </summary>
        GreenBits = ((int)0x0D53),
        /// <summary>
        /// Original was GL_BLUE_BITS = 0x0D54
        /// </summary>
        BlueBits = ((int)0x0D54),
        /// <summary>
        /// Original was GL_ALPHA_BITS = 0x0D55
        /// </summary>
        AlphaBits = ((int)0x0D55),
        /// <summary>
        /// Original was GL_DEPTH_BITS = 0x0D56
        /// </summary>
        DepthBits = ((int)0x0D56),
        /// <summary>
        /// Original was GL_STENCIL_BITS = 0x0D57
        /// </summary>
        StencilBits = ((int)0x0D57),
        /// <summary>
        /// Original was GL_ACCUM_RED_BITS = 0x0D58
        /// </summary>
        AccumRedBits = ((int)0x0D58),
        /// <summary>
        /// Original was GL_ACCUM_GREEN_BITS = 0x0D59
        /// </summary>
        AccumGreenBits = ((int)0x0D59),
        /// <summary>
        /// Original was GL_ACCUM_BLUE_BITS = 0x0D5A
        /// </summary>
        AccumBlueBits = ((int)0x0D5A),
        /// <summary>
        /// Original was GL_ACCUM_ALPHA_BITS = 0x0D5B
        /// </summary>
        AccumAlphaBits = ((int)0x0D5B),
        /// <summary>
        /// Original was GL_NAME_STACK_DEPTH = 0x0D70
        /// </summary>
        NameStackDepth = ((int)0x0D70),
        /// <summary>
        /// Original was GL_AUTO_NORMAL = 0x0D80
        /// </summary>
        AutoNormal = ((int)0x0D80),
        /// <summary>
        /// Original was GL_MAP1_COLOR_4 = 0x0D90
        /// </summary>
        Map1Color4 = ((int)0x0D90),
        /// <summary>
        /// Original was GL_MAP1_INDEX = 0x0D91
        /// </summary>
        Map1Index = ((int)0x0D91),
        /// <summary>
        /// Original was GL_MAP1_NORMAL = 0x0D92
        /// </summary>
        Map1Normal = ((int)0x0D92),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_1 = 0x0D93
        /// </summary>
        Map1TextureCoord1 = ((int)0x0D93),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_2 = 0x0D94
        /// </summary>
        Map1TextureCoord2 = ((int)0x0D94),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_3 = 0x0D95
        /// </summary>
        Map1TextureCoord3 = ((int)0x0D95),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_4 = 0x0D96
        /// </summary>
        Map1TextureCoord4 = ((int)0x0D96),
        /// <summary>
        /// Original was GL_MAP1_VERTEX_3 = 0x0D97
        /// </summary>
        Map1Vertex3 = ((int)0x0D97),
        /// <summary>
        /// Original was GL_MAP1_VERTEX_4 = 0x0D98
        /// </summary>
        Map1Vertex4 = ((int)0x0D98),
        /// <summary>
        /// Original was GL_MAP2_COLOR_4 = 0x0DB0
        /// </summary>
        Map2Color4 = ((int)0x0DB0),
        /// <summary>
        /// Original was GL_MAP2_INDEX = 0x0DB1
        /// </summary>
        Map2Index = ((int)0x0DB1),
        /// <summary>
        /// Original was GL_MAP2_NORMAL = 0x0DB2
        /// </summary>
        Map2Normal = ((int)0x0DB2),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_1 = 0x0DB3
        /// </summary>
        Map2TextureCoord1 = ((int)0x0DB3),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_2 = 0x0DB4
        /// </summary>
        Map2TextureCoord2 = ((int)0x0DB4),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_3 = 0x0DB5
        /// </summary>
        Map2TextureCoord3 = ((int)0x0DB5),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_4 = 0x0DB6
        /// </summary>
        Map2TextureCoord4 = ((int)0x0DB6),
        /// <summary>
        /// Original was GL_MAP2_VERTEX_3 = 0x0DB7
        /// </summary>
        Map2Vertex3 = ((int)0x0DB7),
        /// <summary>
        /// Original was GL_MAP2_VERTEX_4 = 0x0DB8
        /// </summary>
        Map2Vertex4 = ((int)0x0DB8),
        /// <summary>
        /// Original was GL_MAP1_GRID_DOMAIN = 0x0DD0
        /// </summary>
        Map1GridDomain = ((int)0x0DD0),
        /// <summary>
        /// Original was GL_MAP1_GRID_SEGMENTS = 0x0DD1
        /// </summary>
        Map1GridSegments = ((int)0x0DD1),
        /// <summary>
        /// Original was GL_MAP2_GRID_DOMAIN = 0x0DD2
        /// </summary>
        Map2GridDomain = ((int)0x0DD2),
        /// <summary>
        /// Original was GL_MAP2_GRID_SEGMENTS = 0x0DD3
        /// </summary>
        Map2GridSegments = ((int)0x0DD3),
        /// <summary>
        /// Original was GL_TEXTURE_1D = 0x0DE0
        /// </summary>
        Texture1D = ((int)0x0DE0),
        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = ((int)0x0DE1),
        /// <summary>
        /// Original was GL_FEEDBACK_BUFFER_SIZE = 0x0DF1
        /// </summary>
        FeedbackBufferSize = ((int)0x0DF1),
        /// <summary>
        /// Original was GL_FEEDBACK_BUFFER_TYPE = 0x0DF2
        /// </summary>
        FeedbackBufferType = ((int)0x0DF2),
        /// <summary>
        /// Original was GL_SELECTION_BUFFER_SIZE = 0x0DF4
        /// </summary>
        SelectionBufferSize = ((int)0x0DF4),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_UNITS = 0x2A00
        /// </summary>
        PolygonOffsetUnits = ((int)0x2A00),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_POINT = 0x2A01
        /// </summary>
        PolygonOffsetPoint = ((int)0x2A01),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_LINE = 0x2A02
        /// </summary>
        PolygonOffsetLine = ((int)0x2A02),
        /// <summary>
        /// Original was GL_CLIP_PLANE0 = 0x3000
        /// </summary>
        ClipPlane0 = ((int)0x3000),
        /// <summary>
        /// Original was GL_CLIP_PLANE1 = 0x3001
        /// </summary>
        ClipPlane1 = ((int)0x3001),
        /// <summary>
        /// Original was GL_CLIP_PLANE2 = 0x3002
        /// </summary>
        ClipPlane2 = ((int)0x3002),
        /// <summary>
        /// Original was GL_CLIP_PLANE3 = 0x3003
        /// </summary>
        ClipPlane3 = ((int)0x3003),
        /// <summary>
        /// Original was GL_CLIP_PLANE4 = 0x3004
        /// </summary>
        ClipPlane4 = ((int)0x3004),
        /// <summary>
        /// Original was GL_CLIP_PLANE5 = 0x3005
        /// </summary>
        ClipPlane5 = ((int)0x3005),
        /// <summary>
        /// Original was GL_LIGHT0 = 0x4000
        /// </summary>
        Light0 = ((int)0x4000),
        /// <summary>
        /// Original was GL_LIGHT1 = 0x4001
        /// </summary>
        Light1 = ((int)0x4001),
        /// <summary>
        /// Original was GL_LIGHT2 = 0x4002
        /// </summary>
        Light2 = ((int)0x4002),
        /// <summary>
        /// Original was GL_LIGHT3 = 0x4003
        /// </summary>
        Light3 = ((int)0x4003),
        /// <summary>
        /// Original was GL_LIGHT4 = 0x4004
        /// </summary>
        Light4 = ((int)0x4004),
        /// <summary>
        /// Original was GL_LIGHT5 = 0x4005
        /// </summary>
        Light5 = ((int)0x4005),
        /// <summary>
        /// Original was GL_LIGHT6 = 0x4006
        /// </summary>
        Light6 = ((int)0x4006),
        /// <summary>
        /// Original was GL_LIGHT7 = 0x4007
        /// </summary>
        Light7 = ((int)0x4007),
        /// <summary>
        /// Original was GL_BLEND_COLOR_EXT = 0x8005
        /// </summary>
        BlendColorExt = ((int)0x8005),
        /// <summary>
        /// Original was GL_BLEND_EQUATION_EXT = 0x8009
        /// </summary>
        BlendEquationExt = ((int)0x8009),
        /// <summary>
        /// Original was GL_PACK_CMYK_HINT_EXT = 0x800E
        /// </summary>
        PackCmykHintExt = ((int)0x800E),
        /// <summary>
        /// Original was GL_UNPACK_CMYK_HINT_EXT = 0x800F
        /// </summary>
        UnpackCmykHintExt = ((int)0x800F),
        /// <summary>
        /// Original was GL_CONVOLUTION_1D_EXT = 0x8010
        /// </summary>
        Convolution1DExt = ((int)0x8010),
        /// <summary>
        /// Original was GL_CONVOLUTION_2D_EXT = 0x8011
        /// </summary>
        Convolution2DExt = ((int)0x8011),
        /// <summary>
        /// Original was GL_SEPARABLE_2D_EXT = 0x8012
        /// </summary>
        Separable2DExt = ((int)0x8012),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C
        /// </summary>
        PostConvolutionRedScaleExt = ((int)0x801C),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D
        /// </summary>
        PostConvolutionGreenScaleExt = ((int)0x801D),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E
        /// </summary>
        PostConvolutionBlueScaleExt = ((int)0x801E),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F
        /// </summary>
        PostConvolutionAlphaScaleExt = ((int)0x801F),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_BIAS_EXT = 0x8020
        /// </summary>
        PostConvolutionRedBiasExt = ((int)0x8020),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021
        /// </summary>
        PostConvolutionGreenBiasExt = ((int)0x8021),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022
        /// </summary>
        PostConvolutionBlueBiasExt = ((int)0x8022),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023
        /// </summary>
        PostConvolutionAlphaBiasExt = ((int)0x8023),
        /// <summary>
        /// Original was GL_HISTOGRAM_EXT = 0x8024
        /// </summary>
        HistogramExt = ((int)0x8024),
        /// <summary>
        /// Original was GL_MINMAX_EXT = 0x802E
        /// </summary>
        MinmaxExt = ((int)0x802E),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FILL = 0x8037
        /// </summary>
        PolygonOffsetFill = ((int)0x8037),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FACTOR = 0x8038
        /// </summary>
        PolygonOffsetFactor = ((int)0x8038),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_BIAS_EXT = 0x8039
        /// </summary>
        PolygonOffsetBiasExt = ((int)0x8039),
        /// <summary>
        /// Original was GL_RESCALE_NORMAL_EXT = 0x803A
        /// </summary>
        RescaleNormalExt = ((int)0x803A),
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_1D = 0x8068
        /// </summary>
        TextureBinding1D = ((int)0x8068),
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D = 0x8069
        /// </summary>
        TextureBinding2D = ((int)0x8069),
        /// <summary>
        /// Original was GL_TEXTURE_3D_BINDING_EXT = 0x806A
        /// </summary>
        Texture3DBindingExt = ((int)0x806A),
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_3D = 0x806A
        /// </summary>
        TextureBinding3D = ((int)0x806A),
        /// <summary>
        /// Original was GL_PACK_SKIP_IMAGES_EXT = 0x806B
        /// </summary>
        PackSkipImagesExt = ((int)0x806B),
        /// <summary>
        /// Original was GL_PACK_IMAGE_HEIGHT_EXT = 0x806C
        /// </summary>
        PackImageHeightExt = ((int)0x806C),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_IMAGES_EXT = 0x806D
        /// </summary>
        UnpackSkipImagesExt = ((int)0x806D),
        /// <summary>
        /// Original was GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E
        /// </summary>
        UnpackImageHeightExt = ((int)0x806E),
        /// <summary>
        /// Original was GL_TEXTURE_3D_EXT = 0x806F
        /// </summary>
        Texture3DExt = ((int)0x806F),
        /// <summary>
        /// Original was GL_MAX_3D_TEXTURE_SIZE_EXT = 0x8073
        /// </summary>
        Max3DTextureSizeExt = ((int)0x8073),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = ((int)0x8074),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY = 0x8075
        /// </summary>
        NormalArray = ((int)0x8075),
        /// <summary>
        /// Original was GL_COLOR_ARRAY = 0x8076
        /// </summary>
        ColorArray = ((int)0x8076),
        /// <summary>
        /// Original was GL_INDEX_ARRAY = 0x8077
        /// </summary>
        IndexArray = ((int)0x8077),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY = 0x8078
        /// </summary>
        TextureCoordArray = ((int)0x8078),
        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY = 0x8079
        /// </summary>
        EdgeFlagArray = ((int)0x8079),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_SIZE = 0x807A
        /// </summary>
        VertexArraySize = ((int)0x807A),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_TYPE = 0x807B
        /// </summary>
        VertexArrayType = ((int)0x807B),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_STRIDE = 0x807C
        /// </summary>
        VertexArrayStride = ((int)0x807C),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_COUNT_EXT = 0x807D
        /// </summary>
        VertexArrayCountExt = ((int)0x807D),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_TYPE = 0x807E
        /// </summary>
        NormalArrayType = ((int)0x807E),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_STRIDE = 0x807F
        /// </summary>
        NormalArrayStride = ((int)0x807F),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_COUNT_EXT = 0x8080
        /// </summary>
        NormalArrayCountExt = ((int)0x8080),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_SIZE = 0x8081
        /// </summary>
        ColorArraySize = ((int)0x8081),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_TYPE = 0x8082
        /// </summary>
        ColorArrayType = ((int)0x8082),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_STRIDE = 0x8083
        /// </summary>
        ColorArrayStride = ((int)0x8083),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_COUNT_EXT = 0x8084
        /// </summary>
        ColorArrayCountExt = ((int)0x8084),
        /// <summary>
        /// Original was GL_INDEX_ARRAY_TYPE = 0x8085
        /// </summary>
        IndexArrayType = ((int)0x8085),
        /// <summary>
        /// Original was GL_INDEX_ARRAY_STRIDE = 0x8086
        /// </summary>
        IndexArrayStride = ((int)0x8086),
        /// <summary>
        /// Original was GL_INDEX_ARRAY_COUNT_EXT = 0x8087
        /// </summary>
        IndexArrayCountExt = ((int)0x8087),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088
        /// </summary>
        TextureCoordArraySize = ((int)0x8088),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089
        /// </summary>
        TextureCoordArrayType = ((int)0x8089),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A
        /// </summary>
        TextureCoordArrayStride = ((int)0x808A),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B
        /// </summary>
        TextureCoordArrayCountExt = ((int)0x808B),
        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C
        /// </summary>
        EdgeFlagArrayStride = ((int)0x808C),
        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D
        /// </summary>
        EdgeFlagArrayCountExt = ((int)0x808D),
        /// <summary>
        /// Original was GL_INTERLACE_SGIX = 0x8094
        /// </summary>
        InterlaceSgix = ((int)0x8094),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096
        /// </summary>
        DetailTexture2DBindingSgis = ((int)0x8096),
        /// <summary>
        /// Original was GL_MULTISAMPLE_SGIS = 0x809D
        /// </summary>
        MultisampleSgis = ((int)0x809D),
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E
        /// </summary>
        SampleAlphaToMaskSgis = ((int)0x809E),
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F
        /// </summary>
        SampleAlphaToOneSgis = ((int)0x809F),
        /// <summary>
        /// Original was GL_SAMPLE_MASK_SGIS = 0x80A0
        /// </summary>
        SampleMaskSgis = ((int)0x80A0),
        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS_SGIS = 0x80A8
        /// </summary>
        SampleBuffersSgis = ((int)0x80A8),
        /// <summary>
        /// Original was GL_SAMPLES_SGIS = 0x80A9
        /// </summary>
        SamplesSgis = ((int)0x80A9),
        /// <summary>
        /// Original was GL_SAMPLE_MASK_VALUE_SGIS = 0x80AA
        /// </summary>
        SampleMaskValueSgis = ((int)0x80AA),
        /// <summary>
        /// Original was GL_SAMPLE_MASK_INVERT_SGIS = 0x80AB
        /// </summary>
        SampleMaskInvertSgis = ((int)0x80AB),
        /// <summary>
        /// Original was GL_SAMPLE_PATTERN_SGIS = 0x80AC
        /// </summary>
        SamplePatternSgis = ((int)0x80AC),
        /// <summary>
        /// Original was GL_COLOR_MATRIX_SGI = 0x80B1
        /// </summary>
        ColorMatrixSgi = ((int)0x80B1),
        /// <summary>
        /// Original was GL_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2
        /// </summary>
        ColorMatrixStackDepthSgi = ((int)0x80B2),
        /// <summary>
        /// Original was GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3
        /// </summary>
        MaxColorMatrixStackDepthSgi = ((int)0x80B3),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4
        /// </summary>
        PostColorMatrixRedScaleSgi = ((int)0x80B4),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5
        /// </summary>
        PostColorMatrixGreenScaleSgi = ((int)0x80B5),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6
        /// </summary>
        PostColorMatrixBlueScaleSgi = ((int)0x80B6),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7
        /// </summary>
        PostColorMatrixAlphaScaleSgi = ((int)0x80B7),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8
        /// </summary>
        PostColorMatrixRedBiasSgi = ((int)0x80B8),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9
        /// </summary>
        PostColorMatrixGreenBiasSgi = ((int)0x80B9),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA
        /// </summary>
        PostColorMatrixBlueBiasSgi = ((int)0x80BA),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB
        /// </summary>
        PostColorMatrixAlphaBiasSgi = ((int)0x80BB),
        /// <summary>
        /// Original was GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
        /// </summary>
        TextureColorTableSgi = ((int)0x80BC),
        /// <summary>
        /// Original was GL_COLOR_TABLE_SGI = 0x80D0
        /// </summary>
        ColorTableSgi = ((int)0x80D0),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
        /// </summary>
        PostConvolutionColorTableSgi = ((int)0x80D1),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
        /// </summary>
        PostColorMatrixColorTableSgi = ((int)0x80D2),
        /// <summary>
        /// Original was GL_POINT_SIZE_MIN_SGIS = 0x8126
        /// </summary>
        PointSizeMinSgis = ((int)0x8126),
        /// <summary>
        /// Original was GL_POINT_SIZE_MAX_SGIS = 0x8127
        /// </summary>
        PointSizeMaxSgis = ((int)0x8127),
        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128
        /// </summary>
        PointFadeThresholdSizeSgis = ((int)0x8128),
        /// <summary>
        /// Original was GL_DISTANCE_ATTENUATION_SGIS = 0x8129
        /// </summary>
        DistanceAttenuationSgis = ((int)0x8129),
        /// <summary>
        /// Original was GL_FOG_FUNC_POINTS_SGIS = 0x812B
        /// </summary>
        FogFuncPointsSgis = ((int)0x812B),
        /// <summary>
        /// Original was GL_MAX_FOG_FUNC_POINTS_SGIS = 0x812C
        /// </summary>
        MaxFogFuncPointsSgis = ((int)0x812C),
        /// <summary>
        /// Original was GL_PACK_SKIP_VOLUMES_SGIS = 0x8130
        /// </summary>
        PackSkipVolumesSgis = ((int)0x8130),
        /// <summary>
        /// Original was GL_PACK_IMAGE_DEPTH_SGIS = 0x8131
        /// </summary>
        PackImageDepthSgis = ((int)0x8131),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_VOLUMES_SGIS = 0x8132
        /// </summary>
        UnpackSkipVolumesSgis = ((int)0x8132),
        /// <summary>
        /// Original was GL_UNPACK_IMAGE_DEPTH_SGIS = 0x8133
        /// </summary>
        UnpackImageDepthSgis = ((int)0x8133),
        /// <summary>
        /// Original was GL_TEXTURE_4D_SGIS = 0x8134
        /// </summary>
        Texture4DSgis = ((int)0x8134),
        /// <summary>
        /// Original was GL_MAX_4D_TEXTURE_SIZE_SGIS = 0x8138
        /// </summary>
        Max4DTextureSizeSgis = ((int)0x8138),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_SGIX = 0x8139
        /// </summary>
        PixelTexGenSgix = ((int)0x8139),
        /// <summary>
        /// Original was GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E
        /// </summary>
        PixelTileBestAlignmentSgix = ((int)0x813E),
        /// <summary>
        /// Original was GL_PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F
        /// </summary>
        PixelTileCacheIncrementSgix = ((int)0x813F),
        /// <summary>
        /// Original was GL_PIXEL_TILE_WIDTH_SGIX = 0x8140
        /// </summary>
        PixelTileWidthSgix = ((int)0x8140),
        /// <summary>
        /// Original was GL_PIXEL_TILE_HEIGHT_SGIX = 0x8141
        /// </summary>
        PixelTileHeightSgix = ((int)0x8141),
        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142
        /// </summary>
        PixelTileGridWidthSgix = ((int)0x8142),
        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143
        /// </summary>
        PixelTileGridHeightSgix = ((int)0x8143),
        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144
        /// </summary>
        PixelTileGridDepthSgix = ((int)0x8144),
        /// <summary>
        /// Original was GL_PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145
        /// </summary>
        PixelTileCacheSizeSgix = ((int)0x8145),
        /// <summary>
        /// Original was GL_SPRITE_SGIX = 0x8148
        /// </summary>
        SpriteSgix = ((int)0x8148),
        /// <summary>
        /// Original was GL_SPRITE_MODE_SGIX = 0x8149
        /// </summary>
        SpriteModeSgix = ((int)0x8149),
        /// <summary>
        /// Original was GL_SPRITE_AXIS_SGIX = 0x814A
        /// </summary>
        SpriteAxisSgix = ((int)0x814A),
        /// <summary>
        /// Original was GL_SPRITE_TRANSLATION_SGIX = 0x814B
        /// </summary>
        SpriteTranslationSgix = ((int)0x814B),
        /// <summary>
        /// Original was GL_TEXTURE_4D_BINDING_SGIS = 0x814F
        /// </summary>
        Texture4DBindingSgis = ((int)0x814F),
        /// <summary>
        /// Original was GL_MAX_CLIPMAP_DEPTH_SGIX = 0x8177
        /// </summary>
        MaxClipmapDepthSgix = ((int)0x8177),
        /// <summary>
        /// Original was GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178
        /// </summary>
        MaxClipmapVirtualDepthSgix = ((int)0x8178),
        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B
        /// </summary>
        PostTextureFilterBiasRangeSgix = ((int)0x817B),
        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C
        /// </summary>
        PostTextureFilterScaleRangeSgix = ((int)0x817C),
        /// <summary>
        /// Original was GL_REFERENCE_PLANE_SGIX = 0x817D
        /// </summary>
        ReferencePlaneSgix = ((int)0x817D),
        /// <summary>
        /// Original was GL_REFERENCE_PLANE_EQUATION_SGIX = 0x817E
        /// </summary>
        ReferencePlaneEquationSgix = ((int)0x817E),
        /// <summary>
        /// Original was GL_IR_INSTRUMENT1_SGIX = 0x817F
        /// </summary>
        IrInstrument1Sgix = ((int)0x817F),
        /// <summary>
        /// Original was GL_INSTRUMENT_MEASUREMENTS_SGIX = 0x8181
        /// </summary>
        InstrumentMeasurementsSgix = ((int)0x8181),
        /// <summary>
        /// Original was GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183
        /// </summary>
        CalligraphicFragmentSgix = ((int)0x8183),
        /// <summary>
        /// Original was GL_FRAMEZOOM_SGIX = 0x818B
        /// </summary>
        FramezoomSgix = ((int)0x818B),
        /// <summary>
        /// Original was GL_FRAMEZOOM_FACTOR_SGIX = 0x818C
        /// </summary>
        FramezoomFactorSgix = ((int)0x818C),
        /// <summary>
        /// Original was GL_MAX_FRAMEZOOM_FACTOR_SGIX = 0x818D
        /// </summary>
        MaxFramezoomFactorSgix = ((int)0x818D),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192
        /// </summary>
        GenerateMipmapHintSgis = ((int)0x8192),
        /// <summary>
        /// Original was GL_DEFORMATIONS_MASK_SGIX = 0x8196
        /// </summary>
        DeformationsMaskSgix = ((int)0x8196),
        /// <summary>
        /// Original was GL_FOG_OFFSET_SGIX = 0x8198
        /// </summary>
        FogOffsetSgix = ((int)0x8198),
        /// <summary>
        /// Original was GL_FOG_OFFSET_VALUE_SGIX = 0x8199
        /// </summary>
        FogOffsetValueSgix = ((int)0x8199),
        /// <summary>
        /// Original was GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8
        /// </summary>
        LightModelColorControl = ((int)0x81F8),
        /// <summary>
        /// Original was GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB
        /// </summary>
        SharedTexturePaletteExt = ((int)0x81FB),
        /// <summary>
        /// Original was GL_CONVOLUTION_HINT_SGIX = 0x8316
        /// </summary>
        ConvolutionHintSgix = ((int)0x8316),
        /// <summary>
        /// Original was GL_ASYNC_MARKER_SGIX = 0x8329
        /// </summary>
        AsyncMarkerSgix = ((int)0x8329),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_MODE_SGIX = 0x832B
        /// </summary>
        PixelTexGenModeSgix = ((int)0x832B),
        /// <summary>
        /// Original was GL_ASYNC_HISTOGRAM_SGIX = 0x832C
        /// </summary>
        AsyncHistogramSgix = ((int)0x832C),
        /// <summary>
        /// Original was GL_MAX_ASYNC_HISTOGRAM_SGIX = 0x832D
        /// </summary>
        MaxAsyncHistogramSgix = ((int)0x832D),
        /// <summary>
        /// Original was GL_PIXEL_TEXTURE_SGIS = 0x8353
        /// </summary>
        PixelTextureSgis = ((int)0x8353),
        /// <summary>
        /// Original was GL_ASYNC_TEX_IMAGE_SGIX = 0x835C
        /// </summary>
        AsyncTexImageSgix = ((int)0x835C),
        /// <summary>
        /// Original was GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D
        /// </summary>
        AsyncDrawPixelsSgix = ((int)0x835D),
        /// <summary>
        /// Original was GL_ASYNC_READ_PIXELS_SGIX = 0x835E
        /// </summary>
        AsyncReadPixelsSgix = ((int)0x835E),
        /// <summary>
        /// Original was GL_MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F
        /// </summary>
        MaxAsyncTexImageSgix = ((int)0x835F),
        /// <summary>
        /// Original was GL_MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360
        /// </summary>
        MaxAsyncDrawPixelsSgix = ((int)0x8360),
        /// <summary>
        /// Original was GL_MAX_ASYNC_READ_PIXELS_SGIX = 0x8361
        /// </summary>
        MaxAsyncReadPixelsSgix = ((int)0x8361),
        /// <summary>
        /// Original was GL_VERTEX_PRECLIP_SGIX = 0x83EE
        /// </summary>
        VertexPreclipSgix = ((int)0x83EE),
        /// <summary>
        /// Original was GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF
        /// </summary>
        VertexPreclipHintSgix = ((int)0x83EF),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHTING_SGIX = 0x8400
        /// </summary>
        FragmentLightingSgix = ((int)0x8400),
        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401
        /// </summary>
        FragmentColorMaterialSgix = ((int)0x8401),
        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX = 0x8402
        /// </summary>
        FragmentColorMaterialFaceSgix = ((int)0x8402),
        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = 0x8403
        /// </summary>
        FragmentColorMaterialParameterSgix = ((int)0x8403),
        /// <summary>
        /// Original was GL_MAX_FRAGMENT_LIGHTS_SGIX = 0x8404
        /// </summary>
        MaxFragmentLightsSgix = ((int)0x8404),
        /// <summary>
        /// Original was GL_MAX_ACTIVE_LIGHTS_SGIX = 0x8405
        /// </summary>
        MaxActiveLightsSgix = ((int)0x8405),
        /// <summary>
        /// Original was GL_LIGHT_ENV_MODE_SGIX = 0x8407
        /// </summary>
        LightEnvModeSgix = ((int)0x8407),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408
        /// </summary>
        FragmentLightModelLocalViewerSgix = ((int)0x8408),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409
        /// </summary>
        FragmentLightModelTwoSideSgix = ((int)0x8409),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A
        /// </summary>
        FragmentLightModelAmbientSgix = ((int)0x840A),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B
        /// </summary>
        FragmentLightModelNormalInterpolationSgix = ((int)0x840B),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT0_SGIX = 0x840C
        /// </summary>
        FragmentLight0Sgix = ((int)0x840C),
        /// <summary>
        /// Original was GL_PACK_RESAMPLE_SGIX = 0x842E
        /// </summary>
        PackResampleSgix = ((int)0x842E),
        /// <summary>
        /// Original was GL_UNPACK_RESAMPLE_SGIX = 0x842F
        /// </summary>
        UnpackResampleSgix = ((int)0x842F),
        /// <summary>
        /// Original was GL_ALIASED_POINT_SIZE_RANGE = 0x846D
        /// </summary>
        AliasedPointSizeRange = ((int)0x846D),
        /// <summary>
        /// Original was GL_ALIASED_LINE_WIDTH_RANGE = 0x846E
        /// </summary>
        AliasedLineWidthRange = ((int)0x846E),
        /// <summary>
        /// Original was GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0
        /// </summary>
        PackSubsampleRateSgix = ((int)0x85A0),
        /// <summary>
        /// Original was GL_UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1
        /// </summary>
        UnpackSubsampleRateSgix = ((int)0x85A1),
        /// <summary>
        /// Original was GL_DEVICE_UUID_EXT = 0x9597
        /// </summary>
        DeviceUuidExt = ((int)0x9597),
        /// <summary>
        /// Original was GL_DRIVER_UUID_EXT = 0x9598
        /// </summary>
        DriverUuidExt = ((int)0x9598),
        /// <summary>
        /// Original was GL_DEVICE_LUID_EXT = 0x9599
        /// </summary>
        DeviceLuidExt = ((int)0x9599),
        /// <summary>
        /// Original was GL_DEVICE_NODE_MASK_EXT = 0x959A
        /// </summary>
        DeviceNodeMaskExt = ((int)0x959A),
    }

    /// <summary>
    /// Used in GL.GetPointer
    /// </summary>
    public enum GetPointervPName : int
    {
        /// <summary>
        /// Original was GL_FEEDBACK_BUFFER_POINTER = 0x0DF0
        /// </summary>
        FeedbackBufferPointer = ((int)0x0DF0),
        /// <summary>
        /// Original was GL_SELECTION_BUFFER_POINTER = 0x0DF3
        /// </summary>
        SelectionBufferPointer = ((int)0x0DF3),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_POINTER = 0x808E
        /// </summary>
        VertexArrayPointer = ((int)0x808E),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_POINTER_EXT = 0x808E
        /// </summary>
        VertexArrayPointerExt = ((int)0x808E),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_POINTER = 0x808F
        /// </summary>
        NormalArrayPointer = ((int)0x808F),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_POINTER_EXT = 0x808F
        /// </summary>
        NormalArrayPointerExt = ((int)0x808F),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_POINTER = 0x8090
        /// </summary>
        ColorArrayPointer = ((int)0x8090),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_POINTER_EXT = 0x8090
        /// </summary>
        ColorArrayPointerExt = ((int)0x8090),
        /// <summary>
        /// Original was GL_INDEX_ARRAY_POINTER = 0x8091
        /// </summary>
        IndexArrayPointer = ((int)0x8091),
        /// <summary>
        /// Original was GL_INDEX_ARRAY_POINTER_EXT = 0x8091
        /// </summary>
        IndexArrayPointerExt = ((int)0x8091),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092
        /// </summary>
        TextureCoordArrayPointer = ((int)0x8092),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092
        /// </summary>
        TextureCoordArrayPointerExt = ((int)0x8092),
        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_POINTER = 0x8093
        /// </summary>
        EdgeFlagArrayPointer = ((int)0x8093),
        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_POINTER_EXT = 0x8093
        /// </summary>
        EdgeFlagArrayPointerExt = ((int)0x8093),
        /// <summary>
        /// Original was GL_INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180
        /// </summary>
        InstrumentBufferPointerSgix = ((int)0x8180),
        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_FUNCTION = 0x8244
        /// </summary>
        DebugCallbackFunction = ((int)0x8244),
        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_USER_PARAM = 0x8245
        /// </summary>
        DebugCallbackUserParam = ((int)0x8245),
    }

    /// <summary>
    /// Used in GL.GetTexParameter, GL.GetTexParameterx and 4 other functions
    /// </summary>
    public enum GetTextureParameter : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_WIDTH = 0x1000
        /// </summary>
        TextureWidth = ((int)0x1000),
        /// <summary>
        /// Original was GL_TEXTURE_HEIGHT = 0x1001
        /// </summary>
        TextureHeight = ((int)0x1001),
        /// <summary>
        /// Original was GL_TEXTURE_COMPONENTS = 0x1003
        /// </summary>
        TextureComponents = ((int)0x1003),
        /// <summary>
        /// Original was GL_TEXTURE_INTERNAL_FORMAT = 0x1003
        /// </summary>
        TextureInternalFormat = ((int)0x1003),
        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR = 0x1004
        /// </summary>
        TextureBorderColor = ((int)0x1004),
        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR_NV = 0x1004
        /// </summary>
        TextureBorderColorNv = ((int)0x1004),
        /// <summary>
        /// Original was GL_TEXTURE_BORDER = 0x1005
        /// </summary>
        TextureBorder = ((int)0x1005),
        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = ((int)0x2800),
        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = ((int)0x2801),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = ((int)0x2802),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = ((int)0x2803),
        /// <summary>
        /// Original was GL_TEXTURE_RED_SIZE = 0x805C
        /// </summary>
        TextureRedSize = ((int)0x805C),
        /// <summary>
        /// Original was GL_TEXTURE_GREEN_SIZE = 0x805D
        /// </summary>
        TextureGreenSize = ((int)0x805D),
        /// <summary>
        /// Original was GL_TEXTURE_BLUE_SIZE = 0x805E
        /// </summary>
        TextureBlueSize = ((int)0x805E),
        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_SIZE = 0x805F
        /// </summary>
        TextureAlphaSize = ((int)0x805F),
        /// <summary>
        /// Original was GL_TEXTURE_LUMINANCE_SIZE = 0x8060
        /// </summary>
        TextureLuminanceSize = ((int)0x8060),
        /// <summary>
        /// Original was GL_TEXTURE_INTENSITY_SIZE = 0x8061
        /// </summary>
        TextureIntensitySize = ((int)0x8061),
        /// <summary>
        /// Original was GL_TEXTURE_PRIORITY = 0x8066
        /// </summary>
        TexturePriority = ((int)0x8066),
        /// <summary>
        /// Original was GL_TEXTURE_RESIDENT = 0x8067
        /// </summary>
        TextureResident = ((int)0x8067),
        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_EXT = 0x8071
        /// </summary>
        TextureDepthExt = ((int)0x8071),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R_EXT = 0x8072
        /// </summary>
        TextureWrapRExt = ((int)0x8072),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_LEVEL_SGIS = 0x809A
        /// </summary>
        DetailTextureLevelSgis = ((int)0x809A),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_MODE_SGIS = 0x809B
        /// </summary>
        DetailTextureModeSgis = ((int)0x809B),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C
        /// </summary>
        DetailTextureFuncPointsSgis = ((int)0x809C),
        /// <summary>
        /// Original was GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0
        /// </summary>
        SharpenTextureFuncPointsSgis = ((int)0x80B0),
        /// <summary>
        /// Original was GL_SHADOW_AMBIENT_SGIX = 0x80BF
        /// </summary>
        ShadowAmbientSgix = ((int)0x80BF),
        /// <summary>
        /// Original was GL_DUAL_TEXTURE_SELECT_SGIS = 0x8124
        /// </summary>
        DualTextureSelectSgis = ((int)0x8124),
        /// <summary>
        /// Original was GL_QUAD_TEXTURE_SELECT_SGIS = 0x8125
        /// </summary>
        QuadTextureSelectSgis = ((int)0x8125),
        /// <summary>
        /// Original was GL_TEXTURE_4DSIZE_SGIS = 0x8136
        /// </summary>
        Texture4DsizeSgis = ((int)0x8136),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_Q_SGIS = 0x8137
        /// </summary>
        TextureWrapQSgis = ((int)0x8137),
        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD_SGIS = 0x813A
        /// </summary>
        TextureMinLodSgis = ((int)0x813A),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD_SGIS = 0x813B
        /// </summary>
        TextureMaxLodSgis = ((int)0x813B),
        /// <summary>
        /// Original was GL_TEXTURE_BASE_LEVEL_SGIS = 0x813C
        /// </summary>
        TextureBaseLevelSgis = ((int)0x813C),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL_SGIS = 0x813D
        /// </summary>
        TextureMaxLevelSgis = ((int)0x813D),
        /// <summary>
        /// Original was GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147
        /// </summary>
        TextureFilter4SizeSgis = ((int)0x8147),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171
        /// </summary>
        TextureClipmapCenterSgix = ((int)0x8171),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172
        /// </summary>
        TextureClipmapFrameSgix = ((int)0x8172),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173
        /// </summary>
        TextureClipmapOffsetSgix = ((int)0x8173),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174
        /// </summary>
        TextureClipmapVirtualDepthSgix = ((int)0x8174),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175
        /// </summary>
        TextureClipmapLodOffsetSgix = ((int)0x8175),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176
        /// </summary>
        TextureClipmapDepthSgix = ((int)0x8176),
        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179
        /// </summary>
        PostTextureFilterBiasSgix = ((int)0x8179),
        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A
        /// </summary>
        PostTextureFilterScaleSgix = ((int)0x817A),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_S_SGIX = 0x818E
        /// </summary>
        TextureLodBiasSSgix = ((int)0x818E),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_T_SGIX = 0x818F
        /// </summary>
        TextureLodBiasTSgix = ((int)0x818F),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_R_SGIX = 0x8190
        /// </summary>
        TextureLodBiasRSgix = ((int)0x8190),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_SGIS = 0x8191
        /// </summary>
        GenerateMipmapSgis = ((int)0x8191),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_SGIX = 0x819A
        /// </summary>
        TextureCompareSgix = ((int)0x819A),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B
        /// </summary>
        TextureCompareOperatorSgix = ((int)0x819B),
        /// <summary>
        /// Original was GL_TEXTURE_LEQUAL_R_SGIX = 0x819C
        /// </summary>
        TextureLequalRSgix = ((int)0x819C),
        /// <summary>
        /// Original was GL_TEXTURE_GEQUAL_R_SGIX = 0x819D
        /// </summary>
        TextureGequalRSgix = ((int)0x819D),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_S_SGIX = 0x8369
        /// </summary>
        TextureMaxClampSSgix = ((int)0x8369),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_T_SGIX = 0x836A
        /// </summary>
        TextureMaxClampTSgix = ((int)0x836A),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_R_SGIX = 0x836B
        /// </summary>
        TextureMaxClampRSgix = ((int)0x836B),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GraphicsResetStatus : int
    {
        /// <summary>
        /// Original was GL_NO_ERROR = 0
        /// </summary>
        NoError = ((int)0),
        /// <summary>
        /// Original was GL_GUILTY_CONTEXT_RESET = 0x8253
        /// </summary>
        GuiltyContextReset = ((int)0x8253),
        /// <summary>
        /// Original was GL_INNOCENT_CONTEXT_RESET = 0x8254
        /// </summary>
        InnocentContextReset = ((int)0x8254),
        /// <summary>
        /// Original was GL_UNKNOWN_CONTEXT_RESET = 0x8255
        /// </summary>
        UnknownContextReset = ((int)0x8255),
    }

    /// <summary>
    /// Used in GL.Hint
    /// </summary>
    public enum HintMode : int
    {
        /// <summary>
        /// Original was GL_DONT_CARE = 0x1100
        /// </summary>
        DontCare = ((int)0x1100),
        /// <summary>
        /// Original was GL_FASTEST = 0x1101
        /// </summary>
        Fastest = ((int)0x1101),
        /// <summary>
        /// Original was GL_NICEST = 0x1102
        /// </summary>
        Nicest = ((int)0x1102),
    }

    /// <summary>
    /// Used in GL.Hint
    /// </summary>
    public enum HintTarget : int
    {
        /// <summary>
        /// Original was GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50
        /// </summary>
        PerspectiveCorrectionHint = ((int)0x0C50),
        /// <summary>
        /// Original was GL_POINT_SMOOTH_HINT = 0x0C51
        /// </summary>
        PointSmoothHint = ((int)0x0C51),
        /// <summary>
        /// Original was GL_LINE_SMOOTH_HINT = 0x0C52
        /// </summary>
        LineSmoothHint = ((int)0x0C52),
        /// <summary>
        /// Original was GL_POLYGON_SMOOTH_HINT = 0x0C53
        /// </summary>
        PolygonSmoothHint = ((int)0x0C53),
        /// <summary>
        /// Original was GL_FOG_HINT = 0x0C54
        /// </summary>
        FogHint = ((int)0x0C54),
        /// <summary>
        /// Original was GL_PREFER_DOUBLEBUFFER_HINT_PGI = 0x1A1F8
        /// </summary>
        PreferDoublebufferHintPgi = ((int)0x1A1F8),
        /// <summary>
        /// Original was GL_CONSERVE_MEMORY_HINT_PGI = 0x1A1FD
        /// </summary>
        ConserveMemoryHintPgi = ((int)0x1A1FD),
        /// <summary>
        /// Original was GL_RECLAIM_MEMORY_HINT_PGI = 0x1A1FE
        /// </summary>
        ReclaimMemoryHintPgi = ((int)0x1A1FE),
        /// <summary>
        /// Original was GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203
        /// </summary>
        NativeGraphicsBeginHintPgi = ((int)0x1A203),
        /// <summary>
        /// Original was GL_NATIVE_GRAPHICS_END_HINT_PGI = 0x1A204
        /// </summary>
        NativeGraphicsEndHintPgi = ((int)0x1A204),
        /// <summary>
        /// Original was GL_ALWAYS_FAST_HINT_PGI = 0x1A20C
        /// </summary>
        AlwaysFastHintPgi = ((int)0x1A20C),
        /// <summary>
        /// Original was GL_ALWAYS_SOFT_HINT_PGI = 0x1A20D
        /// </summary>
        AlwaysSoftHintPgi = ((int)0x1A20D),
        /// <summary>
        /// Original was GL_ALLOW_DRAW_OBJ_HINT_PGI = 0x1A20E
        /// </summary>
        AllowDrawObjHintPgi = ((int)0x1A20E),
        /// <summary>
        /// Original was GL_ALLOW_DRAW_WIN_HINT_PGI = 0x1A20F
        /// </summary>
        AllowDrawWinHintPgi = ((int)0x1A20F),
        /// <summary>
        /// Original was GL_ALLOW_DRAW_FRG_HINT_PGI = 0x1A210
        /// </summary>
        AllowDrawFrgHintPgi = ((int)0x1A210),
        /// <summary>
        /// Original was GL_ALLOW_DRAW_MEM_HINT_PGI = 0x1A211
        /// </summary>
        AllowDrawMemHintPgi = ((int)0x1A211),
        /// <summary>
        /// Original was GL_STRICT_DEPTHFUNC_HINT_PGI = 0x1A216
        /// </summary>
        StrictDepthfuncHintPgi = ((int)0x1A216),
        /// <summary>
        /// Original was GL_STRICT_LIGHTING_HINT_PGI = 0x1A217
        /// </summary>
        StrictLightingHintPgi = ((int)0x1A217),
        /// <summary>
        /// Original was GL_STRICT_SCISSOR_HINT_PGI = 0x1A218
        /// </summary>
        StrictScissorHintPgi = ((int)0x1A218),
        /// <summary>
        /// Original was GL_FULL_STIPPLE_HINT_PGI = 0x1A219
        /// </summary>
        FullStippleHintPgi = ((int)0x1A219),
        /// <summary>
        /// Original was GL_CLIP_NEAR_HINT_PGI = 0x1A220
        /// </summary>
        ClipNearHintPgi = ((int)0x1A220),
        /// <summary>
        /// Original was GL_CLIP_FAR_HINT_PGI = 0x1A221
        /// </summary>
        ClipFarHintPgi = ((int)0x1A221),
        /// <summary>
        /// Original was GL_WIDE_LINE_HINT_PGI = 0x1A222
        /// </summary>
        WideLineHintPgi = ((int)0x1A222),
        /// <summary>
        /// Original was GL_BACK_NORMALS_HINT_PGI = 0x1A223
        /// </summary>
        BackNormalsHintPgi = ((int)0x1A223),
        /// <summary>
        /// Original was GL_VERTEX_DATA_HINT_PGI = 0x1A22A
        /// </summary>
        VertexDataHintPgi = ((int)0x1A22A),
        /// <summary>
        /// Original was GL_VERTEX_CONSISTENT_HINT_PGI = 0x1A22B
        /// </summary>
        VertexConsistentHintPgi = ((int)0x1A22B),
        /// <summary>
        /// Original was GL_MATERIAL_SIDE_HINT_PGI = 0x1A22C
        /// </summary>
        MaterialSideHintPgi = ((int)0x1A22C),
        /// <summary>
        /// Original was GL_MAX_VERTEX_HINT_PGI = 0x1A22D
        /// </summary>
        MaxVertexHintPgi = ((int)0x1A22D),
        /// <summary>
        /// Original was GL_PACK_CMYK_HINT_EXT = 0x800E
        /// </summary>
        PackCmykHintExt = ((int)0x800E),
        /// <summary>
        /// Original was GL_UNPACK_CMYK_HINT_EXT = 0x800F
        /// </summary>
        UnpackCmykHintExt = ((int)0x800F),
        /// <summary>
        /// Original was GL_PHONG_HINT_WIN = 0x80EB
        /// </summary>
        PhongHintWin = ((int)0x80EB),
        /// <summary>
        /// Original was GL_CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0
        /// </summary>
        ClipVolumeClippingHintExt = ((int)0x80F0),
        /// <summary>
        /// Original was GL_TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E
        /// </summary>
        TextureMultiBufferHintSgix = ((int)0x812E),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT = 0x8192
        /// </summary>
        GenerateMipmapHint = ((int)0x8192),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192
        /// </summary>
        GenerateMipmapHintSgis = ((int)0x8192),
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
        /// </summary>
        ProgramBinaryRetrievableHint = ((int)0x8257),
        /// <summary>
        /// Original was GL_CONVOLUTION_HINT_SGIX = 0x8316
        /// </summary>
        ConvolutionHintSgix = ((int)0x8316),
        /// <summary>
        /// Original was GL_SCALEBIAS_HINT_SGIX = 0x8322
        /// </summary>
        ScalebiasHintSgix = ((int)0x8322),
        /// <summary>
        /// Original was GL_LINE_QUALITY_HINT_SGIX = 0x835B
        /// </summary>
        LineQualityHintSgix = ((int)0x835B),
        /// <summary>
        /// Original was GL_VERTEX_PRECLIP_SGIX = 0x83EE
        /// </summary>
        VertexPreclipSgix = ((int)0x83EE),
        /// <summary>
        /// Original was GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF
        /// </summary>
        VertexPreclipHintSgix = ((int)0x83EF),
        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSION_HINT = 0x84EF
        /// </summary>
        TextureCompressionHint = ((int)0x84EF),
        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF
        /// </summary>
        TextureCompressionHintArb = ((int)0x84EF),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F
        /// </summary>
        VertexArrayStorageHintApple = ((int)0x851F),
        /// <summary>
        /// Original was GL_MULTISAMPLE_FILTER_HINT_NV = 0x8534
        /// </summary>
        MultisampleFilterHintNv = ((int)0x8534),
        /// <summary>
        /// Original was GL_TRANSFORM_HINT_APPLE = 0x85B1
        /// </summary>
        TransformHintApple = ((int)0x85B1),
        /// <summary>
        /// Original was GL_TEXTURE_STORAGE_HINT_APPLE = 0x85BC
        /// </summary>
        TextureStorageHintApple = ((int)0x85BC),
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHint = ((int)0x8B8B),
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHintArb = ((int)0x8B8B),
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHintOes = ((int)0x8B8B),
        /// <summary>
        /// Original was GL_BINNING_CONTROL_HINT_QCOM = 0x8FB0
        /// </summary>
        BinningControlHintQcom = ((int)0x8FB0),
    }

    /// <summary>
    /// Used in GL.Oes.GetHistogramParameterx
    /// </summary>
    public enum HistogramTargetExt : int
    {
        /// <summary>
        /// Original was GL_HISTOGRAM = 0x8024
        /// </summary>
        Histogram = ((int)0x8024),
        /// <summary>
        /// Original was GL_HISTOGRAM_EXT = 0x8024
        /// </summary>
        HistogramExt = ((int)0x8024),
        /// <summary>
        /// Original was GL_PROXY_HISTOGRAM = 0x8025
        /// </summary>
        ProxyHistogram = ((int)0x8025),
        /// <summary>
        /// Original was GL_PROXY_HISTOGRAM_EXT = 0x8025
        /// </summary>
        ProxyHistogramExt = ((int)0x8025),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgMultisampledRenderToTexture : int
    {
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_IMG = 0x9133
        /// </summary>
        RenderbufferSamplesImg = ((int)0x9133),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG = 0x9134
        /// </summary>
        FramebufferIncompleteMultisampleImg = ((int)0x9134),
        /// <summary>
        /// Original was GL_MAX_SAMPLES_IMG = 0x9135
        /// </summary>
        MaxSamplesImg = ((int)0x9135),
        /// <summary>
        /// Original was GL_TEXTURE_SAMPLES_IMG = 0x9136
        /// </summary>
        TextureSamplesImg = ((int)0x9136),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum ImgreadFormat : int
    {
        /// <summary>
        /// Original was GL_BGRA = 0x80E1
        /// </summary>
        Bgra = ((int)0x80E1),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365
        /// </summary>
        UnsignedShort4444Rev = ((int)0x8365),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366
        /// </summary>
        UnsignedShort1555Rev = ((int)0x8366),
        /// <summary>
        /// Original was GL_IMG_read_format = 1
        /// </summary>
        ImgReadFormat = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum ImgReadFormat : int
    {
        /// <summary>
        /// Original was GL_BGRA_IMG = 0x80E1
        /// </summary>
        BgraImg = ((int)0x80E1),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG = 0x8365
        /// </summary>
        UnsignedShort4444RevImg = ((int)0x8365),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum ImgtextureCompressionPvrtc : int
    {
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG = 0x8C00
        /// </summary>
        CompressedRgbPvrtc4Bppv1Img = ((int)0x8C00),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG = 0x8C01
        /// </summary>
        CompressedRgbPvrtc2Bppv1Img = ((int)0x8C01),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG = 0x8C02
        /// </summary>
        CompressedRgbaPvrtc4Bppv1Img = ((int)0x8C02),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG = 0x8C03
        /// </summary>
        CompressedRgbaPvrtc2Bppv1Img = ((int)0x8C03),
        /// <summary>
        /// Original was GL_IMG_texture_compression_pvrtc = 1
        /// </summary>
        ImgTextureCompressionPvrtc = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum ImgTextureCompressionPvrtc : int
    {
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG = 0x8C00
        /// </summary>
        CompressedRgbPvrtc4Bppv1Img = ((int)0x8C00),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG = 0x8C01
        /// </summary>
        CompressedRgbPvrtc2Bppv1Img = ((int)0x8C01),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG = 0x8C02
        /// </summary>
        CompressedRgbaPvrtc4Bppv1Img = ((int)0x8C02),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG = 0x8C03
        /// </summary>
        CompressedRgbaPvrtc2Bppv1Img = ((int)0x8C03),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum ImgtextureEnvEnhancedFixedFunction : int
    {
        /// <summary>
        /// Original was GL_DOT3_RGBA_IMG = 0x86AF
        /// </summary>
        Dot3RgbaImg = ((int)0x86AF),
        /// <summary>
        /// Original was GL_MODULATE_COLOR_IMG = 0x8C04
        /// </summary>
        ModulateColorImg = ((int)0x8C04),
        /// <summary>
        /// Original was GL_RECIP_ADD_SIGNED_ALPHA_IMG = 0x8C05
        /// </summary>
        RecipAddSignedAlphaImg = ((int)0x8C05),
        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_MODULATE_IMG = 0x8C06
        /// </summary>
        TextureAlphaModulateImg = ((int)0x8C06),
        /// <summary>
        /// Original was GL_FACTOR_ALPHA_MODULATE_IMG = 0x8C07
        /// </summary>
        FactorAlphaModulateImg = ((int)0x8C07),
        /// <summary>
        /// Original was GL_FRAGMENT_ALPHA_MODULATE_IMG = 0x8C08
        /// </summary>
        FragmentAlphaModulateImg = ((int)0x8C08),
        /// <summary>
        /// Original was GL_ADD_BLEND_IMG = 0x8C09
        /// </summary>
        AddBlendImg = ((int)0x8C09),
        /// <summary>
        /// Original was GL_IMG_texture_env_enhanced_fixed_function = 1
        /// </summary>
        ImgTextureEnvEnhancedFixedFunction = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum ImgTextureEnvEnhancedFixedFunction : int
    {
        /// <summary>
        /// Original was GL_DOT3_RGBA_IMG = 0x86AF
        /// </summary>
        Dot3RgbaImg = ((int)0x86AF),
        /// <summary>
        /// Original was GL_MODULATE_COLOR_IMG = 0x8C04
        /// </summary>
        ModulateColorImg = ((int)0x8C04),
        /// <summary>
        /// Original was GL_RECIP_ADD_SIGNED_ALPHA_IMG = 0x8C05
        /// </summary>
        RecipAddSignedAlphaImg = ((int)0x8C05),
        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_MODULATE_IMG = 0x8C06
        /// </summary>
        TextureAlphaModulateImg = ((int)0x8C06),
        /// <summary>
        /// Original was GL_FACTOR_ALPHA_MODULATE_IMG = 0x8C07
        /// </summary>
        FactorAlphaModulateImg = ((int)0x8C07),
        /// <summary>
        /// Original was GL_FRAGMENT_ALPHA_MODULATE_IMG = 0x8C08
        /// </summary>
        FragmentAlphaModulateImg = ((int)0x8C08),
        /// <summary>
        /// Original was GL_ADD_BLEND_IMG = 0x8C09
        /// </summary>
        AddBlendImg = ((int)0x8C09),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum ImguserClipPlane : int
    {
        /// <summary>
        /// Original was GL_MAX_CLIP_PLANES_IMG = 0x0D32
        /// </summary>
        MaxClipPlanesImg = ((int)0x0D32),
        /// <summary>
        /// Original was GL_CLIP_PLANE0_IMG = 0x3000
        /// </summary>
        ClipPlane0Img = ((int)0x3000),
        /// <summary>
        /// Original was GL_CLIP_PLANE1_IMG = 0x3001
        /// </summary>
        ClipPlane1Img = ((int)0x3001),
        /// <summary>
        /// Original was GL_CLIP_PLANE2_IMG = 0x3002
        /// </summary>
        ClipPlane2Img = ((int)0x3002),
        /// <summary>
        /// Original was GL_CLIP_PLANE3_IMG = 0x3003
        /// </summary>
        ClipPlane3Img = ((int)0x3003),
        /// <summary>
        /// Original was GL_CLIP_PLANE4_IMG = 0x3004
        /// </summary>
        ClipPlane4Img = ((int)0x3004),
        /// <summary>
        /// Original was GL_CLIP_PLANE5_IMG = 0x3005
        /// </summary>
        ClipPlane5Img = ((int)0x3005),
        /// <summary>
        /// Original was GL_IMG_user_clip_plane = 1
        /// </summary>
        ImgUserClipPlane = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum ImgUserClipPlane : int
    {
        /// <summary>
        /// Original was GL_MAX_CLIP_PLANES_IMG = 0x0D32
        /// </summary>
        MaxClipPlanesImg = ((int)0x0D32),
        /// <summary>
        /// Original was GL_CLIP_PLANE0_IMG = 0x3000
        /// </summary>
        ClipPlane0Img = ((int)0x3000),
        /// <summary>
        /// Original was GL_CLIP_PLANE1_IMG = 0x3001
        /// </summary>
        ClipPlane1Img = ((int)0x3001),
        /// <summary>
        /// Original was GL_CLIP_PLANE2_IMG = 0x3002
        /// </summary>
        ClipPlane2Img = ((int)0x3002),
        /// <summary>
        /// Original was GL_CLIP_PLANE3_IMG = 0x3003
        /// </summary>
        ClipPlane3Img = ((int)0x3003),
        /// <summary>
        /// Original was GL_CLIP_PLANE4_IMG = 0x3004
        /// </summary>
        ClipPlane4Img = ((int)0x3004),
        /// <summary>
        /// Original was GL_CLIP_PLANE5_IMG = 0x3005
        /// </summary>
        ClipPlane5Img = ((int)0x3005),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum IndexPointerType : int
    {
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = ((int)0x1402),
        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = ((int)0x1404),
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406),
        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = ((int)0x140A),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum InterleavedArrayFormat : int
    {
        /// <summary>
        /// Original was GL_V2F = 0x2A20
        /// </summary>
        V2f = ((int)0x2A20),
        /// <summary>
        /// Original was GL_V3F = 0x2A21
        /// </summary>
        V3f = ((int)0x2A21),
        /// <summary>
        /// Original was GL_C4UB_V2F = 0x2A22
        /// </summary>
        C4ubV2f = ((int)0x2A22),
        /// <summary>
        /// Original was GL_C4UB_V3F = 0x2A23
        /// </summary>
        C4ubV3f = ((int)0x2A23),
        /// <summary>
        /// Original was GL_C3F_V3F = 0x2A24
        /// </summary>
        C3fV3f = ((int)0x2A24),
        /// <summary>
        /// Original was GL_N3F_V3F = 0x2A25
        /// </summary>
        N3fV3f = ((int)0x2A25),
        /// <summary>
        /// Original was GL_C4F_N3F_V3F = 0x2A26
        /// </summary>
        C4fN3fV3f = ((int)0x2A26),
        /// <summary>
        /// Original was GL_T2F_V3F = 0x2A27
        /// </summary>
        T2fV3f = ((int)0x2A27),
        /// <summary>
        /// Original was GL_T4F_V4F = 0x2A28
        /// </summary>
        T4fV4f = ((int)0x2A28),
        /// <summary>
        /// Original was GL_T2F_C4UB_V3F = 0x2A29
        /// </summary>
        T2fC4ubV3f = ((int)0x2A29),
        /// <summary>
        /// Original was GL_T2F_C3F_V3F = 0x2A2A
        /// </summary>
        T2fC3fV3f = ((int)0x2A2A),
        /// <summary>
        /// Original was GL_T2F_N3F_V3F = 0x2A2B
        /// </summary>
        T2fN3fV3f = ((int)0x2A2B),
        /// <summary>
        /// Original was GL_T2F_C4F_N3F_V3F = 0x2A2C
        /// </summary>
        T2fC4fN3fV3f = ((int)0x2A2C),
        /// <summary>
        /// Original was GL_T4F_C4F_N3F_V4F = 0x2A2D
        /// </summary>
        T4fC4fN3fV4f = ((int)0x2A2D),
    }

    /// <summary>
    /// Used in GL.Apple.RenderbufferStorageMultisample, GL.CompressedTexImage2D and 11 other functions
    /// </summary>
    public enum InternalFormat : int
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT = 0x1902
        /// </summary>
        DepthComponent = ((int)0x1902),
        /// <summary>
        /// Original was GL_RED = 0x1903
        /// </summary>
        Red = ((int)0x1903),
        /// <summary>
        /// Original was GL_RED_EXT = 0x1903
        /// </summary>
        RedExt = ((int)0x1903),
        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = ((int)0x1907),
        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = ((int)0x1908),
        /// <summary>
        /// Original was GL_R3_G3_B2 = 0x2A10
        /// </summary>
        R3G3B2 = ((int)0x2A10),
        /// <summary>
        /// Original was GL_ALPHA4 = 0x803B
        /// </summary>
        Alpha4 = ((int)0x803B),
        /// <summary>
        /// Original was GL_ALPHA8 = 0x803C
        /// </summary>
        Alpha8 = ((int)0x803C),
        /// <summary>
        /// Original was GL_ALPHA12 = 0x803D
        /// </summary>
        Alpha12 = ((int)0x803D),
        /// <summary>
        /// Original was GL_ALPHA16 = 0x803E
        /// </summary>
        Alpha16 = ((int)0x803E),
        /// <summary>
        /// Original was GL_LUMINANCE4 = 0x803F
        /// </summary>
        Luminance4 = ((int)0x803F),
        /// <summary>
        /// Original was GL_LUMINANCE8 = 0x8040
        /// </summary>
        Luminance8 = ((int)0x8040),
        /// <summary>
        /// Original was GL_LUMINANCE12 = 0x8041
        /// </summary>
        Luminance12 = ((int)0x8041),
        /// <summary>
        /// Original was GL_LUMINANCE16 = 0x8042
        /// </summary>
        Luminance16 = ((int)0x8042),
        /// <summary>
        /// Original was GL_LUMINANCE4_ALPHA4 = 0x8043
        /// </summary>
        Luminance4Alpha4 = ((int)0x8043),
        /// <summary>
        /// Original was GL_LUMINANCE6_ALPHA2 = 0x8044
        /// </summary>
        Luminance6Alpha2 = ((int)0x8044),
        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8 = 0x8045
        /// </summary>
        Luminance8Alpha8 = ((int)0x8045),
        /// <summary>
        /// Original was GL_LUMINANCE12_ALPHA4 = 0x8046
        /// </summary>
        Luminance12Alpha4 = ((int)0x8046),
        /// <summary>
        /// Original was GL_LUMINANCE12_ALPHA12 = 0x8047
        /// </summary>
        Luminance12Alpha12 = ((int)0x8047),
        /// <summary>
        /// Original was GL_LUMINANCE16_ALPHA16 = 0x8048
        /// </summary>
        Luminance16Alpha16 = ((int)0x8048),
        /// <summary>
        /// Original was GL_INTENSITY = 0x8049
        /// </summary>
        Intensity = ((int)0x8049),
        /// <summary>
        /// Original was GL_INTENSITY4 = 0x804A
        /// </summary>
        Intensity4 = ((int)0x804A),
        /// <summary>
        /// Original was GL_INTENSITY8 = 0x804B
        /// </summary>
        Intensity8 = ((int)0x804B),
        /// <summary>
        /// Original was GL_INTENSITY12 = 0x804C
        /// </summary>
        Intensity12 = ((int)0x804C),
        /// <summary>
        /// Original was GL_INTENSITY16 = 0x804D
        /// </summary>
        Intensity16 = ((int)0x804D),
        /// <summary>
        /// Original was GL_RGB2_EXT = 0x804E
        /// </summary>
        Rgb2Ext = ((int)0x804E),
        /// <summary>
        /// Original was GL_RGB4 = 0x804F
        /// </summary>
        Rgb4 = ((int)0x804F),
        /// <summary>
        /// Original was GL_RGB4_EXT = 0x804F
        /// </summary>
        Rgb4Ext = ((int)0x804F),
        /// <summary>
        /// Original was GL_RGB5 = 0x8050
        /// </summary>
        Rgb5 = ((int)0x8050),
        /// <summary>
        /// Original was GL_RGB5_EXT = 0x8050
        /// </summary>
        Rgb5Ext = ((int)0x8050),
        /// <summary>
        /// Original was GL_RGB8 = 0x8051
        /// </summary>
        Rgb8 = ((int)0x8051),
        /// <summary>
        /// Original was GL_RGB8_EXT = 0x8051
        /// </summary>
        Rgb8Ext = ((int)0x8051),
        /// <summary>
        /// Original was GL_RGB8_OES = 0x8051
        /// </summary>
        Rgb8Oes = ((int)0x8051),
        /// <summary>
        /// Original was GL_RGB10 = 0x8052
        /// </summary>
        Rgb10 = ((int)0x8052),
        /// <summary>
        /// Original was GL_RGB10_EXT = 0x8052
        /// </summary>
        Rgb10Ext = ((int)0x8052),
        /// <summary>
        /// Original was GL_RGB12 = 0x8053
        /// </summary>
        Rgb12 = ((int)0x8053),
        /// <summary>
        /// Original was GL_RGB12_EXT = 0x8053
        /// </summary>
        Rgb12Ext = ((int)0x8053),
        /// <summary>
        /// Original was GL_RGB16 = 0x8054
        /// </summary>
        Rgb16 = ((int)0x8054),
        /// <summary>
        /// Original was GL_RGB16_EXT = 0x8054
        /// </summary>
        Rgb16Ext = ((int)0x8054),
        /// <summary>
        /// Original was GL_RGBA4 = 0x8056
        /// </summary>
        Rgba4 = ((int)0x8056),
        /// <summary>
        /// Original was GL_RGBA4_EXT = 0x8056
        /// </summary>
        Rgba4Ext = ((int)0x8056),
        /// <summary>
        /// Original was GL_RGBA4_OES = 0x8056
        /// </summary>
        Rgba4Oes = ((int)0x8056),
        /// <summary>
        /// Original was GL_RGB5_A1 = 0x8057
        /// </summary>
        Rgb5A1 = ((int)0x8057),
        /// <summary>
        /// Original was GL_RGB5_A1_EXT = 0x8057
        /// </summary>
        Rgb5A1Ext = ((int)0x8057),
        /// <summary>
        /// Original was GL_RGB5_A1_OES = 0x8057
        /// </summary>
        Rgb5A1Oes = ((int)0x8057),
        /// <summary>
        /// Original was GL_RGBA8 = 0x8058
        /// </summary>
        Rgba8 = ((int)0x8058),
        /// <summary>
        /// Original was GL_RGBA8_EXT = 0x8058
        /// </summary>
        Rgba8Ext = ((int)0x8058),
        /// <summary>
        /// Original was GL_RGBA8_OES = 0x8058
        /// </summary>
        Rgba8Oes = ((int)0x8058),
        /// <summary>
        /// Original was GL_RGB10_A2 = 0x8059
        /// </summary>
        Rgb10A2 = ((int)0x8059),
        /// <summary>
        /// Original was GL_RGB10_A2_EXT = 0x8059
        /// </summary>
        Rgb10A2Ext = ((int)0x8059),
        /// <summary>
        /// Original was GL_RGBA12 = 0x805A
        /// </summary>
        Rgba12 = ((int)0x805A),
        /// <summary>
        /// Original was GL_RGBA12_EXT = 0x805A
        /// </summary>
        Rgba12Ext = ((int)0x805A),
        /// <summary>
        /// Original was GL_RGBA16 = 0x805B
        /// </summary>
        Rgba16 = ((int)0x805B),
        /// <summary>
        /// Original was GL_RGBA16_EXT = 0x805B
        /// </summary>
        Rgba16Ext = ((int)0x805B),
        /// <summary>
        /// Original was GL_DUAL_ALPHA4_SGIS = 0x8110
        /// </summary>
        DualAlpha4Sgis = ((int)0x8110),
        /// <summary>
        /// Original was GL_DUAL_ALPHA8_SGIS = 0x8111
        /// </summary>
        DualAlpha8Sgis = ((int)0x8111),
        /// <summary>
        /// Original was GL_DUAL_ALPHA12_SGIS = 0x8112
        /// </summary>
        DualAlpha12Sgis = ((int)0x8112),
        /// <summary>
        /// Original was GL_DUAL_ALPHA16_SGIS = 0x8113
        /// </summary>
        DualAlpha16Sgis = ((int)0x8113),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE4_SGIS = 0x8114
        /// </summary>
        DualLuminance4Sgis = ((int)0x8114),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE8_SGIS = 0x8115
        /// </summary>
        DualLuminance8Sgis = ((int)0x8115),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE12_SGIS = 0x8116
        /// </summary>
        DualLuminance12Sgis = ((int)0x8116),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE16_SGIS = 0x8117
        /// </summary>
        DualLuminance16Sgis = ((int)0x8117),
        /// <summary>
        /// Original was GL_DUAL_INTENSITY4_SGIS = 0x8118
        /// </summary>
        DualIntensity4Sgis = ((int)0x8118),
        /// <summary>
        /// Original was GL_DUAL_INTENSITY8_SGIS = 0x8119
        /// </summary>
        DualIntensity8Sgis = ((int)0x8119),
        /// <summary>
        /// Original was GL_DUAL_INTENSITY12_SGIS = 0x811A
        /// </summary>
        DualIntensity12Sgis = ((int)0x811A),
        /// <summary>
        /// Original was GL_DUAL_INTENSITY16_SGIS = 0x811B
        /// </summary>
        DualIntensity16Sgis = ((int)0x811B),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C
        /// </summary>
        DualLuminanceAlpha4Sgis = ((int)0x811C),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D
        /// </summary>
        DualLuminanceAlpha8Sgis = ((int)0x811D),
        /// <summary>
        /// Original was GL_QUAD_ALPHA4_SGIS = 0x811E
        /// </summary>
        QuadAlpha4Sgis = ((int)0x811E),
        /// <summary>
        /// Original was GL_QUAD_ALPHA8_SGIS = 0x811F
        /// </summary>
        QuadAlpha8Sgis = ((int)0x811F),
        /// <summary>
        /// Original was GL_QUAD_LUMINANCE4_SGIS = 0x8120
        /// </summary>
        QuadLuminance4Sgis = ((int)0x8120),
        /// <summary>
        /// Original was GL_QUAD_LUMINANCE8_SGIS = 0x8121
        /// </summary>
        QuadLuminance8Sgis = ((int)0x8121),
        /// <summary>
        /// Original was GL_QUAD_INTENSITY4_SGIS = 0x8122
        /// </summary>
        QuadIntensity4Sgis = ((int)0x8122),
        /// <summary>
        /// Original was GL_QUAD_INTENSITY8_SGIS = 0x8123
        /// </summary>
        QuadIntensity8Sgis = ((int)0x8123),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16 = 0x81A5
        /// </summary>
        DepthComponent16 = ((int)0x81A5),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_ARB = 0x81A5
        /// </summary>
        DepthComponent16Arb = ((int)0x81A5),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_OES = 0x81A5
        /// </summary>
        DepthComponent16Oes = ((int)0x81A5),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_SGIX = 0x81A5
        /// </summary>
        DepthComponent16Sgix = ((int)0x81A5),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_ARB = 0x81A6
        /// </summary>
        DepthComponent24Arb = ((int)0x81A6),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_OES = 0x81A6
        /// </summary>
        DepthComponent24Oes = ((int)0x81A6),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_SGIX = 0x81A6
        /// </summary>
        DepthComponent24Sgix = ((int)0x81A6),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_ARB = 0x81A7
        /// </summary>
        DepthComponent32Arb = ((int)0x81A7),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        /// </summary>
        DepthComponent32Oes = ((int)0x81A7),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_SGIX = 0x81A7
        /// </summary>
        DepthComponent32Sgix = ((int)0x81A7),
        /// <summary>
        /// Original was GL_COMPRESSED_RED = 0x8225
        /// </summary>
        CompressedRed = ((int)0x8225),
        /// <summary>
        /// Original was GL_COMPRESSED_RG = 0x8226
        /// </summary>
        CompressedRg = ((int)0x8226),
        /// <summary>
        /// Original was GL_RG = 0x8227
        /// </summary>
        Rg = ((int)0x8227),
        /// <summary>
        /// Original was GL_R8 = 0x8229
        /// </summary>
        R8 = ((int)0x8229),
        /// <summary>
        /// Original was GL_R8_EXT = 0x8229
        /// </summary>
        R8Ext = ((int)0x8229),
        /// <summary>
        /// Original was GL_R16 = 0x822A
        /// </summary>
        R16 = ((int)0x822A),
        /// <summary>
        /// Original was GL_R16_EXT = 0x822A
        /// </summary>
        R16Ext = ((int)0x822A),
        /// <summary>
        /// Original was GL_RG8 = 0x822B
        /// </summary>
        Rg8 = ((int)0x822B),
        /// <summary>
        /// Original was GL_RG8_EXT = 0x822B
        /// </summary>
        Rg8Ext = ((int)0x822B),
        /// <summary>
        /// Original was GL_RG16 = 0x822C
        /// </summary>
        Rg16 = ((int)0x822C),
        /// <summary>
        /// Original was GL_RG16_EXT = 0x822C
        /// </summary>
        Rg16Ext = ((int)0x822C),
        /// <summary>
        /// Original was GL_R16F = 0x822D
        /// </summary>
        R16f = ((int)0x822D),
        /// <summary>
        /// Original was GL_R16F_EXT = 0x822D
        /// </summary>
        R16fExt = ((int)0x822D),
        /// <summary>
        /// Original was GL_R32F = 0x822E
        /// </summary>
        R32f = ((int)0x822E),
        /// <summary>
        /// Original was GL_R32F_EXT = 0x822E
        /// </summary>
        R32fExt = ((int)0x822E),
        /// <summary>
        /// Original was GL_RG16F = 0x822F
        /// </summary>
        Rg16f = ((int)0x822F),
        /// <summary>
        /// Original was GL_RG16F_EXT = 0x822F
        /// </summary>
        Rg16fExt = ((int)0x822F),
        /// <summary>
        /// Original was GL_RG32F = 0x8230
        /// </summary>
        Rg32f = ((int)0x8230),
        /// <summary>
        /// Original was GL_RG32F_EXT = 0x8230
        /// </summary>
        Rg32fExt = ((int)0x8230),
        /// <summary>
        /// Original was GL_R8I = 0x8231
        /// </summary>
        R8i = ((int)0x8231),
        /// <summary>
        /// Original was GL_R8UI = 0x8232
        /// </summary>
        R8ui = ((int)0x8232),
        /// <summary>
        /// Original was GL_R16I = 0x8233
        /// </summary>
        R16i = ((int)0x8233),
        /// <summary>
        /// Original was GL_R16UI = 0x8234
        /// </summary>
        R16ui = ((int)0x8234),
        /// <summary>
        /// Original was GL_R32I = 0x8235
        /// </summary>
        R32i = ((int)0x8235),
        /// <summary>
        /// Original was GL_R32UI = 0x8236
        /// </summary>
        R32ui = ((int)0x8236),
        /// <summary>
        /// Original was GL_RG8I = 0x8237
        /// </summary>
        Rg8i = ((int)0x8237),
        /// <summary>
        /// Original was GL_RG8UI = 0x8238
        /// </summary>
        Rg8ui = ((int)0x8238),
        /// <summary>
        /// Original was GL_RG16I = 0x8239
        /// </summary>
        Rg16i = ((int)0x8239),
        /// <summary>
        /// Original was GL_RG16UI = 0x823A
        /// </summary>
        Rg16ui = ((int)0x823A),
        /// <summary>
        /// Original was GL_RG32I = 0x823B
        /// </summary>
        Rg32i = ((int)0x823B),
        /// <summary>
        /// Original was GL_RG32UI = 0x823C
        /// </summary>
        Rg32ui = ((int)0x823C),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0
        /// </summary>
        CompressedRgbS3tcDxt1Ext = ((int)0x83F0),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1
        /// </summary>
        CompressedRgbaS3tcDxt1Ext = ((int)0x83F1),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2
        /// </summary>
        CompressedRgbaS3tcDxt3Ext = ((int)0x83F2),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3
        /// </summary>
        CompressedRgbaS3tcDxt5Ext = ((int)0x83F3),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB = 0x84ED
        /// </summary>
        CompressedRgb = ((int)0x84ED),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA = 0x84EE
        /// </summary>
        CompressedRgba = ((int)0x84EE),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL = 0x84F9
        /// </summary>
        DepthStencil = ((int)0x84F9),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_EXT = 0x84F9
        /// </summary>
        DepthStencilExt = ((int)0x84F9),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_NV = 0x84F9
        /// </summary>
        DepthStencilNv = ((int)0x84F9),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_OES = 0x84F9
        /// </summary>
        DepthStencilOes = ((int)0x84F9),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_MESA = 0x8750
        /// </summary>
        DepthStencilMesa = ((int)0x8750),
        /// <summary>
        /// Original was GL_RGBA32F = 0x8814
        /// </summary>
        Rgba32f = ((int)0x8814),
        /// <summary>
        /// Original was GL_RGBA32F_ARB = 0x8814
        /// </summary>
        Rgba32fArb = ((int)0x8814),
        /// <summary>
        /// Original was GL_RGBA32F_EXT = 0x8814
        /// </summary>
        Rgba32fExt = ((int)0x8814),
        /// <summary>
        /// Original was GL_RGBA16F = 0x881A
        /// </summary>
        Rgba16f = ((int)0x881A),
        /// <summary>
        /// Original was GL_RGBA16F_ARB = 0x881A
        /// </summary>
        Rgba16fArb = ((int)0x881A),
        /// <summary>
        /// Original was GL_RGBA16F_EXT = 0x881A
        /// </summary>
        Rgba16fExt = ((int)0x881A),
        /// <summary>
        /// Original was GL_RGB16F = 0x881B
        /// </summary>
        Rgb16f = ((int)0x881B),
        /// <summary>
        /// Original was GL_RGB16F_ARB = 0x881B
        /// </summary>
        Rgb16fArb = ((int)0x881B),
        /// <summary>
        /// Original was GL_RGB16F_EXT = 0x881B
        /// </summary>
        Rgb16fExt = ((int)0x881B),
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8 = 0x88F0
        /// </summary>
        Depth24Stencil8 = ((int)0x88F0),
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_EXT = 0x88F0
        /// </summary>
        Depth24Stencil8Ext = ((int)0x88F0),
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        /// </summary>
        Depth24Stencil8Oes = ((int)0x88F0),
        /// <summary>
        /// Original was GL_R11F_G11F_B10F = 0x8C3A
        /// </summary>
        R11fG11fB10f = ((int)0x8C3A),
        /// <summary>
        /// Original was GL_R11F_G11F_B10F_APPLE = 0x8C3A
        /// </summary>
        R11fG11fB10fApple = ((int)0x8C3A),
        /// <summary>
        /// Original was GL_R11F_G11F_B10F_EXT = 0x8C3A
        /// </summary>
        R11fG11fB10fExt = ((int)0x8C3A),
        /// <summary>
        /// Original was GL_RGB9_E5 = 0x8C3D
        /// </summary>
        Rgb9E5 = ((int)0x8C3D),
        /// <summary>
        /// Original was GL_RGB9_E5_APPLE = 0x8C3D
        /// </summary>
        Rgb9E5Apple = ((int)0x8C3D),
        /// <summary>
        /// Original was GL_RGB9_E5_EXT = 0x8C3D
        /// </summary>
        Rgb9E5Ext = ((int)0x8C3D),
        /// <summary>
        /// Original was GL_SRGB = 0x8C40
        /// </summary>
        Srgb = ((int)0x8C40),
        /// <summary>
        /// Original was GL_SRGB_EXT = 0x8C40
        /// </summary>
        SrgbExt = ((int)0x8C40),
        /// <summary>
        /// Original was GL_SRGB8 = 0x8C41
        /// </summary>
        Srgb8 = ((int)0x8C41),
        /// <summary>
        /// Original was GL_SRGB8_EXT = 0x8C41
        /// </summary>
        Srgb8Ext = ((int)0x8C41),
        /// <summary>
        /// Original was GL_SRGB8_NV = 0x8C41
        /// </summary>
        Srgb8Nv = ((int)0x8C41),
        /// <summary>
        /// Original was GL_SRGB_ALPHA = 0x8C42
        /// </summary>
        SrgbAlpha = ((int)0x8C42),
        /// <summary>
        /// Original was GL_SRGB_ALPHA_EXT = 0x8C42
        /// </summary>
        SrgbAlphaExt = ((int)0x8C42),
        /// <summary>
        /// Original was GL_SRGB8_ALPHA8 = 0x8C43
        /// </summary>
        Srgb8Alpha8 = ((int)0x8C43),
        /// <summary>
        /// Original was GL_SRGB8_ALPHA8_EXT = 0x8C43
        /// </summary>
        Srgb8Alpha8Ext = ((int)0x8C43),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB = 0x8C48
        /// </summary>
        CompressedSrgb = ((int)0x8C48),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA = 0x8C49
        /// </summary>
        CompressedSrgbAlpha = ((int)0x8C49),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C
        /// </summary>
        CompressedSrgbS3tcDxt1Ext = ((int)0x8C4C),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D
        /// </summary>
        CompressedSrgbAlphaS3tcDxt1Ext = ((int)0x8C4D),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E
        /// </summary>
        CompressedSrgbAlphaS3tcDxt3Ext = ((int)0x8C4E),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F
        /// </summary>
        CompressedSrgbAlphaS3tcDxt5Ext = ((int)0x8C4F),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        /// </summary>
        DepthComponent32f = ((int)0x8CAC),
        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        /// </summary>
        Depth32fStencil8 = ((int)0x8CAD),
        /// <summary>
        /// Original was GL_RGBA32UI = 0x8D70
        /// </summary>
        Rgba32ui = ((int)0x8D70),
        /// <summary>
        /// Original was GL_RGB32UI = 0x8D71
        /// </summary>
        Rgb32ui = ((int)0x8D71),
        /// <summary>
        /// Original was GL_RGBA16UI = 0x8D76
        /// </summary>
        Rgba16ui = ((int)0x8D76),
        /// <summary>
        /// Original was GL_RGB16UI = 0x8D77
        /// </summary>
        Rgb16ui = ((int)0x8D77),
        /// <summary>
        /// Original was GL_RGBA8UI = 0x8D7C
        /// </summary>
        Rgba8ui = ((int)0x8D7C),
        /// <summary>
        /// Original was GL_RGB8UI = 0x8D7D
        /// </summary>
        Rgb8ui = ((int)0x8D7D),
        /// <summary>
        /// Original was GL_RGBA32I = 0x8D82
        /// </summary>
        Rgba32i = ((int)0x8D82),
        /// <summary>
        /// Original was GL_RGB32I = 0x8D83
        /// </summary>
        Rgb32i = ((int)0x8D83),
        /// <summary>
        /// Original was GL_RGBA16I = 0x8D88
        /// </summary>
        Rgba16i = ((int)0x8D88),
        /// <summary>
        /// Original was GL_RGB16I = 0x8D89
        /// </summary>
        Rgb16i = ((int)0x8D89),
        /// <summary>
        /// Original was GL_RGBA8I = 0x8D8E
        /// </summary>
        Rgba8i = ((int)0x8D8E),
        /// <summary>
        /// Original was GL_RGB8I = 0x8D8F
        /// </summary>
        Rgb8i = ((int)0x8D8F),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F_NV = 0x8DAB
        /// </summary>
        DepthComponent32fNv = ((int)0x8DAB),
        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8_NV = 0x8DAC
        /// </summary>
        Depth32fStencil8Nv = ((int)0x8DAC),
        /// <summary>
        /// Original was GL_COMPRESSED_RED_RGTC1 = 0x8DBB
        /// </summary>
        CompressedRedRgtc1 = ((int)0x8DBB),
        /// <summary>
        /// Original was GL_COMPRESSED_RED_RGTC1_EXT = 0x8DBB
        /// </summary>
        CompressedRedRgtc1Ext = ((int)0x8DBB),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC
        /// </summary>
        CompressedSignedRedRgtc1 = ((int)0x8DBC),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC
        /// </summary>
        CompressedSignedRedRgtc1Ext = ((int)0x8DBC),
        /// <summary>
        /// Original was GL_COMPRESSED_RG_RGTC2 = 0x8DBD
        /// </summary>
        CompressedRgRgtc2 = ((int)0x8DBD),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE
        /// </summary>
        CompressedSignedRgRgtc2 = ((int)0x8DBE),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
        /// </summary>
        CompressedRgbaBptcUnorm = ((int)0x8E8C),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D
        /// </summary>
        CompressedSrgbAlphaBptcUnorm = ((int)0x8E8D),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
        /// </summary>
        CompressedRgbBptcSignedFloat = ((int)0x8E8E),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
        /// </summary>
        CompressedRgbBptcUnsignedFloat = ((int)0x8E8F),
        /// <summary>
        /// Original was GL_R8_SNORM = 0x8F94
        /// </summary>
        R8Snorm = ((int)0x8F94),
        /// <summary>
        /// Original was GL_RG8_SNORM = 0x8F95
        /// </summary>
        Rg8Snorm = ((int)0x8F95),
        /// <summary>
        /// Original was GL_RGB8_SNORM = 0x8F96
        /// </summary>
        Rgb8Snorm = ((int)0x8F96),
        /// <summary>
        /// Original was GL_RGBA8_SNORM = 0x8F97
        /// </summary>
        Rgba8Snorm = ((int)0x8F97),
        /// <summary>
        /// Original was GL_R16_SNORM = 0x8F98
        /// </summary>
        R16Snorm = ((int)0x8F98),
        /// <summary>
        /// Original was GL_R16_SNORM_EXT = 0x8F98
        /// </summary>
        R16SnormExt = ((int)0x8F98),
        /// <summary>
        /// Original was GL_RG16_SNORM = 0x8F99
        /// </summary>
        Rg16Snorm = ((int)0x8F99),
        /// <summary>
        /// Original was GL_RG16_SNORM_EXT = 0x8F99
        /// </summary>
        Rg16SnormExt = ((int)0x8F99),
        /// <summary>
        /// Original was GL_RGB16_SNORM = 0x8F9A
        /// </summary>
        Rgb16Snorm = ((int)0x8F9A),
        /// <summary>
        /// Original was GL_RGB16_SNORM_EXT = 0x8F9A
        /// </summary>
        Rgb16SnormExt = ((int)0x8F9A),
        /// <summary>
        /// Original was GL_RGB10_A2UI = 0x906F
        /// </summary>
        Rgb10A2ui = ((int)0x906F),
        /// <summary>
        /// Original was GL_COMPRESSED_R11_EAC = 0x9270
        /// </summary>
        CompressedR11Eac = ((int)0x9270),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_R11_EAC = 0x9271
        /// </summary>
        CompressedSignedR11Eac = ((int)0x9271),
        /// <summary>
        /// Original was GL_COMPRESSED_RG11_EAC = 0x9272
        /// </summary>
        CompressedRg11Eac = ((int)0x9272),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273
        /// </summary>
        CompressedSignedRg11Eac = ((int)0x9273),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB8_ETC2 = 0x9274
        /// </summary>
        CompressedRgb8Etc2 = ((int)0x9274),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ETC2 = 0x9275
        /// </summary>
        CompressedSrgb8Etc2 = ((int)0x9275),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276
        /// </summary>
        CompressedRgb8PunchthroughAlpha1Etc2 = ((int)0x9276),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277
        /// </summary>
        CompressedSrgb8PunchthroughAlpha1Etc2 = ((int)0x9277),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278
        /// </summary>
        CompressedRgba8Etc2Eac = ((int)0x9278),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279
        /// </summary>
        CompressedSrgb8Alpha8Etc2Eac = ((int)0x9279),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum InternalFormatPName : int
    {
        /// <summary>
        /// Original was GL_SAMPLES = 0x80A9
        /// </summary>
        Samples = ((int)0x80A9),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP = 0x8191
        /// </summary>
        GenerateMipmap = ((int)0x8191),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_SUPPORTED = 0x826F
        /// </summary>
        InternalformatSupported = ((int)0x826F),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_PREFERRED = 0x8270
        /// </summary>
        InternalformatPreferred = ((int)0x8270),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_RED_SIZE = 0x8271
        /// </summary>
        InternalformatRedSize = ((int)0x8271),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_GREEN_SIZE = 0x8272
        /// </summary>
        InternalformatGreenSize = ((int)0x8272),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_BLUE_SIZE = 0x8273
        /// </summary>
        InternalformatBlueSize = ((int)0x8273),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274
        /// </summary>
        InternalformatAlphaSize = ((int)0x8274),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275
        /// </summary>
        InternalformatDepthSize = ((int)0x8275),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276
        /// </summary>
        InternalformatStencilSize = ((int)0x8276),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_SHARED_SIZE = 0x8277
        /// </summary>
        InternalformatSharedSize = ((int)0x8277),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_RED_TYPE = 0x8278
        /// </summary>
        InternalformatRedType = ((int)0x8278),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_GREEN_TYPE = 0x8279
        /// </summary>
        InternalformatGreenType = ((int)0x8279),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_BLUE_TYPE = 0x827A
        /// </summary>
        InternalformatBlueType = ((int)0x827A),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B
        /// </summary>
        InternalformatAlphaType = ((int)0x827B),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C
        /// </summary>
        InternalformatDepthType = ((int)0x827C),
        /// <summary>
        /// Original was GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D
        /// </summary>
        InternalformatStencilType = ((int)0x827D),
        /// <summary>
        /// Original was GL_MAX_WIDTH = 0x827E
        /// </summary>
        MaxWidth = ((int)0x827E),
        /// <summary>
        /// Original was GL_MAX_HEIGHT = 0x827F
        /// </summary>
        MaxHeight = ((int)0x827F),
        /// <summary>
        /// Original was GL_MAX_DEPTH = 0x8280
        /// </summary>
        MaxDepth = ((int)0x8280),
        /// <summary>
        /// Original was GL_MAX_LAYERS = 0x8281
        /// </summary>
        MaxLayers = ((int)0x8281),
        /// <summary>
        /// Original was GL_COLOR_COMPONENTS = 0x8283
        /// </summary>
        ColorComponents = ((int)0x8283),
        /// <summary>
        /// Original was GL_COLOR_RENDERABLE = 0x8286
        /// </summary>
        ColorRenderable = ((int)0x8286),
        /// <summary>
        /// Original was GL_DEPTH_RENDERABLE = 0x8287
        /// </summary>
        DepthRenderable = ((int)0x8287),
        /// <summary>
        /// Original was GL_STENCIL_RENDERABLE = 0x8288
        /// </summary>
        StencilRenderable = ((int)0x8288),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_RENDERABLE = 0x8289
        /// </summary>
        FramebufferRenderable = ((int)0x8289),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A
        /// </summary>
        FramebufferRenderableLayered = ((int)0x828A),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_BLEND = 0x828B
        /// </summary>
        FramebufferBlend = ((int)0x828B),
        /// <summary>
        /// Original was GL_READ_PIXELS = 0x828C
        /// </summary>
        ReadPixels = ((int)0x828C),
        /// <summary>
        /// Original was GL_READ_PIXELS_FORMAT = 0x828D
        /// </summary>
        ReadPixelsFormat = ((int)0x828D),
        /// <summary>
        /// Original was GL_READ_PIXELS_TYPE = 0x828E
        /// </summary>
        ReadPixelsType = ((int)0x828E),
        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_FORMAT = 0x828F
        /// </summary>
        TextureImageFormat = ((int)0x828F),
        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_TYPE = 0x8290
        /// </summary>
        TextureImageType = ((int)0x8290),
        /// <summary>
        /// Original was GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291
        /// </summary>
        GetTextureImageFormat = ((int)0x8291),
        /// <summary>
        /// Original was GL_GET_TEXTURE_IMAGE_TYPE = 0x8292
        /// </summary>
        GetTextureImageType = ((int)0x8292),
        /// <summary>
        /// Original was GL_MIPMAP = 0x8293
        /// </summary>
        Mipmap = ((int)0x8293),
        /// <summary>
        /// Original was GL_AUTO_GENERATE_MIPMAP = 0x8295
        /// </summary>
        AutoGenerateMipmap = ((int)0x8295),
        /// <summary>
        /// Original was GL_COLOR_ENCODING = 0x8296
        /// </summary>
        ColorEncoding = ((int)0x8296),
        /// <summary>
        /// Original was GL_SRGB_READ = 0x8297
        /// </summary>
        SrgbRead = ((int)0x8297),
        /// <summary>
        /// Original was GL_SRGB_WRITE = 0x8298
        /// </summary>
        SrgbWrite = ((int)0x8298),
        /// <summary>
        /// Original was GL_FILTER = 0x829A
        /// </summary>
        Filter = ((int)0x829A),
        /// <summary>
        /// Original was GL_VERTEX_TEXTURE = 0x829B
        /// </summary>
        VertexTexture = ((int)0x829B),
        /// <summary>
        /// Original was GL_TESS_CONTROL_TEXTURE = 0x829C
        /// </summary>
        TessControlTexture = ((int)0x829C),
        /// <summary>
        /// Original was GL_TESS_EVALUATION_TEXTURE = 0x829D
        /// </summary>
        TessEvaluationTexture = ((int)0x829D),
        /// <summary>
        /// Original was GL_GEOMETRY_TEXTURE = 0x829E
        /// </summary>
        GeometryTexture = ((int)0x829E),
        /// <summary>
        /// Original was GL_FRAGMENT_TEXTURE = 0x829F
        /// </summary>
        FragmentTexture = ((int)0x829F),
        /// <summary>
        /// Original was GL_COMPUTE_TEXTURE = 0x82A0
        /// </summary>
        ComputeTexture = ((int)0x82A0),
        /// <summary>
        /// Original was GL_TEXTURE_SHADOW = 0x82A1
        /// </summary>
        TextureShadow = ((int)0x82A1),
        /// <summary>
        /// Original was GL_TEXTURE_GATHER = 0x82A2
        /// </summary>
        TextureGather = ((int)0x82A2),
        /// <summary>
        /// Original was GL_TEXTURE_GATHER_SHADOW = 0x82A3
        /// </summary>
        TextureGatherShadow = ((int)0x82A3),
        /// <summary>
        /// Original was GL_SHADER_IMAGE_LOAD = 0x82A4
        /// </summary>
        ShaderImageLoad = ((int)0x82A4),
        /// <summary>
        /// Original was GL_SHADER_IMAGE_STORE = 0x82A5
        /// </summary>
        ShaderImageStore = ((int)0x82A5),
        /// <summary>
        /// Original was GL_SHADER_IMAGE_ATOMIC = 0x82A6
        /// </summary>
        ShaderImageAtomic = ((int)0x82A6),
        /// <summary>
        /// Original was GL_IMAGE_TEXEL_SIZE = 0x82A7
        /// </summary>
        ImageTexelSize = ((int)0x82A7),
        /// <summary>
        /// Original was GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8
        /// </summary>
        ImageCompatibilityClass = ((int)0x82A8),
        /// <summary>
        /// Original was GL_IMAGE_PIXEL_FORMAT = 0x82A9
        /// </summary>
        ImagePixelFormat = ((int)0x82A9),
        /// <summary>
        /// Original was GL_IMAGE_PIXEL_TYPE = 0x82AA
        /// </summary>
        ImagePixelType = ((int)0x82AA),
        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC
        /// </summary>
        SimultaneousTextureAndDepthTest = ((int)0x82AC),
        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD
        /// </summary>
        SimultaneousTextureAndStencilTest = ((int)0x82AD),
        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE
        /// </summary>
        SimultaneousTextureAndDepthWrite = ((int)0x82AE),
        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF
        /// </summary>
        SimultaneousTextureAndStencilWrite = ((int)0x82AF),
        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1
        /// </summary>
        TextureCompressedBlockWidth = ((int)0x82B1),
        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2
        /// </summary>
        TextureCompressedBlockHeight = ((int)0x82B2),
        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3
        /// </summary>
        TextureCompressedBlockSize = ((int)0x82B3),
        /// <summary>
        /// Original was GL_CLEAR_BUFFER = 0x82B4
        /// </summary>
        ClearBuffer = ((int)0x82B4),
        /// <summary>
        /// Original was GL_TEXTURE_VIEW = 0x82B5
        /// </summary>
        TextureView = ((int)0x82B5),
        /// <summary>
        /// Original was GL_VIEW_COMPATIBILITY_CLASS = 0x82B6
        /// </summary>
        ViewCompatibilityClass = ((int)0x82B6),
        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED = 0x86A1
        /// </summary>
        TextureCompressed = ((int)0x86A1),
        /// <summary>
        /// Original was GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7
        /// </summary>
        ImageFormatCompatibilityType = ((int)0x90C7),
        /// <summary>
        /// Original was GL_CLEAR_TEXTURE = 0x9365
        /// </summary>
        ClearTexture = ((int)0x9365),
        /// <summary>
        /// Original was GL_NUM_SAMPLE_COUNTS = 0x9380
        /// </summary>
        NumSampleCounts = ((int)0x9380),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum KhrDebug : int
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
        StackOverflow = ((int)0x0503),
        /// <summary>
        /// Original was GL_STACK_OVERFLOW_KHR = 0x0503
        /// </summary>
        StackOverflowKhr = ((int)0x0503),
        /// <summary>
        /// Original was GL_STACK_UNDERFLOW = 0x0504
        /// </summary>
        StackUnderflow = ((int)0x0504),
        /// <summary>
        /// Original was GL_STACK_UNDERFLOW_KHR = 0x0504
        /// </summary>
        StackUnderflowKhr = ((int)0x0504),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = ((int)0x8074),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_KHR = 0x8074
        /// </summary>
        VertexArrayKhr = ((int)0x8074),
        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242
        /// </summary>
        DebugOutputSynchronous = ((int)0x8242),
        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_SYNCHRONOUS_KHR = 0x8242
        /// </summary>
        DebugOutputSynchronousKhr = ((int)0x8242),
        /// <summary>
        /// Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243
        /// </summary>
        DebugNextLoggedMessageLength = ((int)0x8243),
        /// <summary>
        /// Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_KHR = 0x8243
        /// </summary>
        DebugNextLoggedMessageLengthKhr = ((int)0x8243),
        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_FUNCTION = 0x8244
        /// </summary>
        DebugCallbackFunction = ((int)0x8244),
        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_FUNCTION_KHR = 0x8244
        /// </summary>
        DebugCallbackFunctionKhr = ((int)0x8244),
        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_USER_PARAM = 0x8245
        /// </summary>
        DebugCallbackUserParam = ((int)0x8245),
        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_USER_PARAM_KHR = 0x8245
        /// </summary>
        DebugCallbackUserParamKhr = ((int)0x8245),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_API = 0x8246
        /// </summary>
        DebugSourceApi = ((int)0x8246),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_API_KHR = 0x8246
        /// </summary>
        DebugSourceApiKhr = ((int)0x8246),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247
        /// </summary>
        DebugSourceWindowSystem = ((int)0x8247),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM_KHR = 0x8247
        /// </summary>
        DebugSourceWindowSystemKhr = ((int)0x8247),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248
        /// </summary>
        DebugSourceShaderCompiler = ((int)0x8248),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_SHADER_COMPILER_KHR = 0x8248
        /// </summary>
        DebugSourceShaderCompilerKhr = ((int)0x8248),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249
        /// </summary>
        DebugSourceThirdParty = ((int)0x8249),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_THIRD_PARTY_KHR = 0x8249
        /// </summary>
        DebugSourceThirdPartyKhr = ((int)0x8249),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_APPLICATION = 0x824A
        /// </summary>
        DebugSourceApplication = ((int)0x824A),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_APPLICATION_KHR = 0x824A
        /// </summary>
        DebugSourceApplicationKhr = ((int)0x824A),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_OTHER = 0x824B
        /// </summary>
        DebugSourceOther = ((int)0x824B),
        /// <summary>
        /// Original was GL_DEBUG_SOURCE_OTHER_KHR = 0x824B
        /// </summary>
        DebugSourceOtherKhr = ((int)0x824B),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_ERROR = 0x824C
        /// </summary>
        DebugTypeError = ((int)0x824C),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_ERROR_KHR = 0x824C
        /// </summary>
        DebugTypeErrorKhr = ((int)0x824C),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D
        /// </summary>
        DebugTypeDeprecatedBehavior = ((int)0x824D),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_KHR = 0x824D
        /// </summary>
        DebugTypeDeprecatedBehaviorKhr = ((int)0x824D),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E
        /// </summary>
        DebugTypeUndefinedBehavior = ((int)0x824E),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_KHR = 0x824E
        /// </summary>
        DebugTypeUndefinedBehaviorKhr = ((int)0x824E),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_PORTABILITY = 0x824F
        /// </summary>
        DebugTypePortability = ((int)0x824F),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_PORTABILITY_KHR = 0x824F
        /// </summary>
        DebugTypePortabilityKhr = ((int)0x824F),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_PERFORMANCE = 0x8250
        /// </summary>
        DebugTypePerformance = ((int)0x8250),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_PERFORMANCE_KHR = 0x8250
        /// </summary>
        DebugTypePerformanceKhr = ((int)0x8250),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_OTHER = 0x8251
        /// </summary>
        DebugTypeOther = ((int)0x8251),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_OTHER_KHR = 0x8251
        /// </summary>
        DebugTypeOtherKhr = ((int)0x8251),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_MARKER = 0x8268
        /// </summary>
        DebugTypeMarker = ((int)0x8268),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_MARKER_KHR = 0x8268
        /// </summary>
        DebugTypeMarkerKhr = ((int)0x8268),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_PUSH_GROUP = 0x8269
        /// </summary>
        DebugTypePushGroup = ((int)0x8269),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_PUSH_GROUP_KHR = 0x8269
        /// </summary>
        DebugTypePushGroupKhr = ((int)0x8269),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_POP_GROUP = 0x826A
        /// </summary>
        DebugTypePopGroup = ((int)0x826A),
        /// <summary>
        /// Original was GL_DEBUG_TYPE_POP_GROUP_KHR = 0x826A
        /// </summary>
        DebugTypePopGroupKhr = ((int)0x826A),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B
        /// </summary>
        DebugSeverityNotification = ((int)0x826B),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_NOTIFICATION_KHR = 0x826B
        /// </summary>
        DebugSeverityNotificationKhr = ((int)0x826B),
        /// <summary>
        /// Original was GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C
        /// </summary>
        MaxDebugGroupStackDepth = ((int)0x826C),
        /// <summary>
        /// Original was GL_MAX_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826C
        /// </summary>
        MaxDebugGroupStackDepthKhr = ((int)0x826C),
        /// <summary>
        /// Original was GL_DEBUG_GROUP_STACK_DEPTH = 0x826D
        /// </summary>
        DebugGroupStackDepth = ((int)0x826D),
        /// <summary>
        /// Original was GL_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826D
        /// </summary>
        DebugGroupStackDepthKhr = ((int)0x826D),
        /// <summary>
        /// Original was GL_BUFFER = 0x82E0
        /// </summary>
        Buffer = ((int)0x82E0),
        /// <summary>
        /// Original was GL_BUFFER_KHR = 0x82E0
        /// </summary>
        BufferKhr = ((int)0x82E0),
        /// <summary>
        /// Original was GL_SHADER = 0x82E1
        /// </summary>
        Shader = ((int)0x82E1),
        /// <summary>
        /// Original was GL_SHADER_KHR = 0x82E1
        /// </summary>
        ShaderKhr = ((int)0x82E1),
        /// <summary>
        /// Original was GL_PROGRAM = 0x82E2
        /// </summary>
        Program = ((int)0x82E2),
        /// <summary>
        /// Original was GL_PROGRAM_KHR = 0x82E2
        /// </summary>
        ProgramKhr = ((int)0x82E2),
        /// <summary>
        /// Original was GL_QUERY = 0x82E3
        /// </summary>
        Query = ((int)0x82E3),
        /// <summary>
        /// Original was GL_QUERY_KHR = 0x82E3
        /// </summary>
        QueryKhr = ((int)0x82E3),
        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE = 0x82E4
        /// </summary>
        ProgramPipeline = ((int)0x82E4),
        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE_KHR = 0x82E4
        /// </summary>
        ProgramPipelineKhr = ((int)0x82E4),
        /// <summary>
        /// Original was GL_SAMPLER = 0x82E6
        /// </summary>
        Sampler = ((int)0x82E6),
        /// <summary>
        /// Original was GL_SAMPLER_KHR = 0x82E6
        /// </summary>
        SamplerKhr = ((int)0x82E6),
        /// <summary>
        /// Original was GL_DISPLAY_LIST = 0x82E7
        /// </summary>
        DisplayList = ((int)0x82E7),
        /// <summary>
        /// Original was GL_MAX_LABEL_LENGTH = 0x82E8
        /// </summary>
        MaxLabelLength = ((int)0x82E8),
        /// <summary>
        /// Original was GL_MAX_LABEL_LENGTH_KHR = 0x82E8
        /// </summary>
        MaxLabelLengthKhr = ((int)0x82E8),
        /// <summary>
        /// Original was GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143
        /// </summary>
        MaxDebugMessageLength = ((int)0x9143),
        /// <summary>
        /// Original was GL_MAX_DEBUG_MESSAGE_LENGTH_KHR = 0x9143
        /// </summary>
        MaxDebugMessageLengthKhr = ((int)0x9143),
        /// <summary>
        /// Original was GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144
        /// </summary>
        MaxDebugLoggedMessages = ((int)0x9144),
        /// <summary>
        /// Original was GL_MAX_DEBUG_LOGGED_MESSAGES_KHR = 0x9144
        /// </summary>
        MaxDebugLoggedMessagesKhr = ((int)0x9144),
        /// <summary>
        /// Original was GL_DEBUG_LOGGED_MESSAGES = 0x9145
        /// </summary>
        DebugLoggedMessages = ((int)0x9145),
        /// <summary>
        /// Original was GL_DEBUG_LOGGED_MESSAGES_KHR = 0x9145
        /// </summary>
        DebugLoggedMessagesKhr = ((int)0x9145),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_HIGH = 0x9146
        /// </summary>
        DebugSeverityHigh = ((int)0x9146),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_HIGH_KHR = 0x9146
        /// </summary>
        DebugSeverityHighKhr = ((int)0x9146),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_MEDIUM = 0x9147
        /// </summary>
        DebugSeverityMedium = ((int)0x9147),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_MEDIUM_KHR = 0x9147
        /// </summary>
        DebugSeverityMediumKhr = ((int)0x9147),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_LOW = 0x9148
        /// </summary>
        DebugSeverityLow = ((int)0x9148),
        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_LOW_KHR = 0x9148
        /// </summary>
        DebugSeverityLowKhr = ((int)0x9148),
        /// <summary>
        /// Original was GL_DEBUG_OUTPUT = 0x92E0
        /// </summary>
        DebugOutput = ((int)0x92E0),
        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_KHR = 0x92E0
        /// </summary>
        DebugOutputKhr = ((int)0x92E0),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum LightEnvModeSgix : int
    {
        /// <summary>
        /// Original was GL_ADD = 0x0104
        /// </summary>
        Add = ((int)0x0104),
        /// <summary>
        /// Original was GL_REPLACE = 0x1E01
        /// </summary>
        Replace = ((int)0x1E01),
        /// <summary>
        /// Original was GL_MODULATE = 0x2100
        /// </summary>
        Modulate = ((int)0x2100),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum LightEnvParameterSgix : int
    {
        /// <summary>
        /// Original was GL_LIGHT_ENV_MODE_SGIX = 0x8407
        /// </summary>
        LightEnvModeSgix = ((int)0x8407),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum LightModelColorControl : int
    {
        /// <summary>
        /// Original was GL_SINGLE_COLOR = 0x81F9
        /// </summary>
        SingleColor = ((int)0x81F9),
        /// <summary>
        /// Original was GL_SINGLE_COLOR_EXT = 0x81F9
        /// </summary>
        SingleColorExt = ((int)0x81F9),
        /// <summary>
        /// Original was GL_SEPARATE_SPECULAR_COLOR = 0x81FA
        /// </summary>
        SeparateSpecularColor = ((int)0x81FA),
        /// <summary>
        /// Original was GL_SEPARATE_SPECULAR_COLOR_EXT = 0x81FA
        /// </summary>
        SeparateSpecularColorExt = ((int)0x81FA),
    }

    /// <summary>
    /// Used in GL.LightModel, GL.LightModelx and 1 other function
    /// </summary>
    public enum LightModelParameter : int
    {
        /// <summary>
        /// Original was GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51
        /// </summary>
        LightModelLocalViewer = ((int)0x0B51),
        /// <summary>
        /// Original was GL_LIGHT_MODEL_TWO_SIDE = 0x0B52
        /// </summary>
        LightModelTwoSide = ((int)0x0B52),
        /// <summary>
        /// Original was GL_LIGHT_MODEL_AMBIENT = 0x0B53
        /// </summary>
        LightModelAmbient = ((int)0x0B53),
        /// <summary>
        /// Original was GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8
        /// </summary>
        LightModelColorControl = ((int)0x81F8),
        /// <summary>
        /// Original was GL_LIGHT_MODEL_COLOR_CONTROL_EXT = 0x81F8
        /// </summary>
        LightModelColorControlExt = ((int)0x81F8),
    }

    /// <summary>
    /// Used in GL.GetLight, GL.GetLightx and 4 other functions
    /// </summary>
    public enum LightName : int
    {
        /// <summary>
        /// Original was GL_LIGHT0 = 0x4000
        /// </summary>
        Light0 = ((int)0x4000),
        /// <summary>
        /// Original was GL_LIGHT1 = 0x4001
        /// </summary>
        Light1 = ((int)0x4001),
        /// <summary>
        /// Original was GL_LIGHT2 = 0x4002
        /// </summary>
        Light2 = ((int)0x4002),
        /// <summary>
        /// Original was GL_LIGHT3 = 0x4003
        /// </summary>
        Light3 = ((int)0x4003),
        /// <summary>
        /// Original was GL_LIGHT4 = 0x4004
        /// </summary>
        Light4 = ((int)0x4004),
        /// <summary>
        /// Original was GL_LIGHT5 = 0x4005
        /// </summary>
        Light5 = ((int)0x4005),
        /// <summary>
        /// Original was GL_LIGHT6 = 0x4006
        /// </summary>
        Light6 = ((int)0x4006),
        /// <summary>
        /// Original was GL_LIGHT7 = 0x4007
        /// </summary>
        Light7 = ((int)0x4007),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT0_SGIX = 0x840C
        /// </summary>
        FragmentLight0Sgix = ((int)0x840C),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT1_SGIX = 0x840D
        /// </summary>
        FragmentLight1Sgix = ((int)0x840D),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT2_SGIX = 0x840E
        /// </summary>
        FragmentLight2Sgix = ((int)0x840E),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT3_SGIX = 0x840F
        /// </summary>
        FragmentLight3Sgix = ((int)0x840F),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT4_SGIX = 0x8410
        /// </summary>
        FragmentLight4Sgix = ((int)0x8410),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT5_SGIX = 0x8411
        /// </summary>
        FragmentLight5Sgix = ((int)0x8411),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT6_SGIX = 0x8412
        /// </summary>
        FragmentLight6Sgix = ((int)0x8412),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT7_SGIX = 0x8413
        /// </summary>
        FragmentLight7Sgix = ((int)0x8413),
    }

    /// <summary>
    /// Used in GL.GetLight, GL.GetLightx and 4 other functions
    /// </summary>
    public enum LightParameter : int
    {
        /// <summary>
        /// Original was GL_AMBIENT = 0x1200
        /// </summary>
        Ambient = ((int)0x1200),
        /// <summary>
        /// Original was GL_DIFFUSE = 0x1201
        /// </summary>
        Diffuse = ((int)0x1201),
        /// <summary>
        /// Original was GL_SPECULAR = 0x1202
        /// </summary>
        Specular = ((int)0x1202),
        /// <summary>
        /// Original was GL_POSITION = 0x1203
        /// </summary>
        Position = ((int)0x1203),
        /// <summary>
        /// Original was GL_SPOT_DIRECTION = 0x1204
        /// </summary>
        SpotDirection = ((int)0x1204),
        /// <summary>
        /// Original was GL_SPOT_EXPONENT = 0x1205
        /// </summary>
        SpotExponent = ((int)0x1205),
        /// <summary>
        /// Original was GL_SPOT_CUTOFF = 0x1206
        /// </summary>
        SpotCutoff = ((int)0x1206),
        /// <summary>
        /// Original was GL_CONSTANT_ATTENUATION = 0x1207
        /// </summary>
        ConstantAttenuation = ((int)0x1207),
        /// <summary>
        /// Original was GL_LINEAR_ATTENUATION = 0x1208
        /// </summary>
        LinearAttenuation = ((int)0x1208),
        /// <summary>
        /// Original was GL_QUADRATIC_ATTENUATION = 0x1209
        /// </summary>
        QuadraticAttenuation = ((int)0x1209),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ListMode : int
    {
        /// <summary>
        /// Original was GL_COMPILE = 0x1300
        /// </summary>
        Compile = ((int)0x1300),
        /// <summary>
        /// Original was GL_COMPILE_AND_EXECUTE = 0x1301
        /// </summary>
        CompileAndExecute = ((int)0x1301),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ListNameType : int
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = ((int)0x1400),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = ((int)0x1401),
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = ((int)0x1402),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = ((int)0x1403),
        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = ((int)0x1404),
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405),
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406),
        /// <summary>
        /// Original was GL_2_BYTES = 0x1407
        /// </summary>
        Gl2Bytes = ((int)0x1407),
        /// <summary>
        /// Original was GL_3_BYTES = 0x1408
        /// </summary>
        Gl3Bytes = ((int)0x1408),
        /// <summary>
        /// Original was GL_4_BYTES = 0x1409
        /// </summary>
        Gl4Bytes = ((int)0x1409),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ListParameterName : int
    {
        /// <summary>
        /// Original was GL_LIST_PRIORITY_SGIX = 0x8182
        /// </summary>
        ListPrioritySgix = ((int)0x8182),
    }

    /// <summary>
    /// Used in GL.LogicOp
    /// </summary>
    public enum LogicOp : int
    {
        /// <summary>
        /// Original was GL_CLEAR = 0x1500
        /// </summary>
        Clear = ((int)0x1500),
        /// <summary>
        /// Original was GL_AND = 0x1501
        /// </summary>
        And = ((int)0x1501),
        /// <summary>
        /// Original was GL_AND_REVERSE = 0x1502
        /// </summary>
        AndReverse = ((int)0x1502),
        /// <summary>
        /// Original was GL_COPY = 0x1503
        /// </summary>
        Copy = ((int)0x1503),
        /// <summary>
        /// Original was GL_AND_INVERTED = 0x1504
        /// </summary>
        AndInverted = ((int)0x1504),
        /// <summary>
        /// Original was GL_NOOP = 0x1505
        /// </summary>
        Noop = ((int)0x1505),
        /// <summary>
        /// Original was GL_XOR = 0x1506
        /// </summary>
        Xor = ((int)0x1506),
        /// <summary>
        /// Original was GL_OR = 0x1507
        /// </summary>
        Or = ((int)0x1507),
        /// <summary>
        /// Original was GL_NOR = 0x1508
        /// </summary>
        Nor = ((int)0x1508),
        /// <summary>
        /// Original was GL_EQUIV = 0x1509
        /// </summary>
        Equiv = ((int)0x1509),
        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = ((int)0x150A),
        /// <summary>
        /// Original was GL_OR_REVERSE = 0x150B
        /// </summary>
        OrReverse = ((int)0x150B),
        /// <summary>
        /// Original was GL_COPY_INVERTED = 0x150C
        /// </summary>
        CopyInverted = ((int)0x150C),
        /// <summary>
        /// Original was GL_OR_INVERTED = 0x150D
        /// </summary>
        OrInverted = ((int)0x150D),
        /// <summary>
        /// Original was GL_NAND = 0x150E
        /// </summary>
        Nand = ((int)0x150E),
        /// <summary>
        /// Original was GL_SET = 0x150F
        /// </summary>
        Set = ((int)0x150F),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum MapBufferUsageMask : int
    {
        /// <summary>
        /// Original was GL_MAP_READ_BIT = 0x0001
        /// </summary>
        MapReadBit = ((int)0x0001),
        /// <summary>
        /// Original was GL_MAP_READ_BIT_EXT = 0x0001
        /// </summary>
        MapReadBitExt = ((int)0x0001),
        /// <summary>
        /// Original was GL_MAP_WRITE_BIT = 0x0002
        /// </summary>
        MapWriteBit = ((int)0x0002),
        /// <summary>
        /// Original was GL_MAP_WRITE_BIT_EXT = 0x0002
        /// </summary>
        MapWriteBitExt = ((int)0x0002),
        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT = 0x0004
        /// </summary>
        MapInvalidateRangeBit = ((int)0x0004),
        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004
        /// </summary>
        MapInvalidateRangeBitExt = ((int)0x0004),
        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008
        /// </summary>
        MapInvalidateBufferBit = ((int)0x0008),
        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008
        /// </summary>
        MapInvalidateBufferBitExt = ((int)0x0008),
        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010
        /// </summary>
        MapFlushExplicitBit = ((int)0x0010),
        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010
        /// </summary>
        MapFlushExplicitBitExt = ((int)0x0010),
        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT = 0x0020
        /// </summary>
        MapUnsynchronizedBit = ((int)0x0020),
        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020
        /// </summary>
        MapUnsynchronizedBitExt = ((int)0x0020),
        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT = 0x0040
        /// </summary>
        MapPersistentBit = ((int)0x0040),
        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT_EXT = 0x0040
        /// </summary>
        MapPersistentBitExt = ((int)0x0040),
        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT = 0x0080
        /// </summary>
        MapCoherentBit = ((int)0x0080),
        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT_EXT = 0x0080
        /// </summary>
        MapCoherentBitExt = ((int)0x0080),
        /// <summary>
        /// Original was GL_DYNAMIC_STORAGE_BIT = 0x0100
        /// </summary>
        DynamicStorageBit = ((int)0x0100),
        /// <summary>
        /// Original was GL_DYNAMIC_STORAGE_BIT_EXT = 0x0100
        /// </summary>
        DynamicStorageBitExt = ((int)0x0100),
        /// <summary>
        /// Original was GL_CLIENT_STORAGE_BIT = 0x0200
        /// </summary>
        ClientStorageBit = ((int)0x0200),
        /// <summary>
        /// Original was GL_CLIENT_STORAGE_BIT_EXT = 0x0200
        /// </summary>
        ClientStorageBitExt = ((int)0x0200),
        /// <summary>
        /// Original was GL_SPARSE_STORAGE_BIT_ARB = 0x0400
        /// </summary>
        SparseStorageBitArb = ((int)0x0400),
        /// <summary>
        /// Original was GL_LGPU_SEPARATE_STORAGE_BIT_NVX = 0x0800
        /// </summary>
        LgpuSeparateStorageBitNvx = ((int)0x0800),
        /// <summary>
        /// Original was GL_PER_GPU_STORAGE_BIT_NV = 0x0800
        /// </summary>
        PerGpuStorageBitNv = ((int)0x0800),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MapQuery : int
    {
        /// <summary>
        /// Original was GL_COEFF = 0x0A00
        /// </summary>
        Coeff = ((int)0x0A00),
        /// <summary>
        /// Original was GL_ORDER = 0x0A01
        /// </summary>
        Order = ((int)0x0A01),
        /// <summary>
        /// Original was GL_DOMAIN = 0x0A02
        /// </summary>
        Domain = ((int)0x0A02),
    }

    /// <summary>
    /// Used in GL.Oes.GetMapx, GL.Oes.Map1x and 1 other function
    /// </summary>
    public enum MapTarget : int
    {
        /// <summary>
        /// Original was GL_MAP1_COLOR_4 = 0x0D90
        /// </summary>
        Map1Color4 = ((int)0x0D90),
        /// <summary>
        /// Original was GL_MAP1_INDEX = 0x0D91
        /// </summary>
        Map1Index = ((int)0x0D91),
        /// <summary>
        /// Original was GL_MAP1_NORMAL = 0x0D92
        /// </summary>
        Map1Normal = ((int)0x0D92),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_1 = 0x0D93
        /// </summary>
        Map1TextureCoord1 = ((int)0x0D93),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_2 = 0x0D94
        /// </summary>
        Map1TextureCoord2 = ((int)0x0D94),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_3 = 0x0D95
        /// </summary>
        Map1TextureCoord3 = ((int)0x0D95),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_4 = 0x0D96
        /// </summary>
        Map1TextureCoord4 = ((int)0x0D96),
        /// <summary>
        /// Original was GL_MAP1_VERTEX_3 = 0x0D97
        /// </summary>
        Map1Vertex3 = ((int)0x0D97),
        /// <summary>
        /// Original was GL_MAP1_VERTEX_4 = 0x0D98
        /// </summary>
        Map1Vertex4 = ((int)0x0D98),
        /// <summary>
        /// Original was GL_MAP2_COLOR_4 = 0x0DB0
        /// </summary>
        Map2Color4 = ((int)0x0DB0),
        /// <summary>
        /// Original was GL_MAP2_INDEX = 0x0DB1
        /// </summary>
        Map2Index = ((int)0x0DB1),
        /// <summary>
        /// Original was GL_MAP2_NORMAL = 0x0DB2
        /// </summary>
        Map2Normal = ((int)0x0DB2),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_1 = 0x0DB3
        /// </summary>
        Map2TextureCoord1 = ((int)0x0DB3),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_2 = 0x0DB4
        /// </summary>
        Map2TextureCoord2 = ((int)0x0DB4),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_3 = 0x0DB5
        /// </summary>
        Map2TextureCoord3 = ((int)0x0DB5),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_4 = 0x0DB6
        /// </summary>
        Map2TextureCoord4 = ((int)0x0DB6),
        /// <summary>
        /// Original was GL_MAP2_VERTEX_3 = 0x0DB7
        /// </summary>
        Map2Vertex3 = ((int)0x0DB7),
        /// <summary>
        /// Original was GL_MAP2_VERTEX_4 = 0x0DB8
        /// </summary>
        Map2Vertex4 = ((int)0x0DB8),
        /// <summary>
        /// Original was GL_GEOMETRY_DEFORMATION_SGIX = 0x8194
        /// </summary>
        GeometryDeformationSgix = ((int)0x8194),
        /// <summary>
        /// Original was GL_TEXTURE_DEFORMATION_SGIX = 0x8195
        /// </summary>
        TextureDeformationSgix = ((int)0x8195),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MapTextureFormatIntel : int
    {
        /// <summary>
        /// Original was GL_LAYOUT_DEFAULT_INTEL = 0
        /// </summary>
        LayoutDefaultIntel = ((int)0),
        /// <summary>
        /// Original was GL_LAYOUT_LINEAR_INTEL = 1
        /// </summary>
        LayoutLinearIntel = ((int)1),
        /// <summary>
        /// Original was GL_LAYOUT_LINEAR_CPU_CACHED_INTEL = 2
        /// </summary>
        LayoutLinearCpuCachedIntel = ((int)2),
    }

    /// <summary>
    /// Used in GL.GetMaterial, GL.GetMaterialx and 4 other functions
    /// </summary>
    public enum MaterialFace : int
    {
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = ((int)0x0404),
        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = ((int)0x0405),
        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = ((int)0x0408),
    }

    /// <summary>
    /// Used in GL.GetMaterial, GL.GetMaterialx and 4 other functions
    /// </summary>
    public enum MaterialParameter : int
    {
        /// <summary>
        /// Original was GL_AMBIENT = 0x1200
        /// </summary>
        Ambient = ((int)0x1200),
        /// <summary>
        /// Original was GL_DIFFUSE = 0x1201
        /// </summary>
        Diffuse = ((int)0x1201),
        /// <summary>
        /// Original was GL_SPECULAR = 0x1202
        /// </summary>
        Specular = ((int)0x1202),
        /// <summary>
        /// Original was GL_EMISSION = 0x1600
        /// </summary>
        Emission = ((int)0x1600),
        /// <summary>
        /// Original was GL_SHININESS = 0x1601
        /// </summary>
        Shininess = ((int)0x1601),
        /// <summary>
        /// Original was GL_AMBIENT_AND_DIFFUSE = 0x1602
        /// </summary>
        AmbientAndDiffuse = ((int)0x1602),
        /// <summary>
        /// Original was GL_COLOR_INDEXES = 0x1603
        /// </summary>
        ColorIndexes = ((int)0x1603),
    }

    /// <summary>
    /// Used in GL.MatrixMode
    /// </summary>
    public enum MatrixMode : int
    {
        /// <summary>
        /// Original was GL_MODELVIEW = 0x1700
        /// </summary>
        Modelview = ((int)0x1700),
        /// <summary>
        /// Original was GL_MODELVIEW0_EXT = 0x1700
        /// </summary>
        Modelview0Ext = ((int)0x1700),
        /// <summary>
        /// Original was GL_PROJECTION = 0x1701
        /// </summary>
        Projection = ((int)0x1701),
        /// <summary>
        /// Original was GL_TEXTURE = 0x1702
        /// </summary>
        Texture = ((int)0x1702),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum MemoryBarrierMask : int
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
        AllBarrierBits = unchecked((int)0xFFFFFFFF),
        /// <summary>
        /// Original was GL_ALL_BARRIER_BITS_EXT = 0xFFFFFFFF
        /// </summary>
        AllBarrierBitsExt = unchecked((int)0xFFFFFFFF),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MemoryObjectParameterName : int
    {
        /// <summary>
        /// Original was GL_DEDICATED_MEMORY_OBJECT_EXT = 0x9581
        /// </summary>
        DedicatedMemoryObjectExt = ((int)0x9581),
        /// <summary>
        /// Original was GL_PROTECTED_MEMORY_OBJECT_EXT = 0x959B
        /// </summary>
        ProtectedMemoryObjectExt = ((int)0x959B),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MeshMode1 : int
    {
        /// <summary>
        /// Original was GL_POINT = 0x1B00
        /// </summary>
        Point = ((int)0x1B00),
        /// <summary>
        /// Original was GL_LINE = 0x1B01
        /// </summary>
        Line = ((int)0x1B01),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MeshMode2 : int
    {
        /// <summary>
        /// Original was GL_POINT = 0x1B00
        /// </summary>
        Point = ((int)0x1B00),
        /// <summary>
        /// Original was GL_LINE = 0x1B01
        /// </summary>
        Line = ((int)0x1B01),
        /// <summary>
        /// Original was GL_FILL = 0x1B02
        /// </summary>
        Fill = ((int)0x1B02),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MinmaxTargetExt : int
    {
        /// <summary>
        /// Original was GL_MINMAX = 0x802E
        /// </summary>
        Minmax = ((int)0x802E),
        /// <summary>
        /// Original was GL_MINMAX_EXT = 0x802E
        /// </summary>
        MinmaxExt = ((int)0x802E),
    }

    /// <summary>
    /// Used in GL.NormalPointer
    /// </summary>
    public enum NormalPointerType : int
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = ((int)0x1400),
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = ((int)0x1402),
        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = ((int)0x1404),
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406),
        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = ((int)0x140A),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum Nvfence : int
    {
        /// <summary>
        /// Original was GL_ALL_COMPLETED_NV = 0x84F2
        /// </summary>
        AllCompletedNv = ((int)0x84F2),
        /// <summary>
        /// Original was GL_FENCE_STATUS_NV = 0x84F3
        /// </summary>
        FenceStatusNv = ((int)0x84F3),
        /// <summary>
        /// Original was GL_FENCE_CONDITION_NV = 0x84F4
        /// </summary>
        FenceConditionNv = ((int)0x84F4),
        /// <summary>
        /// Original was GL_NV_fence = 1
        /// </summary>
        NvFence = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum NvFence : int
    {
        /// <summary>
        /// Original was GL_ALL_COMPLETED_NV = 0x84F2
        /// </summary>
        AllCompletedNv = ((int)0x84F2),
        /// <summary>
        /// Original was GL_FENCE_STATUS_NV = 0x84F3
        /// </summary>
        FenceStatusNv = ((int)0x84F3),
        /// <summary>
        /// Original was GL_FENCE_CONDITION_NV = 0x84F4
        /// </summary>
        FenceConditionNv = ((int)0x84F4),
    }

    /// <summary>
    /// Used in GL.ObjectLabel, GL.Khr.ObjectLabel
    /// </summary>
    public enum ObjectIdentifier : int
    {
        /// <summary>
        /// Original was GL_TEXTURE = 0x1702
        /// </summary>
        Texture = ((int)0x1702),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = ((int)0x8074),
        /// <summary>
        /// Original was GL_BUFFER = 0x82E0
        /// </summary>
        Buffer = ((int)0x82E0),
        /// <summary>
        /// Original was GL_SHADER = 0x82E1
        /// </summary>
        Shader = ((int)0x82E1),
        /// <summary>
        /// Original was GL_PROGRAM = 0x82E2
        /// </summary>
        Program = ((int)0x82E2),
        /// <summary>
        /// Original was GL_QUERY = 0x82E3
        /// </summary>
        Query = ((int)0x82E3),
        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE = 0x82E4
        /// </summary>
        ProgramPipeline = ((int)0x82E4),
        /// <summary>
        /// Original was GL_SAMPLER = 0x82E6
        /// </summary>
        Sampler = ((int)0x82E6),
        /// <summary>
        /// Original was GL_FRAMEBUFFER = 0x8D40
        /// </summary>
        Framebuffer = ((int)0x8D40),
        /// <summary>
        /// Original was GL_RENDERBUFFER = 0x8D41
        /// </summary>
        Renderbuffer = ((int)0x8D41),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK = 0x8E22
        /// </summary>
        TransformFeedback = ((int)0x8E22),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum OcclusionQueryEventMaskAmd : int
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
        QueryAllEventBitsAmd = unchecked((int)0xFFFFFFFF),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OesblendEquationSeparate : int
    {
        /// <summary>
        /// Original was GL_BLEND_EQUATION_RGB_OES = 0x8009
        /// </summary>
        BlendEquationRgbOes = ((int)0x8009),
        /// <summary>
        /// Original was GL_BLEND_EQUATION_ALPHA_OES = 0x883D
        /// </summary>
        BlendEquationAlphaOes = ((int)0x883D),
        /// <summary>
        /// Original was GL_OES_blend_equation_separate = 1
        /// </summary>
        OesBlendEquationSeparate = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesBlendEquationSeparate : int
    {
        /// <summary>
        /// Original was GL_BLEND_EQUATION_RGB_OES = 0x8009
        /// </summary>
        BlendEquationRgbOes = ((int)0x8009),
        /// <summary>
        /// Original was GL_BLEND_EQUATION_ALPHA_OES = 0x883D
        /// </summary>
        BlendEquationAlphaOes = ((int)0x883D),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OesblendFuncSeparate : int
    {
        /// <summary>
        /// Original was GL_BLEND_DST_RGB_OES = 0x80C8
        /// </summary>
        BlendDstRgbOes = ((int)0x80C8),
        /// <summary>
        /// Original was GL_BLEND_SRC_RGB_OES = 0x80C9
        /// </summary>
        BlendSrcRgbOes = ((int)0x80C9),
        /// <summary>
        /// Original was GL_BLEND_DST_ALPHA_OES = 0x80CA
        /// </summary>
        BlendDstAlphaOes = ((int)0x80CA),
        /// <summary>
        /// Original was GL_BLEND_SRC_ALPHA_OES = 0x80CB
        /// </summary>
        BlendSrcAlphaOes = ((int)0x80CB),
        /// <summary>
        /// Original was GL_OES_blend_func_separate = 1
        /// </summary>
        OesBlendFuncSeparate = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesBlendFuncSeparate : int
    {
        /// <summary>
        /// Original was GL_BLEND_DST_RGB_OES = 0x80C8
        /// </summary>
        BlendDstRgbOes = ((int)0x80C8),
        /// <summary>
        /// Original was GL_BLEND_SRC_RGB_OES = 0x80C9
        /// </summary>
        BlendSrcRgbOes = ((int)0x80C9),
        /// <summary>
        /// Original was GL_BLEND_DST_ALPHA_OES = 0x80CA
        /// </summary>
        BlendDstAlphaOes = ((int)0x80CA),
        /// <summary>
        /// Original was GL_BLEND_SRC_ALPHA_OES = 0x80CB
        /// </summary>
        BlendSrcAlphaOes = ((int)0x80CB),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OesblendSubtract : int
    {
        /// <summary>
        /// Original was GL_FUNC_ADD_OES = 0x8006
        /// </summary>
        FuncAddOes = ((int)0x8006),
        /// <summary>
        /// Original was GL_BLEND_EQUATION_OES = 0x8009
        /// </summary>
        BlendEquationOes = ((int)0x8009),
        /// <summary>
        /// Original was GL_FUNC_SUBTRACT_OES = 0x800A
        /// </summary>
        FuncSubtractOes = ((int)0x800A),
        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT_OES = 0x800B
        /// </summary>
        FuncReverseSubtractOes = ((int)0x800B),
        /// <summary>
        /// Original was GL_OES_blend_subtract = 1
        /// </summary>
        OesBlendSubtract = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesBlendSubtract : int
    {
        /// <summary>
        /// Original was GL_FUNC_ADD_OES = 0x8006
        /// </summary>
        FuncAddOes = ((int)0x8006),
        /// <summary>
        /// Original was GL_BLEND_EQUATION_OES = 0x8009
        /// </summary>
        BlendEquationOes = ((int)0x8009),
        /// <summary>
        /// Original was GL_FUNC_SUBTRACT_OES = 0x800A
        /// </summary>
        FuncSubtractOes = ((int)0x800A),
        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT_OES = 0x800B
        /// </summary>
        FuncReverseSubtractOes = ((int)0x800B),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OesbyteCoordinates : int
    {
        /// <summary>
        /// Original was GL_OES_byte_coordinates = 1
        /// </summary>
        OesByteCoordinates = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesByteCoordinates : int
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = ((int)0x1400),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesCompressedEtc1Rgb8SubTexture : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OescompressedEtc1Rgb8Texture : int
    {
        /// <summary>
        /// Original was GL_ETC1_RGB8_OES = 0x8D64
        /// </summary>
        Etc1Rgb8Oes = ((int)0x8D64),
        /// <summary>
        /// Original was GL_OES_compressed_ETC1_RGB8_texture = 1
        /// </summary>
        OesCompressedEtc1Rgb8Texture = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesCompressedEtc1Rgb8Texture : int
    {
        /// <summary>
        /// Original was GL_ETC1_RGB8_OES = 0x8D64
        /// </summary>
        Etc1Rgb8Oes = ((int)0x8D64),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OescompressedPalettedTexture : int
    {
        /// <summary>
        /// Original was GL_PALETTE4_RGB8_OES = 0x8B90
        /// </summary>
        Palette4Rgb8Oes = ((int)0x8B90),
        /// <summary>
        /// Original was GL_PALETTE4_RGBA8_OES = 0x8B91
        /// </summary>
        Palette4Rgba8Oes = ((int)0x8B91),
        /// <summary>
        /// Original was GL_PALETTE4_R5_G6_B5_OES = 0x8B92
        /// </summary>
        Palette4R5G6B5Oes = ((int)0x8B92),
        /// <summary>
        /// Original was GL_PALETTE4_RGBA4_OES = 0x8B93
        /// </summary>
        Palette4Rgba4Oes = ((int)0x8B93),
        /// <summary>
        /// Original was GL_PALETTE4_RGB5_A1_OES = 0x8B94
        /// </summary>
        Palette4Rgb5A1Oes = ((int)0x8B94),
        /// <summary>
        /// Original was GL_PALETTE8_RGB8_OES = 0x8B95
        /// </summary>
        Palette8Rgb8Oes = ((int)0x8B95),
        /// <summary>
        /// Original was GL_PALETTE8_RGBA8_OES = 0x8B96
        /// </summary>
        Palette8Rgba8Oes = ((int)0x8B96),
        /// <summary>
        /// Original was GL_PALETTE8_R5_G6_B5_OES = 0x8B97
        /// </summary>
        Palette8R5G6B5Oes = ((int)0x8B97),
        /// <summary>
        /// Original was GL_PALETTE8_RGBA4_OES = 0x8B98
        /// </summary>
        Palette8Rgba4Oes = ((int)0x8B98),
        /// <summary>
        /// Original was GL_PALETTE8_RGB5_A1_OES = 0x8B99
        /// </summary>
        Palette8Rgb5A1Oes = ((int)0x8B99),
        /// <summary>
        /// Original was GL_OES_compressed_paletted_texture = 1
        /// </summary>
        OesCompressedPalettedTexture = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesCompressedPalettedTexture : int
    {
        /// <summary>
        /// Original was GL_PALETTE4_RGB8_OES = 0x8B90
        /// </summary>
        Palette4Rgb8Oes = ((int)0x8B90),
        /// <summary>
        /// Original was GL_PALETTE4_RGBA8_OES = 0x8B91
        /// </summary>
        Palette4Rgba8Oes = ((int)0x8B91),
        /// <summary>
        /// Original was GL_PALETTE4_R5_G6_B5_OES = 0x8B92
        /// </summary>
        Palette4R5G6B5Oes = ((int)0x8B92),
        /// <summary>
        /// Original was GL_PALETTE4_RGBA4_OES = 0x8B93
        /// </summary>
        Palette4Rgba4Oes = ((int)0x8B93),
        /// <summary>
        /// Original was GL_PALETTE4_RGB5_A1_OES = 0x8B94
        /// </summary>
        Palette4Rgb5A1Oes = ((int)0x8B94),
        /// <summary>
        /// Original was GL_PALETTE8_RGB8_OES = 0x8B95
        /// </summary>
        Palette8Rgb8Oes = ((int)0x8B95),
        /// <summary>
        /// Original was GL_PALETTE8_RGBA8_OES = 0x8B96
        /// </summary>
        Palette8Rgba8Oes = ((int)0x8B96),
        /// <summary>
        /// Original was GL_PALETTE8_R5_G6_B5_OES = 0x8B97
        /// </summary>
        Palette8R5G6B5Oes = ((int)0x8B97),
        /// <summary>
        /// Original was GL_PALETTE8_RGBA4_OES = 0x8B98
        /// </summary>
        Palette8Rgba4Oes = ((int)0x8B98),
        /// <summary>
        /// Original was GL_PALETTE8_RGB5_A1_OES = 0x8B99
        /// </summary>
        Palette8Rgb5A1Oes = ((int)0x8B99),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum Oesdepth24 : int
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_OES = 0x81A6
        /// </summary>
        DepthComponent24Oes = ((int)0x81A6),
        /// <summary>
        /// Original was GL_OES_depth24 = 1
        /// </summary>
        OesDepth24 = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesDepth24 : int
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_OES = 0x81A6
        /// </summary>
        DepthComponent24Oes = ((int)0x81A6),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum Oesdepth32 : int
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        /// </summary>
        DepthComponent32Oes = ((int)0x81A7),
        /// <summary>
        /// Original was GL_OES_depth32 = 1
        /// </summary>
        OesDepth32 = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesDepth32 : int
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        /// </summary>
        DepthComponent32Oes = ((int)0x81A7),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OesdrawTexture : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_CROP_RECT_OES = 0x8B9D
        /// </summary>
        TextureCropRectOes = ((int)0x8B9D),
        /// <summary>
        /// Original was GL_OES_draw_texture = 1
        /// </summary>
        OesDrawTexture = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesDrawTexture : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_CROP_RECT_OES = 0x8B9D
        /// </summary>
        TextureCropRectOes = ((int)0x8B9D),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum Oeseglimage : int
    {
        /// <summary>
        /// Original was GL_OES_EGL_image = 1
        /// </summary>
        OesEglImage = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesEglImage : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesEglImageExternal : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_EXTERNAL_OES = 0x8D65
        /// </summary>
        TextureExternalOes = ((int)0x8D65),
        /// <summary>
        /// Original was GL_SAMPLER_EXTERNAL_OES = 0x8D66
        /// </summary>
        SamplerExternalOes = ((int)0x8D66),
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_EXTERNAL_OES = 0x8D67
        /// </summary>
        TextureBindingExternalOes = ((int)0x8D67),
        /// <summary>
        /// Original was GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES = 0x8D68
        /// </summary>
        RequiredTextureImageUnitsOes = ((int)0x8D68),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OeselementIndexUint : int
    {
        /// <summary>
        /// Original was GL_OES_element_index_uint = 1
        /// </summary>
        OesElementIndexUint = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesElementIndexUint : int
    {
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OesextendedMatrixPalette : int
    {
        /// <summary>
        /// Original was GL_OES_extended_matrix_palette = 1
        /// </summary>
        OesExtendedMatrixPalette = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesExtendedMatrixPalette : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OesfboRenderMipmap : int
    {
        /// <summary>
        /// Original was GL_OES_fbo_render_mipmap = 1
        /// </summary>
        OesFboRenderMipmap = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesFboRenderMipmap : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OesfixedPoint : int
    {
        /// <summary>
        /// Original was GL_FIXED_OES = 0x140C
        /// </summary>
        FixedOes = ((int)0x140C),
        /// <summary>
        /// Original was GL_OES_fixed_point = 1
        /// </summary>
        OesFixedPoint = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesFixedPoint : int
    {
        /// <summary>
        /// Original was GL_FIXED_OES = 0x140C
        /// </summary>
        FixedOes = ((int)0x140C),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OesframebufferObject : int
    {
        /// <summary>
        /// Original was GL_NONE_OES = 0
        /// </summary>
        NoneOes = ((int)0),
        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506
        /// </summary>
        InvalidFramebufferOperationOes = ((int)0x0506),
        /// <summary>
        /// Original was GL_RGBA4_OES = 0x8056
        /// </summary>
        Rgba4Oes = ((int)0x8056),
        /// <summary>
        /// Original was GL_RGB5_A1_OES = 0x8057
        /// </summary>
        Rgb5A1Oes = ((int)0x8057),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_OES = 0x81A5
        /// </summary>
        DepthComponent16Oes = ((int)0x81A5),
        /// <summary>
        /// Original was GL_MAX_RENDERBUFFER_SIZE_OES = 0x84E8
        /// </summary>
        MaxRenderbufferSizeOes = ((int)0x84E8),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_BINDING_OES = 0x8CA6
        /// </summary>
        FramebufferBindingOes = ((int)0x8CA6),
        /// <summary>
        /// Original was GL_RENDERBUFFER_BINDING_OES = 0x8CA7
        /// </summary>
        RenderbufferBindingOes = ((int)0x8CA7),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES = 0x8CD0
        /// </summary>
        FramebufferAttachmentObjectTypeOes = ((int)0x8CD0),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectNameOes = ((int)0x8CD1),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevelOes = ((int)0x8CD2),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFaceOes = ((int)0x8CD3),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE_OES = 0x8CD5
        /// </summary>
        FramebufferCompleteOes = ((int)0x8CD5),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachmentOes = ((int)0x8CD6),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachmentOes = ((int)0x8CD7),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES = 0x8CD9
        /// </summary>
        FramebufferIncompleteDimensionsOes = ((int)0x8CD9),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES = 0x8CDA
        /// </summary>
        FramebufferIncompleteFormatsOes = ((int)0x8CDA),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED_OES = 0x8CDD
        /// </summary>
        FramebufferUnsupportedOes = ((int)0x8CDD),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_OES = 0x8CE0
        /// </summary>
        ColorAttachment0Oes = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_OES = 0x8D00
        /// </summary>
        DepthAttachmentOes = ((int)0x8D00),
        /// <summary>
        /// Original was GL_STENCIL_ATTACHMENT_OES = 0x8D20
        /// </summary>
        StencilAttachmentOes = ((int)0x8D20),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_OES = 0x8D40
        /// </summary>
        FramebufferOes = ((int)0x8D40),
        /// <summary>
        /// Original was GL_RENDERBUFFER_OES = 0x8D41
        /// </summary>
        RenderbufferOes = ((int)0x8D41),
        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH_OES = 0x8D42
        /// </summary>
        RenderbufferWidthOes = ((int)0x8D42),
        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT_OES = 0x8D43
        /// </summary>
        RenderbufferHeightOes = ((int)0x8D43),
        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT_OES = 0x8D44
        /// </summary>
        RenderbufferInternalFormatOes = ((int)0x8D44),
        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE_OES = 0x8D50
        /// </summary>
        RenderbufferRedSizeOes = ((int)0x8D50),
        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE_OES = 0x8D51
        /// </summary>
        RenderbufferGreenSizeOes = ((int)0x8D51),
        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE_OES = 0x8D52
        /// </summary>
        RenderbufferBlueSizeOes = ((int)0x8D52),
        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE_OES = 0x8D53
        /// </summary>
        RenderbufferAlphaSizeOes = ((int)0x8D53),
        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE_OES = 0x8D54
        /// </summary>
        RenderbufferDepthSizeOes = ((int)0x8D54),
        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE_OES = 0x8D55
        /// </summary>
        RenderbufferStencilSizeOes = ((int)0x8D55),
        /// <summary>
        /// Original was GL_RGB565_OES = 0x8D62
        /// </summary>
        Rgb565Oes = ((int)0x8D62),
        /// <summary>
        /// Original was GL_OES_framebuffer_object = 1
        /// </summary>
        OesFramebufferObject = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesFramebufferObject : int
    {
        /// <summary>
        /// Original was GL_NONE_OES = 0
        /// </summary>
        NoneOes = ((int)0),
        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506
        /// </summary>
        InvalidFramebufferOperationOes = ((int)0x0506),
        /// <summary>
        /// Original was GL_RGBA4_OES = 0x8056
        /// </summary>
        Rgba4Oes = ((int)0x8056),
        /// <summary>
        /// Original was GL_RGB5_A1_OES = 0x8057
        /// </summary>
        Rgb5A1Oes = ((int)0x8057),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_OES = 0x81A5
        /// </summary>
        DepthComponent16Oes = ((int)0x81A5),
        /// <summary>
        /// Original was GL_MAX_RENDERBUFFER_SIZE_OES = 0x84E8
        /// </summary>
        MaxRenderbufferSizeOes = ((int)0x84E8),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_BINDING_OES = 0x8CA6
        /// </summary>
        FramebufferBindingOes = ((int)0x8CA6),
        /// <summary>
        /// Original was GL_RENDERBUFFER_BINDING_OES = 0x8CA7
        /// </summary>
        RenderbufferBindingOes = ((int)0x8CA7),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES = 0x8CD0
        /// </summary>
        FramebufferAttachmentObjectTypeOes = ((int)0x8CD0),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectNameOes = ((int)0x8CD1),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevelOes = ((int)0x8CD2),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFaceOes = ((int)0x8CD3),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE_OES = 0x8CD5
        /// </summary>
        FramebufferCompleteOes = ((int)0x8CD5),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachmentOes = ((int)0x8CD6),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachmentOes = ((int)0x8CD7),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES = 0x8CD9
        /// </summary>
        FramebufferIncompleteDimensionsOes = ((int)0x8CD9),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES = 0x8CDA
        /// </summary>
        FramebufferIncompleteFormatsOes = ((int)0x8CDA),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED_OES = 0x8CDD
        /// </summary>
        FramebufferUnsupportedOes = ((int)0x8CDD),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_OES = 0x8CE0
        /// </summary>
        ColorAttachment0Oes = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_OES = 0x8D00
        /// </summary>
        DepthAttachmentOes = ((int)0x8D00),
        /// <summary>
        /// Original was GL_STENCIL_ATTACHMENT_OES = 0x8D20
        /// </summary>
        StencilAttachmentOes = ((int)0x8D20),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_OES = 0x8D40
        /// </summary>
        FramebufferOes = ((int)0x8D40),
        /// <summary>
        /// Original was GL_RENDERBUFFER_OES = 0x8D41
        /// </summary>
        RenderbufferOes = ((int)0x8D41),
        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH_OES = 0x8D42
        /// </summary>
        RenderbufferWidthOes = ((int)0x8D42),
        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT_OES = 0x8D43
        /// </summary>
        RenderbufferHeightOes = ((int)0x8D43),
        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT_OES = 0x8D44
        /// </summary>
        RenderbufferInternalFormatOes = ((int)0x8D44),
        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE_OES = 0x8D50
        /// </summary>
        RenderbufferRedSizeOes = ((int)0x8D50),
        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE_OES = 0x8D51
        /// </summary>
        RenderbufferGreenSizeOes = ((int)0x8D51),
        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE_OES = 0x8D52
        /// </summary>
        RenderbufferBlueSizeOes = ((int)0x8D52),
        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE_OES = 0x8D53
        /// </summary>
        RenderbufferAlphaSizeOes = ((int)0x8D53),
        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE_OES = 0x8D54
        /// </summary>
        RenderbufferDepthSizeOes = ((int)0x8D54),
        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE_OES = 0x8D55
        /// </summary>
        RenderbufferStencilSizeOes = ((int)0x8D55),
        /// <summary>
        /// Original was GL_RGB565_OES = 0x8D62
        /// </summary>
        Rgb565Oes = ((int)0x8D62),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum Oesmapbuffer : int
    {
        /// <summary>
        /// Original was GL_WRITE_ONLY_OES = 0x88B9
        /// </summary>
        WriteOnlyOes = ((int)0x88B9),
        /// <summary>
        /// Original was GL_BUFFER_ACCESS_OES = 0x88BB
        /// </summary>
        BufferAccessOes = ((int)0x88BB),
        /// <summary>
        /// Original was GL_BUFFER_MAPPED_OES = 0x88BC
        /// </summary>
        BufferMappedOes = ((int)0x88BC),
        /// <summary>
        /// Original was GL_BUFFER_MAP_POINTER_OES = 0x88BD
        /// </summary>
        BufferMapPointerOes = ((int)0x88BD),
        /// <summary>
        /// Original was GL_OES_mapbuffer = 1
        /// </summary>
        OesMapbuffer = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesMapbuffer : int
    {
        /// <summary>
        /// Original was GL_WRITE_ONLY_OES = 0x88B9
        /// </summary>
        WriteOnlyOes = ((int)0x88B9),
        /// <summary>
        /// Original was GL_BUFFER_ACCESS_OES = 0x88BB
        /// </summary>
        BufferAccessOes = ((int)0x88BB),
        /// <summary>
        /// Original was GL_BUFFER_MAPPED_OES = 0x88BC
        /// </summary>
        BufferMappedOes = ((int)0x88BC),
        /// <summary>
        /// Original was GL_BUFFER_MAP_POINTER_OES = 0x88BD
        /// </summary>
        BufferMapPointerOes = ((int)0x88BD),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OesmatrixGet : int
    {
        /// <summary>
        /// Original was GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898D
        /// </summary>
        ModelviewMatrixFloatAsIntBitsOes = ((int)0x898D),
        /// <summary>
        /// Original was GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898E
        /// </summary>
        ProjectionMatrixFloatAsIntBitsOes = ((int)0x898E),
        /// <summary>
        /// Original was GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898F
        /// </summary>
        TextureMatrixFloatAsIntBitsOes = ((int)0x898F),
        /// <summary>
        /// Original was GL_OES_matrix_get = 1
        /// </summary>
        OesMatrixGet = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesMatrixGet : int
    {
        /// <summary>
        /// Original was GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898D
        /// </summary>
        ModelviewMatrixFloatAsIntBitsOes = ((int)0x898D),
        /// <summary>
        /// Original was GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898E
        /// </summary>
        ProjectionMatrixFloatAsIntBitsOes = ((int)0x898E),
        /// <summary>
        /// Original was GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898F
        /// </summary>
        TextureMatrixFloatAsIntBitsOes = ((int)0x898F),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OesmatrixPalette : int
    {
        /// <summary>
        /// Original was GL_MAX_VERTEX_UNITS_OES = 0x86A4
        /// </summary>
        MaxVertexUnitsOes = ((int)0x86A4),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_TYPE_OES = 0x86A9
        /// </summary>
        WeightArrayTypeOes = ((int)0x86A9),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_STRIDE_OES = 0x86AA
        /// </summary>
        WeightArrayStrideOes = ((int)0x86AA),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_SIZE_OES = 0x86AB
        /// </summary>
        WeightArraySizeOes = ((int)0x86AB),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_POINTER_OES = 0x86AC
        /// </summary>
        WeightArrayPointerOes = ((int)0x86AC),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_OES = 0x86AD
        /// </summary>
        WeightArrayOes = ((int)0x86AD),
        /// <summary>
        /// Original was GL_MATRIX_PALETTE_OES = 0x8840
        /// </summary>
        MatrixPaletteOes = ((int)0x8840),
        /// <summary>
        /// Original was GL_MAX_PALETTE_MATRICES_OES = 0x8842
        /// </summary>
        MaxPaletteMatricesOes = ((int)0x8842),
        /// <summary>
        /// Original was GL_CURRENT_PALETTE_MATRIX_OES = 0x8843
        /// </summary>
        CurrentPaletteMatrixOes = ((int)0x8843),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_OES = 0x8844
        /// </summary>
        MatrixIndexArrayOes = ((int)0x8844),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_SIZE_OES = 0x8846
        /// </summary>
        MatrixIndexArraySizeOes = ((int)0x8846),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_TYPE_OES = 0x8847
        /// </summary>
        MatrixIndexArrayTypeOes = ((int)0x8847),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_STRIDE_OES = 0x8848
        /// </summary>
        MatrixIndexArrayStrideOes = ((int)0x8848),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_POINTER_OES = 0x8849
        /// </summary>
        MatrixIndexArrayPointerOes = ((int)0x8849),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_BUFFER_BINDING_OES = 0x889E
        /// </summary>
        WeightArrayBufferBindingOes = ((int)0x889E),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES = 0x8B9E
        /// </summary>
        MatrixIndexArrayBufferBindingOes = ((int)0x8B9E),
        /// <summary>
        /// Original was GL_OES_matrix_palette = 1
        /// </summary>
        OesMatrixPalette = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesMatrixPalette : int
    {
        /// <summary>
        /// Original was GL_MAX_VERTEX_UNITS_OES = 0x86A4
        /// </summary>
        MaxVertexUnitsOes = ((int)0x86A4),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_TYPE_OES = 0x86A9
        /// </summary>
        WeightArrayTypeOes = ((int)0x86A9),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_STRIDE_OES = 0x86AA
        /// </summary>
        WeightArrayStrideOes = ((int)0x86AA),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_SIZE_OES = 0x86AB
        /// </summary>
        WeightArraySizeOes = ((int)0x86AB),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_POINTER_OES = 0x86AC
        /// </summary>
        WeightArrayPointerOes = ((int)0x86AC),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_OES = 0x86AD
        /// </summary>
        WeightArrayOes = ((int)0x86AD),
        /// <summary>
        /// Original was GL_MATRIX_PALETTE_OES = 0x8840
        /// </summary>
        MatrixPaletteOes = ((int)0x8840),
        /// <summary>
        /// Original was GL_MAX_PALETTE_MATRICES_OES = 0x8842
        /// </summary>
        MaxPaletteMatricesOes = ((int)0x8842),
        /// <summary>
        /// Original was GL_CURRENT_PALETTE_MATRIX_OES = 0x8843
        /// </summary>
        CurrentPaletteMatrixOes = ((int)0x8843),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_OES = 0x8844
        /// </summary>
        MatrixIndexArrayOes = ((int)0x8844),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_SIZE_OES = 0x8846
        /// </summary>
        MatrixIndexArraySizeOes = ((int)0x8846),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_TYPE_OES = 0x8847
        /// </summary>
        MatrixIndexArrayTypeOes = ((int)0x8847),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_STRIDE_OES = 0x8848
        /// </summary>
        MatrixIndexArrayStrideOes = ((int)0x8848),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_POINTER_OES = 0x8849
        /// </summary>
        MatrixIndexArrayPointerOes = ((int)0x8849),
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_BUFFER_BINDING_OES = 0x889E
        /// </summary>
        WeightArrayBufferBindingOes = ((int)0x889E),
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES = 0x8B9E
        /// </summary>
        MatrixIndexArrayBufferBindingOes = ((int)0x8B9E),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OespackedDepthStencil : int
    {
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_OES = 0x84F9
        /// </summary>
        DepthStencilOes = ((int)0x84F9),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_24_8_OES = 0x84FA
        /// </summary>
        UnsignedInt248Oes = ((int)0x84FA),
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        /// </summary>
        Depth24Stencil8Oes = ((int)0x88F0),
        /// <summary>
        /// Original was GL_OES_packed_depth_stencil = 1
        /// </summary>
        OesPackedDepthStencil = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesPackedDepthStencil : int
    {
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_OES = 0x84F9
        /// </summary>
        DepthStencilOes = ((int)0x84F9),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_24_8_OES = 0x84FA
        /// </summary>
        UnsignedInt248Oes = ((int)0x84FA),
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        /// </summary>
        Depth24Stencil8Oes = ((int)0x88F0),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OespointSizeArray : int
    {
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_TYPE_OES = 0x898A
        /// </summary>
        PointSizeArrayTypeOes = ((int)0x898A),
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_STRIDE_OES = 0x898B
        /// </summary>
        PointSizeArrayStrideOes = ((int)0x898B),
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_POINTER_OES = 0x898C
        /// </summary>
        PointSizeArrayPointerOes = ((int)0x898C),
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_OES = 0x8B9C
        /// </summary>
        PointSizeArrayOes = ((int)0x8B9C),
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES = 0x8B9F
        /// </summary>
        PointSizeArrayBufferBindingOes = ((int)0x8B9F),
        /// <summary>
        /// Original was GL_OES_point_size_array = 1
        /// </summary>
        OesPointSizeArray = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesPointSizeArray : int
    {
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_TYPE_OES = 0x898A
        /// </summary>
        PointSizeArrayTypeOes = ((int)0x898A),
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_STRIDE_OES = 0x898B
        /// </summary>
        PointSizeArrayStrideOes = ((int)0x898B),
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_POINTER_OES = 0x898C
        /// </summary>
        PointSizeArrayPointerOes = ((int)0x898C),
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_OES = 0x8B9C
        /// </summary>
        PointSizeArrayOes = ((int)0x8B9C),
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES = 0x8B9F
        /// </summary>
        PointSizeArrayBufferBindingOes = ((int)0x8B9F),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OespointSprite : int
    {
        /// <summary>
        /// Original was GL_POINT_SPRITE_OES = 0x8861
        /// </summary>
        PointSpriteOes = ((int)0x8861),
        /// <summary>
        /// Original was GL_COORD_REPLACE_OES = 0x8862
        /// </summary>
        CoordReplaceOes = ((int)0x8862),
        /// <summary>
        /// Original was GL_OES_point_sprite = 1
        /// </summary>
        OesPointSprite = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesPointSprite : int
    {
        /// <summary>
        /// Original was GL_POINT_SPRITE_OES = 0x8861
        /// </summary>
        PointSpriteOes = ((int)0x8861),
        /// <summary>
        /// Original was GL_COORD_REPLACE_OES = 0x8862
        /// </summary>
        CoordReplaceOes = ((int)0x8862),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OesqueryMatrix : int
    {
        /// <summary>
        /// Original was GL_OES_query_matrix = 1
        /// </summary>
        OesQueryMatrix = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesQueryMatrix : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OesreadFormat : int
    {
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_TYPE_OES = 0x8B9A
        /// </summary>
        ImplementationColorReadTypeOes = ((int)0x8B9A),
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES = 0x8B9B
        /// </summary>
        ImplementationColorReadFormatOes = ((int)0x8B9B),
        /// <summary>
        /// Original was GL_OES_read_format = 1
        /// </summary>
        OesReadFormat = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesReadFormat : int
    {
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_TYPE_OES = 0x8B9A
        /// </summary>
        ImplementationColorReadTypeOes = ((int)0x8B9A),
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES = 0x8B9B
        /// </summary>
        ImplementationColorReadFormatOes = ((int)0x8B9B),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesRequiredInternalformat : int
    {
        /// <summary>
        /// Original was GL_ALPHA8_OES = 0x803C
        /// </summary>
        Alpha8Oes = ((int)0x803C),
        /// <summary>
        /// Original was GL_LUMINANCE8_OES = 0x8040
        /// </summary>
        Luminance8Oes = ((int)0x8040),
        /// <summary>
        /// Original was GL_LUMINANCE4_ALPHA4_OES = 0x8043
        /// </summary>
        Luminance4Alpha4Oes = ((int)0x8043),
        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8_OES = 0x8045
        /// </summary>
        Luminance8Alpha8Oes = ((int)0x8045),
        /// <summary>
        /// Original was GL_RGB8_OES = 0x8051
        /// </summary>
        Rgb8Oes = ((int)0x8051),
        /// <summary>
        /// Original was GL_RGB10_EXT = 0x8052
        /// </summary>
        Rgb10Ext = ((int)0x8052),
        /// <summary>
        /// Original was GL_RGBA4_OES = 0x8056
        /// </summary>
        Rgba4Oes = ((int)0x8056),
        /// <summary>
        /// Original was GL_RGB5_A1_OES = 0x8057
        /// </summary>
        Rgb5A1Oes = ((int)0x8057),
        /// <summary>
        /// Original was GL_RGBA8_OES = 0x8058
        /// </summary>
        Rgba8Oes = ((int)0x8058),
        /// <summary>
        /// Original was GL_RGB10_A2_EXT = 0x8059
        /// </summary>
        Rgb10A2Ext = ((int)0x8059),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_OES = 0x81A5
        /// </summary>
        DepthComponent16Oes = ((int)0x81A5),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_OES = 0x81A6
        /// </summary>
        DepthComponent24Oes = ((int)0x81A6),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        /// </summary>
        DepthComponent32Oes = ((int)0x81A7),
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        /// </summary>
        Depth24Stencil8Oes = ((int)0x88F0),
        /// <summary>
        /// Original was GL_RGB565_OES = 0x8D62
        /// </summary>
        Rgb565Oes = ((int)0x8D62),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum Oesrgb8Rgba8 : int
    {
        /// <summary>
        /// Original was GL_RGB8_OES = 0x8051
        /// </summary>
        Rgb8Oes = ((int)0x8051),
        /// <summary>
        /// Original was GL_RGBA8_OES = 0x8058
        /// </summary>
        Rgba8Oes = ((int)0x8058),
        /// <summary>
        /// Original was GL_OES_rgb8_rgba8 = 1
        /// </summary>
        OesRgb8Rgba8 = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesRgb8Rgba8 : int
    {
        /// <summary>
        /// Original was GL_RGB8_OES = 0x8051
        /// </summary>
        Rgb8Oes = ((int)0x8051),
        /// <summary>
        /// Original was GL_RGBA8_OES = 0x8058
        /// </summary>
        Rgba8Oes = ((int)0x8058),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OessinglePrecision : int
    {
        /// <summary>
        /// Original was GL_OES_single_precision = 1
        /// </summary>
        OesSinglePrecision = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesSinglePrecision : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum Oesstencil1 : int
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX1_OES = 0x8D46
        /// </summary>
        StencilIndex1Oes = ((int)0x8D46),
        /// <summary>
        /// Original was GL_OES_stencil1 = 1
        /// </summary>
        OesStencil1 = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesStencil1 : int
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX1_OES = 0x8D46
        /// </summary>
        StencilIndex1Oes = ((int)0x8D46),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum Oesstencil4 : int
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX4_OES = 0x8D47
        /// </summary>
        StencilIndex4Oes = ((int)0x8D47),
        /// <summary>
        /// Original was GL_OES_stencil4 = 1
        /// </summary>
        OesStencil4 = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesStencil4 : int
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX4_OES = 0x8D47
        /// </summary>
        StencilIndex4Oes = ((int)0x8D47),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum Oesstencil8 : int
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX8_OES = 0x8D48
        /// </summary>
        StencilIndex8Oes = ((int)0x8D48),
        /// <summary>
        /// Original was GL_OES_stencil8 = 1
        /// </summary>
        OesStencil8 = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesStencil8 : int
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX8_OES = 0x8D48
        /// </summary>
        StencilIndex8Oes = ((int)0x8D48),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OesstencilWrap : int
    {
        /// <summary>
        /// Original was GL_INCR_WRAP_OES = 0x8507
        /// </summary>
        IncrWrapOes = ((int)0x8507),
        /// <summary>
        /// Original was GL_DECR_WRAP_OES = 0x8508
        /// </summary>
        DecrWrapOes = ((int)0x8508),
        /// <summary>
        /// Original was GL_OES_stencil_wrap = 1
        /// </summary>
        OesStencilWrap = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesStencilWrap : int
    {
        /// <summary>
        /// Original was GL_INCR_WRAP_OES = 0x8507
        /// </summary>
        IncrWrapOes = ((int)0x8507),
        /// <summary>
        /// Original was GL_DECR_WRAP_OES = 0x8508
        /// </summary>
        DecrWrapOes = ((int)0x8508),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesSurfacelessContext : int
    {
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNDEFINED_OES = 0x8219
        /// </summary>
        FramebufferUndefinedOes = ((int)0x8219),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OestextureCubeMap : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_GEN_MODE_OES = 0x2500
        /// </summary>
        TextureGenModeOes = ((int)0x2500),
        /// <summary>
        /// Original was GL_NORMAL_MAP_OES = 0x8511
        /// </summary>
        NormalMapOes = ((int)0x8511),
        /// <summary>
        /// Original was GL_REFLECTION_MAP_OES = 0x8512
        /// </summary>
        ReflectionMapOes = ((int)0x8512),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_OES = 0x8513
        /// </summary>
        TextureCubeMapOes = ((int)0x8513),
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP_OES = 0x8514
        /// </summary>
        TextureBindingCubeMapOes = ((int)0x8514),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES = 0x8515
        /// </summary>
        TextureCubeMapPositiveXOes = ((int)0x8515),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES = 0x8516
        /// </summary>
        TextureCubeMapNegativeXOes = ((int)0x8516),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES = 0x8517
        /// </summary>
        TextureCubeMapPositiveYOes = ((int)0x8517),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES = 0x8518
        /// </summary>
        TextureCubeMapNegativeYOes = ((int)0x8518),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES = 0x8519
        /// </summary>
        TextureCubeMapPositiveZOes = ((int)0x8519),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES = 0x851A
        /// </summary>
        TextureCubeMapNegativeZOes = ((int)0x851A),
        /// <summary>
        /// Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES = 0x851C
        /// </summary>
        MaxCubeMapTextureSizeOes = ((int)0x851C),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_STR_OES = 0x8D60
        /// </summary>
        TextureGenStrOes = ((int)0x8D60),
        /// <summary>
        /// Original was GL_OES_texture_cube_map = 1
        /// </summary>
        OesTextureCubeMap = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesTextureCubeMap : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_GEN_MODE_OES = 0x2500
        /// </summary>
        TextureGenModeOes = ((int)0x2500),
        /// <summary>
        /// Original was GL_NORMAL_MAP_OES = 0x8511
        /// </summary>
        NormalMapOes = ((int)0x8511),
        /// <summary>
        /// Original was GL_REFLECTION_MAP_OES = 0x8512
        /// </summary>
        ReflectionMapOes = ((int)0x8512),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_OES = 0x8513
        /// </summary>
        TextureCubeMapOes = ((int)0x8513),
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP_OES = 0x8514
        /// </summary>
        TextureBindingCubeMapOes = ((int)0x8514),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES = 0x8515
        /// </summary>
        TextureCubeMapPositiveXOes = ((int)0x8515),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES = 0x8516
        /// </summary>
        TextureCubeMapNegativeXOes = ((int)0x8516),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES = 0x8517
        /// </summary>
        TextureCubeMapPositiveYOes = ((int)0x8517),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES = 0x8518
        /// </summary>
        TextureCubeMapNegativeYOes = ((int)0x8518),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES = 0x8519
        /// </summary>
        TextureCubeMapPositiveZOes = ((int)0x8519),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES = 0x851A
        /// </summary>
        TextureCubeMapNegativeZOes = ((int)0x851A),
        /// <summary>
        /// Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES = 0x851C
        /// </summary>
        MaxCubeMapTextureSizeOes = ((int)0x851C),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_STR_OES = 0x8D60
        /// </summary>
        TextureGenStrOes = ((int)0x8D60),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OestextureEnvCrossbar : int
    {
        /// <summary>
        /// Original was GL_OES_texture_env_crossbar = 1
        /// </summary>
        OesTextureEnvCrossbar = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesTextureEnvCrossbar : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum OestextureMirroredRepeat : int
    {
        /// <summary>
        /// Original was GL_MIRRORED_REPEAT_OES = 0x8370
        /// </summary>
        MirroredRepeatOes = ((int)0x8370),
        /// <summary>
        /// Original was GL_OES_texture_mirrored_repeat = 1
        /// </summary>
        OesTextureMirroredRepeat = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum OesTextureMirroredRepeat : int
    {
        /// <summary>
        /// Original was GL_MIRRORED_REPEAT_OES = 0x8370
        /// </summary>
        MirroredRepeatOes = ((int)0x8370),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureNpot : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesVertexArrayObject : int
    {
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BINDING_OES = 0x85B5
        /// </summary>
        VertexArrayBindingOes = ((int)0x85B5),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum OpenGlescoreVersions : int
    {
        /// <summary>
        /// Original was GL_VERSION_ES_CL_1_0 = 1
        /// </summary>
        VersionEsCl10 = ((int)1),
        /// <summary>
        /// Original was GL_VERSION_ES_CL_1_1 = 1
        /// </summary>
        VersionEsCl11 = ((int)1),
        /// <summary>
        /// Original was GL_VERSION_ES_CM_1_0 = 1
        /// </summary>
        VersionEsCm10 = ((int)1),
        /// <summary>
        /// Original was GL_VERSION_ES_CM_1_1 = 1
        /// </summary>
        VersionEsCm11 = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PatchParameterName : int
    {
        /// <summary>
        /// Original was GL_PATCH_VERTICES = 0x8E72
        /// </summary>
        PatchVertices = ((int)0x8E72),
        /// <summary>
        /// Original was GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73
        /// </summary>
        PatchDefaultInnerLevel = ((int)0x8E73),
        /// <summary>
        /// Original was GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74
        /// </summary>
        PatchDefaultOuterLevel = ((int)0x8E74),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathColor : int
    {
        /// <summary>
        /// Original was GL_PRIMARY_COLOR_NV = 0x852C
        /// </summary>
        PrimaryColorNv = ((int)0x852C),
        /// <summary>
        /// Original was GL_SECONDARY_COLOR_NV = 0x852D
        /// </summary>
        SecondaryColorNv = ((int)0x852D),
        /// <summary>
        /// Original was GL_PRIMARY_COLOR = 0x8577
        /// </summary>
        PrimaryColor = ((int)0x8577),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathCoverMode : int
    {
        /// <summary>
        /// Original was GL_PATH_FILL_COVER_MODE_NV = 0x9082
        /// </summary>
        PathFillCoverModeNv = ((int)0x9082),
        /// <summary>
        /// Original was GL_CONVEX_HULL_NV = 0x908B
        /// </summary>
        ConvexHullNv = ((int)0x908B),
        /// <summary>
        /// Original was GL_BOUNDING_BOX_NV = 0x908D
        /// </summary>
        BoundingBoxNv = ((int)0x908D),
        /// <summary>
        /// Original was GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C
        /// </summary>
        BoundingBoxOfBoundingBoxesNv = ((int)0x909C),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathElementType : int
    {
        /// <summary>
        /// Original was GL_UTF8_NV = 0x909A
        /// </summary>
        Utf8Nv = ((int)0x909A),
        /// <summary>
        /// Original was GL_UTF16_NV = 0x909B
        /// </summary>
        Utf16Nv = ((int)0x909B),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathFillMode : int
    {
        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = ((int)0x150A),
        /// <summary>
        /// Original was GL_PATH_FILL_MODE_NV = 0x9080
        /// </summary>
        PathFillModeNv = ((int)0x9080),
        /// <summary>
        /// Original was GL_COUNT_UP_NV = 0x9088
        /// </summary>
        CountUpNv = ((int)0x9088),
        /// <summary>
        /// Original was GL_COUNT_DOWN_NV = 0x9089
        /// </summary>
        CountDownNv = ((int)0x9089),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathFontStyle : int
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = ((int)0),
        /// <summary>
        /// Original was GL_BOLD_BIT_NV = 0x01
        /// </summary>
        BoldBitNv = ((int)0x01),
        /// <summary>
        /// Original was GL_ITALIC_BIT_NV = 0x02
        /// </summary>
        ItalicBitNv = ((int)0x02),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathFontTarget : int
    {
        /// <summary>
        /// Original was GL_STANDARD_FONT_NAME_NV = 0x9072
        /// </summary>
        StandardFontNameNv = ((int)0x9072),
        /// <summary>
        /// Original was GL_SYSTEM_FONT_NAME_NV = 0x9073
        /// </summary>
        SystemFontNameNv = ((int)0x9073),
        /// <summary>
        /// Original was GL_FILE_NAME_NV = 0x9074
        /// </summary>
        FileNameNv = ((int)0x9074),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathGenMode : int
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = ((int)0),
        /// <summary>
        /// Original was GL_EYE_LINEAR = 0x2400
        /// </summary>
        EyeLinear = ((int)0x2400),
        /// <summary>
        /// Original was GL_OBJECT_LINEAR = 0x2401
        /// </summary>
        ObjectLinear = ((int)0x2401),
        /// <summary>
        /// Original was GL_CONSTANT = 0x8576
        /// </summary>
        Constant = ((int)0x8576),
        /// <summary>
        /// Original was GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A
        /// </summary>
        PathObjectBoundingBoxNv = ((int)0x908A),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathHandleMissingGlyphs : int
    {
        /// <summary>
        /// Original was GL_SKIP_MISSING_GLYPH_NV = 0x90A9
        /// </summary>
        SkipMissingGlyphNv = ((int)0x90A9),
        /// <summary>
        /// Original was GL_USE_MISSING_GLYPH_NV = 0x90AA
        /// </summary>
        UseMissingGlyphNv = ((int)0x90AA),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathListMode : int
    {
        /// <summary>
        /// Original was GL_ACCUM_ADJACENT_PAIRS_NV = 0x90AD
        /// </summary>
        AccumAdjacentPairsNv = ((int)0x90AD),
        /// <summary>
        /// Original was GL_ADJACENT_PAIRS_NV = 0x90AE
        /// </summary>
        AdjacentPairsNv = ((int)0x90AE),
        /// <summary>
        /// Original was GL_FIRST_TO_REST_NV = 0x90AF
        /// </summary>
        FirstToRestNv = ((int)0x90AF),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum PathMetricMask : int
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
        GlyphWidthBitNv = ((int)0x01),
        /// <summary>
        /// Original was GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV = 0x01000000
        /// </summary>
        FontMaxAdvanceWidthBitNv = ((int)0x01000000),
        /// <summary>
        /// Original was GL_GLYPH_HEIGHT_BIT_NV = 0x02
        /// </summary>
        GlyphHeightBitNv = ((int)0x02),
        /// <summary>
        /// Original was GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV = 0x02000000
        /// </summary>
        FontMaxAdvanceHeightBitNv = ((int)0x02000000),
        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04
        /// </summary>
        GlyphHorizontalBearingXBitNv = ((int)0x04),
        /// <summary>
        /// Original was GL_FONT_UNDERLINE_POSITION_BIT_NV = 0x04000000
        /// </summary>
        FontUnderlinePositionBitNv = ((int)0x04000000),
        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08
        /// </summary>
        GlyphHorizontalBearingYBitNv = ((int)0x08),
        /// <summary>
        /// Original was GL_FONT_UNDERLINE_THICKNESS_BIT_NV = 0x08000000
        /// </summary>
        FontUnderlineThicknessBitNv = ((int)0x08000000),
        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10
        /// </summary>
        GlyphHorizontalBearingAdvanceBitNv = ((int)0x10),
        /// <summary>
        /// Original was GL_GLYPH_HAS_KERNING_BIT_NV = 0x100
        /// </summary>
        GlyphHasKerningBitNv = ((int)0x100),
        /// <summary>
        /// Original was GL_FONT_HAS_KERNING_BIT_NV = 0x10000000
        /// </summary>
        FontHasKerningBitNv = ((int)0x10000000),
        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20
        /// </summary>
        GlyphVerticalBearingXBitNv = ((int)0x20),
        /// <summary>
        /// Original was GL_FONT_NUM_GLYPH_INDICES_BIT_NV = 0x20000000
        /// </summary>
        FontNumGlyphIndicesBitNv = ((int)0x20000000),
        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40
        /// </summary>
        GlyphVerticalBearingYBitNv = ((int)0x40),
        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80
        /// </summary>
        GlyphVerticalBearingAdvanceBitNv = ((int)0x80),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathParameter : int
    {
        /// <summary>
        /// Original was GL_PATH_STROKE_WIDTH_NV = 0x9075
        /// </summary>
        PathStrokeWidthNv = ((int)0x9075),
        /// <summary>
        /// Original was GL_PATH_END_CAPS_NV = 0x9076
        /// </summary>
        PathEndCapsNv = ((int)0x9076),
        /// <summary>
        /// Original was GL_PATH_INITIAL_END_CAP_NV = 0x9077
        /// </summary>
        PathInitialEndCapNv = ((int)0x9077),
        /// <summary>
        /// Original was GL_PATH_TERMINAL_END_CAP_NV = 0x9078
        /// </summary>
        PathTerminalEndCapNv = ((int)0x9078),
        /// <summary>
        /// Original was GL_PATH_JOIN_STYLE_NV = 0x9079
        /// </summary>
        PathJoinStyleNv = ((int)0x9079),
        /// <summary>
        /// Original was GL_PATH_MITER_LIMIT_NV = 0x907A
        /// </summary>
        PathMiterLimitNv = ((int)0x907A),
        /// <summary>
        /// Original was GL_PATH_DASH_CAPS_NV = 0x907B
        /// </summary>
        PathDashCapsNv = ((int)0x907B),
        /// <summary>
        /// Original was GL_PATH_INITIAL_DASH_CAP_NV = 0x907C
        /// </summary>
        PathInitialDashCapNv = ((int)0x907C),
        /// <summary>
        /// Original was GL_PATH_TERMINAL_DASH_CAP_NV = 0x907D
        /// </summary>
        PathTerminalDashCapNv = ((int)0x907D),
        /// <summary>
        /// Original was GL_PATH_DASH_OFFSET_NV = 0x907E
        /// </summary>
        PathDashOffsetNv = ((int)0x907E),
        /// <summary>
        /// Original was GL_PATH_CLIENT_LENGTH_NV = 0x907F
        /// </summary>
        PathClientLengthNv = ((int)0x907F),
        /// <summary>
        /// Original was GL_PATH_FILL_MODE_NV = 0x9080
        /// </summary>
        PathFillModeNv = ((int)0x9080),
        /// <summary>
        /// Original was GL_PATH_FILL_MASK_NV = 0x9081
        /// </summary>
        PathFillMaskNv = ((int)0x9081),
        /// <summary>
        /// Original was GL_PATH_FILL_COVER_MODE_NV = 0x9082
        /// </summary>
        PathFillCoverModeNv = ((int)0x9082),
        /// <summary>
        /// Original was GL_PATH_STROKE_COVER_MODE_NV = 0x9083
        /// </summary>
        PathStrokeCoverModeNv = ((int)0x9083),
        /// <summary>
        /// Original was GL_PATH_STROKE_MASK_NV = 0x9084
        /// </summary>
        PathStrokeMaskNv = ((int)0x9084),
        /// <summary>
        /// Original was GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A
        /// </summary>
        PathObjectBoundingBoxNv = ((int)0x908A),
        /// <summary>
        /// Original was GL_PATH_COMMAND_COUNT_NV = 0x909D
        /// </summary>
        PathCommandCountNv = ((int)0x909D),
        /// <summary>
        /// Original was GL_PATH_COORD_COUNT_NV = 0x909E
        /// </summary>
        PathCoordCountNv = ((int)0x909E),
        /// <summary>
        /// Original was GL_PATH_DASH_ARRAY_COUNT_NV = 0x909F
        /// </summary>
        PathDashArrayCountNv = ((int)0x909F),
        /// <summary>
        /// Original was GL_PATH_COMPUTED_LENGTH_NV = 0x90A0
        /// </summary>
        PathComputedLengthNv = ((int)0x90A0),
        /// <summary>
        /// Original was GL_PATH_FILL_BOUNDING_BOX_NV = 0x90A1
        /// </summary>
        PathFillBoundingBoxNv = ((int)0x90A1),
        /// <summary>
        /// Original was GL_PATH_STROKE_BOUNDING_BOX_NV = 0x90A2
        /// </summary>
        PathStrokeBoundingBoxNv = ((int)0x90A2),
        /// <summary>
        /// Original was GL_PATH_DASH_OFFSET_RESET_NV = 0x90B4
        /// </summary>
        PathDashOffsetResetNv = ((int)0x90B4),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathStringFormat : int
    {
        /// <summary>
        /// Original was GL_PATH_FORMAT_SVG_NV = 0x9070
        /// </summary>
        PathFormatSvgNv = ((int)0x9070),
        /// <summary>
        /// Original was GL_PATH_FORMAT_PS_NV = 0x9071
        /// </summary>
        PathFormatPsNv = ((int)0x9071),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PathTransformType : int
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = ((int)0),
        /// <summary>
        /// Original was GL_TRANSLATE_X_NV = 0x908E
        /// </summary>
        TranslateXNv = ((int)0x908E),
        /// <summary>
        /// Original was GL_TRANSLATE_Y_NV = 0x908F
        /// </summary>
        TranslateYNv = ((int)0x908F),
        /// <summary>
        /// Original was GL_TRANSLATE_2D_NV = 0x9090
        /// </summary>
        Translate2DNv = ((int)0x9090),
        /// <summary>
        /// Original was GL_TRANSLATE_3D_NV = 0x9091
        /// </summary>
        Translate3DNv = ((int)0x9091),
        /// <summary>
        /// Original was GL_AFFINE_2D_NV = 0x9092
        /// </summary>
        Affine2DNv = ((int)0x9092),
        /// <summary>
        /// Original was GL_AFFINE_3D_NV = 0x9094
        /// </summary>
        Affine3DNv = ((int)0x9094),
        /// <summary>
        /// Original was GL_TRANSPOSE_AFFINE_2D_NV = 0x9096
        /// </summary>
        TransposeAffine2DNv = ((int)0x9096),
        /// <summary>
        /// Original was GL_TRANSPOSE_AFFINE_3D_NV = 0x9098
        /// </summary>
        TransposeAffine3DNv = ((int)0x9098),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PipelineParameterName : int
    {
        /// <summary>
        /// Original was GL_ACTIVE_PROGRAM = 0x8259
        /// </summary>
        ActiveProgram = ((int)0x8259),
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER = 0x8B30
        /// </summary>
        FragmentShader = ((int)0x8B30),
        /// <summary>
        /// Original was GL_VERTEX_SHADER = 0x8B31
        /// </summary>
        VertexShader = ((int)0x8B31),
        /// <summary>
        /// Original was GL_INFO_LOG_LENGTH = 0x8B84
        /// </summary>
        InfoLogLength = ((int)0x8B84),
        /// <summary>
        /// Original was GL_GEOMETRY_SHADER = 0x8DD9
        /// </summary>
        GeometryShader = ((int)0x8DD9),
        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER = 0x8E87
        /// </summary>
        TessEvaluationShader = ((int)0x8E87),
        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER = 0x8E88
        /// </summary>
        TessControlShader = ((int)0x8E88),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelCopyType : int
    {
        /// <summary>
        /// Original was GL_COLOR = 0x1800
        /// </summary>
        Color = ((int)0x1800),
        /// <summary>
        /// Original was GL_COLOR_EXT = 0x1800
        /// </summary>
        ColorExt = ((int)0x1800),
        /// <summary>
        /// Original was GL_DEPTH = 0x1801
        /// </summary>
        Depth = ((int)0x1801),
        /// <summary>
        /// Original was GL_DEPTH_EXT = 0x1801
        /// </summary>
        DepthExt = ((int)0x1801),
        /// <summary>
        /// Original was GL_STENCIL = 0x1802
        /// </summary>
        Stencil = ((int)0x1802),
        /// <summary>
        /// Original was GL_STENCIL_EXT = 0x1802
        /// </summary>
        StencilExt = ((int)0x1802),
    }

    /// <summary>
    /// Used in GL.CompressedTexSubImage2D, GL.ReadPixels and 4 other functions
    /// </summary>
    public enum PixelFormat : int
    {
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = ((int)0x1403),
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405),
        /// <summary>
        /// Original was GL_COLOR_INDEX = 0x1900
        /// </summary>
        ColorIndex = ((int)0x1900),
        /// <summary>
        /// Original was GL_STENCIL_INDEX = 0x1901
        /// </summary>
        StencilIndex = ((int)0x1901),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT = 0x1902
        /// </summary>
        DepthComponent = ((int)0x1902),
        /// <summary>
        /// Original was GL_RED = 0x1903
        /// </summary>
        Red = ((int)0x1903),
        /// <summary>
        /// Original was GL_RED_EXT = 0x1903
        /// </summary>
        RedExt = ((int)0x1903),
        /// <summary>
        /// Original was GL_GREEN = 0x1904
        /// </summary>
        Green = ((int)0x1904),
        /// <summary>
        /// Original was GL_BLUE = 0x1905
        /// </summary>
        Blue = ((int)0x1905),
        /// <summary>
        /// Original was GL_ALPHA = 0x1906
        /// </summary>
        Alpha = ((int)0x1906),
        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = ((int)0x1907),
        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = ((int)0x1908),
        /// <summary>
        /// Original was GL_LUMINANCE = 0x1909
        /// </summary>
        Luminance = ((int)0x1909),
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = ((int)0x190A),
        /// <summary>
        /// Original was GL_ABGR_EXT = 0x8000
        /// </summary>
        AbgrExt = ((int)0x8000),
        /// <summary>
        /// Original was GL_CMYK_EXT = 0x800C
        /// </summary>
        CmykExt = ((int)0x800C),
        /// <summary>
        /// Original was GL_CMYKA_EXT = 0x800D
        /// </summary>
        CmykaExt = ((int)0x800D),
        /// <summary>
        /// Original was GL_YCRCB_422_SGIX = 0x81BB
        /// </summary>
        Ycrcb422Sgix = ((int)0x81BB),
        /// <summary>
        /// Original was GL_YCRCB_444_SGIX = 0x81BC
        /// </summary>
        Ycrcb444Sgix = ((int)0x81BC),
    }

    /// <summary>
    /// Used in GL.GetPixelMapx, GL.PixelMapx
    /// </summary>
    public enum PixelMap : int
    {
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_I = 0x0C70
        /// </summary>
        PixelMapIToI = ((int)0x0C70),
        /// <summary>
        /// Original was GL_PIXEL_MAP_S_TO_S = 0x0C71
        /// </summary>
        PixelMapSToS = ((int)0x0C71),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_R = 0x0C72
        /// </summary>
        PixelMapIToR = ((int)0x0C72),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_G = 0x0C73
        /// </summary>
        PixelMapIToG = ((int)0x0C73),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_B = 0x0C74
        /// </summary>
        PixelMapIToB = ((int)0x0C74),
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_A = 0x0C75
        /// </summary>
        PixelMapIToA = ((int)0x0C75),
        /// <summary>
        /// Original was GL_PIXEL_MAP_R_TO_R = 0x0C76
        /// </summary>
        PixelMapRToR = ((int)0x0C76),
        /// <summary>
        /// Original was GL_PIXEL_MAP_G_TO_G = 0x0C77
        /// </summary>
        PixelMapGToG = ((int)0x0C77),
        /// <summary>
        /// Original was GL_PIXEL_MAP_B_TO_B = 0x0C78
        /// </summary>
        PixelMapBToB = ((int)0x0C78),
        /// <summary>
        /// Original was GL_PIXEL_MAP_A_TO_A = 0x0C79
        /// </summary>
        PixelMapAToA = ((int)0x0C79),
    }

    /// <summary>
    /// Used in GL.PixelStore, GL.PixelStorex
    /// </summary>
    public enum PixelStoreParameter : int
    {
        /// <summary>
        /// Original was GL_UNPACK_SWAP_BYTES = 0x0CF0
        /// </summary>
        UnpackSwapBytes = ((int)0x0CF0),
        /// <summary>
        /// Original was GL_UNPACK_LSB_FIRST = 0x0CF1
        /// </summary>
        UnpackLsbFirst = ((int)0x0CF1),
        /// <summary>
        /// Original was GL_UNPACK_ROW_LENGTH = 0x0CF2
        /// </summary>
        UnpackRowLength = ((int)0x0CF2),
        /// <summary>
        /// Original was GL_UNPACK_ROW_LENGTH_EXT = 0x0CF2
        /// </summary>
        UnpackRowLengthExt = ((int)0x0CF2),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_ROWS = 0x0CF3
        /// </summary>
        UnpackSkipRows = ((int)0x0CF3),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_ROWS_EXT = 0x0CF3
        /// </summary>
        UnpackSkipRowsExt = ((int)0x0CF3),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_PIXELS = 0x0CF4
        /// </summary>
        UnpackSkipPixels = ((int)0x0CF4),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_PIXELS_EXT = 0x0CF4
        /// </summary>
        UnpackSkipPixelsExt = ((int)0x0CF4),
        /// <summary>
        /// Original was GL_UNPACK_ALIGNMENT = 0x0CF5
        /// </summary>
        UnpackAlignment = ((int)0x0CF5),
        /// <summary>
        /// Original was GL_PACK_SWAP_BYTES = 0x0D00
        /// </summary>
        PackSwapBytes = ((int)0x0D00),
        /// <summary>
        /// Original was GL_PACK_LSB_FIRST = 0x0D01
        /// </summary>
        PackLsbFirst = ((int)0x0D01),
        /// <summary>
        /// Original was GL_PACK_ROW_LENGTH = 0x0D02
        /// </summary>
        PackRowLength = ((int)0x0D02),
        /// <summary>
        /// Original was GL_PACK_SKIP_ROWS = 0x0D03
        /// </summary>
        PackSkipRows = ((int)0x0D03),
        /// <summary>
        /// Original was GL_PACK_SKIP_PIXELS = 0x0D04
        /// </summary>
        PackSkipPixels = ((int)0x0D04),
        /// <summary>
        /// Original was GL_PACK_ALIGNMENT = 0x0D05
        /// </summary>
        PackAlignment = ((int)0x0D05),
        /// <summary>
        /// Original was GL_PACK_SKIP_IMAGES = 0x806B
        /// </summary>
        PackSkipImages = ((int)0x806B),
        /// <summary>
        /// Original was GL_PACK_SKIP_IMAGES_EXT = 0x806B
        /// </summary>
        PackSkipImagesExt = ((int)0x806B),
        /// <summary>
        /// Original was GL_PACK_IMAGE_HEIGHT = 0x806C
        /// </summary>
        PackImageHeight = ((int)0x806C),
        /// <summary>
        /// Original was GL_PACK_IMAGE_HEIGHT_EXT = 0x806C
        /// </summary>
        PackImageHeightExt = ((int)0x806C),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_IMAGES = 0x806D
        /// </summary>
        UnpackSkipImages = ((int)0x806D),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_IMAGES_EXT = 0x806D
        /// </summary>
        UnpackSkipImagesExt = ((int)0x806D),
        /// <summary>
        /// Original was GL_UNPACK_IMAGE_HEIGHT = 0x806E
        /// </summary>
        UnpackImageHeight = ((int)0x806E),
        /// <summary>
        /// Original was GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E
        /// </summary>
        UnpackImageHeightExt = ((int)0x806E),
        /// <summary>
        /// Original was GL_PACK_SKIP_VOLUMES_SGIS = 0x8130
        /// </summary>
        PackSkipVolumesSgis = ((int)0x8130),
        /// <summary>
        /// Original was GL_PACK_IMAGE_DEPTH_SGIS = 0x8131
        /// </summary>
        PackImageDepthSgis = ((int)0x8131),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_VOLUMES_SGIS = 0x8132
        /// </summary>
        UnpackSkipVolumesSgis = ((int)0x8132),
        /// <summary>
        /// Original was GL_UNPACK_IMAGE_DEPTH_SGIS = 0x8133
        /// </summary>
        UnpackImageDepthSgis = ((int)0x8133),
        /// <summary>
        /// Original was GL_PIXEL_TILE_WIDTH_SGIX = 0x8140
        /// </summary>
        PixelTileWidthSgix = ((int)0x8140),
        /// <summary>
        /// Original was GL_PIXEL_TILE_HEIGHT_SGIX = 0x8141
        /// </summary>
        PixelTileHeightSgix = ((int)0x8141),
        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142
        /// </summary>
        PixelTileGridWidthSgix = ((int)0x8142),
        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143
        /// </summary>
        PixelTileGridHeightSgix = ((int)0x8143),
        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144
        /// </summary>
        PixelTileGridDepthSgix = ((int)0x8144),
        /// <summary>
        /// Original was GL_PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145
        /// </summary>
        PixelTileCacheSizeSgix = ((int)0x8145),
        /// <summary>
        /// Original was GL_PACK_RESAMPLE_SGIX = 0x842E
        /// </summary>
        PackResampleSgix = ((int)0x842E),
        /// <summary>
        /// Original was GL_UNPACK_RESAMPLE_SGIX = 0x842F
        /// </summary>
        UnpackResampleSgix = ((int)0x842F),
        /// <summary>
        /// Original was GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0
        /// </summary>
        PackSubsampleRateSgix = ((int)0x85A0),
        /// <summary>
        /// Original was GL_UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1
        /// </summary>
        UnpackSubsampleRateSgix = ((int)0x85A1),
        /// <summary>
        /// Original was GL_PACK_RESAMPLE_OML = 0x8984
        /// </summary>
        PackResampleOml = ((int)0x8984),
        /// <summary>
        /// Original was GL_UNPACK_RESAMPLE_OML = 0x8985
        /// </summary>
        UnpackResampleOml = ((int)0x8985),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelStoreResampleMode : int
    {
        /// <summary>
        /// Original was GL_RESAMPLE_DECIMATE_SGIX = 0x8430
        /// </summary>
        ResampleDecimateSgix = ((int)0x8430),
        /// <summary>
        /// Original was GL_RESAMPLE_REPLICATE_SGIX = 0x8433
        /// </summary>
        ResampleReplicateSgix = ((int)0x8433),
        /// <summary>
        /// Original was GL_RESAMPLE_ZERO_FILL_SGIX = 0x8434
        /// </summary>
        ResampleZeroFillSgix = ((int)0x8434),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelStoreSubsampleRate : int
    {
        /// <summary>
        /// Original was GL_PIXEL_SUBSAMPLE_4444_SGIX = 0x85A2
        /// </summary>
        PixelSubsample4444Sgix = ((int)0x85A2),
        /// <summary>
        /// Original was GL_PIXEL_SUBSAMPLE_2424_SGIX = 0x85A3
        /// </summary>
        PixelSubsample2424Sgix = ((int)0x85A3),
        /// <summary>
        /// Original was GL_PIXEL_SUBSAMPLE_4242_SGIX = 0x85A4
        /// </summary>
        PixelSubsample4242Sgix = ((int)0x85A4),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelTexGenMode : int
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = ((int)0),
        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = ((int)0x1907),
        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = ((int)0x1908),
        /// <summary>
        /// Original was GL_LUMINANCE = 0x1909
        /// </summary>
        Luminance = ((int)0x1909),
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = ((int)0x190A),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX = 0x8187
        /// </summary>
        PixelTexGenAlphaReplaceSgix = ((int)0x8187),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX = 0x8188
        /// </summary>
        PixelTexGenAlphaNoReplaceSgix = ((int)0x8188),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_ALPHA_LS_SGIX = 0x8189
        /// </summary>
        PixelTexGenAlphaLsSgix = ((int)0x8189),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_ALPHA_MS_SGIX = 0x818A
        /// </summary>
        PixelTexGenAlphaMsSgix = ((int)0x818A),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelTexGenParameterNameSgis : int
    {
        /// <summary>
        /// Original was GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354
        /// </summary>
        PixelFragmentRgbSourceSgis = ((int)0x8354),
        /// <summary>
        /// Original was GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355
        /// </summary>
        PixelFragmentAlphaSourceSgis = ((int)0x8355),
    }

    /// <summary>
    /// Used in GL.Oes.PixelTransferx
    /// </summary>
    public enum PixelTransferParameter : int
    {
        /// <summary>
        /// Original was GL_MAP_COLOR = 0x0D10
        /// </summary>
        MapColor = ((int)0x0D10),
        /// <summary>
        /// Original was GL_MAP_STENCIL = 0x0D11
        /// </summary>
        MapStencil = ((int)0x0D11),
        /// <summary>
        /// Original was GL_INDEX_SHIFT = 0x0D12
        /// </summary>
        IndexShift = ((int)0x0D12),
        /// <summary>
        /// Original was GL_INDEX_OFFSET = 0x0D13
        /// </summary>
        IndexOffset = ((int)0x0D13),
        /// <summary>
        /// Original was GL_RED_SCALE = 0x0D14
        /// </summary>
        RedScale = ((int)0x0D14),
        /// <summary>
        /// Original was GL_RED_BIAS = 0x0D15
        /// </summary>
        RedBias = ((int)0x0D15),
        /// <summary>
        /// Original was GL_GREEN_SCALE = 0x0D18
        /// </summary>
        GreenScale = ((int)0x0D18),
        /// <summary>
        /// Original was GL_GREEN_BIAS = 0x0D19
        /// </summary>
        GreenBias = ((int)0x0D19),
        /// <summary>
        /// Original was GL_BLUE_SCALE = 0x0D1A
        /// </summary>
        BlueScale = ((int)0x0D1A),
        /// <summary>
        /// Original was GL_BLUE_BIAS = 0x0D1B
        /// </summary>
        BlueBias = ((int)0x0D1B),
        /// <summary>
        /// Original was GL_ALPHA_SCALE = 0x0D1C
        /// </summary>
        AlphaScale = ((int)0x0D1C),
        /// <summary>
        /// Original was GL_ALPHA_BIAS = 0x0D1D
        /// </summary>
        AlphaBias = ((int)0x0D1D),
        /// <summary>
        /// Original was GL_DEPTH_SCALE = 0x0D1E
        /// </summary>
        DepthScale = ((int)0x0D1E),
        /// <summary>
        /// Original was GL_DEPTH_BIAS = 0x0D1F
        /// </summary>
        DepthBias = ((int)0x0D1F),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_SCALE = 0x801C
        /// </summary>
        PostConvolutionRedScale = ((int)0x801C),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C
        /// </summary>
        PostConvolutionRedScaleExt = ((int)0x801C),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D
        /// </summary>
        PostConvolutionGreenScale = ((int)0x801D),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D
        /// </summary>
        PostConvolutionGreenScaleExt = ((int)0x801D),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E
        /// </summary>
        PostConvolutionBlueScale = ((int)0x801E),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E
        /// </summary>
        PostConvolutionBlueScaleExt = ((int)0x801E),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F
        /// </summary>
        PostConvolutionAlphaScale = ((int)0x801F),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F
        /// </summary>
        PostConvolutionAlphaScaleExt = ((int)0x801F),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_BIAS = 0x8020
        /// </summary>
        PostConvolutionRedBias = ((int)0x8020),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_BIAS_EXT = 0x8020
        /// </summary>
        PostConvolutionRedBiasExt = ((int)0x8020),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021
        /// </summary>
        PostConvolutionGreenBias = ((int)0x8021),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021
        /// </summary>
        PostConvolutionGreenBiasExt = ((int)0x8021),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022
        /// </summary>
        PostConvolutionBlueBias = ((int)0x8022),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022
        /// </summary>
        PostConvolutionBlueBiasExt = ((int)0x8022),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023
        /// </summary>
        PostConvolutionAlphaBias = ((int)0x8023),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023
        /// </summary>
        PostConvolutionAlphaBiasExt = ((int)0x8023),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4
        /// </summary>
        PostColorMatrixRedScale = ((int)0x80B4),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4
        /// </summary>
        PostColorMatrixRedScaleSgi = ((int)0x80B4),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5
        /// </summary>
        PostColorMatrixGreenScale = ((int)0x80B5),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5
        /// </summary>
        PostColorMatrixGreenScaleSgi = ((int)0x80B5),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6
        /// </summary>
        PostColorMatrixBlueScale = ((int)0x80B6),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6
        /// </summary>
        PostColorMatrixBlueScaleSgi = ((int)0x80B6),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7
        /// </summary>
        PostColorMatrixAlphaScale = ((int)0x80B7),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7
        /// </summary>
        PostColorMatrixAlphaScaleSgi = ((int)0x80B7),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8
        /// </summary>
        PostColorMatrixRedBias = ((int)0x80B8),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8
        /// </summary>
        PostColorMatrixRedBiasSgi = ((int)0x80B8),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9
        /// </summary>
        PostColorMatrixGreenBias = ((int)0x80B9),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9
        /// </summary>
        PostColorMatrixGreenBiasSgi = ((int)0x80B9),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA
        /// </summary>
        PostColorMatrixBlueBias = ((int)0x80BA),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA
        /// </summary>
        PostColorMatrixBlueBiasSgi = ((int)0x80BA),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB
        /// </summary>
        PostColorMatrixAlphaBias = ((int)0x80BB),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB
        /// </summary>
        PostColorMatrixAlphaBiasSgi = ((int)0x80BB),
    }

    /// <summary>
    /// Used in GL.ReadPixels, GL.TexImage2D and 3 other functions
    /// </summary>
    public enum PixelType : int
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = ((int)0x1400),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = ((int)0x1401),
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = ((int)0x1402),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = ((int)0x1403),
        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = ((int)0x1404),
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405),
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406),
        /// <summary>
        /// Original was GL_BITMAP = 0x1A00
        /// </summary>
        Bitmap = ((int)0x1A00),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE_3_3_2 = 0x8032
        /// </summary>
        UnsignedByte332 = ((int)0x8032),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE_3_3_2_EXT = 0x8032
        /// </summary>
        UnsignedByte332Ext = ((int)0x8032),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033
        /// </summary>
        UnsignedShort4444 = ((int)0x8033),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033
        /// </summary>
        UnsignedShort4444Ext = ((int)0x8033),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034
        /// </summary>
        UnsignedShort5551 = ((int)0x8034),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034
        /// </summary>
        UnsignedShort5551Ext = ((int)0x8034),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_8_8_8_8 = 0x8035
        /// </summary>
        UnsignedInt8888 = ((int)0x8035),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_8_8_8_8_EXT = 0x8035
        /// </summary>
        UnsignedInt8888Ext = ((int)0x8035),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_10_10_10_2 = 0x8036
        /// </summary>
        UnsignedInt1010102 = ((int)0x8036),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_10_10_10_2_EXT = 0x8036
        /// </summary>
        UnsignedInt1010102Ext = ((int)0x8036),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PointParameterNameSgis : int
    {
        /// <summary>
        /// Original was GL_POINT_SIZE_MIN = 0x8126
        /// </summary>
        PointSizeMin = ((int)0x8126),
        /// <summary>
        /// Original was GL_POINT_SIZE_MIN_ARB = 0x8126
        /// </summary>
        PointSizeMinArb = ((int)0x8126),
        /// <summary>
        /// Original was GL_POINT_SIZE_MIN_EXT = 0x8126
        /// </summary>
        PointSizeMinExt = ((int)0x8126),
        /// <summary>
        /// Original was GL_POINT_SIZE_MIN_SGIS = 0x8126
        /// </summary>
        PointSizeMinSgis = ((int)0x8126),
        /// <summary>
        /// Original was GL_POINT_SIZE_MAX = 0x8127
        /// </summary>
        PointSizeMax = ((int)0x8127),
        /// <summary>
        /// Original was GL_POINT_SIZE_MAX_ARB = 0x8127
        /// </summary>
        PointSizeMaxArb = ((int)0x8127),
        /// <summary>
        /// Original was GL_POINT_SIZE_MAX_EXT = 0x8127
        /// </summary>
        PointSizeMaxExt = ((int)0x8127),
        /// <summary>
        /// Original was GL_POINT_SIZE_MAX_SGIS = 0x8127
        /// </summary>
        PointSizeMaxSgis = ((int)0x8127),
        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE = 0x8128
        /// </summary>
        PointFadeThresholdSize = ((int)0x8128),
        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128
        /// </summary>
        PointFadeThresholdSizeArb = ((int)0x8128),
        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128
        /// </summary>
        PointFadeThresholdSizeExt = ((int)0x8128),
        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128
        /// </summary>
        PointFadeThresholdSizeSgis = ((int)0x8128),
        /// <summary>
        /// Original was GL_DISTANCE_ATTENUATION_EXT = 0x8129
        /// </summary>
        DistanceAttenuationExt = ((int)0x8129),
        /// <summary>
        /// Original was GL_DISTANCE_ATTENUATION_SGIS = 0x8129
        /// </summary>
        DistanceAttenuationSgis = ((int)0x8129),
        /// <summary>
        /// Original was GL_POINT_DISTANCE_ATTENUATION = 0x8129
        /// </summary>
        PointDistanceAttenuation = ((int)0x8129),
        /// <summary>
        /// Original was GL_POINT_DISTANCE_ATTENUATION_ARB = 0x8129
        /// </summary>
        PointDistanceAttenuationArb = ((int)0x8129),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PolygonMode : int
    {
        /// <summary>
        /// Original was GL_POINT = 0x1B00
        /// </summary>
        Point = ((int)0x1B00),
        /// <summary>
        /// Original was GL_LINE = 0x1B01
        /// </summary>
        Line = ((int)0x1B01),
        /// <summary>
        /// Original was GL_FILL = 0x1B02
        /// </summary>
        Fill = ((int)0x1B02),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PrecisionType : int
    {
        /// <summary>
        /// Original was GL_LOW_FLOAT = 0x8DF0
        /// </summary>
        LowFloat = ((int)0x8DF0),
        /// <summary>
        /// Original was GL_MEDIUM_FLOAT = 0x8DF1
        /// </summary>
        MediumFloat = ((int)0x8DF1),
        /// <summary>
        /// Original was GL_HIGH_FLOAT = 0x8DF2
        /// </summary>
        HighFloat = ((int)0x8DF2),
        /// <summary>
        /// Original was GL_LOW_INT = 0x8DF3
        /// </summary>
        LowInt = ((int)0x8DF3),
        /// <summary>
        /// Original was GL_MEDIUM_INT = 0x8DF4
        /// </summary>
        MediumInt = ((int)0x8DF4),
        /// <summary>
        /// Original was GL_HIGH_INT = 0x8DF5
        /// </summary>
        HighInt = ((int)0x8DF5),
    }

    /// <summary>
    /// Used in GL.DrawArrays, GL.DrawElements and 2 other functions
    /// </summary>
    public enum PrimitiveType : int
    {
        /// <summary>
        /// Original was GL_POINTS = 0x0000
        /// </summary>
        Points = ((int)0x0000),
        /// <summary>
        /// Original was GL_LINES = 0x0001
        /// </summary>
        Lines = ((int)0x0001),
        /// <summary>
        /// Original was GL_LINE_LOOP = 0x0002
        /// </summary>
        LineLoop = ((int)0x0002),
        /// <summary>
        /// Original was GL_LINE_STRIP = 0x0003
        /// </summary>
        LineStrip = ((int)0x0003),
        /// <summary>
        /// Original was GL_TRIANGLES = 0x0004
        /// </summary>
        Triangles = ((int)0x0004),
        /// <summary>
        /// Original was GL_TRIANGLE_STRIP = 0x0005
        /// </summary>
        TriangleStrip = ((int)0x0005),
        /// <summary>
        /// Original was GL_TRIANGLE_FAN = 0x0006
        /// </summary>
        TriangleFan = ((int)0x0006),
        /// <summary>
        /// Original was GL_QUADS = 0x0007
        /// </summary>
        Quads = ((int)0x0007),
        /// <summary>
        /// Original was GL_QUADS_EXT = 0x0007
        /// </summary>
        QuadsExt = ((int)0x0007),
        /// <summary>
        /// Original was GL_QUAD_STRIP = 0x0008
        /// </summary>
        QuadStrip = ((int)0x0008),
        /// <summary>
        /// Original was GL_POLYGON = 0x0009
        /// </summary>
        Polygon = ((int)0x0009),
        /// <summary>
        /// Original was GL_LINES_ADJACENCY = 0x000A
        /// </summary>
        LinesAdjacency = ((int)0x000A),
        /// <summary>
        /// Original was GL_LINES_ADJACENCY_ARB = 0x000A
        /// </summary>
        LinesAdjacencyArb = ((int)0x000A),
        /// <summary>
        /// Original was GL_LINES_ADJACENCY_EXT = 0x000A
        /// </summary>
        LinesAdjacencyExt = ((int)0x000A),
        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY = 0x000B
        /// </summary>
        LineStripAdjacency = ((int)0x000B),
        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY_ARB = 0x000B
        /// </summary>
        LineStripAdjacencyArb = ((int)0x000B),
        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY_EXT = 0x000B
        /// </summary>
        LineStripAdjacencyExt = ((int)0x000B),
        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY = 0x000C
        /// </summary>
        TrianglesAdjacency = ((int)0x000C),
        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY_ARB = 0x000C
        /// </summary>
        TrianglesAdjacencyArb = ((int)0x000C),
        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY_EXT = 0x000C
        /// </summary>
        TrianglesAdjacencyExt = ((int)0x000C),
        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY = 0x000D
        /// </summary>
        TriangleStripAdjacency = ((int)0x000D),
        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D
        /// </summary>
        TriangleStripAdjacencyArb = ((int)0x000D),
        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D
        /// </summary>
        TriangleStripAdjacencyExt = ((int)0x000D),
        /// <summary>
        /// Original was GL_PATCHES = 0x000E
        /// </summary>
        Patches = ((int)0x000E),
        /// <summary>
        /// Original was GL_PATCHES_EXT = 0x000E
        /// </summary>
        PatchesExt = ((int)0x000E),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ProgramInterface : int
    {
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        /// </summary>
        TransformFeedbackBuffer = ((int)0x8C8E),
        /// <summary>
        /// Original was GL_UNIFORM = 0x92E1
        /// </summary>
        Uniform = ((int)0x92E1),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK = 0x92E2
        /// </summary>
        UniformBlock = ((int)0x92E2),
        /// <summary>
        /// Original was GL_PROGRAM_INPUT = 0x92E3
        /// </summary>
        ProgramInput = ((int)0x92E3),
        /// <summary>
        /// Original was GL_PROGRAM_OUTPUT = 0x92E4
        /// </summary>
        ProgramOutput = ((int)0x92E4),
        /// <summary>
        /// Original was GL_BUFFER_VARIABLE = 0x92E5
        /// </summary>
        BufferVariable = ((int)0x92E5),
        /// <summary>
        /// Original was GL_SHADER_STORAGE_BLOCK = 0x92E6
        /// </summary>
        ShaderStorageBlock = ((int)0x92E6),
        /// <summary>
        /// Original was GL_VERTEX_SUBROUTINE = 0x92E8
        /// </summary>
        VertexSubroutine = ((int)0x92E8),
        /// <summary>
        /// Original was GL_TESS_CONTROL_SUBROUTINE = 0x92E9
        /// </summary>
        TessControlSubroutine = ((int)0x92E9),
        /// <summary>
        /// Original was GL_TESS_EVALUATION_SUBROUTINE = 0x92EA
        /// </summary>
        TessEvaluationSubroutine = ((int)0x92EA),
        /// <summary>
        /// Original was GL_GEOMETRY_SUBROUTINE = 0x92EB
        /// </summary>
        GeometrySubroutine = ((int)0x92EB),
        /// <summary>
        /// Original was GL_FRAGMENT_SUBROUTINE = 0x92EC
        /// </summary>
        FragmentSubroutine = ((int)0x92EC),
        /// <summary>
        /// Original was GL_COMPUTE_SUBROUTINE = 0x92ED
        /// </summary>
        ComputeSubroutine = ((int)0x92ED),
        /// <summary>
        /// Original was GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE
        /// </summary>
        VertexSubroutineUniform = ((int)0x92EE),
        /// <summary>
        /// Original was GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF
        /// </summary>
        TessControlSubroutineUniform = ((int)0x92EF),
        /// <summary>
        /// Original was GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0
        /// </summary>
        TessEvaluationSubroutineUniform = ((int)0x92F0),
        /// <summary>
        /// Original was GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1
        /// </summary>
        GeometrySubroutineUniform = ((int)0x92F1),
        /// <summary>
        /// Original was GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2
        /// </summary>
        FragmentSubroutineUniform = ((int)0x92F2),
        /// <summary>
        /// Original was GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3
        /// </summary>
        ComputeSubroutineUniform = ((int)0x92F3),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4
        /// </summary>
        TransformFeedbackVarying = ((int)0x92F4),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ProgramInterfacePName : int
    {
        /// <summary>
        /// Original was GL_ACTIVE_RESOURCES = 0x92F5
        /// </summary>
        ActiveResources = ((int)0x92F5),
        /// <summary>
        /// Original was GL_MAX_NAME_LENGTH = 0x92F6
        /// </summary>
        MaxNameLength = ((int)0x92F6),
        /// <summary>
        /// Original was GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7
        /// </summary>
        MaxNumActiveVariables = ((int)0x92F7),
        /// <summary>
        /// Original was GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8
        /// </summary>
        MaxNumCompatibleSubroutines = ((int)0x92F8),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ProgramParameterPName : int
    {
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
        /// </summary>
        ProgramBinaryRetrievableHint = ((int)0x8257),
        /// <summary>
        /// Original was GL_PROGRAM_SEPARABLE = 0x8258
        /// </summary>
        ProgramSeparable = ((int)0x8258),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ProgramPropertyArb : int
    {
        /// <summary>
        /// Original was GL_COMPUTE_WORK_GROUP_SIZE = 0x8267
        /// </summary>
        ComputeWorkGroupSize = ((int)0x8267),
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_LENGTH = 0x8741
        /// </summary>
        ProgramBinaryLength = ((int)0x8741),
        /// <summary>
        /// Original was GL_GEOMETRY_VERTICES_OUT = 0x8916
        /// </summary>
        GeometryVerticesOut = ((int)0x8916),
        /// <summary>
        /// Original was GL_GEOMETRY_INPUT_TYPE = 0x8917
        /// </summary>
        GeometryInputType = ((int)0x8917),
        /// <summary>
        /// Original was GL_GEOMETRY_OUTPUT_TYPE = 0x8918
        /// </summary>
        GeometryOutputType = ((int)0x8918),
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35
        /// </summary>
        ActiveUniformBlockMaxNameLength = ((int)0x8A35),
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36
        /// </summary>
        ActiveUniformBlocks = ((int)0x8A36),
        /// <summary>
        /// Original was GL_DELETE_STATUS = 0x8B80
        /// </summary>
        DeleteStatus = ((int)0x8B80),
        /// <summary>
        /// Original was GL_LINK_STATUS = 0x8B82
        /// </summary>
        LinkStatus = ((int)0x8B82),
        /// <summary>
        /// Original was GL_VALIDATE_STATUS = 0x8B83
        /// </summary>
        ValidateStatus = ((int)0x8B83),
        /// <summary>
        /// Original was GL_INFO_LOG_LENGTH = 0x8B84
        /// </summary>
        InfoLogLength = ((int)0x8B84),
        /// <summary>
        /// Original was GL_ATTACHED_SHADERS = 0x8B85
        /// </summary>
        AttachedShaders = ((int)0x8B85),
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORMS = 0x8B86
        /// </summary>
        ActiveUniforms = ((int)0x8B86),
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87
        /// </summary>
        ActiveUniformMaxLength = ((int)0x8B87),
        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTES = 0x8B89
        /// </summary>
        ActiveAttributes = ((int)0x8B89),
        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A
        /// </summary>
        ActiveAttributeMaxLength = ((int)0x8B8A),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76
        /// </summary>
        TransformFeedbackVaryingMaxLength = ((int)0x8C76),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F
        /// </summary>
        TransformFeedbackBufferMode = ((int)0x8C7F),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83
        /// </summary>
        TransformFeedbackVaryings = ((int)0x8C83),
        /// <summary>
        /// Original was GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9
        /// </summary>
        ActiveAtomicCounterBuffers = ((int)0x92D9),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ProgramStagePName : int
    {
        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINES = 0x8DE5
        /// </summary>
        ActiveSubroutines = ((int)0x8DE5),
        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6
        /// </summary>
        ActiveSubroutineUniforms = ((int)0x8DE6),
        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47
        /// </summary>
        ActiveSubroutineUniformLocations = ((int)0x8E47),
        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48
        /// </summary>
        ActiveSubroutineMaxLength = ((int)0x8E48),
        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49
        /// </summary>
        ActiveSubroutineUniformMaxLength = ((int)0x8E49),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum QcomdriverControl : int
    {
        /// <summary>
        /// Original was GL_QCOM_driver_control = 1
        /// </summary>
        QcomDriverControl = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum QcomDriverControl : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomExtendedGet : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_WIDTH_QCOM = 0x8BD2
        /// </summary>
        TextureWidthQcom = ((int)0x8BD2),
        /// <summary>
        /// Original was GL_TEXTURE_HEIGHT_QCOM = 0x8BD3
        /// </summary>
        TextureHeightQcom = ((int)0x8BD3),
        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_QCOM = 0x8BD4
        /// </summary>
        TextureDepthQcom = ((int)0x8BD4),
        /// <summary>
        /// Original was GL_TEXTURE_INTERNAL_FORMAT_QCOM = 0x8BD5
        /// </summary>
        TextureInternalFormatQcom = ((int)0x8BD5),
        /// <summary>
        /// Original was GL_TEXTURE_FORMAT_QCOM = 0x8BD6
        /// </summary>
        TextureFormatQcom = ((int)0x8BD6),
        /// <summary>
        /// Original was GL_TEXTURE_TYPE_QCOM = 0x8BD7
        /// </summary>
        TextureTypeQcom = ((int)0x8BD7),
        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_VALID_QCOM = 0x8BD8
        /// </summary>
        TextureImageValidQcom = ((int)0x8BD8),
        /// <summary>
        /// Original was GL_TEXTURE_NUM_LEVELS_QCOM = 0x8BD9
        /// </summary>
        TextureNumLevelsQcom = ((int)0x8BD9),
        /// <summary>
        /// Original was GL_TEXTURE_TARGET_QCOM = 0x8BDA
        /// </summary>
        TextureTargetQcom = ((int)0x8BDA),
        /// <summary>
        /// Original was GL_TEXTURE_OBJECT_VALID_QCOM = 0x8BDB
        /// </summary>
        TextureObjectValidQcom = ((int)0x8BDB),
        /// <summary>
        /// Original was GL_STATE_RESTORE = 0x8BDC
        /// </summary>
        StateRestore = ((int)0x8BDC),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomExtendedGet2 : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    [CLSCompliant(false)]
    public enum QcomperfmonGlobalMode : int
    {
        /// <summary>
        /// Original was GL_PERFMON_GLOBAL_MODE_QCOM = 0x8FA0
        /// </summary>
        PerfmonGlobalModeQcom = ((int)0x8FA0),
        /// <summary>
        /// Original was GL_QCOM_perfmon_global_mode = 1
        /// </summary>
        QcomPerfmonGlobalMode = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [CLSCompliant(false)]
    public enum QcomPerfmonGlobalMode : int
    {
        /// <summary>
        /// Original was GL_PERFMON_GLOBAL_MODE_QCOM = 0x8FA0
        /// </summary>
        PerfmonGlobalModeQcom = ((int)0x8FA0),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomTiledRendering : int
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
    public enum QcomWriteonlyRendering : int
    {
        /// <summary>
        /// Original was GL_WRITEONLY_RENDERING_QCOM = 0x8823
        /// </summary>
        WriteonlyRenderingQcom = ((int)0x8823),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QueryObjectParameterName : int
    {
        /// <summary>
        /// Original was GL_QUERY_TARGET = 0x82EA
        /// </summary>
        QueryTarget = ((int)0x82EA),
        /// <summary>
        /// Original was GL_QUERY_RESULT = 0x8866
        /// </summary>
        QueryResult = ((int)0x8866),
        /// <summary>
        /// Original was GL_QUERY_RESULT_AVAILABLE = 0x8867
        /// </summary>
        QueryResultAvailable = ((int)0x8867),
        /// <summary>
        /// Original was GL_QUERY_RESULT_NO_WAIT = 0x9194
        /// </summary>
        QueryResultNoWait = ((int)0x9194),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QueryParameterName : int
    {
        /// <summary>
        /// Original was GL_QUERY_COUNTER_BITS = 0x8864
        /// </summary>
        QueryCounterBits = ((int)0x8864),
        /// <summary>
        /// Original was GL_CURRENT_QUERY = 0x8865
        /// </summary>
        CurrentQuery = ((int)0x8865),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QueryTarget : int
    {
        /// <summary>
        /// Original was GL_TIME_ELAPSED = 0x88BF
        /// </summary>
        TimeElapsed = ((int)0x88BF),
        /// <summary>
        /// Original was GL_SAMPLES_PASSED = 0x8914
        /// </summary>
        SamplesPassed = ((int)0x8914),
        /// <summary>
        /// Original was GL_ANY_SAMPLES_PASSED = 0x8C2F
        /// </summary>
        AnySamplesPassed = ((int)0x8C2F),
        /// <summary>
        /// Original was GL_PRIMITIVES_GENERATED = 0x8C87
        /// </summary>
        PrimitivesGenerated = ((int)0x8C87),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88
        /// </summary>
        TransformFeedbackPrimitivesWritten = ((int)0x8C88),
        /// <summary>
        /// Original was GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A
        /// </summary>
        AnySamplesPassedConservative = ((int)0x8D6A),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ReadBufferMode : int
    {
        /// <summary>
        /// Original was GL_FRONT_LEFT = 0x0400
        /// </summary>
        FrontLeft = ((int)0x0400),
        /// <summary>
        /// Original was GL_FRONT_RIGHT = 0x0401
        /// </summary>
        FrontRight = ((int)0x0401),
        /// <summary>
        /// Original was GL_BACK_LEFT = 0x0402
        /// </summary>
        BackLeft = ((int)0x0402),
        /// <summary>
        /// Original was GL_BACK_RIGHT = 0x0403
        /// </summary>
        BackRight = ((int)0x0403),
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = ((int)0x0404),
        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = ((int)0x0405),
        /// <summary>
        /// Original was GL_LEFT = 0x0406
        /// </summary>
        Left = ((int)0x0406),
        /// <summary>
        /// Original was GL_RIGHT = 0x0407
        /// </summary>
        Right = ((int)0x0407),
        /// <summary>
        /// Original was GL_AUX0 = 0x0409
        /// </summary>
        Aux0 = ((int)0x0409),
        /// <summary>
        /// Original was GL_AUX1 = 0x040A
        /// </summary>
        Aux1 = ((int)0x040A),
        /// <summary>
        /// Original was GL_AUX2 = 0x040B
        /// </summary>
        Aux2 = ((int)0x040B),
        /// <summary>
        /// Original was GL_AUX3 = 0x040C
        /// </summary>
        Aux3 = ((int)0x040C),
    }

    /// <summary>
    /// Used in GL.Oes.GetRenderbufferParameter
    /// </summary>
    public enum RenderbufferParameterName : int
    {
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES = 0x8CAB
        /// </summary>
        RenderbufferSamples = ((int)0x8CAB),
        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH = 0x8D42
        /// </summary>
        RenderbufferWidth = ((int)0x8D42),
        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT = 0x8D43
        /// </summary>
        RenderbufferHeight = ((int)0x8D43),
        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44
        /// </summary>
        RenderbufferInternalFormat = ((int)0x8D44),
        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE = 0x8D50
        /// </summary>
        RenderbufferRedSize = ((int)0x8D50),
        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE = 0x8D51
        /// </summary>
        RenderbufferGreenSize = ((int)0x8D51),
        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE = 0x8D52
        /// </summary>
        RenderbufferBlueSize = ((int)0x8D52),
        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53
        /// </summary>
        RenderbufferAlphaSize = ((int)0x8D53),
        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54
        /// </summary>
        RenderbufferDepthSize = ((int)0x8D54),
        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55
        /// </summary>
        RenderbufferStencilSize = ((int)0x8D55),
    }

    /// <summary>
    /// Used in GL.Apple.RenderbufferStorageMultisample, GL.Ext.RenderbufferStorageMultisample and 5 other functions
    /// </summary>
    public enum RenderbufferTarget : int
    {
        /// <summary>
        /// Original was GL_RENDERBUFFER = 0x8D41
        /// </summary>
        Renderbuffer = ((int)0x8D41),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum RenderingMode : int
    {
        /// <summary>
        /// Original was GL_RENDER = 0x1C00
        /// </summary>
        Render = ((int)0x1C00),
        /// <summary>
        /// Original was GL_FEEDBACK = 0x1C01
        /// </summary>
        Feedback = ((int)0x1C01),
        /// <summary>
        /// Original was GL_SELECT = 0x1C02
        /// </summary>
        Select = ((int)0x1C02),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SamplePatternSgis : int
    {
        /// <summary>
        /// Original was GL_1PASS_EXT = 0x80A1
        /// </summary>
        Gl1PassExt = ((int)0x80A1),
        /// <summary>
        /// Original was GL_1PASS_SGIS = 0x80A1
        /// </summary>
        Gl1PassSgis = ((int)0x80A1),
        /// <summary>
        /// Original was GL_2PASS_0_EXT = 0x80A2
        /// </summary>
        Gl2Pass0Ext = ((int)0x80A2),
        /// <summary>
        /// Original was GL_2PASS_0_SGIS = 0x80A2
        /// </summary>
        Gl2Pass0Sgis = ((int)0x80A2),
        /// <summary>
        /// Original was GL_2PASS_1_EXT = 0x80A3
        /// </summary>
        Gl2Pass1Ext = ((int)0x80A3),
        /// <summary>
        /// Original was GL_2PASS_1_SGIS = 0x80A3
        /// </summary>
        Gl2Pass1Sgis = ((int)0x80A3),
        /// <summary>
        /// Original was GL_4PASS_0_EXT = 0x80A4
        /// </summary>
        Gl4Pass0Ext = ((int)0x80A4),
        /// <summary>
        /// Original was GL_4PASS_0_SGIS = 0x80A4
        /// </summary>
        Gl4Pass0Sgis = ((int)0x80A4),
        /// <summary>
        /// Original was GL_4PASS_1_EXT = 0x80A5
        /// </summary>
        Gl4Pass1Ext = ((int)0x80A5),
        /// <summary>
        /// Original was GL_4PASS_1_SGIS = 0x80A5
        /// </summary>
        Gl4Pass1Sgis = ((int)0x80A5),
        /// <summary>
        /// Original was GL_4PASS_2_EXT = 0x80A6
        /// </summary>
        Gl4Pass2Ext = ((int)0x80A6),
        /// <summary>
        /// Original was GL_4PASS_2_SGIS = 0x80A6
        /// </summary>
        Gl4Pass2Sgis = ((int)0x80A6),
        /// <summary>
        /// Original was GL_4PASS_3_EXT = 0x80A7
        /// </summary>
        Gl4Pass3Ext = ((int)0x80A7),
        /// <summary>
        /// Original was GL_4PASS_3_SGIS = 0x80A7
        /// </summary>
        Gl4Pass3Sgis = ((int)0x80A7),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SamplerParameterName : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR = 0x1004
        /// </summary>
        TextureBorderColor = ((int)0x1004),
        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = ((int)0x2800),
        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = ((int)0x2801),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = ((int)0x2802),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = ((int)0x2803),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R = 0x8072
        /// </summary>
        TextureWrapR = ((int)0x8072),
        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD = 0x813A
        /// </summary>
        TextureMinLod = ((int)0x813A),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD = 0x813B
        /// </summary>
        TextureMaxLod = ((int)0x813B),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_MODE = 0x884C
        /// </summary>
        TextureCompareMode = ((int)0x884C),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
        /// </summary>
        TextureCompareFunc = ((int)0x884D),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SemaphoreParameterName : int
    {
        /// <summary>
        /// Original was GL_D3D12_FENCE_VALUE_EXT = 0x9595
        /// </summary>
        D3D12FenceValueExt = ((int)0x9595),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SeparableTargetExt : int
    {
        /// <summary>
        /// Original was GL_SEPARABLE_2D = 0x8012
        /// </summary>
        Separable2D = ((int)0x8012),
        /// <summary>
        /// Original was GL_SEPARABLE_2D_EXT = 0x8012
        /// </summary>
        Separable2DExt = ((int)0x8012),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ShaderParameterName : int
    {
        /// <summary>
        /// Original was GL_SHADER_TYPE = 0x8B4F
        /// </summary>
        ShaderType = ((int)0x8B4F),
        /// <summary>
        /// Original was GL_DELETE_STATUS = 0x8B80
        /// </summary>
        DeleteStatus = ((int)0x8B80),
        /// <summary>
        /// Original was GL_COMPILE_STATUS = 0x8B81
        /// </summary>
        CompileStatus = ((int)0x8B81),
        /// <summary>
        /// Original was GL_INFO_LOG_LENGTH = 0x8B84
        /// </summary>
        InfoLogLength = ((int)0x8B84),
        /// <summary>
        /// Original was GL_SHADER_SOURCE_LENGTH = 0x8B88
        /// </summary>
        ShaderSourceLength = ((int)0x8B88),
    }

    /// <summary>
    /// Used in GL.Qcom.ExtGetProgramBinarySource
    /// </summary>
    public enum ShaderType : int
    {
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER = 0x8B30
        /// </summary>
        FragmentShader = ((int)0x8B30),
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_ARB = 0x8B30
        /// </summary>
        FragmentShaderArb = ((int)0x8B30),
        /// <summary>
        /// Original was GL_VERTEX_SHADER = 0x8B31
        /// </summary>
        VertexShader = ((int)0x8B31),
        /// <summary>
        /// Original was GL_VERTEX_SHADER_ARB = 0x8B31
        /// </summary>
        VertexShaderArb = ((int)0x8B31),
        /// <summary>
        /// Original was GL_GEOMETRY_SHADER = 0x8DD9
        /// </summary>
        GeometryShader = ((int)0x8DD9),
        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER = 0x8E87
        /// </summary>
        TessEvaluationShader = ((int)0x8E87),
        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER = 0x8E88
        /// </summary>
        TessControlShader = ((int)0x8E88),
        /// <summary>
        /// Original was GL_COMPUTE_SHADER = 0x91B9
        /// </summary>
        ComputeShader = ((int)0x91B9),
    }

    /// <summary>
    /// Used in GL.ShadeModel
    /// </summary>
    public enum ShadingModel : int
    {
        /// <summary>
        /// Original was GL_FLAT = 0x1D00
        /// </summary>
        Flat = ((int)0x1D00),
        /// <summary>
        /// Original was GL_SMOOTH = 0x1D01
        /// </summary>
        Smooth = ((int)0x1D01),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum StencilFaceDirection : int
    {
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = ((int)0x0404),
        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = ((int)0x0405),
        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = ((int)0x0408),
    }

    /// <summary>
    /// Used in GL.StencilFunc
    /// </summary>
    public enum StencilFunction : int
    {
        /// <summary>
        /// Original was GL_NEVER = 0x0200
        /// </summary>
        Never = ((int)0x0200),
        /// <summary>
        /// Original was GL_LESS = 0x0201
        /// </summary>
        Less = ((int)0x0201),
        /// <summary>
        /// Original was GL_EQUAL = 0x0202
        /// </summary>
        Equal = ((int)0x0202),
        /// <summary>
        /// Original was GL_LEQUAL = 0x0203
        /// </summary>
        Lequal = ((int)0x0203),
        /// <summary>
        /// Original was GL_GREATER = 0x0204
        /// </summary>
        Greater = ((int)0x0204),
        /// <summary>
        /// Original was GL_NOTEQUAL = 0x0205
        /// </summary>
        Notequal = ((int)0x0205),
        /// <summary>
        /// Original was GL_GEQUAL = 0x0206
        /// </summary>
        Gequal = ((int)0x0206),
        /// <summary>
        /// Original was GL_ALWAYS = 0x0207
        /// </summary>
        Always = ((int)0x0207),
    }

    /// <summary>
    /// Used in GL.StencilOp
    /// </summary>
    public enum StencilOp : int
    {
        /// <summary>
        /// Original was GL_ZERO = 0
        /// </summary>
        Zero = ((int)0),
        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = ((int)0x150A),
        /// <summary>
        /// Original was GL_KEEP = 0x1E00
        /// </summary>
        Keep = ((int)0x1E00),
        /// <summary>
        /// Original was GL_REPLACE = 0x1E01
        /// </summary>
        Replace = ((int)0x1E01),
        /// <summary>
        /// Original was GL_INCR = 0x1E02
        /// </summary>
        Incr = ((int)0x1E02),
        /// <summary>
        /// Original was GL_DECR = 0x1E03
        /// </summary>
        Decr = ((int)0x1E03),
    }

    /// <summary>
    /// Used in GL.GetString
    /// </summary>
    public enum StringName : int
    {
        /// <summary>
        /// Original was GL_VENDOR = 0x1F00
        /// </summary>
        Vendor = ((int)0x1F00),
        /// <summary>
        /// Original was GL_RENDERER = 0x1F01
        /// </summary>
        Renderer = ((int)0x1F01),
        /// <summary>
        /// Original was GL_VERSION = 0x1F02
        /// </summary>
        Version = ((int)0x1F02),
        /// <summary>
        /// Original was GL_EXTENSIONS = 0x1F03
        /// </summary>
        Extensions = ((int)0x1F03),
        /// <summary>
        /// Original was GL_SHADING_LANGUAGE_VERSION = 0x8B8C
        /// </summary>
        ShadingLanguageVersion = ((int)0x8B8C),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SubroutineParameterName : int
    {
        /// <summary>
        /// Original was GL_UNIFORM_SIZE = 0x8A38
        /// </summary>
        UniformSize = ((int)0x8A38),
        /// <summary>
        /// Original was GL_UNIFORM_NAME_LENGTH = 0x8A39
        /// </summary>
        UniformNameLength = ((int)0x8A39),
        /// <summary>
        /// Original was GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A
        /// </summary>
        NumCompatibleSubroutines = ((int)0x8E4A),
        /// <summary>
        /// Original was GL_COMPATIBLE_SUBROUTINES = 0x8E4B
        /// </summary>
        CompatibleSubroutines = ((int)0x8E4B),
    }

    /// <summary>
    /// Used in GL.Apple.FenceSync
    /// </summary>
    public enum SyncCondition : int
    {
        /// <summary>
        /// Original was GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117
        /// </summary>
        SyncGpuCommandsComplete = ((int)0x9117),
    }

    /// <summary>
    /// Used in GL.Apple.ClientWaitSync
    /// </summary>
    [Flags]
    public enum SyncObjectMask : int
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
    public enum SyncParameterName : int
    {
        /// <summary>
        /// Original was GL_OBJECT_TYPE = 0x9112
        /// </summary>
        ObjectType = ((int)0x9112),
        /// <summary>
        /// Original was GL_SYNC_CONDITION = 0x9113
        /// </summary>
        SyncCondition = ((int)0x9113),
        /// <summary>
        /// Original was GL_SYNC_STATUS = 0x9114
        /// </summary>
        SyncStatus = ((int)0x9114),
        /// <summary>
        /// Original was GL_SYNC_FLAGS = 0x9115
        /// </summary>
        SyncFlags = ((int)0x9115),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SyncStatus : int
    {
        /// <summary>
        /// Original was GL_ALREADY_SIGNALED = 0x911A
        /// </summary>
        AlreadySignaled = ((int)0x911A),
        /// <summary>
        /// Original was GL_TIMEOUT_EXPIRED = 0x911B
        /// </summary>
        TimeoutExpired = ((int)0x911B),
        /// <summary>
        /// Original was GL_CONDITION_SATISFIED = 0x911C
        /// </summary>
        ConditionSatisfied = ((int)0x911C),
        /// <summary>
        /// Original was GL_WAIT_FAILED = 0x911D
        /// </summary>
        WaitFailed = ((int)0x911D),
    }

    /// <summary>
    /// Used in GL.TexCoordPointer
    /// </summary>
    public enum TexCoordPointerType : int
    {
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = ((int)0x1402),
        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = ((int)0x1404),
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406),
        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = ((int)0x140A),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Obsolete("Use enum with correct capitalisation instead.")]
    public enum TextureCombineDot3 : int
    {
        /// <summary>
        /// Original was GL_ALPHA_SCALE = 0x0D1C
        /// </summary>
        AlphaScale = ((int)0x0D1C),
        /// <summary>
        /// Original was GL_SUBTRACT = 0x84E7
        /// </summary>
        Subtract = ((int)0x84E7),
        /// <summary>
        /// Original was GL_COMBINE = 0x8570
        /// </summary>
        Combine = ((int)0x8570),
        /// <summary>
        /// Original was GL_COMBINE_RGB = 0x8571
        /// </summary>
        CombineRgb = ((int)0x8571),
        /// <summary>
        /// Original was GL_COMBINE_ALPHA = 0x8572
        /// </summary>
        CombineAlpha = ((int)0x8572),
        /// <summary>
        /// Original was GL_RGB_SCALE = 0x8573
        /// </summary>
        RgbScale = ((int)0x8573),
        /// <summary>
        /// Original was GL_ADD_SIGNED = 0x8574
        /// </summary>
        AddSigned = ((int)0x8574),
        /// <summary>
        /// Original was GL_INTERPOLATE = 0x8575
        /// </summary>
        Interpolate = ((int)0x8575),
        /// <summary>
        /// Original was GL_CONSTANT = 0x8576
        /// </summary>
        Constant = ((int)0x8576),
        /// <summary>
        /// Original was GL_PRIMARY_COLOR = 0x8577
        /// </summary>
        PrimaryColor = ((int)0x8577),
        /// <summary>
        /// Original was GL_PREVIOUS = 0x8578
        /// </summary>
        Previous = ((int)0x8578),
        /// <summary>
        /// Original was GL_SRC0_RGB = 0x8580
        /// </summary>
        Src0Rgb = ((int)0x8580),
        /// <summary>
        /// Original was GL_SRC1_RGB = 0x8581
        /// </summary>
        Src1Rgb = ((int)0x8581),
        /// <summary>
        /// Original was GL_SRC2_RGB = 0x8582
        /// </summary>
        Src2Rgb = ((int)0x8582),
        /// <summary>
        /// Original was GL_SRC0_ALPHA = 0x8588
        /// </summary>
        Src0Alpha = ((int)0x8588),
        /// <summary>
        /// Original was GL_SRC1_ALPHA = 0x8589
        /// </summary>
        Src1Alpha = ((int)0x8589),
        /// <summary>
        /// Original was GL_SRC2_ALPHA = 0x858A
        /// </summary>
        Src2Alpha = ((int)0x858A),
        /// <summary>
        /// Original was GL_OPERAND0_RGB = 0x8590
        /// </summary>
        Operand0Rgb = ((int)0x8590),
        /// <summary>
        /// Original was GL_OPERAND1_RGB = 0x8591
        /// </summary>
        Operand1Rgb = ((int)0x8591),
        /// <summary>
        /// Original was GL_OPERAND2_RGB = 0x8592
        /// </summary>
        Operand2Rgb = ((int)0x8592),
        /// <summary>
        /// Original was GL_OPERAND0_ALPHA = 0x8598
        /// </summary>
        Operand0Alpha = ((int)0x8598),
        /// <summary>
        /// Original was GL_OPERAND1_ALPHA = 0x8599
        /// </summary>
        Operand1Alpha = ((int)0x8599),
        /// <summary>
        /// Original was GL_OPERAND2_ALPHA = 0x859A
        /// </summary>
        Operand2Alpha = ((int)0x859A),
        /// <summary>
        /// Original was GL_DOT3_RGB = 0x86AE
        /// </summary>
        Dot3Rgb = ((int)0x86AE),
        /// <summary>
        /// Original was GL_DOT3_RGBA = 0x86AF
        /// </summary>
        Dot3Rgba = ((int)0x86AF),
    }

    /// <summary>
    /// Used in GL.Oes.GetTexGen, GL.Oes.GetTexGenx and 2 other functions
    /// </summary>
    public enum TextureCoordName : int
    {
        /// <summary>
        /// Original was GL_S = 0x2000
        /// </summary>
        S = ((int)0x2000),
        /// <summary>
        /// Original was GL_T = 0x2001
        /// </summary>
        T = ((int)0x2001),
        /// <summary>
        /// Original was GL_R = 0x2002
        /// </summary>
        R = ((int)0x2002),
        /// <summary>
        /// Original was GL_Q = 0x2003
        /// </summary>
        Q = ((int)0x2003),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureEnvMode : int
    {
        /// <summary>
        /// Original was GL_ADD = 0x0104
        /// </summary>
        Add = ((int)0x0104),
        /// <summary>
        /// Original was GL_BLEND = 0x0BE2
        /// </summary>
        Blend = ((int)0x0BE2),
        /// <summary>
        /// Original was GL_MODULATE = 0x2100
        /// </summary>
        Modulate = ((int)0x2100),
        /// <summary>
        /// Original was GL_DECAL = 0x2101
        /// </summary>
        Decal = ((int)0x2101),
        /// <summary>
        /// Original was GL_REPLACE_EXT = 0x8062
        /// </summary>
        ReplaceExt = ((int)0x8062),
        /// <summary>
        /// Original was GL_TEXTURE_ENV_BIAS_SGIX = 0x80BE
        /// </summary>
        TextureEnvBiasSgix = ((int)0x80BE),
    }

    /// <summary>
    /// Used in GL.GetTexEnv, GL.GetTexEnvx and 4 other functions
    /// </summary>
    public enum TextureEnvParameter : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_ENV_MODE = 0x2200
        /// </summary>
        TextureEnvMode = ((int)0x2200),
        /// <summary>
        /// Original was GL_TEXTURE_ENV_COLOR = 0x2201
        /// </summary>
        TextureEnvColor = ((int)0x2201),
    }

    /// <summary>
    /// Used in GL.GetTexEnv, GL.GetTexEnvx and 4 other functions
    /// </summary>
    public enum TextureEnvTarget : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_ENV = 0x2300
        /// </summary>
        TextureEnv = ((int)0x2300),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureFilterFuncSgis : int
    {
        /// <summary>
        /// Original was GL_FILTER4_SGIS = 0x8146
        /// </summary>
        Filter4Sgis = ((int)0x8146),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureGenMode : int
    {
        /// <summary>
        /// Original was GL_EYE_LINEAR = 0x2400
        /// </summary>
        EyeLinear = ((int)0x2400),
        /// <summary>
        /// Original was GL_OBJECT_LINEAR = 0x2401
        /// </summary>
        ObjectLinear = ((int)0x2401),
        /// <summary>
        /// Original was GL_SPHERE_MAP = 0x2402
        /// </summary>
        SphereMap = ((int)0x2402),
        /// <summary>
        /// Original was GL_EYE_DISTANCE_TO_POINT_SGIS = 0x81F0
        /// </summary>
        EyeDistanceToPointSgis = ((int)0x81F0),
        /// <summary>
        /// Original was GL_OBJECT_DISTANCE_TO_POINT_SGIS = 0x81F1
        /// </summary>
        ObjectDistanceToPointSgis = ((int)0x81F1),
        /// <summary>
        /// Original was GL_EYE_DISTANCE_TO_LINE_SGIS = 0x81F2
        /// </summary>
        EyeDistanceToLineSgis = ((int)0x81F2),
        /// <summary>
        /// Original was GL_OBJECT_DISTANCE_TO_LINE_SGIS = 0x81F3
        /// </summary>
        ObjectDistanceToLineSgis = ((int)0x81F3),
    }

    /// <summary>
    /// Used in GL.Oes.GetTexGen, GL.Oes.GetTexGenx and 2 other functions
    /// </summary>
    public enum TextureGenParameter : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_GEN_MODE = 0x2500
        /// </summary>
        TextureGenMode = ((int)0x2500),
        /// <summary>
        /// Original was GL_OBJECT_PLANE = 0x2501
        /// </summary>
        ObjectPlane = ((int)0x2501),
        /// <summary>
        /// Original was GL_EYE_PLANE = 0x2502
        /// </summary>
        EyePlane = ((int)0x2502),
        /// <summary>
        /// Original was GL_EYE_POINT_SGIS = 0x81F4
        /// </summary>
        EyePointSgis = ((int)0x81F4),
        /// <summary>
        /// Original was GL_OBJECT_POINT_SGIS = 0x81F5
        /// </summary>
        ObjectPointSgis = ((int)0x81F5),
        /// <summary>
        /// Original was GL_EYE_LINE_SGIS = 0x81F6
        /// </summary>
        EyeLineSgis = ((int)0x81F6),
        /// <summary>
        /// Original was GL_OBJECT_LINE_SGIS = 0x81F7
        /// </summary>
        ObjectLineSgis = ((int)0x81F7),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureLayout : int
    {
        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT = 0x9530
        /// </summary>
        LayoutDepthReadOnlyStencilAttachmentExt = ((int)0x9530),
        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT = 0x9531
        /// </summary>
        LayoutDepthAttachmentStencilReadOnlyExt = ((int)0x9531),
        /// <summary>
        /// Original was GL_LAYOUT_GENERAL_EXT = 0x958D
        /// </summary>
        LayoutGeneralExt = ((int)0x958D),
        /// <summary>
        /// Original was GL_LAYOUT_COLOR_ATTACHMENT_EXT = 0x958E
        /// </summary>
        LayoutColorAttachmentExt = ((int)0x958E),
        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT = 0x958F
        /// </summary>
        LayoutDepthStencilAttachmentExt = ((int)0x958F),
        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT = 0x9590
        /// </summary>
        LayoutDepthStencilReadOnlyExt = ((int)0x9590),
        /// <summary>
        /// Original was GL_LAYOUT_SHADER_READ_ONLY_EXT = 0x9591
        /// </summary>
        LayoutShaderReadOnlyExt = ((int)0x9591),
        /// <summary>
        /// Original was GL_LAYOUT_TRANSFER_SRC_EXT = 0x9592
        /// </summary>
        LayoutTransferSrcExt = ((int)0x9592),
        /// <summary>
        /// Original was GL_LAYOUT_TRANSFER_DST_EXT = 0x9593
        /// </summary>
        LayoutTransferDstExt = ((int)0x9593),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureMagFilter : int
    {
        /// <summary>
        /// Original was GL_NEAREST = 0x2600
        /// </summary>
        Nearest = ((int)0x2600),
        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = ((int)0x2601),
        /// <summary>
        /// Original was GL_LINEAR_DETAIL_SGIS = 0x8097
        /// </summary>
        LinearDetailSgis = ((int)0x8097),
        /// <summary>
        /// Original was GL_LINEAR_DETAIL_ALPHA_SGIS = 0x8098
        /// </summary>
        LinearDetailAlphaSgis = ((int)0x8098),
        /// <summary>
        /// Original was GL_LINEAR_DETAIL_COLOR_SGIS = 0x8099
        /// </summary>
        LinearDetailColorSgis = ((int)0x8099),
        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_SGIS = 0x80AD
        /// </summary>
        LinearSharpenSgis = ((int)0x80AD),
        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE
        /// </summary>
        LinearSharpenAlphaSgis = ((int)0x80AE),
        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_COLOR_SGIS = 0x80AF
        /// </summary>
        LinearSharpenColorSgis = ((int)0x80AF),
        /// <summary>
        /// Original was GL_FILTER4_SGIS = 0x8146
        /// </summary>
        Filter4Sgis = ((int)0x8146),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184
        /// </summary>
        PixelTexGenQCeilingSgix = ((int)0x8184),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185
        /// </summary>
        PixelTexGenQRoundSgix = ((int)0x8185),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186
        /// </summary>
        PixelTexGenQFloorSgix = ((int)0x8186),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureMinFilter : int
    {
        /// <summary>
        /// Original was GL_NEAREST = 0x2600
        /// </summary>
        Nearest = ((int)0x2600),
        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = ((int)0x2601),
        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_NEAREST = 0x2700
        /// </summary>
        NearestMipmapNearest = ((int)0x2700),
        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_NEAREST = 0x2701
        /// </summary>
        LinearMipmapNearest = ((int)0x2701),
        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_LINEAR = 0x2702
        /// </summary>
        NearestMipmapLinear = ((int)0x2702),
        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_LINEAR = 0x2703
        /// </summary>
        LinearMipmapLinear = ((int)0x2703),
        /// <summary>
        /// Original was GL_FILTER4_SGIS = 0x8146
        /// </summary>
        Filter4Sgis = ((int)0x8146),
        /// <summary>
        /// Original was GL_LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170
        /// </summary>
        LinearClipmapLinearSgix = ((int)0x8170),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184
        /// </summary>
        PixelTexGenQCeilingSgix = ((int)0x8184),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185
        /// </summary>
        PixelTexGenQRoundSgix = ((int)0x8185),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186
        /// </summary>
        PixelTexGenQFloorSgix = ((int)0x8186),
        /// <summary>
        /// Original was GL_NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D
        /// </summary>
        NearestClipmapNearestSgix = ((int)0x844D),
        /// <summary>
        /// Original was GL_NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E
        /// </summary>
        NearestClipmapLinearSgix = ((int)0x844E),
        /// <summary>
        /// Original was GL_LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F
        /// </summary>
        LinearClipmapNearestSgix = ((int)0x844F),
    }

    /// <summary>
    /// Used in GL.TexParameter
    /// </summary>
    public enum TextureParameterName : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_WIDTH = 0x1000
        /// </summary>
        TextureWidth = ((int)0x1000),
        /// <summary>
        /// Original was GL_TEXTURE_HEIGHT = 0x1001
        /// </summary>
        TextureHeight = ((int)0x1001),
        /// <summary>
        /// Original was GL_TEXTURE_COMPONENTS = 0x1003
        /// </summary>
        TextureComponents = ((int)0x1003),
        /// <summary>
        /// Original was GL_TEXTURE_INTERNAL_FORMAT = 0x1003
        /// </summary>
        TextureInternalFormat = ((int)0x1003),
        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR = 0x1004
        /// </summary>
        TextureBorderColor = ((int)0x1004),
        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR_NV = 0x1004
        /// </summary>
        TextureBorderColorNv = ((int)0x1004),
        /// <summary>
        /// Original was GL_TEXTURE_BORDER = 0x1005
        /// </summary>
        TextureBorder = ((int)0x1005),
        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = ((int)0x2800),
        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = ((int)0x2801),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = ((int)0x2802),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = ((int)0x2803),
        /// <summary>
        /// Original was GL_TEXTURE_RED_SIZE = 0x805C
        /// </summary>
        TextureRedSize = ((int)0x805C),
        /// <summary>
        /// Original was GL_TEXTURE_GREEN_SIZE = 0x805D
        /// </summary>
        TextureGreenSize = ((int)0x805D),
        /// <summary>
        /// Original was GL_TEXTURE_BLUE_SIZE = 0x805E
        /// </summary>
        TextureBlueSize = ((int)0x805E),
        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_SIZE = 0x805F
        /// </summary>
        TextureAlphaSize = ((int)0x805F),
        /// <summary>
        /// Original was GL_TEXTURE_LUMINANCE_SIZE = 0x8060
        /// </summary>
        TextureLuminanceSize = ((int)0x8060),
        /// <summary>
        /// Original was GL_TEXTURE_INTENSITY_SIZE = 0x8061
        /// </summary>
        TextureIntensitySize = ((int)0x8061),
        /// <summary>
        /// Original was GL_TEXTURE_PRIORITY = 0x8066
        /// </summary>
        TexturePriority = ((int)0x8066),
        /// <summary>
        /// Original was GL_TEXTURE_PRIORITY_EXT = 0x8066
        /// </summary>
        TexturePriorityExt = ((int)0x8066),
        /// <summary>
        /// Original was GL_TEXTURE_RESIDENT = 0x8067
        /// </summary>
        TextureResident = ((int)0x8067),
        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_EXT = 0x8071
        /// </summary>
        TextureDepthExt = ((int)0x8071),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R = 0x8072
        /// </summary>
        TextureWrapR = ((int)0x8072),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R_EXT = 0x8072
        /// </summary>
        TextureWrapRExt = ((int)0x8072),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R_OES = 0x8072
        /// </summary>
        TextureWrapROes = ((int)0x8072),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_LEVEL_SGIS = 0x809A
        /// </summary>
        DetailTextureLevelSgis = ((int)0x809A),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_MODE_SGIS = 0x809B
        /// </summary>
        DetailTextureModeSgis = ((int)0x809B),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C
        /// </summary>
        DetailTextureFuncPointsSgis = ((int)0x809C),
        /// <summary>
        /// Original was GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0
        /// </summary>
        SharpenTextureFuncPointsSgis = ((int)0x80B0),
        /// <summary>
        /// Original was GL_SHADOW_AMBIENT_SGIX = 0x80BF
        /// </summary>
        ShadowAmbientSgix = ((int)0x80BF),
        /// <summary>
        /// Original was GL_DUAL_TEXTURE_SELECT_SGIS = 0x8124
        /// </summary>
        DualTextureSelectSgis = ((int)0x8124),
        /// <summary>
        /// Original was GL_QUAD_TEXTURE_SELECT_SGIS = 0x8125
        /// </summary>
        QuadTextureSelectSgis = ((int)0x8125),
        /// <summary>
        /// Original was GL_TEXTURE_4DSIZE_SGIS = 0x8136
        /// </summary>
        Texture4DsizeSgis = ((int)0x8136),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_Q_SGIS = 0x8137
        /// </summary>
        TextureWrapQSgis = ((int)0x8137),
        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD = 0x813A
        /// </summary>
        TextureMinLod = ((int)0x813A),
        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD_SGIS = 0x813A
        /// </summary>
        TextureMinLodSgis = ((int)0x813A),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD = 0x813B
        /// </summary>
        TextureMaxLod = ((int)0x813B),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD_SGIS = 0x813B
        /// </summary>
        TextureMaxLodSgis = ((int)0x813B),
        /// <summary>
        /// Original was GL_TEXTURE_BASE_LEVEL = 0x813C
        /// </summary>
        TextureBaseLevel = ((int)0x813C),
        /// <summary>
        /// Original was GL_TEXTURE_BASE_LEVEL_SGIS = 0x813C
        /// </summary>
        TextureBaseLevelSgis = ((int)0x813C),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL = 0x813D
        /// </summary>
        TextureMaxLevel = ((int)0x813D),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL_SGIS = 0x813D
        /// </summary>
        TextureMaxLevelSgis = ((int)0x813D),
        /// <summary>
        /// Original was GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147
        /// </summary>
        TextureFilter4SizeSgis = ((int)0x8147),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171
        /// </summary>
        TextureClipmapCenterSgix = ((int)0x8171),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172
        /// </summary>
        TextureClipmapFrameSgix = ((int)0x8172),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173
        /// </summary>
        TextureClipmapOffsetSgix = ((int)0x8173),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174
        /// </summary>
        TextureClipmapVirtualDepthSgix = ((int)0x8174),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175
        /// </summary>
        TextureClipmapLodOffsetSgix = ((int)0x8175),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176
        /// </summary>
        TextureClipmapDepthSgix = ((int)0x8176),
        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179
        /// </summary>
        PostTextureFilterBiasSgix = ((int)0x8179),
        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A
        /// </summary>
        PostTextureFilterScaleSgix = ((int)0x817A),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_S_SGIX = 0x818E
        /// </summary>
        TextureLodBiasSSgix = ((int)0x818E),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_T_SGIX = 0x818F
        /// </summary>
        TextureLodBiasTSgix = ((int)0x818F),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_R_SGIX = 0x8190
        /// </summary>
        TextureLodBiasRSgix = ((int)0x8190),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP = 0x8191
        /// </summary>
        GenerateMipmap = ((int)0x8191),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_SGIS = 0x8191
        /// </summary>
        GenerateMipmapSgis = ((int)0x8191),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_SGIX = 0x819A
        /// </summary>
        TextureCompareSgix = ((int)0x819A),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B
        /// </summary>
        TextureCompareOperatorSgix = ((int)0x819B),
        /// <summary>
        /// Original was GL_TEXTURE_LEQUAL_R_SGIX = 0x819C
        /// </summary>
        TextureLequalRSgix = ((int)0x819C),
        /// <summary>
        /// Original was GL_TEXTURE_GEQUAL_R_SGIX = 0x819D
        /// </summary>
        TextureGequalRSgix = ((int)0x819D),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_S_SGIX = 0x8369
        /// </summary>
        TextureMaxClampSSgix = ((int)0x8369),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_T_SGIX = 0x836A
        /// </summary>
        TextureMaxClampTSgix = ((int)0x836A),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_R_SGIX = 0x836B
        /// </summary>
        TextureMaxClampRSgix = ((int)0x836B),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS = 0x8501
        /// </summary>
        TextureLodBias = ((int)0x8501),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_MODE = 0x884C
        /// </summary>
        TextureCompareMode = ((int)0x884C),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
        /// </summary>
        TextureCompareFunc = ((int)0x884D),
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_R = 0x8E42
        /// </summary>
        TextureSwizzleR = ((int)0x8E42),
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_G = 0x8E43
        /// </summary>
        TextureSwizzleG = ((int)0x8E43),
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_B = 0x8E44
        /// </summary>
        TextureSwizzleB = ((int)0x8E44),
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_A = 0x8E45
        /// </summary>
        TextureSwizzleA = ((int)0x8E45),
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_RGBA = 0x8E46
        /// </summary>
        TextureSwizzleRgba = ((int)0x8E46),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA
        /// </summary>
        DepthStencilTextureMode = ((int)0x90EA),
        /// <summary>
        /// Original was GL_TEXTURE_TILING_EXT = 0x9580
        /// </summary>
        TextureTilingExt = ((int)0x9580),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum TextureStorageMaskAmd : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_STORAGE_SPARSE_BIT_AMD = 0x00000001
        /// </summary>
        TextureStorageSparseBitAmd = ((int)0x00000001),
    }

    /// <summary>
    /// Used in GL.BindTexture, GL.CompressedTexImage2D and 19 other functions
    /// </summary>
    public enum TextureTarget : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_1D = 0x0DE0
        /// </summary>
        Texture1D = ((int)0x0DE0),
        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = ((int)0x0DE1),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D = 0x8063
        /// </summary>
        ProxyTexture1D = ((int)0x8063),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_EXT = 0x8063
        /// </summary>
        ProxyTexture1DExt = ((int)0x8063),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D = 0x8064
        /// </summary>
        ProxyTexture2D = ((int)0x8064),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_EXT = 0x8064
        /// </summary>
        ProxyTexture2DExt = ((int)0x8064),
        /// <summary>
        /// Original was GL_TEXTURE_3D = 0x806F
        /// </summary>
        Texture3D = ((int)0x806F),
        /// <summary>
        /// Original was GL_TEXTURE_3D_EXT = 0x806F
        /// </summary>
        Texture3DExt = ((int)0x806F),
        /// <summary>
        /// Original was GL_TEXTURE_3D_OES = 0x806F
        /// </summary>
        Texture3DOes = ((int)0x806F),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_3D = 0x8070
        /// </summary>
        ProxyTexture3D = ((int)0x8070),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_3D_EXT = 0x8070
        /// </summary>
        ProxyTexture3DExt = ((int)0x8070),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_2D_SGIS = 0x8095
        /// </summary>
        DetailTexture2DSgis = ((int)0x8095),
        /// <summary>
        /// Original was GL_TEXTURE_4D_SGIS = 0x8134
        /// </summary>
        Texture4DSgis = ((int)0x8134),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_4D_SGIS = 0x8135
        /// </summary>
        ProxyTexture4DSgis = ((int)0x8135),
        /// <summary>
        /// Original was GL_TEXTURE_RECTANGLE = 0x84F5
        /// </summary>
        TextureRectangle = ((int)0x84F5),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE = 0x84F7
        /// </summary>
        ProxyTextureRectangle = ((int)0x84F7),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7
        /// </summary>
        ProxyTextureRectangleArb = ((int)0x84F7),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE_NV = 0x84F7
        /// </summary>
        ProxyTextureRectangleNv = ((int)0x84F7),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP = 0x8513
        /// </summary>
        TextureCubeMap = ((int)0x8513),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515
        /// </summary>
        TextureCubeMapPositiveX = ((int)0x8515),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516
        /// </summary>
        TextureCubeMapNegativeX = ((int)0x8516),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517
        /// </summary>
        TextureCubeMapPositiveY = ((int)0x8517),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518
        /// </summary>
        TextureCubeMapNegativeY = ((int)0x8518),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519
        /// </summary>
        TextureCubeMapPositiveZ = ((int)0x8519),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A
        /// </summary>
        TextureCubeMapNegativeZ = ((int)0x851A),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP = 0x851B
        /// </summary>
        ProxyTextureCubeMap = ((int)0x851B),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B
        /// </summary>
        ProxyTextureCubeMapArb = ((int)0x851B),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B
        /// </summary>
        ProxyTextureCubeMapExt = ((int)0x851B),
        /// <summary>
        /// Original was GL_TEXTURE_1D_ARRAY = 0x8C18
        /// </summary>
        Texture1DArray = ((int)0x8C18),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19
        /// </summary>
        ProxyTexture1DArray = ((int)0x8C19),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19
        /// </summary>
        ProxyTexture1DArrayExt = ((int)0x8C19),
        /// <summary>
        /// Original was GL_TEXTURE_2D_ARRAY = 0x8C1A
        /// </summary>
        Texture2DArray = ((int)0x8C1A),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B
        /// </summary>
        ProxyTexture2DArray = ((int)0x8C1B),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B
        /// </summary>
        ProxyTexture2DArrayExt = ((int)0x8C1B),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009
        /// </summary>
        TextureCubeMapArray = ((int)0x9009),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009
        /// </summary>
        TextureCubeMapArrayArb = ((int)0x9009),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_EXT = 0x9009
        /// </summary>
        TextureCubeMapArrayExt = ((int)0x9009),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_OES = 0x9009
        /// </summary>
        TextureCubeMapArrayOes = ((int)0x9009),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B
        /// </summary>
        ProxyTextureCubeMapArray = ((int)0x900B),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B
        /// </summary>
        ProxyTextureCubeMapArrayArb = ((int)0x900B),
        /// <summary>
        /// Original was GL_TEXTURE_2D_MULTISAMPLE = 0x9100
        /// </summary>
        Texture2DMultisample = ((int)0x9100),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101
        /// </summary>
        ProxyTexture2DMultisample = ((int)0x9101),
        /// <summary>
        /// Original was GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102
        /// </summary>
        Texture2DMultisampleArray = ((int)0x9102),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103
        /// </summary>
        ProxyTexture2DMultisampleArray = ((int)0x9103),
    }

    /// <summary>
    /// Used in GL.ActiveTexture, GL.ClientActiveTexture and 10 other functions
    /// </summary>
    public enum TextureUnit : int
    {
        /// <summary>
        /// Original was GL_TEXTURE0 = 0x84C0
        /// </summary>
        Texture0 = ((int)0x84C0),
        /// <summary>
        /// Original was GL_TEXTURE1 = 0x84C1
        /// </summary>
        Texture1 = ((int)0x84C1),
        /// <summary>
        /// Original was GL_TEXTURE2 = 0x84C2
        /// </summary>
        Texture2 = ((int)0x84C2),
        /// <summary>
        /// Original was GL_TEXTURE3 = 0x84C3
        /// </summary>
        Texture3 = ((int)0x84C3),
        /// <summary>
        /// Original was GL_TEXTURE4 = 0x84C4
        /// </summary>
        Texture4 = ((int)0x84C4),
        /// <summary>
        /// Original was GL_TEXTURE5 = 0x84C5
        /// </summary>
        Texture5 = ((int)0x84C5),
        /// <summary>
        /// Original was GL_TEXTURE6 = 0x84C6
        /// </summary>
        Texture6 = ((int)0x84C6),
        /// <summary>
        /// Original was GL_TEXTURE7 = 0x84C7
        /// </summary>
        Texture7 = ((int)0x84C7),
        /// <summary>
        /// Original was GL_TEXTURE8 = 0x84C8
        /// </summary>
        Texture8 = ((int)0x84C8),
        /// <summary>
        /// Original was GL_TEXTURE9 = 0x84C9
        /// </summary>
        Texture9 = ((int)0x84C9),
        /// <summary>
        /// Original was GL_TEXTURE10 = 0x84CA
        /// </summary>
        Texture10 = ((int)0x84CA),
        /// <summary>
        /// Original was GL_TEXTURE11 = 0x84CB
        /// </summary>
        Texture11 = ((int)0x84CB),
        /// <summary>
        /// Original was GL_TEXTURE12 = 0x84CC
        /// </summary>
        Texture12 = ((int)0x84CC),
        /// <summary>
        /// Original was GL_TEXTURE13 = 0x84CD
        /// </summary>
        Texture13 = ((int)0x84CD),
        /// <summary>
        /// Original was GL_TEXTURE14 = 0x84CE
        /// </summary>
        Texture14 = ((int)0x84CE),
        /// <summary>
        /// Original was GL_TEXTURE15 = 0x84CF
        /// </summary>
        Texture15 = ((int)0x84CF),
        /// <summary>
        /// Original was GL_TEXTURE16 = 0x84D0
        /// </summary>
        Texture16 = ((int)0x84D0),
        /// <summary>
        /// Original was GL_TEXTURE17 = 0x84D1
        /// </summary>
        Texture17 = ((int)0x84D1),
        /// <summary>
        /// Original was GL_TEXTURE18 = 0x84D2
        /// </summary>
        Texture18 = ((int)0x84D2),
        /// <summary>
        /// Original was GL_TEXTURE19 = 0x84D3
        /// </summary>
        Texture19 = ((int)0x84D3),
        /// <summary>
        /// Original was GL_TEXTURE20 = 0x84D4
        /// </summary>
        Texture20 = ((int)0x84D4),
        /// <summary>
        /// Original was GL_TEXTURE21 = 0x84D5
        /// </summary>
        Texture21 = ((int)0x84D5),
        /// <summary>
        /// Original was GL_TEXTURE22 = 0x84D6
        /// </summary>
        Texture22 = ((int)0x84D6),
        /// <summary>
        /// Original was GL_TEXTURE23 = 0x84D7
        /// </summary>
        Texture23 = ((int)0x84D7),
        /// <summary>
        /// Original was GL_TEXTURE24 = 0x84D8
        /// </summary>
        Texture24 = ((int)0x84D8),
        /// <summary>
        /// Original was GL_TEXTURE25 = 0x84D9
        /// </summary>
        Texture25 = ((int)0x84D9),
        /// <summary>
        /// Original was GL_TEXTURE26 = 0x84DA
        /// </summary>
        Texture26 = ((int)0x84DA),
        /// <summary>
        /// Original was GL_TEXTURE27 = 0x84DB
        /// </summary>
        Texture27 = ((int)0x84DB),
        /// <summary>
        /// Original was GL_TEXTURE28 = 0x84DC
        /// </summary>
        Texture28 = ((int)0x84DC),
        /// <summary>
        /// Original was GL_TEXTURE29 = 0x84DD
        /// </summary>
        Texture29 = ((int)0x84DD),
        /// <summary>
        /// Original was GL_TEXTURE30 = 0x84DE
        /// </summary>
        Texture30 = ((int)0x84DE),
        /// <summary>
        /// Original was GL_TEXTURE31 = 0x84DF
        /// </summary>
        Texture31 = ((int)0x84DF),
        /// <summary>
        /// Original was GL_ACTIVE_TEXTURE = 0x84E0
        /// </summary>
        ActiveTexture = ((int)0x84E0),
        /// <summary>
        /// Original was GL_CLIENT_ACTIVE_TEXTURE = 0x84E1
        /// </summary>
        ClientActiveTexture = ((int)0x84E1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureWrapMode : int
    {
        /// <summary>
        /// Original was GL_CLAMP = 0x2900
        /// </summary>
        Clamp = ((int)0x2900),
        /// <summary>
        /// Original was GL_REPEAT = 0x2901
        /// </summary>
        Repeat = ((int)0x2901),
        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER = 0x812D
        /// </summary>
        ClampToBorder = ((int)0x812D),
        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER_ARB = 0x812D
        /// </summary>
        ClampToBorderArb = ((int)0x812D),
        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER_NV = 0x812D
        /// </summary>
        ClampToBorderNv = ((int)0x812D),
        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER_SGIS = 0x812D
        /// </summary>
        ClampToBorderSgis = ((int)0x812D),
        /// <summary>
        /// Original was GL_CLAMP_TO_EDGE = 0x812F
        /// </summary>
        ClampToEdge = ((int)0x812F),
        /// <summary>
        /// Original was GL_CLAMP_TO_EDGE_SGIS = 0x812F
        /// </summary>
        ClampToEdgeSgis = ((int)0x812F),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TransformFeedbackPName : int
    {
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84
        /// </summary>
        TransformFeedbackBufferStart = ((int)0x8C84),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85
        /// </summary>
        TransformFeedbackBufferSize = ((int)0x8C85),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F
        /// </summary>
        TransformFeedbackBufferBinding = ((int)0x8C8F),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23
        /// </summary>
        TransformFeedbackPaused = ((int)0x8E23),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24
        /// </summary>
        TransformFeedbackActive = ((int)0x8E24),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TypeEnum : int
    {
        /// <summary>
        /// Original was GL_QUERY_WAIT = 0x8E13
        /// </summary>
        QueryWait = ((int)0x8E13),
        /// <summary>
        /// Original was GL_QUERY_NO_WAIT = 0x8E14
        /// </summary>
        QueryNoWait = ((int)0x8E14),
        /// <summary>
        /// Original was GL_QUERY_BY_REGION_WAIT = 0x8E15
        /// </summary>
        QueryByRegionWait = ((int)0x8E15),
        /// <summary>
        /// Original was GL_QUERY_BY_REGION_NO_WAIT = 0x8E16
        /// </summary>
        QueryByRegionNoWait = ((int)0x8E16),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum UniformBlockPName : int
    {
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0
        /// </summary>
        UniformBlockReferencedByTessControlShader = ((int)0x84F0),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1
        /// </summary>
        UniformBlockReferencedByTessEvaluationShader = ((int)0x84F1),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_BINDING = 0x8A3F
        /// </summary>
        UniformBlockBinding = ((int)0x8A3F),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40
        /// </summary>
        UniformBlockDataSize = ((int)0x8A40),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41
        /// </summary>
        UniformBlockNameLength = ((int)0x8A41),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42
        /// </summary>
        UniformBlockActiveUniforms = ((int)0x8A42),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43
        /// </summary>
        UniformBlockActiveUniformIndices = ((int)0x8A43),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44
        /// </summary>
        UniformBlockReferencedByVertexShader = ((int)0x8A44),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45
        /// </summary>
        UniformBlockReferencedByGeometryShader = ((int)0x8A45),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46
        /// </summary>
        UniformBlockReferencedByFragmentShader = ((int)0x8A46),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC
        /// </summary>
        UniformBlockReferencedByComputeShader = ((int)0x90EC),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum UniformPName : int
    {
        /// <summary>
        /// Original was GL_UNIFORM_TYPE = 0x8A37
        /// </summary>
        UniformType = ((int)0x8A37),
        /// <summary>
        /// Original was GL_UNIFORM_SIZE = 0x8A38
        /// </summary>
        UniformSize = ((int)0x8A38),
        /// <summary>
        /// Original was GL_UNIFORM_NAME_LENGTH = 0x8A39
        /// </summary>
        UniformNameLength = ((int)0x8A39),
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_INDEX = 0x8A3A
        /// </summary>
        UniformBlockIndex = ((int)0x8A3A),
        /// <summary>
        /// Original was GL_UNIFORM_OFFSET = 0x8A3B
        /// </summary>
        UniformOffset = ((int)0x8A3B),
        /// <summary>
        /// Original was GL_UNIFORM_ARRAY_STRIDE = 0x8A3C
        /// </summary>
        UniformArrayStride = ((int)0x8A3C),
        /// <summary>
        /// Original was GL_UNIFORM_MATRIX_STRIDE = 0x8A3D
        /// </summary>
        UniformMatrixStride = ((int)0x8A3D),
        /// <summary>
        /// Original was GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E
        /// </summary>
        UniformIsRowMajor = ((int)0x8A3E),
        /// <summary>
        /// Original was GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA
        /// </summary>
        UniformAtomicCounterBufferIndex = ((int)0x92DA),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum UseProgramStageMask : int
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
        AllShaderBits = unchecked((int)0xFFFFFFFF),
        /// <summary>
        /// Original was GL_ALL_SHADER_BITS_EXT = 0xFFFFFFFF
        /// </summary>
        AllShaderBitsExt = unchecked((int)0xFFFFFFFF),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VersionEsCm10 : int
    {
        /// <summary>
        /// Original was GL_FALSE = 0
        /// </summary>
        False = ((int)0),
        /// <summary>
        /// Original was GL_NO_ERROR = 0
        /// </summary>
        NoError = ((int)0),
        /// <summary>
        /// Original was GL_ZERO = 0
        /// </summary>
        Zero = ((int)0),
        /// <summary>
        /// Original was GL_POINTS = 0x0000
        /// </summary>
        Points = ((int)0x0000),
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
        Lines = ((int)0x0001),
        /// <summary>
        /// Original was GL_LINE_LOOP = 0x0002
        /// </summary>
        LineLoop = ((int)0x0002),
        /// <summary>
        /// Original was GL_LINE_STRIP = 0x0003
        /// </summary>
        LineStrip = ((int)0x0003),
        /// <summary>
        /// Original was GL_TRIANGLES = 0x0004
        /// </summary>
        Triangles = ((int)0x0004),
        /// <summary>
        /// Original was GL_TRIANGLE_STRIP = 0x0005
        /// </summary>
        TriangleStrip = ((int)0x0005),
        /// <summary>
        /// Original was GL_TRIANGLE_FAN = 0x0006
        /// </summary>
        TriangleFan = ((int)0x0006),
        /// <summary>
        /// Original was GL_ADD = 0x0104
        /// </summary>
        Add = ((int)0x0104),
        /// <summary>
        /// Original was GL_NEVER = 0x0200
        /// </summary>
        Never = ((int)0x0200),
        /// <summary>
        /// Original was GL_LESS = 0x0201
        /// </summary>
        Less = ((int)0x0201),
        /// <summary>
        /// Original was GL_EQUAL = 0x0202
        /// </summary>
        Equal = ((int)0x0202),
        /// <summary>
        /// Original was GL_LEQUAL = 0x0203
        /// </summary>
        Lequal = ((int)0x0203),
        /// <summary>
        /// Original was GL_GREATER = 0x0204
        /// </summary>
        Greater = ((int)0x0204),
        /// <summary>
        /// Original was GL_NOTEQUAL = 0x0205
        /// </summary>
        Notequal = ((int)0x0205),
        /// <summary>
        /// Original was GL_GEQUAL = 0x0206
        /// </summary>
        Gequal = ((int)0x0206),
        /// <summary>
        /// Original was GL_ALWAYS = 0x0207
        /// </summary>
        Always = ((int)0x0207),
        /// <summary>
        /// Original was GL_SRC_COLOR = 0x0300
        /// </summary>
        SrcColor = ((int)0x0300),
        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_COLOR = 0x0301
        /// </summary>
        OneMinusSrcColor = ((int)0x0301),
        /// <summary>
        /// Original was GL_SRC_ALPHA = 0x0302
        /// </summary>
        SrcAlpha = ((int)0x0302),
        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_ALPHA = 0x0303
        /// </summary>
        OneMinusSrcAlpha = ((int)0x0303),
        /// <summary>
        /// Original was GL_DST_ALPHA = 0x0304
        /// </summary>
        DstAlpha = ((int)0x0304),
        /// <summary>
        /// Original was GL_ONE_MINUS_DST_ALPHA = 0x0305
        /// </summary>
        OneMinusDstAlpha = ((int)0x0305),
        /// <summary>
        /// Original was GL_DST_COLOR = 0x0306
        /// </summary>
        DstColor = ((int)0x0306),
        /// <summary>
        /// Original was GL_ONE_MINUS_DST_COLOR = 0x0307
        /// </summary>
        OneMinusDstColor = ((int)0x0307),
        /// <summary>
        /// Original was GL_SRC_ALPHA_SATURATE = 0x0308
        /// </summary>
        SrcAlphaSaturate = ((int)0x0308),
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = ((int)0x0404),
        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = ((int)0x0405),
        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = ((int)0x0408),
        /// <summary>
        /// Original was GL_INVALID_ENUM = 0x0500
        /// </summary>
        InvalidEnum = ((int)0x0500),
        /// <summary>
        /// Original was GL_INVALID_VALUE = 0x0501
        /// </summary>
        InvalidValue = ((int)0x0501),
        /// <summary>
        /// Original was GL_INVALID_OPERATION = 0x0502
        /// </summary>
        InvalidOperation = ((int)0x0502),
        /// <summary>
        /// Original was GL_STACK_OVERFLOW = 0x0503
        /// </summary>
        StackOverflow = ((int)0x0503),
        /// <summary>
        /// Original was GL_STACK_UNDERFLOW = 0x0504
        /// </summary>
        StackUnderflow = ((int)0x0504),
        /// <summary>
        /// Original was GL_OUT_OF_MEMORY = 0x0505
        /// </summary>
        OutOfMemory = ((int)0x0505),
        /// <summary>
        /// Original was GL_EXP = 0x0800
        /// </summary>
        Exp = ((int)0x0800),
        /// <summary>
        /// Original was GL_EXP2 = 0x0801
        /// </summary>
        Exp2 = ((int)0x0801),
        /// <summary>
        /// Original was GL_CW = 0x0900
        /// </summary>
        Cw = ((int)0x0900),
        /// <summary>
        /// Original was GL_CCW = 0x0901
        /// </summary>
        Ccw = ((int)0x0901),
        /// <summary>
        /// Original was GL_CURRENT_COLOR = 0x0B00
        /// </summary>
        CurrentColor = ((int)0x0B00),
        /// <summary>
        /// Original was GL_CURRENT_NORMAL = 0x0B02
        /// </summary>
        CurrentNormal = ((int)0x0B02),
        /// <summary>
        /// Original was GL_CURRENT_TEXTURE_COORDS = 0x0B03
        /// </summary>
        CurrentTextureCoords = ((int)0x0B03),
        /// <summary>
        /// Original was GL_POINT_SMOOTH = 0x0B10
        /// </summary>
        PointSmooth = ((int)0x0B10),
        /// <summary>
        /// Original was GL_POINT_SIZE = 0x0B11
        /// </summary>
        PointSize = ((int)0x0B11),
        /// <summary>
        /// Original was GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12
        /// </summary>
        SmoothPointSizeRange = ((int)0x0B12),
        /// <summary>
        /// Original was GL_LINE_SMOOTH = 0x0B20
        /// </summary>
        LineSmooth = ((int)0x0B20),
        /// <summary>
        /// Original was GL_LINE_WIDTH = 0x0B21
        /// </summary>
        LineWidth = ((int)0x0B21),
        /// <summary>
        /// Original was GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22
        /// </summary>
        SmoothLineWidthRange = ((int)0x0B22),
        /// <summary>
        /// Original was GL_CULL_FACE = 0x0B44
        /// </summary>
        CullFace = ((int)0x0B44),
        /// <summary>
        /// Original was GL_CULL_FACE_MODE = 0x0B45
        /// </summary>
        CullFaceMode = ((int)0x0B45),
        /// <summary>
        /// Original was GL_FRONT_FACE = 0x0B46
        /// </summary>
        FrontFace = ((int)0x0B46),
        /// <summary>
        /// Original was GL_LIGHTING = 0x0B50
        /// </summary>
        Lighting = ((int)0x0B50),
        /// <summary>
        /// Original was GL_LIGHT_MODEL_TWO_SIDE = 0x0B52
        /// </summary>
        LightModelTwoSide = ((int)0x0B52),
        /// <summary>
        /// Original was GL_LIGHT_MODEL_AMBIENT = 0x0B53
        /// </summary>
        LightModelAmbient = ((int)0x0B53),
        /// <summary>
        /// Original was GL_SHADE_MODEL = 0x0B54
        /// </summary>
        ShadeModel = ((int)0x0B54),
        /// <summary>
        /// Original was GL_COLOR_MATERIAL = 0x0B57
        /// </summary>
        ColorMaterial = ((int)0x0B57),
        /// <summary>
        /// Original was GL_FOG = 0x0B60
        /// </summary>
        Fog = ((int)0x0B60),
        /// <summary>
        /// Original was GL_FOG_DENSITY = 0x0B62
        /// </summary>
        FogDensity = ((int)0x0B62),
        /// <summary>
        /// Original was GL_FOG_START = 0x0B63
        /// </summary>
        FogStart = ((int)0x0B63),
        /// <summary>
        /// Original was GL_FOG_END = 0x0B64
        /// </summary>
        FogEnd = ((int)0x0B64),
        /// <summary>
        /// Original was GL_FOG_MODE = 0x0B65
        /// </summary>
        FogMode = ((int)0x0B65),
        /// <summary>
        /// Original was GL_FOG_COLOR = 0x0B66
        /// </summary>
        FogColor = ((int)0x0B66),
        /// <summary>
        /// Original was GL_DEPTH_RANGE = 0x0B70
        /// </summary>
        DepthRange = ((int)0x0B70),
        /// <summary>
        /// Original was GL_DEPTH_TEST = 0x0B71
        /// </summary>
        DepthTest = ((int)0x0B71),
        /// <summary>
        /// Original was GL_DEPTH_WRITEMASK = 0x0B72
        /// </summary>
        DepthWritemask = ((int)0x0B72),
        /// <summary>
        /// Original was GL_DEPTH_CLEAR_VALUE = 0x0B73
        /// </summary>
        DepthClearValue = ((int)0x0B73),
        /// <summary>
        /// Original was GL_DEPTH_FUNC = 0x0B74
        /// </summary>
        DepthFunc = ((int)0x0B74),
        /// <summary>
        /// Original was GL_STENCIL_TEST = 0x0B90
        /// </summary>
        StencilTest = ((int)0x0B90),
        /// <summary>
        /// Original was GL_STENCIL_CLEAR_VALUE = 0x0B91
        /// </summary>
        StencilClearValue = ((int)0x0B91),
        /// <summary>
        /// Original was GL_STENCIL_FUNC = 0x0B92
        /// </summary>
        StencilFunc = ((int)0x0B92),
        /// <summary>
        /// Original was GL_STENCIL_VALUE_MASK = 0x0B93
        /// </summary>
        StencilValueMask = ((int)0x0B93),
        /// <summary>
        /// Original was GL_STENCIL_FAIL = 0x0B94
        /// </summary>
        StencilFail = ((int)0x0B94),
        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95
        /// </summary>
        StencilPassDepthFail = ((int)0x0B95),
        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_PASS = 0x0B96
        /// </summary>
        StencilPassDepthPass = ((int)0x0B96),
        /// <summary>
        /// Original was GL_STENCIL_REF = 0x0B97
        /// </summary>
        StencilRef = ((int)0x0B97),
        /// <summary>
        /// Original was GL_STENCIL_WRITEMASK = 0x0B98
        /// </summary>
        StencilWritemask = ((int)0x0B98),
        /// <summary>
        /// Original was GL_MATRIX_MODE = 0x0BA0
        /// </summary>
        MatrixMode = ((int)0x0BA0),
        /// <summary>
        /// Original was GL_NORMALIZE = 0x0BA1
        /// </summary>
        Normalize = ((int)0x0BA1),
        /// <summary>
        /// Original was GL_VIEWPORT = 0x0BA2
        /// </summary>
        Viewport = ((int)0x0BA2),
        /// <summary>
        /// Original was GL_MODELVIEW_STACK_DEPTH = 0x0BA3
        /// </summary>
        ModelviewStackDepth = ((int)0x0BA3),
        /// <summary>
        /// Original was GL_PROJECTION_STACK_DEPTH = 0x0BA4
        /// </summary>
        ProjectionStackDepth = ((int)0x0BA4),
        /// <summary>
        /// Original was GL_TEXTURE_STACK_DEPTH = 0x0BA5
        /// </summary>
        TextureStackDepth = ((int)0x0BA5),
        /// <summary>
        /// Original was GL_MODELVIEW_MATRIX = 0x0BA6
        /// </summary>
        ModelviewMatrix = ((int)0x0BA6),
        /// <summary>
        /// Original was GL_PROJECTION_MATRIX = 0x0BA7
        /// </summary>
        ProjectionMatrix = ((int)0x0BA7),
        /// <summary>
        /// Original was GL_TEXTURE_MATRIX = 0x0BA8
        /// </summary>
        TextureMatrix = ((int)0x0BA8),
        /// <summary>
        /// Original was GL_ALPHA_TEST = 0x0BC0
        /// </summary>
        AlphaTest = ((int)0x0BC0),
        /// <summary>
        /// Original was GL_ALPHA_TEST_FUNC = 0x0BC1
        /// </summary>
        AlphaTestFunc = ((int)0x0BC1),
        /// <summary>
        /// Original was GL_ALPHA_TEST_REF = 0x0BC2
        /// </summary>
        AlphaTestRef = ((int)0x0BC2),
        /// <summary>
        /// Original was GL_DITHER = 0x0BD0
        /// </summary>
        Dither = ((int)0x0BD0),
        /// <summary>
        /// Original was GL_BLEND_DST = 0x0BE0
        /// </summary>
        BlendDst = ((int)0x0BE0),
        /// <summary>
        /// Original was GL_BLEND_SRC = 0x0BE1
        /// </summary>
        BlendSrc = ((int)0x0BE1),
        /// <summary>
        /// Original was GL_BLEND = 0x0BE2
        /// </summary>
        Blend = ((int)0x0BE2),
        /// <summary>
        /// Original was GL_LOGIC_OP_MODE = 0x0BF0
        /// </summary>
        LogicOpMode = ((int)0x0BF0),
        /// <summary>
        /// Original was GL_COLOR_LOGIC_OP = 0x0BF2
        /// </summary>
        ColorLogicOp = ((int)0x0BF2),
        /// <summary>
        /// Original was GL_SCISSOR_BOX = 0x0C10
        /// </summary>
        ScissorBox = ((int)0x0C10),
        /// <summary>
        /// Original was GL_SCISSOR_TEST = 0x0C11
        /// </summary>
        ScissorTest = ((int)0x0C11),
        /// <summary>
        /// Original was GL_COLOR_CLEAR_VALUE = 0x0C22
        /// </summary>
        ColorClearValue = ((int)0x0C22),
        /// <summary>
        /// Original was GL_COLOR_WRITEMASK = 0x0C23
        /// </summary>
        ColorWritemask = ((int)0x0C23),
        /// <summary>
        /// Original was GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50
        /// </summary>
        PerspectiveCorrectionHint = ((int)0x0C50),
        /// <summary>
        /// Original was GL_POINT_SMOOTH_HINT = 0x0C51
        /// </summary>
        PointSmoothHint = ((int)0x0C51),
        /// <summary>
        /// Original was GL_LINE_SMOOTH_HINT = 0x0C52
        /// </summary>
        LineSmoothHint = ((int)0x0C52),
        /// <summary>
        /// Original was GL_FOG_HINT = 0x0C54
        /// </summary>
        FogHint = ((int)0x0C54),
        /// <summary>
        /// Original was GL_UNPACK_ALIGNMENT = 0x0CF5
        /// </summary>
        UnpackAlignment = ((int)0x0CF5),
        /// <summary>
        /// Original was GL_PACK_ALIGNMENT = 0x0D05
        /// </summary>
        PackAlignment = ((int)0x0D05),
        /// <summary>
        /// Original was GL_ALPHA_SCALE = 0x0D1C
        /// </summary>
        AlphaScale = ((int)0x0D1C),
        /// <summary>
        /// Original was GL_MAX_LIGHTS = 0x0D31
        /// </summary>
        MaxLights = ((int)0x0D31),
        /// <summary>
        /// Original was GL_MAX_CLIP_PLANES = 0x0D32
        /// </summary>
        MaxClipPlanes = ((int)0x0D32),
        /// <summary>
        /// Original was GL_MAX_TEXTURE_SIZE = 0x0D33
        /// </summary>
        MaxTextureSize = ((int)0x0D33),
        /// <summary>
        /// Original was GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36
        /// </summary>
        MaxModelviewStackDepth = ((int)0x0D36),
        /// <summary>
        /// Original was GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38
        /// </summary>
        MaxProjectionStackDepth = ((int)0x0D38),
        /// <summary>
        /// Original was GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39
        /// </summary>
        MaxTextureStackDepth = ((int)0x0D39),
        /// <summary>
        /// Original was GL_MAX_VIEWPORT_DIMS = 0x0D3A
        /// </summary>
        MaxViewportDims = ((int)0x0D3A),
        /// <summary>
        /// Original was GL_SUBPIXEL_BITS = 0x0D50
        /// </summary>
        SubpixelBits = ((int)0x0D50),
        /// <summary>
        /// Original was GL_RED_BITS = 0x0D52
        /// </summary>
        RedBits = ((int)0x0D52),
        /// <summary>
        /// Original was GL_GREEN_BITS = 0x0D53
        /// </summary>
        GreenBits = ((int)0x0D53),
        /// <summary>
        /// Original was GL_BLUE_BITS = 0x0D54
        /// </summary>
        BlueBits = ((int)0x0D54),
        /// <summary>
        /// Original was GL_ALPHA_BITS = 0x0D55
        /// </summary>
        AlphaBits = ((int)0x0D55),
        /// <summary>
        /// Original was GL_DEPTH_BITS = 0x0D56
        /// </summary>
        DepthBits = ((int)0x0D56),
        /// <summary>
        /// Original was GL_STENCIL_BITS = 0x0D57
        /// </summary>
        StencilBits = ((int)0x0D57),
        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = ((int)0x0DE1),
        /// <summary>
        /// Original was GL_DONT_CARE = 0x1100
        /// </summary>
        DontCare = ((int)0x1100),
        /// <summary>
        /// Original was GL_FASTEST = 0x1101
        /// </summary>
        Fastest = ((int)0x1101),
        /// <summary>
        /// Original was GL_NICEST = 0x1102
        /// </summary>
        Nicest = ((int)0x1102),
        /// <summary>
        /// Original was GL_AMBIENT = 0x1200
        /// </summary>
        Ambient = ((int)0x1200),
        /// <summary>
        /// Original was GL_DIFFUSE = 0x1201
        /// </summary>
        Diffuse = ((int)0x1201),
        /// <summary>
        /// Original was GL_SPECULAR = 0x1202
        /// </summary>
        Specular = ((int)0x1202),
        /// <summary>
        /// Original was GL_POSITION = 0x1203
        /// </summary>
        Position = ((int)0x1203),
        /// <summary>
        /// Original was GL_SPOT_DIRECTION = 0x1204
        /// </summary>
        SpotDirection = ((int)0x1204),
        /// <summary>
        /// Original was GL_SPOT_EXPONENT = 0x1205
        /// </summary>
        SpotExponent = ((int)0x1205),
        /// <summary>
        /// Original was GL_SPOT_CUTOFF = 0x1206
        /// </summary>
        SpotCutoff = ((int)0x1206),
        /// <summary>
        /// Original was GL_CONSTANT_ATTENUATION = 0x1207
        /// </summary>
        ConstantAttenuation = ((int)0x1207),
        /// <summary>
        /// Original was GL_LINEAR_ATTENUATION = 0x1208
        /// </summary>
        LinearAttenuation = ((int)0x1208),
        /// <summary>
        /// Original was GL_QUADRATIC_ATTENUATION = 0x1209
        /// </summary>
        QuadraticAttenuation = ((int)0x1209),
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = ((int)0x1400),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = ((int)0x1401),
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = ((int)0x1402),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = ((int)0x1403),
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406),
        /// <summary>
        /// Original was GL_FIXED = 0x140C
        /// </summary>
        Fixed = ((int)0x140C),
        /// <summary>
        /// Original was GL_CLEAR = 0x1500
        /// </summary>
        Clear = ((int)0x1500),
        /// <summary>
        /// Original was GL_AND = 0x1501
        /// </summary>
        And = ((int)0x1501),
        /// <summary>
        /// Original was GL_AND_REVERSE = 0x1502
        /// </summary>
        AndReverse = ((int)0x1502),
        /// <summary>
        /// Original was GL_COPY = 0x1503
        /// </summary>
        Copy = ((int)0x1503),
        /// <summary>
        /// Original was GL_AND_INVERTED = 0x1504
        /// </summary>
        AndInverted = ((int)0x1504),
        /// <summary>
        /// Original was GL_NOOP = 0x1505
        /// </summary>
        Noop = ((int)0x1505),
        /// <summary>
        /// Original was GL_XOR = 0x1506
        /// </summary>
        Xor = ((int)0x1506),
        /// <summary>
        /// Original was GL_OR = 0x1507
        /// </summary>
        Or = ((int)0x1507),
        /// <summary>
        /// Original was GL_NOR = 0x1508
        /// </summary>
        Nor = ((int)0x1508),
        /// <summary>
        /// Original was GL_EQUIV = 0x1509
        /// </summary>
        Equiv = ((int)0x1509),
        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = ((int)0x150A),
        /// <summary>
        /// Original was GL_OR_REVERSE = 0x150B
        /// </summary>
        OrReverse = ((int)0x150B),
        /// <summary>
        /// Original was GL_COPY_INVERTED = 0x150C
        /// </summary>
        CopyInverted = ((int)0x150C),
        /// <summary>
        /// Original was GL_OR_INVERTED = 0x150D
        /// </summary>
        OrInverted = ((int)0x150D),
        /// <summary>
        /// Original was GL_NAND = 0x150E
        /// </summary>
        Nand = ((int)0x150E),
        /// <summary>
        /// Original was GL_SET = 0x150F
        /// </summary>
        Set = ((int)0x150F),
        /// <summary>
        /// Original was GL_EMISSION = 0x1600
        /// </summary>
        Emission = ((int)0x1600),
        /// <summary>
        /// Original was GL_SHININESS = 0x1601
        /// </summary>
        Shininess = ((int)0x1601),
        /// <summary>
        /// Original was GL_AMBIENT_AND_DIFFUSE = 0x1602
        /// </summary>
        AmbientAndDiffuse = ((int)0x1602),
        /// <summary>
        /// Original was GL_MODELVIEW = 0x1700
        /// </summary>
        Modelview = ((int)0x1700),
        /// <summary>
        /// Original was GL_PROJECTION = 0x1701
        /// </summary>
        Projection = ((int)0x1701),
        /// <summary>
        /// Original was GL_TEXTURE = 0x1702
        /// </summary>
        Texture = ((int)0x1702),
        /// <summary>
        /// Original was GL_ALPHA = 0x1906
        /// </summary>
        Alpha = ((int)0x1906),
        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = ((int)0x1907),
        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = ((int)0x1908),
        /// <summary>
        /// Original was GL_LUMINANCE = 0x1909
        /// </summary>
        Luminance = ((int)0x1909),
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = ((int)0x190A),
        /// <summary>
        /// Original was GL_FLAT = 0x1D00
        /// </summary>
        Flat = ((int)0x1D00),
        /// <summary>
        /// Original was GL_SMOOTH = 0x1D01
        /// </summary>
        Smooth = ((int)0x1D01),
        /// <summary>
        /// Original was GL_KEEP = 0x1E00
        /// </summary>
        Keep = ((int)0x1E00),
        /// <summary>
        /// Original was GL_REPLACE = 0x1E01
        /// </summary>
        Replace = ((int)0x1E01),
        /// <summary>
        /// Original was GL_INCR = 0x1E02
        /// </summary>
        Incr = ((int)0x1E02),
        /// <summary>
        /// Original was GL_DECR = 0x1E03
        /// </summary>
        Decr = ((int)0x1E03),
        /// <summary>
        /// Original was GL_VENDOR = 0x1F00
        /// </summary>
        Vendor = ((int)0x1F00),
        /// <summary>
        /// Original was GL_RENDERER = 0x1F01
        /// </summary>
        Renderer = ((int)0x1F01),
        /// <summary>
        /// Original was GL_VERSION = 0x1F02
        /// </summary>
        Version = ((int)0x1F02),
        /// <summary>
        /// Original was GL_EXTENSIONS = 0x1F03
        /// </summary>
        Extensions = ((int)0x1F03),
        /// <summary>
        /// Original was GL_MODULATE = 0x2100
        /// </summary>
        Modulate = ((int)0x2100),
        /// <summary>
        /// Original was GL_DECAL = 0x2101
        /// </summary>
        Decal = ((int)0x2101),
        /// <summary>
        /// Original was GL_TEXTURE_ENV_MODE = 0x2200
        /// </summary>
        TextureEnvMode = ((int)0x2200),
        /// <summary>
        /// Original was GL_TEXTURE_ENV_COLOR = 0x2201
        /// </summary>
        TextureEnvColor = ((int)0x2201),
        /// <summary>
        /// Original was GL_TEXTURE_ENV = 0x2300
        /// </summary>
        TextureEnv = ((int)0x2300),
        /// <summary>
        /// Original was GL_NEAREST = 0x2600
        /// </summary>
        Nearest = ((int)0x2600),
        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = ((int)0x2601),
        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_NEAREST = 0x2700
        /// </summary>
        NearestMipmapNearest = ((int)0x2700),
        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_NEAREST = 0x2701
        /// </summary>
        LinearMipmapNearest = ((int)0x2701),
        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_LINEAR = 0x2702
        /// </summary>
        NearestMipmapLinear = ((int)0x2702),
        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_LINEAR = 0x2703
        /// </summary>
        LinearMipmapLinear = ((int)0x2703),
        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = ((int)0x2800),
        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = ((int)0x2801),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = ((int)0x2802),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = ((int)0x2803),
        /// <summary>
        /// Original was GL_REPEAT = 0x2901
        /// </summary>
        Repeat = ((int)0x2901),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_UNITS = 0x2A00
        /// </summary>
        PolygonOffsetUnits = ((int)0x2A00),
        /// <summary>
        /// Original was GL_CLIP_PLANE0 = 0x3000
        /// </summary>
        ClipPlane0 = ((int)0x3000),
        /// <summary>
        /// Original was GL_CLIP_PLANE1 = 0x3001
        /// </summary>
        ClipPlane1 = ((int)0x3001),
        /// <summary>
        /// Original was GL_CLIP_PLANE2 = 0x3002
        /// </summary>
        ClipPlane2 = ((int)0x3002),
        /// <summary>
        /// Original was GL_CLIP_PLANE3 = 0x3003
        /// </summary>
        ClipPlane3 = ((int)0x3003),
        /// <summary>
        /// Original was GL_CLIP_PLANE4 = 0x3004
        /// </summary>
        ClipPlane4 = ((int)0x3004),
        /// <summary>
        /// Original was GL_CLIP_PLANE5 = 0x3005
        /// </summary>
        ClipPlane5 = ((int)0x3005),
        /// <summary>
        /// Original was GL_LIGHT0 = 0x4000
        /// </summary>
        Light0 = ((int)0x4000),
        /// <summary>
        /// Original was GL_LIGHT1 = 0x4001
        /// </summary>
        Light1 = ((int)0x4001),
        /// <summary>
        /// Original was GL_LIGHT2 = 0x4002
        /// </summary>
        Light2 = ((int)0x4002),
        /// <summary>
        /// Original was GL_LIGHT3 = 0x4003
        /// </summary>
        Light3 = ((int)0x4003),
        /// <summary>
        /// Original was GL_LIGHT4 = 0x4004
        /// </summary>
        Light4 = ((int)0x4004),
        /// <summary>
        /// Original was GL_LIGHT5 = 0x4005
        /// </summary>
        Light5 = ((int)0x4005),
        /// <summary>
        /// Original was GL_LIGHT6 = 0x4006
        /// </summary>
        Light6 = ((int)0x4006),
        /// <summary>
        /// Original was GL_LIGHT7 = 0x4007
        /// </summary>
        Light7 = ((int)0x4007),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033
        /// </summary>
        UnsignedShort4444 = ((int)0x8033),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034
        /// </summary>
        UnsignedShort5551 = ((int)0x8034),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FILL = 0x8037
        /// </summary>
        PolygonOffsetFill = ((int)0x8037),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FACTOR = 0x8038
        /// </summary>
        PolygonOffsetFactor = ((int)0x8038),
        /// <summary>
        /// Original was GL_RESCALE_NORMAL = 0x803A
        /// </summary>
        RescaleNormal = ((int)0x803A),
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D = 0x8069
        /// </summary>
        TextureBinding2D = ((int)0x8069),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = ((int)0x8074),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY = 0x8075
        /// </summary>
        NormalArray = ((int)0x8075),
        /// <summary>
        /// Original was GL_COLOR_ARRAY = 0x8076
        /// </summary>
        ColorArray = ((int)0x8076),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY = 0x8078
        /// </summary>
        TextureCoordArray = ((int)0x8078),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_SIZE = 0x807A
        /// </summary>
        VertexArraySize = ((int)0x807A),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_TYPE = 0x807B
        /// </summary>
        VertexArrayType = ((int)0x807B),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_STRIDE = 0x807C
        /// </summary>
        VertexArrayStride = ((int)0x807C),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_TYPE = 0x807E
        /// </summary>
        NormalArrayType = ((int)0x807E),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_STRIDE = 0x807F
        /// </summary>
        NormalArrayStride = ((int)0x807F),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_SIZE = 0x8081
        /// </summary>
        ColorArraySize = ((int)0x8081),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_TYPE = 0x8082
        /// </summary>
        ColorArrayType = ((int)0x8082),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_STRIDE = 0x8083
        /// </summary>
        ColorArrayStride = ((int)0x8083),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088
        /// </summary>
        TextureCoordArraySize = ((int)0x8088),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089
        /// </summary>
        TextureCoordArrayType = ((int)0x8089),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A
        /// </summary>
        TextureCoordArrayStride = ((int)0x808A),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_POINTER = 0x808E
        /// </summary>
        VertexArrayPointer = ((int)0x808E),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_POINTER = 0x808F
        /// </summary>
        NormalArrayPointer = ((int)0x808F),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_POINTER = 0x8090
        /// </summary>
        ColorArrayPointer = ((int)0x8090),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092
        /// </summary>
        TextureCoordArrayPointer = ((int)0x8092),
        /// <summary>
        /// Original was GL_MULTISAMPLE = 0x809D
        /// </summary>
        Multisample = ((int)0x809D),
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E
        /// </summary>
        SampleAlphaToCoverage = ((int)0x809E),
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE = 0x809F
        /// </summary>
        SampleAlphaToOne = ((int)0x809F),
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE = 0x80A0
        /// </summary>
        SampleCoverage = ((int)0x80A0),
        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS = 0x80A8
        /// </summary>
        SampleBuffers = ((int)0x80A8),
        /// <summary>
        /// Original was GL_SAMPLES = 0x80A9
        /// </summary>
        Samples = ((int)0x80A9),
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_VALUE = 0x80AA
        /// </summary>
        SampleCoverageValue = ((int)0x80AA),
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_INVERT = 0x80AB
        /// </summary>
        SampleCoverageInvert = ((int)0x80AB),
        /// <summary>
        /// Original was GL_POINT_SIZE_MIN = 0x8126
        /// </summary>
        PointSizeMin = ((int)0x8126),
        /// <summary>
        /// Original was GL_POINT_SIZE_MAX = 0x8127
        /// </summary>
        PointSizeMax = ((int)0x8127),
        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE = 0x8128
        /// </summary>
        PointFadeThresholdSize = ((int)0x8128),
        /// <summary>
        /// Original was GL_POINT_DISTANCE_ATTENUATION = 0x8129
        /// </summary>
        PointDistanceAttenuation = ((int)0x8129),
        /// <summary>
        /// Original was GL_CLAMP_TO_EDGE = 0x812F
        /// </summary>
        ClampToEdge = ((int)0x812F),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP = 0x8191
        /// </summary>
        GenerateMipmap = ((int)0x8191),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT = 0x8192
        /// </summary>
        GenerateMipmapHint = ((int)0x8192),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_6_5 = 0x8363
        /// </summary>
        UnsignedShort565 = ((int)0x8363),
        /// <summary>
        /// Original was GL_ALIASED_POINT_SIZE_RANGE = 0x846D
        /// </summary>
        AliasedPointSizeRange = ((int)0x846D),
        /// <summary>
        /// Original was GL_ALIASED_LINE_WIDTH_RANGE = 0x846E
        /// </summary>
        AliasedLineWidthRange = ((int)0x846E),
        /// <summary>
        /// Original was GL_TEXTURE0 = 0x84C0
        /// </summary>
        Texture0 = ((int)0x84C0),
        /// <summary>
        /// Original was GL_TEXTURE1 = 0x84C1
        /// </summary>
        Texture1 = ((int)0x84C1),
        /// <summary>
        /// Original was GL_TEXTURE2 = 0x84C2
        /// </summary>
        Texture2 = ((int)0x84C2),
        /// <summary>
        /// Original was GL_TEXTURE3 = 0x84C3
        /// </summary>
        Texture3 = ((int)0x84C3),
        /// <summary>
        /// Original was GL_TEXTURE4 = 0x84C4
        /// </summary>
        Texture4 = ((int)0x84C4),
        /// <summary>
        /// Original was GL_TEXTURE5 = 0x84C5
        /// </summary>
        Texture5 = ((int)0x84C5),
        /// <summary>
        /// Original was GL_TEXTURE6 = 0x84C6
        /// </summary>
        Texture6 = ((int)0x84C6),
        /// <summary>
        /// Original was GL_TEXTURE7 = 0x84C7
        /// </summary>
        Texture7 = ((int)0x84C7),
        /// <summary>
        /// Original was GL_TEXTURE8 = 0x84C8
        /// </summary>
        Texture8 = ((int)0x84C8),
        /// <summary>
        /// Original was GL_TEXTURE9 = 0x84C9
        /// </summary>
        Texture9 = ((int)0x84C9),
        /// <summary>
        /// Original was GL_TEXTURE10 = 0x84CA
        /// </summary>
        Texture10 = ((int)0x84CA),
        /// <summary>
        /// Original was GL_TEXTURE11 = 0x84CB
        /// </summary>
        Texture11 = ((int)0x84CB),
        /// <summary>
        /// Original was GL_TEXTURE12 = 0x84CC
        /// </summary>
        Texture12 = ((int)0x84CC),
        /// <summary>
        /// Original was GL_TEXTURE13 = 0x84CD
        /// </summary>
        Texture13 = ((int)0x84CD),
        /// <summary>
        /// Original was GL_TEXTURE14 = 0x84CE
        /// </summary>
        Texture14 = ((int)0x84CE),
        /// <summary>
        /// Original was GL_TEXTURE15 = 0x84CF
        /// </summary>
        Texture15 = ((int)0x84CF),
        /// <summary>
        /// Original was GL_TEXTURE16 = 0x84D0
        /// </summary>
        Texture16 = ((int)0x84D0),
        /// <summary>
        /// Original was GL_TEXTURE17 = 0x84D1
        /// </summary>
        Texture17 = ((int)0x84D1),
        /// <summary>
        /// Original was GL_TEXTURE18 = 0x84D2
        /// </summary>
        Texture18 = ((int)0x84D2),
        /// <summary>
        /// Original was GL_TEXTURE19 = 0x84D3
        /// </summary>
        Texture19 = ((int)0x84D3),
        /// <summary>
        /// Original was GL_TEXTURE20 = 0x84D4
        /// </summary>
        Texture20 = ((int)0x84D4),
        /// <summary>
        /// Original was GL_TEXTURE21 = 0x84D5
        /// </summary>
        Texture21 = ((int)0x84D5),
        /// <summary>
        /// Original was GL_TEXTURE22 = 0x84D6
        /// </summary>
        Texture22 = ((int)0x84D6),
        /// <summary>
        /// Original was GL_TEXTURE23 = 0x84D7
        /// </summary>
        Texture23 = ((int)0x84D7),
        /// <summary>
        /// Original was GL_TEXTURE24 = 0x84D8
        /// </summary>
        Texture24 = ((int)0x84D8),
        /// <summary>
        /// Original was GL_TEXTURE25 = 0x84D9
        /// </summary>
        Texture25 = ((int)0x84D9),
        /// <summary>
        /// Original was GL_TEXTURE26 = 0x84DA
        /// </summary>
        Texture26 = ((int)0x84DA),
        /// <summary>
        /// Original was GL_TEXTURE27 = 0x84DB
        /// </summary>
        Texture27 = ((int)0x84DB),
        /// <summary>
        /// Original was GL_TEXTURE28 = 0x84DC
        /// </summary>
        Texture28 = ((int)0x84DC),
        /// <summary>
        /// Original was GL_TEXTURE29 = 0x84DD
        /// </summary>
        Texture29 = ((int)0x84DD),
        /// <summary>
        /// Original was GL_TEXTURE30 = 0x84DE
        /// </summary>
        Texture30 = ((int)0x84DE),
        /// <summary>
        /// Original was GL_TEXTURE31 = 0x84DF
        /// </summary>
        Texture31 = ((int)0x84DF),
        /// <summary>
        /// Original was GL_ACTIVE_TEXTURE = 0x84E0
        /// </summary>
        ActiveTexture = ((int)0x84E0),
        /// <summary>
        /// Original was GL_CLIENT_ACTIVE_TEXTURE = 0x84E1
        /// </summary>
        ClientActiveTexture = ((int)0x84E1),
        /// <summary>
        /// Original was GL_MAX_TEXTURE_UNITS = 0x84E2
        /// </summary>
        MaxTextureUnits = ((int)0x84E2),
        /// <summary>
        /// Original was GL_SUBTRACT = 0x84E7
        /// </summary>
        Subtract = ((int)0x84E7),
        /// <summary>
        /// Original was GL_COMBINE = 0x8570
        /// </summary>
        Combine = ((int)0x8570),
        /// <summary>
        /// Original was GL_COMBINE_RGB = 0x8571
        /// </summary>
        CombineRgb = ((int)0x8571),
        /// <summary>
        /// Original was GL_COMBINE_ALPHA = 0x8572
        /// </summary>
        CombineAlpha = ((int)0x8572),
        /// <summary>
        /// Original was GL_RGB_SCALE = 0x8573
        /// </summary>
        RgbScale = ((int)0x8573),
        /// <summary>
        /// Original was GL_ADD_SIGNED = 0x8574
        /// </summary>
        AddSigned = ((int)0x8574),
        /// <summary>
        /// Original was GL_INTERPOLATE = 0x8575
        /// </summary>
        Interpolate = ((int)0x8575),
        /// <summary>
        /// Original was GL_CONSTANT = 0x8576
        /// </summary>
        Constant = ((int)0x8576),
        /// <summary>
        /// Original was GL_PRIMARY_COLOR = 0x8577
        /// </summary>
        PrimaryColor = ((int)0x8577),
        /// <summary>
        /// Original was GL_PREVIOUS = 0x8578
        /// </summary>
        Previous = ((int)0x8578),
        /// <summary>
        /// Original was GL_SRC0_RGB = 0x8580
        /// </summary>
        Src0Rgb = ((int)0x8580),
        /// <summary>
        /// Original was GL_SRC1_RGB = 0x8581
        /// </summary>
        Src1Rgb = ((int)0x8581),
        /// <summary>
        /// Original was GL_SRC2_RGB = 0x8582
        /// </summary>
        Src2Rgb = ((int)0x8582),
        /// <summary>
        /// Original was GL_SRC0_ALPHA = 0x8588
        /// </summary>
        Src0Alpha = ((int)0x8588),
        /// <summary>
        /// Original was GL_SRC1_ALPHA = 0x8589
        /// </summary>
        Src1Alpha = ((int)0x8589),
        /// <summary>
        /// Original was GL_SRC2_ALPHA = 0x858A
        /// </summary>
        Src2Alpha = ((int)0x858A),
        /// <summary>
        /// Original was GL_OPERAND0_RGB = 0x8590
        /// </summary>
        Operand0Rgb = ((int)0x8590),
        /// <summary>
        /// Original was GL_OPERAND1_RGB = 0x8591
        /// </summary>
        Operand1Rgb = ((int)0x8591),
        /// <summary>
        /// Original was GL_OPERAND2_RGB = 0x8592
        /// </summary>
        Operand2Rgb = ((int)0x8592),
        /// <summary>
        /// Original was GL_OPERAND0_ALPHA = 0x8598
        /// </summary>
        Operand0Alpha = ((int)0x8598),
        /// <summary>
        /// Original was GL_OPERAND1_ALPHA = 0x8599
        /// </summary>
        Operand1Alpha = ((int)0x8599),
        /// <summary>
        /// Original was GL_OPERAND2_ALPHA = 0x859A
        /// </summary>
        Operand2Alpha = ((int)0x859A),
        /// <summary>
        /// Original was GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2
        /// </summary>
        NumCompressedTextureFormats = ((int)0x86A2),
        /// <summary>
        /// Original was GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3
        /// </summary>
        CompressedTextureFormats = ((int)0x86A3),
        /// <summary>
        /// Original was GL_DOT3_RGB = 0x86AE
        /// </summary>
        Dot3Rgb = ((int)0x86AE),
        /// <summary>
        /// Original was GL_DOT3_RGBA = 0x86AF
        /// </summary>
        Dot3Rgba = ((int)0x86AF),
        /// <summary>
        /// Original was GL_BUFFER_SIZE = 0x8764
        /// </summary>
        BufferSize = ((int)0x8764),
        /// <summary>
        /// Original was GL_BUFFER_USAGE = 0x8765
        /// </summary>
        BufferUsage = ((int)0x8765),
        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = ((int)0x8892),
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = ((int)0x8893),
        /// <summary>
        /// Original was GL_ARRAY_BUFFER_BINDING = 0x8894
        /// </summary>
        ArrayBufferBinding = ((int)0x8894),
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895
        /// </summary>
        ElementArrayBufferBinding = ((int)0x8895),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896
        /// </summary>
        VertexArrayBufferBinding = ((int)0x8896),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897
        /// </summary>
        NormalArrayBufferBinding = ((int)0x8897),
        /// <summary>
        /// Original was GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898
        /// </summary>
        ColorArrayBufferBinding = ((int)0x8898),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A
        /// </summary>
        TextureCoordArrayBufferBinding = ((int)0x889A),
        /// <summary>
        /// Original was GL_STATIC_DRAW = 0x88E4
        /// </summary>
        StaticDraw = ((int)0x88E4),
        /// <summary>
        /// Original was GL_DYNAMIC_DRAW = 0x88E8
        /// </summary>
        DynamicDraw = ((int)0x88E8),
        /// <summary>
        /// Original was GL_ONE = 1
        /// </summary>
        One = ((int)1),
        /// <summary>
        /// Original was GL_TRUE = 1
        /// </summary>
        True = ((int)1),
        /// <summary>
        /// Original was GL_VERSION_ES_CL_1_0 = 1
        /// </summary>
        VersionEsCl10 = ((int)1),
        /// <summary>
        /// Original was GL_VERSION_ES_CL_1_1 = 1
        /// </summary>
        VersionEsCl11 = ((int)1),
        /// <summary>
        /// Original was GL_VERSION_ES_CM_1_1 = 1
        /// </summary>
        VersionEsCm11 = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexArrayPName : int
    {
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5
        /// </summary>
        VertexAttribRelativeOffset = ((int)0x82D5),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622
        /// </summary>
        VertexAttribArrayEnabled = ((int)0x8622),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623
        /// </summary>
        VertexAttribArraySize = ((int)0x8623),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624
        /// </summary>
        VertexAttribArrayStride = ((int)0x8624),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625
        /// </summary>
        VertexAttribArrayType = ((int)0x8625),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E
        /// </summary>
        VertexAttribArrayLong = ((int)0x874E),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A
        /// </summary>
        VertexAttribArrayNormalized = ((int)0x886A),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD
        /// </summary>
        VertexAttribArrayInteger = ((int)0x88FD),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE
        /// </summary>
        VertexAttribArrayDivisor = ((int)0x88FE),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexAttribEnum : int
    {
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622
        /// </summary>
        VertexAttribArrayEnabled = ((int)0x8622),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623
        /// </summary>
        VertexAttribArraySize = ((int)0x8623),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624
        /// </summary>
        VertexAttribArrayStride = ((int)0x8624),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625
        /// </summary>
        VertexAttribArrayType = ((int)0x8625),
        /// <summary>
        /// Original was GL_CURRENT_VERTEX_ATTRIB = 0x8626
        /// </summary>
        CurrentVertexAttrib = ((int)0x8626),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A
        /// </summary>
        VertexAttribArrayNormalized = ((int)0x886A),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F
        /// </summary>
        VertexAttribArrayBufferBinding = ((int)0x889F),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD
        /// </summary>
        VertexAttribArrayInteger = ((int)0x88FD),
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE
        /// </summary>
        VertexAttribArrayDivisor = ((int)0x88FE),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexAttribPointerType : int
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = ((int)0x1400),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = ((int)0x1401),
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = ((int)0x1402),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = ((int)0x1403),
        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = ((int)0x1404),
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405),
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406),
        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = ((int)0x140A),
        /// <summary>
        /// Original was GL_HALF_FLOAT = 0x140B
        /// </summary>
        HalfFloat = ((int)0x140B),
        /// <summary>
        /// Original was GL_FIXED = 0x140C
        /// </summary>
        Fixed = ((int)0x140C),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368
        /// </summary>
        UnsignedInt2101010Rev = ((int)0x8368),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        /// </summary>
        UnsignedInt10F11F11FRev = ((int)0x8C3B),
        /// <summary>
        /// Original was GL_INT_2_10_10_10_REV = 0x8D9F
        /// </summary>
        Int2101010Rev = ((int)0x8D9F),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexAttribType : int
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = ((int)0x1400),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = ((int)0x1401),
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = ((int)0x1402),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = ((int)0x1403),
        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = ((int)0x1404),
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405),
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406),
        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = ((int)0x140A),
        /// <summary>
        /// Original was GL_HALF_FLOAT = 0x140B
        /// </summary>
        HalfFloat = ((int)0x140B),
        /// <summary>
        /// Original was GL_FIXED = 0x140C
        /// </summary>
        Fixed = ((int)0x140C),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368
        /// </summary>
        UnsignedInt2101010Rev = ((int)0x8368),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        /// </summary>
        UnsignedInt10F11F11FRev = ((int)0x8C3B),
        /// <summary>
        /// Original was GL_INT_2_10_10_10_REV = 0x8D9F
        /// </summary>
        Int2101010Rev = ((int)0x8D9F),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexBufferObjectParameter : int
    {
        /// <summary>
        /// Original was GL_BUFFER_IMMUTABLE_STORAGE = 0x821F
        /// </summary>
        BufferImmutableStorage = ((int)0x821F),
        /// <summary>
        /// Original was GL_BUFFER_STORAGE_FLAGS = 0x8220
        /// </summary>
        BufferStorageFlags = ((int)0x8220),
        /// <summary>
        /// Original was GL_BUFFER_SIZE = 0x8764
        /// </summary>
        BufferSize = ((int)0x8764),
        /// <summary>
        /// Original was GL_BUFFER_USAGE = 0x8765
        /// </summary>
        BufferUsage = ((int)0x8765),
        /// <summary>
        /// Original was GL_BUFFER_ACCESS = 0x88BB
        /// </summary>
        BufferAccess = ((int)0x88BB),
        /// <summary>
        /// Original was GL_BUFFER_MAPPED = 0x88BC
        /// </summary>
        BufferMapped = ((int)0x88BC),
        /// <summary>
        /// Original was GL_BUFFER_ACCESS_FLAGS = 0x911F
        /// </summary>
        BufferAccessFlags = ((int)0x911F),
        /// <summary>
        /// Original was GL_BUFFER_MAP_LENGTH = 0x9120
        /// </summary>
        BufferMapLength = ((int)0x9120),
        /// <summary>
        /// Original was GL_BUFFER_MAP_OFFSET = 0x9121
        /// </summary>
        BufferMapOffset = ((int)0x9121),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexBufferObjectUsage : int
    {
        /// <summary>
        /// Original was GL_STREAM_DRAW = 0x88E0
        /// </summary>
        StreamDraw = ((int)0x88E0),
        /// <summary>
        /// Original was GL_STREAM_READ = 0x88E1
        /// </summary>
        StreamRead = ((int)0x88E1),
        /// <summary>
        /// Original was GL_STREAM_COPY = 0x88E2
        /// </summary>
        StreamCopy = ((int)0x88E2),
        /// <summary>
        /// Original was GL_STATIC_DRAW = 0x88E4
        /// </summary>
        StaticDraw = ((int)0x88E4),
        /// <summary>
        /// Original was GL_STATIC_READ = 0x88E5
        /// </summary>
        StaticRead = ((int)0x88E5),
        /// <summary>
        /// Original was GL_STATIC_COPY = 0x88E6
        /// </summary>
        StaticCopy = ((int)0x88E6),
        /// <summary>
        /// Original was GL_DYNAMIC_DRAW = 0x88E8
        /// </summary>
        DynamicDraw = ((int)0x88E8),
        /// <summary>
        /// Original was GL_DYNAMIC_READ = 0x88E9
        /// </summary>
        DynamicRead = ((int)0x88E9),
        /// <summary>
        /// Original was GL_DYNAMIC_COPY = 0x88EA
        /// </summary>
        DynamicCopy = ((int)0x88EA),
    }

    /// <summary>
    /// Used in GL.VertexPointer
    /// </summary>
    public enum VertexPointerType : int
    {
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = ((int)0x1402),
        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = ((int)0x1404),
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406),
        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = ((int)0x140A),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexProvokingMode : int
    {
        /// <summary>
        /// Original was GL_FIRST_VERTEX_CONVENTION = 0x8E4D
        /// </summary>
        FirstVertexConvention = ((int)0x8E4D),
        /// <summary>
        /// Original was GL_LAST_VERTEX_CONVENTION = 0x8E4E
        /// </summary>
        LastVertexConvention = ((int)0x8E4E),
    }

}
