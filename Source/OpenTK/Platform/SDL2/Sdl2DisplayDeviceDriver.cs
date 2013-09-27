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
            int displays = SDL.SDL_GetNumVideoDisplays();
            for (int d = 0; d < displays; d++)
            {
                SDL.SDL_Rect bounds;
                SDL.SDL_GetDisplayBounds(d, out bounds);

                SDL.SDL_DisplayMode current_mode;
                SDL.SDL_GetCurrentDisplayMode(d, out current_mode);

                var mode_list = new List<DisplayResolution>();
                int num_modes = SDL.SDL_GetNumDisplayModes(d);
                for (int m = 0; m < num_modes; m++)
                {
                    SDL.SDL_DisplayMode sdl_mode;
                    SDL.SDL_GetDisplayMode(d, m, out sdl_mode);
                    mode_list.Add(new DisplayResolution(
                        bounds.x, bounds.y,
                        sdl_mode.w, sdl_mode.h,
                        TranslateFormat(sdl_mode.format),
                        sdl_mode.refresh_rate));
                }

                var current_resolution = new DisplayResolution(
                    bounds.x, bounds.y,
                    current_mode.w, current_mode.h,
                    TranslateFormat(current_mode.format),
                    current_mode.refresh_rate);

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
            SDL.SDL_PixelFormatEnumToMasks(format, out bpp, out r, out g, out b, out a);
            return bpp;
        }

        Rectangle TranslateBounds(SDL.SDL_Rect rect)
        {
            return new Rectangle(rect.x, rect.y, rect.w, rect.h);
        }

        #endregion

        #region DisplayDeviceBase Members

        public override bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution)
        {
            // Todo: we need a temporary window to change resolutions, most probably
            Trace.WriteLine("SDL2 driver does not implement TryChangeResolution");
            return true;

            //SDL2.SDL_DisplayMode desired, closest;
            //desired.w = resolution.Width;
            //desired.h = resolution.Height;
            //desired.format = SDL.SDL_PIXELFORMAT_BGRA8888;

            //SDL2.SDL_GetClosestDisplayMode((int)device.Id, ref desired, out closest);
            //SDL2.SDL_SetWindowDisplayMode(IntPtr.Zero, ref closest);
        }

        public override bool TryRestoreResolution(DisplayDevice device)
        {
            Trace.WriteLine("SDL2 driver does not support TryRestoreResolution");
            return true;
            //throw new NotImplementedException();
        }

        #endregion
    }
}

