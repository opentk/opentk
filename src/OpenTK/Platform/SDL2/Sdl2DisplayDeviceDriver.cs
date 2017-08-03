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

using System.Collections.Generic;
#if !MINIMAL
using System.Drawing;
#endif

namespace OpenTK.Platform.SDL2
{
    internal class Sdl2DisplayDeviceDriver : DisplayDeviceDriver
    {
        private class SdlDevice
        {
            public int Index;
            public DisplayResolution OriginalResolution;
            public List<DisplayResolution> AvailableResolutions;
        }

        public Sdl2DisplayDeviceDriver()
        {
            int displays = SDL.GetNumVideoDisplays();
            for (int d = 0; d < displays; d++)
            {
                Rect bounds;
                SDL.GetDisplayBounds(d, out bounds);

                var availableResolutions = new List<DisplayResolution>();
                int numModes = SDL.GetNumDisplayModes(d);
                for (int m = 0; m < numModes; m++)
                {
                    DisplayMode sdl_mode;
                    SDL.GetDisplayMode(d, m, out sdl_mode);
                    availableResolutions.Add(new DisplayResolution(
                        bounds.X, bounds.Y,
                        sdl_mode.Width, sdl_mode.Height,
                        TranslateFormat(sdl_mode.Format),
                        sdl_mode.RefreshRate));
                }

                var sdlDevice = new SdlDevice() { Index = d };
                sdlDevice.OriginalResolution = GetResolution(sdlDevice);
                sdlDevice.AvailableResolutions = availableResolutions;

                var displayDevice = new DisplayDevice(sdlDevice);

                Devices.Add(displayDevice);
            }
        }

        private int TranslateFormat(uint format)
        {
            int bpp;
            uint a, r, g, b;
            SDL.PixelFormatEnumToMasks(format, out bpp, out r, out g, out b, out a);
            return bpp;
        }

        private Rectangle TranslateBounds(Rect rect)
        {
            return new Rectangle(rect.X, rect.Y, rect.Width, rect.Height);
        }

        public override bool TryChangeResolution(object device, DisplayResolution resolution)
        {
            Sdl2Factory.UseFullscreenDesktop = false;
            return true;
        }

        public override bool TryRestoreResolution(object device)
        {
            Sdl2Factory.UseFullscreenDesktop = true;
            return true;
        }

        public override DisplayResolution GetResolution(object device)
        {
            var sdlDevice = (SdlDevice)device;

            Rect bounds;
            SDL.GetDisplayBounds(sdlDevice.Index, out bounds);

            DisplayMode currentMode;
            SDL.GetCurrentDisplayMode(sdlDevice.Index, out currentMode);

            return new DisplayResolution(
                bounds.X, bounds.Y,
                currentMode.Width, currentMode.Height,
                TranslateFormat(currentMode.Format),
                currentMode.RefreshRate);
        }

        public override bool GetIsPrimary(object device)
        {
            var sdlDevice = (SdlDevice)device;
            return sdlDevice.Index == 0;
        }

        public override IList<DisplayResolution> GetAvailableResolutions(object device)
        {
            var sdlDevice = (SdlDevice)device;
            return sdlDevice.AvailableResolutions.AsReadOnly();
        }
    }
}

