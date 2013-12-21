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

        static readonly object SyncRoot = new object();
        readonly IntPtr Device;
        readonly List<GraphicsMode> modes = new List<GraphicsMode>();

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
        GraphicsMode ChoosePixelFormatARB(IntPtr device, GraphicsMode mode)
        {
            GraphicsMode created_mode = null;
            if (Wgl.Delegates.wglChoosePixelFormatARB != null)
            {
                List<int> attributes = new List<int>();
                attributes.Add((int)WGL_ARB_pixel_format.AccelerationArb);
                attributes.Add((int)WGL_ARB_pixel_format.FullAccelerationArb);

                if (mode.ColorFormat.BitsPerPixel > 0)
                {
                    attributes.Add((int)WGL_ARB_pixel_format.RedBitsArb);
                    attributes.Add(mode.ColorFormat.Red);
                    attributes.Add((int)WGL_ARB_pixel_format.GreenBitsArb);
                    attributes.Add(mode.ColorFormat.Green);
                    attributes.Add((int)WGL_ARB_pixel_format.BlueBitsArb);
                    attributes.Add(mode.ColorFormat.Blue);
                    attributes.Add((int)WGL_ARB_pixel_format.AlphaBitsArb);
                    attributes.Add(mode.ColorFormat.Alpha);
                    attributes.Add((int)WGL_ARB_pixel_format.ColorBitsArb);
                    attributes.Add(mode.ColorFormat.BitsPerPixel);
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

                if (mode.AccumulatorFormat.BitsPerPixel > 0)
                {
                    attributes.Add((int)WGL_ARB_pixel_format.AccumRedBitsArb);
                    attributes.Add(mode.AccumulatorFormat.Red);
                    attributes.Add((int)WGL_ARB_pixel_format.AccumGreenBitsArb);
                    attributes.Add(mode.AccumulatorFormat.Green);
                    attributes.Add((int)WGL_ARB_pixel_format.AccumBlueBitsArb);
                    attributes.Add(mode.AccumulatorFormat.Blue);
                    attributes.Add((int)WGL_ARB_pixel_format.AccumAlphaBitsArb);
                    attributes.Add(mode.AccumulatorFormat.Alpha);
                    attributes.Add((int)WGL_ARB_pixel_format.AccumBitsArb);
                    attributes.Add(mode.AccumulatorFormat.BitsPerPixel);
                }

                if (mode.Samples > 0)
                {
                    attributes.Add((int)WGL_ARB_multisample.SampleBuffersArb);
                    attributes.Add(1);
                    attributes.Add((int)WGL_ARB_multisample.SamplesArb);
                    attributes.Add(mode.Samples);
                }

                if (mode.Buffers > 0)
                {
                    attributes.Add((int)WGL_ARB_pixel_format.DoubleBufferArb);
                    attributes.Add(mode.Buffers);
                }

                if (mode.Stereo)
                {
                    attributes.Add((int)WGL_ARB_pixel_format.StereoArb);
                    attributes.Add(1);
                }

                attributes.Add(0);
                attributes.Add(0);

                int[] format = new int[1];
                int count;
                if (Wgl.Arb.ChoosePixelFormat(device, attributes.ToArray(), null, format.Length, format, out count))
                {
                    created_mode = DescribePixelFormatARB(device, format[0]);
                }
                else
                {
                    Debug.Print("[WGL] ChoosePixelFormatARB failed with {0}", Marshal.GetLastWin32Error());
                }
            }
            else
            {
                Debug.Print("[WGL] ChoosePixelFormatARB not supported");
            }

            return created_mode;
        }

        #endregion

        #region ChoosePixelFormatPFD

        GraphicsMode ChoosePixelFormatPFD(IntPtr Device, GraphicsMode mode, AccelerationType requested_acceleration_type)
        {
            PixelFormatDescriptor pfd = new PixelFormatDescriptor();
            pfd.Size = (short)BlittableValueType<PixelFormatDescriptor>.Stride;

            if (mode.ColorFormat.BitsPerPixel > 0)
            {
                pfd.RedBits = (byte)mode.ColorFormat.Red;
                pfd.GreenBits = (byte)mode.ColorFormat.Green;
                pfd.BlueBits = (byte)mode.ColorFormat.Blue;
                pfd.AlphaBits = (byte)mode.ColorFormat.Alpha;
                pfd.ColorBits = (byte)mode.ColorFormat.BitsPerPixel;
            }

            if (mode.Depth > 0)
            {
                pfd.DepthBits = (byte)mode.Depth;
            }

            if (mode.Stencil > 0)
            {
                pfd.StencilBits = (byte)mode.Stencil;
            }

            if (mode.AccumulatorFormat.BitsPerPixel > 0)
            {
                pfd.AccumRedBits = (byte)mode.AccumulatorFormat.Red;
                pfd.AccumGreenBits = (byte)mode.AccumulatorFormat.Green;
                pfd.AccumBlueBits = (byte)mode.AccumulatorFormat.Blue;
                pfd.AccumAlphaBits = (byte)mode.AccumulatorFormat.Alpha;
                pfd.AccumBits = (byte)mode.AccumulatorFormat.BitsPerPixel;
            }

            if (mode.Buffers > 0)
            {
                pfd.Flags |= PixelFormatDescriptorFlags.DOUBLEBUFFER;
            }

            if (mode.Stereo)
            {
                pfd.Flags |= PixelFormatDescriptorFlags.DRAW_TO_WINDOW;
                pfd.Flags |= PixelFormatDescriptorFlags.SUPPORT_OPENGL;
            }

            // Make sure we don't turn off Aero on Vista and newer.
            if (Environment.OSVersion.Version.Major >= 6)
            {
                pfd.Flags |= PixelFormatDescriptorFlags.SUPPORT_COMPOSITION;
            }

            GraphicsMode created_mode = null;
            int pixelformat = Functions.ChoosePixelFormat(Device, ref pfd);
            if (pixelformat > 0)
            {
                AccelerationType acceleration_type = AccelerationType.ICD;
                if ((pfd.Flags & PixelFormatDescriptorFlags.GENERIC_FORMAT) != 0)
                {
                    if ((pfd.Flags & PixelFormatDescriptorFlags.GENERIC_ACCELERATED) != 0)
                    {
                        acceleration_type = AccelerationType.MCD;
                    }
                    else
                    {
                        acceleration_type = AccelerationType.None;
                    }
                }

                if (acceleration_type == requested_acceleration_type)
                {
                    created_mode = DescribePixelFormatPFD(ref pfd, pixelformat);
                }
            }
            return created_mode;
        }

        #endregion

        #region DescribePixelFormatPFD

        static GraphicsMode DescribePixelFormatPFD(ref PixelFormatDescriptor pfd, int pixelformat)
        {
            return new GraphicsMode(
                new IntPtr(pixelformat),
                new ColorFormat(pfd.RedBits, pfd.GreenBits, pfd.BlueBits, pfd.AlphaBits),
                pfd.DepthBits,
                pfd.StencilBits,
                0, // MSAA not supported
                new ColorFormat(pfd.AccumRedBits, pfd.AccumGreenBits, pfd.AccumBlueBits, pfd.AccumAlphaBits),
                (pfd.Flags & PixelFormatDescriptorFlags.DOUBLEBUFFER) != 0 ? 2 : 1,
                (pfd.Flags & PixelFormatDescriptorFlags.STEREO) != 0);
        }

        #endregion

        #region DescribePixelFormatARB

        GraphicsMode DescribePixelFormatARB(IntPtr device, int pixelformat)
        {
            GraphicsMode created_mode = null;
            // See http://www.opengl.org/registry/specs/ARB/wgl_pixel_format.txt for more details
            if (Wgl.Delegates.wglGetPixelFormatAttribivARB != null)
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
                WGL_ARB_pixel_format acceleration = (WGL_ARB_pixel_format)attribs[0];
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
