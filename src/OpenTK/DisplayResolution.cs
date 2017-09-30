/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK team.
 * This notice may not be removed.
 * See license.txt for licensing detailed licensing details.
 */

using System;
#if !MINIMAL
using System.Drawing;
#endif

namespace OpenTK
{
    /// <summary>Contains information regarding a monitor's display resolution.</summary>
    public class DisplayResolution
    {
        private Rectangle bounds;

        internal DisplayResolution() { }

        // Creates a new DisplayResolution object for the primary DisplayDevice.
        internal DisplayResolution(int x, int y, int width, int height, int bitsPerPixel, float refreshRate)
        {
            // Refresh rate may be zero, since this information may not be available on some platforms.
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException("width", "Must be greater than zero.");
            }
            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException("height", "Must be greater than zero.");
            }
            if (bitsPerPixel <= 0)
            {
                throw new ArgumentOutOfRangeException("bitsPerPixel", "Must be greater than zero.");
            }
            if (refreshRate < 0)
            {
                throw new ArgumentOutOfRangeException("refreshRate", "Must be greater than, or equal to zero.");
            }

            this.bounds = new Rectangle(x, y, width, height);
            this.BitsPerPixel = bitsPerPixel;
            this.RefreshRate = refreshRate;
        }

#if false

        /// <summary>
        /// Creates a new DisplayResolution object for the specified DisplayDevice.
        /// </summary>
        /// <param name="width">The requested width in pixels.</param>
        /// <param name="height">The requested height in pixels.</param>
        /// <param name="bitsPerPixel">The requested bits per pixel in bits.</param>
        /// <param name="refreshRate">The requested refresh rate in hertz.</param>
        /// <remarks>OpenTK will select the closest match between all available resolutions on the specified DisplayDevice.</remarks>
        ///
        public DisplayResolution(int width, int height, int bitsPerPixel, float refreshRate, DisplayDevice device)
        {
            // Refresh rate may be zero, since this information may not be available on some platforms.
            if (width <= 0) throw new ArgumentOutOfRangeException("width", "Must be greater than zero.");
            if (height <= 0) throw new ArgumentOutOfRangeException("height", "Must be greater than zero.");
            if (bitsPerPixel <= 0) throw new ArgumentOutOfRangeException("bitsPerPixel", "Must be greater than zero.");
            if (refreshRate < 0) throw new ArgumentOutOfRangeException("refreshRate", "Must be greater than, or equal to zero.");
            if (device == null) throw new ArgumentNullException("DisplayDevice", "Must be a valid DisplayDevice");

            DisplayResolution res = device.SelectResolution(width, height, bitsPerPixel, refreshRate);

            this.width = res.width;
            this.height = res.height;
            this.bits_per_pixel = res.bits_per_pixel;
            this.refresh_rate = res.refresh_rate;
        }
#endif

        /// <summary>
        /// Gets a System.Drawing.Rectangle that contains the bounds of this display device.
        /// </summary>
        [Obsolete("This property will return invalid results if a monitor changes resolution. Use DisplayDevice.Bounds instead.")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Rectangle Bounds
        {
            get { return bounds; }
        }

        /// <summary>Gets a System.Int32 that contains the width of this display in pixels.</summary>
        public int Width
        {
            get { return bounds.Width; }
            internal set { bounds.Width = value; }
        }

        /// <summary>Gets a System.Int32 that contains the height of this display in pixels.</summary>
        public int Height
        {
            get { return bounds.Height; }
            internal set { bounds.Height = value; }
        }

        /// <summary>Gets a System.Int32 that contains number of bits per pixel of this display. Typical values include 8, 16, 24 and 32.</summary>
        public int BitsPerPixel { get; internal set; }

        /// <summary>
        /// Gets a System.Single representing the vertical refresh rate of this display.
        /// </summary>
        public float RefreshRate { get; internal set; }

        /// <summary>
        /// Returns a System.String representing this DisplayResolution.
        /// </summary>
        /// <returns>A System.String representing this DisplayResolution.</returns>
        public override string ToString()
        {
            #pragma warning disable 612,618
            return String.Format("{0}x{1}@{2}Hz", Bounds, BitsPerPixel, RefreshRate);
            #pragma warning restore 612,618
        }

        /// <summary>Determines whether the specified resolutions are equal.</summary>
        /// <param name="obj">The System.Object to check against.</param>
        /// <returns>True if the System.Object is an equal DisplayResolution; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (this.GetType() == obj.GetType())
            {
                DisplayResolution res = (DisplayResolution)obj;
                return
                    Width == res.Width &&
                    Height == res.Height &&
                    BitsPerPixel == res.BitsPerPixel &&
                    RefreshRate == res.RefreshRate;
            }

            return false;
        }

        /// <summary>Returns a unique hash representing this resolution.</summary>
        /// <returns>A System.Int32 that may serve as a hash code for this resolution.</returns>
        public override int GetHashCode()
        {
            #pragma warning disable 612,618
            return Bounds.GetHashCode() ^ BitsPerPixel ^ RefreshRate.GetHashCode();
            #pragma warning restore 612,618
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator== (DisplayResolution left, DisplayResolution right)
        {
            if (((object)left) == null && ((object)right) == null)
            {
                return true;
            }
            else if ((((object)left) == null && ((object)right) != null) ||
                     (((object)left) != null && ((object)right) == null))
            {
                return false;
            }
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equal right; false otherwise.</returns>
        public static bool operator !=(DisplayResolution left, DisplayResolution right)
        {
            return !(left == right);
        }
    }
}
