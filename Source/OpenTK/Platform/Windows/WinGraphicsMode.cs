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
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

using OpenTK.Graphics;

namespace OpenTK.Platform.Windows
{
    class WinGraphicsMode : IGraphicsMode
    {
        #region Fields

        readonly List<GraphicsMode> modes = new List<GraphicsMode>();
        static readonly object SyncRoot = new object();

        #endregion

        #region Constructors

        public WinGraphicsMode()
        {
            lock (SyncRoot)
            {
                using (INativeWindow native = new NativeWindow())
                {
                    modes.AddRange(GetModesARB(native));
                    if (modes.Count == 0)
                        modes.AddRange(GetModesPFD(native));
                    if (modes.Count == 0)
                        throw new GraphicsModeException(
                            "No GraphicsMode available. This should never happen, please report a bug at http://www.opentk.com");
                }
                modes.Sort(new GraphicsModeComparer());
            }
        }

        #endregion

        #region IGraphicsMode Members

        public GraphicsMode SelectGraphicsMode(ColorFormat color, int depth, int stencil, int samples,
            ColorFormat accum, int buffers, bool stereo)
        {
            GraphicsMode mode = null;
            do
            {
                mode = modes.Find(delegate(GraphicsMode current)
                {
                    return ModeSelector(current, color, depth, stencil, samples, accum, buffers, stereo);
                });
            } while (mode == null && RelaxParameters(
                ref color, ref depth, ref stencil, ref samples, ref accum, ref buffers, ref stereo));

            if (mode == null)
                mode = modes[0];

            return mode;
        }

        bool RelaxParameters(ref ColorFormat color, ref int depth, ref int stencil, ref int samples,
            ref ColorFormat accum, ref int buffers, ref bool stereo)
        {
            if (stereo) { stereo = false; return true; }
            if (buffers != 2) { buffers = 2; return true; }
            if (accum != 0) { accum = 0; return true; }
            if (samples != 0) { samples = 0; return true; }
            if (depth < 16) { depth = 16; return true; }
            if (depth != 24) { depth = 24; return true; }
            if (stencil > 0 && stencil != 8) { stencil = 8; return true; }
            if (stencil == 8) { stencil = 0; return true; }
            if (color < 8) { color = 8; return true; }
            if (color < 16) { color = 16; return true; }
            if (color < 24) { color = 24; return true; }
            if (color < 32 || color > 32) { color = 32; return true; }
            return false; // We tried everything we could, no match found.
        }

        #endregion

        #region Private Methods

        #region DescribePixelFormat

        static int DescribePixelFormat(IntPtr hdc, int ipfd, int cjpfd, ref PixelFormatDescriptor pfd)
        {
            unsafe
            {
                fixed (PixelFormatDescriptor* ppfd = &pfd)
                {
                    // Note: DescribePixelFormat found in gdi32 is extremely slow
                    // on nvidia, for some reason.
                    return Wgl.Imports.DescribePixelFormat(hdc, ipfd, (uint)cjpfd, ppfd);
                }
            }
        }

        #endregion

        #region GetModesPFD

        IEnumerable<GraphicsMode> GetModesPFD(INativeWindow native)
        {
            WinWindowInfo window = native.WindowInfo as WinWindowInfo;
            IntPtr deviceContext = ((WinWindowInfo)window).DeviceContext;
            Debug.WriteLine(String.Format("Device context: {0}", deviceContext));

            Debug.WriteLine("Retrieving PFD pixel formats... ");
            PixelFormatDescriptor pfd = new PixelFormatDescriptor();
            pfd.Size = API.PixelFormatDescriptorSize;
            pfd.Version = API.PixelFormatDescriptorVersion;
            pfd.Flags =
                PixelFormatDescriptorFlags.SUPPORT_OPENGL |
                PixelFormatDescriptorFlags.DRAW_TO_WINDOW;

            // Make sure we don't turn off Aero on Vista and newer.
            if (Environment.OSVersion.Version.Major >= 6)
            {
                pfd.Flags |= PixelFormatDescriptorFlags.SUPPORT_COMPOSITION;
            }

            foreach (bool generic_allowed in new bool[] { false, true })
            {
                // Iterate through all accelerated formats first. Afterwards, iterate through non-accelerated formats.
                // This should fix issue #2224, which causes OpenTK to fail on VMs without hardware acceleration.
                int pixel = 0;
                while (DescribePixelFormat(deviceContext, ++pixel, API.PixelFormatDescriptorSize, ref pfd) != 0)
                {
                    // Ignore non-accelerated formats.
                    if (!generic_allowed && (pfd.Flags & PixelFormatDescriptorFlags.GENERIC_FORMAT) != 0)
                        continue;

                    GraphicsMode fmt = new GraphicsMode((IntPtr)pixel,
                        new ColorFormat(pfd.RedBits, pfd.GreenBits, pfd.BlueBits, pfd.AlphaBits),
                        pfd.DepthBits,
                        pfd.StencilBits,
                        0,
                        new ColorFormat(pfd.AccumBits),
                        (pfd.Flags & PixelFormatDescriptorFlags.DOUBLEBUFFER) != 0 ? 2 : 1,
                        (pfd.Flags & PixelFormatDescriptorFlags.STEREO) != 0);

                    yield return fmt;
                }
            }
        }

