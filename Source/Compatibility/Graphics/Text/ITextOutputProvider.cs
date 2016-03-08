// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Graphics.Text
{
    interface ITextOutputProvider : IDisposable
    {
        void Print(ref TextBlock block, Color color, IGlyphRasterizer rasterizer);
        void Clear();
        void Begin();
        void End();
    }
}
