#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit library.
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
using System.Drawing;

namespace OpenTK.Platform.SDL2
{
    class Sdl2DisplayDeviceDriver : DisplayDeviceBase
    {
        public Sdl2DisplayDeviceDriver()
        {
            int displays = SDL.GetNumVideoDisplays();
            for (int d = 0; d < displays; d++)
            {
                Rect bounds;
                SDL.GetDisplayBounds(d, out bounds);

                DisplayMode current_mode;
                SDL.GetCurrentDisplayMode(d, out current_mode);

                var mode_list = new List<DisplayResolution>();
                int num_modes = SDL.GetNumDisplayModes(d);
                for (int m = 0; m < num_modes; m++)
                {
                    DisplayMode sdl_mode;
                    SDL.GetDisplayMode(d, m, out sdl_mode);
                    mode_list.Add(new DisplayResolution(
                        bounds.X, bounds.Y,
                        sdl_mode.Width, sdl_mode.Height,
                        TranslateFormat(sdl_mode.Format),
                        sdl_mode.RefreshRate));
                }

                var current_resolution = new DisplayResolution(
                    bounds.X, bounds.Y,
                    current_mode.Width, current_mode.Height,
                    TranslateFormat(current_mode.Format),
                    current_mode.RefreshRate);

                var device = new DisplayDevice(
                    current_resolution, d == 0, mode_list, TranslateBounds(bounds), d);

                AvailableDevices.Add(device);
                if (d == 0)
                    Primary = device;
            }
        }

        #region Private Members

        int TranslateFormat(uint format)
        {
            int bpp;
            uint a, r, g, b;
            SDL.PixelFormatEnumToMasks(format, out bpp, out r, out g, out b, out a);
            return bpp;
        }

        Rectangle TranslateBounds(Rect rect)
        {
            return new Rectangle(rect.X, rect.Y, rect.Width, rect.Height);
        }

        #endregion

        #region DisplayDeviceBase Members

        public override bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution)
        {
            Sdl2Factory.UseFullscreenDesktop = false;
            return true;
        }

        public override bool TryRestoreResolution(DisplayDevice device)
        {
            Sdl2Factory.UseFullscreenDesktop = true;
            return true;
        }

        #endregion
    }
}

