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
    public enum IntelPerformanceQuery
    {
        /// <summary>
        /// Original was GL_PERFQUERY_SINGLE_CONTEXT_INTEL = 0x00000000
        /// </summary>
        PerfquerySingleContextIntel = 0x00000000,

        /// <summary>
        /// Original was GL_PERFQUERY_GLOBAL_CONTEXT_INTEL = 0x00000001
        /// </summary>
        PerfqueryGlobalContextIntel = 0x00000001,

        /// <summary>
        /// Original was GL_PERFQUERY_DONOT_FLUSH_INTEL = 0x83F9
        /// </summary>
        PerfqueryDonotFlushIntel = 0x83f9,

        /// <summary>
        /// Original was GL_PERFQUERY_FLUSH_INTEL = 0x83FA
        /// </summary>
        PerfqueryFlushIntel = 0x83fa,

        /// <summary>
        /// Original was GL_PERFQUERY_WAIT_INTEL = 0x83FB
        /// </summary>
        PerfqueryWaitIntel = 0x83fb,

        /// <summary>
        /// Original was GL_PERFQUERY_COUNTER_EVENT_INTEL = 0x94F0
        /// </summary>
        PerfqueryCounterEventIntel = 0x94f0,

        /// <summary>
        /// Original was GL_PERFQUERY_COUNTER_DURATION_NORM_INTEL = 0x94F1
        /// </summary>
        PerfqueryCounterDurationNormIntel = 0x94f1,

        /// <summary>
        /// Original was GL_PERFQUERY_COUNTER_DURATION_RAW_INTEL = 0x94F2
        /// </summary>
        PerfqueryCounterDurationRawIntel = 0x94f2,

        /// <summary>
        /// Original was GL_PERFQUERY_COUNTER_THROUGHPUT_INTEL = 0x94F3
        /// </summary>
        PerfqueryCounterThroughputIntel = 0x94f3,

        /// <summary>
        /// Original was GL_PERFQUERY_COUNTER_RAW_INTEL = 0x94F4
        /// </summary>
        PerfqueryCounterRawIntel = 0x94f4,

        /// <summary>
        /// Original was GL_PERFQUERY_COUNTER_TIMESTAMP_INTEL = 0x94F5
        /// </summary>
        PerfqueryCounterTimestampIntel = 0x94f5,

        /// <summary>
        /// Original was GL_PERFQUERY_COUNTER_DATA_UINT32_INTEL = 0x94F8
        /// </summary>
        PerfqueryCounterDataUint32Intel = 0x94f8,

        /// <summary>
        /// Original was GL_PERFQUERY_COUNTER_DATA_UINT64_INTEL = 0x94F9
        /// </summary>
        PerfqueryCounterDataUint64Intel = 0x94f9,

        /// <summary>
        /// Original was GL_PERFQUERY_COUNTER_DATA_FLOAT_INTEL = 0x94FA
        /// </summary>
        PerfqueryCounterDataFloatIntel = 0x94fa,

        /// <summary>
        /// Original was GL_PERFQUERY_COUNTER_DATA_DOUBLE_INTEL = 0x94FB
        /// </summary>
        PerfqueryCounterDataDoubleIntel = 0x94fb,

        /// <summary>
        /// Original was GL_PERFQUERY_COUNTER_DATA_BOOL32_INTEL = 0x94FC
        /// </summary>
        PerfqueryCounterDataBool32Intel = 0x94fc,

        /// <summary>
        /// Original was GL_PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL = 0x94FD
        /// </summary>
        PerfqueryQueryNameLengthMaxIntel = 0x94fd,

        /// <summary>
        /// Original was GL_PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL = 0x94FE
        /// </summary>
        PerfqueryCounterNameLengthMaxIntel = 0x94fe,

        /// <summary>
        /// Original was GL_PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL = 0x94FF
        /// </summary>
        PerfqueryCounterDescLengthMaxIntel = 0x94ff,

        /// <summary>
        /// Original was GL_PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL = 0x9500
        /// </summary>
        PerfqueryGpaExtendedCountersIntel = 0x9500
    }
}
