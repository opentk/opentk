using System.Drawing;
using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        internal int X;
        internal int Y;

        public POINT(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point ToPoint() => new Point(X, Y);

        public override string ToString() => "Point {" + X + ", " + Y + ")";
    }
}
