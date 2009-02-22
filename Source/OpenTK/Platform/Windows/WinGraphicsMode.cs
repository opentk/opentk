#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

using OpenTK.Graphics;
using ColorDepth = OpenTK.Graphics.ColorFormat;

namespace OpenTK.Platform.Windows
{
    internal class WinGraphicsMode : IGraphicsMode
    {
        #region --- Constructors ---

        public WinGraphicsMode()
        {
        }

        #endregion

        #region --- IGraphicsMode Members ---

        public GraphicsMode SelectGraphicsMode(ColorDepth color, int depth, int stencil, int samples, ColorDepth accum,
                                               int buffers, bool stereo)
        {
            return SelectGraphicsModePFD(color, depth, stencil, samples, accum, buffers, stereo);
        }

        #endregion

        #region --- Private Methods ---

        #region GraphicsMode SelectGraphicsModePFD(ColorFormat color, int depth, int stencil, int samples, ColorFormat accum, int buffers, bool stereo)

        GraphicsMode SelectGraphicsModePFD(ColorDepth color, int depth, int stencil, int samples, ColorDepth accum,
                                               int buffers, bool stereo)
        {
            using (Control native_window = new Control())
            using (WinWindowInfo window = new WinWindowInfo(native_window.Handle, null))
            {
                IntPtr deviceContext = ((WinWindowInfo)window).DeviceContext;
                Debug.WriteLine(String.Format("Device context: {0}", deviceContext));

                Debug.Write("Selecting pixel format... ");
                PixelFormatDescriptor pixelFormat = new PixelFormatDescriptor();
                pixelFormat.Size = API.PixelFormatDescriptorSize;
                pixelFormat.Version = API.PixelFormatDescriptorVersion;
                pixelFormat.Flags =
                    PixelFormatDescriptorFlags.SUPPORT_OPENGL |
                    PixelFormatDescriptorFlags.DRAW_TO_WINDOW;
                pixelFormat.ColorBits = (byte)(color.Red + color.Green + color.Blue);

                pixelFormat.PixelType = color.IsIndexed ? PixelType.INDEXED : PixelType.RGBA;
                pixelFormat.RedBits = (byte)color.Red;
                pixelFormat.GreenBits = (byte)color.Green;
                pixelFormat.BlueBits = (byte)color.Blue;
                pixelFormat.AlphaBits = (byte)color.Alpha;

                if (accum.BitsPerPixel > 0)
                {
                    pixelFormat.AccumBits = (byte)(accum.Red + accum.Green + accum.Blue);
                    pixelFormat.AccumRedBits = (byte)accum.Red;
                    pixelFormat.AccumGreenBits = (byte)accum.Green;
                    pixelFormat.AccumBlueBits = (byte)accum.Blue;
                    pixelFormat.AccumAlphaBits = (byte)accum.Alpha;
                }

                pixelFormat.DepthBits = (byte)depth;
                pixelFormat.StencilBits = (byte)stencil;

                if (depth <= 0) pixelFormat.Flags |= PixelFormatDescriptorFlags.DEPTH_DONTCARE;
                if (stereo) pixelFormat.Flags |= PixelFormatDescriptorFlags.STEREO;
                if (buffers > 1) pixelFormat.Flags |= PixelFormatDescriptorFlags.DOUBLEBUFFER;

                int pixel = Functions.ChoosePixelFormat(deviceContext, ref pixelFormat);
                if (pixel == 0)
                    throw new GraphicsModeException("The requested GraphicsMode is not available.");

                // Find out what we really got as a format:
                PixelFormatDescriptor pfd = new PixelFormatDescriptor();
                pixelFormat.Size = API.PixelFormatDescriptorSize;
                pixelFormat.Version = API.PixelFormatDescriptorVersion;
                Functions.DescribePixelFormat(deviceContext, pixel, API.PixelFormatDescriptorSize, ref pfd);
                GraphicsMode fmt = new GraphicsMode((IntPtr)pixel,
                    new ColorDepth(pfd.RedBits, pfd.GreenBits, pfd.BlueBits, pfd.AlphaBits),
                    pfd.DepthBits,
                    pfd.StencilBits,
                    0,
                    new ColorDepth(pfd.AccumBits),
                    (pfd.Flags & PixelFormatDescriptorFlags.DOUBLEBUFFER) != 0 ? 2 : 1,
                    (pfd.Flags & PixelFormatDescriptorFlags.STEREO) != 0);

                return fmt;
            }
        }

        #endregion

        #region GraphicsMode SetGraphicsModeARB(GraphicsMode format, IWindowInfo window)

        GraphicsMode SetGraphicsModeARB(GraphicsMode format, IWindowInfo window)
        {
            return null;
        }

        #endregion

        #endregion
    }
}
