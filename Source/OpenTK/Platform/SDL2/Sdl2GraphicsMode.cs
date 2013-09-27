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
            return new GraphicsMode(new IntPtr(1), new ColorFormat(32), 24, 8, 0, ColorFormat.Empty, 2, false);
        }

        #endregion
    }
}

