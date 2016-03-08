// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    sealed class GraphicsModeComparer : IComparer<GraphicsMode>
    {
        #region IComparer<GraphicsMode> Members

        public int Compare(GraphicsMode x, GraphicsMode y)
        {
            int result = x.ColorFormat.CompareTo(y.ColorFormat);
            if (result != 0)
                return result;
            result = x.Depth.CompareTo(y.Depth);
            if (result != 0)
                return result;
            result = x.Stencil.CompareTo(y.Stencil);
            if (result != 0)
                return result;
            result = x.Samples.CompareTo(y.Samples);
            if (result != 0)
                return result;
            result = x.Stereo.CompareTo(y.Stereo);
            if (result != 0)
                return result;
            result = x.Buffers.CompareTo(y.Buffers);
            if (result != 0)
                return result;
            return x.AccumulatorFormat.CompareTo(y.AccumulatorFormat);
        }

        #endregion
    }
}
