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

        public System.Drawing.Point ToPoint() => new System.Drawing.Point(X, Y);

        public static Point FromPoint(System.Drawing.Point point) => new Point(point.X, point.Y);

        public override string ToString() => "Point {" + X + ", " + Y + ")";
    }
}
