#region License
//
// NSOpenGLContextParameter.cs
//
// Author:
//       Olle Håkansson <ollhak@gmail.com>
//
// Copyright (c) 2014 Olle Håkansson
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;

namespace OpenTK.Platform.MacOS
{
    enum NSOpenGLContextParameter
    {
        [Obsolete] SwapRectangle = 200,
        [Obsolete] SwapRectangleEnable = 201,
        [Obsolete] RasterizationEnable = 221,
        SwapInterval = 222,
        SurfaceOrder = 235,
        SurfaceOpacity = 236,
        [Obsolete] StateValidation = 301,
        SurfaceBackingSize = 304, // Lion
        [Obsolete] SurfaceSurfaceVolatile = 306,
        ReclaimResources = 308, // Lion
        CurrentRendererID = 309, // Lion
        GpuVertexProcessing = 310, // Lion
        GpuFragmentProcessing = 311, // Lion
        HasDrawable = 314, // Lion
        MpsSwapsInFlight = 315, // Lion
    }
}
