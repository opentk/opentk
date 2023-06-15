using System;

namespace OpenTK.Core.Platform
{
    // FIXME: Is there a reason for this struct to be immutable?

    /// <summary>
    /// This immutable structure represents display video modes.
    /// </summary>
    public struct VideoMode
    {
        /// <summary>
        /// Horizontal resolution of this display mode.
        /// </summary>
        public int HorizontalResolution { get; }

        /// <summary>
        /// Vertical resolution of this display mode.
        /// </summary>
        public int VerticalResolution { get; }

        /// <summary>
        /// Display refresh rate of this video mode.
        /// </summary>
        public float RefreshRate { get; }

        /// <summary>
        /// Display scale in this video mode.
        /// </summary>
        public float Scale { get; }

        /// <summary>
        /// Display pixel density in this video mode.
        /// </summary>
        public float Dpi { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMode"/> struct.
        /// </summary>
        /// <param name="horizontalResolution">Horizontal resolution in pixels.</param>
        /// <param name="verticalResolution">Vertical resolution pixels.</param>
        /// <param name="refreshRate">Refresh Rate in Hz.</param>
        /// <param name="scale">Display scale.</param>
        /// <param name="dpi">Display pixel density in DPI.</param>
        public VideoMode(
                int horizontalResolution,
                int verticalResolution,
                float refreshRate,
                float scale,
                float dpi)
        {
            /**/ if (horizontalResolution <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(horizontalResolution), "Must be greater than zero.");
            }
            else if (verticalResolution <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(verticalResolution), "Must be greater than zero.");
            }
            else if (refreshRate <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(refreshRate), "Must be greater than zero");
            }
            else if (scale <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(scale), "Must be greater than zero.");
            }
            else if (dpi <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(dpi), "Must be greater than zero.");
            }

            HorizontalResolution = horizontalResolution;
            VerticalResolution = verticalResolution;
            RefreshRate = refreshRate;
            Scale = scale;
            Dpi = dpi;
        }

        public override string ToString()
        {
            return $"{HorizontalResolution}x{VerticalResolution}@{RefreshRate} Scale: {Scale}, DPI: {Dpi}";
        }
    }
}
