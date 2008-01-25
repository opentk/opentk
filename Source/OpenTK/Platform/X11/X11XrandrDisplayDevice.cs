#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK team.
 * This notice may not be removed.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Graphics;
using System.Diagnostics;

namespace OpenTK.Platform.X11
{
    internal class X11XrandrDisplayDevice : IDisplayDeviceDriver
    {
        static object display_lock = new object();

        #region --- Constructors ---

        static X11XrandrDisplayDevice()
        {
            //lock (display_lock)
            {
                for (int i = 0; i < API.ScreenCount; i++)
                {
                    List<DisplayResolution> resolutions = new List<DisplayResolution>();
                    unsafe
                    {
                        XRRScreenSize[] array = Functions.XRRSizes(API.DefaultDisplay, i);
                        Debug.Print("{0} resolutions.", array.Length);
                        Debug.Indent();
                        for (int count = 0; count < array.Length; count++)
                        {
                            resolutions.Add(new DisplayResolution(array[i].Width, array[i].Height, 24, 0));
                            Debug.Print(resolutions[count].ToString());
                        }
                        Debug.Unindent();
                    }

                    // Construct a default device for testing purposes.
                    new DisplayDevice(resolutions[0], i == API.DefaultScreen, resolutions);
                }
            }
        }

        public X11XrandrDisplayDevice()
        {
        }

        #endregion

        #region --- IDisplayDeviceDriver Members ---

        public bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution)
        {
            return false;
        }

        public void RestoreResolution(DisplayDevice device)
        {
            
        }

        #endregion
    }
}
