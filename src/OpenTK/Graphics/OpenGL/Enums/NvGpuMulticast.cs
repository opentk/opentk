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
    /// Used in GL.NV.MulticastBlitFramebuffer, GL.NV.MulticastCopyImageSubData and 1 other function
    /// </summary>
    public enum NvGpuMulticast
    {
        /// <summary>
        /// Original was GL_PER_GPU_STORAGE_BIT_NV = 0x0800
        /// </summary>
        PerGpuStorageBitNv = 0x0800,

        /// <summary>
        /// Original was GL_MULTICAST_GPUS_NV = 0x92BA
        /// </summary>
        MulticastGpusNv = 0x92ba,

        /// <summary>
        /// Original was GL_PER_GPU_STORAGE_NV = 0x9548
        /// </summary>
        PerGpuStorageNv = 0x9548,

        /// <summary>
        /// Original was GL_MULTICAST_PROGRAMMABLE_SAMPLE_LOCATION_NV = 0x9549
        /// </summary>
        MulticastProgrammableSampleLocationNv = 0x9549,

        /// <summary>
        /// Original was GL_RENDER_GPU_MASK_NV = 0x9558
        /// </summary>
        RenderGpuMaskNv = 0x9558
    }
}
