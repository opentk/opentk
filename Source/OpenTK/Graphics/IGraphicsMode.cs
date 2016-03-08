// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    internal interface IGraphicsMode
    {
        // Creates a temporary OpenGL context (if necessary) and finds the mode which closest matches
        // the specified parameters.
        GraphicsMode SelectGraphicsMode(ColorFormat color, int depth, int stencil, int samples, ColorFormat accum, int buffers,
            bool stereo);
    }
}
