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
        enum AccelerationType
        {
            // Software acceleration
            None = 0,
            // Partial acceleration (Direct3D emulation)
            MCD,
            // Full acceleration
            ICD,
        }

        readonly IntPtr Device;

        #region Constructors

        public WinGraphicsMode(IntPtr device)
        {
            if (device == IntPtr.Zero)
                throw new ArgumentException();

            Device = device;
        }

        #endregion

        #region IGraphicsMode Members

        public GraphicsMode SelectGraphicsMode(ColorFormat color, int depth, int stencil, int samples,
            ColorFormat accum, int buffers, bool stereo)
        {
            GraphicsMode mode = new GraphicsMode(color, depth, stencil, samples,accum, buffers, stereo);
            GraphicsMode created_mode = ChoosePixelFormatARB(Device, mode);

            // If ChoosePixelFormatARB failed, iterate through all acceleration types in turn (ICD, MCD, None)
            // This should fix issue #2224, which causes OpenTK to fail on VMs without hardware acceleration.
            created_mode = created_mode ?? ChoosePixelFormatPFD(Device, mode, AccelerationType.ICD);
            created_mode = created_mode ?? ChoosePixelFormatPFD(Device, mode, AccelerationType.MCD);
            created_mode = created_mode ?? ChoosePixelFormatPFD(Device, mode, AccelerationType.None);

            if (created_mode == null)
            {
                throw new GraphicsModeException("The requested GraphicsMode is not supported");
            }

            return created_mode;
        }

        #endregion

        #region Private Methods

        #region ChoosePixelFormatARB

        // Queries pixel formats through the WGL_ARB_pixel_format extension
        // This method only returns accelerated formats. If no format offers
        // hardware acceleration (e.g. we are running in a VM or in a remote desktop
        // connection), this method will return 0 formats and we will fall back to
        // ChoosePixelFormatPFD.
        GraphicsMode ChoosePixelFormatARB(IntPtr device, GraphicsMode desired_mode)
        {
            GraphicsMode created_mode = null;
            GraphicsMode mode = new GraphicsMode(desired_mode);
            if (Wgl.SupportsExtension("WGL_ARB_pixel_format") &&
                Wgl.SupportsFunction("wglChoosePixelFormatARB"))
            {
                int[] format = new int[1];
                int count;
                List<int> attributes = new List<int>();
                bool retry = false;

                do
                {
                    attributes.Clear();
                    attributes.Add((int)WGL_ARB_pixel_format.AccelerationArb);
                    attributes.Add((int)WGL_ARB_pixel_format.FullAccelerationArb);
                    attributes.Add((int)WGL_ARB_pixel_format.DrawToWindowArb);
                    attributes.Add(1);

                    if (mode.ColorFormat.Red > 0)
                    {
                        attributes.Add((int)WGL_ARB_pixel_format.RedBitsArb);
                        attributes.Add(mode.ColorFormat.Red);
                    }

                    if (mode.ColorFormat.Green > 0)
                    {
                        attributes.Add((int)WGL_ARB_pixel_format.GreenBitsArb);
                        attributes.Add(mode.ColorFormat.Green);
                    }

                    if (mode.ColorFormat.Blue > 0)
                    {
                        attributes.Add((int)WGL_ARB_pixel_format.BlueBitsArb);
                        attributes.Add(mode.ColorFormat.Blue);
                    }

                    if (mode.ColorFormat.Alpha > 0)
                    {
                        attributes.Add((int)WGL_ARB_pixel_format.AlphaBitsArb);
                        attributes.Add(mode.ColorFormat.Alpha);
                    }

                    if (mode.Depth > 0)
                    {
                        attributes.Add((int)WGL_ARB_pixel_format.DepthBitsArb);
                        attributes.Add(mode.Depth);
                    }

                    if (mode.Stencil > 0)
                    {
                        attributes.Add((int)WGL_ARB_pixel_format.StencilBitsArb);
                        attributes.Add(mode.Stencil);
                    }

                    if (mode.AccumulatorFormat.Red > 0)
                    {
                        attributes.Add((int)WGL_ARB_pixel_format.AccumRedBitsArb);
                        attributes.Add(mode.AccumulatorFormat.Red);
                    }

                    if (mode.AccumulatorFormat.Green > 0)
                    {
                        attributes.Add((int)WGL_ARB_pixel_format.AccumGreenBitsArb);
                        attributes.Add(mode.AccumulatorFormat.Green);
                    }

                    if (mode.AccumulatorFormat.Blue > 0)
                    {
                        attributes.Add((int)WGL_ARB_pixel_format.AccumBlueBitsArb);
                        attributes.Add(mode.AccumulatorFormat.Blue);
                    }

                    if (mode.AccumulatorFormat.Alpha > 0)
                    {
                        attributes.Add((int)WGL_ARB_pixel_format.AccumAlphaBitsArb);
                        attributes.Add(mode.AccumulatorFormat.Alpha);
                    }

                    if (mode.Samples > 0 &&
                    Wgl.SupportsExtension("WGL_ARB_multisample"))
                    {
                        attributes.Add((int)WGL_ARB_multisample.SampleBuffersArb);
                        attributes.Add(1);
                        attributes.Add((int)WGL_ARB_multisample.SamplesArb);
                        attributes.Add(mode.Samples);
                    }

                    if (mode.Buffers > 0)
                    {
                        attributes.Add((int)WGL_ARB_pixel_format.DoubleBufferArb);
                        attributes.Add(mode.Buffers > 1 ? 1 : 0);
                    }

                    if (mode.Stereo)
                    {
                        attributes.Add((int)WGL_ARB_pixel_format.StereoArb);
                        attributes.Add(1);
                    }

                    attributes.Add(0);
                    attributes.Add(0);

                    if (Wgl.Arb.ChoosePixelFormat(device, attributes.ToArray(), null, format.Length, format, out count)
                        && count > 0)
                    {
                        created_mode = DescribePixelFormatARB(device, format[0]);
                        retry = false;
                    }
                    else
                    {
                        Debug.Print("[WGL] ChoosePixelFormatARB failed with {0}", Marshal.GetLastWin32Error());
                        retry = Utilities.RelaxGraphicsMode(ref mode);
                    }
                }
                while (retry);
            }
            else
            {
                Debug.WriteLine("[WGL] ChoosePixelFormatARB not supported on this context");
            }

            return created_mode;
        }

        #endregion

        #region ChoosePixelFormatPFD

        static bool Compare(int got, int requested, ref int distance)
        {
            bool valid = true;
            if (got == 0 && requested != 0)
            {
                // mode does not support the requested feature.
                valid = false;
            }
            else if (got >= requested)
            {
                // mode supports the requested feature,
                // calculate the distance from an "ideal" mode
                // that matches this feature exactly.
                distance += got - requested;
            }
            else
            {
                // mode supports the requested feature,
                // but at a suboptimal level. For example:
                // - requsted AA = 8x, got 4x
                // - requested color = 32bpp, got 16bpp
                // We can still use this mode but only if
                // no better mode exists.
                const int penalty = 8;
                distance += penalty * Math.Abs(got - requested);
            }
            return valid;
        }

        static AccelerationType GetAccelerationType(ref PixelFormatDescriptor pfd)
        {
            AccelerationType type = AccelerationType.ICD;
            if ((pfd.Flags & PixelFormatDescriptorFlags.GENERIC_FORMAT) != 0)
            {
                if ((pfd.Flags & PixelFormatDescriptorFlags.GENERIC_ACCELERATED) != 0)
                {
                    type = AccelerationType.MCD;
                }
                else
                {
                    type = AccelerationType.None;
                }
            }
            return type;
        }

        GraphicsMode ChoosePixelFormatPFD(IntPtr device, GraphicsMode mode, AccelerationType requested_acceleration_type)
        {
            PixelFormatDescriptor pfd = new PixelFormatDescriptor();
            PixelFormatDescriptorFlags flags = 0;
            flags |= PixelFormatDescriptorFlags.DRAW_TO_WINDOW;
            flags |= PixelFormatDescriptorFlags.SUPPORT_OPENGL;

            if (mode.Stereo)
            {
                flags |= PixelFormatDescriptorFlags.STEREO;
            }

            if (System.Environment.OSVersion.Version.Major >= 6 &&
                requested_acceleration_type != AccelerationType.None)
            {
                // Request a compositor-capable mode when running on
                // Vista+ and using hardware acceleration. Without this,
                // some modes will cause the compositor to turn off,
                // which is very annoying to the user.
                // Note: compositor-capable modes require hardware
                // acceleration. Don't set this flag when running
                // with software acceleration (e.g. over Remote Desktop
                // as described in bug https://github.com/opentk/opentk/issues/35)
                flags |= PixelFormatDescriptorFlags.SUPPORT_COMPOSITION;
            }

            int count = Functions.DescribePixelFormat(device, 1, API.PixelFormatDescriptorSize, ref pfd);

            int best = 0;
            int best_dist = int.MaxValue;
            for (int index = 1; index <= count; index++)
            {
                int dist = 0;
                bool valid = Functions.DescribePixelFormat(device, index, API.PixelFormatDescriptorSize, ref pfd) != 0;
                valid &= GetAccelerationType(ref pfd) == requested_acceleration_type;
                valid &= (pfd.Flags & flags) == flags;
                valid &= pfd.PixelType == PixelType.RGBA; // indexed modes not currently supported
                // heavily penalize single-buffered modes when the user requests double buffering
                if ((pfd.Flags & PixelFormatDescriptorFlags.DOUBLEBUFFER) == 0 && mode.Buffers > 1)
                    dist += 1000;
                valid &= Compare(pfd.ColorBits, mode.ColorFormat.BitsPerPixel, ref dist);
                valid &= Compare(pfd.RedBits, mode.ColorFormat.Red, ref dist);
                valid &= Compare(pfd.GreenBits, mode.ColorFormat.Green, ref dist);
                valid &= Compare(pfd.BlueBits, mode.ColorFormat.Blue, ref dist);
                valid &= Compare(pfd.AlphaBits, mode.ColorFormat.Alpha, ref dist);
                valid &= Compare(pfd.AccumBits, mode.AccumulatorFormat.BitsPerPixel, ref dist);
                valid &= Compare(pfd.AccumRedBits, mode.AccumulatorFormat.Red, ref dist);
                valid &= Compare(pfd.AccumGreenBits, mode.AccumulatorFormat.Green, ref dist);
                valid &= Compare(pfd.AccumBlueBits, mode.AccumulatorFormat.Blue, ref dist);
                valid &= Compare(pfd.AccumAlphaBits, mode.AccumulatorFormat.Alpha, ref dist);
                valid &= Compare(pfd.DepthBits, mode.Depth, ref dist);
                valid &= Compare(pfd.StencilBits, mode.Stencil, ref dist);

                if (valid && dist < best_dist)
                {
                    best = index;
                    best_dist = dist;
                }
            }

            return DescribePixelFormatPFD(device, ref pfd, best);
        }

        #endregion

        #region DescribePixelFormatPFD

        static GraphicsMode DescribePixelFormatPFD(IntPtr device, ref PixelFormatDescriptor pfd,
            int pixelformat)
        {
            GraphicsMode created_mode = null;
            if (Functions.DescribePixelFormat(device, pixelformat, pfd.Size, ref pfd) > 0)
            {
                created_mode = new GraphicsMode(
                    new IntPtr(pixelformat),
                    new ColorFormat(pfd.RedBits, pfd.GreenBits, pfd.BlueBits, pfd.AlphaBits),
                    pfd.DepthBits,
                    pfd.StencilBits,
                    0, // MSAA not supported when using PixelFormatDescriptor
                    new ColorFormat(pfd.AccumRedBits, pfd.AccumGreenBits, pfd.AccumBlueBits, pfd.AccumAlphaBits),
                    (pfd.Flags & PixelFormatDescriptorFlags.DOUBLEBUFFER) != 0 ? 2 : 1,
                    (pfd.Flags & PixelFormatDescriptorFlags.STEREO) != 0);
            }
            return created_mode;
        }

        #endregion

        #region DescribePixelFormatARB

        GraphicsMode DescribePixelFormatARB(IntPtr device, int pixelformat)
        {
            GraphicsMode created_mode = null;
            // See http://www.opengl.org/registry/specs/ARB/wgl_pixel_format.txt for more details
            if (Wgl.SupportsFunction("wglGetPixelFormatAttribivARB"))
            {
                // Define the list of attributes we are interested in.
                // The results will be stored in the 'values' array below.
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

                // Allocate storage for the results of GetPixelFormatAttrib queries
                int[] values = new int[attribs.Length];

                // Get the format attributes for this pixel format
                if (!Wgl.Arb.GetPixelFormatAttrib(device, pixelformat, 0, attribs.Length - 1, attribs, values))
                {
                    Debug.Print("[Warning] Failed to detect attributes for PixelFormat: {0}.", pixelformat);
                }

                // Skip formats that don't offer full hardware acceleration
                WGL_ARB_pixel_format acceleration = (WGL_ARB_pixel_format)values[0];
                if (acceleration == WGL_ARB_pixel_format.FullAccelerationArb)
                {
                    // Construct a new GraphicsMode to describe this format
                    created_mode = new GraphicsMode(new IntPtr(pixelformat),
                        new ColorFormat(values[1], values[2], values[3], values[4]),
                        values[6],
                        values[7],
                        values[8] != 0 ? values[9] : 0,
                        new ColorFormat(values[10], values[11], values[12], values[13]),
                        values[15] == 1 ? 2 : 1,
                        values[16] == 1 ? true : false);
                }
            }
            return created_mode;
        }

        #endregion

        #endregion
    }
}
