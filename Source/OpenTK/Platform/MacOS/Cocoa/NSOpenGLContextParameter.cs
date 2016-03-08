// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
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
