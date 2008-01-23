#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK team.
 * This notice may not be removed.
 * See license.txt for licensing detailed licensing information. */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Defines a display device on the underlying system, and provides
    /// methods to query and change its display parameters.
    /// </summary>
    public class DisplayDevice
    {
        // TODO: Add support for refresh rate queries and switches.
        // TODO: Check whether bits_per_pixel works correctly under Mono/X11.
        // TODO: Add properties that describe the 'usable' size of the Display, i.e. the maximized size without the taskbar etc.
        // TODO: Does not detect changes to primary device.
        // TODO: Mono does not support System.Windows.Forms.Screen.BitsPerPixel -- find workaround!

        int width, height;
        int bits_per_pixel;
        float refresh_rate;
        bool primary;

        static List<DisplayDevice> available_displays = new List<DisplayDevice>();
        static object display_lock = new object();
        static DisplayDevice primary_display;

        #region --- Constructors ---

        static DisplayDevice()
        {
            lock (display_lock)
            {
                int i = 0;
                foreach (System.Windows.Forms.Screen scr in System.Windows.Forms.Screen.AllScreens)
                {
                    available_displays.Add(new DisplayDevice(scr.Bounds.Width, scr.Bounds.Height, 32, 0, scr.Primary));
                    if (scr.Primary)
                        primary_display = available_displays[i];
                    ++i;
                }
            }
        }

        DisplayDevice(int width, int height, int bitsPerPixel, float refreshRate, bool primary)
        {
            this.width = width;
            this.height = height;
            this.bits_per_pixel = bitsPerPixel;
            this.refresh_rate = refreshRate;
            this.primary = primary;
        }

        #endregion

        #region --- Public Methods ---

        /// <summary>Gets a System.Int32 that contains the width of this Display in pixels.</summary>
        public int Width { get { return width; } }

        /// <summary>Gets a System.Int32 that contains the height of this Display in pixels.</summary>
        public int Height { get { return height; } }

        /// <summary>Gets a System.Int32 that contains number of bits per pixel of this Display. Typical values include 8, 16, 24 and 32.</summary>
        public int BitsPerPixel { get { Debug.Print("This method is not supported currently."); return bits_per_pixel; } }

        /// <summary>Gets a System.Boolean that indicates whether this Display is the primary Display in systems with multiple Displays.</summary>
        public bool IsPrimary { get { return primary; } }

        /// <summary>
        /// Gets an array of OpenTK.Display objects, which describe all available display devices.
        /// </summary>
        public static DisplayDevice[] AvailableDisplays
        {
            get
            {
                lock (display_lock)
                {
                    return available_displays.ToArray();
                }
            }
        }

        /// <summary>Gets the primary display of this system.</summary>
        public static DisplayDevice PrimaryDisplay { get { return primary_display; } }

        #endregion


    }
}
