// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;

namespace OpenTK.Platform.MacOS
{
    [Flags]
    enum NSBitmapFormat
    {
        AlphaFirst = 1 << 0,
        AlphaNonpremultiplied = 1 << 1,
        FloatingPointSamples  = 1 << 2
    }
}

