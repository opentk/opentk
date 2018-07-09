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
    /// Used in GL.Amd.GetPerfMonitorCounterData and GL.Amd.GetPerfMonitorCounterInfo.
    /// </summary>
    public enum AmdPerformanceMonitor
    {
        /// <summary>
        /// Original was GL_COUNTER_TYPE_AMD = 0x8BC0
        /// </summary>
        CounterTypeAmd = 0x8bc0,

        /// <summary>
        /// Original was GL_COUNTER_RANGE_AMD = 0x8BC1
        /// </summary>
        CounterRangeAmd = 0x8bc1,

        /// <summary>
        /// Original was GL_UNSIGNED_INT64_AMD = 0x8BC2
        /// </summary>
        UnsignedInt64Amd = 0x8bc2,

        /// <summary>
        /// Original was GL_PERCENTAGE_AMD = 0x8BC3
        /// </summary>
        PercentageAmd = 0x8bc3,

        /// <summary>
        /// Original was GL_PERFMON_RESULT_AVAILABLE_AMD = 0x8BC4
        /// </summary>
        PerfmonResultAvailableAmd = 0x8bc4,

        /// <summary>
        /// Original was GL_PERFMON_RESULT_SIZE_AMD = 0x8BC5
        /// </summary>
        PerfmonResultSizeAmd = 0x8bc5,

        /// <summary>
        /// Original was GL_PERFMON_RESULT_AMD = 0x8BC6
        /// </summary>
        PerfmonResultAmd = 0x8bc6
    }
}
