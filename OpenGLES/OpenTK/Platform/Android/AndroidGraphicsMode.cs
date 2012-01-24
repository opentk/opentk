#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2011 Xamarin, Inc.
 * Copyright 2013 Xamarin Inc
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using OpenTK.Graphics;

namespace OpenTK.Platform.Android
{
    class AndroidGraphicsMode : IGraphicsMode
    {
        public GraphicsMode SelectGraphicsMode(ColorFormat color, int depth, int stencil, int samples, ColorFormat accum, int buffers, bool stereo)
        {
            return new GraphicsMode((IntPtr)1, color, depth, stencil, samples, accum, buffers, stereo);
        }
    }
}
