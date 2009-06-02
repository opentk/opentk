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
using System.Threading;
using System.Drawing;

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

        #region --- Fields ---

        DisplayResolution current_resolution, original_resolution;
        List<DisplayResolution> available_resolutions = new List<DisplayResolution>();
        bool primary;

        static List<DisplayDevice> available_displays = new List<DisplayDevice>();
        static object display_lock = new object();
        static DisplayDevice primary_display;
        //static FadeEffect effect = new FadeEffect();

        static IDisplayDeviceDriver implementation;

        #endregion

        #region --- Constructors ---

        static DisplayDevice()
        {
            implementation = Platform.Factory.Default.CreateDisplayDeviceDriver();
        }

        internal DisplayDevice(DisplayResolution currentResolution, bool primary,
            IEnumerable<DisplayResolution> availableResolutions)
        {
            this.current_resolution = currentResolution;
            this.primary = primary;
            this.available_resolutions.AddRange(availableResolutions);

            Debug.Print("DisplayDevice {0} ({1}) supports {2} resolutions.",
                available_displays.Count, primary ? "primary" : "secondary", available_resolutions.Count);

            lock (display_lock)
            {
                available_displays.Add(this);
                if (primary)
                    primary_display = this;
            }
        }

        #endregion

        #region --- Public Methods ---

        #region public Rectangle Bounds

        /// <summary>
        /// Gets a System.Drawing.Rectangle that contains the current bounds of this DisplayDevice.
        /// </summary>
        public Rectangle Bounds
        {
            get { return current_resolution.Bounds; }
        }

        #endregion

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
        public int BitsPerPixel { get { return current_resolution.BitsPerPixel; } }

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
        /// <para>If a matching resolution is not found, this function will retry ignoring the specified refresh rate,
        /// bits per pixel and resolution, in this order. If a matching resolution still doesn't exist, this function will
        /// return the current resolution.</para>
        /// <para>A parameter set to 0 or negative numbers will not be used in the search (e.g. if refreshRate is 0,
        /// any refresh rate will be considered valid).</para>
        /// <para>This function allocates memory.</para>
        /// </remarks>
        public DisplayResolution SelectResolution(int width, int height, int bitsPerPixel, float refreshRate)
        {
            DisplayResolution resolution = FindResolution(width, height, bitsPerPixel, refreshRate);
            if (resolution == null)
                resolution = FindResolution(width, height, bitsPerPixel, 0);
            if (resolution == null)
                resolution = FindResolution(width, height, 0, 0);
            if (resolution == null)
                return current_resolution;
            return resolution;
        }

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

        #region public void ChangeResolution(DisplayResolution resolution)

        /// <summary>Changes the resolution of the DisplayDevice.</summary>
        /// <param name="resolution">The resolution to set. <see cref="DisplayDevice.SelectResolution"/></param>
        /// <exception cref="GraphicsModeException">Thrown if the requested resolution could not be set.</exception>
        /// <remarks>If the specified resolution is null, this function will restore the original DisplayResolution.</remarks>
        public void ChangeResolution(DisplayResolution resolution)
        {
            if (resolution == null)
                this.RestoreResolution();

            if (resolution == current_resolution)
                return;

            //effect.FadeOut();

            if (implementation.TryChangeResolution(this, resolution))
            {
                if (original_resolution == null)
                    original_resolution = current_resolution;
                current_resolution = resolution;
            }
            else throw new GraphicsModeException(String.Format("Device {0}: Failed to change resolution to {1}.",
                    this, resolution));

            //effect.FadeIn();
        }

        #endregion

        #region public void ChangeResolution(int width, int height, int bitsPerPixel, float refreshRate)

        /// <summary>Changes the resolution of the DisplayDevice.</summary>
        /// <param name="width">The new width of the DisplayDevice.</param>
        /// <param name="height">The new height of the DisplayDevice.</param>
        /// <param name="bitsPerPixel">The new bits per pixel of the DisplayDevice.</param>
        /// <param name="refreshRate">The new refresh rate of the DisplayDevice.</param>
        /// <exception cref="GraphicsModeException">Thrown if the requested resolution could not be set.</exception>
        public void ChangeResolution(int width, int height, int bitsPerPixel, float refreshRate)
        {
            this.ChangeResolution(this.SelectResolution(width, height, bitsPerPixel, refreshRate));
        }

        #endregion

        #region public void RestoreResolution()

        /// <summary>Restores the original resolution of the DisplayDevice.</summary>
        /// <exception cref="GraphicsModeException">Thrown if the original resolution could not be restored.</exception>
        public void RestoreResolution()
        {
            if (original_resolution != null)
            {
                //effect.FadeOut();

                if (implementation.TryRestoreResolution(this))
                {
                    current_resolution = original_resolution;
                    original_resolution = null;
                }
                else throw new GraphicsModeException(String.Format("Device {0}: Failed to restore resolution.", this));

                //effect.FadeIn();
            }
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

        #region public static DisplayDevice Default

        /// <summary>Gets the default (primary) display of this system.</summary>
        public static DisplayDevice Default { get { return primary_display; } }

        #endregion

        #endregion

        #region --- Private Methods ---

        #region DisplayResolution FindResolution(int width, int height, int bitsPerPixel, float refreshRate)

        DisplayResolution FindResolution(int width, int height, int bitsPerPixel, float refreshRate)
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

        ///// <summary>Determines whether the specified DisplayDevices are equal.</summary>
        ///// <param name="obj">The System.Object to check against.</param>
        ///// <returns>True if the System.Object is an equal DisplayDevice; false otherwise.</returns>
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

        ///// <summary>Returns a unique hash representing this DisplayDevice.</summary>
        ///// <returns>A System.Int32 that may serve as a hash code for this DisplayDevice.</returns>
        ////public override int GetHashCode()
        //{
        //    return current_resolution.GetHashCode() ^ IsPrimary.GetHashCode() ^ available_resolutions.Count;
        //}

        #endregion

        #endregion
    }

    #region --- FadeEffect ---
