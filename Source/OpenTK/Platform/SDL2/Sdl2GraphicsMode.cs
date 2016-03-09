// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;
using OpenTK.Graphics;

namespace OpenTK.Platform.SDL2
{
    class Sdl2GraphicsMode : IGraphicsMode
    {
        public Sdl2GraphicsMode()
        {
        }

        #region IGraphicsMode implementation

        public GraphicsMode SelectGraphicsMode(ColorFormat color, int depth, int stencil, int samples, ColorFormat accum, int buffers, bool stereo)
        {
            return new GraphicsMode(IntPtr.Zero, color, depth, stencil, samples, accum, buffers, stereo);
        }

        #endregion
    }
}

