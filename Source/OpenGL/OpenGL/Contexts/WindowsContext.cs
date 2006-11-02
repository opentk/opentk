#region License
/* Copyright (c) 2006 Stephen Apostolopoulos
 * Contributions from Erik Ylvisaker
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text;

using OpenTK.OpenGL;
using OpenTK.Platform.Windows;

namespace OpenTK.OpenGL.Platform
{
    public class WindowsContext : GLContext
    {
        protected const string _dll_name = "OPENGL32.DLL";
        protected int _dll_handle;
        protected int _device_context;
        protected int _render_context;
        protected IntPtr _window_handle;

        public WindowsContext(Control c, ColorDepth color, int depth, int stencil)
            : base(c)
        {
            int error_code = 0;
            _window_handle = c.Handle;

            // Dynamically load the OpenGL32.dll in order to use the extension loading capabilities of Wgl.
            if (_dll_handle == 0)
            {
                _dll_handle = OpenTK.Platform.Windows.WinApi.LoadLibrary(_dll_name);
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

            _device_context = OpenTK.Platform.Windows.WinApi.GetDC(_window_handle.ToInt32());
            OpenTK.Platform.Windows.WinApi.PixelFormatDescriptor pixel_format = new OpenTK.Platform.Windows.WinApi.PixelFormatDescriptor();

            pixel_format.ColorBits = (byte)(color.Red + color.Green + color.Blue);
            pixel_format.RedBits = (byte)color.Red;
            pixel_format.GreenBits = (byte)color.Green;
            pixel_format.BlueBits = (byte)color.Blue;
            pixel_format.AlphaBits = (byte)color.Alpha;

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
                pixel_format.Flags |= OpenTK.Platform.Windows.WinApi.PixelFormatDescriptorFlags.DEPTH_DONTCARE;
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

            int pixel = OpenTK.Platform.Windows.WinApi.ChoosePixelFormat(_device_context, pixel_format);

            if (pixel == 0)
            {
                throw new Exception("The requested pixel format is not supported by the hardware configuration.");
            }

            OpenTK.Platform.Windows.WinApi.SetPixelFormat(_device_context, pixel, pixel_format);

            _render_context = Wgl.CreateContext(_device_context);

            MakeCurrent();

            c.TopLevelControl.Move += new EventHandler(c_Move);
            c.Move += new EventHandler(c_Move);
            c.Resize += new EventHandler(c_Resize);
            //GL.Init();
            //new GL();

            //if (load_extensions)
            //    LoadExtensions();
        }

        void c_Resize(object sender, EventArgs e)
        {
            if (IsFullscreen)
                SetCursorClip();
        }

        void c_Move(object sender, EventArgs e)
        {
            if (IsFullscreen)
                SetCursorClip();
        }

        protected override void Dispose(bool disposing)
        {
            if (IsFullscreen)
                SetWindowed();

            if (_render_context != 0)
                Wgl.DeleteContext(_render_context);

            if (_device_context != 0)
                OpenTK.Platform.Windows.WinApi.ReleaseDC(_window_handle.ToInt32(), _device_context);

            if (_dll_handle != 0)
                OpenTK.Platform.Windows.WinApi.FreeLibrary(_dll_handle);

            _render_context = 0;
            _device_context = 0;
            _dll_handle = 0;
        }

        public override void SwapBuffers()
        {
            OpenTK.Platform.Windows.WinApi.SwapBuffers(_device_context);
        }

        protected override Delegate GetAddress(string function_string, Type function_type)
        {
            IntPtr address = Wgl.GetProcAddress(function_string);
            if (address == IntPtr.Zero)
                return null;
            else
                return Marshal.GetDelegateForFunctionPointer(address, function_type);
        }

        public override void MakeCurrent()
        {
            Wgl.MakeCurrent(_device_context, _render_context);
        }

        public override void SetWindowed()
        {
            WinApi.ChangeDisplaySettings(null, 0);
            IsFullscreen = false;
        }

        public override void SetFullScreen(int width, int height, OpenTK.OpenGL.ColorDepth color)
        {
            CheckAnyFullScreen();

            WinApi.DeviceMode ScreenSettings = new WinApi.DeviceMode();
            ScreenSettings.PelsWidth = width;                       // Selected Screen Width
            ScreenSettings.PelsHeight = height;                     // Selected Screen Height
            ScreenSettings.BitsPerPel = color.Alpha +               // Selected Bits Per Pixel
                                        color.Red +
                                        color.Green +
                                        color.Blue;
            ScreenSettings.Fields = WinApi.Constants.DM_BITSPERPEL
                | WinApi.Constants.DM_PELSWIDTH
                | WinApi.Constants.DM_PELSHEIGHT;

            // Try To Set Selected Mode And Get Results.  NOTE: CDS_FULLSCREEN Gets Rid Of Start Bar.
            if (WinApi.ChangeDisplaySettings(ScreenSettings,
                WinApi.Constants.CDS_FULLSCREEN) == WinApi.Constants.DISP_CHANGE_SUCCESSFUL)
            {
                IsFullscreen = true;

                SetCursorClip();
            }
            else
            {
                throw new Exception("Could not change full-screen resolution.");
            }
        }

        /// <summary>
        /// Clips the cursor's available positions to within the render target.
        /// </summary>
        private void SetCursorClip()
        {
            Cursor.Clip = new Rectangle(this.Control.PointToScreen(Point.Empty), this.Control.Size);
        }

        public override DisplayMode[] EnumDisplayModes()
        {
            List<DisplayMode> modes = new List<DisplayMode>();
            bool done = false;
            int index = 0;

            while (!done)
            {
                WinApi.DeviceMode currentMode = new WinApi.DeviceMode();
                IntPtr handle = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(WinApi.DeviceMode)));
                Marshal.StructureToPtr(currentMode, handle, true);

                done = (WinApi.EnumDisplaySettings(null, index++, handle) != 0) ? false : true;
                int error = Marshal.GetLastWin32Error();

                Marshal.PtrToStructure(handle, currentMode);
                Marshal.FreeHGlobal(handle);

                if (error != 0)
                {
                    Console.WriteLine("Error: {0}", error);
                    continue;
                }
                if (done)
                    break;

                //DisplayMode mode = new DisplayMode(currentMode.PelsWidth, currentMode.PelsHeight);
                DisplayMode mode = new DisplayMode(
                    currentMode.PelsWidth,
                    currentMode.PelsHeight,
                    currentMode.BitsPerPel,
                    currentMode.DisplayFrequency
                    );

                modes.Add(mode);
            }

            return modes.ToArray();
        }
    }
}