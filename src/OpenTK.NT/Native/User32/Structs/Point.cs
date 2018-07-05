namespace OpenTK.NT.Native
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static implicit operator System.Drawing.Point(Point point) => new System.Drawing.Point(point.X, point.Y);

        public static implicit operator Point(System.Drawing.Point point) => new Point(point.X, point.Y);

        public override string ToString() => "Point {" + X + ", " + Y + ")";
    }
}
