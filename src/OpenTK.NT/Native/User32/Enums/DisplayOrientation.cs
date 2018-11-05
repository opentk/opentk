namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Defines possible display orientations.
    /// </summary>
    public enum DisplayOrientation : uint
    {
        /// <summary>
        /// The current mode's display device orientation is the natural orientation of the device,
        /// and should be used as the default.
        /// </summary>
        Default = 0,

        /// <summary>
        /// The display device orientation is 90 degrees (measured clockwise) from that of <see cref="Default"/>.
        /// </summary>
        Rotated90 = 1,

        /// <summary>
        /// The display device orientation is 180 degrees (measured clockwise) from that of <see cref="Default"/>.
        /// </summary>
        Rotated180 = 2,

        /// <summary>
        /// The display device orientation is 270 degrees (measured clockwise) from that of <see cref="Default"/>.
        /// </summary>
        Rotated270 = 3,
    }
}
