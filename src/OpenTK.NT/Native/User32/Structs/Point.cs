namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Defines the X and Y coordinates of a point.
    /// </summary>
    public struct Point
    {
        /// <summary>
        /// The X coordinate of this point.
        /// </summary>
        public int X;

        /// <summary>
        /// The Y coordinate of this point.
        /// </summary>
        public int Y;

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> struct with the given X and Y coordinates.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Converts a <see cref="Point"/> structure used for interoperability with the Windows API to a
        /// <see cref="System.Drawing.Point"/>.
        /// </summary>
        /// <param name="point">The OpenTK.NT.Native.Point structure to convert.</param>
        public static implicit operator System.Drawing.Point(Point point)
        {
            return new System.Drawing.Point(point.X, point.Y);
        }

        /// <summary>
        /// Converts a <see cref="System.Drawing.Point"/> to a <see cref="Point"/>
        /// structure meant for interoperability with the Windows API.
        /// </summary>
        /// <param name="point">The System.Drawing.Point structure to convert.</param>
        public static implicit operator Point(System.Drawing.Point point) => new Point(point.X, point.Y);

        /// <inheritdoc/>
        public override string ToString() => $"{{X={X},Y={Y}}}";
    }
}
