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

#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShaderAtomicCounters
    {
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        /// </summary>
        AtomicCounterBuffer = 0x92c0,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1
        /// </summary>
        AtomicCounterBufferBinding = 0x92c1,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2
        /// </summary>
        AtomicCounterBufferStart = 0x92c2,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3
        /// </summary>
        AtomicCounterBufferSize = 0x92c3,

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
        /// Original was GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC
        /// </summary>
        MaxVertexAtomicCounterBuffers = 0x92cc,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD
        /// </summary>
        MaxTessControlAtomicCounterBuffers = 0x92cd,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE
        /// </summary>
        MaxTessEvaluationAtomicCounterBuffers = 0x92ce,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF
        /// </summary>
        MaxGeometryAtomicCounterBuffers = 0x92cf,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0
        /// </summary>
        MaxFragmentAtomicCounterBuffers = 0x92d0,

        /// <summary>
        /// Original was GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1
        /// </summary>
        MaxCombinedAtomicCounterBuffers = 0x92d1,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2
        /// </summary>
        MaxVertexAtomicCounters = 0x92d2,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3
        /// </summary>
        MaxTessControlAtomicCounters = 0x92d3,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4
        /// </summary>
        MaxTessEvaluationAtomicCounters = 0x92d4,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5
        /// </summary>
        MaxGeometryAtomicCounters = 0x92d5,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6
        /// </summary>
        MaxFragmentAtomicCounters = 0x92d6,

        /// <summary>
        /// Original was GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7
        /// </summary>
        MaxCombinedAtomicCounters = 0x92d7,

        /// <summary>
        /// Original was GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8
        /// </summary>
        MaxAtomicCounterBufferSize = 0x92d8,

        /// <summary>
        /// Original was GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9
        /// </summary>
        ActiveAtomicCounterBuffers = 0x92d9,

        /// <summary>
        /// Original was GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA
        /// </summary>
        UniformAtomicCounterBufferIndex = 0x92da,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB
        /// </summary>
        UnsignedIntAtomicCounter = 0x92db,

        /// <summary>
        /// Original was GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC
        /// </summary>
        MaxAtomicCounterBufferBindings = 0x92dc
    }
}
