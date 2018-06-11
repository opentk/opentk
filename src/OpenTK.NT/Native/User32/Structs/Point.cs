using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        internal int X;
        internal int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public System.Drawing.Point ToPoint() => new System.Drawing.Point(X, Y);

        public override string ToString() => "Point {" + X + ", " + Y + ")";
    }
}
