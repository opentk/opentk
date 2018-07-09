namespace OpenTK.NT.Native
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
        /// Creates a point with the given X and Y coordinates.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <inheritdoc/>
        public static implicit operator System.Drawing.Point(Point point)
        {
            return new System.Drawing.Point(point.X, point.Y);
        }

        /// <inheritdoc/>
        public static implicit operator Point(System.Drawing.Point point) => new Point(point.X, point.Y);

        /// <inheritdoc/>
        public override string ToString() => $"Point ({X}, {Y})";
    }
}
