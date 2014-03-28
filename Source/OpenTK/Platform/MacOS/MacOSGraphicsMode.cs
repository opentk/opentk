#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
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
using System.Diagnostics;
using System.Text;
using OpenTK.Graphics;

namespace OpenTK.Platform.MacOS
{
    using Carbon;

    class MacOSGraphicsMode : IGraphicsMode
    {
        readonly IntPtr Device;

        public MacOSGraphicsMode(IntPtr device)
        {
            Device = device;
        }

        #region IGraphicsMode Members

        public GraphicsMode SelectGraphicsMode(ColorFormat color, int depth, int stencil,
            int samples, ColorFormat accum, int buffers, bool stereo)
        {
            IntPtr pixelformat;
            do
            {
                pixelformat = SelectPixelFormat(
                    color, depth, stencil, samples, accum, buffers, stereo,
                    true, Device);

                Agl.AglError err = Agl.GetError();
                if (pixelformat == IntPtr.Zero || err == Agl.AglError.BadPixelFormat)
                {
                    Debug.Print("Failed to create full screen pixel format.");
                    Debug.Print("Trying again to create a non-fullscreen pixel format.");
                    pixelformat = SelectPixelFormat(
                        color, depth, stencil, samples, accum, buffers, stereo,
                        false, IntPtr.Zero);
                }

                if (pixelformat == IntPtr.Zero)
                {
                    if (!Utilities.RelaxGraphicsMode(
                        ref color, ref depth, ref stencil, ref samples, ref accum,
                        ref buffers, ref stereo))
                    {
                        throw new GraphicsModeException("Requested GraphicsMode not available.");
                    }
                }
            }
            while (pixelformat == IntPtr.Zero);

            return GetGraphicsModeFromPixelFormat(pixelformat);
        }

        #endregion

        #region Internal Members

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

            return new GraphicsMode(pixelformat, new ColorFormat(r, g, b, a),
                depth, stencil, samples, new ColorFormat(ar, ag, ab, aa), buffers + 1, stereo != 0);
        }

        IntPtr SelectPixelFormat(ColorFormat color, int depth, int stencil, int samples,
            ColorFormat accum, int buffers, bool stereo, bool fullscreen, IntPtr device)
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

            if (stencil > 1)
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

            if (fullscreen)
            {
                attribs.Add((int)Agl.PixelFormatAttribute.AGL_FULLSCREEN);
            }

            attribs.Add(0);
            attribs.Add(0);

            IntPtr pixelformat = IntPtr.Zero;
            if (device != IntPtr.Zero)
            {
                pixelformat = Agl.aglChoosePixelFormat(ref device, 0, attribs.ToArray());
            }
            else
            {
                pixelformat = Agl.aglChoosePixelFormat(IntPtr.Zero, 0, attribs.ToArray());
            }
            return pixelformat;
        }

        #endregion
    }
}
