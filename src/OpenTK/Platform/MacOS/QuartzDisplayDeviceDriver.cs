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

using System;
using System.Collections.Generic;
using System.Diagnostics;
#if !MINIMAL
using System.Drawing;
#endif
using OpenTK.Platform.MacOS.Carbon;

namespace OpenTK.Platform.MacOS
{
    internal sealed class QuartzDisplayDevice : DisplayDevice
    {
        public readonly IntPtr Display;
        public readonly DisplayResolution OriginalResolution;
        public readonly List<DisplayResolution> Resolutions = new List<DisplayResolution>();

        public QuartzDisplayDevice(IntPtr display)
        {
            Display = display;
            OriginalResolution = CurrentResolution;
        }

        public override DisplayResolution CurrentResolution
        {
            get
            {
                IntPtr displayModesPtr = CG.DisplayAvailableModes(Display);
                CFArray displayModes = new CFArray(displayModesPtr);

                DisplayResolution opentkDevCurrentRes = null;
                IntPtr currentModePtr = CG.DisplayCurrentMode(Display);
                CFDictionary currentMode = new CFDictionary(currentModePtr);

                for (int j = 0; j < displayModes.Count; j++)
                {
                    CFDictionary dict = new CFDictionary(displayModes[j]);

                    int width = (int)dict.GetNumberValue("Width");
                    int height = (int)dict.GetNumberValue("Height");
                    int bpp = (int)dict.GetNumberValue("BitsPerPixel");
                    double freq = dict.GetNumberValue("RefreshRate");
                    bool current = currentMode.Ref == dict.Ref;

                    if (current)
                    {
                        opentkDevCurrentRes = new DisplayResolution(0, 0, width, height, bpp, (float)freq);
                        break;
                    }
                }

                NSRect bounds = CG.DisplayBounds(Display);

                return new DisplayResolution((int)bounds.Location.X, (int)bounds.Location.Y,
                    opentkDevCurrentRes.Width, opentkDevCurrentRes.Height,
                    opentkDevCurrentRes.BitsPerPixel, opentkDevCurrentRes.RefreshRate);
            }

            set
            {
                base.CurrentResolution = value;
            }
        }

        public override IList<DisplayResolution> AvailableResolutions
        {
            get
            {
                return Resolutions.AsReadOnly();
            }
        }

        public override bool IsPrimary
        {
            get
            {
                IntPtr primaryDisplay;
                int displayCount;

                unsafe
                {
                    CG.GetActiveDisplayList(1, &primaryDisplay, out displayCount);
                }

                return Display == primaryDisplay;
            }
        }

        public override void ChangeResolution(DisplayResolution resolution)
        {
            IntPtr currentModePtr = CG.DisplayCurrentMode(Display);

            IntPtr displayModesPtr = CG.DisplayAvailableModes(Display);
            CFArray displayModes = new CFArray(displayModesPtr);

            for (int j = 0; j < displayModes.Count; j++)
            {
                CFDictionary dict = new CFDictionary(displayModes[j]);

                int width = (int)dict.GetNumberValue("Width");
                int height = (int)dict.GetNumberValue("Height");
                int bpp = (int)dict.GetNumberValue("BitsPerPixel");
                double freq = dict.GetNumberValue("RefreshRate");

                if (width == resolution.Width && height == resolution.Height && bpp == resolution.BitsPerPixel && Math.Abs(freq - resolution.RefreshRate) < 1e-6)
                {
                    Debug.Print("Changing resolution to {0}x{1}x{2}@{3}.", width, height, bpp, freq);

                    CG.DisplaySwitchToMode(Display, displayModes[j]);
                }
            }

            throw new Graphics.GraphicsModeException(
                string.Format("Device {0}: Failed to change resolution to {1}.", this, resolution));
        }

        public override void RestoreResolution()
        {
            ChangeResolution(OriginalResolution);
        }
    }

    internal sealed class QuartzDisplayDeviceDriver : DisplayDeviceDriver
    {
        private static object display_lock = new object();

        // Small object for tracking name, available resolutions, and original resolution.
        private sealed class QuartzDevice
        {
        }

        public QuartzDisplayDeviceDriver()
        {
            lock (display_lock)
            {
                const int maxDisplayCount = 20;
                IntPtr[] displays = new IntPtr[maxDisplayCount];
                int displayCount;

                unsafe
                {
                    fixed (IntPtr* displayPtr = displays)
                    {
                        CG.GetActiveDisplayList(maxDisplayCount, displayPtr, out displayCount);
                    }
                }

                Debug.Print("CoreGraphics reported {0} display(s).", displayCount);
                Debug.Indent();

                for (int i = 0; i < displayCount; i++)
                {
                    IntPtr currentDisplay = displays[i];
                    var quartzDevice = new QuartzDisplayDevice(currentDisplay);

                    IntPtr displayModesPtr = CG.DisplayAvailableModes(currentDisplay);
                    CFArray displayModes = new CFArray(displayModesPtr);
                    Debug.Print("Supports {0} display modes.", displayModes.Count);

                    for (int j = 0; j < displayModes.Count; j++)
                    {
                        CFDictionary dict = new CFDictionary(displayModes[j]);

                        int width = (int)dict.GetNumberValue("Width");
                        int height = (int)dict.GetNumberValue("Height");
                        int bpp = (int)dict.GetNumberValue("BitsPerPixel");
                        double freq = dict.GetNumberValue("RefreshRate");

                        DisplayResolution thisRes = new DisplayResolution(0, 0, width, height, bpp, (float)freq);
                        quartzDevice.AvailableResolutions.Add(thisRes);
                    }

                    Devices.Add(quartzDevice);
                }

                Debug.Unindent();
            }
        }
    }
}
