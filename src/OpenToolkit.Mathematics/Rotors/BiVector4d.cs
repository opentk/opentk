using System;
using System.Collections.Generic;
using System.Text;

namespace OpenToolkit.Mathematics.Rotors
{
    /// <summary>
    /// A four dimentional bi-vector i.e. a line.
    /// </summary>
    public struct BiVector4d
    {
        public float XY;
        public float YZ;
        public float ZX;
        public float WX;
        public float WY;
        public float WZ;

        public BiVector4d()
        {
            XY = YZ = ZX = WX = WY = WZ = 0;
        }

        public BiVector4d(float xy, float yz, float zx, float wx, float wy, float wz)
        {
            XY = xy;
            YZ = yz;
            ZX = zx;
            WX = wx;
            WY = wy;
            WZ = wz;
        }

        /// <summary>
        /// 
        /// </summary>
        public Vector3 Tangent => new Vector3(WX, WY, WZ);

        /// <summary>
        /// 
        /// </summary>
        public Vector3 Moment => new Vector3(XY, YZ, ZX);

        /// <summary>
        /// 
        /// </summary>
        public float MagnitudeSqr => (XY * XY) + (YZ * YZ) + (ZX * ZX) + (WX * WX) + (WY * WY) + (WZ * WZ);

        /// <summary>
        /// 
        /// </summary>
        public float Magnitude => (float)Math.Sqrt(Magnitude);

        /// <summary>
        /// Creates a AntiVector4 (plane) from a BiVector4 (line) and a Vector4 (point).
        /// </summary>
        /// <param name="bv">The BiVector4 (line).</param>
        /// <param name="v">The Vector4 (point).</param>
        /// <param name="tv">The result AntiVector4 (plane).</param>
        public static void Wedge(in BiVector4d bv, in Vector4 v, out AntiVector4d tv)
        {
            tv.NotX = (bv.WY * v.Z) + (bv.YZ * v.W) - (bv.WZ * v.Y);
            tv.NotY = (bv.ZX * v.W) + (bv.WZ * v.X) - (bv.WX * v.Z);
            tv.NotZ = (bv.XY * v.W) + (bv.WX * v.Y) - (bv.WY * v.X);

            // Note the dubble minus
            tv.NotW = (bv.YZ * v.X) - (bv.XY * v.Z) - (bv.ZX * v.Y);
        }
    }
}
