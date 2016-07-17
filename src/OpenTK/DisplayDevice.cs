#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
#if !MINIMAL
using System.Drawing;
#endif

namespace OpenTK
{
    /// <summary>
    /// Defines a display device on the underlying system, and provides
    /// methods to query and change its display parameters.
    /// </summary>
    public class DisplayDevice
    {
        // TODO: Add properties that describe the 'usable' size of the Display, i.e. the maximized size without the taskbar etc.
        // TODO: Does not detect changes to primary device.

        #region Fields

        bool primary;
        Rectangle bounds;
        DisplayResolution current_resolution = new DisplayResolution();
        DisplayResolution original_resolution;
        List<DisplayResolution> available_resolutions = new List<DisplayResolution>();
        IList<DisplayResolution> available_resolutions_readonly;
        
        internal object Id; // A platform-specific id for this monitor

        static readonly object display_lock = new object();
        static DisplayDevice primary_display;

        static Platform.IDisplayDeviceDriver implementation;

        #endregion

        #region Constructors

        static DisplayDevice()
        {
            implementation = Platform.Factory.Default.CreateDisplayDeviceDriver();
        }

        internal DisplayDevice()
        {
            available_resolutions_readonly = available_resolutions.AsReadOnly();
        }

        internal DisplayDevice(DisplayResolution currentResolution, bool primary,
            IEnumerable<DisplayResolution> availableResolutions, Rectangle bounds,
            object id)
            : this()
        {
            // Todo: Consolidate current resolution with bounds? Can they fall out of sync right now?
            this.current_resolution = currentResolution;
            IsPrimary = primary;
            this.available_resolutions.AddRange(availableResolutions);
            #pragma warning disable 612,618
            this.bounds = bounds == Rectangle.Empty ? currentResolution.Bounds : bounds;
            #pragma warning restore 612,618
            this.Id = id;
        }

        #endregion

        #region --- Public Methods ---

        #region public Rectangle Bounds

        /// <summary>
        /// Gets the bounds of this instance in pixel coordinates..
        /// </summary>
        public Rectangle Bounds
        {
            get { return bounds; }
            internal set
            {
                bounds = value;
                current_resolution.Height = bounds.Height;
                current_resolution.Width = bounds.Width;
            }
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
        public int BitsPerPixel
        {
            get { return current_resolution.BitsPerPixel; }
            internal set { current_resolution.BitsPerPixel = value; }
        }

        #endregion

        #region public float RefreshRate

        /// <summary>
        /// Gets a System.Single representing the vertical refresh rate of this display.
        /// </summary>
        public float RefreshRate
        {
            get { return current_resolution.RefreshRate; }
            internal set { current_resolution.RefreshRate = value; }
        }

        #endregion

        #region public bool IsPrimary

        /// <summary>Gets a System.Boolean that indicates whether this Display is the primary Display in systems with multiple Displays.</summary>
        public bool IsPrimary
        {
            get { return primary; }
            internal set
            {
                if (value && primary_display != null && primary_display != this)
                    primary_display.IsPrimary = false;

                lock (display_lock)
                {
                    primary = value;
                    if (value)
                        primary_display = this;
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
        /// <param name="refreshRate">The refresh rate of the requested resolution in hertz.</param>
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

        #region public IList<DisplayResolution> AvailableResolutions

        /// <summary>
        /// Gets the list of <see cref="DisplayResolution"/> objects available on this device.
        /// </summary>
        public IList<DisplayResolution> AvailableResolutions
        {
            get { return available_resolutions_readonly; }
            internal set
            {
                available_resolutions = (List<DisplayResolution>)value;
                available_resolutions_readonly = available_resolutions.AsReadOnly();
            }
        }

        #endregion

        #region public void ChangeResolution(DisplayResolution resolution)

        /// <summary>Changes the resolution of the DisplayDevice.</summary>
        /// <param name="resolution">The resolution to set. <see cref="DisplayDevice.SelectResolution"/></param>
        /// <exception cref="Graphics.GraphicsModeException">Thrown if the requested resolution could not be set.</exception>
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
            else throw new Graphics.GraphicsModeException(String.Format("Device {0}: Failed to change resolution to {1}.",
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
        /// <exception cref="Graphics.GraphicsModeException">Thrown if the requested resolution could not be set.</exception>
        public void ChangeResolution(int width, int height, int bitsPerPixel, float refreshRate)
        {
            this.ChangeResolution(this.SelectResolution(width, height, bitsPerPixel, refreshRate));
        }

        #endregion

        #region public void RestoreResolution()

        /// <summary>Restores the original resolution of the DisplayDevice.</summary>
        /// <exception cref="Graphics.GraphicsModeException">Thrown if the original resolution could not be restored.</exception>
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
                else throw new Graphics.GraphicsModeException(String.Format("Device {0}: Failed to restore resolution.", this));

                //effect.FadeIn();
            }
        }

        #endregion

        #region public static IList<DisplayDevice> AvailableDisplays

        /// <summary>
        /// Gets the list of available <see cref="DisplayDevice"/> objects.
        /// This function allocates memory.
        /// </summary>
        [Obsolete("Use GetDisplay(DisplayIndex) instead.")]
        public static IList<DisplayDevice> AvailableDisplays
        {
            get
            {
                List<DisplayDevice> displays = new List<DisplayDevice>();
                for (int i = 0; i < 6; i++)
                {
                    DisplayDevice dev = GetDisplay(DisplayIndex.First + i);
                    if (dev != null)
                        displays.Add(dev);
                }

                return displays.AsReadOnly();
            }
        }

        #endregion

        #region public static DisplayDevice Default

        /// <summary>Gets the default (primary) display of this system.</summary>
        public static DisplayDevice Default
        {
            get { return implementation.GetDisplay(DisplayIndex.Primary); }
        }

        #endregion

        #region GetDisplay

        /// <summary>
        /// Gets the <see cref="DisplayDevice"/> for the specified <see cref="DisplayIndex"/>.
        /// </summary>
        /// <param name="index">The <see cref="DisplayIndex"/> that defines the desired display.</param>
        /// <returns>A <see cref="DisplayDevice"/> or null, if no device corresponds to the specified index.</returns>
        public static DisplayDevice GetDisplay(DisplayIndex index)
        {
            return implementation.GetDisplay(index);
        }

        #endregion

        #endregion

        #region --- Internal Methods ---

        #region internal DisplayResolution OriginalResolution

        /// <summary>
        /// Gets the original resolution of this instance.
        /// </summary>
        internal DisplayResolution OriginalResolution
        {
            get { return original_resolution; }
            set { original_resolution = value; }
        }

        #endregion

        #region FromPoint

        internal static DisplayDevice FromPoint(int x, int y)
        {
            for (DisplayIndex i = DisplayIndex.First; i < DisplayIndex.Sixth; i++)
            {
                DisplayDevice display = DisplayDevice.GetDisplay(i);
                if (display != null)
                {
                    if (display.Bounds.Contains(x, y))
                    {
                        return display;
                    }
                }
            }
            return null;
        }

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
                Bounds.ToString(), available_resolutions.Count);
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
