// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using OpenTK.Graphics;

namespace OpenTK.Platform.MacOS
{
    class AglGraphicsMode
    {
        public GraphicsMode SelectGraphicsMode(ColorFormat color, int depth, int stencil,
            int samples, ColorFormat accum, int buffers, bool stereo, out IntPtr pixelformat)
        {
            do
            {
                pixelformat = SelectPixelFormat(
                    color, depth, stencil, samples, accum, buffers, stereo);

                if (pixelformat == IntPtr.Zero)
                {
                    if (!RelaxGraphicsMode(
                        ref color, ref depth, ref stencil, ref samples, ref accum,
                        ref buffers, ref stereo))
                    {
                        throw new GraphicsModeException("Requested GraphicsMode not available, error: " + Agl.GetError());
                    }
                }
            }
            while (pixelformat == IntPtr.Zero);

            return GetGraphicsModeFromPixelFormat(pixelformat);
        }

        #region Internal Members

        static bool RelaxGraphicsMode(ref ColorFormat color, ref int depth, ref int stencil, ref int samples, ref ColorFormat accum, ref int buffers, ref bool stereo)
        {
            // Parameters are relaxed in order of importance.
            // - Accumulator buffers are way outdated as a concept,
            // so they go first.
            // - Triple+ buffering is generally not supported by the
            // core WGL/GLX/AGL/CGL/EGL specs, so we clamp
            // to double-buffering as a second step. (If this doesn't help
            // we will also fall back to undefined single/double buffering
            // as a last resort).
            // - AA samples are an easy way to increase compatibility
            // so they go next.
            // - Stereoscopic is only supported on very few GPUs
            // (Quadro/FirePro series) so it goes next.
            // - The rest of the parameters then follow.

            if (accum != 0)
            {
                accum = 0;
                return true;
            }

            if (buffers > 2)
            {
                buffers = 2;
                return true;
            }

            if (samples > 0)
            {
                samples = Math.Max(samples - 1, 0);
                return true;
            }

            if (stereo)
            {
                stereo = false;
                return true;
            }

            if (stencil != 0)
            {
                stencil = 0;
                return true;
            }

            if (depth != 0)
            {
                depth = 0;
                return true;
            }

            if (color != 24)
            {
                color = 24;
                return true;
            }

            if (buffers != 0)
            {
                buffers = 0;
                return true;
            }

            // no parameters left to relax, fail
            return false;
        }

        GraphicsMode GetGraphicsModeFromPixelFormat(IntPtr pixelformat)
        {
            int r, g, b, a;
            Agl.aglDescribePixelFormat(pixelformat, Agl.PixelFormatAttribute.AGL_RED_SIZE, out r);
            Agl.aglDescribePixelFormat(pixelformat, Agl.PixelFormatAttribute.AGL_GREEN_SIZE, out g);
            Agl.aglDescribePixelFormat(pixelformat, Agl.PixelFormatAttribute.AGL_BLUE_SIZE, out b);
            Agl.aglDescribePixelFormat(pixelformat, Agl.PixelFormatAttribute.AGL_ALPHA_SIZE, out a);
            int ar, ag, ab, aa;
            Agl.aglDescribePixelFormat(pixelformat, Agl.PixelFormatAttribute.AGL_ACCUM_ALPHA_SIZE, out aa);
            Agl.aglDescribePixelFormat(pixelformat, Agl.PixelFormatAttribute.AGL_ACCUM_RED_SIZE, out ar);
            Agl.aglDescribePixelFormat(pixelformat, Agl.PixelFormatAttribute.AGL_ACCUM_GREEN_SIZE, out ag);
            Agl.aglDescribePixelFormat(pixelformat, Agl.PixelFormatAttribute.AGL_ACCUM_BLUE_SIZE, out ab);
            int depth, stencil, samples, buffers, stereo;
            Agl.aglDescribePixelFormat(pixelformat, Agl.PixelFormatAttribute.AGL_DEPTH_SIZE, out depth);
            Agl.aglDescribePixelFormat(pixelformat, Agl.PixelFormatAttribute.AGL_STENCIL_SIZE, out stencil);
            Agl.aglDescribePixelFormat(pixelformat, Agl.PixelFormatAttribute.AGL_SAMPLES_ARB, out samples);
            Agl.aglDescribePixelFormat(pixelformat, Agl.PixelFormatAttribute.AGL_DOUBLEBUFFER, out buffers);
            Agl.aglDescribePixelFormat(pixelformat, Agl.PixelFormatAttribute.AGL_STEREO, out stereo);

            return new GraphicsMode(new ColorFormat(r, g, b, a),
                depth, stencil, samples, new ColorFormat(ar, ag, ab, aa), buffers + 1, stereo != 0);
        }

        IntPtr SelectPixelFormat(ColorFormat color, int depth, int stencil, int samples,
            ColorFormat accum, int buffers, bool stereo)
        {
            List<int> attribs = new List<int>();

            Debug.Print("Bits per pixel: {0}", color.BitsPerPixel);
            
            if (color.BitsPerPixel > 0)
            {
                if (!color.IsIndexed)
                {
                    attribs.Add((int)Agl.PixelFormatAttribute.AGL_RGBA);
                }
                attribs.Add((int)Agl.PixelFormatAttribute.AGL_RED_SIZE);
                attribs.Add(color.Red);
                attribs.Add((int)Agl.PixelFormatAttribute.AGL_GREEN_SIZE);
                attribs.Add(color.Green);
                attribs.Add((int)Agl.PixelFormatAttribute.AGL_BLUE_SIZE);
                attribs.Add(color.Blue);
                attribs.Add((int)Agl.PixelFormatAttribute.AGL_ALPHA_SIZE);
                attribs.Add(color.Alpha);
            }

            Debug.Print("Depth: {0}", depth);

            if (depth > 0)
            {
                attribs.Add((int)Agl.PixelFormatAttribute.AGL_DEPTH_SIZE);
                attribs.Add(depth);
            }

            if (buffers > 1)
            {
                attribs.Add((int)Agl.PixelFormatAttribute.AGL_DOUBLEBUFFER);
            }

            if (stencil > 0)
            {
                attribs.Add((int)Agl.PixelFormatAttribute.AGL_STENCIL_SIZE);
                attribs.Add(stencil);
            }

            if (accum.BitsPerPixel > 0)
            {
                attribs.Add((int)Agl.PixelFormatAttribute.AGL_ACCUM_ALPHA_SIZE);
                attribs.Add(accum.Alpha);
                attribs.Add((int)Agl.PixelFormatAttribute.AGL_ACCUM_BLUE_SIZE);
                attribs.Add(accum.Blue);
                attribs.Add((int)Agl.PixelFormatAttribute.AGL_ACCUM_GREEN_SIZE);
                attribs.Add(accum.Green);
                attribs.Add((int)Agl.PixelFormatAttribute.AGL_ACCUM_RED_SIZE);
                attribs.Add(accum.Red);
            }

            if (samples > 0)
            {
                attribs.Add((int)Agl.PixelFormatAttribute.AGL_SAMPLE_BUFFERS_ARB);
                attribs.Add(1);
                attribs.Add((int)Agl.PixelFormatAttribute.AGL_SAMPLES_ARB);
                attribs.Add(samples);
            }

            if (stereo)
            {
                attribs.Add((int)Agl.PixelFormatAttribute.AGL_STEREO);
            }

            attribs.Add(0);
            attribs.Add(0);

            IntPtr pixelformat = Agl.aglChoosePixelFormat(IntPtr.Zero, 0, attribs.ToArray());
            return pixelformat;
        }

        #endregion
    }
}