        #endregion

        #region GetModesARB

        IEnumerable<GraphicsMode> GetModesARB(INativeWindow native)
        {
            using (IGraphicsContext context = new GraphicsContext(
                new GraphicsMode(new IntPtr(2), new ColorFormat(), 0, 0, 0, new ColorFormat(), 2, false),
                (WinWindowInfo)native.WindowInfo, 1, 0, GraphicsContextFlags.Default))
            {
                WinWindowInfo window = (WinWindowInfo)native.WindowInfo;

                // See http://www.opengl.org/registry/specs/ARB/wgl_pixel_format.txt 
                // for more details
                Debug.Write("Retrieving ARB pixel formats.... ");
                if (Wgl.Delegates.wglChoosePixelFormatARB == null || Wgl.Delegates.wglGetPixelFormatAttribivARB == null)
                {
                    Debug.WriteLine("failed.");
                    yield break;
                }

                int[] attribs = new int[]
                {
                    (int)WGL_ARB_pixel_format.AccelerationArb,

                    (int)WGL_ARB_pixel_format.RedBitsArb,
                    (int)WGL_ARB_pixel_format.GreenBitsArb,
                    (int)WGL_ARB_pixel_format.BlueBitsArb,
                    (int)WGL_ARB_pixel_format.AlphaBitsArb,
                    (int)WGL_ARB_pixel_format.ColorBitsArb,
                    
                    (int)WGL_ARB_pixel_format.DepthBitsArb,
                    (int)WGL_ARB_pixel_format.StencilBitsArb,
                    
                    (int)WGL_ARB_multisample.SampleBuffersArb,
                    (int)WGL_ARB_multisample.SamplesArb,

                    (int)WGL_ARB_pixel_format.AccumRedBitsArb,
                    (int)WGL_ARB_pixel_format.AccumGreenBitsArb,
                    (int)WGL_ARB_pixel_format.AccumBlueBitsArb,
                    (int)WGL_ARB_pixel_format.AccumAlphaBitsArb,
                    (int)WGL_ARB_pixel_format.AccumBitsArb,

                    (int)WGL_ARB_pixel_format.DoubleBufferArb,
                    (int)WGL_ARB_pixel_format.StereoArb,
                    0
                };

                int[] values = new int[attribs.Length];

                int[] attribs_values = new int[]
                {
                    (int)WGL_ARB_pixel_format.AccelerationArb,
                    (int)WGL_ARB_pixel_format.FullAccelerationArb,
                    (int)WGL_ARB_pixel_format.SupportOpenglArb, 1,
                    (int)WGL_ARB_pixel_format.DrawToWindowArb, 1,
                    0, 0
                };

                int[] num_formats = new int[1];
                // Get the number of available formats
                if (Wgl.Arb.ChoosePixelFormat(window.DeviceContext, attribs_values, null, 0, null, num_formats))
                {
                    // Create an array big enough to hold all available formats and get those formats
                    int[] pixel = new int[num_formats[0]];
                    
                    if (Wgl.Arb.ChoosePixelFormat(window.DeviceContext, attribs_values, null, pixel.Length, pixel, num_formats))
                    {
                        foreach (int p in pixel)
                        {
                            // Find out what we really got as a format:
                            if (!Wgl.Arb.GetPixelFormatAttrib(window.DeviceContext, p, 0, attribs.Length - 1, attribs, values))
                            {
                                Debug.Print("[Warning] Failed to detect attributes for PixelFormat:{0}.", p);
                                continue;
                            }

                            GraphicsMode mode = new GraphicsMode(new IntPtr(p),
                                new ColorFormat(values[1], values[2], values[3], values[4]),
                                values[6],
                                values[7],
                                values[8] != 0 ? values[9] : 0,
                                new ColorFormat(values[10], values[11], values[12], values[13]),
                                values[15] == 1 ? 2 : 1,
                                values[16] == 1 ? true : false);

                            yield return mode;
                        }
                    }
                }
            }
        }

        #endregion

        #region ModeSelector

        bool ModeSelector(GraphicsMode current, ColorFormat color, int depth, int stencil, int samples,
            ColorFormat accum, int buffers, bool stereo)
        {
            bool result =
                (color != ColorFormat.Empty ? current.ColorFormat >= color : true) &&
                (depth != 0 ? current.Depth >= depth : true) &&
                (stencil != 0 ? current.Stencil >= stencil : true) &&
                (samples != 0 ? current.Samples >= samples : true) &&
                (accum != ColorFormat.Empty ? current.AccumulatorFormat >= accum : true) &&
                (buffers != 0 ? current.Buffers >= buffers : true) &&
                current.Stereo == stereo;
            return result;
        }

        #endregion

        #endregion
    }
}
