//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
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

using System;
using OpenTK.Graphics;

namespace OpenTK.Platform.Egl
{
    internal class EglGraphicsMode
    {
        public GraphicsMode SelectGraphicsMode(EglWindowInfo window,
            GraphicsMode mode, RenderableFlags flags)
        {
            return SelectGraphicsMode(window,
                mode.ColorFormat, mode.Depth, mode.Stencil,
                mode.Samples, mode.AccumulatorFormat, mode.Buffers, mode.Stereo,
                flags);
        }

        public GraphicsMode SelectGraphicsMode(EglWindowInfo window,
            ColorFormat color, int depth, int stencil,
            int samples, ColorFormat accum, int buffers, bool stereo,
            RenderableFlags renderableFlags)
        {
            return SelectGraphicsMode(
                SurfaceType.WINDOW_BIT,
                window.Display,
                color, depth, stencil, samples, accum, buffers, stereo, renderableFlags);
        }

        public GraphicsMode SelectGraphicsMode(SurfaceType surfaceType,
            IntPtr display, ColorFormat color, int depth, int stencil,
            int samples, ColorFormat accum, int buffers, bool stereo,
            RenderableFlags renderableFlags)
        {
            IntPtr[] configs = new IntPtr[1];
            int[] attribList = new int[]
            {
                Egl.SURFACE_TYPE, (int)surfaceType,
                Egl.RENDERABLE_TYPE, (int)renderableFlags,

                Egl.RED_SIZE, color.Red,
                Egl.GREEN_SIZE, color.Green,
                Egl.BLUE_SIZE, color.Blue,
                Egl.ALPHA_SIZE, color.Alpha,

                Egl.DEPTH_SIZE, depth > 0 ? depth : 0,
                Egl.STENCIL_SIZE, stencil > 0 ? stencil : 0,

                Egl.SAMPLE_BUFFERS, samples > 0 ? 1 : 0,
                Egl.SAMPLES, samples > 0 ? samples : 0,

                Egl.NONE,
            };

            int numConfigs;
            if (!Egl.ChooseConfig(display, attribList, configs, configs.Length, out numConfigs) || numConfigs == 0)
            {
                throw new GraphicsModeException(String.Format("Failed to retrieve GraphicsMode, error {0}", Egl.GetError()));
            }

            // See what we really got
            IntPtr activeConfig = configs[0];
            int r, g, b, a;
            Egl.GetConfigAttrib(display, activeConfig, Egl.RED_SIZE, out r);
            Egl.GetConfigAttrib(display, activeConfig, Egl.GREEN_SIZE, out g);
            Egl.GetConfigAttrib(display, activeConfig, Egl.BLUE_SIZE, out b);
            Egl.GetConfigAttrib(display, activeConfig, Egl.ALPHA_SIZE, out a);
            int d, s;
            Egl.GetConfigAttrib(display, activeConfig, Egl.DEPTH_SIZE, out d);
            Egl.GetConfigAttrib(display, activeConfig, Egl.STENCIL_SIZE, out s);
            int sampleBuffers;
            Egl.GetConfigAttrib(display, activeConfig, Egl.SAMPLES, out sampleBuffers);
            Egl.GetConfigAttrib(display, activeConfig, Egl.SAMPLES, out samples);

            return new GraphicsMode(activeConfig, new ColorFormat(r, g, b, a), d, s, sampleBuffers > 0 ? samples : 0, 0, 2, false);
        }
    }
}
