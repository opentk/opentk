using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenTK.Platform.MacOS
{
    using System.Drawing;
    using Carbon;

    class QuartzDisplayDeviceDriver : IDisplayDeviceDriver
    {
        static object display_lock = new object();

        static Dictionary<DisplayDevice, IntPtr> displayMap = 
            new Dictionary<DisplayDevice, IntPtr>();

        static IntPtr mainDisplay;
        internal static IntPtr MainDisplay { get { return mainDisplay; } }

        static QuartzDisplayDeviceDriver()
        {
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

                unsafe
                {
                    fixed(IntPtr* displayPtr = displays)
                    {
                        CG.GetActiveDisplayList(maxDisplayCount, displayPtr, out displayCount);
                    }
                }

                Debug.Print("CoreGraphics reported {0} displays.", displayCount);
                Debug.Indent();

                for (int i = 0; i < displayCount; i++)
                {
                    IntPtr currentDisplay = displays[i];

                    // according to docs, first element in the array is always the
                    // main display.
                    bool primary = (i == 0);

                    if (primary)
                        mainDisplay = currentDisplay;

                    // gets current settings
                    int currentWidth = CG.DisplayPixelsWide(currentDisplay);
                    int currentHeight = CG.DisplayPixelsHigh(currentDisplay);
                    Debug.Print("Display {0} is at  {1}x{2}", i, currentWidth, currentHeight);

                    IntPtr displayModesPtr = CG.DisplayAvailableModes(currentDisplay);                
                    CFArray displayModes = new CFArray(displayModesPtr);
                    Debug.Print("Supports {0} display modes.", displayModes.Count);

                    DisplayResolution opentk_dev_current_res = null;
                    List<DisplayResolution> opentk_dev_available_res = new List<DisplayResolution>();
                    IntPtr currentModePtr = CG.DisplayCurrentMode(currentDisplay);
                    CFDictionary currentMode = new CFDictionary(currentModePtr);

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

                        DisplayResolution thisRes = new DisplayResolution(0, 0, width, height, bpp, (float)freq);
                        opentk_dev_available_res.Add(thisRes);

                        if (current)
                            opentk_dev_current_res = thisRes;

                    }

                    DisplayDevice opentk_dev =
                        new DisplayDevice(opentk_dev_current_res, primary, opentk_dev_available_res, Rectangle.Empty);

                    displayMap.Add(opentk_dev, currentDisplay);
                }

                Debug.Unindent();
            }
        }

        #region IDisplayDeviceDriver Members

        Dictionary<IntPtr, IntPtr> storedModes = new Dictionary<IntPtr, IntPtr>();
        List<IntPtr> displaysCaptured = new List<IntPtr>();
                    
        public bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution)
        {
            IntPtr display = displayMap[device];
            IntPtr currentModePtr = CG.DisplayCurrentMode(display);

            if (storedModes.ContainsKey(display) == false)
            {
                storedModes.Add(display, currentModePtr);        
            }

            IntPtr displayModesPtr = CG.DisplayAvailableModes(display);
            CFArray displayModes = new CFArray(displayModesPtr);

            for (int j = 0; j < displayModes.Count; j++)
            {
                CFDictionary dict = new CFDictionary(displayModes[j]);

                int width = (int)dict.GetNumberValue("Width");
                int height = (int)dict.GetNumberValue("Height");
                int bpp = (int)dict.GetNumberValue("BitsPerPixel");
                double freq = dict.GetNumberValue("RefreshRate");

                if (width == resolution.Width &&
                    height == resolution.Height &&
                    bpp == resolution.BitsPerPixel &&
                    System.Math.Abs(freq - resolution.RefreshRate) < 1e-6)
                {
                    if (displaysCaptured.Contains(display) == false)
                    {
                        CG.DisplayCapture(display);
                    }

                    Debug.Print("Changing resolution to {0}x{1}x{2}@{3}.", width, height, bpp, freq);

                    CG.DisplaySwitchToMode(display, displayModes[j]);

                    return true;
                }

            }
            return false;
        }

        public bool TryRestoreResolution(DisplayDevice device)
        {
            IntPtr display = displayMap[device];

            if (storedModes.ContainsKey(display))
            {
                Debug.Print("Restoring resolution.");

                CG.DisplaySwitchToMode(display, storedModes[display]);
                CG.DisplayRelease(display);
                displaysCaptured.Remove(display);

                return true;
            }

            return false;
        }

        #endregion
    }
}
