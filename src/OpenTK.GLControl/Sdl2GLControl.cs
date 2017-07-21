//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System.Runtime.InteropServices;
using System.Windows.Forms;
using OpenTK.Graphics;
using OpenTK.Platform;

namespace OpenTK
{
    internal class Sdl2GLControl : IGLControl
    {
        private GraphicsMode mode;

        public Sdl2GLControl(GraphicsMode mode, Control control)
        {
            this.mode = mode;
            WindowInfo = Utilities.CreateSdl2WindowInfo(control.Handle);
            // Fixme: SDL2 will refuse to create an OpenGL context on
            // a window with the SDL_WINDOW_FOREIGN flag (i.e. windows
            // that are passed to SDL2 through SDL_CreateWindowFrom).
            // This must be fixed upstream.
        }

        public Graphics.IGraphicsContext CreateContext(int major, int minor, Graphics.GraphicsContextFlags flags)
        {
            return new GraphicsContext(mode, WindowInfo, major, minor, flags);
        }

        public bool IsIdle
        {
            get { return NativeMethods.SDL_HasEvents(0, 0xffff); }
        }

        public Platform.IWindowInfo WindowInfo { get; }

        private static class NativeMethods
        {
            [DllImport("SDL2.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool SDL_HasEvents(int minType, int maxType);
        }
    }
}