#if false
    class FadeEffect : IDisposable
    {
        List<Form> forms = new List<Form>();
        double opacity_step = 0.04;
        int sleep_step;

        internal FadeEffect()
        {
            foreach (Screen s in Screen.AllScreens)
            {
                Form form = new Form();
                form.ShowInTaskbar = false;
                form.StartPosition = FormStartPosition.Manual;
                form.WindowState = FormWindowState.Maximized;
                form.FormBorderStyle = FormBorderStyle.None;
                form.TopMost = true;

                form.BackColor = System.Drawing.Color.Black;
                forms.Add(form);
            }

            sleep_step = 10 / forms.Count;
            MoveToStartPositions();
        }

        void MoveToStartPositions()
        {
            int count = 0;
            foreach (Screen s in Screen.AllScreens)
            {
            //    forms[count++].Location = new System.Drawing.Point(s.Bounds.X, s.Bounds.Y);
                //forms[count].Size = new System.Drawing.Size(4096, 4096);
                count++;
            }
        }

        bool FadedOut
        {
            get
            {
                bool ready = true;
                foreach (Form form in forms)
                    ready = ready && form.Opacity >= 1.0;

                return ready;
            }
        }

        bool FadedIn
        {
            get
            {
                bool ready = true;
                foreach (Form form in forms)
                    ready = ready && form.Opacity <= 0.0;

                return ready;
            }
        }

        internal void FadeOut()
        {
            MoveToStartPositions();

            foreach (Form form in forms)
            {
                form.Opacity = 0.0;
                form.Visible = true;
            }

            while (!FadedOut)
            {
                foreach (Form form in forms)
                {
                    form.Opacity += opacity_step;
                    form.Refresh();
                }
                Thread.Sleep(sleep_step);
            }
        }

        internal void FadeIn()
        {
            MoveToStartPositions();

            foreach (Form form in forms)
                form.Opacity = 1.0;

            while (!FadedIn)
            {
                foreach (Form form in forms)
                {
                    form.Opacity -= opacity_step;
                    form.Refresh();
                }
                Thread.Sleep(sleep_step);
            }

            foreach (Form form in forms)
                form.Visible = false;
        }

        #region IDisposable Members

        public void Dispose()
        {
            foreach (Form form in forms)
                form.Dispose();
        }

        #endregion
    }
#endif
    #endregion
}
