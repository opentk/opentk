// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using OpenTK.Graphics;
using OpenTK.Platform.SDL2;

namespace OpenTK.Platform.Egl
{

    class EglSdl2PlatformFactory : Sdl2Factory
    {
        public override OpenTK.Graphics.IGraphicsContext CreateGLContext(
            GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering,
            int major, int minor, GraphicsContextFlags flags)
        {
            flags |= GraphicsContextFlags.Embedded;
            return base.CreateGLContext(mode, window, shareContext, directRendering, major, minor, flags);
        }
    }
}

