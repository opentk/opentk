// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;
using System.Collections.Generic;
using System.Diagnostics;
#if !MINIMAL
using System.Drawing;
#endif

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

