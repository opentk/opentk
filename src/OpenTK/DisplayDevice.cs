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

        readonly internal object id; // A platform-specific id for this monitor
        private static Platform.DisplayDeviceDriver implementation;

        static DisplayDevice()
        {
            implementation = Platform.Factory.Default.CreateDisplayDeviceDriver();
        }

        internal DisplayDevice(object id)
        {
            this.id = id;
        }

        /// <summary>
        /// Get or set the current resolution of this instance.
        /// </summary>
        public DisplayResolution CurrentResolution
        {
            get
            {
                return implementation.GetResolution(id);
            }
            set
            {
                ChangeResolution(value);
            }
        }

        /// <summary>
        /// Gets the bounds of this instance in pixel coordinates..
        /// </summary>
        [Obsolete("Use CurrentResolution.Bounds instead.")]
        public Rectangle Bounds
        {
            get { return CurrentResolution.Bounds; }
        }

        /// <summary>Gets a System.Int32 that contains the width of this display in pixels.</summary>
        [Obsolete("Use CurrentResolution.Width instead.")]
        public int Width { get { return CurrentResolution.Width; } }

        /// <summary>Gets a System.Int32 that contains the height of this display in pixels.</summary>
        [Obsolete("Use CurrentResolution.Height instead.")]
        public int Height { get { return CurrentResolution.Height; } }

        /// <summary>Gets a System.Int32 that contains number of bits per pixel of this display. Typical values include 8, 16, 24 and 32.</summary>
        [Obsolete("Use CurrentResolution.BitsPerPixel instead.")]
        public int BitsPerPixel
        {
            get { return CurrentResolution.BitsPerPixel; }
        }

        /// <summary>
        /// Gets a System.Single representing the vertical refresh rate of this display.
        /// </summary>
        [Obsolete("Use CurrentResolution.RefreshRate instead.")]
        public float RefreshRate
        {
            get { return CurrentResolution.RefreshRate; }
        }

        /// <summary>Gets a System.Boolean that indicates whether this Display is the primary Display in systems with multiple Displays.</summary>
        public bool IsPrimary { get { return implementation.GetIsPrimary(id); } }

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
            {
                resolution = FindResolution(width, height, bitsPerPixel, 0);
            }
            if (resolution == null)
            {
                resolution = FindResolution(width, height, 0, 0);
            }
            if (resolution == null)
            {
                return CurrentResolution;
            }
            return resolution;
        }

        /// <summary>
        /// Gets the list of <see cref="DisplayResolution"/> objects available on this device.
        /// </summary>
        public IList<DisplayResolution> AvailableResolutions
        {
            get { return implementation.GetAvailableResolutions(id); }
        }

        /// <summary>Changes the resolution of the DisplayDevice.</summary>
        /// <param name="resolution">The resolution to set. <see cref="DisplayDevice.SelectResolution"/></param>
        /// <exception cref="Graphics.GraphicsModeException">Thrown if the requested resolution could not be set.</exception>
        /// <remarks>If the specified resolution is null, this function will restore the original DisplayResolution.</remarks>
        public void ChangeResolution(DisplayResolution resolution)
        {
            if (resolution == null)
            {
                RestoreResolution();
            }

            if (resolution == CurrentResolution)
            {
                return;
            }

            if (!implementation.TryChangeResolution(id, resolution))
            {
                throw new Graphics.GraphicsModeException(
                    String.Format("Device {0}: Failed to change resolution to {1}.", this, resolution));
            }
        }

        /// <summary>Changes the resolution of the DisplayDevice.</summary>
        /// <param name="width">The new width of the DisplayDevice.</param>
        /// <param name="height">The new height of the DisplayDevice.</param>
        /// <param name="bitsPerPixel">The new bits per pixel of the DisplayDevice.</param>
        /// <param name="refreshRate">The new refresh rate of the DisplayDevice.</param>
        /// <exception cref="Graphics.GraphicsModeException">Thrown if the requested resolution could not be set.</exception>
        public void ChangeResolution(int width, int height, int bitsPerPixel, float refreshRate)
        {
            ChangeResolution(SelectResolution(width, height, bitsPerPixel, refreshRate));
        }

        /// <summary>Restores the original resolution of the DisplayDevice.</summary>
        /// <exception cref="Graphics.GraphicsModeException">Thrown if the original resolution could not be restored.</exception>
        public void RestoreResolution()
        {
            if (!implementation.TryRestoreResolution(id))
            {
                throw new Graphics.GraphicsModeException(
                    String.Format("Device {0}: Failed to restore resolution.", this));
            }

        }

        /// <summary>Gets the default (primary) display of this system.</summary>
        public static DisplayDevice Default
        {
            get { return implementation.GetDisplay(DisplayIndex.Primary); }
        }

        /// <summary>
        /// Gets the <see cref="DisplayDevice"/> for the specified <see cref="DisplayIndex"/>.
        /// </summary>
        /// <param name="index">The <see cref="DisplayIndex"/> that defines the desired display.</param>
        /// <returns>A <see cref="DisplayDevice"/> or null, if no device corresponds to the specified index.</returns>
        public static DisplayDevice GetDisplay(DisplayIndex index)
        {
            return implementation.GetDisplay(index);
        }

        /// <summary>
        /// Tries to find an available resolution for this DisplayDevice that matches the parameters passed in.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="bitsPerPixel"></param>
        /// <param name="refreshRate"></param>
        /// <returns>A matching DisplayResolution or null if one cannnot be found.</returns>
        DisplayResolution FindResolution(int width, int height, int bitsPerPixel, float refreshRate)
        {
            foreach (var resolution in AvailableResolutions)
            {
                if (
                    ((width != 0 && width == resolution.Width) || width == 0) &&
                    ((height != 0 && height == resolution.Height) || height == 0) &&
                    ((bitsPerPixel != 0 && bitsPerPixel == resolution.BitsPerPixel) || bitsPerPixel == 0) &&
                    ((refreshRate != 0 && System.Math.Abs(refreshRate - resolution.RefreshRate) < 1.0) || refreshRate == 0))
                {
                    return resolution;
                }
            }

            return null;
        }

        /// <summary>
        /// Returns a System.String representing this DisplayDevice.
        /// </summary>
        /// <returns>A System.String representing this DisplayDevice.</returns>
        public override string ToString()
        {
            return String.Format("{0}: {1} ({2} modes available)", IsPrimary ? "Primary" : "Secondary",
                CurrentResolution.Bounds.ToString(), AvailableResolutions.Count);
        }

        /// <summary>Determines whether the specified DisplayDevices are equal.</summary>
        /// <param name="obj">The System.Object to check against.</param>
        /// <returns>True if the System.Object is an equal DisplayDevice; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj is DisplayDevice)
            {
                return Equals((DisplayDevice)obj);
            }

            return false;
        }

        /// <summary>Determines whether the specified DisplayDevices are equal.</summary>
        /// <param name="other">The DisplayDevice to check against.</param>
        /// <returns>True if the other DisplayDevice is a equal; false otherwise.</returns>
        public bool Equals(DisplayDevice other)
        {
            return id == other.id;
        }

        /// <summary>Returns a unique hash representing this DisplayDevice.</summary>
        /// <returns>A System.Int32 that may serve as a hash code for this DisplayDevice.</returns>
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}
