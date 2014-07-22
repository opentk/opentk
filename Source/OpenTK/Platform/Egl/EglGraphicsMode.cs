#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Graphics;

namespace OpenTK.Platform.Egl
{
    class EglGraphicsMode
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
            RenderableFlags renderable_flags)
        {
            IntPtr[] configs = new IntPtr[1];
            int[] attribList = new int[] 
            { 
                Egl.SURFACE_TYPE, Egl.WINDOW_BIT,
                Egl.RENDERABLE_TYPE, (int)renderable_flags,

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

            IntPtr display = window.Display;

            int num_configs;
            if (!Egl.ChooseConfig(display, attribList, configs, configs.Length, out num_configs) || num_configs == 0)
            {
                throw new GraphicsModeException(String.Format("Failed to retrieve GraphicsMode, error {0}", Egl.GetError()));
            }

            // See what we really got
            IntPtr active_config = configs[0];
            int r, g, b, a;
            Egl.GetConfigAttrib(display, active_config, Egl.RED_SIZE, out r);
            Egl.GetConfigAttrib(display, active_config, Egl.GREEN_SIZE, out g);
            Egl.GetConfigAttrib(display, active_config, Egl.BLUE_SIZE, out b);
            Egl.GetConfigAttrib(display, active_config, Egl.ALPHA_SIZE, out a);
            int d, s;
            Egl.GetConfigAttrib(display, active_config, Egl.DEPTH_SIZE, out d);
            Egl.GetConfigAttrib(display, active_config, Egl.STENCIL_SIZE, out s);
            int sample_buffers;
            Egl.GetConfigAttrib(display, active_config, Egl.SAMPLES, out sample_buffers);
            Egl.GetConfigAttrib(display, active_config, Egl.SAMPLES, out samples);

            return new GraphicsMode(active_config, new ColorFormat(r, g, b, a), d, s, sample_buffers > 0 ? samples : 0, 0, 2, false);
        }
    }
}
