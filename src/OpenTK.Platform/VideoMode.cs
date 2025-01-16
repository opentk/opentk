namespace OpenTK.Platform
{
    /// <summary>
    /// This structure represents a display video mode.
    /// </summary>
    public struct VideoMode
    {
        /// <summary>
        /// Width in pixels of the video mode.
        /// </summary>
        public int Width;

        /// <summary>
        /// Height in pixels of the video mode.
        /// </summary>
        public int Height;

        /// <summary>
        /// Refresh rate in Hz of the video mode.
        /// </summary>
        public float RefreshRate;

        /// <summary>
        /// Number of bits used to represent each color in the video mode.
        /// </summary>
        // FIXME: What practical usage does this have?
        // Is this something we can reliably use?
        // Maybe we'll want to change this in favor of a format enum like SDL has..?
        //
        // The current conceivable use would be to be able to select a VideoMode with a high bpp.
        // - Noggin_bops 2023-08-28
        public int BitsPerPixel;

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMode"/> struct.
        /// </summary>
        /// <param name="width">The width of the video mode.</param>
        /// <param name="height">The height of the video mode.</param>
        /// <param name="refreshRate">The refresh rate of the video mode.</param>
        /// <param name="bitsPerPixel">The color depth of the video mode.</param>
        public VideoMode(int width, int height, float refreshRate, int bitsPerPixel)
        {
            Width = width;
            Height = height;
            RefreshRate = refreshRate;
            BitsPerPixel = bitsPerPixel;
        }

        /// <summary>
        /// Returns the video mode as a string with the format "{Width}x{Height}@{RefreshRate} ({RedBits}:{GreenBits}:{BlueBits})".
        /// </summary>
        /// <returns>The string representation of the video mode.</returns>
        public override readonly string ToString()
        {
            return $"{Width}x{Height}@{RefreshRate} ({BitsPerPixel}bpp)";
        }
    }
}
