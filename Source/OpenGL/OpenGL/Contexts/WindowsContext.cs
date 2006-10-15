#region License
/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using OpenTK.OpenGL;
using System.Runtime.InteropServices;

namespace OpenTK.OpenGL.Platform
{
    public partial class WindowsContext : WindowsBaseContext
    {
        public WindowsContext(Control c, int red, int green, int blue, int alpha, int depth, int stencil)
        {
            int error_code = 0;
            _window_handle = c.Handle;

            // Dynamically load the OpenGL32.dll in order to use the extension loading capabilities of Wgl.
            if (_dll_handle == 0)
            {
                _dll_handle = OpenTK.Platform.Windows.Api.LoadLibrary(_dll_name);

                error_code = Marshal.GetLastWin32Error();
                if (error_code != 0)
                {
                    //System.Diagnostics.Debug.WriteLine("LoadLibrary({0}) set error code: {1}. Will not load extensions.", _dll_name, error_code);
                }
                else
                {
                    //System.Diagnostics.Debug.WriteLine("Loaded dll: {0}", _dll_name);
                }
            }

            _device_context = OpenTK.Platform.Windows.Api.GetDC(_window_handle.ToInt32());
            OpenTK.Platform.Windows.Api.PixelFormatDescriptor pixel_format = new OpenTK.Platform.Windows.Api.PixelFormatDescriptor();

            pixel_format.ColorBits = (byte)(red + green + blue);
            pixel_format.RedBits = (byte)red;
            pixel_format.GreenBits = (byte)green;
            pixel_format.BlueBits = (byte)blue;
            pixel_format.AlphaBits = (byte)alpha;

            pixel_format.DepthBits = (byte)depth;
            pixel_format.StencilBits = (byte)stencil;

            /*
            pixel_format.AccumBits = (byte)(AccumRed + AccumGreen + AccumBlue);
            pixel_format.AccumRedBits = (byte)AccumRed;
            pixel_format.AccumGreenBits = (byte)AccumGreen;
            pixel_format.AccumBlueBits = (byte)AccumBlue;
            pixel_format.AccumAlphaBits = (byte)AccumAlpha;
            */

            if (depth <= 0)
            {
                pixel_format.Flags |= OpenTK.Platform.Windows.Api.PixelFormatDescriptorFlags.DEPTH_DONTCARE;
            }

            /*
            if (Stereo)
            {
                pixel_format.Flags |= OpenTK.Platform.Windows.Api.PixelFormatDescriptorFlags.STEREO;
            }
            */

            /*
            if (DoubleBuffer)
            {
                pixel_format.Flags |= OpenTK.Platform.Windows.Api.PixelFormatDescriptorFlags.DOUBLEBUFFER;
            }
            */

            int pixel = OpenTK.Platform.Windows.Api.ChoosePixelFormat(_device_context, pixel_format);

            if (pixel == 0)
            {
                // "The pixel format requested is not supported by the hardware configuration."
                throw new Exception("Pixel format not supported.");
            }

            OpenTK.Platform.Windows.Api.SetPixelFormat(_device_context, pixel, pixel_format);

            _render_context = Wgl.CreateContext(_device_context);

            MakeCurrent();

            //GL.Init();
            //new GL();

            //if (load_extensions)
            //    LoadExtensions();
        }
    }
}
