// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Graphics;
using OpenTK.Platform;

namespace OpenTK
{
    internal interface IGLControl
    {
        IGraphicsContext CreateContext(int major, int minor, GraphicsContextFlags flags);
        bool IsIdle { get; }
        IWindowInfo WindowInfo { get; }
    }
}
