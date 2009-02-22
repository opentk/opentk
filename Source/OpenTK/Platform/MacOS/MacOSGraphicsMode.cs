using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.MacOS
{
    using Graphics;

    class MacOSGraphicsMode : IGraphicsMode 
    {
        #region IGraphicsMode Members

        public GraphicsMode SelectGraphicsMode(ColorFormat color, int depth, int stencil, int samples, ColorFormat accum, int buffers, bool stereo)
        {
            GraphicsMode gfx = new GraphicsMode((IntPtr)1, color, depth, stencil, samples,
                                                 accum, buffers, stereo);

            System.Diagnostics.Debug.Print("Created dummy graphics mode.");

            return gfx;
        }

        #endregion
    }
}
