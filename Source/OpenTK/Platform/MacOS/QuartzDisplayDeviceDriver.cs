using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OpenTK.Platform.MacOS
{
    using Graphics;
    using Carbon;

    class QuartzDisplayDeviceDriver : IDisplayDeviceDriver
    {
        static object display_lock = new object();
        
        static QuartzDisplayDeviceDriver()
        {
            //lock (display_lock)
            //{
            //    List<DisplayResolution> resolutions = new List<DisplayResolution>();

            //    DisplayResolution primaryRes = new DisplayResolution(1024, 768, 32, 60);
            //    resolutions.Add(primaryRes);

            //    object o = new Graphics.DisplayDevice(primaryRes, true, resolutions);
            //}

            lock (display_lock)
            {
                // To minimize the need to add static methods to OpenTK.Graphics.DisplayDevice
                // we only allow settings to be set through its constructor.
                // Thus, we save all necessary parameters in temporary variables
                // and construct the device when every needed detail is available.
                // The main DisplayDevice constructor adds the newly constructed device
                // to the list of available devices.
                const int maxDisplayCount = 20;
                IntPtr[] displays = new IntPtr[maxDisplayCount];
                int displayCount;

                CG.GetActiveDisplayList(maxDisplayCount, displays, out displayCount);

                Debug.Print("CoreGraphics reported {0} displays.", displayCount);
                Debug.Indent();

                for (int i = 0; i < displayCount; i++)
                {
                    IntPtr currentDisplay = displays[i];

                    // according to docs, first element in the array is always the
                    // main display.
                    bool primary = (i == 0);

                    // gets current settings
                    int currentWidth = CG.DisplayPixelsWide(currentDisplay);
                    int currentHeight = CG.DisplayPixelsHigh(currentDisplay);
                    Debug.Print("Display {0} is at  {1}x{2}", i, currentWidth, currentHeight);

                    CFArray displayModes = CG.DisplayAvailableModes(currentDisplay);
                    Debug.Print("Supports {0} display modes.", displayModes.Count);

                    DisplayResolution opentk_dev_current_res = null;
                    List<DisplayResolution> opentk_dev_available_res = new List<DisplayResolution>();
                    CFDictionary currentMode = CG.DisplayCurrentMode(currentDisplay);

                    for (int j = 0; j < displayModes.Count; j++)
                    {
                        CFDictionary dict = new CFDictionary(displayModes[j]);
                        
                        int width = (int) dict.GetNumberValue("Width");
                        int height = (int) dict.GetNumberValue("Height");
                        int bpp = (int) dict.GetNumberValue("BitsPerPixel");
                        double freq = dict.GetNumberValue("RefreshRate");
                        bool current = currentMode.Ref == dict.Ref;

                        //if (current) Debug.Write("  * ");
                        //else Debug.Write("    ");

                        //Debug.Print("Mode {0} is {1}x{2}x{3} @ {4}.", j, width, height, bpp, freq);

                        DisplayResolution thisRes = new DisplayResolution(width, height, bpp, (float)freq);
                        opentk_dev_available_res.Add(thisRes);

                        if (current)
                            opentk_dev_current_res = thisRes;

                    }

                    OpenTK.Graphics.DisplayDevice opentk_dev =
                        new DisplayDevice(opentk_dev_current_res, primary, opentk_dev_available_res);
                }

                Debug.Unindent();
            }
        }

        #region IDisplayDeviceDriver Members

        public bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution)
        {
            
            return false;
        }

        public bool TryRestoreResolution(DisplayDevice device)
        {
            return false;
        }

        #endregion
    }
}
