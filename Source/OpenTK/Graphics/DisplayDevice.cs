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

        DisplayResolution current_resolution;
        List<DisplayResolution> available_resolutions = new List<DisplayResolution>();
        bool primary;

        static List<DisplayDevice> available_displays = new List<DisplayDevice>();
        static object display_lock = new object();
        static DisplayDevice primary_display;

        static IDisplayDeviceDriver implementation;

        #region --- Constructors ---

        static DisplayDevice()
        {
            switch (System.Environment.OSVersion.Platform)
            {
                case PlatformID.Unix:
                case (PlatformID)128:
                    implementation = new OpenTK.Platform.X11.X11XrandrDisplayDevice();
                    break;

                default:
                    implementation = new OpenTK.Platform.Windows.WinDisplayDeviceDriver();
                    break;
            }
            //lock (display_lock)
            //{
            //    int i = 0;
            //    foreach (System.Windows.Forms.Screen scr in System.Windows.Forms.Screen.AllScreens)
            //    {
            //        available_displays.Add(new DisplayDevice(scr.Bounds.Width, scr.Bounds.Height, 32, 0, scr.Primary));
            //        if (scr.Primary)
            //            primary_display = available_displays[i];
            //        ++i;
            //    }
            //}
        }

        internal DisplayDevice(DisplayResolution currentResolution, bool primary,
            IEnumerable<DisplayResolution> availableResolutions)
        {
            this.current_resolution = currentResolution;
            this.primary = primary;
            this.available_resolutions.AddRange(availableResolutions);
            available_displays.Add(this);
            if (primary)
                primary_display = this;
        }

        #endregion

        #region --- Public Methods ---

        #region public int Width

        /// <summary>Gets a System.Int32 that contains the width of this display in pixels.</summary>
        public int Width { get { return current_resolution.Width; } }

        #endregion

        #region public int Height

        /// <summary>Gets a System.Int32 that contains the height of this display in pixels.</summary>
        public int Height { get { return current_resolution.Height; } }

        #endregion

        #region public int BitsPerPixel

        /// <summary>Gets a System.Int32 that contains number of bits per pixel of this display. Typical values include 8, 16, 24 and 32.</summary>
        public int BitsPerPixel { get { Debug.Print("This method is not supported currently."); return current_resolution.BitsPerPixel; } }

        #endregion

        #region public float RefreshRate

        /// <summary>
        /// Gets a System.Single representing the vertical refresh rate of this display.
        /// </summary>
        public float RefreshRate
        {
            get { return current_resolution.RefreshRate; }
        }

        #endregion

        #region public bool IsPrimary

        /// <summary>Gets a System.Boolean that indicates whether this Display is the primary Display in systems with multiple Displays.</summary>
        public bool IsPrimary { get { return primary; } }

        #endregion

        #region public DisplayResolution[] AvailableResolutions

        /// <summary>
        /// Gets an array of OpenTK.DisplayResolution objects, which describe all available resolutions
        /// for this device.
        /// </summary>
        public DisplayResolution[] AvailableResolutions
        {
            get
            {
                lock (display_lock)
                {
                    return available_resolutions.ToArray();
                }
            }
        }

        #endregion

        #region public DisplayResolution SelectResolution(int width, int height, int bitsPerPixel, float refreshRate)

        /// <summary>
        /// Selects an available resolution that matches the specified parameters.
        /// </summary>
        /// <param name="width">The width of the requested resolution in pixels.</param>
        /// <param name="height">The height of the requested resolution in pixels.</param>
        /// <param name="bitsPerPixel">The bits per pixel of the requested resolution.</param>
        /// <param name="refreshRate">The refresh rate of the requested resolution in Herz.</param>
        /// <returns>The requested DisplayResolution or null if the parameters cannot be met.</returns>
        /// <remarks>
        /// <para>A parameter set to 0 will not be used in the search (e.g. if refreshRate is 0, any refresh rate will be considered valid).</para>
        /// <para>This function generates garbage.</para>
        /// </remarks>
        public DisplayResolution SelectResolution(int width, int height, int bitsPerPixel, float refreshRate)
        {
            return available_resolutions.Find(delegate(DisplayResolution test)
            {
                return
                    ((width > 0 && width == test.Width) || width == 0) &&
                    ((height > 0 && height == test.Height) || height == 0) &&
                    ((bitsPerPixel > 0 && bitsPerPixel == test.BitsPerPixel) || bitsPerPixel == 0) &&
                    ((refreshRate > 0 && System.Math.Abs(refreshRate - test.RefreshRate) < 1.0) || refreshRate == 0);
            });
        }

        #endregion

        #region public void ChangeResolution(DisplayResolution resolution)

        /// <summary>Changes the resolution of the DisplayDevice.</summary>
        /// <param name="width">The new width of the DisplayDevice.</param>
        /// <param name="height">The new height of the DisplayDevice.</param>
        /// <param name="bitsPerPixel">The new bits per pixel of the DisplayDevice.</param>
        /// <param name="refreshRate">The new refresh rate of the DisplayDevice.</param>
        /// <exception cref="GraphicsModeException">Thrown if the requested resolution change failed.</exception>
        public void ChangeResolution(DisplayResolution resolution)
        {
            if (resolution == null)
                throw new ArgumentNullException("resulotion", "Must be a valid resolution.");

            if (implementation.TryChangeResolution(this, resolution))
            {
                current_resolution = resolution;
            }
            else
                throw new GraphicsModeException(String.Format("Device {0}: Failed to change resolution to {1}.",
                    this, resolution));
        }

        #endregion

        #region public void RestoreResolution()

        public void RestoreResolution()
        {
            implementation.RestoreResolution(this);
        }

        #endregion

        #region public static DisplayDevice[] AvailableDisplays

        /// <summary>
        /// Gets an array of OpenTK.DisplayDevice objects, which describe all available display devices.
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

        #endregion

        #region public static DisplayDevice PrimaryDisplay

        /// <summary>Gets the primary display of this system.</summary>
        public static DisplayDevice PrimaryDisplay { get { return primary_display; } }

        #endregion

        #endregion

        #region --- Overrides ---

        #region public override string ToString()

        /// <summary>
        /// Returns a System.String representing this DisplayDevice.
        /// </summary>
        /// <returns>A System.String representing this DisplayDevice.</returns>
        public override string ToString()
        {
            return String.Format("{0}: {1} ({2} modes available)", IsPrimary ? "Primary" : "Secondary",
                current_resolution.ToString(), available_resolutions.Count);
        }

        #endregion

        #region public override bool Equals(object obj)

        /// <summary>Determines whether the specified DisplayDevices are equal.</summary>
        /// <param name="obj">The System.Object to check against.</param>
        /// <returns>True if the System.Object is an equal DisplayDevice; false otherwise.</returns>
        //public override bool Equals(object obj)
        //{
        //    if (obj is DisplayDevice)
        //    {
        //        DisplayDevice dev = (DisplayDevice)obj;
        //        return
        //            IsPrimary == dev.IsPrimary &&
        //            current_resolution == dev.current_resolution &&
        //            available_resolutions.Count == dev.available_resolutions.Count;
        //    }

        //    return false;
        //}

        #endregion

        #region public override int GetHashCode()

        /// <summary>Returns a unique hash representing this DisplayDevice.</summary>
        /// <returns>A System.Int32 that may serve as a hash code for this DisplayDevice.</returns>
        //public override int GetHashCode()
        //{
        //    return current_resolution.GetHashCode() ^ IsPrimary.GetHashCode() ^ available_resolutions.Count;
        //}

        #endregion

        #endregion
    }
}
