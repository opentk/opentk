// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using OpenTK.Graphics;
using OpenTK.Platform;

namespace OpenTK
{
    class Sdl2GLControl : IGLControl
    {
        IWindowInfo window_info;
        GraphicsMode mode;

        public Sdl2GLControl(GraphicsMode mode, Control control)
        {
            this.mode = mode;
            window_info = Utilities.CreateSdl2WindowInfo(control.Handle);
            // Fixme: SDL2 will refuse to create an OpenGL context on
            // a window with the SDL_WINDOW_FOREIGN flag (i.e. windows
            // that are passed to SDL2 through SDL_CreateWindowFrom).
            // This must be fixed upstream.
        }

        public Graphics.IGraphicsContext CreateContext(int major, int minor, Graphics.GraphicsContextFlags flags)
        {
            return new GraphicsContext(mode, window_info, major, minor, flags);
        }

        public bool IsIdle
        {
            get { return NativeMethods.SDL_HasEvents(0, 0xffff); }
        }

        public Platform.IWindowInfo WindowInfo
        {
            get { return window_info; }
        }

        static class NativeMethods
        {
            [DllImport("SDL2.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool SDL_HasEvents(int minType, int maxType);
        }
    }
}
